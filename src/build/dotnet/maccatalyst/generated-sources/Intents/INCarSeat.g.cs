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
	/// <summary>Enumerates car seat positions.</summary>
	[ObsoletedOSPlatform ("ios15.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst15.0")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum INCarSeat : long {
		/// <summary>An undetermined position.</summary>
		Unknown = 0,
		/// <summary>The seat in which the driver sits.</summary>
		Driver = 1,
		/// <summary>The front seat in which the passenger sits.</summary>
		Passenger = 2,
		/// <summary>The seat in the front left.</summary>
		FrontLeft = 3,
		/// <summary>The seat in the front right.</summary>
		FrontRight = 4,
		/// <summary>The first row of seats.</summary>
		Front = 5,
		/// <summary>The left seat in the 2nd row.</summary>
		RearLeft = 6,
		/// <summary>The right seat in the 2nd row.</summary>
		RearRight = 7,
		/// <summary>The 2nd row of seats.</summary>
		Rear = 8,
		/// <summary>The left seat in the third row.</summary>
		ThirdRowLeft = 9,
		/// <summary>The right seat in the third row.</summary>
		ThirdRowRight = 10,
		/// <summary>The third row of seats.</summary>
		ThirdRow = 11,
		/// <summary>All seats in the car.</summary>
		All = 12,
	}
}
