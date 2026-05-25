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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Metal {
	/// <summary>Enumerates vertex data formats (type and number).</summary>
	[Native]
	public enum MTLVertexFormat : ulong {
		/// <summary>To be added.</summary>
		Invalid = 0,
		/// <summary>To be added.</summary>
		UChar2 = 1,
		/// <summary>To be added.</summary>
		UChar3 = 2,
		/// <summary>To be added.</summary>
		UChar4 = 3,
		/// <summary>To be added.</summary>
		Char2 = 4,
		/// <summary>To be added.</summary>
		Char3 = 5,
		/// <summary>To be added.</summary>
		Char4 = 6,
		/// <summary>To be added.</summary>
		UChar2Normalized = 7,
		/// <summary>To be added.</summary>
		UChar3Normalized = 8,
		/// <summary>To be added.</summary>
		UChar4Normalized = 9,
		/// <summary>To be added.</summary>
		Char2Normalized = 10,
		/// <summary>To be added.</summary>
		Char3Normalized = 11,
		/// <summary>To be added.</summary>
		Char4Normalized = 12,
		/// <summary>To be added.</summary>
		UShort2 = 13,
		/// <summary>To be added.</summary>
		UShort3 = 14,
		/// <summary>To be added.</summary>
		UShort4 = 15,
		/// <summary>To be added.</summary>
		Short2 = 16,
		/// <summary>To be added.</summary>
		Short3 = 17,
		/// <summary>To be added.</summary>
		Short4 = 18,
		/// <summary>To be added.</summary>
		UShort2Normalized = 19,
		/// <summary>To be added.</summary>
		UShort3Normalized = 20,
		/// <summary>To be added.</summary>
		UShort4Normalized = 21,
		/// <summary>To be added.</summary>
		Short2Normalized = 22,
		/// <summary>To be added.</summary>
		Short3Normalized = 23,
		/// <summary>To be added.</summary>
		Short4Normalized = 24,
		/// <summary>To be added.</summary>
		Half2 = 25,
		/// <summary>To be added.</summary>
		Half3 = 26,
		/// <summary>To be added.</summary>
		Half4 = 27,
		/// <summary>To be added.</summary>
		Float = 28,
		/// <summary>To be added.</summary>
		Float2 = 29,
		/// <summary>To be added.</summary>
		Float3 = 30,
		/// <summary>To be added.</summary>
		Float4 = 31,
		/// <summary>To be added.</summary>
		Int = 32,
		/// <summary>To be added.</summary>
		Int2 = 33,
		/// <summary>To be added.</summary>
		Int3 = 34,
		/// <summary>To be added.</summary>
		Int4 = 35,
		/// <summary>To be added.</summary>
		UInt = 36,
		/// <summary>To be added.</summary>
		UInt2 = 37,
		/// <summary>To be added.</summary>
		UInt3 = 38,
		/// <summary>To be added.</summary>
		UInt4 = 39,
		/// <summary>To be added.</summary>
		Int1010102Normalized = 40,
		/// <summary>To be added.</summary>
		UInt1010102Normalized = 41,
		/// <summary>Indicates four unsigned 8-bit characters that describe BGRA channels.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		UChar4NormalizedBgra = 42,
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
		/// <summary>ndicates a single normalized unsigned 16-bit two's complement value.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		UShortNormalized = 51,
		/// <summary>Indicates a single normalized signed 16-bit two's complement value</summary>
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
		FloatRgb9E5 = 55,
	}
}
