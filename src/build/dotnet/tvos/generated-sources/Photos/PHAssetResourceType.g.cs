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
namespace Photos {
	/// <summary>Enumerates types of <see cref="T:Photos.PHAssetResource" /> data.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum PHAssetResourceType : long {
		/// <summary>Photo data.</summary>
		Photo = 1,
		/// <summary>Video data.</summary>
		Video = 2,
		/// <summary>Audio data.</summary>
		Audio = 3,
		/// <summary>Photo data in an alternate format (such as JPEG for a RAW photo).</summary>
		AlternatePhoto = 4,
		/// <summary>Photo data in the highest quality and size available.</summary>
		FullSizePhoto = 5,
		/// <summary>Video data in the highest quality and size available.</summary>
		FullSizeVideo = 6,
		/// <summary>Data used to reconstruct edits to an asset.</summary>
		AdjustmentData = 7,
		/// <summary>An unaltered copy of the original photo.</summary>
		AdjustmentBasePhoto = 8,
		/// <summary>Original video data for a Live Photo.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		PairedVideo = 9,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		FullSizePairedVideo = 10,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		AdjustmentBasePairedVideo = 11,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		AdjustmentBaseVideo = 12,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		PhotoProxy = 19,
	}
}
