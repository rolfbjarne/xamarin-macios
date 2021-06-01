using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using Microsoft.Build.Utilities;

using NUnit.Framework;

using Xamarin.iOS.Tasks;
using Xamarin.Tests;

namespace Xamarin.MacDev.Tasks {
	[TestFixture]
	public class MergeAppBundleTaskTest : TestBase {
		[OneTimeSetUp]
		public void SetUp ()
		{
			var rv = ExecutionHelper.Execute ("make", new string [] { "-C", Path.Combine (Configuration.RootPath, "tests", "test-libraries"), "-j8" }, out var output, TimeSpan.FromSeconds (30));
			Console.WriteLine (output);
			Assert.AreEqual (0, rv, "make test-libraries");
		}

		MergeAppBundles CreateTask (string outputBundle, params string[] inputBundles)
		{
			var task = CreateTask<MergeAppBundles> ();
			task.InputAppBundles = inputBundles.Select (v => new TaskItem (v)).ToArray ();
			task.OutputAppBundle = outputBundle;
			return task;
		}

		// Create two app bundles, one with fileA, and one with fileB, in the root directory
		string[] CreateAppBundle (string fileA, string fileB, string fileName = null)
		{
			var appBundleA = Path.Combine (Cache.CreateTemporaryDirectory (), "MergeMe.app");
			var appBundleB = Path.Combine (Cache.CreateTemporaryDirectory (), "MergeMe.app");
			Directory.CreateDirectory (appBundleA);
			Directory.CreateDirectory (appBundleB);
			File.Copy (fileA, Path.Combine (appBundleA, fileName ?? Path.GetFileName (fileA)));
			File.Copy (fileB, Path.Combine (appBundleB, fileName ?? Path.GetFileName (fileB)));
			return new string [] { appBundleA, appBundleB };
		}

		[Test]
		public void TestLipoExecutable ()
		{
			var fileA = Path.Combine (Configuration.RootPath, "tests", "test-libraries", ".libs", "macos", "libtest.arm64.dylib");
			var fileB = Path.Combine (Configuration.RootPath, "tests", "test-libraries", ".libs", "macos", "libtest.x86_64.dylib");
			var bundles = CreateAppBundle (fileA, fileB, "libtest.dylib");

			var outputBundle = Path.Combine (Cache.CreateTemporaryDirectory (), "Merged.app");
			var task = CreateTask (outputBundle, bundles);
			task.Execute ();

			// The bundle should only contain a single file.
			Assert.AreEqual (1, Directory.GetFileSystemEntries (outputBundle).Length, "Files in bundle");

			// The resulting dylib should contain 2 architectures.
			var fatLibrary = Path.Combine (outputBundle, "libtest.dylib");
			Assert.That (fatLibrary, Does.Exist, "Existence");
			var machO = MachO.Read (fatLibrary).ToArray ();
			Assert.AreEqual (2, machO.Length, "Architecture Count");
		}
	}
}
