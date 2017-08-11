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
			float m11, float m12, float m13,
			float m21, float m22, float m23,
			float m31, float m32, float m33)
		{
			Column0.X = m11;
			Column0.Y = m21;
			Column0.Z = m31;
			Column1.X = m12;
			Column1.Y = m22;
			Column1.Z = m32;
			Column2.X = m13;
			Column2.Y = m23;
			Column2.Z = m33;
			dummy0 = 0;
			dummy1 = 0;
			dummy2 = 0;
		}

		public float Determinant {
			get {
				return 
					Column0.X * (Column1.Y * Column2.Z - Column2.Y * Column1.Z) - 
					Column1.X * (Column0.X * Column2.Z - Column2.Y * Column0.Z) + 
					Column2.X * (Column0.X * Column1.Z - Column1.Y * Column0.Z);
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

		[DllImport ("/usr/lib/system/libsystem_m.dylib", EntryPoint = "__invert_f3")]
		public static extern MatrixFloat3x3 Invert (MatrixFloat3x3 matrix);

		public void Transpose ()
		{
			this = Transpose (this);
		}

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

		public static MatrixFloat3x3 Multiply (MatrixFloat3x3 left, MatrixFloat3x3 right)
		{
			MatrixFloat3x3 result;
			Multiply (ref left, ref right, out result);
			return result;
		}

		public static void Multiply (ref MatrixFloat3x3 left, ref MatrixFloat3x3 right, out MatrixFloat3x3 result)
		{
			result.Column0.X = left.Column0.X * right.Column0.X + left.Column1.X * right.Column0.Y + left.Column2.X * right.Column0.Z;
			result.Column1.X = left.Column0.X * right.Column1.X + left.Column1.X * right.Column1.Y + left.Column2.X * right.Column1.Z;
			result.Column2.X = left.Column0.X * right.Column2.X + left.Column1.X * right.Column2.Y + left.Column2.X * right.Column2.Z;
			result.dummy0 = 0;

			result.Column0.Y = left.Column0.Y * right.Column0.X + left.Column1.Y * right.Column0.Y + left.Column2.Y * right.Column0.Z;
			result.Column1.Y = left.Column0.Y * right.Column1.X + left.Column1.Y * right.Column1.Y + left.Column2.Y * right.Column1.Z;
			result.Column2.Y = left.Column0.Y * right.Column2.X + left.Column1.Y * right.Column2.Y + left.Column2.Y * right.Column2.Z;
			result.dummy1 = 0;

			result.Column0.Z = left.Column0.Z * right.Column0.X + left.Column1.Z * right.Column0.Y + left.Column2.Z * right.Column0.Z;
			result.Column1.Z = left.Column0.Z * right.Column1.X + left.Column1.Z * right.Column1.Y + left.Column2.Z * right.Column1.Z;
			result.Column2.Z = left.Column0.Z * right.Column2.X + left.Column1.Z * right.Column2.Y + left.Column2.Z * right.Column2.Z;
			result.dummy2 = 0;
		}

		public static MatrixFloat3x3 operator * (MatrixFloat3x3 left, MatrixFloat3x3 right)
		{
			return Multiply (left, right);
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
			return new global::OpenTK.Matrix3 (value.M11, value.M12, value.M13,
											   value.M21, value.M22, value.M23,
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
