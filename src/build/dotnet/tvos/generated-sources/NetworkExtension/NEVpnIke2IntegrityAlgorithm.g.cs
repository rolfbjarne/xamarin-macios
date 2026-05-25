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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace NetworkExtension {
	/// <summary>Enumerates the valid integrity algorithms for <see cref="P:NetworkExtension.NEVpnIke2SecurityAssociationParameters.IntegrityAlgorithm" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native ("NEVPNIKEv2IntegrityAlgorithm")]
	public enum NEVpnIke2IntegrityAlgorithm : long {
		/// <summary>Indicates the SHA-1 96-bit algorithm.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios26.0", "Not supported anymore.")]
		[ObsoletedOSPlatform ("macos26.0", "Not supported anymore.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Not supported anymore.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		SHA96 = 1,
		/// <summary>Indicates the SHA-1 160-bit algorithm.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios26.0", "Not supported anymore.")]
		[ObsoletedOSPlatform ("macos26.0", "Not supported anymore.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Not supported anymore.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		SHA160 = 2,
		/// <summary>Indicates the SHA-2 256-bit algorithm.</summary>
		SHA256 = 3,
		/// <summary>Indicates the SHA-2 384-bit algorithm.</summary>
		SHA384 = 4,
		/// <summary>Indicates the SHA-2 512-bit algorithm.</summary>
		SHA512 = 5,
	}
}
