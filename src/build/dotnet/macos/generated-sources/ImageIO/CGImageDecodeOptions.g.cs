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
namespace ImageIO {
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public unsafe partial class CGImageDecodeOptions  {
		/// <summary>Represents the value associated with the constant 'kCGComputeHDRStats'.</summary>
		[Field ("kCGComputeHDRStats",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		internal static nint ComputeHdrStats {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				return Dlfcn.GetIntPtr (Libraries.ImageIO.Handle, "kCGComputeHDRStats");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGImageSourceDecodeRequest'.</summary>
		[Field ("kCGImageSourceDecodeRequest",  "ImageIO")]
		internal static nint DecodeRequest {
			get {
				return Dlfcn.GetIntPtr (Libraries.ImageIO.Handle, "kCGImageSourceDecodeRequest");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGImageSourceDecodeRequestOptions'.</summary>
		[Field ("kCGImageSourceDecodeRequestOptions",  "ImageIO")]
		internal static nint DecodeRequestOptions {
			get {
				return Dlfcn.GetIntPtr (Libraries.ImageIO.Handle, "kCGImageSourceDecodeRequestOptions");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGImageSourceDecodeToHDR'.</summary>
		[Field ("kCGImageSourceDecodeToHDR",  "ImageIO")]
		internal static nint DecodeToHDR {
			get {
				return Dlfcn.GetIntPtr (Libraries.ImageIO.Handle, "kCGImageSourceDecodeToHDR");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGImageSourceDecodeToSDR'.</summary>
		[Field ("kCGImageSourceDecodeToSDR",  "ImageIO")]
		internal static nint DecodeToSDR {
			get {
				return Dlfcn.GetIntPtr (Libraries.ImageIO.Handle, "kCGImageSourceDecodeToSDR");
			}
		}
		/// <summary>Represents the value associated with the constant 'kCGImageSourceGenerateImageSpecificLumaScaling'.</summary>
		[Field ("kCGImageSourceGenerateImageSpecificLumaScaling",  "ImageIO")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		internal static nint GenerateImageSpecificLumaScaling {
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			get {
				return Dlfcn.GetIntPtr (Libraries.ImageIO.Handle, "kCGImageSourceGenerateImageSpecificLumaScaling");
			}
		}
	} /* class CGImageDecodeOptions */
}
