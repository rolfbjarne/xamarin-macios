#region --- License ---
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
#endregion

/*
 * This represents the native matrix_float4x4 type, which has a column-major layout
 */

using System;
using System.Runtime.InteropServices;

using VectorFloat3=global::OpenTK.Vector3;
using VectorFloat4=global::OpenTK.Vector4;

namespace Simd
{
    [Serializable]
    [StructLayout (LayoutKind.Sequential)]
    public struct MatrixFloat4x4 : IEquatable<MatrixFloat4x4>
    {
        public VectorFloat4 Column0;
        public VectorFloat4 Column1;
        public VectorFloat4 Column2;
        public VectorFloat4 Column3;

        public readonly static MatrixFloat4x4 Identity = new MatrixFloat4x4 (VectorFloat4.UnitX, VectorFloat4.UnitY, VectorFloat4.UnitZ, VectorFloat4.UnitW);

        public MatrixFloat4x4 (VectorFloat4 column0, VectorFloat4 column1, VectorFloat4 column2, VectorFloat4 column3)
        {
            Column0 = column0;
            Column1 = column1;
            Column2 = column2;
            Column3 = column3;
        }

        public MatrixFloat4x4 (
            float m00, float m01, float m02, float m03,
            float m10, float m11, float m12, float m13,
            float m20, float m21, float m22, float m23,
            float m30, float m31, float m32, float m33)
        {
            Column0 = new VectorFloat4 (m00, m10, m20, m30);
            Column1 = new VectorFloat4 (m01, m11, m21, m31);
            Column2 = new VectorFloat4 (m02, m12, m22, m32);
            Column3 = new VectorFloat4 (m03, m13, m23, m33);
        }

        /// <summary>
        /// The determinant of this matrix
        /// </summary>
        public float Determinant
        {
            get
            {
                return
                    Row0.X * Row1.Y * Row2.Z * Row3.W - Row0.X * Row1.Y * Row2.W * Row3.Z + Row0.X * Row1.Z * Row2.W * Row3.Y - Row0.X * Row1.Z * Row2.Y * Row3.W
                  + Row0.X * Row1.W * Row2.Y * Row3.Z - Row0.X * Row1.W * Row2.Z * Row3.Y - Row0.Y * Row1.Z * Row2.W * Row3.X + Row0.Y * Row1.Z * Row2.X * Row3.W
                  - Row0.Y * Row1.W * Row2.X * Row3.Z + Row0.Y * Row1.W * Row2.Z * Row3.X - Row0.Y * Row1.X * Row2.Z * Row3.W + Row0.Y * Row1.X * Row2.W * Row3.Z
                  + Row0.Z * Row1.W * Row2.X * Row3.Y - Row0.Z * Row1.W * Row2.Y * Row3.X + Row0.Z * Row1.X * Row2.Y * Row3.W - Row0.Z * Row1.X * Row2.W * Row3.Y
                  + Row0.Z * Row1.Y * Row2.W * Row3.X - Row0.Z * Row1.Y * Row2.X * Row3.W - Row0.W * Row1.X * Row2.Y * Row3.Z + Row0.W * Row1.X * Row2.Z * Row3.Y
                  - Row0.W * Row1.Y * Row2.Z * Row3.X + Row0.W * Row1.Y * Row2.X * Row3.Z - Row0.W * Row1.Z * Row2.X * Row3.Y + Row0.W * Row1.Z * Row2.Y * Row3.X;
            }
        }

        public VectorFloat4 Row0
        {
            get { return new VectorFloat4 (Column0.X, Column1.X, Column2.X, Column3.X); }
        }

        public VectorFloat4 Row1
        {
            get { return new VectorFloat4 (Column0.Y, Column1.Y, Column2.Y, Column3.Y); }
        }

        public VectorFloat4 Row2
        {
            get { return new VectorFloat4 (Column0.Z, Column1.Z, Column2.Z, Column3.Z); }
        }

        public VectorFloat4 Row3
        {
            get { return new VectorFloat4 (Column0.W, Column1.W, Column2.W, Column3.W); }
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

        public void Transpose ()
        {
            this = Transpose (this);
        }

        public static MatrixFloat4x4 Multiply (MatrixFloat4x4 left, MatrixFloat4x4 right)
        {
            MatrixFloat4x4 result;
            Mult (ref left, ref right, out result);
            return result;
        }

        public static void Multiply (ref MatrixFloat4x4 left, ref MatrixFloat4x4 right, out MatrixFloat4x4 result)
        {
            result = new MatrixFloat4x4 (
                left.M11 * right.M11 + left.M12 * right.M21 + left.M13 * right.M31 + left.M14 * right.M41,
                left.M11 * right.M12 + left.M12 * right.M22 + left.M13 * right.M32 + left.M14 * right.M42,
                left.M11 * right.M13 + left.M12 * right.M23 + left.M13 * right.M33 + left.M14 * right.M43,
                left.M11 * right.M14 + left.M12 * right.M24 + left.M13 * right.M34 + left.M14 * right.M44,
                left.M21 * right.M11 + left.M22 * right.M21 + left.M23 * right.M31 + left.M24 * right.M41,
                left.M21 * right.M12 + left.M22 * right.M22 + left.M23 * right.M32 + left.M24 * right.M42,
                left.M21 * right.M13 + left.M22 * right.M23 + left.M23 * right.M33 + left.M24 * right.M43,
                left.M21 * right.M14 + left.M22 * right.M24 + left.M23 * right.M34 + left.M24 * right.M44,
                left.M31 * right.M11 + left.M32 * right.M21 + left.M33 * right.M31 + left.M34 * right.M41,
                left.M31 * right.M12 + left.M32 * right.M22 + left.M33 * right.M32 + left.M34 * right.M42,
                left.M31 * right.M13 + left.M32 * right.M23 + left.M33 * right.M33 + left.M34 * right.M43,
                left.M31 * right.M14 + left.M32 * right.M24 + left.M33 * right.M34 + left.M34 * right.M44,
                left.M41 * right.M11 + left.M42 * right.M21 + left.M43 * right.M31 + left.M44 * right.M41,
                left.M41 * right.M12 + left.M42 * right.M22 + left.M43 * right.M32 + left.M44 * right.M42,
                left.M41 * right.M13 + left.M42 * right.M23 + left.M43 * right.M33 + left.M44 * right.M43,
                left.M41 * right.M14 + left.M42 * right.M24 + left.M43 * right.M34 + left.M44 * right.M44);
        }

        [DllImport ("/usr/lib/system/libsystem_m.dylib", EntryPoint = "__invert_d4")]
        static extern MatrixFloat4x4 __invert_d4 (MatrixFloat4x4 matrix);

        public static MatrixFloat4x4 Transpose (MatrixFloat4x4 mat)
        {
            return new MatrixFloat4x4 (mat.Row0, mat.Row1, mat.Row2, mat.Row3);
        }

        public static void Transpose (ref MatrixFloat4x4 mat, out MatrixFloat4x4 result)
        {
            result.Row0 = mat.Column0;
            result.Row1 = mat.Column1;
            result.Row2 = mat.Column2;
            result.Row3 = mat.Column3;
        }

        public static MatrixFloat4x4 operator * (MatrixFloat4x4 left, MatrixFloat4x4 right)
        {
            return MatrixFloat4x4.Multiply (left, right);
        }

        public static bool operator == (MatrixFloat4x4 left, MatrixFloat4x4 right)
        {
            return left.Equals (right);
        }

        public static bool operator != (Matrix4 left, Matrix4 right)
        {
            return !left.Equals(right);
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
            return Column0.GetHashCode() ^ Column0.GetHashCode() ^ Column0.GetHashCode() ^ Column0.GetHashCode();
        }

        public override bool Equals (object obj)
        {
            if (!(obj is MatrixFloat4x4))
                return false;

            return this.Equals ((MatrixFloat4x4) obj);
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
