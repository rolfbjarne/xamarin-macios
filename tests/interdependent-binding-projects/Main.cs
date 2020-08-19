using System;

using Foundation;
using UIKit;

using MonoTouch.NUnit.UI;
using NUnit.Framework;
using NUnit.Framework.Internal;

#if !__WATCHOS__
[Register ("AppDelegate")]
public partial class AppDelegate : UIApplicationDelegate
{
	UIWindow window;
	TouchRunner runner;

	public override bool FinishedLaunching (UIApplication app, NSDictionary options)
	{
		window = new UIWindow (UIScreen.MainScreen.Bounds);

		runner = new TouchRunner (window);
		runner.Add (System.Reflection.Assembly.GetExecutingAssembly ());
		runner.Add (typeof (Xamarin.BindingTests2.BindingTest).Assembly);
		runner.Add (typeof (Xamarin.BindingTests.ProtocolTest).Assembly);

		window.RootViewController = new UINavigationController (runner.GetViewController ());
		window.MakeKeyAndVisible ();

		return true;
	}

	static void Main (string[] args)
	{
		UIApplication.Main (args, null, typeof (AppDelegate));
	}
}
#else
public static partial class TestLoader {
	static partial void AddTestAssembliesImpl (BaseTouchRunner runner)
	{
		runner.Add (typeof (Xamarin.BindingTests2.BindingTest).Assembly);
		runner.Add (typeof (Xamarin.BindingTests.ProtocolTest).Assembly);
	}
}

#endif // !__WATCHOS__
