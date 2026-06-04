//
// SCNGeometrySource.cs: extensions to provide an array-based API that
// we pass as pointers
//
// Authors:
//   MIguel de Icaza (miguel@xamarin.com)
//
// Copyright Xamarin Inc
//

using CoreGraphics;
using Metal;

#nullable enable

namespace SceneKit {
	public partial class SCNGeometrySource {

		/// <param name="vertices">The vertices.</param>
		///         <summary>Factory method to create a source for vertex data.</summary>
		public static unsafe SCNGeometrySource FromVertices (SCNVector3 [] vertices)
		{
			if (vertices is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (vertices));

			fixed (SCNVector3* ptr = vertices)
				return FromVertices ((IntPtr) ptr, vertices.Length);
		}

		/// <param name="normals">The normals.</param>
		///         <summary>Factory method that creates a source for vertex normals.</summary>
		///         <remarks>
		///           <para>The <paramref name="normals" /> must correspond directly to their associated vertices (in another <see cref="SceneKit.SCNGeometrySource" />).</para>
		///         </remarks>
		public static unsafe SCNGeometrySource FromNormals (SCNVector3 [] normals)
		{
			if (normals is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (normals));

			fixed (SCNVector3* ptr = normals)
				return FromNormals ((IntPtr) ptr, normals.Length);
		}

		/// <param name="texcoords">The texcoords.</param>
		///         <summary>Factory method that creates a source for texture coordinates.</summary>
		///         <remarks>
		///           <para>The <paramref name="texcoords" /> must correspond directly to their associated vertices (in another <see cref="SceneKit.SCNGeometrySource" />).</para>
		///           <para>For non-tiling textures, texture coordinates are values between 0 and 1 that describe the mapping between a texture location and a geometry location. A value of [0,0] represents the origin of the texture while [1,1] represents the point at its furthest extent.</para>
		///         </remarks>
		public static unsafe SCNGeometrySource FromTextureCoordinates (CGPoint [] texcoords)
		{
			if (texcoords is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (texcoords));

			fixed (CGPoint* ptr = texcoords)
				return FromTextureCoordinates ((IntPtr) ptr, texcoords.Length);
		}

		static NSString SemanticToToken (SCNGeometrySourceSemantics geometrySourceSemantic)
		{
			switch (geometrySourceSemantic) {
			case SCNGeometrySourceSemantics.Vertex:
				return SCNGeometrySourceSemantic.Vertex;
			case SCNGeometrySourceSemantics.Normal:
				return SCNGeometrySourceSemantic.Normal;
			case SCNGeometrySourceSemantics.Color:
				return SCNGeometrySourceSemantic.Color;
			case SCNGeometrySourceSemantics.Texcoord:
				return SCNGeometrySourceSemantic.Texcoord;
			case SCNGeometrySourceSemantics.VertexCrease:
				return SCNGeometrySourceSemantic.VertexCrease;
			case SCNGeometrySourceSemantics.EdgeCrease:
				return SCNGeometrySourceSemantic.EdgeCrease;
			case SCNGeometrySourceSemantics.BoneWeights:
				return SCNGeometrySourceSemantic.BoneWeights;
			case SCNGeometrySourceSemantics.BoneIndices:
				return SCNGeometrySourceSemantic.BoneIndices;
			default:
				throw new System.ArgumentException ("geometrySourceSemantic");
			}
		}

		/// <param name="data">The data.</param>
		/// <param name="semantic">The semantic.</param>
		/// <param name="vectorCount">The vector count.</param>
		/// <param name="floatComponents">The float components.</param>
		/// <param name="componentsPerVector">The components per vector.</param>
		/// <param name="bytesPerComponent">The bytes per component.</param>
		/// <param name="offset">The offset.</param>
		/// <param name="stride">The stride.</param>
		/// <summary>FromData.</summary>
		public static SCNGeometrySource FromData (NSData data, SCNGeometrySourceSemantics semantic, nint vectorCount, bool floatComponents, nint componentsPerVector, nint bytesPerComponent, nint offset, nint stride)
		{
			return FromData (data, SemanticToToken (semantic), vectorCount, floatComponents, componentsPerVector, bytesPerComponent, offset, stride);
		}

		/// <param name="mtlBuffer">The mtl buffer.</param>
		/// <param name="vertexFormat">The vertex format.</param>
		/// <param name="semantic">The semantic.</param>
		/// <param name="vertexCount">The vertex count.</param>
		/// <param name="offset">The offset.</param>
		/// <param name="stride">The stride.</param>
		/// <summary>Factory method to create a new <see cref="SceneKit.SCNGeometrySource" /> from a data buffer.</summary>
		public static SCNGeometrySource FromMetalBuffer (IMTLBuffer mtlBuffer, MTLVertexFormat vertexFormat, SCNGeometrySourceSemantics semantic, nint vertexCount, nint offset, nint stride)
		{
			return FromMetalBuffer (mtlBuffer, vertexFormat, SemanticToToken (semantic), vertexCount, offset, stride);
		}
	}

}
