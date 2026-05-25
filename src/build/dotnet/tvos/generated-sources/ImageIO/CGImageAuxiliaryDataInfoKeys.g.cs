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
	internal unsafe static partial class CGImageAuxiliaryDataInfoKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorSpaceKey;
		/// <summary>Represents the value associated with the constant 'kCGImageAuxiliaryDataInfoColorSpace'.</summary>
		[Field ("kCGImageAuxiliaryDataInfoColorSpace",  "ImageIO")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString ColorSpaceKey {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_ColorSpaceKey is null)
					_ColorSpaceKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataInfoColorSpace")!;
				return _ColorSpaceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DataDescriptionKey;
		/// <summary>Represents the value associated with the constant 'kCGImageAuxiliaryDataInfoDataDescription'.</summary>
		[Field ("kCGImageAuxiliaryDataInfoDataDescription",  "ImageIO")]
		public static NSString DataDescriptionKey {
			get {
				if (_DataDescriptionKey is null)
					_DataDescriptionKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataInfoDataDescription")!;
				return _DataDescriptionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DataKey;
		/// <summary>Represents the value associated with the constant 'kCGImageAuxiliaryDataInfoData'.</summary>
		[Field ("kCGImageAuxiliaryDataInfoData",  "ImageIO")]
		public static NSString DataKey {
			get {
				if (_DataKey is null)
					_DataKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataInfoData")!;
				return _DataKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MetadataKey;
		/// <summary>Represents the value associated with the constant 'kCGImageAuxiliaryDataInfoMetadata'.</summary>
		[Field ("kCGImageAuxiliaryDataInfoMetadata",  "ImageIO")]
		public static NSString MetadataKey {
			get {
				if (_MetadataKey is null)
					_MetadataKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataInfoMetadata")!;
				return _MetadataKey;
			}
		}
	} /* class CGImageAuxiliaryDataInfoKeys */
}
