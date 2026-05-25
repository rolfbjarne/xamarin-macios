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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MultipeerConnectivity {
	/// <summary>An enumeration whose values specify whether an <see cref="T:MultipeerConnectivity.MCSession" /> should encrypt its connection. Used with <see cref="MultipeerConnectivity.MCSession(MultipeerConnectivity.MCPeerID,Security.SecIdentity, MultipeerConnectivity.MCEncryptionPreference)" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum MCEncryptionPreference : long {
		/// <summary>No preference.</summary>
		Optional = 0,
		/// <summary>Connections should be encrypted.</summary>
		Required = 1,
		/// <summary>A preference for unencrypted connections.</summary>
		None = 2,
	}
}
