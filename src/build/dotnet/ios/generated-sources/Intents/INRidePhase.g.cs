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
	/// <summary>Enumerates the state of a ride in a vehicle.</summary>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum INRidePhase : long {
		/// <summary>The status of the ride is not known.</summary>
		Unknown = 0,
		/// <summary>The ride request has been received but is not yet <see cref="F:Intents.INRidePhase.Confirmed" />.</summary>
		Received = 1,
		/// <summary>The ride is accepted and confirmed.</summary>
		Confirmed = 2,
		/// <summary>The ride is currently in progress.</summary>
		Ongoing = 3,
		/// <summary>The ride has ended.</summary>
		Completed = 4,
		/// <summary>The vehicle is anticipated to arrive shortly.</summary>
		ApproachingPickup = 5,
		/// <summary>The ride is currently picking up the passenger(s).</summary>
		Pickup = 6,
	}
}
