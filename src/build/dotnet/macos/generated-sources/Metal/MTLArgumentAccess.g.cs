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
	/// <summary>Function access restrictions of argument data in the shader code.</summary>
	[ObsoletedOSPlatform ("macos14.0")]
	[ObsoletedOSPlatform ("ios17.0")]
	[ObsoletedOSPlatform ("tvos17.0")]
	[ObsoletedOSPlatform ("maccatalyst17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[Native]
	public enum MTLArgumentAccess : ulong {
		/// <summary>To be added.</summary>
		ReadOnly = 0,
		/// <summary>To be added.</summary>
		ReadWrite = 1,
		/// <summary>To be added.</summary>
		WriteOnly = 2,
	}
}
