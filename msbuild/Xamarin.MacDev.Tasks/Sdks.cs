using System;
using System.IO;

using Xamarin.Localization.MSBuild;
using Xamarin.Utils;
using Xamarin.MacDev.Tasks;

#nullable enable

namespace Xamarin.MacDev {
	public static class Sdks {
		public static IAppleSdk GetAppleSdk (ApplePlatform framework, XcodeLocator appleSdk)
		{
			switch (framework) {
			case ApplePlatform.iOS:
				return new AppleIPhoneSdk (appleSdk.DeveloperRoot, appleSdk.DeveloperRootVersionPlist);
			case ApplePlatform.TVOS:
				return new AppleTVOSSdk (appleSdk.DeveloperRoot, appleSdk.DeveloperRootVersionPlist);
			case ApplePlatform.MacCatalyst:
			case ApplePlatform.MacOSX:
				return new MacOSXSdk (appleSdk.DeveloperRoot, appleSdk.DeveloperRootVersionPlist);
			default:
				throw new InvalidOperationException (string.Format (MSBStrings.InvalidFramework, framework));
			}
		}

		public static IAppleSdk GetAppleSdk (string targetFrameworkMoniker, XcodeLocator appleSdk)
		{
			return GetAppleSdk (PlatformFrameworkHelper.GetFramework (targetFrameworkMoniker), appleSdk);
		}
	}
}
