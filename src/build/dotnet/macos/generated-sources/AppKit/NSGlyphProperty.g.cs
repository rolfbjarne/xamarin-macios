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
namespace AppKit {
	/// <summary>An enumeration whose values specify characteristics of a glyph.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum NSGlyphProperty : long {
		/// <summary>Null glyph; ignored for layout and display.</summary>
		Null = 1,
		/// <summary>A control character such as tab, that has associated special behavior.</summary>
		ControlCharacter = 2,
		/// <summary>Glyphs such as whitespace that have elastic width behavior.</summary>
		Elastic = 4,
		/// <summary>Glyphs with combining properties, often characters in Unicode Mn class.</summary>
		NonBaseCharacter = 8,
	}
}
