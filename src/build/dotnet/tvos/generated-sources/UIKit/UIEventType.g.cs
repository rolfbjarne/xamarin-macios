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
namespace UIKit {
	/// <summary>An enumeration of event types.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIEventType : long {
		/// <summary>The event relates to touches to the screen.</summary>
		Touches = 0,
		/// <summary>A motion event, such as when the user shakes the device.</summary>
		Motion = 1,
		/// <summary>A remote-control event originating from a headset or external accessory, for the purpose of controlling multimedia.</summary>
		RemoteControl = 2,
		/// <summary>Indicates that a physical button was pressed.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Presses = 3,
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		Scroll = 10,
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		Hover = 11,
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		Transform = 14,
	}
}
