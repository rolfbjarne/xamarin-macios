using System.IO;
using System.Linq;

using Microsoft.Build.Evaluation;
using Microsoft.Build.Utilities;

using NUnit.Framework;

using Xamarin.Tests;

namespace Xamarin.iOS.Tasks
{
	public abstract class TestBase
	{
		public TestEngine Engine {
			get; private set;
		}

		public string GetProjectPath (string projectName)
		{
			var testDir = Configuration.CloneTestDirectory (Configuration.TestProjectsDirectory, "tasks");
			return Path.Combine (testDir, projectName);
		}

		[SetUp]
		public virtual void Setup ()
		{
			Engine?.UnloadAllProjects ();
			Engine = new TestEngine ();
		}

		public Project SetupProject (TestEngine engine, string projectPath)
		{
			return engine.ProjectCollection.LoadProject (projectPath);
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
	}

	public class ProjectPaths {
		public string ProjectPath { get; set; }
	}
}
