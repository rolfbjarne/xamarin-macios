using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

#nullable enable

namespace Xamarin.MacDev.Tasks {
	public class CollectHotRestartFrameworks : Task {
		#region Inputs

		[Required]
		public string Architectures { get; set; } = string.Empty;

		[Required]
		public string IntermediateOutputPath { get; set; } = string.Empty;

		public ITaskItem [] NativeReference { get; set; } = Array.Empty<ITaskItem> ();

		public ITaskItem [] None { get; set; } = Array.Empty<ITaskItem> ();

		[Required]
		public bool SdkIsSimulator { get; set; }

		public ITaskItem [] UnpackedFramework { get; set; } = Array.Empty<ITaskItem> ();

		[Required]
		public string TargetFrameworkMoniker { get; set; } = string.Empty;
		#endregion

		#region Outputs

		[Output]
		public ITaskItem [] HotRestartFrameworks { get; set; } = Array.Empty<ITaskItem> ();

		#endregion

		const string XCFramework_Extension = ".xcframework";
		static string? GetXCFramework (string framework)
		{
			framework = framework.TrimEnd (Path.DirectorySeparatorChar);
			if (framework.EndsWith (XCFramework_Extension, StringComparison.OrdinalIgnoreCase))
				return framework;
			if (framework.Length <= XCFramework_Extension.Length)
				return null;
			return GetXCFramework (Path.GetDirectoryName (framework));
		}

		IEnumerable<ITaskItem> ProcessFrameworks (IEnumerable<ITaskItem> input)
		{
			var frameworks = new List<ITaskItem> ();
			var xcframeworkPaths = new HashSet<string> ();

			// split frameworks and xcframeworks
			foreach (var item in input) {
				var spec = item.ItemSpec.TrimEnd (Path.DirectorySeparatorChar);
				if (!spec.EndsWith (".framework", StringComparison.OrdinalIgnoreCase))
					continue;

				var xcframework = GetXCFramework (spec);
				if (xcframework is not null) {
					xcframeworkPaths.Add (xcframework);
				} else {
					item.ItemSpec = spec;
					frameworks.Add (item);
				}
			}

			// if we got no xcframeworks, then we only have frameworks (if anything at all)
			if (!xcframeworkPaths.Any ())
				return frameworks;

			var xcframeworks = new List<ITaskItem> ();
			foreach (var xcframework in xcframeworkPaths) {
				var resolved = ResolveNativeReferencesBase.ResolveXCFramework (Log, SdkIsSimulator, TargetFrameworkMoniker, Architectures, xcframework);
				if (resolved is null) {
					Log.LogWarning ($"Unable to resolve the xcframework: {xcframework}");
					continue;
				}
				var resolvedFullPath = Path.GetFullPath (resolved).Trim (Path.DirectorySeparatorChar);
				var t = new TaskItem (resolved);
				var originalTaskItems = input.Where (v => string.Equals (
					Path.GetFullPath (v.ItemSpec).TrimEnd (Path.DirectorySeparatorChar),
					resolvedFullPath,
					StringComparison.OrdinalIgnoreCase));
				if (!originalTaskItems.Any ()) {
					Log.LogWarning ($"Could not find the original item for: {xcframework}");
				} else if (originalTaskItems.Count () > 1) {
					Log.LogWarning ($"Found more than one original item for: {xcframework}:\n\t{string.Join ("\n\t", originalTaskItems.Select (v => v.ItemSpec))}");
				} else {
					// add metadata from the original item
					var nr = originalTaskItems.Single ();
					nr.CopyMetadataTo (t);
				}

				Log.LogWarning ($"Resolved {xcframework} to {resolvedFullPath}");

				t.SetMetadata ("Kind", "Framework");
				t.SetMetadata ("Name", resolved);
				xcframeworks.Add (t);
			}

			return frameworks.Union (xcframeworks);
		}

		public override bool Execute ()
		{
			var allInput = new List<ITaskItem> ();

			var noneFrameworks = None.Where (v => v.GetMetadata ("Directory").TrimEnd (Path.DirectorySeparatorChar).EndsWith (".framework"));

			allInput.AddRange (noneFrameworks);
			allInput.AddRange (UnpackedFramework);
			allInput.AddRange (NativeReference);

			var frameworks = new Dictionary<string, ITaskItem> ();
			foreach (var framework in ProcessFrameworks (allInput)) {
				if (frameworks.ContainsKey (framework.ItemSpec)) {
					Log.LogMessage (MessageImportance.Normal, "The framework {0} has already been included.", framework.ItemSpec);
					continue;
				}

				// Set extra metadata used in the _CollectHotRestartDynamicFrameworks target
				var filename = framework.GetMetadata ("Filename");
				var extension = framework.GetMetadata ("Extension");
				var fullpath = framework.GetMetadata ("FullPath");
				framework.SetMetadata ("FrameworkExecutable", Path.Combine (fullpath, filename));
				framework.SetMetadata ("Outputs", Path.Combine (IntermediateOutputPath, "DynamicFrameworks", filename, extension + ".stamp"));
				var frameworkDirName = Path.GetFileName (framework.ItemSpec);
				framework.SetMetadata ("FrameworkDir", $@"{frameworkDirName}\");

				frameworks.Add (framework.ItemSpec, framework);
			}

			HotRestartFrameworks = frameworks.Select (v => v.Value).ToArray ();

			return !Log.HasLoggedErrors;
		}
	}
}

