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
	/// <summary>Contains values that describe the data with which an <see cref="T:SpriteKit.SKUniform" /> was initialized.</summary>
	[Native]
	public enum SKUniformType : long {
		/// <summary>The <see cref="T:SpriteKit.SKUniform" /> has not been initialized.</summary>
		None = 0,
		/// <summary>The <see cref="T:SpriteKit.SKUniform" /> was initialized with a float.</summary>
		Float = 1,
		/// <summary>The <see cref="T:SpriteKit.SKUniform" /> was initialized with a vector that contains 2 floats.</summary>
		FloatVector2 = 2,
		/// <summary>The <see cref="T:SpriteKit.SKUniform" /> was initialized with a vector that contains 3 floats.</summary>
		FloatVector3 = 3,
		/// <summary>The <see cref="T:SpriteKit.SKUniform" /> was initialized with a vector that contains 4 floats.</summary>
		FloatVector4 = 4,
		/// <summary>The <see cref="T:SpriteKit.SKUniform" /> was initialized with a 2x2 array of floats.</summary>
		FloatMatrix2 = 5,
		/// <summary>The <see cref="T:SpriteKit.SKUniform" /> was initialized with a 3x3 array of floats.</summary>
		FloatMatrix3 = 6,
		/// <summary>The <see cref="T:SpriteKit.SKUniform" /> was initialized with a 4x4 array of floats.</summary>
		FloatMatrix4 = 7,
		/// <summary>The <see cref="T:SpriteKit.SKUniform" /> contains texture data.</summary>
		Texture = 8,
	}
}
