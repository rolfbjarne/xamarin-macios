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
	/// <summary>Enumeration of the ways in which overlapping particles emitted by a <see cref="T:SceneKit.SCNParticleSystem" /> will be rendered.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum SCNParticleBlendMode : long {
		/// <summary>To be added.</summary>
		Additive = 0,
		/// <summary>To be added.</summary>
		Subtract = 1,
		/// <summary>To be added.</summary>
		Multiply = 2,
		/// <summary>To be added.</summary>
		Screen = 3,
		/// <summary>To be added.</summary>
		Alpha = 4,
		/// <summary>To be added.</summary>
		Replace = 5,
	}
}
