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
namespace NetworkExtension {
	/// <summary>Enumerates states that can be encountered while establishing a UDP connection.</summary><remarks>To be added.</remarks>
	[ObsoletedOSPlatform ("ios18.0", "Use 'Network.NWConnectionState' instead.")]
	[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Network.NWConnectionState' instead.")]
	[ObsoletedOSPlatform ("macos15.0", "Use 'Network.NWConnectionState' instead.")]
	[ObsoletedOSPlatform ("tvos18.0", "Use 'Network.NWConnectionState' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum NWUdpSessionState : long {
		/// <summary>Indicates that the session is invalid or hasn't been initialized.</summary>
		Invalid = 0,
		/// <summary>Indicates that the session is waiting for better connection conditions.</summary>
		Waiting = 1,
		/// <summary>Indicates that the session is attempting to resolve a remote endpoint.</summary>
		Preparing = 2,
		/// <summary>Indicate that data may be written and read.</summary>
		Ready = 3,
		/// <summary>Indicates that none of the endpoints can be resolved.</summary>
		Failed = 4,
		/// <summary>Indicates that the session was cancelled.</summary>
		Cancelled = 5,
	}
}
