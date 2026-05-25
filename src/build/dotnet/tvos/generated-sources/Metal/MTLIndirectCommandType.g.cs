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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum MTLIndirectCommandType : ulong {
		/// <summary>To be added.</summary>
		Draw = 1,
		/// <summary>To be added.</summary>
		DrawIndexed = 2,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		DrawPatches = 4,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		DrawIndexedPatches = 8,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ConcurrentDispatch = 32,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ConcurrentDispatchThreads = 64,
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.1")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		DrawMeshThreadgroups = 128,
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos18.1")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		DrawMeshThreads = 256,
	}
}
