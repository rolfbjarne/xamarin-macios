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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace VideoToolbox {
	/// <summary>A class that encapsulates keys needed by <see cref="T:VideoToolbox.VTPixelTransferProperties" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class VTPixelTransferPropertyKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DestinationCleanAperture;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPixelTransferPropertyKey_DestinationCleanAperture",  "VideoToolbox")]
		public static NSString DestinationCleanAperture {
			get {
				if (_DestinationCleanAperture is null)
					_DestinationCleanAperture = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_DestinationCleanAperture")!;
				return _DestinationCleanAperture;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DestinationColorPrimaries;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPixelTransferPropertyKey_DestinationColorPrimaries",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DestinationColorPrimaries {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DestinationColorPrimaries is null)
					_DestinationColorPrimaries = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_DestinationColorPrimaries")!;
				return _DestinationColorPrimaries;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DestinationICCProfile;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPixelTransferPropertyKey_DestinationICCProfile",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DestinationICCProfile {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DestinationICCProfile is null)
					_DestinationICCProfile = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_DestinationICCProfile")!;
				return _DestinationICCProfile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DestinationPixelAspectRatio;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPixelTransferPropertyKey_DestinationPixelAspectRatio",  "VideoToolbox")]
		public static NSString DestinationPixelAspectRatio {
			get {
				if (_DestinationPixelAspectRatio is null)
					_DestinationPixelAspectRatio = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_DestinationPixelAspectRatio")!;
				return _DestinationPixelAspectRatio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DestinationTransferFunction;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPixelTransferPropertyKey_DestinationTransferFunction",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DestinationTransferFunction {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DestinationTransferFunction is null)
					_DestinationTransferFunction = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_DestinationTransferFunction")!;
				return _DestinationTransferFunction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DestinationYCbCrMatrix;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPixelTransferPropertyKey_DestinationYCbCrMatrix",  "VideoToolbox")]
		public static NSString DestinationYCbCrMatrix {
			get {
				if (_DestinationYCbCrMatrix is null)
					_DestinationYCbCrMatrix = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_DestinationYCbCrMatrix")!;
				return _DestinationYCbCrMatrix;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DownsamplingMode;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPixelTransferPropertyKey_DownsamplingMode",  "VideoToolbox")]
		public static NSString DownsamplingMode {
			get {
				if (_DownsamplingMode is null)
					_DownsamplingMode = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_DownsamplingMode")!;
				return _DownsamplingMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DownsamplingMode_Average;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDownsamplingMode_Average",  "VideoToolbox")]
		public static NSString DownsamplingMode_Average {
			get {
				if (_DownsamplingMode_Average is null)
					_DownsamplingMode_Average = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDownsamplingMode_Average")!;
				return _DownsamplingMode_Average;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DownsamplingMode_Decimate;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDownsamplingMode_Decimate",  "VideoToolbox")]
		public static NSString DownsamplingMode_Decimate {
			get {
				if (_DownsamplingMode_Decimate is null)
					_DownsamplingMode_Decimate = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDownsamplingMode_Decimate")!;
				return _DownsamplingMode_Decimate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RealTime;
		/// <summary>Represents the value associated with the constant 'kVTPixelTransferPropertyKey_RealTime'.</summary>
		[Field ("kVTPixelTransferPropertyKey_RealTime",  "VideoToolbox")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString RealTime {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RealTime is null)
					_RealTime = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_RealTime")!;
				return _RealTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScalingMode;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTPixelTransferPropertyKey_ScalingMode",  "VideoToolbox")]
		public static NSString ScalingMode {
			get {
				if (_ScalingMode is null)
					_ScalingMode = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_ScalingMode")!;
				return _ScalingMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScalingMode_CropSourceToCleanAperture;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTScalingMode_CropSourceToCleanAperture",  "VideoToolbox")]
		public static NSString ScalingMode_CropSourceToCleanAperture {
			get {
				if (_ScalingMode_CropSourceToCleanAperture is null)
					_ScalingMode_CropSourceToCleanAperture = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTScalingMode_CropSourceToCleanAperture")!;
				return _ScalingMode_CropSourceToCleanAperture;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScalingMode_Letterbox;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTScalingMode_Letterbox",  "VideoToolbox")]
		public static NSString ScalingMode_Letterbox {
			get {
				if (_ScalingMode_Letterbox is null)
					_ScalingMode_Letterbox = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTScalingMode_Letterbox")!;
				return _ScalingMode_Letterbox;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScalingMode_Normal;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTScalingMode_Normal",  "VideoToolbox")]
		public static NSString ScalingMode_Normal {
			get {
				if (_ScalingMode_Normal is null)
					_ScalingMode_Normal = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTScalingMode_Normal")!;
				return _ScalingMode_Normal;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScalingMode_Trim;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTScalingMode_Trim",  "VideoToolbox")]
		public static NSString ScalingMode_Trim {
			get {
				if (_ScalingMode_Trim is null)
					_ScalingMode_Trim = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTScalingMode_Trim")!;
				return _ScalingMode_Trim;
			}
		}
	} /* class VTPixelTransferPropertyKeys */
}
