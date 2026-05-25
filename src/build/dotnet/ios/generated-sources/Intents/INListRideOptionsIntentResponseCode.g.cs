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
namespace Intents {
	/// <summary>Enumerates results codes for the <see cref="T:Intents.INListRideOptionsIntent" />.</summary>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum INListRideOptionsIntentResponseCode : long {
		/// <summary>Indicates that no explicit response code was provided.</summary>
		Unspecified = 0,
		/// <summary>Developers should return this during the confirmation phase, indicating the extension's ability to handle the intent.</summary>
		Ready = 1,
		/// <summary>Developers should not use this deprecated field. </summary>
		[ObsoletedOSPlatform ("ios11.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		InProgress = 2,
		/// <summary>Developers should use this response code to indicate that the extension successfully processed the intent.</summary>
		Success = 3,
		/// <summary>Developers should use this code to indicate that they failed to process the intent.</summary>
		Failure = 4,
		/// <summary>Developers should use this code to indicate that they failed to process the intent and further processing must be done in the app.</summary>
		FailureRequiringAppLaunch = 5,
		/// <summary>Developers should use this code to indicate that the companion app must verify the user's credentals.</summary>
		FailureRequiringAppLaunchMustVerifyCredentials = 6,
		/// <summary>Developers should use this code to indicate a failure because the ride service is not available in the requested area.</summary>
		FailureRequiringAppLaunchNoServiceInArea = 7,
		/// <summary>Developers should use this code to indicate that the required service is temporarily unavailable and continuation requires the companion app.</summary>
		FailureRequiringAppLaunchServiceTemporarilyUnavailable = 8,
		/// <summary>Developers should use this code to indicate a failure because the previous ride has not been completed.</summary>
		FailureRequiringAppLaunchPreviousRideNeedsCompletion = 9,
		/// <summary>Developers should use this code to indicate a failure because feedback on the previous ride has not been completed.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		FailurePreviousRideNeedsFeedback = 10,
	}
}
