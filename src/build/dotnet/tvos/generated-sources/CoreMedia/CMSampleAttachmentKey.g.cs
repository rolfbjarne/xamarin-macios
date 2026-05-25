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
namespace CoreMedia {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class CMSampleAttachmentKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AudioIndependentSampleDecoderRefreshCountKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleAttachmentKey_AudioIndependentSampleDecoderRefreshCount'.</summary>
		[Field ("kCMSampleAttachmentKey_AudioIndependentSampleDecoderRefreshCount",  "CoreMedia")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AudioIndependentSampleDecoderRefreshCountKey {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AudioIndependentSampleDecoderRefreshCountKey is null)
					_AudioIndependentSampleDecoderRefreshCountKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_AudioIndependentSampleDecoderRefreshCount")!;
				return _AudioIndependentSampleDecoderRefreshCountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BufferLensStabilizationInfo_Active;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferLensStabilizationInfo_Active'.</summary>
		[Field ("kCMSampleBufferLensStabilizationInfo_Active",  "CoreMedia")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString BufferLensStabilizationInfo_Active {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_BufferLensStabilizationInfo_Active is null)
					_BufferLensStabilizationInfo_Active = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferLensStabilizationInfo_Active")!;
				return _BufferLensStabilizationInfo_Active;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BufferLensStabilizationInfo_Off;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferLensStabilizationInfo_Off'.</summary>
		[Field ("kCMSampleBufferLensStabilizationInfo_Off",  "CoreMedia")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString BufferLensStabilizationInfo_Off {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_BufferLensStabilizationInfo_Off is null)
					_BufferLensStabilizationInfo_Off = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferLensStabilizationInfo_Off")!;
				return _BufferLensStabilizationInfo_Off;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BufferLensStabilizationInfo_OutOfRange;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferLensStabilizationInfo_OutOfRange'.</summary>
		[Field ("kCMSampleBufferLensStabilizationInfo_OutOfRange",  "CoreMedia")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString BufferLensStabilizationInfo_OutOfRange {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_BufferLensStabilizationInfo_OutOfRange is null)
					_BufferLensStabilizationInfo_OutOfRange = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferLensStabilizationInfo_OutOfRange")!;
				return _BufferLensStabilizationInfo_OutOfRange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BufferLensStabilizationInfo_Unavailable;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferLensStabilizationInfo_Unavailable'.</summary>
		[Field ("kCMSampleBufferLensStabilizationInfo_Unavailable",  "CoreMedia")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString BufferLensStabilizationInfo_Unavailable {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_BufferLensStabilizationInfo_Unavailable is null)
					_BufferLensStabilizationInfo_Unavailable = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferLensStabilizationInfo_Unavailable")!;
				return _BufferLensStabilizationInfo_Unavailable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CameraIntrinsicMatrixKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix",  "CoreMedia")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString CameraIntrinsicMatrixKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_CameraIntrinsicMatrixKey is null)
					_CameraIntrinsicMatrixKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix")!;
				return _CameraIntrinsicMatrixKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DependsOnOthers;
		/// <summary>Represents the value associated with the constant 'kCMSampleAttachmentKey_DependsOnOthers'.</summary>
		[Field ("kCMSampleAttachmentKey_DependsOnOthers",  "CoreMedia")]
		public static NSString DependsOnOthers {
			get {
				if (_DependsOnOthers is null)
					_DependsOnOthers = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_DependsOnOthers")!;
				return _DependsOnOthers;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayEmptyMediaImmediately;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately",  "CoreMedia")]
		public static NSString DisplayEmptyMediaImmediately {
			get {
				if (_DisplayEmptyMediaImmediately is null)
					_DisplayEmptyMediaImmediately = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately")!;
				return _DisplayEmptyMediaImmediately;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayImmediately;
		/// <summary>Represents the value associated with the constant 'kCMSampleAttachmentKey_DisplayImmediately'.</summary>
		[Field ("kCMSampleAttachmentKey_DisplayImmediately",  "CoreMedia")]
		public static NSString DisplayImmediately {
			get {
				if (_DisplayImmediately is null)
					_DisplayImmediately = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_DisplayImmediately")!;
				return _DisplayImmediately;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DoNotDisplay;
		/// <summary>Represents the value associated with the constant 'kCMSampleAttachmentKey_DoNotDisplay'.</summary>
		[Field ("kCMSampleAttachmentKey_DoNotDisplay",  "CoreMedia")]
		public static NSString DoNotDisplay {
			get {
				if (_DoNotDisplay is null)
					_DoNotDisplay = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_DoNotDisplay")!;
				return _DoNotDisplay;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DrainAfterDecoding;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_DrainAfterDecoding'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_DrainAfterDecoding",  "CoreMedia")]
		public static NSString DrainAfterDecoding {
			get {
				if (_DrainAfterDecoding is null)
					_DrainAfterDecoding = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_DrainAfterDecoding")!;
				return _DrainAfterDecoding;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DroppedFrameReason;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_DroppedFrameReason'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_DroppedFrameReason",  "CoreMedia")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DroppedFrameReason {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DroppedFrameReason is null)
					_DroppedFrameReason = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_DroppedFrameReason")!;
				return _DroppedFrameReason;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EarlierDisplayTimesAllowed;
		/// <summary>Represents the value associated with the constant 'kCMSampleAttachmentKey_EarlierDisplayTimesAllowed'.</summary>
		[Field ("kCMSampleAttachmentKey_EarlierDisplayTimesAllowed",  "CoreMedia")]
		public static NSString EarlierDisplayTimesAllowed {
			get {
				if (_EarlierDisplayTimesAllowed is null)
					_EarlierDisplayTimesAllowed = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_EarlierDisplayTimesAllowed")!;
				return _EarlierDisplayTimesAllowed;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EmptyMedia;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_EmptyMedia'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_EmptyMedia",  "CoreMedia")]
		public static NSString EmptyMedia {
			get {
				if (_EmptyMedia is null)
					_EmptyMedia = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_EmptyMedia")!;
				return _EmptyMedia;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EndsPreviousSampleDuration;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration",  "CoreMedia")]
		public static NSString EndsPreviousSampleDuration {
			get {
				if (_EndsPreviousSampleDuration is null)
					_EndsPreviousSampleDuration = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration")!;
				return _EndsPreviousSampleDuration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FillDiscontinuitiesWithSilence;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence",  "CoreMedia")]
		public static NSString FillDiscontinuitiesWithSilence {
			get {
				if (_FillDiscontinuitiesWithSilence is null)
					_FillDiscontinuitiesWithSilence = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence")!;
				return _FillDiscontinuitiesWithSilence;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ForceKeyFrameKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_ForceKeyFrame'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_ForceKeyFrame",  "CoreMedia")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ForceKeyFrameKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ForceKeyFrameKey is null)
					_ForceKeyFrameKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_ForceKeyFrame")!;
				return _ForceKeyFrameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GradualDecoderRefreshKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_GradualDecoderRefresh'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_GradualDecoderRefresh",  "CoreMedia")]
		public static NSString GradualDecoderRefreshKey {
			get {
				if (_GradualDecoderRefreshKey is null)
					_GradualDecoderRefreshKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_GradualDecoderRefresh")!;
				return _GradualDecoderRefreshKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HasRedundantCoding;
		/// <summary>Represents the value associated with the constant 'kCMSampleAttachmentKey_HasRedundantCoding'.</summary>
		[Field ("kCMSampleAttachmentKey_HasRedundantCoding",  "CoreMedia")]
		public static NSString HasRedundantCoding {
			get {
				if (_HasRedundantCoding is null)
					_HasRedundantCoding = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HasRedundantCoding")!;
				return _HasRedundantCoding;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Hdr10PlusPerFrameDataKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleAttachmentKey_HDR10PlusPerFrameData'.</summary>
		[Field ("kCMSampleAttachmentKey_HDR10PlusPerFrameData",  "CoreMedia")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static NSString Hdr10PlusPerFrameDataKey {
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				if (_Hdr10PlusPerFrameDataKey is null)
					_Hdr10PlusPerFrameDataKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HDR10PlusPerFrameData")!;
				return _Hdr10PlusPerFrameDataKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HevcStepwiseTemporalSubLayerAccessKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess'.</summary>
		[Field ("kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess",  "CoreMedia")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString HevcStepwiseTemporalSubLayerAccessKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_HevcStepwiseTemporalSubLayerAccessKey is null)
					_HevcStepwiseTemporalSubLayerAccessKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess")!;
				return _HevcStepwiseTemporalSubLayerAccessKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HevcSyncSampleNalUnitTypeKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType'.</summary>
		[Field ("kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType",  "CoreMedia")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString HevcSyncSampleNalUnitTypeKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_HevcSyncSampleNalUnitTypeKey is null)
					_HevcSyncSampleNalUnitTypeKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType")!;
				return _HevcSyncSampleNalUnitTypeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HevcTemporalLevelInfoKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleAttachmentKey_HEVCTemporalLevelInfo'.</summary>
		[Field ("kCMSampleAttachmentKey_HEVCTemporalLevelInfo",  "CoreMedia")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString HevcTemporalLevelInfoKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_HevcTemporalLevelInfoKey is null)
					_HevcTemporalLevelInfoKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCTemporalLevelInfo")!;
				return _HevcTemporalLevelInfoKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HevcTemporalSubLayerAccessKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess'.</summary>
		[Field ("kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess",  "CoreMedia")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString HevcTemporalSubLayerAccessKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_HevcTemporalSubLayerAccessKey is null)
					_HevcTemporalSubLayerAccessKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess")!;
				return _HevcTemporalSubLayerAccessKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsDependedOnByOthers;
		/// <summary>Represents the value associated with the constant 'kCMSampleAttachmentKey_IsDependedOnByOthers'.</summary>
		[Field ("kCMSampleAttachmentKey_IsDependedOnByOthers",  "CoreMedia")]
		public static NSString IsDependedOnByOthers {
			get {
				if (_IsDependedOnByOthers is null)
					_IsDependedOnByOthers = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_IsDependedOnByOthers")!;
				return _IsDependedOnByOthers;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NotSync;
		/// <summary>Represents the value associated with the constant 'kCMSampleAttachmentKey_NotSync'.</summary>
		[Field ("kCMSampleAttachmentKey_NotSync",  "CoreMedia")]
		public static NSString NotSync {
			get {
				if (_NotSync is null)
					_NotSync = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_NotSync")!;
				return _NotSync;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PartialSync;
		/// <summary>Represents the value associated with the constant 'kCMSampleAttachmentKey_PartialSync'.</summary>
		[Field ("kCMSampleAttachmentKey_PartialSync",  "CoreMedia")]
		public static NSString PartialSync {
			get {
				if (_PartialSync is null)
					_PartialSync = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_PartialSync")!;
				return _PartialSync;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PermanentEmptyMedia;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_PermanentEmptyMedia'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_PermanentEmptyMedia",  "CoreMedia")]
		public static NSString PermanentEmptyMedia {
			get {
				if (_PermanentEmptyMedia is null)
					_PermanentEmptyMedia = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_PermanentEmptyMedia")!;
				return _PermanentEmptyMedia;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PostNotificationWhenConsumedKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed",  "CoreMedia")]
		public static NSString PostNotificationWhenConsumedKey {
			get {
				if (_PostNotificationWhenConsumedKey is null)
					_PostNotificationWhenConsumedKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed")!;
				return _PostNotificationWhenConsumedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResetDecoderBeforeDecoding;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding",  "CoreMedia")]
		public static NSString ResetDecoderBeforeDecoding {
			get {
				if (_ResetDecoderBeforeDecoding is null)
					_ResetDecoderBeforeDecoding = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding")!;
				return _ResetDecoderBeforeDecoding;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResumeOutputKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_ResumeOutput'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_ResumeOutput",  "CoreMedia")]
		public static NSString ResumeOutputKey {
			get {
				if (_ResumeOutputKey is null)
					_ResumeOutputKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_ResumeOutput")!;
				return _ResumeOutputKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Reverse;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_Reverse'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_Reverse",  "CoreMedia")]
		public static NSString Reverse {
			get {
				if (_Reverse is null)
					_Reverse = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_Reverse")!;
				return _Reverse;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SampleReferenceByteOffsetKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_SampleReferenceByteOffset'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_SampleReferenceByteOffset",  "CoreMedia")]
		public static NSString SampleReferenceByteOffsetKey {
			get {
				if (_SampleReferenceByteOffsetKey is null)
					_SampleReferenceByteOffsetKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_SampleReferenceByteOffset")!;
				return _SampleReferenceByteOffsetKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SampleReferenceUrlKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_SampleReferenceURL'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_SampleReferenceURL",  "CoreMedia")]
		public static NSString SampleReferenceUrlKey {
			get {
				if (_SampleReferenceUrlKey is null)
					_SampleReferenceUrlKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_SampleReferenceURL")!;
				return _SampleReferenceUrlKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpeedMultiplierKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_SpeedMultiplier'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_SpeedMultiplier",  "CoreMedia")]
		public static NSString SpeedMultiplierKey {
			get {
				if (_SpeedMultiplierKey is null)
					_SpeedMultiplierKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_SpeedMultiplier")!;
				return _SpeedMultiplierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StillImageLensStabilizationInfo;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_StillImageLensStabilizationInfo'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_StillImageLensStabilizationInfo",  "CoreMedia")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString StillImageLensStabilizationInfo {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_StillImageLensStabilizationInfo is null)
					_StillImageLensStabilizationInfo = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_StillImageLensStabilizationInfo")!;
				return _StillImageLensStabilizationInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TransitionIdKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_TransitionID'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_TransitionID",  "CoreMedia")]
		public static NSString TransitionIdKey {
			get {
				if (_TransitionIdKey is null)
					_TransitionIdKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_TransitionID")!;
				return _TransitionIdKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TrimDurationAtEndKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_TrimDurationAtEnd'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_TrimDurationAtEnd",  "CoreMedia")]
		public static NSString TrimDurationAtEndKey {
			get {
				if (_TrimDurationAtEndKey is null)
					_TrimDurationAtEndKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_TrimDurationAtEnd")!;
				return _TrimDurationAtEndKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TrimDurationAtStartKey;
		/// <summary>Represents the value associated with the constant 'kCMSampleBufferAttachmentKey_TrimDurationAtStart'.</summary>
		[Field ("kCMSampleBufferAttachmentKey_TrimDurationAtStart",  "CoreMedia")]
		public static NSString TrimDurationAtStartKey {
			get {
				if (_TrimDurationAtStartKey is null)
					_TrimDurationAtStartKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_TrimDurationAtStart")!;
				return _TrimDurationAtStartKey;
			}
		}
	} /* class CMSampleAttachmentKey */
}
