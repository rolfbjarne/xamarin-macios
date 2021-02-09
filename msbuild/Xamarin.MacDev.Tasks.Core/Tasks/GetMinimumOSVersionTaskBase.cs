using System;

using Microsoft.Build.Framework;

using Xamarin.Localization.MSBuild;
using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks {
	public abstract class GetMinimumOSVersionTaskBase : XamarinTask {
		public ITaskItem AppManifest { get; set; }

		[Required]
		public string SdkVersion { get; set; }

		[Output]
		public string MinimumOSVersion { get; set; }

		public override bool Execute ()
		{
			PDictionary plist = null;

			if (!string.IsNullOrEmpty (AppManifest?.ItemSpec)) {
				try {
					plist = PDictionary.FromFile (AppManifest.ItemSpec);
				} catch (Exception ex) {
					Log.LogError (null, null, null, AppManifest.ItemSpec, 0, 0, 0, 0, MSBStrings.E0010, AppManifest.ItemSpec, ex.Message);
					return false;
				}
			}

			var minimumOSVersionInManifest = plist?.Get<PString> (PlatformFrameworkHelper.GetMinimumOSVersionKey (Platform))?.Value;
			if (string.IsNullOrEmpty (minimumOSVersionInManifest)) {
				MinimumOSVersion = SdkVersion;
			} else if (!IAppleSdkVersion_Extensions.TryParse (minimumOSVersionInManifest, out var _)) {
				Log.LogError (null, null, null, AppManifest.ItemSpec, 0, 0, 0, 0, MSBStrings.E0011, minimumOSVersionInManifest);
				return false;
			} else {
				MinimumOSVersion = minimumOSVersionInManifest;
			}

			if (Platform == ApplePlatform.MacCatalyst) {
				// Convert the min macOS version to the min iOS version, which the rest of our tooling expects.
				var dict = ((MacOSXSdk) Sdks.GetAppleSdk (Platform)).GetCatalystVersionMap_Mac_to_iOS (SdkVersion);
				if (dict.TryGetValue (MinimumOSVersion, out var convertedVersion)) {
					MinimumOSVersion = convertedVersion;
				} else {
					Log.LogError ($"Can't convert macOS version {MinimumOSVersion} to an iOS version.");
					foreach (var kvp in dict)
						Log.LogError ($" {kvp.Key} => {kvp.Value}");
					return false;
				}
			}

			return true;
		}
	}
}

