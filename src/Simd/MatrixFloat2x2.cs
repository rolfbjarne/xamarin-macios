//
// Authors:
//     Rolf Bjarne Kvinge <rolf@xamarin.com>
//
// Copyright (c) 2017 Microsoft Inc
//

// 
// This represents the native matrix_float2x2 type, which has a column-major layout
// (as opposed to OpenTK.Matrix2, which has a row-major layout).
// 

using System;
using System.Runtime.InteropServices;

namespace OpenTK
{
	[StructLayout (LayoutKind.Sequential)]
	public struct SimdMatrix2 : IEquatable<SimdMatrix2>
	{
		public float M11;
		public float M21;
		public float M12;
		public float M22;

		public readonly static SimdMatrix2 Identity = new SimdMatrix2 (
			1, 0,
			0, 1);

		public SimdMatrix2 (global::OpenTK.Vector2 column0, global::OpenTK.Vector2 column1)
		{
			M11 = column0.X;
			M21 = column0.Y;
			M12 = column1.X;
			M22 = column1.Y;
		}

		public SimdMatrix2 (
			float m11, float m12,
			float m21, float m22)
		{
			M11 = m11;
			M21 = m21;
			M12 = m12;
			M22 = m22;
		}

		public float Determinant {
			get {
				return M11 * M22 - M21 * M12;
			}
		}

		public void Transpose ()
		{
			this = Transpose (this);
		}

		public static SimdMatrix2 Transpose (SimdMatrix2 mat)
		{
			return new SimdMatrix2 (mat.M11, mat.M21, mat.M12, mat.M22);
		}

		public static void Transpose (ref SimdMatrix2 mat, out SimdMatrix2 result)
		{
			result.M11 = mat.M11;
			result.M12 = mat.M21;
			result.M21 = mat.M12;
			result.M22 = mat.M22;
		}

		public static SimdMatrix2 Multiply (SimdMatrix2 left, SimdMatrix2 right)
		{
			SimdMatrix2 result;
			Multiply (ref left, ref right, out result);
			return result;
		}

		public static void Multiply (ref SimdMatrix2 left, ref SimdMatrix2 right, out SimdMatrix2 result)
		{
			result.M11 = left.M11 * right.M11 + left.M12 * right.M21;
			result.M12 = left.M11 * right.M12 + left.M12 * right.M22;

			result.M21 = left.M21 * right.M11 + left.M22 * right.M21;
			result.M22 = left.M21 * right.M12 + left.M22 * right.M22;
		}

		public static SimdMatrix2 operator * (SimdMatrix2 left, SimdMatrix2 right)
		{
			return Multiply (left, right);
		}

		public static bool operator == (SimdMatrix2 left, SimdMatrix2 right)
		{
			return left.Equals (right);
		}

		public static bool operator != (SimdMatrix2 left, SimdMatrix2 right)
		{
			return !left.Equals (right);
		}

		public static explicit operator global::OpenTK.Matrix2 (SimdMatrix2 value)
		{
			return new global::OpenTK.Matrix2 (
				value.M11, value.M12,
				value.M21, value.M22);
		}

		public static explicit operator SimdMatrix2 (global::OpenTK.Matrix2 value)
		{
			return new SimdMatrix2 (
				value.R0C0, value.R0C1,
				value.R1C0, value.R1C1);
		}

		public override string ToString ()
		{
			return $"({M11}, {M12})\n({M21}, {M22})";
		}

		public override int GetHashCode ()
		{
			return M11.GetHashCode () ^ M12.GetHashCode () ^ M21.GetHashCode () ^ M22.GetHashCode ();
		}

		public override bool Equals (object obj)
		{
			if (!(obj is SimdMatrix2))
				return false;

			return Equals ((SimdMatrix2) obj);
		}

		public bool Equals (SimdMatrix2 other)
		{
			return
				M11 == other.M11 &&
				M12 == other.M12 &&
				M21 == other.M21 &&
				M22 == other.M22;
		}
	}
}
