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
	[SupportedOSPlatform ("ios17.4")]
	[SupportedOSPlatform ("tvos17.4")]
	[SupportedOSPlatform ("macos14.4")]
	[SupportedOSPlatform ("maccatalyst17.4")]
	public unsafe static partial class VTSampleAttachmentQualityMetricsKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaBlueMeanSquaredError;
		/// <summary>Represents the value associated with the constant 'kVTSampleAttachmentQualityMetricsKey_ChromaBlueMeanSquaredError'.</summary>
		[Field ("kVTSampleAttachmentQualityMetricsKey_ChromaBlueMeanSquaredError",  "VideoToolbox")]
		public static NSString ChromaBlueMeanSquaredError {
			get {
				if (_ChromaBlueMeanSquaredError is null)
					_ChromaBlueMeanSquaredError = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTSampleAttachmentQualityMetricsKey_ChromaBlueMeanSquaredError")!;
				return _ChromaBlueMeanSquaredError;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaRedMeanSquaredError;
		/// <summary>Represents the value associated with the constant 'kVTSampleAttachmentQualityMetricsKey_ChromaRedMeanSquaredError'.</summary>
		[Field ("kVTSampleAttachmentQualityMetricsKey_ChromaRedMeanSquaredError",  "VideoToolbox")]
		public static NSString ChromaRedMeanSquaredError {
			get {
				if (_ChromaRedMeanSquaredError is null)
					_ChromaRedMeanSquaredError = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTSampleAttachmentQualityMetricsKey_ChromaRedMeanSquaredError")!;
				return _ChromaRedMeanSquaredError;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LumaMeanSquaredError;
		/// <summary>Represents the value associated with the constant 'kVTSampleAttachmentQualityMetricsKey_LumaMeanSquaredError'.</summary>
		[Field ("kVTSampleAttachmentQualityMetricsKey_LumaMeanSquaredError",  "VideoToolbox")]
		public static NSString LumaMeanSquaredError {
			get {
				if (_LumaMeanSquaredError is null)
					_LumaMeanSquaredError = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTSampleAttachmentQualityMetricsKey_LumaMeanSquaredError")!;
				return _LumaMeanSquaredError;
			}
		}
	} /* class VTSampleAttachmentQualityMetricsKey */
}
