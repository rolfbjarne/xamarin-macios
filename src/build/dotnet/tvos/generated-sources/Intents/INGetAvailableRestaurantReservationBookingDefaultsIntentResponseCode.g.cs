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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Intents {
	/// <summary>Enumerates results codes for the <see cref="T:Intents.INGetAvailableRestaurantReservationBookingDefaultsIntent" />.</summary><remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum INGetAvailableRestaurantReservationBookingDefaultsIntentResponseCode : long {
		/// <summary>Developers should use this response code to indicate that the extension successfully processed the intent.</summary>
		Success = 0,
		/// <summary>Developers should use this code to indicate that they failed to process the intent.</summary>
		Failure = 1,
		/// <summary>Indicates that no explicit response code was provided.</summary>
		Unspecified = 2,
	}
}
