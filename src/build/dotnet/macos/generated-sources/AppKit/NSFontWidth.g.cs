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
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSFontWidth  {
		/// <summary>Represents the value associated with the constant 'NSFontWidthCompressed'.</summary>
		[Field ("NSFontWidthCompressed",  "AppKit")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static double Compressed {
			[SupportedOSPlatform ("macos13.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				return Dlfcn.GetDouble (Libraries.AppKit.Handle, "NSFontWidthCompressed");
			}
		}
		/// <summary>Represents the value associated with the constant 'NSFontWidthCondensed'.</summary>
		[Field ("NSFontWidthCondensed",  "AppKit")]
		public static double Condensed {
			get {
				return Dlfcn.GetDouble (Libraries.AppKit.Handle, "NSFontWidthCondensed");
			}
		}
		/// <summary>Represents the value associated with the constant 'NSFontWidthExpanded'.</summary>
		[Field ("NSFontWidthExpanded",  "AppKit")]
		public static double Expanded {
			get {
				return Dlfcn.GetDouble (Libraries.AppKit.Handle, "NSFontWidthExpanded");
			}
		}
		/// <summary>Represents the value associated with the constant 'NSFontWidthStandard'.</summary>
		[Field ("NSFontWidthStandard",  "AppKit")]
		public static double Standard {
			get {
				return Dlfcn.GetDouble (Libraries.AppKit.Handle, "NSFontWidthStandard");
			}
		}
	} /* class NSFontWidth */
}
