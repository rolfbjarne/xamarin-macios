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
namespace LocalAuthentication {
	/// <summary>Authentication policies.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum LAPolicy : long {
		/// <summary>Use the TouchID sensor to authenticate the user.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		DeviceOwnerAuthenticationWithBiometrics = 1,
		/// <summary>Use the Touch ID sensor or the device password to authenticate the user.</summary>
		DeviceOwnerAuthentication = 2,
		[ObsoletedOSPlatform ("macos15.0", "Use 'DeviceOwnerAuthenticationWithCompanion' instead.")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		DeviceOwnerAuthenticationWithWatch = 3,
		[SupportedOSPlatform ("ios18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[Obsolete ("This value is not available on this platform.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		DeviceOwnerAuthenticationWithCompanion = 3,
		[ObsoletedOSPlatform ("macos15.0", "Use 'DeviceOwnerAuthenticationWithBiometricsOrCompanion' instead.")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		DeviceOwnerAuthenticationWithBiometricsOrWatch = 4,
		[SupportedOSPlatform ("ios18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[Obsolete ("This value is not available on this platform.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		DeviceOwnerAuthenticationWithBiometricsOrCompanion = 4,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[Obsolete ("Use DeviceOwnerAuthenticationWithBiometricsOrWatch enum value instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		OwnerAuthenticationWithBiometricsOrWatch = 4,
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		DeviceOwnerAuthenticationWithWristDetection = 5,
	}
}
