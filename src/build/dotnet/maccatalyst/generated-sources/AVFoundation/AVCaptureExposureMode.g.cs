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
namespace AVFoundation {
	/// <summary>An enumeration whose values specify options for varying exposure modes during capture.</summary><remarks><para /></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum AVCaptureExposureMode : long {
		/// <summary>Exposure setting is locked.</summary>
		Locked = 0,
		/// <summary>The camera performs auto expose.</summary>
		AutoExpose = 1,
		/// <summary>Performs auto-expose and adjusts the setting continously. </summary>
		ContinuousAutoExposure = 2,
		/// <summary>Exposure is limited by the <see cref="P:AVFoundation.AVCaptureDevice.ISO" /> and <see cref="P:AVFoundation.AVCaptureDevice.ExposureDuration" /> properties.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		Custom = 3,
	}
}
