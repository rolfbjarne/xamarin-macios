//
// GLKit/Defs.cs: basic definitions for GLKit
//
// Authors:
//   Miguel de Icaza
//
// Copyright 2011-2014 Xamarin, Inc.
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

using ModelIO;

#nullable enable

namespace GLKit {

	// GLint (32 bits on 64 bit hardware) -> GLKEffects.h
	/// <summary>An enumeration whose values specify various components of a vertex.</summary>
	public enum GLKVertexAttrib {
		/// <summary>Indicates position.</summary>
		Position,
		/// <summary>Indicates normal.</summary>
		Normal,
		/// <summary>Indicates color.</summary>
		Color,
		/// <summary>Indicates tex coord0.</summary>
		TexCoord0,
		/// <summary>Indicates tex coord1.</summary>
		TexCoord1,
	}

	// GLint (32 bits on 64 bit hardware) -> GLKEffectPropertyLight.h
	/// <summary>An enumeration whose values specify how lighting is calculated by an effect.</summary>
	public enum GLKLightingType {
		/// <summary>Indicates per vertex.</summary>
		PerVertex,
		/// <summary>Indicates per pixel.</summary>
		PerPixel,
	}

	// GLint (32 bits on 64 bit hardware) -> GLKEffectPropertyTexture.h
	/// <summary>An enumeration of ways in which texture can be combined with other color components.</summary>
	public enum GLKTextureEnvMode {
		/// <summary>Indicates replace.</summary>
		Replace,
		/// <summary>Indicates modulate.</summary>
		Modulate,
		/// <summary>Indicates decal.</summary>
		Decal,
	}

	// GLenum (32 bits on 64 bit hardware) -> GLKEffectPropertyTexture.h
	/// <summary>An enumeration whose values specify different kinds of texture.</summary>
	public enum GLKTextureTarget {
		/// <summary>Indicates texture2 d.</summary>
		Texture2D = 0x0DE1,    // GL_TEXTURE_2D
		/// <summary>Indicates cube map.</summary>
		CubeMap = 0x8513, // GL_TEXTURE_CUBE_MAP
		/// <summary>Indicates target ct.</summary>
		TargetCt = 2,
	}

	// GLint (32 bits on 64 bit hardware) -> GLKEffectPropertyFog.h
	/// <summary>An enumeration whose values specify different types of fog effect.</summary>
	///     <remarks>In all cases, the fog calculation is clamped to the range 0..1.</remarks>
	public enum GLKFogMode {
		/// <summary>The fog is calculated using Math.Exp(-density * distance).</summary>
		Exp = 0,
		/// <summary>The fog is calculated using Math.Exp(-(density * distance) ^2).</summary>
		Exp2,
		/// <summary>The fog is calculated using (end - distance) / (end - start).</summary>
		Linear,
	}

	// GLint (32 bits on 64 bit hardware) -> GLKView.h
	/// <summary>An enumeration whose values specify the format of the color renderbuffer.</summary>
	public enum GLKViewDrawableColorFormat {
		/// <summary>Indicates RGB a8888.</summary>
		RGBA8888 = 0,
		/// <summary>Indicates RG b565.</summary>
		RGB565,
		/// <summary>Indicates SRGB a8888.</summary>
		SRGBA8888,
	}

	// GLint (32 bits on 64 bit hardware) -> GLKView.h
	/// <summary>An enumeration whose values specify the format of the depth renderbuffer.</summary>
	public enum GLKViewDrawableDepthFormat {
		/// <summary>Indicates none.</summary>
		None,
		/// <summary>Indicates format16.</summary>
		Format16,
		/// <summary>Indicates format24.</summary>
		Format24,
	}

	// GLint (32 bits on 64 bit hardware) -> GLKView.h
	/// <summary>An enumeration whose values specify the format of the stencil renderbuffer.</summary>
	public enum GLKViewDrawableStencilFormat {
		/// <summary>Indicates format none.</summary>
		FormatNone,
		/// <summary>Indicates format8.</summary>
		Format8,
	}

	// GLint (32 bits on 64 bit hardware) -> GLKView.h
	/// <summary>An enumeration whose values specify the format of the multisampling buffer.</summary>
	public enum GLKViewDrawableMultisample {
		/// <summary>Indicates none.</summary>
		None,
		/// <summary>Indicates sample4x.</summary>
		Sample4x,
	}

	// GLint (32 bits on 64 bit hardware) -> GLKTextureLoader.h
	/// <summary>An enumeration whose values specify the manner in which the alpha information is stored in the source image.</summary>
	public enum GLKTextureInfoAlphaState {
		/// <summary>Indicates none.</summary>
		None,
		/// <summary>Indicates non premultiplied.</summary>
		NonPremultiplied,
		/// <summary>Indicates premultiplied.</summary>
		Premultiplied,
	}

	// GLint (32 bits on 64 bit hardware) -> GLKTextureLoader.h
	/// <summary>An enumeration whose values specify the origin in the original source image.</summary>
	public enum GLKTextureInfoOrigin {
		/// <summary>Indicates unknown.</summary>
		Unknown = 0,
		/// <summary>Indicates top left.</summary>
		TopLeft,
		/// <summary>Indicates bottom left.</summary>
		BottomLeft,
	}

	// GLuint (we'll keep `int` for compatibility) -> GLKTextureLoader.h
	/// <summary>An enumeration whose values specify errors relating to texture loading.</summary>
	public enum GLKTextureLoaderError {
		/// <summary>Indicates file or u r l not found.</summary>
		FileOrURLNotFound = 0,
		/// <summary>Indicates invalid n s data.</summary>
		InvalidNSData = 1,
		/// <summary>Indicates invalid c g image.</summary>
		InvalidCGImage = 2,
		/// <summary>Indicates unknown path type.</summary>
		UnknownPathType = 3,
		/// <summary>Indicates unknown file type.</summary>
		UnknownFileType = 4,
		/// <summary>Indicates PVR atlas unsupported.</summary>
		PVRAtlasUnsupported = 5,
		/// <summary>Indicates cube map invalid num files.</summary>
		CubeMapInvalidNumFiles = 6,
		/// <summary>Indicates compressed texture upload.</summary>
		CompressedTextureUpload = 7,
		/// <summary>Indicates uncompressed texture upload.</summary>
		UncompressedTextureUpload = 8,
		/// <summary>Indicates unsupported cube map dimensions.</summary>
		UnsupportedCubeMapDimensions = 9,
		/// <summary>Indicates unsupported bit depth.</summary>
		UnsupportedBitDepth = 10,
		/// <summary>Indicates unsupported p v r format.</summary>
		UnsupportedPVRFormat = 11,
		/// <summary>Indicates data preprocessing failure.</summary>
		DataPreprocessingFailure = 12,
		/// <summary>Indicates mipmap unsupported.</summary>
		MipmapUnsupported = 13,
		/// <summary>Indicates unsupported orientation.</summary>
		UnsupportedOrientation = 14,
		/// <summary>Indicates reorientation failure.</summary>
		ReorientationFailure = 15,
		/// <summary>Indicates alpha premultiplication failure.</summary>
		AlphaPremultiplicationFailure = 16,
		/// <summary>Indicates invalid e a g l context.</summary>
		InvalidEAGLContext = 17,
		/// <summary>Indicates incompatible format s r g b.</summary>
		IncompatibleFormatSRGB = 18,
		/// <summary>Indicates unsupported texture target.</summary>
		UnsupportedTextureTarget = 19,
	}

	// glVertexAttribPointer structure values, again, problems with definitions being in different namespaces
	/// <summary>To be added.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("tvos12.0", "Use 'Metal' instead.")]
	[ObsoletedOSPlatform ("macos10.14", "Use 'Metal' instead.")]
	[ObsoletedOSPlatform ("ios12.0", "Use 'Metal' instead.")]
	[StructLayout (LayoutKind.Sequential)]
	public struct GLKVertexAttributeParameters {
		/// <summary>To be added.</summary>
		public uint Type;
		/// <summary>To be added.</summary>
		public uint Size;
#if XAMCORE_5_0
		byte normalized;
		public bool Normalized {
			get => normalized != 0;
			set => normalized = value.AsByte ();
		}
#else
		/// <summary>To be added.</summary>
		[MarshalAs (UnmanagedType.I1)]
		public bool Normalized;
#endif

#if !COREBUILD
		[DllImport (Constants.GLKitLibrary, EntryPoint = "GLKVertexAttributeParametersFromModelIO")]
#if XAMCORE_5_0
		extern static GLKVertexAttributeParameters FromVertexFormat_ (nuint vertexFormat);
#else
		extern static GLKVertexAttributeParametersInternal FromVertexFormat_ (nuint vertexFormat);
#endif

		/// <param name="vertexFormat">The vertex format.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		public static GLKVertexAttributeParameters FromVertexFormat (MDLVertexFormat vertexFormat)
		{
#if XAMCORE_5_0
			return FromVertexFormat_ ((nuint) (ulong) vertexFormat);
#else
			var tmp = FromVertexFormat_ ((nuint) (ulong) vertexFormat);
			var rv = new GLKVertexAttributeParameters ();
			rv.Type = tmp.Type;
			rv.Size = tmp.Size;
			rv.Normalized = tmp.Normalized != 0;
			return rv;
#endif
		}
#endif
	}

#if !XAMCORE_5_0
	[StructLayout (LayoutKind.Sequential)]
	struct GLKVertexAttributeParametersInternal {
		public uint Type;
		public uint Size;
		public byte Normalized;
	}
#endif // !XAMCORE_5_0
}
