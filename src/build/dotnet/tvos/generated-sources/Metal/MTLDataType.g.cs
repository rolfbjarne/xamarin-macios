//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Metal {
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
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Texture = 58,
		/// <summary>Indicates a sampler.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Sampler = 59,
		/// <summary>Indicates a pointer.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Pointer = 60,
		/// <summary>Indicates an unsigned 8-bit normalized integer.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		R8Unorm = 62,
		/// <summary>Indicates a signed 8-bit normalized integer.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		R8Snorm = 63,
		/// <summary>Indicates an unsigned 16-bit normalized integer.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		R16Unorm = 64,
		/// <summary>Indicates a signed 16-bit normalized integer.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		R16Snorm = 65,
		/// <summary>Indicates a value that contains two unsigned 8-bit normalized integer components.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		Rg8Unorm = 66,
		/// <summary>Indicates a value that contains two signed 8-bit normalized integer components.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		Rg8Snorm = 67,
		/// <summary>Indicates a value that contains two unsigned 16-bit normalized integer components.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		Rg16Unorm = 68,
		/// <summary>Indicates a value that contains two signed 16-bit normalized integer components.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		Rg16Snorm = 69,
		/// <summary>Indicates a value that contains four unsigned 8-bit normalized integer components.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		Rgba8Unorm = 70,
		/// <summary>Indicates normalized unsigned 8-bit RGBA values, convertible to sRGB.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		Rgba8Unorm_sRgb = 71,
		/// <summary>Indicates a value that contains four signed 8-bit normalized integer components.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		Rgba8Snorm = 72,
		/// <summary>Indicates a value that contains four unsigned 16-bit normalized integer components.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		Rgba16Unorm = 73,
		/// <summary>Indicates a value that contains four signed 16-bit normalized integer components.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		Rgba16Snorm = 74,
		/// <summary>Indicates a packed RGBA normalized integer value with 10 bits each for RGB and 2 bits for A.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		Rgb10A2Unorm = 75,
		/// <summary>Indicates a 32-bit packed floating point RGB value with 11 bits for R and G and 10 bits for B.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		Rg11B10Float = 76,
		/// <summary>Indicates a packed RGBE normalized floating point value with 9 bits each for R, G, and B, with a 5-bit exponent.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		Rgb9E5Float = 77,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RenderPipeline = 78,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		ComputePipeline = 79,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		IndirectCommandBuffer = 80,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Long = 81,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Long2 = 82,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Long3 = 83,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Long4 = 84,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ULong = 85,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ULong2 = 86,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ULong3 = 87,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ULong4 = 88,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos")]
		VisibleFunctionTable = 115,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos")]
		IntersectionFunctionTable = 116,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos")]
		PrimitiveAccelerationStructure = 117,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos")]
		InstanceAccelerationStructure = 118,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		BFloat = 121,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		BFloat2 = 122,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		BFloat3 = 123,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		BFloat4 = 124,
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		DepthStencilState = 139,
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		Tensor = 140,
	}
}
