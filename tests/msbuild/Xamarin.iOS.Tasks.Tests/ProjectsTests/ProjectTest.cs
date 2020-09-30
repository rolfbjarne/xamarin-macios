using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Microsoft.Build.Evaluation;

namespace Xamarin.iOS.Tasks
{
	public class ProjectTest : TestBase {
		public string BundlePath;
		public string Platform;
		public ExecutionMode? Mode;

		public ProjectTest (string platform)
		{
			Platform = platform;
		}

		public ProjectTest (string platform, ExecutionMode executionMode)
		{
			Platform = platform;
			Mode = executionMode;
		}

		public ProjectTest (string bundlePath, string platform)
		{
			BundlePath = bundlePath;
			Platform = platform;
		}

		public ProjectTest (string bundlePath, string platform, ExecutionMode executionMode)
		{
			BundlePath = bundlePath;
			Platform = platform;
			Mode = executionMode;
		}

		[SetUp]
		public override void Setup () 
		{
			AssertValidDeviceBuild (Platform);
			SetupEngine ();
		}

		public ProjectPaths BuildProject (string appName, string platform, string config, int expectedErrorCount = 0, bool clean = true, string projectBaseDir = "../", ExecutionMode? executionMode = null, bool nuget_restore = false)
		{
			// If the execution mode isn't passed in, use the class-level variable
			executionMode ??= Mode;
			// If the class-level variable isn't set either, default to InProcess
			executionMode ??= ExecutionMode.InProcess;

			var mtouchPaths = SetupProjectPaths (appName, appName, projectBaseDir, includePlatform: true, platform: platform, config: config, is_dotnet: executionMode == ExecutionMode.DotNet);
			var csproj = mtouchPaths.ProjectCSProjPath;

			Project proj = null;
			if (executionMode != ExecutionMode.DotNet)
				proj = SetupProject (Engine, csproj);

			AppBundlePath = mtouchPaths.AppBundlePath;
			Engine.ProjectCollection.SetGlobalProperty("Platform", platform);
			Engine.ProjectCollection.SetGlobalProperty("Configuration", config);

			if (nuget_restore)
				NugetRestore (csproj);

			if (clean) {
				RunTarget (proj, csproj, "Clean", executionMode.Value);
				Assert.IsFalse (Directory.Exists (AppBundlePath), "App bundle exists after cleanup: {0} ", AppBundlePath);
				Assert.IsFalse (Directory.Exists (AppBundlePath + ".dSYM"), "App bundle .dSYM exists after cleanup: {0} ", AppBundlePath + ".dSYM");
				Assert.IsFalse (Directory.Exists (AppBundlePath + ".mSYM"), "App bundle .mSYM exists after cleanup: {0} ", AppBundlePath + ".mSYM");

				var baseDir = Path.GetDirectoryName (csproj);
				var objDir = Path.Combine (baseDir, "obj", platform, config);
				var binDir = Path.Combine (baseDir, "bin", platform, config);

				if (Directory.Exists (objDir)) {
					var paths = Directory.EnumerateFiles (objDir, "*.*", SearchOption.AllDirectories)
							.Where (v => !v.EndsWith (".FileListAbsolute.txt", StringComparison.Ordinal))
							.Where (v => !v.EndsWith (".assets.cache", StringComparison.Ordinal));
					Assert.IsEmpty (paths, "Files not cleaned:\n\t{0}", string.Join ("\n\t", paths));
				}

				if (Directory.Exists (binDir)) {
					var paths = Directory.EnumerateFiles (binDir, "*.*", SearchOption.AllDirectories);
					Assert.IsEmpty (paths, "Files not cleaned:\n\t{0}", string.Join ("\n\t", paths));
				}
			}

			if (executionMode != ExecutionMode.DotNet)
				proj = SetupProject (Engine, mtouchPaths.ProjectCSProjPath);

			RunTarget (proj, csproj, "Build", executionMode.Value, expectedErrorCount);

			if (expectedErrorCount > 0)
				return mtouchPaths;

			Assert.IsTrue (Directory.Exists (AppBundlePath), "App Bundle does not exist: {0} ", AppBundlePath);

			TestFilesExists (AppBundlePath, ExpectedAppFiles);
			TestFilesDoNotExist (AppBundlePath, UnexpectedAppFiles);

			if (executionMode != ExecutionMode.DotNet) {
				var coreFiles = GetCoreAppFiles (platform, config, appName.Replace (" ", "") + ".exe", appName.Replace (" ", ""));
				var baseDirs = new string [] {
				Path.Combine (AppBundlePath, ".monotouch-32"),
				Path.Combine (AppBundlePath, ".monotouch-64"),
				AppBundlePath,
				Path.Combine (AppBundlePath, "Frameworks", "Xamarin.Sdk.framework", "MonoBundle", ".monotouch-32"),
				Path.Combine (AppBundlePath, "Frameworks", "Xamarin.Sdk.framework", "MonoBundle", ".monotouch-64"),
				Path.Combine (AppBundlePath, "Frameworks", "Xamarin.Sdk.framework", "MonoBundle"),
			};
				TestFilesExists (baseDirs, coreFiles);
			}

			if (platform == "iPhone") {
				var dSYMInfoPlist = Path.Combine (AppBundlePath + ".dSYM", "Contents", "Info.plist");
				var nativeExecutable = Path.Combine (AppBundlePath, appName);

				Assert.IsTrue (File.Exists (dSYMInfoPlist), "dSYM Info.plist file does not exist");
				Assert.IsTrue (File.GetLastWriteTimeUtc (dSYMInfoPlist) >= File.GetLastWriteTimeUtc (nativeExecutable), "dSYM Info.plist should be newer than the native executable");
			}

			return mtouchPaths;
		}
	}
}

