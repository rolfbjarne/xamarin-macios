using System;
using System.Collections.Generic;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Localization.MSBuild;
using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks {
	// This is a clone of XamarinToolTask, except that it subclasses Task instead of ToolTask
	public abstract class XamarinTask : Task {

		public string SessionId { get; set; }

		[Required]
		public string TargetFrameworkMoniker { get; set; }

		public string Product {
			get {
				switch (Platform) {
				case ApplePlatform.iOS:
				case ApplePlatform.TVOS:
				case ApplePlatform.WatchOS:
					return "Xamarin.iOS";
				case ApplePlatform.MacOSX:
					return "Xamarin.Mac";
				default:
					throw new InvalidOperationException ($"Invalid platform: {Platform}");
				}
			}
		}

		ApplePlatform? platform;
		public ApplePlatform Platform {
			get {
				if (!platform.HasValue)
					platform = PlatformFrameworkHelper.GetFramework (TargetFrameworkMoniker);
				return platform.Value;
			}
		}

		TargetFramework? target_framework;
		public TargetFramework TargetFramework {
			get {
				if (!target_framework.HasValue)
					target_framework = TargetFramework.Parse (TargetFrameworkMoniker);
				return target_framework.Value;
			}
		}

		public string PlatformName {
			get {
				switch (Platform) {
				case ApplePlatform.iOS:
					return "iOS";
				case ApplePlatform.TVOS:
					return "tvOS";
				case ApplePlatform.WatchOS:
					return "watchOS";
				case ApplePlatform.MacOSX:
					return "macOS";
				default:
					throw new InvalidOperationException ($"Invalid platform: {Platform}");
				}
			}
		}

		protected string GetSdkPlatform (bool isSimulator)
		{
			switch (Platform) {
			case ApplePlatform.iOS:
				return isSimulator ? "iPhoneSimulator" : "iPhoneOS";
			case ApplePlatform.TVOS:
				return isSimulator ? "AppleTVSimulator" : "AppleTVOS";
			case ApplePlatform.WatchOS:
				return isSimulator ? "WatchSimulator" : "WatchOS";
			case ApplePlatform.MacOSX:
				return "MacOSX";
			default:
				throw new InvalidOperationException ($"Invalid platform: {Platform}");
			}
		}

		public bool TryParseTargetArchitectures (string value, out TargetArchitecture architectures)
		{
			if (!Enum.TryParse<TargetArchitecture> (value, out architectures)) {
				Log.LogError (MSBStrings.E0057 /* Invalid architectures: '{0}'. */, value);
				return false;
			}

			return true;
		}
	}
}

