// 
// UIScreen.cs: Helper methods for UIScreen.
//
// Authors:
//   Miguel de Icaza
//     
// Copyright 2010 Novell, Inc
// Copyright 2014 Xamarin Inc.
//

using System;
using System.Collections;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

// Disable until we get around to enable + fix any issues.
#nullable disable

namespace UIKit {
	public partial class UIScreen {

		public CoreAnimation.CADisplayLink CreateDisplayLink (Action action)
		{
			if (action is null)
				throw new ArgumentNullException ("action");
			var d = new NSActionDispatcher (action);
			return CreateDisplayLink (d, NSActionDispatcher.Selector);
		}

		public UIImage Capture ()
		{
			// This is from https://developer.apple.com/library/content/qa/qa1817/_index.html
			try {
				// Ignore this CA1422 warning, because it only applies for apps that support multiple windows (the code still works as expected for single-window apps).
#pragma warning disable CA1422 // This call site is reachable on: 'ios' 12.2 and later, 'maccatalyst' 12.2 and later, 'tvos' 12.2 and later. 'UIApplication.KeyWindow' is obsoleted on: 'ios' 13.0 and later (Should not be used for applications that support multiple scenes because it returns a key window across all connected scenes.), 'maccatalyst' 13.0 and later (Should not be used for applications that support multiple scenes because it returns a key window across all connected scenes.), 'tvos' 13.0 and later (Should not be used for applications that support multiple scenes because it returns a key window across all connected scenes.).
				var view = UIApplication.SharedApplication.KeyWindow;
#pragma warning restore CA1422
				UIGraphics.BeginImageContextWithOptions (view.Bounds.Size, view.Opaque, 0);
				view.DrawViewHierarchy (view.Bounds, true);
				return UIGraphics.GetImageFromCurrentImageContext ();
			} finally {
				UIGraphics.EndImageContext ();
			}
		}
	}
}
