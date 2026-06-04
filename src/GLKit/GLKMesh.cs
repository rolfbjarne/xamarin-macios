// Copyright 2015 Xamarin Inc.

using ModelIO;

#nullable enable

namespace GLKit {

	public partial class GLKMesh {
		/// <param name="asset">The asset.</param>
		///         <param name="sourceMeshes">The source meshes.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		public static GLKMesh []? FromAsset (MDLAsset asset, out MDLMesh []? sourceMeshes, out NSError? error)
		{
			var ret = FromAsset (asset, out NSArray? aret, out error);
			sourceMeshes = NSArray.FromArray<MDLMesh> (aret);
			return ret;
		}
	}
}
