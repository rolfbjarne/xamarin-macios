using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.iOS.Tasks.Windows.Properties;
using Xamarin.iOS.Windows;
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
					// These aren't copied to the bundle
					continue;

				case PublishFolderType.AppleFramework:
				case PublishFolderType.PlugIns:
				case PublishFolderType.DynamicLibrary:
				case PublishFolderType.PluginLibrary:
				case PublishFolderType.StaticLibrary:
					// These have to be signed
					signedAppDirContents.Add (CopyWithDestinationAndStamp (item, HotRestartSignedAppDir));
					break;

				case PublishFolderType.CompressedAppleFramework:
				case PublishFolderType.CompressedPlugIns:
					// Shouldn't really happen?
					continue;
				}
			}

			HotRestartAppContentDirContents = appContentDirContents.ToArray ();
			HotRestartContentDirContents = contentDirContents.ToArray ();
			HotRestartSignedAppDirContents = signedAppDirContents.ToArray ();

			return !Log.HasLoggedErrors;
		}
	}
}
