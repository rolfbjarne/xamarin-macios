#if !__WATCHOS__ && !MONOMAC
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

using CoreFoundation;
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
		} finally {
			runner.CloseWriter ();
		}
		return true;
	}
#endif

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

	public static bool RunAsync (DateTime timeout, Task startTask, Task completionTask, UIImage imageToShow = null)
	{
		return TestRuntime.RunAsync (timeout, startTask, completionTask, imageToShow);
	}

	public static bool RunAsync (DateTime timeout, Func<Task> startTask, Func<bool> completionTask, UIImage imageToShow = null)
	{
		return TestRuntime.RunAsync (timeout, startTask, completionTask, imageToShow);
	}

	public static bool RunAsync (DateTime timeout, Func<Task> startTask, Task completionTask, UIImage imageToShow = null)
	{
		return TestRuntime.RunAsync (timeout, startTask, completionTask, imageToShow);
	}

	public static bool RunAsync (DateTime timeout, Action action, Func<bool> check_completed, UIImage imageToShow = null)
	{
		return TestRuntime.RunAsync (timeout, action, check_completed, imageToShow);
	}

	public static IDisposable ShowAsyncUI (UIImage? imageToShow = null)
	{
		var state = new AsyncState (window);
		state.Show (imageToShow);
		return state;
	}
}

class AsyncState : IDisposable {
	UIWindow window;
	UIViewController? initialRootViewController;
	UINavigationController? navigation;

	public AsyncState (UIWindow window)
	{
		this.window = window;
	}

	public void Show (UIImage imageToShow)
	{
		var vc = new AsyncController (imageToShow);
		initialRootViewController = window.RootViewController;
		navigation = window.RootViewController as UINavigationController;

		// Pushing something to a navigation controller doesn't seem to work on phones
		if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone)
			navigation = null;

		if (navigation is not null) {
			navigation.PushViewController (vc, false);
		} else {
			window.RootViewController = vc;
		}
	}

	public void Hide ()
	{
		if (initialRootViewController is null)
			return;
		if (navigation is not null) {
			navigation.PopViewController (false);
		} else {
			window.RootViewController = initialRootViewController;
		}
		initialRootViewController = null; // set to null so if we're called again we know to do nothing.
	}

	public void Dispose ()
	{
		Hide ();
	}
}

class AsyncController : UIViewController {
	UIImage imageToShow;
	static int counter;

	public AsyncController (UIImage imageToShow = null)
	{
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
		if (imageToShow is not null) {
			var imgView = new UIImageView (View.Bounds);
			imgView.Image = imageToShow;
			imgView.ContentMode = UIViewContentMode.Center;
			View.AddSubview (imgView);
		}
	}
}

#endif // !__WATCHOS__
