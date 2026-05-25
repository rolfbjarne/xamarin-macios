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
	/// <summary>Enumerates the kinds of objects detected by the <see cref="M:ARKit.ARFrame.HitTest(CoreGraphics.CGPoint,ARKit.ARHitTestResultType)" /> method.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Flags]
	[Native]
	public enum ARHitTestResultType : ulong {
		/// <summary>A point detected by image processing that appears to be on a continuous surface but does not have an <see cref="T:ARKit.ARAnchor" />.</summary>
		FeaturePoint = 1,
		/// <summary>A real-world horizontal plane detected by image analysis.</summary>
		EstimatedHorizontalPlane = 2,
		/// <summary>A real-world vertical plane detected by image analysis.</summary>
		EstimatedVerticalPlane = 4,
		/// <summary>An existing plane in the scene, detected without constraints on the plane's size.</summary>
		ExistingPlane = 8,
		/// <summary>An existing plane in the scene, detected only if the point is within the plane's extent.</summary>
		ExistingPlaneUsingExtent = 16,
		/// <summary>An existint plane in the scene, detected if the point is coplanar with the plane's geometry.</summary>
		ExistingPlaneUsingGeometry = 32,
	}
}
