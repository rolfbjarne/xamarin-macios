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
	/// <summary>The format used by pixels, including color, depth, compression technigue, and data type for components.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum MTLPixelFormat : ulong {
		/// <summary>Indicates an invalid pixel format.</summary>
		Invalid = 0,
		/// <summary>Indicates the unsigned, normalized integer format.</summary>
		A8Unorm = 1,
		/// <summary>Indicates a single 8-bit normalized integer format.</summary>
		R8Unorm = 10,
		/// <summary>Indicates a single 8-bit unnormalized signed integer format with sRGB-Linear conversion.</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
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
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RG8Unorm_sRGB = 31,
		/// <summary>Indicates a 2-channel normalized signed integer format with 8 bits per channel.</summary>
		RG8Snorm = 32,
		/// <summary>Indicates a 2-channel unsigned integer format with 8 bits per channel.</summary>
		RG8Uint = 33,
		/// <summary>Indicates a 2-channel signed integer format with 8 bits per channel.</summary>
		RG8Sint = 34,
		/// <summary>Indicates a 5-bit B, 6-bit G, and 5-bit R unsigned, normalized integer format.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		B5G6R5Unorm = 40,
		/// <summary>Indicates the unsigned, normalized integer format.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		A1BGR5Unorm = 41,
		/// <summary>Indicates the unsigned, normalized integer format.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ABGR4Unorm = 42,
		/// <summary>Indicates a 5-bit B, 6-bit G, 5-bit R, and 1-bit Alpha unnormalized signed integer format.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
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
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
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
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		BC1RGBA = 130,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		BC1_RGBA_sRGB = 131,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		BC2RGBA = 132,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		BC2_RGBA_sRGB = 133,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		BC3RGBA = 134,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		BC3_RGBA_sRGB = 135,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		BC4_RUnorm = 140,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		BC4_RSnorm = 141,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		BC5_RGUnorm = 142,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		BC5_RGSnorm = 143,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		BC6H_RGBFloat = 150,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		BC6H_RGBUFloat = 151,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		BC7_RGBAUnorm = 152,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		BC7_RGBAUnorm_sRGB = 153,
		/// <summary>Indicatea a 2bpp PVRTC RGB format.</summary>
		[ObsoletedOSPlatform ("ios18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use ASTC/ETC2/BC formats instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		PVRTC_RGB_2BPP = 160,
		/// <summary>Indicatea a 2bpp PVRTC RGB format with sRGB-Linear conversion.</summary>
		[ObsoletedOSPlatform ("ios18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use ASTC/ETC2/BC formats instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		PVRTC_RGB_2BPP_sRGB = 161,
		/// <summary>Indicatea a 4bpp PVRTC RGB format.</summary>
		[ObsoletedOSPlatform ("ios18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use ASTC/ETC2/BC formats instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		PVRTC_RGB_4BPP = 162,
		/// <summary>Indicatea a 4bpp PVRTC RGB format with sRGB-Linear conversion.</summary>
		[ObsoletedOSPlatform ("ios18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use ASTC/ETC2/BC formats instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		PVRTC_RGB_4BPP_sRGB = 163,
		/// <summary>Indicatea a 2bpp PVRTC RGBA format.</summary>
		[ObsoletedOSPlatform ("ios18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use ASTC/ETC2/BC formats instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		PVRTC_RGBA_2BPP = 164,
		/// <summary>Indicatea a 2bpp PVRTC RGBA format with sRGB-Linear conversion.</summary>
		[ObsoletedOSPlatform ("ios18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use ASTC/ETC2/BC formats instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		PVRTC_RGBA_2BPP_sRGB = 165,
		/// <summary>Indicatea a 4bpp PVRTC RGBA format.</summary>
		[ObsoletedOSPlatform ("ios18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use ASTC/ETC2/BC formats instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		PVRTC_RGBA_4BPP = 166,
		/// <summary>Indicatea a 4bpp PVRTC RGBA format with sRGB-Linear conversion.</summary>
		[ObsoletedOSPlatform ("ios18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use ASTC/ETC2/BC formats instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use ASTC/ETC2/BC formats instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
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
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ASTC_4x4_HDR = 222,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ASTC_5x4_HDR = 223,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ASTC_5x5_HDR = 224,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ASTC_6x5_HDR = 225,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ASTC_6x6_HDR = 226,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ASTC_8x5_HDR = 228,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ASTC_8x6_HDR = 229,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ASTC_8x8_HDR = 230,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ASTC_10x5_HDR = 231,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ASTC_10x6_HDR = 232,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ASTC_10x8_HDR = 233,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ASTC_10x10_HDR = 234,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ASTC_12x10_HDR = 235,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
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
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Depth24Unorm_Stencil8 = 255,
		/// <summary>Indicates a 24-bit depth and 8-bit stencil floating-point format.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Depth32Float_Stencil8 = 260,
		/// <summary>Indicates an 8-bit stencil format.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		X32_Stencil8 = 261,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		X24_Stencil8 = 262,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		BGRA10_XR = 552,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		BGRA10_XR_sRGB = 553,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		BGR10_XR = 554,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		BGR10_XR_sRGB = 555,
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		Unspecialized = 263,
	}
}
