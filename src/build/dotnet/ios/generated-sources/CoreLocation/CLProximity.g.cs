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
namespace CoreLocation {
	/// <summary>An enumeration whose values specify the physical proximity of an iBeacon.</summary><remarks><para>The returned value of <see cref="P:CoreLocation.CLBeacon.Proximity" /> varies based on power output and the physical environment. It is difficult to translate these qualitative values into absolute physical distances.</para></remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum CLProximity : long {
		/// <summary>The distance to the iBeacon could not be estimated.</summary>
		Unknown = 0,
		/// <summary>The closest distance reported by an iBeacon.</summary>
		Immediate = 1,
		/// <summary>An intermediate distance reported by an iBeacon.</summary>
		Near = 2,
		/// <summary>The furthest distance reported by an iBeacon.</summary>
		Far = 3,
	}
}
