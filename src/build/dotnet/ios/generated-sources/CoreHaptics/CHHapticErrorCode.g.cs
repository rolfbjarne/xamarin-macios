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
namespace CoreHaptics {
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum CHHapticErrorCode : long {
		EngineNotRunning = -4805,
		OperationNotPermitted = -4806,
		EngineStartTimeout = -4808,
		NotSupported = -4809,
		ServerInitFailed = -4810,
		ServerInterrupted = -4811,
		InvalidPatternPlayer = -4812,
		InvalidPatternData = -4813,
		InvalidPatternDictionary = -4814,
		InvalidAudioSession = -4815,
		InvalidEngineParameter = -4816,
		InvalidParameterType = -4820,
		InvalidEventType = -4821,
		InvalidEventTime = -4822,
		InvalidEventDuration = -4823,
		InvalidAudioResource = -4824,
		ResourceNotAvailable = -4825,
		BadEventEntry = -4830,
		BadParameterEntry = -4831,
		InvalidTime = -4840,
		FileNotFound = -4851,
		InsufficientPower = -4897,
		UnknownError = -4898,
		MemoryError = -4899,
	}
}
