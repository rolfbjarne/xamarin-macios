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
namespace CloudKit {
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[Native]
	public enum CKSyncEngineEventType : long {
		StateUpdate = 0,
		AccountChange = 1,
		FetchedDatabaseChanges = 2,
		FetchedRecordZoneChanges = 3,
		SentDatabaseChanges = 4,
		SentRecordZoneChanges = 5,
		WillFetchChanges = 6,
		WillFetchRecordZoneChanges = 7,
		DidFetchRecordZoneChanges = 8,
		DidFetchChanges = 9,
		WillSendChanges = 10,
		DidSendChanges = 11,
	}
}
