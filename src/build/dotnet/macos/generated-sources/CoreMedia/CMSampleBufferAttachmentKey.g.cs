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
namespace CoreMedia {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CMSampleBufferAttachmentKey : int {
		/// <summary>To be added.</summary>
		NotSync = 0,
		/// <summary>To be added.</summary>
		PartialSync = 1,
		/// <summary>To be added.</summary>
		HasRedundantCoding = 2,
		/// <summary>To be added.</summary>
		IsDependedOnByOthers = 3,
		/// <summary>To be added.</summary>
		DependsOnOthers = 4,
		/// <summary>To be added.</summary>
		EarlierDisplayTimesAllowed = 5,
		/// <summary>To be added.</summary>
		DisplayImmediately = 6,
		/// <summary>To be added.</summary>
		DoNotDisplay = 7,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		HevcTemporalLevelInfo = 8,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		HevcTemporalSubLayerAccess = 9,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		HevcStepwiseTemporalSubLayerAccess = 10,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		HevcSyncSampleNalUnitType = 11,
		/// <summary>To be added.</summary>
		ResetDecoderBeforeDecoding = 12,
		/// <summary>To be added.</summary>
		DrainAfterDecoding = 13,
		/// <summary>To be added.</summary>
		PostNotificationWhenConsumed = 14,
		/// <summary>To be added.</summary>
		ResumeOutput = 15,
		/// <summary>To be added.</summary>
		TransitionId = 16,
		/// <summary>To be added.</summary>
		TrimDurationAtStart = 17,
		/// <summary>To be added.</summary>
		TrimDurationAtEnd = 18,
		/// <summary>To be added.</summary>
		SpeedMultiplier = 19,
		/// <summary>To be added.</summary>
		Reverse = 20,
		/// <summary>To be added.</summary>
		FillDiscontinuitiesWithSilence = 21,
		/// <summary>To be added.</summary>
		EmptyMedia = 22,
		/// <summary>To be added.</summary>
		PermanentEmptyMedia = 23,
		/// <summary>To be added.</summary>
		DisplayEmptyMediaImmediately = 24,
		/// <summary>To be added.</summary>
		EndsPreviousSampleDuration = 25,
		/// <summary>To be added.</summary>
		SampleReferenceUrl = 26,
		/// <summary>To be added.</summary>
		SampleReferenceByteOffset = 27,
		/// <summary>To be added.</summary>
		GradualDecoderRefresh = 28,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		DroppedFrameReason = 29,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		StillImageLensStabilizationInfo = 30,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		CameraIntrinsicMatrix = 31,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		DroppedFrameReasonInfo = 32,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ForceKeyFrame = 33,
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		Hdr10PlusPerFrameData = 34,
	}
	/// <summary>Extension methods for the <see cref="global::CoreMedia.CMSampleBufferAttachmentKey" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CMSampleBufferAttachmentKeyExtensions {
		static IntPtr[] values = new IntPtr [35];
		[Field ("kCMSampleAttachmentKey_NotSync", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleAttachmentKey_NotSync {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_NotSync", storage);
			}
		}
		[Field ("kCMSampleAttachmentKey_PartialSync", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleAttachmentKey_PartialSync {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_PartialSync", storage);
			}
		}
		[Field ("kCMSampleAttachmentKey_HasRedundantCoding", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleAttachmentKey_HasRedundantCoding {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HasRedundantCoding", storage);
			}
		}
		[Field ("kCMSampleAttachmentKey_IsDependedOnByOthers", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleAttachmentKey_IsDependedOnByOthers {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_IsDependedOnByOthers", storage);
			}
		}
		[Field ("kCMSampleAttachmentKey_DependsOnOthers", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleAttachmentKey_DependsOnOthers {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_DependsOnOthers", storage);
			}
		}
		[Field ("kCMSampleAttachmentKey_EarlierDisplayTimesAllowed", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleAttachmentKey_EarlierDisplayTimesAllowed {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_EarlierDisplayTimesAllowed", storage);
			}
		}
		[Field ("kCMSampleAttachmentKey_DisplayImmediately", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleAttachmentKey_DisplayImmediately {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_DisplayImmediately", storage);
			}
		}
		[Field ("kCMSampleAttachmentKey_DoNotDisplay", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleAttachmentKey_DoNotDisplay {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_DoNotDisplay", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCMSampleAttachmentKey_HEVCTemporalLevelInfo", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleAttachmentKey_HEVCTemporalLevelInfo {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCTemporalLevelInfo", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_DrainAfterDecoding", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_DrainAfterDecoding {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_DrainAfterDecoding", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_ResumeOutput", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_ResumeOutput {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_ResumeOutput", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_TransitionID", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_TransitionID {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_TransitionID", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_TrimDurationAtStart", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_TrimDurationAtStart {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_TrimDurationAtStart", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_TrimDurationAtEnd", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_TrimDurationAtEnd {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_TrimDurationAtEnd", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_SpeedMultiplier", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_SpeedMultiplier {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_SpeedMultiplier", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_Reverse", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_Reverse {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_Reverse", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_EmptyMedia", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_EmptyMedia {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_EmptyMedia", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_PermanentEmptyMedia", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_PermanentEmptyMedia {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_PermanentEmptyMedia", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_SampleReferenceURL", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_SampleReferenceURL {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_SampleReferenceURL", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_SampleReferenceByteOffset", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_SampleReferenceByteOffset {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_SampleReferenceByteOffset", storage);
			}
		}
		[Field ("kCMSampleBufferAttachmentKey_GradualDecoderRefresh", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_GradualDecoderRefresh {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_GradualDecoderRefresh", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCMSampleBufferAttachmentKey_DroppedFrameReason", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_DroppedFrameReason {
			get {
				fixed (IntPtr *storage = &values [29])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_DroppedFrameReason", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCMSampleBufferAttachmentKey_StillImageLensStabilizationInfo", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_StillImageLensStabilizationInfo {
			get {
				fixed (IntPtr *storage = &values [30])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_StillImageLensStabilizationInfo", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix {
			get {
				fixed (IntPtr *storage = &values [31])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCMSampleBufferAttachmentKey_DroppedFrameReasonInfo", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_DroppedFrameReasonInfo {
			get {
				fixed (IntPtr *storage = &values [32])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_DroppedFrameReasonInfo", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCMSampleBufferAttachmentKey_ForceKeyFrame", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleBufferAttachmentKey_ForceKeyFrame {
			get {
				fixed (IntPtr *storage = &values [33])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_ForceKeyFrame", storage);
			}
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[Field ("kCMSampleAttachmentKey_HDR10PlusPerFrameData", "CoreMedia")]
		internal unsafe static IntPtr kCMSampleAttachmentKey_HDR10PlusPerFrameData {
			get {
				fixed (IntPtr *storage = &values [34])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HDR10PlusPerFrameData", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CMSampleBufferAttachmentKey self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CMSampleBufferAttachmentKey.NotSync
				ptr = kCMSampleAttachmentKey_NotSync;
				break;
			case 1: // CMSampleBufferAttachmentKey.PartialSync
				ptr = kCMSampleAttachmentKey_PartialSync;
				break;
			case 2: // CMSampleBufferAttachmentKey.HasRedundantCoding
				ptr = kCMSampleAttachmentKey_HasRedundantCoding;
				break;
			case 3: // CMSampleBufferAttachmentKey.IsDependedOnByOthers
				ptr = kCMSampleAttachmentKey_IsDependedOnByOthers;
				break;
			case 4: // CMSampleBufferAttachmentKey.DependsOnOthers
				ptr = kCMSampleAttachmentKey_DependsOnOthers;
				break;
			case 5: // CMSampleBufferAttachmentKey.EarlierDisplayTimesAllowed
				ptr = kCMSampleAttachmentKey_EarlierDisplayTimesAllowed;
				break;
			case 6: // CMSampleBufferAttachmentKey.DisplayImmediately
				ptr = kCMSampleAttachmentKey_DisplayImmediately;
				break;
			case 7: // CMSampleBufferAttachmentKey.DoNotDisplay
				ptr = kCMSampleAttachmentKey_DoNotDisplay;
				break;
			case 8: // CMSampleBufferAttachmentKey.HevcTemporalLevelInfo
				ptr = kCMSampleAttachmentKey_HEVCTemporalLevelInfo;
				break;
			case 9: // CMSampleBufferAttachmentKey.HevcTemporalSubLayerAccess
				ptr = kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess;
				break;
			case 10: // CMSampleBufferAttachmentKey.HevcStepwiseTemporalSubLayerAccess
				ptr = kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess;
				break;
			case 11: // CMSampleBufferAttachmentKey.HevcSyncSampleNalUnitType
				ptr = kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType;
				break;
			case 12: // CMSampleBufferAttachmentKey.ResetDecoderBeforeDecoding
				ptr = kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding;
				break;
			case 13: // CMSampleBufferAttachmentKey.DrainAfterDecoding
				ptr = kCMSampleBufferAttachmentKey_DrainAfterDecoding;
				break;
			case 14: // CMSampleBufferAttachmentKey.PostNotificationWhenConsumed
				ptr = kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed;
				break;
			case 15: // CMSampleBufferAttachmentKey.ResumeOutput
				ptr = kCMSampleBufferAttachmentKey_ResumeOutput;
				break;
			case 16: // CMSampleBufferAttachmentKey.TransitionId
				ptr = kCMSampleBufferAttachmentKey_TransitionID;
				break;
			case 17: // CMSampleBufferAttachmentKey.TrimDurationAtStart
				ptr = kCMSampleBufferAttachmentKey_TrimDurationAtStart;
				break;
			case 18: // CMSampleBufferAttachmentKey.TrimDurationAtEnd
				ptr = kCMSampleBufferAttachmentKey_TrimDurationAtEnd;
				break;
			case 19: // CMSampleBufferAttachmentKey.SpeedMultiplier
				ptr = kCMSampleBufferAttachmentKey_SpeedMultiplier;
				break;
			case 20: // CMSampleBufferAttachmentKey.Reverse
				ptr = kCMSampleBufferAttachmentKey_Reverse;
				break;
			case 21: // CMSampleBufferAttachmentKey.FillDiscontinuitiesWithSilence
				ptr = kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence;
				break;
			case 22: // CMSampleBufferAttachmentKey.EmptyMedia
				ptr = kCMSampleBufferAttachmentKey_EmptyMedia;
				break;
			case 23: // CMSampleBufferAttachmentKey.PermanentEmptyMedia
				ptr = kCMSampleBufferAttachmentKey_PermanentEmptyMedia;
				break;
			case 24: // CMSampleBufferAttachmentKey.DisplayEmptyMediaImmediately
				ptr = kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately;
				break;
			case 25: // CMSampleBufferAttachmentKey.EndsPreviousSampleDuration
				ptr = kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration;
				break;
			case 26: // CMSampleBufferAttachmentKey.SampleReferenceUrl
				ptr = kCMSampleBufferAttachmentKey_SampleReferenceURL;
				break;
			case 27: // CMSampleBufferAttachmentKey.SampleReferenceByteOffset
				ptr = kCMSampleBufferAttachmentKey_SampleReferenceByteOffset;
				break;
			case 28: // CMSampleBufferAttachmentKey.GradualDecoderRefresh
				ptr = kCMSampleBufferAttachmentKey_GradualDecoderRefresh;
				break;
			case 29: // CMSampleBufferAttachmentKey.DroppedFrameReason
				ptr = kCMSampleBufferAttachmentKey_DroppedFrameReason;
				break;
			case 30: // CMSampleBufferAttachmentKey.StillImageLensStabilizationInfo
				ptr = kCMSampleBufferAttachmentKey_StillImageLensStabilizationInfo;
				break;
			case 31: // CMSampleBufferAttachmentKey.CameraIntrinsicMatrix
				ptr = kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix;
				break;
			case 32: // CMSampleBufferAttachmentKey.DroppedFrameReasonInfo
				ptr = kCMSampleBufferAttachmentKey_DroppedFrameReasonInfo;
				break;
			case 33: // CMSampleBufferAttachmentKey.ForceKeyFrame
				ptr = kCMSampleBufferAttachmentKey_ForceKeyFrame;
				break;
			case 34: // CMSampleBufferAttachmentKey.Hdr10PlusPerFrameData
				ptr = kCMSampleAttachmentKey_HDR10PlusPerFrameData;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMSampleBufferAttachmentKey" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CMSampleBufferAttachmentKey GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCMSampleAttachmentKey_NotSync))
				return CMSampleBufferAttachmentKey.NotSync;
			if (constant.IsEqualTo (kCMSampleAttachmentKey_PartialSync))
				return CMSampleBufferAttachmentKey.PartialSync;
			if (constant.IsEqualTo (kCMSampleAttachmentKey_HasRedundantCoding))
				return CMSampleBufferAttachmentKey.HasRedundantCoding;
			if (constant.IsEqualTo (kCMSampleAttachmentKey_IsDependedOnByOthers))
				return CMSampleBufferAttachmentKey.IsDependedOnByOthers;
			if (constant.IsEqualTo (kCMSampleAttachmentKey_DependsOnOthers))
				return CMSampleBufferAttachmentKey.DependsOnOthers;
			if (constant.IsEqualTo (kCMSampleAttachmentKey_EarlierDisplayTimesAllowed))
				return CMSampleBufferAttachmentKey.EarlierDisplayTimesAllowed;
			if (constant.IsEqualTo (kCMSampleAttachmentKey_DisplayImmediately))
				return CMSampleBufferAttachmentKey.DisplayImmediately;
			if (constant.IsEqualTo (kCMSampleAttachmentKey_DoNotDisplay))
				return CMSampleBufferAttachmentKey.DoNotDisplay;
			if (constant.IsEqualTo (kCMSampleAttachmentKey_HEVCTemporalLevelInfo))
				return CMSampleBufferAttachmentKey.HevcTemporalLevelInfo;
			if (constant.IsEqualTo (kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess))
				return CMSampleBufferAttachmentKey.HevcTemporalSubLayerAccess;
			if (constant.IsEqualTo (kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess))
				return CMSampleBufferAttachmentKey.HevcStepwiseTemporalSubLayerAccess;
			if (constant.IsEqualTo (kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType))
				return CMSampleBufferAttachmentKey.HevcSyncSampleNalUnitType;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding))
				return CMSampleBufferAttachmentKey.ResetDecoderBeforeDecoding;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_DrainAfterDecoding))
				return CMSampleBufferAttachmentKey.DrainAfterDecoding;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed))
				return CMSampleBufferAttachmentKey.PostNotificationWhenConsumed;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_ResumeOutput))
				return CMSampleBufferAttachmentKey.ResumeOutput;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_TransitionID))
				return CMSampleBufferAttachmentKey.TransitionId;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_TrimDurationAtStart))
				return CMSampleBufferAttachmentKey.TrimDurationAtStart;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_TrimDurationAtEnd))
				return CMSampleBufferAttachmentKey.TrimDurationAtEnd;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_SpeedMultiplier))
				return CMSampleBufferAttachmentKey.SpeedMultiplier;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_Reverse))
				return CMSampleBufferAttachmentKey.Reverse;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence))
				return CMSampleBufferAttachmentKey.FillDiscontinuitiesWithSilence;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_EmptyMedia))
				return CMSampleBufferAttachmentKey.EmptyMedia;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_PermanentEmptyMedia))
				return CMSampleBufferAttachmentKey.PermanentEmptyMedia;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately))
				return CMSampleBufferAttachmentKey.DisplayEmptyMediaImmediately;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration))
				return CMSampleBufferAttachmentKey.EndsPreviousSampleDuration;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_SampleReferenceURL))
				return CMSampleBufferAttachmentKey.SampleReferenceUrl;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_SampleReferenceByteOffset))
				return CMSampleBufferAttachmentKey.SampleReferenceByteOffset;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_GradualDecoderRefresh))
				return CMSampleBufferAttachmentKey.GradualDecoderRefresh;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_DroppedFrameReason))
				return CMSampleBufferAttachmentKey.DroppedFrameReason;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_StillImageLensStabilizationInfo))
				return CMSampleBufferAttachmentKey.StillImageLensStabilizationInfo;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix))
				return CMSampleBufferAttachmentKey.CameraIntrinsicMatrix;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_DroppedFrameReasonInfo))
				return CMSampleBufferAttachmentKey.DroppedFrameReasonInfo;
			if (constant.IsEqualTo (kCMSampleBufferAttachmentKey_ForceKeyFrame))
				return CMSampleBufferAttachmentKey.ForceKeyFrame;
			if (constant.IsEqualTo (kCMSampleAttachmentKey_HDR10PlusPerFrameData))
				return CMSampleBufferAttachmentKey.Hdr10PlusPerFrameData;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMSampleBufferAttachmentKey" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMSampleBufferAttachmentKey GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMSampleBufferAttachmentKey" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMSampleBufferAttachmentKey? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreMedia.CMSampleBufferAttachmentKey" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CMSampleBufferAttachmentKey[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSString?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="NSString" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="NSString" /> values to convert.</param>
		internal static CMSampleBufferAttachmentKey[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CMSampleBufferAttachmentKey> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
