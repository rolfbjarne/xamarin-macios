using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Xamarin.iOS.Tasks.Windows.Properties;
using Xamarin.iOS.Windows;
using Xamarin.MacDev.Tasks;

#nullable enable

namespace Xamarin.iOS.HotRestart.Tasks {
	public class CollectDynamicFrameworks : Task {
		#region Inputs

		[Required]
		public string Architectures { get; set; } = string.Empty;

		[Required]
		public ITaskItem [] Frameworks { get; set; } = Array.Empty<ITaskItem> ();

		[Required]
		public bool SdkIsSimulator { get; set; }

		[Required]
		public string TargetFrameworkMoniker { get; set; } = string.Empty;
		#endregion

		#region Outputs

		[Output]
		public ITaskItem [] DynamicFrameworks { get; set; } = Array.Empty<ITaskItem> ();

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

		IEnumerable<ITaskItem> ProcessFrameworks (ITaskItem [] input)
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
			var frameworks = new List<ITaskItem> ();
			var hotRestartClient = new HotRestartClient ();

			foreach (var framework in ProcessFrameworks (Frameworks)) {
				if (frameworks.Any (x => x.ItemSpec == framework.ItemSpec)) {
					continue;
				}

				var frameworkDirName = Path.GetFileName (framework.ItemSpec);
				try {
					var frameworkPath = Path.Combine (framework.ItemSpec, Path.GetFileNameWithoutExtension (frameworkDirName));
					Log.LogMessage (MessageImportance.Low, $"Loading: {frameworkPath}");
					hotRestartClient.LoadDynamicFramework (frameworkPath);
				} catch (AppleInvalidFrameworkException frameworkEx) {
					Log.LogMessage (MessageImportance.Normal, Resources.CollectDynamicFrameworks_InvalidFramework, Path.GetFileName (framework.ItemSpec), frameworkEx.Message);
					continue;
				} catch (Exception ex) {
					Log.LogErrorFromException (ex, true, true, framework.ItemSpec);
					continue;
				}

				framework.SetMetadata ("FrameworkDir", $@"{frameworkDirName}\");

				frameworks.Add (framework);
			}

			DynamicFrameworks = frameworks.ToArray ();

			return !Log.HasLoggedErrors;
		}
	}
}
