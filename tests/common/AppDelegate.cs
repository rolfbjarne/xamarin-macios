using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

using Foundation;
#if !__MACOS__
using UIKit;
#endif

using MonoTouch.NUnit.UI;
using NUnit.Framework;
using NUnit.Framework.Internal;

[Register ("AppDelegate")]
public partial class AppDelegate : UIApplicationDelegate {
#if __MACCATALYST__
	public static ManualResetEvent FinishedLaunchingEvent = new ManualResetEvent (false);
#endif
	public static TouchRunner Runner { get; set; }

#if !__MACOS__
	public override UIWindow Window { get; set; }
#endif

	public partial IEnumerable<Assembly> GetTestAssemblies ();

	partial void PostFinishedLaunching ();

	public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
#if __MACCATALYST__
		FinishedLaunchingEvent.Set ();
		// Debug spew to track down https://github.com/xamarin/maccore/issues/2414
		Console.WriteLine ("AppDelegate.FinishedLaunching");
#endif
		var window = new UIWindow (UIScreen.MainScreen.Bounds);

		var runner = new TouchRunner (window);
		foreach (var assembly in GetTestAssemblies ())
			runner.Add (assembly);

		Window = window;
		Runner = runner;

		window.RootViewController = new UINavigationController (runner.GetViewController ());
		window.MakeKeyAndVisible ();

		PostFinishedLaunching ();

		return true;
	}
}

public static class MainClass {
#if __MACCATALYST__
	[DllImport ("/usr/lib/libSystem.dylib")]
	static extern void _exit (int exit_code);
#endif

	static void Main (string [] args)
	{
#if __MACCATALYST__

		var thread = new Thread ((v) => {
			if (!AppDelegate.FinishedLaunchingEvent.WaitOne (TimeSpan.FromSeconds (10))) {
				Console.Error.WriteLine ("Launch timeout of 10 seconds reached! Will now exit the process abruptly.");
				_exit (99);
			} else {
				Console.Error.WriteLine ("Finished launching reached as expected, launch watchdog cancelled.");
			}
		}) {
			IsBackground = true,
		};
		thread.Start ();
#endif
#if !__MACOS__
		UIApplication.Main (args, null, typeof (AppDelegate));
#endif
	}
}
