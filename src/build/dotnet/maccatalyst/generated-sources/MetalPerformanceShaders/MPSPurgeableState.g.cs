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
namespace MetalPerformanceShaders {
	/// <summary>Enumerates an image's underlying texture's purgeable state.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum MPSPurgeableState : ulong {
		/// <summary>Indicates that the underlying texture has not been allocated.</summary>
		AllocationDeferred = 0,
		/// <summary>Indicates that the underlying texture can be queried without changing its purgeable state.</summary>
		KeepCurrent = 1,
		/// <summary>Indicates that the texture may not be discarded.</summary>
		NonVolatile = 2,
		/// <summary>Indicates that the texture may be, but does not have to be, discarded.</summary>
		Volatile = 3,
		/// <summary>Indicates that the underlying texture should be discarded.</summary>
		Empty = 4,
	}
}
