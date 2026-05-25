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
namespace VideoToolbox {
	/// <summary>A class that encapsulates keys necessary for compression sessions. Used by <see cref="T:VideoToolbox.VTCompressionProperties" /></summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class VTCompressionPropertyKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowFrameReordering;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_AllowFrameReordering",  "VideoToolbox")]
		public static NSString AllowFrameReordering {
			get {
				if (_AllowFrameReordering is null)
					_AllowFrameReordering = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_AllowFrameReordering")!;
				return _AllowFrameReordering;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowOpenGop;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_AllowOpenGOP",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AllowOpenGop {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AllowOpenGop is null)
					_AllowOpenGop = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_AllowOpenGOP")!;
				return _AllowOpenGop;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowTemporalCompression;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_AllowTemporalCompression",  "VideoToolbox")]
		public static NSString AllowTemporalCompression {
			get {
				if (_AllowTemporalCompression is null)
					_AllowTemporalCompression = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_AllowTemporalCompression")!;
				return _AllowTemporalCompression;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlphaChannelMode;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_AlphaChannelMode'.</summary>
		[Field ("kVTCompressionPropertyKey_AlphaChannelMode",  "VideoToolbox")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AlphaChannelMode {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AlphaChannelMode is null)
					_AlphaChannelMode = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_AlphaChannelMode")!;
				return _AlphaChannelMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AspectRatio16x9;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_AspectRatio16x9",  "VideoToolbox")]
		public static NSString AspectRatio16x9 {
			get {
				if (_AspectRatio16x9 is null)
					_AspectRatio16x9 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_AspectRatio16x9")!;
				return _AspectRatio16x9;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AverageBitRate;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_AverageBitRate",  "VideoToolbox")]
		public static NSString AverageBitRate {
			get {
				if (_AverageBitRate is null)
					_AverageBitRate = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_AverageBitRate")!;
				return _AverageBitRate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BaseLayerBitRateFraction;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_BaseLayerBitRateFraction'.</summary>
		[Field ("kVTCompressionPropertyKey_BaseLayerBitRateFraction",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString BaseLayerBitRateFraction {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_BaseLayerBitRateFraction is null)
					_BaseLayerBitRateFraction = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_BaseLayerBitRateFraction")!;
				return _BaseLayerBitRateFraction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BaseLayerFrameRate;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_BaseLayerFrameRate",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString BaseLayerFrameRate {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_BaseLayerFrameRate is null)
					_BaseLayerFrameRate = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_BaseLayerFrameRate")!;
				return _BaseLayerFrameRate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BaseLayerFrameRateFraction;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_BaseLayerFrameRateFraction'.</summary>
		[Field ("kVTCompressionPropertyKey_BaseLayerFrameRateFraction",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString BaseLayerFrameRateFraction {
			[SupportedOSPlatform ("tvos14.5")]
			[SupportedOSPlatform ("ios14.5")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_BaseLayerFrameRateFraction is null)
					_BaseLayerFrameRateFraction = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_BaseLayerFrameRateFraction")!;
				return _BaseLayerFrameRateFraction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CalculateMeanSquaredError;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_CalculateMeanSquaredError'.</summary>
		[Field ("kVTCompressionPropertyKey_CalculateMeanSquaredError",  "VideoToolbox")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public static NSString CalculateMeanSquaredError {
			[SupportedOSPlatform ("macos14.4")]
			[SupportedOSPlatform ("ios17.4")]
			[SupportedOSPlatform ("tvos17.4")]
			[SupportedOSPlatform ("maccatalyst17.4")]
			get {
				if (_CalculateMeanSquaredError is null)
					_CalculateMeanSquaredError = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_CalculateMeanSquaredError")!;
				return _CalculateMeanSquaredError;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CameraCalibrationDataLensCollection;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_CameraCalibrationDataLensCollection'.</summary>
		[Field ("kVTCompressionPropertyKey_CameraCalibrationDataLensCollection",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString CameraCalibrationDataLensCollection {
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_CameraCalibrationDataLensCollection is null)
					_CameraCalibrationDataLensCollection = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_CameraCalibrationDataLensCollection")!;
				return _CameraCalibrationDataLensCollection;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleanAperture;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_CleanAperture",  "VideoToolbox")]
		public static NSString CleanAperture {
			get {
				if (_CleanAperture is null)
					_CleanAperture = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_CleanAperture")!;
				return _CleanAperture;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorPrimaries;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_ColorPrimaries",  "VideoToolbox")]
		public static NSString ColorPrimaries {
			get {
				if (_ColorPrimaries is null)
					_ColorPrimaries = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ColorPrimaries")!;
				return _ColorPrimaries;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ConstantBitRate;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_ConstantBitRate'.</summary>
		[Field ("kVTCompressionPropertyKey_ConstantBitRate",  "VideoToolbox")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public static NSString ConstantBitRate {
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("tvos16.0")]
			get {
				if (_ConstantBitRate is null)
					_ConstantBitRate = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ConstantBitRate")!;
				return _ConstantBitRate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentLightLevelInfo;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_ContentLightLevelInfo",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ContentLightLevelInfo {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ContentLightLevelInfo is null)
					_ContentLightLevelInfo = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ContentLightLevelInfo")!;
				return _ContentLightLevelInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DataRateLimits;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_DataRateLimits",  "VideoToolbox")]
		public static NSString DataRateLimits {
			get {
				if (_DataRateLimits is null)
					_DataRateLimits = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_DataRateLimits")!;
				return _DataRateLimits;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Depth;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_Depth",  "VideoToolbox")]
		public static NSString Depth {
			get {
				if (_Depth is null)
					_Depth = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_Depth")!;
				return _Depth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EnableLowLatencyRateControl;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderSpecification_EnableLowLatencyRateControl'.</summary>
		[Field ("kVTVideoEncoderSpecification_EnableLowLatencyRateControl",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString EnableLowLatencyRateControl {
			[SupportedOSPlatform ("tvos14.5")]
			[SupportedOSPlatform ("ios14.5")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_EnableLowLatencyRateControl is null)
					_EnableLowLatencyRateControl = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderSpecification_EnableLowLatencyRateControl")!;
				return _EnableLowLatencyRateControl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EnableLtr;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_EnableLTR'.</summary>
		[Field ("kVTCompressionPropertyKey_EnableLTR",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString EnableLtr {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_EnableLtr is null)
					_EnableLtr = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_EnableLTR")!;
				return _EnableLtr;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncoderId;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_EncoderID",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString EncoderId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EncoderId is null)
					_EncoderId = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_EncoderID")!;
				return _EncoderId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EstimatedAverageBytesPerFrame;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_EstimatedAverageBytesPerFrame'.</summary>
		[Field ("kVTCompressionPropertyKey_EstimatedAverageBytesPerFrame",  "VideoToolbox")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public static NSString EstimatedAverageBytesPerFrame {
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("tvos16.0")]
			get {
				if (_EstimatedAverageBytesPerFrame is null)
					_EstimatedAverageBytesPerFrame = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_EstimatedAverageBytesPerFrame")!;
				return _EstimatedAverageBytesPerFrame;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExpectedDuration;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_ExpectedDuration",  "VideoToolbox")]
		public static NSString ExpectedDuration {
			get {
				if (_ExpectedDuration is null)
					_ExpectedDuration = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ExpectedDuration")!;
				return _ExpectedDuration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExpectedFrameRate;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_ExpectedFrameRate",  "VideoToolbox")]
		public static NSString ExpectedFrameRate {
			get {
				if (_ExpectedFrameRate is null)
					_ExpectedFrameRate = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ExpectedFrameRate")!;
				return _ExpectedFrameRate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldCount;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_FieldCount",  "VideoToolbox")]
		public static NSString FieldCount {
			get {
				if (_FieldCount is null)
					_FieldCount = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_FieldCount")!;
				return _FieldCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldDetail;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_FieldDetail",  "VideoToolbox")]
		public static NSString FieldDetail {
			get {
				if (_FieldDetail is null)
					_FieldDetail = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_FieldDetail")!;
				return _FieldDetail;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GammaLevel;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_GammaLevel'.</summary>
		[Field ("kVTCompressionPropertyKey_GammaLevel",  "VideoToolbox")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GammaLevel {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GammaLevel is null)
					_GammaLevel = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_GammaLevel")!;
				return _GammaLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264EntropyMode;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_H264EntropyMode",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264EntropyMode {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264EntropyMode is null)
					_H264EntropyMode = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_H264EntropyMode")!;
				return _H264EntropyMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HasLeftStereoEyeView;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_HasLeftStereoEyeView'.</summary>
		[Field ("kVTCompressionPropertyKey_HasLeftStereoEyeView",  "VideoToolbox")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString HasLeftStereoEyeView {
			[SupportedOSPlatform ("ios17.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_HasLeftStereoEyeView is null)
					_HasLeftStereoEyeView = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_HasLeftStereoEyeView")!;
				return _HasLeftStereoEyeView;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HasRightStereoEyeView;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_HasRightStereoEyeView'.</summary>
		[Field ("kVTCompressionPropertyKey_HasRightStereoEyeView",  "VideoToolbox")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString HasRightStereoEyeView {
			[SupportedOSPlatform ("ios17.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_HasRightStereoEyeView is null)
					_HasRightStereoEyeView = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_HasRightStereoEyeView")!;
				return _HasRightStereoEyeView;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HdrMetadataInsertionMode;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_HDRMetadataInsertionMode'.</summary>
		[Field ("kVTCompressionPropertyKey_HDRMetadataInsertionMode",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString HdrMetadataInsertionMode {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_HdrMetadataInsertionMode is null)
					_HdrMetadataInsertionMode = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_HDRMetadataInsertionMode")!;
				return _HdrMetadataInsertionMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeroEye;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_HeroEye'.</summary>
		[Field ("kVTCompressionPropertyKey_HeroEye",  "VideoToolbox")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString HeroEye {
			[SupportedOSPlatform ("ios17.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_HeroEye is null)
					_HeroEye = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_HeroEye")!;
				return _HeroEye;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HorizontalDisparityAdjustment;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_HorizontalDisparityAdjustment'.</summary>
		[Field ("kVTCompressionPropertyKey_HorizontalDisparityAdjustment",  "VideoToolbox")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString HorizontalDisparityAdjustment {
			[SupportedOSPlatform ("ios17.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_HorizontalDisparityAdjustment is null)
					_HorizontalDisparityAdjustment = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_HorizontalDisparityAdjustment")!;
				return _HorizontalDisparityAdjustment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HorizontalFieldOfView;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_HorizontalFieldOfView'.</summary>
		[Field ("kVTCompressionPropertyKey_HorizontalFieldOfView",  "VideoToolbox")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString HorizontalFieldOfView {
			[SupportedOSPlatform ("ios17.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_HorizontalFieldOfView is null)
					_HorizontalFieldOfView = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_HorizontalFieldOfView")!;
				return _HorizontalFieldOfView;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ICCProfile;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_ICCProfile",  "VideoToolbox")]
		public static NSString ICCProfile {
			get {
				if (_ICCProfile is null)
					_ICCProfile = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ICCProfile")!;
				return _ICCProfile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MasteringDisplayColorVolume;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_MasteringDisplayColorVolume",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MasteringDisplayColorVolume {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MasteringDisplayColorVolume is null)
					_MasteringDisplayColorVolume = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MasteringDisplayColorVolume")!;
				return _MasteringDisplayColorVolume;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaxAllowedFrameQP;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_MaxAllowedFrameQP'.</summary>
		[Field ("kVTCompressionPropertyKey_MaxAllowedFrameQP",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MaxAllowedFrameQP {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MaxAllowedFrameQP is null)
					_MaxAllowedFrameQP = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MaxAllowedFrameQP")!;
				return _MaxAllowedFrameQP;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaxFrameDelayCount;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_MaxFrameDelayCount",  "VideoToolbox")]
		public static NSString MaxFrameDelayCount {
			get {
				if (_MaxFrameDelayCount is null)
					_MaxFrameDelayCount = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MaxFrameDelayCount")!;
				return _MaxFrameDelayCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaxH264SliceBytes;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_MaxH264SliceBytes",  "VideoToolbox")]
		public static NSString MaxH264SliceBytes {
			get {
				if (_MaxH264SliceBytes is null)
					_MaxH264SliceBytes = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MaxH264SliceBytes")!;
				return _MaxH264SliceBytes;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaxKeyFrameInterval;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_MaxKeyFrameInterval",  "VideoToolbox")]
		public static NSString MaxKeyFrameInterval {
			get {
				if (_MaxKeyFrameInterval is null)
					_MaxKeyFrameInterval = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MaxKeyFrameInterval")!;
				return _MaxKeyFrameInterval;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaxKeyFrameIntervalDuration;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_MaxKeyFrameIntervalDuration",  "VideoToolbox")]
		public static NSString MaxKeyFrameIntervalDuration {
			get {
				if (_MaxKeyFrameIntervalDuration is null)
					_MaxKeyFrameIntervalDuration = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MaxKeyFrameIntervalDuration")!;
				return _MaxKeyFrameIntervalDuration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaximizePowerEfficiency;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_MaximizePowerEfficiency",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MaximizePowerEfficiency {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MaximizePowerEfficiency is null)
					_MaximizePowerEfficiency = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MaximizePowerEfficiency")!;
				return _MaximizePowerEfficiency;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaximumRealTimeFrameRate;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_MaximumRealTimeFrameRate'.</summary>
		[Field ("kVTCompressionPropertyKey_MaximumRealTimeFrameRate",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString MaximumRealTimeFrameRate {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_MaximumRealTimeFrameRate is null)
					_MaximumRealTimeFrameRate = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MaximumRealTimeFrameRate")!;
				return _MaximumRealTimeFrameRate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MinAllowedFrameQP;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_MinAllowedFrameQP'.</summary>
		[Field ("kVTCompressionPropertyKey_MinAllowedFrameQP",  "VideoToolbox")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public static NSString MinAllowedFrameQP {
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("tvos16.0")]
			get {
				if (_MinAllowedFrameQP is null)
					_MinAllowedFrameQP = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MinAllowedFrameQP")!;
				return _MinAllowedFrameQP;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MoreFramesAfterEnd;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_MoreFramesAfterEnd",  "VideoToolbox")]
		public static NSString MoreFramesAfterEnd {
			get {
				if (_MoreFramesAfterEnd is null)
					_MoreFramesAfterEnd = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MoreFramesAfterEnd")!;
				return _MoreFramesAfterEnd;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MoreFramesBeforeStart;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_MoreFramesBeforeStart",  "VideoToolbox")]
		public static NSString MoreFramesBeforeStart {
			get {
				if (_MoreFramesBeforeStart is null)
					_MoreFramesBeforeStart = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MoreFramesBeforeStart")!;
				return _MoreFramesBeforeStart;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MultiPassStorage;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_MultiPassStorage",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MultiPassStorage {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MultiPassStorage is null)
					_MultiPassStorage = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MultiPassStorage")!;
				return _MultiPassStorage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MvHevcLeftAndRightViewIds;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_MVHEVCLeftAndRightViewIDs'.</summary>
		[Field ("kVTCompressionPropertyKey_MVHEVCLeftAndRightViewIDs",  "VideoToolbox")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString MvHevcLeftAndRightViewIds {
			[SupportedOSPlatform ("ios17.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_MvHevcLeftAndRightViewIds is null)
					_MvHevcLeftAndRightViewIds = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MVHEVCLeftAndRightViewIDs")!;
				return _MvHevcLeftAndRightViewIds;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MvHevcVideoLayerIds;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_MVHEVCVideoLayerIDs'.</summary>
		[Field ("kVTCompressionPropertyKey_MVHEVCVideoLayerIDs",  "VideoToolbox")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString MvHevcVideoLayerIds {
			[SupportedOSPlatform ("ios17.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_MvHevcVideoLayerIds is null)
					_MvHevcVideoLayerIds = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MVHEVCVideoLayerIDs")!;
				return _MvHevcVideoLayerIds;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MvHevcViewIds;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_MVHEVCViewIDs'.</summary>
		[Field ("kVTCompressionPropertyKey_MVHEVCViewIDs",  "VideoToolbox")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString MvHevcViewIds {
			[SupportedOSPlatform ("ios17.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_MvHevcViewIds is null)
					_MvHevcViewIds = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MVHEVCViewIDs")!;
				return _MvHevcViewIds;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NumberOfPendingFrames;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_NumberOfPendingFrames",  "VideoToolbox")]
		public static NSString NumberOfPendingFrames {
			get {
				if (_NumberOfPendingFrames is null)
					_NumberOfPendingFrames = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_NumberOfPendingFrames")!;
				return _NumberOfPendingFrames;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OutputBitDepth;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_OutputBitDepth'.</summary>
		[Field ("kVTCompressionPropertyKey_OutputBitDepth",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		public static NSString OutputBitDepth {
			[SupportedOSPlatform ("tvos15.4")]
			[SupportedOSPlatform ("macos12.3")]
			[SupportedOSPlatform ("ios15.4")]
			[SupportedOSPlatform ("maccatalyst15.4")]
			get {
				if (_OutputBitDepth is null)
					_OutputBitDepth = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_OutputBitDepth")!;
				return _OutputBitDepth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelAspectRatio;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_PixelAspectRatio",  "VideoToolbox")]
		public static NSString PixelAspectRatio {
			get {
				if (_PixelAspectRatio is null)
					_PixelAspectRatio = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_PixelAspectRatio")!;
				return _PixelAspectRatio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelBufferPoolIsShared;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_PixelBufferPoolIsShared",  "VideoToolbox")]
		public static NSString PixelBufferPoolIsShared {
			get {
				if (_PixelBufferPoolIsShared is null)
					_PixelBufferPoolIsShared = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_PixelBufferPoolIsShared")!;
				return _PixelBufferPoolIsShared;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelTransferProperties;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_PixelTransferProperties",  "VideoToolbox")]
		public static NSString PixelTransferProperties {
			get {
				if (_PixelTransferProperties is null)
					_PixelTransferProperties = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_PixelTransferProperties")!;
				return _PixelTransferProperties;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreserveAlphaChannel;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_PreserveAlphaChannel'.</summary>
		[Field ("kVTCompressionPropertyKey_PreserveAlphaChannel",  "VideoToolbox")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public static NSString PreserveAlphaChannel {
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("tvos16.0")]
			get {
				if (_PreserveAlphaChannel is null)
					_PreserveAlphaChannel = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_PreserveAlphaChannel")!;
				return _PreserveAlphaChannel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreserveDynamicHdrMetadata;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_PreserveDynamicHDRMetadata'.</summary>
		[Field ("kVTCompressionPropertyKey_PreserveDynamicHDRMetadata",  "VideoToolbox")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PreserveDynamicHdrMetadata {
			[SupportedOSPlatform ("ios14.1")]
			[SupportedOSPlatform ("tvos14.2")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PreserveDynamicHdrMetadata is null)
					_PreserveDynamicHdrMetadata = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_PreserveDynamicHDRMetadata")!;
				return _PreserveDynamicHdrMetadata;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PrioritizeEncodingSpeedOverQuality;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_PrioritizeEncodingSpeedOverQuality'.</summary>
		[Field ("kVTCompressionPropertyKey_PrioritizeEncodingSpeedOverQuality",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PrioritizeEncodingSpeedOverQuality {
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PrioritizeEncodingSpeedOverQuality is null)
					_PrioritizeEncodingSpeedOverQuality = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_PrioritizeEncodingSpeedOverQuality")!;
				return _PrioritizeEncodingSpeedOverQuality;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileLevel;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_ProfileLevel",  "VideoToolbox")]
		public static NSString ProfileLevel {
			get {
				if (_ProfileLevel is null)
					_ProfileLevel = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ProfileLevel")!;
				return _ProfileLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProgressiveScan;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_ProgressiveScan",  "VideoToolbox")]
		public static NSString ProgressiveScan {
			get {
				if (_ProgressiveScan is null)
					_ProgressiveScan = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ProgressiveScan")!;
				return _ProgressiveScan;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProjectionKind;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_ProjectionKind'.</summary>
		[Field ("kVTCompressionPropertyKey_ProjectionKind",  "VideoToolbox")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString ProjectionKind {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_ProjectionKind is null)
					_ProjectionKind = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ProjectionKind")!;
				return _ProjectionKind;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Quality;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_Quality",  "VideoToolbox")]
		public static NSString Quality {
			get {
				if (_Quality is null)
					_Quality = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_Quality")!;
				return _Quality;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RealTime;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_RealTime",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString RealTime {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_RealTime is null)
					_RealTime = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_RealTime")!;
				return _RealTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecommendedParallelizationLimit;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_RecommendedParallelizationLimit'.</summary>
		[Field ("kVTCompressionPropertyKey_RecommendedParallelizationLimit",  "VideoToolbox")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString RecommendedParallelizationLimit {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_RecommendedParallelizationLimit is null)
					_RecommendedParallelizationLimit = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_RecommendedParallelizationLimit")!;
				return _RecommendedParallelizationLimit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecommendedParallelizedSubdivisionMinimumDuration;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_RecommendedParallelizedSubdivisionMinimumDuration'.</summary>
		[Field ("kVTCompressionPropertyKey_RecommendedParallelizedSubdivisionMinimumDuration",  "VideoToolbox")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString RecommendedParallelizedSubdivisionMinimumDuration {
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_RecommendedParallelizedSubdivisionMinimumDuration is null)
					_RecommendedParallelizedSubdivisionMinimumDuration = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_RecommendedParallelizedSubdivisionMinimumDuration")!;
				return _RecommendedParallelizedSubdivisionMinimumDuration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecommendedParallelizedSubdivisionMinimumFrameCount;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_RecommendedParallelizedSubdivisionMinimumFrameCount'.</summary>
		[Field ("kVTCompressionPropertyKey_RecommendedParallelizedSubdivisionMinimumFrameCount",  "VideoToolbox")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString RecommendedParallelizedSubdivisionMinimumFrameCount {
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_RecommendedParallelizedSubdivisionMinimumFrameCount is null)
					_RecommendedParallelizedSubdivisionMinimumFrameCount = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_RecommendedParallelizedSubdivisionMinimumFrameCount")!;
				return _RecommendedParallelizedSubdivisionMinimumFrameCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReferenceBufferCount;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_ReferenceBufferCount'.</summary>
		[Field ("kVTCompressionPropertyKey_ReferenceBufferCount",  "VideoToolbox")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public static NSString ReferenceBufferCount {
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("tvos16.0")]
			get {
				if (_ReferenceBufferCount is null)
					_ReferenceBufferCount = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ReferenceBufferCount")!;
				return _ReferenceBufferCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SourceFrameCount;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_SourceFrameCount",  "VideoToolbox")]
		public static NSString SourceFrameCount {
			get {
				if (_SourceFrameCount is null)
					_SourceFrameCount = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_SourceFrameCount")!;
				return _SourceFrameCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpatialAdaptiveQPLevel;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_SpatialAdaptiveQPLevel'.</summary>
		[Field ("kVTCompressionPropertyKey_SpatialAdaptiveQPLevel",  "VideoToolbox")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString SpatialAdaptiveQPLevel {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos15.0")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_SpatialAdaptiveQPLevel is null)
					_SpatialAdaptiveQPLevel = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_SpatialAdaptiveQPLevel")!;
				return _SpatialAdaptiveQPLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StereoCameraBaseline;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_StereoCameraBaseline'.</summary>
		[Field ("kVTCompressionPropertyKey_StereoCameraBaseline",  "VideoToolbox")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString StereoCameraBaseline {
			[SupportedOSPlatform ("ios17.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_StereoCameraBaseline is null)
					_StereoCameraBaseline = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_StereoCameraBaseline")!;
				return _StereoCameraBaseline;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SuggestedLookAheadFrameCount;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_SuggestedLookAheadFrameCount'.</summary>
		[Field ("kVTCompressionPropertyKey_SuggestedLookAheadFrameCount",  "VideoToolbox")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString SuggestedLookAheadFrameCount {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos15.0")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_SuggestedLookAheadFrameCount is null)
					_SuggestedLookAheadFrameCount = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_SuggestedLookAheadFrameCount")!;
				return _SuggestedLookAheadFrameCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SupportedPresetDictionaries;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_SupportedPresetDictionaries'.</summary>
		[Field ("kVTCompressionPropertyKey_SupportedPresetDictionaries",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString SupportedPresetDictionaries {
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_SupportedPresetDictionaries is null)
					_SupportedPresetDictionaries = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_SupportedPresetDictionaries")!;
				return _SupportedPresetDictionaries;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SupportsBaseFrameQP;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_SupportsBaseFrameQP'.</summary>
		[Field ("kVTCompressionPropertyKey_SupportsBaseFrameQP",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SupportsBaseFrameQP {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SupportsBaseFrameQP is null)
					_SupportsBaseFrameQP = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_SupportsBaseFrameQP")!;
				return _SupportsBaseFrameQP;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TargetQualityForAlpha;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_TargetQualityForAlpha'.</summary>
		[Field ("kVTCompressionPropertyKey_TargetQualityForAlpha",  "VideoToolbox")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TargetQualityForAlpha {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TargetQualityForAlpha is null)
					_TargetQualityForAlpha = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_TargetQualityForAlpha")!;
				return _TargetQualityForAlpha;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TransferFunction;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_TransferFunction",  "VideoToolbox")]
		public static NSString TransferFunction {
			get {
				if (_TransferFunction is null)
					_TransferFunction = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_TransferFunction")!;
				return _TransferFunction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UsingGpuRegistryId;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_UsingGPURegistryID'.</summary>
		[Field ("kVTCompressionPropertyKey_UsingGPURegistryID",  "VideoToolbox")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UsingGpuRegistryId {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UsingGpuRegistryId is null)
					_UsingGpuRegistryId = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_UsingGPURegistryID")!;
				return _UsingGpuRegistryId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UsingHardwareAcceleratedVideoEncoder;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_UsingHardwareAcceleratedVideoEncoder",  "VideoToolbox")]
		public static NSString UsingHardwareAcceleratedVideoEncoder {
			get {
				if (_UsingHardwareAcceleratedVideoEncoder is null)
					_UsingHardwareAcceleratedVideoEncoder = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_UsingHardwareAcceleratedVideoEncoder")!;
				return _UsingHardwareAcceleratedVideoEncoder;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VariableBitRate;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_VariableBitRate'.</summary>
		[Field ("kVTCompressionPropertyKey_VariableBitRate",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString VariableBitRate {
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_VariableBitRate is null)
					_VariableBitRate = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_VariableBitRate")!;
				return _VariableBitRate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VbvBufferDuration;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_VBVBufferDuration'.</summary>
		[Field ("kVTCompressionPropertyKey_VBVBufferDuration",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString VbvBufferDuration {
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_VbvBufferDuration is null)
					_VbvBufferDuration = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_VBVBufferDuration")!;
				return _VbvBufferDuration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VbvInitialDelayPercentage;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_VBVInitialDelayPercentage'.</summary>
		[Field ("kVTCompressionPropertyKey_VBVInitialDelayPercentage",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString VbvInitialDelayPercentage {
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_VbvInitialDelayPercentage is null)
					_VbvInitialDelayPercentage = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_VBVInitialDelayPercentage")!;
				return _VbvInitialDelayPercentage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VbvMaxBitRate;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_VBVMaxBitRate'.</summary>
		[Field ("kVTCompressionPropertyKey_VBVMaxBitRate",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString VbvMaxBitRate {
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_VbvMaxBitRate is null)
					_VbvMaxBitRate = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_VBVMaxBitRate")!;
				return _VbvMaxBitRate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VideoEncoderPixelBufferAttributes;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_VideoEncoderPixelBufferAttributes",  "VideoToolbox")]
		public static NSString VideoEncoderPixelBufferAttributes {
			get {
				if (_VideoEncoderPixelBufferAttributes is null)
					_VideoEncoderPixelBufferAttributes = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_VideoEncoderPixelBufferAttributes")!;
				return _VideoEncoderPixelBufferAttributes;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ViewPackingKind;
		/// <summary>Represents the value associated with the constant 'kVTCompressionPropertyKey_ViewPackingKind'.</summary>
		[Field ("kVTCompressionPropertyKey_ViewPackingKind",  "VideoToolbox")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString ViewPackingKind {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_ViewPackingKind is null)
					_ViewPackingKind = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ViewPackingKind")!;
				return _ViewPackingKind;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YCbCrMatrix;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTCompressionPropertyKey_YCbCrMatrix",  "VideoToolbox")]
		public static NSString YCbCrMatrix {
			get {
				if (_YCbCrMatrix is null)
					_YCbCrMatrix = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_YCbCrMatrix")!;
				return _YCbCrMatrix;
			}
		}
	} /* class VTCompressionPropertyKey */
}
