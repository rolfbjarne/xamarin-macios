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
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Flags]
	[Native]
	public enum MTLAccelerationStructureUsage : ulong {
		None = 0,
		Refit = 1,
		PreferFastBuild = 2,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos")]
		ExtendedLimits = 4,
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		PreferFastIntersection = 16,
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		MinimizeMemory = 32,
	}
}
