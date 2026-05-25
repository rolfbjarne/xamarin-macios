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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MLCompute {
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum MLCArithmeticOperation : int {
		Add = 0,
		Subtract = 1,
		Multiply = 2,
		Divide = 3,
		Floor = 4,
		Round = 5,
		Ceil = 6,
		Sqrt = 7,
		Rsqrt = 8,
		Sin = 9,
		Cos = 10,
		Tan = 11,
		Asin = 12,
		Acos = 13,
		Atan = 14,
		Sinh = 15,
		Cosh = 16,
		Tanh = 17,
		Asinh = 18,
		Acosh = 19,
		Atanh = 20,
		Pow = 21,
		Exp = 22,
		Exp2 = 23,
		Log = 24,
		Log2 = 25,
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		MultiplyNoNaN = 26,
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		DivideNoNaN = 27,
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Min = 28,
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Max = 29,
	}
}
