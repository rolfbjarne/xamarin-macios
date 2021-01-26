#if __IOS__

using System;
using System.Reflection;
using ARKit;
using Foundation;
using ObjCRuntime;
using NUnit.Framework;

namespace MonoTouchFixtures.ARKit {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class ARCondigurationTest {

		[SetUp]
		public void Setup ()
		{
			TestRuntime.AssertXcodeVersion (9, 3);
			// The API here was introduced to Mac Catalyst later than for the other frameworks, so we have this additional check
			TestRuntime.AssertSystemVersion (PlatformName.MacCatalyst, 14, 0, throwIfOtherPlatform: false);
		}

		[Test]
		public void SupportedVideoFormats ()
		{
			var svf = ARConfiguration.SupportedVideoFormats;
			Assert.That (svf, Is.Empty, "empty");
		}

		[Test]
		public void GetSupportedVideoFormats_9_3 ()
		{
			Assert.NotNull (ARWorldTrackingConfiguration.GetSupportedVideoFormats (), "ARWorldTrackingConfiguration");
			Assert.NotNull (AROrientationTrackingConfiguration.GetSupportedVideoFormats (), "AROrientationTrackingConfiguration");
			Assert.NotNull (ARFaceTrackingConfiguration.GetSupportedVideoFormats (), "ARFaceTrackingConfiguration");
		}

		[Test]
		public void GetSupportedVideoFormats_10_0 ()
		{
			TestRuntime.AssertXcodeVersion (10, 0);
			Assert.NotNull (ARImageTrackingConfiguration.GetSupportedVideoFormats (), "ARImageTrackingConfiguration");
			Assert.NotNull (ARObjectScanningConfiguration.GetSupportedVideoFormats (), "ARObjectScanningConfiguration");
		}

		[Test]
		public void Subclasses ()
		{
			// note: this can be run on any xcode / OS version since it's reflection only
			// all subclasses of ARConfiguration must (re)export 'GetSupportedVideoFormats'
			var c = typeof (ARConfiguration);
			foreach (var sc in c.Assembly.GetTypes ()) {
				if (!sc.IsSubclassOf (c))
					continue;
				var m = sc.GetMethod ("GetSupportedVideoFormats", BindingFlags.Static | BindingFlags.Public);
				Assert.NotNull (m, sc.FullName);
			}
		}
	}
}

#endif
