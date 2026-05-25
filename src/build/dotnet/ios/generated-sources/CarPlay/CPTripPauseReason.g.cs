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
namespace CarPlay {
	/// <summary>Enumerates the reasons why the current trip has been paused.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum CPTripPauseReason : ulong {
		/// <summary>The car has arrived at the trip destinatioj.</summary>
		Arrived = 1,
		/// <summary>The data for the trip is still loading.</summary>
		Loading = 2,
		/// <summary>The system is trying to locate the car.</summary>
		Locating = 3,
		/// <summary>The system is currently rerouting the trip.</summary>
		Rerouting = 4,
		/// <summary>The car is not on the trip route.</summary>
		ProceedToRoute = 5,
	}
}
