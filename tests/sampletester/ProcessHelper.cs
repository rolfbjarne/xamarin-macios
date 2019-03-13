using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Text;
using System.Text.RegularExpressions;

using NUnit.Framework;

using Xamarin;

public static class ProcessHelper
{
	static string log_directory;
	static string LogDirectory {
		get {
			if (log_directory == null)
				log_directory = Cache.CreateTemporaryDirectory ("execution-logs");
			return log_directory;
		}

	}
	public static void AssertRunProcess (string filename, string arguments, TimeSpan timeout, string workingDirectory, string message)
	{
		var exitCode = 0;
		var output = new List<string> ();
		var rv = RunProcess (filename, arguments, out exitCode, timeout, workingDirectory, output);

		// Write execution log to disk (and print the path)
		var logfile = Path.Combine (LogDirectory, Guid.NewGuid ().ToString () + ".log");
		File.WriteAllLines (logfile, output);
		TestContext.AddTestAttachment (logfile, $"Execution log for {filename}");
		Console.WriteLine ("Execution log for {0}: {1}", filename, logfile);

		var errors = new List<string> ();
		var errorMessage = "";
		if ((!rv || exitCode != 0) && output.Count > 0) {
			var regex = new Regex (@"error\s*(MSB....)?(CS....)?:", RegexOptions.IgnoreCase | RegexOptions.Singleline);
			foreach (var line in output) {
				if (regex.IsMatch (line) && !errors.Contains (line))
					errors.Add (line);
			}
			if (errors.Count > 0)
				errorMessage = "\n\t[Summary of errors from the build output below]\n\t" + string.Join ("\n\t", errors);
		}
		Assert.IsTrue (rv, $"{message} timed out after {timeout.TotalMinutes} minutes{errorMessage}");
		Assert.AreEqual (0, exitCode, $"{message} failed (unexpected exit code){errorMessage}");
	}

	// runs the process and doesn't care about the result.
	public static void RunProcess (string filename, string arguments, TimeSpan timeout, string workingDirectory, List<string> output = null)
	{
		int exitCode;
		RunProcess (filename, arguments, out exitCode, timeout, workingDirectory, output);
	}

	// returns false if timed out (in which case exit code is int.MinValue
	public static bool RunProcess (string filename, string arguments, out int exitCode, TimeSpan timeout, string workingDirectory, List<string> output = null, Func<string, string> scrambler = null)
	{
		if (scrambler == null)
			scrambler = (string v) => v;

		var outputDone = new ManualResetEvent (false);
		var errorDone = new ManualResetEvent (false);
		using (var xbuild = new Process ()) {
			xbuild.StartInfo.FileName = filename;
			xbuild.StartInfo.Arguments = arguments;
			xbuild.StartInfo.RedirectStandardError = true;
			xbuild.StartInfo.RedirectStandardOutput = true;
			xbuild.StartInfo.UseShellExecute = false;
			xbuild.StartInfo.WorkingDirectory = workingDirectory;
			// XS sets XCODE_DEVELOPER_DIR_PATH, which breaks pretty much everything 
			// if it doesn't match what xcode-select reports, so clear it.
			xbuild.StartInfo.EnvironmentVariables ["XCODE_DEVELOPER_DIR_PATH"] = null;
			// Make sure we use the Xcode specified in this repository.
			xbuild.StartInfo.EnvironmentVariables ["DEVELOPER_DIR"] = Configuration.XcodeLocation;
			xbuild.OutputDataReceived += (sender, e) =>
			{
				if (e.Data == null) {
					outputDone.Set ();
				} else {
					var data = scrambler (e.Data);
					if (output != null) {
						lock (output)
							output.Add (data);
					} else {
						Console.WriteLine (data);
					}
				}
			};
			xbuild.ErrorDataReceived += (sender, e) =>
			{
				if (e.Data == null) {
					errorDone.Set ();
				} else {
					var data = scrambler (e.Data);
					if (output != null) {
						lock (output)
							output.Add (data);
					} else {
						Console.WriteLine (data);
					}
				}
			};
			Console.WriteLine (scrambler ($"{xbuild.StartInfo.FileName} {xbuild.StartInfo.Arguments}"));
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

	public static void BuildSolution (string solution, string platform, string configuration, string target = "")
	{
		try {
			// nuget restore
			var solution_dir = string.Empty;
			var solutions = new string [] { solution };
			if (!solution.EndsWith (".sln", StringComparison.Ordinal)) {
				var slndir = Path.GetDirectoryName (solution);
				solutions = Directory.GetFiles (slndir, "*.sln", SearchOption.TopDirectoryOnly);
				while ((solutions = Directory.GetFiles (slndir, "*.sln", SearchOption.TopDirectoryOnly)).Length == 0 && slndir.Length > 1)
					slndir = Path.GetDirectoryName (slndir);
				solution_dir = $"-SolutionDir \"{slndir}\"";

			}
			foreach (var sln in solutions)
				AssertRunProcess ("nuget", $"restore \"{sln}\" -Verbosity detailed {solution_dir}", TimeSpan.FromMinutes (2), Configuration.RootDirectory, "nuget restore");

			// msbuild
			var sb = new StringBuilder ();
			sb.Append ("/verbosity:diag ");
			if (!string.IsNullOrEmpty (platform))
				sb.Append ($" /p:Platform={platform}");
			if (!string.IsNullOrEmpty (configuration))
				sb.Append ($" /p:Configuration={configuration}");
			sb.Append ($" \"{solution}\"");
			if (!string.IsNullOrEmpty (target))
				sb.Append ($" /t:{target}");
			AssertRunProcess ("msbuild", sb.ToString (), TimeSpan.FromMinutes (5), Configuration.RootDirectory, "build");
		} finally {
			// Clean up after us, since building for device needs a lot of space.
			// Ignore any failures (since failures here doesn't mean the test failed).
			//GitHub.CleanRepository (Path.GetDirectoryName (solution), false);
		}
	}

	public static void BuildMakefile (string makefile, string target = "")
	{
		try {
			AssertRunProcess ("make", target, TimeSpan.FromMinutes (5), Path.GetDirectoryName (makefile), "build");
		} finally {
			// Clean up after us, since building for device needs a lot of space.
			// Ignore any failures (since failures here doesn't mean the test failed).
			GitHub.CleanRepository (Path.GetDirectoryName (makefile), false);
		}
	}
}
