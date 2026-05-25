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
namespace SceneKit {
	/// <summary>Enumerates texture-wrapping techniques.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum SCNWrapMode : long {
		/// <summary>Clamps texture coordinates to the range [0,1].</summary>
		Clamp = 1,
		/// <summary>Uses the fractional part of the texture coordinate, so effectively 0.0 to less than 1.0.</summary>
		Repeat = 2,
		/// <summary>Uses texture colors in the range [0,1] and the material's border color otherwise.</summary>
		ClampToBorder = 3,
		/// <summary>Texture coordinates outside the range [0,1] are treated as if the range reverses before repeating.</summary>
		Mirror = 4,
	}
}
