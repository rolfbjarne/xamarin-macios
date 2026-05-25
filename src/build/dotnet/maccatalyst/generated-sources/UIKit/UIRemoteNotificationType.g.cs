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
namespace UIKit {
	/// <summary>An enumeration of remote notification types.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Flags]
	[Native]
	public enum UIRemoteNotificationType : ulong {
		/// <summary>The app accepts no notifications.</summary>
		None = 0,
		/// <summary>The app accepts notifications that badge the app's icon.</summary>
		Badge = 1,
		/// <summary>The app accepts alert sounds as notifications.</summary>
		Sound = 2,
		/// <summary>The app accepts alert messages as notifications.</summary>
		Alert = 4,
		/// <summary>The app accepts notifications that trigger the downloading of issue assets in a Newsstand app.</summary>
		NewsstandContentAvailability = 8,
	}
}
