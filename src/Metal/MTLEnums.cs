//
// API for the Metal framework
//
// Authors:
//   Miguel de Icaza
//
// Copyrigh 2014, Xamarin Inc.
//
using System.ComponentModel;
using CoreFoundation;
using ModelIO;

#nullable enable

namespace Metal {

	/// <summary>Argument values for use with <see cref="Metal.MTLBlendOperation" />.</summary>
	[Native]
	public enum MTLBlendFactor : ulong {
		/// <summary>Zero.</summary>
		Zero = 0,
		/// <summary>One.</summary>
		One = 1,
		/// <summary>Source Color.</summary>
		SourceColor = 2,
		/// <summary>One Minus Source Color.</summary>
		OneMinusSourceColor = 3,
		/// <summary>Source Alpha.</summary>
		SourceAlpha = 4,
		/// <summary>One Minus Source Alpha.</summary>
		OneMinusSourceAlpha = 5,
		/// <summary>Destination Color.</summary>
		DestinationColor = 6,
		/// <summary>One Minus Destination Color.</summary>
		OneMinusDestinationColor = 7,
		/// <summary>Destination Alpha.</summary>
		DestinationAlpha = 8,
		/// <summary>One Minus Destination Alpha.</summary>
		OneMinusDestinationAlpha = 9,
		/// <summary>Source Alpha Saturated.</summary>
		SourceAlphaSaturated = 10,
		/// <summary>Blend Color.</summary>
		BlendColor = 11,
		/// <summary>One Minus Blend Color.</summary>
		OneMinusBlendColor = 12,
		/// <summary>Blend Alpha.</summary>
		BlendAlpha = 13,
		/// <summary>One Minus Blend Alpha.</summary>
		OneMinusBlendAlpha = 14,
		[MacCatalyst (13, 1)]
		Source1Color = 15,
		[MacCatalyst (13, 1)]
		OneMinusSource1Color = 16,
		[MacCatalyst (13, 1)]
		Source1Alpha = 17,
		[MacCatalyst (13, 1)]
		OneMinusSource1Alpha = 18,
		[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
		Unspecialized = 19,
	}

	/// <summary>How the source and destination values are combined.</summary>
	[Native]
	public enum MTLBlendOperation : ulong {
		/// <summary>Add.</summary>
		Add = 0,
		/// <summary>Subtract.</summary>
		Subtract = 1,
		/// <summary>Reverse Subtract.</summary>
		ReverseSubtract = 2,
		/// <summary>Min.</summary>
		Min = 3,
		/// <summary>Max.</summary>
		Max = 4,
		[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
		Unspecialized = 5,
	}

	/// <summary>Permits or restricts writing to specific color channels.</summary>
	[Native]
	[Flags]
	public enum MTLColorWriteMask : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Red.</summary>
		Red = 0x1 << 3,
		/// <summary>Green.</summary>
		Green = 0x1 << 2,
		/// <summary>Blue.</summary>
		Blue = 0x1 << 1,
		/// <summary>Alpha.</summary>
		Alpha = 0x1 << 0,
		/// <summary>All.</summary>
		All = 0xf,
		[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
		Unspecialized = 0x10,
	}

	/// <summary>The state of the command-buffer state-machine. Enqueued-&gt;Committed-&gt;Scheduled-&gt;Completed.</summary>
	[Native]
	public enum MTLCommandBufferStatus : ulong {
		/// <summary>Not Enqueued.</summary>
		NotEnqueued,
		/// <summary>Enqueued.</summary>
		Enqueued,
		/// <summary>Committed.</summary>
		Committed,
		/// <summary>Scheduled.</summary>
		Scheduled,
		/// <summary>Completed.</summary>
		Completed,
		/// <summary>Error.</summary>
		Error,
	}

	/// <summary>Enumeration of error codes describing why a command buffer has failed.</summary>
	[Native]
	[ErrorDomain ("MTLCommandBufferErrorDomain")]
	public enum MTLCommandBufferError : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Internal.</summary>
		Internal = 1,
		/// <summary>Timeout.</summary>
		Timeout = 2,
		/// <summary>Page Fault.</summary>
		PageFault = 3,
		/// <summary>Blacklisted.</summary>
		Blacklisted = 4,
		/// <summary>Not Permitted.</summary>
		NotPermitted = 7,
		/// <summary>Out Of Memory.</summary>
		OutOfMemory = 8,
		/// <summary>Invalid Resource.</summary>
		InvalidResource = 9,
		/// <summary>Memoryless.</summary>
		Memoryless = 10,
		/// <summary>Indicates that the device was removed.</summary>
		DeviceRemoved = 11,
		StackOverflow = 12,
	}

	/// <summary>An action performed at the start of a rendering pass.</summary>
	[Native]
	public enum MTLLoadAction : ulong {
		/// <summary>Dont Care.</summary>
		DontCare,
		/// <summary>Load.</summary>
		Load,
		/// <summary>Clear.</summary>
		Clear,
	}

	/// <summary>The action to be performed at the end of a rendering pass.</summary>
	[Native]
	public enum MTLStoreAction : ulong {
		/// <summary>Dont Care.</summary>
		DontCare,
		/// <summary>Store.</summary>
		Store,
		/// <summary>Multisample Resolve.</summary>
		MultisampleResolve,
		/// <summary>Store And Multisample Resolve.</summary>
		[MacCatalyst (13, 1)]
		StoreAndMultisampleResolve,
		/// <summary>Unknown.</summary>
		[MacCatalyst (13, 1)]
		Unknown,
		/// <summary>Indicates that data will be stored in a way that does not consider the sample position.</summary>
		[MacCatalyst (13, 1)]
		CustomSampleDepthStore,
	}

	/// <summary>The dimensionality of each texture and how multiple images are arranged.</summary>
	[Native]
	public enum MTLTextureType : ulong {
		/// <summary>k1 D.</summary>
		k1D = 0,
		/// <summary>k1 D Array.</summary>
		k1DArray = 1,
		/// <summary>k2 D.</summary>
		k2D = 2,
		/// <summary>k2 D Array.</summary>
		k2DArray = 3,
		/// <summary>k2 D Multisample.</summary>
		k2DMultisample = 4,
		/// <summary>k Cube.</summary>
		kCube = 5,
		/// <summary>k Cube Array.</summary>
		[MacCatalyst (13, 1)]
		kCubeArray = 6,
		/// <summary>k3 D.</summary>
		k3D = 7,
		/// <summary>k2 D Multisample Array.</summary>
		[MacCatalyst (13, 1)]
		k2DMultisampleArray = 8,
		/// <summary>k Texture Buffer.</summary>
		[MacCatalyst (13, 1)]
		kTextureBuffer = 9,
	}

	/// <summary>Options for calculating the pixel value returned within a mipmap level.</summary>
	[Native]
	public enum MTLSamplerMinMagFilter : ulong {
		/// <summary>Nearest.</summary>
		Nearest,
		/// <summary>Linear.</summary>
		Linear,
	}

	/// <summary>Options for calculating the pixel value returned with multiple mipmap levels.</summary>
	[Native]
	public enum MTLSamplerMipFilter : ulong {
		/// <summary>Not Mipmapped.</summary>
		NotMipmapped,
		/// <summary>Nearest.</summary>
		Nearest,
		/// <summary>Linear.</summary>
		Linear,
	}

	/// <summary>The wrapping mode. Used when a fetch falls outside the bounds of a texture.</summary>
	[Native]
	public enum MTLSamplerAddressMode : ulong {
		/// <summary>Clamp To Edge.</summary>
		ClampToEdge = 0,
		/// <summary>Mirror Clamp To Edge.</summary>
		[iOS (14, 0)]
		[MacCatalyst (14, 0)]
		MirrorClampToEdge = 1,
		/// <summary>Repeat.</summary>
		Repeat = 2,
		/// <summary>Mirror Repeat.</summary>
		MirrorRepeat = 3,
		/// <summary>Clamp To Zero.</summary>
		ClampToZero = 4,

		/// <summary>Clamp To Border Color.</summary>
		[iOS (14, 0)]
		[MacCatalyst (14, 0)]
		ClampToBorderColor = 5,
	}

	/// <summary>Enumerates vertex data formats (type and number).</summary>
	[Native]
	public enum MTLVertexFormat : ulong {
		/// <summary>Invalid.</summary>
		Invalid = 0,

		/// <summary>U Char2.</summary>
		UChar2 = 1,
		/// <summary>U Char3.</summary>
		UChar3 = 2,
		/// <summary>U Char4.</summary>
		UChar4 = 3,

		/// <summary>Char2.</summary>
		Char2 = 4,
		/// <summary>Char3.</summary>
		Char3 = 5,
		/// <summary>Char4.</summary>
		Char4 = 6,

		/// <summary>U Char2 Normalized.</summary>
		UChar2Normalized = 7,
		/// <summary>U Char3 Normalized.</summary>
		UChar3Normalized = 8,
		/// <summary>U Char4 Normalized.</summary>
		UChar4Normalized = 9,

		/// <summary>Char2 Normalized.</summary>
		Char2Normalized = 10,
		/// <summary>Char3 Normalized.</summary>
		Char3Normalized = 11,
		/// <summary>Char4 Normalized.</summary>
		Char4Normalized = 12,

		/// <summary>U Short2.</summary>
		UShort2 = 13,
		/// <summary>U Short3.</summary>
		UShort3 = 14,
		/// <summary>U Short4.</summary>
		UShort4 = 15,

		/// <summary>Short2.</summary>
		Short2 = 16,
		/// <summary>Short3.</summary>
		Short3 = 17,
		/// <summary>Short4.</summary>
		Short4 = 18,

		/// <summary>U Short2 Normalized.</summary>
		UShort2Normalized = 19,
		/// <summary>U Short3 Normalized.</summary>
		UShort3Normalized = 20,
		/// <summary>U Short4 Normalized.</summary>
		UShort4Normalized = 21,

		/// <summary>Short2 Normalized.</summary>
		Short2Normalized = 22,
		/// <summary>Short3 Normalized.</summary>
		Short3Normalized = 23,
		/// <summary>Short4 Normalized.</summary>
		Short4Normalized = 24,

		/// <summary>Half2.</summary>
		Half2 = 25,
		/// <summary>Half3.</summary>
		Half3 = 26,
		/// <summary>Half4.</summary>
		Half4 = 27,

		/// <summary>Float.</summary>
		Float = 28,
		/// <summary>Float2.</summary>
		Float2 = 29,
		/// <summary>Float3.</summary>
		Float3 = 30,
		/// <summary>Float4.</summary>
		Float4 = 31,
		/// <summary>Int.</summary>
		Int = 32,
		/// <summary>Int2.</summary>
		Int2 = 33,
		/// <summary>Int3.</summary>
		Int3 = 34,
		/// <summary>Int4.</summary>
		Int4 = 35,

		/// <summary>U Int.</summary>
		UInt = 36,
		/// <summary>U Int2.</summary>
		UInt2 = 37,
		/// <summary>U Int3.</summary>
		UInt3 = 38,
		/// <summary>U Int4.</summary>
		UInt4 = 39,

		/// <summary>Int1010102 Normalized.</summary>
		Int1010102Normalized = 40,
		/// <summary>U Int1010102 Normalized.</summary>
		UInt1010102Normalized = 41,

		/// <summary>Indicates four unsigned 8-bit characters that describe BGRA channels.</summary>
		[MacCatalyst (13, 1)]
		UChar4NormalizedBgra = 42,
		/// <summary>Indicates a single unsigned 8-bit character.</summary>
		[MacCatalyst (13, 1)]
		UChar = 45,
		/// <summary>Indicates a single signed 8-bit character.</summary>
		[MacCatalyst (13, 1)]
		Char = 46,
		/// <summary>Indicates a single unsigned 8-bit character.</summary>
		[MacCatalyst (13, 1)]
		UCharNormalized = 47,

		/// <summary>Indicates a single normalized signed 8-bit character.</summary>
		[MacCatalyst (13, 1)]
		CharNormalized = 48,
		/// <summary>Indicates a single unsigned 16-bit two's complement value.</summary>
		[MacCatalyst (13, 1)]
		UShort = 49,
		/// <summary>Indicates a single signed 16-bit two's complement value.</summary>
		[MacCatalyst (13, 1)]
		Short = 50,
		/// <summary>ndicates a single normalized unsigned 16-bit two's complement value.</summary>
		[MacCatalyst (13, 1)]
		UShortNormalized = 51,
		/// <summary>Indicates a single normalized signed 16-bit two's complement value</summary>
		[MacCatalyst (13, 1)]
		ShortNormalized = 52,

		/// <summary>Indicates a single half-precision floating point value.</summary>
		[MacCatalyst (13, 1)]
		Half = 53,

		[Mac (14, 0), iOS (17, 0), TV (17, 0), MacCatalyst (17, 0)]
		FloatRG11B10 = 54,
		[Mac (14, 0), iOS (17, 0), TV (17, 0), MacCatalyst (17, 0)]
		FloatRgb9E5 = 55,
	}

	/// <summary>The format used by pixels, including color, depth, compression technigue, and data type for components.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLPixelFormat : ulong {
		/// <summary>Indicates an invalid pixel format.</summary>
		Invalid = 0,
		/// <summary>Indicates the unsigned, normalized integer format.</summary>
		A8Unorm = 1,
		/// <summary>Indicates a single 8-bit normalized integer format.</summary>
		R8Unorm = 10,
		/// <summary>Indicates a single 8-bit unnormalized signed integer format with sRGB-Linear conversion.</summary>
		[NoiOS]
		[NoTV]
		[NoMacCatalyst]
		R8Unorm_sRGB = 11,
		/// <summary>Indicates a single 8-bit normalized integer format.</summary>
		R8Snorm = 12,
		/// <summary>Indicates a single 8-bit unsigned integer format.</summary>
		R8Uint = 13,
		/// <summary>Indicates a single 8-bit signed integer format.</summary>
		R8Sint = 14,
		/// <summary>Indicates a single 16-bit normalized integer format.</summary>
		R16Unorm = 20,
		/// <summary>Indicates a single 16-bit normalized integer format.</summary>
		R16Snorm = 22,
		/// <summary>Indicates a single 16-bit unsigned integer format.</summary>
		R16Uint = 23,
		/// <summary>Indicates a single 16-bit signed integer format.</summary>
		R16Sint = 24,
		/// <summary>Indicates a single 16-bit floating point format.</summary>
		R16Float = 25,
		/// <summary>Indicates a 2-channel unnormalized signed integer format with 8 bits per channel.</summary>
		RG8Unorm = 30,
		/// <summary>Indicates a 2-channel unnormalized signed integer format with 8 bits per channel and sRGB-Linear conversion.</summary>
		[MacCatalyst (13, 1)]
		RG8Unorm_sRGB = 31,
		/// <summary>Indicates a 2-channel normalized signed integer format with 8 bits per channel.</summary>
		RG8Snorm = 32,
		/// <summary>Indicates a 2-channel unsigned integer format with 8 bits per channel.</summary>
		RG8Uint = 33,
		/// <summary>Indicates a 2-channel signed integer format with 8 bits per channel.</summary>
		RG8Sint = 34,
		/// <summary>Indicates a 5-bit B, 6-bit G, and 5-bit R unsigned, normalized integer format.</summary>
		[MacCatalyst (13, 1)]
		B5G6R5Unorm = 40,
		/// <summary>Indicates the unsigned, normalized integer format.</summary>
		[MacCatalyst (13, 1)]
		A1BGR5Unorm = 41,
		/// <summary>Indicates the unsigned, normalized integer format.</summary>
		[MacCatalyst (13, 1)]
		ABGR4Unorm = 42,
		/// <summary>Indicates a 5-bit B, 6-bit G, 5-bit R, and 1-bit Alpha unnormalized signed integer format.</summary>
		[MacCatalyst (13, 1)]
		BGR5A1Unorm = 43,
		/// <summary>Indicates a single 32-bit unsigned integer format.</summary>
		R32Uint = 53,
		/// <summary>Indicates a single 32-bit signed integer format.</summary>
		R32Sint = 54,
		/// <summary>Indicates a single 32-bit floating point format.</summary>
		R32Float = 55,
		/// <summary>Indicates a 2-channel unnormalized signed integer format with 16 bits per channel.</summary>
		RG16Unorm = 60,
		/// <summary>Indicates a 2-channel normalized integer format with 16 bits per channel.</summary>
		RG16Snorm = 62,
		/// <summary>Indicates a 2-channel unsigned integer format with 16 bits per channel.</summary>
		RG16Uint = 63,
		/// <summary>Indicates a 2-channel signed integer format with 16 bits per channel.</summary>
		RG16Sint = 64,
		/// <summary>Indicates a 2-channel floating point format with 16 bits per channel.</summary>
		RG16Float = 65,
		/// <summary>Indicates a format with 4 8-bit normalized unsigned integer channels.</summary>
		RGBA8Unorm = 70,
		/// <summary>Indicates a format with 4 8-bit normalized unsigned integer channels, with sRGB-Linear conversion.</summary>
		RGBA8Unorm_sRGB = 71,
		/// <summary>Indicates a format with 4 8-bit normalized signed integer channels.</summary>
		RGBA8Snorm = 72,
		/// <summary>Indicates a format with 4 8-bit unsigned integer channels.</summary>
		RGBA8Uint = 73,
		/// <summary>Indicates a format with 4 8-bit signed integer channels.</summary>
		RGBA8Sint = 74,
		/// <summary>Indicates an 8-bit BGRA unnormalized signed integer format.</summary>
		BGRA8Unorm = 80,
		/// <summary>Indicates an 8-bit BGRA unnormalized signed integer format with sRGB-Linear conversion</summary>
		BGRA8Unorm_sRGB = 81,
		/// <summary>Indicates a format with 10-bit normalized unsigned integer RGB values plus 2 alpha bits.</summary>
		RGB10A2Unorm = 90,
		/// <summary>Indicates a format with 10-bit unsigned integer RGB values plus 2 alpha bits.</summary>
		RGB10A2Uint = 91,
		/// <summary>Indicates an 11-bit RG plus 10-bit B value floating-point format.</summary>
		RG11B10Float = 92,
		/// <summary>Indicates a format with 9 bits per RGB channel plus a 5-bit shared exponent.</summary>
		RGB9E5Float = 93,
		/// <summary>Indicates a 10-bit B, 10-bit G, 10-bit R, and 2-bit Alpha normalized unsigned integer format.</summary>
		[MacCatalyst (13, 1)]
		BGR10A2Unorm = 94,
		/// <summary>Indicates a 2-channel unsigned integer format with 32 bits per channel.</summary>
		RG32Uint = 103,
		/// <summary>Indicates a 2-channel signed integer format with 32 bits per channel.</summary>
		RG32Sint = 104,
		/// <summary>Indicates a 2-channel floating point format with 32 bits per channel.</summary>
		RG32Float = 105,
		/// <summary>Indicates a format with 4 16-bit normalized unsigned integer channels.</summary>
		RGBA16Unorm = 110,
		/// <summary>Indicates a format with 4 16-bit normalized signed integer channels.</summary>
		RGBA16Snorm = 112,
		/// <summary>Indicates a format with 4 16-bit unsigned integer channels.</summary>
		RGBA16Uint = 113,
		/// <summary>Indicates a format with 4 16-bit signed integer channels.</summary>
		RGBA16Sint = 114,
		/// <summary>Indicates a format with 4 16-bit floating point channels.</summary>
		RGBA16Float = 115,
		/// <summary>Indicates a format with 4 32-bit unsigned integer channels.</summary>
		RGBA32Uint = 123,
		/// <summary>Indicates a format with 4 32-bit signed integer channels.</summary>
		RGBA32Sint = 124,
		/// <summary>Indicates a format with 4 32-bit floating point channels.</summary>
		RGBA32Float = 125,
		/// <summary>B C1 R G B A.</summary>
		[NoTV]
		[NoiOS]
		[NoMacCatalyst]
		BC1RGBA = 130,
		/// <summary>B C1_ R G B A_s R G B.</summary>
		[NoTV]
		[NoiOS]
		[NoMacCatalyst]
		BC1_RGBA_sRGB = 131,
		/// <summary>B C2 R G B A.</summary>
		[NoTV]
		[NoiOS]
		[NoMacCatalyst]
		BC2RGBA = 132,
		/// <summary>B C2_ R G B A_s R G B.</summary>
		[NoTV]
		[NoiOS]
		[NoMacCatalyst]
		BC2_RGBA_sRGB = 133,
		/// <summary>B C3 R G B A.</summary>
		[NoTV]
		[NoiOS]
		[NoMacCatalyst]
		BC3RGBA = 134,
		/// <summary>B C3_ R G B A_s R G B.</summary>
		[NoTV]
		[NoiOS]
		[NoMacCatalyst]
		BC3_RGBA_sRGB = 135,
		/// <summary>B C4_ R Unorm.</summary>
		[NoTV]
		[NoiOS]
		[NoMacCatalyst]
		BC4_RUnorm = 140,
		/// <summary>B C4_ R Snorm.</summary>
		[NoTV]
		[NoiOS]
		[NoMacCatalyst]
		BC4_RSnorm = 141,
		/// <summary>B C5_ R G Unorm.</summary>
		[NoTV]
		[NoiOS]
		[NoMacCatalyst]
		BC5_RGUnorm = 142,
		/// <summary>B C5_ R G Snorm.</summary>
		[NoTV]
		[NoiOS]
		[NoMacCatalyst]
		BC5_RGSnorm = 143,
		/// <summary>B C6 H_ R G B Float.</summary>
		[NoTV]
		[NoiOS]
		[NoMacCatalyst]
		BC6H_RGBFloat = 150,
		/// <summary>B C6 H_ R G B U Float.</summary>
		[NoTV]
		[NoiOS]
		[NoMacCatalyst]
		BC6H_RGBUFloat = 151,
		/// <summary>B C7_ R G B A Unorm.</summary>
		[NoTV]
		[NoiOS]
		[NoMacCatalyst]
		BC7_RGBAUnorm = 152,
		/// <summary>B C7_ R G B A Unorm_s R G B.</summary>
		[NoTV]
		[NoiOS]
		[NoMacCatalyst]
		BC7_RGBAUnorm_sRGB = 153,

		/// <summary>Indicatea a 2bpp PVRTC RGB format.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		PVRTC_RGB_2BPP = 160,

		/// <summary>Indicatea a 2bpp PVRTC RGB format with sRGB-Linear conversion.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		PVRTC_RGB_2BPP_sRGB = 161,

		/// <summary>Indicatea a 4bpp PVRTC RGB format.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		PVRTC_RGB_4BPP = 162,

		/// <summary>Indicatea a 4bpp PVRTC RGB format with sRGB-Linear conversion.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		PVRTC_RGB_4BPP_sRGB = 163,

		/// <summary>Indicatea a 2bpp PVRTC RGBA format.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		PVRTC_RGBA_2BPP = 164,

		/// <summary>Indicatea a 2bpp PVRTC RGBA format with sRGB-Linear conversion.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		PVRTC_RGBA_2BPP_sRGB = 165,

		/// <summary>Indicatea a 4bpp PVRTC RGBA format.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		PVRTC_RGBA_4BPP = 166,

		/// <summary>Indicatea a 4bpp PVRTC RGBA format with sRGB-Linear conversion.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use ASTC/ETC2/BC formats instead.")]
		PVRTC_RGBA_4BPP_sRGB = 167,

		/// <summary>Indicates a single-channel EAC, unnormalized signed integer format.</summary>
		EAC_R11Unorm = 170,
		/// <summary>Indicates a single-channel EAC, normalized signed integer format.</summary>
		EAC_R11Snorm = 172,
		/// <summary>Indicates a two-channel EAC, unnormalized signed integer format.</summary>
		EAC_RG11Unorm = 174,
		/// <summary>Indicates a two-channel EAC, normalized signed integer format.</summary>
		EAC_RG11Snorm = 176,
		/// <summary>Indicates an 8-bit RGB EAC format.</summary>
		EAC_RGBA8 = 178,
		/// <summary>Indicates an 8-bit RGBa EAC format with sRGB-Linear conversion.</summary>
		EAC_RGBA8_sRGB = 179,
		/// <summary>Indicates an ETC2 format.</summary>
		ETC2_RGB8 = 180,
		/// <summary>Indicates an ETC2 format with sRGB-Linear conversion.</summary>
		ETC2_RGB8_sRGB = 181,
		/// <summary>Indicates an ETC2 format with 8-bit RGB channels and a single-bit Alpha channel.</summary>
		ETC2_RGB8A1 = 182,
		/// <summary>Indicates an ETC2 format with 8-bit RGB channels and a single-bit Alpha channel, with sRGB-Linear conversion.</summary>
		ETC2_RGB8A1_sRGB = 183,


		/// <summary>Indicates the 4x4 ASTC format, with sRGB-Linear conversion.</summary>
		ASTC_4x4_sRGB = 186,
		/// <summary>Indicates the 5x4 ASTC format, with sRGB-Linear conversion.</summary>
		ASTC_5x4_sRGB = 187,
		/// <summary>Indicates the 5x5 ASTC format, with sRGB-Linear conversion.</summary>
		ASTC_5x5_sRGB = 188,
		/// <summary>Indicates the 6x5 ASTC format, with sRGB-Linear conversion.</summary>
		ASTC_6x5_sRGB = 189,
		/// <summary>Indicates the 6x6 ASTC format, with sRGB-Linear conversion.</summary>
		ASTC_6x6_sRGB = 190,
		/// <summary>Indicates the 8x5 ASTC format, with sRGB-Linear conversion.</summary>
		ASTC_8x5_sRGB = 192,
		/// <summary>Indicates the 8x6 ASTC format, with sRGB-Linear conversion.</summary>
		ASTC_8x6_sRGB = 193,
		/// <summary>Indicates the 8x8 ASTC format, with sRGB-Linear conversion.</summary>
		ASTC_8x8_sRGB = 194,
		/// <summary>Indicates the 10x5 ASTC format, with sRGB-Linear conversion.</summary>
		ASTC_10x5_sRGB = 195,
		/// <summary>Indicates the 10x6 ASTC format, with sRGB-Linear conversion.</summary>
		ASTC_10x6_sRGB = 196,
		/// <summary>Indicates the 10x8 ASTC format, with sRGB-Linear conversion.</summary>
		ASTC_10x8_sRGB = 197,
		/// <summary>Indicates the 10x10 ASTC format, with sRGB-Linear conversion.</summary>
		ASTC_10x10_sRGB = 198,
		/// <summary>Indicates the 12x10 ASTC format, with sRGB-Linear conversion.</summary>
		ASTC_12x10_sRGB = 199,
		/// <summary>Indicates the 12x12 ASTC format, with sRGB-Linear conversion.</summary>
		ASTC_12x12_sRGB = 200,

		/// <summary>Indicates the 4x4 ASTC, low dynamic range format.</summary>
		ASTC_4x4_LDR = 204,
		/// <summary>Indicates the 5x4 ASTC, low dynamic range format.</summary>
		ASTC_5x4_LDR = 205,
		/// <summary>Indicates the 5x5 ASTC, low dynamic range format.</summary>
		ASTC_5x5_LDR = 206,
		/// <summary>Indicates the 6x5 ASTC, low dynamic range format.</summary>
		ASTC_6x5_LDR = 207,
		/// <summary>Indicates the 6x6 ASTC, low dynamic range format.</summary>
		ASTC_6x6_LDR = 208,
		/// <summary>Indicates the 8x5 ASTC, low dynamic range format.</summary>
		ASTC_8x5_LDR = 210,
		/// <summary>Indicates the 8x6 ASTC, low dynamic range format.</summary>
		ASTC_8x6_LDR = 211,
		/// <summary>Indicates the 8x8 ASTC, low dynamic range format.</summary>
		ASTC_8x8_LDR = 212,
		/// <summary>Indicates the 10x5 ASTC, low dynamic range format.</summary>
		ASTC_10x5_LDR = 213,
		/// <summary>Indicates the 10x6 ASTC, low dynamic range format.</summary>
		ASTC_10x6_LDR = 214,
		/// <summary>Indicates the 10x8 ASTC, low dynamic range format.</summary>
		ASTC_10x8_LDR = 215,
		/// <summary>Indicates the 10x10 ASTC, low dynamic range format.</summary>
		ASTC_10x10_LDR = 216,
		/// <summary>Indicates the 12x10 ASTC, low dynamic range format.</summary>
		ASTC_12x10_LDR = 217,
		/// <summary>Indicates the 12x12 ASTC, low dynamic range format.</summary>
		ASTC_12x12_LDR = 218,

		[iOS (13, 0)]
		[TV (16, 0)]
		[MacCatalyst (13, 1)]
		ASTC_4x4_HDR = 222,
		[iOS (13, 0)]
		[TV (16, 0)]
		[MacCatalyst (13, 1)]
		ASTC_5x4_HDR = 223,
		[iOS (13, 0)]
		[TV (16, 0)]
		[MacCatalyst (13, 1)]
		ASTC_5x5_HDR = 224,
		[iOS (13, 0)]
		[TV (16, 0)]
		[MacCatalyst (13, 1)]
		ASTC_6x5_HDR = 225,
		[iOS (13, 0)]
		[TV (16, 0)]
		[MacCatalyst (13, 1)]
		ASTC_6x6_HDR = 226,
		[iOS (13, 0)]
		[TV (16, 0)]
		[MacCatalyst (13, 1)]
		ASTC_8x5_HDR = 228,
		[iOS (13, 0)]
		[TV (16, 0)]
		[MacCatalyst (13, 1)]
		ASTC_8x6_HDR = 229,
		[iOS (13, 0)]
		[TV (16, 0)]
		[MacCatalyst (13, 1)]
		ASTC_8x8_HDR = 230,
		[iOS (13, 0)]
		[TV (16, 0)]
		[MacCatalyst (13, 1)]
		ASTC_10x5_HDR = 231,
		[iOS (13, 0)]
		[TV (16, 0)]
		[MacCatalyst (13, 1)]
		ASTC_10x6_HDR = 232,
		[iOS (13, 0)]
		[TV (16, 0)]
		[MacCatalyst (13, 1)]
		ASTC_10x8_HDR = 233,
		[iOS (13, 0)]
		[TV (16, 0)]
		[MacCatalyst (13, 1)]
		ASTC_10x10_HDR = 234,
		[iOS (13, 0)]
		[TV (16, 0)]
		[MacCatalyst (13, 1)]
		ASTC_12x10_HDR = 235,
		[iOS (13, 0)]
		[TV (16, 0)]
		[MacCatalyst (13, 1)]
		ASTC_12x12_HDR = 236,

		/// <summary>Indicates a red-green horizontally subsampled format.</summary>
		GBGR422 = 240,
		/// <summary>Indicates a red-green horizontally subsampled format.</summary>
		BGRG422 = 241,

		Depth16Unorm = 250,

		/// <summary>Indicates a 32-bit format that is suitable for depth stencils.</summary>
		Depth32Float = 252,
		/// <summary>Indicates a single-channel 8-bit stencil format.</summary>
		Stencil8 = 253,

		/// <summary>Depth24 Unorm_ Stencil8.</summary>
		[NoiOS]
		[NoTV]
		[NoMacCatalyst]
		Depth24Unorm_Stencil8 = 255,

		/// <summary>Indicates a 24-bit depth and 8-bit stencil floating-point format.</summary>
		[MacCatalyst (13, 1)]
		Depth32Float_Stencil8 = 260,

		/// <summary>Indicates an 8-bit stencil format.</summary>
		[MacCatalyst (13, 1)]
		X32_Stencil8 = 261,

		/// <summary>X24_ Stencil8.</summary>
		[NoiOS]
		[NoTV]
		[NoMacCatalyst]
		X24_Stencil8 = 262,

		[MacCatalyst (13, 1)]
		BGRA10_XR = 552,
		[MacCatalyst (13, 1)]
		BGRA10_XR_sRGB = 553,
		[MacCatalyst (13, 1)]
		BGR10_XR = 554,
		[MacCatalyst (13, 1)]
		BGR10_XR_sRGB = 555,
		[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
		Unspecialized = 263,
	}

	/// <summary>The type of a Metal function.</summary>
	[Native]
	public enum MTLFunctionType : ulong {
		/// <summary>Vertex.</summary>
		Vertex = 1,
		/// <summary>Fragment.</summary>
		Fragment = 2,
		/// <summary>Kernel.</summary>
		Kernel = 3,
		[iOS (14, 0)]
		[TV (14, 0)]
		[MacCatalyst (14, 0)]
		Visible = 5,
		[iOS (14, 0)]
		[TV (16, 0)]
		[MacCatalyst (14, 0)]
		Intersection = 6,
		[Mac (13, 0), iOS (16, 0), TV (16, 0), MacCatalyst (16, 0)]
		Mesh = 7,
		[Mac (13, 0), iOS (16, 0), TV (16, 0), MacCatalyst (16, 0)]
		Object = 8,
	}

	/// <summary>Enumerates errors possible in the creation of an MTLLibrary or MTLFunction object.</summary>
	[Native]
	[ErrorDomain ("MTLLibraryErrorDomain")]
	public enum MTLLibraryError : ulong {
		/// <summary>Unsupported.</summary>
		Unsupported = 1,
		/// <summary>Internal.</summary>
		Internal,
		/// <summary>Compile Failure.</summary>
		CompileFailure,
		/// <summary>Compile Warning.</summary>
		CompileWarning,
		/// <summary>Function Not Found.</summary>
		FunctionNotFound,
		/// <summary>File Not Found.</summary>
		FileNotFound,
	}

	/// <summary>Holds a comparison test. When the comparison test passes, the incoming fragment is compared to the stored data at the specified location.</summary>
	[Native]
	public enum MTLCompareFunction : ulong {
		/// <summary>Never.</summary>
		Never = 0,
		/// <summary>Less.</summary>
		Less = 1,
		/// <summary>Equal.</summary>
		Equal = 2,
		/// <summary>Less Equal.</summary>
		LessEqual = 3,
		/// <summary>Greater.</summary>
		Greater = 4,
		/// <summary>Not Equal.</summary>
		NotEqual = 5,
		/// <summary>Greater Equal.</summary>
		GreaterEqual = 6,
		/// <summary>Always.</summary>
		Always = 7,
	}


	/// <summary>What to do if a stencil value passes or fails a comparison test.</summary>
	[Native]
	public enum MTLStencilOperation : ulong {
		/// <summary>Keep.</summary>
		Keep = 0,
		/// <summary>Zero.</summary>
		Zero = 1,
		/// <summary>Replace.</summary>
		Replace = 2,
		/// <summary>Increment Clamp.</summary>
		IncrementClamp = 3,
		/// <summary>Decrement Clamp.</summary>
		DecrementClamp = 4,
		/// <summary>Invert.</summary>
		Invert = 5,
		/// <summary>Increment Wrap.</summary>
		IncrementWrap = 6,
		/// <summary>Decrement Wrap.</summary>
		DecrementWrap = 7,
	}

	/// <summary>Enumerates the primitive geometry used for drawing commands.</summary>
	[Native]
	public enum MTLPrimitiveType : ulong {
		/// <summary>Point.</summary>
		Point = 0,
		/// <summary>Line.</summary>
		Line = 1,
		/// <summary>Line Strip.</summary>
		LineStrip = 2,
		/// <summary>Triangle.</summary>
		Triangle = 3,
		/// <summary>Triangle Strip.</summary>
		TriangleStrip = 4,
	}

	/// <summary>The index type for an index buffer.</summary>
	[Native]
	public enum MTLIndexType : ulong {
		/// <summary>U Int16.</summary>
		UInt16,
		/// <summary>U Int32.</summary>
		UInt32,
	}

	/// <summary>Enumerates values that control how and whether to monitor samples that pass depth and stencil tests.</summary>
	[Native]
	public enum MTLVisibilityResultMode : ulong {
		/// <summary>Indicates that monitoring is turned off.</summary>
		Disabled = 0,
		/// <summary>Indicates that only whether the samples pass the depth and stencil tests should be tracked.</summary>
		Boolean = 1,
		/// <summary>Indicates that the samples that pass should be monitored.</summary>
		Counting = 2,
	}

	/// <summary>Enumerates modes for culling and which types of primitives are culled.</summary>
	[Native]
	public enum MTLCullMode : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Front.</summary>
		Front = 1,
		/// <summary>Back.</summary>
		Back = 2,
	}

	/// <summary>Vertex winding rule for front-facing primitives.</summary>
	[Native]
	public enum MTLWinding : ulong {
		/// <summary>Clockwise.</summary>
		Clockwise = 0,
		/// <summary>Counter Clockwise.</summary>
		CounterClockwise = 1,
	}

	/// <summary>How to rasterize triangle and triangle-strip primitives.</summary>
	[Native]
	public enum MTLTriangleFillMode : ulong {
		/// <summary>Fill.</summary>
		Fill,
		/// <summary>Lines.</summary>
		Lines,
	}

	/// <summary>The purgeable state of the resource.</summary>
	[Native]
	public enum MTLPurgeableState : ulong {
		/// <summary>Keep Current.</summary>
		KeepCurrent = 1,
		/// <summary>Non Volatile.</summary>
		NonVolatile = 2,
		/// <summary>Volatile.</summary>
		Volatile = 3,
		/// <summary>Empty.</summary>
		Empty = 4,
	}

	/// <summary>Enumerates what cache mode is used for CPU mapping of a resource.</summary>
	[Native]
	public enum MTLCpuCacheMode : ulong {
		/// <summary>Default Cache.</summary>
		DefaultCache,
		/// <summary>Write Combined.</summary>
		WriteCombined,
	}

	/// <summary>Enumerates the ways in which a <see cref="Metal.IMTLTexture" /> may be used.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	[Flags]
	public enum MTLTextureUsage : ulong {
		/// <summary>A value that indicates that it is not known what the texture usage option is.</summary>
		Unknown = 0x0000,
		/// <summary>A value that indicates that the texture will be read by shaders at any stage in rendering.</summary>
		ShaderRead = 0x0001,
		/// <summary>A value that indicates that the texture will be written to by compute shaders.</summary>
		ShaderWrite = 0x0002,
		/// <summary>A value that indicates that the texture will be used as a color, depth, or stencil render target in a rendering pass.</summary>
		RenderTarget = 0x0004,
		/// <summary>A value that indicates that the texture will be used for creating new textures.</summary>
		PixelFormatView = 0x0010,

		[Mac (14, 0), iOS (17, 0), TV (17, 0), MacCatalyst (17, 0)]
		ShaderAtomic = 0x20,
	}

	/// <summary>Holds options used by buffer and texture objects.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	[Flags]
	public enum MTLResourceOptions : ulong {
		/// <summary>Indicates the default CPU cache mode.</summary>
		CpuCacheModeDefault = MTLCpuCacheMode.DefaultCache << 0,
		/// <summary>Indicates a write-combined CPU cache mode, which is best for resources that the CPU will write but never read.</summary>
		CpuCacheModeWriteCombined = MTLCpuCacheMode.WriteCombined << 0,

		/// <summary>Indicates that the resource is stored in a location where both the GPU and CPU can access it.</summary>
		[MacCatalyst (13, 1)]
		StorageModeShared = MTLStorageMode.Shared << 4,
		/// <summary>Storage Mode Managed.</summary>
		[NoiOS]
		[NoTV]
		[NoMacCatalyst]
		StorageModeManaged = MTLStorageMode.Managed << 4,
		/// <summary>Indicates that the resource is stored in a location where only the GPU can acces it.</summary>
		[MacCatalyst (13, 1)]
		StorageModePrivate = MTLStorageMode.Private << 4,

		/// <summary>Indicates that the resource is a temporary render target and is stored only on the tile.</summary>
		[NoMac]
		[MacCatalyst (13, 1)]
		StorageModeMemoryless = MTLStorageMode.Memoryless << 4,

		/// <summary>Indicates that the developer must track command encoder dependencies with fences.</summary>
		[MacCatalyst (13, 1)]
		HazardTrackingModeUntracked = 1 << 8,

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		HazardTrackingModeTracked = 1 << 9,
	}

	// MTLVertexDescriptor.h
	/// <summary>The frequency at which the vertex shader function should fetch attribute data.</summary>
	[Native]
	public enum MTLVertexStepFunction : ulong {
		/// <summary>Constant.</summary>
		Constant,
		/// <summary>Per Vertex.</summary>
		PerVertex,
		/// <summary>Per Instance.</summary>
		PerInstance,
		/// <summary>Per Patch.</summary>
		[MacCatalyst (13, 1)]
		PerPatch = 3,
		/// <summary>Per Patch Control Point.</summary>
		[MacCatalyst (13, 1)]
		PerPatchControlPoint = 4,
	}

	/// <summary>The data type of a function argument, as used in the shader language code.</summary>
	[Native]
	public enum MTLDataType : ulong {

		/// <summary>Indicates an unrecognized or invalid type.</summary>
		None = 0,

		/// <summary>Indicates a struct.</summary>
		Struct = 1,
		/// <summary>Indicates an array.</summary>
		Array = 2,

		/// <summary>Indicates a 32-bit floating point value.</summary>
		Float = 3,
		/// <summary>Indicates a vector of two 32-bit floating point values.</summary>
		Float2 = 4,
		/// <summary>Indicates a vector of three 32-bit floating point values.</summary>
		Float3 = 5,
		/// <summary>Indicates a vector of four 32-bit floating point values.</summary>
		Float4 = 6,

		/// <summary>Indicates a 2x2 matrix of 32-bit floating point values.</summary>
		Float2x2 = 7,
		/// <summary>Indicates a 2x3 matrix of 32-bit floating point values.</summary>
		Float2x3 = 8,
		/// <summary>Indicates a 2x4 matrix of 32-bit floating point values.</summary>
		Float2x4 = 9,

		/// <summary>Indicates a 3x2 matrix of 32-bit floating point values.</summary>
		Float3x2 = 10,
		/// <summary>Indicates a 3x3 matrix of 32-bit floating point values.</summary>
		Float3x3 = 11,
		/// <summary>Indicates a 3x4 matrix of 32-bit floating point values.</summary>
		Float3x4 = 12,

		/// <summary>Indicates a 4x2 matrix of 32-bit floating point values.</summary>
		Float4x2 = 13,
		/// <summary>Indicates a 4x3 matrix of 32-bit floating point values.</summary>
		Float4x3 = 14,
		/// <summary>Indicates a 4x4 matrix of 32-bit floating point values.</summary>
		Float4x4 = 15,

		/// <summary>Indicates a 16-bit floating point value.</summary>
		Half = 16,
		/// <summary>Indicates a vector of two 16-bit floating point values.</summary>
		Half2 = 17,
		/// <summary>Indicates a vector of three 16-bit floating point values.</summary>
		Half3 = 18,
		/// <summary>Indicates a vector of four 16-bit floating point values.</summary>
		Half4 = 19,

		/// <summary>Indicates a 2x2 matrix of 16-bit floating point values.</summary>
		Half2x2 = 20,
		/// <summary>Indicates a 2x3 matrix of 16-bit floating point values.</summary>
		Half2x3 = 21,
		/// <summary>Indicates a 2x4 matrix of 16-bit floating point values.</summary>
		Half2x4 = 22,

		/// <summary>Indicates a 3x2 matrix of 16-bit floating point values.</summary>
		Half3x2 = 23,
		/// <summary>Indicates a 3x3 matrix of 16-bit floating point values.</summary>
		Half3x3 = 24,
		/// <summary>Indicates a 3x4 matrix of 16-bit floating point values.</summary>
		Half3x4 = 25,

		/// <summary>Indicates a 4x2 matrix of 16-bit floating point values.</summary>
		Half4x2 = 26,
		/// <summary>Indicates a 4x3 matrix of 16-bit floating point values.</summary>
		Half4x3 = 27,
		/// <summary>Indicates a 4x4 matrix of 16-bit floating point values.</summary>
		Half4x4 = 28,

		/// <summary>Indicates a signed 32-bit integer.</summary>
		Int = 29,
		/// <summary>Indicates a vector of two 32-bit signed integers.</summary>
		Int2 = 30,
		/// <summary>Indicates a vector of three signed 32-bit integers.</summary>
		Int3 = 31,
		/// <summary>Indicates a vector of four signed 32-bit integers.</summary>
		Int4 = 32,

		/// <summary>Indicates an unsigned 32-bit integer.</summary>
		UInt = 33,
		/// <summary>Indicates a value that contains two unsigned 32-bit integer components.</summary>
		UInt2 = 34,
		/// <summary>Indicates a value that contains three unsigned 32-bit integer components.</summary>
		UInt3 = 35,
		/// <summary>Indicates a value that contains four unsigned 32-bit integer components.</summary>
		UInt4 = 36,

		/// <summary>Indicates a signed 16-bit integer.</summary>
		Short = 37,
		/// <summary>Indicates a value that contains two signed 16-bit integer components.</summary>
		Short2 = 38,
		/// <summary>Indicates a value that contains three signed 16-bit integer components.</summary>
		Short3 = 39,
		/// <summary>Indicates a value that contains four signed 16-bit integer components.</summary>
		Short4 = 40,

		/// <summary>Indicates an unsigned 16-bit integer.</summary>
		UShort = 41,
		/// <summary>Indicates a value that contains two unsigned 16-bit integer components.</summary>
		UShort2 = 42,
		/// <summary>Indicates a value that contains three unsigned 16-bit integer components.</summary>
		UShort3 = 43,
		/// <summary>Indicates a value that contains four unsigned 16-bit integer components.</summary>
		UShort4 = 44,

		/// <summary>Indicates a signed 8-bit character.</summary>
		Char = 45,
		/// <summary>Indicates a vector of two signed 8-bit characters.</summary>
		Char2 = 46,
		/// <summary>Indicates a vector of three signed 8-bit characters.</summary>
		Char3 = 47,
		/// <summary>Indicates a vector of four signed 8-bit characters.</summary>
		Char4 = 48,

		/// <summary>Indicates an unsigned 8-bit character.</summary>
		UChar = 49,
		/// <summary>Indicates a value that contains two unsigned 8-bit integer components.</summary>
		UChar2 = 50,
		/// <summary>Indicates a value that contains three unsigned 8-bit integer components.</summary>
		UChar3 = 51,
		/// <summary>Indicates a value that contains four unsigned 8-bit integer components.</summary>
		UChar4 = 52,

		/// <summary>Indicates a Boolean value.</summary>
		Bool = 53,
		/// <summary>Indicates vector of two Boolean values.</summary>
		Bool2 = 54,
		/// <summary>Indicates vector of three Boolean values.</summary>
		Bool3 = 55,
		/// <summary>Indicates vector of four Boolean values</summary>
		Bool4 = 56,
		/// <summary>Indicates a texture.</summary>
		[MacCatalyst (13, 1)]

		Texture = 58,
		/// <summary>Indicates a sampler.</summary>
		[MacCatalyst (13, 1)]
		Sampler = 59,
		/// <summary>Indicates APointer.</summary>
		[MacCatalyst (13, 1)]
		Pointer = 60,
		/// <summary>Indicates an unsigned 8-bit normalized integer.</summary>
		[MacCatalyst (13, 1)]

		[NoMac, TV (14, 5)] R8Unorm = 62,
		/// <summary>Indicates a signed 8-bit normalized integer.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] R8Snorm = 63,
		/// <summary>Indicates an unsigned 16-bit normalized integer.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] R16Unorm = 64,
		/// <summary>Indicates a signed 16-bit normalized integer.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] R16Snorm = 65,
		/// <summary>Indicates a value that contains two unsigned 8-bit normalized integer components.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] Rg8Unorm = 66,
		/// <summary>Indicates a value that contains two signed 8-bit normalized integer components.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] Rg8Snorm = 67,
		/// <summary>Indicates a value that contains two unsigned 16-bit normalized integer components.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] Rg16Unorm = 68,
		/// <summary>Indicates a value that contains two signed 16-bit normalized integer components.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] Rg16Snorm = 69,
		/// <summary>Indicates a value that contains four unsigned 8-bit normalized integer components.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] Rgba8Unorm = 70,
		/// <summary>Indicates normalized unsigned 8-bit RGBA values, convertible to sRGB.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] Rgba8Unorm_sRgb = 71,
		/// <summary>Indicates a value that contains four signed 8-bit normalized integer components.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] Rgba8Snorm = 72,
		/// <summary>Indicates a value that contains four unsigned 16-bit normalized integer components.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] Rgba16Unorm = 73,
		/// <summary>Indicates a value that contains four signed 16-bit normalized integer components.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] Rgba16Snorm = 74,
		/// <summary>Indicates APacked RGBA normalized integer value with 10 bits each for RGB and 2 bits for A.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] Rgb10A2Unorm = 75,
		/// <summary>Indicates a 32-bit packed floating point RGB value with 11 bits for R and G and 10 bits for B.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] Rg11B10Float = 76,
		/// <summary>Indicates APacked RGBE normalized floating point value with 9 bits each for R, G, and B, with a 5-bit exponent.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] Rgb9E5Float = 77,
		/// <summary>Render Pipeline.</summary>
		[MacCatalyst (13, 1)]

		RenderPipeline = 78,
		[MacCatalyst (13, 1)]
		[iOS (13, 0), TV (13, 0)] ComputePipeline = 79,
		/// <summary>Indirect Command Buffer.</summary>
		[MacCatalyst (13, 1)]
		IndirectCommandBuffer = 80,

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)] Long = 81,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)] Long2 = 82,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)] Long3 = 83,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)] Long4 = 84,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)] ULong = 85,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)] ULong2 = 86,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)] ULong3 = 87,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)] ULong4 = 88,
		[MacCatalyst (14, 0)]

		[iOS (14, 0), TV (16, 0)]
		VisibleFunctionTable = 115,
		[MacCatalyst (14, 0)]
		[iOS (14, 0), TV (16, 0)]
		IntersectionFunctionTable = 116,
		[MacCatalyst (14, 0)]
		[iOS (14, 0), TV (16, 0)]
		PrimitiveAccelerationStructure = 117,
		[MacCatalyst (14, 0)]
		[iOS (14, 0), TV (16, 0)]
		InstanceAccelerationStructure = 118,

		[iOS (17, 0), TV (17, 0), Mac (14, 0), MacCatalyst (17, 0)]
		BFloat = 121,
		[iOS (17, 0), TV (17, 0), Mac (14, 0), MacCatalyst (17, 0)]
		BFloat2 = 122,
		[iOS (17, 0), TV (17, 0), Mac (14, 0), MacCatalyst (17, 0)]
		BFloat3 = 123,
		[iOS (17, 0), TV (17, 0), Mac (14, 0), MacCatalyst (17, 0)]
		BFloat4 = 124,
		[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
		DepthStencilState = 139,
		[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
		Tensor = 140,
	}

	/// <summary>The resource type of an argument of a function.</summary>
	[Native]
	public enum MTLArgumentType : ulong {
		/// <summary>Buffer.</summary>
		Buffer = 0,
		/// <summary>Threadgroup Memory.</summary>
		ThreadgroupMemory = 1,
		/// <summary>Texture.</summary>
		Texture = 2,
		/// <summary>Sampler.</summary>
		Sampler = 3,
		/// <summary>Visible Function Table.</summary>
		[MacCatalyst (13, 1)]

		[NoMac, TV (14, 5)] ImageblockData = 16,
		/// <summary>Visible Function Table.</summary>
		[MacCatalyst (13, 1)]
		[NoMac, TV (14, 5)] Imageblock = 17,

		[iOS (14, 0)]
		[TV (16, 0)]
		[MacCatalyst (14, 0)]
		VisibleFunctionTable = 24,
		[iOS (14, 0)]
		[TV (16, 0)]
		[MacCatalyst (14, 0)]
		PrimitiveAccelerationStructure = 25,
		[iOS (14, 0)]
		[TV (16, 0)]
		[MacCatalyst (14, 0)]
		InstanceAccelerationStructure = 26,
		[iOS (14, 0)]
		[TV (16, 0)]
		[MacCatalyst (14, 0)]
		IntersectionFunctionTable = 27,
	}

#if !XAMCORE_5_0
	/// <summary>Function access restrictions of argument data in the shader code.</summary>
	[Deprecated (PlatformName.MacOSX, 14, 0)]
	[Deprecated (PlatformName.iOS, 17, 0)]
	[Deprecated (PlatformName.TvOS, 17, 0)]
	[Deprecated (PlatformName.MacCatalyst, 17, 0)]
	[Native]
	public enum MTLArgumentAccess : ulong {
		/// <summary>Read Only.</summary>
		ReadOnly,
		/// <summary>Read Write.</summary>
		ReadWrite,
		/// <summary>Write Only.</summary>
		WriteOnly,
	}
#endif

	/// <summary>Options relating to argument information in the creation of APipeline.</summary>
	[Native]
	[Flags]
	public enum MTLPipelineOption : ulong {
		/// <summary>None.</summary>
		None,
#if !XAMCORE_5_0
		/// <summary>Argument Info.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'BindingInfo' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'BindingInfo' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'BindingInfo' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'BindingInfo' instead.")]
		ArgumentInfo = 1 << 0,
#endif
		BindingInfo = 1 << 0,
		/// <summary>Buffer Type Info.</summary>
		BufferTypeInfo,
		[iOS (14, 0)]
		[TV (14, 0)]
		[MacCatalyst (14, 0)]
		FailOnBinaryArchiveMiss = 4,
	}

	/// <summary>Enumerates the hardware feature sets that are available on a device.</summary>
	[Native]
	public enum MTLFeatureSet : ulong {
		/// <summary>The iOS GPU Family 1 v1 feature set.</summary>
#if XAMCORE_5_0
		[NoMacCatalyst]
#elif __MACCATALYST__
		[Obsolete ("Not available on the current platform.")]
#endif
		[NoTV, NoMac]
		iOS_GPUFamily1_v1 = 0,
		/// <summary>The iOS GPU Family 1 v2 feature set.</summary>
#if XAMCORE_5_0
		[NoMacCatalyst]
#elif __MACCATALYST__
		[Obsolete ("Not available on the current platform.")]
#endif
		[NoTV, NoMac]
		iOS_GPUFamily1_v2 = 2,
		/// <summary>The iOS GPU Family 2 v1 feature set.</summary>
#if XAMCORE_5_0
		[NoMacCatalyst]
#elif __MACCATALYST__
		[Obsolete ("Not available on the current platform.")]
#endif
		[NoTV, NoMac]
		iOS_GPUFamily2_v1 = 1,
		/// <summary>The iOS GPU Family 2 v2 feature set.</summary>
#if XAMCORE_5_0
		[NoMacCatalyst]
#elif __MACCATALYST__
		[Obsolete ("Not available on the current platform.")]
#endif
		[NoTV, NoMac]
		iOS_GPUFamily2_v2 = 3,
		/// <summary>The iOS GPU Family 3 v1 feature set.</summary>
#if XAMCORE_5_0
		[NoMacCatalyst]
#elif __MACCATALYST__
		[Obsolete ("Not available on the current platform.")]
#endif
		[NoTV, NoMac]
		iOS_GPUFamily3_v1 = 4,
		/// <summary>The iOS GPU Family 1 v3 feature set.</summary>
		[NoTV, NoMac, NoMacCatalyst]
		iOS_GPUFamily1_v3 = 5,
		/// <summary>The iOS GPU Family 2 v3 feature set.</summary>
		[NoTV, NoMac, NoMacCatalyst]
		iOS_GPUFamily2_v3 = 6,
		/// <summary>The iOS GPU Family 3 v2 feature set.</summary>
		[NoTV, NoMac, NoMacCatalyst]
		iOS_GPUFamily3_v2 = 7,
		/// <summary>The iOS GPU Family 1 v4 feature set.</summary>
		[NoTV, NoMac, NoMacCatalyst]
		iOS_GPUFamily1_v4 = 8,
		/// <summary>The iOS GPU Family 2 v4 feature set.</summary>
		[NoTV, NoMac, NoMacCatalyst]
		iOS_GPUFamily2_v4 = 9,
		/// <summary>The iOS GPU Family 3 v3 feature set.</summary>
		[NoTV, NoMac, NoMacCatalyst]
		iOS_GPUFamily3_v3 = 10,
		/// <summary>The iOS GPU Family 4 v1 feature set.</summary>
		[NoTV, NoMac, NoMacCatalyst]
		iOS_GPUFamily4_v1 = 11,

		/// <summary>i O S_ G P U Family1_v5.</summary>
		[NoTV, NoMac, NoMacCatalyst]
		iOS_GPUFamily1_v5 = 12,
		/// <summary>i O S_ G P U Family2_v5.</summary>
		[NoTV, NoMac, NoMacCatalyst]
		iOS_GPUFamily2_v5 = 13,
		/// <summary>i O S_ G P U Family3_v4.</summary>
		[NoTV, NoMac, NoMacCatalyst]
		iOS_GPUFamily3_v4 = 14,
		/// <summary>i O S_ G P U Family4_v2.</summary>
		[NoTV, NoMac, NoMacCatalyst]
		iOS_GPUFamily4_v2 = 15,
		/// <summary>i O S_ G P U Family5_v1.</summary>
		[NoTV, NoMac, NoMacCatalyst]
		iOS_GPUFamily5_v1 = 16,

		/// <summary>The macOS GPU Family 1 v1 feature set.</summary>
		[NoiOS, NoTV, NoMacCatalyst]
		macOS_GPUFamily1_v1 = 10000,

		/// <summary>The macOS GPU Family 1 v2 feature set.</summary>
		[NoiOS, NoTV]
		[NoMacCatalyst]
		macOS_GPUFamily1_v2 = 10001,

		/// <summary>The macOS read-write texture, tier 2 feature set.</summary>
		[NoiOS, NoTV]
		[NoMacCatalyst]
		macOS_ReadWriteTextureTier2 = 10002,

		/// <summary>The macOS GPU Family 1 v3 feature set.</summary>
		[NoiOS, NoTV]
		[NoMacCatalyst]
		macOS_GPUFamily1_v3 = 10003,

		[NoiOS, NoTV]
		[NoMacCatalyst]
		macOS_GPUFamily1_v4 = 10004,

		[NoiOS, NoTV]
		[NoMacCatalyst]
		macOS_GPUFamily2_v1 = 10005,

		/// <summary>The tvOS GPU Family 1 v1 feature set.</summary>
#if XAMCORE_5_0
		[NoMacCatalyst]
#elif __MACCATALYST__
		[Obsolete ("Not available on the current platform.")]
#endif
		[NoiOS, NoMac]
		tvOS_GPUFamily1_v1 = 30000,

		/// <summary>The TVOS GPU Family 1 v2 feature set.</summary>
		[NoiOS, NoMac]
		[NoMacCatalyst]
		tvOS_GPUFamily1_v2 = 30001,

		[NoiOS, NoMac]
		[NoMacCatalyst]
		tvOS_GPUFamily1_v3 = 30002,

		/// <summary>The TVOS GPU Family 2 v1 feature set.</summary>
		[NoiOS, NoMac]
		[NoMacCatalyst]
		tvOS_GPUFamily2_v1 = 30003,

		/// <summary>tv O S_ G P U Family1_v4.</summary>
		[NoiOS, NoMac]
		[NoMacCatalyst]
		tvOS_GPUFamily1_v4 = 30004,
		[NoiOS, NoMac]
		[NoMacCatalyst]
		tvOS_GPUFamily2_v2 = 30005,
	}

	/// <summary>Enumerates Metal shader programming language versions.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLLanguageVersion : ulong {
		/// <summary>Indicates version 1.0.</summary>
		[NoMac]
		[NoMacCatalyst]
		v1_0 = (1 << 16),
		/// <summary>Indicates version 1.1.</summary>
		v1_1 = (1 << 16) + 1,
		/// <summary>Indicates version 1.2.</summary>
		[MacCatalyst (13, 1)]
		v1_2 = (1 << 16) + 2,
		/// <summary>Indicates version 2.0.</summary>
		[MacCatalyst (13, 1)]
		v2_0 = (2 << 16),
		/// <summary>v2_1.</summary>
		[MacCatalyst (13, 1)]
		v2_1 = (2 << 16) + 1,
		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		v2_2 = (2 << 16) + 2,
		[iOS (14, 0), TV (14, 0)]
		[MacCatalyst (14, 0)]
		v2_3 = (2 << 16) + 3,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		v2_4 = (2uL << 16) + 4,
		[iOS (16, 0), TV (16, 0), MacCatalyst (16, 0), Mac (13, 0)]
		v3_0 = (3uL << 16) + 0,
		[iOS (17, 0), TV (17, 0), MacCatalyst (17, 0), Mac (14, 0)]
		v3_1 = (3uL << 16) + 1,
		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		v3_2 = (3ul << 16) + 2,
		[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
		v4_0 = (4uL << 16) + 0,
	}

	/// <summary>Enumerates values that indicate whether to clip or clamp depth values.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLDepthClipMode : ulong {
		/// <summary>Clip.</summary>
		Clip = 0,
		/// <summary>Clamp.</summary>
		Clamp = 1,
	}

	/// <summary>Enumerates blitting options.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	[Flags]
	public enum MTLBlitOption : ulong {
		/// <summary>Indicates that no blit option was specified.</summary>
		None = 0,
		/// <summary>Indicates that the depth attachment part of a depth/stencil resource will be blitted.</summary>
		DepthFromDepthStencil = 1 << 0,
		/// <summary>Indicates that the stencil attachment part of a depth/stencil resource will be blitted.</summary>
		StencilFromDepthStencil = 1 << 1,
		/// <summary>Indicates that compressed row-major, linearly arranged PVRTC texture data will be blitted.</summary>
		[NoMac]
		[MacCatalyst (13, 1)]
		RowLinearPvrtc = 1 << 2,
	}

	/// <summary>Enumerates CPU cache modes for resource mapping.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLStorageMode : ulong {
		/// <summary>Indicates that both the CPU and GPU can access the location of the resource.</summary>
		Shared = 0,
		/// <summary>Managed.</summary>
		[NoiOS]
		[NoTV]
		[NoMacCatalyst]
		Managed = 1,
		/// <summary>Indicates that only the GPU can access the location of the resource.</summary>
		Private = 2,
		/// <summary>Indicates the memory mode for an unbacked temporary render target.</summary>
		[NoMac]
		[MacCatalyst (13, 1)]
		Memoryless = 3,
	}

	/// <summary>Enumerates MSAA dept resolve filter operations.</summary>
	[Native]
	public enum MTLMultisampleDepthResolveFilter : ulong {
		/// <summary>Indicates that no filter is applied. Default.</summary>
		Sample0,
		/// <summary>Indicates that a minimum filter is applied, selecting the minimum depth sample for each pixel.</summary>
		Min,
		/// <summary>Indicates that a maximum filter is applied, selecting the largest depth sample for each pixel.</summary>
		Max,
	}

	[TV (16, 0)]
	[iOS (14, 0)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum MTLSamplerBorderColor : ulong {
		/// <summary>Transparent Black.</summary>
		TransparentBlack = 0,
		/// <summary>Opaque Black.</summary>
		OpaqueBlack = 1,
		/// <summary>Opaque White.</summary>
		OpaqueWhite = 2,
	}

	[TV (13, 0)]
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLPrimitiveTopologyClass : ulong {
		/// <summary>Unspecified.</summary>
		Unspecified = 0,
		/// <summary>Point.</summary>
		Point = 1,
		/// <summary>Line.</summary>
		Line = 2,
		/// <summary>Triangle.</summary>
		Triangle = 3,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLTessellationPartitionMode : ulong {
		/// <summary>Pow2.</summary>
		Pow2 = 0,
		/// <summary>Integer.</summary>
		Integer = 1,
		/// <summary>Fractional Odd.</summary>
		FractionalOdd = 2,
		/// <summary>Fractional Even.</summary>
		FractionalEven = 3,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLTessellationFactorFormat : ulong {
		/// <summary>Half.</summary>
		Half = 0,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLTessellationControlPointIndexType : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>U Int16.</summary>
		UInt16 = 1,
		/// <summary>U Int32.</summary>
		UInt32 = 2,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLTessellationFactorStepFunction : ulong {
		/// <summary>Constant.</summary>
		Constant = 0,
		/// <summary>Per Patch.</summary>
		PerPatch = 1,
		/// <summary>Per Instance.</summary>
		PerInstance = 2,
		/// <summary>Per Patch And Per Instance.</summary>
		PerPatchAndPerInstance = 3,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLPatchType : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Triangle.</summary>
		Triangle = 1,
		/// <summary>Quad.</summary>
		Quad = 2,
	}

	/// <summary>Enumerates formats for function attributes.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLAttributeFormat : ulong {
		/// <summary>Indicates an invalid format.</summary>
		Invalid = 0,
		/// <summary>Indicates two unsigned 8-bit characters.</summary>
		UChar2 = 1,
		/// <summary>Indicates three unsigned 8-bit characters.</summary>
		UChar3 = 2,
		/// <summary>Indicates four unsigned 8-bit characters..</summary>
		UChar4 = 3,
		/// <summary>Indicates two signed 8-bit characters.</summary>
		Char2 = 4,
		/// <summary>Indicates three signed 8-bit characters.</summary>
		Char3 = 5,
		/// <summary>Indicates four signed 8-bit characters.</summary>
		Char4 = 6,
		/// <summary>Indicates two normalized unsigned 8-bit characters.</summary>
		UChar2Normalized = 7,
		/// <summary>Indicates three normalized unsigned 8-bit characters.</summary>
		UChar3Normalized = 8,
		/// <summary>Indicates four normalized unsigned 8-bit characters.</summary>
		UChar4Normalized = 9,
		/// <summary>Indicates two normalized signed 8-bit characters.</summary>
		Char2Normalized = 10,
		/// <summary>Indicates three normalized signed 8-bit characters.</summary>
		Char3Normalized = 11,
		/// <summary>Indicates four normalized signed 8-bit characters.</summary>
		Char4Normalized = 12,
		/// <summary>Indicates two unsigned 16-bit two's complement values.</summary>
		UShort2 = 13,
		/// <summary>Indicates three unsigned 16-bit two's complement values.</summary>
		UShort3 = 14,
		/// <summary>Indicates four unsigned 16-bit two's complement values.</summary>
		UShort4 = 15,
		/// <summary>Indicates two signed 16-bit two's complement value.</summary>
		Short2 = 16,
		/// <summary>Indicates three signed 16-bit two's complement values.</summary>
		Short3 = 17,
		/// <summary>Indicates four signed 16-bit two's complement values.</summary>
		Short4 = 18,
		/// <summary>Indicates two normalized unsigned 16-bit two's complement values.</summary>
		UShort2Normalized = 19,
		/// <summary>Indicates three normalized unsigned 16-bit two's complement values.</summary>
		UShort3Normalized = 20,
		/// <summary>Indicates four normalized unsigned 16-bit two's complement values.</summary>
		UShort4Normalized = 21,
		/// <summary>Indicates two normalized signed 16-bit two's complement values.</summary>
		Short2Normalized = 22,
		/// <summary>Indicates three normalized signed 16-bit two's complement values.</summary>
		Short3Normalized = 23,
		/// <summary>Indicates four normalized signed 16-bit two's complement values.</summary>
		Short4Normalized = 24,
		/// <summary>Indicates two half-precision floating point values.</summary>
		Half2 = 25,
		/// <summary>Indicates three half-precision floating point values.</summary>
		Half3 = 26,
		/// <summary>Indicates four half-precision floating point values.</summary>
		Half4 = 27,
		/// <summary>Indicates one single-precision floating point value.</summary>
		Float = 28,
		/// <summary>Indicates two single-precision floating point values.</summary>
		Float2 = 29,
		/// <summary>Indicates three single-precision floating point values.</summary>
		Float3 = 30,
		/// <summary>Indicates four single-precision floating point values.</summary>
		Float4 = 31,
		/// <summary>Indicates a single signed 32-bit two's complement value.</summary>
		Int = 32,
		/// <summary>Indicates two signed 32-bit two's complement values.</summary>
		Int2 = 33,
		/// <summary>Indicates three signed 32-bit two's complement values.</summary>
		Int3 = 34,
		/// <summary>Indicates four signed 32-bit two's complement values.</summary>
		Int4 = 35,
		/// <summary>Indicates a single unsigned 32-bit two's complement value.</summary>
		UInt = 36,
		/// <summary>Indicates two unsigned 32-bit two's complement values.</summary>
		UInt2 = 37,
		/// <summary>Indicates three unsigned 32-bit two's complement values.</summary>
		UInt3 = 38,
		/// <summary>Indicates four unsigned 32-bit two's complement values.</summary>
		UInt4 = 39,
		/// <summary>Indicates a 10-10-10-2 scheme of packed normalized signed integers.</summary>
		Int1010102Normalized = 40,
		/// <summary>U Int1010102 Normalized.</summary>
		UInt1010102Normalized = 41,
		/// <summary>Indicates four unsigned 8-bit characters that describe BGRA channels.</summary>
		[MacCatalyst (13, 1)]
		UChar4Normalized_Bgra = 42,
		/// <summary>Indicates a single unsigned 8-bit character.</summary>
		[MacCatalyst (13, 1)]
		UChar = 45,
		/// <summary>Indicates a single signed 8-bit character.</summary>
		[MacCatalyst (13, 1)]
		Char = 46,
		/// <summary>Indicates a single unsigned 8-bit character.</summary>
		[MacCatalyst (13, 1)]
		UCharNormalized = 47,
		/// <summary>Indicates a single normalized signed 8-bit character.</summary>
		[MacCatalyst (13, 1)]
		CharNormalized = 48,
		/// <summary>Indicates a single unsigned 16-bit two's complement value.</summary>
		[MacCatalyst (13, 1)]
		UShort = 49,
		/// <summary>Indicates a single signed 16-bit two's complement value.</summary>
		[MacCatalyst (13, 1)]
		Short = 50,
		/// <summary>Indicates a single normalized unsigned 16-bit two's complement value.</summary>
		[MacCatalyst (13, 1)]
		UShortNormalized = 51,
		/// <summary>Indicates a single normalized signed 16-bit two's complement value.</summary>
		[MacCatalyst (13, 1)]
		ShortNormalized = 52,
		/// <summary>Indicates a single half-precision floating point value.</summary>
		[MacCatalyst (13, 1)]
		Half = 53,
		[Mac (14, 0), iOS (17, 0), TV (17, 0), MacCatalyst (17, 0)]
		FloatRG11B10 = 54,
		[Mac (14, 0), iOS (17, 0), TV (17, 0), MacCatalyst (17, 0)]
		FloatRGB9E5 = 55,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLStepFunction : ulong {
		/// <summary>Constant.</summary>
		Constant = 0,
		/// <summary>Per Vertex.</summary>
		PerVertex = 1,
		/// <summary>Per Instance.</summary>
		PerInstance = 2,
		/// <summary>Per Patch.</summary>
		PerPatch = 3,
		/// <summary>Per Patch Control Point.</summary>
		PerPatchControlPoint = 4,
		/// <summary>Thread Position In Grid X.</summary>
		ThreadPositionInGridX = 5,
		/// <summary>Thread Position In Grid Y.</summary>
		ThreadPositionInGridY = 6,
		/// <summary>Thread Position In Grid X Indexed.</summary>
		ThreadPositionInGridXIndexed = 7,
		/// <summary>Thread Position In Grid Y Indexed.</summary>
		ThreadPositionInGridYIndexed = 8,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLRenderStages : ulong {
		/// <summary>Vertex.</summary>
		Vertex = (1 << 0),
		/// <summary>Fragment.</summary>
		Fragment = (1 << 1),
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		Tile = (1uL << 2),

		[iOS (16, 0), TV (16, 0), Mac (13, 0), MacCatalyst (16, 0)]
		Object = (1uL << 3),
		[iOS (16, 0), TV (16, 0), Mac (13, 0), MacCatalyst (16, 0)]
		Mesh = (1uL << 4),
	}

	/// <summary>Enumerates resource usage patterns.</summary>
	[MacCatalyst (13, 1)]
	[Native, Flags]
	public enum MTLResourceUsage : ulong {
		/// <summary>Indicates reading operations.</summary>
		Read = 1 << 0,
		/// <summary>Indicate writing operations.</summary>
		Write = 1 << 1,
		/// <summary>Indicates sampling operations.</summary>
		Sample = 1 << 2,
	}

	/// <summary>Enumerates buffer mutability descriptions.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLMutability : ulong {
		/// <summary>Indicates the default mutability of the buffer, by tupe.</summary>
		Default = 0,
		/// <summary>Indicates a mutable buffer.</summary>
		Mutable = 1,
		/// <summary>Indicates an immutable buffer.</summary>
		Immutable = 2,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLReadWriteTextureTier : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>One.</summary>
		One = 1,
		/// <summary>Two.</summary>
		Two = 2,
	}

	/// <summary>Enumerates argument buffer tiers.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLArgumentBuffersTier : ulong {
		/// <summary>Indicates tier one.</summary>
		One = 0,
		/// <summary>Indicates tier two.</summary>
		Two = 1,
	}

	/// <summary>Enumerates store action options.</summary>
	[MacCatalyst (13, 1)]
	[Native, Flags]
	public enum MTLStoreActionOptions : ulong {
		/// <summary>Indicates no store action modification.</summary>
		None = 0,
		/// <summary>Indicates that data will be stored in a way that does not consider the sample position.</summary>
		CustomSamplePositions = 1 << 0,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLDispatchType : ulong {
		/// <summary>Serial.</summary>
		Serial,
		/// <summary>Concurrent.</summary>
		Concurrent,
	}

	[Flags]
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLBarrierScope : ulong {
		/// <summary>Buffers.</summary>
		Buffers = 1 << 0,
		/// <summary>Textures.</summary>
		Textures = 1 << 1,
		/// <summary>Render Targets.</summary>
		[NoiOS, NoTV]
		[NoMacCatalyst]
		RenderTargets = 1 << 2,
	}

	[Flags]
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLIndirectCommandType : ulong {
		/// <summary>Draw.</summary>
		Draw = 1 << 0,
		/// <summary>Draw Indexed.</summary>
		DrawIndexed = 1 << 1,
		/// <summary>Draw Patches.</summary>
		[TV (14, 5)]
		[MacCatalyst (13, 1)]
		DrawPatches = 1 << 2,
		/// <summary>Draw Indexed Patches.</summary>
		[TV (14, 5)]
		[MacCatalyst (13, 1)]
		DrawIndexedPatches = 1 << 3,
		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		ConcurrentDispatch = 1 << 5,
		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		ConcurrentDispatchThreads = 1 << 6,
		[NoMac, iOS (17, 0), TV (18, 1), MacCatalyst (17, 0)]
		DrawMeshThreadgroups = (1uL << 7),
		[NoMac, iOS (17, 0), TV (18, 1), MacCatalyst (17, 0)]
		DrawMeshThreads = (1uL << 8),
	}

	[TV (14, 5)]
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLMultisampleStencilResolveFilter : ulong {
		/// <summary>Sample0.</summary>
		Sample0 = 0,
		/// <summary>Depth Resolved Sample.</summary>
		DepthResolvedSample = 1,
	}


	[Flags, TV (17, 0), iOS (13, 0)]
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLSparseTextureRegionAlignmentMode : ulong {
		Outward = 0x0,
		Inward = 0x1,
	}

	[Flags, TV (17, 0), iOS (13, 0)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum MTLSparseTextureMappingMode : ulong {
		Map = 0x0,
		Unmap = 0x1,
	}

	[iOS (13, 0)]
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLHazardTrackingMode : ulong {
		Default = 0,
		Untracked = 1,
		Tracked = 2,
	}

	[TV (13, 0), iOS (13, 0)]
	[MacCatalyst (13, 1)]
	[Native]
	[ErrorDomain ("MTLCaptureErrorDomain")]
	public enum MTLCaptureError : long {
		NotSupported = 1,
		AlreadyCapturing,
		InvalidDescriptor,
	}

	[TV (13, 0), iOS (13, 0)]
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLGpuFamily : long {
		Apple1 = 1001,
		Apple2 = 1002,
		Apple3 = 1003,
		Apple4 = 1004,
		Apple5 = 1005,
		[NoTV, iOS (14, 0)]
		[MacCatalyst (14, 0)]
		Apple6 = 1006,
		[NoTV, iOS (14, 0)]
		[MacCatalyst (14, 0)]
		Apple7 = 1007,
		Apple8 = 1008,
		[NoTV]
		Apple9 = 1009,
		[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
		Apple10 = 1010,
		Mac1 = 2001,
		Mac2 = 2002,
		Common1 = 3001,
		Common2 = 3002,
		Common3 = 3003,
		iOSMac1 = 4001,
		iOSMac2 = 4002,

		[iOS (16, 0), TV (16, 0), MacCatalyst (16, 0), Mac (13, 0)]
		Metal3 = 5001,
		[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
		Metal4 = 5002,
	}

	[TV (13, 0), iOS (13, 0)]
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLHeapType : long {
		Automatic = 0,
		Placement = 1,
		[TV (16, 0)]
		[MacCatalyst (13, 1)]
		Sparse = 2,
	}

	[iOS (13, 0), TV (13, 0)]
	[MacCatalyst (13, 1)]
	[Native]
	public enum MTLCaptureDestination : long {
		DeveloperTools = 1,
		GpuTraceDocument,
	}

	[NoiOS, NoTV]
	[NoMacCatalyst]
	[Native]
	public enum MTLDeviceLocation : ulong {
		BuiltIn = 0,
		Slot = 1,
		External = 2,
		Unspecified = ulong.MaxValue,
	}

	[iOS (14, 0), TV (14, 0)]
	[MacCatalyst (14, 0)]
	[Native]
	[ErrorDomain ("MTLCounterErrorDomain")]
	public enum MTLCounterSampleBufferError : long {
		OutOfMemory,
		Invalid = 1,
		Internal = 2,
	}

	[iOS (14, 0), TV (14, 0)]
	[MacCatalyst (14, 0)]
	public enum MTLCommonCounter {
		[Field ("MTLCommonCounterTimestamp")]
		Timestamp,

		[Field ("MTLCommonCounterTessellationInputPatches")]
		TessellationInputPatches,

		[Field ("MTLCommonCounterVertexInvocations")]
		VertexInvocations,

		[Field ("MTLCommonCounterPostTessellationVertexInvocations")]
		PostTessellationVertexInvocations,

		[Field ("MTLCommonCounterClipperInvocations")]
		ClipperInvocations,

		[Field ("MTLCommonCounterClipperPrimitivesOut")]
		ClipperPrimitivesOut,

		[Field ("MTLCommonCounterFragmentInvocations")]
		FragmentInvocations,

		[Field ("MTLCommonCounterFragmentsPassed")]
		FragmentsPassed,

		[Field ("MTLCommonCounterComputeKernelInvocations")]
		ComputeKernelInvocations,

		[Field ("MTLCommonCounterTotalCycles")]
		TotalCycles,

		[Field ("MTLCommonCounterVertexCycles")]
		VertexCycles,

		[Field ("MTLCommonCounterTessellationCycles")]
		TessellationCycles,

		[Field ("MTLCommonCounterPostTessellationVertexCycles")]
		PostTessellationVertexCycles,

		[Field ("MTLCommonCounterFragmentCycles")]
		FragmentCycles,

		[Field ("MTLCommonCounterRenderTargetWriteCycles")]
		RenderTargetWriteCycles,

		[Field ("MTLCommonCounterSetTimestamp")]
		SetTimestamp,

		[Field ("MTLCommonCounterSetStageUtilization")]
		SetStageUtilization,

		[Field ("MTLCommonCounterSetStatistic")]
		SetStatistic,
	}

	[Flags, iOS (14, 0), TV (14, 0)]
	[MacCatalyst (14, 0)]
	public enum MTLAccelerationStructureInstanceOptions : uint {
		None = 0x0,
		DisableTriangleCulling = (1u << 0),
		TriangleFrontFacingWindingCounterClockwise = (1u << 1),
		Opaque = (1u << 2),
		NonOpaque = (1u << 3),
	}

	[iOS (14, 0), TV (16, 0)]
	[MacCatalyst (14, 0)]
	[Flags]
	[Native]
	public enum MTLAccelerationStructureUsage : ulong {
		None = 0x0,
		Refit = (1uL << 0),
		PreferFastBuild = (1uL << 1),
		[iOS (15, 0), MacCatalyst (15, 0), TV (16, 0)]
		ExtendedLimits = (1uL << 2),
		[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
		PreferFastIntersection = (1uL << 4),
		[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
		MinimizeMemory = (1uL << 5),
	}

	[iOS (14, 0), TV (14, 0)]
	[MacCatalyst (14, 0)]
	[ErrorDomain ("MTLBinaryArchiveDomain")]
	[Native]
	public enum MTLBinaryArchiveError : ulong {
		None = 0,
		InvalidFile = 1,
		UnexpectedElement = 2,
		CompilationFailure = 3,
		InternalError = 4,
	}

	[iOS (14, 0), TV (14, 0)]
	[MacCatalyst (14, 0)]
	[Flags]
	[Native]
	public enum MTLCommandBufferErrorOption : ulong {
		None = 0x0,
		EncoderExecutionStatus = 1uL << 0,
	}

	[iOS (14, 0), TV (14, 0)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum MTLCommandEncoderErrorState : long {
		Unknown = 0,
		Completed = 1,
		Affected = 2,
		Pending = 3,
		Faulted = 4,
	}

	[iOS (14, 0), TV (14, 0)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum MTLCounterSamplingPoint : ulong {
		StageBoundary,
		DrawBoundary,
		DispatchBoundary,
		TileDispatchBoundary,
		BlitBoundary,
	}

	[iOS (14, 0), TV (14, 0)]
	[MacCatalyst (14, 0)]
	[ErrorDomain ("MTLDynamicLibraryDomain")]
	[Native]
	public enum MTLDynamicLibraryError : ulong {
		None = 0,
		InvalidFile = 1,
		CompilationFailure = 2,
		UnresolvedInstallName = 3,
		DependencyLoadFailure = 4,
		Unsupported = 5,
	}

	[iOS (14, 0), TV (14, 0)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum MTLFunctionLogType : ulong {
		Validation = 0,
	}

	[Flags, iOS (14, 0), TV (14, 0)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum MTLFunctionOptions : ulong {
		None = 0x0,
		[TV (16, 0)]
		[MacCatalyst (14, 0)]
		CompileToBinary = 1uL << 0,
		[iOS (17, 0), TV (17, 0), MacCatalyst (17, 0), Mac (14, 0)]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'StoreFunctionInMetalPipelinesScript' instead.")]
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'StoreFunctionInMetalPipelinesScript' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'StoreFunctionInMetalPipelinesScript' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'StoreFunctionInMetalPipelinesScript' instead.")]
		StoreFunctionInMetalScript = 1uL << 1,
		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		StoreFunctionInMetalPipelinesScript = 1 << 1,
		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		FailOnBinaryArchiveMiss = 1 << 2,
		[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
		PipelineIndependent = 1uL << 3,
	}

	[Flags, iOS (14, 0), TV (16, 0)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum MTLIntersectionFunctionSignature : ulong {
		None = 0x0,
		Instancing = (1uL << 0),
		TriangleData = (1uL << 1),
		WorldSpaceData = (1uL << 2),
		[iOS (15, 0), MacCatalyst (15, 0)]
		InstanceMotion = (1uL << 3),
		[iOS (15, 0), MacCatalyst (15, 0)]
		PrimitiveMotion = (1uL << 4),
		[iOS (15, 0), MacCatalyst (15, 0)]
		ExtendedLimits = (1uL << 5),
		[Mac (14, 0), iOS (17, 0), TV (17, 0), MacCatalyst (17, 0)]
		MaxLevels = (1uL << 6),
		[Mac (14, 0), iOS (17, 0), TV (17, 0), MacCatalyst (17, 0)]
		CurveData = (1uL << 7),
		[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
		IntersectionFunctionBuffer = (1uL << 8),
		[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
		UserData = (1uL << 9),
	}

	[iOS (14, 0), TV (14, 0)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum MTLLibraryType : long {
		Executable = 0,
		Dynamic = 1,
	}

	[iOS (13, 0), TV (13, 0)]
	[MacCatalyst (13, 1)]
	public enum MTLTextureSwizzle : byte {
		Zero = 0,
		One = 1,
		Red = 2,
		Green = 3,
		Blue = 4,
		Alpha = 5,
	}

	[iOS (15, 0), MacCatalyst (15, 0), TV (17, 0)]
	public enum MTLMotionBorderMode : uint {
		Clamp = 0,
		Vanish = 1,
	}

	[iOS (15, 0), MacCatalyst (15, 0), TV (16, 0)]
	[Native]
	public enum MTLAccelerationStructureInstanceDescriptorType : ulong {
		Default = 0,
		UserID = 1,
		Motion = 2,
		[Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0), TV (17, 0)]
		Indirect = 3,
		[Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0), TV (17, 0)]
		IndirectMotion = 4,
	}

	[Mac (12, 5), iOS (15, 0), MacCatalyst (15, 0), TV (17, 0)]
	[Native]
	public enum MTLTextureCompressionType : long {
		Lossless = 0,
		Lossy = 1,
	}

	[Flags, Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
	[Native]
	public enum MTLAccelerationStructureRefitOptions : ulong {
		VertexData = (1uL << 0),
		PerPrimitiveData = (1uL << 1),
	}

	[iOS (14, 0), MacCatalyst (14, 0), TV (14, 0)]
	[Native]
	public enum MTLBindingType : long {
		Buffer = 0,
		ThreadgroupMemory = 1,
		Texture = 2,
		Sampler = 3,
		ImageblockData = 16,
		Imageblock = 17,
		VisibleFunctionTable = 24,
		PrimitiveAccelerationStructure = 25,
		InstanceAccelerationStructure = 26,
		IntersectionFunctionTable = 27,
		ObjectPayload = 34,
		[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
		Tensor = 37,
	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
	[Native]
	public enum MTLIOCommandQueueType : long {
		Concurrent = 0,
		Serial = 1,
	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
	[Native]
	public enum MTLIOCompressionMethod : long {
		Zlib = 0,
		Lzfse = 1,
		Lz4 = 2,
		Lzma = 3,
		LzBitmap = 4,
	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
	[Native]
	public enum MTLIOCompressionStatus : long {
		Complete = 0,
		Error = 1,
	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
	[Native]
	[ErrorDomain ("MTLIOErrorDomain")]
	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	public enum MTLIOError : long {
		UrlInvalid = 1,
		Internal = 2,
	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
	[Native]
	public enum MTLIOPriority : long {
		High = 0,
		Normal = 1,
		Low = 2,
	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
	[Native]
	public enum MTLIOStatus : long {
		Pending = 0,
		Cancelled = 1,
		Error = 2,
		Complete = 3,
	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
	[Native]
	public enum MTLLibraryOptimizationLevel : long {
		Default = 0,
		Size = 1,
	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
	[Native]
	public enum MTLSparsePageSize : long {
		Size16 = 101,
		Size64 = 102,
		Size256 = 103,
	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
	[Native]
	public enum MTLBindingAccess : long {
		ReadOnly = 0,
		ReadWrite = 1,
		WriteOnly = 2,
	}

	[Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0), TV (17, 0)]
	[Native]
	public enum MTLCurveType : long {
		Round = 0,
		Flat = 1,
	}

	[Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0), TV (17, 0)]
	[Native]
	public enum MTLCurveBasis : long {
		BSpline = 0,
		CatmullRom = 1,
		Linear = 2,
		Bezier = 3,
	}

	[Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0), TV (17, 0)]
	[Native]
	public enum MTLCurveEndCaps : long {
		None = 0,
		Disk = 1,
		Sphere = 2,
	}

	[Mac (13, 3), iOS (16, 4), MacCatalyst (16, 4), TV (16, 4)]
	[Native]
	public enum MTLCompileSymbolVisibility : long {
		Default = 0,
		Hidden = 1,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTL4AlphaToCoverageState : long {
		Disabled = 0,
		Enabled = 1,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTL4AlphaToOneState : long {
		Disabled = 0,
		Enabled = 1,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTL4BinaryFunctionOptions : ulong {
		None = 0x0,
		PipelineIndependent = 1uL << 1,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTL4BlendState : long {
		Disabled = 0,
		Enabled = 1,
		Unspecialized = 2,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	[ErrorDomain ("MTL4CommandQueueErrorDomain")]
	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	public enum MTL4CommandQueueError : long {
		None = 0,
		Timeout = 1,
		NotPermitted = 2,
		OutOfMemory = 3,
		DeviceRemoved = 4,
		AccessRevoked = 5,
		Internal = 6,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTL4CompilerTaskStatus : long {
		None = 0,
		Scheduled = 1,
		Compiling = 2,
		Finished = 3,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTL4CounterHeapType : long {
		Invalid,
		Timestamp,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTL4IndirectCommandBufferSupportState : long {
		Disabled = 0,
		Enabled = 1,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTL4LogicalToPhysicalColorAttachmentMappingState : long {
		Identity = 0,
		Inherited = 1,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Flags]
	[Native]
	public enum MTL4PipelineDataSetSerializerConfiguration : ulong {
		Descriptors = (1 << 0),
		Binaries = (1 << 1),
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTL4RenderEncoderOptions : ulong {
		None = 0x0,
		Suspending = (1uL << 0),
		Resuming = (1uL << 1),
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTL4ShaderReflection : ulong {
		None = 0x0,
		BindingInfo = 1uL << 0,
		BufferTypeInfo = 1uL << 1,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTL4TimestampGranularity : long {
		Relaxed = 0,
		Precise = 1,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	[Flags]
	public enum MTL4VisibilityOptions : ulong {
		None = 0,
		Device = 1 << 0,
		ResourceAlias = 1 << 1,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTLBufferSparseTier : long {
		None = 0,
		MTLBufferSparseTier1 = 1,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTLStages : ulong {
		Vertex = 1uL << 0,
		Fragment = 1uL << 1,
		Tile = 1uL << 2,
		Object = 1uL << 3,
		Mesh = 1uL << 4,
		ResourceState = 1uL << 26,
		Dispatch = 1uL << 27,
		Blit = 1uL << 28,
		AccelerationStructure = 1uL << 29,
		MachineLearning = 1uL << 30,
		All = 0x7fffffffffffffffL,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTLTensorDataType : long {
		None = (long) MTLDataType.None,
		Float32 = (long) MTLDataType.Float,
		Float16 = (long) MTLDataType.Half,
		BFloat16 = (long) MTLDataType.BFloat,
		Int8 = (long) MTLDataType.Char,
		UInt8 = (long) MTLDataType.UChar,
		Int16 = (long) MTLDataType.Short,
		UInt16 = (long) MTLDataType.UShort,
		Int32 = (long) MTLDataType.Int,
		UInt32 = (long) MTLDataType.UInt,
		[iOS (26, 4), TV (26, 4), Mac (26, 4), MacCatalyst (26, 4)]
		Int4 = 143,
		[iOS (26, 4), TV (26, 4), Mac (26, 4), MacCatalyst (26, 4)]
		UInt4 = 144,
	}

	[iOS (26, 4), TV (26, 4), Mac (26, 4), MacCatalyst (26, 4)]
	[Native]
	[ErrorDomain ("MTLDeviceErrorDomain")]
	public enum MTLDeviceError : long {
		None = 0,
		NotSupported = 1,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	[ErrorDomain ("MTLTensorDomain")]
	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	public enum MTLTensorError : long {
		None = 0,
		InternalError = 1,
		InvalidDescriptor = 2,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	[Flags]
	public enum MTLTensorUsage : ulong {
		Compute = 1L << 0,
		Render = 1L << 1,
		MachineLearning = 1L << 2,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTLTextureSparseTier : long {
		None = 0,
		Tier1 = 1,
		Tier2 = 2,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTLVisibilityResultType : long {
		Reset = 0,
		Accumulate = 1,
	}

	[Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0), TV (26, 0)]
	[Native]
	public enum MTLSamplerReductionMode : ulong {
		WeightedAverage = 0,
		Minimum = 1,
		Maximum = 2,
	}
}
