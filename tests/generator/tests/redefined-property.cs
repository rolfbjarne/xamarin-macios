using System;

using Foundation;
using ObjCRuntime;
using UIKit;

namespace NS {
	[BaseType (typeof (UITabBarController))]
	interface MyObject {
		[Export("supportedInterfaceOrientations")]
		UIInterfaceOrientationMask SupportedInterfaceOrientations { get; }
	}
}
