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
namespace Metal {
	/// <summary>Argument values for use with <see cref="T:Metal.MTLBlendOperation" />.</summary>
	[Native]
	public enum MTLBlendFactor : ulong {
		/// <summary>To be added.</summary>
		Zero = 0,
		/// <summary>To be added.</summary>
		One = 1,
		/// <summary>To be added.</summary>
		SourceColor = 2,
		/// <summary>To be added.</summary>
		OneMinusSourceColor = 3,
		/// <summary>To be added.</summary>
		SourceAlpha = 4,
		/// <summary>To be added.</summary>
		OneMinusSourceAlpha = 5,
		/// <summary>To be added.</summary>
		DestinationColor = 6,
		/// <summary>To be added.</summary>
		OneMinusDestinationColor = 7,
		/// <summary>To be added.</summary>
		DestinationAlpha = 8,
		/// <summary>To be added.</summary>
		OneMinusDestinationAlpha = 9,
		/// <summary>To be added.</summary>
		SourceAlphaSaturated = 10,
		/// <summary>To be added.</summary>
		BlendColor = 11,
		/// <summary>To be added.</summary>
		OneMinusBlendColor = 12,
		/// <summary>To be added.</summary>
		BlendAlpha = 13,
		/// <summary>To be added.</summary>
		OneMinusBlendAlpha = 14,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Source1Color = 15,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		OneMinusSource1Color = 16,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Source1Alpha = 17,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		OneMinusSource1Alpha = 18,
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		Unspecialized = 19,
	}
}
