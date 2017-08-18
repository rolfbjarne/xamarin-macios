#if XAMCORE_2_0 && !XAMCORE_4_0
using OpenTK;
using Simd;

namespace XamCore.ModelIO {
	public partial class MDLTransformComponent_Extensions {
		public static MatrixFloat4x4 GetMatrix4x4 (this IMDLTransformComponent self)
		{
			return (MatrixFloat4x4) self.Matrix;
		}

		public static void SetMatrix4x4 (this IMDLTransformComponent self, MatrixFloat4x4 value)
		{
			self.Matrix = (Matrix4) value;
		}

		public static void SetLocalTransform (this IMDLTransformComponent This, MatrixFloat4x4 transform, double time)
		{
			SetLocalTransform (This, (Matrix4) transform, time);
		}

		public static void SetLocalTransform (this IMDLTransformComponent This, MatrixFloat4x4 transform)
		{
			SetLocalTransform (This, (Matrix4) transform);
		}

		public static MatrixFloat4x4 GetLocalTransform4x4 (this IMDLTransformComponent This, double atTime)
		{
			return (MatrixFloat4x4) GetLocalTransform (This, atTime);
		}
	}
}
#endif