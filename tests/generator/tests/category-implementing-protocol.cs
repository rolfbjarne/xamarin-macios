using System;

using Foundation;
using ObjCRuntime;
using UIKit;

namespace NS {
	[BaseType(typeof(UINavigationController))]
	interface MyNavigationController
	{
	}

	[Category]
	[BaseType(typeof(MyNavigationController))]
	interface MyCategory : IUIAdaptivePresentationControllerDelegate
	{
	}
}
