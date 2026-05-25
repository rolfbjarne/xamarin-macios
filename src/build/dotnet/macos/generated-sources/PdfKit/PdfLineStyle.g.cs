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
namespace PdfKit {
	/// <summary>Enumerates line ending styles</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[Native]
	public enum PdfLineStyle : long {
		/// <summary>Indicates no line ending glyph.</summary>
		None = 0,
		/// <summary>Indicates a solid square line ending glyph.</summary>
		Square = 1,
		/// <summary>Indicates a filled circle line ending glyph.</summary>
		Circle = 2,
		/// <summary>Indicates a solid diamond line ending glyph.</summary>
		Diamond = 3,
		/// <summary>Indicates an open arrow line ending glyph.</summary>
		OpenArrow = 4,
		/// <summary>Indicates a solid triangular line ending glyph.</summary>
		ClosedArrow = 5,
	}
}
