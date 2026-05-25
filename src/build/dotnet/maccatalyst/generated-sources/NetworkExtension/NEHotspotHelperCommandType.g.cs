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
	/// <summary>Enumerates commands that can be made to a Hotspot Helper to facilitate registering for Wi-Fi access.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum NEHotspotHelperCommandType : long {
		/// <summary>No command.</summary>
		None = 0,
		/// <summary>Command to filter scan list.</summary>
		FilterScanList = 1,
		/// <summary>Command to evaluate the network.</summary>
		Evaluate = 2,
		/// <summary>Command to authenticate on the network.</summary>
		Authenticate = 3,
		/// <summary>Command to present a user interface.</summary>
		PresentUI = 4,
		/// <summary>Command to maintain the network connection.</summary>
		Maintain = 5,
		/// <summary>Command to log off.</summary>
		Logoff = 6,
	}
}
