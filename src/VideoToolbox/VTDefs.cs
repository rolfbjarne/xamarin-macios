//
// VideoToolbox core enumerations
//
// Authors: 
// 		Miguel de Icaza (miguel@xamarin.com)
//		Alex Soto (alex.soto@xamarin.com)
//
// Copyright 2014 Xamarin Inc
//

namespace VideoToolbox {

	// untyped enum -> VTErrors.h
	/// <summary>Possible VideoToolbox API errors.</summary>
	public enum VTStatus {
		/// <summary>No error.</summary>
		Ok,
		/// <summary>The property is not supported.</summary>
		PropertyNotSupported = -12900,
		/// <summary>The property is read-only.</summary>
		PropertyReadOnly = -12901,
		/// <summary>An invalid parameter was passed.</summary>
		Parameter = -12902,
		/// <summary>The session is invalid.</summary>
		InvalidSession = -12903,
		/// <summary>Memory allocation failed.</summary>
		AllocationFailed = -12904,
		/// <summary>Pixel transfer is not supported.</summary>
		PixelTransferNotSupported = -12905,
		/// <summary>A suitable video decoder could not be found.</summary>
		CouldNotFindVideoDecoder = -12906,
		/// <summary>Could not create an instance.</summary>
		CouldNotCreateInstance = -12907,
		/// <summary>A suitable video encoder could not be found.</summary>
		CouldNotFindVideoEncoder = -12908,
		/// <summary>The video decoder received bad data.</summary>
		VideoDecoderBadData = -12909,
		/// <summary>The video decoder does not support the data format.</summary>
		VideoDecoderUnsupportedDataFormat = -12910,
		/// <summary>The video decoder malfunctioned.</summary>
		VideoDecoderMalfunction = -12911,
		/// <summary>The video encoder malfunctioned.</summary>
		VideoEncoderMalfunction = -12912,
		/// <summary>The video decoder is not available now.</summary>
		VideoDecoderNotAvailableNow = -12913,
		/// <summary>Image rotation is not supported.</summary>
		[Obsolete ("Use PixelRotationNotSupported enum value instead.")]
		ImageRotationNotSupported = -12914,
		PixelRotationNotSupported = -12914,
		/// <summary>The video encoder is not available now.</summary>
		VideoEncoderNotAvailableNow = -12915,
		/// <summary>Format description change is not supported.</summary>
		FormatDescriptionChangeNotSupported = -12916,
		/// <summary>Insufficient source color data.</summary>
		InsufficientSourceColorData = -12917,
		/// <summary>Could not create color correction data.</summary>
		CouldNotCreateColorCorrectionData = -12918,
		/// <summary>ColorSync transform conversion failed.</summary>
		ColorSyncTransformConvertFailed = -12919,
		/// <summary>Video decoder authorization failed.</summary>
		VideoDecoderAuthorization = -12210,
		/// <summary>Video encoder authorization failed.</summary>
		VideoEncoderAuthorization = -12211,
		/// <summary>Color correction pixel transfer failed.</summary>
		ColorCorrectionPixelTransferFailed = -12212,
		/// <summary>Multi-pass storage identifier mismatch.</summary>
		MultiPassStorageIdentifierMismatch = -12913,
		/// <summary>Multi-pass storage is invalid.</summary>
		MultiPassStorageInvalid = -12214,
		/// <summary>Invalid timestamp in frame silo.</summary>
		FrameSiloInvalidTimeStamp = -12215,
		/// <summary>Invalid time range in frame silo.</summary>
		FrameSiloInvalidTimeRange = -12216,
		/// <summary>Could not find a temporal filter.</summary>
		CouldNotFindTemporalFilter = -12217,
		/// <summary>Pixel transfer is not permitted.</summary>
		PixelTransferNotPermitted = -12218,
		/// <summary>Color correction image rotation failed.</summary>
		ColorCorrectionImageRotationFailed = -12219,
		/// <summary>The video decoder was removed.</summary>
		VideoDecoderRemoved = -17690,
		SessionMalfunction = -17691,
		[MacCatalyst (13, 1)]
		DecoderNeedsRosetta = -17692,
		[MacCatalyst (13, 1)]
		EncoderNeedsRosetta = -17693,
		[iOS (15, 0), MacCatalyst (15, 0), TV (15, 0)]
		VideoDecoderReferenceMissing = -17694,
		[iOS (15, 0), MacCatalyst (15, 0), TV (15, 0)]
		VideoDecoderCallbackMessaging = -17695,
		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
		VideoDecoderUnknownErr = -17696,
		ExtensionDisabledErr = -17697,
		VideoEncoderMVHEVCVideoLayerIDsMismatchErr = -17698,
		CouldNotOutputTaggedBufferGroupErr = -17699,
		CouldNotFindExtensionErr = -19510,
		ExtensionConflictErr = -19511,
		VideoEncoderAutoWhiteBalanceNotLockedErr = -19512,
	}

	// uint32_t -> VTErrors.h
	/// <summary>Flags to control encoder in a decompression session</summary>
	[Flags]
	public enum VTDecodeFrameFlags : uint {
		None = 0,
		/// <summary>Enable asynchronous decompression.</summary>
		EnableAsynchronousDecompression = 1 << 0,
		/// <summary>Do not output the decoded frame.</summary>
		DoNotOutputFrame = 1 << 1,
		/// <summary>Hint that this is for one-time real-time playback.</summary>
		OneTimeRealTimePlayback = 1 << 2,
		/// <summary>Enable temporal processing.</summary>
		EnableTemporalProcessing = 1 << 3,
	}

	// UInt32 -> VTErrors.h
	/// <summary>Flags for status reporting in decoding sessions.</summary>
	[Flags]
	public enum VTDecodeInfoFlags : uint {
		None = 0,
		/// <summary>The frame was decoded asynchronously.</summary>
		Asynchronous = 1 << 0,
		/// <summary>The frame was dropped.</summary>
		FrameDropped = 1 << 1,
		/// <summary>The image buffer is modifiable.</summary>
		ImageBufferModifiable = 1 << 2,
		SkippedLeadingFrameDropped = 1 << 3,
		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		FrameInterrupted = 1 << 4,
	}

	// UInt32 -> VTErrors.h
	/// <summary>Encoding status flags.</summary>
	[Flags]
	public enum VTEncodeInfoFlags : uint {
		/// <summary>The frame was decoded asynchronously.</summary>
		Asynchronous = 1 << 0,
		/// <summary>The frame was dropped.</summary>
		FrameDropped = 1 << 1,
	}

	// uint32_t -> VTCompressionSession.h
	/// <summary>Flags to control encoder in multIPass compression sessions</summary>
	[Flags]
	public enum VTCompressionSessionOptionFlags : uint {
		/// <summary>Begin the final encoding pass.</summary>
		BeginFinalPass = 1 << 0,
	}

	// Strongly Typed VTProfileLevelKey
	/// <summary>Strongly typed set of options used by <see cref="VideoToolbox.VTCompressionProperties.ProfileLevel" />.</summary>
	public enum VTProfileLevel {
		/// <summary>The protocol, profile, and level have not been set.</summary>
		Unset,
		/// <summary>The H.264 compression format, baseline profile, level 1.3.</summary>
		H264Baseline13,
		/// <summary>The H.264 compression format, baseline profile, level 3.0.</summary>
		H264Baseline30,
		/// <summary>The H.264 compression format, baseline profile, level 3.1.</summary>
		H264Baseline31,
		/// <summary>The H.264 compression format, baseline profile, level 3.2.</summary>
		H264Baseline32,
		/// <summary>The H.264 compression format, baseline profile, level 4.0.</summary>
		H264Baseline40,
		/// <summary>The H.264 compression format, baseline profile, level 4.1.</summary>
		H264Baseline41,
		/// <summary>The H.264 compression format, baseline profile, level 4.2.</summary>
		H264Baseline42,
		/// <summary>The H.264 compression format, baseline profile, level 5.0.</summary>
		H264Baseline50,
		/// <summary>The H.264 compression format, baseline profile, level 5.1.</summary>
		H264Baseline51,
		/// <summary>The H.264 compression format, baseline profile, level 5.2.</summary>
		H264Baseline52,
		/// <summary>The H.264 compression format, baseline profile. Determine the level automatically.</summary>
		H264BaselineAutoLevel,
		/// <summary>The H.264 compression format, main profile, level 3.0.</summary>
		H264Main30,
		/// <summary>The H.264 compression format, main profile, level 3.1.</summary>
		H264Main31,
		/// <summary>The H.264 compression format, main profile, level 3.2.</summary>
		H264Main32,
		/// <summary>The H.264 compression format, main profile, level 4.0.</summary>
		H264Main40,
		/// <summary>The H.264 compression format, main profile, level 4.1.</summary>
		H264Main41,
		/// <summary>The H.264 compression format, main profile, level 4.2.</summary>
		H264Main42,
		/// <summary>The H.264 compression format, main profile, level 5.0.</summary>
		H264Main50,
		/// <summary>The H.264 compression format, main profile, level 5.1.</summary>
		H264Main51,
		/// <summary>The H.264 compression format, main profile, level 5.2.</summary>
		H264Main52,
		/// <summary>The H.264 compression format, main profile. Determine the level automatically.</summary>
		H264MainAutoLevel,
		/// <summary>The H.264 compression format, extended profile, level 5.0.</summary>
		H264Extended50,
		/// <summary>The H.264 compression format, extended profile. Determine the level automatically.</summary>
		H264ExtendedAutoLevel,
		/// <summary>The H.264 compression format, high profile, level 3.0.</summary>
		H264High30,
		/// <summary>The H.264 compression format, high profile, level 3.1.</summary>
		H264High31,
		/// <summary>The H.264 compression format, high profile, level 3.2.</summary>
		H264High32,
		/// <summary>The H.264 compression format, high profile, level 4.0.</summary>
		H264High40,
		/// <summary>The H.264 compression format, high profile, level 4.1.</summary>
		H264High41,
		/// <summary>The H.264 compression format, high profile, level 4.2.</summary>
		H264High42,
		/// <summary>The H.264 compression format, high profile, level 5.0.</summary>
		H264High50,
		/// <summary>The H.264 compression format, high profile, level 5.1.</summary>
		H264High51,
		/// <summary>The H.264 compression format, high profile, level 5.2.</summary>
		H264High52,
		/// <summary>The H.264 compression format, high profile. Determine the level automatically.</summary>
		H264HighAutoLevel,
		/// <summary>The MPEG-4 simple profile, level 0.</summary>
		MP4VSimpleL0,
		/// <summary>The MPEG-4 simple profile, level 1.</summary>
		MP4VSimpleL1,
		/// <summary>The MPEG-4 simple profile, level 2.</summary>
		MP4VSimpleL2,
		/// <summary>The MPEG-4 simple profile, level 3.</summary>
		MP4VSimpleL3,
		/// <summary>The MPEG-4 main profile, level 2.</summary>
		MP4VMainL2,
		/// <summary>The MPEG-4 main profile, level 3.</summary>
		MP4VMainL3,
		/// <summary>The MPEG-4 main profile, level 4.</summary>
		MP4VMainL4,
		/// <summary>The MPEG-4 advanced simple profile, level 0.</summary>
		MP4VAdvancedSimpleL0,
		/// <summary>The MPEG-4 advanced simple profile, level 1.</summary>
		MP4VAdvancedSimpleL1,
		/// <summary>The MPEG-4 advanced simple profile, level 2.</summary>
		MP4VAdvancedSimpleL2,
		/// <summary>The MPEG-4 advanced simple profile, level 3.</summary>
		MP4VAdvancedSimpleL3,
		/// <summary>The MPEG-4 advanced simple profile, level 4.</summary>
		MP4VAdvancedSimpleL4,
		/// <summary>The H.263 compression format, profile 0, level 1.0.</summary>
		H263Profile0Level10,
		/// <summary>The H.263 compression format, profile 0, level 4.5.</summary>
		H263Profile0Level45,
		/// <summary>The H.263 compression format, profile 3, level 4.5.</summary>
		H263Profile3Level45,
		/// <summary>The HEVC compression format, main profile. Determine the level automatically.</summary>
		[MacCatalyst (13, 1)]
		HevcMainAutoLevel,
		/// <summary>The HEVC compression format, main 10 profile. Determine the level automatically.</summary>
		[MacCatalyst (13, 1)]
		HevcMain10AutoLevel,
	}

	// Strongly Typed VTH264EntropyModeKeys
	/// <summary>Strongly typed set of options used by <see cref="VideoToolbox.VTCompressionProperties.H264EntropyMode" />.</summary>
	public enum VTH264EntropyMode {
		/// <summary>The value is not set.</summary>
		Unset,
		/// <summary>CAVLC (Context-Adaptive Variable-Length Coding) entropy mode.</summary>
		Cavlc,
		/// <summary>CABAC (Context-Adaptive Binary Arithmetic Coding) entropy mode.</summary>
		Cabac,
	}

	// Strongly Typed kVTCompressionPropertyKey_FieldCount
	/// <summary>Frame encoding options.</summary>
	public enum VTFieldCount {
		/// <summary>Progressive (non-interlaced) encoding.</summary>
		Progressive = 1,
		/// <summary>Interlaced encoding.</summary>
		Interlaced = 2,
	}

	// Strongly Typed kVTCompressionPropertyKey_FieldDetail
	/// <summary>Field ordering options.</summary>
	public enum VTFieldDetail {
		/// <summary>The value is not set.</summary>
		Unset,
		/// <summary>Temporal top field first.</summary>
		TemporalTopFirst,
		/// <summary>Temporal bottom field first.</summary>
		TemporalBottomFirst,
		/// <summary>Spatial first line early.</summary>
		SpatialFirstLineEarly,
		/// <summary>Spatial first line late.</summary>
		SpatialFirstLineLate,
	}

	// Strongly Typed kVTCompressionPropertyKey_ColorPrimaries
	/// <summary>Represents color primaries in compressed sample buffers</summary>
	public enum VTColorPrimaries {
		/// <summary>The value is not set.</summary>
		Unset,
		/// <summary>ITU-R BT.709-2 color primaries.</summary>
		ItuR7092,
		/// <summary>EBU Tech. 3213 color primaries.</summary>
		Ebu3213,
		/// <summary>SMPTE C color primaries.</summary>
		SmpteC,
		/// <summary>P22 color primaries.</summary>
		P22,
	}

	// Strongly Typed kVTCompressionPropertyKey_TransferFunction
	/// <summary>Strongly typed set of options used by <see cref="VideoToolbox.VTCompressionProperties.TransferFunction" />.</summary>
	public enum VTTransferFunction {
		/// <summary>The value is not set.</summary>
		Unset,
		/// <summary>ITU-R BT.709-2 color primaries.</summary>
		ItuR7092,
		/// <summary>SMPTE 240M-1955 transfer function.</summary>
		Smpte240M1955,
		/// <summary>Use gamma transfer function.</summary>
		UseGamma,
	}

	// Strongly Typed kVTCompressionPropertyKey_YCbCrMatrix
	/// <summary>Colorimetry for compressed content.</summary>
	public enum VTYCbCrMatrix {
		/// <summary>The value is not set.</summary>
		Unset,
		/// <summary>ITU-R BT.709-2 color primaries.</summary>
		ItuR7092,
		/// <summary>ITU-R BT.601-4 YCbCr matrix.</summary>
		ItuR6014,
		/// <summary>SMPTE 240M-1955 transfer function.</summary>
		Smpte240M1955,
	}

	// Strongly Typed kVTDecompressionPropertyKey_FieldMode
	/// <summary>Decoder field mode options.</summary>
	public enum VTFieldMode {
		/// <summary>The value is not set.</summary>
		Unset,
		/// <summary>Output both fields.</summary>
		BothFields,
		/// <summary>Output only the top field.</summary>
		TopFieldOnly,
		/// <summary>Output only the bottom field.</summary>
		BottomFieldOnly,
		/// <summary>Output a single field.</summary>
		SingleField,
		/// <summary>Deinterlace both fields.</summary>
		DeinterlaceFields,
	}

	// Strongly Typed kVTDecompressionPropertyKey_DeinterlaceMode
	/// <summary>Deinterlacing techniques.</summary>
	public enum VTDeinterlaceMode {
		/// <summary>The value is not set.</summary>
		Unset,
		/// <summary>Vertical filter deinterlacing.</summary>
		VerticalFilter,
		/// <summary>Temporal deinterlacing.</summary>
		Temporal,
	}

	// Strongly Typed kVTDecompressionPropertyKey_OnlyTheseFrames
	/// <summary>Strongly typed set of options used by <see cref="VideoToolbox.VTDecompressionProperties.OnlyTheseFrames" />.</summary>
	public enum VTOnlyTheseFrames {
		/// <summary>The value is not set.</summary>
		Unset,
		/// <summary>Decode all frames.</summary>
		AllFrames,
		/// <summary>Decode only non-droppable frames.</summary>
		NonDroppableFrames,
		/// <summary>Decode only I-frames.</summary>
		IFrames,
		/// <summary>Decode only key frames.</summary>
		KeyFrames,
	}

	// Strongly Typed kVTPropertyTypeKey
	/// <summary>Strongly typed set of options.</summary>
	public enum VTPropertyType {
		/// <summary>The value is not set.</summary>
		Unset,
		/// <summary>An enumeration property type.</summary>
		Enumeration,
		/// <summary>A boolean property type.</summary>
		Boolean,
		/// <summary>A number property type.</summary>
		Number,
	}

	// Strongly Typed kVTPropertyReadWriteStatusKey
	/// <summary>Strongly typed set of options used by <see cref="VideoToolbox.VTPropertyOptions.ReadWriteStatus" />.</summary>
	public enum VTReadWriteStatus {
		/// <summary>The value is not set.</summary>
		Unset,
		/// <summary>The property is read-only.</summary>
		ReadOnly,
		/// <summary>The property is read-write.</summary>
		ReadWrite,
	}

	public struct VTDataRateLimit {
		public uint NumberOfBytes { get; set; }
		public double Seconds { get; set; }

		public VTDataRateLimit (uint numberOfBytes, double seconds) : this ()
		{
			NumberOfBytes = numberOfBytes;
			Seconds = seconds;
		}
	}

	/// <summary>Image scaling options.</summary>
	[MacCatalyst (13, 1)]
	public enum VTScalingMode {
		/// <summary>The value is not set.</summary>
		Unset,
		/// <summary>Normal scaling.</summary>
		Normal,
		/// <summary>Crop the source to the clean aperture.</summary>
		CropSourceToCleanAperture,
		/// <summary>Letterbox the content.</summary>
		Letterbox,
		/// <summary>Trim the content.</summary>
		Trim,
	}

	/// <summary>Chroma downsampling techniques.</summary>
	[MacCatalyst (13, 1)]
	public enum VTDownsamplingMode {
		/// <summary>The value is not set.</summary>
		Unset,
		/// <summary>Decimate downsampling.</summary>
		Decimate,
		/// <summary>Average downsampling.</summary>
		Average,
	}

	[TV (14, 0), iOS (14, 0)]
	[MacCatalyst (14, 0)]
	public enum HdrMetadataInsertionMode {
		[Field ("kVTHDRMetadataInsertionMode_None")]
		None,
		[Field ("kVTHDRMetadataInsertionMode_Auto")]
		Auto,

		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("kVTHDRMetadataInsertionMode_RequestSDRRangePreservation")]
		RequestSdrRangePreservation,

	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (16, 0)]
	public enum VTRotation {
		[DefaultEnumValue]
		[Field ("kVTRotation_0")]
		Zero,
		[Field ("kVTRotation_CW90")]
		ClockwiseNinety,
		[Field ("kVTRotation_180")]
		OneHundredAndEighty,
		[Field ("kVTRotation_CCW90")]
		CounterclockwiseNinety,
	}
}
