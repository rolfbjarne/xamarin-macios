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
namespace CoreMedia {
	/// <summary>An enumeration whose values specify errors relating to <see cref="CoreMedia.CMBlockBuffer" />s.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CMBlockBufferError : int {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		StructureAllocationFailed = -12700,
		/// <summary>To be added.</summary>
		BlockAllocationFailed = -12701,
		/// <summary>To be added.</summary>
		BadCustomBlockSource = -12702,
		/// <summary>To be added.</summary>
		BadOffsetParameter = -12703,
		/// <summary>To be added.</summary>
		BadLengthParameter = -12704,
		/// <summary>To be added.</summary>
		BadPointerParameter = -12705,
		/// <summary>To be added.</summary>
		EmptyBlockBuffer = -12706,
		/// <summary>To be added.</summary>
		UnallocatedBlock = -12707,
		/// <summary>To be added.</summary>
		InsufficientSpace = -12708,
	}
}
