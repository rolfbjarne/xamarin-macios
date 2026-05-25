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
	/// <summary>Enumerates material property types.</summary>
	[Native]
	public enum MDLMaterialPropertyType : ulong {
		/// <summary>Indicates an uninitialized property.</summary>
		None = 0,
		/// <summary>Indicates a property that contains a string.</summary>
		String = 1,
		/// <summary>Indicates a property that contains a URL that typically addresses a texture.</summary>
		Url = 2,
		/// <summary>Indicates a property that contains a texture.</summary>
		Texture = 3,
		/// <summary>Indicates a property that specifies a color.</summary>
		Color = 4,
		/// <summary>Indicates a property that contains a floating-point value.</summary>
		Float = 5,
		/// <summary>Indicates a vector property that contains two floating-point values.</summary>
		Float2 = 6,
		/// <summary>Indicates a vector property that contains three floating-point values.</summary>
		Float3 = 7,
		/// <summary>Indicates a vector property that contains four floating-point values.</summary>
		Float4 = 8,
		/// <summary>Indicates a property that contains a 4x4 matrix of floating-point values.</summary>
		Matrix44 = 9,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Buffer = 10,
	}
}
