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
			var env = new Dictionary<string, string> {
				{ "MSBUILD_EXE_PATH", null }, // Comes from VSMac (when running tests from inside the IDE), and it confuses 'dotnet build', so remove it.
			};

			Assert.AreEqual (0, ExecutionHelper.Execute ("make",
				new string [] { "-C", Path.Combine (Configuration.RootPath, "tests", "test-libraries"), "-j8" },
				output: out var _,
				working_directory: null,
				timeout: TimeSpan.FromSeconds (30),
				environment_variables: env));

			Assert.AreEqual (0, ExecutionHelper.Execute ("make",
				new string [] { "-C", Path.Combine (Configuration.RootPath, "tests", "common", "TestProjects", "ComplexAssembly"), "-j8", "V=1" },
				output: out var output,
				working_directory: null,
				timeout: TimeSpan.FromSeconds (30),
				environment_variables: env));
		}

		MergeAppBundles CreateTask (string outputBundle, params string[] inputBundles)
		{
			var inputItems = new List<TaskItem> ();
			for (var i = 0; i < inputBundles.Length; i++) {
				var item = new TaskItem (inputBundles [i]);
				item.SetMetadata ("SpecificSubdirectory", $"SubDir{i + 1}");
				inputItems.Add (item);
			}
			var task = CreateTask<MergeAppBundles> ();
			task.InputAppBundles = inputItems.ToArray ();
			task.OutputAppBundle = outputBundle;
			return task;
		}

		// Create two app bundles, one with fileA, and one with fileB, in the root directory
		string[] CreateAppBundles (string fileA, string fileB, string fileName = null)
		{
			var appBundleA = Path.Combine (Cache.CreateTemporaryDirectory (), "MergeMe.app");
			var appBundleB = Path.Combine (Cache.CreateTemporaryDirectory (), "MergeMe.app");
			Directory.CreateDirectory (appBundleA);
			Directory.CreateDirectory (appBundleB);
			File.Copy (fileA, Path.Combine (appBundleA, fileName ?? Path.GetFileName (fileA)));
			File.Copy (fileB, Path.Combine (appBundleB, fileName ?? Path.GetFileName (fileB)));
			return new string [] { appBundleA, appBundleB };
		}

		string CreateAppBundle (string directory, params string[] files)
		{
			var appBundle = Path.Combine (Cache.CreateTemporaryDirectory (), "MergeMe.app");
			Directory.CreateDirectory (appBundle);
			foreach (var file in files) {
				var inputPath = Path.Combine (directory, file);
				var outputPath = Path.Combine (appBundle, file);
				Directory.CreateDirectory (Path.GetDirectoryName (outputPath));
				File.Copy (inputPath, outputPath, true);
			}
			return appBundle;
		}

		[Test]
		public void TestLipoExecutable ()
		{
			var fileA = Path.Combine (Configuration.RootPath, "tests", "test-libraries", ".libs", "macos", "libtest.arm64.dylib");
			var fileB = Path.Combine (Configuration.RootPath, "tests", "test-libraries", ".libs", "macos", "libtest.x86_64.dylib");
			var bundles = CreateAppBundles (fileA, fileB, "libtest.dylib");

			var outputBundle = Path.Combine (Cache.CreateTemporaryDirectory (), "Merged.app");
			var task = CreateTask (outputBundle, bundles);
			Assert.IsTrue (task.Execute (), "Task execution");

			// The bundle should only contain a single file.
			Assert.AreEqual (1, Directory.GetFileSystemEntries (outputBundle).Length, "Files in bundle");

			// The resulting dylib should contain 2 architectures.
			var fatLibrary = Path.Combine (outputBundle, "libtest.dylib");
			Assert.That (fatLibrary, Does.Exist, "Existence");
			var machO = MachO.Read (fatLibrary).ToArray ();
			Assert.AreEqual (2, machO.Length, "Architecture Count");
		}

		[Test]
		public void TestPEAssembly ()
		{
			var complexAssemblyPath = Path.Combine (Configuration.RootPath, "tests", "common", "TestProjects", "ComplexAssembly", "bin", "Debug", "net6.0");
			var complexFiles = new string [] {
				"ComplexAssembly.dll",
				"ComplexAssembly.pdb",
				"ComplexAssembly.dll.config",
				"de/ComplexAssembly.resources.dll",
				"en-AU/ComplexAssembly.resources.dll",
				"es/ComplexAssembly.resources.dll",
			};
			var appA = CreateAppBundle (complexAssemblyPath, complexFiles);
			var appB = CreateAppBundle (complexAssemblyPath, complexFiles);
			var bundles = new string [] { appA, appB };

			var outputBundle = Path.Combine (Cache.CreateTemporaryDirectory (), "Merged.app");
			var task = CreateTask (outputBundle, bundles);
			Assert.IsTrue (task.Execute (), "Task execution");

			// The bundle should have all the files
			Assert.AreEqual (complexFiles.Length, Directory.GetFileSystemEntries (outputBundle).Length, "Files in bundle");

			// with the same structure
			foreach (var file in complexFiles)
				Assert.That (Path.Combine (outputBundle, file), Does.Exist, $"File existence");
		}

		[Test]
		public void TestDifferentOtherFiles ()
		{
			var tmpDir = Cache.CreateTemporaryDirectory ();
			var fileA = Path.Combine (tmpDir, "A.txt");
			var fileB = Path.Combine (tmpDir, "B.txt");
			File.WriteAllText (fileA, "A");
			File.WriteAllText (fileB, "B");
			var bundles = CreateAppBundles (fileA, fileB, "Something.txt");

			var outputBundle = Path.Combine (Cache.CreateTemporaryDirectory (), "Merged.app");
			var task = CreateTask (outputBundle, bundles);
			Assert.IsFalse (task.Execute (), "Task execution");
			Assert.AreEqual (1, Engine.Logger.ErrorEvents.Count, "Errors");
			Assert.AreEqual ("Message", Engine.Logger.ErrorEvents [0].Message, "Error message");
		}

	}
}
