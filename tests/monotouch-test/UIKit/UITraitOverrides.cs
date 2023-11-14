//
// Unit tests for UITraitOverrides
//
// Authors:
//	Rolf Bjarne Kvinge  <rolf@xamarin.com>
//
// Copyright 2023 Microsoft Corp. All rights reserved.
//

#if !__WATCHOS__ && !__MACOS__

using System;
using System.IO;
using System.Reflection;
using System.Threading;

using Foundation;
using UIKit;
using ObjCRuntime;

using NUnit.Framework;

using Xamarin.Utils;

namespace MonoTouchFixtures.UIKit {
	[TestFixture]
	[Preserve (AllMembers = true)]
	public class UITraitOverridesTest {
		[Test]
		public void Test ()
		{
			TestRuntime.AssertXcodeVersion (15, 0);

			var vc = new UIViewController ();
			vc.View!.AddSubview (new UILabel () {
				BackgroundColor = UIColor.SystemBackground,
				TextAlignment = UITextAlignment.Center,
			});

			UIUserInterfaceSizeClass? horizontal = null;
			UIUserInterfaceSizeClass? vertical = null;
			var msgPrefix = "?";
			var callbackCounter = 0;
			Exception? ex = null;

			vc.RegisterForTraitChanges (new [] {
					new Class (typeof (UITraitVerticalSizeClass)),
					new Class (typeof (UITraitHorizontalSizeClass)),
					}, (env, coll) => {
						try {
							Assert.AreEqual (horizontal is not null, vc.TraitOverrides.ContainsTrait<UITraitHorizontalSizeClass> (), $"{msgPrefix} Horizontal A");
							Assert.AreEqual (horizontal is not null, vc.TraitOverrides.ContainsTrait (typeof (UITraitHorizontalSizeClass)), $"{msgPrefix} Horizontal B");
							Assert.AreEqual (horizontal is not null, vc.TraitOverrides.ContainsTrait (new Class (typeof (UITraitHorizontalSizeClass))), $"{msgPrefix} Horizontal C");
							Assert.AreEqual (vertical is not null, vc.TraitOverrides.ContainsTrait<UITraitVerticalSizeClass> (), $"{msgPrefix} Vertical A");
							Assert.AreEqual (vertical is not null, vc.TraitOverrides.ContainsTrait (typeof (UITraitVerticalSizeClass)), $"{msgPrefix} Vertical B");
							Assert.AreEqual (vertical is not null, vc.TraitOverrides.ContainsTrait (new Class (typeof (UITraitVerticalSizeClass))), $"{msgPrefix} Vertical C");
							if (horizontal is not null) {
								Assert.AreEqual (horizontal.Value, vc.TraitOverrides.HorizontalSizeClass, $"{msgPrefix} Horizontal Value");
							}
							if (vertical is not null) {
								Assert.AreEqual (vertical.Value, vc.TraitOverrides.VerticalSizeClass, $"{msgPrefix} Vertical Value");
							}
							callbackCounter++;
						} catch (Exception e) {
							ex = e;
						}
					});

			horizontal = UIUserInterfaceSizeClass.Regular;
			vc.TraitOverrides.HorizontalSizeClass = horizontal.Value;
			Assert.AreEqual (1, callbackCounter, "CallbackCounter 1");
			Assert.IsNull (ex, "Exception 1");

			horizontal = UIUserInterfaceSizeClass.Compact;
			vc.TraitOverrides.HorizontalSizeClass = horizontal.Value;
			Assert.AreEqual (2, callbackCounter, "CallbackCounter 2");
			Assert.IsNull (ex, "Exception 2");

			vertical = UIUserInterfaceSizeClass.Compact;
			vc.TraitOverrides.VerticalSizeClass = vertical.Value;
			Assert.AreEqual (3, callbackCounter, "CallbackCounter 3");
			Assert.IsNull (ex, "Exception 3");

			vertical = UIUserInterfaceSizeClass.Regular;
			vc.TraitOverrides.VerticalSizeClass = vertical.Value;
			Assert.AreEqual (4, callbackCounter, "CallbackCounter 4");
			Assert.IsNull (ex, "Exception 4");

			vertical = null;
			vc.TraitOverrides.RemoveTrait (typeof (UITraitVerticalSizeClass));
			Assert.AreEqual (4, callbackCounter, "CallbackCounter 5");
			Assert.IsNull (ex, "Exception 5");

			horizontal = null;
			vc.TraitOverrides.RemoveTrait<UITraitHorizontalSizeClass> ();
			Assert.AreEqual (4, callbackCounter, "CallbackCounter 6");
			Assert.IsNull (ex, "Exception 6");

			horizontal = UIUserInterfaceSizeClass.Regular;
			vc.TraitOverrides.HorizontalSizeClass = horizontal.Value;
			Assert.AreEqual (5, callbackCounter, "CallbackCounter 7");
			Assert.IsNull (ex, "Exception 7");

			horizontal = null;
			vc.TraitOverrides.RemoveTrait (new Class (typeof (UITraitHorizontalSizeClass)));
			Assert.AreEqual (5, callbackCounter, "CallbackCounter 8");
			Assert.IsNull (ex, "Exception 8");
		}
	}
}

#endif // !__WATCHOS__ && !__MACOS__
