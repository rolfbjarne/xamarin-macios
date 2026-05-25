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
namespace GameKit {
	/// <summary>An enumeration whose values specify the state of a peer-to-peer connection.</summary><remarks>To be added.</remarks><altmember cref="M:GameKit.GKSession.PeersWithConnectionState(GameKit.GKPeerConnectionState)" /><altmember cref="M:GameKit.GKSessionDelegate.PeerChangedState(GameKit.GKSession,System.String,GameKit.GKPeerConnectionState)" />
	[ObsoletedOSPlatform ("ios7.0")]
	[ObsoletedOSPlatform ("tvos9.0")]
	[ObsoletedOSPlatform ("macos10.10")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum GKPeerConnectionState : int {
		/// <summary>To be added.</summary>
		Available = 0,
		/// <summary>To be added.</summary>
		Unavailable = 1,
		/// <summary>To be added.</summary>
		Connected = 2,
		/// <summary>To be added.</summary>
		Disconnected = 3,
		/// <summary>To be added.</summary>
		Connecting = 4,
		ConnectedRelay = 5,
	}
}
