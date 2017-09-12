﻿//
// Unit tests for GKAgent3D
//
// Authors:
//	Rolf Bjarne Kvinge <rolf@xamarin.com>
//	
//
// Copyright 2017 Microsoft Inc. All rights reserved.
//

#if !__WATCHOS__

using System;
using OpenTK;

#if XAMCORE_2_0
using Foundation;
using GameplayKit;
#else
using MonoTouch.Foundation;
using MonoTouch.GameplayKit;
#endif

using MatrixFloat2x2 = global::OpenTK.NMatrix2;
using MatrixFloat3x3 = global::OpenTK.NMatrix3;
using MatrixFloat4x4 = global::OpenTK.NMatrix4;
using VectorFloat3 = global::OpenTK.NVector3;

using Bindings.Test;
using NUnit.Framework;

namespace MonoTouchFixtures.GamePlayKit
{
	[TestFixture]
	[Preserve (AllMembers = true)]
	public class GKAgent3DTest
	{
		[Test]
		public void RotationTest ()
		{
			using (var obj = new GKAgent3D ()) {
				var initial = new Matrix3 (0, 0, 1,
										   0, 1, 0,
										   1, 0, 0);
				Asserts.AreEqual (initial, obj.Rotation, "Rotation");
				Asserts.AreEqual ((MatrixFloat3x3) initial, obj.Rotation3x3, "Rotation3x3");

				var mat = new Matrix3 (1, 2, 3,
									   4, 5, 6,
									   7, 8, 9);
				var mat3x3 = (MatrixFloat3x3) mat;

				obj.Rotation = mat;
				Asserts.AreEqual (mat, obj.Rotation, "Rotation after setter");
				var transposed3x3 = MatrixFloat3x3.Transpose ((MatrixFloat3x3) mat);
				Asserts.AreEqual (transposed3x3, obj.Rotation3x3, "Rotation3x3 after setter");
				Asserts.AreEqual (transposed3x3, CFunctions.GetMatrixFloat3x3 (obj, "rotation"), "Rotation3x3 after setter native");

				obj.Rotation3x3 = mat3x3;
				Asserts.AreEqual (mat3x3, obj.Rotation3x3, "Rotation3x3 after setter 3x3");
				Asserts.AreEqual (mat3x3, CFunctions.GetMatrixFloat3x3 (obj, "rotation"), "Rotation3x3 after setter native 3x3");
			}
		}
	}
}

#endif // __WATCHOS__
