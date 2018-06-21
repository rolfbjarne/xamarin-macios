//
// Unit tests for CaptiveNetwork
//
// Authors:
//	Sebastien Pouliot <sebastien@xamarin.com>
//
// Copyright 2012 Xamarin Inc. All rights reserved.
//

#if !__WATCHOS__

using System;
using System.IO;
#if XAMCORE_2_0
using Foundation;
using ObjCRuntime;
using SystemConfiguration;
#if !MONOMAC
using UIKit;
#endif
#else
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.SystemConfiguration;
using MonoTouch.UIKit;
#endif
using NUnit.Framework;

namespace MonoTouchFixtures.SystemConfiguration {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class CaptiveNetworkTest {
		
		static bool RunningOnSnowLeopard {
			get {
				return !File.Exists ("/usr/lib/system/libsystem_kernel.dylib");
			}
		}

#if !MONOMAC // Fields are not on Mac
		[Test]
		public void Fields ()
		{
			if (Runtime.Arch == Arch.SIMULATOR) {
				// Fails (NullReferenceException) on iOS6 simulator
				TestRuntime.AssertiOSSystemVersion (7, 0, throwIfOtherPlatform: false);
			}

			Assert.That (CaptiveNetwork.NetworkInfoKeyBSSID.ToString (), Is.EqualTo ("BSSID"), "kCNNetworkInfoKeyBSSID");
			Assert.That (CaptiveNetwork.NetworkInfoKeySSID.ToString (), Is.EqualTo ("SSID"), "kCNNetworkInfoKeySSID");
			Assert.That (CaptiveNetwork.NetworkInfoKeySSIDData.ToString (), Is.EqualTo ("SSIDDATA"), "kCNNetworkInfoKeySSIDData");
		}
#endif

#if !MONOMAC // TryCopyCurrentNetworkInfo and fields checked are not on Mac
		[Test]
		[ExpectedException (typeof (ArgumentNullException))]
		public void TryCopyCurrentNetworkInfo_Null ()
		{
			NSDictionary dict;
			CaptiveNetwork.TryCopyCurrentNetworkInfo (null, out dict);
		}
		
		[Test]
		public void TryCopyCurrentNetworkInfo ()
		{
			NSDictionary dict;
			var status = CaptiveNetwork.TryCopyCurrentNetworkInfo ("en0", out dict);

			// No network, ignore test
			if (status == StatusCode.NoKey)
				return;

			Assert.AreEqual (StatusCode.OK, status, "Status");

			if ((dict == null) && (Runtime.Arch == Arch.DEVICE) && TestRuntime.CheckiOSSystemVersion (9, 0))
				Assert.Ignore ("null on iOS9 devices - CaptiveNetwork is being deprecated ?!?");

			if (dict.Count == 3) {
				Assert.NotNull (dict [CaptiveNetwork.NetworkInfoKeyBSSID], "NetworkInfoKeyBSSID");
				Assert.NotNull (dict [CaptiveNetwork.NetworkInfoKeySSID], "NetworkInfoKeySSID");
				Assert.NotNull (dict [CaptiveNetwork.NetworkInfoKeySSIDData], "NetworkInfoKeySSIDData");
			} else {
				Assert.Fail ("Unexpected dictionary result with {0} items", dict.Count);
			}
		}
#endif

		[Test]
		[ExpectedException (typeof (ArgumentNullException))]
		public void MarkPortalOnline_Null ()
		{
			CaptiveNetwork.MarkPortalOnline (null);
		}

		[Test]
		public void MarkPortalOnline ()
		{
			TestRuntime.AssertMacSystemVersion (10, 8, throwIfOtherPlatform: false);

			Assert.False (CaptiveNetwork.MarkPortalOnline ("xamxam"));
		}
		
		[Test]
		[ExpectedException (typeof (ArgumentNullException))]
		public void MarkPortalOffline_Null ()
		{
			CaptiveNetwork.MarkPortalOffline (null);
		}

		[Test]
		public void MarkPortalOffline ()
		{
			TestRuntime.AssertMacSystemVersion (10, 8, throwIfOtherPlatform: false);

			Assert.False (CaptiveNetwork.MarkPortalOffline ("xamxam"));
		}
		
		[Test]
		[ExpectedException (typeof (ArgumentNullException))]
		public void SetSupportedSSIDs_Null ()
		{
			CaptiveNetwork.SetSupportedSSIDs (null);
		}

		[Test]
		public void SetSupportedSSIDs ()
		{
			TestRuntime.AssertMacSystemVersion (10, 8, throwIfOtherPlatform: false);

#if MONOMAC
			bool supported = true;
#else
			if (Runtime.Arch == Arch.SIMULATOR) {
				if (RunningOnSnowLeopard)
					Assert.Inconclusive ("This test crash on the simulator with Snow Leopard");
			}

			// that API is deprecated in iOS9 - and it might be why it returns false (or not)
			bool supported = !TestRuntime.CheckiOSSystemVersion (9, 0);
#endif
			Assert.That (CaptiveNetwork.SetSupportedSSIDs (new string [2] { "one", "two" } ), Is.EqualTo (supported), "set");
		}
	}
}

#endif // !__WATCHOS__
