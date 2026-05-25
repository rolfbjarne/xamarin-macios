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
	/// <summary>An enumeration whose values specify types of video codecs.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CMVideoCodecType : uint {
		/// <summary>Indicates YCbCR content.</summary>
		YUV422YpCbCr8 = 846624121,
		/// <summary>Indicates Apple animation format.</summary>
		Animation = 1919706400,
		/// <summary>Indicates Cinepak content.</summary>
		Cinepak = 1668704612,
		/// <summary>Indicates JPEG content.</summary>
		JPEG = 1785750887,
		/// <summary>Indicates Open-DML JPEG content.</summary>
		JPEG_OpenDML = 1684890161,
		JPEG_XL = 1786276963,
		/// <summary>Indicates Sorenson content.</summary>
		SorensonVideo = 1398165809,
		/// <summary>Indicates Sorenson 3 content.</summary>
		SorensonVideo3 = 1398165811,
		/// <summary>Indicates ITU-T H.263 content.</summary>
		H263 = 1748121139,
		/// <summary>Indicates ITU-T H.264 content.</summary>
		H264 = 1635148593,
		/// <summary>Indicates MPEG-4 Part 2 content.</summary>
		Mpeg4Video = 1836070006,
		/// <summary>Indicates MPEG-2 content.</summary>
		Mpeg2Video = 1836069494,
		/// <summary>Indicates MPEG-1 content.</summary>
		Mpeg1Video = 1836069238,
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		VP9 = 1987063865,
		/// <summary>Indicates DV NTSC content.</summary>
		DvcNtsc = 1685480224,
		/// <summary>Indicates DVC PAL content.</summary>
		DvcPal = 1685480304,
		/// <summary>Indicates Panasonic DVCPro PAL content.</summary>
		DvcProPal = 1685483632,
		/// <summary>Indicates Panasonic DVCPro-50 NTSC content.</summary>
		DvcPro50NTSC = 1685468526,
		/// <summary>Indicates Panasonic DVCPro PAL content.</summary>
		DvcPro50PAL = 1685468528,
		/// <summary>Indicates Panasonic DVCPro-HD 720p60 content.</summary>
		DvcProHD720p60 = 1685481584,
		/// <summary>Indicates Panasonic DVCPro-HD 720p50 content.</summary>
		DvcProHD720p50 = 1685481585,
		/// <summary>Indicates Panasonic DVCPro-HD 1080i60 content.</summary>
		DvcProHD1080i60 = 1685481526,
		/// <summary>Indicates Panasonic DVCPro-HD 1080i50 content.</summary>
		DvcProHD1080i50 = 1685481525,
		/// <summary>Indicates Panasonic DVCPro-HD 1080p30 content.</summary>
		DvcProHD1080p30 = 1685481523,
		/// <summary>Indicates Panasonic DVCPro-HD 1080p25 content.</summary>
		DvcProHD1080p25 = 1685481522,
		AppleProRes4444XQ = 1634743416,
		/// <summary>To be added.</summary>
		AppleProRes4444 = 1634743400,
		/// <summary>To be added.</summary>
		AppleProRes422HQ = 1634755432,
		/// <summary>To be added.</summary>
		AppleProRes422 = 1634755438,
		/// <summary>To be added.</summary>
		AppleProRes422LT = 1634755443,
		/// <summary>To be added.</summary>
		AppleProRes422Proxy = 1634755439,
		AppleProResRaw = 1634759278,
		AppleProResRawHQ = 1634759272,
		/// <summary>To be added.</summary>
		Hevc = 1752589105,
		HevcWithAlpha = 1836415073,
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		DolbyVisionHevc = 1685481521,
		DisparityHevc = 1684632424,
		DepthHevc = 1684369512,
		/// <summary>Indicates AV1 content.</summary>
		AV1 = 1635135537,
	}
}
