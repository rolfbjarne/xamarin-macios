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
namespace UIKit {
	/// <summary>Enumerates the various types of user notification. Can be "OR"ed together as flags.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios10.0", "Use 'UNAuthorizationOptions' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UNAuthorizationOptions' instead.")]
	[SupportedOSPlatform ("ios")]
	[Flags]
	[Native]
	public enum UIUserNotificationType : ulong {
		/// <summary>No notifications types are allowed.</summary>
		None = 0,
		/// <summary>Modifications to the application icon's badge.</summary>
		Badge = 1,
		/// <summary>Plays a sound.</summary>
		Sound = 2,
		/// <summary>Text alerts.</summary>
		Alert = 4,
	}
}
