#nullable enable

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using NUnit.Framework;

using Xamarin.Utils;

namespace Xamarin.Tests {
	[TestFixture]
	public class PublishFilesTest : TestBaseClass {
		void AssertFileExistenceAndContents (string appAssemblyPath, string relativePath, string contents)
		{
			var fullPath = Path.Combine (appAssemblyPath, relativePath);
			Assert.That (fullPath, Does.Exist, "Existence: " + relativePath);
			Assert.That (File.ReadAllText (fullPath).Trim (), Is.EqualTo (contents), "Contents: " + relativePath);
		}

		void CheckAppBundleContents (ApplePlatform platform, string appPath)
		{
			// Directory.GetFileSystemEntries will enter symlink directories and iterate inside :/
			Assert.AreEqual (0, ExecutionHelper.Execute ("find", new string [] { appPath }, out var output), "find");

			var isCoreCLR = platform == ApplePlatform.MacOSX;
			var allFiles = output.ToString ().
								Split ('\n', StringSplitOptions.RemoveEmptyEntries).
								Where (v => v.Length > appPath.Length).
								Select (v => v.Substring (appPath.Length + 1)).ToList ();

			// Remove files from the BCL, the exact set can vary between .NET versions
			Predicate<string?> predicate = (v) => {
				var fn = Path.GetFileName (v!);

				switch (fn) {
				case "libclrjit.dylib":
				case "libcoreclr.dylib":
				case "libdbgshim.dylib":
				case "libhostfxr.dylib":
				case "libhostpolicy.dylib":
				case "libmscordaccore.dylib":
				case "libmscordbi.dylib":
					return platform == ApplePlatform.MacOSX;
				case "libSystem.Native.dylib":
				case "libSystem.Net.Security.Native.dylib":
				case "libSystem.IO.Compression.Native.dylib":
				case "libSystem.Security.Cryptography.Native.Apple.dylib":
				case "libmono-component-debugger.dylib":
				case "libmono-component-diagnostics_tracing.dylib":
				case "libmono-component-hot_reload.dylib":
				case "libmonosgen-2.0.dylib":
					return platform != ApplePlatform.MacOSX;
				case "mscorlib.dll":
				case "WindowsBase.dll":
				case "netstandard.dll":
					return true;
				}

				if (fn.StartsWith ("System.", StringComparison.Ordinal) && (fn.EndsWith (".dll", StringComparison.Ordinal) || fn.EndsWith (".pdb", StringComparison.Ordinal)))
					return true;

				if (fn.StartsWith ("Microsoft.", StringComparison.Ordinal) && (fn.EndsWith (".dll", StringComparison.Ordinal) || fn.EndsWith (".pdb", StringComparison.Ordinal)))
					return true;

				if (fn.StartsWith ("libSystem.", StringComparison.Ordinal) && fn.EndsWith (".dylib", StringComparison.Ordinal))
					return platform == ApplePlatform.MacOSX;

				return false;
			};

			allFiles.RemoveAll (predicate);

			var expectedFiles = new List<string> ();

			var assemblyDirectory = string.Empty;
			var resourcesDirectory = string.Empty;
			var frameworksDirectory = "Frameworks";
			var pluginsDirectory = "PlugIns";
			switch (platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
				break;
			case ApplePlatform.MacCatalyst:
			case ApplePlatform.MacOSX:
				assemblyDirectory = "Contents/MonoBundle/";
				resourcesDirectory = "Contents/Resources/";
				frameworksDirectory = "Contents/Frameworks";
				pluginsDirectory = "Contents/PlugIns";
				break;
			default:
				throw new NotImplementedException ($"Unknown platform: {platform}");
			}

			// Create a list of all the files we expect in the app bundle
			// The files here are listed in the same order they show up in shared.csproj

			// NoneA.txt is not bundled
			expectedFiles.Add ($"{assemblyDirectory}NoneB.dll");
			expectedFiles.Add ($"{assemblyDirectory}NoneB.pdb");
			expectedFiles.Add ($"{assemblyDirectory}NoneB.dll.mdb");
			expectedFiles.Add ($"{assemblyDirectory}NoneB.config");
			expectedFiles.Add ($"{assemblyDirectory}NoneC.pdb");
			expectedFiles.Add ($"{assemblyDirectory}NoneD.exe");
			expectedFiles.Add ($"{assemblyDirectory}libNoneE.dylib");
			// NoneF.a is not bundled
			// Sub/NoneG.txt is not bundled
			// Sub/NoneH.txt is not bundled
			// NoneI.txt is not bundled
			// NoneJ.txt is not bundled
			// NoneK.txt is not bundled
			expectedFiles.Add ($"{assemblyDirectory}NoneL.config");
			// NoneM.unknown is not bundled

			expectedFiles.Add ($"{resourcesDirectory}basn3p08.png");
			expectedFiles.Add ($"{resourcesDirectory}iTunesArtwork.jpg");

			// UnknownA.bin: None
			expectedFiles.Add ($"{assemblyDirectory}UnknownB.bin"); // UnknownB.bin: Assembly
			expectedFiles.Add ($"{resourcesDirectory}UnknownC.bin"); // UnknownC.bin: Resource
			AddExpectedFrameworkFiles (platform, expectedFiles, "UnknownD"); // UnknownD: AppleFramework
			AddExpectedFrameworkFiles (platform, expectedFiles, "UnknownE"); // UnknownE: CompressedAppleFramework
			AddExpectedFrameworkFiles (platform, expectedFiles, "UnknownF1"); // UnknownF1.bin: AppleBindingResource 
			AddExpectedFrameworkFiles (platform, expectedFiles, "UnknownF2"); // UnknownF2.bin: AppleBindingResource (compressed)
			expectedFiles.Add ($"{pluginsDirectory}/UnknownG.bin"); // UnknownG.bin: PlugIns
			expectedFiles.Add ($"{pluginsDirectory}/UnknownH.bin");
			expectedFiles.Add ($"{pluginsDirectory}/UnknownH.bin/UnknownH.bin"); // UnknownH.bin: CompressedPlugIns
																	// UnknownI.bin: Unknown -- this should show a warning
			expectedFiles.Add ($"UnknownJ.bin"); // UnknownJ.bin: RootDirectory

			// SomewhatUnknownA.bin: None
			expectedFiles.Add ($"{assemblyDirectory}Subfolder/SomewhatUnknownB.bin"); // SomewhatUnknownB.bin: Assembly
			expectedFiles.Add ($"{resourcesDirectory}Subfolder/SomewhatUnknownC.bin"); // SomewhatUnknownC.bin: Resource

			AddExpectedFrameworkFiles (platform, expectedFiles, "SomewhatUnknownD"); // SomewhatUnknownD.bin: AppleFramework
			AddExpectedFrameworkFiles (platform, expectedFiles, "SomewhatUnknownE"); // SomewhatUnknownE.bin: CompressedAppleFramework
			AddExpectedFrameworkFiles (platform, expectedFiles, "SomewhatUnknownF1"); // SomewhatUnknownF1.bin: AppleBindingResource
			AddExpectedFrameworkFiles (platform, expectedFiles, "SomewhatUnknownF2"); // SomewhatUnknownF2.bin: AppleBindingResource (compressed)
			expectedFiles.Add ($"{pluginsDirectory}/Subfolder/SomewhatUnknownG.bin"); // SomewhatUnknownG.bin: PlugIns
			expectedFiles.Add ($"{pluginsDirectory}/Subfolder/SomewhatUnknownH.bin");
			expectedFiles.Add ($"{pluginsDirectory}/Subfolder/SomewhatUnknownH.bin/SomewhatUnknownH.bin"); // SomewhatUnknownH.bin: CompressedPlugIns
																										   // SomewhatUnknownI.bin: SomewhatUnknown -- this should show a warning
			expectedFiles.Add ($"Subfolder");
			expectedFiles.Add ($"Subfolder/SomewhatUnknownJ.bin"); // SomewhatUnknownJ.bin: RootDirectory

			expectedFiles.Add ($"{resourcesDirectory}ContentA.txt");
			expectedFiles.Add ($"{resourcesDirectory}ContentB.txt");
			expectedFiles.Add ($"{resourcesDirectory}ContentC.txt");

			// expectedFiles.Add ($"{resourcesDirectory}EmbeddedResourceA.txt");
			expectedFiles.Add ($"{resourcesDirectory}EmbeddedResourceB.txt");
			expectedFiles.Add ($"{resourcesDirectory}EmbeddedResourceC.txt");

			expectedFiles.Add ($"{resourcesDirectory}BundleResourceA.txt");
			expectedFiles.Add ($"{resourcesDirectory}BundleResourceB.txt");
			expectedFiles.Add ($"{resourcesDirectory}BundleResourceC.txt");

			expectedFiles.Add ($"{assemblyDirectory}FrameworksInRuntimesNativeDirectory.dll");
			AddExpectedFrameworkFiles (platform, expectedFiles, "FrameworksInRuntimesNativeDirectory1");
			AddExpectedFrameworkFiles (platform, expectedFiles, "FrameworksInRuntimesNativeDirectory2");

			switch (platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
				AddExpectedFrameworkFiles (platform, expectedFiles, "FrameworkTest2");
				AddExpectedFrameworkFiles (platform, expectedFiles, "FrameworkTest3");
				break;
			}

			AddExpectedFrameworkFiles (platform, expectedFiles, "FrameworkTest4");
			AddExpectedFrameworkFiles (platform, expectedFiles, "FrameworkTest5");

			expectedFiles.Add ($"{assemblyDirectory}bindings-framework-test.dll");
			expectedFiles.Add ($"{assemblyDirectory}bindings-framework-test.pdb");
			AddExpectedFrameworkFiles (platform, expectedFiles, "XTest");

			// various directories
			expectedFiles.Add (frameworksDirectory);
			expectedFiles.Add (pluginsDirectory);
			expectedFiles.Add ($"{pluginsDirectory}/Subfolder");

			// misc other files not directly related to the test itself
			if (!isCoreCLR)
				expectedFiles.Add ($"{assemblyDirectory}icudt.dat");
			expectedFiles.Add ($"{assemblyDirectory}BundleStructure.dll");
			expectedFiles.Add ($"{assemblyDirectory}BundleStructure.pdb");
			expectedFiles.Add ($"{assemblyDirectory}MonoTouch.Dialog.dll");
			expectedFiles.Add ($"{assemblyDirectory}MonoTouch.Dialog.pdb");
			expectedFiles.Add ($"{assemblyDirectory}nunit.framework.dll");
			expectedFiles.Add ($"{assemblyDirectory}nunitlite.dll");
			expectedFiles.Add ($"{assemblyDirectory}Touch.Client.dll");
			expectedFiles.Add ($"{assemblyDirectory}Touch.Client.pdb");
			expectedFiles.Add ($"{assemblyDirectory}{Configuration.GetBaseLibraryName (platform)}");
			expectedFiles.Add ($"{assemblyDirectory}runtimeconfig.bin");

			if (platform == ApplePlatform.MacOSX)
				expectedFiles.Add ("Contents/MonoBundle/createdump");

			switch (platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
				expectedFiles.Add ("BundleStructure");
				expectedFiles.Add ("Info.plist");
				expectedFiles.Add ("MonoTouchDebugConfiguration.txt");
				expectedFiles.Add ("PkgInfo");
				expectedFiles.Add ("Settings.bundle");
				expectedFiles.Add ("Settings.bundle/Root.plist");
				expectedFiles.Add ("libxamarin-dotnet-debug.dylib");
				break;
			case ApplePlatform.MacCatalyst:
			case ApplePlatform.MacOSX:
				expectedFiles.Add ("Contents");
				expectedFiles.Add ("Contents/Info.plist");
				expectedFiles.Add ("Contents/MacOS");
				expectedFiles.Add ("Contents/MacOS/BundleStructure");
				expectedFiles.Add ("Contents/MonoBundle");
				expectedFiles.Add ("Contents/PkgInfo");
				expectedFiles.Add ("Contents/Resources");
				break;
			}

			var unexpectedFiles = allFiles.Except (expectedFiles).OrderBy (v => v).ToArray ();
			var missingFiles = expectedFiles.Except (allFiles).OrderBy (v => v).ToArray ();
			if (unexpectedFiles.Any () || missingFiles.Any ()) {
				Console.WriteLine ($"All files in the bundle ({allFiles.Count ()})");
				foreach (var file in allFiles.OrderBy (v => v)) {
					Console.WriteLine ($"    {file}");
				}
				Console.WriteLine ("---------------------------------------");
			}
			Console.WriteLine ($"Found {unexpectedFiles.Count ()} unexpected files");
			foreach (var file in unexpectedFiles)
				Console.WriteLine ($"Unexpected file: {file}");
			Console.WriteLine ($"Found {missingFiles.Count ()} missing files");
			foreach (var file in missingFiles)
				Console.WriteLine ($"Missing file: {file}");

			Assert.That (unexpectedFiles, Is.Empty, "No unexpected files");
			Assert.That (missingFiles, Is.Empty, "No missing files");
		}

		static void AddExpectedFrameworkFiles (ApplePlatform platform, List<string> expectedFiles, string frameworkName)
		{
			var frameworksDirectory = "Frameworks";
			switch (platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
				break;
			case ApplePlatform.MacCatalyst:
			case ApplePlatform.MacOSX:
				frameworksDirectory = "Contents/Frameworks";
				break;
			default:
				throw new NotImplementedException ($"Unknown platform: {platform}");
			}

			expectedFiles.Add ($"{frameworksDirectory}/{frameworkName}.framework");
			expectedFiles.Add ($"{frameworksDirectory}/{frameworkName}.framework/{frameworkName}");
			switch (platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
				expectedFiles.Add ($"{frameworksDirectory}/{frameworkName}.framework/Info.plist");
				break;
			case ApplePlatform.MacCatalyst:
			case ApplePlatform.MacOSX:
				expectedFiles.Add ($"{frameworksDirectory}/{frameworkName}.framework/Resources");
				expectedFiles.Add ($"{frameworksDirectory}/{frameworkName}.framework/Versions");
				expectedFiles.Add ($"{frameworksDirectory}/{frameworkName}.framework/Versions/A");
				expectedFiles.Add ($"{frameworksDirectory}/{frameworkName}.framework/Versions/A/Resources");
				expectedFiles.Add ($"{frameworksDirectory}/{frameworkName}.framework/Versions/A/Resources/Info.plist");
				expectedFiles.Add ($"{frameworksDirectory}/{frameworkName}.framework/Versions/A/{frameworkName}");
				expectedFiles.Add ($"{frameworksDirectory}/{frameworkName}.framework/Versions/Current");
				break;
			default:
				throw new NotImplementedException ($"Unknown platform: {platform}");
			}

			expectedFiles.Add ($"{frameworksDirectory}/{frameworkName}.framework/_CodeSignature");
			expectedFiles.Add ($"{frameworksDirectory}/{frameworkName}.framework/_CodeSignature/CodeResources");
		}

		[Test]
		[TestCase (ApplePlatform.iOS, "iossimulator-x64")]
		//[TestCase (ApplePlatform.iOS, "ios-arm64;ios-arm")]
		//[TestCase (ApplePlatform.TVOS, "tvos-arm64")]
		//[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-x64")]
		//[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-x64;maccatalyst-arm64")]
		//[TestCase (ApplePlatform.MacOSX, "osx-x64")]
		//[TestCase (ApplePlatform.MacOSX, "osx-x64;osx-arm64")]
		public void BundleStructure (ApplePlatform platform, string runtimeIdentifiers)
		{
			var project = "BundleStructure";
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var project_path = GetProjectPath (project, runtimeIdentifiers: runtimeIdentifiers, platform: platform, out var appPath);
			var project_dir = Path.GetDirectoryName (Path.GetDirectoryName (project_path));
			Clean (project_path);

			var properties = GetDefaultProperties (runtimeIdentifiers);
			var rv = DotNet.AssertBuild (project_path, properties);
			var warnings = BinLog.GetBuildLogWarnings (rv.BinLogPath).ToArray ();
			Console.WriteLine ($"Found {warnings.Length} warnings:");
			foreach (var w in warnings)
				Console.WriteLine ($"    Warning: {w.Message}");

			var platformString = platform.AsString ();
			var tfm = platform.ToFramework ();
			var testsDirectory = Path.GetDirectoryName (Path.GetDirectoryName (project_dir));
			var warningMessages = warnings.Select (v => v.Message).OrderBy (v => v).ToArray ();
			var expectedWarnings = new string [] {
				$"The file '{project_dir}/{platformString}/NoneA.txt' does not specify a 'PublishFolderType' metadata, and a default value could not be calculated. The file will not be copied to the app bundle.",
				$"The file '{project_dir}/{platformString}/Sub/NoneG.txt' does not specify a 'PublishFolderType' metadata, and a default value could not be calculated. The file will not be copied to the app bundle.",
				$"The file '{project_dir}/NoneH.txt' does not specify a 'PublishFolderType' metadata, and a default value could not be calculated. The file will not be copied to the app bundle.",
				$"The file '{project_dir}/{platformString}/NoneI.txt' does not specify a 'PublishFolderType' metadata, and a default value could not be calculated. The file will not be copied to the app bundle.",
				$"The file '{project_dir}/{platformString}/NoneJ.txt' does not specify a 'PublishFolderType' metadata, and a default value could not be calculated. The file will not be copied to the app bundle.",
				$"The file '{project_dir}/{platformString}/NoneK.txt' does not specify a 'PublishFolderType' metadata, and a default value could not be calculated. The file will not be copied to the app bundle.",
				$"The file '{project_dir}/{platformString}/NoneM.unknown' does not specify a 'PublishFolderType' metadata, and a default value could not be calculated. The file will not be copied to the app bundle.",
				$"The 'PublishFolderType' metadata value 'Unknown' on the item '{project_dir}/{platformString}/SomewhatUnknownI.bin' is not recognized. The file will not be copied to the app bundle. If the file is not supposed to be copied to the app bundle, remove the 'CopyToOutputDirectory' metadata on the item.",
				$"The 'PublishFolderType' metadata value 'Unknown' on the item '{project_dir}/{platformString}/UnknownI.bin' is not recognized. The file will not be copied to the app bundle. If the file is not supposed to be copied to the app bundle, remove the 'CopyToOutputDirectory' metadata on the item.",
				$"The framework {testsDirectory}/bindings-framework-test/dotnet/{platform}/bin/Debug/{tfm}/bindings-framework-test.resources/XStaticObjectTest.framework is a framework of static libraries, and will not be copied to the app.",
				$"The framework {testsDirectory}/bindings-framework-test/dotnet/{platform}/bin/Debug/{tfm}/bindings-framework-test.resources/XStaticArTest.framework is a framework of static libraries, and will not be copied to the app.",
			}.OrderBy (v => v).ToArray ();

			Assert.AreEqual (11, warnings.Length, $"Warning Count:\n\t{string.Join ("\n\t", warningMessages)}");
			CollectionAssert.AreEqual (expectedWarnings, warningMessages, "Warnings");

			CheckAppBundleContents (platform, appPath);

			var appExecutable = GetNativeExecutable (platform, appPath);
			ExecuteWithMagicWordAndAssert (platform, runtimeIdentifiers, appExecutable);
		}
	}
}
