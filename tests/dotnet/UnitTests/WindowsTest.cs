using System.IO;

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

			var project_path = GetProjectPath (project, runtimeIdentifiers: runtimeIdentifiers, platform: platform, out var appPath, configuration: configuration);
			var project_dir = Path.GetDirectoryName (Path.GetDirectoryName (project_path))!;
			Clean (project_path);

			var properties = GetDefaultProperties (runtimeIdentifiers);
			if (!string.IsNullOrWhiteSpace (configuration))
				properties ["Configuration"] = configuration;
			properties ["IsHotRestartBuild"] = "true";
			properties ["IsHotRestartEnvironmentReady"] = "true";
			properties ["EnableCodeSigning"] = "false";
			var hotRestartOutputDir = Path.Combine (Cache.CreateTemporaryDirectory (), "out");
			Directory.CreateDirectory (hotRestartOutputDir);
			properties ["HotRestartSignedAppOutputDir"] = hotRestartOutputDir + Path.DirectorySeparatorChar;
			var rv = DotNet.AssertBuild (project_path, properties);

			DumpDirContents (appPath);
			DumpDirContents (hotRestartOutputDir);

			var rids = runtimeIdentifiers.Split (';');
			BundleStructureTest.CheckAppBundleContents (platform, appPath, rids, BundleStructureTest.CodeSignature.None, configuration == "Release");
		}

		static void DumpDirContents (string dir)
		{
			var files = Directory.GetFileSystemEntries (dir, "*", SearchOption.AllDirectories);
			Console.WriteLine ($"Found {files.Count ()} in {dir}:");
			foreach (var entry in files)
				Console.WriteLine ($"    {entry}");
		}

		[Test]
		[TestCase (ApplePlatform.iOS, "ios-arm64")]
		public void ConfigurationTestWhileDebugging (ApplePlatform platform, string runtimeIdentifiers)
		{
			Configuration.IgnoreIfIgnoredPlatform (platform);
		}


	}
}
