using System;
using System.Runtime.InteropServices;

using OpenTK;
using Simd;

#if !__UNIFIED__
using nint=System.Int32;
#endif

namespace Bindings.Test
{
	public static class CFunctions {
		[DllImport ("__Internal")]
		public static extern int theUltimateAnswer ();

		[DllImport ("__Internal")]
		public static extern float test_matrix_float2x2_get_value (ref MatrixFloat2x2 value, int row, int column);

		[DllImport ("__Internal")]
		public static extern float test_matrix_float3x3_get_value (ref MatrixFloat3x3 value, int row, int column);

		[DllImport ("__Internal")]
		public static extern float test_matrix_float4x4_get_value (ref MatrixFloat4x4 value, int row, int column);

		[DllImport ("__Internal")]
		public static extern float test_vector_float2_get_value (ref Vector2 value, int index);

		[DllImport ("__Internal")]
		public static extern float test_vector_float3_get_value (ref Vector3 value, int index);

		[DllImport ("__Internal")]
		public static extern float test_vector_float4_get_value (ref Vector4 value, int index);
	}
}

