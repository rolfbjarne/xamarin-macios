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
namespace SpriteKit {
	/// <summary>An enumeration whose values specify the time-varying behavior of a <see cref="T:SpriteKit.SKAction" />. Used with <see cref="P:SpriteKit.SKAction.TimingMode" />.</summary>
	[Native]
	public enum SKActionTimingMode : long {
		/// <summary>Render the animation with no easing.</summary>
		Linear = 0,
		/// <summary>Ease the animation in.</summary>
		EaseIn = 1,
		/// <summary>Ease the animation out.</summary>
		EaseOut = 2,
		/// <summary>Ease the animation in and out.</summary>
		EaseInEaseOut = 3,
	}
}
