// this is an adaptation of NUnitLite's TcpWriter.cs with an additional 
// overrides and with network-activity UI enhancement
// This code is a small modification of 
// https://github.com/spouliot/Touch.Unit/blob/master/NUnitLite/TouchRunner/TcpTextWriter.cs
using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

#if __IOS__
using UIKit;
#endif

namespace BCLTests.TestRunner.Core {
	public class TcpTextWriter : TextWriter {
		
		TcpClient client;
		StreamWriter writer;
		
		void ConnectToAny (string[] names, int port)
		{
			if (names.Length == 0) {
				Console.WriteLine ("No hosts provided to connect to.");
				return;
			}

			TcpClient connected_client = null;
			StreamWriter connected_writer = null;
			object lock_obj = new object ();
			string result = null;
			int failures = 0;

			Console.WriteLine ($"Selecting between multiple hosts: {string.Join (", ", names)} on {port}");
			using (var evt = new ManualResetEvent (false)) {
				for (int i = names.Length - 1; i >= 0; i--) {
					var name = names [i];
					ThreadPool.QueueUserWorkItem ((v) =>
						{
							try {
								var client_attempt = new TcpClient (name, port);
								client_attempt.NoDelay = true;
								var writer_attempt = new StreamWriter (client_attempt.GetStream ());
								for (int x = 0; x < 200; x++)
									writer_attempt.WriteLine ($"ping{x}");
								writer = writer_attempt;
								WriteLine ("Hello world");
								Console.WriteLine ($"    Successfully connected {name}:{port}");
								lock (lock_obj) {
									if (connected_client == null) {
										connected_client = client_attempt;
										connected_writer = writer_attempt;
										result = name;
									}
								}
								evt.Set ();
							} catch (Exception e) {
								Console.WriteLine ($"    Failed to connect to {name}:{port}: {e.Message}");
								lock (lock_obj) {
									failures++;
									if (failures == names.Length)
										evt.Set ();
								}
							}
						});
				}

				// Wait for 1 success or all failures
				evt.WaitOne ();
			}

			Console.WriteLine ($"Selected host: {result}");

			client = connected_client;
			writer = connected_writer;
			HostName = result;
			Port = port;

			for (int i = 0; i < 100000; i++)
				transmit_queue.Add (new TransmitData { StringValue = $"Hello world {i}\n"});

			var transmit_thread = new Thread (Transmit);
			transmit_thread.IsBackground = true;
			transmit_thread.Start ();

			WriteLine ("Host selection complete");
		}

		public TcpTextWriter (string hostName, int port)
		{
			if ((port < 0) || (port > ushort.MaxValue))
				throw new ArgumentOutOfRangeException (nameof (port), $"Port must be between 0 and {ushort.MaxValue}" );

			if (hostName == null)
				throw new ArgumentNullException (nameof (hostName));

#if __IOS__
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;
#endif

			try {
				ConnectToAny (hostName.Split (','), port);
			}
			catch {
#if __IOS__
				UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
#endif
				throw;
			}
		}
		
		public string HostName { get; private set; }
		
		public int Port { get; private set; }

		// we override everything that StreamWriter overrides from TextWriter

		public override System.Text.Encoding Encoding => Encoding.UTF8;

		public override void Close ()
		{
#if __IOS__
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
#endif
			Console.WriteLine ("TcpTextWriter.Close ()");
			writer.Close ();
		}
		
		protected override void Dispose (bool disposing)
		{
			Console.WriteLine ("TcpTextWriter.Dispose ()");
			transmit_queue.CompleteAdding ();
			Console.WriteLine ("TcpTextWriter.Dispose () waiting for transmit completion...");
			transmit_complete.WaitOne ();
			Console.WriteLine ("TcpTextWriter.Dispose () transmit completed");
		}

		class TransmitData {
			public string StringValue;
			public char CharValue;
			public char[] CharArray;
			public int Index;
			public int Count;
			public bool Flush;
		}
		BlockingCollection<TransmitData> transmit_queue = new BlockingCollection<TransmitData> ();
		ManualResetEvent transmit_complete = new ManualResetEvent (false);
		void Transmit ()
		{
			try {
				while (transmit_queue.TryTake (out var data, Timeout.Infinite)) {
					Console.WriteLine ($"Got data to transmit, {transmit_queue.Count} items left");
					if (data.StringValue != null) {
						writer.Write (data.StringValue);
					} else if (data.CharArray != null) {
						writer.Write (data.CharArray, data.Index, data.Count);
					} else if (data.CharValue != 0) {
						writer.Write (data.CharValue);
					} else {
						Console.WriteLine ("Unknown data type to transmit.");
					}
					if (data.Flush) {
						//writer.Flush ();
						Console.WriteLine ("{0} Not flushed", DateTime.Now);
					}
				}
			 	writer.Dispose ();
				Console.WriteLine ("Transmit complete.");
			} catch (Exception e) {
				Console.WriteLine ($"Failed to transmit data: {e.Message}");
			} finally {
				transmit_complete.Set ();
			}
		}

		void Transmit (TransmitData data, string type)
		{
			transmit_queue.Add (data);
			Console.WriteLine ($"Added {type} to transmit, {transmit_queue.Count} items in queue");
			Thread.Sleep (100);
		}

		public override void Flush ()
		{
			Transmit (new TransmitData { Flush = true }, "flush");
		}

		// minimum to override - see http://msdn.microsoft.com/en-us/library/system.io.textwriter.aspx
		public override void Write (char value)
		{
			Transmit (new TransmitData { CharValue = value }, "char");
		}
		
		public override void Write (char[] buffer)
		{
			Transmit (new TransmitData { CharArray = buffer, Index = 0, Count = buffer?.Length ?? 0 }, "char[]");
		}
		
		public override void Write (char[] buffer, int index, int count)
		{
			Transmit(new TransmitData { CharArray = buffer, Index = index, Count = count }, "char[],int,int");
		}

		public override void Write (string value)
		{
			Transmit (new TransmitData { StringValue = value }, "string");
		}
		
		// special extra override to ensure we flush data regularly

		public override void WriteLine ()
		{
			Transmit (new TransmitData { StringValue = "\n", Flush = true }, "newline");
		}
	}
}
