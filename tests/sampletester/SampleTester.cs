using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Xml;

using NUnit.Framework;

using Xamarin.Tests;

namespace Samples {
	public class SampleTestData {
		public string Solution;
		public bool BuildSolution;
		public string KnownFailure;
		public string DebugConfiguration;
		public string ReleaseConfiguration;
	}

	[TestFixture]
	public abstract class SampleTester : BaseTester {
		Dictionary<string, string> ignored_solutions;
		Dictionary<string, string> GetIgnoredSolutions ()
		{
			if (ignored_solutions == null)
				ignored_solutions = GetIgnoredSolutionsImpl ();
			return ignored_solutions;
		}

		protected virtual Dictionary<string, string> GetIgnoredSolutionsImpl ()
		{
			return new Dictionary<string, string> ();
		}

		Dictionary<string, SampleTestData> test_data;
		Dictionary<string, SampleTestData> GetTestData ()
		{
			if (test_data == null)
				test_data = GetTestDataImpl ();
			return test_data;
		}

		protected virtual Dictionary<string, SampleTestData> GetTestDataImpl ()
		{
			return new Dictionary<string, SampleTestData> ();
		}

		protected SampleTester ()
		{
		}

		protected SampleTester (string repo, string hash)
			: base (repo, hash)
		{
		}

		[Test]
		public void BuildProject ([Values ("Debug"/*, "Release"*/)] string configuration, [ValueSource ("GetProjects")] string project)
		{
			var proj_path = Path.Combine (CloneRepo (), project);
			var xml = File.ReadAllText (proj_path);
			if (!xml.Contains ("<OutputType>Exe</OutputType>"))
				Assert.Ignore ("Project is not an executable project");
			var xml_lines = xml.Split ('\n');
			var xml_imports = xml_lines.
				Where ((v) => v.Contains ("<Import Project=")).
				Select ((v) => v.Split ('"') [1]);

			var test_platform = TestPlatform.None;
			if (xml_imports.Any ((v) => v.Contains ("Xamarin.iOS"))) {
				test_platform = TestPlatform.iOS;
			} else if (xml_imports.Any ((v) => v.Contains ("Xamarin.TVOS"))) {
				test_platform = TestPlatform.tvOS;
			} else if (xml_imports.Any ((v) => v.Contains ("Xamarin.WatchOS"))) {
				test_platform = TestPlatform.watchOS;
			} else if (xml_imports.Any ((v) => v.Contains ("Xamarin.Mac"))) {
				test_platform = TestPlatform.macOS; // CHECK ME
			} else {
				Assert.Ignore ("Project is not an Xamarin.iOS/Xamarin.Mac/Xamarin.WatchOS/Xamarin.TVOS project. Imports:\n\t{0}", string.Join ("\t\n", xml_imports));
			}

			var platform = string.Empty;
			switch (test_platform) {
			case TestPlatform.iOS:
				platform = "iPhone";
				break;
			case TestPlatform.tvOS:
				platform = "iPhone";
				break;
			case TestPlatform.watchOS:
				Assert.Ignore ("Project is a watchOS app"); // no need to build watchOS apps, they're built as part of their containing iOS project.
				break;
			case TestPlatform.macOS:
				// empty platform is expected
				break;
			default:
				throw new NotImplementedException (test_platform.ToString ());
			}

			var environment_variables = new Dictionary<string, string> ();
			switch (test_platform) {
			case TestPlatform.iOS:
			case TestPlatform.tvOS:
			case TestPlatform.watchOS:
				environment_variables ["MD_APPLE_SDK_ROOT"] = Configuration.XcodeLocation;
				environment_variables ["MD_MTOUCH_SDK_ROOT"] = Path.Combine (Configuration.IOS_DESTDIR, "Library", "Frameworks", "Xamarin.iOS.framework", "Versions", "Current");
				environment_variables ["TargetFrameworkFallbackSearchPaths"] = Path.Combine (Configuration.IOS_DESTDIR, "Library", "Frameworks", "Mono.framework", "External", "xbuild-frameworks");
				environment_variables ["MSBuildExtensionsPathFallbackPathsOverride"] = Path.Combine (Configuration.IOS_DESTDIR, "Library", "Frameworks", "Mono.framework", "External", "xbuild");
				break;
			case TestPlatform.macOS:
				environment_variables ["MD_APPLE_SDK_ROOT"] = Configuration.XcodeLocation;
				environment_variables ["TargetFrameworkFallbackSearchPaths"] = Path.Combine (Configuration.MAC_DESTDIR, "Library", "Frameworks", "Mono.framework", "External", "xbuild-frameworks");
				environment_variables ["MSBuildExtensionsPathFallbackPathsOverride"] = Path.Combine (Configuration.MAC_DESTDIR, "Library", "Frameworks", "Mono.framework", "External", "xbuild");
				environment_variables ["XamarinMacFrameworkRoot"] = Path.Combine (Configuration.MAC_DESTDIR, "Library", "Frameworks", "Xamarin.Mac.framework", "Versions", "Current");
				environment_variables ["XAMMAC_FRAMEWORK_PATH"] = Path.Combine (Configuration.MAC_DESTDIR, "Library", "Frameworks", "Xamarin.Mac.framework", "Versions", "Current");
				break;
			default:
				throw new NotImplementedException (test_platform.ToString ());
			}
			var project_to_build = project;
			var target = string.Empty;
			if (GetTestData ().TryGetValue (project, out var data)) {
				if (!string.IsNullOrEmpty (data.KnownFailure))
					Assert.Ignore (data.KnownFailure);
				if (data.BuildSolution) {
					project_to_build = data.Solution;
					target = Path.GetFileNameWithoutExtension (project).Replace ('.', '_');
				}

				if (configuration == "Debug" && data.DebugConfiguration != null)
					configuration = data.DebugConfiguration;
				if (configuration == "Release" && data.ReleaseConfiguration != null)
					configuration = data.ReleaseConfiguration;
			}


			project_to_build = Path.Combine (CloneRepo (), project_to_build);
		 	ProcessHelper.BuildSolution (project_to_build, platform, configuration, environment_variables, target);
		}

		void BuildProject (string configuration, string platform, string solution)
		{

		}

		protected static string RootDirectory {
			get {
				return Configuration.SampleRootDirectory;
			}
		}

		static Dictionary<string, string []> solutions = new Dictionary<string, string []> ();
		protected static string [] GetSolutionsImpl (string repo)
		{
			string [] rv;
			if (!solutions.TryGetValue (repo, out rv))
				solutions [repo] = rv = GitHub.GetSolutions ("xamarin", repo);
			return rv;
		}

		static Dictionary<string, string []> projects = new Dictionary<string, string []> ();
		protected static string [] GetExecutableProjects (string repo)
		{
			if (!projects.TryGetValue (repo, out var rv))
				projects [repo] = rv = GitHub.GetProjects ("xamarin", repo);
			return rv;
		}

		string CloneRepo ()
		{
			return GitHub.CloneRepository ("xamarin", Repository);
		}
	}
}
