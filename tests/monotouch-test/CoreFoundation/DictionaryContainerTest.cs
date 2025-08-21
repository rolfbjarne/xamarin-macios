// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;

using Foundation;
using CoreGraphics;
using ObjCRuntime;

using NUnit.Framework;

namespace MonoTouchFixtures.CoreFoundation;

[TestFixture]
[Preserve (AllMembers = true)]
public class DictionaryContainerTest {

	[Test]
	public void Matrix ()
	{
		Assert.Multiple (() => {
			var dict = new VTCompressionPropertyCameraCalibration ();

			Assert.IsNull (dict.IntrinsicMatrix, "IntrinsicMatrix");

			var matrix = new NMatrix3 (1, 2, 3, 4, 5, 6, 7, 8, 9);
			dict.IntrinsicMatrix = matrix;
			Assert.AreEqual (matrix, dict.IntrinsicMatrix, "IntrinsicMatrix 2");

			dict.IntrinsicMatrix = null;
			Assert.IsNull (dict.IntrinsicMatrix, "IntrinsicMatrix 3");
		});
	}

	[Test]
	public void FloatArray ()
	{
		Assert.Multiple (() => {
			var dict = new VTCompressionPropertyCameraCalibration ();

			Assert.IsNull (dict.LensDistortions, "LensDistortions");

			var array = new float [ 1, 2, 3, 4, 5, 6, 7, 8, 9 ];
			dict.LensDistortions = array;
			Assert.AreEqual (array, dict.LensDistortions, "LensDistortions 2");

			dict.LensDistortions = null;
			Assert.IsNull (dict.LensDistortions, "LensDistortions 3");
		});
	}
}
