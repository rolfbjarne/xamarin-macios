using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Utils;

namespace Xamarin.MacDev {
	public static class BundleResource {
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

		public static bool IsIllegalName (string name, [NotNullWhen (true)] out string? illegal)
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
			return GetVirtualProjectPath (null, projectDir, item, isVSBuild);
		}

		public static string GetVirtualProjectPath (Task? task, string projectDir, ITaskItem item, bool isVSBuild)
		{
			var link = item.GetMetadata ("Link");

			// Note: if the Link metadata exists, then it will be the equivalent of the ProjectVirtualPath
			if (!string.IsNullOrEmpty (link)) {
				if (Path.DirectorySeparatorChar != '\\') {
					task?.Log.LogWarning ($"GetVirtualProjectPath ({projectDir}, {item.ItemSpec}, {isVSBuild}) => Link={link.Replace ('\\', '/')} (original {link})");
					return link.Replace ('\\', '/');
				}

				task?.Log.LogWarning ($"GetVirtualProjectPath ({projectDir}, {item.ItemSpec}, {isVSBuild}) => Link={link.Replace ('\\', '/')}");
				return link;
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

			task?.Log.LogWarning ($"GetVirtualProjectPath ({projectDir}, {item.ItemSpec}, {isVSBuild}) => isDefaultItem={isDefaultItem} definingProjectFullPath={definingProjectFullPath} FullPath={path} baseDir={baseDir}");

			baseDir = PathUtils.ResolveSymbolicLinks (baseDir);
			path = PathUtils.ResolveSymbolicLinks (path);

			var rv2 = PathUtils.AbsoluteToRelative (baseDir, path);
			task?.Log.LogWarning ($"GetVirtualProjectPath ({projectDir}, {item.ItemSpec}, {isVSBuild}) => isDefaultItem={isDefaultItem} definingProjectFullPath={definingProjectFullPath} FullPath={path} baseDir={baseDir} ==> {rv2}");
			return rv2;
		}

		public static string GetLogicalName (string projectDir, IList<string> prefixes, ITaskItem item, bool isVSBuild)
		{
			return GetLogicalName (null, projectDir, prefixes, item, isVSBuild);
		}

		public static string GetLogicalName (Task? task, string projectDir, IList<string> prefixes, ITaskItem item, bool isVSBuild)
		{
			var logicalName = item.GetMetadata ("LogicalName");

			if (!string.IsNullOrEmpty (logicalName)) {
				if (Path.DirectorySeparatorChar != '\\') {
					task?.Log.LogWarning ($"GetLogicalName ({projectDir}, {string.Join (";", prefixes)}, {item.ItemSpec}, {isVSBuild}) => has LogicalName={logicalName.Replace ('\\', '/')} (original {logicalName})");
					return logicalName.Replace ('\\', '/');
				}
				task?.Log.LogWarning ($"GetLogicalName ({projectDir}, {string.Join (";", prefixes)}, {item.ItemSpec}, {isVSBuild}) => has LogicalName={logicalName}");
				return logicalName;
			}

			var vpath = GetVirtualProjectPath (task, projectDir, item, isVSBuild);
			int matchlen = 0;

			foreach (var prefix in prefixes) {
				if (vpath.StartsWith (prefix, StringComparison.OrdinalIgnoreCase) && prefix.Length > matchlen)
					matchlen = prefix.Length;
			}

			if (matchlen > 0) {
				task?.Log.LogWarning ($"GetLogicalName ({projectDir}, {string.Join (";", prefixes)}, {item.ItemSpec}, {isVSBuild}) => has LogicalName={vpath.Substring (matchlen)} with vpath {vpath} substring {matchlen}");
				return vpath.Substring (matchlen);
			}

			task?.Log.LogWarning ($"GetLogicalName ({projectDir}, {string.Join (";", prefixes)}, {item.ItemSpec}, {isVSBuild}) => has LogicalName={vpath.Substring (matchlen)} with vpath {vpath}");
			return vpath;
		}
	}
}
