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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MetalPerformanceShaders {
	/// <summary>Enumerates values that indicate if and what kind of color premultiplication will be applied to color values.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum MPSAlphaType : ulong {
		/// <summary>Indicates that the image will not be premultiplied, and the alpha channel will not be guaranteed to be 1.</summary>
		NonPremultiplied = 0,
		/// <summary>Indicates that the alpha channel will be clamped to 1, even if it is not encoded in the source data.</summary>
		AlphaIsOne = 1,
		/// <summary>Indicates that the image will be premultiplied, and the alpha channel will not be guaranteed to be 1.</summary>
		Premultiplied = 2,
	}
}
