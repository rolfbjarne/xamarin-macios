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
namespace CoreGraphics {
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	internal unsafe static partial class CGPdfTagPropertyKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ActualTextKey;
		/// <summary>Represents the value associated with the constant 'kCGPDFTagPropertyActualText'.</summary>
		[Field ("kCGPDFTagPropertyActualText",  "CoreGraphics")]
		public static NSString ActualTextKey {
			get {
				if (_ActualTextKey is null)
					_ActualTextKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGPDFTagPropertyActualText")!;
				return _ActualTextKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlternativeTextKey;
		/// <summary>Represents the value associated with the constant 'kCGPDFTagPropertyAlternativeText'.</summary>
		[Field ("kCGPDFTagPropertyAlternativeText",  "CoreGraphics")]
		public static NSString AlternativeTextKey {
			get {
				if (_AlternativeTextKey is null)
					_AlternativeTextKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGPDFTagPropertyAlternativeText")!;
				return _AlternativeTextKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LanguageTextKey;
		/// <summary>Represents the value associated with the constant 'kCGPDFTagPropertyLanguageText'.</summary>
		[Field ("kCGPDFTagPropertyLanguageText",  "CoreGraphics")]
		public static NSString LanguageTextKey {
			get {
				if (_LanguageTextKey is null)
					_LanguageTextKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGPDFTagPropertyLanguageText")!;
				return _LanguageTextKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TitleTextKey;
		/// <summary>Represents the value associated with the constant 'kCGPDFTagPropertyTitleText'.</summary>
		[Field ("kCGPDFTagPropertyTitleText",  "CoreGraphics")]
		public static NSString TitleTextKey {
			get {
				if (_TitleTextKey is null)
					_TitleTextKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGPDFTagPropertyTitleText")!;
				return _TitleTextKey;
			}
		}
	} /* class CGPdfTagPropertyKeys */
}
