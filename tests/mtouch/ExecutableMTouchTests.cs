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
