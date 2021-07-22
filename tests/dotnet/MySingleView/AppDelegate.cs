using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Threading;

using Compression;
using Foundation;
using UIKit;

using NUnit.Framework;

using DeflateStream = Compression.CompressionStream; // done to not differ from the mono tests

namespace MySingleView
{
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		static string SelectHostName ()
		{
			return SelectHostName (new string [] { "192.168.1.82", "169.254.34.163", "fe80::48d:fb00:89bf:c36c", "fe80::aede:48ff:fe00:1122", "fe80::14a6:1e61:2f4e:e2c5", "fe80::6aa3:6295:30dd:b552"}, 49681);
		}

		static string SelectHostName (string[] names, int port)
		{
			if (names.Length == 0)
				return null;

			if (names.Length == 1)
				return names [0];

			object lock_obj = new object ();
			string result = null;
			int failures = 0;

			using (var evt = new ManualResetEvent (false)) {
				for (int i = names.Length - 1; i >= 0; i--) {
					var name = names [i];
					ThreadPool.QueueUserWorkItem ((v) =>
						{
							try {
								var client = new TcpClient (name, port);
								using (var writer = new StreamWriter (client.GetStream ())) {
									writer.WriteLine ("ping");
								}
								lock (lock_obj) {
									if (result == null)
										result = name;
								}
								evt.Set ();
							} catch (Exception e) {
								lock (lock_obj) {
									Console.WriteLine ("TCP connection failed when selecting 'hostname': {0} and 'port': {1}. {2}", name, port, e);
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

			Console.WriteLine ($"Selected host name: {result}");

			return result;
		}

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			SelectHostName ();

			var dvc = new UIViewController ();
			var button = new UIButton (window.Bounds);
			button.SetTitle ("net6!", UIControlState.Normal);
			dvc.Add (button);

			window.RootViewController = dvc;
			window.MakeKeyAndVisible ();

			return true;
		}
	}
}
