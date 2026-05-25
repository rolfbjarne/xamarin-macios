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
	/// <summary>An enumeration of values used to specify the source used by the <see cref="T:UIKit.UIImagePickerController" />.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIImagePickerControllerSourceType : long {
		/// <summary>The device's photo library.</summary>
		[ObsoletedOSPlatform ("ios14.0", "Use 'PHPicker' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'PHPicker' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		PhotoLibrary = 0,
		/// <summary>One of the cameras on the device.</summary>
		Camera = 1,
		/// <summary>The device's "Camera Roll" album or, if the device does not have a camera, the "Saved Photos" album.</summary>
		[ObsoletedOSPlatform ("ios14.0", "Use 'PHPicker' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'PHPicker' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		SavedPhotosAlbum = 2,
	}
}
