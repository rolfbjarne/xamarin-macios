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
	/// <summary>Enumerates the amount of space available for a <see cref="T:UIKit.UIUserNotificationAction" />. Used with <see cref="M:UIKit.UIMutableUserNotificationCategory.SetActions(UIKit.UIUserNotificationAction[],UIKit.UIUserNotificationActionContext)" /></summary>
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios10.0", "Use 'UNNotificationCategory.Actions' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UNNotificationCategory.Actions' instead.")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIUserNotificationActionContext : ulong {
		/// <summary>The full UI is displayed for the notification's alert. Allows up to four <see cref="T:UIKit.UIUserNotificationAction" />s.</summary>
		Default = 0,
		/// <summary>Only minimal space is available for the notification's alert. Allows up to two <see cref="T:UIKit.UIUserNotificationAction" />s.</summary>
		Minimal = 1,
	}
}
