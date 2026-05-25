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
	/// <summary>Options relating to argument information in the creation of a pipeline.</summary>
	[Flags]
	[Native]
	public enum MTLPipelineOption : ulong {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("ios18.0", "Use 'BindingInfo' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'BindingInfo' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'BindingInfo' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'BindingInfo' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		ArgumentInfo = 1,
		BindingInfo = 1,
		/// <summary>To be added.</summary>
		BufferTypeInfo = 2,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		FailOnBinaryArchiveMiss = 4,
	}
}
