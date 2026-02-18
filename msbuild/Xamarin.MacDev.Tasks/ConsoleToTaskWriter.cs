// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

// TODO: Copilot add license here

using System.IO;
using System.Text;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

#nullable enable

namespace Xamarin.Utils;

class ConsoleToTaskWriter : TextWriter {
	TaskLoggingHelper helper;
	bool errorShown;

	public ConsoleToTaskWriter (TaskLoggingHelper helper)
	{
		this.helper = helper;
	}

	public override Encoding Encoding => Encoding.UTF8;

	public override void Write (char value)
	{
		ShowError ();
		helper.LogMessage (MessageImportance.Low, value.ToString ());
	}

	public override void Write (char [] buffer, int index, int count)
	{
		ShowError ();
		helper.LogMessage (MessageImportance.Low, new string (buffer, index, count));
	}

	public override void Write (string? value)
	{
		ShowError ();
		helper.LogMessage (MessageImportance.Low, value ?? string.Empty);
	}

	public override void WriteLine ()
	{
		ShowError ();
	}

	public override void WriteLine (string? value)
	{
		ShowError ();
		helper.LogMessage (MessageImportance.Low, value ?? string.Empty);
	}

	void ShowError ()
	{
		if (errorShown)
			return;
		errorShown = true;

		// Copilot TODO: add proper error message with number
		helper.LogError ($"Console.Standard[Output|Error] accessed!",
			$"Console.Standard[Output|Error] should not be used in tasks, as it can cause deadlocks and other issues. Please use the TaskLoggingHelper to log messages instead.");
		helper.LogError ($"Stack trace: {Environment.StackTrace}");
	}

	public static IDisposable EnsureNoConsoleUsage (TaskLoggingHelper log)
	{
		return new NoConsoleUsage (new ConsoleToTaskWriter (log));
	}

	class NoConsoleUsage : IDisposable {
		TextWriter? originalStdout;
		TextWriter? originalStderr;

		public NoConsoleUsage (ConsoleToTaskWriter redirector)
		{
			originalStdout = Console.Out;
			originalStderr = Console.Error;
			Console.SetOut (redirector);
			Console.SetError (redirector);
		}

		~NoConsoleUsage ()
		{
			Restore ();
		}

		void IDisposable.Dispose ()
		{
			Restore ();
			GC.SuppressFinalize (this);
		}

		void Restore ()
		{
			if (originalStdout is not null) {
				Console.SetOut (originalStdout);
				originalStdout = null;
			}
			if (originalStderr is not null) {
				Console.SetError (originalStderr);
				originalStderr = null;
			}
		}
	}
}
