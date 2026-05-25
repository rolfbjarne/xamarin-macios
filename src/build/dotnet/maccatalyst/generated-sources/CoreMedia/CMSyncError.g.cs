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
	/// <summary>An enumeration whose values specify errors returned by <see cref="CoreMedia.CMClockOrTimebase.GetRelativeRateAndAnchorTime(CoreMedia.CMClockOrTimebase,CoreMedia.CMClockOrTimebase,out System.Double,out CoreMedia.CMTime,out CoreMedia.CMTime)" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CMSyncError : int {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		MissingRequiredParameter = -12752,
		/// <summary>To be added.</summary>
		InvalidParameter = -12753,
		/// <summary>To be added.</summary>
		AllocationFailed = -12754,
		/// <summary>To be added.</summary>
		RateMustBeNonZero = -12755,
	}
}
