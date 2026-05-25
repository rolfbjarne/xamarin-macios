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
	public unsafe static partial class NSImageHint  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Ctm;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageHintCTM",  "AppKit")]
		public static NSString Ctm {
			get {
				if (_Ctm is null)
					_Ctm = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageHintCTM")!;
				return _Ctm;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Interpolation;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageHintInterpolation",  "AppKit")]
		public static NSString Interpolation {
			get {
				if (_Interpolation is null)
					_Interpolation = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageHintInterpolation")!;
				return _Interpolation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UserInterfaceLayoutDirection;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSImageHintUserInterfaceLayoutDirection",  "AppKit")]
		public static NSString UserInterfaceLayoutDirection {
			get {
				if (_UserInterfaceLayoutDirection is null)
					_UserInterfaceLayoutDirection = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageHintUserInterfaceLayoutDirection")!;
				return _UserInterfaceLayoutDirection;
			}
		}
	} /* class NSImageHint */
}
