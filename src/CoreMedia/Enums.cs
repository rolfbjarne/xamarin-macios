
#nullable enable

namespace CoreMedia {
	// keys names got changed at some point, but they all refer to a CMSampleBuffer (there is not CMSample obj)
	[MacCatalyst (13, 1)]
	enum CMSampleBufferAttachmentKey {
		/// <summary>Indicates not sync.</summary>
		[Field ("kCMSampleAttachmentKey_NotSync")]
		NotSync,
		/// <summary>Indicates partial sync.</summary>
		[Field ("kCMSampleAttachmentKey_PartialSync")]
		PartialSync,
		/// <summary>Indicates has redundant coding.</summary>
		[Field ("kCMSampleAttachmentKey_HasRedundantCoding")]
		HasRedundantCoding,
		/// <summary>Indicates is depended on by others.</summary>
		[Field ("kCMSampleAttachmentKey_IsDependedOnByOthers")]
		IsDependedOnByOthers,
		/// <summary>Indicates depends on others.</summary>
		[Field ("kCMSampleAttachmentKey_DependsOnOthers")]
		DependsOnOthers,
		/// <summary>Indicates earlier display times allowed.</summary>
		[Field ("kCMSampleAttachmentKey_EarlierDisplayTimesAllowed")]
		EarlierDisplayTimesAllowed,
		/// <summary>Indicates display immediately.</summary>
		[Field ("kCMSampleAttachmentKey_DisplayImmediately")]
		DisplayImmediately,
		/// <summary>Indicates do not display.</summary>
		[Field ("kCMSampleAttachmentKey_DoNotDisplay")]
		DoNotDisplay,
		/// <summary>Indicates hevc temporal level info.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCMSampleAttachmentKey_HEVCTemporalLevelInfo")]
		HevcTemporalLevelInfo,
		/// <summary>Indicates hevc temporal sub layer access.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess")]
		HevcTemporalSubLayerAccess,
		/// <summary>Indicates hevc stepwise temporal sub layer access.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess")]
		HevcStepwiseTemporalSubLayerAccess,
		/// <summary>Indicates hevc sync sample nal unit type.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType")]
		HevcSyncSampleNalUnitType,
		/// <summary>Indicates reset decoder before decoding.</summary>
		[Field ("kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding")]
		ResetDecoderBeforeDecoding,
		/// <summary>Indicates drain after decoding.</summary>
		[Field ("kCMSampleBufferAttachmentKey_DrainAfterDecoding")]
		DrainAfterDecoding,
		/// <summary>Indicates post notification when consumed.</summary>
		[Field ("kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed")]
		PostNotificationWhenConsumed,
		/// <summary>Indicates resume output.</summary>
		[Field ("kCMSampleBufferAttachmentKey_ResumeOutput")]
		ResumeOutput,
		/// <summary>Indicates transition id.</summary>
		[Field ("kCMSampleBufferAttachmentKey_TransitionID")]
		TransitionId,
		/// <summary>Indicates trim duration at start.</summary>
		[Field ("kCMSampleBufferAttachmentKey_TrimDurationAtStart")]
		TrimDurationAtStart,
		/// <summary>Indicates trim duration at end.</summary>
		[Field ("kCMSampleBufferAttachmentKey_TrimDurationAtEnd")]
		TrimDurationAtEnd,
		/// <summary>Indicates speed multiplier.</summary>
		[Field ("kCMSampleBufferAttachmentKey_SpeedMultiplier")]
		SpeedMultiplier,
		/// <summary>Indicates reverse.</summary>
		[Field ("kCMSampleBufferAttachmentKey_Reverse")]
		Reverse,
		/// <summary>Indicates fill discontinuities with silence.</summary>
		[Field ("kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence")]
		FillDiscontinuitiesWithSilence,
		/// <summary>Indicates empty media.</summary>
		[Field ("kCMSampleBufferAttachmentKey_EmptyMedia")]
		EmptyMedia,
		/// <summary>Indicates permanent empty media.</summary>
		[Field ("kCMSampleBufferAttachmentKey_PermanentEmptyMedia")]
		PermanentEmptyMedia,
		/// <summary>Indicates display empty media immediately.</summary>
		[Field ("kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately")]
		DisplayEmptyMediaImmediately,
		/// <summary>Indicates ends previous sample duration.</summary>
		[Field ("kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration")]
		EndsPreviousSampleDuration,
		/// <summary>Indicates sample reference url.</summary>
		[Field ("kCMSampleBufferAttachmentKey_SampleReferenceURL")]
		SampleReferenceUrl,
		/// <summary>Indicates sample reference byte offset.</summary>
		[Field ("kCMSampleBufferAttachmentKey_SampleReferenceByteOffset")]
		SampleReferenceByteOffset,
		/// <summary>Indicates gradual decoder refresh.</summary>
		[Field ("kCMSampleBufferAttachmentKey_GradualDecoderRefresh")]
		GradualDecoderRefresh,
		/// <summary>Indicates dropped frame reason.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCMSampleBufferAttachmentKey_DroppedFrameReason")]
		DroppedFrameReason,
		/// <summary>Indicates still image lens stabilization info.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCMSampleBufferAttachmentKey_StillImageLensStabilizationInfo")]
		StillImageLensStabilizationInfo,
		/// <summary>Indicates camera intrinsic matrix.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix")]
		CameraIntrinsicMatrix,
		/// <summary>Indicates dropped frame reason info.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCMSampleBufferAttachmentKey_DroppedFrameReasonInfo")]
		DroppedFrameReasonInfo,
		/// <summary>Indicates force key frame.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCMSampleBufferAttachmentKey_ForceKeyFrame")]
		ForceKeyFrame,
		[TV (16, 0), Mac (13, 0), iOS (16, 0)]
		[MacCatalyst (16, 0)]
		[Field ("kCMSampleAttachmentKey_HDR10PlusPerFrameData")]
		Hdr10PlusPerFrameData,
	}
}
