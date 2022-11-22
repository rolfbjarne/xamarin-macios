#if !__WATCHOS__
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using MonoTouch.NUnit.UI;

using Bindings.Test;

namespace LinkAll
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		TouchRunner runner;

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			var x = new UltimateMachine2();

#if __MACCATALYST__
			// Debug spew to track down https://github.com/xamarin/maccore/issues/2414
			Console.WriteLine ("AppDelegate.FinishedLaunching");
#endif
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			runner = new TouchRunner (window);

			// register every tests included in the main application/assembly
			runner.Add (System.Reflection.Assembly.GetExecutingAssembly ());
			runner.Add (typeof (BundledResources.ResourcesTest).Assembly);

			window.RootViewController = new UINavigationController (runner.GetViewController ());
			
			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}

		static void Main (string[] args)
		{
			UIApplication.Main (args, null, typeof (AppDelegate));
		}
	}
}
#endif // !__WATCHOS__
