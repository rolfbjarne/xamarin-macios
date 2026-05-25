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
	/// <summary>An enumeration whose values specify optional audio behaviors.</summary><remarks>To be added.</remarks>
	[Flags]
	[Native]
	public enum AVAudioSessionCategoryOptions : ulong {
		/// <summary>Indicates that this session's output should mix in with output from other sessions.</summary>
		MixWithOthers = 1,
		/// <summary>Indicates that output volume from other audio sessions will be reduced when this one is playing.</summary>
		DuckOthers = 2,
		/// <summary>Indicates that Bluetooth is allowed.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		AllowBluetooth = 4,
		/// <summary>Indicates that the system output should be used by default.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		DefaultToSpeaker = 8,
		/// <summary>Indicates that the output is typically spoken word output that should pause output from other sessions.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		InterruptSpokenAudioAndMixWithOthers = 17,
		/// <summary>Indicates that Bluetooth A2DP is allowed.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		AllowBluetoothA2DP = 32,
		/// <summary>Indicates that AirPlay is allowed.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		AllowAirPlay = 64,
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		OverrideMutedMicrophoneInterruption = 128,
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		BluetoothHighQualityRecording = 524288,
		[SupportedOSPlatform ("ios26.2")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst26.2")]
		[UnsupportedOSPlatform ("macos")]
		FarFieldInput = 262144,
	}
}
