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
 * This represents the native matrix_float4x4 type, which has a column-major layout
 */

using System;
using System.Runtime.InteropServices;

using VectorFloat4=global::OpenTK.Vector4;

namespace Simd
{
	[StructLayout (LayoutKind.Sequential)]
	public struct MatrixFloat4x4 : IEquatable<MatrixFloat4x4>
	{
		public VectorFloat4 Column0;
		public VectorFloat4 Column1;
		public VectorFloat4 Column2;
		public VectorFloat4 Column3;

		public readonly static MatrixFloat4x4 Identity = new MatrixFloat4x4 {
			M11 = 1f,
			M22 = 1f,
			M33 = 1f,
			M44 = 1f,
		};

		public MatrixFloat4x4 (VectorFloat4 column0, VectorFloat4 column1, VectorFloat4 column2, VectorFloat4 column3)
		{
			Column0 = column0;
			Column1 = column1;
			Column2 = column2;
			Column3 = column3;
		}

		public MatrixFloat4x4 (
			float m11, float m12, float m13, float m14,
			float m21, float m22, float m23, float m24,
			float m31, float m32, float m33, float m34,
			float m41, float m42, float m43, float m44)
		{
			Column0.X = m11;
			Column0.Y = m21;
			Column0.Z = m31;
			Column0.W = m41;
			Column1.X = m12;
			Column1.Y = m22;
			Column1.Z = m32;
			Column1.W = m42;
			Column2.X = m13;
			Column2.Y = m23;
			Column2.Z = m33;
			Column2.W = m43;
			Column3.X = m14;
			Column3.Y = m24;
			Column3.Z = m34;
			Column3.W = m44;
		}

		public float Determinant {
			get {
				float a = Column2.Z * Column3.W - Column3.Z * Column2.W;
				float b = Column1.Z * Column3.W - Column3.Z * Column1.W;
				float c = Column1.Z * Column2.W - Column2.Z * Column1.W;
				float d = Column0.Z * Column3.W - Column3.Z * Column0.W;
				float e = Column0.Z * Column2.W - Column2.Z * Column0.W;
				float f = Column0.Z * Column1.W - Column1.Z * Column0.W;

				return Column0.X * (Column1.Y * a - Column2.Y * b + Column3.Y * c) -
					   Column1.X * (Column0.Y * a - Column2.Y * d + Column3.Y * e) +
					   Column2.X * (Column0.Y * b - Column1.Y * d + Column3.Y * f) -
					   Column3.X * (Column0.Y * c - Column1.Y * e + Column2.Y * f);
			}
		}

		public VectorFloat4 Row0 {
			get { return new VectorFloat4 (Column0.X, Column1.X, Column2.X, Column3.X); }
			set {
				Column0.X = value.X;
				Column1.X = value.Y;
				Column2.X = value.Z;
				Column3.X = value.W;
			}
		}

		public VectorFloat4 Row1 {
			get { return new VectorFloat4 (Column0.Y, Column1.Y, Column2.Y, Column3.Y); }
			set {
				Column0.Y = value.X;
				Column1.Y = value.Y;
				Column2.Y = value.Z;
				Column3.Y = value.W;
			}
		}

		public VectorFloat4 Row2 {
			get { return new VectorFloat4 (Column0.Z, Column1.Z, Column2.Z, Column3.Z); }
			set {
				Column0.Z = value.X;
				Column1.Z = value.Y;
				Column2.Z = value.Z;
				Column3.Z = value.W;
			}
		}

		public VectorFloat4 Row3 {
			get { return new VectorFloat4 (Column0.W, Column1.W, Column2.W, Column3.W); }
			set {
				Column0.W = value.X;
				Column1.W = value.Y;
				Column2.W = value.Z;
				Column3.W = value.W;
			}
		}

		public float M11 { get { return Column0.X; } set { Column0.X = value; } }
		public float M12 { get { return Column1.X; } set { Column1.X = value; } }
		public float M13 { get { return Column2.X; } set { Column2.X = value; } }
		public float M14 { get { return Column3.X; } set { Column3.X = value; } }
		public float M21 { get { return Column0.Y; } set { Column0.Y = value; } }
		public float M22 { get { return Column1.Y; } set { Column1.Y = value; } }
		public float M23 { get { return Column2.Y; } set { Column2.Y = value; } }
		public float M24 { get { return Column3.Y; } set { Column3.Y = value; } }
		public float M31 { get { return Column0.Z; } set { Column0.Z = value; } }
		public float M32 { get { return Column1.Z; } set { Column1.Z = value; } }
		public float M33 { get { return Column2.Z; } set { Column2.Z = value; } }
		public float M34 { get { return Column3.Z; } set { Column3.Z = value; } }
		public float M41 { get { return Column0.W; } set { Column0.W = value; } }
		public float M42 { get { return Column1.W; } set { Column1.W = value; } }
		public float M43 { get { return Column2.W; } set { Column2.W = value; } }
		public float M44 { get { return Column3.W; } set { Column3.W = value; } }

		public void Invert ()
		{
			this = Invert (this);
		}

		// FIXME: check which OS versions this was introduced in.
		// Introduced in Yosemite (not present in Mavericks)
		[DllImport ("/usr/lib/system/libsystem_m.dylib", EntryPoint = "__invert_f4")]
		public static extern MatrixFloat4x4 Invert (MatrixFloat4x4 matrix);

		public void Invert (ref MatrixFloat4x4 result)
		{
			result = Invert (this);
		}

		public void Transpose ()
		{
			this = Transpose (this);
		}

		public static MatrixFloat4x4 Transpose (MatrixFloat4x4 mat)
		{
			MatrixFloat4x4 result;
			Transpose (ref mat, out result);
			return result;
		}

		public static void Transpose (ref MatrixFloat4x4 mat, out MatrixFloat4x4 result)
		{
			result.Column0.X = mat.Column0.X;
			result.Column0.Y = mat.Column1.X;
			result.Column0.Z = mat.Column2.X;
			result.Column0.W = mat.Column3.X;

			result.Column1.X = mat.Column0.Y;
			result.Column1.Y = mat.Column1.Y;
			result.Column1.Z = mat.Column2.Y;
			result.Column1.W = mat.Column3.Y;

			result.Column2.X = mat.Column0.Z;
			result.Column2.Y = mat.Column1.Z;
			result.Column2.Z = mat.Column2.Z;
			result.Column2.W = mat.Column3.Z;

			result.Column3.X = mat.Column0.W;
			result.Column3.Y = mat.Column1.W;
			result.Column3.Z = mat.Column2.W;
			result.Column3.W = mat.Column3.W;
		}

		public static MatrixFloat4x4 Multiply (MatrixFloat4x4 left, MatrixFloat4x4 right)
		{
			MatrixFloat4x4 result;
			Multiply (ref left, ref right, out result);
			return result;
		}

		public static void Multiply (ref MatrixFloat4x4 left, ref MatrixFloat4x4 right, out MatrixFloat4x4 result)
		{
			result.Column0.X = left.Column0.X * right.Column0.X + left.Column1.X * right.Column0.Y + left.Column2.X * right.Column0.Z + left.Column3.X * right.Column0.W;
			result.Column1.X = left.Column0.X * right.Column1.X + left.Column1.X * right.Column1.Y + left.Column2.X * right.Column1.Z + left.Column3.X * right.Column1.W;
			result.Column2.X = left.Column0.X * right.Column2.X + left.Column1.X * right.Column2.Y + left.Column2.X * right.Column2.Z + left.Column3.X * right.Column2.W;
			result.Column3.X = left.Column0.X * right.Column3.X + left.Column1.X * right.Column3.Y + left.Column2.X * right.Column3.Z + left.Column3.X * right.Column3.W;

			result.Column0.Y = left.Column0.Y * right.Column0.X + left.Column1.Y * right.Column0.Y + left.Column2.Y * right.Column0.Z + left.Column3.Y * right.Column0.W;
			result.Column1.Y = left.Column0.Y * right.Column1.X + left.Column1.Y * right.Column1.Y + left.Column2.Y * right.Column1.Z + left.Column3.Y * right.Column1.W;
			result.Column2.Y = left.Column0.Y * right.Column2.X + left.Column1.Y * right.Column2.Y + left.Column2.Y * right.Column2.Z + left.Column3.Y * right.Column2.W;
			result.Column3.Y = left.Column0.Y * right.Column3.X + left.Column1.Y * right.Column3.Y + left.Column2.Y * right.Column3.Z + left.Column3.Y * right.Column3.W;

			result.Column0.Z = left.Column0.Z * right.Column0.X + left.Column1.Z * right.Column0.Y + left.Column2.Z * right.Column0.Z + left.Column3.Z * right.Column0.W;
			result.Column1.Z = left.Column0.Z * right.Column1.X + left.Column1.Z * right.Column1.Y + left.Column2.Z * right.Column1.Z + left.Column3.Z * right.Column1.W;
			result.Column2.Z = left.Column0.Z * right.Column2.X + left.Column1.Z * right.Column2.Y + left.Column2.Z * right.Column2.Z + left.Column3.Z * right.Column2.W;
			result.Column3.Z = left.Column0.Z * right.Column3.X + left.Column1.Z * right.Column3.Y + left.Column2.Z * right.Column3.Z + left.Column3.Z * right.Column3.W;

			result.Column0.W = left.Column0.W * right.Column0.X + left.Column1.W * right.Column0.Y + left.Column2.W * right.Column0.Z + left.Column3.W * right.Column0.W;
			result.Column1.W = left.Column0.W * right.Column1.X + left.Column1.W * right.Column1.Y + left.Column2.W * right.Column1.Z + left.Column3.W * right.Column1.W;
			result.Column2.W = left.Column0.W * right.Column2.X + left.Column1.W * right.Column2.Y + left.Column2.W * right.Column2.Z + left.Column3.W * right.Column2.W;
			result.Column3.W = left.Column0.W * right.Column3.X + left.Column1.W * right.Column3.Y + left.Column2.W * right.Column3.Z + left.Column3.W * right.Column3.W;
		}

		public static MatrixFloat4x4 operator * (MatrixFloat4x4 left, MatrixFloat4x4 right)
		{
			return Multiply (left, right);
		}

		public static bool operator == (MatrixFloat4x4 left, MatrixFloat4x4 right)
		{
			return left.Equals (right);
		}

		public static bool operator != (MatrixFloat4x4 left, MatrixFloat4x4 right)
		{
			return !left.Equals (right);
		}

		public static explicit operator global::OpenTK.Matrix4 (MatrixFloat4x4 value)
		{
			return new global::OpenTK.Matrix4 (value.Row0, value.Row1, value.Row2, value.Row3);
		}

		public static explicit operator MatrixFloat4x4 (global::OpenTK.Matrix4 value)
		{
			return new MatrixFloat4x4 (value.Column0, value.Column1, value.Column2, value.Column3);
		}

		public override string ToString ()
		{
			return String.Format ("{0}\n{1}\n{2}\n{3}", Row0, Row1, Row2, Row3);
		}

		public override int GetHashCode ()
		{
			return Column0.GetHashCode () ^ Column1.GetHashCode () ^ Column2.GetHashCode () ^ Column3.GetHashCode ();
		}

		public override bool Equals (object obj)
		{
			if (!(obj is MatrixFloat4x4))
				return false;

			return Equals ((MatrixFloat4x4) obj);
		}

		public bool Equals (MatrixFloat4x4 other)
		{
			return
				Column0 == other.Column0 &&
				Column1 == other.Column1 &&
				Column2 == other.Column2 &&
				Column3 == other.Column3;
		}
	}
}
