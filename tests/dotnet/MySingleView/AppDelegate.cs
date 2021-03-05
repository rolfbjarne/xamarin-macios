using System;
using System.Net;
using System.Net.Http;

using Foundation;
using UIKit;

namespace MySingleView
{
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);


			const string url = "http://www.google.com";
			Uri uri = new Uri (url);
			HttpWebRequest hwr = WebRequest.CreateHttp (uri);
			WebResponse wr = hwr.GetResponse ();
			Console.WriteLine("That worked");



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
