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
namespace UIKit {
	/// <summary>Enumerates valid display modes for an expanded <see cref="T:UIKit.UISplitViewController" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UISplitViewControllerDisplayMode : long {
		/// <summary>The system decides the most appropriate display mode.</summary>
		Automatic = 0,
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		SecondaryOnly = 1,
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		OneBesideSecondary = 2,
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		OneOverSecondary = 3,
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		TwoBesideSecondary = 4,
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		TwoOverSecondary = 5,
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		TwoDisplaceSecondary = 6,
		/// <summary>The primary <see cref="T:UIKit.UISplitViewController" /> is hidden.</summary>
		[ObsoletedOSPlatform ("ios14.0", "Use 'SecondaryOnly' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'SecondaryOnly' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'SecondaryOnly' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		PrimaryHidden = 1,
		/// <summary>The primary and secondary <see cref="T:UIKit.UIViewController" />s are displayed side-by-side.</summary>
		[ObsoletedOSPlatform ("ios14.0", "Use 'OneBesideSecondary' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'OneBesideSecondary' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'OneBesideSecondary' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		AllVisible = 2,
		/// <summary>The primary <see cref="T:UIKit.UISplitViewController" /> overlays the secondary, which is partially visible.</summary>
		[ObsoletedOSPlatform ("ios14.0", "Use 'OneOverSecondary' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'OneOverSecondary' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'OneOverSecondary' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		PrimaryOverlay = 3,
	}
}
