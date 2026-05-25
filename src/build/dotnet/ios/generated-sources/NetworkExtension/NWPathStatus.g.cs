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
	/// <summary>Enumerates status information about network connection paths.</summary><remarks>To be added.</remarks>
	[ObsoletedOSPlatform ("ios18.0", "Use 'Network.NWPathStatus' instead.")]
	[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Network.NWPathStatus' instead.")]
	[ObsoletedOSPlatform ("macos15.0", "Use 'Network.NWPathStatus' instead.")]
	[ObsoletedOSPlatform ("tvos18.0", "Use 'Network.NWPathStatus' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum NWPathStatus : long {
		/// <summary>Indicates that the path is not valid.</summary>
		Invalid = 0,
		/// <summary>Indicates that the path is ready for use.</summary>
		Satisfied = 1,
		/// <summary>The path cannot be used.</summary>
		Unsatisfied = 2,
		/// <summary>Indicates that the path is able to be used if, for example, a VPN becomes available or cellular data is enabled.</summary>
		Satisfiable = 3,
	}
}
