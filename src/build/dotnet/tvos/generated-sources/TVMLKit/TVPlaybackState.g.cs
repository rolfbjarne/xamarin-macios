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
namespace TVMLKit {
	[ObsoletedOSPlatform ("tvos18.0", "Use SwiftUI or UIKit instead.")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum TVPlaybackState : long {
		Undefined = 0,
		Begin = 1,
		Loading = 2,
		Playing = 3,
		Paused = 4,
		Scanning = 5,
		FastForwarding = 6,
		Rewinding = 7,
		End = 8,
	}
}
