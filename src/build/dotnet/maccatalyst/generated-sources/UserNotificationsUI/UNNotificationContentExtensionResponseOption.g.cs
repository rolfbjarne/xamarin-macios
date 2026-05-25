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
