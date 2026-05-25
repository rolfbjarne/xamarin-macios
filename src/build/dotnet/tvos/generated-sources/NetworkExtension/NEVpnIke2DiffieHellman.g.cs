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
namespace NetworkExtension {
	/// <summary>Enumeration of Diffie Hellman groups, which determine encryption strength.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native ("NEVPNIKEv2DiffieHellmanGroup")]
	public enum NEVpnIke2DiffieHellman : long {
		/// <summary>To be added.</summary>
		Invalid = 0,
		/// <summary>To be added.</summary>
		Group0 = 0,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios26.0", "Groups less than 14 are not supported anymore.")]
		[ObsoletedOSPlatform ("macos26.0", "Groups less than 14 are not supported anymore.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Groups less than 14 are not supported anymore.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		Group1 = 1,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios26.0", "Groups less than 14 are not supported anymore.")]
		[ObsoletedOSPlatform ("macos26.0", "Groups less than 14 are not supported anymore.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Groups less than 14 are not supported anymore.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		Group2 = 2,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios26.0", "Groups less than 14 are not supported anymore.")]
		[ObsoletedOSPlatform ("macos26.0", "Groups less than 14 are not supported anymore.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Groups less than 14 are not supported anymore.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		Group5 = 5,
		/// <summary>To be added.</summary>
		Group14 = 14,
		/// <summary>To be added.</summary>
		Group15 = 15,
		/// <summary>To be added.</summary>
		Group16 = 16,
		/// <summary>To be added.</summary>
		Group17 = 17,
		/// <summary>To be added.</summary>
		Group18 = 18,
		/// <summary>To be added.</summary>
		Group19 = 19,
		/// <summary>To be added.</summary>
		Group20 = 20,
		/// <summary>To be added.</summary>
		Group21 = 21,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Group31 = 31,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		Group32 = 32,
	}
}
