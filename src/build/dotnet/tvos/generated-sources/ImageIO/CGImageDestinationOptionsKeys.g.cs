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
namespace ImageIO {
	/// <summary>Contains keys that index image destination options.</summary>
	public unsafe static partial class CGImageDestinationOptionsKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString AvisDictionary {
			get {
				return (CGImageProperties.AvisDictionary as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString CIFFDictionary {
			get {
				return (CGImageProperties.CIFFDictionary as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString DNGDictionary {
			get {
				return (CGImageProperties.DNGDictionary as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString EightBIMDictionary {
			get {
				return (CGImageProperties.EightBIMDictionary as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString ExifAuxDictionary {
			get {
				return (CGImageProperties.ExifAuxDictionary as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString ExifDictionary {
			get {
				return (CGImageProperties.ExifDictionary as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString GIFDictionary {
			get {
				return (CGImageProperties.GIFDictionary as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString GPSDictionary {
			get {
				return (CGImageProperties.GPSDictionary as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString IPTCDictionary {
			get {
				return (CGImageProperties.IPTCDictionary as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString JFIFDictionary {
			get {
				return (CGImageProperties.JFIFDictionary as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString PNGDictionary {
			get {
				return (CGImageProperties.PNGDictionary as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString RawDictionary {
			get {
				return (CGImageProperties.RawDictionary as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString TIFFDictionary {
			get {
				return (CGImageProperties.TIFFDictionary as NSString)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TgaDictionary {
			get {
				return (CGImageProperties.TgaDictionary as NSString)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString WebPDictionary {
			get {
				return (CGImageProperties.WebPDictionary as NSString)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BackgroundColor;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImageDestinationBackgroundColor",  "ImageIO")]
		public static NSString BackgroundColor {
			get {
				if (_BackgroundColor is null)
					_BackgroundColor = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationBackgroundColor")!;
				return _BackgroundColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EmbedThumbnail;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImageDestinationEmbedThumbnail",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString EmbedThumbnail {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EmbedThumbnail is null)
					_EmbedThumbnail = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationEmbedThumbnail")!;
				return _EmbedThumbnail;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodeAlternateColorSpace;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationEncodeAlternateColorSpace'.</summary>
		[Field ("kCGImageDestinationEncodeAlternateColorSpace",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString EncodeAlternateColorSpace {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_EncodeAlternateColorSpace is null)
					_EncodeAlternateColorSpace = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationEncodeAlternateColorSpace")!;
				return _EncodeAlternateColorSpace;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodeBaseColorSpace;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationEncodeBaseColorSpace'.</summary>
		[Field ("kCGImageDestinationEncodeBaseColorSpace",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString EncodeBaseColorSpace {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_EncodeBaseColorSpace is null)
					_EncodeBaseColorSpace = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationEncodeBaseColorSpace")!;
				return _EncodeBaseColorSpace;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodeBaseIsSdr;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationEncodeBaseIsSDR'.</summary>
		[Field ("kCGImageDestinationEncodeBaseIsSDR",  "ImageIO")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString EncodeBaseIsSdr {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_EncodeBaseIsSdr is null)
					_EncodeBaseIsSdr = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationEncodeBaseIsSDR")!;
				return _EncodeBaseIsSdr;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodeBasePixelFormatRequest;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationEncodeBasePixelFormatRequest'.</summary>
		[Field ("kCGImageDestinationEncodeBasePixelFormatRequest",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString EncodeBasePixelFormatRequest {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_EncodeBasePixelFormatRequest is null)
					_EncodeBasePixelFormatRequest = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationEncodeBasePixelFormatRequest")!;
				return _EncodeBasePixelFormatRequest;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodeGainMapPixelFormatRequest;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationEncodeGainMapPixelFormatRequest'.</summary>
		[Field ("kCGImageDestinationEncodeGainMapPixelFormatRequest",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString EncodeGainMapPixelFormatRequest {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_EncodeGainMapPixelFormatRequest is null)
					_EncodeGainMapPixelFormatRequest = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationEncodeGainMapPixelFormatRequest")!;
				return _EncodeGainMapPixelFormatRequest;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodeGainMapSubsampleFactor;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationEncodeGainMapSubsampleFactor'.</summary>
		[Field ("kCGImageDestinationEncodeGainMapSubsampleFactor",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString EncodeGainMapSubsampleFactor {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_EncodeGainMapSubsampleFactor is null)
					_EncodeGainMapSubsampleFactor = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationEncodeGainMapSubsampleFactor")!;
				return _EncodeGainMapSubsampleFactor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodeGenerateGainMapWithBaseImage;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationEncodeGenerateGainMapWithBaseImage'.</summary>
		[Field ("kCGImageDestinationEncodeGenerateGainMapWithBaseImage",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString EncodeGenerateGainMapWithBaseImage {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_EncodeGenerateGainMapWithBaseImage is null)
					_EncodeGenerateGainMapWithBaseImage = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationEncodeGenerateGainMapWithBaseImage")!;
				return _EncodeGenerateGainMapWithBaseImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodeIsBaseImage;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationEncodeIsBaseImage'.</summary>
		[Field ("kCGImageDestinationEncodeIsBaseImage",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString EncodeIsBaseImage {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_EncodeIsBaseImage is null)
					_EncodeIsBaseImage = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationEncodeIsBaseImage")!;
				return _EncodeIsBaseImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodeRequest;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationEncodeRequest'.</summary>
		[Field ("kCGImageDestinationEncodeRequest",  "ImageIO")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString EncodeRequest {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_EncodeRequest is null)
					_EncodeRequest = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationEncodeRequest")!;
				return _EncodeRequest;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodeRequestOptions;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationEncodeRequestOptions'.</summary>
		[Field ("kCGImageDestinationEncodeRequestOptions",  "ImageIO")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString EncodeRequestOptions {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_EncodeRequestOptions is null)
					_EncodeRequestOptions = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationEncodeRequestOptions")!;
				return _EncodeRequestOptions;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodeToIsoGainmap;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationEncodeToISOGainmap'.</summary>
		[Field ("kCGImageDestinationEncodeToISOGainmap",  "ImageIO")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString EncodeToIsoGainmap {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_EncodeToIsoGainmap is null)
					_EncodeToIsoGainmap = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationEncodeToISOGainmap")!;
				return _EncodeToIsoGainmap;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodeToIsoHdr;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationEncodeToISOHDR'.</summary>
		[Field ("kCGImageDestinationEncodeToISOHDR",  "ImageIO")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString EncodeToIsoHdr {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_EncodeToIsoHdr is null)
					_EncodeToIsoHdr = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationEncodeToISOHDR")!;
				return _EncodeToIsoHdr;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodeToSdr;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationEncodeToSDR'.</summary>
		[Field ("kCGImageDestinationEncodeToSDR",  "ImageIO")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString EncodeToSdr {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_EncodeToSdr is null)
					_EncodeToSdr = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationEncodeToSDR")!;
				return _EncodeToSdr;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodeTonemapMode;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationEncodeTonemapMode'.</summary>
		[Field ("kCGImageDestinationEncodeTonemapMode",  "ImageIO")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString EncodeTonemapMode {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_EncodeTonemapMode is null)
					_EncodeTonemapMode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationEncodeTonemapMode")!;
				return _EncodeTonemapMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ImageMaxPixelSize;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImageDestinationImageMaxPixelSize",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ImageMaxPixelSize {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ImageMaxPixelSize is null)
					_ImageMaxPixelSize = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationImageMaxPixelSize")!;
				return _ImageMaxPixelSize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LossyCompressionQuality;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImageDestinationLossyCompressionQuality",  "ImageIO")]
		public static NSString LossyCompressionQuality {
			get {
				if (_LossyCompressionQuality is null)
					_LossyCompressionQuality = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationLossyCompressionQuality")!;
				return _LossyCompressionQuality;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OptimizeColorForSharing;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImageDestinationOptimizeColorForSharing",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OptimizeColorForSharing {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OptimizeColorForSharing is null)
					_OptimizeColorForSharing = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationOptimizeColorForSharing")!;
				return _OptimizeColorForSharing;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreserveGainMapKey;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationPreserveGainMap'.</summary>
		[Field ("kCGImageDestinationPreserveGainMap",  "ImageIO")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PreserveGainMapKey {
			[SupportedOSPlatform ("ios14.1")]
			[SupportedOSPlatform ("tvos14.2")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PreserveGainMapKey is null)
					_PreserveGainMapKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationPreserveGainMap")!;
				return _PreserveGainMapKey;
			}
		}
	} /* class CGImageDestinationOptionsKeys */
}
