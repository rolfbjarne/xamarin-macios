using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Localization.MSBuild;
using Xamarin.Utils;

#nullable enable

namespace Xamarin.MacDev.Tasks {
	public abstract class ComputeCodesignItemsTaskBase : XamarinTask {
		[Required]
		public string AppBundleDir { get; set; } = string.Empty;
		[Required]
		public ITaskItem [] CodesignItems { get; set; } = Array.Empty<ITaskItem> ();
		public ITaskItem [] CodesignBundle { get; set; } = Array.Empty<ITaskItem> ();
		public ITaskItem [] GenerateDSymItem { get; set; } = Array.Empty<ITaskItem> ();
		public ITaskItem [] NativeStripItem { get; set; } = Array.Empty<ITaskItem> ();

		[Output]
		public ITaskItem[] OutputCodesignItems { get; set; } = Array.Empty<ITaskItem> ();

		public override bool Execute ()
		{
			var output = new List<ITaskItem> ();

			// Make sure AppBundleDir has a trailing slash
			var appBundlePath = EnsureTrailingSlash (Path.GetFullPath (AppBundleDir));

			// Find all *.dylib files
			foreach (var bundle in CodesignBundle) {
				var bundlePath = Path.Combine (appBundlePath, bundle.ItemSpec);
				Console.WriteLine ($"    Looking in {bundlePath} for native libraries");
				var nativeLibraries = FindNativeLibraries (bundlePath);
				Console.WriteLine ($"    Found {nativeLibraries.Count ()} native libraries in {bundlePath}");
				foreach (var lib in nativeLibraries) {
					var relativeLib = lib.Substring (appBundlePath.Length);
					var item = new TaskItem (relativeLib);
					bundle.CopyMetadataTo (item);
					output.Add (item);
				}
			}

			foreach (var item in CodesignItems) {
				output.Add (item);
			}

			OutputCodesignItems = output.ToArray ();

			return !Log.HasLoggedErrors;
		}

		string EnsureTrailingSlash (string path)
		{
			if (path [path.Length - 1] != Path.DirectorySeparatorChar)
				path += Path.DirectorySeparatorChar;
			return path;
		}

		IEnumerable<string> FindNativeLibraries (string appPath)
		{
			var rv = new List<string> ();

			// Make sure path ends with trailing slash to ease logic
			appPath = EnsureTrailingSlash (appPath);

			string dylibDirectory;
			string metallibDirectory;
			switch (Platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
			case ApplePlatform.WatchOS:
				dylibDirectory = appPath;
				metallibDirectory = appPath;
				break;
			case ApplePlatform.MacOSX:
			case ApplePlatform.MacCatalyst:
				dylibDirectory = Path.Combine (appPath, "Contents");
				metallibDirectory = Path.Combine (appPath, "Contents", "Resources");
				break;
			default:
				throw new InvalidOperationException (string.Format (MSBStrings.InvalidPlatform, Platform));
			}

			dylibDirectory = EnsureTrailingSlash (dylibDirectory);
			metallibDirectory = EnsureTrailingSlash (metallibDirectory);

			foreach (var file in Directory.EnumerateFileSystemEntries (appPath)) {
				var relativePath = file.Substring (appPath.Length);
				if (relativePath.StartsWith ("PlugIns" + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase))
					continue;
				if (relativePath.StartsWith ("Watch" + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase))
					continue;

				if (file.EndsWith (".dylib", StringComparison.OrdinalIgnoreCase) && file.StartsWith (dylibDirectory)) {
					rv.Add (file);
				} else if (file.EndsWith (".metallib", StringComparison.OrdinalIgnoreCase) && file.StartsWith (metallibDirectory)) {
					rv.Add (file);
				}
			}

			return rv;
		}

		void ResolveMetadata (ITaskItem metadata)
		{

		}
	}
}
