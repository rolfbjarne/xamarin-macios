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
namespace ModelIO {
	/// <summary>Enumerates vertex data descriptions.</summary>
	[Native]
	public enum MDLVertexFormat : ulong {
		/// <summary>Indicates an invalid format.</summary>
		Invalid = 0,
		/// <summary>Indicates a packed vector format.</summary>
		PackedBits = 4096,
		/// <summary>Indicates unsigned two's complement 8-bit values.</summary>
		UCharBits = 65536,
		/// <summary>Indicate 8-bit signed integer values.</summary>
		CharBits = 131072,
		/// <summary>Indicates normalized unsigned two's complement 8-bit values.</summary>
		UCharNormalizedBits = 196608,
		/// <summary>Indicates a normalized 8-bit value.</summary>
		CharNormalizedBits = 262144,
		/// <summary>Indicates 16-bit unsigned two's complement value.</summary>
		UShortBits = 327680,
		/// <summary>Indicates 16-bit signed two's complement values.</summary>
		ShortBits = 393216,
		/// <summary>Indicates 16-bit normalized unsigned two's complement value.</summary>
		UShortNormalizedBits = 458752,
		/// <summary>Indicates 16-bit signed two's complement values.</summary>
		ShortNormalizedBits = 524288,
		/// <summary>Indicates 32-bit unsigned integer values.</summary>
		UIntBits = 589824,
		/// <summary>Indicates 32-bit two's complement values.</summary>
		IntBits = 655360,
		/// <summary>Indicates half-precision floating point values.</summary>
		HalfBits = 720896,
		/// <summary>Indicates single-precision floating point values.</summary>
		FloatBits = 786432,
		/// <summary>Indicates one unsigned two's complement 8-bit value.</summary>
		UChar = 65537,
		/// <summary>Indicates two unsigned two's complement 8-bit values.</summary>
		UChar2 = 65538,
		/// <summary>Indicates three unsigned two's complement 8-bit values.</summary>
		UChar3 = 65539,
		/// <summary>Indicates four unsigned two's complement 8-bit values.</summary>
		UChar4 = 65540,
		/// <summary>Indicates a signed two's complement 8-bit value.</summary>
		Char = 131073,
		/// <summary>Indicates two signed two's complement 8-bit values.</summary>
		Char2 = 131074,
		/// <summary>Indicates three signed two's complement 8-bit values.</summary>
		Char3 = 131075,
		/// <summary>Indicates four signed two's complement 8-bit values.</summary>
		Char4 = 131076,
		/// <summary>Indicates one normalized unsigned two's complement 8-bit values.</summary>
		UCharNormalized = 196609,
		/// <summary>Indicates two normalized unsigned two's complement 8-bit values.</summary>
		UChar2Normalized = 196610,
		/// <summary>Indicates three normalized unsigned two's complement 8-bit values.</summary>
		UChar3Normalized = 196611,
		/// <summary>Indicates four normalized unsigned two's complement 8-bit values.</summary>
		UChar4Normalized = 196612,
		/// <summary>Indicates a normalized 8-bit value.</summary>
		CharNormalized = 262145,
		/// <summary>Indicates two normalized 8-bit values.</summary>
		Char2Normalized = 262146,
		/// <summary>Indicates three normalized 8-bit values.</summary>
		Char3Normalized = 262147,
		/// <summary>Indicates four normalized 8-bit values.</summary>
		Char4Normalized = 262148,
		/// <summary>Indicates one 16-bit signed two's complement values.</summary>
		UShort = 327681,
		/// <summary>Indicates two 16-bit unsigned two's complement values.</summary>
		UShort2 = 327682,
		/// <summary>Indicates three 16-bit unsigned two's complement values.</summary>
		UShort3 = 327683,
		/// <summary>Indicates four 16-bit unsigned two's complement values.</summary>
		UShort4 = 327684,
		/// <summary>Indicates one 16-bit signed two's complement value.</summary>
		Short = 393217,
		/// <summary>Indicates two 16-bit signed two's complement values.</summary>
		Short2 = 393218,
		/// <summary>Indicates three 16-bit signed two's complement values.</summary>
		Short3 = 393219,
		/// <summary>Indicates four 16-bit signed two's complement values.</summary>
		Short4 = 393220,
		/// <summary>Indicates one 16-bit normalized unsigned two's complement value.</summary>
		UShortNormalized = 458753,
		/// <summary>Indicates two 16-bit normalized unsigned two's complement values.</summary>
		UShort2Normalized = 458754,
		/// <summary>Indicates three 16-bit normalized unsigned two's complement values.</summary>
		UShort3Normalized = 458755,
		/// <summary>Indicates four 16-bit normalized unsigned two's complement values.</summary>
		UShort4Normalized = 458756,
		/// <summary>Indicates one normalized 16-bit signed two's complement value.</summary>
		ShortNormalized = 524289,
		/// <summary>Indicates two normalized 16-bit signed two's complement values.</summary>
		Short2Normalized = 524290,
		/// <summary>Indicates three normalized 16-bit signed two's complement values.</summary>
		Short3Normalized = 524291,
		/// <summary>Indicates four normalized 16-bit signed two's complement values.</summary>
		Short4Normalized = 524292,
		/// <summary>Indicates one 32-bit unsigned integer value.</summary>
		UInt = 589825,
		/// <summary>Indicates two 32-bit unsigned integer values.</summary>
		UInt2 = 589826,
		/// <summary>Indicates three 32-bit unsigned integer values.</summary>
		UInt3 = 589827,
		/// <summary>Indicates four 32-bit unsigned integer values.</summary>
		UInt4 = 589828,
		/// <summary>Indicates one 32-bit two's complement value.</summary>
		Int = 655361,
		/// <summary>Indicates two 32-bit two's complement values.</summary>
		Int2 = 655362,
		/// <summary>Indicates three 32-bit two's complement values.</summary>
		Int3 = 655363,
		/// <summary>Indicates four 32-bit two's complement values.</summary>
		Int4 = 655364,
		/// <summary>Indicates one half-precision floating point value.</summary>
		Half = 720897,
		/// <summary>Indicates two half-precision floating point values.</summary>
		Half2 = 720898,
		/// <summary>Indicates three half-precision floating point values.</summary>
		Half3 = 720899,
		/// <summary>Indicates four half-precision floating point values.</summary>
		Half4 = 720900,
		/// <summary>Indicates one single-precision floating point value.</summary>
		Float = 786433,
		/// <summary>Indicates two single-precision floating point values.</summary>
		Float2 = 786434,
		/// <summary>Indicates three single-precision floating point values.</summary>
		Float3 = 786435,
		/// <summary>Indicates four single-precision floating point values.</summary>
		Float4 = 786436,
		/// <summary>Indicates a packed 32-bit value with four signed two's complement integers arranged 10/10/10/2.</summary>
		Int1010102Normalized = 659460,
		/// <summary>Indicates a packed 32-bit value with four unsigned two's complement integers arranged 10/10/10/2.</summary>
		UInt1010102Normalized = 593924,
	}
}
