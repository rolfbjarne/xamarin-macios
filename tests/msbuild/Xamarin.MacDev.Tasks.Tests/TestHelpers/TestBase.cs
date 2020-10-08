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

			var rv = Configuration.CloneTestDirectory (Configuration.TestProjectsDirectory, mode);

			if (mode == "dotnet")
				Configuration.CopyDotNetSupportingFiles (rv);

			return rv;
		}

		public TestEngine Engine {
			get; private set;
		}

		public string MonoTouchProjectObjPath;
		public string MonoTouchProjectPath;
		public string MonoTouchProjectCSProjPath;
		public string AppBundlePath;

		public ProjectPaths SetupProjectPaths (string projectName, string csprojName, string baseDir = "../", bool includePlatform = true, string platform = "iPhoneSimulator", string config = "Debug", string projectPath = null)
		{
			var testsBase = GetTestDirectory ();
			if (projectPath == null) {
				if (Path.IsPathRooted (baseDir)) {
					projectPath = Path.Combine (baseDir, projectName);
				} else {
					if (baseDir.StartsWith ("../", StringComparison.Ordinal))
						baseDir = baseDir.Substring (3); // Tests have been relocated, which means the given relative base dir is not correct anymore, so fix it.
					projectPath = Path.Combine (testsBase, baseDir, projectName);
				}
			}

			var binPath = includePlatform ? Path.Combine (projectPath, "bin", platform, config) : Path.Combine (projectPath, "bin", config);
			var objPath = includePlatform ? Path.Combine (projectPath, "obj", platform, config) : Path.Combine (projectPath, "obj", config);
			
			return new ProjectPaths {
				ProjectPath = projectPath,
				ProjectBinPath = binPath,
				ProjectObjPath = objPath,
				ProjectCSProjPath = Path.Combine (projectPath, csprojName + ".csproj"),
				AppBundlePath = Path.Combine (binPath, projectName.Replace (" ", "") + ".app"),
			};
		}

		public ProjectPaths SetupProjectPaths (string projectName, string baseDir = "../", bool includePlatform = true, string platform = "iPhoneSimulator", string config = "Debug", string projectPath = null)
		{
			return SetupProjectPaths (projectName, projectName, baseDir, includePlatform, platform, config, projectPath);
		}

		[SetUp]
		public virtual void Setup ()
		{
			var mtouchPaths = SetupProjectPaths ("MySingleView");

			MonoTouchProjectObjPath = mtouchPaths.ProjectObjPath;
			MonoTouchProjectCSProjPath = mtouchPaths.ProjectCSProjPath;
			MonoTouchProjectPath = mtouchPaths.ProjectPath;

			AppBundlePath = mtouchPaths.AppBundlePath;

			SetupEngine ();

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

		public void CleanUp () {

			var paths = SetupProjectPaths ("MySingleView");
			MonoTouchProjectPath = paths.ProjectPath;

			// Ensure the bin and obj directories are cleared
			SafeDelete (Path.Combine (MonoTouchProjectPath, "bin"));
			SafeDelete (Path.Combine (MonoTouchProjectPath, "obj"));

			// Reset all the write times as we deliberately set some in the future for our tests
			foreach (var file in Directory.GetFiles (MonoTouchProjectPath, "*.*", SearchOption.AllDirectories))
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
			return Path.Combine (Cache.CreateTemporaryDirectory (), path);
		}
	}

	public class ProjectPaths {
		public string ProjectPath { get; set; }
		public string ProjectBinPath { get; set; }
		public string ProjectObjPath { get; set; }
		public string ProjectCSProjPath { get; set; }
		public string AppBundlePath { get; set; }
	}
}
