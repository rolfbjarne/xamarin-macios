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
	/// <summary>An enumeration whose values specify whether the time value of a <see cref="T:SpriteKit.SKKeyframeSequence" /> should cycle.</summary>
	[Native]
	public enum SKRepeatMode : long {
		/// <summary>After the last keyframe's time sequence is past, the last keyframe's value is returned.</summary>
		Clamp = 1,
		/// <summary>After the last keyframe's time sequence is past, the sequence loops back to the first keyframe.</summary>
		Loop = 2,
	}
}
