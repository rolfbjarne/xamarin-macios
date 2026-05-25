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
	/// <summary>Enumerates formats for function attributes.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
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
		/// <summary>To be added.</summary>
		UInt1010102Normalized = 41,
		/// <summary>Indicates four unsigned 8-bit characters that describe BGRA channels.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		UChar4Normalized_Bgra = 42,
		/// <summary>Indicates a single unsigned 8-bit character.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		UChar = 45,
		/// <summary>Indicates a single signed 8-bit character.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Char = 46,
		/// <summary>Indicates a single unsigned 8-bit character.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		UCharNormalized = 47,
		/// <summary>Indicates a single normalized signed 8-bit character.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		CharNormalized = 48,
		/// <summary>Indicates a single unsigned 16-bit two's complement value.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		UShort = 49,
		/// <summary>Indicates a single signed 16-bit two's complement value.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Short = 50,
		/// <summary>Indicates a single normalized unsigned 16-bit two's complement value.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		UShortNormalized = 51,
		/// <summary>Indicates a single normalized signed 16-bit two's complement value.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ShortNormalized = 52,
		/// <summary>Indicates a single half-precision floating point value.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Half = 53,
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		FloatRG11B10 = 54,
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		FloatRGB9E5 = 55,
	}
}
