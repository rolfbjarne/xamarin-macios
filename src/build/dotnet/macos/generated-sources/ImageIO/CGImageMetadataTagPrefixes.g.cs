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
namespace ImageIO {
	/// <summary>Constants defining standard prefixes. Primarily used with <see cref="ImageIO.CGImageMetadataTag.Prefix" />.</summary>
	public unsafe static partial class CGImageMetadataTagPrefixes  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DublinCore;
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixDublinCore</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataPrefixDublinCore",  "ImageIO")]
		public static NSString DublinCore {
			get {
				if (_DublinCore is null)
					_DublinCore = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataPrefixDublinCore")!;
				return _DublinCore;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Exif;
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixExif</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataPrefixExif",  "ImageIO")]
		public static NSString Exif {
			get {
				if (_Exif is null)
					_Exif = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataPrefixExif")!;
				return _Exif;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifAux;
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixExifAux</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataPrefixExifAux",  "ImageIO")]
		public static NSString ExifAux {
			get {
				if (_ExifAux is null)
					_ExifAux = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataPrefixExifAux")!;
				return _ExifAux;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifEx;
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixExifEX</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataPrefixExifEX",  "ImageIO")]
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
					_ExifEx = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataPrefixExifEX")!;
				return _ExifEx;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCCore;
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixIPTCCore</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataPrefixIPTCCore",  "ImageIO")]
		public static NSString IPTCCore {
			get {
				if (_IPTCCore is null)
					_IPTCCore = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataPrefixIPTCCore")!;
				return _IPTCCore;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtension;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataPrefixIPTCExtension",  "ImageIO")]
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
					_IPTCExtension = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataPrefixIPTCExtension")!;
				return _IPTCExtension;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Photoshop;
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixPhotoshop</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataPrefixPhotoshop",  "ImageIO")]
		public static NSString Photoshop {
			get {
				if (_Photoshop is null)
					_Photoshop = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataPrefixPhotoshop")!;
				return _Photoshop;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFF;
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixTIFF</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataPrefixTIFF",  "ImageIO")]
		public static NSString TIFF {
			get {
				if (_TIFF is null)
					_TIFF = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataPrefixTIFF")!;
				return _TIFF;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _XMPBasic;
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixXMPBasic</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataPrefixXMPBasic",  "ImageIO")]
		public static NSString XMPBasic {
			get {
				if (_XMPBasic is null)
					_XMPBasic = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataPrefixXMPBasic")!;
				return _XMPBasic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _XMPRights;
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixXMPRights</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCGImageMetadataPrefixXMPRights",  "ImageIO")]
		public static NSString XMPRights {
			get {
				if (_XMPRights is null)
					_XMPRights = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageMetadataPrefixXMPRights")!;
				return _XMPRights;
			}
		}
	} /* class CGImageMetadataTagPrefixes */
}
