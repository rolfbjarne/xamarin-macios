using Foundation;
using UIKit;

namespace MyExtensionContainer
{
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			window.MakeKeyAndVisible ();

			return true;
		}

		static void Main (string [] args)
		{
			UIApplication.Main (args, null, typeof (AppDelegate));
		}
	}
}

