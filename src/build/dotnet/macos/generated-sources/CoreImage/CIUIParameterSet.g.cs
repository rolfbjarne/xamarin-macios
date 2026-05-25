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
	/// <summary>Contains options for core image filter user interfaces.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class CIUIParameterSet  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Advanced;
		/// <summary>Advanced user interface set.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIUISetAdvanced",  "Quartz")]
		public static NSString Advanced {
			get {
				if (_Advanced is null)
					_Advanced = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCIUISetAdvanced")!;
				return _Advanced;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Basic;
		/// <summary>Basic  user interface set.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIUISetBasic",  "Quartz")]
		public static NSString Basic {
			get {
				if (_Basic is null)
					_Basic = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCIUISetBasic")!;
				return _Basic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Development;
		/// <summary>Development user interface set.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIUISetDevelopment",  "Quartz")]
		public static NSString Development {
			get {
				if (_Development is null)
					_Development = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCIUISetDevelopment")!;
				return _Development;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Intermediate;
		/// <summary>Intermediate user interface set.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIUISetIntermediate",  "Quartz")]
		public static NSString Intermediate {
			get {
				if (_Intermediate is null)
					_Intermediate = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCIUISetIntermediate")!;
				return _Intermediate;
			}
		}
	} /* class CIUIParameterSet */
}
