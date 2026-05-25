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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreMedia {
	/// <summary>An enumeration whose values specify the rounding method to be used with a <see cref="T:CoreMedia.CMTime" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CMTimeRoundingMethod : uint {
		/// <summary>To be added.</summary>
		RoundHalfAwayFromZero = 1,
		/// <summary>To be added.</summary>
		RoundTowardZero = 2,
		/// <summary>To be added.</summary>
		RoundAwayFromZero = 3,
		/// <summary>To be added.</summary>
		QuickTime = 4,
		/// <summary>To be added.</summary>
		RoundTowardPositiveInfinity = 5,
		/// <summary>To be added.</summary>
		RoundTowardNegativeInfinity = 6,
		/// <summary>To be added.</summary>
		Default = 1,
	}
}
