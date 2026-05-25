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
	/// <summary>An enumeration whose values specify why an audio route changed.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum AVAudioSessionRouteChangeReason : ulong {
		/// <summary>To be added.</summary>
		Unknown = 0,
		/// <summary>To be added.</summary>
		NewDeviceAvailable = 1,
		/// <summary>To be added.</summary>
		OldDeviceUnavailable = 2,
		/// <summary>To be added.</summary>
		CategoryChange = 3,
		/// <summary>To be added.</summary>
		Override = 4,
		/// <summary>To be added.</summary>
		WakeFromSleep = 6,
		/// <summary>To be added.</summary>
		NoSuitableRouteForCategory = 7,
		/// <summary>To be added.</summary>
		RouteConfigurationChange = 8,
	}
}
