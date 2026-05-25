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
namespace CoreMotion {
	/// <summary>An enumeration whose values specify the reference frame from which <see cref="T:CoreMotion.CMAttitude" /> readings are referenced.</summary>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Flags]
	[Native]
	public enum CMAttitudeReferenceFrame : ulong {
		/// <summary>Z axis is vertical; X axis is in any direction. </summary>
		XArbitraryZVertical = 1,
		/// <summary>Z axis is vertical; X axis is in any direction. Magnetometer is used to correct long-term yaw. A reference frame in which the magnetometer (if available) is used to improve the long-term yaw.</summary>
		XArbitraryCorrectedZVertical = 2,
		/// <summary>Z axis is vertical; X axis is magnetic north. Magnetometer is used to correct long-term yaw.</summary>
		XMagneticNorthZVertical = 4,
		/// <summary>Z axis is vertical; X axis is true north. Magnetometer is used to correct long-term yaw.</summary>
		XTrueNorthZVertical = 8,
	}
}
