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
namespace MultipeerConnectivity {
	/// <summary>An enumeration whose values indicate the state of a <see cref="T:MultipeerConnectivity.MCSession" />. Used with <see cref="M:MultipeerConnectivity.MCSessionDelegate.DidChangeState(MultipeerConnectivity.MCSession,MultipeerConnectivity.MCPeerID,MultipeerConnectivity.MCSessionState)" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum MCSessionState : long {
		/// <summary>Indicates that the <see cref="T:MultipeerConnectivity.MCSession" /> is not connected.</summary>
		NotConnected = 0,
		/// <summary>Indicates that the <see cref="T:MultipeerConnectivity.MCSession" /> is in the process of connecting.</summary>
		Connecting = 1,
		/// <summary>Indicates that the <see cref="T:MultipeerConnectivity.MCSession" /> is connected.</summary>
		Connected = 2,
	}
}
