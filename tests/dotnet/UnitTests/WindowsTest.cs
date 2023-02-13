using System.IO;
using System.IO.Compression;

#nullable enable

namespace Xamarin.Tests {
	[Category ("Windows")]
	public class WindowsTest : TestBaseClass {
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

			// Find the files in the prebuilt hot restart app
			var prebuiltAppFiles = Array.Empty<string> ().ToHashSet ();
			if (BinLog.TryFindPropertyValue (rv.BinLogPath, "MessagingAgentsDirectory", out var preBuiltAppBundleLocation)) {
				Console.WriteLine ($"Found the property 'MessagingAgentsDirectory' in the binlog: {preBuiltAppBundleLocation}");
				var preBuiltAppBundlePath = Path.Combine (preBuiltAppBundleLocation, "Xamarin.PreBuilt.iOS.app.zip");
				using var archive = System.IO.Compression.ZipFile.OpenRead (preBuiltAppBundlePath);
				prebuiltAppFiles = archive.Entries.Select (v => v.FullName).ToHashSet ();

				Console.WriteLine ($"Prebuilt app files:");
				foreach (var pbf in prebuiltAppFiles)
					Console.WriteLine ($"    {pbf}");

			} else {
				Console.WriteLine ("Could not find the property 'MessagingAgentsDirectory' in the binlog.");
			}

			DumpDirContents (appPath);
			DumpDirContents (tmpdir);

			var hotRestartAppBundleFiles = BundleStructureTest.Find (hotRestartAppBundlePath)
				// Exclude any files from the prebuilt hot restart app
				.Where (v => !prebuiltAppFiles.Contains (v));
			var payloadFiles = BundleStructureTest.Find (Path.Combine (hotRestartOutputDir, "Payload", "BundleStructure.app"));
			var contentFiles = BundleStructureTest.Find (Path.Combine (hotRestartOutputDir, "BundleStructure.content"));
			var merged = hotRestartAppBundleFiles
				.Union (payloadFiles)
				.Union (contentFiles)
				.Where (v => {
					// remove files in the BundleStructure.content subdirectory
					if (v.StartsWith ("BundleStructure.content", StringComparison.Ordinal))
						return false;
					// hotrestart-specific files
					if (v == "Extracted")
						return false;
					if (v == "Entitlements.plist")
						return false;
					return true;
				})
				.Distinct ()
				.OrderBy (v => v)
				.ToList ();

			var rids = runtimeIdentifiers.Split (';');
			BundleStructureTest.CheckAppBundleContents (platform, merged, rids, BundleStructureTest.CodeSignature.All, configuration == "Release");
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
