
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

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

		IEnumerable<ITaskItem> ProcessFrameworks (IEnumerable<ITaskItem> input)
		{
			var frameworks = new List<ITaskItem> ();
			var xcframeworkPaths = new Dictionary<string, ITaskItem> ();

			// split frameworks and xcframeworks
			// we sort the input to get predicable output
			foreach (var item in input.OrderBy (v => v.ItemSpec)) {
				if (!ComputeBundleLocationTaskBase.TryGetFrameworkDirectory (item.ItemSpec, out var framework, out var isXCFramework)) {
					Log.LogMessage (MessageImportance.Low, "The item {0} is not a framework.", item.ItemSpec);
					continue;
				}

				Log.LogMessage (MessageImportance.Low, $"The item {item.ItemSpec} is {(isXCFramework ? "an xcframework" : "a framework")} with path {framework}");

				if (isXCFramework) {
					if (!xcframeworkPaths.ContainsKey (framework)) {
						xcframeworkPaths.Add (framework, item);
					} else {
						Log.LogMessage (MessageImportance.Low, $"The xcframework {framework} has already been added from the path {item.ItemSpec}");
					}
				} else {
					frameworks.Add (item);
					item.ItemSpec = framework;
				}
			}

			// if we got no xcframeworks, then we only have frameworks (if anything at all)
			if (!xcframeworkPaths.Any ())
				return frameworks;

			var xcframeworks = new List<ITaskItem> ();
			foreach (var entry in xcframeworkPaths) {
				var xcframework = entry.Key;
				var resolved = ResolveNativeReferencesBase.ResolveXCFramework (Log, SdkIsSimulator, TargetFrameworkMoniker, Architectures, xcframework);
				if (resolved is null) {
					Log.LogWarning ($"Unable to resolve the xcframework: {xcframework}");
					continue;
				}
				var item = entry.Value;
				item.ItemSpec = Path.GetFullPath (resolved);
				xcframeworks.Add (item);

				Log.LogWarning ($"Resolved {xcframework} to {item.ItemSpec}");
			}

			return frameworks.Union (xcframeworks);
		}

		public override bool Execute ()
		{
			var allInput = new List<ITaskItem> ();

			var noneFrameworks = None.Where (v => Path.GetDirectoryName (v.ItemSpec).EndsWith (".framework", StringComparison.OrdinalIgnoreCase));

			allInput.AddRange (noneFrameworks);
			allInput.AddRange (UnpackedFramework);
			allInput.AddRange (NativeReference);

			Log.LogMessage (MessageImportance.Normal, $"Found {noneFrameworks.Count ()} None framework items, {UnpackedFramework.Length} UnpackedFramework items, {NativeReference.Length} NativeReference items, for a total of {allInput.Count} items");

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
			Log.LogMessage (MessageImportance.Normal, $"Found {HotRestartFrameworks.Length} hot restart frameworks");

			return !Log.HasLoggedErrors;
		}
	}
}

