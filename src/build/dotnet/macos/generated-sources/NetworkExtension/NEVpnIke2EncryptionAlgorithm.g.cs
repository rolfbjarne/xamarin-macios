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
	/// <summary>Enumerates the algorithms that can be used for <see cref="P:NetworkExtension.NEVpnIke2SecurityAssociationParameters.EncryptionAlgorithm" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native ("NEVPNIKEv2EncryptionAlgorithm")]
	public enum NEVpnIke2EncryptionAlgorithm : long {
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios26.0", "Not supported anymore.")]
		[ObsoletedOSPlatform ("macos26.0", "Not supported anymore.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Not supported anymore.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		DES = 1,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios26.0", "Not supported anymore.")]
		[ObsoletedOSPlatform ("macos26.0", "Not supported anymore.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Not supported anymore.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		TripleDES = 2,
		/// <summary>To be added.</summary>
		AES128 = 3,
		/// <summary>To be added.</summary>
		AES256 = 4,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		AES128GCM = 5,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		AES256GCM = 6,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ChaCha20Poly1305 = 7,
	}
}
