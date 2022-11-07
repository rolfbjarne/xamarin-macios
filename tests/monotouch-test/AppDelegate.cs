#if !__WATCHOS__ && !MONOMAC
using System;
using System.Collections.Generic;
using System.Reflection;
using Foundation;
using UIKit;
using MonoTouch.NUnit.UI;
using NUnit.Framework.Internal;
using MonoTouchFixtures.BackgroundTasks;

public partial class AppDelegate : UIApplicationDelegate {
	// class-level declarations
	static UIWindow window;
	TouchRunner runner => Runner;

#if __IOS__ && !__MACCATALYST__
	public override bool AccessibilityPerformMagicTap ()
	{
		try {
			runner.OpenWriter ("Magic Tap");
			runner.Run (runner.LoadedTest as TestSuite);
		}
		finally {
			runner.CloseWriter ();
		}
		return true;
	}
#endif

	public partial IEnumerable<Assembly> GetTestAssemblies ()
	{
		return new Assembly [] {
			Assembly.GetExecutingAssembly (),
			typeof (EmbeddedResources.ResourcesTest).Assembly,
			typeof (Xamarin.BindingTests.ProtocolTest).Assembly,
		};
	}

	partial void PostFinishedLaunching ()
	{
		// required for the background tasks tests, we can only register the tasks in this method
		BGTaskSchedulerTest.RegisterTestTasks ();
		window = Window;
	}

	public static void PresentModalViewController (UIViewController vc, double duration)
	{
		var bckp = window.RootViewController;
		window.RootViewController = vc;
		try {
			NSRunLoop.Main.RunUntil (NSDate.Now.AddSeconds (duration));
		} finally {
			window.RootViewController = bckp;
		}
	}

	public static bool RunAsync (DateTime timeout, Action action, Func<bool> check_completed, UIImage imageToShow = null)
	{
		var vc = new AsyncController (action, imageToShow);
		var bckp = window.RootViewController;
		var navigation = bckp as UINavigationController;

		if (navigation != null) {
			navigation.PushViewController (vc, false);
		} else {
			window.RootViewController = vc;
		}

		try {
			do {
				if (timeout < DateTime.Now)
					return false;
				NSRunLoop.Main.RunUntil (NSDate.Now.AddSeconds (0.1));
			} while (!check_completed ());
		} finally {
			if (navigation != null) {
				navigation.PopViewController (false);
			} else {
				window.RootViewController = bckp;
			}
		}

		return true;
	}
}

class AsyncController : UIViewController {
	Action action;
	UIImage imageToShow;
	static int counter;

	public AsyncController (Action action, UIImage imageToShow = null)
	{
		this.action = action;
		this.imageToShow = imageToShow;
		counter++;
	}

	public override void ViewDidLoad ()
	{
		base.ViewDidLoad ();

		switch (counter % 2) {
		case 0:
			View.BackgroundColor = UIColor.Yellow;
			break;
		default:
			View.BackgroundColor = UIColor.LightGray;
			break;
		}
		if (imageToShow != null) {
			var imgView = new UIImageView (View.Bounds);
			imgView.Image = imageToShow;
			imgView.ContentMode = UIViewContentMode.Center;
			View.AddSubview (imgView);
		}
		NSTimer.CreateScheduledTimer (0.01, (v) => action ());
	}
}

#endif // !__WATCHOS__
