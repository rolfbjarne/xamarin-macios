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
	/// <summary>Enumerates inputs to the car sound system.</summary>
	[ObsoletedOSPlatform ("ios15.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst15.0")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum INCarAudioSource : long {
		/// <summary>The input source is not determined.</summary>
		Unknown = 0,
		/// <summary>CarPlay audio.</summary>
		CarPlay = 1,
		/// <summary>An attached iPod.</summary>
		iPod = 2,
		/// <summary>A radio station.</summary>
		Radio = 3,
		/// <summary>A bluetooth audio stream.</summary>
		Bluetooth = 4,
		/// <summary>An auxiliary jack.</summary>
		Aux = 5,
		/// <summary>An audio stream provided over a USB connection.</summary>
		Usb = 6,
		/// <summary>A removable memory card.</summary>
		MemoryCard = 7,
		/// <summary>A removable optical disk (e.g., a CD).</summary>
		OpticalDrive = 8,
		/// <summary>An external drive.</summary>
		HardDrive = 9,
	}
}
