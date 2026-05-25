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
namespace MetalPerformanceShaders {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum MPSImageType : uint {
		Type2d = 0,
		Type2dArray = 1,
		Array2d = 2,
		Array2dArray = 3,
		ArrayMask = 1,
		BatchMask = 2,
		TypeMask = 3,
		NoAlpha = 4,
		TexelFormatMask = 56,
		TexelFormatShift = 3,
		TexelFormatStandard = 0,
		TexelFormatUnorm8 = 8,
		TexelFormatFloat16 = 16,
		TexelFormatBFloat16 = 24,
		BitCount = 6,
		Mask = 63,
		Type2dNoAlpha = 4,
		Type2dArrayNoAlpha = 5,
		Array2dNoAlpha = 6,
		Array2dArrayNoAlpha = 7,
		DestTextureType = 63,
		Src0TextureType = 63,
		Src1TextureType = 1,
		Src2TextureType = 0,
		Src3TextureType = 0,
		Src4TextureType = 0,
	}
}
