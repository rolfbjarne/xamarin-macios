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
namespace AVFoundation {
	/// <summary>A class whose static members define how scaling should behave for different sizes and aspect ratios</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVVideoScalingModeKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Fit;
		/// <summary>Represents the value associated with the constant AVVideoScalingModeFit</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoScalingModeFit",  "AVFoundation")]
		public static NSString Fit {
			get {
				if (_Fit is null)
					_Fit = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoScalingModeFit")!;
				return _Fit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Resize;
		/// <summary>Represents the value associated with the constant AVVideoScalingModeResize</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoScalingModeResize",  "AVFoundation")]
		public static NSString Resize {
			get {
				if (_Resize is null)
					_Resize = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoScalingModeResize")!;
				return _Resize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResizeAspect;
		/// <summary>Represents the value associated with the constant AVVideoScalingModeResizeAspect</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoScalingModeResizeAspect",  "AVFoundation")]
		public static NSString ResizeAspect {
			get {
				if (_ResizeAspect is null)
					_ResizeAspect = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoScalingModeResizeAspect")!;
				return _ResizeAspect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResizeAspectFill;
		/// <summary>Represents the value associated with the constant AVVideoScalingModeResizeAspectFill</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoScalingModeResizeAspectFill",  "AVFoundation")]
		public static NSString ResizeAspectFill {
			get {
				if (_ResizeAspectFill is null)
					_ResizeAspectFill = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoScalingModeResizeAspectFill")!;
				return _ResizeAspectFill;
			}
		}
	} /* class AVVideoScalingModeKey */
}
