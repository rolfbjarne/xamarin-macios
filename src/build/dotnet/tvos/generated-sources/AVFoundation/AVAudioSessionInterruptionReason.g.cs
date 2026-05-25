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
namespace AVFoundation {
	[SupportedOSPlatform ("ios14.5")]
	[SupportedOSPlatform ("tvos14.5")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[Native]
	public enum AVAudioSessionInterruptionReason : ulong {
		Default = 0,
		[ObsoletedOSPlatform ("maccatalyst16.0", "Not reported anymore.")]
		[ObsoletedOSPlatform ("ios16.0", "Not reported anymore.")]
		[ObsoletedOSPlatform ("tvos16.0", "Not reported anymore.")]
		[ObsoletedOSPlatform ("macos11.3", "Not reported anymore.")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		AppWasSuspended = 1,
		BuiltInMicMuted = 2,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("macos")]
		RouteDisconnected = 4,
	}
}
