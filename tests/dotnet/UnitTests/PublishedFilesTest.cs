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
		[Test] 
		//[TestCase (ApplePlatform.iOS, "ios-arm64")]
		//[TestCase (ApplePlatform.iOS, "ios-arm64;ios-arm")]
		//[TestCase (ApplePlatform.TVOS, "tvos-arm64")]
		//[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-x64")]
		//[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-arm64;maccatalyst-x64")]
		[TestCase (ApplePlatform.MacOSX, "osx-x64")]
		//[TestCase (ApplePlatform.MacOSX, "osx-arm64;osx-x64")]
		public void BundledFiles (ApplePlatform platform, string runtimeIdentifiers)
		{
			var project = "BundleStructure";
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var project_path = GetProjectPath (project, runtimeIdentifiers: runtimeIdentifiers, platform: platform, out var appPath);
			Clean (project_path);

			DotNet.AssertBuild (project_path, GetDefaultProperties (runtimeIdentifiers));

			var appAssemblyPath = Path.Combine (appPath, GetRelativeAssemblyDirectory (platform));
			AssertFileExistenceAndContents (appAssemblyPath, "A.txt", "A");
			AssertFileExistenceAndContents (appAssemblyPath, "B.dll", "B");
			AssertFileExistenceAndContents (appAssemblyPath, "C.pdb", "C");
			AssertFileExistenceAndContents (appAssemblyPath, "D.exe", "D");
			AssertFileExistenceAndContents (appAssemblyPath, "E.dylib", "E");
			AssertFileExistenceAndContents (appAssemblyPath, "F.a", "F");
			AssertFileExistenceAndContents (appAssemblyPath, "Sub/G.txt", "G");
			AssertFileExistenceAndContents (appAssemblyPath, "H.txt", "H");
			AssertFileExistenceAndContents (appAssemblyPath, "Somewhere/I.txt", "I");
			AssertFileExistenceAndContents (appAssemblyPath, "../Somewhere/Else/J.txt", "J");
			AssertFileExistenceAndContents (appAssemblyPath, "K.txt", "K");
			AssertFileExistenceAndContents (appAssemblyPath, Path.Combine ("..", "Resources", platform.AsString (), "L.txt"), "L");
			AssertFileExistenceAndContents (appAssemblyPath, Path.Combine ("..", "Resources", platform.AsString (), "M.txt"), "M");

			// Assert that we have only the files above, and each of them only once.
			var allFilesInBundle = Directory.GetFileSystemEntries (appPath, "*", SearchOption.AllDirectories);
			var singleLetterFiles = allFilesInBundle.Where (v => Path.GetFileNameWithoutExtension (v).Length == 1).OrderBy (v => v);
			var allSingleLetterFiles = singleLetterFiles.Select (Path.GetFileNameWithoutExtension).OrderBy (v => v);
			CollectionAssert.AllItemsAreUnique (singleLetterFiles.Select (Path.GetFileName), "Each file only once");

			var lastLetter = 'M';
			var allLetters = Enumerable.Range (0, lastLetter - 'A').Select (v => (char) ('A' + v));
			CollectionAssert.AreEqual (allLetters, singleLetterFiles, "All the files");
		}

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
			expectedFiles.Add ($"{assemblyDirectory}NoneE.dylib");
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
			expectedFiles.Add ($"{frameworksDirectory}UnknownD.bin"); // UnknownD.bin: AppleFramework
																	  // UnknownE.bin: CompressedAppleFramework - this should show an error
																	  // UnknownF.bin: AppleBindingResource // FIXME UNDEFINED
			expectedFiles.Add ($"{pluginsDirectory}UnknownG.bin"); // UnknownG.bin: PlugIns
																   // UnknownH.bin: CompressedPlugIns -- this should show an error
																   // UnknownI.bin: Unknown -- this should show a warning
			expectedFiles.Add ($"UnknownJ.bin"); // UnknownJ.bin: RootDirectory

			// SomewhatUnknownA.bin: None
			expectedFiles.Add ($"{assemblyDirectory}Subfolder/SomewhatUnknownB.bin"); // SomewhatUnknownB.bin: Assembly
			expectedFiles.Add ($"{resourcesDirectory}Subfolder/SomewhatUnknownC.bin"); // SomewhatUnknownC.bin: Resource
			expectedFiles.Add ($"{frameworksDirectory}Subfolder/SomewhatUnknownD.bin"); // SomewhatUnknownD.bin: AppleFramework
																						// SomewhatUnknownE.bin: CompressedAppleFramework - this should show an error
																						// SomewhatUnknownF.bin: AppleBindingResource // FIXME UNDEFINED
			expectedFiles.Add ($"{pluginsDirectory}Subfolder/SomewhatUnknownG.bin"); // SomewhatUnknownG.bin: PlugIns
																					// SomewhatUnknownH.bin: CompressedPlugIns -- this should show an error
																					// SomewhatUnknownI.bin: SomewhatUnknown -- this should show a warning
			expectedFiles.Add ($"Subfolder/SomewhatUnknownJ.bin"); // SomewhatUnknownJ.bin: RootDirectory

			expectedFiles.Add ($"{resourcesDirectory}ContentA.txt");
			expectedFiles.Add ($"{resourcesDirectory}ContentB.txt");
			expectedFiles.Add ($"{resourcesDirectory}ContentC.txt");

			expectedFiles.Add ($"{resourcesDirectory}EmbeddedResourceA.txt");
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
				AddExpectedFrameworkFiles (platform, expectedFiles, "XTest2");
				AddExpectedFrameworkFiles (platform, expectedFiles, "XTest3");
				break;
			}

			AddExpectedFrameworkFiles (platform, expectedFiles, "XTest4");
			AddExpectedFrameworkFiles (platform, expectedFiles, "XTest5");

			expectedFiles.Add ($"{assemblyDirectory}bindings-framework-test.dll");
			expectedFiles.Add ($"{assemblyDirectory}bindings-framework-test.pdb");
			AddExpectedFrameworkFiles (platform, expectedFiles, "XTest");

			// misc other files not directly related to the test itself
			expectedFiles.Add ($"{assemblyDirectory}BundleStructure.dll");
			expectedFiles.Add ($"{assemblyDirectory}BundleStructure.pdb");
			expectedFiles.Add ($"{assemblyDirectory}{Configuration.GetBaseLibraryName (platform)}");
			expectedFiles.Add ($"{assemblyDirectory}runtimeconfig.bin");
			expectedFiles.Add ($"{frameworksDirectory}");

			if (platform == ApplePlatform.MacOSX)
				expectedFiles.Add ("Contents/MonoBundle/createdump");

			switch (platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
				expectedFiles.Add ("Info.plist");
				expectedFiles.Add ("BundleStructure");
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

			var unexpectedFiles = allFiles.Except (expectedFiles);
			Console.WriteLine ($"Found {unexpectedFiles.Count ()} unexpected files");
			foreach (var file in unexpectedFiles)
				Console.WriteLine ($"Unexpected file: {file}");
			var missingFiles = expectedFiles.Except (allFiles);
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
		}

		[Test]
		[TestCase (ApplePlatform.iOS, "iossimulator-x64")]
		[TestCase (ApplePlatform.iOS, "ios-arm64;ios-arm")]
		[TestCase (ApplePlatform.TVOS, "tvos-arm64")]
		[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-x64")]
		[TestCase (ApplePlatform.MacCatalyst, "maccatalyst-x64;maccatalyst-arm64")]
		[TestCase (ApplePlatform.MacOSX, "osx-x64")]
		[TestCase (ApplePlatform.MacOSX, "osx-x64;osx-arm64")]
		public void BundleStructure (ApplePlatform platform, string runtimeIdentifiers)
		{
			var project = "BundleStructure";
			Configuration.IgnoreIfIgnoredPlatform (platform);

			var project_path = GetProjectPath (project, runtimeIdentifiers: runtimeIdentifiers, platform: platform, out var appPath);
			Clean (project_path);

			var properties = GetDefaultProperties (runtimeIdentifiers);
			DotNet.AssertBuild (project_path, properties);

			CheckAppBundleContents (platform, appPath);

			var appExecutable = GetNativeExecutable (platform, appPath);
			ExecuteWithMagicWordAndAssert (platform, runtimeIdentifiers, appExecutable);
		}
	}
}
