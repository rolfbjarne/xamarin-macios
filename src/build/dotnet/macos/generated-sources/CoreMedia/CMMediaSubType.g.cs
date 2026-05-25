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
	/// <summary>This enum contains most values that can be returned from <see cref="CMFormatDescription.MediaSubType" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CMMediaSubType : uint {
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.LinearPCM" />.</summary>
		LinearPcm = 1819304813,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.AC3" />.</summary>
		Ac3 = 1633889587,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.AC3_60958" />.</summary>
		Iec60958Ac3 = 1667326771,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.AppleIMA4" />.</summary>
		AppleIma4 = 1768775988,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MPEG4AAC" />.</summary>
		Mpeg4Aac = 1633772320,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MPEG4CELP" />.</summary>
		Mpeg4Celp = 1667591280,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MPEG4HVXC" />.</summary>
		Mpeg4Hvxc = 1752594531,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MPEG4TwinVQ" />.</summary>
		Mpeg4TwinVQ = 1953986161,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MACE3" />.</summary>
		Mace3 = 1296122675,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MACE6" />.</summary>
		Mace6 = 1296122678,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.ULaw" />.</summary>
		ULaw = 1970037111,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.ALaw" />.</summary>
		ALaw = 1634492791,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.QDesign" />.</summary>
		QDesign = 1363430723,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.QDesign2" />.</summary>
		QDesign2 = 1363430706,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.QUALCOMM" />.</summary>
		Qualcomm = 1365470320,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MPEGLayer1" />.</summary>
		MpegLayer1 = 778924081,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MPEGLayer2" />.</summary>
		MpegLayer2 = 778924082,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MPEGLayer3" />.</summary>
		MpegLayer3 = 778924083,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.TimeCode" />.</summary>
		TimeCode = 1953066341,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MIDIStream" />.</summary>
		MidiStream = 1835623529,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.ParameterValueStream" />.</summary>
		ParameterValueStream = 1634760307,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.AppleLossless" />.</summary>
		AppleLossless = 1634492771,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MPEG4AAC_HE" />.</summary>
		Mpeg4Aac_HE = 1633772392,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MPEG4AAC_LD" />.</summary>
		Mpeg4Aac_LD = 1633772396,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MPEG4AAC_ELD" />.</summary>
		Mpeg4Aac_Eld = 1633772389,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MPEG4AAC_ELD_SBR" />.</summary>
		Mpeg4Aac_Eld_SBR = 1633772390,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MPEG4AAC_ELD_V2" />.</summary>
		Mpeg4Aac_Eld_V2 = 1633772391,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MPEG4AAC_HE_V2" />.</summary>
		Mpeg4Aac_HE_V2 = 1633772400,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MPEG4AAC_Spatial" />.</summary>
		Mpeg4Aac_Spatial = 1633772403,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MpegD_Usac" />.</summary>
		MpegD_USAC = 1970495843,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.AMR" />.</summary>
		Amr = 1935764850,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.AMRWideBand" />.</summary>
		Amr_WB = 1935767394,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.Audible" />.</summary>
		Audible = 1096107074,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.iLBC" />.</summary>
		ILbc = 1768710755,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.DVIIntelIMA" />.</summary>
		DviIntelIma = 1836253201,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.MicrosoftGSM" />.</summary>
		MicrosoftGsm = 1836253233,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.AES3" />.</summary>
		Aes3 = 1634038579,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.EnhancedAC3" />.</summary>
		EnhancedAC3 = 1700998451,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.Flac" />.</summary>
		Flac = 1718378851,
		/// <summary>This has the same value as <see cref="F:AudioToolbox.AudioFormatType.Opus" />.</summary>
		Opus = 1869641075,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMAudioCodecType.AacLCProtected" />.</summary>
		AacLCProtected = 1885430115,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMAudioCodecType.AacAudibleProtected" />.</summary>
		AacAudibleProtected = 1633771875,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.AlphaRedGreenBlue32bits" />.</summary>
		PixelFormat32ARGB = 32,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.BlueGreenRedAlpha32bits" />.</summary>
		PixelFormat32BGRA = 1111970369,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.RedGreenBlue24bits" />.</summary>
		PixelFormat24RGB = 24,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.BigEndian555_16bits" />.</summary>
		PixelFormat16BE555 = 16,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.BigEndian565_16bits" />.</summary>
		PixelFormat16BE565 = 1110783541,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.LittleEndian555_16bits" />.</summary>
		PixelFormat16LE555 = 1278555445,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.LittleEndian565_16bits" />.</summary>
		PixelFormat16LE565 = 1278555701,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.LittleEndian5551_16bits" />.</summary>
		PixelFormat16LE5551 = 892679473,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.YpCbCr422_8bits" />.</summary>
		PixelFormat422YpCbCr8 = 846624121,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.YpCbCr422yuvs_8bits" />.</summary>
		PixelFormat422YpCbCr8_yuvs = 2037741171,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.YpCbCr444_8bits" />.</summary>
		PixelFormat444YpCbCr8 = 1983066168,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.YpCbCrA4444_8bits" />.</summary>
		PixelFormat4444YpCbCrA8 = 1983131704,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.YpCbCr422_16bits" />.</summary>
		PixelFormat422YpCbCr16 = 1983000886,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.YpCbCr422_10bits" />.</summary>
		PixelFormat422YpCbCr10 = 1983000880,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.YpCbCr444_10bits" />.</summary>
		PixelFormat444YpCbCr10 = 1983131952,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMPixelFormat.IndexedGrayWhiteIsZero_8bits" />.</summary>
		PixelFormat8IndexedGray_WhiteIsZero = 40,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.Animation" />.</summary>
		Animation = 1919706400,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.Cinepak" />.</summary>
		Cinepak = 1668704612,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.JPEG" />.</summary>
		Jpeg = 1785750887,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.JPEG_OpenDML" />.</summary>
		Jpeg_OpenDml = 1684890161,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.SorensonVideo" />.</summary>
		SorensonVideo = 1398165809,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.SorensonVideo3" />.</summary>
		SorensonVideo3 = 1398165811,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.H263" />.</summary>
		H263 = 1748121139,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.H264" />.</summary>
		H264 = 1635148593,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.Hevc" />.</summary>
		Hevc = 1752589105,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.HevcWithAlpha" />.</summary>
		HevcWithAlpha = 1836415073,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.Mpeg4Video" />.</summary>
		Mpeg4Video = 1836070006,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.Mpeg2Video" />.</summary>
		Mpeg2Video = 1836069494,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.Mpeg1Video" />.</summary>
		Mpeg1Video = 1836069238,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.DvcNtsc" />.</summary>
		DvcNtsc = 1685480224,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.DvcPal" />.</summary>
		DvcPal = 1685480304,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.DvcProPal" />.</summary>
		DvcProPal = 1685483632,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.DvcPro50NTSC" />.</summary>
		DvcPro50Ntsc = 1685468526,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.DvcPro50PAL" />.</summary>
		DvcPro50Pal = 1685468528,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.DvcProHD720p60" />.</summary>
		DvcProHD720p60 = 1685481584,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.DvcProHD720p50" />.</summary>
		DvcProHD720p50 = 1685481585,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.DvcProHD1080i60" />.</summary>
		DvcProHD1080i60 = 1685481526,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.DvcProHD1080i50" />.</summary>
		DvcProHD1080i50 = 1685481525,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.DvcProHD1080p30" />.</summary>
		DvcProHD1080p30 = 1685481523,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.DvcProHD1080p25" />.</summary>
		DvcProHD1080p25 = 1685481522,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.AppleProRes4444XQ" />.</summary>
		ProRes4444XQ = 1634743416,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.AppleProRes4444" />.</summary>
		ProRes4444 = 1634743400,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.AppleProRes422HQ" />.</summary>
		ProRes422HQ = 1634755432,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.AppleProRes422" />.</summary>
		ProRes422 = 1634755438,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.AppleProRes422LT" />.</summary>
		ProRes422LT = 1634755443,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.AppleProRes422Proxy" />.</summary>
		ProRes422Proxy = 1634755439,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.AppleProResRaw" />.</summary>
		ProResRAW = 1634759278,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMVideoCodecType.AppleProResRawHQ" />.</summary>
		ProResRAWHQ = 1634759272,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMMuxedStreamType.MPEG1System" />.</summary>
		Mpeg1System = 1836069235,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMMuxedStreamType.MPEG2Transport" />.</summary>
		Mpeg2Transport = 1836069492,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMMuxedStreamType.MPEG2Program" />.</summary>
		Mpeg2Program = 1836069488,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMMuxedStreamType.DV" />.</summary>
		Dv = 1685463072,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMMuxedStreamType.EmbeddedDeviceScreenRecording" />.</summary>
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		EmbeddedDeviceScreenRecording = 1769173536,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMClosedCaptionFormatType.CEA608" />.</summary>
		Cea608 = 1664495672,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMClosedCaptionFormatType.CEA708" />.</summary>
		Cea708 = 1664561208,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMClosedCaptionFormatType.ATSC" />.</summary>
		Atsc = 1635017571,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMTextFormatType.QTText" />.</summary>
		Qt = 1952807028,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMSubtitleFormatType.Text3G" />.</summary>
		Mobile3Gpp = 1954034535,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMSubtitleFormatType.WebVTT" />.</summary>
		WebVtt = 2004251764,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMTimeCodeFormatType.TimeCode32" />.</summary>
		TimeCode32 = 1953325924,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMTimeCodeFormatType.TimeCode64" />.</summary>
		TimeCode64 = 1952658996,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMTimeCodeFormatType.Counter32" />.</summary>
		Counter32 = 1668166450,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMTimeCodeFormatType.Counter64" />.</summary>
		Counter64 = 1668167220,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMMetadataFormatType.ICY" />.</summary>
		Icy = 1768126752,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMMetadataFormatType.ID3" />.</summary>
		Id3 = 1768174368,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMMetadataFormatType.Boxed" />.</summary>
		Boxed = 1835360888,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMMetadataFormatType.Emsg" />.</summary>
		Emsg = 1701671783,
		/// <summary>This has the same value as <see cref="F:CoreMedia.CMMediaType.TaggedBufferGroup" />.</summary>
		Tbgr = 1952606066,
	}
}
