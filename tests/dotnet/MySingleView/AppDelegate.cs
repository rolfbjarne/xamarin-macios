using System;

using Foundation;
using UIKit;

using NUnit.Framework;

namespace MySingleView
{
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			var dvc = new UIViewController ();
			var button = new UIButton (window.Bounds);
			button.SetTitle ("net6!", UIControlState.Normal);
			dvc.Add (button);

			Assert.That (0, Is.EqualTo (0));

			window.RootViewController = dvc;
			window.MakeKeyAndVisible ();

			return true;
		}
	}
}
