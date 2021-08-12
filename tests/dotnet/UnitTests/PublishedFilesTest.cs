#nullable enable

using System;
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
	}
}
