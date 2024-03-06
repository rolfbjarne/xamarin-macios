//
// Unit tests for UrlConnection
//
// Authors:
//	Sebastien Pouliot <sebastien@xamarin.com>
//
// Copyright 2013 Xamarin Inc. All rights reserved.
//

#if !__WATCHOS__

using System;
using System.Threading;

using Foundation;
#if MONOMAC
using AppKit;
#else
using UIKit;
#endif
using ObjCRuntime;
using NUnit.Framework;
using MonoTests.System.Net.Http;

#nullable enable

namespace MonoTouchFixtures.Foundation {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class UrlConnectionTest {

		class MyDelegate : NSUrlConnectionDelegate {

		}

		[Test]
		public void StartCancel ()
		{
			using (var url = new NSUrl (NetworkResources.MicrosoftUrl))
			using (var r = new NSUrlRequest (url))
			using (var d = new MyDelegate ())
			using (var c = new NSUrlConnection (r, d)) {
				c.Start ();
				c.Cancel ();
			}
		}

		[Test]
		public void SendSynchronousRequest ()
		{
			Exception? ex = null;
			var thread = new Thread ((v) => {
				try {
					using var url = new NSUrl (NetworkResources.MicrosoftUrl);
					using var request = new NSUrlRequest (url);
					using var data = NSUrlConnection.SendSynchronousRequest (request, out var response, out var error);
					TestRuntime.IgnoreInCIIfBadNetwork (error);
					Assert.IsNull (error, $"Error: {error?.Description}");
					Assert.IsNotNull (data, "Data");
					Assert.IsNotNull (response, "Response");
					response?.Dispose ();
					error?.Dispose ();
				} catch (Exception e) {
					ex = e;
				}
			});
			thread.Start ();
			var timedOut = !thread.Join (TimeSpan.FromSeconds (15));
			if (timedOut) {
				TestRuntime.IgnoreInCI ("Timed out");
				Assert.IsFalse (timedOut, "Timed out");
			}
			TestRuntime.IgnoreInCIIfBadNetwork (ex);
			TestRuntime.AssertNoNonNUnitException (ex, "Exception");
		}
	}
}

#endif // !__WATCHOS__
