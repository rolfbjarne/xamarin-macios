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
namespace Metal {
	/// <summary>The resource type of an argument of a function.</summary>
	[Native]
	public enum MTLArgumentType : ulong {
		/// <summary>To be added.</summary>
		Buffer = 0,
		/// <summary>To be added.</summary>
		ThreadgroupMemory = 1,
		/// <summary>To be added.</summary>
		Texture = 2,
		/// <summary>To be added.</summary>
		Sampler = 3,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		ImageblockData = 16,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios")]
		Imageblock = 17,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		VisibleFunctionTable = 24,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		PrimitiveAccelerationStructure = 25,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		InstanceAccelerationStructure = 26,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		IntersectionFunctionTable = 27,
	}
}
