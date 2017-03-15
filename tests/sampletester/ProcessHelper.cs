using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

using NUnit.Framework;

public static class ProcessHelper
{
	public static void AssertRunProcess (string filename, string arguments, TimeSpan timeout, string workingDirectory, string message)
	{
		var exitCode = 0;

		Assert.IsTrue (RunProcess (filename, arguments, out exitCode, timeout, workingDirectory), $"{message} timed out after {timeout.TotalMinutes} minutes");
		Assert.AreEqual (0, exitCode, $"{message} failed (unexpected exit code)");
	}

	// runs the process and doesn't care about the result.
	public static void RunProcess (string filename, string arguments, TimeSpan timeout, string workingDirectory)
	{
		int exitCode;
		RunProcess (filename, arguments, out exitCode, timeout, workingDirectory);
	}

	// returns false if timed out (in which case exit code is int.MinValue
	public static bool RunProcess (string filename, string arguments, out int exitCode, TimeSpan timeout, string workingDirectory)
	{
		var outputDone = new ManualResetEvent (false);
		var errorDone = new ManualResetEvent (false);
		using (var xbuild = new Process ()) {
			xbuild.StartInfo.FileName = filename;
			xbuild.StartInfo.Arguments = arguments;
			xbuild.StartInfo.RedirectStandardError = true;
			xbuild.StartInfo.RedirectStandardOutput = true;
			xbuild.StartInfo.UseShellExecute = false;
			xbuild.StartInfo.WorkingDirectory = workingDirectory;
			xbuild.OutputDataReceived += (sender, e) =>
			{
				if (e.Data == null) {
					outputDone.Set ();
				} else {
					Console.WriteLine (e.Data);
				}
			};
			xbuild.ErrorDataReceived += (sender, e) =>
			{
				if (e.Data == null) {
					errorDone.Set ();
				} else {
					Console.WriteLine (e.Data);
				}
			};
			Console.WriteLine ("{0} {1}", xbuild.StartInfo.FileName, xbuild.StartInfo.Arguments);
			xbuild.Start ();
			xbuild.BeginErrorReadLine ();
			xbuild.BeginOutputReadLine ();
			var rv = xbuild.WaitForExit ((int) timeout.TotalMilliseconds);
			if (rv) {
				outputDone.WaitOne (TimeSpan.FromSeconds (5));
				errorDone.WaitOne (TimeSpan.FromSeconds (5));
				exitCode = xbuild.ExitCode;
			} else {
				Console.WriteLine ("Command timed out after {0}s", timeout.TotalSeconds);
				exitCode = int.MinValue;
			}
			return rv;
		}
	}

	public static void BuildSolution (string solution, string msbuild, string platform, string configuration)
	{
		try {
			AssertRunProcess ("nuget", $"restore \"{solution}\"", TimeSpan.FromMinutes (2), Configuration.RootDirectory, "nuget restore");
			AssertRunProcess (msbuild, $"/verbosity:diag /p:Platform={platform} /p:Configuration={configuration} \"{solution}\"", TimeSpan.FromMinutes (5), Configuration.RootDirectory, "build");
		} finally {
			// Clean up after us, since building for device needs a lot of space.
			// Ignore any failures (since failures here doesn't mean the test failed).
			RunProcess ("git", "clean -xfdq", TimeSpan.FromSeconds (30), Path.GetDirectoryName (solution));
		}
	}

	public static void BuildMakefile (string makefile, string target = "")
	{
		try {
			AssertRunProcess ("make", target, TimeSpan.FromMinutes (5), Path.GetDirectoryName (makefile), "build");
		} finally {
			// Clean up after us, since building for device needs a lot of space.
			// Ignore any failures (since failures here doesn't mean the test failed).
			RunProcess ("git", "clean -xfdq", TimeSpan.FromSeconds (30), Path.GetDirectoryName (makefile));
		}
	}
}
