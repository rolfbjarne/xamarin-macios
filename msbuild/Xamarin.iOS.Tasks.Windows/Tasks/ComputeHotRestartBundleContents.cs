using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.MacDev.Tasks;

#nullable enable

namespace Xamarin.iOS.HotRestart.Tasks {
	public class ComputeHotRestartBundleContents : Task {
		#region Inputs

		[Required]
		public string HotRestartAppContentDir { get; set; } = string.Empty;

		[Required]
		public string HotRestartContentDir { get; set; } = string.Empty;

		[Required]
		public string HotRestartContentStampDir { get; set; } = string.Empty;

		[Required]
		public string HotRestartSignedAppDir { get; set; } = string.Empty;

		[Required]
		public string RelativeAppBundlePath { get; set; } = string.Empty;

		[Required]
		public string TargetFrameworkMoniker { get; set; } = string.Empty;

		[Required]
		public ITaskItem [] ResolvedFileToPublish { get; set; } = Array.Empty<ITaskItem> ();

		#endregion

		#region Outputs

		[Output]
		public ITaskItem [] HotRestartAppContentDirContents { get; set; } = Array.Empty<ITaskItem> ();

		[Output]
		public ITaskItem [] HotRestartContentDirContents { get; set; } = Array.Empty<ITaskItem> ();

		[Output]
		public ITaskItem [] HotRestartSignedAppDirContents { get; set; } = Array.Empty<ITaskItem> ();

		#endregion

		ITaskItem CopyWithDestinationAndStamp (ITaskItem item, string destinationDirectory, string? stampDirectory = null)
		{
			var rv = new TaskItem (item);
			var relativePath = item.GetMetadata ("RelativePath");
			if (relativePath.StartsWith (RelativeAppBundlePath, StringComparison.OrdinalIgnoreCase))
				relativePath = relativePath.Substring (RelativeAppBundlePath.Length).TrimStart ('\\', '/');
			relativePath = relativePath.Replace ('/', Path.DirectorySeparatorChar);
			rv.SetMetadata ("DestinationFile", Path.Combine (destinationDirectory, relativePath));
			if (!string.IsNullOrEmpty (stampDirectory))
				rv.SetMetadata ("StampFile", Path.Combine (stampDirectory, relativePath));
			return rv;
		}

		// The Copy task can't copy directories, so expand directories to their individual files
		List<ITaskItem> ExpandDirectories (List<ITaskItem> items)
		{
			var rv = new List<ITaskItem> ();

			foreach (var item in items) {
				if (File.Exists (item.ItemSpec)) {
					rv.Add (item);
				} else if (Directory.Exists (item.ItemSpec)) {
					var entries = Directory.GetFileSystemEntries (item.ItemSpec).ToArray ();
					Log.LogMessage (MessageImportance.Low, $"Expanding {item.ItemSpec} with {entries.Length} items:");
					foreach (var entry in entries) {
						if (Directory.Exists (entry)) {
							Log.LogMessage (MessageImportance.Low, $"    Skipped directory: {entry}");
							continue;
						}
						var relativePathSuffix = entry.Substring (item.ItemSpec.Length).TrimStart ('\\', '/');
						var relativePath = Path.Combine (item.GetMetadata ("RelativePath"), relativePathSuffix);
						var destinationFile = Path.Combine (item.GetMetadata ("DestinationFile"), relativePathSuffix);
						var file = new TaskItem (item);
						file.ItemSpec = entry;
						file.SetMetadata ("RelativePath", relativePath);
						file.SetMetadata ("DestinationFile", destinationFile);
						rv.Add (file);
						Log.LogMessage (MessageImportance.Low, $"    Added {file.ItemSpec} with relative path: {relativePath} and destination file: {destinationFile}");
					}
				} else {
					// Trust that this will just somehow work.
					rv.Add (item);
				}
			}

			return rv;
		}

		public override bool Execute ()
		{
			var appContentDirContents = new List<ITaskItem> ();
			var contentDirContents = new List<ITaskItem> ();
			var signedAppDirContents = new List<ITaskItem> ();

			foreach (var item in ResolvedFileToPublish) {
				var publishFolderType = item.GetPublishFolderType ();
				switch (publishFolderType) {
				case PublishFolderType.Unset:
				case PublishFolderType.None:
				case PublishFolderType.Unknown:
					// Don't copy unknown stuff anywhere
					continue;

				case PublishFolderType.RootDirectory:
				case PublishFolderType.Assembly:
				case PublishFolderType.Resource:
					appContentDirContents.Add (CopyWithDestinationAndStamp (item, HotRestartAppContentDir));
					contentDirContents.Add (CopyWithDestinationAndStamp (item, HotRestartContentDir, HotRestartContentStampDir));
					break;

				case PublishFolderType.AppleBindingResourcePackage:
				case PublishFolderType.CompressedAppleBindingResourcePackage:
				case PublishFolderType.StaticLibrary:
					// These aren't copied to the bundle
					continue;

				case PublishFolderType.AppleFramework:
				case PublishFolderType.PlugIns:
				case PublishFolderType.DynamicLibrary:
				case PublishFolderType.PluginLibrary:
					// These have to be signed
					signedAppDirContents.Add (CopyWithDestinationAndStamp (item, HotRestartSignedAppDir));
					break;

				case PublishFolderType.CompressedAppleFramework:
				case PublishFolderType.CompressedPlugIns:
					// Shouldn't really happen?
					continue;
				}
			}

			appContentDirContents = ExpandDirectories (appContentDirContents);
			contentDirContents = ExpandDirectories (contentDirContents);
			signedAppDirContents = ExpandDirectories (signedAppDirContents);

			HotRestartAppContentDirContents = appContentDirContents.ToArray ();
			HotRestartContentDirContents = contentDirContents.ToArray ();
			HotRestartSignedAppDirContents = signedAppDirContents.ToArray ();

			return !Log.HasLoggedErrors;
		}
	}
}
