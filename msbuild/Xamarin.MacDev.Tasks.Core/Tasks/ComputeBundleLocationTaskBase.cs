#nullable enable

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
			var sb = new StringBuilder ();
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

			var appleFrameworks = new Dictionary<string, List<ITaskItem>> ();
			foreach (var item in list.ToArray ()) { 
				var publishFolderType = ParsePublishFolderType (item);
				if (publishFolderType == PublishFolderType.Unset) {
					publishFolderType = ComputePublishFolderType (list, item);
					item.SetMetadata ("PublishFolderType", publishFolderType.ToString ());
				}

				var virtualProjectPath = GetVirtualAppBundlePath (item, out var withLink);
				var relativePath = string.Empty;
				switch (publishFolderType) {
				case PublishFolderType.Assembly:
					relativePath = AssemblyDirectory;
					break;
				case PublishFolderType.Resource:
					relativePath = ResourceDirectory;
					break;
				case PublishFolderType.AppleFramework:
					if (TryGetFrameworkDirectory (item.ItemSpec, out var frameworkDirectory)) {
						if (!appleFrameworks.TryGetValue (frameworkDirectory!, out var items))
							appleFrameworks [frameworkDirectory!] = items = new List<ITaskItem> ();
						items.Add (item);
						// Remove AppleFramework entries, we'll add back one entry per framework at the end
						list.Remove (item);
						continue;
					}

					Console.WriteLine ("NIEX"); // FIXME: show error
					continue;
				case PublishFolderType.CompressedAppleFramework:
					relativePath = FrameworksDirectory;
					if (!withLink && string.Equals (Path.GetExtension (virtualProjectPath), ".zip", StringComparison.OrdinalIgnoreCase)) {
						// Remove the .zip extension of the input file
						virtualProjectPath = Path.Combine (Path.GetDirectoryName (virtualProjectPath), Path.GetFileNameWithoutExtension (virtualProjectPath));
					}
					break;
				case PublishFolderType.AppleBindingResource:
					//throw new NotImplementedException ();
					Console.WriteLine ("NIEX"); // FIXME
					break;
				case PublishFolderType.CompressedPlugIns:
					relativePath = PlugInsDirectory;
					if (!withLink && string.Equals (Path.GetExtension (virtualProjectPath), ".zip", StringComparison.OrdinalIgnoreCase)) {
						// Remove the .zip extension of the input file
						virtualProjectPath = Path.Combine (Path.GetDirectoryName (virtualProjectPath), Path.GetFileNameWithoutExtension (virtualProjectPath));
					}
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

				item.SetMetadata ("RelativePath", Path.Combine (relativePath, virtualProjectPath));
				Dump (sb, item);
			}

			// Add back the .framework directory (only) for AppleFramework
			foreach (var entry in appleFrameworks) {
				var items = entry.Value;
				var item = new TaskItem (entry.Key);
				item.SetMetadata ("PublishFolderType", "AppleFramework");
				item.SetMetadata ("RelativePath", Path.Combine (FrameworksDirectory, Path.GetFileName (entry.Key)));
				list.Add (item);
			}

			UpdatedResolvedFileToPublish = list.ToArray ();

			Console.WriteLine (sb);
			Log.LogWarning (sb.ToString ());
			File.WriteAllText ("/tmp/log", sb.ToString ());
			Log.LogWarning ("Wrote output to /tmp/log!!");

			return !Log.HasLoggedErrors;
		}

		static bool TryGetFrameworkDirectory (string path, out string? frameworkDirectory)
		{
			if (string.IsNullOrEmpty (path)) {
				frameworkDirectory = null;
				return false;
			}

			if (path.EndsWith (".xcframework", StringComparison.OrdinalIgnoreCase)) {
				frameworkDirectory = path;
				return true;
			}

			if (path.EndsWith (".framework", StringComparison.OrdinalIgnoreCase)) {
				// We might be inside a .xcframework, so check for that first
				if (TryGetFrameworkDirectory (Path.GetDirectoryName (path), out var xcframeworkDirectory) && xcframeworkDirectory!.EndsWith (".xcframework", StringComparison.OrdinalIgnoreCase)) {
					frameworkDirectory = xcframeworkDirectory;
					return true;
				}

				frameworkDirectory = path;
				return true;
			}

			return TryGetFrameworkDirectory (Path.GetDirectoryName (path), out frameworkDirectory);
		}

		static string GetVirtualAppBundlePath (ITaskItem item, out bool withLink)
		{
			var link = item.GetMetadata ("Link");
			if (string.IsNullOrEmpty (link)) {
				withLink = false;
				return Path.GetFileName (item.ItemSpec);
			}

			withLink = true;
			return link;
		}

		static void Dump (StringBuilder sb, ITaskItem item)
		{
			sb.AppendLine ($"Item: {item.ItemSpec}");
			foreach (var name in item.MetadataNames) {
				sb.AppendLine ($"    {name}: {item.GetMetadata ((string) name)}");
			}
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
			if (TryGetFrameworkDirectory (filename, out _))
				return PublishFolderType.AppleFramework;

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
