using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Utilities;
using NUnit.Framework;
using Xamarin.MacDev;

using Xamarin.Tests;
using Xamarin.Utils;

namespace Xamarin.iOS.Tasks
{
	public abstract class TestBase
	{
		protected static class TargetName
		{
			public static string Build = "Build";
			public static string Clean = "Clean";
			public static string CollectBundleResources = "_CollectBundleResources";
			public static string CompileImageAssets = "_CompileImageAssets";
			public static string CompileInterfaceDefinitions = "_CompileInterfaceDefinitions";
			public static string CopyResourcesToBundle = "_CopyResourcesToBundle";
			public static string DetectAppManifest = "_DetectAppManifest";
			public static string GenerateBundleName = "_GenerateBundleName";
			public static string PackLibraryResources = "_PackLibraryResources";
			public static string ResolveReferences = "ResolveReferences";
		}

		protected static string GetTestDirectory (string mode = null)
		{
			var assembly_path = Assembly.GetExecutingAssembly ().Location;
			if (string.IsNullOrEmpty (mode)) {
				if (assembly_path.Contains ("netstandard2.0"))
					mode = "netstandard2.0";
				else if (assembly_path.Contains ("net461"))
					mode = "net461";
				else
					mode = "unknown";
			}

			var testSourceDirectory = Path.Combine (Configuration.RootPath, "msbuild", "tests");
			return Configuration.CloneTestDirectory (testSourceDirectory, mode);
		}

		public string [] ExpectedAppFiles = { };
		public string [] UnexpectedAppFiles = { "monotouch.dll" };

		public string[] GetCoreAppFiles (string platform, string config, string managedExe, string nativeExe)
		{
			var coreFiles = new List<string> ();

			if (TargetFrameworkIdentifier == "Xamarin.WatchOS") {
				coreFiles.Add ("Xamarin.WatchOS.dll");
				if (config == "Debug")
					coreFiles.Add ("Xamarin.WatchOS.pdb");
			} else if (TargetFrameworkIdentifier == "Xamarin.TVOS") {
				coreFiles.Add ("Xamarin.TVOS.dll");
				if (config == "Debug")
					coreFiles.Add ("Xamarin.TVOS.pdb");
			} else {
				coreFiles.Add ("Xamarin.iOS.dll");
				if (config == "Debug")
					coreFiles.Add ("Xamarin.iOS.pdb");
			}

			coreFiles.Add ("mscorlib.dll");
			if (config == "Debug")
				coreFiles.Add ("mscorlib.pdb");

			coreFiles.Add (managedExe);
			if (config == "Debug")
				coreFiles.Add (Path.ChangeExtension (managedExe, ".pdb"));

			coreFiles.Add (nativeExe);

			return coreFiles.ToArray ();
		}

		public Logger Logger {
			get; set;
		}

		public TestEngine Engine {
			get; private set;
		}


		public Project LibraryProject {
			get; private set;
		}

		public ProjectInstance LibraryProjectInstance {
			get; set;
		}

		public Project MonoTouchProject {
			get; private set;
		}

		public ProjectInstance MonoTouchProjectInstance {
			get; set;
		}

		public string LibraryProjectBinPath;
		public string LibraryProjectObjPath;
		public string LibraryProjectPath;
		public string LibraryProjectCSProjPath;

		public string MonoTouchProjectBinPath;
		public string MonoTouchProjectObjPath;
		public string MonoTouchProjectPath;
		public string MonoTouchProjectCSProjPath;
		public string AppBundlePath;

		public string TempDir {
			get; set;
		}

		public ProjectPaths SetupProjectPaths (string projectName, string csprojName, string baseDir = "../", bool includePlatform = true, string platform = "iPhoneSimulator", string config = "Debug", bool use_dotnet = false)
		{
			string projectPath;
			if (Path.IsPathRooted (baseDir)) {
				projectPath = Path.Combine (baseDir, projectName);
			} else {
				var testsBase = GetTestDirectory ();
				projectPath = Path.Combine (testsBase, "Xamarin.iOS.Tasks.Tests", baseDir, projectName);
			}

			string binPath;
			string objPath;
			if (use_dotnet) {
				var targetPlatform = platform == "iPhone" ? "Device" : "Simulator";
				var subdir = string.Empty;
				switch (TargetFrameworkIdentifier) {
				case "Xamarin.iOS":
					subdir = "xamarinios10";
					break;
				case "Xamarin.TVOS":
					subdir = "xamarintvos10";
					break;
				case "Xamarin.WatchOS":
					subdir = "xamarinwatchos10";
					break;
				default:
					throw new NotImplementedException ($"Unknown TargetFrameworkIdentifier: {TargetFrameworkIdentifier}");
				}
				binPath = Path.Combine (projectPath, "bin", platform, config, targetPlatform, subdir);
				objPath = Path.Combine (projectPath, "obj", platform, config, targetPlatform, subdir);
			} else {
				binPath = includePlatform ? Path.Combine (projectPath, "bin", platform, config) : Path.Combine (projectPath, "bin", config);
				objPath = includePlatform ? Path.Combine (projectPath, "obj", platform, config) : Path.Combine (projectPath, "obj", config);
			}			
			
			return new ProjectPaths {
				ProjectPath = projectPath,
				ProjectBinPath = binPath,
				ProjectObjPath = objPath,
				ProjectCSProjPath = Path.Combine (projectPath, csprojName + ".csproj"),
				AppBundlePath = Path.Combine (binPath, projectName.Replace (" ", "") + ".app"),
			};
		}

		public ProjectPaths SetupProjectPaths (string projectName, string baseDir = "../", bool includePlatform = true, string platform = "iPhoneSimulator", string config = "Debug", bool use_dotnet = false)
		{
			return SetupProjectPaths (projectName, projectName, baseDir, includePlatform, platform, config, use_dotnet);
		}

		[SetUp]
		public virtual void Setup ()
		{
			var mtouchPaths = SetupProjectPaths ("MySingleView");

			MonoTouchProjectBinPath = mtouchPaths ["project_binpath"];
			MonoTouchProjectObjPath = mtouchPaths ["project_objpath"];
			MonoTouchProjectCSProjPath = mtouchPaths ["project_csprojpath"];
			MonoTouchProjectPath = mtouchPaths ["project_path"];

			AppBundlePath = mtouchPaths ["app_bundlepath"];

			var libraryPaths = SetupProjectPaths ("MyLibrary", "../MySingleView/", false);

			LibraryProjectBinPath = libraryPaths ["project_binpath"];
			LibraryProjectObjPath = libraryPaths ["project_objpath"];
			LibraryProjectPath = libraryPaths ["project_path"];
			LibraryProjectCSProjPath = libraryPaths ["project_csprojpath"];

			SetupEngine ();

			MonoTouchProject = SetupProject (Engine, MonoTouchProjectCSProjPath);
			MonoTouchProjectInstance = MonoTouchProject.CreateProjectInstance ();
			LibraryProject = SetupProject (Engine, LibraryProjectCSProjPath);
			LibraryProjectInstance = LibraryProject.CreateProjectInstance ();

			CleanUp ();
		}

		public void SetupEngine () 
		{
			Engine = new TestEngine ();
		}

		public Project SetupProject (TestEngine engine, string projectPath)
		{
			return engine.ProjectCollection.LoadProject (projectPath);
		}

		public virtual string TargetFrameworkIdentifier {
			get {
				return "Xamarin.iOS";
			}
		}

		public bool IsWatchOS {
			get { return TargetFrameworkIdentifier == "Xamarin.WatchOS"; }
		}

		public bool IsTVOS {
			get { return TargetFrameworkIdentifier == "Xamarin.TVOS"; }
		}

		public void CleanUp () {

			var paths = SetupProjectPaths ("MySingleView");
			MonoTouchProjectPath = paths ["project_path"];

			TempDir = Path.Combine (Path.GetDirectoryName (Assembly.GetExecutingAssembly ().Location), "ScratchDir");
			SafeDelete (TempDir);
			Directory.CreateDirectory (TempDir);

			// Ensure the bin and obj directories are cleared
			SafeDelete (Path.Combine (MonoTouchProjectPath, "bin"));
			SafeDelete (Path.Combine (MonoTouchProjectPath, "obj"));

			SafeDelete (Path.Combine (LibraryProjectPath, "bin"));
			SafeDelete (Path.Combine (LibraryProjectPath, "obj"));

			// Reset all the write times as we deliberately set some in the future for our tests
			foreach (var file in Directory.GetFiles (MonoTouchProjectPath, "*.*", SearchOption.AllDirectories))
				File.SetLastWriteTimeUtc (file, DateTime.UtcNow);
			foreach (var file in Directory.GetFiles (LibraryProjectPath, "*.*", SearchOption.AllDirectories))
				File.SetLastWriteTimeUtc (file, DateTime.UtcNow);

			Engine.UnloadAllProjects ();
			Engine = new TestEngine ();
		}

		protected void SafeDelete (string path)
		{
			try {
				if (Directory.Exists (path))
					Directory.Delete (path, true);
				else if (File.Exists (path))
					File.Delete (path);
			} catch {

			}
		}

		public void TestFilesDoNotExist(string baseDir, IEnumerable<string> files)
		{
			foreach (var v in files.Select (s => Path.Combine (baseDir, s)))
				Assert.IsFalse (File.Exists (v) || Directory.Exists (v), "Unexpected file: {0} exists", v);
		}

		public void TestFilesExists (string baseDir, string[] files)
		{
			foreach (var v in files.Select (s => Path.Combine (baseDir, s)))
				Assert.IsTrue (File.Exists (v) || Directory.Exists (v), "Expected file: {0} does not exist", v);
		}

		public void TestFilesExists (string [] baseDirs, string [] files)
		{

			if (baseDirs.Length == 1) {
				TestFilesExists (baseDirs [0], files);
			} else {
				foreach (var file in files)
					Assert.IsTrue (baseDirs.Select (s => File.Exists (Path.Combine (s, file))).Any (v => v), $"Expected file: {file} does not exist in any of the directories: {string.Join (", ", baseDirs)}");
			}
		}

		public void TestStoryboardC (string path) 
		{
			Assert.IsTrue (Directory.Exists (path), "Storyboard {0} does not exist", path);
			Assert.IsTrue (File.Exists (Path.Combine (path, "Info.plist")));
			TestPList (path, new string [] {"CFBundleVersion", "CFBundleExecutable"});
		}

		public void TestPList (string path, string[] keys)
		{
			var plist = PDictionary.FromFile (Path.Combine (path, "Info.plist"));
			foreach (var x in keys) {
				Assert.IsTrue (plist.ContainsKey (x), "Key {0} is not present in {1} Info.plist", x, path);
				Assert.IsNotEmpty (((PString)plist[x]).Value, "Key {0} is empty in {1} Info.plist", x, path);
			}
		}

		[TearDown]
		public virtual void Teardown ()
		{
			SafeDelete (TempDir);
		}

		public T CreateTask<T> () where T : Task, new()
		{
			var t = new T ();
			t.BuildEngine = Engine;
			return t;
		}

		/// <summary>
		/// Executes the task and log its error messages.</summary>
		/// <remarks>
		/// This is the prefered way to run tasks as we want error messages to show up in the test results.</remarks>
		/// <param name="task">An msbuild task.</param>
		/// <param name="expectedErrorCount">Expected error count. 0 by default.</param>
		public void ExecuteTask (Task task, int expectedErrorCount = 0)
		{
			task.Execute ();
			if (expectedErrorCount != Engine.Logger.ErrorEvents.Count) {
				string messages = string.Empty;
				if (Engine.Logger.ErrorEvents.Count > 0) {
					messages = "\n\t" + string.Join ("\n\t", Engine.Logger.ErrorEvents.Select ((v) => v.Message).ToArray ());
				}
				Assert.AreEqual (expectedErrorCount, Engine.Logger.ErrorEvents.Count, "#RunTask-ErrorCount" + messages);
			}
		}

		protected string CreateTempFile (string path)
		{
			path = Path.Combine (TempDir, path);
			Directory.CreateDirectory (Path.GetDirectoryName (path));
			using (new FileStream (path, FileMode.CreateNew)) {}
			return path;
		}

		protected DateTime GetLastModified (string file)
		{
			if (Path.GetExtension (file) == ".nib" && !File.Exists (file))
				file = Path.Combine (file, "runtime.nib");

			if (!File.Exists (file))
				Assert.Fail ("Expected file '{0}' did not exist", file);

			return File.GetLastWriteTimeUtc (file);
		}

		protected void RemoveItemsByName (Project project, string itemName)
		{
			project.RemoveItems (project.GetItems (itemName));
		}

		protected string SetPListKey (string key, PObject value)
		{

			var paths = SetupProjectPaths ("MySingleView");

			var plist = PDictionary.FromFile (Path.Combine (paths ["project_path"], "Info.plist"));
			if (value == null)
				plist.Remove (key);
			else
				plist [key] = value;

			var modifiedPListPath = Path.Combine (TempDir, "modified.plist");
			plist.Save (modifiedPListPath);
			return modifiedPListPath;
		}

		protected void Touch (string file)
		{
			if (!File.Exists (file))
				Assert.Fail ("Expected file '{0}' did not exist", file);
			EnsureFilestampChange ();
			File.SetLastWriteTimeUtc (file, DateTime.UtcNow);
			EnsureFilestampChange ();
		}

		static bool? is_apfs;
		public static bool IsAPFS {
			get {
				if (!is_apfs.HasValue) {
					var exit_code = ExecutionHelper.Execute ("/bin/df", new string[] { "-t", "apfs", "/" }, out var output, TimeSpan.FromSeconds (10));
					is_apfs = exit_code == 0 && output.Trim ().Split ('\n').Length >= 2;
				}
				return is_apfs.Value;
			}
		}

		public static void EnsureFilestampChange ()
		{
			if (IsAPFS)
				return;
			Thread.Sleep (1000);
		}

		public void RunTarget (Project project, string target, int expectedErrorCount = 0)
		{
			RunTarget (project, null, target, false, expectedErrorCount);
		}
		public void RunTarget (Project project, string project_path, string target, bool use_dotnet, int expectedErrorCount = 0)
		{
			if (use_dotnet) {
				if (expectedErrorCount != 0)
					throw new NotImplementedException ();
				var platform = Engine.ProjectCollection.GetGlobalProperty ("Platform")?.EvaluatedValue;
				var configuration = Engine.ProjectCollection.GetGlobalProperty ("Configuration")?.EvaluatedValue;
				var dict = new Dictionary<string, string> ();
				if (!string.IsNullOrEmpty (platform))
					dict ["Platform"] = platform;
				if (!string.IsNullOrEmpty (configuration))
					dict ["Configuration"] = configuration;
				Dotnet (target, project_path, dict);
			} else {
				RunTargetOnInstance (project.CreateProjectInstance (), target, expectedErrorCount);
			}
		}

		public void Dotnet (string command, string project, Dictionary<string, string> properties)
		{
			if (properties == null)
				properties = new Dictionary<string, string> ();
			properties.Add ("XamarinMacFrameworkRoot", Configuration.SdkRootXM);
			properties.Add ("MD_MTOUCH_SDK_ROOT", Configuration.SdkRootXI);
			DotNet.Execute (command, project, properties, out var _, assert_success: true);
		}

		public void RunTargetOnInstance (ProjectInstance instance, string target, int expectedErrorCount = 0)
		{
			Engine.BuildProject (instance, new [] { target }, new Hashtable { {"Platform", "iPhone"} });
			if (expectedErrorCount != Engine.Logger.ErrorEvents.Count) {
				string messages = string.Empty;
				if (Engine.Logger.ErrorEvents.Count > 0) {
					messages = "\n\t" + string.Join ("\n\t", Engine.Logger.ErrorEvents.Select ((v) => v.Message).ToArray ());
				}
				Assert.AreEqual (expectedErrorCount, Engine.Logger.ErrorEvents.Count, "#RunTarget-ErrorCount" + messages);
			}
		}

		public void RunTarget_WithErrors (Project project, string target)
		{
			RunTarget_WithErrors (project.CreateProjectInstance (), target);
		}

		public void RunTarget_WithErrors (ProjectInstance instance, string target)
		{
			Engine.BuildProject (instance, new [] { target }, new Hashtable ());
			Assert.IsTrue (Engine.Logger.ErrorEvents.Count > 0, "#RunTarget-HasExpectedErrors");
		}

		protected void AssertValidDeviceBuild (string platform)
		{
			if (!Xamarin.Tests.Configuration.include_device && platform == "iPhone")
				Assert.Ignore ("This build does not include device support.");
		}

		public static void NugetRestore (string project)
		{
			var rv = ExecutionHelper.Execute ("nuget", new string[] { "restore", project }, out var output);
			if (rv != 0) {
				Console.WriteLine ("nuget restore failed:");
				Console.WriteLine (output);
				Assert.Fail ($"'nuget restore' failed for {project}");
			}
		}

		/// <summary>
		/// Returns true if a target was skipped.
		/// Originally from: https://github.com/xamarin/xamarin-android/blob/320cb0f66730e7107cc17310b99cd540605a234d/src/Xamarin.Android.Build.Tasks/Tests/Xamarin.ProjectTools/Common/BuildOutput.cs#L48-L62
		/// </summary>
		public bool IsTargetSkipped (string target)
		{
			foreach (var line in Engine.Logger.MessageEvents.Select (m => m.Message)) {
				if (line.Contains ($"Building target \"{target}\" completely")
					|| line.Contains ($"Done building target \"{target}\""))
					return false;
				if (line.Contains ($"Target {target} skipped due to ")
					|| line.Contains ($"Skipping target \"{target}\" because it has no ") //NOTE: message can say `inputs` or `outputs`
					|| line.Contains ($"Target \"{target}\" skipped, due to")
					|| line.Contains ($"Skipping target \"{target}\" because its outputs are up-to-date")
					|| line.Contains ($"target {target}, skipping")
					|| line.Contains ($"Skipping target \"{target}\" because all output files are up-to-date"))
					return true;
			}
			return false;
		}
	}

	public class ProjectPaths : Dictionary<string, string> {
		public string ProjectPath { get { return this ["project_path"]; } set { this ["project_path"] = value; } }
		public string ProjectBinPath { get { return this ["project_binpath"]; } set { this ["project_binpath"] = value; } }
		public string ProjectObjPath { get { return this ["project_objpath"]; } set { this ["project_objpath"] = value; } }
		public string ProjectCSProjPath { get { return this ["project_csprojpath"]; } set { this ["project_csprojpath"] = value; } }
		public string AppBundlePath { get { return this ["app_bundlepath"]; } set { this ["app_bundlepath"] = value; } }
	}
}
