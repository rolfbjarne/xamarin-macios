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
	/// <summary>An enumeration whose values specify how a <see cref="T:SpriteKit.SKTexture" /> is rendered on a <see cref="T:SpriteKit.SKSpriteNode" /> of a different size.</summary>
	[Native]
	public enum SKTextureFilteringMode : long {
		/// <summary>The pixel is calculated using the nearest point in the texture. Faster, lower quality.</summary>
		Nearest = 0,
		/// <summary>The pixel is calculated using a linear filter of the nearby texture pixels. Slower, higher quality.</summary>
		Linear = 1,
	}
}
