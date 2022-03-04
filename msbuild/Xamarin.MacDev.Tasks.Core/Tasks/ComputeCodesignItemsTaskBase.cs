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
		public ITaskItem [] CodesignBundle { get; set; } = Array.Empty<ITaskItem> ();

		[Required]
		public ITaskItem [] CodesignItems { get; set; } = Array.Empty<ITaskItem> ();

		[Required]
		public string CodesignStampPath { get; set; } = string.Empty;

		public ITaskItem [] GenerateDSymItems { get; set; } = Array.Empty<ITaskItem> ();

		public ITaskItem [] NativeStripItems { get; set; } = Array.Empty<ITaskItem> ();

		[Output]
		public ITaskItem[] OutputCodesignItems { get; set; } = Array.Empty<ITaskItem> ();

		public override bool Execute ()
		{
			var output = new List<ITaskItem> ();

			// Make sure AppBundleDir has a trailing slash
			var appBundlePath = EnsureTrailingSlash (Path.GetFullPath (AppBundleDir));

			// Add the app bundles themselves
			foreach (var bundle in CodesignBundle) {
				var codesignExecutable = bundle.GetMetadata ("CodesignExecutable");
				if (!string.Equals (codesignExecutable, "true"))
					continue;

				var bundlePath = Path.Combine (Path.GetDirectoryName (AppBundleDir), bundle.ItemSpec);
				var item = new TaskItem (bundlePath);
				bundle.CopyMetadataTo (item);

				// Compute the stamp file to use
				item.SetMetadataIfNotSet ("CodesignStampFile", Path.Combine (CodeSignatureRelativePath, "_CodeSignature", "CodeResources"));

				output.Add (item);
			}

			// Find all:
			//	- *.dylib and *.metallib files
			//	- *.framework directories
			Log.LogWarning ($"    Looking in {CodesignBundle.Length} bundles for files to sign");
			foreach (var bundle in CodesignBundle) {
				var bundlePath = Path.Combine (Path.GetDirectoryName (Path.GetDirectoryName (appBundlePath)), bundle.ItemSpec);
				Log.LogWarning ($"    Looking in {bundlePath} for files to sign");
				var filesToSign = FindFilesToSign (bundlePath);
				Log.LogWarning ($"    Found {filesToSign.Count ()} native libraries in {bundlePath}");
				foreach (var lib in filesToSign) {
					var relativeLib = Path.Combine (AppBundleDir, lib.Substring (appBundlePath.Length));
					var item = new TaskItem (relativeLib);
					bundle.CopyMetadataTo (item);

					// Native libraries are a bit special, because they're always signed. This is done
					// by setting the signing key to '-' if it's not set.
					item.SetMetadataIfNotSet ("CodesignSigningKey", "-");

					// Set the stamp file even if already set (because any existing values would be copied from the bundle, which would be the wrong stamp file, so it must be overridden)
					if (Directory.Exists (relativeLib)) {
						item.SetMetadata ("CodesignStampFile", Path.Combine (CodesignStampPath, relativeLib, ".stampfile"));
					} else {
						item.SetMetadata ("CodesignStampFile", Path.Combine (CodesignStampPath, relativeLib));
					}

					output.Add (item);
				}
			}

			// Add all additional items
			foreach (var item in CodesignItems) {
				// Set the stamp file if not already set.
				item.SetMetadataIfNotSet ("CodesignStampFile", Path.Combine (CodesignStampPath, item.ItemSpec));

				output.Add (item);
			}

			foreach (var item in output) {
				// Get any additional stamp files we must touch when the item is signed.
				var additionalStampFiles = new List<string> ();
				// We must touch the dSYM directory's Info.plist, to ensure that we don't want to run dsymutil again after codesigning in the next build
				var generateDSymItem = GenerateDSymItems.FirstOrDefault (v => {
					return string.Equals (Path.Combine (Path.GetDirectoryName (AppBundleDir), Path.GetDirectoryName (v.ItemSpec)), item.ItemSpec, StringComparison.OrdinalIgnoreCase);
				});
				if (generateDSymItem is not null)
					additionalStampFiles.Add (generateDSymItem.GetMetadata ("dSYMUtilStampFile"));
				// We must touch the stamp file for native stripping, to ensure that we don't want to run strip again after codesigning in the next build
				var nativeStripItem = NativeStripItems.FirstOrDefault (v => string.Equals (Path.Combine (Path.GetDirectoryName (AppBundleDir), Path.GetDirectoryName (v.ItemSpec)), item.ItemSpec, StringComparison.OrdinalIgnoreCase));
				if (nativeStripItem is not null)
					additionalStampFiles.Add (nativeStripItem.GetMetadata ("StripStampFile"));
				// Set the CodesignAdditionalFilesToTouch metadata
				if (additionalStampFiles.Count > 0) {
					additionalStampFiles.AddRange (item.GetMetadata ("CodesignAdditionalFilesToTouch").Split (','));
					additionalStampFiles.RemoveAll (v => string.IsNullOrEmpty (v));
					item.SetMetadata ("CodesignAdditionalFilesToTouch", string.Join (";", additionalStampFiles));
				}
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

		string CodeSignatureRelativePath {
			get {

				switch (Platform) {
				case ApplePlatform.iOS:
				case ApplePlatform.TVOS:
				case ApplePlatform.WatchOS:
					return string.Empty;
				case ApplePlatform.MacOSX:
				case ApplePlatform.MacCatalyst:
					return "Contents";
				default:
					throw new InvalidOperationException (string.Format (MSBStrings.InvalidPlatform, Platform));
				}
			}
		}

		IEnumerable<string> FindFilesToSign (string appPath)
		{
			var rv = new List<string> ();

			// Make sure path ends with trailing slash to ease logic
			appPath = EnsureTrailingSlash (appPath);

			string dylibDirectory;
			string metallibDirectory;
			string frameworksDirectory;
			switch (Platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
			case ApplePlatform.WatchOS:
				dylibDirectory = appPath;
				metallibDirectory = appPath;
				frameworksDirectory = Path.Combine (appPath, "Frameworks");
				break;
			case ApplePlatform.MacOSX:
			case ApplePlatform.MacCatalyst:
				dylibDirectory = Path.Combine (appPath, "Contents");
				metallibDirectory = Path.Combine (appPath, "Contents", "Resources");
				frameworksDirectory = Path.Combine (appPath, "Content", "Frameworks");
				break;
			default:
				throw new InvalidOperationException (string.Format (MSBStrings.InvalidPlatform, Platform));
			}

			dylibDirectory = EnsureTrailingSlash (dylibDirectory);
			metallibDirectory = EnsureTrailingSlash (metallibDirectory);

			foreach (var entry in Directory.EnumerateFileSystemEntries (appPath, "*", SearchOption.AllDirectories)) {
				var relativePath = entry.Substring (appPath.Length);
				if (relativePath.StartsWith ("PlugIns" + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase))
					continue;
				if (relativePath.StartsWith ("Watch" + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase))
					continue;

				if (entry.EndsWith (".dylib", StringComparison.OrdinalIgnoreCase) && entry.StartsWith (dylibDirectory)) {
					rv.Add (entry);
				} else if (entry.EndsWith (".metallib", StringComparison.OrdinalIgnoreCase) && entry.StartsWith (metallibDirectory)) {
					rv.Add (entry);
				} else if (entry.EndsWith (".framework", StringComparison.OrdinalIgnoreCase) && string.Equals (Path.GetDirectoryName (entry), frameworksDirectory, StringComparison.OrdinalIgnoreCase)) {
					rv.Add (entry);
				}
			}

			return rv;
		}
	}

	public static class ITaskItem_Extensions {
		public static void SetMetadataIfNotSet (this ITaskItem self, string metadata, string value)
		{
			if (!string.IsNullOrEmpty (self.GetMetadata (metadata)))
				return;
			self.SetMetadata (metadata, value);
		}
	}
}
