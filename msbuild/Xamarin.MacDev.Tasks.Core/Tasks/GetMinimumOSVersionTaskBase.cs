using System;

using Microsoft.Build.Framework;

using Xamarin.Localization.MSBuild;

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

			return true;
		}
	}
}

