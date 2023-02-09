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
			var tmpdir = Cache.CreateTemporaryDirectory ();
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
			var hotRestartOutputDir = Path.Combine (tmpdir, "out");
			Directory.CreateDirectory (hotRestartOutputDir);
			properties ["HotRestartSignedAppOutputDir"] = hotRestartOutputDir + Path.DirectorySeparatorChar;
			var hotRestartAppBundlePath = Path.Combine (tmpdir, "HotRestartAppBundlePath"); // Do not create this directory, it will be created and populated with default contents if it doesn't exist.
			properties ["HotRestartAppBundlePath"] = hotRestartAppBundlePath; // no trailing directory separator char for this property.
			var rv = DotNet.AssertBuild (project_path, properties);

			DumpDirContents (appPath);
			DumpDirContents (tmpdir);

			var hotRestartAppBundleFiles = BundleStructureTest.Find (hotRestartAppBundlePath);
			var payloadFiles = BundleStructureTest.Find (Path.Combine (hotRestartOutputDir, "Payload", "BundleStructure.app"));
			var contentFiles = BundleStructureTest.Find (Path.Combine (hotRestartOutputDir, "BundleStructure.content"));
			var merged = hotRestartAppBundleFiles.Union (payloadFiles).ToList ();
			var duplicates = merged.GroupBy (v => v).Where (g => g.Count () > 1).Select (v => v.Key);
			merged = merged.Distinct ().OrderBy (v => v).ToList ();

			var rids = runtimeIdentifiers.Split (';');
			BundleStructureTest.CheckAppBundleContents (platform, merged, rids, BundleStructureTest.CodeSignature.None, configuration == "Release");
		}

		static void DumpDirContents (string dir)
		{
			var files = Directory.GetFileSystemEntries (dir, "*", SearchOption.AllDirectories);
			Console.WriteLine ($"Found {files.Count ()} in {dir}:");
			foreach (var entry in files.OrderBy (v => v))
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
