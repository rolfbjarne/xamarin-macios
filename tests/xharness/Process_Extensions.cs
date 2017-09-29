﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Utils;

namespace xharness
{
	public class ProcessExecutionResult
	{
		public bool TimedOut { get; set; }
		public int ExitCode { get; set; }

		public bool Succeeded { get { return !TimedOut && ExitCode == 0; } }
	}

	public static class ProcessHelper
	{
		public static async Task<ProcessExecutionResult> ExecuteCommandAsync (string filename, string args, Log log, TimeSpan timeout, Dictionary<string, string> environment_variables = null, CancellationToken? cancellation_token = null)
		{
			using (var p = new Process ()) {
				p.StartInfo.FileName = filename;
				p.StartInfo.Arguments = args;
				return await p.RunAsync (log, true, timeout, environment_variables, cancellation_token);
			}
		}

		[DllImport ("/usr/lib/libc.dylib")]
		internal static extern int kill (int pid, int sig);

		public static Task<bool> PollForExitAsync (int pid, TimeSpan timeout)
		{
			var rv = new TaskCompletionSource<bool> ();
			var watch = new Stopwatch ();
			watch.Start ();
			Task.Run (async () => {
				while (watch.ElapsedMilliseconds < timeout.TotalMilliseconds) {
					if (kill (pid, 0) != 0) {
						// pid is not valid anymore, program exited
						rv.SetResult (true);
						return;
					}
					await Task.Delay (TimeSpan.FromMilliseconds (100));
				}

				rv.SetResult (false);
			});
			return rv.Task;
		}
	}

	public static class Process_Extensions
	{
		public static async Task<ProcessExecutionResult> RunAsync (this Process process, Log log, CancellationToken? cancellation_token = null)
		{
			return await RunAsync (process, log, log, log, cancellation_token: cancellation_token);
		}

		public static Task<ProcessExecutionResult> RunAsync (this Process process, Log log, bool append = true, TimeSpan? timeout = null, Dictionary<string, string> environment_variables = null, CancellationToken? cancellation_token = null)
		{
			return RunAsync (process, log, log, log, timeout, environment_variables, cancellation_token);
		}

		public static async Task<ProcessExecutionResult> RunAsync (this Process process, Log log, TextWriter StdoutStream, TextWriter StderrStream, TimeSpan? timeout = null, Dictionary<string, string> environment_variables = null, CancellationToken? cancellation_token = null)
		{
			var stdout_completion = new TaskCompletionSource<bool> ();
			var stderr_completion = new TaskCompletionSource<bool> ();
			var exit_completion = new TaskCompletionSource<bool> ();
			var rv = new ProcessExecutionResult ();

			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;

			if (environment_variables != null) {
				foreach (var kvp in environment_variables)
					process.StartInfo.EnvironmentVariables [kvp.Key] = kvp.Value;
			}

			process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
			{
				if (e.Data != null) {
					lock (StdoutStream) {
						StdoutStream.WriteLine (e.Data);
						StdoutStream.Flush ();
					}
				} else {
					stdout_completion.TrySetResult (true);
				}
			};

			process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
			{
				if (e.Data != null) {
					lock (StderrStream) {
						StderrStream.WriteLine (e.Data);
						StderrStream.Flush ();
					}
				} else {
					stderr_completion.TrySetResult (true);
				}
			};


			log.WriteLine ("{0} {1}", process.StartInfo.FileName, process.StartInfo.Arguments);
			process.Start ();

			process.BeginErrorReadLine ();
			process.BeginOutputReadLine ();

			cancellation_token?.Register (() => {
				if (!exit_completion.Task.IsCompleted) {
					StderrStream.WriteLine ($"Execution was cancelled.");
					ProcessHelper.kill (process.Id, 9);
				}
			});

			new Thread (() =>
			{
				if (timeout.HasValue) {
					if (!process.WaitForExit ((int) timeout.Value.TotalMilliseconds)) {
						process.KillTreeAsync (log, true).Wait ();
						rv.TimedOut = true;
						lock (StderrStream)
							log.WriteLine ($"Execution timed out after {timeout.Value.TotalSeconds} seconds and the process was killed.");
					}
				}
				process.WaitForExit ();
				exit_completion.TrySetResult (true);
				Task.WaitAll (new Task [] { stderr_completion.Task, stdout_completion.Task }, TimeSpan.FromSeconds (1));
				stderr_completion.TrySetResult (false);
				stdout_completion.TrySetResult (false);
			}) {
				IsBackground = true,
			}.Start ();

			await Task.WhenAll (stderr_completion.Task, stdout_completion.Task, exit_completion.Task);

			try {
				rv.ExitCode = process.ExitCode;
			} catch (Exception e) {
				rv.ExitCode = 12345678;
				log.WriteLine ($"Failed to get ExitCode: {e}");
			}
			return rv;
		}

		public static Task KillTreeAsync (this Process @this, Log log, bool diagnostics = true)
		{
			return KillTreeAsync (@this.Id, log, diagnostics);
		}

		public static async Task KillTreeAsync (int pid, Log log, bool diagnostics = true)
		{
			var pids = new List<int> ();
			GetChildrenPS (log, pids, pid);
			if (diagnostics) {
				log.WriteLine ($"Pids to kill: {string.Join (", ", pids.Select ((v) => v.ToString ()).ToArray ())}");
				using (var ps = new Process ()) {
					log.WriteLine ("Writing process list:");
					ps.StartInfo.FileName = "ps";
					ps.StartInfo.Arguments = "-A -o pid,ruser,ppid,pgid,%cpu=%CPU,%mem=%MEM,flags=FLAGS,lstart,rss,vsz,tty,state,time,command";
					await ps.RunAsync (log, true, TimeSpan.FromSeconds (5));
				}

				foreach (var diagnose_pid in pids) {
					var template = Path.GetTempFileName ();
					try {
						var commands = new StringBuilder ();
						using (var dbg = new Process ()) {
							commands.AppendLine ($"process attach --pid {diagnose_pid}");
							commands.AppendLine ("thread list");
							commands.AppendLine ("thread backtrace all");
							commands.AppendLine ("detach");
							commands.AppendLine ("quit");
							dbg.StartInfo.FileName = "/usr/bin/lldb";
							dbg.StartInfo.Arguments = $"--source {StringUtils.Quote (template)}";
							File.WriteAllText (template, commands.ToString ());

							log.WriteLine ($"Printing backtrace for pid={pid}");
							await dbg.RunAsync (log, true, TimeSpan.FromSeconds (30));
						}
					} finally {
						try {
							File.Delete (template);
						} catch {
							// Don't care
						}
					}
				}
			}

			using (var kill = new Process ()) {
				kill.StartInfo.FileName = "kill";
				// Send SIGABRT since that produces a crash report
				// lldb may fail to attach to system processes, but crash reports will still be produced with potentially helpful stack traces.
				kill.StartInfo.Arguments = "-6 " + string.Join (" ", pids.Select ((v) => v.ToString ()).ToArray ());
				await kill.RunAsync (log, true, TimeSpan.FromSeconds (2.5));
			}

			using (var kill = new Process ()) {
				kill.StartInfo.FileName = "kill";
				// send kill -9 anyway as a last resort
				kill.StartInfo.Arguments = "-9 " + string.Join (" ", pids.Select ((v) => v.ToString ()).ToArray ());
				await kill.RunAsync (log, true, TimeSpan.FromSeconds (2.5));
			}
		}

		static void GetChildrenPS (Log log, List<int> list, int pid)
		{
			string stdout;

			using (Process ps = new Process ()) {
				ps.StartInfo.FileName = "ps";
				ps.StartInfo.Arguments = "-eo ppid,pid";
				ps.StartInfo.UseShellExecute = false;
				ps.StartInfo.RedirectStandardOutput = true;
				ps.Start ();
				stdout = ps.StandardOutput.ReadToEnd ();

				if (!ps.WaitForExit (1000)) {
					log.WriteLine ("ps didn't finish in a reasonable amount of time (1 second).");
					return;
				}

				if (ps.ExitCode != 0)
					return;

				stdout = stdout.Trim ();

				if (string.IsNullOrEmpty (stdout))
					return;

				var dict = new Dictionary<int, List<int>> ();
				foreach (string line in stdout.Split (new char [] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)) {
					var l = line.Trim ();
					var space = l.IndexOf (' ');
					if (space <= 0)
						continue;
				
					var parent = l.Substring (0, space);
					var process = l.Substring (space + 1);
					int parent_id, process_id;

					if (int.TryParse (parent, out parent_id) && int.TryParse (process, out process_id)) {
						List<int> children;
						if (!dict.TryGetValue (parent_id, out children))
							dict [parent_id] = children = new List<int> ();
						children.Add (process_id);
					}
				}

				var queue = new Queue<int> ();
				queue.Enqueue (pid);

				do {
					List<int> children;
					var parent_id = queue.Dequeue ();
					list.Add (parent_id);
					if (dict.TryGetValue (parent_id, out children)) {
						foreach (var child in children)
							queue.Enqueue (child);
					}
				} while (queue.Count > 0);
			}
		}
	}
}
