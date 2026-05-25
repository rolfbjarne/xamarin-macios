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
namespace UserNotifications {
	/// <summary>Enumerates user interaction authorization requests.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum UNAuthorizationOptions : ulong {
		/// <summary>Indicates that no request type is specified.</summary>
		None = 0,
		/// <summary>Indicates authorization to update the app's badge.</summary>
		Badge = 1,
		/// <summary>Indicates authorization to play sound.</summary>
		Sound = 2,
		/// <summary>Indicates authorization to display alerts.</summary>
		Alert = 4,
		/// <summary>Indicates authorization to display notifications in CarPlay.</summary>
		CarPlay = 8,
		/// <summary>Indicates authorization to display critical alerts.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		CriticalAlert = 16,
		/// <summary>Indicates that the app should provide a button for notification settings.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ProvidesAppNotificationSettings = 32,
		/// <summary>Indicates authorization to make provisional noncritical notifications.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Provisional = 64,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[ObsoletedOSPlatform ("ios15.0", "Announcement is always included.")]
		[ObsoletedOSPlatform ("tvos15.0", "Announcement is always included.")]
		[ObsoletedOSPlatform ("macos15.0", "Announcement is always included.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Announcement is always included.")]
		[SupportedOSPlatform ("macos")]
		Announcement = 128,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		TimeSensitive = 256,
	}
}
