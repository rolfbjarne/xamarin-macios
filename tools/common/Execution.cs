/*
 * Copyright 2014 Xamarin Inc. All rights reserved.
 * Copyright 2019, 2020 Microsoft Corp. All rights reserved.
 *
 * Authors:
 *   Rolf Bjarne Kvinge <rolf@xamarin.com>
 *
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Xamarin.Utils {
	public class Execution {
		public string FileName;
		public IList<string> Arguments;
		public IDictionary<string, string> Environment;
		public string WorkingDirectory;
		public TimeSpan? Timeout;
		public CancellationToken? CancellationToken;

		public TextWriter Log;

		public int ExitCode { get; private set; }
		public bool TimedOut { get; private set; }
		public TextWriter StandardOutput { get; private set; }
		public TextWriter StandardError { get; private set; }

		[DllImport ("/usr/lib/libc.dylib")]
		static extern void kill (int pid, int sig);

		static void StartOutputThread (TaskCompletionSource<Execution> tcs, object lockobj, StreamReader reader, TextWriter writer, string thread_name)
		{
			var thread = new Thread (() => {
				try {
					string line;
					while ((line = reader.ReadLine ()) != null) {
						lock (lockobj)
							writer.WriteLine (line);
					}
				} catch (Exception e) {
					tcs.TrySetException (e);
				}
			}) {
				IsBackground = true,
				Name = thread_name,
			};
			thread.Start ();
		}

		public Task<Execution> RunAsync ()
		{
			var tcs = new TaskCompletionSource<Execution> ();
			var lockobj = new object ();

			try {
				var p = new Process ();
				p.StartInfo.FileName = FileName;
				p.StartInfo.Arguments = StringUtils.FormatArguments (Arguments);
				p.StartInfo.UseShellExecute = false;
				p.StartInfo.RedirectStandardInput = false;
				p.StartInfo.RedirectStandardOutput = true;
				p.StartInfo.RedirectStandardError = true;
				if (!string.IsNullOrEmpty (WorkingDirectory))
					p.StartInfo.WorkingDirectory = WorkingDirectory;

				// mtouch/mmp writes UTF8 data outside of the ASCII range, so we need to make sure
				// we read it in the same format. This also means we can't use the events to get
				// stdout/stderr, because mono's Process class parses those using Encoding.Default.
				p.StartInfo.StandardOutputEncoding = Encoding.UTF8;
				p.StartInfo.StandardErrorEncoding = Encoding.UTF8;

				if (Environment != null) {
					foreach (var kvp in Environment) {
						if (kvp.Value == null) {
							p.StartInfo.EnvironmentVariables.Remove (kvp.Key);
						} else {
							p.StartInfo.EnvironmentVariables [kvp.Key] = kvp.Value;
						}
					}
				}

				StandardOutput ??= new StringWriter ();
				StandardError ??= new StringWriter ();

				if (Log != null) {
					if (!string.IsNullOrEmpty (p.StartInfo.WorkingDirectory))
						Log.Write ($"cd {StringUtils.Quote (p.StartInfo.WorkingDirectory)} && ");
					Log.WriteLine ("{0} {1}", p.StartInfo.FileName, p.StartInfo.Arguments);
				}
				p.Start ();
				var pid = p.Id;

				StartOutputThread (tcs, lockobj, p.StandardOutput, StandardOutput, $"StandardOutput reader for {p.StartInfo.FileName} (PID: {pid})");
				StartOutputThread (tcs, lockobj, p.StandardError, StandardError, $"StandardError reader for {p.StartInfo.FileName} (PID: {pid})");

				CancellationToken?.Register (() => {
					// Don't call tcs.TrySetCanceled, that won't return an Execution result to the caller.
					kill (pid, 9);
				});

				var thread = new Thread (() => {
					try {
						if (Timeout.HasValue) {
							if (!p.WaitForExit ((int) Timeout.Value.TotalMilliseconds)) {
								Log?.WriteLine ($"Command '{p.StartInfo.FileName} {p.StartInfo.Arguments}' didn't finish in {Timeout.Value.TotalMilliseconds} minutes, and will be killed.");
								TimedOut = true;
								kill (pid, 9); // SIGKILL
							}
						}
						// Always call this WaitForExit overload to be make sure the stdout/stderr buffers have been flushed,
						// even if we've called the WaitForExit (int) overload
						p.WaitForExit ();
						ExitCode = p.ExitCode;
						p.Dispose ();
						tcs.TrySetResult (this);
					} catch (Exception e) {
						tcs.TrySetException (e);
					}
				}) {
					IsBackground = true,
					Name = $"Thread waiting for {p.StartInfo.FileName} (PID: {pid}) to finish",
				};
				thread.Start ();
			} catch (Exception e) {
				tcs.TrySetException (e);
			}

			return tcs.Task;
		}

		public static Task<Execution> RunWithCallbacksAsync (string filename, IList<string> arguments, Dictionary<string, string> environment = null, Action<string> standardOutput = null, Action<string> standardError = null, TextWriter log = null, string workingDirectory = null, TimeSpan? timeout = null, CancellationToken? cancellationToken = null)
		{
			CallbackWriter outputCallback = null;
			CallbackWriter errorCallback = null;
			if (standardOutput != null)
				outputCallback = new CallbackWriter { Callback = standardOutput };
			if (standardOutput == standardError)
				errorCallback = outputCallback;
			else if (standardError != null)
				errorCallback = new CallbackWriter { Callback = standardError };
			return RunAsync (filename, arguments, environment, outputCallback, errorCallback, log, workingDirectory, timeout, cancellationToken);
		}

		public static Task<Execution> RunAsync (string filename, IList<string> arguments, Dictionary<string, string> environment = null, TextWriter standardOutput = null, TextWriter standardError = null, TextWriter log = null, string workingDirectory = null, TimeSpan? timeout = null, CancellationToken? cancellationToken = null)
		{
			return new Execution {
				FileName = filename,
				Arguments = arguments,
				Environment = environment,
				StandardOutput = standardOutput,
				StandardError = standardError,
				WorkingDirectory = workingDirectory,
				CancellationToken = cancellationToken,
				Timeout = timeout,
			}.RunAsync ();
		}

		public static Task<Execution> RunAsync (string filename, IList<string> arguments, Dictionary<string, string> environment = null, bool mergeOutput = false, string workingDirectory = null, TextWriter log = null, TimeSpan? timeout = null, CancellationToken? cancellationToken = null)
		{
			var standardOutput = new StringWriter ();
			var standardError = mergeOutput ? standardOutput : new StringWriter ();
			return RunAsync (filename, arguments, environment, standardOutput, standardError, log, workingDirectory, timeout, cancellationToken);
		}

		public static Task<Execution> RunWithStringBuildersAsync (string filename, IList<string> arguments, Dictionary<string, string> environment = null, StringBuilder standardOutput = null, StringBuilder standardError = null, TextWriter log = null, string workingDirectory = null, TimeSpan? timeout = null, CancellationToken? cancellationToken = null)
		{
			var stdout = standardOutput == null ? null : new StringWriter (standardOutput);
			var stderr = standardError == null ? null : (standardOutput == standardError ? stdout : new StringWriter (standardError));
			return RunAsync (filename, arguments, environment, stdout, stderr, log, workingDirectory, timeout, cancellationToken);
		}

		class CallbackWriter : TextWriter {
			public Action<string> Callback;
			public override void WriteLine (string value)
			{
				Callback (value);
			}

			public override Encoding Encoding => Encoding.UTF8;
		}
	}
}
