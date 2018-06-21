﻿//
// Unit tests for MPMoviePlayerController
//
// Authors:
//	Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2014 Xamarin Inc. All rights reserved.
//

#if !__TVOS__ && !__WATCHOS__ && !MONOMAC

using System;
#if XAMCORE_2_0
using Foundation;
using MediaPlayer;
using UIKit;
using iAd;
#else
using MonoTouch.Foundation;
using MonoTouch.MediaPlayer;
using MonoTouch.UIKit;
using MonoTouch.iAd;
#endif
using NUnit.Framework;

namespace MonoTouchFixtures.MediaPlayer {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class MoviePlayerControllerTest {
		
		[Test]
		public void PreparePrerollAds_New ()
		{
			TestRuntime.AssertiOSSystemVersion (7, 0);

			MPMoviePlayerController.PrepareForPrerollAds ();
		}
	}
}

#endif // !__TVOS__ && !__WATCHOS__
