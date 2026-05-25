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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class CGCopyImageSourceOptionsKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AstcBlockSizeKey;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyASTCBlockSize'.</summary>
		[Field ("kCGImagePropertyASTCBlockSize",  "ImageIO")]
		public static NSString AstcBlockSizeKey {
			get {
				if (_AstcBlockSizeKey is null)
					_AstcBlockSizeKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyASTCBlockSize")!;
				return _AstcBlockSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BCFormatKey;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyBCFormat'.</summary>
		[Field ("kCGImagePropertyBCFormat",  "ImageIO")]
		public static NSString BCFormatKey {
			get {
				if (_BCFormatKey is null)
					_BCFormatKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyBCFormat")!;
				return _BCFormatKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DateTimeKey;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationDateTime'.</summary>
		[Field ("kCGImageDestinationDateTime",  "ImageIO")]
		public static NSString DateTimeKey {
			get {
				if (_DateTimeKey is null)
					_DateTimeKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationDateTime")!;
				return _DateTimeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncoderKey;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyEncoder'.</summary>
		[Field ("kCGImagePropertyEncoder",  "ImageIO")]
		public static NSString EncoderKey {
			get {
				if (_EncoderKey is null)
					_EncoderKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyEncoder")!;
				return _EncoderKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MergeMetadataKey;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationMergeMetadata'.</summary>
		[Field ("kCGImageDestinationMergeMetadata",  "ImageIO")]
		public static NSString MergeMetadataKey {
			get {
				if (_MergeMetadataKey is null)
					_MergeMetadataKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationMergeMetadata")!;
				return _MergeMetadataKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MetadataKey;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationMetadata'.</summary>
		[Field ("kCGImageDestinationMetadata",  "ImageIO")]
		public static NSString MetadataKey {
			get {
				if (_MetadataKey is null)
					_MetadataKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationMetadata")!;
				return _MetadataKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrientationKey;
		/// <summary>Represents the value associated with the constant 'kCGImageDestinationOrientation'.</summary>
		[Field ("kCGImageDestinationOrientation",  "ImageIO")]
		public static NSString OrientationKey {
			get {
				if (_OrientationKey is null)
					_OrientationKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageDestinationOrientation")!;
				return _OrientationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShouldExcludeGpsKey;
		/// <summary>Represents the value associated with the constant 'kCGImageMetadataShouldExcludeGPS'.</summary>
		[Field ("kCGImageMetadataShouldExcludeGPS",  "ImageIO")]
		public static NSString ShouldExcludeGpsKey {
			get {
				if (_ShouldExcludeGpsKey is null)
					_ShouldExcludeGpsKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataShouldExcludeGPS")!;
				return _ShouldExcludeGpsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShouldExcludeXmpKey;
		/// <summary>Represents the value associated with the constant 'kCGImageMetadataShouldExcludeXMP'.</summary>
		[Field ("kCGImageMetadataShouldExcludeXMP",  "ImageIO")]
		public static NSString ShouldExcludeXmpKey {
			get {
				if (_ShouldExcludeXmpKey is null)
					_ShouldExcludeXmpKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataShouldExcludeXMP")!;
				return _ShouldExcludeXmpKey;
			}
		}
	} /* class CGCopyImageSourceOptionsKeys */
}
