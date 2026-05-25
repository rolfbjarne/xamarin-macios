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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
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
	internal unsafe static partial class CIImageInitializationOptionsKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplyCleanApertureKey;
		/// <summary>Represents the value associated with the constant 'kCIImageApplyCleanAperture'.</summary>
		[Field ("kCIImageApplyCleanAperture",  "CoreImage")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public static NSString ApplyCleanApertureKey {
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				if (_ApplyCleanApertureKey is null)
					_ApplyCleanApertureKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageApplyCleanAperture")!;
				return _ApplyCleanApertureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplyOrientationPropertyKey;
		/// <summary>Represents the value associated with the constant 'kCIImageApplyOrientationProperty'.</summary>
		[Field ("kCIImageApplyOrientationProperty",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ApplyOrientationPropertyKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ApplyOrientationPropertyKey is null)
					_ApplyOrientationPropertyKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageApplyOrientationProperty")!;
				return _ApplyOrientationPropertyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuxiliaryDepthKey;
		/// <summary>Represents the value associated with the constant 'kCIImageAuxiliaryDepth'.</summary>
		[Field ("kCIImageAuxiliaryDepth",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AuxiliaryDepthKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AuxiliaryDepthKey is null)
					_AuxiliaryDepthKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageAuxiliaryDepth")!;
				return _AuxiliaryDepthKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuxiliaryDisparityKey;
		/// <summary>Represents the value associated with the constant 'kCIImageAuxiliaryDisparity'.</summary>
		[Field ("kCIImageAuxiliaryDisparity",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AuxiliaryDisparityKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AuxiliaryDisparityKey is null)
					_AuxiliaryDisparityKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageAuxiliaryDisparity")!;
				return _AuxiliaryDisparityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuxiliaryHdrGainMapKey;
		/// <summary>Represents the value associated with the constant 'kCIImageAuxiliaryHDRGainMap'.</summary>
		[Field ("kCIImageAuxiliaryHDRGainMap",  "CoreImage")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.1")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuxiliaryHdrGainMapKey {
			[SupportedOSPlatform ("ios14.1")]
			[SupportedOSPlatform ("tvos14.1")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuxiliaryHdrGainMapKey is null)
					_AuxiliaryHdrGainMapKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageAuxiliaryHDRGainMap")!;
				return _AuxiliaryHdrGainMapKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuxiliaryPortraitEffectsMatteKey;
		/// <summary>Represents the value associated with the constant 'kCIImageAuxiliaryPortraitEffectsMatte'.</summary>
		[Field ("kCIImageAuxiliaryPortraitEffectsMatte",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AuxiliaryPortraitEffectsMatteKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AuxiliaryPortraitEffectsMatteKey is null)
					_AuxiliaryPortraitEffectsMatteKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageAuxiliaryPortraitEffectsMatte")!;
				return _AuxiliaryPortraitEffectsMatteKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuxiliarySemanticSegmentationGlassesMatteKey;
		/// <summary>Represents the value associated with the constant 'kCIImageAuxiliarySemanticSegmentationGlassesMatte'.</summary>
		[Field ("kCIImageAuxiliarySemanticSegmentationGlassesMatte",  "CoreImage")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuxiliarySemanticSegmentationGlassesMatteKey {
			[SupportedOSPlatform ("ios14.1")]
			[SupportedOSPlatform ("tvos14.2")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuxiliarySemanticSegmentationGlassesMatteKey is null)
					_AuxiliarySemanticSegmentationGlassesMatteKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageAuxiliarySemanticSegmentationGlassesMatte")!;
				return _AuxiliarySemanticSegmentationGlassesMatteKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuxiliarySemanticSegmentationHairMatteKey;
		/// <summary>Represents the value associated with the constant 'kCIImageAuxiliarySemanticSegmentationHairMatte'.</summary>
		[Field ("kCIImageAuxiliarySemanticSegmentationHairMatte",  "CoreImage")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuxiliarySemanticSegmentationHairMatteKey {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuxiliarySemanticSegmentationHairMatteKey is null)
					_AuxiliarySemanticSegmentationHairMatteKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageAuxiliarySemanticSegmentationHairMatte")!;
				return _AuxiliarySemanticSegmentationHairMatteKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuxiliarySemanticSegmentationSkinMatteKey;
		/// <summary>Represents the value associated with the constant 'kCIImageAuxiliarySemanticSegmentationSkinMatte'.</summary>
		[Field ("kCIImageAuxiliarySemanticSegmentationSkinMatte",  "CoreImage")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuxiliarySemanticSegmentationSkinMatteKey {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuxiliarySemanticSegmentationSkinMatteKey is null)
					_AuxiliarySemanticSegmentationSkinMatteKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageAuxiliarySemanticSegmentationSkinMatte")!;
				return _AuxiliarySemanticSegmentationSkinMatteKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuxiliarySemanticSegmentationSkyMatteKey;
		/// <summary>Represents the value associated with the constant 'kCIImageAuxiliarySemanticSegmentationSkyMatte'.</summary>
		[Field ("kCIImageAuxiliarySemanticSegmentationSkyMatte",  "CoreImage")]
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("tvos14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuxiliarySemanticSegmentationSkyMatteKey {
			[SupportedOSPlatform ("ios14.3")]
			[SupportedOSPlatform ("tvos14.3")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuxiliarySemanticSegmentationSkyMatteKey is null)
					_AuxiliarySemanticSegmentationSkyMatteKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageAuxiliarySemanticSegmentationSkyMatte")!;
				return _AuxiliarySemanticSegmentationSkyMatteKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuxiliarySemanticSegmentationTeethMatteKey;
		/// <summary>Represents the value associated with the constant 'kCIImageAuxiliarySemanticSegmentationTeethMatte'.</summary>
		[Field ("kCIImageAuxiliarySemanticSegmentationTeethMatte",  "CoreImage")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AuxiliarySemanticSegmentationTeethMatteKey {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AuxiliarySemanticSegmentationTeethMatteKey is null)
					_AuxiliarySemanticSegmentationTeethMatteKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageAuxiliarySemanticSegmentationTeethMatte")!;
				return _AuxiliarySemanticSegmentationTeethMatteKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CacheImmediatelyKey;
		/// <summary>Represents the value associated with the constant 'kCIImageCacheImmediately'.</summary>
		[Field ("kCIImageCacheImmediately",  "CoreImage")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString CacheImmediatelyKey {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_CacheImmediatelyKey is null)
					_CacheImmediatelyKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageCacheImmediately")!;
				return _CacheImmediatelyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorSpaceKey;
		/// <summary>Represents the value associated with the constant 'kCIImageColorSpace'.</summary>
		[Field ("kCIImageColorSpace",  "CoreImage")]
		public static NSString ColorSpaceKey {
			get {
				if (_ColorSpaceKey is null)
					_ColorSpaceKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageColorSpace")!;
				return _ColorSpaceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentAverageLightLevelKey;
		/// <summary>Represents the value associated with the constant 'kCIImageContentAverageLightLevel'.</summary>
		[Field ("kCIImageContentAverageLightLevel",  "CoreImage")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public static NSString ContentAverageLightLevelKey {
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				if (_ContentAverageLightLevelKey is null)
					_ContentAverageLightLevelKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageContentAverageLightLevel")!;
				return _ContentAverageLightLevelKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentHeadroomKey;
		/// <summary>Represents the value associated with the constant 'kCIImageContentHeadroom'.</summary>
		[Field ("kCIImageContentHeadroom",  "CoreImage")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString ContentHeadroomKey {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_ContentHeadroomKey is null)
					_ContentHeadroomKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageContentHeadroom")!;
				return _ContentHeadroomKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExpandToHdrKey;
		/// <summary>Represents the value associated with the constant 'kCIImageExpandToHDR'.</summary>
		[Field ("kCIImageExpandToHDR",  "CoreImage")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString ExpandToHdrKey {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_ExpandToHdrKey is null)
					_ExpandToHdrKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageExpandToHDR")!;
				return _ExpandToHdrKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NearestSamplingKey;
		/// <summary>Represents the value associated with the constant 'kCIImageNearestSampling'.</summary>
		[Field ("kCIImageNearestSampling",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NearestSamplingKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NearestSamplingKey is null)
					_NearestSamplingKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageNearestSampling")!;
				return _NearestSamplingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PropertiesKey;
		/// <summary>Represents the value associated with the constant 'kCIImageProperties'.</summary>
		[Field ("kCIImageProperties",  "CoreImage")]
		public static NSString PropertiesKey {
			get {
				if (_PropertiesKey is null)
					_PropertiesKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageProperties")!;
				return _PropertiesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ToneMapHdrToSdrKey;
		/// <summary>Represents the value associated with the constant 'kCIImageToneMapHDRtoSDR'.</summary>
		[Field ("kCIImageToneMapHDRtoSDR",  "CoreImage")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ToneMapHdrToSdrKey {
			[SupportedOSPlatform ("ios14.1")]
			[SupportedOSPlatform ("tvos14.2")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ToneMapHdrToSdrKey is null)
					_ToneMapHdrToSdrKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIImageToneMapHDRtoSDR")!;
				return _ToneMapHdrToSdrKey;
			}
		}
	} /* class CIImageInitializationOptionsKeys */
}
