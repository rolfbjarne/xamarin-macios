using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Xamarin.Bundler;

namespace Xamarin.MMP.Tests.Unit
{
	[TestFixture]
	[Parallelizable (ParallelScope.All)]
	public class AotTests
	{
		class TestFileEnumerator : IFileEnumerator
		{
			public List<Tuple<string, string>> CommandsRun { get; } = new List<Tuple<string, string>> (); 
			public IEnumerable<string> Files { get; }
			public string RootDir { get; }

			public TestFileEnumerator (IEnumerable <string> files)
			{
				Files = files;
				RootDir = Cache.CreateTemporaryDirectory ();
			}
		}

		void Compile (AOTOptions options, TestFileEnumerator files, AOTCompilerType compilerType = AOTCompilerType.Bundled64, RunCommandDelegate onRunDelegate = null, bool isRelease = false, bool isModern = false)
		{
			AOTCompiler compiler = new AOTCompiler (options, compilerType, isModern, isRelease)
			{
				RunCommand = onRunDelegate != null ? onRunDelegate : (string path, string args, string [] env, StringBuilder output, bool suppressPrintOnErrors) => {
					return OnRunCommand (path, args, env, output, suppressPrintOnErrors, files);
				},
				ParallelOptions = new ParallelOptions () { MaxDegreeOfParallelism = 1 },
				XamarinMacPrefix = Driver.WalkUpDirHierarchyLookingForLocalBuild (), // HACK - AOT test shouldn't need this from driver.cs 
			};
			compiler.Compile (files);
		}

		int OnRunCommand (string path, string args, string [] env, StringBuilder output, bool suppressPrintOnErrors, TestFileEnumerator enumerator)
		{
			enumerator.CommandsRun.Add (Tuple.Create <string, string>(path, args));
			if (path != AOTCompiler.StripCommand && path != AOTCompiler.DeleteDebugSymbolCommand) {
				Assert.IsTrue (env[0] == "MONO_PATH", "MONO_PATH should be first env set");
				Assert.IsTrue (env[1] == enumerator.RootDir, "MONO_PATH should be set to our expected value");
			}
			return 0;
		}

		string GetExpectedMonoCommand (AOTCompilerType compilerType)
		{
			switch (compilerType) {
			case AOTCompilerType.Bundled64:
				return "bmac-mobile-mono";
			case AOTCompilerType.Bundled32:
				return "bmac-mobile-mono-32";
			case AOTCompilerType.System64:
				return "mono64";
			case AOTCompilerType.System32:
				return "mono32";
			default:
				Assert.Fail ("GetMonoPath with invalid option");
				return "";
			}
		}

		List<string> GetFiledAOTed (TestFileEnumerator enumerator, AOTCompilerType compilerType = AOTCompilerType.Bundled64, AOTKind kind = AOTKind.Standard, bool isModern = false, bool expectStripping = false, bool expectSymbolDeletion = false)
		{
			List<string> filesAOTed = new List<string> (); 

			foreach (var command in enumerator.CommandsRun) {
				if (expectStripping && command.Item1 == AOTCompiler.StripCommand)
					continue;
				if (expectSymbolDeletion && command.Item1 == AOTCompiler.DeleteDebugSymbolCommand)
					continue;
				Assert.IsTrue (command.Item1.EndsWith (GetExpectedMonoCommand (compilerType), StringComparison.OrdinalIgnoreCase), "Unexpected command: " + command.Item1);
				string [] argParts = command.Item2.Split (' ');

				if (kind == AOTKind.Hybrid)
					Assert.AreEqual (argParts[0], "--aot=hybrid", "First arg should be --aot=hybrid");
				else
					Assert.AreEqual (argParts[0], "--aot", "First arg should be --aot");

				if (isModern)
					Assert.AreEqual (argParts[1], "--runtime=mobile", "Second arg should be --runtime=mobile");
				else
					Assert.AreNotEqual (argParts[1], "--runtime=mobile", "Second arg should not be --runtime=mobile");


				int fileNameBeginningIndex = command.Item2.IndexOf(' ') + 1;
				if (isModern)
					fileNameBeginningIndex = command.Item2.IndexOf(' ', fileNameBeginningIndex) + 1;

				string fileName = command.Item2.Substring (fileNameBeginningIndex).Replace ("\'", "");
				filesAOTed.Add (fileName);
			}
			return filesAOTed;
		}

		List<string> GetFilesStripped (TestFileEnumerator enumerator)
		{
			return enumerator.CommandsRun.Where (x => x.Item1 == AOTCompiler.StripCommand).Select (x => x.Item2.Replace ("\'", "")).ToList ();
		}
		
		void AssertFilesStripped (TestFileEnumerator enumerator, IEnumerable <string> expectedFiles)
		{
			List<string> filesStripped = GetFilesStripped (enumerator);

			Func<string> getErrorDetails = () => $"\n {FormatDebugList (filesStripped)} \nvs\n {FormatDebugList (expectedFiles)}\n{AllCommandsRun (enumerator)}";

			Assert.AreEqual (filesStripped.Count, expectedFiles.Count (), "Different number of files stripped than expected: " + getErrorDetails ());
			Assert.IsTrue (filesStripped.All (x => expectedFiles.Contains (x)), "Different files stripped than expected: "  + getErrorDetails ());
		}
		
		List<string> GetDeletedSymbols (TestFileEnumerator enumerator)
		{
			// Chop off -r prefix and quotes around filename
			return enumerator.CommandsRun.Where (x => x.Item1 == AOTCompiler.DeleteDebugSymbolCommand).Select (x => x.Item2.Substring(3).Replace ("\'", "")).ToList ();
		}

		string AllCommandsRun (TestFileEnumerator enumerator) => "\nCommands Run:\n\t" + String.Join ("\n\t", enumerator.CommandsRun.Select (x => $"{x.Item1} {x.Item2}"));
		string FormatDebugList (IEnumerable <string> list) => String.Join (" ", list.Select (x => "\"" + x + "\""));

		void AssertSymbolsDeleted (TestFileEnumerator enumerator, IEnumerable <string> expectedFiles)
		{
			expectedFiles = expectedFiles.Select (x => x + ".dylib.dSYM/").ToList ();
			List<string> symbolsDeleted = GetDeletedSymbols (enumerator);

			Func<string> getErrorDetails = () => $"\n {FormatDebugList (symbolsDeleted)} \nvs\n {FormatDebugList (expectedFiles)}\n{AllCommandsRun (enumerator)}";

			Assert.AreEqual (symbolsDeleted.Count, expectedFiles.Count (), "Different number of symbols deleted than expected: " + getErrorDetails ());
			Assert.IsTrue (symbolsDeleted.All (x => expectedFiles.Contains (x)), "Different files deleted than expected: "  + getErrorDetails ());
		}

		void AssertFilesAOTed (TestFileEnumerator enumerator, IEnumerable <string> expectedFiles, AOTCompilerType compilerType = AOTCompilerType.Bundled64, AOTKind kind = AOTKind.Standard, bool isModern = false, bool expectStripping = false, bool expectSymbolDeletion = false)
		{
			List<string> filesAOTed = GetFiledAOTed (enumerator, compilerType, kind, isModern: isModern, expectStripping: expectStripping, expectSymbolDeletion : expectSymbolDeletion);

			Func<string> getErrorDetails = () => $"\n {FormatDebugList (filesAOTed)} \nvs\n {FormatDebugList (expectedFiles)}\n{AllCommandsRun (enumerator)}";

			Assert.AreEqual (filesAOTed.Count, expectedFiles.Count (), "Different number of files AOT than expected: " + getErrorDetails ());
			Assert.IsTrue (filesAOTed.All (x => expectedFiles.Contains (x)), "Different files AOT than expected: "  + getErrorDetails ());
		}

		void AssertThrowErrorWithCode (Action action, int code)
		{
			try {
				action ();
			}
			catch (MonoMacException e) {
				Assert.AreEqual (e.Code, code, $"Got code {e.Code} but expected {code}");
				return;
			}
			catch (AggregateException e) {
				Assert.AreEqual (e.InnerExceptions.Count, 1, "Got AggregateException but more than one exception");
				MonoMacException innerException = e.InnerExceptions[0] as MonoMacException;
				Assert.IsNotNull (innerException, "Got AggregateException but inner not MonoMacException");
				Assert.AreEqual (innerException.Code, code, $"Got code {innerException.Code} but expected {code}");
				return;
			}
			Assert.Fail ($"We should have thrown MonoMacException with code: {code}");
		}

		readonly string [] FullAppFileList = { 
			"Foo Bar.exe", "libMonoPosixHelper.dylib", "mscorlib.dll", "Xamarin.Mac.dll", "System.dll", "System.Core.dll"
		};

		readonly string [] CoreXMFileList = { "mscorlib.dll", "Xamarin.Mac.dll", "System.dll" };
		readonly string [] SDKFileList = { "mscorlib.dll", "Xamarin.Mac.dll", "System.dll", "System.Core.dll" };

		[Test]
		public void ParsingNone_DoesNoAOT ()
		{
			var options = new AOTOptions ("none");
			Assert.IsFalse (options.IsAOT, "Parsing none should not be IsAOT");
			AssertThrowErrorWithCode (() => Compile (options, new TestFileEnumerator (FullAppFileList)), 99);
		}

		[Test]
		public void All_AOTAllFiles ()
		{
			var options = new AOTOptions ("all");
			Assert.IsTrue (options.IsAOT, "Should be IsAOT");
			var enumerator = new TestFileEnumerator (FullAppFileList);
			Compile (options, enumerator);

			var expectedFiles = FullAppFileList.Where (x => x.EndsWith (".exe", StringComparison.OrdinalIgnoreCase) || x.EndsWith (".dll", StringComparison.OrdinalIgnoreCase));
			AssertFilesAOTed (enumerator, expectedFiles);
		}

		[Test]
		public void Core_ParsingJustCoreFiles()
		{
			var options = new AOTOptions ("core");
			Assert.IsTrue (options.IsAOT, "Should be IsAOT");
			var enumerator = new TestFileEnumerator (FullAppFileList);
			Compile (options, enumerator);

			AssertFilesAOTed (enumerator, CoreXMFileList);
		}

		[Test]
		public void SDK_ParsingJustSDKFiles()
		{
			var options = new AOTOptions ("sdk");
			Assert.IsTrue (options.IsAOT, "Should be IsAOT");
			var enumerator = new TestFileEnumerator (FullAppFileList);
			Compile (options, enumerator);

			AssertFilesAOTed (enumerator, SDKFileList);
		}

		[Test]
		public void ExplicitAssembly_JustAOTExplicitFile ()
		{
			var options = new AOTOptions ("+System.dll");
			Assert.IsTrue (options.IsAOT, "Should be IsAOT");
			var enumerator = new TestFileEnumerator (FullAppFileList);
			Compile (options, enumerator);

			AssertFilesAOTed (enumerator, new string [] { "System.dll" });
		}

		[Test]
		public void CoreWithInclusionAndSubtraction ()
		{
			var options = new AOTOptions ("core,+Foo.dll,-Xamarin.Mac.dll");
			Assert.IsTrue (options.IsAOT, "Should be IsAOT");
		
			string [] testFiles = { 
				"Foo.dll", "Foo Bar.exe", "libMonoPosixHelper.dylib", "mscorlib.dll", "Xamarin.Mac.dll", "System.dll"
			};
			var enumerator = new TestFileEnumerator (testFiles);
			Compile (options, enumerator);

			AssertFilesAOTed (enumerator, new string [] { "Foo.dll", "mscorlib.dll", "System.dll" });
		}

		[Test]
		public void CoreWithFullPath_GivesFullPathCommands ()
		{
			var options = new AOTOptions ("core,-Xamarin.Mac.dll");
			Assert.IsTrue (options.IsAOT, "Should be IsAOT");
			var rootDir = Cache.CreateTemporaryDirectory ();

			var enumerator = new TestFileEnumerator (FullAppFileList.Select (x => Path.Combine (rootDir, x)));
			Compile (options, enumerator);

			AssertFilesAOTed (enumerator, new string [] { Path.Combine (rootDir, "mscorlib.dll"), Path.Combine (rootDir, "System.dll") });
		}

		[Test]
		public void ExplicitNegativeFileWithNonExistantFiles_ThrowError ()
		{
			var options = new AOTOptions ("core,-NonExistant.dll");
			Assert.IsTrue (options.IsAOT, "Should be IsAOT");

			AssertThrowErrorWithCode (() => Compile (options, new TestFileEnumerator (FullAppFileList)), 3010);
		}

		[Test]
		public void ExplicitPositiveFileWithNonExistantFiles_ThrowError ()
		{
			var options = new AOTOptions ("core,+NonExistant.dll");
			Assert.IsTrue (options.IsAOT, "Should be IsAOT");

			AssertThrowErrorWithCode (() => Compile (options, new TestFileEnumerator (FullAppFileList)), 3009);
		}

		[Test]
		public void ExplicitNegativeWithNoAssemblies_ShouldNoOp()
		{
			var options = new AOTOptions ("-System.dll");
			Assert.IsTrue (options.IsAOT, "Should be IsAOT");
			var enumerator = new TestFileEnumerator (FullAppFileList);
			Compile (options, enumerator);
			AssertFilesAOTed (enumerator, new string [] {});
		}

		[Test]
		public void ParsingSimpleOptions_InvalidOption ()
		{
			AssertThrowErrorWithCode (() => new AOTOptions ("FooBar"), 20);
		}

		[Test]
		public void AssemblyWithSpaces_ShouldAOTWithQuotes ()
		{
			var options = new AOTOptions ("+Foo Bar.dll");
			Assert.IsTrue (options.IsAOT, "Should be IsAOT");
			var enumerator = new TestFileEnumerator (new string [] { "Foo Bar.dll", "Xamarin.Mac.dll" });
			Compile (options, enumerator);
			AssertFilesAOTed (enumerator, new string [] {"Foo Bar.dll"});
			Assert.IsTrue (enumerator.CommandsRun.Where (x => x.Item2.Contains ("Foo Bar.dll")).All (x => x.Item2.EndsWith ("\'Foo Bar.dll\'", StringComparison.InvariantCulture)), "Should end with quoted filename");
		}

		[Test]
		public void WhenAOTFails_ShouldReturnError ()
		{
			RunCommandDelegate runThatErrors = (path, args, env, output, suppressPrintOnErrors) => 42;
			var options = new AOTOptions ("all");

			AssertThrowErrorWithCode (() => Compile (options, new TestFileEnumerator (FullAppFileList), onRunDelegate : runThatErrors), 3001);
		}

		[Test]
		public void DifferentMonoTypes_ShouldInvokeCorrectMono ()
		{
			foreach (var compilerType in new List<AOTCompilerType> (){ AOTCompilerType.Bundled64, AOTCompilerType.Bundled32, AOTCompilerType.System32, AOTCompilerType.System64 })
			{
				var options = new AOTOptions ("sdk");
				Assert.IsTrue (options.IsAOT, "Should be IsAOT");
				var enumerator = new TestFileEnumerator (FullAppFileList);
				Compile (options, enumerator, compilerType);

				AssertFilesAOTed (enumerator, SDKFileList, compilerType);
			}
		}

		[Test]
		public void PipeFileName_ShouldNotHybridCompiler ()
		{
			foreach (var testCase in new string [] { "+|hybrid.dll", "core,+|hybrid.dll,-Xamarin.Mac.dll" }){
				var options = new AOTOptions (testCase);
				Assert.IsTrue (options.IsAOT, "Should be IsAOT");
				Assert.IsFalse (options.IsHybridAOT, "Should not be IsHybridAOT");
				var enumerator = new TestFileEnumerator (new string [] { "|hybrid.dll", "Xamarin.Mac.dll" });
				Compile (options, enumerator);
				AssertFilesAOTed (enumerator, new string [] {"|hybrid.dll"});
			}
		}

		[Test]
		public void InvalidHybridOptions_ShouldThrow ()
		{
			AssertThrowErrorWithCode (() => new AOTOptions ("|"), 20);
			AssertThrowErrorWithCode (() => new AOTOptions ("|hybrid"), 20);
			AssertThrowErrorWithCode (() => new AOTOptions ("core|"), 20);
			AssertThrowErrorWithCode (() => new AOTOptions ("foo|hybrid"), 20);
			AssertThrowErrorWithCode (() => new AOTOptions ("core|foo"), 20);
			AssertThrowErrorWithCode (() => new AOTOptions ("|hybrid,+Foo.dll"), 20);
		}

		[Test]
		public void HybridOption_ShouldInvokeHybridCompiler ()
		{
			var options = new AOTOptions ("all|hybrid");
			Assert.IsTrue (options.IsAOT, "Should be IsAOT");
			Assert.IsTrue (options.IsHybridAOT, "Should be IsHybridAOT");
			var enumerator = new TestFileEnumerator (FullAppFileList);
			Compile (options, enumerator);

			var expectedFiles = FullAppFileList.Where (x => x.EndsWith (".exe", StringComparison.OrdinalIgnoreCase) || x.EndsWith (".dll", StringComparison.OrdinalIgnoreCase));
			AssertFilesAOTed (enumerator, expectedFiles, kind : AOTKind.Hybrid);
		}

		[Test]
		public void AllReleaseHybrid_AOTStripAndDelete ()
		{
			var options = new AOTOptions ("all|hybrid");
			var enumerator = new TestFileEnumerator (FullAppFileList);
			Compile (options, enumerator, isRelease : true);

			var expectedFiles = FullAppFileList.Where (x => x.EndsWith (".exe", StringComparison.OrdinalIgnoreCase) || x.EndsWith (".dll", StringComparison.OrdinalIgnoreCase));
			AssertFilesAOTed (enumerator, expectedFiles, kind : AOTKind.Hybrid, expectStripping : true, expectSymbolDeletion : true);
			AssertFilesStripped (enumerator, expectedFiles);
			AssertSymbolsDeleted (enumerator, expectedFiles);
		}

		[Test]
		public void AllReleaseNonHybrid_ShouldNotStripButDelete ()
		{
			var options = new AOTOptions ("all");
			var enumerator = new TestFileEnumerator (FullAppFileList);
			Compile (options, enumerator, isRelease : true);

			var expectedFiles = FullAppFileList.Where (x => x.EndsWith (".exe", StringComparison.OrdinalIgnoreCase) || x.EndsWith (".dll", StringComparison.OrdinalIgnoreCase));
			AssertFilesAOTed (enumerator, expectedFiles, expectStripping : false, expectSymbolDeletion : true);
			AssertFilesStripped (enumerator, new string [] {});
			AssertSymbolsDeleted (enumerator, expectedFiles);
		}

		[Test]
		public void AssemblyWithSpaces_ShouldStripWithQuotes ()
		{
			var options = new AOTOptions ("all|hybrid,+Foo Bar.dll");

			var files = new string [] { "Foo Bar.dll", "Xamarin.Mac.dll" };
			var enumerator = new TestFileEnumerator (files);
			Compile (options, enumerator, isRelease : true);
			AssertFilesStripped (enumerator, files);
			AssertSymbolsDeleted (enumerator, files);
			// We don't check end quote here, since we might have .dylib.dSYM suffix
			Assert.IsTrue (enumerator.CommandsRun.Where (x => x.Item2.Contains ("Foo Bar.dll")).All (x => x.Item2.Contains ("\'Foo Bar.dll")), "Should contain quoted filename");
		}

		[Test]
		public void WhenAssemblyStrippingFails_ShouldThrowError ()
		{
			RunCommandDelegate runThatErrors = (path, args, env, output, suppressPrintOnErrors) => path.Contains ("mono-cil-strip") ? 42 : 0;

			var options = new AOTOptions ("all|hybrid");

			AssertThrowErrorWithCode (() => Compile (options, new TestFileEnumerator (FullAppFileList), onRunDelegate : runThatErrors, isRelease : true), 3001);
		}

		[Test]
		public void HybridOption_MustAlsoHaveAll_ThrowsIfNot ()
		{
			AssertThrowErrorWithCode (() => new AOTOptions ("core|hybrid"), 114);
			AssertThrowErrorWithCode (() => new AOTOptions ("sdk|hybrid"), 114);
			var options = new AOTOptions ("all|hybrid");
		}

		[Test]
		public void All_AOTAllFiles_Modern ()
		{
			var options = new AOTOptions ("all");
			Assert.IsTrue (options.IsAOT, "Should be IsAOT");
			var enumerator = new TestFileEnumerator (FullAppFileList);
			Compile (options, enumerator, isModern : true);

			var expectedFiles = FullAppFileList.Where (x => x.EndsWith (".exe", StringComparison.OrdinalIgnoreCase) || x.EndsWith (".dll", StringComparison.OrdinalIgnoreCase));
			AssertFilesAOTed (enumerator, expectedFiles, isModern : true);
		}
	}
}
