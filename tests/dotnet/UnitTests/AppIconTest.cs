using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

#nullable enable

namespace Xamarin.Tests {
	public class AppIconTest : TestBaseClass {
		[TestCase (ApplePlatform.iOS, "iossimulator-x64")]
		// [TestCase (ApplePlatform.iOS, "ios-arm64")]
		// [TestCase (ApplePlatform.TVOS, "tvossimulator-x64")]
		// [TestCase (ApplePlatform.MacCatalyst, "maccatalyst-arm64;maccatalyst-x64")]
		// [TestCase (ApplePlatform.MacOSX, "osx-x64")]
		// [TestCase (ApplePlatform.MacOSX, "osx-arm64;osx-x64")]
		public void DefaultValues (ApplePlatform platform, string runtimeIdentifiers)
		{
			TestXCAssetsImpl (platform, runtimeIdentifiers);
		}

		[TestCase (ApplePlatform.iOS, "iossimulator-x64")]
		// [TestCase (ApplePlatform.iOS, "ios-arm64")]
		// [TestCase (ApplePlatform.TVOS, "tvos-arm64")]
		// [TestCase (ApplePlatform.MacCatalyst, "maccatalyst-x64")]
		// [TestCase (ApplePlatform.MacCatalyst, "maccatalyst-arm64;maccatalyst-x64")]
		// [TestCase (ApplePlatform.MacOSX, "osx-x64")]
		// [TestCase (ApplePlatform.MacOSX, "osx-arm64;osx-x64")]
		public void IncludeAllIcons (ApplePlatform platform, string runtimeIdentifiers)
		{
			TestXCAssetsImpl (
				platform,
				runtimeIdentifiers,
				new Dictionary<string, string> () { { "IncludeAllAppIcons", "true" } },
				new string [] { "Icon Image:Icon1024.png", "MultiSized Image:AlternateAppIcons", "MultiSized Image:AppIcons" });
		}


		[TestCase (ApplePlatform.iOS, "iossimulator-x64")]
		// [TestCase (ApplePlatform.iOS, "ios-arm64")]
		// [TestCase (ApplePlatform.TVOS, "tvos-arm64")]
		// [TestCase (ApplePlatform.MacCatalyst, "maccatalyst-x64")]
		// [TestCase (ApplePlatform.MacCatalyst, "maccatalyst-arm64;maccatalyst-x64")]
		// [TestCase (ApplePlatform.MacOSX, "osx-x64")]
		// [TestCase (ApplePlatform.MacOSX, "osx-arm64;osx-x64")]
		public void XSAppIconAssets (ApplePlatform platform, string runtimeIdentifiers)
		{
			TestXCAssetsImpl (
				platform,
				runtimeIdentifiers,
				new Dictionary<string, string> () {
					{ "_XSAppIconAssets", "Resources/Images.xcassets/AlternateAppIcons.appiconset" }
				},
				new string [] { "Icon Image:Icon1024.png", "MultiSized Image:AlternateAppIcons" });
		}

		void TestXCAssetsImpl (ApplePlatform platform, string runtimeIdentifiers, Dictionary<string, string>? extraProperties = null, IEnumerable<string>? extraAssets = null)
		{
			var projectPath = string.Empty;
			var appPath = string.Empty;

			Configuration.AssertRuntimeIdentifiersAvailable (platform, runtimeIdentifiers);
			var project = "AppWithXCAssets";
			Configuration.IgnoreIfIgnoredPlatform (platform);
			projectPath = GetProjectPath (project, runtimeIdentifiers: runtimeIdentifiers, platform: platform, out appPath);

			Clean (projectPath);

			var properties = GetDefaultProperties (runtimeIdentifiers, extraProperties);
			DotNet.AssertBuild (projectPath, properties);

			var resourcesDirectory = GetResourcesDirectory (platform, appPath);
			var assetsCar = Path.Combine (resourcesDirectory, "Assets.car");
			Assert.That (assetsCar, Does.Exist, "Assets.car");

			var doc = AssetsTest.ProcessAssets (assetsCar, GetFullSdkVersion (platform, runtimeIdentifiers));
			Assert.IsNotNull (doc, "There was an issue processing the asset binary.");

			var foundAssets = AssetsTest.FindAssets (doc);

			var expectedAssets = new HashSet<string> () {
				"Image:Icon16.png",
				"Image:Icon32.png",
				"Image:Icon64.png",
			};
			if (extraAssets is not null) {
				foreach (var asset in extraAssets)
					expectedAssets.Add (asset);
			}

			switch (platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
			case ApplePlatform.MacOSX:
			case ApplePlatform.MacCatalyst:
				break;
			default:
				throw new ArgumentOutOfRangeException ($"Unknown platform: {platform}");
			}
			CollectionAssert.AreEquivalent (expectedAssets, foundAssets, "Incorrect assets");
		}

		public static string GetFullSdkVersion (ApplePlatform platform, string runtimeIdentifiers)
		{
			switch (platform) {
			case ApplePlatform.iOS:
				if (runtimeIdentifiers.Contains ("simulator")) {
					return $"iphonesimulator{Configuration.sdk_version}";
				} else {
					return $"iphoneos{Configuration.sdk_version}";
				}
			case ApplePlatform.TVOS:
				if (runtimeIdentifiers.Contains ("simulator")) {
					return $"appletvosimulator{Configuration.tvos_sdk_version}";
				} else {
					return $"appletvos{Configuration.tvos_sdk_version}";
				}
			case ApplePlatform.MacOSX:
			case ApplePlatform.MacCatalyst:
				return $"macosx{Configuration.macos_sdk_version}";
			default:
				throw new ArgumentOutOfRangeException ($"Unknown platform: {platform}");
			}
		}
	}
}
