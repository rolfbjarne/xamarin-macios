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
	/// <summary>A class whose static members encapsulate AV Foundation constants.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVVideo  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowFrameReorderingKey;
		/// <summary>Represents the value associated with the constant AVVideoAllowFrameReorderingKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoAllowFrameReorderingKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AllowFrameReorderingKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AllowFrameReorderingKey is null)
					_AllowFrameReorderingKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoAllowFrameReorderingKey")!;
				return _AllowFrameReorderingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleProRawBitDepthKey;
		/// <summary>Represents the value associated with the constant 'AVVideoAppleProRAWBitDepthKey'.</summary>
		[Field ("AVVideoAppleProRAWBitDepthKey",  "AVFoundation")]
		[SupportedOSPlatform ("tvos14.3")]
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AppleProRawBitDepthKey {
			[SupportedOSPlatform ("tvos14.3")]
			[SupportedOSPlatform ("ios14.3")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AppleProRawBitDepthKey is null)
					_AppleProRawBitDepthKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoAppleProRAWBitDepthKey")!;
				return _AppleProRawBitDepthKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleProRes422;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVVideoCodecAppleProRes422",  "AVFoundation")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'AVVideoCodecType' enum instead.")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AppleProRes422 {
			[ObsoletedOSPlatform ("macos10.13", "Use 'AVVideoCodecType' enum instead.")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AppleProRes422 is null)
					_AppleProRes422 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCodecAppleProRes422")!;
				return _AppleProRes422;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleProRes4444;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVVideoCodecAppleProRes4444",  "AVFoundation")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'AVVideoCodecType' enum instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'AVVideoCodecType' enum instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'AVVideoCodecType' enum instead.")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVVideoCodecType' enum instead.")]
		[SupportedOSPlatform ("macos")]
		public static NSString AppleProRes4444 {
			[ObsoletedOSPlatform ("ios11.0", "Use 'AVVideoCodecType' enum instead.")]
			[ObsoletedOSPlatform ("macos10.13", "Use 'AVVideoCodecType' enum instead.")]
			[ObsoletedOSPlatform ("tvos11.0", "Use 'AVVideoCodecType' enum instead.")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVVideoCodecType' enum instead.")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AppleProRes4444 is null)
					_AppleProRes4444 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCodecAppleProRes4444")!;
				return _AppleProRes4444;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AverageBitRateKey;
		/// <summary>Represents the value associated with the constant AVVideoAverageBitRateKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoAverageBitRateKey",  "AVFoundation")]
		public static NSString AverageBitRateKey {
			get {
				if (_AverageBitRateKey is null)
					_AverageBitRateKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoAverageBitRateKey")!;
				return _AverageBitRateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AverageNonDroppableFrameRateKey;
		/// <summary>Represents the value associated with the constant AVVideoAverageNonDroppableFrameRateKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoAverageNonDroppableFrameRateKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AverageNonDroppableFrameRateKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AverageNonDroppableFrameRateKey is null)
					_AverageNonDroppableFrameRateKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoAverageNonDroppableFrameRateKey")!;
				return _AverageNonDroppableFrameRateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleanApertureHeightKey;
		/// <summary>Represents the value associated with the constant AVVideoCleanApertureHeightKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoCleanApertureHeightKey",  "AVFoundation")]
		public static NSString CleanApertureHeightKey {
			get {
				if (_CleanApertureHeightKey is null)
					_CleanApertureHeightKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCleanApertureHeightKey")!;
				return _CleanApertureHeightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleanApertureHorizontalOffsetKey;
		/// <summary>Represents the value associated with the constant AVVideoCleanApertureHorizontalOffsetKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoCleanApertureHorizontalOffsetKey",  "AVFoundation")]
		public static NSString CleanApertureHorizontalOffsetKey {
			get {
				if (_CleanApertureHorizontalOffsetKey is null)
					_CleanApertureHorizontalOffsetKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCleanApertureHorizontalOffsetKey")!;
				return _CleanApertureHorizontalOffsetKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleanApertureKey;
		/// <summary>Represents the value associated with the constant AVVideoCleanApertureKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoCleanApertureKey",  "AVFoundation")]
		public static NSString CleanApertureKey {
			get {
				if (_CleanApertureKey is null)
					_CleanApertureKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCleanApertureKey")!;
				return _CleanApertureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleanApertureVerticalOffsetKey;
		/// <summary>Represents the value associated with the constant AVVideoCleanApertureVerticalOffsetKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoCleanApertureVerticalOffsetKey",  "AVFoundation")]
		public static NSString CleanApertureVerticalOffsetKey {
			get {
				if (_CleanApertureVerticalOffsetKey is null)
					_CleanApertureVerticalOffsetKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCleanApertureVerticalOffsetKey")!;
				return _CleanApertureVerticalOffsetKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleanApertureWidthKey;
		/// <summary>Represents the value associated with the constant AVVideoCleanApertureWidthKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoCleanApertureWidthKey",  "AVFoundation")]
		public static NSString CleanApertureWidthKey {
			get {
				if (_CleanApertureWidthKey is null)
					_CleanApertureWidthKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCleanApertureWidthKey")!;
				return _CleanApertureWidthKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CodecH264;
		/// <summary>Developers should not use this deprecated property. Developers should use 'AVVideoCodecType' enum instead.</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoCodecH264",  "AVFoundation")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'AVVideoCodecType' enum instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'AVVideoCodecType' enum instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'AVVideoCodecType' enum instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVVideoCodecType' enum instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString CodecH264 {
			[ObsoletedOSPlatform ("ios11.0", "Use 'AVVideoCodecType' enum instead.")]
			[ObsoletedOSPlatform ("macos10.13", "Use 'AVVideoCodecType' enum instead.")]
			[ObsoletedOSPlatform ("tvos11.0", "Use 'AVVideoCodecType' enum instead.")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVVideoCodecType' enum instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_CodecH264 is null)
					_CodecH264 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCodecH264")!;
				return _CodecH264;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CodecJPEG;
		/// <summary>Represents the value associated with the constant AVVideoCodecJPEG</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoCodecJPEG",  "AVFoundation")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'AVVideoCodecType' enum instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'AVVideoCodecType' enum instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'AVVideoCodecType' enum instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVVideoCodecType' enum instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString CodecJPEG {
			[ObsoletedOSPlatform ("ios11.0", "Use 'AVVideoCodecType' enum instead.")]
			[ObsoletedOSPlatform ("macos10.13", "Use 'AVVideoCodecType' enum instead.")]
			[ObsoletedOSPlatform ("tvos11.0", "Use 'AVVideoCodecType' enum instead.")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVVideoCodecType' enum instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_CodecJPEG is null)
					_CodecJPEG = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCodecJPEG")!;
				return _CodecJPEG;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CodecKey;
		/// <summary>Represents the value associated with the constant AVVideoCodecKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoCodecKey",  "AVFoundation")]
		public static NSString CodecKey {
			get {
				if (_CodecKey is null)
					_CodecKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCodecKey")!;
				return _CodecKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CompressionPropertiesKey;
		/// <summary>Represents the value associated with the constant AVVideoCompressionPropertiesKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoCompressionPropertiesKey",  "AVFoundation")]
		public static NSString CompressionPropertiesKey {
			get {
				if (_CompressionPropertiesKey is null)
					_CompressionPropertiesKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCompressionPropertiesKey")!;
				return _CompressionPropertiesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DecompressionPropertiesKey;
		/// <summary>Represents the value associated with the constant 'AVVideoDecompressionPropertiesKey'.</summary>
		[Field ("AVVideoDecompressionPropertiesKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios17.0")]
		public static NSString DecompressionPropertiesKey {
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("tvos26.4")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios17.0")]
			get {
				if (_DecompressionPropertiesKey is null)
					_DecompressionPropertiesKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoDecompressionPropertiesKey")!;
				return _DecompressionPropertiesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncoderSpecificationKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVVideoEncoderSpecificationKey",  "AVFoundation")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString EncoderSpecificationKey {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_EncoderSpecificationKey is null)
					_EncoderSpecificationKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoEncoderSpecificationKey")!;
				return _EncoderSpecificationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExpectedSourceFrameRateKey;
		/// <summary>Represents the value associated with the constant AVVideoExpectedSourceFrameRateKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoExpectedSourceFrameRateKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExpectedSourceFrameRateKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExpectedSourceFrameRateKey is null)
					_ExpectedSourceFrameRateKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoExpectedSourceFrameRateKey")!;
				return _ExpectedSourceFrameRateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264EntropyModeCABAC;
		/// <summary>Represents the value associated with the constant AVVideoH264EntropyModeCABAC</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoH264EntropyModeCABAC",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264EntropyModeCABAC {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264EntropyModeCABAC is null)
					_H264EntropyModeCABAC = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoH264EntropyModeCABAC")!;
				return _H264EntropyModeCABAC;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264EntropyModeCAVLC;
		/// <summary>Represents the value associated with the constant AVVideoH264EntropyModeCAVLC</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoH264EntropyModeCAVLC",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264EntropyModeCAVLC {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264EntropyModeCAVLC is null)
					_H264EntropyModeCAVLC = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoH264EntropyModeCAVLC")!;
				return _H264EntropyModeCAVLC;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264EntropyModeKey;
		/// <summary>Represents the value associated with the constant AVVideoH264EntropyModeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoH264EntropyModeKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264EntropyModeKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264EntropyModeKey is null)
					_H264EntropyModeKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoH264EntropyModeKey")!;
				return _H264EntropyModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeightKey;
		/// <summary>Represents the value associated with the constant AVVideoHeightKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoHeightKey",  "AVFoundation")]
		public static NSString HeightKey {
			get {
				if (_HeightKey is null)
					_HeightKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoHeightKey")!;
				return _HeightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaxKeyFrameIntervalDurationKey;
		/// <summary>Represents the value associated with the constant AVVideoMaxKeyFrameIntervalDurationKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoMaxKeyFrameIntervalDurationKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MaxKeyFrameIntervalDurationKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MaxKeyFrameIntervalDurationKey is null)
					_MaxKeyFrameIntervalDurationKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoMaxKeyFrameIntervalDurationKey")!;
				return _MaxKeyFrameIntervalDurationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaxKeyFrameIntervalKey;
		/// <summary>Represents the value associated with the constant AVVideoMaxKeyFrameIntervalKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoMaxKeyFrameIntervalKey",  "AVFoundation")]
		public static NSString MaxKeyFrameIntervalKey {
			get {
				if (_MaxKeyFrameIntervalKey is null)
					_MaxKeyFrameIntervalKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoMaxKeyFrameIntervalKey")!;
				return _MaxKeyFrameIntervalKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelAspectRatioHorizontalSpacingKey;
		/// <summary>Represents the value associated with the constant AVVideoPixelAspectRatioHorizontalSpacingKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoPixelAspectRatioHorizontalSpacingKey",  "AVFoundation")]
		public static NSString PixelAspectRatioHorizontalSpacingKey {
			get {
				if (_PixelAspectRatioHorizontalSpacingKey is null)
					_PixelAspectRatioHorizontalSpacingKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoPixelAspectRatioHorizontalSpacingKey")!;
				return _PixelAspectRatioHorizontalSpacingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelAspectRatioKey;
		/// <summary>Represents the value associated with the constant AVVideoPixelAspectRatioKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoPixelAspectRatioKey",  "AVFoundation")]
		public static NSString PixelAspectRatioKey {
			get {
				if (_PixelAspectRatioKey is null)
					_PixelAspectRatioKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoPixelAspectRatioKey")!;
				return _PixelAspectRatioKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelAspectRatioVerticalSpacingKey;
		/// <summary>Represents the value associated with the constant AVVideoPixelAspectRatioVerticalSpacingKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoPixelAspectRatioVerticalSpacingKey",  "AVFoundation")]
		public static NSString PixelAspectRatioVerticalSpacingKey {
			get {
				if (_PixelAspectRatioVerticalSpacingKey is null)
					_PixelAspectRatioVerticalSpacingKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoPixelAspectRatioVerticalSpacingKey")!;
				return _PixelAspectRatioVerticalSpacingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileLevelH264Baseline30;
		/// <summary>Represents the value associated with the constant AVVideoProfileLevelH264Baseline30</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoProfileLevelH264Baseline30",  "AVFoundation")]
		public static NSString ProfileLevelH264Baseline30 {
			get {
				if (_ProfileLevelH264Baseline30 is null)
					_ProfileLevelH264Baseline30 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264Baseline30")!;
				return _ProfileLevelH264Baseline30;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileLevelH264Baseline31;
		/// <summary>Represents the value associated with the constant AVVideoProfileLevelH264Baseline31</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoProfileLevelH264Baseline31",  "AVFoundation")]
		public static NSString ProfileLevelH264Baseline31 {
			get {
				if (_ProfileLevelH264Baseline31 is null)
					_ProfileLevelH264Baseline31 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264Baseline31")!;
				return _ProfileLevelH264Baseline31;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileLevelH264Baseline41;
		/// <summary>Represents the value associated with the constant AVVideoProfileLevelH264Baseline41</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoProfileLevelH264Baseline41",  "AVFoundation")]
		public static NSString ProfileLevelH264Baseline41 {
			get {
				if (_ProfileLevelH264Baseline41 is null)
					_ProfileLevelH264Baseline41 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264Baseline41")!;
				return _ProfileLevelH264Baseline41;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileLevelH264BaselineAutoLevel;
		/// <summary>Represents the value associated with the constant AVVideoProfileLevelH264BaselineAutoLevel</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoProfileLevelH264BaselineAutoLevel",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ProfileLevelH264BaselineAutoLevel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ProfileLevelH264BaselineAutoLevel is null)
					_ProfileLevelH264BaselineAutoLevel = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264BaselineAutoLevel")!;
				return _ProfileLevelH264BaselineAutoLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileLevelH264High40;
		/// <summary>Represents the value associated with the constant AVVideoProfileLevelH264High40</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoProfileLevelH264High40",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ProfileLevelH264High40 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ProfileLevelH264High40 is null)
					_ProfileLevelH264High40 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264High40")!;
				return _ProfileLevelH264High40;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileLevelH264High41;
		/// <summary>Represents the value associated with the constant AVVideoProfileLevelH264High41</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoProfileLevelH264High41",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ProfileLevelH264High41 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ProfileLevelH264High41 is null)
					_ProfileLevelH264High41 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264High41")!;
				return _ProfileLevelH264High41;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileLevelH264HighAutoLevel;
		/// <summary>Represents the value associated with the constant AVVideoProfileLevelH264HighAutoLevel</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoProfileLevelH264HighAutoLevel",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ProfileLevelH264HighAutoLevel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ProfileLevelH264HighAutoLevel is null)
					_ProfileLevelH264HighAutoLevel = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264HighAutoLevel")!;
				return _ProfileLevelH264HighAutoLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileLevelH264Main30;
		/// <summary>Represents the value associated with the constant AVVideoProfileLevelH264Main30</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoProfileLevelH264Main30",  "AVFoundation")]
		public static NSString ProfileLevelH264Main30 {
			get {
				if (_ProfileLevelH264Main30 is null)
					_ProfileLevelH264Main30 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264Main30")!;
				return _ProfileLevelH264Main30;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileLevelH264Main31;
		/// <summary>Represents the value associated with the constant AVVideoProfileLevelH264Main31</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoProfileLevelH264Main31",  "AVFoundation")]
		public static NSString ProfileLevelH264Main31 {
			get {
				if (_ProfileLevelH264Main31 is null)
					_ProfileLevelH264Main31 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264Main31")!;
				return _ProfileLevelH264Main31;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileLevelH264Main32;
		/// <summary>Represents the value associated with the constant AVVideoProfileLevelH264Main32</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoProfileLevelH264Main32",  "AVFoundation")]
		public static NSString ProfileLevelH264Main32 {
			get {
				if (_ProfileLevelH264Main32 is null)
					_ProfileLevelH264Main32 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264Main32")!;
				return _ProfileLevelH264Main32;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileLevelH264Main41;
		/// <summary>Represents the value associated with the constant AVVideoProfileLevelH264Main41</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoProfileLevelH264Main41",  "AVFoundation")]
		public static NSString ProfileLevelH264Main41 {
			get {
				if (_ProfileLevelH264Main41 is null)
					_ProfileLevelH264Main41 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264Main41")!;
				return _ProfileLevelH264Main41;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileLevelH264MainAutoLevel;
		/// <summary>Represents the value associated with the constant AVVideoProfileLevelH264MainAutoLevel</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoProfileLevelH264MainAutoLevel",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ProfileLevelH264MainAutoLevel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ProfileLevelH264MainAutoLevel is null)
					_ProfileLevelH264MainAutoLevel = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264MainAutoLevel")!;
				return _ProfileLevelH264MainAutoLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileLevelKey;
		/// <summary>Represents the value associated with the constant AVVideoProfileLevelKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoProfileLevelKey",  "AVFoundation")]
		public static NSString ProfileLevelKey {
			get {
				if (_ProfileLevelKey is null)
					_ProfileLevelKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoProfileLevelKey")!;
				return _ProfileLevelKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QualityKey;
		/// <summary>Represents the value associated with the constant AVVideoQualityKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoQualityKey",  "AVFoundation")]
		public static NSString QualityKey {
			get {
				if (_QualityKey is null)
					_QualityKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoQualityKey")!;
				return _QualityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScalingModeKey;
		/// <summary>Represents the value associated with the constant AVVideoScalingModeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoScalingModeKey",  "AVFoundation")]
		public static NSString ScalingModeKey {
			get {
				if (_ScalingModeKey is null)
					_ScalingModeKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoScalingModeKey")!;
				return _ScalingModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WidthKey;
		/// <summary>Represents the value associated with the constant AVVideoWidthKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVVideoWidthKey",  "AVFoundation")]
		public static NSString WidthKey {
			get {
				if (_WidthKey is null)
					_WidthKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoWidthKey")!;
				return _WidthKey;
			}
		}
	} /* class AVVideo */
}
