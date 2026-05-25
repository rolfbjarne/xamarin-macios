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
namespace PassKit {
	/// <summary>Enumeration of valid states of a <see cref="T:PassKit.PKPaymentPass" /> payment card.</summary>
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios13.4", "Use 'PKSecureElementPassActivationState' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'PKSecureElementPassActivationState' instead.")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum PKPaymentPassActivationState : ulong {
		/// <summary>Ready to use for payment.</summary>
		Activated = 0,
		/// <summary>Inactive. Requires user intervention to enable.</summary>
		RequiresActivation = 1,
		/// <summary>Not ready to use, but activation is in progress.</summary>
		Activating = 2,
		/// <summary>Inactive and cannot be reactivated.</summary>
		Suspended = 3,
		/// <summary>The user has proactively disabled the asssociated account.</summary>
		Deactivated = 4,
	}
}
