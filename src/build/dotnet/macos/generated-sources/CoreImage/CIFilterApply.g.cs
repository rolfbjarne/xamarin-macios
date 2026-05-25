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
namespace CoreImage {
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class CIFilterApply  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OptionColorSpace;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIApplyOptionColorSpace",  "Quartz")]
		public static NSString OptionColorSpace {
			get {
				if (_OptionColorSpace is null)
					_OptionColorSpace = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCIApplyOptionColorSpace")!;
				return _OptionColorSpace;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OptionDefinition;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIApplyOptionDefinition",  "Quartz")]
		public static NSString OptionDefinition {
			get {
				if (_OptionDefinition is null)
					_OptionDefinition = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCIApplyOptionDefinition")!;
				return _OptionDefinition;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OptionExtent;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIApplyOptionExtent",  "Quartz")]
		public static NSString OptionExtent {
			get {
				if (_OptionExtent is null)
					_OptionExtent = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCIApplyOptionExtent")!;
				return _OptionExtent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OptionUserInfo;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIApplyOptionUserInfo",  "Quartz")]
		public static NSString OptionUserInfo {
			get {
				if (_OptionUserInfo is null)
					_OptionUserInfo = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCIApplyOptionUserInfo")!;
				return _OptionUserInfo;
			}
		}
	} /* class CIFilterApply */
}
