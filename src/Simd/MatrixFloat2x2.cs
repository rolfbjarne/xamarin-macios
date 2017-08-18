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

using VectorFloat2=global::OpenTK.Vector2;

namespace Simd
{
	[StructLayout (LayoutKind.Sequential)]
	public struct MatrixFloat2x2 : IEquatable<MatrixFloat2x2>
	{
		public VectorFloat2 Column0;
		public VectorFloat2 Column1;

		public readonly static MatrixFloat2x2 Identity = new MatrixFloat2x2 (VectorFloat2.UnitX, VectorFloat2.UnitY);

		public MatrixFloat2x2 (VectorFloat2 column0, VectorFloat2 column1)
		{
			Column0 = column0;
			Column1 = column1;
		}

		public MatrixFloat2x2 (
			float m11, float m12,
			float m21, float m22)
		{
			Column0.X = m11;
			Column0.Y = m21;
			Column1.X = m12;
			Column1.Y = m22;
		}

		public float Determinant {
			get {
				return Column0.X * Column1.Y - Column1.X * Column0.Y;
			}
		}

		public VectorFloat2 Row0 {
			get { return new VectorFloat2 (Column0.X, Column1.X); }
			set {
				Column0.X = value.X;
				Column1.X = value.Y;
			}
		}

		public VectorFloat2 Row1 {
			get { return new VectorFloat2 (Column0.Y, Column1.Y); }
			set {
				Column0.Y = value.X;
				Column1.Y = value.Y;
			}
		}

		public float M11 { get { return Column0.X; } set { Column0.X = value; } }
		public float M12 { get { return Column1.X; } set { Column1.X = value; } }
		public float M21 { get { return Column0.Y; } set { Column0.Y = value; } }
		public float M22 { get { return Column1.Y; } set { Column1.Y = value; } }

		public void Invert ()
		{
			this = Invert (this);
		}

		[DllImport ("/usr/lib/system/libsystem_m.dylib", EntryPoint = "__invert_f2")]
		public static extern MatrixFloat2x2 Invert (MatrixFloat2x2 matrix);

		public void Transpose ()
		{
			this = Transpose (this);
		}

		public static MatrixFloat2x2 Transpose (MatrixFloat2x2 mat)
		{
			return new MatrixFloat2x2 (mat.Row0, mat.Row1);
		}

		public static void Transpose (ref MatrixFloat2x2 mat, out MatrixFloat2x2 result)
		{
			result = new MatrixFloat2x2 ();
			result.Row0 = mat.Column0;
			result.Row1 = mat.Column1;
		}

		public static MatrixFloat2x2 Multiply (MatrixFloat2x2 left, MatrixFloat2x2 right)
		{
			MatrixFloat2x2 result;
			Multiply (ref left, ref right, out result);
			return result;
		}

		public static void Multiply (ref MatrixFloat2x2 left, ref MatrixFloat2x2 right, out MatrixFloat2x2 result)
		{
			result.Column0.X = left.Column0.X * right.Column0.X + left.Column1.X * right.Column0.Y;
			result.Column1.X = left.Column0.X * right.Column1.X + left.Column1.X * right.Column1.Y;

			result.Column0.Y = left.Column0.Y * right.Column0.X + left.Column1.Y * right.Column0.Y;
			result.Column1.Y = left.Column0.Y * right.Column1.X + left.Column1.Y * right.Column1.Y;
		}

		public static MatrixFloat2x2 operator * (MatrixFloat2x2 left, MatrixFloat2x2 right)
		{
			return Multiply (left, right);
		}

		public static bool operator == (MatrixFloat2x2 left, MatrixFloat2x2 right)
		{
			return left.Equals (right);
		}

		public static bool operator != (MatrixFloat2x2 left, MatrixFloat2x2 right)
		{
			return !left.Equals (right);
		}

		public static explicit operator global::OpenTK.Matrix2 (MatrixFloat2x2 value)
		{
			return new global::OpenTK.Matrix2 (value.M11, value.M12,
											   value.M21, value.M22);
		}

		public static explicit operator MatrixFloat2x2 (global::OpenTK.Matrix2 value)
		{
			return new MatrixFloat2x2 (value.R0C0, value.R0C1,
									   value.R1C0, value.R1C1);
		}

		public override string ToString ()
		{
			return String.Format ("{0}\n{1}", Row0, Row1);
		}

		public override int GetHashCode ()
		{
			return Column0.GetHashCode () ^ Column1.GetHashCode ();
		}

		public override bool Equals (object obj)
		{
			if (!(obj is MatrixFloat2x2))
				return false;

			return Equals ((MatrixFloat2x2) obj);
		}

		public bool Equals (MatrixFloat2x2 other)
		{
			return
				Column0 == other.Column0 &&
				Column1 == other.Column1;
		}
	}
}
