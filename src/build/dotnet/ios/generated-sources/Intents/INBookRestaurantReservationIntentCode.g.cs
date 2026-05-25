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
	/// <summary>Enumerates the results of an <see cref="T:Intents.INBookRestaurantReservationIntent" />.</summary><remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum INBookRestaurantReservationIntentCode : long {
		/// <summary>Developers should use this response code to indicate that the extension successfully processed the intent.</summary>
		Success = 0,
		/// <summary>The processing completed, but the booking was not made.</summary>
		Denied = 1,
		/// <summary>Developers should use this code to indicate that they failed to process the intent.</summary>
		Failure = 2,
		/// <summary>Developers should use this code to indicate that they failed to process the intent and further processing must be done in the app.</summary>
		FailureRequiringAppLaunch = 3,
		/// <summary>Developers should use this code to indicate that the companion app must verify the user's credentals.</summary>
		FailureRequiringAppLaunchMustVerifyCredentials = 4,
		/// <summary>Developers should use this code to indicate that the required service is temporarily unavailable and continuation requires the companion app.</summary>
		FailureRequiringAppLaunchServiceTemporarilyUnavailable = 5,
	}
}
