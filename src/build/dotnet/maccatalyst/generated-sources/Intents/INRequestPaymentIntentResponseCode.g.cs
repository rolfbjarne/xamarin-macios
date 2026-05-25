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
namespace Intents {
	/// <summary>Enumerates results codes for the <see cref="T:Intents.INRequestPaymentIntent" />.</summary>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum INRequestPaymentIntentResponseCode : long {
		/// <summary>Indicates that no explicit response code was provided.</summary>
		Unspecified = 0,
		/// <summary>Developers should return this during the confirmation phase, indicating the extension's ability to handle the intent.</summary>
		Ready = 1,
		/// <summary>Developers should use this code to indicate they have not finished processing.</summary>
		InProgress = 2,
		/// <summary>Developers should use this response code to indicate that the extension successfully processed the intent.</summary>
		Success = 3,
		/// <summary>Developers should use this code to indicate that they failed to process the intent.</summary>
		Failure = 4,
		/// <summary>Developers should use this code to indicate that they failed to process the intent and further processing must be done in the app.</summary>
		FailureRequiringAppLaunch = 5,
		/// <summary>Developers should use this code to indicate a failure in verifying credentials.</summary>
		FailureCredentialsUnverified = 6,
		/// <summary>Developers should use this code to indicate a failure because the payment is too small.</summary>
		FailurePaymentsAmountBelowMinimum = 7,
		/// <summary>Developers should use this code to indicate a failure because the payment exceeds the allowed maximum.</summary>
		FailurePaymentsAmountAboveMaximum = 8,
		/// <summary>Developers should use this code to indicate a failure because the requested currency is not supported.</summary>
		FailurePaymentsCurrencyUnsupported = 9,
		/// <summary>Developers should use this code to indicate a failure because no bank account is configured.</summary>
		FailureNoBankAccount = 10,
		/// <summary>Developers should use this code to indicate a failure because the user is not eligible to either send or receive funds via money transfer.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		FailureNotEligible = 11,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		FailureTermsAndConditionsAcceptanceRequired = 12,
	}
}
