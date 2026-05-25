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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	/// <summary>An enumeration of values used by <see cref="P:UIKit.UIViewController.ModalPresentationStyle" /></summary><remarks>iPhones and iTouches should always use <see cref="F:UIKit.UIModalPresentationStyle.FullScreen" />. iPads may use any value.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIModalPresentationStyle : long {
		/// <summary>A non-modal presentation or dismissal.</summary>
		None = -1,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		Automatic = -2,
		/// <summary>A UIModalPresentationStyle that encompasses the whole screen.</summary>
		FullScreen = 0,
		/// <summary>Set to the height and width of the screen in portrait orientation.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		PageSheet = 1,
		/// <summary>Centered on and smaller than the screen.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		FormSheet = 2,
		/// <summary>The same UIModalPresentationStyle used by the view's parent UIViewController.</summary>
		CurrentContext = 3,
		/// <summary>Managed by a custom animator and an optional interative controller.</summary>
		Custom = 4,
		/// <summary>Display the modal content over the full screen on top of the current view hierarchy.</summary>
		OverFullScreen = 5,
		/// <summary>Display the modal content over only the parent view controller's content area.</summary>
		OverCurrentContext = 6,
		/// <summary>Display the modal content in a popover view for horizontally regular environments, and in full screen mode for horizontally compact environments.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		Popover = 7,
		/// <summary>Blur the previous content and then overlay the new content.</summary>
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("tvos16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		BlurOverFullScreen = 8,
	}
}
