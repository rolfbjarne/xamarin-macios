﻿//
// Unit tests for VTCompressionSession
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
	public class VTCompressionSessionTests
	{
		[Test]
		public void CompressionSessionCreateTest ()
		{
			if (!TestRuntime.CheckSystemAndSDKVersion (8, 0))
				Assert.Ignore ("Ignoring VideoToolbox tests: Requires iOS8+");

			using (var session = CreateSession ()){
				Assert.IsNotNull (session, "Session should not be null");
			}
		}

		[Test]
		public void CompressionSessionSetCompressionPropertiesTest ()
		{
			if (!TestRuntime.CheckSystemAndSDKVersion (8, 0))
				Assert.Ignore ("Ignoring VideoToolbox tests: Requires iOS8+");

			using (var session = CreateSession ()){

				var result = session.SetCompressionProperties (new VTCompressionProperties {
					RealTime = true,
					AllowFrameReordering = false
				});

				Assert.That (result == VTStatus.Ok, "SetCompressionProperties");
			}
		}

		[Test]
		public void CompressionSessionSetPropertiesTest ()
		{
			if (!TestRuntime.CheckSystemAndSDKVersion (8, 0))
				Assert.Ignore ("Ignoring VideoToolbox tests: Requires iOS8+");

			using (var session = CreateSession ()){

				var result = session.SetProperties (new VTPropertyOptions {
					ReadWriteStatus = VTReadWriteStatus.ReadWrite,
					ShouldBeSerialized = true
				});

				Assert.That (result == VTStatus.Ok, "SetProperties");
			}
		}

		[Test]
		public void CompressionSessionSetCompressionPropertiesMultiPassStorageTest ()
		{
			if (!TestRuntime.CheckSystemAndSDKVersion (8, 0))
				Assert.Ignore ("Ignoring VideoToolbox tests: Requires iOS8+");

			using (var session = CreateSession ())
			using (var storage = VTMultiPassStorage.Create ()){
				var result = session.SetCompressionProperties (new VTCompressionProperties {
					RealTime = false,
					AllowFrameReordering = true,
					MultiPassStorage = storage
				});

				Assert.That (result == VTStatus.Ok, "SetCompressionPropertiesMultiPassStorage");
			}
		}

		// On iOS 8 all properties in GetSupportedProperties for Compression session return false on ShouldBeSerialized
		// with this test we will be able to catch if apple changes its mind about this in the future.
		[Test]
		public void CompressionSessionGetSupportedPropertiesTest ()
		{
			if (!TestRuntime.CheckSystemAndSDKVersion (8, 0))
				Assert.Ignore ("Ignoring VideoToolbox tests: Requires iOS8+");

			using (var session = CreateSession ()) {
				var supportedProps = session.GetSupportedProperties ();
				Assert.NotNull (supportedProps, "GetSupportedProperties IsNull");

				var key = new NSString ("ShouldBeSerialized");
				foreach (var item in supportedProps) {
					var dict = (NSDictionary)item.Value;
					if (dict == null) continue;

					NSObject value;
					if (dict.TryGetValue (key, out value) && value != null ) {
						var number = (NSNumber) value;
						Assert.IsFalse (number.BoolValue, "CompressionSession GetSupportedPropertiesTest ShouldBeSerialized is True");
					}
				}
			}
		}

		// This test is (kind of) expected to be null due to as of iOS 8 all supported properties are not meant to be serialized
		// see CompressionSessionGetSupportedPropertiesTest.
		[Test]
#if MONOMAC // https://bugzilla.xamarin.com/show_bug.cgi?id=51258
		[Ignore ("Crashes with SIGSEGV when trying to dispose session after calling session.GetSerializableProperties ()")]
#endif
		public void CompressionSessionGetSerializablePropertiesTest ()
		{
			if (!TestRuntime.CheckSystemAndSDKVersion (8, 0))
				Assert.Ignore ("Ignoring VideoToolbox tests: Requires iOS8+");
			
			using (var session = CreateSession ()) {
				var supportedProps = session.GetSerializableProperties ();
				Assert.IsNull (supportedProps, "CompressionSession GetSerializableProperties is not null");
			}
		}

		VTCompressionSession CreateSession ()
		{
			var session = VTCompressionSession.Create (1024, 768, CMVideoCodecType.H264,
				(sourceFrame, status, flags, buffer) => { });
			return session;
		}
	}
}

#endif // !__WATCHOS__

