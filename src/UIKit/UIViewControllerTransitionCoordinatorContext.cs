//
// UIViewControllerTransitionCoordinatorContext.cs: Helper methods to make the class more usable
//
// Authors: miguel de icaza
//
// Copyright 2014 Xamarin
//

using System.Runtime.Versioning;

// Disable until we get around to enable + fix any issues.
#nullable disable

namespace UIKit {
	public static partial class UIViewControllerTransitionCoordinatorContext_Extensions {
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		public static UIView GetTransitionViewController (this IUIViewControllerTransitionCoordinatorContext This, UITransitionViewControllerKind kind)
		{
			switch (kind) {
			case UITransitionViewControllerKind.ToView:
				return This.GetTransitionViewControllerForKey (UITransitionContext.ToViewKey);
			case UITransitionViewControllerKind.FromView:
				return This.GetTransitionViewControllerForKey (UITransitionContext.FromViewKey);
			default:
				return null;
			}
		}
	}
}
