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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UserNotifications {
	/// <summary>Enumerates flags that control the presentation of notifications in foreground apps.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum UNNotificationPresentationOptions : ulong {
		/// <summary>No options are set.</summary>
		None = 0,
		/// <summary>Display the notification badge value in the application's badge.</summary>
		Badge = 1,
		/// <summary>Play the notification sound.</summary>
		Sound = 2,
		/// <summary>Display the notification as an alert, using the notification text.</summary>
		[ObsoletedOSPlatform ("ios14.0", "Use 'List | Banner' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'List | Banner' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'List | Banner' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'List | Banner' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		Alert = 4,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		List = 8,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Banner = 16,
	}
}
