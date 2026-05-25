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
	/// <summary>Whether a <see cref="T:UIKit.UIUserNotificationAction" /> should run the app in foreground or background mode.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios10.0", "Use 'UNNotificationActionOptions' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UNNotificationActionOptions' instead.")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIUserNotificationActivationMode : ulong {
		/// <summary>The activated app should be placed in the foreground.</summary>
		Foreground = 0,
		/// <summary>The activated app should be placed in the background.</summary>
		Background = 1,
	}
}
