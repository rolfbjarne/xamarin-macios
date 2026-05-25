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
	/// <summary>Enumerates results codes for the <see cref="T:Intents.INStartAudioCallIntent" />.</summary>
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios13.0", "Use 'INStartCallIntentResponseCode' instead.")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'INStartCallIntentResponseCode' instead.")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum INStartAudioCallIntentResponseCode : long {
		/// <summary>Indicates that no explicit response code was provided.</summary>
		Unspecified = 0,
		/// <summary>Developers should return this during the confirmation phase, indicating the extension's ability to handle the intent.</summary>
		Ready = 1,
		/// <summary>Developers should use this code to indicate to the system that the intent needs further processing inside the app.</summary>
		ContinueInApp = 2,
		/// <summary>Developers should use this code to indicate that they failed to process the intent.</summary>
		Failure = 3,
		/// <summary>Developers should use this code to indicate that they failed to process the intent and further processing must be done in the app.</summary>
		FailureRequiringAppLaunch = 4,
		/// <summary>Developers should use this code to indicate that they failed to process the intent and further configuration must be done in the app before the intent can succeed.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'INStartCallIntentResponseCode' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'INStartCallIntentResponseCode' instead.")]
		[SupportedOSPlatform ("ios")]
		FailureAppConfigurationRequired = 5,
		/// <summary>Developers should use this code to indicate that they failed to process the intent because the calling service was not available.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'INStartCallIntentResponseCode' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'INStartCallIntentResponseCode' instead.")]
		[SupportedOSPlatform ("ios")]
		FailureCallingServiceNotAvailable = 6,
		/// <summary>Developers should use this code to indicate that they failed to process the intent because the contact was not supported by the associated app.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'INStartCallIntentResponseCode' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'INStartCallIntentResponseCode' instead.")]
		[SupportedOSPlatform ("ios")]
		FailureContactNotSupportedByApp = 7,
		/// <summary>Developers should use this code to indicate that they failed to process the intent because the number was not valid.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'INStartCallIntentResponseCode' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'INStartCallIntentResponseCode' instead.")]
		[SupportedOSPlatform ("ios")]
		FailureNoValidNumber = 8,
	}
}
