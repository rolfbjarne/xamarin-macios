//
// Unit tests for SCNMatrix4
//
// Authors:
//	Sebastien Pouliot <sebastien@xamarin.com>
//
// Copyright 2014 Xamarin Inc. All rights reserved.
//

#nullable enable

using System;
using CoreAnimation;
using Foundation;
using SceneKit;
#if !NET
using OpenTK;
#endif

using NUnit.Framework;

#if __MACOS__
#if NET
using pfloat = ObjCRuntime.nfloat;
#else
using pfloat = System.nfloat;
#endif
#else
using pfloat = System.Single;
#endif

namespace MonoTouchFixtures.SceneKit {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class SCNMatrix4Test {
		public SCNMatrix4Test ()
		{
		}

		void AssertEqual (SCNMatrix4 matrix, string message,
			pfloat m11, pfloat m12, pfloat m13, pfloat m14,
			pfloat m21, pfloat m22, pfloat m23, pfloat m24,
			pfloat m31, pfloat m32, pfloat m33, pfloat m34,
			pfloat m41, pfloat m42, pfloat m43, pfloat m44
		)
		{
			if (m11 == matrix.M11 && m12 == matrix.M12 && m13 == matrix.M13 && m14 == matrix.M14 &&
				m21 == matrix.M21 && m22 == matrix.M22 && m23 == matrix.M23 && m24 == matrix.M24 &&
				m31 == matrix.M31 && m32 == matrix.M32 && m33 == matrix.M33 && m34 == matrix.M34 &&
				m41 == matrix.M41 && m42 == matrix.M42 && m43 == matrix.M43 && m44 == matrix.M44)
				return;

			var expectedString = matrix.ToString ();

			var row1 = $"({m11}, {m12}, {m13}, {m14})";
			var row2 = $"({m21}, {m22}, {m23}, {m24})";
			var row3 = $"({m31}, {m32}, {m33}, {m34})";
			var row4 = $"({m41}, {m42}, {m43}, {m44})";
			var actualString = $"{row1}\n{row2}\n{row3}\n{row4}";

			Assert.Fail ($"Expected matrix:\n{expectedString}\nActual matrix:\n{actualString}\n{message}");
		}

		void AssertEqual (SCNVector4 vector, string message, pfloat m1, pfloat m2, pfloat m3, pfloat m4)
		{
			if (m1 == vector.X && m2 == vector.Y && m3 == vector.Z && m4 == vector.W)
				return;

			var expectedString = vector.ToString ();
			var actualString = $"({m1}, {m2}, {m3}, {m4})";

			Assert.Fail ($"Expected vector:\n{expectedString}\nActual vector:\n{actualString}\n{message}");
		}

		[Test]
		public void Identity ()
		{
			var matrix = SCNMatrix4.Identity;
			AssertEqual (matrix, "Identity",
				1, 0, 0, 0,
				0, 1, 0, 0,
				0, 0, 1, 0,
				0, 0, 0, 1);
		}

		[Test]
		public void Constructor_RowVectors ()
		{
			var matrix = new SCNMatrix4 (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44));
			AssertEqual (matrix, "Constructor",
				11, 12, 13, 14,
				21, 22, 23, 24,
				31, 32, 33, 34,
				41, 42, 43, 44);
		}

		[Test]
		public void Constructor_Elements ()
		{
			var matrix = new SCNMatrix4 (
				11, 12, 13, 14,
				21, 22, 23, 24,
				31, 32, 33, 34,
				41, 42, 43, 44);
			AssertEqual (matrix, "Constructor",
				11, 12, 13, 14,
				21, 22, 23, 24,
				31, 32, 33, 34,
				41, 42, 43, 44);
		}

#if !WATCH
		[Test]
		public void Constructor_CATransform3d ()
		{
			var transform = new CATransform3D () {
				m11 = 11,
				m12 = 12,
				m13 = 13,
				m14 = 14,
				m21 = 21,
				m22 = 22,
				m23 = 23,
				m24 = 24,
				m31 = 31,
				m32 = 32,
				m33 = 33,
				m34 = 34,
				m41 = 41,
				m42 = 42,
				m43 = 43,
				m44 = 44,
			};
			var matrix = new SCNMatrix4 (transform);
			AssertEqual (matrix, "Constructor",
				11, 12, 13, 14,
				21, 22, 23, 24,
				31, 32, 33, 34,
				41, 42, 43, 44);
		}
#endif

		[Test]
		public void Determinant ()
		{
			var matrix = new SCNMatrix4 (
				3, 5, 8, 9,
				5, 3, 5, 8,
				9, 6, 4, 2,
				4, 6, 9, 8);
			Assert.AreEqual ((pfloat) (-165), matrix.Determinant, "Determinant");
		}


		[Test]
		public void Rows ()
		{
			var matrix = new SCNMatrix4 (
				11, 12, 13, 14,
				21, 22, 23, 24,
				31, 32, 33, 34,
				41, 42, 43, 44);
			AssertEqual (matrix.Row0, "Row0", 11, 12, 13, 14);
			AssertEqual (matrix.Row1, "Row1", 21, 22, 23, 24);
			AssertEqual (matrix.Row2, "Row2", 31, 32, 33, 34);
			AssertEqual (matrix.Row3, "Row3", 41, 42, 43, 44);
		}

		[Test]
		public void Elements ()
		{
			var matrix = new SCNMatrix4 (
				11, 12, 13, 14,
				21, 22, 23, 24,
				31, 32, 33, 34,
				41, 42, 43, 44);
			Assert.AreEqual (11, matrix.M11, "M11");
			Assert.AreEqual (12, matrix.M12, "M12");
			Assert.AreEqual (13, matrix.M13, "M13");
			Assert.AreEqual (14, matrix.M14, "M14");
			Assert.AreEqual (21, matrix.M21, "M21");
			Assert.AreEqual (22, matrix.M22, "M22");
			Assert.AreEqual (23, matrix.M23, "M23");
			Assert.AreEqual (24, matrix.M24, "M24");
			Assert.AreEqual (31, matrix.M31, "M31");
			Assert.AreEqual (32, matrix.M32, "M32");
			Assert.AreEqual (33, matrix.M33, "M33");
			Assert.AreEqual (34, matrix.M34, "M34");
			Assert.AreEqual (41, matrix.M41, "M41");
			Assert.AreEqual (42, matrix.M42, "M42");
			Assert.AreEqual (43, matrix.M43, "M43");
			Assert.AreEqual (44, matrix.M44, "M44");
		}

		[Test]
		public void Invert ()
		{
			var matrix = new SCNMatrix4 (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44));
			matrix.Invert ();
			AssertEqual (matrix, "Invert",
				11, 12, 13, 14,
				21, 22, 23, 24,
				31, 32, 33, 34,
				41, 42, 43, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void Transpose ()
		{
			var matrix = new SCNMatrix4 (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44));
			matrix.Transpose ();
			AssertEqual (matrix, "Transpose",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
		}

		[Test]
		public void CreateFromColumns ()
		{
			var matrix = SCNMatrix4.CreateFromColumns (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44));
			AssertEqual (matrix, "CreateFromColumns",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
		}

		[Test]
		public void CreateFromColumns_Out ()
		{
			SCNMatrix4.CreateFromColumns (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44),
			out var matrix);
			AssertEqual (matrix, "CreateFromColumns",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
		}

		[Test]
		public void CreateFromAxisAngle_pfloat_Out ()
		{
			SCNMatrix4.CreateFromAxisAngle (new SCNVector3 (2, 2, 2), (pfloat) (Math.PI / 2), out var matrix);
			AssertEqual (matrix, "CreateFromAxisAngle",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

#if !NET
		[Test]
		public void CreateFromAxisAngle_float_Out ()
		{
			SCNMatrix4.CreateFromAxisAngle (new Vector3 (2, 2, 2), (float) (Math.PI / 2), out var matrix);
			AssertEqual (matrix, "CreateFromAxisAngle",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreateFromAxisAngle_double_Out ()
		{
			SCNMatrix4.CreateFromAxisAngle (new Vector3d (2, 2, 2), (double) (Math.PI / 2), out var matrix);
			AssertEqual (matrix, "CreateFromAxisAngle",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}
#endif

		[Test]
		public void CreateFromAxisAngle ()
		{
			var matrix = SCNMatrix4.CreateFromAxisAngle (new SCNVector3 (2, 2, 2), (pfloat) (Math.PI / 2));
			AssertEqual (matrix, "CreateFromAxisAngle",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreateRotationX_Out ()
		{
			SCNMatrix4.CreateRotationX ((pfloat) (Math.PI / 2), out var matrix);
			AssertEqual (matrix, "CreateRotationX",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreateRotationX ()
		{
			var matrix = SCNMatrix4.CreateRotationX ((pfloat) (Math.PI / 2));
			AssertEqual (matrix, "CreateRotationX",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreateRotationY_Out ()
		{
			SCNMatrix4.CreateRotationY ((pfloat) (Math.PI / 2), out var matrix);
			AssertEqual (matrix, "CreateRotationY",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreateRotationY ()
		{
			var matrix = SCNMatrix4.CreateRotationY ((pfloat) (Math.PI / 2));
			AssertEqual (matrix, "CreateRotationY",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreateRotationZ_Out ()
		{
			SCNMatrix4.CreateRotationZ ((pfloat) (Math.PI / 2), out var matrix);
			AssertEqual (matrix, "CreateRotationZ",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreateRotationZ ()
		{
			var matrix = SCNMatrix4.CreateRotationZ ((pfloat) (Math.PI / 2));
			AssertEqual (matrix, "CreateRotationZ",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreateTranslation_Out ()
		{
			SCNMatrix4.CreateTranslation (1, 2, 3, out var matrix);
			AssertEqual (matrix, "CreateTranslation",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreateTranslation_Vector_Out ()
		{
			var translation = new SCNVector3 (1, 2, 3);
			SCNMatrix4.CreateTranslation (ref translation, out var matrix);
			AssertEqual (matrix, "CreateTranslation",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreateTranslation ()
		{
			var matrix = SCNMatrix4.CreateTranslation (1, 2, 3);
			AssertEqual (matrix, "CreateTranslation",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreateTranslation_Vector ()
		{
			var translation = new SCNVector3 (1, 2, 3);
			var matrix = SCNMatrix4.CreateTranslation (translation);
			AssertEqual (matrix, "CreateTranslation",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreateOrthographic_Out ()
		{
			SCNMatrix4.CreateOrthographic (1, 2, 3, 4, out var matrix);
			AssertEqual (matrix, "CreateOrthographic",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreateOrthographic ()
		{
			var matrix = SCNMatrix4.CreateOrthographic (1, 2, 3, 4);
			AssertEqual (matrix, "CreateOrthographic",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreateOrthographicOffCenter_Out ()
		{
			SCNMatrix4.CreateOrthographicOffCenter (1, 2, 3, 4, 5, 6, out var matrix);
			AssertEqual (matrix, "CreateOrthographicOffCenter",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreateOrthographicOffCenter ()
		{
			var matrix = SCNMatrix4.CreateOrthographicOffCenter (1, 2, 3, 4, 5, 6);
			AssertEqual (matrix, "CreateOrthographicOffCenter",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreatePerspectiveFieldOfView_Out ()
		{
			SCNMatrix4.CreatePerspectiveFieldOfView (1, 2, 3, 4, out var matrix);
			AssertEqual (matrix, "CreatePerspectiveFieldOfView",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreatePerspectiveFieldOfView ()
		{
			var matrix = SCNMatrix4.CreatePerspectiveFieldOfView (1, 2, 3, 4);
			AssertEqual (matrix, "CreatePerspectiveFieldOfView",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreatePerspectiveOffCenter_Out ()
		{
			SCNMatrix4.CreatePerspectiveOffCenter (1, 2, 3, 4, 5, 6, out var matrix);
			AssertEqual (matrix, "CreatePerspectiveOffCenter",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void CreatePerspectiveOffCenter ()
		{
			var matrix = SCNMatrix4.CreatePerspectiveOffCenter (1, 2, 3, 4, 5, 6);
			AssertEqual (matrix, "CreatePerspectiveOffCenter",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void Scale ()
		{
			var matrix = SCNMatrix4.Scale (2);
			AssertEqual (matrix, "CreateScale",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void Scale_Vector ()
		{
			var matrix = SCNMatrix4.Scale (new SCNVector3 (1, 2, 3));
			AssertEqual (matrix, "CreateScale",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void Scale_3 ()
		{
			var matrix = SCNMatrix4.Scale (1, 2, 3);
			AssertEqual (matrix, "CreateScale",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void Rotate ()
		{
			var quaternion = new Quaternion (1, 2, 3, 4);
			var matrix = SCNMatrix4.Rotate (quaternion);
			AssertEqual (matrix, "Rotate",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void Rotate_d ()
		{
			var quaternion = new Quaterniond (1, 2, 3, 4);
			var matrix = SCNMatrix4.Rotate (quaternion);
			AssertEqual (matrix, "Rotate",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void LookAt_Vectors ()
		{
			var matrix = SCNMatrix4.LookAt (new SCNVector3 (1, 2, 3), new SCNVector3 (4, 5, 6), new SCNVector3 (7, 8, 9));
			AssertEqual (matrix, "LookAt",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void LookAt_Elements ()
		{
			var matrix = SCNMatrix4.LookAt (1, 2, 3, 4, 5, 6, 7, 8, 9);
			AssertEqual (matrix, "LookAt",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
			/// NEEDS CORRECT ANSWER
		}

		[Test]
		public void Mult ()
		{
			var a = new SCNMatrix4 (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44));
			var b = new SCNMatrix4 (
				new SCNVector4 (911, 912, 913, 914),
				new SCNVector4 (921, 922, 923, 924),
				new SCNVector4 (931, 932, 933, 934),
				new SCNVector4 (941, 942, 943, 944));
			var matrix = SCNMatrix4.Mult (a, b);
			AssertEqual (matrix, "Mult",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
		}

		[Test]
		public void Mult_ByRef ()
		{
			var a = new SCNMatrix4 (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44));
			var b = new SCNMatrix4 (
				new SCNVector4 (911, 912, 913, 914),
				new SCNVector4 (921, 922, 923, 924),
				new SCNVector4 (931, 932, 933, 934),
				new SCNVector4 (941, 942, 943, 944));
			SCNMatrix4.Mult (ref a, ref b, out var matrix);
			AssertEqual (matrix, "Mult",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
		}

		[Test]
		public void Static_Invert ()
		{
			var a = new SCNMatrix4 (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44));
			var matrix = SCNMatrix4.Invert (a);
			AssertEqual (matrix, "Invert",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
		}

		[Test]
		public void Static_Transpose ()
		{
			var a = new SCNMatrix4 (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44));
			var matrix = SCNMatrix4.Transpose (a);
			AssertEqual (matrix, "Transpose",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
		}

		[Test]
		public void Static_Transpose_ByRef ()
		{
			var a = new SCNMatrix4 (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44));
			SCNMatrix4.Transpose (ref a, out var matrix);
			AssertEqual (matrix, "Transpose",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
		}

		[Test]
		public void Operator_Multiply ()
		{
			var a = new SCNMatrix4 (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44));
			var b = new SCNMatrix4 (
				new SCNVector4 (911, 912, 913, 914),
				new SCNVector4 (921, 922, 923, 924),
				new SCNVector4 (931, 932, 933, 934),
				new SCNVector4 (941, 942, 943, 944));
			var matrix = a * b;
			AssertEqual (matrix, "*",
				11, 21, 31, 41,
				12, 22, 32, 42,
				13, 23, 33, 43,
				14, 24, 34, 44);
		}

		[Test]
		public void Operator_Equals ()
		{
			var a = new SCNMatrix4 (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44));
			var b = new SCNMatrix4 (
				new SCNVector4 (911, 912, 913, 914),
				new SCNVector4 (921, 922, 923, 924),
				new SCNVector4 (931, 932, 933, 934),
				new SCNVector4 (941, 942, 943, 944));
			Assert.IsFalse (a == b, "Equals");
		}

		[Test]
		public void Operator_NotEquals ()
		{
			var a = new SCNMatrix4 (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44));
			var b = new SCNMatrix4 (
				new SCNVector4 (911, 912, 913, 914),
				new SCNVector4 (921, 922, 923, 924),
				new SCNVector4 (931, 932, 933, 934),
				new SCNVector4 (941, 942, 943, 944));
			Assert.IsTrue (a != b, "NotEquals");
		}

		[Test]
		public void ToString ()
		{
			var matrix = new SCNMatrix4 (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44));
			Assert.AreEqual ("(11, 12, 13, 14)\n(21, 22, 23, 24)\n(31, 32, 33, 34)\n(41, 42, 43, 44)", matrix.ToString (), "ToString");
		}

		[Test]
		public void Object_Equals ()
		{
			var a = new SCNMatrix4 (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44));
			var b = new SCNMatrix4 (
				new SCNVector4 (911, 912, 913, 914),
				new SCNVector4 (921, 922, 923, 924),
				new SCNVector4 (931, 932, 933, 934),
				new SCNVector4 (941, 942, 943, 944));
			Assert.IsFalse (((object) a).Equals (b), "object.Equals");
		}

		[Test]
		public void IEquatable_Equals ()
		{
			var a = new SCNMatrix4 (
				new SCNVector4 (11, 12, 13, 14),
				new SCNVector4 (21, 22, 23, 24),
				new SCNVector4 (31, 32, 33, 34),
				new SCNVector4 (41, 42, 43, 44));
			var b = new SCNMatrix4 (
				new SCNVector4 (911, 912, 913, 914),
				new SCNVector4 (921, 922, 923, 924),
				new SCNVector4 (931, 932, 933, 934),
				new SCNVector4 (941, 942, 943, 944));
			Assert.IsFalse (((IEquatable<SCNMatrix4>) a).Equals (b), "object.Equals");
		}
	}
}

