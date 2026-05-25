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
namespace Metal {
	/// <summary>Enumerates the hardware feature sets that are available on a device.</summary>
	[Native]
	public enum MTLFeatureSet : ulong {
		/// <summary>The iOS GPU Family 1 v1 feature set.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		iOS_GPUFamily1_v1 = 0,
		/// <summary>The iOS GPU Family 1 v2 feature set.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		iOS_GPUFamily1_v2 = 2,
		/// <summary>The iOS GPU Family 2 v1 feature set.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		iOS_GPUFamily2_v1 = 1,
		/// <summary>The iOS GPU Family 2 v2 feature set.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		iOS_GPUFamily2_v2 = 3,
		/// <summary>The iOS GPU Family 3 v1 feature set.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		iOS_GPUFamily3_v1 = 4,
		/// <summary>The iOS GPU Family 1 v3 feature set.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		iOS_GPUFamily1_v3 = 5,
		/// <summary>The iOS GPU Family 2 v3 feature set.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		iOS_GPUFamily2_v3 = 6,
		/// <summary>The iOS GPU Family 3 v2 feature set.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		iOS_GPUFamily3_v2 = 7,
		/// <summary>The iOS GPU Family 1 v4 feature set.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		iOS_GPUFamily1_v4 = 8,
		/// <summary>The iOS GPU Family 2 v4 feature set.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		iOS_GPUFamily2_v4 = 9,
		/// <summary>The iOS GPU Family 3 v3 feature set.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		iOS_GPUFamily3_v3 = 10,
		/// <summary>The iOS GPU Family 4 v1 feature set.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		iOS_GPUFamily4_v1 = 11,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		iOS_GPUFamily1_v5 = 12,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		iOS_GPUFamily2_v5 = 13,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		iOS_GPUFamily3_v4 = 14,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		iOS_GPUFamily4_v2 = 15,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		iOS_GPUFamily5_v1 = 16,
		/// <summary>The macOS GPU Family 1 v1 feature set.</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		macOS_GPUFamily1_v1 = 10000,
		/// <summary>The macOS GPU Family 1 v2 feature set.</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		macOS_GPUFamily1_v2 = 10001,
		/// <summary>The macOS read-write texture, tier 2 feature set.</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		macOS_ReadWriteTextureTier2 = 10002,
		/// <summary>The macOS GPU Family 1 v3 feature set.</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		macOS_GPUFamily1_v3 = 10003,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		macOS_GPUFamily1_v4 = 10004,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		macOS_GPUFamily2_v1 = 10005,
		/// <summary>The tvOS GPU Family 1 v1 feature set.</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		tvOS_GPUFamily1_v1 = 30000,
		/// <summary>The TVOS GPU Family 1 v2 feature set.</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		tvOS_GPUFamily1_v2 = 30001,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		tvOS_GPUFamily1_v3 = 30002,
		/// <summary>The TVOS GPU Family 2 v1 feature set.</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		tvOS_GPUFamily2_v1 = 30003,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		tvOS_GPUFamily1_v4 = 30004,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		tvOS_GPUFamily2_v2 = 30005,
	}
}
