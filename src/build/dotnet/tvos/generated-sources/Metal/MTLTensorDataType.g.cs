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
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[Native]
	public enum MTLTensorDataType : long {
		None = 0,
		Float32 = 3,
		Float16 = 16,
		BFloat16 = 121,
		Int8 = 45,
		UInt8 = 49,
		Int16 = 37,
		UInt16 = 41,
		Int32 = 29,
		UInt32 = 33,
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		Int4 = 143,
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		UInt4 = 144,
	}
}
