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
namespace PdfKit {
	/// <summary>Enumerates Adobe-specified PDF display box boundaries.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[Native]
	public enum PdfDisplayBox : long {
		/// <summary>Indicates a rectangle around a physical medium in user space.</summary>
		Media = 0,
		/// <summary>Indicates a crop rectangle around the visible portion of the page.</summary>
		Crop = 1,
		/// <summary>Indicates a bleed box for production.</summary>
		Bleed = 2,
		/// <summary>Indicates a box around intended finish boundaries.</summary>
		Trim = 3,
		/// <summary>Indicates a rectangle around the boundaries of a page's content for display.</summary>
		Art = 4,
	}
}
