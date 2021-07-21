using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;

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

		static byte [] compressed_data = { 0xf3, 0x48, 0xcd, 0xc9, 0xc9,
			0xe7, 0x02, 0x00 };


		void ThrowA ()
		{
			throw new ArgumentNullException ();
		}

		void ThrowB ()
		{
			Assert.Throws<ArgumentNullException> (ThrowA, "ThrowA message");
			Assert.Throws (typeof (ArgumentNullException), ThrowA, "ThrowA message B");

			MemoryStream backing = new MemoryStream (compressed_data);
			DeflateStream decompressing = new DeflateStream (backing, CompressionMode.Decompress, CompressionAlgorithm.Zlib);
			Assert.Throws<NotSupportedException> (() => { var length = decompressing.Length; });


			Console.WriteLine ("✅ SUCCESS");
		}

		void ThrowC ()
		{
			try {
				ThrowB ();
				Console.WriteLine ("✅ Caught no exception C!");
			} catch (Exception e) {
				Console.WriteLine ("❌ Caught Exception: {0}", e);
			}
		}

		void ThrowD ()
		{
			try {
				GetType ().GetMethod ("ThrowB", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Invoke (this, new object [0]);
				Console.WriteLine ("✅ Caught no exception D!");
			} catch (Exception e) {
				Console.WriteLine ("❌ Caught Exception: {0}", e);
			}
		}

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			ThrowC ();
			ThrowD ();

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
