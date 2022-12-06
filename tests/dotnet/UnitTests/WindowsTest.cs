#nullable enable

namespace Xamarin.Tests {
	[Category ("Windows")]
	public class WindowsTest : TestBaseClass {
		[Test]
		public void First ()
		{
		}

		[Test]
		[TestCase (ApplePlatform.iOS, "ios-arm64")]
		public void BundleStructureWithHotRestart (ApplePlatform platform, string runtimeIdentifiers)
		{
			var project = "BundleStructure";
			var configuration = "Debug";
			// FIXME Configuration.IgnoreIfIgnoredPlatform(platform);

			var project_path = GetProjectPath(project, runtimeIdentifiers: runtimeIdentifiers, platform: platform, out var appPath, configuration: configuration);
			var project_dir = Path.GetDirectoryName(Path.GetDirectoryName(project_path))!;
			Clean(project_path);

			var properties = GetDefaultProperties(runtimeIdentifiers);
			if (!string.IsNullOrWhiteSpace(configuration))
				properties["Configuration"] = configuration;
			var rv = DotNet.AssertBuild(project_path, properties);
		}

		[Test]
		[TestCase(ApplePlatform.iOS, "ios-arm64")]
		public void ConfigurationTestWhileDebugging(ApplePlatform platform, string runtimeIdentifiers)
		{
			Configuration.IgnoreIfIgnoredPlatform(platform);
		}


	}
}
