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
namespace AVFoundation {
	/// <summary>An enumeration whose values specify how interlaced fields should be dealt with.</summary><!-- TODO: This should be used with AVCaptureConnection.VideoFieldMode property, but that doesn't appear to exist  -->
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum AVVideoFieldMode : long {
		/// <summary>Both top and bottom interlaced video fields should be passed through.</summary>
		Both = 0,
		/// <summary>Only the top interlaced video field should be passed through.</summary>
		TopOnly = 1,
		/// <summary>Only the bottom interlaced video field should be passed through.</summary>
		BottomOnly = 2,
		/// <summary>The top and bottom fields should be de-interlaced.</summary>
		Deinterlace = 3,
	}
}
