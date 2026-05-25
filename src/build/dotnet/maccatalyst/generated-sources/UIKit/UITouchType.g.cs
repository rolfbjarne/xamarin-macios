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
	/// <summary>Enumerates different kinds of <see cref="T:UIKit.UITouch" /> objects.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UITouchType : long {
		/// <summary>A direct touch caused by a finger on the screen.</summary>
		Direct = 0,
		/// <summary>A touch that was not caused by a finger or stylus.</summary>
		Indirect = 1,
		/// <summary>A touch that was caused by a stylus (e.g., the Apple Pencil).</summary>
		Stylus = 2,
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		IndirectPointer = 3,
	}
}
