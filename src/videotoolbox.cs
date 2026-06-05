////
// VideoToolbox core types and enumerations
//
// Author: Miguel de Icaza (miguel@xamarin.com)
//         Alex Soto (alex.soto@xamarin.com)
//
// Copyright 2014 Xamarin Inc
//
using System.Collections.Generic;

using AVFoundation;
using CoreGraphics;
using CoreMedia;
using CoreVideo;
using Metal;

namespace VideoToolbox {

	interface VTSession : INativeObject { }
	interface VTDecompressionSession : VTSession { }

	/// <summary>A class that encapsulates keys necessary for compression sessions. Used by <see cref="VideoToolbox.VTCompressionProperties" /></summary>
	[MacCatalyst (13, 1)]
	[Static]
	interface VTCompressionPropertyKey {
		// Buffers

		/// <summary>Gets the NumberOfPendingFrames property key.</summary>
		[Field ("kVTCompressionPropertyKey_NumberOfPendingFrames")]
		NSString NumberOfPendingFrames { get; }

		/// <summary>Gets the PixelBufferPoolIsShared property key.</summary>
		[Field ("kVTCompressionPropertyKey_PixelBufferPoolIsShared")]
		NSString PixelBufferPoolIsShared { get; }

		/// <summary>Gets the VideoEncoderPixelBufferAttributes property key.</summary>
		[Field ("kVTCompressionPropertyKey_VideoEncoderPixelBufferAttributes")]
		NSString VideoEncoderPixelBufferAttributes { get; }

		// Frame dependency

		/// <summary>Gets the MaxKeyFrameInterval property key.</summary>
		[Field ("kVTCompressionPropertyKey_MaxKeyFrameInterval")]
		NSString MaxKeyFrameInterval { get; }

		/// <summary>Gets the MaxKeyFrameIntervalDuration property key.</summary>
		[Field ("kVTCompressionPropertyKey_MaxKeyFrameIntervalDuration")]
		NSString MaxKeyFrameIntervalDuration { get; }

		/// <summary>Gets the AllowTemporalCompression property key.</summary>
		[Field ("kVTCompressionPropertyKey_AllowTemporalCompression")]
		NSString AllowTemporalCompression { get; }

		/// <summary>Gets the AllowFrameReordering property key.</summary>
		[Field ("kVTCompressionPropertyKey_AllowFrameReordering")]
		NSString AllowFrameReordering { get; }

		/// <summary>Gets the AllowOpenGop property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kVTCompressionPropertyKey_AllowOpenGOP")]
		NSString AllowOpenGop { get; }

		// Rate control

		/// <summary>Gets the AverageBitRate property key.</summary>
		[Field ("kVTCompressionPropertyKey_AverageBitRate")]
		NSString AverageBitRate { get; }

		/// <summary>Gets the DataRateLimits property key.</summary>
		[Field ("kVTCompressionPropertyKey_DataRateLimits")]
		NSString DataRateLimits { get; } // NSArray of an even number of CFNumbers alternating [int, double](bytes, seconds] Read/write

		/// <summary>Gets the Quality property key.</summary>
		[Field ("kVTCompressionPropertyKey_Quality")]
		NSString Quality { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kVTCompressionPropertyKey_TargetQualityForAlpha")]
		NSString TargetQualityForAlpha { get; }

		/// <summary>Gets the MoreFramesBeforeStart property key.</summary>
		[Field ("kVTCompressionPropertyKey_MoreFramesBeforeStart")]
		NSString MoreFramesBeforeStart { get; }

		/// <summary>Gets the MoreFramesAfterEnd property key.</summary>
		[Field ("kVTCompressionPropertyKey_MoreFramesAfterEnd")]
		NSString MoreFramesAfterEnd { get; }

		// Bitstream configuration

		/// <summary>Gets the ProfileLevel property key.</summary>
		[Field ("kVTCompressionPropertyKey_ProfileLevel")]
		NSString ProfileLevel { get; }

		/// <summary>Gets the H264EntropyMode property key.</summary>
		[Field ("kVTCompressionPropertyKey_H264EntropyMode")]
		[MacCatalyst (13, 1)]
		NSString H264EntropyMode { get; }

		/// <summary>Gets the Depth property key.</summary>
		[Field ("kVTCompressionPropertyKey_Depth")]
		NSString Depth { get; }

		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
		[Field ("kVTCompressionPropertyKey_PreserveAlphaChannel")]
		NSString PreserveAlphaChannel { get; }

		// Runtime restrictions

		/// <summary>Gets the MaxFrameDelayCount property key.</summary>
		[Field ("kVTCompressionPropertyKey_MaxFrameDelayCount")]
		NSString MaxFrameDelayCount { get; }

		/// <summary>Gets the MaxH264SliceBytes property key.</summary>
		[Field ("kVTCompressionPropertyKey_MaxH264SliceBytes")]
		NSString MaxH264SliceBytes { get; }

		/// <summary>Gets the RealTime property key.</summary>
		[Field ("kVTCompressionPropertyKey_RealTime")]
		[MacCatalyst (13, 1)]
		NSString RealTime { get; }

		/// <summary>Gets the MaximizePowerEfficiency property key.</summary>
		[Field ("kVTCompressionPropertyKey_MaximizePowerEfficiency")]
		[MacCatalyst (13, 1)]
		NSString MaximizePowerEfficiency { get; }

		// Hints

		/// <summary>Gets the SourceFrameCount property key.</summary>
		[Field ("kVTCompressionPropertyKey_SourceFrameCount")]
		NSString SourceFrameCount { get; }

		/// <summary>Gets the ExpectedFrameRate property key.</summary>
		[Field ("kVTCompressionPropertyKey_ExpectedFrameRate")]
		NSString ExpectedFrameRate { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kVTCompressionPropertyKey_MaximumRealTimeFrameRate")]
		NSString MaximumRealTimeFrameRate { get; }

		[TV (14, 5)]
		[iOS (14, 5)]
		[MacCatalyst (14, 5)]
		[Field ("kVTCompressionPropertyKey_BaseLayerFrameRateFraction")]
		NSString BaseLayerFrameRateFraction { get; }

		/// <summary>Gets the ExpectedDuration property key.</summary>
		[Field ("kVTCompressionPropertyKey_ExpectedDuration")]
		NSString ExpectedDuration { get; }

		/// <summary>Gets the BaseLayerFrameRate property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kVTCompressionPropertyKey_BaseLayerFrameRate")]
		NSString BaseLayerFrameRate { get; }

		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
		[Field ("kVTCompressionPropertyKey_ReferenceBufferCount")]
		NSString ReferenceBufferCount { get; }

		[Mac (14, 4), iOS (17, 4), TV (17, 4), MacCatalyst (17, 4)]
		[Field ("kVTCompressionPropertyKey_CalculateMeanSquaredError")]
		NSString CalculateMeanSquaredError { get; }

		// Hardware acceleration
		// Hardware acceleration is default behavior on iOS. No opt-in required.

		/// <summary>Gets the UsingHardwareAcceleratedVideoEncoder property key.</summary>
		[Field ("kVTCompressionPropertyKey_UsingHardwareAcceleratedVideoEncoder")]
		NSString UsingHardwareAcceleratedVideoEncoder { get; } // CFBoolean Read

		// Clean aperture and pixel aspect ratio

		/// <summary>Gets the CleanAperture property key.</summary>
		[Field ("kVTCompressionPropertyKey_CleanAperture")]
		NSString CleanAperture { get; }

		/// <summary>Gets the PixelAspectRatio property key.</summary>
		[Field ("kVTCompressionPropertyKey_PixelAspectRatio")]
		NSString PixelAspectRatio { get; }

		/// <summary>Gets the FieldCount property key.</summary>
		[Field ("kVTCompressionPropertyKey_FieldCount")]
		NSString FieldCount { get; }

		/// <summary>Gets the FieldDetail property key.</summary>
		[Field ("kVTCompressionPropertyKey_FieldDetail")]
		NSString FieldDetail { get; }

		/// <summary>Gets the AspectRatio16x9 property key.</summary>
		[Field ("kVTCompressionPropertyKey_AspectRatio16x9")]
		NSString AspectRatio16x9 { get; }

		/// <summary>Gets the ProgressiveScan property key.</summary>
		[Field ("kVTCompressionPropertyKey_ProgressiveScan")]
		NSString ProgressiveScan { get; }

		// Color

		/// <summary>Gets the ColorPrimaries property key.</summary>
		[Field ("kVTCompressionPropertyKey_ColorPrimaries")]
		NSString ColorPrimaries { get; }

		/// <summary>Gets the TransferFunction property key.</summary>
		[Field ("kVTCompressionPropertyKey_TransferFunction")]
		NSString TransferFunction { get; }

		/// <summary>Gets the YCbCrMatrix property key.</summary>
		[Field ("kVTCompressionPropertyKey_YCbCrMatrix")]
		NSString YCbCrMatrix { get; }

		/// <summary>Gets the ICCProfile property key.</summary>
		[Field ("kVTCompressionPropertyKey_ICCProfile")]
		NSString ICCProfile { get; }

		// AlphaChannelMode

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kVTCompressionPropertyKey_AlphaChannelMode")]
		NSString AlphaChannelMode { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kVTCompressionPropertyKey_GammaLevel")]
		NSString GammaLevel { get; }

		/// <summary>Gets the MasteringDisplayColorVolume property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kVTCompressionPropertyKey_MasteringDisplayColorVolume")]
		NSString MasteringDisplayColorVolume { get; }

		/// <summary>Gets the ContentLightLevelInfo property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kVTCompressionPropertyKey_ContentLightLevelInfo")]
		NSString ContentLightLevelInfo { get; }

		// Pre-compression processing

		/// <summary>Gets the PixelTransferProperties property key.</summary>
		[Field ("kVTCompressionPropertyKey_PixelTransferProperties")]
		NSString PixelTransferProperties { get; }

		// Multi-pass

		/// <summary>Gets the MultiPassStorage property key.</summary>
		[Field ("kVTCompressionPropertyKey_MultiPassStorage")]
		[MacCatalyst (13, 1)]
		NSString MultiPassStorage { get; }

		// Encoder information

		/// <summary>Gets the EncoderId property key.</summary>
		[Field ("kVTCompressionPropertyKey_EncoderID")]
		[MacCatalyst (13, 1)]
		NSString EncoderId { get; }

		[NoiOS, NoTV, NoMacCatalyst, Mac (14, 0)]
		[Field ("kVTCompressionPropertyKey_RecommendedParallelizationLimit")]
		NSString RecommendedParallelizationLimit { get; }

		[iOS (26, 0), TV (26, 0), MacCatalyst (26, 0), Mac (14, 0)]
		[Field ("kVTCompressionPropertyKey_RecommendedParallelizedSubdivisionMinimumFrameCount")]
		NSString RecommendedParallelizedSubdivisionMinimumFrameCount { get; }

		[iOS (26, 0), TV (26, 0), MacCatalyst (26, 0), Mac (14, 0)]
		[Field ("kVTCompressionPropertyKey_RecommendedParallelizedSubdivisionMinimumDuration")]
		NSString RecommendedParallelizedSubdivisionMinimumDuration { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kVTCompressionPropertyKey_UsingGPURegistryID")]
		NSString UsingGpuRegistryId { get; }

		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Field ("kVTCompressionPropertyKey_HDRMetadataInsertionMode")]
		NSString HdrMetadataInsertionMode { get; }

		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Field ("kVTCompressionPropertyKey_PrioritizeEncodingSpeedOverQuality")]
		NSString PrioritizeEncodingSpeedOverQuality { get; }

		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
		[Field ("kVTCompressionPropertyKey_ConstantBitRate")]
		NSString ConstantBitRate { get; }

		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
		[Field ("kVTCompressionPropertyKey_EstimatedAverageBytesPerFrame")]
		NSString EstimatedAverageBytesPerFrame { get; }

		[iOS (14, 1)]
		[TV (14, 2)]
		[MacCatalyst (14, 1)]
		[Field ("kVTCompressionPropertyKey_PreserveDynamicHDRMetadata")]
		NSString PreserveDynamicHdrMetadata { get; }

		[TV (14, 5)]
		[iOS (14, 5)]
		[MacCatalyst (14, 5)]
		[Field ("kVTVideoEncoderSpecification_EnableLowLatencyRateControl")]
		NSString EnableLowLatencyRateControl { get; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("kVTCompressionPropertyKey_BaseLayerBitRateFraction")]
		NSString BaseLayerBitRateFraction { get; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("kVTCompressionPropertyKey_EnableLTR")]
		NSString EnableLtr { get; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("kVTCompressionPropertyKey_MaxAllowedFrameQP")]
		NSString MaxAllowedFrameQP { get; }

		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
		[Field ("kVTCompressionPropertyKey_MinAllowedFrameQP")]
		NSString MinAllowedFrameQP { get; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("kVTCompressionPropertyKey_SupportsBaseFrameQP")]
		NSString SupportsBaseFrameQP { get; }

		[TV (15, 4), Mac (12, 3), iOS (15, 4), MacCatalyst (15, 4)]
		[Field ("kVTCompressionPropertyKey_OutputBitDepth")]
		NSString OutputBitDepth { get; }

		[NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kVTCompressionPropertyKey_ProjectionKind")]
		NSString ProjectionKind { get; }

		[NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kVTCompressionPropertyKey_ViewPackingKind")]
		NSString ViewPackingKind { get; }

		[NoTV, Mac (15, 0), NoiOS, NoMacCatalyst]
		[Field ("kVTCompressionPropertyKey_SuggestedLookAheadFrameCount")]
		NSString SuggestedLookAheadFrameCount { get; }

		[NoTV, Mac (15, 0), NoiOS, NoMacCatalyst]
		[Field ("kVTCompressionPropertyKey_SpatialAdaptiveQPLevel")]
		NSString SpatialAdaptiveQPLevel { get; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Field ("kVTCompressionPropertyKey_MVHEVCVideoLayerIDs")]
		NSString MvHevcVideoLayerIds { get; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Field ("kVTCompressionPropertyKey_MVHEVCViewIDs")]
		NSString MvHevcViewIds { get; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Field ("kVTCompressionPropertyKey_MVHEVCLeftAndRightViewIDs")]
		NSString MvHevcLeftAndRightViewIds { get; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Field ("kVTCompressionPropertyKey_HeroEye")]
		NSString HeroEye { get; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Field ("kVTCompressionPropertyKey_StereoCameraBaseline")]
		NSString StereoCameraBaseline { get; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Field ("kVTCompressionPropertyKey_HorizontalDisparityAdjustment")]
		NSString HorizontalDisparityAdjustment { get; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Field ("kVTCompressionPropertyKey_HasLeftStereoEyeView")]
		NSString HasLeftStereoEyeView { get; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Field ("kVTCompressionPropertyKey_HasRightStereoEyeView")]
		NSString HasRightStereoEyeView { get; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Field ("kVTCompressionPropertyKey_HorizontalFieldOfView")]
		NSString HorizontalFieldOfView { get; }

		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("kVTCompressionPropertyKey_VariableBitRate")]
		NSString VariableBitRate { get; }

		// VBV = Video Buffering Verifier
		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("kVTCompressionPropertyKey_VBVMaxBitRate")]
		NSString VbvMaxBitRate { get; }

		// VBV = Video Buffering Verifier
		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("kVTCompressionPropertyKey_VBVBufferDuration")]
		NSString VbvBufferDuration { get; }

		// VBV = Video Buffering Verifier
		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("kVTCompressionPropertyKey_VBVInitialDelayPercentage")]
		NSString VbvInitialDelayPercentage { get; }

		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("kVTCompressionPropertyKey_CameraCalibrationDataLensCollection")]
		NSString CameraCalibrationDataLensCollection { get; }

		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("kVTCompressionPropertyKey_SupportedPresetDictionaries")]
		NSString SupportedPresetDictionaries { get; }
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[Static]
	interface VTCompressionPresetKey {
		[Field ("kVTCompressionPreset_HighQuality")]
		NSString HighQuality { get; }

		[Field ("kVTCompressionPreset_Balanced")]
		NSString Balanced { get; }

		[Field ("kVTCompressionPreset_HighSpeed")]
		NSString HighSpeed { get; }

		[Field ("kVTCompressionPreset_VideoConferencing")]
		NSString VideoConferencing { get; }
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[StrongDictionary ("VTCompressionPresetKey", Suffix = "")]
	interface VTCompressionPreset {
		// FIXME: investigate stronger typing that NSDictionary
		NSDictionary HighQuality { get; }
		NSDictionary Balanced { get; }
		NSDictionary HighSpeed { get; }
		NSDictionary VideoConferencing { get; }
	}

	[iOS (13, 0), TV (13, 0)]
	[MacCatalyst (13, 1)]
	enum VTAlphaChannelMode {
		[Field ("kVTAlphaChannelMode_StraightAlpha")]
		StraightAlpha,
		[DefaultEnumValue]
		[Field ("kVTAlphaChannelMode_PremultipliedAlpha")]
		PremultipliedAlpha,
	}

	/// <summary>Strongly typed set of options for compression sessions</summary>
	[MacCatalyst (13, 1)]
	[StrongDictionary ("VTCompressionPropertyKey")]
	interface VTCompressionProperties {

		/// <summary>Gets the NumberOfPendingFrames property key.</summary>
		[Export ("NumberOfPendingFrames")]
		int NumberOfPendingFrames { get; }

		/// <summary>Gets the PixelBufferPoolIsShared property key.</summary>
		[Export ("PixelBufferPoolIsShared")]
		bool PixelBufferPoolIsShared { get; }

		/// <summary>Gets the VideoEncoderPixelBufferAttributes property key.</summary>
		[Export ("VideoEncoderPixelBufferAttributes")]
		NSDictionary VideoEncoderPixelBufferAttributes { get; }

		/// <summary>Gets the MaxKeyFrameInterval property key.</summary>
		[Export ("MaxKeyFrameInterval")]
		int MaxKeyFrameInterval { get; set; }

		/// <summary>Gets the MaxKeyFrameIntervalDuration property key.</summary>
		[Export ("MaxKeyFrameIntervalDuration")]
		double MaxKeyFrameIntervalDuration { get; set; }

		/// <summary>Gets the AllowTemporalCompression property key.</summary>
		[Export ("AllowTemporalCompression")]
		bool AllowTemporalCompression { get; set; }

		/// <summary>Gets the AllowFrameReordering property key.</summary>
		[Export ("AllowFrameReordering")]
		bool AllowFrameReordering { get; set; }

		/// <summary>Gets the AllowOpenGop property key.</summary>
		[MacCatalyst (13, 1)]
		[Export ("AllowOpenGop")]
		bool AllowOpenGop { get; set; }

		/// <summary>Gets the AverageBitRate property key.</summary>
		[Export ("AverageBitRate")]
		int AverageBitRate { get; set; }

		/// <summary>Gets the Quality property key.</summary>
		[Export ("Quality")]
		float Quality { get; set; }

		/// <summary>Gets the MoreFramesBeforeStart property key.</summary>
		[Export ("MoreFramesBeforeStart")]
		bool MoreFramesBeforeStart { get; set; }

		/// <summary>Gets the MoreFramesAfterEnd property key.</summary>
		[Export ("MoreFramesAfterEnd")]
		bool MoreFramesAfterEnd { get; set; }

		/// <summary>Gets the Depth property key.</summary>
		[Export ("Depth")]
		CMPixelFormat Depth { get; set; }

		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
		[Export ("PreserveAlphaChannel")]
		bool PreserveAlphaChannel { get; set; }

		/// <summary>Gets the MaxFrameDelayCount property key.</summary>
		[Export ("MaxFrameDelayCount")]
		int MaxFrameDelayCount { get; set; }

		/// <summary>Gets the MaxH264SliceBytes property key.</summary>
		[Export ("MaxH264SliceBytes")]
		int MaxH264SliceBytes { get; set; }

		/// <summary>Gets the RealTime property key.</summary>
		[MacCatalyst (13, 1)]
		[Export ("RealTime")]
		bool RealTime { get; set; }

		/// <summary>Gets the MaximizePowerEfficiency property key.</summary>
		[MacCatalyst (13, 1)]
		[Export ("MaximizePowerEfficiency")]
		bool MaximizePowerEfficiency { get; set; }

		/// <summary>Gets the SourceFrameCount property key.</summary>
		[Export ("SourceFrameCount")]
		uint SourceFrameCount { get; set; }

		/// <summary>Gets the ExpectedFrameRate property key.</summary>
		[Export ("ExpectedFrameRate")]
		double ExpectedFrameRate { get; set; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("MaximumRealTimeFrameRate")]
		double MaximumRealTimeFrameRate { get; }

		/// <summary>Gets the ExpectedDuration property key.</summary>
		[Export ("ExpectedDuration")]
		double ExpectedDuration { get; set; }

		/// <summary>Gets the BaseLayerFrameRate property key.</summary>
		[MacCatalyst (13, 1)]
		[Export ("BaseLayerFrameRate")]
		double BaseLayerFrameRate { get; set; }

		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
		[Export ("ReferenceBufferCount")]
		long ReferenceBufferCount { get; }

		[Mac (14, 4), iOS (17, 4), TV (17, 4), MacCatalyst (17, 4)]
		[Export ("CalculateMeanSquaredError")]
		bool CalculateMeanSquaredError { get; }

		/// <summary>Gets the UsingHardwareAcceleratedVideoEncoder property key.</summary>
		[Export ("UsingHardwareAcceleratedVideoEncoder")]
		bool UsingHardwareAcceleratedVideoEncoder { get; }

		/// <summary>Gets the CleanAperture property key.</summary>
		[Export ("CleanAperture")]
		NSDictionary CleanAperture { get; set; }

		/// <summary>Gets the PixelAspectRatio property key.</summary>
		[Export ("PixelAspectRatio")]
		NSDictionary PixelAspectRatio { get; set; }

		/// <summary>Gets the FieldCount property key.</summary>
		[Export ("FieldCount")]
		VTFieldCount FieldCount { get; set; }

		/// <summary>Gets the AspectRatio16x9 property key.</summary>
		[Export ("AspectRatio16x9")]
		bool AspectRatio16x9 { get; set; }

		/// <summary>Gets the ProgressiveScan property key.</summary>
		[Export ("ProgressiveScan")]
		bool ProgressiveScan { get; set; }

		/// <summary>Gets the ICCProfile property key.</summary>
		[Export ("ICCProfile")]
		NSData ICCProfile { get; set; }

		/// <summary>Gets the MasteringDisplayColorVolume property key.</summary>
		[MacCatalyst (13, 1)]
		[Export ("MasteringDisplayColorVolume")]
		NSData MasteringDisplayColorVolume { get; set; }

		/// <summary>Gets the ContentLightLevelInfo property key.</summary>
		[MacCatalyst (13, 1)]
		[Export ("ContentLightLevelInfo")]
		NSData ContentLightLevelInfo { get; set; }

		/// <summary>Gets the PixelTransferProperties property key.</summary>
		[Export ("PixelTransferProperties")]
		NSDictionary PixelTransferProperties { get; set; }

		/// <summary>Gets the EncoderId property key.</summary>
		[MacCatalyst (13, 1)]
		[Export ("EncoderId")]
		string EncoderId { get; set; }

		[NoiOS, NoTV, NoMacCatalyst, Mac (14, 0)]
		[Export ("RecommendedParallelizationLimit")]
		int RecommendedParallelizationLimit { get; }

		[iOS (26, 0), TV (26, 0), MacCatalyst (26, 0), Mac (14, 0)]
		[Export ("RecommendedParallelizedSubdivisionMinimumFrameCount")]
		ulong RecommendedParallelizedSubdivisionMinimumFrameCount { get; }

		[iOS (26, 0), TV (26, 0), MacCatalyst (26, 0), Mac (14, 0)]
		[Export ("RecommendedParallelizedSubdivisionMinimumDuration")]
		NSDictionary RecommendedParallelizedSubdivisionMinimumDuration { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("TargetQualityForAlpha")]
		float TargetQualityForAlpha { get; set; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("GammaLevel")]
		double GammaLevel { get; set; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("UsingGpuRegistryId")]
		uint UsingGpuRegistryId { get; }

		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
		[Export ("ConstantBitRate")]
		long ConstantBitRate { get; set; }

		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
		[Export ("EstimatedAverageBytesPerFrame")]
		long EstimatedAverageBytesPerFrame { get; }

		[iOS (14, 1)]
		[TV (14, 2)]
		[MacCatalyst (14, 1)]
		[Export ("PreserveDynamicHdrMetadata")]
		bool PreserveDynamicHdrMetadata { get; set; }

		[TV (14, 5)]
		[iOS (14, 5)]
		[MacCatalyst (14, 5)]
		[Export ("EnableLowLatencyRateControl")]
		bool EnableLowLatencyRateControl { get; set; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("BaseLayerBitRateFraction")]
		float BaseLayerBitRateFraction { get; set; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("EnableLtr")]
		bool EnableLtr { get; set; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("MaxAllowedFrameQP")]
		uint MaxAllowedFrameQP { get; set; }

		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
		[Export ("MinAllowedFrameQP")]
		uint MinAllowedFrameQP { get; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("SupportsBaseFrameQP")]
		bool SupportsBaseFrameQP { get; }

		[TV (15, 4), Mac (12, 3), iOS (15, 4), MacCatalyst (15, 4)]
		[Export ("OutputBitDepth")]
		bool OutputBitDepth { get; set; }

		[NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("ProjectionKind")]
#if XAMCORE_5_0
		VTProjectionKind /* NSString */ ProjectionKind { get; }
#else
		CMFormatDescriptionProjectionKind /* NSString */ ProjectionKind { get; }
#endif

		[NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("ViewPackingKind")]
#if XAMCORE_5_0
		VTViewPackingKind /* NSString */ ViewPackingKind { get; }
#else
		CMFormatDescriptionViewPackingKind /* NSString */ ViewPackingKind { get; }
#endif

		[NoTV, Mac (15, 0), NoiOS, NoMacCatalyst]
		[Export ("SuggestedLookAheadFrameCount")]
		nint /* NSNumber */ SuggestedLookAheadFrameCount { get; }

		[NoTV, Mac (15, 0), NoiOS, NoMacCatalyst]
		[Export ("SpatialAdaptiveQPLevel")]
		VTQPModulationLevel /* NSNumber */ SpatialAdaptiveQPLevel { get; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Export ("MvHevcVideoLayerIds")]
		NSNumber [] MvHevcVideoLayerIds { get; set; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Export ("MvHevcViewIds")]
		NSNumber [] MvHevcViewIds { get; set; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Export ("MvHevcLeftAndRightViewIds")]
		NSNumber [] MvHevcLeftAndRightViewIds { get; set; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Export ("HeroEye")]
#if XAMCORE_5_0
		VTHeroEye HeroEye { get; }
#else
		[Obsolete ("Use the strongly typed 'VTHeroEye' instead.")]
		string HeroEye { get; }
#endif

#if !XAMCORE_6_0
#if XAMCORE_5_0
		[Obsolete ("Use 'HeroEye' instead.")]
#endif
		[NoTV, MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Export ("HeroEye")]
		VTHeroEye VTHeroEye { get; }
#endif

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Export ("StereoCameraBaseline")]
		uint StereoCameraBaseline { get; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Export ("HorizontalDisparityAdjustment")]
		int HorizontalDisparityAdjustment { get; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Export ("HasLeftStereoEyeView")]
		bool HasLeftStereoEyeView { get; set; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Export ("HasRightStereoEyeView")]
		bool HasRightStereoEyeView { get; set; }

		[iOS (17, 0), NoTV, MacCatalyst (17, 0), Mac (14, 0)]
		[Export ("HorizontalFieldOfView")]
		uint HorizontalFieldOfView { get; set; }

		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Export ("VariableBitRate")]
		uint VariableBitRate { get; set; }

		// VBV = Video Buffering Verifier
		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Export ("VbvMaxBitRate")]
		uint VbvMaxBitRate { get; set; }

		// VBV = Video Buffering Verifier
		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Export ("VbvBufferDuration")]
		float VbvBufferDuration { get; set; }

		// VBV = Video Buffering Verifier
		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Export ("VbvInitialDelayPercentage")]
		float VbvInitialDelayPercentage { get; set; }

		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Export ("CameraCalibrationDataLensCollection")]
		VTCompressionPropertyCameraCalibration [] CameraCalibrationDataLensCollection { get; set; }

		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Export ("SupportedPresetDictionaries")]
		VTCompressionPreset SupportedPresetDictionaries { get; }
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	enum VTCameraCalibrationLensAlgorithmKind {
		[Field ("kVTCameraCalibrationLensAlgorithmKind_ParametricLens")]
		ParametricLens,
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	enum VTCameraCalibrationLensDomain {
		[Field ("kVTCameraCalibrationLensDomain_Color")]
		Color,
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	enum VTCameraCalibrationLensRole {
		[Field ("kVTCameraCalibrationLensRole_Mono")]
		Mono,

		[Field ("kVTCameraCalibrationLensRole_Left")]
		Left,

		[Field ("kVTCameraCalibrationLensRole_Right")]
		Right,
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	enum VTCameraCalibrationExtrinsicOriginSource {
		[Field ("kVTCameraCalibrationExtrinsicOriginSource_StereoCameraSystemBaseline")]
		StereoCameraSystemBaseline,
	}

	// There's an almost identical mirror of this class in CoreMedia (as CMCompressionPropertyCameraCalibrationKey),
	// which should probably be updated if this class is updated.
	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[Static]
	interface VTCompressionPropertyCameraCalibrationKey {
		[Field ("kVTCompressionPropertyCameraCalibrationKey_LensAlgorithmKind")]
		NSString LensAlgorithmKind { get; } // VTCameraCalibrationLensAlgorithmKind

		[Field ("kVTCompressionPropertyCameraCalibrationKey_LensDomain")]
		NSString LensDomain { get; } // VTCameraCalibrationLensDomain

		[Field ("kVTCompressionPropertyCameraCalibrationKey_LensIdentifier")]
		NSString LensIdentifier { get; } // int

		[Field ("kVTCompressionPropertyCameraCalibrationKey_LensRole")]
		NSString LensRole { get; } // kVTCameraCalibrationLensRole

		[Field ("kVTCompressionPropertyCameraCalibrationKey_LensDistortions")]
		NSString LensDistortions { get; } // float[]

		[Field ("kVTCompressionPropertyCameraCalibrationKey_RadialAngleLimit")]
		NSString RadialAngleLimit { get; } // float

		[Field ("kVTCompressionPropertyCameraCalibrationKey_LensFrameAdjustmentsPolynomialX")]
		NSString LensFrameAdjustmentsPolynomialX { get; } // float[]

		[Field ("kVTCompressionPropertyCameraCalibrationKey_LensFrameAdjustmentsPolynomialY")]
		NSString LensFrameAdjustmentsPolynomialY { get; } // float[]

		[Field ("kVTCompressionPropertyCameraCalibrationKey_IntrinsicMatrix")]
		NSString IntrinsicMatrix { get; }

		[Field ("kVTCompressionPropertyCameraCalibrationKey_IntrinsicMatrixProjectionOffset")]
		NSString IntrinsicMatrixProjectionOffset { get; } // float

		[Field ("kVTCompressionPropertyCameraCalibrationKey_IntrinsicMatrixReferenceDimensions")]
		NSString IntrinsicMatrixReferenceDimensions { get; } // "CGSize dictionary" = ??

		[Field ("kVTCompressionPropertyCameraCalibrationKey_ExtrinsicOriginSource")]
		NSString ExtrinsicOriginSource { get; } // VTCameraCalibrationExtrinsicOriginSource

		[Field ("kVTCompressionPropertyCameraCalibrationKey_ExtrinsicOrientationQuaternion")]
		NSString ExtrinsicOrientationQuaternion { get; } // float[]

		// There's an almost identical mirror of this class in CoreMedia (as CMCompressionPropertyCameraCalibrationKey),
		// which should probably be updated if this class is updated.
	}

	// There's an almost identical mirror of this class in CoreMedia (as CMCompressionPropertyCameraCalibrationKey),
	// which should probably be updated if this class is updated.
	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[StrongDictionary ("VTCompressionPropertyCameraCalibrationKey", Suffix = "")]
	interface VTCompressionPropertyCameraCalibration {
		VTCameraCalibrationLensAlgorithmKind LensAlgorithmKind { get; set; }
		VTCameraCalibrationLensDomain LensDomain { get; set; }
		int LensIdentifier { get; set; }
		VTCameraCalibrationLensRole LensRole { get; set; }
		float [] LensDistortions { get; set; } // CFArray[CFNumber(float)]
		float RadialAngleLimit { get; set; }
		float [] LensFrameAdjustmentsPolynomialX { get; set; } // CFArray[CFNumber(float)]
		float [] LensFrameAdjustmentsPolynomialY { get; set; } // CFArray[CFNumber(float)]
		NMatrix3 IntrinsicMatrix { get; set; }
		float IntrinsicMatrixProjectionOffset { get; set; }
		CGSizeDictionary IntrinsicMatrixReferenceDimensions { get; set; }
		VTCameraCalibrationExtrinsicOriginSource ExtrinsicOriginSource { get; set; }
		float [] ExtrinsicOrientationQuaternion { get; set; } // CFArray[CFNumber(float)]

		// There's an almost identical mirror of this class in CoreMedia (as CMCompressionPropertyCameraCalibrationKey),
		// which should probably be updated if this class is updated.
	}

	[NoTV, MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	enum VTHeroEye {
		[Field ("kVTHeroEye_Left")]
		Left,

		[Field ("kVTHeroEye_Right")]
		Right,
	}

	[NoTV, MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	enum VTProjectionKind {
		[Field ("kVTProjectionKind_Rectilinear")]
		Rectilinear,

		[Field ("kVTProjectionKind_Equirectangular")]
		Equirectangular,

		[Field ("kVTProjectionKind_HalfEquirectangular")]
		HalfEquirectangular,

		[Field ("kVTProjectionKind_ParametricImmersive")]
		ParametricImmersive,
	}

	[NoTV, MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	enum VTViewPackingKind {
		[Field ("kVTViewPackingKind_SideBySide")]
		SideBySide,

		[Field ("kVTViewPackingKind_OverUnder")]
		OverUnder,
	}

	[NoTV, Mac (15, 0), NoiOS, NoMacCatalyst]
	public enum VTQPModulationLevel {
		Default = -1,
		Disable = 0,
	}

	/// <summary>A class that encapsulates keys necessary by <see cref="VideoToolbox.VTProfileLevel" />.</summary>
	[MacCatalyst (13, 1)]
	[Static]
	interface VTProfileLevelKeys {
		// HEVC

		/// <summary>Gets the Hevc_Main_AutoLevel property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kVTProfileLevel_HEVC_Main_AutoLevel")]
		NSString Hevc_Main_AutoLevel { get; }

		/// <summary>Gets the Hevc_Main10_AutoLevel property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kVTProfileLevel_HEVC_Main10_AutoLevel")]
		NSString Hevc_Main10_AutoLevel { get; }

		[TV (15, 4), Mac (12, 3), iOS (15, 4), MacCatalyst (15, 4)]
		[Field ("kVTProfileLevel_HEVC_Main42210_AutoLevel")]
		NSString Hevc_Main42210_AutoLevel { get; }

		[Field ("kVTProfileLevel_HEVC_Monochrome_AutoLevel")]
		NSString Hevc_Monochrome_AutoLevel { get; }

		[TV (13, 0), iOS (13, 0), MacCatalyst (13, 0)]
		[Field ("kVTProfileLevel_HEVC_Monochrome10_AutoLevel")]
		NSString Hevc_Monochrome10_AutoLevel { get; }

		// H264

		/// <summary>The key for H.264, baseline profile, level 1.3.</summary>
		[Field ("kVTProfileLevel_H264_Baseline_1_3")]
		NSString H264_Baseline_1_3 { get; }

		/// <summary>The key for H.264, baseline profile, level 3.0.</summary>
		[Field ("kVTProfileLevel_H264_Baseline_3_0")]
		NSString H264_Baseline_3_0 { get; }

		/// <summary>The key for H.264, baseline profile, level 3.1.</summary>
		[Field ("kVTProfileLevel_H264_Baseline_3_1")]
		NSString H264_Baseline_3_1 { get; }

		/// <summary>The key for H.264, baseline profile, level 3.2.</summary>
		[Field ("kVTProfileLevel_H264_Baseline_3_2")]
		NSString H264_Baseline_3_2 { get; }

		/// <summary>The key for H.264, baseline profile, level 4.0.</summary>
		[Field ("kVTProfileLevel_H264_Baseline_4_0")]
		[MacCatalyst (13, 1)]
		NSString H264_Baseline_4_0 { get; }

		/// <summary>The key for H.264, baseline profile, level 4.1.</summary>
		[Field ("kVTProfileLevel_H264_Baseline_4_1")]
		NSString H264_Baseline_4_1 { get; }

		/// <summary>The key for H.264, baseline profile, level 4.2.</summary>
		[Field ("kVTProfileLevel_H264_Baseline_4_2")]
		[MacCatalyst (13, 1)]
		NSString H264_Baseline_4_2 { get; }

		/// <summary>The key for H.264, baseline profile, level 5.0.</summary>
		[Field ("kVTProfileLevel_H264_Baseline_5_0")]
		[MacCatalyst (13, 1)]
		NSString H264_Baseline_5_0 { get; }

		/// <summary>The key for H.264, baseline profile, level 5.1.</summary>
		[Field ("kVTProfileLevel_H264_Baseline_5_1")]
		[MacCatalyst (13, 1)]
		NSString H264_Baseline_5_1 { get; }

		/// <summary>The key for H.264, baseline profile, level 5.2.</summary>
		[Field ("kVTProfileLevel_H264_Baseline_5_2")]
		[MacCatalyst (13, 1)]
		NSString H264_Baseline_5_2 { get; }

		/// <summary>The key for H.264, baseline profile, with automatically determined level.</summary>
		[Field ("kVTProfileLevel_H264_Baseline_AutoLevel")]
		[MacCatalyst (13, 1)]
		NSString H264_Baseline_AutoLevel { get; }

		/// <summary>The key for H.264, main profile, level 3.0.</summary>
		[Field ("kVTProfileLevel_H264_Main_3_0")]
		NSString H264_Main_3_0 { get; }

		/// <summary>The key for H.264, main profile, level 3.1.</summary>
		[Field ("kVTProfileLevel_H264_Main_3_1")]
		NSString H264_Main_3_1 { get; }

		/// <summary>The key for H.264, main profile, level 3.2.</summary>
		[Field ("kVTProfileLevel_H264_Main_3_2")]
		NSString H264_Main_3_2 { get; }

		/// <summary>The key for H.264, main profile, level 4.0.</summary>
		[Field ("kVTProfileLevel_H264_Main_4_0")]
		NSString H264_Main_4_0 { get; }

		/// <summary>The key for H.264, main profile, level 4.1.</summary>
		[Field ("kVTProfileLevel_H264_Main_4_1")]
		NSString H264_Main_4_1 { get; }

		/// <summary>The key for H.264, main profile, level 4.2.</summary>
		[Field ("kVTProfileLevel_H264_Main_4_2")]
		[MacCatalyst (13, 1)]
		NSString H264_Main_4_2 { get; }

		/// <summary>The key for H.264, main profile, level 5.0.</summary>
		[Field ("kVTProfileLevel_H264_Main_5_0")]
		NSString H264_Main_5_0 { get; }

		/// <summary>The key for H.264, main profile, level 5.1.</summary>
		[Field ("kVTProfileLevel_H264_Main_5_1")]
		[MacCatalyst (13, 1)]
		NSString H264_Main_5_1 { get; }

		/// <summary>The key for H.264, main profile, level 5.2.</summary>
		[Field ("kVTProfileLevel_H264_Main_5_2")]
		[MacCatalyst (13, 1)]
		NSString H264_Main_5_2 { get; }

		/// <summary>The key for H.264, main profile, with automatically determined level.</summary>
		[Field ("kVTProfileLevel_H264_Main_AutoLevel")]
		[MacCatalyst (13, 1)]
		NSString H264_Main_AutoLevel { get; }

		/// <summary>The key for H.264, extended profile, level 5.0.</summary>
		[Field ("kVTProfileLevel_H264_Extended_5_0")]
		NSString H264_Extended_5_0 { get; }

		/// <summary>The key for H.264, extended profile, with automatically determined level.</summary>
		[Field ("kVTProfileLevel_H264_Extended_AutoLevel")]
		[MacCatalyst (13, 1)]
		NSString H264_Extended_AutoLevel { get; }

		/// <summary>The key for H.264, high profile, level 3.0.</summary>
		[Field ("kVTProfileLevel_H264_High_3_0")]
		[MacCatalyst (13, 1)]
		NSString H264_High_3_0 { get; }

		/// <summary>The key for H.264, high profile, level 3.1.</summary>
		[Field ("kVTProfileLevel_H264_High_3_1")]
		[MacCatalyst (13, 1)]
		NSString H264_High_3_1 { get; }

		/// <summary>The key for H.264, high profile, level 3.2.</summary>
		[Field ("kVTProfileLevel_H264_High_3_2")]
		[MacCatalyst (13, 1)]
		NSString H264_High_3_2 { get; }

		/// <summary>The key for H.264, high profile, level 4.0.</summary>
		[Field ("kVTProfileLevel_H264_High_4_0")]
		[MacCatalyst (13, 1)]
		NSString H264_High_4_0 { get; }

		/// <summary>The key for H.264, high profile, level 4.1.</summary>
		[Field ("kVTProfileLevel_H264_High_4_1")]
		[MacCatalyst (13, 1)]
		NSString H264_High_4_1 { get; }

		/// <summary>The key for H.264, high profile, level 4.2.</summary>
		[Field ("kVTProfileLevel_H264_High_4_2")]
		[MacCatalyst (13, 1)]
		NSString H264_High_4_2 { get; }

		/// <summary>The key for H.264, high profile, level 5.0.</summary>
		[Field ("kVTProfileLevel_H264_High_5_0")]
		NSString H264_High_5_0 { get; }

		/// <summary>The key for H.264, high profile, level 5.1.</summary>
		[Field ("kVTProfileLevel_H264_High_5_1")]
		[MacCatalyst (13, 1)]
		NSString H264_High_5_1 { get; }

		/// <summary>The key for H.264, high profile, level 5.2.</summary>
		[Field ("kVTProfileLevel_H264_High_5_2")]
		[MacCatalyst (13, 1)]
		NSString H264_High_5_2 { get; }

		/// <summary>The key for H.264, high profile, with automatically determined level.</summary>
		[Field ("kVTProfileLevel_H264_High_AutoLevel")]
		[MacCatalyst (13, 1)]
		NSString H264_High_AutoLevel { get; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("kVTProfileLevel_H264_ConstrainedBaseline_AutoLevel")]
		NSString H264_ConstrainedBaseline_AutoLevel { get; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("kVTProfileLevel_H264_ConstrainedHigh_AutoLevel")]
		NSString H264_ConstrainedHigh_AutoLevel { get; }

		// MP4V

		/// <summary>The key for MPEG-4 video, simple profile, level 0.</summary>
		[Field ("kVTProfileLevel_MP4V_Simple_L0")]
		NSString MP4V_Simple_L0 { get; }

		/// <summary>The key for MPEG-4 video, simple profile, level 1.</summary>
		[Field ("kVTProfileLevel_MP4V_Simple_L1")]
		NSString MP4V_Simple_L1 { get; }

		/// <summary>The key for MPEG-4 video, simple profile, level 2.</summary>
		[Field ("kVTProfileLevel_MP4V_Simple_L2")]
		NSString MP4V_Simple_L2 { get; }

		/// <summary>The key for MPEG-4 video, simple profile, level 3.</summary>
		[Field ("kVTProfileLevel_MP4V_Simple_L3")]
		NSString MP4V_Simple_L3 { get; }

		/// <summary>The key for MPEG-4 video, main profile, level 2.</summary>
		[Field ("kVTProfileLevel_MP4V_Main_L2")]
		NSString MP4V_Main_L2 { get; }

		/// <summary>The key for MPEG-4 video, main profile, level 3.</summary>
		[Field ("kVTProfileLevel_MP4V_Main_L3")]
		NSString MP4V_Main_L3 { get; }

		/// <summary>The key for MPEG-4 video, main profile, level 4.</summary>
		[Field ("kVTProfileLevel_MP4V_Main_L4")]
		NSString MP4V_Main_L4 { get; }

		/// <summary>The key for MPEG-4 video, advanced simple profile, level 0.</summary>
		[Field ("kVTProfileLevel_MP4V_AdvancedSimple_L0")]
		NSString MP4V_AdvancedSimple_L0 { get; }

		/// <summary>The key for MPEG-4 video, advanced simple profile, level 1.</summary>
		[Field ("kVTProfileLevel_MP4V_AdvancedSimple_L1")]
		NSString MP4V_AdvancedSimple_L1 { get; }

		/// <summary>The key for MPEG-4 video, advanced simple profile, level 2.</summary>
		[Field ("kVTProfileLevel_MP4V_AdvancedSimple_L2")]
		NSString MP4V_AdvancedSimple_L2 { get; }

		/// <summary>The key for MPEG-4 video, advanced simple profile, level 3.</summary>
		[Field ("kVTProfileLevel_MP4V_AdvancedSimple_L3")]
		NSString MP4V_AdvancedSimple_L3 { get; }

		/// <summary>The key for MPEG-4 video, advanced simple profile, level 4.</summary>
		[Field ("kVTProfileLevel_MP4V_AdvancedSimple_L4")]
		NSString MP4V_AdvancedSimple_L4 { get; }

		// H263

		/// <summary>The key for H.263, profile 0, level 1.0.</summary>
		[Field ("kVTProfileLevel_H263_Profile0_Level10")]
		NSString H263_Profile0_Level10 { get; }

		/// <summary>The key for H.263, profile 0, level 4.5.</summary>
		[Field ("kVTProfileLevel_H263_Profile0_Level45")]
		NSString H263_Profile0_Level45 { get; }

		/// <summary>The key for H.263, profile 3, level 4.5.</summary>
		[Field ("kVTProfileLevel_H263_Profile3_Level45")]
		NSString H263_Profile3_Level45 { get; }
	}

	/// <summary>A class that encapsulates keys necessary by <see cref="VideoToolbox.VTH264EntropyMode" />.</summary>
	[Static]
	[MacCatalyst (13, 1)]
	interface VTH264EntropyModeKeys {
		/// <summary>Gets the CAVLC property key.</summary>
		[Field ("kVTH264EntropyMode_CAVLC")]
		NSString CAVLC { get; }

		/// <summary>Gets the CABAC property key.</summary>
		[Field ("kVTH264EntropyMode_CABAC")]
		NSString CABAC { get; }
	}

	/// <summary>Strongly typed representation of a video encoder.</summary>
	[MacCatalyst (13, 1)]
	[StrongDictionary ("VTVideoEncoderSpecificationKeys")]
	interface VTVideoEncoderSpecification {

		/// <summary>Gets the EnableHardwareAcceleratedVideoEncoder property key.</summary>
		[iOS (17, 4), TV (17, 4), MacCatalyst (17, 4)]
		[Export ("EnableHardwareAcceleratedVideoEncoder")]
		bool EnableHardwareAcceleratedVideoEncoder { get; set; }

		/// <summary>Gets the RequireHardwareAcceleratedVideoEncoder property key.</summary>
		[iOS (17, 4), TV (17, 4), MacCatalyst (17, 4)]
		[Export ("RequireHardwareAcceleratedVideoEncoder")]
		bool RequireHardwareAcceleratedVideoEncoder { get; set; }

		/// <summary>Gets the EncoderID property key.</summary>
		[Export ("EncoderID")]
		string EncoderID { get; set; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("RequiredEncoderGpuRegistryId")]
		uint RequiredEncoderGpuRegistryId { get; set; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("PreferredEncoderGpuRegistryId")]
		uint PreferredEncoderGpuRegistryId { get; set; }
	}

	/// <summary>A class that encapsulates keys necessary by <see cref="VideoToolbox.VTVideoEncoderSpecification" />.</summary>
	[MacCatalyst (13, 1)]
	[Static]
	interface VTVideoEncoderSpecificationKeys {

		/// <summary>Gets the EnableHardwareAcceleratedVideoEncoder property key.</summary>
		[Field ("kVTVideoEncoderSpecification_EnableHardwareAcceleratedVideoEncoder")]
		[iOS (17, 4), TV (17, 4), MacCatalyst (17, 4)]
		NSString EnableHardwareAcceleratedVideoEncoder { get; }

		/// <summary>Gets the RequireHardwareAcceleratedVideoEncoder property key.</summary>
		[Field ("kVTVideoEncoderSpecification_RequireHardwareAcceleratedVideoEncoder")]
		[iOS (17, 4), TV (17, 4), MacCatalyst (17, 4)]
		NSString RequireHardwareAcceleratedVideoEncoder { get; }

		/// <summary>Gets the EncoderID property key.</summary>
		[Field ("kVTVideoEncoderSpecification_EncoderID")]
		NSString EncoderID { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kVTVideoEncoderSpecification_RequiredEncoderGPURegistryID")]
		NSString RequiredEncoderGpuRegistryId { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kVTVideoEncoderSpecification_PreferredEncoderGPURegistryID")]
		NSString PreferredEncoderGpuRegistryId { get; }
	}

	/// <summary>Strongly typed set of options.</summary>
	[MacCatalyst (13, 1)]
	[StrongDictionary ("VTEncodeFrameOptionKey")]
	interface VTEncodeFrameOptions {

		/// <summary>Gets the ForceKeyFrame property key.</summary>
		[Export ("ForceKeyFrame")]
		bool ForceKeyFrame { get; set; }
	}

	/// <summary>A class that encapsulates keys necessary by <see cref="VideoToolbox.VTEncodeFrameOptions" /></summary>
	[MacCatalyst (13, 1)]
	[Static]
	interface VTEncodeFrameOptionKey {
		// Per-frame configuration

		/// <summary>Gets the ForceKeyFrame property key.</summary>
		[Field ("kVTEncodeFrameOptionKey_ForceKeyFrame")]
		NSString ForceKeyFrame { get; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("kVTEncodeFrameOptionKey_AcknowledgedLTRTokens")]
		NSString AcknowledgedLtrTokens { get; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("kVTEncodeFrameOptionKey_BaseFrameQP")]
		NSString BaseFrameQP { get; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("kVTEncodeFrameOptionKey_ForceLTRRefresh")]
		NSString ForceLtrRefresh { get; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("kVTSampleAttachmentKey_RequireLTRAcknowledgementToken")]
		NSString RequireLtrAcknowledgementToken { get; }
	}

	[Static]
	interface VTSampleAttachmentKey {
		[TV (15, 0), Mac (12, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("kVTSampleAttachmentKey_RequireLTRAcknowledgementToken")]
		NSString RequireLtrAcknowledgementToken { get; }

		[iOS (17, 4), TV (17, 4), Mac (14, 4), MacCatalyst (17, 4)]
		[Field ("kVTSampleAttachmentKey_QualityMetrics")]
		NSString QualityMetrics { get; }
	}

	[Static]
	[iOS (17, 4), TV (17, 4), Mac (14, 4), MacCatalyst (17, 4)]
	interface VTSampleAttachmentQualityMetricsKey {
		[Field ("kVTSampleAttachmentQualityMetricsKey_LumaMeanSquaredError")]
		NSString LumaMeanSquaredError { get; }

		[Field ("kVTSampleAttachmentQualityMetricsKey_ChromaBlueMeanSquaredError")]
		NSString ChromaBlueMeanSquaredError { get; }

		[Field ("kVTSampleAttachmentQualityMetricsKey_ChromaRedMeanSquaredError")]
		NSString ChromaRedMeanSquaredError { get; }
	}

	/// <summary>A class that encapsulates keys necessary for decompression sessions. Used by <see cref="VideoToolbox.VTDecompressionProperties" /></summary>
	[MacCatalyst (13, 1)]
	[Static]
	interface VTDecompressionPropertyKey {
		// Pixel buffer pools

		/// <summary>Gets the PixelBufferPool property key.</summary>
		[Field ("kVTDecompressionPropertyKey_PixelBufferPool")]
		NSString PixelBufferPool { get; }

		/// <summary>Gets the PixelBufferPoolIsShared property key.</summary>
		[Field ("kVTDecompressionPropertyKey_PixelBufferPoolIsShared")]
		NSString PixelBufferPoolIsShared { get; }

		/// <summary>Gets the OutputPoolRequestedMinimumBufferCount property key.</summary>
		[Field ("kVTDecompressionPropertyKey_OutputPoolRequestedMinimumBufferCount")]
		[MacCatalyst (13, 1)]
		NSString OutputPoolRequestedMinimumBufferCount { get; }

		// Asynchronous state

		/// <summary>Gets the NumberOfFramesBeingDecoded property key.</summary>
		[Field ("kVTDecompressionPropertyKey_NumberOfFramesBeingDecoded")]
		NSString NumberOfFramesBeingDecoded { get; }

		/// <summary>Gets the MinOutputPresentationTimeStampOfFramesBeingDecoded property key.</summary>
		[Field ("kVTDecompressionPropertyKey_MinOutputPresentationTimeStampOfFramesBeingDecoded")]
		NSString MinOutputPresentationTimeStampOfFramesBeingDecoded { get; }

		/// <summary>Gets the MaxOutputPresentationTimeStampOfFramesBeingDecoded property key.</summary>
		[Field ("kVTDecompressionPropertyKey_MaxOutputPresentationTimeStampOfFramesBeingDecoded")]
		NSString MaxOutputPresentationTimeStampOfFramesBeingDecoded { get; }

		// Content

		/// <summary>Gets the ContentHasInterframeDependencies property key.</summary>
		[Field ("kVTDecompressionPropertyKey_ContentHasInterframeDependencies")]
		NSString ContentHasInterframeDependencies { get; }

		// Hardware acceleration
		// hardware acceleration is default behavior on iOS.  no opt-in required.

		/// <summary>Gets the UsingHardwareAcceleratedVideoDecoder property key.</summary>
		[Field ("kVTDecompressionPropertyKey_UsingHardwareAcceleratedVideoDecoder")]
		[MacCatalyst (13, 1)]
		NSString UsingHardwareAcceleratedVideoDecoder { get; }

		// Decoder behavior

		/// <summary>Gets the RealTime property key.</summary>
		[Field ("kVTDecompressionPropertyKey_RealTime")]
		[MacCatalyst (13, 1)]
		NSString RealTime { get; }

		/// <summary>Gets the MaximizePowerEfficiency property key.</summary>
		[Field ("kVTDecompressionPropertyKey_MaximizePowerEfficiency")]
		[MacCatalyst (13, 1)]
		NSString MaximizePowerEfficiency { get; }

		/// <summary>Gets the ThreadCount property key.</summary>
		[Field ("kVTDecompressionPropertyKey_ThreadCount")]
		NSString ThreadCount { get; }

		/// <summary>Gets the FieldMode property key.</summary>
		[Field ("kVTDecompressionPropertyKey_FieldMode")]
		NSString FieldMode { get; }

		/// <summary>Gets the FieldMode_BothFields property key.</summary>
		[Field ("kVTDecompressionProperty_FieldMode_BothFields")]
		NSString FieldMode_BothFields { get; }

		/// <summary>Gets the FieldMode_TopFieldOnly property key.</summary>
		[Field ("kVTDecompressionProperty_FieldMode_TopFieldOnly")]
		NSString FieldMode_TopFieldOnly { get; }

		/// <summary>Gets the FieldMode_BottomFieldOnly property key.</summary>
		[Field ("kVTDecompressionProperty_FieldMode_BottomFieldOnly")]
		NSString FieldMode_BottomFieldOnly { get; }

		/// <summary>Gets the FieldMode_SingleField property key.</summary>
		[Field ("kVTDecompressionProperty_FieldMode_SingleField")]
		NSString FieldMode_SingleField { get; }

		/// <summary>Gets the FieldMode_DeinterlaceFields property key.</summary>
		[Field ("kVTDecompressionProperty_FieldMode_DeinterlaceFields")]
		NSString FieldMode_DeinterlaceFields { get; }

		/// <summary>Gets the DeinterlaceMode property key.</summary>
		[Field ("kVTDecompressionPropertyKey_DeinterlaceMode")]
		NSString DeinterlaceMode { get; }

		/// <summary>Gets the DeinterlaceMode_VerticalFilter property key.</summary>
		[Field ("kVTDecompressionProperty_DeinterlaceMode_VerticalFilter")]
		NSString DeinterlaceMode_VerticalFilter { get; }

		/// <summary>Gets the DeinterlaceMode_Temporal property key.</summary>
		[Field ("kVTDecompressionProperty_DeinterlaceMode_Temporal")]
		NSString DeinterlaceMode_Temporal { get; }

		/// <summary>Gets the ReducedResolutionDecode property key.</summary>
		[Field ("kVTDecompressionPropertyKey_ReducedResolutionDecode")]
		NSString ReducedResolutionDecode { get; }

		/// <summary>Gets the ReducedCoefficientDecode property key.</summary>
		[Field ("kVTDecompressionPropertyKey_ReducedCoefficientDecode")]
		NSString ReducedCoefficientDecode { get; }

		/// <summary>Gets the ReducedFrameDelivery property key.</summary>
		[Field ("kVTDecompressionPropertyKey_ReducedFrameDelivery")]
		NSString ReducedFrameDelivery { get; }

		/// <summary>Gets the OnlyTheseFrames property key.</summary>
		[Field ("kVTDecompressionPropertyKey_OnlyTheseFrames")]
		NSString OnlyTheseFrames { get; }

		/// <summary>Gets the OnlyTheseFrames_AllFrames property key.</summary>
		[Field ("kVTDecompressionProperty_OnlyTheseFrames_AllFrames")]
		NSString OnlyTheseFrames_AllFrames { get; }

		/// <summary>Gets the OnlyTheseFrames_NonDroppableFrames property key.</summary>
		[Field ("kVTDecompressionProperty_OnlyTheseFrames_NonDroppableFrames")]
		NSString OnlyTheseFrames_NonDroppableFrames { get; }

		/// <summary>Gets the OnlyTheseFrames_IFrames property key.</summary>
		[Field ("kVTDecompressionProperty_OnlyTheseFrames_IFrames")]
		NSString OnlyTheseFrames_IFrames { get; }

		/// <summary>Gets the OnlyTheseFrames_KeyFrames property key.</summary>
		[Field ("kVTDecompressionProperty_OnlyTheseFrames_KeyFrames")]
		NSString OnlyTheseFrames_KeyFrames { get; }

		/// <summary>Gets the TemporalLevelLimit property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kVTDecompressionProperty_TemporalLevelLimit")]
		NSString TemporalLevelLimit { get; }

		/// <summary>Gets the SuggestedQualityOfServiceTiers property key.</summary>
		[Field ("kVTDecompressionPropertyKey_SuggestedQualityOfServiceTiers")]
		NSString SuggestedQualityOfServiceTiers { get; }

		/// <summary>Gets the SupportedPixelFormatsOrderedByQuality property key.</summary>
		[Field ("kVTDecompressionPropertyKey_SupportedPixelFormatsOrderedByQuality")]
		NSString SupportedPixelFormatsOrderedByQuality { get; }

		/// <summary>Gets the SupportedPixelFormatsOrderedByPerformance property key.</summary>
		[Field ("kVTDecompressionPropertyKey_SupportedPixelFormatsOrderedByPerformance")]
		NSString SupportedPixelFormatsOrderedByPerformance { get; }

		/// <summary>Gets the PixelFormatsWithReducedResolutionSupport property key.</summary>
		[Field ("kVTDecompressionPropertyKey_PixelFormatsWithReducedResolutionSupport")]
		NSString PixelFormatsWithReducedResolutionSupport { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kVTDecompressionPropertyKey_UsingGPURegistryID")]
		NSString UsingGpuRegistryId { get; }

		//Post-decompression processing

		/// <summary>Gets the PixelTransferProperties property key.</summary>
		[Field ("kVTDecompressionPropertyKey_PixelTransferProperties")]
		NSString PixelTransferProperties { get; }

		[iOS (14, 1)]
		[TV (14, 2)]
		[MacCatalyst (14, 1)]
		[Field ("kVTDecompressionPropertyKey_PropagatePerFrameHDRDisplayMetadata")]
		NSString PropagatePerFrameHdrDisplayMetadata { get; }

		[iOS (17, 0), TV (17, 0), MacCatalyst (17, 0), Mac (14, 0)]
		[Field ("kVTDecompressionPropertyKey_GeneratePerFrameHDRDisplayMetadata")]
		NSString GeneratePerFrameHdrDisplayMetadata { get; }

		[iOS (18, 0), TV (18, 0), MacCatalyst (18, 0), Mac (15, 0)]
		[Field ("kVTDecompressionPropertyKey_AllowBitstreamToChangeFrameDimensions")]
		NSString AllowBitstreamToChangeFrameDimensions { get; }

		[NoiOS, NoTV, NoMacCatalyst, Mac (15, 0)]
		[Field ("kVTDecompressionPropertyKey_DecoderProducesRAWOutput")]
		NSString DecoderProducesRawOutput { get; }

		[NoiOS, NoTV, NoMacCatalyst, Mac (15, 0)]
		[Field ("kVTDecompressionPropertyKey_RequestRAWOutput")]
		NSString RequestRawWOutput { get; }

		[iOS (17, 0), NoTV, Mac (14, 0), MacCatalyst (17, 0)]
		[Field ("kVTDecompressionPropertyKey_RequestedMVHEVCVideoLayerIDs")]
		NSString RequestedMvHevcVideoLayerIds { get; }
	}

	/// <summary>Strongly typed set of options for decompression sessions.</summary>
	[MacCatalyst (13, 1)]
	[StrongDictionary ("VTDecompressionPropertyKey")]
	interface VTDecompressionProperties {

		/// <summary>Gets the PixelBufferPoolIsShared property key.</summary>
		[Export ("PixelBufferPoolIsShared")]
		bool PixelBufferPoolIsShared { get; }

		/// <summary>Gets the OutputPoolRequestedMinimumBufferCount property key.</summary>
		[Export ("OutputPoolRequestedMinimumBufferCount")]
		uint OutputPoolRequestedMinimumBufferCount { get; set; }

		/// <summary>Gets the NumberOfFramesBeingDecoded property key.</summary>
		[Export ("NumberOfFramesBeingDecoded")]
		uint NumberOfFramesBeingDecoded { get; }

		/// <summary>Gets the MinOutputPresentationTimeStampOfFramesBeingDecoded property key.</summary>
		[Export ("MinOutputPresentationTimeStampOfFramesBeingDecoded")]
		NSDictionary MinOutputPresentationTimeStampOfFramesBeingDecoded { get; }

		/// <summary>Gets the MaxOutputPresentationTimeStampOfFramesBeingDecoded property key.</summary>
		[Export ("MaxOutputPresentationTimeStampOfFramesBeingDecoded")]
		NSDictionary MaxOutputPresentationTimeStampOfFramesBeingDecoded { get; }

		/// <summary>Gets the ContentHasInterframeDependencies property key.</summary>
		[Export ("ContentHasInterframeDependencies")]
		bool ContentHasInterframeDependencies { get; }

		// Hardware acceleration
		// hardware acceleration is default behavior on iOS.  no opt-in required.

		/// <summary>Gets the UsingHardwareAcceleratedVideoDecoder property key.</summary>
		[Export ("UsingHardwareAcceleratedVideoDecoder")]
		[MacCatalyst (13, 1)]
		bool UsingHardwareAcceleratedVideoDecoder { get; }

		/// <summary>Gets the RealTime property key.</summary>
		[MacCatalyst (13, 1)]
		[Export ("RealTime")]
		bool RealTime { get; set; }

		/// <summary>Gets the MaximizePowerEfficiency property key.</summary>
		[MacCatalyst (13, 1)]
		[Export ("MaximizePowerEfficiency")]
		bool MaximizePowerEfficiency { get; set; }

		/// <summary>Gets the ThreadCount property key.</summary>
		[Export ("ThreadCount")]
		uint ThreadCount { get; set; }

		/// <summary>Gets the ReducedResolutionDecode property key.</summary>
		[StrongDictionary]
		[Export ("ReducedResolutionDecode")]
		VTDecompressionResolutionOptions ReducedResolutionDecode { get; set; }

		/// <summary>Gets the ReducedCoefficientDecode property key.</summary>
		[Export ("ReducedCoefficientDecode")]
		uint ReducedCoefficientDecode { get; set; }

		/// <summary>Gets the ReducedFrameDelivery property key.</summary>
		[Export ("ReducedFrameDelivery")]
		float ReducedFrameDelivery { get; set; }

		/// <summary>Gets the TemporalLevelLimit property key.</summary>
		[MacCatalyst (13, 1)]
		[Export ("TemporalLevelLimit")]
		int TemporalLevelLimit { get; set; }

		/// <summary>Gets the SuggestedQualityOfServiceTiers property key.</summary>
		[Export ("SuggestedQualityOfServiceTiers")]
		NSDictionary [] SuggestedQualityOfServiceTiers { get; }

		/// <summary>Gets the SupportedPixelFormatsOrderedByQuality property key.</summary>
		[Export ("SupportedPixelFormatsOrderedByQuality")]
		CMPixelFormat [] SupportedPixelFormatsOrderedByQuality { get; }

		/// <summary>Gets the SupportedPixelFormatsOrderedByPerformance property key.</summary>
		[Export ("SupportedPixelFormatsOrderedByPerformance")]
		CMPixelFormat [] SupportedPixelFormatsOrderedByPerformance { get; }

		/// <summary>Gets the PixelFormatsWithReducedResolutionSupport property key.</summary>
		[Export ("PixelFormatsWithReducedResolutionSupport")]
		CMPixelFormat [] PixelFormatsWithReducedResolutionSupport { get; }

		/// <summary>Gets the PixelTransferProperties property key.</summary>
		[Advice ("Use Strongly typed version PixelTransferSettings")]
		[Export ("PixelTransferProperties")]
		NSDictionary PixelTransferProperties { get; set; }

		// VTPixelTransferProperties are available in iOS 9 radar://22614931 https://trello.com/c/bTl6hRu9
		/// <summary>Gets the PixelTransferSettings property key.</summary>
		[StrongDictionary]
		[MacCatalyst (13, 1)]
		[Export ("PixelTransferProperties")]
		VTPixelTransferProperties PixelTransferSettings { get; set; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("UsingGpuRegistryId")]
		uint UsingGpuRegistryId { get; }

		[iOS (14, 1)]
		[TV (14, 2)]
		[MacCatalyst (14, 1)]
		[Export ("PropagatePerFrameHdrDisplayMetadata")]
#if XAMCORE_5_0
		bool PropagatePerFrameHdrDisplayMetadata { get; set; }
#else
		bool PropagatePerFrameHhrDisplayMetadata { get; set; }
#endif

		[Export ("GeneratePerFrameHdrDisplayMetadata")]
		[iOS (17, 0), TV (17, 0), MacCatalyst (17, 0), Mac (14, 0)]
		bool GeneratePerFrameHdrDisplayMetadata { get; }

		[Export ("AllowBitstreamToChangeFrameDimensions")]
		[iOS (18, 0), TV (18, 0), MacCatalyst (18, 0), Mac (15, 0)]
		bool AllowBitstreamToChangeFrameDimensions { get; }

		[Export ("DecoderProducesRawOutput")]
		[NoiOS, NoTV, NoMacCatalyst, Mac (15, 0)]
		bool DecoderProducesRawOutput { get; }

		[Export ("RequestRawWOutput")]
		[NoiOS, NoTV, NoMacCatalyst, Mac (15, 0)]
		bool RequestRawWOutput { get; }

		[iOS (17, 0), NoTV, Mac (14, 0), MacCatalyst (17, 0)]
		[Export ("RequestedMvHevcVideoLayerIds")]
		NSNumber [] RequestedMvHevcVideoLayerIds { get; }
	}

	/// <summary>Strongly typed set of options.</summary>
	[MacCatalyst (13, 1)]
	[StrongDictionary ("VTVideoDecoderSpecificationKeys")]
	interface VTVideoDecoderSpecification {
		/// <summary>Gets the EnableHardwareAcceleratedVideoDecoder property key.</summary>
		[Export ("EnableHardwareAcceleratedVideoDecoder")]
		bool EnableHardwareAcceleratedVideoDecoder { get; set; }

		/// <summary>Gets the RequireHardwareAcceleratedVideoDecoder property key.</summary>
		[Export ("RequireHardwareAcceleratedVideoDecoder")]
		bool RequireHardwareAcceleratedVideoDecoder { get; set; }

		/// <summary>Gets the RequiredDecoderGpuRegistryId property key.</summary>
		[Export ("RequiredDecoderGpuRegistryId")]
		NSNumber RequiredDecoderGpuRegistryId { get; }

		/// <summary>Gets the PreferredDecoderGpuRegistryId property key.</summary>
		[Export ("PreferredDecoderGpuRegistryId")]
		NSNumber PreferredDecoderGpuRegistryId { get; }
	}

	/// <summary>A class that encapsulates keys necessary by <see cref="VideoToolbox.VTVideoDecoderSpecification" />.</summary>
	[MacCatalyst (13, 1)]
	[Static]
	interface VTVideoDecoderSpecificationKeys {
		/// <summary>Gets the EnableHardwareAcceleratedVideoDecoder property key.</summary>
		[Field ("kVTVideoDecoderSpecification_EnableHardwareAcceleratedVideoDecoder")]
		NSString EnableHardwareAcceleratedVideoDecoder { get; }

		/// <summary>Gets the RequireHardwareAcceleratedVideoDecoder property key.</summary>
		[Field ("kVTVideoDecoderSpecification_RequireHardwareAcceleratedVideoDecoder")]
		NSString RequireHardwareAcceleratedVideoDecoder { get; }

		/// <summary>Gets the RequiredDecoderGpuRegistryId property key.</summary>
		[Field ("kVTVideoDecoderSpecification_RequiredDecoderGPURegistryID")]
		NSString RequiredDecoderGpuRegistryId { get; }

		/// <summary>Gets the PreferredDecoderGpuRegistryId property key.</summary>
		[Field ("kVTVideoDecoderSpecification_PreferredDecoderGPURegistryID")]
		NSString PreferredDecoderGpuRegistryId { get; }
	}

	/// <summary>Strongly typed set of options used by <see cref="VideoToolbox.VTDecompressionProperties.ReducedResolutionDecode" />.</summary>
	[MacCatalyst (13, 1)]
	[StrongDictionary ("VTDecompressionResolutionKeys")]
	interface VTDecompressionResolutionOptions {
		/// <summary>Gets the Width property key.</summary>
		[Export ("Width")]
		float Width { get; set; }

		/// <summary>Gets the Height property key.</summary>
		[Export ("Height")]
		float Height { get; set; }
	}

	/// <summary>A class that encapsulates keys necessary by <see cref="VideoToolbox.VTEncodeFrameOptions" />.</summary>
	[MacCatalyst (13, 1)]
	[Static]
	interface VTDecompressionResolutionKeys {
		/// <summary>Gets the Width property key.</summary>
		[Field ("kVTDecompressionResolutionKey_Width")]
		NSString Width { get; }

		/// <summary>Gets the Height property key.</summary>
		[Field ("kVTDecompressionResolutionKey_Height")]
		NSString Height { get; }
	}

	// VTSession.h
	/// <summary>Strongly typed set of options.</summary>
	[MacCatalyst (13, 1)]
	[StrongDictionary ("VTPropertyKeys")]
	interface VTPropertyOptions {
		/// <summary>Gets the ShouldBeSerialized property key.</summary>
		[Export ("ShouldBeSerialized")]
		bool ShouldBeSerialized { get; set; }

		/// <summary>Gets the SupportedValueMinimum property key.</summary>
		[Export ("SupportedValueMinimumKey")]
		NSNumber SupportedValueMinimum { get; set; }

		/// <summary>Gets the SupportedValueMaximum property key.</summary>
		[Export ("SupportedValueMaximumKey")]
		NSNumber SupportedValueMaximum { get; set; }

		/// <summary>Gets the SupportedValueList property key.</summary>
		[Export ("SupportedValueListKey")]
		NSNumber [] SupportedValueList { get; set; }

		/// <summary>Gets the Documentation property key.</summary>
		[Export ("DocumentationKey")]
		NSString Documentation { get; set; }
	}

	/// <summary>A class that encapsulates keys necessary by <see cref="VideoToolbox.VTPropertyOptions" />.</summary>
	[MacCatalyst (13, 1)]
	[Static]
	interface VTPropertyKeys {
		/// <summary>Gets the Type property key.</summary>
		[Field ("kVTPropertyTypeKey")]
		NSString Type { get; }

		/// <summary>Gets the ReadWriteStatus property key.</summary>
		[Field ("kVTPropertyReadWriteStatusKey")]
		NSString ReadWriteStatus { get; }

		/// <summary>Gets the ShouldBeSerialized property key.</summary>
		[Field ("kVTPropertyShouldBeSerializedKey")]
		NSString ShouldBeSerialized { get; }

		/// <summary>Gets the SupportedValueMinimumKey property key.</summary>
		[Field ("kVTPropertySupportedValueMinimumKey")]
		NSString SupportedValueMinimumKey { get; }

		/// <summary>Gets the SupportedValueMaximumKey property key.</summary>
		[Field ("kVTPropertySupportedValueMaximumKey")]
		NSString SupportedValueMaximumKey { get; }

		/// <summary>Gets the SupportedValueListKey property key.</summary>
		[Field ("kVTPropertySupportedValueListKey")]
		NSString SupportedValueListKey { get; }

		/// <summary>Gets the DocumentationKey property key.</summary>
		[Field ("kVTPropertyDocumentationKey")]
		NSString DocumentationKey { get; }
	}

	/// <summary>A class that encapsulates keys necessary by <see cref="VideoToolbox.VTPropertyType" />.</summary>
	[MacCatalyst (13, 1)]
	[Static]
	interface VTPropertyTypeKeys {
		/// <summary>Gets the Boolean property key.</summary>
		[Field ("kVTPropertyType_Boolean")]
		NSString Boolean { get; }

		/// <summary>Gets the Enumeration property key.</summary>
		[Field ("kVTPropertyType_Enumeration")]
		NSString Enumeration { get; }

		/// <summary>Gets the Number property key.</summary>
		[Field ("kVTPropertyType_Number")]
		NSString Number { get; }
	}

	/// <summary>A class that encapsulates keys necessary by <see cref="VideoToolbox.VTPropertyOptions.ReadWriteStatus" />.</summary>
	[MacCatalyst (13, 1)]
	[Static]
	interface VTPropertyReadWriteStatusKeys {
		/// <summary>Gets the ReadOnly property key.</summary>
		[Field ("kVTPropertyReadWriteStatus_ReadOnly")]
		NSString ReadOnly { get; }

		/// <summary>Gets the ReadWrite property key.</summary>
		[Field ("kVTPropertyReadWriteStatus_ReadWrite")]
		NSString ReadWrite { get; }
	}

	// VTVideoEncoderList.h
	[MacCatalyst (13, 1)]
	[Static]
	[Internal]
	interface VTVideoEncoderList {
		[Field ("kVTVideoEncoderList_CodecName")]
		NSString CodecName { get; }

		[Field ("kVTVideoEncoderList_CodecType")]
		NSString CodecType { get; }

		[Field ("kVTVideoEncoderList_DisplayName")]
		NSString DisplayName { get; }

		[Field ("kVTVideoEncoderList_EncoderID")]
		NSString EncoderID { get; }

		[Field ("kVTVideoEncoderList_EncoderName")]
		NSString EncoderName { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kVTVideoEncoderList_GPURegistryID")]
		NSString GpuRegistryId { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kVTVideoEncoderList_SupportedSelectionProperties")]
		NSString SupportedSelectionProperties { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kVTVideoEncoderList_PerformanceRating")]
		NSString PerformanceRating { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kVTVideoEncoderList_QualityRating")]
		NSString QualityRating { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kVTVideoEncoderList_InstanceLimit")]
		NSString InstanceLimit { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kVTVideoEncoderList_IsHardwareAccelerated")]
		NSString IsHardwareAccelerated { get; }

		[iOS (14, 2)]
		[TV (14, 2)]
		[MacCatalyst (14, 2)]
		[Field ("kVTVideoEncoderList_SupportsFrameReordering")]
		NSString SupportsFrameReordering { get; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("kVTVideoEncoderListOption_IncludeStandardDefinitionDVEncoders")]
		NSString IncludeStandardDefinitionDVEncoders { get; }

		// VTVideoEncoder.cs should be updated when new constants are added here
		// some are missing https://github.com/dotnet/macios/issues/9904
	}

	// VTMultiPassStorage.h
	/// <summary>A class that encapsulates keys necessary by <see cref="VideoToolbox.VTMultiPassStorageCreationOptions" /></summary>
	[MacCatalyst (13, 1)]
	[Static]
	interface VTMultiPassStorageCreationOptionKeys {
		/// <summary>Gets the DoNotDelete property key.</summary>
		[Field ("kVTMultiPassStorageCreationOption_DoNotDelete")]
		NSString DoNotDelete { get; }
	}

	/// <summary>Strongly typed set of options.</summary>
	[MacCatalyst (13, 1)]
	[StrongDictionary ("VTMultiPassStorageCreationOptionKeys")]
	interface VTMultiPassStorageCreationOptions {
		/// <summary>Gets the DoNotDelete property key.</summary>
		[Export ("DoNotDelete")]
		bool DoNotDelete { get; set; }
	}

	// VTPixelTransferProperties are available in iOS 9 radar://22614931 https://trello.com/c/bTl6hRu9
	/// <summary>Strongly typed set of options used by <see cref="VideoToolbox.VTDecompressionProperties.PixelTransferSettings" />.</summary>
	[MacCatalyst (13, 1)]
	[StrongDictionary ("VTPixelTransferPropertyKeys")]
	interface VTPixelTransferProperties {
		/// <summary>Gets the DestinationCleanAperture property key.</summary>
		[StrongDictionary]
		[Export ("DestinationCleanAperture")]
		AVVideoCleanApertureSettings DestinationCleanAperture { get; set; }

		/// <summary>Gets the DestinationPixelAspectRatio property key.</summary>
		[StrongDictionary]
		[Export ("DestinationPixelAspectRatio")]
		AVVideoPixelAspectRatioSettings DestinationPixelAspectRatio { get; set; }

		/// <summary>Gets the DestinationICCProfile property key.</summary>
		[MacCatalyst (13, 1)]
		[Export ("DestinationICCProfile")]
		NSData DestinationICCProfile { get; set; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("RealTime")]
		bool RealTime { get; set; }
	}

	// VTPixelTransferProperties are available in iOS 9 radar://22614931 https://trello.com/c/bTl6hRu9
	/// <summary>A class that encapsulates keys needed by <see cref="VideoToolbox.VTPixelTransferProperties" />.</summary>
	[MacCatalyst (13, 1)]
	[Static]
	[AdvancedAttribute]
	interface VTPixelTransferPropertyKeys {

		// ScalingMode

		/// <summary>Gets the ScalingMode property key.</summary>
		[Field ("kVTPixelTransferPropertyKey_ScalingMode")]
		NSString ScalingMode { get; }

		/// <summary>Gets the ScalingMode_Normal property key.</summary>
		[Field ("kVTScalingMode_Normal")]
		NSString ScalingMode_Normal { get; }

		/// <summary>Gets the ScalingMode_CropSourceToCleanAperture property key.</summary>
		[Field ("kVTScalingMode_CropSourceToCleanAperture")]
		NSString ScalingMode_CropSourceToCleanAperture { get; }

		/// <summary>Gets the ScalingMode_Letterbox property key.</summary>
		[Field ("kVTScalingMode_Letterbox")]
		NSString ScalingMode_Letterbox { get; }

		/// <summary>Gets the ScalingMode_Trim property key.</summary>
		[Field ("kVTScalingMode_Trim")]
		NSString ScalingMode_Trim { get; }

		// DestinationCleanAperture

		/// <summary>Gets the DestinationCleanAperture property key.</summary>
		[Field ("kVTPixelTransferPropertyKey_DestinationCleanAperture")]
		NSString DestinationCleanAperture { get; }

		// DestinationCleanAperture

		/// <summary>Gets the DestinationPixelAspectRatio property key.</summary>
		[Field ("kVTPixelTransferPropertyKey_DestinationPixelAspectRatio")]
		NSString DestinationPixelAspectRatio { get; }

		// DownsamplingMode

		/// <summary>Gets the DownsamplingMode property key.</summary>
		[Field ("kVTPixelTransferPropertyKey_DownsamplingMode")]
		NSString DownsamplingMode { get; }

		/// <summary>Gets the DownsamplingMode_Decimate property key.</summary>
		[Field ("kVTDownsamplingMode_Decimate")]
		NSString DownsamplingMode_Decimate { get; }

		/// <summary>Gets the DownsamplingMode_Average property key.</summary>
		[Field ("kVTDownsamplingMode_Average")]
		NSString DownsamplingMode_Average { get; }

		// DestinationColorPrimaries

		/// <summary>Gets the DestinationColorPrimaries property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kVTPixelTransferPropertyKey_DestinationColorPrimaries")]
		NSString DestinationColorPrimaries { get; }

		// DestinationColorPrimaries

		/// <summary>Gets the DestinationTransferFunction property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kVTPixelTransferPropertyKey_DestinationTransferFunction")]
		NSString DestinationTransferFunction { get; }

		// DestinationICCProfile

		/// <summary>Gets the DestinationICCProfile property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kVTPixelTransferPropertyKey_DestinationICCProfile")]
		NSString DestinationICCProfile { get; }

		// DestinationYCbCrMatrix

		/// <summary>Gets the DestinationYCbCrMatrix property key.</summary>
		[Field ("kVTPixelTransferPropertyKey_DestinationYCbCrMatrix")]
		NSString DestinationYCbCrMatrix { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kVTPixelTransferPropertyKey_RealTime")]
		NSString RealTime { get; }
	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
	[StrongDictionary ("VTPixelRotationPropertyKeys")]
	interface VTPixelRotationProperties {
		[Export ("FlipHorizontalOrientation")]
		bool FlipHorizontalOrientation { get; set; }

		[Export ("FlipVerticalOrientation")]
		bool FlipVerticalOrientation { get; set; }
	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
	[Static]
	[Advanced]
	interface VTPixelRotationPropertyKeys {

		// Rotation

		[Field ("kVTPixelRotationPropertyKey_Rotation")]
		NSString Rotation { get; }

		// FlipHorizontalOrientation

		[Field ("kVTPixelRotationPropertyKey_FlipHorizontalOrientation")]
		NSString FlipHorizontalOrientation { get; }

		// FlipVerticalOrientation

		[Field ("kVTPixelRotationPropertyKey_FlipVerticalOrientation")]
		NSString FlipVerticalOrientation { get; }
	}

	[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	public enum VTHdrPerFrameMetadataGenerationHdrFormatType {
		[Field ("kVTHDRPerFrameMetadataGenerationHDRFormatType_DolbyVision")]
		DolbyVision,
	}

	[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[Static]
	interface VTHdrPerFrameMetadataGenerationOptionsKey {
		[Field ("kVTHDRPerFrameMetadataGenerationOptionsKey_HDRFormats")]
		NSString HdrFormats { get; }

	}

	[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[StrongDictionary ("VTHdrPerFrameMetadataGenerationOptionsKey")]
	interface VTHdrPerFrameMetadataGenerationOptions {
		[Export ("HdrFormats")]
		VTHdrPerFrameMetadataGenerationHdrFormatType HdrFormats { get; set; }
	}

	[NoTV, NoiOS, NoMacCatalyst, Mac (15, 0)]
	[Static]
	interface VTExtensionPropertiesKey {
		[Field ("kVTExtensionProperties_ExtensionIdentifierKey")]
		NSString ExtensionIdentifier { get; }

		[Field ("kVTExtensionProperties_ExtensionNameKey")]
		NSString ExtensionName { get; }

		[Field ("kVTExtensionProperties_ContainingBundleNameKey")]
		NSString ContainingBundleName { get; }

		[Field ("kVTExtensionProperties_ExtensionURLKey")]
		NSString ExtensionUrl { get; }

		[Field ("kVTExtensionProperties_ContainingBundleURLKey")]
		NSString ContainingBundleUrl { get; }

		[Field ("kVTExtensionProperties_CodecNameKey")]
		NSString CodecName { get; }
	}

	[NoTV, NoiOS, NoMacCatalyst, Mac (15, 0)]
	[StrongDictionary ("VTExtensionPropertiesKey")]
	interface VTDecoderExtensionProperties {
		[Export ("ExtensionIdentifier")]
		string ExtensionIdentifier { get; set; }

		[Export ("ExtensionName")]
		string ExtensionName { get; set; }

		[Export ("ContainingBundleName")]
		string ContainingBundleName { get; set; }

		[Export ("ExtensionUrl")]
		NSUrl ExtensionUrl { get; set; }

		[Export ("ContainingBundleUrl")]
		NSUrl ContainingBundleUrl { get; set; }

		[Export ("CodecName")]
		string CodecName { get; set; }
	}

	[NoTV, NoiOS, NoMacCatalyst, Mac (15, 0)]
	[Static]
	interface VTRawProcessingParameterKey {
		[Field ("kVTRAWProcessingParameter_Key")]
		NSString Key { get; }

		[Field ("kVTRAWProcessingParameter_Name")]
		NSString Name { get; }

		[Field ("kVTRAWProcessingParameter_Description")]
		NSString Description { get; }

		[Field ("kVTRAWProcessingParameter_Enabled")]
		NSString Enabled { get; }

		[Field ("kVTRAWProcessingParameter_ValueType")]
		NSString ValueType { get; }

		[Field ("kVTRAWProcessingParameter_ListArray")]
		NSString ListArray { get; }

		[Field ("kVTRAWProcessingParameter_SubGroup")]
		NSString SubGroup { get; }

		[Field ("kVTRAWProcessingParameter_MaximumValue")]
		NSString MaximumValue { get; }

		[Field ("kVTRAWProcessingParameter_MinimumValue")]
		NSString MinimumValue { get; }

		[Field ("kVTRAWProcessingParameter_InitialValue")]
		NSString InitialValue { get; }

		[Field ("kVTRAWProcessingParameter_NeutralValue")]
		NSString NeutralValue { get; }

		[Field ("kVTRAWProcessingParameter_CameraValue")]
		NSString CameraValue { get; }

		[Field ("kVTRAWProcessingParameter_CurrentValue")]
		NSString CurrentValue { get; }
	}

	[NoTV, NoiOS, NoMacCatalyst, Mac (15, 0)]
	[Static]
	interface VTRawProcessingParameterListElementKey {
		[Field ("kVTRAWProcessingParameterListElement_Label")]
		NSString Label { get; }

		[Field ("kVTRAWProcessingParameterListElement_Description")]
		NSString Description { get; }

		[Field ("kVTRAWProcessingParameterListElement_ListElementID")]
		NSString ListElementId { get; }
	}

	[NoTV, NoiOS, NoMacCatalyst, Mac (15, 0)]
	[StrongDictionary ("VTRawProcessingParameterListElementKey")]
	interface VTRawProcessingParametersListElement {
		[Export ("Label")]
		string Label { get; set; }

		[Export ("Description")]
		string Description { get; set; }

		[Export ("ListElementId")]
		nint ListElementId { get; set; }
	}

	[NoTV, NoiOS, NoMacCatalyst, Mac (15, 0)]
	[Static]
	interface VTRawProcessingParameterValueTypeKey {
		[Field ("kVTRAWProcessingParameterValueType_Boolean")]
		NSString Boolean { get; }

		[Field ("kVTRAWProcessingParameterValueType_Integer")]
		NSString Integer { get; }

		[Field ("kVTRAWProcessingParameterValueType_Float")]
		NSString Float { get; }

		[Field ("kVTRAWProcessingParameterValueType_List")]
		NSString List { get; }

		[Field ("kVTRAWProcessingParameterValueType_SubGroup")]
		NSString SubGroup { get; }
	}

	[NoTV, NoiOS, NoMacCatalyst, Mac (15, 0)]
	[StrongDictionary ("VTRawProcessingParameterValueTypeKey")]
	interface VTRawProcessingParameterValueType {
		[Export ("Boolean")]
		bool Boolean { get; set; }

		[Export ("Integer")]
		int Integer { get; set; }

		[Export ("Float")]
		float Float { get; set; }

		[Export ("List")]
		NSObject [] List { get; set; }

		[Export ("SubGroup")]
		NSDictionary SubGroup { get; set; }
	}

	[NoTV, NoiOS, NoMacCatalyst, Mac (15, 0)]
	[StrongDictionary ("VTRawProcessingParameterKey")]
	interface VTRawProcessingParameters {
		[Export ("Key")]
		string Key { get; set; }

		[Export ("Name")]
		string Name { get; set; }

		[Export ("Description")]
		string Description { get; set; }

		[Export ("Enabled")]
		bool Enabled { get; set; }

		[Export ("ValueType")]
		VTRawProcessingParameterValueType ValueType { get; set; }

		// FIXME: Generated code doesn't compile
		// [Export ("ListArray")]
		// VTRawProcessingParametersListElement [] ListArray { get; set; }

		// FIXME: Generated code doesn't compile
		// [Export ("SubGroup")]
		// VTRawProcessingParameters[] SubGroup { get; set; }

		[Export ("MaximumValue")]
		NSObject MaximumValue { get; set; }

		[Export ("MinimumValue")]
		NSObject MinimumValue { get; set; }

		[Export ("InitialValue")]
		NSObject InitialValue { get; set; }

		[Export ("NeutralValue")]
		NSObject NeutralValue { get; set; }

		[Export ("CameraValue")]
		NSObject CameraValue { get; set; }

		[Export ("CurrentValue")]
		NSObject CurrentValue { get; set; }
	}

	[NoTV, NoiOS, NoMacCatalyst, Mac (15, 0)]
	[Static]
	interface VTRawProcessingPropertyKey {
		[Field ("kVTRAWProcessingPropertyKey_MetalDeviceRegistryID")]
		NSString MetalDeviceRegistryId { get; }

		[Field ("kVTRAWProcessingPropertyKey_OutputColorAttachments")]
		NSString OutputColorAttachments { get; }

		[Mac (26, 0)]
		[Field ("kVTRAWProcessingPropertyKey_MetadataForSidecarFile")]
		NSString MetadataForSidecarFile { get; }
	}

	[NoTV, NoiOS, NoMacCatalyst, Mac (15, 0)]
	[StrongDictionary ("VTRawProcessingPropertyKey", Suffix = "")]
	interface VTRawProcessingProperty {
		ulong MetalDeviceRegistryId { get; set; }

		NSDictionary OutputColorAttachments { get; }

		[Mac (26, 0)]
		NSData MetadataForSidecarFile { get; }
	}

	[MacCatalyst (13, 1)]
	[StrongDictionary ("VTSampleAttachmentKey", Suffix = "")]
	interface VTSampleAttachments {
		[TV (15, 0), Mac (12, 0), iOS (15, 0), MacCatalyst (15, 0)]
		NSNumber RequireLtrAcknowledgementToken { get; set; }

		[iOS (17, 4), TV (17, 4), Mac (14, 4), MacCatalyst (17, 4)]
		VTSampleAttachmentQualityMetrics QualityMetrics { get; }
	}

	[StrongDictionary ("VTSampleAttachmentQualityMetricsKey", Suffix = "")]
	[iOS (17, 4), TV (17, 4), Mac (14, 4), MacCatalyst (17, 4)]
	interface VTSampleAttachmentQualityMetrics {
		// This can be either CFNumber or CFArray, so we have to bind it as NSObject
		NSObject LumaMeanSquaredError { get; }

		// This can be either CFNumber or CFArray, so we have to bind it as NSObject
		NSObject ChromaBlueMeanSquaredError { get; }

		// This can be either CFNumber or CFArray, so we have to bind it as NSObject
		NSString ChromaRedMeanSquaredError { get; }
	}

	[MacCatalyst (26, 0), TV (26, 0), iOS (26, 0), Mac (15, 4)]
	[BaseType (typeof (NSObject))]
	interface VTFrameProcessor {
		[Export ("startSessionWithConfiguration:error:")]
		bool StartSession (IVTFrameProcessorConfiguration configuration, [NullAllowed] out NSError error);

		[Export ("processWithParameters:error:")]
		bool Process (IVTFrameProcessorParameters parameters, [NullAllowed] out NSError error);

		[Async]
		[Export ("processWithParameters:completionHandler:")]
		void Process (IVTFrameProcessorParameters parameters, VTFrameProcessorProcessHandler completionHandler);

		[MacCatalyst (26, 0), TV (26, 0), iOS (26, 0), Mac (26, 0)]
		[Export ("processWithParameters:frameOutputHandler:")]
		void Process (IVTFrameProcessorParameters parameters, VTFrameProcessorProcessFrameOutputHandler frameOutputHandler);

		[Export ("processWithCommandBuffer:parameters:")]
		void Process (IMTLCommandBuffer commandBuffer, IVTFrameProcessorParameters parameters);

		[Export ("endSession")]
		void EndSession ();
	}

	delegate void VTFrameProcessorProcessHandler (IVTFrameProcessorParameters parameters, [NullAllowed] NSError error);
	delegate void VTFrameProcessorProcessFrameOutputHandler (IVTFrameProcessorParameters parameters, CMTime presentationTimeStamp, bool isFinalOutput, [NullAllowed] NSError error);

	[MacCatalyst (26, 0), TV (26, 0), iOS (26, 0), Mac (15, 4)]
	[Protocol (BackwardsCompatibleCodeGeneration = false)]
	interface VTFrameProcessorConfiguration {
#if !XAMCORE_5_0
		[NoMacCatalyst, NoTV, NoiOS]
		[Deprecated (PlatformName.MacCatalyst, 26, 0, "Use 'Supported' instead.")]
		[Static, Abstract]
		[Export ("processorSupported")]
		bool ProcessorSupported { get; }
#endif

		[Abstract]
		[Export ("frameSupportedPixelFormats")]
		NSNumber [] WeakFrameSupportedPixelFormats { get; }

		CVPixelFormatType [] FrameSupportedPixelFormats {
			[Wrap ("Array.ConvertAll (this.WeakFrameSupportedPixelFormats, (v) => (CVPixelFormatType) v.UInt32Value);")]
			get;
		}

		[Abstract]
		[Export ("sourcePixelBufferAttributes")]
		NSDictionary WeakSourcePixelBufferAttributes { get; }

		[Wrap ("WeakSourcePixelBufferAttributes")]
		CVPixelBufferAttributes SourcePixelBufferAttributes { get; }

		[Abstract]
		[Export ("destinationPixelBufferAttributes")]
		NSDictionary WeakDestinationPixelBufferAttributes { get; }

		[Wrap ("WeakDestinationPixelBufferAttributes")]
		CVPixelBufferAttributes DestinationPixelBufferAttributes { get; }

		[Export ("nextFrameCount")]
		nint NextFrameCount { get; }

		[Export ("previousFrameCount")]
		nint PreviousFrameCount { get; }

		[Static]
		[Export ("maximumDimensions")]
		CMVideoDimensions MaximumDimensions { get; }

		[Static]
		[Export ("minimumDimensions")]
		CMVideoDimensions MinimumDimensions { get; }
	}

	interface IVTFrameProcessorConfiguration { }

	[MacCatalyst (18, 4), TV (26, 0), iOS (26, 0), Mac (15, 4)]
	[ErrorDomain ("VTFrameProcessorErrorDomain")] // this field is only available in Mac Catalyst for Mac Catalyst 26+
	[Native]
	public enum VTFrameProcessorError : long {
		UnknownError = -19730,
		UnsupportedResolution = -19731,
		SessionNotStarted = -19732,
		SessionAlreadyActive = -19733,
		FatalError = -19734,
		SessionLevelError = -19735,
		InitializationFailed = -19736,
		UnsupportedInput = -19737,
		MemoryAllocationFailure = -19738,
		RevisionNotSupported = -19739,
		ProcessingError = -19740,
		InvalidParameterError = -19741,
		InvalidFrameTiming = -19742,
		AssetDownloadFailed = -19743,
	}

	[MacCatalyst (26, 0), TV (26, 0), iOS (26, 0), Mac (15, 4)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTFrameProcessorFrame {
		[Export ("initWithBuffer:presentationTimeStamp:")]
		NativeHandle Constructor (CVPixelBuffer buffer, CMTime presentationTimeStamp);

		[Export ("buffer")]
		CVPixelBuffer Buffer { get; }

		[Export ("presentationTimeStamp")]
		CMTime PresentationTimeStamp { get; }
	}

	[MacCatalyst (26, 0), TV (26, 0), iOS (26, 0), Mac (15, 4)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTFrameProcessorOpticalFlow {
		[Export ("initWithForwardFlow:backwardFlow:")]
		NativeHandle Constructor (CVPixelBuffer forwardFlow, CVPixelBuffer backwardFlow);

		[Export ("forwardFlow")]
		CVPixelBuffer ForwardFlow { get; }

		[Export ("backwardFlow")]
		CVPixelBuffer BackwardFlow { get; }
	}

	[MacCatalyst (26, 0), TV (26, 0), iOS (26, 0), Mac (15, 4)]
	[Protocol (BackwardsCompatibleCodeGeneration = false)]
	interface VTFrameProcessorParameters {
		[Abstract]
		[Export ("sourceFrame")]
		VTFrameProcessorFrame SourceFrame { get; }

		[MacCatalyst (26, 0), TV (26, 0), iOS (26, 0), Mac (26, 0)]
		[Export ("destinationFrame")]
		VTFrameProcessorFrame DestinationFrame { get; }

		[MacCatalyst (26, 0), TV (26, 0), iOS (26, 0), Mac (26, 0)]
		[Export ("destinationFrames")]
		VTFrameProcessorFrame [] DestinationFrames { get; }
	}

	interface IVTFrameProcessorParameters { }

	[MacCatalyst (18, 4), NoTV, iOS (26, 0), Mac (15, 4)]
	[Native]
	public enum VTFrameRateConversionConfigurationQualityPrioritization : long {
		Normal = 1,
		Quality = 2,
	}

	[MacCatalyst (18, 4), NoTV, iOS (26, 0), Mac (15, 4)]
	[Native]
	public enum VTFrameRateConversionConfigurationRevision : long {
		Revision1 = 1,
	}

	[MacCatalyst (18, 4), NoTV, iOS (26, 0), Mac (15, 4)]
	[Native]
	public enum VTFrameRateConversionParametersSubmissionMode : long {
		Random = 1,
		Sequential = 2,
		SequentialReferencesUnchanged = 3,
	}

	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	[MacCatalyst (18, 4), NoTV, iOS (26, 0), Mac (15, 4)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTFrameRateConversionConfiguration : VTFrameProcessorConfiguration {
		[Export ("initWithFrameWidth:frameHeight:usePrecomputedFlow:qualityPrioritization:revision:")]
		NativeHandle Constructor (nint frameWidth, nint frameHeight, bool usePrecomputedFlow, VTFrameRateConversionConfigurationQualityPrioritization qualityPrioritization, VTFrameRateConversionConfigurationRevision revision);

		[Export ("frameWidth")]
		nint FrameWidth { get; }

		[Export ("frameHeight")]
		nint FrameHeight { get; }

		[Export ("usePrecomputedFlow")]
		bool UsePrecomputedFlow { get; }

		[Export ("qualityPrioritization")]
		VTFrameRateConversionConfigurationQualityPrioritization QualityPrioritization { get; }

		[Export ("revision")]
		VTFrameRateConversionConfigurationRevision Revision { get; }

		[Static]
		[Export ("supportedRevisions")]
		NSIndexSet WeakSupportedRevisions { get; }

		[Static]
		[Wrap ("WeakSupportedRevisions.ToInt64EnumHashSet<VTFrameRateConversionConfigurationRevision> ()")]
		HashSet<VTFrameRateConversionConfigurationRevision> SupportedRevisions { get; }

		[Static]
		[Export ("defaultRevision")]
		VTFrameRateConversionConfigurationRevision DefaultRevision { get; }

		[MacCatalyst (26, 0), iOS (26, 0), Mac (26, 0)]
		[Static]
		[Export ("supported")]
		bool Supported { [Bind ("isSupported")] get; }
	}

	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	[MacCatalyst (18, 4), NoTV, iOS (26, 0), Mac (15, 4)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTFrameRateConversionParameters : VTFrameProcessorParameters {
		[Export ("initWithSourceFrame:nextFrame:opticalFlow:interpolationPhase:submissionMode:destinationFrames:")]
		NativeHandle Constructor (VTFrameProcessorFrame sourceFrame, VTFrameProcessorFrame nextFrame, [NullAllowed] VTFrameProcessorOpticalFlow opticalFlow, NSNumber [] interpolationPhase, VTFrameRateConversionParametersSubmissionMode submissionMode, VTFrameProcessorFrame [] destinationFrame);

		[NullAllowed, Export ("nextFrame")]
		VTFrameProcessorFrame NextFrame { get; }

		[NullAllowed, Export ("opticalFlow")]
		VTFrameProcessorOpticalFlow OpticalFlow { get; }

		[BindAs (typeof (float []))]
		[Export ("interpolationPhase")]
		NSNumber [] InterpolationPhase { get; }

		[Export ("submissionMode")]
		VTFrameRateConversionParametersSubmissionMode SubmissionMode { get; }
	}

	[MacCatalyst (18, 4), NoTV, iOS (26, 0), Mac (15, 4)]
	[Native]
	public enum VTMotionBlurConfigurationQualityPrioritization : long {
		Normal = 1,
		Quality = 2,
	}

	[MacCatalyst (18, 4), NoTV, iOS (26, 0), Mac (15, 4)]
	[Native]
	public enum VTMotionBlurConfigurationRevision : long {
		Revision1 = 1,
	}

	[MacCatalyst (18, 4), NoTV, iOS (26, 0), Mac (15, 4)]
	[Native]
	public enum VTMotionBlurParametersSubmissionMode : long {
		Random = 1,
		Sequential = 2,
	}

	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	[MacCatalyst (26, 0), NoTV, iOS (26, 0), Mac (15, 4)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTMotionBlurConfiguration : VTFrameProcessorConfiguration {
		[Export ("initWithFrameWidth:frameHeight:usePrecomputedFlow:qualityPrioritization:revision:")]
		NativeHandle Constructor (nint frameWidth, nint frameHeight, bool usePrecomputedFlow, VTMotionBlurConfigurationQualityPrioritization qualityPrioritization, VTMotionBlurConfigurationRevision revision);

		[Export ("frameWidth")]
		nint FrameWidth { get; }

		[Export ("frameHeight")]
		nint FrameHeight { get; }

		[Export ("usePrecomputedFlow")]
		bool UsePrecomputedFlow { get; }

		[Export ("qualityPrioritization")]
		VTMotionBlurConfigurationQualityPrioritization QualityPrioritization { get; }

		[Export ("revision")]
		VTMotionBlurConfigurationRevision Revision { get; }

		[Static]
		[Export ("supportedRevisions")]
		NSIndexSet WeakSupportedRevisions { get; }

		[Static]
		[Wrap ("WeakSupportedRevisions.ToInt64EnumHashSet<VTMotionBlurConfigurationRevision> ()")]
		HashSet<VTMotionBlurConfigurationRevision> SupportedRevisions { get; }

		[Static]
		[Export ("defaultRevision")]
		VTMotionBlurConfigurationRevision DefaultRevision { get; }

		[MacCatalyst (26, 0), iOS (26, 0), Mac (26, 0)]
		[Static]
		[Export ("supported")]
		bool Supported { [Bind ("isSupported")] get; }
	}

	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	[MacCatalyst (26, 0), NoTV, iOS (26, 0), Mac (15, 4)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTMotionBlurParameters : VTFrameProcessorParameters {
		[Export ("initWithSourceFrame:nextFrame:previousFrame:nextOpticalFlow:previousOpticalFlow:motionBlurStrength:submissionMode:destinationFrame:")]
		NativeHandle Constructor (VTFrameProcessorFrame sourceFrame, [NullAllowed] VTFrameProcessorFrame nextFrame, [NullAllowed] VTFrameProcessorFrame previousFrame, [NullAllowed] VTFrameProcessorOpticalFlow nextOpticalFlow, [NullAllowed] VTFrameProcessorOpticalFlow previousOpticalFlow, nint motionBlurStrength, VTMotionBlurParametersSubmissionMode submissionMode, VTFrameProcessorFrame destinationFrame);

		[NullAllowed, Export ("nextFrame")]
		VTFrameProcessorFrame NextFrame { get; }

		[NullAllowed, Export ("previousFrame")]
		VTFrameProcessorFrame PreviousFrame { get; }

		[NullAllowed, Export ("nextOpticalFlow")]
		VTFrameProcessorOpticalFlow NextOpticalFlow { get; }

		[NullAllowed, Export ("previousOpticalFlow")]
		VTFrameProcessorOpticalFlow PreviousOpticalFlow { get; }

		[Export ("motionBlurStrength")]
		nint MotionBlurStrength { get; }

		[Export ("submissionMode")]
		VTMotionBlurParametersSubmissionMode SubmissionMode { get; }
	}

	[MacCatalyst (18, 4), NoTV, iOS (26, 0), Mac (15, 4)]
	[Native]
	public enum VTOpticalFlowConfigurationQualityPrioritization : long {
		Normal = 1,
		Quality = 2,
	}

	[MacCatalyst (18, 4), NoTV, iOS (26, 0), Mac (15, 4)]
	[Native]
	public enum VTOpticalFlowConfigurationRevision : long {
		Revision1 = 1,
	}

	[MacCatalyst (18, 4), NoTV, iOS (26, 0), Mac (15, 4)]
	[Native]
	public enum VTOpticalFlowParametersSubmissionMode : long {
		Random = 1,
		Sequential = 2,
	}

	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	[MacCatalyst (26, 0), NoTV, iOS (26, 0), Mac (15, 4)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTOpticalFlowConfiguration : VTFrameProcessorConfiguration {
		[Export ("initWithFrameWidth:frameHeight:qualityPrioritization:revision:")]
		NativeHandle Constructor (nint frameWidth, nint frameHeight, VTOpticalFlowConfigurationQualityPrioritization qualityPrioritization, VTOpticalFlowConfigurationRevision revision);

		[Export ("frameWidth")]
		nint FrameWidth { get; }

		[Export ("frameHeight")]
		nint FrameHeight { get; }

		[Export ("qualityPrioritization")]
		VTOpticalFlowConfigurationQualityPrioritization QualityPrioritization { get; }

		[Export ("revision")]
		VTOpticalFlowConfigurationRevision Revision { get; }

		[Static]
		[Export ("supportedRevisions")]
		NSIndexSet WeakSupportedRevisions { get; }

		[Static]
		[Wrap ("WeakSupportedRevisions.ToInt64EnumHashSet<VTOpticalFlowConfigurationRevision> ()")]
		HashSet<VTOpticalFlowConfigurationRevision> SupportedRevisions { get; }

		[Static]
		[Export ("defaultRevision")]
		VTOpticalFlowConfigurationRevision DefaultRevision { get; }

		[MacCatalyst (26, 0), NoTV, iOS (26, 0), Mac (26, 0)]
		[Static]
		[Export ("supported")]
		bool Supported { [Bind ("isSupported")] get; }
	}

	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	[MacCatalyst (26, 0), NoTV, iOS (26, 0), Mac (15, 4)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTOpticalFlowParameters : VTFrameProcessorParameters {
		[Export ("initWithSourceFrame:nextFrame:submissionMode:destinationOpticalFlow:")]
		NativeHandle Constructor (VTFrameProcessorFrame sourceFrame, VTFrameProcessorFrame nextFrame, VTOpticalFlowParametersSubmissionMode submissionMode, VTFrameProcessorOpticalFlow destinationOpticalFlow);

		[Export ("nextFrame")]
		VTFrameProcessorFrame NextFrame { get; }

		[Export ("submissionMode")]
		VTOpticalFlowParametersSubmissionMode SubmissionMode { get; }

		[Export ("destinationOpticalFlow")]
		VTFrameProcessorOpticalFlow DestinationOpticalFlow { get; }
	}

	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTLowLatencyFrameInterpolationConfiguration : VTFrameProcessorConfiguration {
		[Internal]
		[Export ("initWithFrameWidth:frameHeight:numberOfInterpolatedFrames:")]
		NativeHandle _InitWithFrameWidthAndNumberOfInterpolatedFrames (nint frameWidth, nint frameHeight, nint numberOfInterpolatedFrames);

		[Internal]
		[Export ("initWithFrameWidth:frameHeight:spatialScaleFactor:")]
		NativeHandle _InitWithFrameWidthAndSpatialScaleFactor (nint frameWidth, nint frameHeight, nint spatialScaleFactor);

		[Export ("frameWidth")]
		nint FrameWidth { get; }

		[Export ("frameHeight")]
		nint FrameHeight { get; }

		[Export ("spatialScaleFactor")]
		nint SpatialScaleFactor { get; }

		[Export ("numberOfInterpolatedFrames")]
		nint NumberOfInterpolatedFrames { get; }

		[Static]
		[Export ("supported")]
		bool Supported { [Bind ("isSupported")] get; }
	}

	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTLowLatencyFrameInterpolationParameters : VTFrameProcessorParameters {
		[Export ("initWithSourceFrame:previousFrame:interpolationPhase:destinationFrames:")]
		NativeHandle Constructor (VTFrameProcessorFrame sourceFrame, VTFrameProcessorFrame previousFrame, [BindAs (typeof (float []))] NSNumber [] interpolationPhase, VTFrameProcessorFrame [] destinationFrames);

		[Export ("previousFrame")]
		VTFrameProcessorFrame PreviousFrame { get; }

		[Export ("interpolationPhase")]
		[BindAs (typeof (float []))]
		NSNumber [] InterpolationPhase { get; }
	}

	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTLowLatencySuperResolutionScalerConfiguration : VTFrameProcessorConfiguration {
		[Export ("initWithFrameWidth:frameHeight:scaleFactor:")]
		NativeHandle Constructor (nint frameWidth, nint frameHeight, float scaleFactor);

		[Export ("frameWidth")]
		nint FrameWidth { get; }

		[Export ("frameHeight")]
		nint FrameHeight { get; }

		[Export ("scaleFactor")]
		float ScaleFactor { get; }

		[Static]
		[Export ("supported")]
		bool Supported { [Bind ("isSupported")] get; }

		[Static]
		[Export ("supportedScaleFactorsForFrameWidth:frameHeight:")]
		[return: BindAs (typeof (nint []))]
		NSNumber [] GetSupportedScaleFactors (nint frameWidth, nint frameHeight);
	}

	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	[NoTV, MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTSuperResolutionScalerConfiguration : VTFrameProcessorConfiguration {
		[Export ("initWithFrameWidth:frameHeight:scaleFactor:inputType:usePrecomputedFlow:qualityPrioritization:revision:")]
		NativeHandle Constructor (nint frameWidth, nint frameHeight, nint scaleFactor, VTSuperResolutionScalerConfigurationInputType inputType, bool usePrecomputedFlow, VTSuperResolutionScalerConfigurationQualityPrioritization qualityPrioritization, VTSuperResolutionScalerConfigurationRevision revision);

		[Export ("frameWidth")]
		nint FrameWidth { get; }

		[Export ("frameHeight")]
		nint FrameHeight { get; }

		[Export ("inputType")]
		VTSuperResolutionScalerConfigurationInputType InputType { get; }

		[Export ("precomputedFlow")]
		bool PrecomputedFlow { [Bind ("usesPrecomputedFlow")] get; }

		[Export ("scaleFactor")]
		nint ScaleFactor { get; }

		[Export ("qualityPrioritization")]
		VTSuperResolutionScalerConfigurationQualityPrioritization QualityPrioritization { get; }

		[Export ("revision")]
		VTSuperResolutionScalerConfigurationRevision Revision { get; }

		[Static]
		[Export ("supportedRevisions")]
		NSIndexSet SupportedRevisions { get; }

		[Static]
		[Export ("defaultRevision")]
		VTSuperResolutionScalerConfigurationRevision DefaultRevision { get; }

		[Export ("configurationModelStatus")]
		VTSuperResolutionScalerConfigurationModelStatus ConfigurationModelStatus { get; }

		[Async]
		[Export ("downloadConfigurationModelWithCompletionHandler:")]
		void DownloadConfigurationModel (VTSuperResolutionScalerConfigurationDownloadConfigurationModelCallback completionHandler);

		[Export ("configurationModelPercentageAvailable")]
		float ConfigurationModelPercentageAvailable { get; }

		[Static]
		[Export ("supported")]
		bool Supported { [Bind ("isSupported")] get; }

		[Static]
		[Export ("supportedScaleFactors")]
		[BindAs (typeof (float []))]
		NSNumber [] SupportedScaleFactors { get; }
	}

	delegate void VTSuperResolutionScalerConfigurationDownloadConfigurationModelCallback ([NullAllowed] NSError error);

	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	[MacCatalyst (26, 0), NoTV, Mac (26, 0), iOS (26, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTSuperResolutionScalerParameters : VTFrameProcessorParameters {
		[Export ("initWithSourceFrame:previousFrame:previousOutputFrame:opticalFlow:submissionMode:destinationFrame:")]
		NativeHandle Constructor (VTFrameProcessorFrame sourceFrame, [NullAllowed] VTFrameProcessorFrame previousFrame, [NullAllowed] VTFrameProcessorFrame previousOutputFrame, [NullAllowed] VTFrameProcessorOpticalFlow opticalFlow, VTSuperResolutionScalerParametersSubmissionMode submissionMode, VTFrameProcessorFrame destinationFrame);

		[NullAllowed, Export ("previousFrame")]
		VTFrameProcessorFrame PreviousFrame { get; }

		[NullAllowed, Export ("previousOutputFrame")]
		VTFrameProcessorFrame PreviousOutputFrame { get; }

		[NullAllowed, Export ("opticalFlow")]
		VTFrameProcessorOpticalFlow OpticalFlow { get; }

		[Export ("submissionMode")]
		VTSuperResolutionScalerParametersSubmissionMode SubmissionMode { get; }
	}

	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	[MacCatalyst (26, 0), NoTV, Mac (26, 0), iOS (26, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTTemporalNoiseFilterConfiguration : VTFrameProcessorConfiguration {
		[Export ("initWithFrameWidth:frameHeight:sourcePixelFormat:")]
		NativeHandle Constructor (nint frameWidth, nint frameHeight, CMPixelFormat sourcePixelFormat);

		[Export ("frameWidth")]
		nint FrameWidth { get; }

		[Export ("frameHeight")]
		nint FrameHeight { get; }

		[Static]
		[Export ("supportedSourcePixelFormats")]
		[BindAs (typeof (CMPixelFormat []))]
		NSNumber [] SupportedSourcePixelFormats { get; }

		[Static]
		[Export ("supported")]
		bool Supported { [Bind ("isSupported")] get; }
	}

	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	[MacCatalyst (26, 0), NoTV, Mac (26, 0), iOS (26, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTTemporalNoiseFilterParameters : VTFrameProcessorParameters {
		[Export ("initWithSourceFrame:nextFrames:previousFrames:destinationFrame:filterStrength:hasDiscontinuity:")]
		NativeHandle Constructor (VTFrameProcessorFrame sourceFrame, VTFrameProcessorFrame [] nextFrames, VTFrameProcessorFrame [] previousFrames, VTFrameProcessorFrame destinationFrame, float filterStrength, byte hasDiscontinuity);

		[Export ("nextFrames")]
		VTFrameProcessorFrame [] NextFrames { get; }

		[Export ("previousFrames")]
		VTFrameProcessorFrame [] PreviousFrames { get; }

		[Export ("filterStrength")]
		float FilterStrength { get; set; }

		[Export ("hasDiscontinuity")]
		bool HasDiscontinuity { get; set; }
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[Flags]
	public enum VTMotionEstimationFrameFlags : uint {
		None = 0,
		CurrentBufferWillBeNextReferenceBuffer = 1u << 0,
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[Flags]
	public enum VTMotionEstimationInfoFlags : uint {
		None = 0,
		Reserved0 = 1u << 0,
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[Static]
	interface VTMotionEstimationSessionCreationOptionKey {
		[Field ("kVTMotionEstimationSessionCreationOption_MotionVectorSize")]
		NSString MotionVectorSize { get; }

		[Field ("kVTMotionEstimationSessionCreationOption_UseMultiPassSearch")]
		NSString UseMultiPassSearch { get; }

		[Field ("kVTMotionEstimationSessionCreationOption_Label")]
		NSString Label { get; }
	}

	[UnsupportedSimulator ("ios")]
	[UnsupportedSimulator ("tvos")]
	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VTLowLatencySuperResolutionScalerParameters : VTFrameProcessorParameters {
		[Export ("initWithSourceFrame:destinationFrame:")]
		NativeHandle Constructor (VTFrameProcessorFrame sourceFrame, VTFrameProcessorFrame destinationFrame);
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[StrongDictionary ("VTMotionEstimationSessionCreationOptionKey", Suffix = "")]
	interface VTMotionEstimationSessionCreationOption {
		[Field ("kVTMotionEstimationSessionCreationOption_MotionVectorSize")]
		nint MotionVectorSize { get; set; }

		[Field ("kVTMotionEstimationSessionCreationOption_UseMultiPassSearch")]
		bool UseMultiPassSearch { get; set; }

		[Field ("kVTMotionEstimationSessionCreationOption_Label")]
		string Label { get; set; }
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[Static]
	interface VTDecodeFrameOptionKey {
		[Field ("kVTDecodeFrameOptionKey_ContentAnalyzerRotation")]
		NSString ContentAnalyzerRotation { get; }

		[Field ("kVTDecodeFrameOptionKey_ContentAnalyzerCropRectangle")]
		NSString ContentAnalyzerCropRectangle { get; }
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[StrongDictionary ("VTDecodeFrameOptionKey", Suffix = "")]
	interface VTDecodeFrameOptions {
		nint ContentAnalyzerRotation { get; set; }
		CGRectDictionary ContentAnalyzerCropRectangle { get; set; }
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[Native]
	public enum VTSuperResolutionScalerConfigurationQualityPrioritization : long {
		Normal = 1,
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[Native]
	public enum VTSuperResolutionScalerConfigurationRevision : long {
		Revision1 = 1,
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[Native]
	public enum VTSuperResolutionScalerConfigurationInputType : long {
		Video = 1,
		Image = 2,
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[Native]
	public enum VTSuperResolutionScalerConfigurationModelStatus : long {
		DownloadRequired = 0,
		Downloading = 1,
		Ready = 2,
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	[Native]
	public enum VTSuperResolutionScalerParametersSubmissionMode : long {
		Random = 1,
		Sequential = 2,
	}
}
