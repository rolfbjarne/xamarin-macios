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
	/// <summary>Enumerates results codes for the <see cref="T:Intents.INGetAvailableRestaurantReservationBookingsIntent" />.</summary><remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum INGetAvailableRestaurantReservationBookingsIntentCode : long {
		/// <summary>Developers should use this response code to indicate that the extension successfully processed the intent.</summary>
		Success = 0,
		/// <summary>Developers should use this code to indicate that they failed to process the intent.</summary>
		Failure = 1,
		/// <summary>Developers should use this code to indicate that while processing succeeded, no available bookings satisfy the request.</summary>
		FailureRequestUnsatisfiable = 2,
		/// <summary>Developers should use this code to iindicate a failure for an unspecified reason.</summary>
		FailureRequestUnspecified = 3,
	}
}
