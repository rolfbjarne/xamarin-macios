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
namespace CoreMedia {
	/// <summary>An enumeration whose values specify errors relating to <see cref="T:CoreMedia.CMTimebase" />s.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CMTimebaseError : int {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		MissingRequiredParameter = -12748,
		/// <summary>To be added.</summary>
		InvalidParameter = -12749,
		/// <summary>To be added.</summary>
		AllocationFailed = -12750,
		/// <summary>To be added.</summary>
		TimerIntervalTooShort = -12751,
		/// <summary>To be added.</summary>
		ReadOnly = -12757,
	}
}
