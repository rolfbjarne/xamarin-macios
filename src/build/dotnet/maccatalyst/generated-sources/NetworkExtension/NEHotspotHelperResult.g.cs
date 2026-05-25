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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace NetworkExtension {
	/// <summary>Enumerates Hotspot Helper command response results.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum NEHotspotHelperResult : long {
		/// <summary>The command succeeded.</summary>
		Success = 0,
		/// <summary>The command failed.</summary>
		Failure = 1,
		/// <summary>In response to an "authenticate" command, user interaction is needed.</summary>
		UIRequired = 2,
		/// <summary>The command was not recognized.</summary>
		CommandNotRecognized = 3,
		/// <summary>In response to a "maintain" command, the network requires reauthentication.</summary>
		AuthenticationRequired = 4,
		/// <summary>The network is not supported.</summary>
		UnsupportedNetwork = 5,
		/// <summary>In response to an "authenticate" or "presentUI" command, a temporary failure resulted.</summary>
		TemporaryFailure = 6,
	}
}
