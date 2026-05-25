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
namespace CoreVideo {
	public unsafe partial class CVPixelFormatKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BitsPerBlock;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatBitsPerBlock'.</summary>
		[Field ("kCVPixelFormatBitsPerBlock",  "CoreVideo")]
		public static NSString BitsPerBlock {
			get {
				if (_BitsPerBlock is null)
					_BitsPerBlock = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatBitsPerBlock")!;
				return _BitsPerBlock;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BitsPerComponent;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatBitsPerComponent'.</summary>
		[Field ("kCVPixelFormatBitsPerComponent",  "CoreVideo")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		public static NSString BitsPerComponent {
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			get {
				if (_BitsPerComponent is null)
					_BitsPerComponent = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatBitsPerComponent")!;
				return _BitsPerComponent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BlackBlock;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatBlackBlock'.</summary>
		[Field ("kCVPixelFormatBlackBlock",  "CoreVideo")]
		public static NSString BlackBlock {
			get {
				if (_BlackBlock is null)
					_BlackBlock = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatBlackBlock")!;
				return _BlackBlock;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BlockHeight;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatBlockHeight'.</summary>
		[Field ("kCVPixelFormatBlockHeight",  "CoreVideo")]
		public static NSString BlockHeight {
			get {
				if (_BlockHeight is null)
					_BlockHeight = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatBlockHeight")!;
				return _BlockHeight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BlockHorizontalAlignment;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatBlockHorizontalAlignment'.</summary>
		[Field ("kCVPixelFormatBlockHorizontalAlignment",  "CoreVideo")]
		public static NSString BlockHorizontalAlignment {
			get {
				if (_BlockHorizontalAlignment is null)
					_BlockHorizontalAlignment = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatBlockHorizontalAlignment")!;
				return _BlockHorizontalAlignment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BlockVerticalAlignment;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatBlockVerticalAlignment'.</summary>
		[Field ("kCVPixelFormatBlockVerticalAlignment",  "CoreVideo")]
		public static NSString BlockVerticalAlignment {
			get {
				if (_BlockVerticalAlignment is null)
					_BlockVerticalAlignment = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatBlockVerticalAlignment")!;
				return _BlockVerticalAlignment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BlockWidth;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatBlockWidth'.</summary>
		[Field ("kCVPixelFormatBlockWidth",  "CoreVideo")]
		public static NSString BlockWidth {
			get {
				if (_BlockWidth is null)
					_BlockWidth = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatBlockWidth")!;
				return _BlockWidth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CGBitmapContextCompatibility;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatCGBitmapContextCompatibility'.</summary>
		[Field ("kCVPixelFormatCGBitmapContextCompatibility",  "CoreVideo")]
		public static NSString CGBitmapContextCompatibility {
			get {
				if (_CGBitmapContextCompatibility is null)
					_CGBitmapContextCompatibility = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatCGBitmapContextCompatibility")!;
				return _CGBitmapContextCompatibility;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CGBitmapInfo;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatCGBitmapInfo'.</summary>
		[Field ("kCVPixelFormatCGBitmapInfo",  "CoreVideo")]
		public static NSString CGBitmapInfo {
			get {
				if (_CGBitmapInfo is null)
					_CGBitmapInfo = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatCGBitmapInfo")!;
				return _CGBitmapInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CGImageCompatibility;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatCGImageCompatibility'.</summary>
		[Field ("kCVPixelFormatCGImageCompatibility",  "CoreVideo")]
		public static NSString CGImageCompatibility {
			get {
				if (_CGImageCompatibility is null)
					_CGImageCompatibility = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatCGImageCompatibility")!;
				return _CGImageCompatibility;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CodecType;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatCodecType'.</summary>
		[Field ("kCVPixelFormatCodecType",  "CoreVideo")]
		public static NSString CodecType {
			get {
				if (_CodecType is null)
					_CodecType = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatCodecType")!;
				return _CodecType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ComponentRange;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatComponentRange'.</summary>
		[Field ("kCVPixelFormatComponentRange",  "CoreVideo")]
		public static NSString ComponentRange {
			get {
				if (_ComponentRange is null)
					_ComponentRange = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatComponentRange")!;
				return _ComponentRange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Constant;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatConstant'.</summary>
		[Field ("kCVPixelFormatConstant",  "CoreVideo")]
		public static NSString Constant {
			get {
				if (_Constant is null)
					_Constant = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatConstant")!;
				return _Constant;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContainsAlpha;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatContainsAlpha'.</summary>
		[Field ("kCVPixelFormatContainsAlpha",  "CoreVideo")]
		public static NSString ContainsAlpha {
			get {
				if (_ContainsAlpha is null)
					_ContainsAlpha = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatContainsAlpha")!;
				return _ContainsAlpha;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContainsGrayscale;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatContainsGrayscale'.</summary>
		[Field ("kCVPixelFormatContainsGrayscale",  "CoreVideo")]
		public static NSString ContainsGrayscale {
			get {
				if (_ContainsGrayscale is null)
					_ContainsGrayscale = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatContainsGrayscale")!;
				return _ContainsGrayscale;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContainsRgb;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatContainsRGB'.</summary>
		[Field ("kCVPixelFormatContainsRGB",  "CoreVideo")]
		public static NSString ContainsRgb {
			get {
				if (_ContainsRgb is null)
					_ContainsRgb = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatContainsRGB")!;
				return _ContainsRgb;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContainsSenselArray;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatContainsSenselArray'.</summary>
		[Field ("kCVPixelFormatContainsSenselArray",  "CoreVideo")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public static NSString ContainsSenselArray {
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("tvos16.0")]
			get {
				if (_ContainsSenselArray is null)
					_ContainsSenselArray = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatContainsSenselArray")!;
				return _ContainsSenselArray;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContainsYCbCr;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatContainsYCbCr'.</summary>
		[Field ("kCVPixelFormatContainsYCbCr",  "CoreVideo")]
		public static NSString ContainsYCbCr {
			get {
				if (_ContainsYCbCr is null)
					_ContainsYCbCr = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatContainsYCbCr")!;
				return _ContainsYCbCr;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FillExtendedPixelsCallback;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatFillExtendedPixelsCallback'.</summary>
		[Field ("kCVPixelFormatFillExtendedPixelsCallback",  "CoreVideo")]
		public static NSString FillExtendedPixelsCallback {
			get {
				if (_FillExtendedPixelsCallback is null)
					_FillExtendedPixelsCallback = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatFillExtendedPixelsCallback")!;
				return _FillExtendedPixelsCallback;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FourCC;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatFourCC'.</summary>
		[Field ("kCVPixelFormatFourCC",  "CoreVideo")]
		public static NSString FourCC {
			get {
				if (_FourCC is null)
					_FourCC = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatFourCC")!;
				return _FourCC;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HorizontalSubsampling;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatHorizontalSubsampling'.</summary>
		[Field ("kCVPixelFormatHorizontalSubsampling",  "CoreVideo")]
		public static NSString HorizontalSubsampling {
			get {
				if (_HorizontalSubsampling is null)
					_HorizontalSubsampling = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatHorizontalSubsampling")!;
				return _HorizontalSubsampling;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Name;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatName'.</summary>
		[Field ("kCVPixelFormatName",  "CoreVideo")]
		public static NSString Name {
			get {
				if (_Name is null)
					_Name = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatName")!;
				return _Name;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OpenGLCompatibility;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatOpenGLCompatibility'.</summary>
		[Field ("kCVPixelFormatOpenGLCompatibility",  "CoreVideo")]
		public static NSString OpenGLCompatibility {
			get {
				if (_OpenGLCompatibility is null)
					_OpenGLCompatibility = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatOpenGLCompatibility")!;
				return _OpenGLCompatibility;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OpenGLFormat;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatOpenGLFormat'.</summary>
		[Field ("kCVPixelFormatOpenGLFormat",  "CoreVideo")]
		public static NSString OpenGLFormat {
			get {
				if (_OpenGLFormat is null)
					_OpenGLFormat = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatOpenGLFormat")!;
				return _OpenGLFormat;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OpenGLInternalFormat;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatOpenGLInternalFormat'.</summary>
		[Field ("kCVPixelFormatOpenGLInternalFormat",  "CoreVideo")]
		public static NSString OpenGLInternalFormat {
			get {
				if (_OpenGLInternalFormat is null)
					_OpenGLInternalFormat = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatOpenGLInternalFormat")!;
				return _OpenGLInternalFormat;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OpenGLType;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatOpenGLType'.</summary>
		[Field ("kCVPixelFormatOpenGLType",  "CoreVideo")]
		public static NSString OpenGLType {
			get {
				if (_OpenGLType is null)
					_OpenGLType = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatOpenGLType")!;
				return _OpenGLType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Planes;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatPlanes'.</summary>
		[Field ("kCVPixelFormatPlanes",  "CoreVideo")]
		public static NSString Planes {
			get {
				if (_Planes is null)
					_Planes = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatPlanes")!;
				return _Planes;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QDCompatibility;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatQDCompatibility'.</summary>
		[Field ("kCVPixelFormatQDCompatibility",  "CoreVideo")]
		public static NSString QDCompatibility {
			get {
				if (_QDCompatibility is null)
					_QDCompatibility = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatQDCompatibility")!;
				return _QDCompatibility;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VerticalSubsampling;
		/// <summary>Represents the value associated with the constant 'kCVPixelFormatVerticalSubsampling'.</summary>
		[Field ("kCVPixelFormatVerticalSubsampling",  "CoreVideo")]
		public static NSString VerticalSubsampling {
			get {
				if (_VerticalSubsampling is null)
					_VerticalSubsampling = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelFormatVerticalSubsampling")!;
				return _VerticalSubsampling;
			}
		}
	} /* class CVPixelFormatKeys */
}
