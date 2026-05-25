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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum AVAudioSessionRouteSharingPolicy : ulong {
		/// <summary>To be added.</summary>
		Default = 0,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("ios13.0", "Use 'LongFormAudio' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'LongFormAudio' instead.")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'LongFormAudio' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.11", "Use 'LongFormAudio' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		LongForm = 1,
		LongFormAudio = 1,
		/// <summary>To be added.</summary>
		Independent = 2,
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		LongFormVideo = 3,
	}
}
