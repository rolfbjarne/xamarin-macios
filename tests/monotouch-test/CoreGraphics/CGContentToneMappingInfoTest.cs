// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using Foundation;
using CoreGraphics;
using NUnit.Framework;
using ObjCRuntime;

namespace MonoTouchFixtures.CoreGraphics {
	[TestFixture]
	[Preserve (AllMembers = true)]
	public class CGContentToneMappingInfoTest {
		[Test]
		public void DefaultValuesTest ()
		{
			var t = new CGContentToneMappingInfo ();
			Assert.AreEqual (default(CGComponent), t.DeepestImageComponent, "DeepestImageComponent");
			Assert.AreEqual (default(CGColorModel), t.ContentColorModels, "ContentColorModels");
			Assert.IsFalse (t.HasWideGamut, "HasWideGamut");
			Assert.IsFalse (t.HasTransparency, "HasTransparency");
			Assert.AreEqual (0f, t.LargestContentHeadroom, "LargestContentHeadroom");
			Assert.AreEqual (0f, t.ToneMappingStrength, "ToneMappingStrength");
		}

		[Test]
		public void PropertySetGetTest ()
		{
			var t = new CGContentToneMappingInfo ();
			// Example property sets, adjust as needed for actual struct
			t.DeepestImageComponent = (CGComponent)2;
			t.ContentColorModels = (CGColorModel)3;
			t.HasWideGamut = true;
			t.HasTransparency = true;
			t.LargestContentHeadroom = 1.25f;
			t.ToneMappingStrength = 0.75f;

			Assert.AreEqual ((CGComponent)2, t.DeepestImageComponent, "DeepestImageComponent");
			Assert.AreEqual ((CGColorModel)3, t.ContentColorModels, "ContentColorModels");
			Assert.IsTrue (t.HasWideGamut, "HasWideGamut");
			Assert.IsTrue (t.HasTransparency, "HasTransparency");
			Assert.AreEqual (1.25f, t.LargestContentHeadroom, "LargestContentHeadroom");
			Assert.AreEqual (0.75f, t.ToneMappingStrength, "ToneMappingStrength");
		}

		[Test]
		public void HasWideGamutFalseTest ()
		{
			var t = new CGContentToneMappingInfo ();
			t.HasWideGamut = false;
			Assert.IsFalse (t.HasWideGamut, "HasWideGamut");
		}

		[Test]
		public void HasTransparencyFalseTest ()
		{
			var t = new CGContentToneMappingInfo ();
			t.HasTransparency = false;
			Assert.IsFalse (t.HasTransparency, "HasTransparency");
		}
	}
}
