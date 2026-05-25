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
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class CGDisplayStreamYCbCrMatrixOptionKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Itu_R_601_4;
		/// <summary>Represents the value associated with the constant 'kCGDisplayStreamYCbCrMatrix_ITU_R_601_4'.</summary>
		[Field ("kCGDisplayStreamYCbCrMatrix_ITU_R_601_4",  "CoreGraphics")]
		public static NSString Itu_R_601_4 {
			get {
				if (_Itu_R_601_4 is null)
					_Itu_R_601_4 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGDisplayStreamYCbCrMatrix_ITU_R_601_4")!;
				return _Itu_R_601_4;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Itu_R_709_2;
		/// <summary>Represents the value associated with the constant 'kCGDisplayStreamYCbCrMatrix_ITU_R_709_2'.</summary>
		[Field ("kCGDisplayStreamYCbCrMatrix_ITU_R_709_2",  "CoreGraphics")]
		public static NSString Itu_R_709_2 {
			get {
				if (_Itu_R_709_2 is null)
					_Itu_R_709_2 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGDisplayStreamYCbCrMatrix_ITU_R_709_2")!;
				return _Itu_R_709_2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Smpte_240M_1995;
		/// <summary>Represents the value associated with the constant 'kCGDisplayStreamYCbCrMatrix_SMPTE_240M_1995'.</summary>
		[Field ("kCGDisplayStreamYCbCrMatrix_SMPTE_240M_1995",  "CoreGraphics")]
		public static NSString Smpte_240M_1995 {
			get {
				if (_Smpte_240M_1995 is null)
					_Smpte_240M_1995 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGDisplayStreamYCbCrMatrix_SMPTE_240M_1995")!;
				return _Smpte_240M_1995;
			}
		}
	} /* class CGDisplayStreamYCbCrMatrixOptionKeys */
}
