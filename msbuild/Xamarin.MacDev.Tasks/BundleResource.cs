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

		[Obsolete ("DO NOT USE")]
		public static string GetVirtualProjectPath (string projectDir, ITaskItem item, bool isVSBuild)
		{
			return GetVirtualProjectPath (null, projectDir, item, "");
		}

		public static string GetVirtualProjectPath (string projectDir, ITaskItem item, string macProjectDir)
		{
			return GetVirtualProjectPath (null, projectDir, item, macProjectDir);
		}

		public static string GetVirtualProjectPath (Task? task, string projectDir, ITaskItem item, string macProjectDir)
		{
			var link = item.GetMetadata ("Link");
			var isVSBuild = !string.IsNullOrEmpty (macProjectDir);

			// Note: if the Link metadata exists, then it will be the equivalent of the ProjectVirtualPath
			if (!string.IsNullOrEmpty (link)) {
				if (Path.DirectorySeparatorChar != '\\') {
					task?.Log.LogWarning ($"GetVirtualProjectPath ({projectDir}, {item.ItemSpec}, {macProjectDir}) => Link={link.Replace ('\\', '/')} (original {link})");
					return link.Replace ('\\', '/');
				}

				task?.Log.LogWarning ($"GetVirtualProjectPath ({projectDir}, {item.ItemSpec}, {macProjectDir}) => Link={link.Replace ('\\', '/')}");
				return link;
			}

			// Evaluate ~
#if NET
			if (macProjectDir.StartsWith ('~'))
#else
			if (macProjectDir.StartsWith ("~"))
#endif
				macProjectDir = Environment.GetEnvironmentVariable ("HOME") + projectDir.Substring (1);

			var isDefaultItem = item.GetMetadata ("IsDefaultItem") == "true";
			var msbuildProjectFullPath = item.GetMetadata ("MSBuildProjectFullPath");
			var localMSBuildProjectFullPath = item.GetMetadata ("LocalMSBuildProjectFullPath");
			var definingProjectFullPath = item.GetMetadata ("DefiningProjectFullPath");
			var localDefiningProjectFullPath = item.GetMetadata ("LocalDefiningProjectFullPath").Replace ('\\', '/');
			var fullPath = item.GetMetadata ("FullPath");
			string path;
			string baseDir;

			string rv;

			if (isVSBuild) {
				// 'path' is full path on Windows
				path = PathUtils.PathCombineWindows (projectDir, item.ItemSpec);

				// 'baseDir' is the base directory in Windows
				if (isDefaultItem) {
					baseDir = Path.GetDirectoryName (localMSBuildProjectFullPath);
				} else {
					baseDir = Path.GetDirectoryName (localDefiningProjectFullPath);
				}

				rv = PathUtils.AbsoluteToRelativeWindows (baseDir, path);
				// Make it a mac-style path
				rv = rv.Replace ('\\', '/');

				task?.Log.LogWarning ($"GetVirtualProjectPath" +
						$"\t\t\t{projectDir}\n" +
						$"\t\t\t{item.ItemSpec}\n" +
						$"\t\t\t{macProjectDir}\n" +
						$"\t\t\t\tisDefaultItem={isDefaultItem}\n" +
						$"\t\t\t\tMSBuildProjectFullPath={msbuildProjectFullPath}\n" +
						$"\t\t\t\tLocalMSBuildProjectFullPath={localMSBuildProjectFullPath}\n" +
						$"\t\t\t\tDefiningProjectFullPath={definingProjectFullPath}\n" +
						$"\t\t\t\tLocalDefiningProjectFullPath={localDefiningProjectFullPath}\n" +
						$"\t\t\t\tFullPath={path}\n" +
						$"\t\t\t\tbaseDir={baseDir}\n" +
						$"\t\t\t\t ==> {rv}");
			} else {
				path = fullPath;

				if (isDefaultItem) {
					baseDir = Path.GetDirectoryName (msbuildProjectFullPath);
				// } else if (!string.IsNullOrEmpty (localDefiningProjectFullPath)) {
				// 	baseDir = Path.GetDirectoryName (localDefiningProjectFullPath);
				} else if (!string.IsNullOrEmpty (definingProjectFullPath)) {
					baseDir = Path.GetDirectoryName (definingProjectFullPath);
				} else {
					baseDir = projectDir;
				}

				var originalBaseDir = baseDir;
				var originalPath = path;

				baseDir = PathUtils.ResolveSymbolicLinks (baseDir);
				path = PathUtils.ResolveSymbolicLinks (path);

				rv = PathUtils.AbsoluteToRelative (baseDir, path);
				task?.Log.LogWarning ($"GetVirtualProjectPath" +
						$"\t\t\t{projectDir}\n" +
						$"\t\t\t{item.ItemSpec}\n" +
						$"\t\t\t{macProjectDir}\n" +
						$"\t\t\t\tisDefaultItem={isDefaultItem}\n" +
						$"\t\t\t\tMSBuildProjectFullPath={msbuildProjectFullPath}\n" +
						$"\t\t\t\tDefiningProjectFullPath={definingProjectFullPath}\n" +
						$"\t\t\t\tLocalDefiningProjectFullPath={localDefiningProjectFullPath}\n" +
						$"\t\t\t\tFullPath={path} ({originalPath})\n" +
						$"\t\t\t\tbaseDir={baseDir} ({originalBaseDir})\n" +
						$"\t\t\t\t ==> {rv}");
			}

			return rv;
		}

		[Obsolete ("DO NOT USE")]
		public static string GetLogicalName (string projectDir, IList<string> prefixes, ITaskItem item, bool isVSBuild)
		{
			return GetLogicalName (null, projectDir, prefixes, item, "");
		}

		public static string GetLogicalName (string projectDir, IList<string> prefixes, ITaskItem item, string macProjectDir)
		{
			return GetLogicalName (null, projectDir, prefixes, item, macProjectDir);
		}

		public static string GetLogicalName (Task? task, string projectDir, IList<string> prefixes, ITaskItem item, string macProjectDir)
		{
			var logicalName = item.GetMetadata ("LogicalName");

			if (!string.IsNullOrEmpty (logicalName)) {
				if (Path.DirectorySeparatorChar != '\\') {
					task?.Log.LogWarning ($"GetLogicalName ({projectDir}, {string.Join (";", prefixes)}, {item.ItemSpec}, {macProjectDir}) => has LogicalName={logicalName.Replace ('\\', '/')} (original {logicalName})");
					return logicalName.Replace ('\\', '/');
				}
				task?.Log.LogWarning ($"GetLogicalName ({projectDir}, {string.Join (";", prefixes)}, {item.ItemSpec}, {macProjectDir}) => has LogicalName={logicalName}");
				return logicalName;
			}

			var vpath = GetVirtualProjectPath (task, projectDir, item, macProjectDir);
			int matchlen = 0;

			foreach (var prefix in prefixes) {
				if (vpath.StartsWith (prefix, StringComparison.OrdinalIgnoreCase) && prefix.Length > matchlen)
					matchlen = prefix.Length;
			}

			if (matchlen > 0) {
				task?.Log.LogWarning ($"GetLogicalName ({projectDir}, {string.Join (";", prefixes)}, {item.ItemSpec}, {macProjectDir}) => has LogicalName={vpath.Substring (matchlen)} with vpath {vpath} substring {matchlen}");
				return vpath.Substring (matchlen);
			}

			task?.Log.LogWarning ($"GetLogicalName ({projectDir}, {string.Join (";", prefixes)}, {item.ItemSpec}, {macProjectDir}) => has LogicalName={vpath.Substring (matchlen)} with vpath {vpath}");
			return vpath;
		}
	}
}
