//
// Authors:
//     Rolf Bjarne Kvinge <rolf@xamarin.com>
//
// Copyright (c) 2017 Microsoft Inc
//

//
// This represents the native vector_float3 type, which is 16 bytes.
//

using System;
using System.Runtime.InteropServices;

namespace OpenTK
{
	[StructLayout (LayoutKind.Sequential)]
	public struct SimdVector3 : IEquatable<SimdVector3>
	{
		public float X;
		public float Y;
		public float Z;
		float dummy;

		public SimdVector3 (float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
			dummy = 0;
		}

		public static bool operator == (SimdVector3 left, SimdVector3 right)
		{
			return left.Equals (right);
		}

		public static bool operator != (SimdVector3 left, SimdVector3 right)
		{
			return !left.Equals (right);
		}

		public static explicit operator global::OpenTK.Vector3 (SimdVector3 value)
		{
			return new global::OpenTK.Vector3 (value.X, value.Y, value.Z);
		}

		public static explicit operator SimdVector3 (global::OpenTK.Vector3 value)
		{
			return new SimdVector3 (value.X, value.Y, value.Z);
		}

		public override string ToString ()
		{
			return $"({X}, {Y}, {Z})";
		}

		public override int GetHashCode ()
		{
			return X.GetHashCode () ^ Y.GetHashCode () ^ Z.GetHashCode ();
		}

		public override bool Equals (object obj)
		{
			if (!(obj is SimdVector3))
				return false;

			return Equals ((SimdVector3) obj);
		}

		public bool Equals (SimdVector3 other)
		{
			return X == other.X && Y == other.Y && Z == other.Z;
		}
	}
}
