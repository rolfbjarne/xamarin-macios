/*
Copyright (c) 2006 - 2008 The Open Toolkit library.
Copyright (c) 2017 Microsoft Inc.  All rights reserved

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
of the Software, and to permit persons to whom the Software is furnished to do
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
 */

/*
 * This represents the native matrix_float3x3 type, which has a column-major layout
 */

using System;
using System.Runtime.InteropServices;

using VectorFloat3=global::OpenTK.Vector3;

namespace Simd
{
	[StructLayout (LayoutKind.Sequential)]
	public struct MatrixFloat3x3 : IEquatable<MatrixFloat3x3>
	{
		/* Due to memory alignment, vectors of length 3 are 
		 * represented as vectors of length 4, so we pad here
		 * with dummy fields.
		 * See top of /usr/include/simd/matrix_types.h for more information. */
		public VectorFloat3 Column0;
		float dummy0;
		public VectorFloat3 Column1;
		float dummy1;
		public VectorFloat3 Column2;
		float dummy2;

		public readonly static MatrixFloat3x3 Identity = new MatrixFloat3x3 (VectorFloat3.UnitX, VectorFloat3.UnitY, VectorFloat3.UnitZ);

		public MatrixFloat3x3 (VectorFloat3 column0, VectorFloat3 column1, VectorFloat3 column2)
		{
			Column0 = column0;
			Column1 = column1;
			Column2 = column2;
			dummy0 = 0;
			dummy1 = 0;
			dummy2 = 0;
		}

		public MatrixFloat3x3 (
			float m00, float m01, float m02,
			float m10, float m11, float m12,
			float m20, float m21, float m22)
		{
			Column0 = new VectorFloat3 (m00, m10, m20);
			Column1 = new VectorFloat3 (m01, m11, m21);
			Column2 = new VectorFloat3 (m02, m12, m22);
			dummy0 = 0;
			dummy1 = 0;
			dummy2 = 0;
		}

		public float Determinant {
			get {
				return 
					M11 * (M22 * M33 - M23 * M32) - 
					M12 * (M21 * M33 - M23 * M31) + 
					M13 * (M21 * M32 - M22 * M31);
			}
		}

		public VectorFloat3 Row0 {
			get { return new VectorFloat3 (Column0.X, Column1.X, Column2.X); }
			set {
				Column0.X = value.X;
				Column1.X = value.Y;
				Column2.X = value.Z;
			}
		}

		public VectorFloat3 Row1 {
			get { return new VectorFloat3 (Column0.Y, Column1.Y, Column2.Y); }
			set {
				Column0.Y = value.X;
				Column1.Y = value.Y;
				Column2.Y = value.Z;
			}
		}

		public VectorFloat3 Row2 {
			get { return new VectorFloat3 (Column0.Z, Column1.Z, Column2.Z); }
			set {
				Column0.Z = value.X;
				Column1.Z = value.Y;
				Column2.Z = value.Z;
			}
		}

		public float M11 { get { return Column0.X; } set { Column0.X = value; } }
		public float M12 { get { return Column1.X; } set { Column1.X = value; } }
		public float M13 { get { return Column2.X; } set { Column2.X = value; } }
		public float M21 { get { return Column0.Y; } set { Column0.Y = value; } }
		public float M22 { get { return Column1.Y; } set { Column1.Y = value; } }
		public float M23 { get { return Column2.Y; } set { Column2.Y = value; } }
		public float M31 { get { return Column0.Z; } set { Column0.Z = value; } }
		public float M32 { get { return Column1.Z; } set { Column1.Z = value; } }
		public float M33 { get { return Column2.Z; } set { Column2.Z = value; } }

		public void Invert ()
		{
			this = Invert (this);
		}

		public void Transpose ()
		{
			this = Transpose (this);
		}

		public static MatrixFloat3x3 Multiply (MatrixFloat3x3 left, MatrixFloat3x3 right)
		{
			MatrixFloat3x3 result;
			Multiply (ref left, ref right, out result);
			return result;
		}

		public static void Multiply (ref MatrixFloat3x3 left, ref MatrixFloat3x3 right, out MatrixFloat3x3 result)
		{
			result = new MatrixFloat3x3 (
				left.M11 * right.M11 + left.M12 * right.M21 + left.M13 * right.M31,
				left.M11 * right.M12 + left.M12 * right.M22 + left.M13 * right.M32,
				left.M11 * right.M13 + left.M12 * right.M23 + left.M13 * right.M33,
				left.M21 * right.M11 + left.M22 * right.M21 + left.M23 * right.M31,
				left.M21 * right.M12 + left.M22 * right.M22 + left.M23 * right.M32,
				left.M21 * right.M13 + left.M22 * right.M23 + left.M23 * right.M33,
				left.M31 * right.M11 + left.M32 * right.M21 + left.M33 * right.M31,
				left.M31 * right.M12 + left.M32 * right.M22 + left.M33 * right.M32,
				left.M31 * right.M13 + left.M32 * right.M23 + left.M33 * right.M33);
		}

		[DllImport ("/usr/lib/system/libsystem_m.dylib", EntryPoint = "__invert_f3")]
		static extern MatrixFloat3x3 Invert (MatrixFloat3x3 matrix);

		public static MatrixFloat3x3 Transpose (MatrixFloat3x3 mat)
		{
			return new MatrixFloat3x3 (mat.Row0, mat.Row1, mat.Row2);
		}

		public static void Transpose (ref MatrixFloat3x3 mat, out MatrixFloat3x3 result)
		{
			result = new MatrixFloat3x3 ();
			result.Row0 = mat.Column0;
			result.Row1 = mat.Column1;
			result.Row2 = mat.Column2;
		}

		public static MatrixFloat3x3 operator * (MatrixFloat3x3 left, MatrixFloat3x3 right)
		{
			return MatrixFloat3x3.Multiply (left, right);
		}

		public static bool operator == (MatrixFloat3x3 left, MatrixFloat3x3 right)
		{
			return left.Equals (right);
		}

		public static bool operator != (MatrixFloat3x3 left, MatrixFloat3x3 right)
		{
			return !left.Equals (right);
		}

		public static explicit operator global::OpenTK.Matrix3 (MatrixFloat3x3 value)
		{
			return new global::OpenTK.Matrix3 (value.M11, value.M21, value.M31,
											   value.M21, value.M22, value.M32,
											   value.M31, value.M32, value.M33);
		}

		public static explicit operator MatrixFloat3x3 (global::OpenTK.Matrix3 value)
		{
			return new MatrixFloat3x3 (value.R0C0, value.R0C1, value.R0C1,
									   value.R1C0, value.R1C1, value.R1C2,
									   value.R2C0, value.R2C1, value.R2C2);
		}

		public override string ToString ()
		{
			return String.Format ("{0}\n{1}\n{2}", Row0, Row1, Row2);
		}

		public override int GetHashCode ()
		{
			return Column0.GetHashCode () ^ Column1.GetHashCode () ^ Column2.GetHashCode ();
		}

		public override bool Equals (object obj)
		{
			if (!(obj is MatrixFloat3x3))
				return false;

			return Equals ((MatrixFloat3x3) obj);
		}

		public bool Equals (MatrixFloat3x3 other)
		{
			return
				Column0 == other.Column0 &&
				Column1 == other.Column1 &&
				Column2 == other.Column2;
		}
	}
}
