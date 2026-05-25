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
namespace GameKit {
	/// <summary>The session mode.</summary><remarks>To be added.</remarks>
	[ObsoletedOSPlatform ("ios7.0")]
	[ObsoletedOSPlatform ("tvos9.0")]
	[ObsoletedOSPlatform ("macos10.10")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum GKSessionMode : int {
		/// <summary>Acting as a server.</summary>
		Server = 0,
		/// <summary>Acting as a client.</summary>
		Client = 1,
		/// <summary>Acting as a peer.</summary>
		Peer = 2,
	}
}
