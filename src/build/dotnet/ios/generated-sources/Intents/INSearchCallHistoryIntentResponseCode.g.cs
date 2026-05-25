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
	/// <summary>Enumerates results codes for the <see cref="T:Intents.INSearchCallHistoryIntent" />.</summary>
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios15.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst15.0")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum INSearchCallHistoryIntentResponseCode : long {
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
		[ObsoletedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		FailureAppConfigurationRequired = 5,
		/// <summary>Developers should use this code to indicate they have not finished processing.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		InProgress = 6,
		/// <summary>Developers should use this response code to indicate that the extension successfully processed the intent.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		Success = 7,
	}
}
