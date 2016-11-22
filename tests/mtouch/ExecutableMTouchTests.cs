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
	[TestFixture]
	public partial class MTouch
	{

		// test reduction criteria:
		// iOS builds are fat, since tvOS/watchOS won't be (i.e. tvOS/watchOS tests single-arch, iOS multi-arch).
		// debug builds have profiling enabled, release builds doesn't.
		// release builds have llvm enabled.
		// release builds doesn't have incremental builds enabled
		[Test]

		// standard debug build
		[TestCase (Profile.Unified, "armv7,arm64", false, "--assembly-build-target=@all=staticobject", true)]
		[TestCase (Profile.TVOS, "arm64", false, "--assembly-build-target=@all=staticobject", true)]
		[TestCase (Profile.WatchOS, "arm7k", false, "--assembly-build-target=@all=staticobject", true)]

		// debug build with profiling enabled
		[TestCase (Profile.Unified, "armv7,arm64", true, "--assembly-build-target=@all=staticobject", true)]
		[TestCase (Profile.TVOS, "arm64", true, "--assembly-build-target=@all=staticobject", true)]
		[TestCase (Profile.WatchOS, "armv7k", true, "--assembly-build-target=@all=staticobject", true)]

		// debug build building to dylibs (incremental builds) and profiling enabled.
		[TestCase (Profile.Unified, "armv7,arm64", true, "--assembly-build-target=@all=dynamiclibrary", true)]
		[TestCase (Profile.TVOS, "arm64", true, "--assembly-build-target=@all=dynamiclibrary", true)]
		[TestCase (Profile.WatchOS, "armv7k", true, "--assembly-build-target=@all=dynamiclibrary", true)]

		// debug build building to frameworks and profiling enabled
		[TestCase (Profile.Unified, "armv7,arm64", true, "--assembly-build-target=@sdk=framework=Xamarin.Sdk --assembly-build-target=@rest=framework", true)]
		[TestCase (Profile.TVOS, "arm64", true, "--assembly-build-target=@sdk=framework=Xamarin.Sdk --assembly-build-target=@rest=framework", true)]
		[TestCase (Profile.WatchOS, "armv7k", true, "--assembly-build-target=@sdk=framework=Xamarin.Sdk --assembly-build-target=@rest=framework", true)]

		// release builds using static objects
		[TestCase (Profile.Unified, "armv7,arm64", false, "--assembly-build-target=@all=staticobject", false)]
		[TestCase (Profile.TVOS, "arm64", false, "--assembly-build-target=@all=staticobject", false)]
		[TestCase (Profile.WatchOS, "armv7k", false, "--assembly-build-target=@all=staticobject", false)]

		// release builds using frameworks
		[TestCase (Profile.Unified, "armv7,arm64",false, "--assembly-build-target=@sdk=framework=Xamarin.Sdk --assembly-build-target=@rest=framework", false)]
		[TestCase (Profile.TVOS, "arm64", false, "--assembly-build-target=@sdk=framework=Xamarin.Sdk --assembly-build-target=@rest=framework", false)]
		[TestCase (Profile.WatchOS, "armv7k", false, "--assembly-build-target=@sdk=framework=Xamarin.Sdk --assembly-build-target=@rest=framework", false)]

		public void BuildTest (
			Profile profile,
			string architecture,
			bool profiling,
			string build_target,
			bool debug
		)
		{
			bool llvm = !debug;

			using (var cache = new Cache ()) {
				var dir = cache.CreateTemporaryDirectory ();
				var project = new ProjectFile ();
				project.ProjectPath = Path.Combine (dir, nameof (BuildTest) + ".csproj");
				project.Profile = profile;
				project.MTouchArch_Device = architecture;
				switch (profile) {
				case Profile.Unified:
					project.MTouchArch_Simulator = "i386,x86_64";
					break;
				case Profile.TVOS:
					project.MTouchArch_Simulator = "x86_64";
					break;
				case Profile.WatchOS:
					project.MTouchArch_Simulator = "i386";
					break;
				default:
					throw new NotImplementedException ();
				}
				project.MTouchProfiling = profiling;
				project.MTouchDebug = debug;
				project.MTouchUseLlvm = llvm;
				project.MTouchExtraArgs = build_target;
				project.GenerateInfoPlist ();
				project.GenerateUnitTestProject ();

				XBuild.Build (project.ProjectPath, platform: "iPhone");

				using (var xharness = new XHarnessTool ()) {
					xharness.Configuration = "Debug";
					xharness.LogDirectory = cache.CreateTemporaryDirectory ();
					switch (profile) {
					case Profile.Unified:
						xharness.Target = "ios-device";
						break;
					case Profile.TVOS:
						xharness.Target = "tvos-device";
						break;
					case Profile.WatchOS:
						xharness.Target = "watchos-device";
						break;
					default:
						throw new NotImplementedException ();
					}
					xharness.Verbose = true;
					Assert.AreEqual (0, xharness.Install (project.ProjectPath), "run");
					Assert.AreEqual (0, xharness.Run (project.ProjectPath), "run");
				}
			}
		}
		                       

		[Test]
		[TestCase (Profile.Unified, true)]
		[TestCase (Profile.Unified, false)]
		public void ExecutableFastDev (Profile profile, bool fastdev)
		{
			using (var cache = new Cache ()) {
				var dir = cache.CreateTemporaryDirectory ();
				var project = new ProjectFile ();
				project.ProjectPath = Path.Combine (dir, nameof (ExecutableFastDev) + ".csproj");
				project.Profile = profile;
				project.MTouchArch_Device = "ARM64";
				project.MTouchArch_Simulator = "x86_64";
				project.GenerateInfoPlist ();
				project.GenerateUnitTestProject ();

				XBuild.Build (project.ProjectPath, platform: "iPhoneSimulator");

				using (var xharness = new XHarnessTool ()) {
					xharness.Configuration = "Debug";
					xharness.LogDirectory = cache.CreateTemporaryDirectory ();
					xharness.Target = "ios-simulator-64";
					Assert.AreEqual (0, xharness.Run (project.ProjectPath), "run");
				}
			}
		}
	}
}
