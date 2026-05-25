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
namespace PassKit {
	/// <summary>Enumeration of results of authorization requests.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum PKPaymentAuthorizationStatus : long {
		/// <summary>The authorization succeeded.</summary>
		Success = 0,
		/// <summary>Authorization failed.</summary>
		Failure = 1,
		/// <summary>Developers should not use this deprecated field. Developers should use 'Failure' and 'PKPaymentRequest.CreatePaymentBillingAddressInvalidError'.</summary>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'Failure' and 'PKPaymentRequest.CreatePaymentBillingAddressInvalidError'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'Failure' and 'PKPaymentRequest.CreatePaymentBillingAddressInvalidError'.")]
		[SupportedOSPlatform ("ios")]
		InvalidBillingPostalAddress = 2,
		/// <summary>Unusable shipping address.</summary>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'Failure' and 'PKPaymentRequest.CreatePaymentShippingAddressInvalidError'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'Failure' and 'PKPaymentRequest.CreatePaymentShippingAddressInvalidError'.")]
		[SupportedOSPlatform ("ios")]
		InvalidShippingPostalAddress = 3,
		/// <summary>Unusable shipping contact.</summary>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'Failure' and 'PKPaymentRequest.CreatePaymentContactInvalidError'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'Failure' and 'PKPaymentRequest.CreatePaymentContactInvalidError'.")]
		[SupportedOSPlatform ("ios")]
		InvalidShippingContact = 4,
		/// <summary>Indicates that a PIN is required for the action.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		PinRequired = 5,
		/// <summary>Indicates that an invalid PIN was entered.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		PinIncorrect = 6,
		/// <summary>Indicates that too many incorrect PINs were entered and the user is locked out for PIN transactions.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		PinLockout = 7,
	}
}
