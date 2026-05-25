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
	/// <summary>Enumerates options in calls to <see cref="M:ARKit.ARSession.Run(ARKit.ARConfiguration,ARKit.ARSessionRunOptions)" />.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Flags]
	[Native]
	public enum ARSessionRunOptions : ulong {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>The <see cref="T:ARKit.ARSession" /> should reset its world-tracking.</summary>
		ResetTracking = 1,
		/// <summary>The <see cref="T:ARKit.ARSession" /> should remove any existing <see cref="T:ARKit.ARAnchor" /> objects.</summary>
		RemoveExistingAnchors = 2,
		StopTrackedRaycasts = 4,
		[SupportedOSPlatform ("ios13.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		ResetSceneReconstruction = 8,
	}
}
