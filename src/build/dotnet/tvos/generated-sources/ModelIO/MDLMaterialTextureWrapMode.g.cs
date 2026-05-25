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
namespace ModelIO {
	/// <summary>Enumerates procedures for handling texture coordinates outside of the range <c>[0.0,1.0]</c>.</summary>
	[Native]
	public enum MDLMaterialTextureWrapMode : ulong {
		/// <summary>Clamp coordinates outside the range <c>[0.0,1.0]</c> to <c>0.0</c> if low, or <c>1.0</c> if high.</summary>
		Clamp = 0,
		/// <summary>Use only the fractional part of the coordinate.</summary>
		Repeat = 1,
		/// <summary>Reflect coordinates outside the range <c>[0.0,1.0]</c> so that, for example, <c>1.3</c> maps to <c>0.7</c>, and <c>2.3</c> maps to <c>0.3</c>.</summary>
		Mirror = 2,
	}
}
