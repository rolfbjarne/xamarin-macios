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
namespace CoreImage {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class CIImageRepresentationKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVDepthDataKey;
		/// <summary>Represents the value associated with the constant 'kCIImageRepresentationAVDepthData'.</summary>
		[Field ("kCIImageRepresentationAVDepthData",  "CoreImage")]
		public static NSString AVDepthDataKey {
			get {
				if (_AVDepthDataKey is null)
					_AVDepthDataKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageRepresentationAVDepthData")!;
				return _AVDepthDataKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVPortraitEffectsMatteKey;
		/// <summary>Represents the value associated with the constant 'kCIImageRepresentationAVPortraitEffectsMatte'.</summary>
		[Field ("kCIImageRepresentationAVPortraitEffectsMatte",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AVPortraitEffectsMatteKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AVPortraitEffectsMatteKey is null)
					_AVPortraitEffectsMatteKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageRepresentationAVPortraitEffectsMatte")!;
				return _AVPortraitEffectsMatteKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DepthImageKey;
		/// <summary>Represents the value associated with the constant 'kCIImageRepresentationDepthImage'.</summary>
		[Field ("kCIImageRepresentationDepthImage",  "CoreImage")]
		public static NSString DepthImageKey {
			get {
				if (_DepthImageKey is null)
					_DepthImageKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageRepresentationDepthImage")!;
				return _DepthImageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisparityImageKey;
		/// <summary>Represents the value associated with the constant 'kCIImageRepresentationDisparityImage'.</summary>
		[Field ("kCIImageRepresentationDisparityImage",  "CoreImage")]
		public static NSString DisparityImageKey {
			get {
				if (_DisparityImageKey is null)
					_DisparityImageKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageRepresentationDisparityImage")!;
				return _DisparityImageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HdrGainMapImageKey;
		/// <summary>Represents the value associated with the constant 'kCIImageRepresentationHDRGainMapImage'.</summary>
		[Field ("kCIImageRepresentationHDRGainMapImage",  "CoreImage")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString HdrGainMapImageKey {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_HdrGainMapImageKey is null)
					_HdrGainMapImageKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageRepresentationHDRGainMapImage")!;
				return _HdrGainMapImageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HdrImageKey;
		/// <summary>Represents the value associated with the constant 'kCIImageRepresentationHDRImage'.</summary>
		[Field ("kCIImageRepresentationHDRImage",  "CoreImage")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString HdrImageKey {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_HdrImageKey is null)
					_HdrImageKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageRepresentationHDRImage")!;
				return _HdrImageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LossyCompressionQualityKey;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationLossyCompressionQuality'.</summary>
		[Field ("kCGImageDestinationLossyCompressionQuality",  "ImageIO")]
		public static NSString LossyCompressionQualityKey {
			get {
				if (_LossyCompressionQualityKey is null)
					_LossyCompressionQualityKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationLossyCompressionQuality")!;
				return _LossyCompressionQualityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PortraitEffectsMatteImageKey;
		/// <summary>Represents the value associated with the constant 'kCIImageRepresentationPortraitEffectsMatteImage'.</summary>
		[Field ("kCIImageRepresentationPortraitEffectsMatteImage",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PortraitEffectsMatteImageKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PortraitEffectsMatteImageKey is null)
					_PortraitEffectsMatteImageKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageRepresentationPortraitEffectsMatteImage")!;
				return _PortraitEffectsMatteImageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RepresentationHdrGainMapAsRgbKey;
		/// <summary>Represents the value associated with the constant 'kCIImageRepresentationHDRGainMapAsRGB'.</summary>
		[Field ("kCIImageRepresentationHDRGainMapAsRGB",  "CoreImage")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public static NSString RepresentationHdrGainMapAsRgbKey {
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				if (_RepresentationHdrGainMapAsRgbKey is null)
					_RepresentationHdrGainMapAsRgbKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageRepresentationHDRGainMapAsRGB")!;
				return _RepresentationHdrGainMapAsRgbKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SemanticSegmentationGlassesMatteImageKey;
		/// <summary>Represents the value associated with the constant 'kCIImageRepresentationSemanticSegmentationGlassesMatteImage'.</summary>
		[Field ("kCIImageRepresentationSemanticSegmentationGlassesMatteImage",  "CoreImage")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SemanticSegmentationGlassesMatteImageKey {
			[SupportedOSPlatform ("ios14.1")]
			[SupportedOSPlatform ("tvos14.2")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SemanticSegmentationGlassesMatteImageKey is null)
					_SemanticSegmentationGlassesMatteImageKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageRepresentationSemanticSegmentationGlassesMatteImage")!;
				return _SemanticSegmentationGlassesMatteImageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SemanticSegmentationHairMatteImageKey;
		/// <summary>Represents the value associated with the constant 'kCIImageRepresentationSemanticSegmentationHairMatteImage'.</summary>
		[Field ("kCIImageRepresentationSemanticSegmentationHairMatteImage",  "CoreImage")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SemanticSegmentationHairMatteImageKey {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SemanticSegmentationHairMatteImageKey is null)
					_SemanticSegmentationHairMatteImageKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageRepresentationSemanticSegmentationHairMatteImage")!;
				return _SemanticSegmentationHairMatteImageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SemanticSegmentationMattesKey;
		/// <summary>Represents the value associated with the constant 'kCIImageRepresentationAVSemanticSegmentationMattes'.</summary>
		[Field ("kCIImageRepresentationAVSemanticSegmentationMattes",  "CoreImage")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SemanticSegmentationMattesKey {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SemanticSegmentationMattesKey is null)
					_SemanticSegmentationMattesKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageRepresentationAVSemanticSegmentationMattes")!;
				return _SemanticSegmentationMattesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SemanticSegmentationSkinMatteImageKey;
		/// <summary>Represents the value associated with the constant 'kCIImageRepresentationSemanticSegmentationSkinMatteImage'.</summary>
		[Field ("kCIImageRepresentationSemanticSegmentationSkinMatteImage",  "CoreImage")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SemanticSegmentationSkinMatteImageKey {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SemanticSegmentationSkinMatteImageKey is null)
					_SemanticSegmentationSkinMatteImageKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageRepresentationSemanticSegmentationSkinMatteImage")!;
				return _SemanticSegmentationSkinMatteImageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SemanticSegmentationSkyMatteImageKey;
		/// <summary>Represents the value associated with the constant 'kCIImageRepresentationSemanticSegmentationSkyMatteImage'.</summary>
		[Field ("kCIImageRepresentationSemanticSegmentationSkyMatteImage",  "CoreImage")]
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("tvos14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SemanticSegmentationSkyMatteImageKey {
			[SupportedOSPlatform ("ios14.3")]
			[SupportedOSPlatform ("tvos14.3")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SemanticSegmentationSkyMatteImageKey is null)
					_SemanticSegmentationSkyMatteImageKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageRepresentationSemanticSegmentationSkyMatteImage")!;
				return _SemanticSegmentationSkyMatteImageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SemanticSegmentationTeethMatteImageKey;
		/// <summary>Represents the value associated with the constant 'kCIImageRepresentationSemanticSegmentationTeethMatteImage'.</summary>
		[Field ("kCIImageRepresentationSemanticSegmentationTeethMatteImage",  "CoreImage")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SemanticSegmentationTeethMatteImageKey {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SemanticSegmentationTeethMatteImageKey is null)
					_SemanticSegmentationTeethMatteImageKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageRepresentationSemanticSegmentationTeethMatteImage")!;
				return _SemanticSegmentationTeethMatteImageKey;
			}
		}
	} /* class CIImageRepresentationKeys */
}
