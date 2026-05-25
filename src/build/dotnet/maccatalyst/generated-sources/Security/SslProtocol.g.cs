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
	/// <summary>Enumerates SSL protocols.</summary>
	[ObsoletedOSPlatform ("macos10.15", "Use 'TlsProtocolVersion' instead.")]
	[ObsoletedOSPlatform ("ios13.0", "Use 'TlsProtocolVersion' instead.")]
	[ObsoletedOSPlatform ("tvos13.0", "Use 'TlsProtocolVersion' instead.")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'TlsProtocolVersion' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum SslProtocol : int {
		/// <summary>To be added.</summary>
		Unknown = 0,
		/// <summary>To be added.</summary>
		Ssl_3_0 = 2,
		/// <summary>To be added.</summary>
		Tls_1_0 = 4,
		/// <summary>To be added.</summary>
		Tls_1_1 = 7,
		/// <summary>To be added.</summary>
		Tls_1_2 = 8,
		/// <summary>To be added.</summary>
		Dtls_1_0 = 9,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'TlsProtocolVersion' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'TlsProtocolVersion' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'TlsProtocolVersion' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'TlsProtocolVersion' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Tls_1_3 = 10,
		Dtls_1_2 = 11,
		/// <summary>To be added.</summary>
		Ssl_2_0 = 1,
		/// <summary>To be added.</summary>
		Ssl_3_0_only = 3,
		/// <summary>To be added.</summary>
		Tls_1_0_only = 5,
		/// <summary>To be added.</summary>
		All = 6,
	}
}
