using System;
using System.Collections.Generic;

using Microsoft.Build.Framework;
using Microsoft.Build.Tasks;
using Microsoft.Build.Utilities;

using Xamarin.Localization.MSBuild;
using Xamarin.Utils;

#nullable enable

namespace Xamarin.MacDev.Tasks {
	// This is a variation of XamarinToolTask that subclasses XamarinTask and provides an interface similar to ToolTask.
	public abstract class XamarinToolTask2 : XamarinTask {
		public string ToolPath { get; set; } = string.Empty;
		protected virtual string ToolName { get; set; } = string.Empty;

		string? tool_exe;
		public virtual string ToolExe {
			get {
#if NET
				if (!string.IsNullOrEmpty (tool_exe))
#else
				if (!string.IsNullOrEmpty (tool_exe) && tool_exe is not null)
#endif
					return tool_exe;
				return ToolName;
			}
			set {
				tool_exe = value;
			}
		}

		public Dictionary<string, string?> EnvironmentVariables { get; set; } = new Dictionary<string, string?> ();

		protected Execution? ExecutionResult { get; private set; }

		protected abstract IList<string> GenerateCommandLineCommands ();
		protected virtual string? GetWorkingDirectory () => null;
		protected abstract string GenerateFullPathToTool ();
		public override bool Execute ()
		{
			var workingDirectory = GetWorkingDirectory ();
			var fileName = GenerateFullPathToTool ();
			var arguments = GenerateCommandLineCommands ();

			if (Log.HasLoggedErrors)
				return false;

			ExecutionResult = ExecuteAsync (fileName, arguments, mergeOutput: true, showErrorIfFailure: true, workingDirectory: workingDirectory, environment: EnvironmentVariables).Result;

			return ExecutionResult.ExitCode == 0;
		}

		public virtual void Cancel ()
		{
		}
	}
}
