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
	}

	[TestFixture]
	public partial class AAAMTouch
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
				project.MTouchExtraArgs = BuildTarget.AsString () + " -vvvvvv --dot";
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
						};

						app_project.AddProjectReference (ext_project);
						project.AddProjectReference (app_project);
						break;
					case ProjectType.TodayExtension:
						project.AddProjectReference (ext_project);
						break;
					default:
						throw new NotImplementedException ();
					}
				}
				return project;
			}

			public void AssertFrameworkArchitectures ()
			{
				project.TargetDirectory
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
			project.RunDevice ();
		}

		[Test]
		[TestCase (Profile.iOS, AssemblyBuildTarget.StaticObject)]
		[TestCase (Profile.iOS, AssemblyBuildTarget.DynamicLibrary)]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_All)]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk)]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk_RestStaticObject)]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk_RestSingleFramework)]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Single)]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.StaticObject)]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.DynamicLibrary)]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_All)]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk)]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk_RestStaticObject)]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk_RestSingleFramework)]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Single)]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.StaticObject)]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.DynamicLibrary)]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_All)]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk)]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk_RestStaticObject)]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk_RestSingleFramework)]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Single)]
		public void RunMonoTouchTest (Profile profile, AssemblyBuildTarget build_target)
		{
			var extra_args = build_target.AsString () + " -vvvvvvvvvv";
			var build = new BuildTool ()
			{
				ProjectPath = Path.Combine (Configuration.SourceRoot, "tests", "monotouch-test", "monotouch-test" + MTouch.GetProjectSuffix (profile) + ".csproj"),
				Config = "Debug",
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
			Assert.AreEqual (0, xharness.InstallDevice (timeout: TimeSpan.FromMinutes (1)), "install");
			Assert.AreEqual (0, xharness.RunDevice (timeout: TimeSpan.FromMinutes (5)), "run");
		}

		[Test]
		[TestCase (Profile.iOS, AssemblyBuildTarget.StaticObject)]
		[TestCase (Profile.iOS, AssemblyBuildTarget.DynamicLibrary)]
		[TestCase (Profile.iOS, AssemblyBuildTarget.Framework_Sdk)]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.StaticObject)]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.DynamicLibrary)]
		[TestCase (Profile.tvOS, AssemblyBuildTarget.Framework_Sdk)]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.StaticObject)]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.DynamicLibrary)]
		[TestCase (Profile.watchOS, AssemblyBuildTarget.Framework_Sdk)]
		public void InterdependentBindingProjects (Profile profile, AssemblyBuildTarget build_target)
		{
			var extra_args = build_target.AsString () + " -vvvvvvvvvv --dot";
			var build = new BuildTool
			{
				ProjectPath = Path.Combine (Configuration.SourceRoot, "tests", "interdependent-binding-projects", "interdependent-binding-projects" + MTouch.GetProjectSuffix (profile) + ".csproj"),
				Config = "Debug",
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
	}
}
