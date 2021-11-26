#nullable enable

using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.MacDev;
using Xamarin.Utils;
using Xamarin.Localization.MSBuild;

namespace Xamarin.MacDev.Tasks {
	public abstract class ComputeBundleLocationTaskBase : XamarinTask {
		// not required because this can be the root directory (so an empty string)
		public string AssemblyDirectory { get; set; } = string.Empty;

		public ITaskItem []? BundleResource { get; set; }
		public ITaskItem []? Content { get; set; }
		public ITaskItem []? EmbeddedResource { get; set; }

		[Required]
		public string FrameworksDirectory { get; set; } = string.Empty;

		[Required]
		public string PlugInsDirectory { get; set; } = string.Empty;

		[Required]
		public string ProjectDir { get; set; } = string.Empty;

		// not required because this can be the root directory (so an empty string)
		public string ResourceDirectory { get; set; } = string.Empty;

		[Required]
		public ITaskItem []? ResolvedFileToPublish { get; set; }

		[Output]
		public ITaskItem []? UpdatedResolvedFileToPublish { get; set; }

		HashSet<string> resourceFilesSet = new HashSet<string> ();
		
		public override bool Execute ()
		{
			if (ResolvedFileToPublish == null)
				return !Log.HasLoggedErrors;

			var list = ResolvedFileToPublish.ToList ();

			// Make sure we use the correct path separator, these are relative paths, so it doesn't look
			// like MSBuild does this automatically
			FrameworksDirectory = FrameworksDirectory.Replace ('\\', Path.DirectorySeparatorChar);
			PlugInsDirectory = PlugInsDirectory.Replace ('\\', Path.DirectorySeparatorChar);
			ResourceDirectory = ResourceDirectory.Replace ('\\', Path.DirectorySeparatorChar);

			if (BundleResource != null)
				resourceFilesSet.UnionWith (BundleResource.Select (v => Path.GetFullPath (v.ItemSpec)));
			if (Content != null)
				resourceFilesSet.UnionWith (Content.Select (v => Path.GetFullPath (v.ItemSpec)));
			if (EmbeddedResource != null)
				resourceFilesSet.UnionWith (EmbeddedResource.Select (v => Path.GetFullPath (v.ItemSpec)));

			foreach (var item in list) { 
				var publishFolderType = ParsePublishFolderType (item);
				if (publishFolderType == PublishFolderType.Unset) {
					publishFolderType = ComputePublishFolderType (list, item);
					item.SetMetadata ("PublishFolderType", publishFolderType.ToString ());
				}

				var relativePath = string.Empty;
				switch (publishFolderType) {
				case PublishFolderType.Assembly:
					relativePath = AssemblyDirectory;
					break;
				case PublishFolderType.Resource:
					relativePath = ResourceDirectory;
					break;
				case PublishFolderType.AppleFramework:
					relativePath = FrameworksDirectory;
					break;
				case PublishFolderType.CompressedAppleFramework:
					relativePath = FrameworksDirectory;
					break;
				case PublishFolderType.AppleBindingResource:
					//throw new NotImplementedException ();
					Console.WriteLine ("NIEX"); // FIXME
					break;
				case PublishFolderType.CompressedPlugIns: // FIXME
					relativePath = PlugInsDirectory;
					break;
				case PublishFolderType.PlugIns:
					relativePath = PlugInsDirectory;
					break;
				case PublishFolderType.RootDirectory:
					break;
				case PublishFolderType.DynamicLibrary:
					// FIXME: don't copy at all for release mobile builds?
					relativePath = AssemblyDirectory;
					break;
				case PublishFolderType.None:
					continue;
				case PublishFolderType.Unknown:
				default:
					item.SetMetadata ("PublishFolderType", "None");
					ReportUnknownPublishFolderType (item);
					continue;
				}

				// var virtualProjectPath = BundleResource.GetVirtualProjectPath (ProjectDir, item, !string.IsNullOrEmpty (SessionId));
				// item.SetMetadata ("RelativePath", Path.Combine (relativePath, virtualProjectPath));
				item.SetMetadata ("RelativePath", Path.Combine (relativePath, Path.GetFileName (item.ItemSpec)));
			}

			UpdatedResolvedFileToPublish = list.ToArray ();

			return !Log.HasLoggedErrors;
		}

		void ReportUnknownPublishFolderType (ITaskItem item)
		{
			var publishFolderType = item.GetMetadata ("PublishFolderType");

			var metadata = item.GetMetadata ("CopyToOutputDirectory");
			if (!string.IsNullOrEmpty (metadata)) {
				Log.LogWarning (MSBStrings.E7090 /* The 'PublishFolderType' metadata value '{0}' on the item '{1}' is not recognized. The file will not be copied to the app bundle. If the file is not supposed to be copied to the app bundle, remove the '{2}' metadata on the item. */, publishFolderType, item.ItemSpec, "CopyToOutputDirectory");
				return;
			}

			metadata = item.GetMetadata ("CopyToPublishDirectory");
			if (!string.IsNullOrEmpty (metadata)) {
				Log.LogWarning (MSBStrings.E7090 /* The 'PublishFolderType' metadata value '{0}' on the item '{1}' is not recognized. The file will not be copied to the app bundle. If the file is not supposed to be copied to the app bundle, remove the '{2}' metadata on the item. */, publishFolderType, item.ItemSpec, "CopyToPublishDirectory");
				return;
			}

			Log.LogWarning (MSBStrings.E7088 /* The 'PublishFolderType' metadata value '{0}' on the item '{1}' is not recognized. The file will not be copied to the app bundle. */, publishFolderType, item.ItemSpec);
		}

		// 'item' is not supposed to have a PublishFolderType set
		PublishFolderType ComputePublishFolderType (IList<ITaskItem> items, ITaskItem item)
		{
			var filename = item.ItemSpec;

			// Check if the item came from @(BundleResource), @(Content) or @(EmbeddedResource)
			if (resourceFilesSet.Contains (Path.GetFullPath (item.ItemSpec)))
				return PublishFolderType.Resource;

			var publishedItems = items.Where (v => {
				var type = ParsePublishFolderType (v);
				return type != PublishFolderType.None && type != PublishFolderType.Unknown;
			});

			// Assemblies and their related files
			if (filename.EndsWith (".dll", StringComparison.OrdinalIgnoreCase)) {
				return PublishFolderType.Assembly;
			} else if (filename.EndsWith (".exe", StringComparison.OrdinalIgnoreCase)) {
				return PublishFolderType.Assembly;
			} else if (filename.EndsWith (".pdb", StringComparison.OrdinalIgnoreCase)) {
				return PublishFolderType.Assembly;
			} else if (filename.EndsWith (".dll.mdb", StringComparison.OrdinalIgnoreCase) || filename.EndsWith (".exe.mdb", StringComparison.OrdinalIgnoreCase)) {
				return PublishFolderType.Assembly;
			} else if (filename.EndsWith (".config", StringComparison.OrdinalIgnoreCase)) {
				return PublishFolderType.Assembly;
			}
			//if (filename.EndsWith (".config", StringComparison.OrdinalIgnoreCase)) {
			//	// If we're publishing any assemblies that matches this .config file, then consider the .config as an assembly file
			//	var dllName = Path.ChangeExtension (filename, "dll");
			//	var exeName = Path.ChangeExtension (filename, "exe");
			//	if (publishedItems.Any (v => string.Equals (v.ItemSpec, dllName, StringComparison.OrdinalIgnoreCase) || string.Equals (v.ItemSpec, exeName, StringComparison.OrdinalIgnoreCase)))
			//		return PublishFolderType.Assembly;
			//}

			// Native (xc)frameworks
			var pathComponents = filename.Split (Path.DirectorySeparatorChar);
			if (pathComponents.Any (v => v.EndsWith (".framework", StringComparison.OrdinalIgnoreCase))) {
				return PublishFolderType.AppleFramework;
			} else if (pathComponents.Any (v => v.EndsWith (".xcframework", StringComparison.OrdinalIgnoreCase))) {
				return PublishFolderType.AppleFramework;
			}

			// *.resources
			// FIXME: implement this somehow
			//var resourcesIndex = Array.FindLastIndex<string> (pathComponents, (v) => v.EndsWith (".resources", StringComparison.OrdinalIgnoreCase));
			//if (pathComponents.Any (v => v.EndsWith (".resources", StringComparison.OrdinalIgnoreCase)) {
			//	string resourcesDir = filename;
			//	if (!filename.EndsWith (".resources", StringComparison.OrdinalIgnoreCase))
			//		resourcesDir = filename.Substring (0, filename.LastIndexOf (".resources" + Path.DirectorySeparatorChar));
			//	var assemblyName = 
			//	if (Directory.Exists (resourcesDir))
			//		return PublishFolderType.
			//	var resourcesPath = GetPathRoot" string.Join (Path.DirectorySeparatorChar.ToString (), pathComponents, 0, resourcesIndex + 1);
			//}

			// resources (png, jpg)
			if (filename.EndsWith (".jpg", StringComparison.OrdinalIgnoreCase)) {
				return PublishFolderType.Resource;
			} else if (filename.EndsWith (".png", StringComparison.OrdinalIgnoreCase)) {
				return PublishFolderType.Resource;
			}

			// *.framework.zip, *.xcframework.zip
			if (filename.EndsWith (".framework.zip", StringComparison.OrdinalIgnoreCase)) {
				return PublishFolderType.CompressedAppleFramework;
			} else if (filename.EndsWith (".xcframework.zip", StringComparison.OrdinalIgnoreCase)) {
				return PublishFolderType.CompressedAppleFramework;
			}

			// *.a and *.dylib
			if (filename.EndsWith (".a", StringComparison.OrdinalIgnoreCase)) {
				return PublishFolderType.StaticLibrary;
			} else if (filename.EndsWith (".dylib", StringComparison.OrdinalIgnoreCase)) {

				return PublishFolderType.DynamicLibrary;
			}

			// no other files are copied

			Log.LogWarning (MSBStrings.E7089 /* The file '{0}' does not specify a 'PublishFolderType' metadata, and a default value could not be calcuated. The file will not be copied to the app bundle. */, item.ItemSpec);

			return PublishFolderType.None;
		}

		static PublishFolderType ParsePublishFolderType (ITaskItem item)
		{
			return ParsePublishFolderType (item.GetMetadata ("PublishFolderType"));
		}

		static PublishFolderType ParsePublishFolderType (string value)
		{
			if (string.IsNullOrEmpty (value))
				return PublishFolderType.Unset;

			if (!Enum.TryParse<PublishFolderType> (value, out var result))
				result = PublishFolderType.Unknown;

			return result;
		}

		enum PublishFolderType {
			Unset,
			None,
			RootDirectory,
			Assembly,
			Resource,
			AppleBindingResource,
			AppleFramework,
			CompressedAppleFramework,
			PlugIns,
			CompressedPlugIns,
			DynamicLibrary, // link with + copy to app bundle
			StaticLibrary, // link with (but not copy to app bundle)
			Unknown,
		}
	}
}
