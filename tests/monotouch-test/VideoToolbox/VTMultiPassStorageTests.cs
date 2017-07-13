﻿//
// Unit tests for VTMultiPassStorage
//
// Authors:
//	Alex Soto <alex.soto@xamarin.com>
//	
//
// Copyright 2015 Xamarin Inc. All rights reserved.
//

#if !__WATCHOS__

using System;

#if XAMCORE_2_0
using Foundation;
using VideoToolbox;
using CoreMedia;
using AVFoundation;
using CoreFoundation;
#else
using MonoTouch.Foundation;
using MonoTouch.VideoToolbox;
using MonoTouch.UIKit;
using MonoTouch.CoreMedia;
using MonoTouch.AVFoundation;
using MonoTouch.CoreFoundation;
#endif
using NUnit.Framework;

namespace MonoTouchFixtures.VideoToolbox {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class VTMultiPassStorageTests
	{
		[Test]
		public void MultiPassStorageCreateTest ()
		{
			if (!TestRuntime.CheckSystemAndSDKVersion (8, 0))
				Assert.Ignore ("Ignoring VideoToolbox tests: Requires iOS8+");

			using (var storage = VTMultiPassStorage.Create ()){
				Assert.IsNotNull (storage, "Storage should not be null");
			}
		}

		[Test]
		public void MultiPassStorageCloseTest ()
		{
			if (!TestRuntime.CheckSystemAndSDKVersion (8, 0))
				Assert.Ignore ("Ignoring VideoToolbox tests: Requires iOS8+");

			using (var storage = VTMultiPassStorage.Create ()){
				var result = storage.Close ();
				Assert.IsTrue (result == VTStatus.Ok, "VTMultiPassStorage Close");
			}
		}
	}
}

#endif // !__WATCHOS__
