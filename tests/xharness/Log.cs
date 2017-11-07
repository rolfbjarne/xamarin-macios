﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Text;

namespace xharness
{
	public abstract class Log : TextWriter
	{
		public string Description;
		public bool Timestamp;

		protected Log ()
		{
		}

		protected Log (string description)
		{
			Description = description;
		}

		public abstract string FullPath { get; }

		protected abstract void WriteImpl (string value);

		public virtual StreamReader GetReader ()
		{
			throw new NotSupportedException ();
		}

		public virtual StreamWriter GetWriter ()
		{
			throw new NotSupportedException ();
		}

		public override void Write (string value)
		{
			if (Timestamp)
				value = DateTime.Now.ToString ("HH:mm:ss.fffffff") + " " + value;
			WriteImpl (value);
		}

		public override void WriteLine (string value)
		{
			Write (value + "\n");
		}

		public override void WriteLine (string format, params object [] args)
		{
			Write (string.Format (format, args) + "\n");
		}

		public override string ToString ()
		{
			return Description;
		}

		public override void Flush ()
		{
		}

		public override Encoding Encoding {
			get {
				return System.Text.Encoding.UTF8;
			}
		}

		public static Log CreateAggregatedLog (params Log [] logs)
		{
			return new AggregatedLog (logs);
		}

		// Log that will duplicate log output to multiple other logs.
		class AggregatedLog : Log
		{
			Log [] logs;

			public AggregatedLog (params Log [] logs)
			{
				this.logs = logs;
			}

			public override string FullPath => throw new NotImplementedException ();

			protected override void WriteImpl (string value)
			{
				foreach (var log in logs)
					log.WriteImpl (value);
			}
		}
	}

	public class LogFile : Log
	{
		public string Path;
		StreamWriter writer;

		public LogFile (string description, string path, bool append = true)
			: base (description)
		{
			Path = path;

			writer = new StreamWriter (new FileStream (Path, append ? FileMode.Append : FileMode.Create, FileAccess.Write, FileShare.Read));
			writer.AutoFlush = true;
		}

		protected override void WriteImpl (string value)
		{
			writer.Write (value);
		}

		public override string FullPath {
			get {
				return Path;
			}
		}

		public override StreamReader GetReader ()
		{
			return new StreamReader (new FileStream (Path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
		}

		public override StreamWriter GetWriter ()
		{
			return writer;
		}

		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);

			if (writer != null) {
				writer.Dispose ();
				writer = null;
			}
		}
	}

	public class LogStream : Log
	{
		string path;
		FileStream fs;
		StreamWriter writer;

		public FileStream FileStream {
			get {
				return fs;
			}
		}

		public override StreamReader GetReader ()
		{
			return new StreamReader (new FileStream (path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
		}

		public override StreamWriter GetWriter ()
		{
			return writer ?? (writer = new StreamWriter (fs) { AutoFlush = true });
		}

		public LogStream (string description, string path)
			: base (description)
		{
			this.path = path;

			fs = new FileStream (path, FileMode.Create, FileAccess.Write, FileShare.Read);
		}

		protected override void WriteImpl (string value)
		{
			var w = GetWriter ();
			w.Write (value);
			w.Flush ();
		}

		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);

			if (writer != null) {
				writer.Dispose ();
				writer = null;
			}

			if (fs != null) {
				fs.Dispose ();
				fs = null;
			}
		}

		public override string FullPath {
			get {
				return path;
			}
		}
	}

	public class Logs : List<Log>
	{
		public LogStream CreateStream (string directory, string filename, string name)
		{
			Directory.CreateDirectory (directory);
			var rv = new LogStream (name, Path.GetFullPath (Path.Combine (directory, filename)));
			Add (rv);
			return rv;
		}

		public LogFile CreateFile (string description, string path, bool append = true)
		{
			var rv = new LogFile (description, path, append);
			Add (rv);
			return rv;
		}
	}

	public class ConsoleLog : Log
	{
		StringBuilder captured = new StringBuilder ();

		protected override void WriteImpl (string value)
		{
			captured.Append (value);
			Console.Write (value);
		}

		public override string FullPath {
			get {
				throw new NotSupportedException ();
			}
		}

		public override StreamWriter GetWriter ()
		{
			return new StreamWriter (Console.OpenStandardOutput ());
		}

		public override StreamReader GetReader ()
		{
			var str = new MemoryStream (System.Text.Encoding.UTF8.GetBytes (captured.ToString ()));
			return new StreamReader (str, System.Text.Encoding.UTF8, false);
		}
	}

	public class CaptureLog : Log
	{
		public string CapturePath { get; private set; }
		public string Path { get; set; }

		long startPosition;
		long endPosition;
		bool entire_file;

		public CaptureLog (string capture_path, bool entire_file = false)
		{
			CapturePath = capture_path;
			this.entire_file = entire_file;
		}

		public void StartCapture ()
		{
			if (entire_file)
				return;

			if (File.Exists (CapturePath))
				startPosition = new FileInfo (CapturePath).Length;
		}

		public void StopCapture ()
		{
			if (!File.Exists (CapturePath)) {
				File.WriteAllText (Path, $"Could not capture the file '{CapturePath}' because it doesn't exist.");
				return;
			}

			if (entire_file) {
				File.Copy (CapturePath, Path, true);
				return;
			}

			endPosition = new FileInfo (CapturePath).Length;

			Capture ();
		}

		void Capture ()
		{
			if (startPosition == 0 || entire_file)
				return;
			
			var currentEndPosition = endPosition;
			if (currentEndPosition == 0)
				currentEndPosition = new FileInfo (CapturePath).Length;
			
			var length = (int) (currentEndPosition - startPosition);
			var currentLength = new FileInfo (CapturePath).Length;
			var capturedLength = 0L;

			if (File.Exists (Path))
				capturedLength = new FileInfo (Path).Length;

			// capture 1k more data than when we stopped, since the system log
			// is cached in memory and flushed once in a while (so when the app
			// requests the system log to be captured, it's usually not complete).
			var availableLength = currentLength - startPosition;
			if (availableLength <= capturedLength)
				return; // We've captured before, and nothing new as added since last time.

			// Capture at most 1k more
			availableLength = Math.Min (availableLength, length + 1024);

			using (var reader = new FileStream (CapturePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
				using (var writer = new FileStream (Path, FileMode.Create, FileAccess.Write, FileShare.Read)) {
					var buffer = new byte [4096];
					reader.Position = startPosition;
					while (availableLength > 0) {
						int read = reader.Read (buffer, 0, Math.Min (buffer.Length, length));
						if (read > 0) {
							writer.Write (buffer, 0, read);
							availableLength -= read;
						} else {
							// There's nothing more to read.
							// I can't see how we get here, since we calculate the amount to read based on what's available, but it does happen randomly.
							break;
						}
					}
				}
			}
		}

		public override void Flush ()
		{
			base.Flush ();

			Capture ();
		}

		protected override void WriteImpl (string value)
		{
			throw new InvalidOperationException ();
		}

		public override string FullPath {
			get {
				return Path;
			}
		}
	}

	public class CallbackLog : Log
	{
		public Action<string> OnWrite;

		public CallbackLog (Action<string> onWrite)
		{
			OnWrite = onWrite;
		}

		public override string FullPath => throw new NotImplementedException ();

		protected override void WriteImpl (string value)
		{
			OnWrite (value);
		}
	}
}

