using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using Mono.Cecil;

using NUnit.Framework;

using Xamarin.Utils;
using Xamarin.Tests;
using Xamarin.MacDev;

namespace Xamarin.Tests {
	[TestFixture]
	public class DotNetProjectTest : TestBaseClass {
		[Test]
		[TestCase (null)]
		[TestCase ("iossimulator-x86")]
		[TestCase ("iossimulator-x64")]
		[TestCase ("iossimulator-arm64")]
		[TestCase ("ios-arm64")]
		[TestCase ("ios-arm")]
		public void BuildMySingleView (string runtimeIdentifier)
		{
			var platform = ApplePlatform.iOS;
			var project_path = GetProjectPath ("MySingleView", runtimeIdentifiers: runtimeIdentifier, platform: platform, out var appPath);
			Configuration.IgnoreIfIgnoredPlatform (platform);
			Clean (project_path);
			var properties = GetDefaultProperties (runtimeIdentifier);
			var result = DotNet.AssertBuild (project_path, properties);
			AssertThatLinkerExecuted (result);
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
			var project_path = GetProjectPath ("MyCocoaApp", runtimeIdentifiers: runtimeIdentifier, platform: platform, out var appPath);
			Configuration.IgnoreIfIgnoredPlatform (platform);
			Clean (project_path);
			var properties = GetDefaultProperties (runtimeIdentifier);
			var result = DotNet.AssertBuild (project_path, properties);
			AssertThatLinkerExecuted (result);
			AssertAppContents (platform, appPath);
		}

		[Test]
		[TestCase (null)]
		[TestCase ("tvossimulator-x64")]
		[TestCase ("tvossimulator-arm64")]
		[TestCase ("tvos-arm64")]
		public void BuildMyTVApp (string runtimeIdentifier)
		{
			var platform = ApplePlatform.TVOS;
			var project_path = GetProjectPath ("MyTVApp", runtimeIdentifiers: runtimeIdentifier, platform: platform, out var appPath);
			Configuration.IgnoreIfIgnoredPlatform (platform);
			Clean (project_path);
			var properties = GetDefaultProperties (runtimeIdentifier);
			var result = DotNet.AssertBuild (project_path, properties);
			AssertThatLinkerExecuted (result);
			AssertAppContents (platform, appPath);
		}

		[Test]
		[TestCase (null)]
		[TestCase ("maccatalyst-x64")]
		[TestCase ("maccatalyst-arm64")]
		public void BuildMyCatalystApp (string runtimeIdentifier)
		{
			var platform = ApplePlatform.MacCatalyst;
			var project_path = GetProjectPath ("MyCatalystApp", runtimeIdentifiers: runtimeIdentifier, platform: platform, out var appPath);
			Configuration.IgnoreIfIgnoredPlatform (platform);
			Clean (project_path);
			var properties = GetDefaultProperties (runtimeIdentifier);
			var result = DotNet.AssertBuild (project_path, properties);
			AssertThatLinkerExecuted (result);
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

		[TestCase (ApplePlatform.iOS)]
		[TestCase (ApplePlatform.TVOS)]
		[TestCase (ApplePlatform.MacOSX)]
		[TestCase (ApplePlatform.MacCatalyst)]
		public void BuildBindingsTest (ApplePlatform platform)
		{
			Configuration.IgnoreIfIgnoredPlatform (platform);
			var assemblyName = "bindings-test";
			var dotnet_bindings_dir = Path.Combine (Configuration.SourceRoot, "tests", assemblyName, "dotnet");
			var project_dir = Path.Combine (dotnet_bindings_dir, platform.AsString ());
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
			Assert.That (ad.MainModule.Resources.Count, Is.EqualTo (0), "no embedded resources");
			var resourceBundle = Path.Combine (project_dir, "bin", "Debug", platform.ToFramework (), assemblyName + ".resources");
			Assert.That (resourceBundle, Does.Exist, "Bundle existence");
		}

		[TestCase (ApplePlatform.iOS)]
		[TestCase (ApplePlatform.TVOS)]
		[TestCase (ApplePlatform.MacOSX)]
		[TestCase (ApplePlatform.MacCatalyst)]
		public void BuildBindingsTest2 (ApplePlatform platform)
		{
			Configuration.IgnoreIfIgnoredPlatform (platform);
			var assemblyName = "bindings-test2";
			var dotnet_bindings_dir = Path.Combine (Configuration.SourceRoot, "tests", assemblyName, "dotnet");
			var project_dir = Path.Combine (dotnet_bindings_dir, platform.AsString ());
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
			Assert.That (ad.MainModule.Resources.Count, Is.EqualTo (0), "no embedded resources");
			var resourceBundle = Path.Combine (project_dir, "bin", "Debug", platform.ToFramework (), assemblyName + ".resources");
			Assert.That (resourceBundle, Does.Exist, "Bundle existence");
		}

		[TestCase ("iOS", "monotouch")]
		[TestCase ("tvOS", "monotouch")]
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
		[TestCase ("macOS")]
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
			var cleanupSupportFiles = Configuration.CopyDotNetSupportingFiles (
				Path.Combine (Configuration.SourceRoot, "external", "Touch.Unit", "Touch.Client", "dotnet"),
				Path.Combine (Configuration.SourceRoot, "external", "MonoTouch.Dialog", "MonoTouch.Dialog", "dotnet")
			);
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
		[TestCase (ApplePlatform.iOS, "iossimulator-x86;iossimulator-x64")]
		[TestCase (ApplePlatform.iOS, "iossimulator-x86;iossimulator-x64;iossimulator-arm64")]
		[TestCase (ApplePlatform.iOS, "ios-arm;ios-arm64")]
		[TestCase (ApplePlatform.TVOS, "tvossimulator-x64;tvossimulator-arm64")]
		[TestCase (ApplePlatform.MacOSX, "osx-arm64;osx-x64")]
		[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-arm64;maccatalyst-x64")]
		public void BuildFatApp (ApplePlatform platform, string runtimeIdentifiers)
		{
			var project = "MySimpleApp";
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var project_path = GetProjectPath (project, runtimeIdentifiers: runtimeIdentifiers, platform: platform, out var appPath);
			Clean (project_path);
			var properties = GetDefaultProperties (runtimeIdentifiers);
			var result = DotNet.AssertBuild (project_path, properties);
			AssertThatLinkerExecuted (result);
			var infoPlistPath = GetInfoPListPath (platform, appPath);
			Assert.That (infoPlistPath, Does.Exist, "Info.plist");
			var infoPlist = PDictionary.FromFile (infoPlistPath);
			Assert.AreEqual ("com.xamarin.mysimpleapp", infoPlist.GetString ("CFBundleIdentifier").Value, "CFBundleIdentifier");
			Assert.AreEqual ("MySimpleApp", infoPlist.GetString ("CFBundleDisplayName").Value, "CFBundleDisplayName");
			Assert.AreEqual ("3.14", infoPlist.GetString ("CFBundleVersion").Value, "CFBundleVersion");
			Assert.AreEqual ("3.14", infoPlist.GetString ("CFBundleShortVersionString").Value, "CFBundleShortVersionString");
		}

		[Test]
		[TestCase (ApplePlatform.iOS, "iossimulator-x86;iossimulator-x64")]
		[TestCase (ApplePlatform.iOS, "ios-arm;ios-arm64", "MtouchLink=SdkOnly")]
		[TestCase (ApplePlatform.MacOSX, "osx-arm64;osx-x64")]
		[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-arm64;maccatalyst-x64")]
		public void BuildFatMonoTouchTest (ApplePlatform platform, string runtimeIdentifiers, params string[] additionalProperties)
		{
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var project_path = Path.Combine (Configuration.SourceRoot, "tests", "monotouch-test", "dotnet", platform.AsString (), "monotouch-test.csproj");
			Configuration.CopyDotNetSupportingFiles (Path.GetDirectoryName (Path.GetDirectoryName (project_path)));
			Configuration.CopyDotNetSupportingFiles (Path.Combine (Configuration.SourceRoot, "tests", "bindings-test", "dotnet"));
			Configuration.CopyDotNetSupportingFiles (Path.Combine (Configuration.SourceRoot, "tests", "bindings-test2", "dotnet"));
			Configuration.CopyDotNetSupportingFiles (Path.Combine (Configuration.SourceRoot, "tests", "EmbeddedResources", "dotnet"));
			Configuration.CopyDotNetSupportingFiles (Path.Combine (Configuration.SourceRoot, "tests", "fsharplibrary", "dotnet"));
			Configuration.CopyDotNetSupportingFiles (Path.Combine (Configuration.SourceRoot, "external", "Touch.Unit", "Touch.Client", "dotnet"));
			Clean (project_path);
			var properties = GetDefaultProperties (runtimeIdentifiers);
			if (additionalProperties != null) {
				foreach (var prop in additionalProperties) {
					var eq = prop.IndexOf ('=');
					var name = prop.Substring (0, eq);
					var value = prop.Substring (eq + 1);
					properties [name] = value;
				}
			}
			var result = DotNet.AssertBuild (project_path, properties);
			var appPath = Path.Combine (Path.GetDirectoryName (project_path), "bin", "Debug", platform.ToFramework (), "monotouchtest.app");
			var infoPlistPath = GetInfoPListPath (platform, appPath);
			Assert.That (infoPlistPath, Does.Exist, "Info.plist");
			var infoPlist = PDictionary.FromFile (infoPlistPath);
			Assert.AreEqual ("com.xamarin.monotouch-test", infoPlist.GetString ("CFBundleIdentifier").Value, "CFBundleIdentifier");
			Assert.AreEqual ("MonoTouchTest", infoPlist.GetString ("CFBundleDisplayName").Value, "CFBundleDisplayName");
		}

		[Test]
		[TestCase (ApplePlatform.iOS, "ios-arm;ios-arm64;iossimulator-x64;iossimulator-x86")]
		[TestCase (ApplePlatform.iOS, "ios-arm64;iossimulator-x64")]
		[TestCase (ApplePlatform.iOS, "ios-arm64;iossimulator-arm64")]
		[TestCase (ApplePlatform.iOS, "ios-arm64;ios-arm;iossimulator-x64")]
		[TestCase (ApplePlatform.iOS, "ios-arm64;iossimulator-x64;iossimulator-x86")]
		[TestCase (ApplePlatform.TVOS, "tvos-arm64;tvossimulator-x64")]
		[TestCase (ApplePlatform.TVOS, "tvos-arm64;tvossimulator-arm64")]
		public void InvalidRuntimeIdentifiers (ApplePlatform platform, string runtimeIdentifiers)
		{
			var project = "MySimpleApp";
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var project_path = GetProjectPath (project, platform: platform);
			Clean (project_path);
			var properties = GetDefaultProperties (runtimeIdentifiers);
			var rv = DotNet.AssertBuildFailure (project_path, properties);
			var errors = BinLog.GetBuildLogErrors (rv.BinLogPath).ToArray ();
			Assert.AreEqual (1, errors.Length, "Error count");
			Assert.AreEqual ($"Building for all the runtime identifiers '{runtimeIdentifiers}' at the same time isn't possible, because they represent different platform variations.", errors [0].Message, "Error message");
		}

		[Test]
		[TestCase ("iossimulator-x64", false)]
		[TestCase ("ios-arm64", true)]
		public void IsNotMacBuild (string runtimeIdentifier, bool isDeviceBuild)
		{
			if (isDeviceBuild)
				Configuration.AssertDeviceAvailable ();

			var platform = ApplePlatform.iOS;
			var project_path = GetProjectPath ("MySingleView", runtimeIdentifiers: runtimeIdentifier, platform: platform, out var appPath);
			Configuration.IgnoreIfIgnoredPlatform (platform);
			Clean (project_path);
			var properties = GetDefaultProperties (runtimeIdentifier);
			properties ["IsMacEnabled"] = "false";
			var result = DotNet.AssertBuild (project_path, properties);
			AssertThatLinkerDidNotExecute (result);
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

			var project_path = GetProjectPath (project, runtimeIdentifiers: runtimeIdentifier, platform: platform, out var appPath);
			Clean (project_path);
			var properties = GetDefaultProperties (runtimeIdentifier);
			DotNet.AssertBuild (project_path, properties);

			if (platform == ApplePlatform.MacOSX || platform == ApplePlatform.MacCatalyst) {
				var appExecutable = Path.Combine (appPath, "Contents", "MacOS", Path.GetFileNameWithoutExtension (project_path));
				Assert.That (appExecutable, Does.Exist, "There is an executable");
				ExecuteWithMagicWordAndAssert (appExecutable);
			}
		}

		[Test]
		[TestCase (ApplePlatform.iOS, "ios-x64")] // valid RID in a previous preview (and common mistake)
		[TestCase (ApplePlatform.iOS, "iossimulator-x84")] // it's x86, not x84
		[TestCase (ApplePlatform.iOS, "iossimulator-arm")] // we don't support this
		[TestCase (ApplePlatform.iOS, "helloworld")] // random text
		[TestCase (ApplePlatform.iOS, "osx-x64")] // valid RID for another platform
		[TestCase (ApplePlatform.TVOS, "tvos-x64")] // valid RID in a previous preview (and common mistake)
		[TestCase (ApplePlatform.TVOS, "tvossimulator-x46")] // it's x64, not x46
		[TestCase (ApplePlatform.TVOS, "tvossimulator-arm")] // we don't support this
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
			var properties = GetDefaultProperties (runtimeIdentifier);
			var rv = DotNet.AssertBuildFailure (project_path, properties);
			var errors = BinLog.GetBuildLogErrors (rv.BinLogPath).ToArray ();
			var uniqueErrors = errors.Select (v => v.Message).Distinct ().ToArray ();
			Assert.AreEqual (1, uniqueErrors.Length, "Error count");
			Assert.AreEqual ($"The RuntimeIdentifier '{runtimeIdentifier}' is invalid.", uniqueErrors [0], "Error message");
		}

		[Test]
		[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-x64")]
		public void FilesInAppBundle (ApplePlatform platform, string runtimeIdentifiers)
		{
			var project = "MySimpleApp";
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var project_path = GetProjectPath (project, runtimeIdentifiers: runtimeIdentifiers, platform: platform, out var appPath);
			Clean (project_path);

			var properties = GetDefaultProperties (runtimeIdentifiers);

			// Build
			DotNet.AssertBuild (project_path, properties);

			// Simulate a crash dump
			File.WriteAllText (Path.Combine (appPath, "mono_crash.mem.123456.something.blob"), "A crash dump");
			File.WriteAllText (Path.Combine (appPath, "mono_crash.123456.somethingelse.blob"), "A crash dump");

			// Build again
			DotNet.AssertBuild (project_path, properties);

			// Create a file that isn't a crash report.
			File.WriteAllText (Path.Combine (appPath, "otherfile.txt"), "A file");

			// Build again - this time it'll fail
			var rv = DotNet.Build (project_path, properties);
			var warnings = BinLog.GetBuildLogWarnings (rv.BinLogPath).ToArray ();
			Assert.AreNotEqual (0, rv.ExitCode, "Unexpected success");
			Assert.AreEqual (1, warnings.Length, "Warning Count");
			Assert.AreEqual ("Found files in the root directory of the app bundle. This will likely cause codesign to fail. Files:\nbin/Debug/net6.0-maccatalyst/maccatalyst-x64/MySimpleApp.app/otherfile.txt", warnings [0].Message, "Warning");

			// Remove the offending file
			File.Delete (Path.Combine (appPath, "otherfile.txt"));

			// Build yet again
			DotNet.AssertBuild (project_path, properties);
		}

		[Test]
		[TestCase (ApplePlatform.MacOSX, "osx-x64")]
		[TestCase (ApplePlatform.MacOSX, "osx-arm64")]
		[TestCase (ApplePlatform.MacOSX, "osx-arm64;osx-x64")]
		public void BuildCoreCLR (ApplePlatform platform, string runtimeIdentifiers)
		{
			var project = "MySimpleApp";
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var project_path = GetProjectPath (project, runtimeIdentifiers: runtimeIdentifiers, platform: platform, out var appPath);
			Clean (project_path);
			var properties = GetDefaultProperties (runtimeIdentifiers);
			properties ["UseMonoRuntime"] = "false";
			var rv = DotNet.AssertBuild (project_path, properties);

			AssertThatLinkerExecuted (rv);
			var infoPlistPath = GetInfoPListPath (platform, appPath);
			Assert.That (infoPlistPath, Does.Exist, "Info.plist");
			var infoPlist = PDictionary.FromFile (infoPlistPath);
			Assert.AreEqual ("com.xamarin.mysimpleapp", infoPlist.GetString ("CFBundleIdentifier").Value, "CFBundleIdentifier");
			Assert.AreEqual ("MySimpleApp", infoPlist.GetString ("CFBundleDisplayName").Value, "CFBundleDisplayName");
			Assert.AreEqual ("3.14", infoPlist.GetString ("CFBundleVersion").Value, "CFBundleVersion");
			Assert.AreEqual ("3.14", infoPlist.GetString ("CFBundleShortVersionString").Value, "CFBundleShortVersionString");

			var appExecutable = GetNativeExecutable (platform, appPath);
			ExecuteWithMagicWordAndAssert (platform, runtimeIdentifiers, appExecutable);

			var createdump = Path.Combine (appPath, "Contents", "MonoBundle", "createdump");
			Assert.That (createdump, Does.Exist, "createdump existence");
		}

		[Test]
		[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-x64")]
		public void AbsoluteOutputPath (ApplePlatform platform, string runtimeIdentifiers)
		{
			var project = "MySimpleApp";
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var outputPath = Cache.CreateTemporaryDirectory ();
			var project_path = GetProjectPath (project, platform: platform);
			Clean (project_path);
			var properties = GetDefaultProperties (runtimeIdentifiers);
			properties ["OutputPath"] = outputPath + "/";
			var rv = DotNet.AssertBuild (project_path, properties);

			AssertThatLinkerExecuted (rv);

			var appPath = Path.Combine (outputPath, project + ".app");
			var appExecutable = GetNativeExecutable (platform, appPath);
			ExecuteWithMagicWordAndAssert (platform, runtimeIdentifiers, appExecutable);
		}

		[Test]
		[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-x64")]
		[TestCase (ApplePlatform.MacOSX, "osx-x64")]
		public void SimpleAppWithOldReferences (ApplePlatform platform, string runtimeIdentifiers)
		{
			var project = "SimpleAppWithOldReferences";
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var project_path = GetProjectPath (project, runtimeIdentifiers: runtimeIdentifiers, platform: platform, out var appPath);
			Clean (project_path);

			DotNet.AssertBuild (project_path, GetDefaultProperties (runtimeIdentifiers));

			var appExecutable = GetNativeExecutable (platform, appPath);
			Assert.That (appExecutable, Does.Exist, "There is an executable");
			ExecuteWithMagicWordAndAssert (platform, runtimeIdentifiers, appExecutable);
		}

		[Test]
		[TestCase (ApplePlatform.iOS)]
		[TestCase (ApplePlatform.TVOS)]
		[TestCase (ApplePlatform.MacCatalyst)]
		[TestCase (ApplePlatform.MacOSX)]
		public void BindingWithDefaultCompileInclude (ApplePlatform platform)
		{
			var project = "BindingWithDefaultCompileInclude";
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var project_path = GetProjectPath (project, platform: platform);
			Clean (project_path);

			var rv = DotNet.AssertBuild (project_path, GetDefaultProperties ());

			var dllPath = Path.Combine (Path.GetDirectoryName (project_path), "bin", "Debug", platform.ToFramework (), $"{project}.dll");
			Assert.That (dllPath, Does.Exist, "Binding assembly");

			// Verify that the MyNativeClass class exists in the assembly, and that it's actually a class.
			var ad = AssemblyDefinition.ReadAssembly (dllPath, new ReaderParameters { ReadingMode = ReadingMode.Deferred });
			var myNativeClass = ad.MainModule.Types.FirstOrDefault (v => v.FullName == "MyApiDefinition.MyNativeClass");
			Assert.IsFalse (myNativeClass.IsInterface, "IsInterface");
			var myStruct = ad.MainModule.Types.FirstOrDefault (v => v.FullName == "MyClassLibrary.MyStruct");
			Assert.IsTrue (myStruct.IsValueType, "MyStruct");

			var warnings = BinLog.GetBuildLogWarnings (rv.BinLogPath).Select (v => v.Message);
			Assert.That (warnings, Is.Empty, $"Build warnings:\n\t{string.Join ("\n\t", warnings)}");
		}

		[TestCase (ApplePlatform.iOS, "iossimulator-x64")]
		[TestCase (ApplePlatform.iOS, "ios-arm64;ios-arm")]
		[TestCase (ApplePlatform.TVOS, "tvossimulator-x64")]
		[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-x64")]
		[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-arm64;maccatalyst-x64")]
		[TestCase (ApplePlatform.MacOSX, "osx-x64")]
		[TestCase (ApplePlatform.MacOSX, "osx-arm64;osx-x64")] // https://github.com/xamarin/xamarin-macios/issues/12410
		public void AppWithResources (ApplePlatform platform, string runtimeIdentifiers)
		{
			var project = "AppWithResources";
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var project_path = GetProjectPath (project, runtimeIdentifiers: runtimeIdentifiers, platform: platform, out var appPath);
			Clean (project_path);

			DotNet.AssertBuild (project_path, GetDefaultProperties (runtimeIdentifiers));

			var appExecutable = GetNativeExecutable (platform, appPath);
			ExecuteWithMagicWordAndAssert (platform, runtimeIdentifiers, appExecutable);

			var resourcesDirectory = GetResourcesDirectory (platform, appPath);

			var fontDirectory = resourcesDirectory;
			var fontAFile = Path.Combine (fontDirectory, "A.ttc");
			var fontBFile = Path.Combine (fontDirectory, "B.otf");
			var fontCFile = Path.Combine (fontDirectory, "C.ttf");

			Assert.That (fontAFile, Does.Exist, "A.ttc existence");
			Assert.That (fontBFile, Does.Exist, "B.otf existence");
			Assert.That (fontCFile, Does.Exist, "C.ttf existence");

			var plist = PDictionary.FromFile (GetInfoPListPath (platform, appPath));
			switch (platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
			case ApplePlatform.MacCatalyst:
				var uiAppFonts = plist.GetArray ("UIAppFonts");
				Assert.IsNotNull (uiAppFonts, "UIAppFonts");
				Assert.AreEqual (1, uiAppFonts.Count, "UIAppFonts.Count");
				Assert.AreEqual ("B.otf", ((PString) uiAppFonts [0]).Value, "UIAppFonts [0]");
				break;
			case ApplePlatform.MacOSX:
				var applicationFontsPath = plist.GetString ("ATSApplicationFontsPath")?.Value;
				Assert.AreEqual (".", applicationFontsPath, "ATSApplicationFontsPath");
				break;
			default:
				throw new ArgumentOutOfRangeException ($"Unknown platform: {platform}");
			}

			var assetsCar = Path.Combine (resourcesDirectory, "Assets.car");
			Assert.That (assetsCar, Does.Exist, "Assets.car");

			var mainStoryboard = Path.Combine (resourcesDirectory, "Main.storyboardc");
			Assert.That (mainStoryboard, Does.Exist, "Main.storyboardc");

			var scnAssetsDir = Path.Combine (resourcesDirectory, "art.scnassets");
			Assert.That (Path.Combine (scnAssetsDir, "scene.scn"), Does.Exist, "scene.scn");
			Assert.That (Path.Combine (scnAssetsDir, "texture.png"), Does.Exist, "texture.png");

			var colladaScene = Path.Combine (resourcesDirectory, "scene.dae");
			Assert.That (colladaScene, Does.Exist, "Collada - scene.dae");

			var atlasTexture = Path.Combine (resourcesDirectory, "Archer_Attack.atlasc", "Archer_Attack.plist");
			Assert.That (atlasTexture, Does.Exist, "AtlasTexture - Archer_Attack");

			var mlModel = Path.Combine (resourcesDirectory, "SqueezeNet.mlmodelc");
			Assert.That (mlModel, Does.Exist, "CoreMLModel");

			var arm64txt = Path.Combine (resourcesDirectory, "arm64.txt");
			var armtxt = Path.Combine (resourcesDirectory, "arm.txt");
			var x64txt = Path.Combine (resourcesDirectory, "x64.txt");
			Assert.AreEqual (runtimeIdentifiers.Split (';').Any (v => v.EndsWith ("-arm64")), File.Exists (arm64txt), "arm64.txt");
			Assert.AreEqual (runtimeIdentifiers.Split (';').Any (v => v.EndsWith ("-arm")), File.Exists (armtxt), "arm.txt");
			Assert.AreEqual (runtimeIdentifiers.Split (';').Any (v => v.EndsWith ("-x64")), File.Exists (x64txt), "x64.txt");
		}

		[TestCase (ApplePlatform.iOS, "iossimulator-x64")]
		[TestCase (ApplePlatform.iOS, "ios-arm64;ios-arm")]
		[TestCase (ApplePlatform.TVOS, "tvossimulator-x64")]
		[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-x64")]
		[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-arm64;maccatalyst-x64")]
		[TestCase (ApplePlatform.MacOSX, "osx-x64")]
		[TestCase (ApplePlatform.MacOSX, "osx-arm64;osx-x64")] // https://github.com/xamarin/xamarin-macios/issues/12410
		public void DoubleBuild (ApplePlatform platform, string runtimeIdentifiers)
		{
			var project = "AppWithResources";
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var projectPath = GetProjectPath (project, runtimeIdentifiers: runtimeIdentifiers, platform: platform, out _);
			Clean (projectPath);

			DotNet.AssertBuild (projectPath, GetDefaultProperties (runtimeIdentifiers));
			DotNet.AssertBuild (projectPath, GetDefaultProperties (runtimeIdentifiers));
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
			var info_plist_path = GetInfoPListPath (platform, app_directory);
			Assert.That (info_plist_path, Does.Exist, "Info.plist");

			var assets_path = string.Empty;
			switch (platform) {
			case ApplePlatform.iOS:
				break; // sample project doesn't have assets
			case ApplePlatform.TVOS:
				assets_path = Path.Combine (app_directory, "Assets.car");
				break;
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


		[TestCase (ApplePlatform.iOS, "bin/Debug/net6.0-ios/iossimulator-x64/MySimpleApp.app/PlugIns/ExtensionProject.appex")]
		[TestCase (ApplePlatform.TVOS, "bin/Debug/net6.0-tvos/tvossimulator-x64/MySimpleApp.app/PlugIns/ExtensionProject.appex")]		
		[TestCase (ApplePlatform.MacOSX, "bin/Debug/net6.0-macos/osx-x64/MySimpleApp.app/Contents/PlugIns/ExtensionProject.appex")]
		// [TestCase ("MacCatalyst", "")] - No extension support yet
		public void BuildProjectsWithExtensions (ApplePlatform platform, string appPath)
		{
			Configuration.IgnoreIfIgnoredPlatform (platform);
			var consumingProjectDir = GetProjectPath ("ExtensionConsumer", platform: platform);
			var extensionProjectDir = GetProjectPath ("ExtensionProject", platform: platform);

			Clean (extensionProjectDir);
			Clean (consumingProjectDir);

			Configuration.CopyDotNetSupportingFiles (Path.GetDirectoryName (extensionProjectDir));
			Configuration.CopyDotNetSupportingFiles (Path.GetDirectoryName (consumingProjectDir));

			DotNet.AssertBuild (consumingProjectDir, verbosity);
			
			var extensionPath = Path.Combine (Path.GetDirectoryName (consumingProjectDir), appPath);
			Assert.That (Directory.Exists (extensionPath), $"App extension directory does not exist: {extensionPath}");
		}
	}
}
