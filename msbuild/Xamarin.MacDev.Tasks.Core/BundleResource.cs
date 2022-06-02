using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Utils;

namespace Xamarin.MacDev
{
	public static class BundleResource
	{
		static readonly HashSet<string> illegalDirectoryNames = new HashSet<string> (new [] {
			"Resources",
			"_CodeSignature",
		}, StringComparer.OrdinalIgnoreCase);

		static readonly HashSet<string> illegalFileNames = new HashSet<string> (new [] {
			"Info.plist",
			"embedded.mobileprovision",
			"ResourceRules.plist",
			"PkgInfo",
			"CodeResources",
			"_CodeSignature",
		}, StringComparer.OrdinalIgnoreCase);

		public static bool IsIllegalName (string name, out string illegal)
		{
			if (illegalFileNames.Contains (name)) {
				illegal = name;
				return true;
			}

			int delim = name.IndexOf (Path.DirectorySeparatorChar);

			if (delim == -1 && illegalDirectoryNames.Contains (name)) {
				illegal = name;
				return true;
			}

			if (delim != -1 && illegalDirectoryNames.Contains (name.Substring (0, delim))) {
				illegal = name.Substring (0, delim);
				return true;
			}

			illegal = null;

			return false;
		}

		public static IList<string> SplitResourcePrefixes (string prefix)
		{
			return prefix.Split (new [] { ';' }, StringSplitOptions.RemoveEmptyEntries)
				.Select (s => s.Replace ('\\', Path.DirectorySeparatorChar).Trim () + Path.DirectorySeparatorChar)
				.Where (s => s.Length > 1)
				.ToList ();
		}

		public static string GetVirtualProjectPath (string projectDir, ITaskItem item, bool isVSBuild, Task task = null)
		{
			var link = item.GetMetadata ("Link");

			// Note: if the Link metadata exists, then it will be the equivalent of the ProjectVirtualPath
			if (!string.IsNullOrEmpty (link)) {
				if (Path.DirectorySeparatorChar != '\\')
					return link.Replace ('\\', '/');

				task?.Log?.LogWarning ($"GetVirtuaProjectPath ({projectDir}, {item.ItemSpec}, {isVSBuild}) => link: {link}");
				return link;
			}

			// HACK: This is for Visual Studio iOS projects
			if (isVSBuild) {
				if (item.GetMetadata("DefiningProjectFullPath") != item.GetMetadata("MSBuildProjectFullPath")) {
					return item.GetMetadata("FullPath").Replace(item.GetMetadata ("DefiningProjectDirectory"), string.Empty);
				}
				else {
					return item.ItemSpec;
				}
			}

			var isDefaultItem = item.GetMetadata ("IsDefaultItem") == "true";
			var definingProjectFullPath = item.GetMetadata (isDefaultItem ? "MSBuildProjectFullPath" : "DefiningProjectFullPath");
			var path = item.GetMetadata ("FullPath");
			string baseDir;

			if (!string.IsNullOrEmpty (definingProjectFullPath)) {
				baseDir = Path.GetDirectoryName (definingProjectFullPath);
			} else {
				baseDir = projectDir;
			}

			baseDir = PathUtils.ResolveSymbolicLinks (baseDir);
			path = PathUtils.ResolveSymbolicLinks (path);

			var rv = PathUtils.AbsoluteToRelative (baseDir, path);
			task?.Log?.LogWarning ($"GetVirtuaProjectPath ({projectDir}, {item.ItemSpec}, {isVSBuild}) => AbsoluteToRelative ({baseDir}, {path}) => {rv}");
			return rv;
		}

		public static string GetLogicalName (string projectDir, IList<string> prefixes, ITaskItem item, bool isVSBuild, Task task = null)
		{
			var logicalName = item.GetMetadata ("LogicalName");

			if (!string.IsNullOrEmpty (logicalName)) {
				if (Path.DirectorySeparatorChar != '\\')
					return logicalName.Replace ('\\', '/');
				task?.Log?.LogWarning ($"GetLogicalName ({projectDir}, {string.Join (", ", prefixes)}, {item.ItemSpec}, {isVSBuild}) => logicalName: {logicalName}");
				return logicalName;
			}

			var vpath = GetVirtualProjectPath (projectDir, item, isVSBuild, task);
			task?.Log?.LogWarning ($"GetLogicalName ({projectDir}, {string.Join (", ", prefixes)}, {item.ItemSpec}, {isVSBuild}) => vpath: {vpath}");
			int matchlen = 0;

			foreach (var prefix in prefixes) {
				var starts = vpath.StartsWith (prefix, StringComparison.OrdinalIgnoreCase);
				task?.Log?.LogWarning ($"GetLogicalName ({projectDir}, {string.Join (", ", prefixes)}, {item.ItemSpec}, {isVSBuild}) => checking prefix {prefix}: {starts} prefix length: {prefix.Length} matchlen: {matchlen}");
				if (starts && prefix.Length > matchlen) {
					matchlen = prefix.Length;
					task?.Log?.LogWarning ($"GetLogicalName ({projectDir}, {string.Join (", ", prefixes)}, {item.ItemSpec}, {isVSBuild}) => checking prefix {prefix}: {starts} prefix length: {prefix.Length} matchlen: {matchlen} yeah");
				} else {
					task?.Log?.LogWarning ($"GetLogicalName ({projectDir}, {string.Join (", ", prefixes)}, {item.ItemSpec}, {isVSBuild}) => checking prefix {prefix}: {starts} prefix length: {prefix.Length} matchlen: {matchlen} nope");
				}
			}

			if (matchlen > 0) {
				var rv = vpath.Substring (matchlen);
				task?.Log?.LogWarning ($"GetLogicalName ({projectDir}, {string.Join (", ", prefixes)}, {item.ItemSpec}, {isVSBuild}) => vpath substring: {rv} matchlen: {matchlen}");
				return rv;
			}

			task?.Log?.LogWarning ($"GetLogicalName ({projectDir}, {string.Join (", ", prefixes)}, {item.ItemSpec}, {isVSBuild}) => vpath: {vpath} yeah");

			return vpath;
		}
	}
}
