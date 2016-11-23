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
		// debug builds have profiling enabled, release builds don't.
		// release builds have llvm enabled (debug builds haven't).
		// release builds doesn't have incremental builds enabled (some debug builds have).
		[Test]

		// standard debug build
		[TestCase (Profile.Unified, "ARMv7, ARM64", false, "--assembly-build-target=@all=staticobject", true)]
		[TestCase (Profile.TVOS, "ARM64", false, "--assembly-build-target=@all=staticobject", true)]
		[TestCase (Profile.WatchOS, "ARMv7k", false, "--assembly-build-target=@all=staticobject", true)]

		// debug build with profiling enabled
		[TestCase (Profile.Unified, "ARMv7, ARM64", true, "--assembly-build-target=@all=staticobject", true)]
		[TestCase (Profile.TVOS, "ARM64", true, "--assembly-build-target=@all=staticobject", true)]
		[TestCase (Profile.WatchOS, "ARMv7k", true, "--assembly-build-target=@all=staticobject", true)]

		// debug build building to dylibs (incremental builds) and profiling enabled.
		[TestCase (Profile.Unified, "ARMv7, ARM64", true, "--assembly-build-target=@all=dynamiclibrary", true)]
		[TestCase (Profile.TVOS, "ARM64", true, "--assembly-build-target=@all=dynamiclibrary", true)]
		[TestCase (Profile.WatchOS, "ARMv7k", true, "--assembly-build-target=@all=dynamiclibrary", true)]

		// debug build building to frameworks and profiling enabled
		[TestCase (Profile.Unified, "ARMv7, ARM64", true, "--assembly-build-target=@sdk=framework=Xamarin.Sdk --assembly-build-target=@all=framework", true)]
		[TestCase (Profile.TVOS, "ARM64", true, "--assembly-build-target=@sdk=framework=Xamarin.Sdk --assembly-build-target=@all=framework", true)]
		[TestCase (Profile.WatchOS, "ARMv7k", true, "--assembly-build-target=@sdk=framework=Xamarin.Sdk --assembly-build-target=@all=framework", true)]

		// release builds using static objects
		[TestCase (Profile.Unified, "ARMv7, ARM64", false, "--assembly-build-target=@all=staticobject", false)]
		[TestCase (Profile.TVOS, "ARM64", false, "--assembly-build-target=@all=staticobject", false)]
		[TestCase (Profile.WatchOS, "ARMv7k", false, "--assembly-build-target=@all=staticobject", false)]

		// release builds using frameworks
		[TestCase (Profile.Unified, "ARMv7, ARM64",false, "--assembly-build-target=@sdk=framework=Xamarin.Sdk --assembly-build-target=@all=framework", false)]
		[TestCase (Profile.Unified, "ARMv7", false, "--assembly-build-target=@sdk=framework=Xamarin.Sdk --assembly-build-target=@all=framework", false)] // this exposes an llvm bug (I think?). Selectors end up not being unique, causing "Selector.GetHandle" to return invalid values.
		[TestCase (Profile.TVOS, "ARM64", false, "--assembly-build-target=@sdk=framework=Xamarin.Sdk --assembly-build-target=@all=framework", false)]
		[TestCase (Profile.WatchOS, "ARMv7k", false, "--assembly-build-target=@sdk=framework=Xamarin.Sdk --assembly-build-target=@all=framework", false)]

		public void BuildTest (
			Profile profile,
			string architecture,
			bool profiling,
			string build_target,
			bool debug
		)
		{
			bool llvm = !debug;
			bool bitcode = !debug && profile != Profile.Unified;

			using (var cache = new Cache ()) {
				var dir = cache.CreateTemporaryDirectory ();
				var project = new ProjectFile ();
				project.ProjectPath = Path.Combine (dir, nameof (BuildTest) + ".csproj");
				project.Profile = profile;
				project.MTouchArch_Device = architecture;
				switch (architecture) {
				case "ARMv7, ARM64":
				case "ARMv7s,ARM64":
				case "ARMv7,ARMv7s,ARM64":
					project.MTouchArch_Simulator = "i386, x86_64";
					break;
				case "ARM64":
					project.MTouchArch_Simulator = "x86_64";
					break;
				case "ARMv7":
				case "ARMv7k":
					project.MTouchArch_Simulator = "i386";
					break;
				default:
					throw new NotImplementedException ();
				}
				project.MTouchProfiling = profiling;
				project.MTouchDebug = debug;
				project.MTouchUseLlvm = llvm;
				project.MTouchExtraArgs = build_target  + " -vvvvvv";
				project.MTouchEnableBitcode = bitcode;
				project.GenerateInfoPlist ();
				project.GenerateUnitTestProject ();

				XBuild.Build (project.ProjectPath, platform: "iPhone", verbosity: "diagnostic");

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
