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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace VideoToolbox {
	/// <summary>Strongly typed set of options used by <see cref="VideoToolbox.VTCompressionProperties.ProfileLevel" />.</summary>
	public enum VTProfileLevel : int {
		/// <summary>The protocol, profile, and level have not been set.</summary>
		Unset = 0,
		/// <summary>The H.264 compression format, baseline profile, level 1.3.</summary>
		H264Baseline13 = 1,
		/// <summary>The H.264 compression format, baseline profile, level 3.0.</summary>
		H264Baseline30 = 2,
		/// <summary>The H.264 compression format, baseline profile, level 3.1.</summary>
		H264Baseline31 = 3,
		/// <summary>The H.264 compression format, baseline profile, level 3.2.</summary>
		H264Baseline32 = 4,
		/// <summary>The H.264 compression format, baseline profile, level 4.0.</summary>
		H264Baseline40 = 5,
		/// <summary>The H.264 compression format, baseline profile, level 4.1.</summary>
		H264Baseline41 = 6,
		/// <summary>The H.264 compression format, baseline profile, level 4.2.</summary>
		H264Baseline42 = 7,
		/// <summary>The H.264 compression format, baseline profile, level 5.0.</summary>
		H264Baseline50 = 8,
		/// <summary>The H.264 compression format, baseline profile, level 5.1.</summary>
		H264Baseline51 = 9,
		/// <summary>The H.264 compression format, baseline profile, level 5.2.</summary>
		H264Baseline52 = 10,
		/// <summary>The H.264 compression format, baseline profile. Determine the level automatically.</summary>
		H264BaselineAutoLevel = 11,
		/// <summary>The H.264 compression format, main profile, level 3.0.</summary>
		H264Main30 = 12,
		/// <summary>The H.264 compression format, main profile, level 3.1.</summary>
		H264Main31 = 13,
		/// <summary>The H.264 compression format, main profile, level 3.2.</summary>
		H264Main32 = 14,
		/// <summary>The H.264 compression format, main profile, level 4.0.</summary>
		H264Main40 = 15,
		/// <summary>The H.264 compression format, main profile, level 4.1.</summary>
		H264Main41 = 16,
		/// <summary>The H.264 compression format, main profile, level 4.2.</summary>
		H264Main42 = 17,
		/// <summary>The H.264 compression format, main profile, level 5.0.</summary>
		H264Main50 = 18,
		/// <summary>The H.264 compression format, main profile, level 5.1.</summary>
		H264Main51 = 19,
		/// <summary>The H.264 compression format, main profile, level 5.2.</summary>
		H264Main52 = 20,
		/// <summary>The H.264 compression format, main profile. Determine the level automatically.</summary>
		H264MainAutoLevel = 21,
		/// <summary>The H.264 compression format, extended profile, level 5.0.</summary>
		H264Extended50 = 22,
		/// <summary>The H.264 compression format, extended profile. Determine the level automatically.</summary>
		H264ExtendedAutoLevel = 23,
		/// <summary>The H.264 compression format, high profile, level 3.0.</summary>
		H264High30 = 24,
		/// <summary>The H.264 compression format, high profile, level 3.1.</summary>
		H264High31 = 25,
		/// <summary>The H.264 compression format, high profile, level 3.2.</summary>
		H264High32 = 26,
		/// <summary>The H.264 compression format, high profile, level 4.0.</summary>
		H264High40 = 27,
		/// <summary>The H.264 compression format, high profile, level 4.1.</summary>
		H264High41 = 28,
		/// <summary>The H.264 compression format, high profile, level 4.2.</summary>
		H264High42 = 29,
		/// <summary>The H.264 compression format, high profile, level 5.0.</summary>
		H264High50 = 30,
		/// <summary>The H.264 compression format, high profile, level 5.1.</summary>
		H264High51 = 31,
		/// <summary>The H.264 compression format, high profile, level 5.2.</summary>
		H264High52 = 32,
		/// <summary>The H.264 compression format, high profile. Determine the level automatically.</summary>
		H264HighAutoLevel = 33,
		/// <summary>The MPEG-4 simple profile, level 0.</summary>
		MP4VSimpleL0 = 34,
		/// <summary>The MPEG-4 simple profile, level 1.</summary>
		MP4VSimpleL1 = 35,
		/// <summary>The MPEG-4 simple profile, level 2.</summary>
		MP4VSimpleL2 = 36,
		/// <summary>The MPEG-4 simple profile, level 3.</summary>
		MP4VSimpleL3 = 37,
		/// <summary>The MPEG-4 main profile, level 2.</summary>
		MP4VMainL2 = 38,
		/// <summary>The MPEG-4 main profile, level 3.</summary>
		MP4VMainL3 = 39,
		/// <summary>The MPEG-4 main profile, level 4.</summary>
		MP4VMainL4 = 40,
		/// <summary>The MPEG-4 advanced simple profile, level 0.</summary>
		MP4VAdvancedSimpleL0 = 41,
		/// <summary>The MPEG-4 advanced simple profile, level 1.</summary>
		MP4VAdvancedSimpleL1 = 42,
		/// <summary>The MPEG-4 advanced simple profile, level 2.</summary>
		MP4VAdvancedSimpleL2 = 43,
		/// <summary>The MPEG-4 advanced simple profile, level 3.</summary>
		MP4VAdvancedSimpleL3 = 44,
		/// <summary>The MPEG-4 advanced simple profile, level 4.</summary>
		MP4VAdvancedSimpleL4 = 45,
		/// <summary>The H.263 compression format, profile 0, level 1.0.</summary>
		H263Profile0Level10 = 46,
		/// <summary>The H.263 compression format, profile 0, level 4.5.</summary>
		H263Profile0Level45 = 47,
		/// <summary>The H.263 compression format, profile 3, level 4.5.</summary>
		H263Profile3Level45 = 48,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		HevcMainAutoLevel = 49,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		HevcMain10AutoLevel = 50,
	}
}
