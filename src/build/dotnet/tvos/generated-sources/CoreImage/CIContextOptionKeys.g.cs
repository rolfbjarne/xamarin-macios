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
namespace CoreImage {
	internal unsafe static partial class CIContextOptionKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowLowPower;
		/// <summary>Represents the value associated with the constant 'kCIContextAllowLowPower'.</summary>
		[Field ("kCIContextAllowLowPower",  "CoreImage")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AllowLowPower {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AllowLowPower is null)
					_AllowLowPower = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIContextAllowLowPower")!;
				return _AllowLowPower;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CVMetalTextureCache;
		/// <summary>Represents the value associated with the constant 'kCIContextCVMetalTextureCache'.</summary>
		[Field ("kCIContextCVMetalTextureCache",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public static NSString CVMetalTextureCache {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			get {
				if (_CVMetalTextureCache is null)
					_CVMetalTextureCache = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIContextCVMetalTextureCache")!;
				return _CVMetalTextureCache;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CacheIntermediates;
		/// <summary>Represents the value associated with the constant 'kCIContextCacheIntermediates'.</summary>
		[Field ("kCIContextCacheIntermediates",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString CacheIntermediates {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_CacheIntermediates is null)
					_CacheIntermediates = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIContextCacheIntermediates")!;
				return _CacheIntermediates;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HighQualityDownsample;
		/// <summary>Represents the value associated with the constant 'kCIContextHighQualityDownsample'.</summary>
		[Field ("kCIContextHighQualityDownsample",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString HighQualityDownsample {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_HighQualityDownsample is null)
					_HighQualityDownsample = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIContextHighQualityDownsample")!;
				return _HighQualityDownsample;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MemoryLimit;
		/// <summary>Represents the value associated with the constant 'kCIContextMemoryLimit'.</summary>
		[Field ("kCIContextMemoryLimit",  "CoreImage")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString MemoryLimit {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_MemoryLimit is null)
					_MemoryLimit = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIContextMemoryLimit")!;
				return _MemoryLimit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Name;
		/// <summary>Represents the value associated with the constant 'kCIContextName'.</summary>
		[Field ("kCIContextName",  "CoreImage")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Name {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Name is null)
					_Name = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIContextName")!;
				return _Name;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OutputColorSpace;
		/// <summary>Represents the value associated with the constant 'kCIContextOutputColorSpace'.</summary>
		[Field ("kCIContextOutputColorSpace",  "CoreImage")]
		public static NSString OutputColorSpace {
			get {
				if (_OutputColorSpace is null)
					_OutputColorSpace = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIContextOutputColorSpace")!;
				return _OutputColorSpace;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OutputPremultiplied;
		/// <summary>Represents the value associated with the constant 'kCIContextOutputPremultiplied'.</summary>
		[Field ("kCIContextOutputPremultiplied",  "CoreImage")]
		public static NSString OutputPremultiplied {
			get {
				if (_OutputPremultiplied is null)
					_OutputPremultiplied = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIContextOutputPremultiplied")!;
				return _OutputPremultiplied;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PriorityRequestLow;
		/// <summary>Represents the value associated with the constant 'kCIContextPriorityRequestLow'.</summary>
		[Field ("kCIContextPriorityRequestLow",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PriorityRequestLow {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PriorityRequestLow is null)
					_PriorityRequestLow = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIContextPriorityRequestLow")!;
				return _PriorityRequestLow;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UseSoftwareRenderer;
		/// <summary>Represents the value associated with the constant 'kCIContextUseSoftwareRenderer'.</summary>
		[Field ("kCIContextUseSoftwareRenderer",  "CoreImage")]
		public static NSString UseSoftwareRenderer {
			get {
				if (_UseSoftwareRenderer is null)
					_UseSoftwareRenderer = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIContextUseSoftwareRenderer")!;
				return _UseSoftwareRenderer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkingColorSpace;
		/// <summary>Represents the value associated with the constant 'kCIContextWorkingColorSpace'.</summary>
		[Field ("kCIContextWorkingColorSpace",  "CoreImage")]
		public static NSString WorkingColorSpace {
			get {
				if (_WorkingColorSpace is null)
					_WorkingColorSpace = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIContextWorkingColorSpace")!;
				return _WorkingColorSpace;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkingFormatField;
		/// <summary>Represents the value associated with the constant 'kCIContextWorkingFormat'.</summary>
		[Field ("kCIContextWorkingFormat",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString WorkingFormatField {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_WorkingFormatField is null)
					_WorkingFormatField = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIContextWorkingFormat")!;
				return _WorkingFormatField;
			}
		}
	} /* class CIContextOptionKeys */
}
