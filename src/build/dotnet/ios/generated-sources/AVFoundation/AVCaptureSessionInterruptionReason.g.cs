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
namespace AVFoundation {
	/// <summary>Enumerates ways that a capture session can be interrupted.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum AVCaptureSessionInterruptionReason : long {
		/// <summary>Indicates that the app was sent to the background while capturing.</summary>
		VideoDeviceNotAvailableInBackground = 1,
		/// <summary>Indicates that another client began using the audio capture device.</summary>
		AudioDeviceInUseByAnotherClient = 2,
		/// <summary>Indicates that another client began using the video capture device.</summary>
		VideoDeviceInUseByAnotherClient = 3,
		/// <summary>Indicates that the app was displayed in Slide Over, Split View, or PIP mode, which would result in resource contention and degraded capture quality.</summary>
		VideoDeviceNotAvailableWithMultipleForegroundApps = 4,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		VideoDeviceNotAvailableDueToSystemPressure = 5,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios26.0")]
		SensitiveContentMitigationActivated = 6,
	}
}
