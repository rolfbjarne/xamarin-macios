#if XAMCORE_2_0 && !XAMCORE_4_0
using Simd;

namespace XamCore.ModelIO {
	public partial class MDLTransformComponent_Extensions {
		public static MatrixFloat4x4 GetMatrix4x4 (this IMDLTransformComponent self)
		{
			return (MatrixFloat4x4) self.Matrix;
		}
	}
}
#endif