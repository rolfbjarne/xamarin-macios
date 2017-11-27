﻿// Copyright 2017 Microsoft Inc. All rights reserved.

#if !__WATCHOS__ && !MONOMAC

using System;

#if XAMCORE_2_0
using Metal;
using MetalPerformanceShaders;
using UIKit;
#else
using MonoTouch.Metal;
using MonoTouch.MetalPerformanceShaders;
using MonoTouch.UIKit;
#endif

using NUnit.Framework;

namespace MonoTouchFixtures.MetalPerformanceShaders
{

	[TestFixture]
	public class MPSImageHistogramTest
	{

		[Test]
		public void Constructors ()
		{
			TestRuntime.AssertDevice ();
			TestRuntime.AssertXcodeVersion (7, 0);

			MPSImageHistogramInfo info = new MPSImageHistogramInfo ();
			info.NumberOfHistogramEntries = 256;
			using (var obj = new MPSImageHistogram (MTLDevice.SystemDefault, ref info)) {
				var rv = obj.HistogramInfo;
				Asserts.AreEqual (info, rv, "HistogramForAlpha");

				Assert.IsTrue (obj.ZeroHistogram, "ZeroHistogram");
				if (TestRuntime.CheckXcodeVersion (8, 0)) {
					// HistogramSizeForSourceFormat was introduced in iOS 9, but no matter which MTLPixelFormat value I pass in,
					// the native histogramSizeForSourceFormat: function rudely aborts the entire process with an abrupt:
					// > /BuildRoot/Library/Caches/com.apple.xbs/Sources/MetalImage/MetalImage-39.3/MetalImage/Filters/MIHistogram.mm:103: failed assertion `[MPSImageHistogram histogramSizeForSourceFormat:] unsupported texture format: 114'
					// I made sure the MTLPixelFormat values I tested with were also added in iOS 9, so that's not the problem.
					// Conclusion: just avoid executing HistogramSizeForSourceFormat on anything below iOS 10.rm 
					Assert.AreEqual (3072, obj.HistogramSizeForSourceFormat (MTLPixelFormat.RGBA16Sint), "HistogramSizeForSourceFormat");
				}
				var crs = obj.ClipRectSource;
				Assert.AreEqual (0, crs.Origin.X, "ClipRectSource.Origin.X");
				Assert.AreEqual (0, crs.Origin.Y, "ClipRectSource.Origin.Y");
				Assert.AreEqual (0, crs.Origin.Z, "ClipRectSource.Origin.Z");
				Assert.AreEqual (-1, crs.Size.Depth, "ClipRectSource.Size.Depth");
				Assert.AreEqual (-1, crs.Size.Height, "ClipRectSource.Size.Height");
				Assert.AreEqual (-1, crs.Size.Width, "ClipRectSource.Size.Width");
			}
		}
	}
}

#endif // !__WATCHOS__
