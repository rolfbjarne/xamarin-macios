using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Microsoft.Build.Framework;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Logging;
using NUnit.Framework;
using Microsoft.Build.Utilities;

namespace Xamarin.iOS.Tasks
{

	class PersistentConsoleLogger : ConsoleLogger {
		public PersistentConsoleLogger (LoggerVerbosity verbosity, WriteHandler write, ColorSetter colorSet, ColorResetter colorReset)
			: base (verbosity, write, colorSet, colorReset)
		{
		}

		public override void Shutdown ()
		{
			// Don't do anything
		}
	}


	public class TestEngine : IBuildEngine, IBuildEngine2, IBuildEngine3, IBuildEngine4
	{
		ConsoleReportPrinter printer;
		PersistentConsoleLogger cl;

		BinaryLogger binlog;
		string binlog_path;
		string msbuildlog_path;
		StreamWriter file_writer;
		ConsoleLogger file_logger;
		
		public Logger Logger {
			get; set;
		}

		public TestEngine ()
		{
			Logger = new Logger ();
			ProjectCollection = new ProjectCollection ();

			printer = new ConsoleReportPrinter ();
			cl = new PersistentConsoleLogger (LoggerVerbosity.Diagnostic, printer.Print, printer.SetForeground, printer.ResetColor);
		}

		void RegisterLoggers ()
		{
			ProjectCollection.RegisterLogger (Logger);
			ProjectCollection.RegisterLogger (cl);

			var ticks = DateTime.UtcNow.Ticks;
			msbuildlog_path = $"/tmp/Xamarin.MacDev.Tasks-{ticks}.msbuildlog";
			binlog_path = $"/tmp/Xamarin.MacDev.Tasks-{ticks}.binlog";

			file_writer = new StreamWriter (File.OpenWrite (msbuildlog_path));
			file_writer.AutoFlush = true;
			var printer = new ConsoleReportPrinter (file_writer);
			file_logger = new ConsoleLogger (LoggerVerbosity.Diagnostic, printer.Print, printer.SetForeground, printer.ResetColor);
			ProjectCollection.RegisterLogger (file_logger);

			var bl = new BinaryLogger ();
			bl.Parameters = $"LogFile={binlog_path}";
			ProjectCollection.RegisterLogger (bl);
		}

		void UnregisterLoggers ()
		{
			ProjectCollection.UnregisterAllLoggers ();

			Console.WriteLine ($"MSBuildLog: {msbuildlog_path}");
			Console.WriteLine ($"BinLog: {binlog_path}");

			file_writer.Dispose ();
		}

		public bool BuildProjectFile (string projectFileName, string [] targetNames, IDictionary globalProperties, IDictionary targetOutputs)
		{
			throw new NotImplementedException ();
		}

		public bool BuildProject (ProjectInstance instance, string [] targetNames, IDictionary globalProperties)
		{
			if (globalProperties != null) {
				foreach (DictionaryEntry de in globalProperties) {
					//Note: trying to set this on the project causes the project to be added to the PC
					//      again, which of course, fails
					instance.SetProperty ((string)de.Key, (string)de.Value);
				}
			}

			RegisterLoggers ();

			//FIXME: assumption that we are still using the same PC!
			var rv = instance.Build (targetNames, ProjectCollection.Loggers);

			UnregisterLoggers ();

			return rv;
		}

		public void LogCustomEvent (CustomBuildEventArgs e)
		{
			Logger.CustomEvents.Add (e);
		}
		public void LogErrorEvent (BuildErrorEventArgs e)
		{
			Logger.ErrorEvents.Add (e);
		}
		public void LogMessageEvent (BuildMessageEventArgs e)
		{
			Logger.MessageEvents.Add (e);
		}
		public void LogWarningEvent (BuildWarningEventArgs e)
		{
			Logger.WarningsEvents.Add (e);
		}

		public void UnloadAllProjects ()
		{
			ProjectCollection.UnloadAllProjects ();
		}

		public int ColumnNumberOfTaskNode {
			get { return 0; }
		}
		public bool ContinueOnError {
			get { return true; }
		}
		public int LineNumberOfTaskNode {
			get {return 0;}
		}
		public string ProjectFileOfTaskNode {
			get { return ""; }
		}

		public ProjectCollection ProjectCollection { get; set; }

		private Dictionary<object, object> Tasks = new Dictionary<object, object> ();

		void IBuildEngine4.RegisterTaskObject (object key, object obj, RegisteredTaskObjectLifetime lifetime, bool allowEarlyCollection)
		{
			Tasks [key] = obj;
		}

		object IBuildEngine4.GetRegisteredTaskObject (object key, RegisteredTaskObjectLifetime lifetime)
		{
			Tasks.TryGetValue (key, out object value);
			return value;
		}

		object IBuildEngine4.UnregisterTaskObject (object key, RegisteredTaskObjectLifetime lifetime)
		{
			if (Tasks.TryGetValue (key, out object value)) {
				Tasks.Remove (key);
			}
			return value;
		}

		BuildEngineResult IBuildEngine3.BuildProjectFilesInParallel (string [] projectFileNames, string [] targetNames, IDictionary [] globalProperties, IList<string> [] removeGlobalProperties, string [] toolsVersion, bool returnTargetOutputs)
		{
			throw new NotImplementedException ();
		}

		void IBuildEngine3.Yield () { }

		void IBuildEngine3.Reacquire () { }

		bool IBuildEngine2.BuildProjectFile (string projectFileName, string [] targetNames, IDictionary globalProperties, IDictionary targetOutputs, string toolsVersion) => true;

		bool IBuildEngine2.BuildProjectFilesInParallel (string [] projectFileNames, string [] targetNames, IDictionary [] globalProperties, IDictionary [] targetOutputsPerProject, string [] toolsVersion, bool useResultsCache, bool unloadProjectsOnCompletion) => true;

		bool IBuildEngine2.IsRunningMultipleNodes => false;

	}

}
