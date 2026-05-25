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
namespace UIKit {
	/// <summary>An enumeration whose values specify whether a <see cref="T:UIKit.UICollisionBehavior" /> detects collisions to boundaries, items, or everything.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum UICollisionBehaviorMode : ulong {
		/// <summary>The dynamic items collide only with each and not with collision boundaries.</summary>
		Items = 1,
		/// <summary>The dynamic items will not collide with each other, only the specified collision boundaries.</summary>
		Boundaries = 2,
		/// <summary>The dynamic items will collide with each other or the specified collision boundaries.</summary>
		Everything = 18446744073709551615,
	}
}
