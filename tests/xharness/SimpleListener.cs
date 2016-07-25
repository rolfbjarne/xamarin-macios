using System;
using System.Net;
using System.IO;
using System.Text;
using System.Threading;

namespace xharness
{
	public abstract class SimpleListener : IDisposable
	{
		FileStream output_stream;

		protected ManualResetEvent stopped = new ManualResetEvent (false);
		protected ManualResetEvent connected = new ManualResetEvent (false);

		public IPAddress Address { get; set; }
		public int Port { get; set; }
		public Log Log { get; set; }
		public LogStream TestLog { get; set; }
		public bool AutoExit { get; set; }

		public abstract void Initialize ();
		protected abstract void Start ();
		protected abstract void Stop ();

		public FileStream OutputStream {
			get {
				return output_stream;
			}
		}

		protected void Connected (string remote)
		{
			Log.WriteLine ("Connection from {0} saving logs to {1}", remote, TestLog.FullPath);
			connected.Set ();

			if (output_stream != null) {
				output_stream.Flush ();
				output_stream.Dispose ();
			}

			var fs = TestLog.FileStream;
			// a few extra bits of data only available from this side
			string header = String.Format ("[Local Date/Time:\t{1}]{0}[Remote Address:\t{2}]{0}",
				Environment.NewLine, DateTime.Now, remote);
			byte [] array = Encoding.UTF8.GetBytes (header);
			fs.Write (array, 0, array.Length);
			fs.Flush ();
			output_stream = fs;
		}


		public void StartAsync ()
		{
			var t = new Thread (Start)
			{
				IsBackground = true,
			};
			t.Start ();
		}

		public bool WaitForConnection (TimeSpan ts)
		{
			return connected.WaitOne (ts);
		}

		public bool WaitForCompletion (TimeSpan ts)
		{
			bool rv;
			var ms = (int) ts.TotalMilliseconds;
			Console.WriteLine ("{0} WAITING 1 {1}", DateTime.Now, ms);
			rv = stopped.WaitOne (ms, false);
			Console.WriteLine ("{0} WAITING 2 {1}: {2}", DateTime.Now, ms, rv);
			return rv;
		}

		public void Cancel ()
		{
			try {
				// wait a second just in case more data arrives.
				bool rv;
				Console.WriteLine ("CANCELLING 1");
				rv = stopped.WaitOne (TimeSpan.FromSeconds (1));
				Console.WriteLine ("CANCELLING 1: {0}", rv);
				if (!rv)
					Stop ();
			} catch {
				// We might have stopped already, so just ignore any exceptions.
			}
		}

#region IDisposable Support
		protected virtual void Dispose (bool disposing)
		{
			if (output_stream != null)
				output_stream.Dispose ();
		}

		public void Dispose ()
		{
			Dispose (true);
		}
#endregion

	}
}

