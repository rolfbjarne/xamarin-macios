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
	/// <summary>Enumerates environmental texturing strategies used with <see cref="T:ARKit.AREnvironmentProbeAnchor" /> objects.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum AREnvironmentTexturing : long {
		/// <summary>Environmental texture-map generation is not in use.</summary>
		None = 0,
		/// <summary>The developer creates and places <see cref="T:ARKit.AREnvironmentProbeAnchor" /> objects.</summary>
		Manual = 1,
		/// <summary>The system automatically creates and places <see cref="T:ARKit.AREnvironmentProbeAnchor" /> objects. .</summary>
		Automatic = 2,
	}
}
