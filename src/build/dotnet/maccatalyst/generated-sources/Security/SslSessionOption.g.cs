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
namespace Security {
	/// <summary>Enumerates SSL session behavior options.</summary>
	[ObsoletedOSPlatform ("macos10.15", "Use 'Network.framework' instead.")]
	[ObsoletedOSPlatform ("ios13.0", "Use 'Network.framework' instead.")]
	[ObsoletedOSPlatform ("tvos13.0", "Use 'Network.framework' instead.")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'Network.framework' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum SslSessionOption : int {
		/// <summary>To be added.</summary>
		BreakOnServerAuth = 0,
		/// <summary>To be added.</summary>
		BreakOnCertRequested = 1,
		/// <summary>To be added.</summary>
		BreakOnClientAuth = 2,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'Network.framework' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		FalseStart = 3,
		/// <summary>To be added.</summary>
		SendOneByteRecord = 4,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'Network.framework' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		AllowServerIdentityChange = 5,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'Network.framework' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Fallback = 6,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'Network.framework' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		BreakOnClientHello = 7,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'Network.framework' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		AllowRenegotiation = 8,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'Network.framework' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'Network.framework' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		EnableSessionTickets = 9,
	}
}
