// Copyright 2012-2013 Xamarin Inc. All rights reserved

#if !__WATCHOS__ && !MONOMAC

using System;
using System.Drawing;
#if XAMCORE_2_0
using Foundation;
using UIKit;
#else
using MonoTouch.Foundation;
using MonoTouch.UIKit;
#endif
using NUnit.Framework;

namespace MonoTouchFixtures.UIKit {
	
	[TestFixture]
	[Preserve (AllMembers = true)]
	public class LayoutConstraintTest {
		
		[Test]
		public void Create ()
		{
			if (!TestRuntime.CheckSystemAndSDKVersion (6,0))
				Assert.Inconclusive ("requires iOS 6");

			using (var view = new UIView ()) {
				NSLayoutConstraint.Create (view, NSLayoutAttribute.Width, NSLayoutRelation.Equal, null, NSLayoutAttribute.NoAttribute, 1, 5).Dispose ();
			}
		}

		[Test]
		public void FromVisualFormat_NullMetrics ()
		{
			if (!TestRuntime.CheckSystemAndSDKVersion (6,0))
				Assert.Inconclusive ("requires iOS 6");

			using (var dict = new NSMutableDictionary ())
			using (var b0 = UIButton.FromType (UIButtonType.InfoDark))
			using (var b1 = UIButton.FromType (UIButtonType.InfoLight)) {
				dict ["button0"] = b0;
				dict ["button1"] = b1;
				var constaints = NSLayoutConstraint.FromVisualFormat ("[button0]-20-[button1]", NSLayoutFormatOptions.AlignAllBaseline, null, dict);
				Assert.That (constaints.Length, Is.EqualTo (2), "constaints");
			}
		}

		[Test]
		public void FromVisualFormat ()
		{
			if (!TestRuntime.CheckSystemAndSDKVersion (6,0))
				Assert.Inconclusive ("requires iOS 6");
			
			using (var metrics = new NSMutableDictionary ())
			using (var dict = new NSMutableDictionary ())
			using (var b0 = UIButton.FromType (UIButtonType.InfoDark))
			using (var b1 = UIButton.FromType (UIButtonType.InfoLight)) {
				dict ["button0"] = b0;
				dict ["button1"] = b1;
				var constaints = NSLayoutConstraint.FromVisualFormat ("[button0]-20-[button1]", NSLayoutFormatOptions.AlignAllBaseline, metrics, dict);
				Assert.NotNull (constaints);
			}
		}
	}
}

#endif // !__WATCHOS__
