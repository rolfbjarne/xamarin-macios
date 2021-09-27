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
		public string? AssemblyDirectory { get; set; }

		public string? FrameworksDirectory { get; set; }

		public string? PlugInsDirectory { get; set; }

		[Required]
		public string? ProjectDir { get; set; }

		public string? ResourceDirectory { get; set; }

		[Required]
		[Output]
		public ITaskItem[]? ResolvedFileToPublish { get; set; }

		[Output]
		public ITaskItem[]? CompressedFrameworks { get; set; }

		public override bool Execute ()
		{
			if (ResolvedFileToPublish == null)
				return !Log.HasLoggedErrors;

			var list = ResolvedFileToPublish.ToList ();

			// First remove all with unknown PublishFolderType or where it's 'None'
			list.RemoveAll (v => {
				var publishFolderType = ParsePublishFolderType (v);
				switch (publishFolderType) {
				case PublishFolderType.None:
					return true;
				case PublishFolderType.Unknown:
					Log.LogWarning (MSBStrings.E7088 /* The 'PublishFolderType' metadata value '{0}' on the item '{1}' is not recognized. The file will not be copied to the app bundle. */, v.GetMetadata ("PublishFolderType"), v.ItemSpec);
					return true;
				}
				return false;
			});

			for (var i = list.Count - 1; i >= 0; i--) {
				var item = list [i];
				var publishFolderType = ParsePublishFolderType (item);
				if (publishFolderType == PublishFolderType.Unset) {
					publishFolderType = ComputePublishFolderType (list, item);
					item.SetMetadata ("PublishFolderType", publishFolderType.ToString ());
				}

				var virtualProjectPath = BundleResource.GetVirtualProjectPath (ProjectDir, item, !string.IsNullOrEmpty (SessionId));
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
					throw new NotImplementedException ();
				case PublishFolderType.CompressedPlugIns: // FIXME
					relativePath = FrameworksDirectory;
					break;
				case PublishFolderType.PlugIns:
					relativePath = PlugInsDirectory;
					break;
				case PublishFolderType.RootDirectory:
					break;
				case PublishFolderType.None:
					list.RemoveAt (i);
					break;
				case PublishFolderType.Unknown:
				default:
					Log.LogWarning (MSBStrings.E7088 /* The 'PublishFolderType' metadata value '{0}' on the item '{1}' is not recognized. The file will not be copied to the app bundle. */, item.GetMetadata ("PublishFolderType"), item.ItemSpec);
					list.RemoveAt (i);
					break;
				}

				item.SetMetadata ("RelativePath", Path.Combine (relativePath, virtualProjectPath));
			}

			ResolvedFileToPublish = list.ToArray ();

			return !Log.HasLoggedErrors;
		}


		PublishFolderType ComputePublishFolderType (IList<ITaskItem> items, ITaskItem item)
		{
			var filename = item.ItemSpec;

			// Assemblies and their related files
			if (filename.EndsWith (".dll", StringComparison.OrdinalIgnoreCase)) {
				return PublishFolderType.Assembly;
			} else if (filename.EndsWith (".exe", StringComparison.OrdinalIgnoreCase)) {
				return PublishFolderType.Assembly;
			} else if (filename.EndsWith (".pdb", StringComparison.OrdinalIgnoreCase)) {
				return PublishFolderType.Assembly;
			} else if (filename.EndsWith (".dll.mdb", StringComparison.OrdinalIgnoreCase) || filename.EndsWith (".exe.mdb", StringComparison.OrdinalIgnoreCase)) {
				return PublishFolderType.Assembly;
			}
			if (filename.EndsWith (".config", StringComparison.OrdinalIgnoreCase)) {
				// If we're publishing any assemblies that matches this .config file, then consider the .config as an assembly file
				var dllName = Path.ChangeExtension (filename, "dll");
				var exeName = Path.ChangeExtension (filename, "exe");
				if (items.Any (v => string.Equals (v.ItemSpec, dllName, StringComparison.OrdinalIgnoreCase) || string.Equals (v.ItemSpec, exeName, StringComparison.OrdinalIgnoreCase)))
					return PublishFolderType.Assembly;
			}

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
				return PublishFolderType.Unknown;

			if (!Enum.TryParse<PublishFolderType> (value, out var result))
				result = PublishFolderType.Unknown;

			return result;
		}

		enum PublishFolderType {
			Unset,
			None,
			Assembly,
			Resource,
			AppleFramework,
			CompressedAppleFramework,
			AppleBindingResource,
			CompressedPlugIns,
			PlugIns,
			RootDirectory,
			DynamicLibrary, // link with + copy to app bundle
			StaticLibrary, // link with (but not copy to app bundle)
			Unknown,
		}
	}
}
