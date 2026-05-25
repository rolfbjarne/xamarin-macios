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
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[NativeName ("UMPStreamMessageStatus")]
	public enum UmpStreamMessageStatus : uint {
		EndpointDiscovery = 0,
		EndpointInfoNotification = 1,
		DeviceIdentityNotification = 2,
		EndpointNameNotification = 3,
		ProductInstanceIDNotification = 4,
		StreamConfigurationRequest = 5,
		StreamConfigurationNotification = 6,
		FunctionBlockDiscovery = 16,
		FunctionBlockInfoNotification = 17,
		FunctionBlockNameNotification = 18,
		StartOfClip = 32,
		EndOfClip = 33,
	}
}
