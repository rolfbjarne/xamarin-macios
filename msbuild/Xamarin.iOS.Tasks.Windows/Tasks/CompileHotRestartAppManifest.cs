using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.IO;
using System.Linq;
using Xamarin.iOS.Tasks.Windows.Properties;
using Xamarin.MacDev;

#nullable enable

namespace Xamarin.iOS.HotRestart.Tasks {
	public class CompileHotRestartAppManifest : Task {
		static readonly string [] IgnorePlistKeys = {
		   "XSAppIconAssets",
		   "CFBundleIconName",
		   "XSLaunchImageAssets",
		   "UIMainStoryboardFile",
		   "UIFileSharingEnabled",
		   "UILaunchStoryboardName",
		   "UIMainStoryboardFile~ipad",
		   "UIMainStoryboardFile~iphone",
		   "CFBundleIdentifier",
		   "CFBundleExecutable"
		};

		#region Inputs

		[Required]
		public string CompiledAppManifestPath { get; set; } = String.Empty;

		[Required]
		public string PrebuiltAppManifestPath { get; set; } = string.Empty;

		[Required]
		public string OutputAppManifestPath { get; set; } = String.Empty;
		#endregion

		// This task will take the prebuilt app manifest (Info.plist) and the (compiled) app manifest from the current build,
		// and merge them by copying all keys in the compiled app manifest into the prebuilt app manifest, except those
		// listed in 'IgnorePlistKeys' (and save the result to OutputAppManifestPath and PrebuiltAppManifestPath)
		public override bool Execute ()
		{
			try {
				var infoPlist = PDictionary.FromFile (CompiledAppManifestPath)!;
				var preBuiltInfoPlist = PDictionary.FromFile (PrebuiltAppManifestPath)!;

				foreach (var item in infoPlist) {
					var key = item.Key!;
					if (!IgnorePlistKeys.Contains (key)) {
						if (preBuiltInfoPlist.ContainsKey (key)) {
							Log.LogMessage (MessageImportance.Low, $"Removed the key {key} with value {PObject_ToString (preBuiltInfoPlist [key])} from the prebuilt input");
							preBuiltInfoPlist.Remove (key);
						}

						preBuiltInfoPlist.Add (key, item.Value.Clone ());
						Log.LogMessage (MessageImportance.Low, $"Added the key {key} with value {PObject_ToString (preBuiltInfoPlist [key])} from the compiled input");
					} else {
						Log.LogMessage (MessageImportance.Low, $"Not copying the key {key} because it's ignored.");
					}
				}

				preBuiltInfoPlist.Save (OutputAppManifestPath, binary: true);
				Log.LogMessage (MessageImportance.Low, $"Saved app manifest to {OutputAppManifestPath}");

				preBuiltInfoPlist.Save (PrebuiltAppManifestPath, binary: true);
				Log.LogMessage (MessageImportance.Low, $"Saved app manifest to {PrebuiltAppManifestPath}");

				Log.LogMessage (MessageImportance.Low, $"App manifest:\n{preBuiltInfoPlist.ToXml ()}");

				return true;
			} catch (Exception ex) {
				Log.LogErrorFromException (ex);

				return false;
			}
		}

		static string? PObject_ToString (PObject? obj)
		{
			if (obj is PString str)
				return str.Value;
			else if (obj is PBoolean b)
				return b.Value.ToString ();
			else if (obj is PData pd)
				return pd.Value.ToString ();
			else if (obj is PNumber number)
				return number.Value.ToString ();
			else if (obj is PReal real)
				return real.Value.ToString ();
			return obj?.ToString ();
		}
	}
}
