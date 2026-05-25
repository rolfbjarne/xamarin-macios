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
namespace ARKit {
	/// <summary>Enumerates the causes of <see cref="F:ARKit.ARTrackingState.Limited" />.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum ARTrackingStateReason : long {
		/// <summary>Either tracking is <see cref="F:ARKit.ARTrackingState.Normal" /> or the reason for poor tracking cannot be determined.</summary>
		None = 0,
		/// <summary>ARKit is still starting up.</summary>
		Initializing = 1,
		/// <summary>The camera is moving too quickly.</summary>
		ExcessiveMotion = 2,
		/// <summary>Processing is not revealing sufficient high-contrast points in the field of view.</summary>
		InsufficientFeatures = 3,
		/// <summary>The AR session was interrupted and is reorienting.</summary>
		Relocalizing = 4,
	}
}
