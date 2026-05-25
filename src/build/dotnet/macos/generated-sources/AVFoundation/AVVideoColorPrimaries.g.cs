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
namespace AVFoundation {
	/// <summary>Contains constants that identify video color primaries.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVVideoColorPrimaries  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Ebu_3213;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVVideoColorPrimaries_EBU_3213",  "AVFoundation")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Ebu_3213 {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Ebu_3213 is null)
					_Ebu_3213 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoColorPrimaries_EBU_3213")!;
				return _Ebu_3213;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Itu_R_2020;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVVideoColorPrimaries_ITU_R_2020",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Itu_R_2020 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Itu_R_2020 is null)
					_Itu_R_2020 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoColorPrimaries_ITU_R_2020")!;
				return _Itu_R_2020;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Itu_R_709_2;
		/// <summary>Represents the constant AVVideoColorPrimaries_ITU_R_709_2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVVideoColorPrimaries_ITU_R_709_2",  "AVFoundation")]
		public static NSString Itu_R_709_2 {
			get {
				if (_Itu_R_709_2 is null)
					_Itu_R_709_2 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoColorPrimaries_ITU_R_709_2")!;
				return _Itu_R_709_2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _P3_D65;
		/// <summary>Represents the constant AVVideoColorPrimaries_P3_D65.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVVideoColorPrimaries_P3_D65",  "AVFoundation")]
		public static NSString P3_D65 {
			get {
				if (_P3_D65 is null)
					_P3_D65 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoColorPrimaries_P3_D65")!;
				return _P3_D65;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Smpte_C;
		/// <summary>Represents the constant AVVideoColorPrimaries_SMPTE_C.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVVideoColorPrimaries_SMPTE_C",  "AVFoundation")]
		public static NSString Smpte_C {
			get {
				if (_Smpte_C is null)
					_Smpte_C = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoColorPrimaries_SMPTE_C")!;
				return _Smpte_C;
			}
		}
	} /* class AVVideoColorPrimaries */
}
