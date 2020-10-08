using System;
using System.IO;
using NUnit.Framework;

using Xamarin.Tests;

namespace Xamarin.MacDev.Tasks {
	public class BindingReferences : TestBase {

		[Test]
		public void BuildTest ()
		{
			var mtouchPathsLibraryA = SetupProjectPaths ("MyBindingsReferences/LibraryA", includePlatform: false);
			var mtouchPathsLibraryB = SetupProjectPaths ("MyBindingsReferences/LibraryB", includePlatform: false);

			var dllAPath = Path.Combine (mtouchPathsLibraryA.ProjectBinPath, "LibraryA.dll");

			RunTarget (mtouchPathsLibraryA, "Build", 0);
			Assert.IsTrue (File.Exists (dllAPath), "LibraryA dll does not exist: {0} ", dllAPath);

			var dllBPath = Path.Combine (mtouchPathsLibraryB.ProjectBinPath, "LibraryB.dll");

			RunTarget (mtouchPathsLibraryB, "Build", 0);
			Assert.IsTrue (File.Exists (dllBPath), "LibraryB binding dll does not exist: {0} ", dllBPath);
		}

		// https://bugzilla.xamarin.com/show_bug.cgi?id=56317
		[Test]
		public void SatelliteAssembliesBug ()
		{
			var mtouchPaths = SetupProjectPaths ("MySatelliteAssembliesBug/iOSBinding", includePlatform: false);

			var dll = Path.Combine (mtouchPaths.ProjectBinPath, "iOSBinding.dll");

			RunTarget (mtouchPaths, "Build", 0);
			Assert.IsTrue (File.Exists (dll), "iOSBinding dll does not exist: {0} ", dll);
		}

		public override void Setup ()
		{
			SetupEngine ();
		}
	}
}
