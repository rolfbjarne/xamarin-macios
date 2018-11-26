#if !__WATCHOS__ && !MONOMAC
using System;
using System.Collections.Generic;
using System.Reflection;
#if XAMCORE_2_0
using Foundation;
using UIKit;
#else
using MonoTouch.Foundation;
using MonoTouch.UIKit;
#endif
using MonoTouch.NUnit.UI;
using NUnit.Framework.Internal;

namespace MonoTouchFixtures {
	
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate {
		// class-level declarations
		static UIWindow window;
		TouchRunner runner;

#if !__TVOS__
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
		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			runner = new TouchRunner (window);

			// tests can be inside the main assembly
			runner.Add (Assembly.GetExecutingAssembly ());
			runner.Add (typeof(EmbeddedResources.ResourcesTest).Assembly);
			runner.Add (typeof(Xamarin.BindingTests.ProtocolTest).Assembly);
			
			window.RootViewController = new UINavigationController (runner.GetViewController ());
			// make the window visible
			window.MakeKeyAndVisible ();

			NSTimer.CreateScheduledTimer (TimeSpan.FromSeconds (1), (var) => {
				string name;
				var rt = new ObjCRuntime.RegistrarTest ();

				name = nameof (rt.___RefOutTest_StringArray);
				try {
					Console.WriteLine (name);
					rt.___RefOutTest_StringArray ();
					Console.WriteLine ("✅ SUCCESS! {0}", name);
				} catch (Exception e) {
					Console.WriteLine ("❌ FAILURE! {0}", name);
					Console.WriteLine (e);
				}

				name = nameof (rt.___RefOutTest_NSValueArray);
				try {
					Console.WriteLine (name);
					rt.___RefOutTest_NSValueArray ();
					Console.WriteLine ("✅ SUCCESS! {0}", name);
				} catch (Exception e) {
					Console.WriteLine ("❌ FAILURE! {0}", name);
					Console.WriteLine (e);
				}

				name = nameof (rt.___RefOutTest_NSValueArray);
				try {
					Console.WriteLine (name);
					rt.___RefOutTest_NSValueArray ();
					Console.WriteLine ("✅ SUCCESS! {0}", name);
				} catch (Exception e) {
					Console.WriteLine ("❌ FAILURE! {0}", name);
					Console.WriteLine (e);
				}

				name = nameof (rt.___RefOutTest_INSCodingArray);
				try {
					Console.WriteLine (name);
					rt.___RefOutTest_INSCodingArray ();
					Console.WriteLine ("✅ SUCCESS! {0}", name);
				} catch (Exception e) {
					Console.WriteLine ("❌ FAILURE! {0}", name);
					Console.WriteLine (e);
				}

				name = nameof (rt.___RefOutTest_String);
				try {
					Console.WriteLine (name);
					rt.___RefOutTest_String ();
					Console.WriteLine ("✅ SUCCESS! {0}", name);
				} catch (Exception e) {
					Console.WriteLine ("❌ FAILURE! {0}", name);
					Console.WriteLine (e);
				}

				name = nameof (rt.___RefOutTest_NSValue);
				try {
					Console.WriteLine (name);
					rt.___RefOutTest_NSValue ();
					Console.WriteLine ("✅ SUCCESS! {0}", name);
				} catch (Exception e) {
					Console.WriteLine ("❌ FAILURE! {0}", name);
					Console.WriteLine (e);
				}

				name = nameof (rt.___RefOutTest_NSObject);
				try {
					Console.WriteLine (name);
					rt.___RefOutTest_NSObject ();
					Console.WriteLine ("✅ SUCCESS! {0}", name);
				} catch (Exception e) {
					Console.WriteLine ("❌ FAILURE! {0}", name);
					Console.WriteLine (e);
				}

				name = nameof (rt.___RefOutTest_INSCoding);
				try {
					Console.WriteLine (name);
					rt.___RefOutTest_INSCoding ();
					Console.WriteLine ("✅ SUCCESS! {0}", name);
				} catch (Exception e) {
					Console.WriteLine ("❌ FAILURE! {0}", name);
					Console.WriteLine (e);
				}

				name = nameof (rt.___RefOutTest_CFBundle);
				try {
					Console.WriteLine (name);
					rt.___RefOutTest_CFBundle ();
					Console.WriteLine ("✅ SUCCESS! {0}", name);
				} catch (Exception e) {
					Console.WriteLine ("❌ FAILURE! {0}", name);
					Console.WriteLine (e);
				}

				name = nameof (rt.___RefOutTest_Int);
				try {
					Console.WriteLine (name);
					rt.___RefOutTest_Int ();
					Console.WriteLine ("✅ SUCCESS! {0}", name);
				} catch (Exception e) {
					Console.WriteLine ("❌ FAILURE! {0}", name);
					Console.WriteLine (e);
				}

				name = nameof (rt.___RefOutTest_Sel);
				try {
					Console.WriteLine (name);
					rt.___RefOutTest_Sel ();
					Console.WriteLine ("✅ SUCCESS! {0}", name);
				} catch (Exception e) {
					Console.WriteLine ("❌ FAILURE! {0}", name);
					Console.WriteLine (e);
				}

				name = nameof (rt.___RefOutTest_ClassArray);
				try {
					Console.WriteLine (name);
					rt.___RefOutTest_ClassArray ();
					Console.WriteLine ("✅ SUCCESS! {0}", name);
				} catch (Exception e) {
					Console.WriteLine ("❌ FAILURE! {0}", name);
					Console.WriteLine (e);
				}

				name = nameof (rt.___RefOutTest_Class);
				try {
					Console.WriteLine (name);
					rt.___RefOutTest_Class ();
					Console.WriteLine ("✅ SUCCESS! {0}", name);
				} catch (Exception e) {
					Console.WriteLine ("❌ FAILURE! {0}", name);
					Console.WriteLine (e);
				}

				//Environment.Exit (0);
			});
			return true;
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

		public static bool RunAsync (DateTime timeout, Action action, Func<bool> check_completed)
		{
			var vc = new AsyncController (action);
			var bckp = window.RootViewController;
			window.RootViewController = vc;
			try {
				do {
					if (timeout < DateTime.Now)
						return false;
					NSRunLoop.Main.RunUntil (NSDate.Now.AddSeconds (0.1));
				} while (!check_completed ());
			} finally {
				window.RootViewController = bckp;
			}

			return true;
		}
	}

	class AsyncController : UIViewController {
		Action action;
		static int counter;

		public AsyncController (Action action)
		{
			this.action = action;
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
#if XAMCORE_2_0
			NSTimer.CreateScheduledTimer (0.01, (v) => action ());
#else
			NSTimer.CreateScheduledTimer (0.01, () => action ());
#endif
		}
	}
}

#endif // !__WATCHOS__
