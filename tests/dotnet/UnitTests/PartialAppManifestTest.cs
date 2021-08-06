using System.Collections.Generic;

using NUnit.Framework;

using Xamarin.Utils;
using Xamarin.MacDev;

namespace Xamarin.Tests {
	public class PartialAppManifestTest : TestBaseClass {

		[Test]
		[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-x64")]
		public void Build (ApplePlatform platform, string runtimeIdentifiers)
		{
			var project = "MyPartialAppManifestApp";
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var project_path = GetProjectPath (project, runtimeIdentifiers: runtimeIdentifiers, platform: platform, out var appPath);
			Clean (project_path);
			var properties = new Dictionary<string, string> (verbosity);
			SetRuntimeIdentifiers (properties, runtimeIdentifiers);

			DotNet.AssertBuild (project_path, properties);

			var infoPlistPath = GetInfoPListPath (platform, appPath);
			var infoPlist = PDictionary.FromFile (infoPlistPath);
			Assert.AreEqual ("com.xamarin.mypartialappmanifestapp", infoPlist.GetString ("CFBundleIdentifier").Value, "CFBundleIdentifier");
			Assert.AreEqual ("MyPartialAppManifestApp", infoPlist.GetString ("CFBundleDisplayName").Value, "CFBundleDisplayName");
			Assert.AreEqual ("3.14", infoPlist.GetString ("CFBundleVersion").Value, "CFBundleVersion");
			Assert.AreEqual ("3.14", infoPlist.GetString ("CFBundleShortVersionString").Value, "CFBundleShortVersionString");
			Assert.AreEqual ("SomeValue", infoPlist.GetString ("Something").Value, "Something");
		}
	}
}
