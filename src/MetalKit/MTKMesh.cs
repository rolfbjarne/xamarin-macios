//
// MTKMesh.cs: just so we can implement IMDLMeshBufferAllocator
//

#nullable enable

using ModelIO;
using Metal;
namespace MetalKit {

	public partial class MTKMesh {
		/// <param name="asset">The asset.</param>
		///         <param name="device">The device.</param>
		///         <param name="sourceMeshes">The source meshes.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		///         <summary>Creates and returns a new Metal Kit mesh from the supplied Model IO asset.</summary>
		///         <returns>To be added.</returns>
		public static MTKMesh []? FromAsset (MDLAsset asset, IMTLDevice device, out MDLMesh []? sourceMeshes, out NSError error)
		{
			NSArray aret;

			var ret = FromAsset (asset, device, out aret, out error);
			sourceMeshes = NSArray.FromArray<MDLMesh> (aret);
			return ret;
		}
	}
}
