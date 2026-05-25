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
namespace NetworkExtension {
	/// <summary>Enumerates the state of a VPN connection.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum NEVpnStatus : long {
		/// <summary>The VPN configuration is invalid or disabled.</summary>
		Invalid = 0,
		/// <summary>The VPN is disconnected.</summary>
		Disconnected = 1,
		/// <summary>The VPN is in the process of attempting to connect.</summary>
		Connecting = 2,
		/// <summary>The VPN is connected.</summary>
		Connected = 3,
		/// <summary>The VPN is in the process of reconnecting.</summary>
		Reasserting = 4,
		/// <summary>The VPN is in the process of attempting to disconnect.</summary>
		Disconnecting = 5,
	}
}
