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
namespace HealthKit {
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[Native]
	public enum HKWorkoutSessionState : long {
		NotStarted = 1,
		Running = 2,
		Ended = 3,
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos13.0")]
		Paused = 4,
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos13.0")]
		Prepared = 5,
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos13.0")]
		Stopped = 6,
	}
}
