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
namespace CoreML {
	/// <summary>Enumerates the kinds of features supported by CoreML.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum MLFeatureType : long {
		/// <summary>An invalid value for a feature.</summary>
		Invalid = 0,
		/// <summary>A 64-bit integer feature.</summary>
		Int64 = 1,
		/// <summary>A double-precision floating-point value feature.</summary>
		Double = 2,
		/// <summary>A string feature.</summary>
		String = 3,
		/// <summary>An image feature.</summary>
		Image = 4,
		/// <summary>A multidimensional array feature.</summary>
		MultiArray = 5,
		/// <summary>A dictionary / map feature. The dictionary is of type <see cref="T:System.Object" /> -&gt; <see cref="T:Foundation.NSNumber" />.</summary>
		Dictionary = 6,
		/// <summary>Sequence data, such as a time series or words ordered as text.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Sequence = 7,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		State = 8,
	}
}
