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
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Flags]
	[Native]
	public enum MTLFunctionOptions : ulong {
		None = 0,
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		CompileToBinary = 1,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'StoreFunctionInMetalPipelinesScript' instead.")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'StoreFunctionInMetalPipelinesScript' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'StoreFunctionInMetalPipelinesScript' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'StoreFunctionInMetalPipelinesScript' instead.")]
		StoreFunctionInMetalScript = 2,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		StoreFunctionInMetalPipelinesScript = 2,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		FailOnBinaryArchiveMiss = 4,
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		PipelineIndependent = 8,
	}
}
