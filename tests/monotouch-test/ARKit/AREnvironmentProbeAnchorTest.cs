﻿//
// Unit tests for AREnvironmentProbeAnchor
//
// Authors:
//	Vincent Dondain <vidondai@microsoft.com>
//
// Copyright 2018 Microsoft. All rights reserved.
//

#if __IOS__

using System;
using ARKit;
using Foundation;
using ObjCRuntime;
using NUnit.Framework;

using VectorFloat3 = global::OpenTK.NVector3;
using MatrixFloat4x4 = global::OpenTK.NMatrix4;

namespace MonoTouchFixtures.ARKit {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class AREnvironmentProbeAnchorTest {

		[SetUp]
		public void Setup ()
		{
			TestRuntime.AssertXcodeVersion (10, 0);
			// The API here was introduced to Mac Catalyst later than for the other frameworks, so we have this additional check
			TestRuntime.AssertSystemVersion (PlatformName.MacCatalyst, 14, 0, throwIfOtherPlatform: false);
		}

		[Test]
		public void MarshallingTest ()
		{
			var probeAnchor = new AREnvironmentProbeAnchor (MatrixFloat4x4.Identity, new VectorFloat3 (1, 1, 1));
			Assert.AreEqual (MatrixFloat4x4.Identity, probeAnchor.Transform, "Transform");
			// broken since xcode 12 beta 1 on simulator (only)
			if ((Runtime.Arch == Arch.DEVICE) || !TestRuntime.CheckXcodeVersion (12, 0))
				Assert.AreEqual (new VectorFloat3 (1, 1, 1), probeAnchor.Extent, "Extent");
		}

		[Test]
		public void MarshallingTest2 ()
		{
			var probeAnchorWithName = new AREnvironmentProbeAnchor ("My Anchor", MatrixFloat4x4.Identity, new VectorFloat3 (1, 1, 1));
			Assert.AreEqual (MatrixFloat4x4.Identity, probeAnchorWithName.Transform, "Transform");
			// broken since xcode 12 beta 1 on simulator (only)
			if ((Runtime.Arch == Arch.DEVICE) || !TestRuntime.CheckXcodeVersion (12, 0))
				Assert.AreEqual (new VectorFloat3 (1, 1, 1), probeAnchorWithName.Extent, "Extent");
		}
	}
}

#endif