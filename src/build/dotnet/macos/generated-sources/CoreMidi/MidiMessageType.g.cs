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
namespace CoreMidi {
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[NativeName ("MIDIMessageType")]
	public enum MidiMessageType : uint {
		Utility = 0,
		System = 1,
		ChannelVoice1 = 2,
		SysEx = 3,
		ChannelVoice2 = 4,
		Data128 = 5,
		FlexData = 13,
		[ObsoletedOSPlatform ("ios18.0", "Use 'Stream' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Stream' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Stream' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Stream' instead.")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		UnknownF = 15,
		Stream = 15,
		Invalid = 255,
	}
}
