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
namespace UserNotificationsUI {
	/// <summary>Enumerates preferred notification responses.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum UNNotificationContentExtensionResponseOption : ulong {
		/// <summary>Indicates that the notification interface will not be dismissed, and that the content extension will handle the action.</summary>
		DoNotDismiss = 0,
		/// <summary>Indicates that the notification interface will be dismissed, and that the content extension will handle the action.</summary>
		Dismiss = 1,
		/// <summary>Indicates that the notification interface will be dismissed, and that the notification will be forwarded to the app for it to respond.</summary>
		DismissAndForwardAction = 2,
	}
}
