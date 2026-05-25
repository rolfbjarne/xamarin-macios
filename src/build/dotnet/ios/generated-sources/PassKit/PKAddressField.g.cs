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
namespace PassKit {
	/// <summary>Holds address information for billing or shipping purposes.</summary>
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios11.0", "Use 'PKContactField' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'PKContactField' instead.")]
	[SupportedOSPlatform ("ios")]
	[Flags]
	[Native]
	public enum PKAddressField : ulong {
		/// <summary>None of the fields.</summary>
		None = 0,
		/// <summary>The buyer's address.</summary>
		PostalAddress = 1,
		/// <summary>The buyer's phone number.</summary>
		Phone = 2,
		/// <summary>The buyer's email.</summary>
		Email = 4,
		/// <summary>The buyer's full name.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios12.2", "Use 'PKContactField' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'PKContactField' instead.")]
		[SupportedOSPlatform ("ios")]
		Name = 8,
		/// <summary>All the fields.</summary>
		All = 15,
	}
}
