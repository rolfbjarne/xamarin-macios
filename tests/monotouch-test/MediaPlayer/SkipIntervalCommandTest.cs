//
// Unit tests for MPSkipIntervalCommand
//
// Authors:
//	Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2013 Xamarin Inc. All rights reserved.
//

#if !__WATCHOS__

using System;
#if XAMCORE_2_0
using Foundation;
using MediaPlayer;
#if !MONOMAC
using UIKit;
#endif
#else
using MonoTouch.Foundation;
using MonoTouch.MediaPlayer;
#if !MONOMAC
using MonoTouch.UIKit;
#endif
#endif
using NUnit.Framework;

namespace MonoTouchFixtures.MediaPlayer {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class SkipIntervalCommandTest {

		static bool manualBindingDone;
		[Test]
		public void ManualBinding ()
		{
			if (manualBindingDone)
				Assert.Ignore ("This test can only be executed once, it modifies global state.");
			manualBindingDone = true;

#if !MONOMAC
			if (!UIDevice.CurrentDevice.CheckSystemVersion (7, 1))
				Assert.Inconclusive ("Requires 7.1+");
#endif

			MPSkipIntervalCommand skip = MPRemoteCommandCenter.Shared.SkipBackwardCommand;

			Assert.Null (skip.PreferredIntervals, "PreferredIntervals");
			double[] intervals = new [] { 1.0d, 3.14d };
			skip.PreferredIntervals = intervals;

			Assert.That (skip.PreferredIntervals, Is.EqualTo (intervals), "identical");
		}
	}
}

#endif // !__WATCHOS__
