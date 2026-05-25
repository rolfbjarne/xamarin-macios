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
namespace MetalPerformanceShadersGraph {
	[Native]
	public enum MPSGraphTensorNamedDataLayout : ulong {
		Nchw = 0,
		Nhwc = 1,
		Oihw = 2,
		Hwio = 3,
		Chw = 4,
		Hwc = 5,
		Hw = 6,
		[SupportedOSPlatform ("macos13.2")]
		[SupportedOSPlatform ("ios16.3")]
		[SupportedOSPlatform ("tvos16.3")]
		[SupportedOSPlatform ("maccatalyst16.3")]
		Ncdhw = 7,
		[SupportedOSPlatform ("macos13.2")]
		[SupportedOSPlatform ("ios16.3")]
		[SupportedOSPlatform ("tvos16.3")]
		[SupportedOSPlatform ("maccatalyst16.3")]
		Ndhwc = 8,
		[SupportedOSPlatform ("macos13.2")]
		[SupportedOSPlatform ("ios16.3")]
		[SupportedOSPlatform ("tvos16.3")]
		[SupportedOSPlatform ("maccatalyst16.3")]
		Oidhw = 9,
		[SupportedOSPlatform ("macos13.2")]
		[SupportedOSPlatform ("ios16.3")]
		[SupportedOSPlatform ("tvos16.3")]
		[SupportedOSPlatform ("maccatalyst16.3")]
		Dhwio = 10,
	}
}
