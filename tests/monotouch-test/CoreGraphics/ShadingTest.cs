//
// Unit tests for CGPath
//
// Authors:
//	Sebastien Pouliot <sebastien@xamarin.com>
//
// Copyright 2013-2014 Xamarin Inc. All rights reserved.
//

using System;
using System.Runtime.InteropServices;
using Foundation;
using CoreGraphics;
using ObjCRuntime;
using NUnit.Framework;

namespace MonoTouchFixtures.CoreGraphics {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class CGShadingTest {

#if HAS_UIKIT
		[Test]
		public void CreateAxialWithContentHeadroom ()
		{
			TestRuntime.AssertXcodeVersion (26, 0);

			var domain = new nfloat [] { 0f, 1f };
			var range = new nfloat [] { 0f, 1f, 0f, 1f };
			var size = new CGSize (128, 128);

			using var renderer = new UIGraphicsImageRenderer (size);
			using var img = renderer.CreateImage ((context) =>
			{
				var start = new CGPoint (0, 0);
				var end = new CGPoint (size.Height, size.Width);
				using var hdrCapableColorspace = CGColorSpace.CreateWithName (CGColorSpaceNames.ExtendedRange);
				// using var shadingFunction = new CGFunction (domain, range, Shading);
				using (var shading = CGShading.CreateAxial (0.5f, hdrCapableColorspace, start, end, null, true, false)) {
					context.DrawShading (shading);
				}
			});

			File.WriteAllBytes ("/tmp/axial.png", img.AsPNG ().ToArray ());
			Assert.Fail ("Inspect the image!");
		}

		[Test]
		public void CreateRadialWithContentHeadroom ()
		{
			TestRuntime.AssertXcodeVersion (26, 0);

			var domain = new nfloat [] { 0f, 1f };
			var range = new nfloat [] { 0f, 1f, 0f, 1f };
			var size = new CGSize (128, 128);

			using var renderer = new UIGraphicsImageRenderer (size);
			using var img = renderer.CreateImage ((context) =>
			{
				var start = new CGPoint (0, 0);
				var startRadius = 16.0f;
				var end = new CGPoint (size.Height, size.Width);
				var endRadius = 32.0f;
				using var hdrCapableColorspace = CGColorSpace.CreateWithName (CGColorSpaceNames.ExtendedRange);
				// using var shadingFunction = new CGFunction (domain, range, Shading);
				using (var shading = CGShading.CreateRadial (0.5f, hdrCapableColorspace, start, startRadius, end, endRadius, null, true, false)) {
					context.DrawShading (shading);
				}
			});

			File.WriteAllBytes ("/tmp/radial.png", img.AsPNG ().ToArray ());
			Assert.Fail ("Inspect the image!");
		}
#endif
	}
}
