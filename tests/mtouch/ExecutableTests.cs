using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

using Xamarin;
using Xamarin.Tests;

using NUnit.Framework;

namespace Xamarin
{
	public enum AssemblyBuildTarget
	{
		Default,
		StaticObject,
		DynamicLibrary,
		Framework_Sdk,
		Framework_Sdk_RestSingleFramework,
		Framework_Sdk_RestStaticObject,
		Framework_All,
		Framework_Single,
	}

	[Flags]
	public enum Architecture
	{
		Default = 0,
		ARM64 = 1,
		ARMv7 = 2,
		ARMv7s = 4,
		ARMv7k = 8,
		Dual = ARMv7 | ARM64,
	}

	public static class Extensions
	{
		public static string AsString (this AssemblyBuildTarget @this)
		{
			switch (@this) {
			case AssemblyBuildTarget.Default:
				return string.Empty;
			case AssemblyBuildTarget.StaticObject:
				return "--assembly-build-target @all=staticobject";
			case AssemblyBuildTarget.DynamicLibrary:
				return "--assembly-build-target @all=dynamiclibrary";
			case AssemblyBuildTarget.Framework_Sdk:
				return "--assembly-build-target @sdk=framework=Xamarin.Sdk --assembly-build-target @all=framework";
			case AssemblyBuildTarget.Framework_All:
				return "--assembly-build-target=@all=framework";
			case AssemblyBuildTarget.Framework_Sdk_RestStaticObject:
				return "--assembly-build-target=@sdk=framework=Xamarin.Sdk --assembly-build-target=@all=staticobject";
			case AssemblyBuildTarget.Framework_Single:
				return "--assembly-build-target=@all=framework";
			case AssemblyBuildTarget.Framework_Sdk_RestSingleFramework:
				return "--assembly-build-target @sdk=framework=Xamarin.Sdk --assembly-build-target @all=framework=rest";
			default:
				throw new NotImplementedException ();
			}
		}

		static void AddArchitectures (ProjectFile project, HashSet<string> architectures, bool recursive)
		{
			if ((project.Architectures & Architecture.ARM64) == Architecture.ARM64)
				architectures.Add ("arm64");
			if ((project.Architectures & Architecture.ARMv7) == Architecture.ARMv7)
				architectures.Add ("armv7");
			if ((project.Architectures & Architecture.ARMv7s) == Architecture.ARMv7s)
				architectures.Add ("armv7s");
			if ((project.Architectures & Architecture.ARMv7k) == Architecture.ARMv7k)
				architectures.Add ("armv7k");

			if (recursive) {
				foreach (var ext in project.ProjectReferences) {
					if (ext.ProjectType == ProjectType.WatchKit2App || ext.ProjectType == ProjectType.WatchKit2Extension)
						continue;
					AddArchitectures (ext, architectures, recursive);
				}
			}
		}

		public static void AssertExecutableArchitectures (this ProjectFile project)
		{
			var outputPath = project.GetOutputPath ("iPhone", "Debug");
			var apps = Directory.GetDirectories (outputPath, "*.app");
			if (apps.Length != 1)
				throw new Exception ($"Found {apps.Length} .app directories when exactly 1 was expected.");

			var app_expected_architectures = new HashSet<string> ();
			AddArchitectures (project, app_expected_architectures, project.MTouchExtraArgs?.Contains ("framework") == true);

			var executable = Path.Combine (apps [0], Path.GetFileNameWithoutExtension (apps [0]));
			if (!File.Exists (executable))
				throw new Exception ($"Executable {executable} does not exist.");
			Assert.That (MTouch.GetArchitectures (executable), Is.EquivalentTo (app_expected_architectures), $"executable architectures: {executable}");

			var fws = Path.Combine (apps [0], "Frameworks");
			if (Directory.Exists (fws)) {
				var executables = new List<string> ();
				var frameworks = Directory.GetDirectories (fws, "*.framework");
				foreach (var framework in frameworks) {
					var name = Path.GetFileNameWithoutExtension (framework);
					executable = Path.Combine (framework, name);
					if (!File.Exists (executable))
						throw new Exception ($"Framework {executable} does not exist.");
					executables.Add (executable);
				}

				var all_expected_architectures = new HashSet<string> ();
				AddArchitectures (project, all_expected_architectures, true);
				foreach (var exec in executables) {
					var architectures = MTouch.GetArchitectures (exec);
					Assert.That (architectures, Is.EquivalentTo (all_expected_architectures), $"architectures: {exec}");
				}
			}
		}

		static Dictionary<string, DateTime> CaptureFilesWithTimestamps (string path)
		{
			var dict = new Dictionary<string, DateTime> ();

			foreach (var file in Directory.GetFiles (path, "*", SearchOption.AllDirectories))
				dict.Add (file, File.GetLastWriteTime (file));

			return dict;
		}

		public static void AssertFastRebuild (this ProjectFile project, string platform = "iPhone", string configuration = "Debug" )
		{
			var timestamps = CaptureFilesWithTimestamps (Directory.GetDirectories (project.GetOutputPath (platform, configuration), "*.app") [0]);
			var watch = Stopwatch.StartNew ();
			File.SetLastWriteTimeUtc (project.ProjectPath, DateTime.UtcNow); // Touch the project file.
			project.BuildDevice ();
			watch.Stop ();
			var failures = new List<string> ();
			foreach (var kvp in timestamps) {
				switch (Path.GetExtension (kvp.Key)) {
				case ".dll":
				case ".mdb":
				case ".exe":
					var fn = Path.GetFileName (kvp.Key);
					if (kvp.Key.EndsWith ($"{fn}.framework/{fn}", StringComparison.Ordinal)) {
						// This isn't an assembly, but a native executable.
						// https://bugzilla.xamarin.com/show_bug.cgi?id=49097
						continue;
					}
					break;
				default:
					// https://bugzilla.xamarin.com/show_bug.cgi?id=49097
					continue;
				}
				var actual = File.GetLastWriteTime (kvp.Key);
				if (kvp.Value == actual)
					continue;
				failures.Add ($"{kvp.Key}\n\tExpected: {kvp.Value}\n\tActual: {actual}");
			}
			if (failures.Count > 0)
				Assert.Fail (string.Join ("\n", failures.ToArray ()));
			var projectCount = 1 + project.ProjectReferences.Length;
			// 10s per project is *very generous*, and we should take much less than that.
			// See also: https://bugzilla.xamarin.com/show_bug.cgi?id=49087
			Assert.That (watch.Elapsed.TotalSeconds, Is.LessThan (10 * projectCount), "Rebuild shouldn't take more than 10 seconds per project.");
		}
	}

	[TestFixture]
	[Category ("LongRunning")]
	[Category ("RequiresDevice")]
	public class ExecutableTests
	{
		public class RunAppTestData
		{
			public ProjectType ProjectType;
			public Architecture Architectures;
			public bool Profiling;
			public AssemblyBuildTarget BuildTarget;
			public bool Debug;
			public ProjectType [] Extensions;
			public string MinimumOSVersion;

			ProjectFile project;

			public RunAppTestData (ProjectType projectType, Architecture architectures, bool profiling, AssemblyBuildTarget build_target, bool debug, params ProjectType [] extensions)
			{
				ProjectType = projectType;
				Architectures = architectures;
				Profiling = profiling;
				BuildTarget = build_target;
				Debug = debug;
				Extensions = extensions;
			}

			public RunAppTestData (ProjectType projectType, bool profiling, AssemblyBuildTarget build_target, bool debug, params ProjectType [] extensions)
			{
				ProjectType = projectType;
				Profiling = profiling;
				BuildTarget = build_target;
				Debug = debug;
				Extensions = extensions;
				switch (ProjectType) {
				case ProjectType.tvOSApp:
					Architectures = Architecture.ARM64;
					break;
				case ProjectType.iOSApp:
					throw new Exception ("iOS apps must specify architecture.");
				default:
					throw new NotImplementedException ();
				}
			}

			public override string ToString ()
			{
				var has_extensions = Extensions != null && Extensions.Length >= 0;
				var ext = has_extensions ? (", " + string.Join (", ", Extensions.Select ((v) => v.ToString ()).ToArray ())) : string.Empty;
				var profiling = Profiling ? ", Profiling" : string.Empty;
				var debug = Debug ? "Debug" : "Release";
				var minOS = string.IsNullOrEmpty (MinimumOSVersion) ? string.Empty : (", " + MinimumOSVersion);
				return $"{ProjectType}, \"{Architectures}\", {debug}{profiling}, {BuildTarget}{ext}{minOS}";
			}

			void SetData (ProjectFile project)
			{
				project.Architectures = Architectures;
				project.ProjectType = ProjectType;
				project.MTouchProfiling = Profiling;
				project.MTouchDebug = Debug;
				project.MTouchUseLlvm = !Debug;
				project.MTouchExtraArgs = BuildTarget.AsString ();
				project.MTouchEnableBitcode = !Debug && ProjectType != ProjectType.iOSApp;
				if (project.ProjectType == ProjectType.iOSApp || project.ProjectType == ProjectType.tvOSApp)
					project.MinimumOSVersion = MinimumOSVersion;
			}

			public ProjectFile CreateProjectFile ()
			{
				// create main project
				project = new ProjectFile ();
				SetData (project);

				// create any extension projects
				var project_references = new List<ProjectFile> ();
				foreach (var extension in Extensions) {
					var ext_project = new ProjectFile
					{
						ProjectType = extension,
					};
					SetData (project);

					switch (extension) {
					case ProjectType.WatchKit2Extension:
						var app_project = new ProjectFile
						{
							ProjectType = ProjectType.WatchKit2App,
							ProjectReferences = new ProjectFile [] { ext_project },
						};

						project_references.Add (app_project);
						break;
					case ProjectType.TodayExtension:
						project_references.Add (ext_project);
						break;
					default:
						throw new NotImplementedException ();
					}
				}
				project.ProjectReferences = project_references.ToArray ();
				return project;
			}
		}

#pragma warning disable 414
		static RunAppTestData [] Data =
#pragma warning restore 414
		{
			// test reduction criteria:
			// iOS builds are fat, since tvOS/watchOS won't be (i.e. tvOS/watchOS tests single-arch, iOS multi-arch).
			// debug builds have profiling enabled, release builds don't.
			// release builds have llvm enabled (debug builds haven't).
			// release builds doesn't have incremental builds enabled (some debug builds have).

			// standard debug build
			new RunAppTestData (ProjectType.iOSApp, Architecture.Dual, false, AssemblyBuildTarget.StaticObject, true),
			new RunAppTestData (ProjectType.iOSApp, Architecture.ARMv7, false, AssemblyBuildTarget.StaticObject, true, ProjectType.WatchKit2Extension),
			new RunAppTestData (ProjectType.iOSApp, Architecture.ARMv7, false, AssemblyBuildTarget.StaticObject, true, ProjectType.TodayExtension),
			new RunAppTestData (ProjectType.tvOSApp, false, AssemblyBuildTarget.StaticObject, true),

			// debug build with profiling enabled
			new RunAppTestData (ProjectType.iOSApp, Architecture.Dual, true, AssemblyBuildTarget.StaticObject, true),
			new RunAppTestData (ProjectType.iOSApp, Architecture.ARMv7, true, AssemblyBuildTarget.StaticObject, true, ProjectType.WatchKit2Extension),
			new RunAppTestData (ProjectType.iOSApp, Architecture.ARM64, true, AssemblyBuildTarget.StaticObject, true, ProjectType.TodayExtension),
			new RunAppTestData (ProjectType.tvOSApp, true, AssemblyBuildTarget.StaticObject, true),

			// debug build building to dylibs (incremental builds) and profiling enabled.
			new RunAppTestData (ProjectType.iOSApp, Architecture.Dual, true, AssemblyBuildTarget.DynamicLibrary, true),
			new RunAppTestData (ProjectType.iOSApp, Architecture.ARMv7, true, AssemblyBuildTarget.DynamicLibrary, true, ProjectType.WatchKit2Extension),
			new RunAppTestData (ProjectType.iOSApp, Architecture.ARMv7, true, AssemblyBuildTarget.DynamicLibrary, true, ProjectType.TodayExtension),
			new RunAppTestData (ProjectType.tvOSApp, true, AssemblyBuildTarget.DynamicLibrary, true),
			
			// debug build building to frameworks and profiling enabled
			new RunAppTestData (ProjectType.iOSApp, Architecture.Dual, true, AssemblyBuildTarget.Framework_Sdk, true),
			new RunAppTestData (ProjectType.iOSApp, Architecture.ARMv7, true, AssemblyBuildTarget.Framework_Sdk, true, ProjectType.WatchKit2Extension),
			new RunAppTestData (ProjectType.iOSApp, Architecture.ARM64, true, AssemblyBuildTarget.Framework_Sdk, true, ProjectType.TodayExtension),
			new RunAppTestData (ProjectType.tvOSApp, true, AssemblyBuildTarget.Framework_Sdk, true),
			
			// release builds using static objects
			new RunAppTestData (ProjectType.iOSApp, Architecture.Dual, false, AssemblyBuildTarget.StaticObject, false),
			new RunAppTestData (ProjectType.iOSApp, Architecture.ARMv7, false, AssemblyBuildTarget.StaticObject, false, ProjectType.WatchKit2Extension),
			new RunAppTestData (ProjectType.iOSApp, Architecture.ARMv7, false, AssemblyBuildTarget.StaticObject, false, ProjectType.TodayExtension),
			new RunAppTestData (ProjectType.tvOSApp, false, AssemblyBuildTarget.StaticObject, false),
			
			// release builds using frameworks
			new RunAppTestData (ProjectType.iOSApp, Architecture.Dual, false, AssemblyBuildTarget.Framework_Sdk, false),
			new RunAppTestData (ProjectType.iOSApp, Architecture.ARMv7, false, AssemblyBuildTarget.Framework_Sdk, false), // this exposes an llvm bug. Selectors end up not being unique, causing "Selector.GetHandle" to return invalid values,
			new RunAppTestData (ProjectType.iOSApp, Architecture.ARMv7, false, AssemblyBuildTarget.Framework_Sdk, false, ProjectType.WatchKit2Extension),
			new RunAppTestData (ProjectType.iOSApp, Architecture.ARM64, false, AssemblyBuildTarget.Framework_Sdk, false, ProjectType.TodayExtension),
			new RunAppTestData (ProjectType.tvOSApp, false, AssemblyBuildTarget.Framework_Sdk, false),
		};

		[TestCaseSource (nameof (Data))]
		public void RunAppTest (RunAppTestData data)
		{
			var project = data.CreateProjectFile ();
			project.Generate ();
			project.BuildDevice ();
			project.AssertExecutableArchitectures ();
			project.AssertFastRebuild ();

			project.RunDevice ();
		}

		[Test]
		[TestCase (Profile.iOS, AssemblyBuildTarget.StaticObject, "Debug32")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.DynamicLibrary, "Debug64")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_All, "Debug32")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk, "Debug64")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk_RestStaticObject, "Debug")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk_RestSingleFramework, "Debug32")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Single, "Debug64")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.StaticObject, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.DynamicLibrary, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_All, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk_RestStaticObject, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk_RestSingleFramework, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Single, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.StaticObject, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.DynamicLibrary, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_All, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk_RestStaticObject, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk_RestSingleFramework, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Single, "Debug")]
		public void RunMonoTouchTest (Profile profile, AssemblyBuildTarget build_target, string configuration)
		{
			var extra_args = build_target.AsString ();
			var build = new BuildTool ()
			{
				ProjectPath = Path.Combine (Configuration.SourceRoot, "tests", "monotouch-test", "monotouch-test" + MTouch.GetProjectSuffix (profile) + ".csproj"),
				Config = configuration,
				Platform = "iPhone",
				Timeout = TimeSpan.FromMinutes (5),
				Properties = { { "MtouchExtraArgs", extra_args } },
			};
			build.Clean ();
			build.Build ();

			var xharness = new XHarnessTool ()
			{
				Profile = profile,
				ProjectPath = build.ProjectPath,
				Configuration = build.Config,
			};
			Assert.AreEqual (0, xharness.UninstallDevice (), "uninstall");
			Assert.AreEqual (0, xharness.InstallDevice (), "install");
			Assert.AreEqual (0, xharness.RunDevice (timeout: TimeSpan.FromMinutes (5)), "run");
		}

		[Test]
		[TestCase (Profile.iOS, AssemblyBuildTarget.StaticObject, "Debug32")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.DynamicLibrary, "Debug64")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_All, "Debug32")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk, "Debug64")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk_RestStaticObject, "Debug")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk_RestSingleFramework, "Debug32")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Single, "Debug64")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.StaticObject, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.DynamicLibrary, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_All, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk_RestStaticObject, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk_RestSingleFramework, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Single, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.StaticObject, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.DynamicLibrary, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_All, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk_RestStaticObject, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk_RestSingleFramework, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Single, "Debug")]
		public void RunDontLink (Profile profile, AssemblyBuildTarget build_target, string configuration)
		{
			var extra_args = build_target.AsString ();
			var build = new BuildTool ()
			{
				ProjectPath = Path.Combine (Configuration.SourceRoot, "tests", "linker-ios/dont link", "dont link" + MTouch.GetProjectSuffix (profile) + ".csproj"),
				Config = configuration,
				Platform = "iPhone",
				Timeout = TimeSpan.FromMinutes (15),
				Properties = { { "MtouchExtraArgs", extra_args } },
			};
			build.Clean ();
			build.Build ();

			var xharness = new XHarnessTool ()
			{
				Profile = profile,
				ProjectPath = build.ProjectPath,
				Configuration = build.Config,
			};
			Assert.AreEqual (0, xharness.UninstallDevice (), "uninstall");
			Assert.AreEqual (0, xharness.InstallDevice (), "install");
			Assert.AreEqual (0, xharness.RunDevice (timeout: TimeSpan.FromMinutes (5)), "run");
		}

		[Test]
		[TestCase (Profile.iOS, AssemblyBuildTarget.StaticObject, "Debug32")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.DynamicLibrary, "Debug64")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_All, "Debug32")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk, "Debug64")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk_RestStaticObject, "Debug")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk_RestSingleFramework, "Debug32")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Single, "Debug64")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.StaticObject, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.DynamicLibrary, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_All, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk_RestStaticObject, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk_RestSingleFramework, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Single, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.StaticObject, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.DynamicLibrary, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_All, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk_RestStaticObject, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk_RestSingleFramework, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Single, "Debug")]
		public void RunLinkSdk (Profile profile, AssemblyBuildTarget build_target, string configuration)
		{
			var extra_args = build_target.AsString ();
			var build = new BuildTool ()
			{
				ProjectPath = Path.Combine (Configuration.SourceRoot, "tests", "linker-ios/link sdk", "link sdk" + MTouch.GetProjectSuffix (profile) + ".csproj"),
				Config = configuration,
				Platform = "iPhone",
				Timeout = TimeSpan.FromMinutes (5),
				Properties = { { "MtouchExtraArgs", extra_args } },
			};
			build.Clean ();
			build.Build ();

			var xharness = new XHarnessTool ()
			{
				Profile = profile,
				ProjectPath = build.ProjectPath,
				Configuration = build.Config,
			};
			Assert.AreEqual (0, xharness.UninstallDevice (), "uninstall");
			Assert.AreEqual (0, xharness.InstallDevice (), "install");
			Assert.AreEqual (0, xharness.RunDevice (timeout: TimeSpan.FromMinutes (5)), "run");
		}

		[Test]
		[TestCase (Profile.iOS, AssemblyBuildTarget.StaticObject, "Debug32")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.DynamicLibrary, "Debug64")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_All, "Debug32")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk, "Debug64")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk_RestStaticObject, "Debug")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk_RestSingleFramework, "Debug32")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Single, "Debug64")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.StaticObject, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.DynamicLibrary, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_All, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk_RestStaticObject, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk_RestSingleFramework, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Single, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.StaticObject, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.DynamicLibrary, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_All, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk_RestStaticObject, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk_RestSingleFramework, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Single, "Debug")]
		public void RunLinkAll (Profile profile, AssemblyBuildTarget build_target, string configuration)
		{
			var extra_args = build_target.AsString ();
			var build = new BuildTool ()
			{
				ProjectPath = Path.Combine (Configuration.SourceRoot, "tests", "linker-ios/link all", "link all" + MTouch.GetProjectSuffix (profile) + ".csproj"),
				Config = configuration,
				Platform = "iPhone",
				Timeout = TimeSpan.FromMinutes (5),
				Properties = { { "MtouchExtraArgs", extra_args } },
			};
			build.Clean ();
			build.Build ();

			var xharness = new XHarnessTool ()
			{
				Profile = profile,
				ProjectPath = build.ProjectPath,
				Configuration = build.Config,
			};
			Assert.AreEqual (0, xharness.UninstallDevice (), "uninstall");
			Assert.AreEqual (0, xharness.InstallDevice (), "install");
			Assert.AreEqual (0, xharness.RunDevice (timeout: TimeSpan.FromMinutes (5)), "run");
		}

		[Test]
		[TestCase (Profile.iOS, AssemblyBuildTarget.StaticObject, "Debug32")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.DynamicLibrary, "Debug64")]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.StaticObject, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.DynamicLibrary, "Debug")]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.StaticObject, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.DynamicLibrary, "Debug")]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk, "Debug")]
		public void InterdependentBindingProjects (Profile profile, AssemblyBuildTarget build_target, string configuration)
		{
			var extra_args = build_target.AsString ();
			var build = new BuildTool
			{
				ProjectPath = Path.Combine (Configuration.SourceRoot, "tests", "interdependent-binding-projects", "interdependent-binding-projects" + MTouch.GetProjectSuffix (profile) + ".csproj"),
				Config = configuration,
				Platform = "iPhone",
				Timeout = TimeSpan.FromMinutes (5),
				Properties = { { "MtouchExtraArgs", extra_args } },
			};
			build.Clean ();
			build.Build ();

			var xharness = new XHarnessTool ()
			{
				Profile = profile,
				ProjectPath = build.ProjectPath,
				Configuration = build.Config,
			};
			Assert.AreEqual (0, xharness.UninstallDevice (), "uninstall");
			Assert.AreEqual (0, xharness.InstallDevice (), "install");
			Assert.AreEqual (0, xharness.RunDevice (timeout: TimeSpan.FromMinutes (5)), "run");
		}

		[Test]
		public void FatMonoFrameworkWithFatExtensionAndSimpleApp ()
		{
			var project = new ProjectFile
			{
				Architectures = Architecture.ARM64,
				ProjectType = ProjectType.iOSApp,
				ProjectReferences = new ProjectFile []
				{
					new ProjectFile
					{
						Architectures = Architecture.ARM64 | Architecture.ARMv7,
						ProjectType = ProjectType.TodayExtension,
					},
				}
			};

			project.Generate ();
			project.BuildDevice ();
			project.AssertExecutableArchitectures ();

			project.RunDevice ();
		}
	}
}
