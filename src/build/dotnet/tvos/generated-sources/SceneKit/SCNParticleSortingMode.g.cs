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
	/// <summary>Enumeration specifying the order in which particles emitted by a <see cref="T:SceneKit.SCNParticleSystem" /> are rendered.</summary><remarks><para>Along with <see cref="P:SceneKit.SCNParticleSystem.BlendMode" />, <see cref="P:SceneKit.SCNParticleSystem.SortingMode" /> affects the appearance of overlapping particles.</para></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum SCNParticleSortingMode : long {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		ProjectedDepth = 1,
		/// <summary>To be added.</summary>
		Distance = 2,
		/// <summary>To be added.</summary>
		OldestFirst = 3,
		/// <summary>To be added.</summary>
		YoungestFirst = 4,
	}
}
