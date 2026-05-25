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
	/// <summary>Holds constants specifying standard metadata namespaces. Primarily used with <see cref="ImageIO.CGImageMetadataTag.Namespace" />.</summary>
	public unsafe static partial class CGImageMetadataTagNamespaces  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DublinCore;
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceDublinCore</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataNamespaceDublinCore",  "ImageIO")]
		public static NSString DublinCore {
			get {
				if (_DublinCore is null)
					_DublinCore = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceDublinCore")!;
				return _DublinCore;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Exif;
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceExif</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataNamespaceExif",  "ImageIO")]
		public static NSString Exif {
			get {
				if (_Exif is null)
					_Exif = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceExif")!;
				return _Exif;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifAux;
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceExifAux</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataNamespaceExifAux",  "ImageIO")]
		public static NSString ExifAux {
			get {
				if (_ExifAux is null)
					_ExifAux = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceExifAux")!;
				return _ExifAux;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifEx;
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceExifEX</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataNamespaceExifEX",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExifEx {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExifEx is null)
					_ExifEx = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceExifEX")!;
				return _ExifEx;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCCore;
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceIPTCCore</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataNamespaceIPTCCore",  "ImageIO")]
		public static NSString IPTCCore {
			get {
				if (_IPTCCore is null)
					_IPTCCore = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceIPTCCore")!;
				return _IPTCCore;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtension;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataNamespaceIPTCExtension",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtension {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtension is null)
					_IPTCExtension = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceIPTCExtension")!;
				return _IPTCExtension;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Photoshop;
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespacePhotoshop</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataNamespacePhotoshop",  "ImageIO")]
		public static NSString Photoshop {
			get {
				if (_Photoshop is null)
					_Photoshop = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataNamespacePhotoshop")!;
				return _Photoshop;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFF;
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceTIFF</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataNamespaceTIFF",  "ImageIO")]
		public static NSString TIFF {
			get {
				if (_TIFF is null)
					_TIFF = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceTIFF")!;
				return _TIFF;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _XMPBasic;
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceXMPBasic</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataNamespaceXMPBasic",  "ImageIO")]
		public static NSString XMPBasic {
			get {
				if (_XMPBasic is null)
					_XMPBasic = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceXMPBasic")!;
				return _XMPBasic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _XMPRights;
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceXMPRights</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataNamespaceXMPRights",  "ImageIO")]
		public static NSString XMPRights {
			get {
				if (_XMPRights is null)
					_XMPRights = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceXMPRights")!;
				return _XMPRights;
			}
		}
	} /* class CGImageMetadataTagNamespaces */
}
