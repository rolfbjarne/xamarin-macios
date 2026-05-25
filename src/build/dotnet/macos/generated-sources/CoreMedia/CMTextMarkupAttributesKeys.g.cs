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
namespace CoreMedia {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class CMTextMarkupAttributesKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BackgroundColorARGB;
		/// <summary>Represents the value associated with the constant 'kCMTextMarkupAttribute_BackgroundColorARGB'.</summary>
		[Field ("kCMTextMarkupAttribute_BackgroundColorARGB",  "CoreMedia")]
		internal static NSString BackgroundColorARGB {
			get {
				if (_BackgroundColorARGB is null)
					_BackgroundColorARGB = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_BackgroundColorARGB")!;
				return _BackgroundColorARGB;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BaseFontSizePercentageRelativeToVideoHeight;
		/// <summary>Represents the value associated with the constant 'kCMTextMarkupAttribute_BaseFontSizePercentageRelativeToVideoHeight'.</summary>
		[Field ("kCMTextMarkupAttribute_BaseFontSizePercentageRelativeToVideoHeight",  "CoreMedia")]
		internal static NSString BaseFontSizePercentageRelativeToVideoHeight {
			get {
				if (_BaseFontSizePercentageRelativeToVideoHeight is null)
					_BaseFontSizePercentageRelativeToVideoHeight = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_BaseFontSizePercentageRelativeToVideoHeight")!;
				return _BaseFontSizePercentageRelativeToVideoHeight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BoldStyle;
		/// <summary>Represents the value associated with the constant 'kCMTextMarkupAttribute_BoldStyle'.</summary>
		[Field ("kCMTextMarkupAttribute_BoldStyle",  "CoreMedia")]
		internal static NSString BoldStyle {
			get {
				if (_BoldStyle is null)
					_BoldStyle = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_BoldStyle")!;
				return _BoldStyle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontFamilyName;
		/// <summary>Represents the value associated with the constant 'kCMTextMarkupAttribute_FontFamilyName'.</summary>
		[Field ("kCMTextMarkupAttribute_FontFamilyName",  "CoreMedia")]
		internal static NSString FontFamilyName {
			get {
				if (_FontFamilyName is null)
					_FontFamilyName = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_FontFamilyName")!;
				return _FontFamilyName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ForegroundColorARGB;
		/// <summary>Represents the value associated with the constant 'kCMTextMarkupAttribute_ForegroundColorARGB'.</summary>
		[Field ("kCMTextMarkupAttribute_ForegroundColorARGB",  "CoreMedia")]
		internal static NSString ForegroundColorARGB {
			get {
				if (_ForegroundColorARGB is null)
					_ForegroundColorARGB = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_ForegroundColorARGB")!;
				return _ForegroundColorARGB;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItalicStyle;
		/// <summary>Represents the value associated with the constant 'kCMTextMarkupAttribute_ItalicStyle'.</summary>
		[Field ("kCMTextMarkupAttribute_ItalicStyle",  "CoreMedia")]
		internal static NSString ItalicStyle {
			get {
				if (_ItalicStyle is null)
					_ItalicStyle = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_ItalicStyle")!;
				return _ItalicStyle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RelativeFontSize;
		/// <summary>Represents the value associated with the constant 'kCMTextMarkupAttribute_RelativeFontSize'.</summary>
		[Field ("kCMTextMarkupAttribute_RelativeFontSize",  "CoreMedia")]
		internal static NSString RelativeFontSize {
			get {
				if (_RelativeFontSize is null)
					_RelativeFontSize = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_RelativeFontSize")!;
				return _RelativeFontSize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnderlineStyle;
		/// <summary>Represents the value associated with the constant 'kCMTextMarkupAttribute_UnderlineStyle'.</summary>
		[Field ("kCMTextMarkupAttribute_UnderlineStyle",  "CoreMedia")]
		internal static NSString UnderlineStyle {
			get {
				if (_UnderlineStyle is null)
					_UnderlineStyle = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMTextMarkupAttribute_UnderlineStyle")!;
				return _UnderlineStyle;
			}
		}
	} /* class CMTextMarkupAttributesKeys */
}
