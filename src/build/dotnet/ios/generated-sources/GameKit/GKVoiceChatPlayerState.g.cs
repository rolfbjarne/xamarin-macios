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
namespace GameKit {
	/// <summary>An enumeration whose values specify the state of a <see cref="T:GameKit.GKVoiceChat" /> channel. (See <see cref="T:GameKit.GKPlayerStateUpdateHandler" />.)</summary><remarks>To be added.</remarks>
	[ObsoletedOSPlatform ("ios18.0", "No longer supported.")]
	[ObsoletedOSPlatform ("maccatalyst18.0", "No longer supported.")]
	[ObsoletedOSPlatform ("tvos18.0", "No longer supported.")]
	[ObsoletedOSPlatform ("macos15.0", "No longer supported.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[Native]
	public enum GKVoiceChatPlayerState : long {
		/// <summary>To be added.</summary>
		Connected = 0,
		/// <summary>To be added.</summary>
		Disconnected = 1,
		/// <summary>To be added.</summary>
		Speaking = 2,
		/// <summary>To be added.</summary>
		Silent = 3,
		/// <summary>To be added.</summary>
		Connecting = 4,
	}
}
