using System;
using System.IO;
using NUnit.Framework;

using Xamarin.Tests;

namespace GeneratorTests
{
	[TestFixture ()]
	[Parallelizable (ParallelScope.All)]
	public class BGenTests
	{
		[Test]
		public void BMac_Smoke ()
		{
			var bgen = new BGenTool ();
			bgen.Profile = Profile.macClassic;
			bgen.CreateTemporaryBinding (File.ReadAllText (Path.Combine (Configuration.SourceRoot, "tests", "generator", "bmac_smoke.cs")));
			bgen.AssertExecute ("build");
			bgen.AssertNoWarnings ();
		}

		[Test]
		public void BMac_With_Hyphen_In_Name ()
		{
			var bgen = new BGenTool ();
			bgen.Profile = Profile.macClassic;
			bgen.CreateTemporaryBinding (File.ReadAllText (Path.Combine (Configuration.SourceRoot, "tests", "generator", "bmac-with-hyphen-in-name.cs")));
			bgen.AssertExecute ("build");
			bgen.AssertNoWarnings ();
		}
	}
}
