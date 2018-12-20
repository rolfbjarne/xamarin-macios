/*
 * Copyright 2014 Xamarin Inc. All rights reserved.
 * Copyright 2018 Microsoft Corp. All rights reserved.
 *
 * Authors:
 *   Rolf Bjarne Kvinge <rolf@xamarin.com>
 *
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

using Xamarin.Utils;

namespace Xamarin.Utils {
	public partial class ProcessHelper {
		public static int Run (string path, IEnumerable<string> args, Dictionary<string, string> environment, StringBuilder output = null, bool verbose = false, bool always_show_errors = true)
		{
			var sb = new StringBuilder ();
			foreach (var arg in args) {
				if (sb.Length > 0)
					sb.Append (' ');
				sb.Append (StringUtils.Quote (arg));
			}
			return Run (path, sb.ToString (), environment, output, verbose, always_show_errors);
		}

		public static int Run (string path, string args, Dictionary<string, string> environment, StringBuilder output = null, bool verbose = false, bool always_show_errors = true)
		{
			var info = new ProcessStartInfo (path, args);
			info.UseShellExecute = false;
			info.RedirectStandardInput = false;
			info.RedirectStandardOutput = true;
			info.RedirectStandardError = true;
			var stdout_completed = new ManualResetEvent (false);
			var stderr_completed = new ManualResetEvent (false);

			if (output == null)
				output = new StringBuilder ();

			if (environment != null) {
				foreach (var kvp in environment) {
					info.EnvironmentVariables [kvp.Key] = kvp.Value;
				}
			}

			if (verbose) {
				// Print any environment variables that differ from the current environment.
				foreach (string key in info.EnvironmentVariables.Keys) {
					var value = info.EnvironmentVariables [key];
					var existing = Environment.GetEnvironmentVariable (key);
					if (existing != value)
						Console.WriteLine ("{0}={1}", key, value);
				}
				Console.WriteLine ("{0} {1}", path, args);
			}

			using (var p = Process.Start (info)) {

				p.OutputDataReceived += (s, e) => {
					if (e.Data != null) {
						lock (output)
							output.AppendLine (e.Data);
					} else {
						stdout_completed.Set ();
					}
				};

				p.ErrorDataReceived += (s, e) => {
					if (e.Data != null) {
						lock (output)
							output.AppendLine (e.Data);
					} else {
						stderr_completed.Set ();
					}
				};

				p.BeginOutputReadLine ();
				p.BeginErrorReadLine ();

				p.WaitForExit ();

				stderr_completed.WaitOne (TimeSpan.FromSeconds (1));
				stdout_completed.WaitOne (TimeSpan.FromSeconds (1));

				var exitCode = p.ExitCode;

				if (exitCode != 0) {
					if (verbose || always_show_errors) {
						// note: this repeat the failing command line. However we can't avoid this since we're often
						// running commands in parallel (so the last one printed might not be the one failing)
						Console.WriteLine ("Process exited with code {0}, command:\n{1} {2}{3}", p.ExitCode, path, args, output.Length > 0 ? "\n" + output : string.Empty);
					}
				} else if (verbose && output.Length > 0) {
					Console.WriteLine (output);
				}

				return exitCode;
			}
		}
	}
}
