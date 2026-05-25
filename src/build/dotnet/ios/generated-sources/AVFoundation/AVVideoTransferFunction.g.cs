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
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVVideoTransferFunction  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVVideoTransferFunction_Itu_R_709_2;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use 'Itu_R_709_2' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVVideoTransferFunction_ITU_R_709_2",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AVVideoTransferFunction_Itu_R_709_2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AVVideoTransferFunction_Itu_R_709_2 is null)
					_AVVideoTransferFunction_Itu_R_709_2 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoTransferFunction_ITU_R_709_2")!;
				return _AVVideoTransferFunction_Itu_R_709_2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Iec_sRgb;
		/// <summary>Represents the value associated with the constant 'AVVideoTransferFunction_IEC_sRGB'.</summary>
		[Field ("AVVideoTransferFunction_IEC_sRGB",  "AVFoundation")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		public static NSString Iec_sRgb {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			get {
				if (_Iec_sRgb is null)
					_Iec_sRgb = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoTransferFunction_IEC_sRGB")!;
				return _Iec_sRgb;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Itu_R_2100_Hlg;
		/// <summary>Represents the value associated with the constant 'AVVideoTransferFunction_ITU_R_2100_HLG'.</summary>
		[Field ("AVVideoTransferFunction_ITU_R_2100_HLG",  "AVFoundation")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		public static NSString Itu_R_2100_Hlg {
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_Itu_R_2100_Hlg is null)
					_Itu_R_2100_Hlg = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoTransferFunction_ITU_R_2100_HLG")!;
				return _Itu_R_2100_Hlg;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Itu_R_709_2;
		/// <summary>Represents the value associated with the constant 'AVVideoTransferFunction_ITU_R_709_2'.</summary>
		[Field ("AVVideoTransferFunction_ITU_R_709_2",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Itu_R_709_2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Itu_R_709_2 is null)
					_Itu_R_709_2 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoTransferFunction_ITU_R_709_2")!;
				return _Itu_R_709_2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Linear;
		/// <summary>Represents the value associated with the constant 'AVVideoTransferFunction_Linear'.</summary>
		[Field ("AVVideoTransferFunction_Linear",  "AVFoundation")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public static NSString Linear {
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			get {
				if (_Linear is null)
					_Linear = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoTransferFunction_Linear")!;
				return _Linear;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Smpte_St_2084_Pq;
		/// <summary>Represents the value associated with the constant 'AVVideoTransferFunction_SMPTE_ST_2084_PQ'.</summary>
		[Field ("AVVideoTransferFunction_SMPTE_ST_2084_PQ",  "AVFoundation")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		public static NSString Smpte_St_2084_Pq {
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_Smpte_St_2084_Pq is null)
					_Smpte_St_2084_Pq = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoTransferFunction_SMPTE_ST_2084_PQ")!;
				return _Smpte_St_2084_Pq;
			}
		}
	} /* class AVVideoTransferFunction */
}
