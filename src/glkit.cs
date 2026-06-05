//
// GLKit.cs: bindings to the iOS5/Lion GLKit
//
// Authors:
//   Miguel de Icaza
//
// Copyright 2011 Xamarin, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Numerics;
using CoreGraphics;
using CoreFoundation;
using ModelIO;

using Matrix3 = global::CoreGraphics.RMatrix3;
using Matrix4 = global::System.Numerics.Matrix4x4;

#if MONOMAC
using pfloat = System.Runtime.InteropServices.NFloat;
using AppKit;
using EAGLSharegroup = Foundation.NSObject;
using EAGLContext = Foundation.NSObject;
using UIView = AppKit.NSView;
using UIImage = AppKit.NSImage;
using UIViewController = AppKit.NSViewController;
#else
using OpenGLES;
using UIKit;
using pfloat = System.Single;
using NSOpenGLContext = Foundation.NSObject;
#endif

namespace GLKit {

	/// <summary>Defines values whose values represent constant values relating to errors.</summary>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[Static]
	interface GLKModelError {

		/// <summary>A value corresponding to the constant <c>kGLKModelErrorDomain</c>.</summary>
		[Field ("kGLKModelErrorDomain")]
		NSString Domain { get; }

		/// <summary>A value corresponding to the constant <c>kGLKModelErrorKey</c>.</summary>
		[Field ("kGLKModelErrorKey")]
		NSString Key { get; }
	}

	/// <summary>A class that provides a variety of shaders based on the OpenGL ES 1.1 lighting and shading model.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKBaseEffect_ClassRef/index.html">Apple documentation for <c>GLKBaseEffect</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (NSObject))]
	interface GLKBaseEffect : GLKNamedEffect {
		/// <summary>Gets or sets whether color material is enabled.</summary>
		[Export ("colorMaterialEnabled", ArgumentSemantic.Assign)]
		bool ColorMaterialEnabled { get; set; }

		/// <summary>Gets or sets whether to use a constant color.</summary>
		[Export ("useConstantColor", ArgumentSemantic.Assign)]
		bool UseConstantColor { get; set; }

		/// <summary>Gets the transform property.</summary>
		[Export ("transform")]
		GLKEffectPropertyTransform Transform { get; }

		/// <summary>Gets the first light property.</summary>
		[Export ("light0")]
		GLKEffectPropertyLight Light0 { get; }

		/// <summary>Gets the second light property.</summary>
		[Export ("light1")]
		GLKEffectPropertyLight Light1 { get; }

		/// <summary>Gets the third light property.</summary>
		[Export ("light2")]
		GLKEffectPropertyLight Light2 { get; }

		[Export ("lightingType", ArgumentSemantic.Assign)]
		GLKLightingType LightingType { get; set; }

		/// <summary>Gets or sets the ambient color for the light model.</summary>
		[Export ("lightModelAmbientColor", ArgumentSemantic.Assign)]
		Vector4 LightModelAmbientColor { [Align (16)] get; set; }

		/// <summary>Gets the material property.</summary>
		[Export ("material")]
		GLKEffectPropertyMaterial Material { get; }

		/// <summary>Gets the first texture property.</summary>
		[Export ("texture2d0")]
		GLKEffectPropertyTexture Texture2d0 { get; }

		/// <summary>Gets the second texture property.</summary>
		[Export ("texture2d1")]
		GLKEffectPropertyTexture Texture2d1 { get; }

		/// <summary>Gets or sets the texture rendering order.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("textureOrder", ArgumentSemantic.Copy)]
		GLKEffectPropertyTexture [] TextureOrder { get; set; }

		/// <summary>Gets or sets the constant color.</summary>
		[Export ("constantColor", ArgumentSemantic.Assign)]
		Vector4 ConstantColor { [Align (16)] get; set; }

		/// <summary>Gets the fog property.</summary>
		[Export ("fog")]
		GLKEffectPropertyFog Fog { get; }

		/// <summary>Gets or sets a label for the effect.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("label", ArgumentSemantic.Copy)]
		[NullAllowed] // default is null on iOS 5.1.1
		string Label { get; set; }

		/// <summary>Gets or sets whether two-sided lighting is enabled.</summary>
		[Export ("lightModelTwoSided", ArgumentSemantic.Assign)]
		bool LightModelTwoSided { get; set; }
	}

	/// <summary>A base class whose subtypes define properties for graphic effects.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKEffectProperty_ClassRef/index.html">Apple documentation for <c>GLKEffectProperty</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (NSObject))]
	interface GLKEffectProperty {
	}

	/// <summary>A class that holds properties that configure how fog is applied to an effect.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKEffectPropertyFog_ClassRef/index.html">Apple documentation for <c>GLKEffectPropertyFog</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (GLKEffectProperty))]
	interface GLKEffectPropertyFog {
		/// <summary>Gets or sets the fog mode.</summary>
		[Export ("mode", ArgumentSemantic.Assign)]
		GLKFogMode Mode { get; set; }

		/// <summary>Gets or sets the fog color.</summary>
		[Export ("color", ArgumentSemantic.Assign)]
		Vector4 Color { [Align (16)] get; set; }

		/// <summary>Gets or sets the fog density.</summary>
		[Export ("density", ArgumentSemantic.Assign)]
		float Density { get; set; } /* GLfloat = float */

		/// <summary>Gets or sets the distance at which fog begins.</summary>
		[Export ("start", ArgumentSemantic.Assign)]
		float Start { get; set; } /* GLfloat = float */

		/// <summary>Gets or sets the distance at which fog is fully opaque.</summary>
		[Export ("end", ArgumentSemantic.Assign)]
		float End { get; set; } /* GLfloat = float */

		/// <summary>Gets or sets whether fog is enabled.</summary>
		[Export ("enabled", ArgumentSemantic.Assign)]
		bool Enabled { get; set; }
	}

	/// <summary>A class that holds properties that configure how a single light is applied to an effect.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKEffectPropertyLight_ClassRef/index.html">Apple documentation for <c>GLKEffectPropertyLight</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (GLKEffectProperty))]
	interface GLKEffectPropertyLight {
		/// <summary>Gets or sets the position of the light.</summary>
		[Export ("position", ArgumentSemantic.Assign)]
		Vector4 Position { [Align (16)] get; set; }

		/// <summary>Gets or sets the ambient color of the light.</summary>
		[Export ("ambientColor", ArgumentSemantic.Assign)]
		Vector4 AmbientColor { [Align (16)] get; set; }

		/// <summary>Gets or sets the diffuse color of the light.</summary>
		[Export ("diffuseColor", ArgumentSemantic.Assign)]
		Vector4 DiffuseColor { [Align (16)] get; set; }

		/// <summary>Gets or sets the specular color of the light.</summary>
		[Export ("specularColor", ArgumentSemantic.Assign)]
		Vector4 SpecularColor { [Align (16)] get; set; }

		/// <summary>Gets or sets the direction the spotlight points.</summary>
		[Export ("spotDirection", ArgumentSemantic.Assign)]
		Vector3 SpotDirection { get; set; }

		/// <summary>Gets or sets the spotlight exponent (focus).</summary>
		[Export ("spotExponent", ArgumentSemantic.Assign)]
		float SpotExponent { get; set; } /* GLfloat = float */

		/// <summary>Gets or sets the spotlight cutoff angle.</summary>
		[Export ("spotCutoff", ArgumentSemantic.Assign)]
		float SpotCutoff { get; set; } /* GLfloat = float */

		/// <summary>Gets or sets the constant attenuation factor.</summary>
		[Export ("constantAttenuation", ArgumentSemantic.Assign)]
		float ConstantAttenuation { get; set; } /* GLfloat = float */

		/// <summary>Gets or sets the linear attenuation factor.</summary>
		[Export ("linearAttenuation", ArgumentSemantic.Assign)]
		float LinearAttenuation { get; set; } /* GLfloat = float */

		/// <summary>Gets or sets the quadratic attenuation factor.</summary>
		[Export ("quadraticAttenuation", ArgumentSemantic.Assign)]
		float QuadraticAttenuation { get; set; } /* GLfloat = float */

		/// <summary>Gets or sets the transform property for the light.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("transform", ArgumentSemantic.Retain)]
		GLKEffectPropertyTransform Transform { get; set; }

		/// <summary>Gets or sets whether the light is enabled.</summary>
		[Export ("enabled", ArgumentSemantic.Assign)]
		bool Enabled { get; set; }

	}

	/// <summary>A class that holds properties that configure the characteristics of a surface being lit.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKEffectPropertyMaterial_ClassRef/index.html">Apple documentation for <c>GLKEffectPropertyMaterial</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (GLKEffectProperty))]
	interface GLKEffectPropertyMaterial {
		/// <summary>Gets or sets the diffuse color of the material.</summary>
		[Export ("diffuseColor", ArgumentSemantic.Assign)]
		Vector4 DiffuseColor { [Align (16)] get; set; }

		/// <summary>Gets or sets the specular color of the material.</summary>
		[Export ("specularColor", ArgumentSemantic.Assign)]
		Vector4 SpecularColor { [Align (16)] get; set; }

		/// <summary>Gets or sets the emissive color of the material.</summary>
		[Export ("emissiveColor", ArgumentSemantic.Assign)]
		Vector4 EmissiveColor { [Align (16)] get; set; }

		/// <summary>Gets or sets the shininess of the material.</summary>
		[Export ("shininess", ArgumentSemantic.Assign)]
		float Shininess { get; set; } /* GLfloat = float */

		/// <summary>Gets or sets the ambient color of the material.</summary>
		[Export ("ambientColor", ArgumentSemantic.Assign)]
		Vector4 AmbientColor { [Align (16)] get; set; }
	}

	/// <summary>A class that holds properties that configure an OpenGL texturing operation.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKEffectPropertyTexture_ClassRef/index.html">Apple documentation for <c>GLKEffectPropertyTexture</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (GLKEffectProperty))]
	interface GLKEffectPropertyTexture {
		[Export ("target", ArgumentSemantic.Assign)]
		GLKTextureTarget Target { get; set; }

		[Export ("envMode", ArgumentSemantic.Assign)]
		GLKTextureEnvMode EnvMode { get; set; }

		/// <summary>Gets or sets whether the texture is enabled.</summary>
		[Export ("enabled", ArgumentSemantic.Assign)]
		bool Enabled { get; set; }

		[Export ("name", ArgumentSemantic.Assign)]
		uint GLName { get; set; } /* GLuint = uint32_t */

	}

	/// <summary>A class that holds properties that configure the coordinate transforms to be applied when rendering an effect.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKEffectPropertyTransform_ClassRef/index.html">Apple documentation for <c>GLKEffectPropertyTransform</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (GLKEffectProperty))]
	interface GLKEffectPropertyTransform {
		/// <summary>Gets the computed normal matrix.</summary>
		[Export ("normalMatrix")]
		Matrix3 NormalMatrix { get; }

		/// <summary>Gets or sets the model-view matrix.</summary>
		[Export ("modelviewMatrix", ArgumentSemantic.Assign)]
		Matrix4 ModelViewMatrix { [Align (16)] get; set; }

		/// <summary>Gets or sets the projection matrix.</summary>
		[Export ("projectionMatrix", ArgumentSemantic.Assign)]
		Matrix4 ProjectionMatrix { [Align (16)] get; set; }
	}

	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/GLKit/GLKMesh">Apple documentation for <c>GLKMesh</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // - (nullable instancetype)init NS_UNAVAILABLE;
	interface GLKMesh {
		/// <param name="mesh">The Model I/O mesh to create the GLKit mesh from.</param>
		/// <param name="error">On return, contains any error that occurred.</param>
		/// <summary>Creates a GLKit mesh from a Model I/O mesh.</summary>
		
		[Export ("initWithMesh:error:")]
		NativeHandle Constructor (MDLMesh mesh, out NSError error);

		// generator does not like `out []` -> https://trello.com/c/sZYNalbB/524-generator-support-out
		[Internal] // there's another, manual, public API exposed
		[Static]
		[Export ("newMeshesFromAsset:sourceMeshes:error:")]
		[return: NullAllowed]
		[return: Release]
		GLKMesh [] FromAsset (MDLAsset asset, [NullAllowed] out NSArray sourceMeshes, [NullAllowed] out NSError error);

		/// <summary>Gets the number of vertices in the mesh.</summary>
		[Export ("vertexCount")]
		nuint VertexCount { get; }

		/// <summary>Gets the vertex buffers for the mesh.</summary>
		[Export ("vertexBuffers")]
		GLKMeshBuffer [] VertexBuffers { get; }

		/// <summary>Gets the vertex descriptor for the mesh.</summary>
		[Export ("vertexDescriptor")]
		MDLVertexDescriptor VertexDescriptor { get; }

		/// <summary>Gets the submeshes for the mesh.</summary>
		[Export ("submeshes")]
		GLKSubmesh [] Submeshes { get; }

		[Export ("name")]
		string Name { get; }
	}

	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/GLKit/GLKMeshBuffer">Apple documentation for <c>GLKMeshBuffer</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface GLKMeshBuffer : MDLMeshBuffer {
		/// <summary>Gets the OpenGL buffer name.</summary>
		[Export ("glBufferName")]
		uint GlBufferName { get; }

		/// <summary>Gets the byte offset into the buffer.</summary>
		[Export ("offset")]
		nuint Offset { get; }
	}

	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/GLKit/GLKMeshBufferAllocator">Apple documentation for <c>GLKMeshBufferAllocator</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface GLKMeshBufferAllocator : MDLMeshBufferAllocator {
	}

	/// <summary>A class that allows pre-drawing initialization for an effect.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKNamedEffect_ProtocolRef/index.html">Apple documentation for <c>GLKNamedEffect</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface GLKNamedEffect {
		/// <summary>Prepares the effect for rendering.</summary>
		[Abstract]
		[Export ("prepareToDraw")]
		void PrepareToDraw ();
	}

	/// <summary>A type of <see cref="GLKit.GLKBaseEffect" /> that has a reflection-mapping texturing stage.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKReflectionEffect_ClassRef/index.html">Apple documentation for <c>GLKReflectionMapEffect</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (GLKBaseEffect))]
	interface GLKReflectionMapEffect : GLKNamedEffect {
		/// <summary>Gets the cube map texture property.</summary>
		[Export ("textureCubeMap")]
		GLKEffectPropertyTexture TextureCubeMap { get; }

		/// <summary>Gets or sets the texture environment matrix.</summary>
		[Export ("matrix", ArgumentSemantic.Assign)]
		Matrix3 Matrix { get; set; }
	}

	/// <summary>A skybox effect.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKSkyboxEffect_ClassRef/index.html">Apple documentation for <c>GLKSkyboxEffect</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (NSObject))]
	interface GLKSkyboxEffect : GLKNamedEffect {
		/// <summary>Gets or sets the center of the skybox.</summary>
		[Export ("center", ArgumentSemantic.Assign)]
		Vector3 Center { get; set; }

		/// <summary>Gets or sets the X dimension of the skybox.</summary>
		[Export ("xSize", ArgumentSemantic.Assign)]
		float XSize { get; set; } /* GLfloat = float */

		/// <summary>Gets or sets the Y dimension of the skybox.</summary>
		[Export ("ySize", ArgumentSemantic.Assign)]
		float YSize { get; set; } /* GLfloat = float */

		/// <summary>Gets or sets the Z dimension of the skybox.</summary>
		[Export ("zSize", ArgumentSemantic.Assign)]
		float ZSize { get; set; } /* GLfloat = float */

		/// <summary>Gets the cube map texture for the skybox.</summary>
		[Export ("textureCubeMap")]
		GLKEffectPropertyTexture TextureCubeMap { get; }

		/// <summary>Gets the transform property for the skybox.</summary>
		[Export ("transform")]
		GLKEffectPropertyTransform Transform { get; }

		/// <summary>Gets or sets a label for the skybox effect.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("label", ArgumentSemantic.Copy)]
		string Label { get; set; }

		/// <summary>Draws the skybox.</summary>
		[Export ("draw")]
		void Draw ();
	}

	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/GLKit/GLKSubmesh">Apple documentation for <c>GLKSubmesh</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // (nullable instancetype)init NS_UNAVAILABLE;
	interface GLKSubmesh {
		// Problematic, OpenTK has this define in 3 namespaces in:
		// OpenTK.Graphics.ES11.DataType
		// OpenTK.Graphics.ES20.DataType
		// OpenTK.Graphics.ES30.DataType
		/// <summary>Gets the OpenGL element type.</summary>
		[Export ("type")]
		uint Type { get; }

		//  Problematic, OpenTK has this define in 3 namespaces in:
		// OpenTK.Graphics.ES11.BeginMode
		// OpenTK.Graphics.ES20.BeginMode
		// OpenTK.Graphics.ES30.BeginMode
		/// <summary>Gets the OpenGL drawing mode.</summary>
		[Export ("mode")]
		uint Mode { get; }

		/// <summary>Gets the number of elements in the submesh.</summary>
		[Export ("elementCount")]
		int ElementCount { get; }

		/// <summary>Gets the element buffer for the submesh.</summary>
		[Export ("elementBuffer")]
		GLKMeshBuffer ElementBuffer { get; }

		/// <summary>Gets the mesh that contains this submesh.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("mesh", ArgumentSemantic.Weak)]
		GLKMesh Mesh { get; }

		[Export ("name")]
		string Name { get; }
	}

	/// <summary>Encapsulates the information relating to a texture.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKTextureInfo_Ref/index.html">Apple documentation for <c>GLKTextureInfo</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (NSObject))]
	interface GLKTextureInfo : NSCopying {
		[Export ("width")]
		int Width { get; } /* GLuint = uint32_t */

		[Export ("height")]
		int Height { get; } /* GLuint = uint32_t */

		[Export ("alphaState")]
		GLKTextureInfoAlphaState AlphaState { get; }

		[Export ("textureOrigin")]
		GLKTextureInfoOrigin TextureOrigin { get; }

		[Export ("containsMipmaps")]
		bool ContainsMipmaps { get; }

		[Export ("name")]
		uint Name { get; } /* GLuint = uint32_t */

		[Export ("target")]
		GLKTextureTarget Target { get; }

		[Export ("mimapLevelCount")]
		uint MimapLevelCount { get; }

		[Export ("arrayLength")]
		uint ArrayLength { get; }

		[Export ("depth")]
		uint Depth { get; }
	}

	/// <param name="textureInfo">The information about the texture loaded, or null on error.</param>
	///     <param name="error">On success, this value is null.   Otherwise it contains the error information.</param>
	///     <summary>Signature used by the asynchrous texture loading methods in <see cref="GLKit.GLKTextureLoader" />.</summary>
	delegate void GLKTextureLoaderCallback ([NullAllowed] GLKTextureInfo textureInfo, [NullAllowed] NSError error);

#if __MACOS__
	/// <include file="../docs/api/GLKit/GLKTextureLoader.xml" path="/Documentation/Docs[@DocId='T:GLKit.GLKTextureLoader' and contains(@Platforms,'macOS')]/*" />
#else
	/// <include file="../docs/api/GLKit/GLKTextureLoader.xml" path="/Documentation/Docs[@DocId='T:GLKit.GLKTextureLoader' and not(@Platforms)]/*" />
#endif
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (NSObject))]
	interface GLKTextureLoader {
		/// <param name="path">File name where the data will be loaded from.</param>
		///         <param name="textureOperations">
		///           <para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">Error result.</param>
		///         <summary>Loads a texture from a file synchronously.</summary>
		///         <returns>On error, this will return null, the details of the error will be stored in the NSError parameter.   Otherwise the instance of the GLKTextureInfo.</returns>
		[Static]
		[Export ("textureWithContentsOfFile:options:error:")]
		[return: NullAllowed]
		GLKTextureInfo FromFile (string path, [NullAllowed] NSDictionary textureOperations, out NSError error);

		/// <param name="url">URL pointing to the texture to load.</param>
		///         <param name="textureOperations">
		///           <para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">Error result.</param>
		///         <summary>Loads a texture from a file pointed to by the url.</summary>
		///         <returns>On error, this will return null, the details of the error will be stored in the NSError parameter.   Otherwise the instance of the GLKTextureInfo.</returns>
		[Static]
		[Export ("textureWithContentsOfURL:options:error:")]
		[return: NullAllowed]
		GLKTextureInfo FromUrl (NSUrl url, [NullAllowed] NSDictionary textureOperations, out NSError error);

		/// <param name="data">NSData object that contains the bitmap that will be loaded into the texture.</param>
		///         <param name="textureOperations">
		///           <para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">Error result.</param>
		///         <summary>Loads a texture from an NSData source.</summary>
		///         <returns>On error, this will return null, the details of the error will be stored in the NSError parameter.   Otherwise the instance of the GLKTextureInfo.</returns>
		[Static]
		[Export ("textureWithContentsOfData:options:error:")]
		[return: NullAllowed]
		GLKTextureInfo FromData (NSData data, [NullAllowed] NSDictionary textureOperations, out NSError error);

		/// <param name="cgImage">CGImage that contains the image to be loaded into the texture.</param>
		///         <param name="textureOperations">
		///           <para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">Error result.</param>
		///         <summary>Loads a texture from a CGImage.</summary>
		///         <returns>On error, this will return null, the details of the error will be stored in the NSError parameter.   Otherwise the instance of the GLKTextureInfo be added.</returns>
		///         <remarks>
		///         </remarks>
		[Static]
		[Export ("textureWithCGImage:options:error:")]
		[return: NullAllowed]
		GLKTextureInfo FromImage (CGImage cgImage, [NullAllowed] NSDictionary textureOperations, out NSError error);

		[Static]
		[Export ("cubeMapWithContentsOfFiles:options:error:"), Internal]
		[return: NullAllowed]
		GLKTextureInfo CubeMapFromFiles (NSArray paths, [NullAllowed] NSDictionary textureOperations, out NSError error);

		/// <param name="path">The file that contains the texture.</param>
		///         <param name="textureOperations">
		///           <para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">Error result.</param>
		///         <summary>Loads a cube map synchronously.</summary>
		///         <returns>On error, this will return null, the details of the error will be stored in the NSError parameter.   Otherwise the instance of the GLKTextureInfo.</returns>
		[Static]
		[Export ("cubeMapWithContentsOfFile:options:error:")]
		[return: NullAllowed]
		GLKTextureInfo CubeMapFromFile (string path, [NullAllowed] NSDictionary textureOperations, out NSError error);

		/// <param name="url">URL pointing to the texture to load.</param>
		///         <param name="textureOperations">
		///           <para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">Error result.</param>
		///         <summary>Loads a cube map synchronously.</summary>
		///         <returns>On error, this will return null, the details of the error will be stored in the NSError parameter.   Otherwise the instance of the GLKTextureInfo.</returns>
		[Static]
		[Export ("cubeMapWithContentsOfURL:options:error:")]
		[return: NullAllowed]
		GLKTextureInfo CubeMapFromUrl (NSUrl url, [NullAllowed] NSDictionary textureOperations, out NSError error);

		/// <param name="name">The name of the texture resource.</param>
		/// <param name="scaleFactor">The scale factor to apply.</param>
		/// <param name="bundle">
		///           <para>The bundle containing the resource.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="options">
		///           <para>The texture loading options.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="outError">On return, contains any error that occurred.</param>
		/// <summary>Loads a texture by name from the specified bundle.</summary>
		/// <returns>The loaded texture info, or <see langword="null" /> on error.</returns>
		
		[Static]
		[Export ("textureWithName:scaleFactor:bundle:options:error:")]
		[return: NullAllowed]
		GLKTextureInfo FromName (string name, nfloat scaleFactor, [NullAllowed] NSBundle bundle, [NullAllowed] NSDictionary<NSString, NSNumber> options, out NSError outError);

		/// <param name="context">The OpenGL context to load textures into.</param>
		/// <summary>Creates a texture loader with the specified OpenGL context.</summary>
		
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Export ("initWithShareContext:")]
		NativeHandle Constructor (NSOpenGLContext context);

		/// <param name="sharegroup">Share context where the textures will be loaded.</param>
		/// <summary>Creates a GLKTextureLoader for an EAGLSharegroup, used for asynchronous texture loading.</summary>
		/// <remarks>
		///         </remarks>
		[NoMac]
		[Export ("initWithSharegroup:")]
		NativeHandle Constructor (EAGLSharegroup sharegroup);

		/// <param name="file">The file that contains the texture.</param>
		///         <param name="textureOperations">
		///           <para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="queue">
		///           <para>The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="onComplete">Callback to invoke when the texture is loaded.   The callback receives a GLKTextureInfo and an NSError.</param>
		///         <summary>Asynchronously loads a texture.</summary>
		///         <remarks>
		///         </remarks>
		[Export ("textureWithContentsOfFile:options:queue:completionHandler:")]
		[Async (XmlDocs = """
			<param name="file">The file that contains the texture.</param>
			<param name="textureOperations">An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.This parameter can be .</param>
			<param name="queue">The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.This parameter can be .</param>
			<summary>Asynchronously loads a texture.</summary>
			<returns>
			          <para>A task that represents the asynchronous BeginTextureLoad operation.   The value of the TResult parameter is a <see cref="GLKit.GLKTextureLoaderCallback" />.</para>
			        </returns>
			<remarks>The returned task contains the loaded texture info.</remarks>
			""")]
		void BeginTextureLoad (string file, [NullAllowed] NSDictionary textureOperations, [NullAllowed] DispatchQueue queue, GLKTextureLoaderCallback onComplete);

		/// <param name="filePath">The file that contains the texture.</param>
		///         <param name="textureOperations">
		///           <para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="queue">
		///           <para>The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="onComplete">Callback to invoke when the texture is loaded.   The callback receives a GLKTextureInfo and an NSError.</param>
		///         <summary>Asynchronously loads a texture.</summary>
		///         <remarks>
		///         </remarks>
		[Export ("textureWithContentsOfURL:options:queue:completionHandler:")]
		[Async (XmlDocs = """
			<param name="filePath">The file that contains the texture.</param>
			<param name="textureOperations">An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.This parameter can be .</param>
			<param name="queue">The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.This parameter can be .</param>
			<summary>Asynchronously loads a texture.</summary>
			<returns>
			          <para>A task that represents the asynchronous BeginTextureLoad operation.   The value of the TResult parameter is a <see cref="GLKit.GLKTextureLoaderCallback" />.</para>
			        </returns>
			<remarks>The returned task contains the loaded texture info.</remarks>
			""")]
		void BeginTextureLoad (NSUrl filePath, [NullAllowed] NSDictionary textureOperations, [NullAllowed] DispatchQueue queue, GLKTextureLoaderCallback onComplete);

		/// <param name="data">NSData object that contains the bitmap that will be loaded into the texture.</param>
		///         <param name="textureOperations">
		///           <para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="queue">
		///           <para>The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="onComplete">Callback to invoke when the texture is loaded.   The callback receives a GLKTextureInfo and an NSError.</param>
		///         <summary>Asynchronously loads a texture.</summary>
		///         <remarks>
		///         </remarks>
		[Export ("textureWithContentsOfData:options:queue:completionHandler:")]
		[Async (XmlDocs = """
			<param name="data">NSData object that contains the bitmap that will be loaded into the texture.</param>
			<param name="textureOperations">An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.This parameter can be .</param>
			<param name="queue">The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.This parameter can be .</param>
			<summary>Asynchronously loads a texture.</summary>
			<returns>
			          <para>A task that represents the asynchronous BeginTextureLoad operation.   The value of the TResult parameter is a <see cref="GLKit.GLKTextureLoaderCallback" />.</para>
			        </returns>
			<remarks>The returned task contains the loaded texture info.</remarks>
			""")]
		void BeginTextureLoad (NSData data, [NullAllowed] NSDictionary textureOperations, [NullAllowed] DispatchQueue queue, GLKTextureLoaderCallback onComplete);

		/// <param name="image">CGImage that contains the image to be loaded into the texture.</param>
		///         <param name="textureOperations">
		///           <para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="queue">
		///           <para>The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="onComplete">Callback to invoke when the texture is loaded.   The callback receives a GLKTextureInfo and an NSError.</param>
		///         <summary>Asynchronously loads a texture.</summary>
		///         <remarks>
		///         </remarks>
		[Export ("textureWithCGImage:options:queue:completionHandler:")]
		[Async (XmlDocs = """
			<param name="image">CGImage that contains the image to be loaded into the texture.</param>
			<param name="textureOperations">An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.This parameter can be .</param>
			<param name="queue">The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.This parameter can be .</param>
			<summary>Asynchronously loads a texture.</summary>
			<returns>
			          <para>A task that represents the asynchronous BeginTextureLoad operation.   The value of the TResult parameter is a <see cref="GLKit.GLKTextureLoaderCallback" />.</para>
			        </returns>
			<remarks>The returned task contains the loaded texture info.</remarks>
			""")]
		void BeginTextureLoad (CGImage image, [NullAllowed] NSDictionary textureOperations, [NullAllowed] DispatchQueue queue, GLKTextureLoaderCallback onComplete);

		[Export ("cubeMapWithContentsOfFiles:options:queue:completionHandler:"), Internal]
		[Async]
		void BeginLoadCubeMap (NSArray filePaths, [NullAllowed] NSDictionary textureOperations, [NullAllowed] DispatchQueue queue, GLKTextureLoaderCallback onComplete);

		/// <param name="fileName">File name where the data will be loaded from.</param>
		///         <param name="textureOperations">
		///           <para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="queue">
		///           <para>The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="onComplete">Callback to invoke when the texture is loaded.   The callback receives a GLKTextureInfo and an NSError.</param>
		///         <summary>Asynchronously loads a cube map.</summary>
		///         <remarks>
		///         </remarks>
		[Export ("cubeMapWithContentsOfFile:options:queue:completionHandler:")]
		[Async (XmlDocs = """
			<param name="fileName">File name where the data will be loaded from.</param>
			<param name="textureOperations">An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.This parameter can be .</param>
			<param name="queue">The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.This parameter can be .</param>
			<summary>Asynchronously loads a cube map.</summary>
			<returns>
			          <para>A task that represents the asynchronous BeginLoadCubeMap operation.   The value of the TResult parameter is a <see cref="GLKit.GLKTextureLoaderCallback" />.</para>
			        </returns>
			<remarks>The returned task contains the loaded cube map texture info.</remarks>
			""")]
		void BeginLoadCubeMap (string fileName, [NullAllowed] NSDictionary textureOperations, [NullAllowed] DispatchQueue queue, GLKTextureLoaderCallback onComplete);

		/// <param name="filePath">The file that contains the texture.</param>
		///         <param name="textureOperations">
		///           <para>An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="queue">
		///           <para>The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="onComplete">Callback to invoke when the texture is loaded.   The callback receives a GLKTextureInfo and an NSError.</param>
		///         <summary>Asynchronously loads a cube map.</summary>
		///         <remarks>
		///         </remarks>
		[Export ("cubeMapWithContentsOfURL:options:queue:completionHandler:")]
		[Async (XmlDocs = """
			<param name="filePath">The file that contains the texture.</param>
			<param name="textureOperations">An NSDictionary populated with configuration options.   Alternatively, use the strongly-typed version of this method that takes a GLKTextureOperations object.This parameter can be .</param>
			<param name="queue">The queue on which the callback method will be invoked, or null to invoke the method on the main dispatch queue.This parameter can be .</param>
			<summary>Asynchronously loads a cube map.</summary>
			<returns>
			          <para>A task that represents the asynchronous BeginLoadCubeMap operation.   The value of the TResult parameter is a <see cref="GLKit.GLKTextureLoaderCallback" />.</para>
			        </returns>
			<remarks>The returned task contains the loaded cube map texture info.</remarks>
			""")]
		void BeginLoadCubeMap (NSUrl filePath, [NullAllowed] NSDictionary textureOperations, [NullAllowed] DispatchQueue queue, GLKTextureLoaderCallback onComplete);

		/// <param name="name">The name of the texture resource.</param>
		/// <param name="scaleFactor">The scale factor to apply.</param>
		/// <param name="bundle">
		///           <para>The bundle containing the resource.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="options">
		///           <para>The texture loading options.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="queue">
		///           <para>The dispatch queue for the completion handler.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="block">The completion handler to invoke when loading completes.</param>
		/// <summary>Asynchronously loads a texture by name from the specified bundle.</summary>
		
		[Export ("textureWithName:scaleFactor:bundle:options:queue:completionHandler:")]
		[Async (XmlDocs = """
			<param name="name">The name of the texture resource.</param>
			<param name="scaleFactor">The scale factor to apply.</param>
			<param name="bundle">The bundle containing the resource.</param>
			<param name="options">The texture loading options.</param>
			<param name="queue">The dispatch queue for the completion handler.</param>
			<summary>Asynchronously loads a texture by name from the specified bundle.</summary>
			<returns>
			          <para>A task that represents the asynchronous BeginTextureLoad operation.   The value of the TResult parameter is a <see cref="GLKit.GLKTextureLoaderCallback" />.</para>
			        </returns>
			<remarks>
			          <para copied="true">The BeginTextureLoadAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>The BeginTextureLoadAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			        </remarks>
			""")]
		void BeginTextureLoad (string name, nfloat scaleFactor, [NullAllowed] NSBundle bundle, [NullAllowed] NSDictionary<NSString, NSNumber> options, [NullAllowed] DispatchQueue queue, GLKTextureLoaderCallback block);

		/// <summary>Represents the value associated with the constant GLKTextureLoaderApplyPremultiplication</summary>
		///         <value>
		///         </value>
		///         <remarks>Used as a key for textureOperations if you are using the NSDictionary overloads instead of the strongly typed GLKTextureOperations class.</remarks>
		[Field ("GLKTextureLoaderApplyPremultiplication")]
		NSString ApplyPremultiplication { get; }

		/// <summary>Represents the value associated with the constant GLKTextureLoaderGenerateMipmaps</summary>
		///         <value>
		///         </value>
		///         <remarks>Used as a key for textureOperations if you are using the NSDictionary overloads instead of the strongly typed GLKTextureOperations class.</remarks>
		[Field ("GLKTextureLoaderGenerateMipmaps")]
		NSString GenerateMipmaps { get; }

		/// <summary>Represents the value associated with the constant GLKTextureLoaderOriginBottomLeft</summary>
		///         <value>
		///         </value>
		///         <remarks>Used as a key for textureOperations if you are using the NSDictionary overloads instead of the strongly typed GLKTextureOperations class.</remarks>
		[Field ("GLKTextureLoaderOriginBottomLeft")]
		NSString OriginBottomLeft { get; }

		/// <summary>Represents the value associated with the constant GLKTextureLoaderGrayscaleAsAlpha</summary>
		///         <value>
		///         </value>
		///         <remarks>Used as a key for textureOperations if you are using the NSDictionary overloads instead of the strongly typed GLKTextureOperations class.</remarks>
		[Field ("GLKTextureLoaderGrayscaleAsAlpha")]
		NSString GrayscaleAsAlpha { get; }

		/// <summary>Represents the value associated with the constant GLKTextureLoaderSRGB</summary>
		///         <value>
		///         </value>
		[Field ("GLKTextureLoaderSRGB")]
		NSString SRGB { get; }

		/// <summary>Represents the value associated with the constant GLKTextureLoaderErrorDomain</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("GLKTextureLoaderErrorDomain")]
		NSString ErrorDomain { get; }

		/// <summary>Represents the value associated with the constant GLKTextureLoaderErrorKey</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("GLKTextureLoaderErrorKey")]
		NSString ErrorKey { get; }

		/// <summary>Represents the value associated with the constant GLKTextureLoaderGLErrorKey</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Field ("GLKTextureLoaderGLErrorKey")]
		NSString GLErrorKey { get; }
	}

	/// <summary>A <see cref="UIKit.UIView" /> that supports OpenGL ES rendering.</summary>
	///     
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKView_ClassReference/index.html">Apple documentation for <c>GLKView</c></related>
	[NoMac]
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[BaseType (typeof (UIView), Delegates = new string [] { "WeakDelegate" }, Events = new Type [] { typeof (GLKViewDelegate) })]
	interface GLKView {
		/// <param name="frame">Frame used by the view, expressed in iOS points.</param>
		/// <summary>Initializes the GLKView with the specified frame.</summary>
		/// <remarks>
		///           <para>This constructor is used to programmatically create a new instance of GLKView with the specified dimension in the frame.   The object will only be displayed once it has been added to a view hierarchy by calling AddSubview in a containing view.</para>
		///           <para>This constructor is not invoked when deserializing objects from storyboards or XIB files; instead, the constructor that takes an NSCoder parameter is invoked.</para>
		///         </remarks>
		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frame);

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the GLKit.IGLKViewDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the GLKit.IGLKViewDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		IGLKViewDelegate Delegate { get; set; }

		/// <summary>Gets or sets the EAGLContext used for rendering.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("context", ArgumentSemantic.Retain)]
		EAGLContext Context { get; set; }

		/// <summary>Gets the width of the drawable area in pixels.</summary>
		[Export ("drawableWidth")]
		nint DrawableWidth { get; }

		/// <summary>Gets the height of the drawable area in pixels.</summary>
		[Export ("drawableHeight")]
		nint DrawableHeight { get; }

		/// <summary>Gets or sets the color format of the drawable.</summary>
		[Export ("drawableColorFormat")]
		GLKViewDrawableColorFormat DrawableColorFormat { get; set; }

		/// <summary>Gets or sets the depth format of the drawable.</summary>
		[Export ("drawableDepthFormat")]
		GLKViewDrawableDepthFormat DrawableDepthFormat { get; set; }

		/// <summary>Gets or sets the stencil format of the drawable.</summary>
		[Export ("drawableStencilFormat")]
		GLKViewDrawableStencilFormat DrawableStencilFormat { get; set; }

		/// <summary>Gets or sets the multisample mode of the drawable.</summary>
		[Export ("drawableMultisample")]
		GLKViewDrawableMultisample DrawableMultisample { get; set; }

		/// <summary>Gets or sets whether setNeedsDisplay is enabled.</summary>
		[Export ("enableSetNeedsDisplay")]
		bool EnableSetNeedsDisplay { get; set; }

		/// <param name="frame">The frame rectangle for the view.</param>
		/// <param name="context">The EAGLContext to use for rendering.</param>
		/// <summary>Creates a GLKit view with the specified frame and context.</summary>
		
		[Export ("initWithFrame:context:")]
		NativeHandle Constructor (CGRect frame, EAGLContext context);

		/// <summary>Binds the drawable framebuffer for rendering.</summary>
		[Export ("bindDrawable")]
		void BindDrawable ();

		/// <summary>Takes a snapshot of the current rendering.</summary>
		/// <returns>A UIImage containing the rendered content.</returns>
		[Export ("snapshot")]
		UIImage Snapshot ();

		/// <summary>Redraws the view contents immediately.</summary>
		[Export ("display")]
		void Display ();

		/// <summary>Deletes the drawable objects associated with the view.</summary>
		[Export ("deleteDrawable")]
		void DeleteDrawable ();
	}

	interface IGLKViewDelegate { }

	/// <summary>A class that acts like a delegate object for instances of <see cref="GLKit.GLKView" />.</summary>
	///     <remarks>
	///       <para>The specific use-case supported by this class is to customize the <see cref="GLKit.IGLKViewDelegate.DrawInRect(GLKit.GLKView,CoreGraphics.CGRect)" /> method without subclassing <see cref="GLKit.GLKView" />.</para>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKViewDelegate_ProtocolRef/index.html">Apple documentation for <c>GLKViewDelegate</c></related>
	[NoMac]
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface GLKViewDelegate {
		/// <param name="view">The GLKit view requesting the draw.</param>
		/// <param name="rect">The rectangle to draw into.</param>
		/// <summary>Called when the view needs to be drawn.</summary>
		
		[Abstract]
		[Export ("glkView:drawInRect:"), EventArgs ("GLKViewDraw", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void DrawInRect (GLKView view, CGRect rect);
	}

	/// <include file="../docs/api/GLKit/GLKViewController.xml" path="/Documentation/Docs[@DocId='T:GLKit.GLKViewController']/*" />
	[NoMac]
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[BaseType (typeof (UIViewController))]
	interface GLKViewController : GLKViewDelegate {
		/// <param name="nibName">
		///           <para>The nib name to load.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="bundle">
		///           <para>The bundle containing the nib.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new <see cref="GLKit.GLKViewController" /> from the specified Nib name in the specified <paramref name="bundle" />.</summary>
		/// <remarks>Loads the view controller from a nib file.</remarks>
		[Export ("initWithNibName:bundle:")]
		[PostGet ("NibBundle")]
		NativeHandle Constructor ([NullAllowed] string nibName, [NullAllowed] NSBundle bundle);

		/// <summary>The desired number of frames per second.   Controls the frequency that your Update and Draw methods will be called.</summary>
		[Export ("preferredFramesPerSecond")]
		nint PreferredFramesPerSecond { get; set; }

		/// <summary>The actual frames per second that your application is getting.</summary>
		[Export ("framesPerSecond")]
		nint FramesPerSecond { get; }

		/// <summary>When paused, the Update and Draw methods are not invoked.</summary>
		[Export ("paused")]
		bool Paused { [Bind ("isPaused")] get; set; }

		/// <summary>Cumulative count of frames displayed.</summary>
		[Export ("framesDisplayed")]
		nint FramesDisplayed { get; }

		/// <summary>Gets the time interval, in seconds, since the view controller first resumed sending updates.</summary>
		[Export ("timeSinceFirstResume")]
		double TimeSinceFirstResume { get; }

		/// <summary>Gets the time interval, in seconds, since the view controller most recently resumed sending updates.</summary>
		[Export ("timeSinceLastResume")]
		double TimeSinceLastResume { get; }

		[Export ("timeSinceLastUpdate")]
		double TimeSinceLastUpdate { get; }

		[Export ("timeSinceLastDraw")]
		double TimeSinceLastDraw { get; }

		/// <summary>Gets or sets a Boolean value that controls whether the rendering loop will pause when the application resigns from the active state.</summary>
		[Export ("pauseOnWillResignActive")]
		bool PauseOnWillResignActive { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the rendering loop will resume when the application enters the active state.</summary>
		[Export ("resumeOnDidBecomeActive")]
		bool ResumeOnDidBecomeActive { get; set; }

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the GLKit.IGLKViewControllerDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the GLKit.IGLKViewControllerDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		IGLKViewControllerDelegate Delegate { get; set; }

		// Pseudo-documented, if the user overrides it, call this instead of the delegate method
		/// <include file="../docs/api/GLKit/GLKViewController.xml" path="/Documentation/Docs[@DocId='M:GLKit.GLKViewController.Update']/*" />
		[Export ("update")]
		void Update ();
	}

	interface IGLKViewControllerDelegate { }

	/// <summary>A delegate object that gives the application developer fine-grained control over events relating to the life-cycle of a <see cref="GLKit.GLKViewController" /> object.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKViewControllerDelegate_ProtocolRef/index.html">Apple documentation for <c>GLKViewControllerDelegate</c></related>
	[NoMac]
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface GLKViewControllerDelegate {
		/// <param name="controller">The view controller requesting the update.</param>
		/// <summary>Called before each frame is rendered.</summary>
		
		[Abstract]
		[Export ("glkViewControllerUpdate:")]
		void Update (GLKViewController controller);

		/// <param name="controller">The view controller whose pause state changed.</param>
		/// <param name="pause">Whether the controller is pausing or resuming.</param>
		/// <summary>Called when the rendering loop is paused or resumed.</summary>
		
		[Export ("glkViewController:willPause:")]
		void WillPause (GLKViewController controller, bool pause);
	}
}
