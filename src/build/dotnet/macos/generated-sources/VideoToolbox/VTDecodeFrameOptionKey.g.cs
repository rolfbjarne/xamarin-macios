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
namespace VideoToolbox {
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public unsafe static partial class VTDecodeFrameOptionKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentAnalyzerCropRectangle;
		/// <summary>Represents the value associated with the constant 'kVTDecodeFrameOptionKey_ContentAnalyzerCropRectangle'.</summary>
		[Field ("kVTDecodeFrameOptionKey_ContentAnalyzerCropRectangle",  "VideoToolbox")]
		public static NSString ContentAnalyzerCropRectangle {
			get {
				if (_ContentAnalyzerCropRectangle is null)
					_ContentAnalyzerCropRectangle = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecodeFrameOptionKey_ContentAnalyzerCropRectangle")!;
				return _ContentAnalyzerCropRectangle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentAnalyzerRotation;
		/// <summary>Represents the value associated with the constant 'kVTDecodeFrameOptionKey_ContentAnalyzerRotation'.</summary>
		[Field ("kVTDecodeFrameOptionKey_ContentAnalyzerRotation",  "VideoToolbox")]
		public static NSString ContentAnalyzerRotation {
			get {
				if (_ContentAnalyzerRotation is null)
					_ContentAnalyzerRotation = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecodeFrameOptionKey_ContentAnalyzerRotation")!;
				return _ContentAnalyzerRotation;
			}
		}
	} /* class VTDecodeFrameOptionKey */
}
