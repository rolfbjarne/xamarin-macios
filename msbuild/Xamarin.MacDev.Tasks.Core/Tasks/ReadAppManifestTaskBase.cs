using System;

using Microsoft.Build.Framework;

using Xamarin.Localization.MSBuild;
using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks {
	public abstract class ReadAppManifestTaskBase : XamarinTask {
		[Required]
		public string AppManifest { get; set; }

		[Required]
		public string SdkVersion { get; set; }

		[Output]
		public string BundleIdentifier { get; set; }

		[Output]
		public string ExecutableName { get; set; }

		[Output]
		public string MinimumOSVersion { get; set; }

		public override bool Execute ()
		{
			PDictionary plist = null;

			try {
				plist = PDictionary.FromFile (AppManifest);
			} catch (Exception ex) {
				Log.LogError (null, null, null, AppManifest, 0, 0, 0, 0, MSBStrings.E0010, AppManifest, ex.Message);
				return false;
			}

			BundleIdentifier = plist.GetCFBundleIdentifier ();
			ExecutableName = plist.GetCFBundleExecutable ();
			MinimumOSVersion = plist.Get<PString> (PlatformFrameworkHelper.GetMinimumOSVersionKey (Platform))?.Value;

			return true;
		}
	}
}
