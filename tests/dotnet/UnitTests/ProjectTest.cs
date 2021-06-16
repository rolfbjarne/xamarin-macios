using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Mono.Cecil;

using NUnit.Framework;

using Xamarin.Utils;
using Xamarin.Tests;
using Xamarin.MacDev;

namespace Xamarin.Tests {
	[TestFixture]
	public class DotNetProjectTest {
		Dictionary<string, string> verbosity = new Dictionary<string, string> {
			{ "MtouchExtraArgs", "-v" },
			{ "MonoBundlingExtraArgs", "-v" },
		};

		string GetProjectPath (string project, string subdir = null, ApplePlatform? platform = null)
		{
			var project_dir = Path.Combine (Configuration.SourceRoot, "tests", "dotnet", project);
			if (!string.IsNullOrEmpty (subdir))
				project_dir = Path.Combine (project_dir, subdir);

			if (platform.HasValue)
				project_dir = Path.Combine (project_dir, platform.Value.AsString ());

			var project_path = Path.Combine (project_dir, project + ".csproj");
			if (!File.Exists (project_path))
				project_path = Path.ChangeExtension (project_path, "sln");

			if (!File.Exists (project_path))
				throw new FileNotFoundException ($"Could not find the project or solution {project} - {project_path} does not exist.");

			return project_path;
		}

		void Clean (string project_path)
		{
			var dirs = Directory.GetDirectories (Path.GetDirectoryName (project_path), "*", SearchOption.AllDirectories);
			dirs = dirs.OrderBy (v => v.Length).Reverse ().ToArray (); // If we have nested directories, make sure to delete the nested one first
			foreach (var dir in dirs) {
				var name = Path.GetFileName (dir);
				if (name != "bin" && name != "obj")
					continue;
				Directory.Delete (dir, true);
			}
		}

		[Test]
		[TestCase (null)]
		[TestCase ("iossimulator-x86")]
		[TestCase ("iossimulator-x64")]
		[TestCase ("ios-arm64")]
		[TestCase ("ios-arm")]
		public void BuildMySingleView (string runtimeIdentifier)
		{
			var platform = ApplePlatform.iOS;
			var project_path = GetProjectPath ("MySingleView");
			Configuration.IgnoreIfIgnoredPlatform (platform);
			Clean (project_path);
			var properties = new Dictionary<string, string> (verbosity);
			if (!string.IsNullOrEmpty (runtimeIdentifier)) {
				properties ["RuntimeIdentifier"] = runtimeIdentifier;
			} else {
				runtimeIdentifier = "iossimulator-x64"; // default RID for iOS projects. We set it here to make the rest of the test know where to expect files to be.
			}
			var result = DotNet.AssertBuild (project_path, properties);
			AssertThatLinkerExecuted (result);
			var appPath = Path.Combine (Path.GetDirectoryName (project_path), "bin", "Debug", "net6.0-ios", runtimeIdentifier, "MySingleView.app");
			AssertAppContents (platform, appPath);
			var infoPlistPath = Path.Combine (appPath, "Info.plist");
			var infoPlist = PDictionary.FromFile (infoPlistPath);
			Assert.AreEqual ("com.xamarin.mysingletitle", infoPlist.GetString ("CFBundleIdentifier").Value, "CFBundleIdentifier");
			Assert.AreEqual ("MySingleTitle", infoPlist.GetString ("CFBundleDisplayName").Value, "CFBundleDisplayName");
			Assert.AreEqual ("3.14", infoPlist.GetString ("CFBundleVersion").Value, "CFBundleVersion");
			Assert.AreEqual ("3.14", infoPlist.GetString ("CFBundleShortVersionString").Value, "CFBundleShortVersionString");
		}

		[Test]
		[TestCase (null)]
		[TestCase ("osx-x64")]
		[TestCase ("osx-arm64")]
		public void BuildMyCocoaApp (string runtimeIdentifier)
		{
			var platform = ApplePlatform.MacOSX;
			var project_path = GetProjectPath ("MyCocoaApp");
			Configuration.IgnoreIfIgnoredPlatform (platform);
			Clean (project_path);
			var properties = new Dictionary<string, string> (verbosity);
			if (!string.IsNullOrEmpty (runtimeIdentifier)) {
				properties ["RuntimeIdentifier"] = runtimeIdentifier;
			} else {
				runtimeIdentifier = "osx-x64"; // default RID for macOS projects. We set it here to make the rest of the test know where to expect files to be.
			}
			var result = DotNet.AssertBuild (project_path, properties);
			AssertThatLinkerExecuted (result);
			AssertAppContents (platform, Path.Combine (Path.GetDirectoryName (project_path), "bin", "Debug", "net6.0-macos", runtimeIdentifier, "MyCocoaApp.app"));
		}

		[Test]
		[TestCase (null)]
		[TestCase ("tvossimulator-x64")]
		[TestCase ("tvos-arm64")]
		public void BuildMyTVApp (string runtimeIdentifier)
		{
			var platform = ApplePlatform.TVOS;
			var project_path = GetProjectPath ("MyTVApp");
			Configuration.IgnoreIfIgnoredPlatform (platform);
			Clean (project_path);
			var properties = new Dictionary<string, string> (verbosity);
			if (!string.IsNullOrEmpty (runtimeIdentifier)) {
				properties ["RuntimeIdentifier"] = runtimeIdentifier;
			} else {
				runtimeIdentifier = "tvossimulator-x64"; // default RID for tvOS projects. We set it here to make the rest of the test know where to expect files to be.
			}
			var result = DotNet.AssertBuild (project_path, properties);
			AssertThatLinkerExecuted (result);
			AssertAppContents (platform, Path.Combine (Path.GetDirectoryName (project_path), "bin", "Debug", "net6.0-tvos", runtimeIdentifier, "MyTVApp.app"));
		}

		[Test]
		[Ignore ("watchOS not supported on net6")]
		public void BuildMyWatchApp ()
		{
			Configuration.IgnoreIfIgnoredPlatform (ApplePlatform.WatchOS);
			var project_path = GetProjectPath ("MyWatchApp");
			Clean (project_path);
			var result = DotNet.AssertBuildFailure (project_path, verbosity);
			Assert.That (result.StandardOutput.ToString (), Does.Contain ("The specified RuntimeIdentifier 'watchos-x86' is not recognized."), "Missing runtime pack for watchOS");
		}

		[Test]
		[TestCase (null)]
		[TestCase ("maccatalyst-x64")]
		[TestCase ("maccatalyst-arm64")]
		public void BuildMyCatalystApp (string runtimeIdentifier)
		{
			var platform = ApplePlatform.MacCatalyst;
			var project_path = GetProjectPath ("MyCatalystApp");
			Configuration.IgnoreIfIgnoredPlatform (platform);
			Clean (project_path);
			var properties = new Dictionary<string, string> (verbosity);
			if (!string.IsNullOrEmpty (runtimeIdentifier)) {
				properties ["RuntimeIdentifier"] = runtimeIdentifier;
			} else {
				runtimeIdentifier = "maccatalyst-x64"; // default RID for Mac Catalyst projects. We set it here to make the rest of the test know where to expect files to be.
			}
			var result = DotNet.AssertBuild (project_path, properties);
			AssertThatLinkerExecuted (result);
			var appPath = Path.Combine (Path.GetDirectoryName (project_path), "bin", "Debug", "net6.0-maccatalyst", runtimeIdentifier, "MyCatalystApp.app");
			AssertAppContents (platform, appPath);
			var infoPlistPath = Path.Combine (appPath, "Contents", "Info.plist");
			var infoPlist = PDictionary.FromFile (infoPlistPath);
			Assert.AreEqual ("com.xamarin.mycatalystapp", infoPlist.GetString ("CFBundleIdentifier").Value, "CFBundleIdentifier");
			Assert.AreEqual ("MyCatalystApp", infoPlist.GetString ("CFBundleDisplayName").Value, "CFBundleDisplayName");
			Assert.AreEqual ("3.14", infoPlist.GetString ("CFBundleVersion").Value, "CFBundleVersion");
			Assert.AreEqual ("3.14", infoPlist.GetString ("CFBundleShortVersionString").Value, "CFBundleShortVersionString");
		}

		[TestCase ("iOS")]
		[TestCase ("tvOS")]
		// not supported on net6 [TestCase ("watchOS")]
		[TestCase ("macOS")]
		[TestCase ("MacCatalyst")]
		public void BuildMyClassLibrary (string platform)
		{
			Configuration.IgnoreIfIgnoredPlatform (platform);
			var project_path = GetProjectPath ("MyClassLibrary", platform);
			Clean (project_path);
			var result = DotNet.AssertBuild (project_path, verbosity);
			Assert.That (result.StandardOutput.ToString (), Does.Not.Contain ("Task \"ILLink\""), "Linker executed unexpectedly.");
		}

		[TestCase ("iOS")]
		[TestCase ("tvOS")]
		// not supported on net6 [TestCase ("watchOS")]
		[TestCase ("macOS")]
		[TestCase ("MacCatalyst")]
		public void BuildEmbeddedResourcesTest (string platform)
		{
			Configuration.IgnoreIfIgnoredPlatform (platform);
			var assemblyName = "EmbeddedResources";
			var dotnet_bindings_dir = Path.Combine (Configuration.SourceRoot, "tests", assemblyName, "dotnet");
			var project_dir = Path.Combine (dotnet_bindings_dir, platform);
			var project_path = Path.Combine (project_dir, $"{assemblyName}.csproj");
			Clean (project_path);
			Configuration.CopyDotNetSupportingFiles (dotnet_bindings_dir);
			var result = DotNet.AssertBuild (project_path, verbosity);
			var lines = BinLog.PrintToLines (result.BinLogPath);
			// Find the resulting binding assembly from the build log
			var assemblies = FilterToAssembly (lines, assemblyName);
			Assert.That (assemblies, Is.Not.Empty, "Assemblies");
			// Make sure there's no other assembly confusing our logic
			assemblies = assemblies.Distinct ();
			Assert.That (assemblies.Count (), Is.EqualTo (1), $"Unique assemblies\n\t{string.Join ("\n\t", assemblies)}");
			var asm = assemblies.First ();
			Assert.That (asm, Does.Exist, "Assembly existence");
			// Verify that there's one resource in the assembly, and its name
			var ad = AssemblyDefinition.ReadAssembly (asm, new ReaderParameters { ReadingMode = ReadingMode.Deferred });
			Assert.That (ad.MainModule.Resources.Count, Is.EqualTo (1), "1 resource");
			Assert.That (ad.MainModule.Resources [0].Name, Is.EqualTo ("EmbeddedResources.Welcome.resources"), "libtest.a");
			var asm_dir = Path.GetDirectoryName (asm);
			Assert.That (Path.Combine (asm_dir, "en-AU", "EmbeddedResources.resources.dll"), Does.Exist, "en-AU");
			Assert.That (Path.Combine (asm_dir, "de", "EmbeddedResources.resources.dll"), Does.Exist, "de");
			Assert.That (Path.Combine (asm_dir, "es", "EmbeddedResources.resources.dll"), Does.Exist, "es");
		}

		[TestCase ("iOS")]
		[TestCase ("tvOS")]
		// not supported on net6 [TestCase ("watchOS")]
		[TestCase ("macOS")]
		[TestCase ("MacCatalyst")]
		public void BuildFSharpLibraryTest (string platform)
		{
			Configuration.IgnoreIfIgnoredPlatform (platform);
			var assemblyName = "fsharplibrary";
			var dotnet_bindings_dir = Path.Combine (Configuration.SourceRoot, "tests", assemblyName, "dotnet");
			var project_dir = Path.Combine (dotnet_bindings_dir, platform);
			var project_path = Path.Combine (project_dir, $"{assemblyName}.fsproj");
			Clean (project_path);
			Configuration.CopyDotNetSupportingFiles (dotnet_bindings_dir);
			var result = DotNet.AssertBuild (project_path, verbosity);
			var lines = BinLog.PrintToLines (result.BinLogPath);
			// Find the resulting binding assembly from the build log
			var assemblies = FilterToAssembly (lines, assemblyName);
			Assert.That (assemblies, Is.Not.Empty, "Assemblies");
			// Make sure there's no other assembly confusing our logic
			Assert.That (assemblies.Distinct ().Count (), Is.EqualTo (1), "Unique assemblies");
			var asm = assemblies.First ();
			Assert.That (asm, Does.Exist, "Assembly existence");
			// Verify that there's no resources in the assembly
			var ad = AssemblyDefinition.ReadAssembly (asm, new ReaderParameters { ReadingMode = ReadingMode.Deferred });
			Assert.That (ad.MainModule.Resources.Count (), Is.EqualTo (2), "2 resources"); // There are 2 embedded resources by default by the F# compiler.
		}

		[TestCase ("iOS")]
		[TestCase ("tvOS")]
		// not supported on net6 [TestCase ("watchOS")]
		[TestCase ("macOS")]
		[TestCase ("MacCatalyst")]
		public void BuildBindingsTest (string platform)
		{
			Configuration.IgnoreIfIgnoredPlatform (platform);
			var assemblyName = "bindings-test";
			var dotnet_bindings_dir = Path.Combine (Configuration.SourceRoot, "tests", assemblyName, "dotnet");
			var project_dir = Path.Combine (dotnet_bindings_dir, platform);
			var project_path = Path.Combine (project_dir, $"{assemblyName}.csproj");

			Clean (project_path);
			Configuration.CopyDotNetSupportingFiles (dotnet_bindings_dir);
			var result = DotNet.AssertBuild (project_path, verbosity);
			var lines = BinLog.PrintToLines (result.BinLogPath).ToList ();
			Console.WriteLine (string.Join ("\n", lines));
			// Find the resulting binding assembly from the build log
			var assemblies = FilterToAssembly (lines, assemblyName);
			Assert.That (assemblies, Is.Not.Empty, "Assemblies");
			// Make sure there's no other assembly confusing our logic
			Assert.That (assemblies.Distinct ().Count (), Is.EqualTo (1), "Unique assemblies");
			var asm = assemblies.First ();
			Assert.That (asm, Does.Exist, "Assembly existence");

			// Verify that there's one resource in the binding assembly, and its name
			var ad = AssemblyDefinition.ReadAssembly (asm, new ReaderParameters { ReadingMode = ReadingMode.Deferred });
			Assert.That (ad.MainModule.Resources.Count, Is.EqualTo (1), "1 resource");
			Assert.That (ad.MainModule.Resources [0].Name, Is.EqualTo ("libtest.a"), "libtest.a");
		}

		[TestCase ("iOS")]
		[TestCase ("tvOS")]
		// not supported on net6 [TestCase ("watchOS")]
		[TestCase ("macOS")]
		[TestCase ("MacCatalyst")]
		public void BuildBindingsTest2 (string platform)
		{
			Configuration.IgnoreIfIgnoredPlatform (platform);
			var assemblyName = "bindings-test2";
			var dotnet_bindings_dir = Path.Combine (Configuration.SourceRoot, "tests", assemblyName, "dotnet");
			var project_dir = Path.Combine (dotnet_bindings_dir, platform);
			var project_path = Path.Combine (project_dir, $"{assemblyName}.csproj");

			Clean (project_path);
			Configuration.CopyDotNetSupportingFiles (dotnet_bindings_dir);
			var result = DotNet.AssertBuild (project_path, verbosity);
			var lines = BinLog.PrintToLines (result.BinLogPath);
			// Find the resulting binding assembly from the build log
			var assemblies = FilterToAssembly (lines, assemblyName);
			Assert.That (assemblies, Is.Not.Empty, "Assemblies");
			// Make sure there's no other assembly confusing our logic
			Assert.That (assemblies.Distinct ().Count (), Is.EqualTo (1), "Unique assemblies");
			var asm = assemblies.First ();
			Assert.That (asm, Does.Exist, "Assembly existence");

			// Verify that there's one resource in the binding assembly, and its name
			var ad = AssemblyDefinition.ReadAssembly (asm, new ReaderParameters { ReadingMode = ReadingMode.Deferred });
			Assert.That (ad.MainModule.Resources.Count, Is.EqualTo (1), "1 resource");
			Assert.That (ad.MainModule.Resources [0].Name, Is.EqualTo ("libtest2.a"), "libtest2.a");
		}

		[TestCase ("iOS", "monotouch")]
		[TestCase ("tvOS", "monotouch")]
		// not supported on net6 [TestCase ("watchOS")]
		[TestCase ("macOS", "xammac")]
		[TestCase ("MacCatalyst", "monotouch")]
		public void BuildBundledResources (string platform, string prefix)
		{
			Configuration.IgnoreIfIgnoredPlatform (platform);
			var assemblyName = "BundledResources";
			var dotnet_bindings_dir = Path.Combine (Configuration.SourceRoot, "tests", assemblyName, "dotnet");
			var project_dir = Path.Combine (dotnet_bindings_dir, platform);
			var project_path = Path.Combine (project_dir, $"{assemblyName}.csproj");

			Clean (project_path);
			Configuration.CopyDotNetSupportingFiles (dotnet_bindings_dir);
			var result = DotNet.AssertBuild (project_path, verbosity);
			var lines = BinLog.PrintToLines (result.BinLogPath);
			// Find the resulting binding assembly from the build log
			var assemblies = FilterToAssembly (lines, assemblyName);
			Assert.That (assemblies, Is.Not.Empty, "Assemblies");
			// Make sure there's no other assembly confusing our logic
			Assert.That (assemblies.Distinct ().Count (), Is.EqualTo (1), "Unique assemblies");
			var asm = assemblies.First ();
			Assert.That (asm, Does.Exist, "Assembly existence");

			// Verify that there's one resource in the binding assembly, and its name
			var ad = AssemblyDefinition.ReadAssembly (asm, new ReaderParameters { ReadingMode = ReadingMode.Deferred });
			Assert.That (ad.MainModule.Resources.Count, Is.EqualTo (2), "2 resources");
			// Sort the resources before we assert, since we don't care about the order, and sorted order makes the asserts simpler.
			var resources = ad.MainModule.Resources.OrderBy (v => v.Name).ToArray ();
			Assert.That (resources [0].Name, Is.EqualTo ($"__{prefix}_content_basn3p08.png"), $"__{prefix}_content_basn3p08.png");
			Assert.That (resources [1].Name, Is.EqualTo ($"__{prefix}_content_xamvideotest.mp4"), $"__{prefix}_content_xamvideotest.mp4");
		}

		[TestCase ("iOS")]
		[TestCase ("tvOS")]
		// not supported on net6 [TestCase ("watchOS")]
		// [TestCase ("macOS")] // No macOS Touch.Client project for .NET yet
		[TestCase ("MacCatalyst")]
		public void BuildInterdependentBindingProjects (string platform)
		{
			Configuration.IgnoreIfIgnoredPlatform (platform);
			var assemblyName = "interdependent-binding-projects";
			var dotnet_bindings_dir = Path.Combine (Configuration.SourceRoot, "tests", assemblyName, "dotnet");
			var project_dir = Path.Combine (dotnet_bindings_dir, platform);
			var project_path = Path.Combine (project_dir, $"{assemblyName}.csproj");

			Clean (project_path);
			Configuration.CopyDotNetSupportingFiles (dotnet_bindings_dir);
			Configuration.CopyDotNetSupportingFiles (dotnet_bindings_dir.Replace (assemblyName, "bindings-test"));
			Configuration.CopyDotNetSupportingFiles (dotnet_bindings_dir.Replace (assemblyName, "bindings-test2"));
			var cleanupSupportFiles = Configuration.CopyDotNetSupportingFiles (Path.Combine (Configuration.SourceRoot, "external", "Touch.Unit", "Touch.Client/dotnet"));
			try {
				var result = DotNet.AssertBuild (project_path, verbosity);
				var lines = BinLog.PrintToLines (result.BinLogPath);
				// Find the resulting binding assembly from the build log
				var assemblies = lines.
					Select (v => v.Trim ()).
					Where (v => {
						if (v.Length < 10)
							return false;
						if (v [0] != '/')
							return false;
						if (!v.EndsWith ($"{assemblyName}.dll", StringComparison.Ordinal))
							return false;
						if (!v.Contains ("/bin/", StringComparison.Ordinal))
							return false;
						if (!v.Contains ($"{assemblyName}.app", StringComparison.Ordinal))
							return false;
						return true;
					});
				Assert.That (assemblies, Is.Not.Empty, "Assemblies");
				// Make sure there's no other assembly confusing our logic
				assemblies = assemblies.Distinct ();
				Assert.That (assemblies.Count (), Is.EqualTo (1), $"Unique assemblies: {string.Join (", ", assemblies)}");
				var asm = assemblies.First ();
				Assert.That (asm, Does.Exist, "Assembly existence");

				// Verify that the resources have been linked away
				var asmDir = Path.GetDirectoryName (asm);
				var ad = AssemblyDefinition.ReadAssembly (asm, new ReaderParameters { ReadingMode = ReadingMode.Deferred });
				Assert.That (ad.MainModule.Resources.Count, Is.EqualTo (0), "0 resources for interdependent-binding-projects.dll");

				var ad1 = AssemblyDefinition.ReadAssembly (Path.Combine (asmDir, "bindings-test.dll"), new ReaderParameters { ReadingMode = ReadingMode.Deferred });
				// The native library is removed from the resources by the linker
				Assert.That (ad1.MainModule.Resources.Count, Is.EqualTo (0), "0 resources for bindings-test.dll");

				var ad2 = AssemblyDefinition.ReadAssembly (Path.Combine (asmDir, "bindings-test2.dll"), new ReaderParameters { ReadingMode = ReadingMode.Deferred });
				// The native library is removed from the resources by the linker
				Assert.That (ad2.MainModule.Resources.Count, Is.EqualTo (0), "0 resources for bindings-test2.dll");
			} finally {
				foreach (var file in cleanupSupportFiles)
					File.Delete (file);
			}
		}

		[Test]
		[TestCase ("iossimulator-x64", false)]
		[TestCase ("ios-arm64", true)]
		public void IsNotMacBuild (string runtimeIdentifier, bool isDeviceBuild)
		{
			if (isDeviceBuild)
				Configuration.AssertDeviceAvailable ();

			var platform = ApplePlatform.iOS;
			var project_path = GetProjectPath ("MySingleView");
			Configuration.IgnoreIfIgnoredPlatform (platform);
			Clean (project_path);
			var properties = new Dictionary<string, string> (verbosity);
			properties ["RuntimeIdentifier"] = runtimeIdentifier;
			properties ["IsMacEnabled"] = "false";
			var result = DotNet.AssertBuild (project_path, properties);
			AssertThatLinkerDidNotExecute (result);
			var appPath = Path.Combine (Path.GetDirectoryName (project_path), "bin", "Debug", "net6.0-ios", runtimeIdentifier, "MySingleView.app");
			var appExecutable = Path.Combine (appPath, Path.GetFileName (project_path));
			Assert.That (appPath, Does.Exist, "There is an .app");
			Assert.That (appExecutable, Does.Not.Empty, "There is no executable");
			Assert.That (Path.Combine (appPath, "Xamarin.iOS.dll"), Does.Exist, "Xamarin.iOS.dll is in the bundle");
		}

		[Test]
		[TestCase ("NativeDynamicLibraryReferencesApp", ApplePlatform.iOS, "iossimulator-x64")]
		[TestCase ("NativeDynamicLibraryReferencesApp", ApplePlatform.MacOSX, "osx-x64")]
		[TestCase ("NativeFileReferencesApp", ApplePlatform.iOS, "iossimulator-x64")]
		[TestCase ("NativeFileReferencesApp", ApplePlatform.MacOSX, "osx-x64")]
		[TestCase ("NativeFrameworkReferencesApp", ApplePlatform.iOS, "iossimulator-x64")]
		[TestCase ("NativeFrameworkReferencesApp", ApplePlatform.MacOSX, "osx-x64")]
		[TestCase ("NativeXCFrameworkReferencesApp", ApplePlatform.iOS, "iossimulator-x64")]
		[TestCase ("NativeXCFrameworkReferencesApp", ApplePlatform.MacOSX, "osx-x64")]
		public void BuildAndExecuteNativeReferencesTestApp (string project, ApplePlatform platform, string runtimeIdentifier)
		{
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var project_path = GetProjectPath (project, platform: platform);
			Clean (project_path);
			var properties = new Dictionary<string, string> (verbosity);
			properties ["RuntimeIdentifier"] = runtimeIdentifier;
			DotNet.AssertBuild (project_path, properties);

			if (platform == ApplePlatform.MacOSX || platform == ApplePlatform.MacCatalyst) {
				var appPath = Path.Combine (Path.GetDirectoryName (project_path), "bin", "Debug", platform.ToFramework (), runtimeIdentifier, project + ".app");
				var appExecutable = Path.Combine (appPath, "Contents", "MacOS", Path.GetFileNameWithoutExtension (project_path));
				Assert.That (appExecutable, Does.Exist, "There is an executable");
				ExecuteWithMagicWordAndAssert (appExecutable);
			}
		}

		[Test]
		[TestCase (ApplePlatform.iOS, "ios-x64")] // valid RID in a previous preview (and common mistake)
		[TestCase (ApplePlatform.iOS, "iossimulator-x84")] // it's x86, not x84
		[TestCase (ApplePlatform.iOS, "iossimulator-arm64")] // we don't support this yet
		[TestCase (ApplePlatform.iOS, "helloworld")] // random text
		[TestCase (ApplePlatform.iOS, "osx-x64")] // valid RID for another platform
		[TestCase (ApplePlatform.TVOS, "tvos-x64")] // valid RID in a previous preview (and common mistake)
		[TestCase (ApplePlatform.TVOS, "tvossimulator-x46")] // it's x64, not x46
		[TestCase (ApplePlatform.TVOS, "tvossimulator-arm64")] // we don't support this yet
		[TestCase (ApplePlatform.TVOS, "helloworld")] // random text
		[TestCase (ApplePlatform.TVOS, "osx-x64")] // valid RID for another platform
		[TestCase (ApplePlatform.MacOSX, "osx-x46")] // it's x64, not x46
		[TestCase (ApplePlatform.MacOSX, "macos-arm64")] // it's osx, not macos
		[TestCase (ApplePlatform.MacOSX, "helloworld")] // random text
		[TestCase (ApplePlatform.MacOSX, "ios-arm64")] // valid RID for another platform
		[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-x46")] // it's x64, not x46
		[TestCase (ApplePlatform.MacCatalyst, "helloworld")] // random text
		[TestCase (ApplePlatform.MacCatalyst, "osx-x64")] // valid RID for another platform
		public void InvalidRuntimeIdentifier (ApplePlatform platform, string runtimeIdentifier)
		{
			var project = "MySimpleApp";
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var project_path = GetProjectPath (project, platform: platform);
			Clean (project_path);
			var properties = new Dictionary<string, string> (verbosity);
			properties ["RuntimeIdentifier"] = runtimeIdentifier;
			var rv = DotNet.AssertBuildFailure (project_path, properties);
			var errors = BinLog.GetBuildMessages (rv.BinLogPath).Where (v => v.Type == BuildLogEventType.Error).ToArray ();
			Assert.AreEqual (1, errors.Length, "Error count");
			Assert.AreEqual ($"The RuntimeIdentifier '{runtimeIdentifier}' is invalid.", errors [0].Message, "Error message");
		}

		void ExecuteWithMagicWordAndAssert (string executable)
		{
			var magicWord = Guid.NewGuid ().ToString ();
			var env = new Dictionary<string, string> { { "MAGIC_WORD", magicWord } };

			var output = new StringBuilder ();
			var rv = Execution.RunWithStringBuildersAsync (executable, Array.Empty<string> (), environment: env, standardOutput: output, standardError: output, timeout: TimeSpan.FromSeconds (15)).Result;
			Assert.That (output.ToString (), Does.Contain (magicWord), "Contains magic word");
			Assert.AreEqual (0, rv.ExitCode, "ExitCode");
		}

		void AssertThatLinkerExecuted (ExecutionResult result)
		{
			var output = BinLog.PrintToString (result.BinLogPath);
			Assert.That (output, Does.Contain ("Building target \"_RunILLink\" completely."), "Linker did not executed as expected.");
			Assert.That (output, Does.Contain ("LinkerConfiguration:"), "Custom steps did not run as expected.");
		}

		void AssertThatLinkerDidNotExecute (ExecutionResult result)
		{
			var output = BinLog.PrintToString (result.BinLogPath);
			Assert.That (output, Does.Not.Contain ("Building target \"_RunILLink\" completely."), "Linker did not executed as expected.");
			Assert.That (output, Does.Not.Contain ("LinkerConfiguration:"), "Custom steps did not run as expected.");
		}

		void AssertAppContents (ApplePlatform platform, string app_directory)
		{
			string info_plist_path;
			switch (platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
			case ApplePlatform.WatchOS:
				info_plist_path = Path.Combine (app_directory, "Info.plist");
				break;
			case ApplePlatform.MacOSX:
			case ApplePlatform.MacCatalyst:
				info_plist_path = Path.Combine (app_directory, "Contents", "Info.plist");
				break;
			default:
				throw new NotImplementedException ($"Unknown platform: {platform}");
			}
			Assert.That (info_plist_path, Does.Exist, "Info.plist");

			var assets_path = string.Empty;
			switch (platform) {
			case ApplePlatform.iOS:
				break; // sample project doesn't have assets
			case ApplePlatform.TVOS:
				assets_path = Path.Combine (app_directory, "Assets.car");
				break;
			case ApplePlatform.WatchOS:
				break; // sample project doesn't have assets
			case ApplePlatform.MacOSX:
			case ApplePlatform.MacCatalyst:
				assets_path = Path.Combine (app_directory, "Contents", "Resources", "Assets.car");
				break;
			default:
				throw new NotImplementedException ($"Unknown platform: {platform}");
			}
			if (!string.IsNullOrEmpty (assets_path))
				Assert.That (assets_path, Does.Exist, "Assets.car");

			var libxamarin = Directory.GetFileSystemEntries (app_directory, "libxamarin*dylib", SearchOption.AllDirectories);
			Assert.That (libxamarin, Has.Length.LessThanOrEqualTo (1), $"No more than one libxamarin should be present, but found {libxamarin.Length}:\n\t{string.Join ("\n\t", libxamarin)}");
		}

		IEnumerable<string> FilterToAssembly (IEnumerable<string> lines, string assemblyName)
		{
			return lines.
				Select (v => v.Trim ()).
				Where (v => {
					if (v.Length < 10)
						return false;
					if (v [0] != '/')
						return false;
					if (!v.EndsWith ($"{assemblyName}.dll", StringComparison.Ordinal))
						return false;
					if (!v.Contains ("/bin/", StringComparison.Ordinal))
						return false;
					if (v.Contains ("/ref/", StringComparison.Ordinal))
						return false; // Skip reference assemblies
					return true;
				});
		}

		// This is copied from the KillEverything method in xharness/Microsoft.DotNet.XHarness.iOS.Shared/Hardware/SimulatorDevice.cs and modified to work here.
		[OneTimeSetUp]
		public void KillEverything ()
		{
			ExecutionHelper.Execute ("launchctl", new [] { "remove", "com.apple.CoreSimulator.CoreSimulatorService" }, timeout: TimeSpan.FromSeconds (10));

			var to_kill = new string [] { "iPhone Simulator", "iOS Simulator", "Simulator", "Simulator (Watch)", "com.apple.CoreSimulator.CoreSimulatorService", "ibtoold" };

			var args = new List<string> ();
			args.Add ("-9");
			args.AddRange (to_kill);
			ExecutionHelper.Execute ("killall", args, timeout: TimeSpan.FromSeconds (10));

			var dirsToBeDeleted = new [] {
				Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.UserProfile), "Library", "Saved Application State", "com.apple.watchsimulator.savedState"),
				Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.UserProfile), "Library", "Saved Application State", "com.apple.iphonesimulator.savedState"),
			};

			foreach (var dir in dirsToBeDeleted) {
				try {
					if (Directory.Exists (dir))
						Directory.Delete (dir, true);
				} catch (Exception e) {
					Console.WriteLine ("Could not delete the directory '{0}': {1}", dir, e.Message);
				}
			}

			// https://github.com/xamarin/xamarin-macios/issues/10012
			ExecutionHelper.Execute ("xcrun", new [] { "simctl", "list" });
		}
	}
}
