using System;
using System.IO;
using System.Linq;

using Microsoft.Build.Framework;

using Xamarin.Localization.MSBuild;
using Xamarin.Messaging.Build.Client;
using Xamarin.Utils;

// Disable until we get around to enable + fix any issues.
#nullable disable

namespace Xamarin.MacDev.Tasks {
	public class DetectSdkLocations : XamarinTask, ICancelableTask {
		const string SdkVersionDefaultValue = "default";
		#region Inputs

		public string TargetArchitectures {
			get; set;
		}

		public string IsDotNetSimulatorBuild {
			get; set;
		}

		#endregion Inputs

		#region Outputs

		[Output]
		public string SdkRoot {
			get; set;
		}

		[Output]
		public string SdkBinPath {
			get; set;
		}

		[Output]
		public string SdkDevPath {
			get; set;
		}

		[Output]
		public string SdkUsrPath {
			get; set;
		}

		[Output]
		public bool SdkIsSimulator {
			get; set;
		}

		[Output]
		public string SdkPlatform {
			get; set;
		}

		// This is also an input
		[Output]
		public string SdkVersion {
			get; set;
		}

		// This is also an input
		[Output]
		public string XamarinSdkRoot {
			get; set;
		}

		[Output]
		public string XcodeVersion {
			get; set;
		}

		#endregion Outputs

		protected IAppleSdk CurrentSdk {
			get {
				return Sdks.GetAppleSdk (Platform);
			}
		}

		string GetDefaultXamarinSdkRoot ()
		{
			switch (Platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
			case ApplePlatform.WatchOS:
			case ApplePlatform.MacCatalyst:
				return Sdks.XamIOS.SdkDir;
			case ApplePlatform.MacOSX:
				return Sdks.XamMac.FrameworkDirectory;
			default:
				throw new InvalidOperationException (string.Format (MSBStrings.InvalidPlatform, Platform));
			}
		}

		IAppleSdkVersion GetDefaultSdkVersion ()
		{
			switch (Platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
			case ApplePlatform.WatchOS:
			case ApplePlatform.MacCatalyst:
				return AppleSdkVersion.UseDefault;
			case ApplePlatform.MacOSX:
				var v = CurrentSdk.GetInstalledSdkVersions (false);
				return v.Count > 0 ? v [v.Count - 1] : AppleSdkVersion.UseDefault;
			default:
				throw new InvalidOperationException (string.Format (MSBStrings.InvalidPlatform, Platform));
			}
		}

		protected string GetEnvironmentVariableOverride ()
		{
			switch (Platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
			case ApplePlatform.WatchOS:
			case ApplePlatform.MacCatalyst:
				return "MD_MTOUCH_SDK_ROOT";
			case ApplePlatform.MacOSX:
				return "XAMMAC_FRAMEWORK_PATH";
			default:
				throw new InvalidOperationException (string.Format (MSBStrings.InvalidPlatform, Platform));
			}
		}

		protected void EnsureSdkPath ()
		{
			SdkPlatform = GetSdkPlatform (SdkIsSimulator);

			var currentSdk = CurrentSdk;
			IAppleSdkVersion requestedSdkVersion;

			if (string.IsNullOrEmpty (SdkVersion)) {
				requestedSdkVersion = GetDefaultSdkVersion ();
			} else if (!currentSdk.TryParseSdkVersion (SdkVersion, out requestedSdkVersion)) {
				Log.LogError (MSBStrings.E0025 /* Could not parse the SDK version '{0}' */, SdkVersion);
				return;
			}

			var sdkVersion = requestedSdkVersion.ResolveIfDefault (currentSdk, SdkIsSimulator);
			if (!currentSdk.SdkIsInstalled (sdkVersion, SdkIsSimulator)) {
				sdkVersion = currentSdk.GetClosestInstalledSdk (sdkVersion, SdkIsSimulator);

				if (sdkVersion.IsUseDefault || !currentSdk.SdkIsInstalled (sdkVersion, SdkIsSimulator)) {
					if (requestedSdkVersion.IsUseDefault) {
						Log.LogError (MSBStrings.E0171 /* The {0} SDK is not installed. */, PlatformName);
					} else {
						Log.LogError (MSBStrings.E0172 /* The {0} SDK version '{0}' is not installed, and no newer version was found. */, PlatformName, requestedSdkVersion.ToString ());
					}
					return;
				}
				Log.LogWarning (MSBStrings.E0173 /* The {0} SDK version '{1}' is not installed. Using newer version '{2}' instead'. */, PlatformName, requestedSdkVersion, sdkVersion);
			}
			SdkVersion = sdkVersion.ToString ();

			SdkRoot = currentSdk.GetSdkPath (SdkVersion, SdkIsSimulator);
			if (string.IsNullOrEmpty (SdkRoot))
				Log.LogError (MSBStrings.E0084 /* Could not locate the {0} '{1}' SDK at path '{2}' */, PlatformName, SdkVersion, SdkRoot);

			SdkUsrPath = DirExists ("SDK usr directory", Path.Combine (currentSdk.DeveloperRoot, "usr"));
			if (string.IsNullOrEmpty (SdkUsrPath))
				Log.LogError (MSBStrings.E0085 /* Could not locate the {0} '{1}' SDK usr path at '{2}' */, PlatformName, SdkVersion, SdkRoot);

			SdkBinPath = DirExists ("SDK bin directory", Path.Combine (SdkUsrPath, "bin"));
			if (string.IsNullOrEmpty (SdkBinPath))
				Log.LogError (MSBStrings.E0032 /* Could not locate SDK bin directory */);
		}

		void EnsureXamarinSdkRoot ()
		{
			if (string.IsNullOrEmpty (XamarinSdkRoot))
				XamarinSdkRoot = GetDefaultXamarinSdkRoot ();

			if (string.IsNullOrEmpty (XamarinSdkRoot))
				Log.LogError (MSBStrings.E0046 /* Could not find '{0}' */, Product);
			else if (!Directory.Exists (XamarinSdkRoot))
				Log.LogError (MSBStrings.E0170 /* Could not find {0} in {1}. */, Product, XamarinSdkRoot);
		}

		public override bool Execute ()
		{
			if (ShouldExecuteRemotely ()) {
				// The new targets do not support the "default" value for the MtouchSdkVersion
				// So we fix it to not break existing projects that has this value defined in the .csproj
				if (!string.IsNullOrEmpty (SdkVersion) && SdkVersionDefaultValue.Equals (SdkVersion, StringComparison.OrdinalIgnoreCase))
					SdkVersion = string.Empty;

				return new TaskRunner (SessionId, BuildEngine4).RunAsync (this).Result;
			}

			AppleSdkSettings.Init ();

			SetIsSimulator ();

			// If XamarinSdkRoot is set, then make that override any other value, and in order to do so,
			// set the corresponding environment variable accordingly.
			if (!string.IsNullOrEmpty (XamarinSdkRoot))
				Environment.SetEnvironmentVariable (GetEnvironmentVariableOverride (), XamarinSdkRoot);

			if (EnsureAppleSdkRoot ())
				EnsureSdkPath ();
			EnsureXamarinSdkRoot ();

			XcodeVersion = AppleSdkSettings.XcodeVersion.ToString ();

			return !Log.HasLoggedErrors;
		}

		void SetIsSimulator ()
		{
			switch (Platform) {
			case ApplePlatform.MacCatalyst:
			case ApplePlatform.MacOSX:
				return;
			}

			TargetArchitecture architectures;
			if (string.IsNullOrEmpty (TargetArchitectures) || !Enum.TryParse (TargetArchitectures, out architectures))
				architectures = TargetArchitecture.Default;

			if (!string.IsNullOrEmpty (IsDotNetSimulatorBuild)) {
				SdkIsSimulator = string.Equals (IsDotNetSimulatorBuild, "true", StringComparison.OrdinalIgnoreCase);
			} else {
				SdkIsSimulator = (architectures & (TargetArchitecture.i386 | TargetArchitecture.x86_64)) != 0;
			}
		}

		protected bool EnsureAppleSdkRoot ()
		{
			var currentSdk = CurrentSdk;
			if (!currentSdk.IsInstalled) {
				Log.LogError (MSBStrings.E0044v2 /* Could not find a valid Xcode app bundle at '{0}'. Please verify that 'xcode-select -p' points to your Xcode installation. For more information see https://aka.ms/macios-missing-xcode. */, AppleSdkSettings.InvalidDeveloperRoot);
				return false;
			}
			Log.LogMessage (MessageImportance.Low, "DeveloperRoot: {0}", currentSdk.DeveloperRoot);
			Log.LogMessage (MessageImportance.Low, "GetPlatformPath: {0}", currentSdk.GetPlatformPath (SdkIsSimulator));

			SdkDevPath = currentSdk.DeveloperRoot;
			if (string.IsNullOrEmpty (SdkDevPath)) {
				Log.LogError (MSBStrings.E0086 /* Could not find a valid Xcode developer path */);
				return false;
			}
			return true;
		}

		protected string DirExists (string checkingFor, params string [] paths)
		{
			try {
				if (paths.Any (p => string.IsNullOrEmpty (p)))
					return null;

				var path = Path.GetFullPath (Path.Combine (paths));
				Log.LogMessage (MessageImportance.Low, MSBStrings.M0047 /* Searching for '{0}' in '{1}' */, checkingFor, path);
				return Directory.Exists (path) ? path : null;
			} catch {
				return null;
			}
		}

		public void Cancel ()
		{
			if (ShouldExecuteRemotely ())
				BuildConnection.CancelAsync (BuildEngine4).Wait ();
		}
	}
}
