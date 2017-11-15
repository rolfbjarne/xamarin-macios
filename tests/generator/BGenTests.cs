﻿using System;
using System.IO;
using System.Linq;

using NUnit.Framework;

using Xamarin.Tests;

namespace GeneratorTests
{
	[TestFixture ()]
	[Parallelizable (ParallelScope.All)]
	public class BGenTests
	{
		[Test]
		[TestCase (Profile.macClassic)]
		[TestCase (Profile.macFull)]
		[TestCase (Profile.macModern)]
		public void BMac_Smoke (Profile profile)
		{
			BuildFile (profile, "bmac_smoke.cs");
		}

		[Test]
		[TestCase (Profile.macClassic)]
		[TestCase (Profile.macFull)]
		[TestCase (Profile.macModern)]
		public void BMac_With_Hyphen_In_Name (Profile profile)
		{
			BuildFile (profile, "bmac-with-hyphen-in-name.cs");
		}

		[Test]
		[TestCase (Profile.macClassic)]
		[TestCase (Profile.macFull)]
		[TestCase (Profile.macModern)]
		public void PropertyRedefinitionMac (Profile profile)
		{
			BuildFile (profile, "property-redefination-mac.cs");
		}

		[Test]
		[TestCase (Profile.macClassic)]
		[TestCase (Profile.macFull)]
		[TestCase (Profile.macModern)]
		public void NSApplicationPublicEnsureMethods (Profile profile)
		{
			BuildFile (profile, "NSApplicationPublicEnsureMethods.cs");
		}

		[Test]
		[TestCase (Profile.macClassic)]
		[TestCase (Profile.macFull)]
		[TestCase (Profile.macModern)]
		public void ProtocolDuplicateAbstract (Profile profile)
		{
			BuildFile (profile, "protocol-duplicate-abstract.cs");
		}

		[Test]
		public void Bug15283 ()
		{
			BuildFile (Profile.iOS, "bug15283.cs");
		}

		[Test]
		public void Bug15307 ()
		{
			BuildFile (Profile.iOS, "bug15307.cs");
		}

		[Test]
		public void Bug15799 ()
		{
			BuildFile (Profile.iOS, "bug15799.cs");
		}

		[Test]
		public void Bug16036 ()
		{
			BuildFile (Profile.iOS, "bug16036.cs");
		}

		[Test]
		public void Bug17232 ()
		{
			BuildFile (Profile.iOS, "bug17232.cs");
		}

		[Test]
		public void Bug23041 ()
		{
			BuildFile (Profile.iOS, "bug23041.cs");
		}

		[Test]
		public void Bug24078 ()
		{
			BuildFile (Profile.iOS, "bug24078-ignore-methods-events.cs");
		}

		[Test]
		public void Bug27428 ()
		{
			BuildFile (Profile.iOS, "bug27428.cs");
		}

		[Test]
		public void Bug27430 ()
		{
			BuildFile (Profile.iOS, "bug27430.cs");
		}

		[Test]
		public void Bug31788 ()
		{
			var bgen = new BGenTool ();
			bgen.Profile = Profile.macClassic;
			bgen.Defines = BGenTool.GetDefaultDefines (bgen.Profile);
			bgen.CreateTemporaryBinding (File.ReadAllText (Path.Combine (Configuration.SourceRoot, "tests", "generator", "bug31788.cs")));
			bgen.AssertExecute ("build");
			bgen.AssertNoWarnings ();

			bgen.AssertApiCallsMethod ("Test", "MarshalInProperty", "get_Shared", "xamarin_IntPtr_objc_msgSend", "MarshalInProperty.Shared getter");
			bgen.AssertApiCallsMethod ("Test", "MarshalOnProperty", "get_Shared", "xamarin_IntPtr_objc_msgSend", "MarshalOnProperty.Shared getter");
		}

		[Test]
		public void Bug34042 ()
		{
			BuildFile (Profile.iOS, "bug34042.cs");
		}

		[Test]
		public void Bug36457 ()
		{
			BuildFile (Profile.iOS, "bug36457.cs");
		}

		[Test]
		public void Bug39614 ()
		{
			BuildFile (Profile.iOS, "bug39614.cs");
		}

		[Test]
		public void Bug40282 ()
		{
			BuildFile (Profile.iOS, "bug40282.cs");
		}

		[Test]
		public void Bug43579 ()
		{
			BuildFile (Profile.iOS, "bug43579.cs");
		}

		[Test]
		public void StackOverflow20696157 ()
		{
			BuildFile (Profile.iOS, "sof20696157.cs");
		}

		[Test]
		public void HyphenInName ()
		{
			BuildFile (Profile.iOS, "btouch-with-hyphen-in-name.cs");
		}

		[Test]
		public void PropertyRedefinition ()
		{
			BuildFile (Profile.iOS, "property-redefination-ios.cs");
		}

		[Test]
		public void ArrayFromHandleBug ()
		{
			BuildFile (Profile.iOS, "arrayfromhandlebug.cs");
		}

		[Test]
		public void StrongDictSupportTemplatedDicts ()
		{
			BuildFile (Profile.iOS, "strong-dict-support-templated-dicts.cs");
		}

		[Test]
		[Ignore ("Fails with: api.cs(10,17): error CS0246: The type or namespace name `CBUUID' could not be found. Are you missing `CoreBluetooth' using directive?")]
		public void GenericStrongDictionary ()
		{
			BuildFile (Profile.iOS, "generic-strong-dictionary.cs");
		}

		[Test]
		public void BindAsTests ()
		{
			BuildFile (Profile.iOS, "bindastests.cs");
		}

		void BuildFile (Profile profile, string filename)
		{
			var bgen = new BGenTool ();
			bgen.Profile = profile;
			bgen.Defines = BGenTool.GetDefaultDefines (bgen.Profile);
			bgen.CreateTemporaryBinding (File.ReadAllText (Path.Combine (Configuration.SourceRoot, "tests", "generator", filename)));
			bgen.AssertExecute ("build");
			bgen.AssertNoWarnings ();
		}
	}
}
