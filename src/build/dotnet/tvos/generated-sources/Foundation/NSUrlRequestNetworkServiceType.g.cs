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
	/// <summary>Network service types for <see cref="T:Foundation.NSUrlRequest" />.</summary><remarks></remarks>
	[Native]
	public enum NSUrlRequestNetworkServiceType : ulong {
		/// <summary>Default traffic</summary>
		Default = 0,
		/// <summary>Voice over IP traffic.</summary>
		[ObsoletedOSPlatform ("macos10.15", "Use 'PushKit' framework instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'PushKit' framework instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'PushKit' framework instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'PushKit' framework instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		VoIP = 1,
		/// <summary>Video traffic.</summary>
		Video = 2,
		/// <summary>Background traffic.</summary>
		Background = 3,
		/// <summary>Voice traffic.</summary>
		Voice = 4,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ResponsiveData = 6,
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		AVStreaming = 8,
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ResponsiveAV = 9,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		CallSignaling = 11,
	}
}
