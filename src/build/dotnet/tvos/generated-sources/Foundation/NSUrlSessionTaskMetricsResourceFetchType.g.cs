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
namespace Foundation {
	/// <summary>Enumerates the way a network resource might be loaded.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum NSUrlSessionTaskMetricsResourceFetchType : long {
		/// <summary>The manner of the resource loading is not known.</summary>
		Unknown = 0,
		/// <summary>The resource was retrieved via a network connection.</summary>
		NetworkLoad = 1,
		/// <summary>The resource was pushed from a server.</summary>
		[ObsoletedOSPlatform ("ios18.4", "Not supported in iOS 17+.")]
		[ObsoletedOSPlatform ("tvos18.4", "Not supported in tvOS 17+.")]
		[ObsoletedOSPlatform ("maccatalyst18.4", "Not supported in Mac Catalyst 17+.")]
		[ObsoletedOSPlatform ("macos15.4", "Not supported in macOS 14+.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		ServerPush = 2,
		/// <summary>The resource was retrieved from a local cache.</summary>
		LocalCache = 3,
	}
}
