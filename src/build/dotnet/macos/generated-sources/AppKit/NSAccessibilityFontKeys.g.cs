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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSAccessibilityFontKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontFamilyKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityFontFamilyKey",  "AppKit")]
		public static NSString FontFamilyKey {
			get {
				if (_FontFamilyKey is null)
					_FontFamilyKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFontFamilyKey")!;
				return _FontFamilyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontNameKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityFontNameKey",  "AppKit")]
		public static NSString FontNameKey {
			get {
				if (_FontNameKey is null)
					_FontNameKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFontNameKey")!;
				return _FontNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontSizeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityFontSizeKey",  "AppKit")]
		public static NSString FontSizeKey {
			get {
				if (_FontSizeKey is null)
					_FontSizeKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFontSizeKey")!;
				return _FontSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VisibleNameKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSAccessibilityVisibleNameKey",  "AppKit")]
		public static NSString VisibleNameKey {
			get {
				if (_VisibleNameKey is null)
					_VisibleNameKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityVisibleNameKey")!;
				return _VisibleNameKey;
			}
		}
	} /* class NSAccessibilityFontKeys */
}
