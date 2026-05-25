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
	/// <summary>Contains flags that control whether a custom dismiss action is used, and whether the category is allowed in CarPlay application.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Flags]
	[Native]
	public enum UNNotificationCategoryOptions : ulong {
		/// <summary>No options are specified.</summary>
		None = 0,
		/// <summary>Send the dismiss action to the user notification center for handling.</summary>
		CustomDismissAction = 1,
		/// <summary>Whether to allow the notification in CarPlay. (If this value is not specified, the notification is disallowed in CarPlay.)</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		AllowInCarPlay = 2,
		/// <summary>Display titles for notification previews, even when hidden.</summary>
		HiddenPreviewsShowTitle = 4,
		/// <summary>Display subtitles for notification previews, even when hidden.</summary>
		HiddenPreviewsShowSubtitle = 8,
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		AllowAnnouncement = 16,
	}
}
