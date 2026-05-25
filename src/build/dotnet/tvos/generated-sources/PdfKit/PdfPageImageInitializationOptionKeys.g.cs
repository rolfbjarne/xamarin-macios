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
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos18.2")]
	public unsafe static partial class PdfPageImageInitializationOptionKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CompressionQualityKey;
		/// <summary>Represents the value associated with the constant 'PDFPageImageInitializationOptionCompressionQuality'.</summary>
		[Field ("PDFPageImageInitializationOptionCompressionQuality",  "PdfKit")]
		public static NSString CompressionQualityKey {
			get {
				if (_CompressionQualityKey is null)
					_CompressionQualityKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFPageImageInitializationOptionCompressionQuality")!;
				return _CompressionQualityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaBoxKey;
		/// <summary>Represents the value associated with the constant 'PDFPageImageInitializationOptionMediaBox'.</summary>
		[Field ("PDFPageImageInitializationOptionMediaBox",  "PdfKit")]
		public static NSString MediaBoxKey {
			get {
				if (_MediaBoxKey is null)
					_MediaBoxKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFPageImageInitializationOptionMediaBox")!;
				return _MediaBoxKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RotationKey;
		/// <summary>Represents the value associated with the constant 'PDFPageImageInitializationOptionRotation'.</summary>
		[Field ("PDFPageImageInitializationOptionRotation",  "PdfKit")]
		public static NSString RotationKey {
			get {
				if (_RotationKey is null)
					_RotationKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFPageImageInitializationOptionRotation")!;
				return _RotationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UpscaleIfSmallerKey;
		/// <summary>Represents the value associated with the constant 'PDFPageImageInitializationOptionUpscaleIfSmaller'.</summary>
		[Field ("PDFPageImageInitializationOptionUpscaleIfSmaller",  "PdfKit")]
		public static NSString UpscaleIfSmallerKey {
			get {
				if (_UpscaleIfSmallerKey is null)
					_UpscaleIfSmallerKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFPageImageInitializationOptionUpscaleIfSmaller")!;
				return _UpscaleIfSmallerKey;
			}
		}
	} /* class PdfPageImageInitializationOptionKeys */
}
