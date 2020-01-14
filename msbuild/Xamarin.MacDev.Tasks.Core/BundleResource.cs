using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using Microsoft.Build.Framework;

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

		public static string GetVirtualProjectPath (string projectDir, ITaskItem item, bool isVSBuild)
		{
			Console.WriteLine ($"GetVirtualProjectPath ({projectDir}, {item})");
			var link = item.GetMetadata ("Link");

			// Note: if the Link metadata exists, then it will be the equivalent of the ProjectVirtualPath
			if (!string.IsNullOrEmpty (link)) {
				Console.WriteLine ($"GetVirtualProjectPath ({projectDir}, {item}) => link => {link} (definingProjectFullPath: {item.GetMetadata ("DefiningProjectFullPath")})");
				if (Path.DirectorySeparatorChar != '\\')
					return link.Replace ('\\', '/');

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
			Console.WriteLine ($"GetVirtualProjectPath ({projectDir}, {item}) => isDefaultItem: {isDefaultItem} DefiningProjectFullPath: {definingProjectFullPath} => {rv}");
			return rv;
		}

		public static string GetLogicalName (string projectDir, IList<string> prefixes, ITaskItem item, bool isVSBuild)
		{
			var logicalName = item.GetMetadata ("LogicalName");

			if (!string.IsNullOrEmpty (logicalName)) {
				Console.WriteLine ($"GetLogicalName ({projectDir}, {string.Join (";", prefixes)}, {item}, {isVSBuild}) => LogicalName => {logicalName}");
				if (Path.DirectorySeparatorChar != '\\')
					return logicalName.Replace ('\\', '/');

				return logicalName;
			}

			var vpath = GetVirtualProjectPath (projectDir, item, isVSBuild);
			int matchlen = 0;

			foreach (var prefix in prefixes) {
				if (vpath.StartsWith (prefix, StringComparison.OrdinalIgnoreCase) && prefix.Length > matchlen)
					matchlen = prefix.Length;
			}

			if (matchlen > 0) {
				var rv = vpath.Substring (matchlen);
				Console.WriteLine ($"GetLogicalName ({projectDir}, {string.Join (";", prefixes)}, {item}, {isVSBuild}) => vpath match => {rv}");
				return rv;
			}

			Console.WriteLine ($"GetLogicalName ({projectDir}, {string.Join (";", prefixes)}, {item}, {isVSBuild}) => vpath => {vpath}");
			return vpath;
		}
	}
}
