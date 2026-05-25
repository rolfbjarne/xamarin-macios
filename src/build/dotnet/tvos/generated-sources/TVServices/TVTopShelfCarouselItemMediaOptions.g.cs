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
namespace TVServices {
	[SupportedOSPlatform ("tvos13.0")]
	[Flags]
	[Native]
	public enum TVTopShelfCarouselItemMediaOptions : ulong {
		VideoResolutionHD = 1,
		VideoResolution4K = 2,
		VideoColorSpaceHdr = 64,
		VideoColorSpaceDolbyVision = 128,
		AudioDolbyAtmos = 4096,
		AudioTranscriptionClosedCaptioning = 8192,
		AudioTranscriptionSdh = 16384,
		AudioDescription = 32768,
	}
}
