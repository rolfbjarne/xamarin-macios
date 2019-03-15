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

	public class ProjectInfo {
		public string Path;
		public bool IsExecutable;
		public string [] Imports;
		public TestPlatform Platform;

		public bool IsApplicable (bool assert)
		{
			if (!IsExecutable) {
				if (assert)
					Assert.Ignore ("Project is not an executable project");
				return false;
			}

			if (Platform == TestPlatform.None) {
				if (assert)
					Assert.Ignore ("Project is not an Xamarin.iOS/Xamarin.Mac/Xamarin.WatchOS/Xamarin.TVOS project. Imports:\n\t{0}", string.Join ("\t\n", Imports));
				return false;
			}

			if (Platform == TestPlatform.watchOS) {
				if (assert)
					Assert.Ignore ("Project is a watchOS app"); // no need to build watchOS apps, they're built as part of their containing iOS project.

				return false;
			}

			return true;
		}
	}

	public abstract class SampleTester : BaseTester {
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

		static ProjectInfo GetProjectInfo (string project)
		{
			var xml = File.ReadAllText (project);
			var info = new ProjectInfo ();
			info.Path = project;
			info.IsExecutable = xml.Contains ("<OutputType>Exe</OutputType>");

			var xml_lines = xml.Split ('\n');
			var xml_imports = xml_lines.
				Where ((v) => v.Contains ("<Import Project=")).
				Select ((v) => v.Split ('"') [1]);
			info.Imports = xml_imports.ToArray ();

			var test_platform = TestPlatform.None;
			if (xml_imports.Any ((v) => v.Contains ("Xamarin.iOS"))) {
				test_platform = TestPlatform.iOS;
			} else if (xml_imports.Any ((v) => v.Contains ("Xamarin.TVOS"))) {
				test_platform = TestPlatform.tvOS;
			} else if (xml_imports.Any ((v) => v.Contains ("Xamarin.WatchOS"))) {
				test_platform = TestPlatform.watchOS;
			} else if (xml_imports.Any ((v) => v.Contains ("Xamarin.Mac"))) {
				test_platform = TestPlatform.macOS;
			} else {
				test_platform = TestPlatform.None;
			}
			info.Platform = test_platform;

			return info;
		}

		[Test]
		public void BuildProject ([Values ("Debug", "Release")] string configuration, [ValueSource ("GetProjects")] string project)
		{
			var proj_path = Path.Combine (CloneRepo (), project);
			var info = GetProjectInfo (proj_path);

			info.IsApplicable (true);

			var platform = string.Empty;
			switch (info.Platform) {
			case TestPlatform.iOS:
			case TestPlatform.tvOS:
				platform = "iPhone";
				break;
			case TestPlatform.macOS:
				// empty platform is expected
				break;
			case TestPlatform.watchOS: // info.IsApplicable should Assert.Ignore for watchOS, so this shouldn't happen
			default:
				throw new NotImplementedException (info.Platform.ToString ());
			}

			var environment_variables = new Dictionary<string, string> ();
			switch (info.Platform) {
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
				throw new NotImplementedException (info.Platform.ToString ());
			}

			var file_to_build = project;
			var target = string.Empty;
			if (GetTestData ().TryGetValue (project, out var data)) {
				if (!string.IsNullOrEmpty (data.KnownFailure))
					Assert.Ignore (data.KnownFailure);
				if (data.BuildSolution) {
					file_to_build = data.Solution;
					target = Path.GetFileNameWithoutExtension (project).Replace ('.', '_');
				}

				if (configuration == "Debug" && data.DebugConfiguration != null)
					configuration = data.DebugConfiguration;
				if (configuration == "Release" && data.ReleaseConfiguration != null)
					configuration = data.ReleaseConfiguration;
			}


			file_to_build = Path.Combine (CloneRepo (), file_to_build);
			ProcessHelper.BuildSolution (file_to_build, platform, configuration, environment_variables, target);
		}

		static Dictionary<string, string []> projects = new Dictionary<string, string []> ();
		protected static string [] GetExecutableProjects (string repo)
		{
			if (!projects.TryGetValue (repo, out var rv)) {
				var clone = true; // If we clone the repo to get the list of projects, or if we use GitHub's REST API. The former is much slower, but needs to be done anyway, and allows us to immediately filter out projects we don't care about.

				rv = GitHub.GetProjects ("xamarin", repo, clone);
				if (clone) {
					// We can filter out project we don't care about.
					rv = rv.Where ((v) => {
						var proj_path = Path.Combine (GitHub.CloneRepository ("xamarin", repo, false), v);
						var info = GetProjectInfo (proj_path);
						return info.IsApplicable (false);
					}).ToArray ();
				}

				projects [repo] = rv;
			}
			return rv;
		}

		string CloneRepo ()
		{
			return GitHub.CloneRepository ("xamarin", Repository);
		}
	}
}
