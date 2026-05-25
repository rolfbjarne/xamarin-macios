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
namespace Security {
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[NativeName ("tls_ciphersuite_t")]
	public enum TlsCipherSuite : ushort {
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		RsaWith3desEdeCbcSha = 10,
		RsaWithAes128CbcSha = 47,
		RsaWithAes256CbcSha = 53,
		RsaWithAes128GcmSha256 = 156,
		RsaWithAes256GcmSha384 = 157,
		RsaWithAes128CbcSha256 = 60,
		RsaWithAes256CbcSha256 = 61,
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		EcdheEcdsaWith3desEdeCbcSha = 49160,
		EcdheEcdsaWithAes128CbcSha = 49161,
		EcdheEcdsaWithAes256CbcSha = 49162,
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		EcdheRsaWith3desEdeCbcSha = 49170,
		EcdheRsaWithAes128CbcSha = 49171,
		EcdheRsaWithAes256CbcSha = 49172,
		EcdheEcdsaWithAes128CbcSha256 = 49187,
		EcdheEcdsaWithAes256CbcSha384 = 49188,
		EcdheRsaWithAes128CbcSha256 = 49191,
		EcdheRsaWithAes256CbcSha384 = 49192,
		EcdheEcdsaWithAes128GcmSha256 = 49195,
		EcdheEcdsaWithAes256GcmSha384 = 49196,
		EcdheRsaWithAes128GcmSha256 = 49199,
		EcdheRsaWithAes256GcmSha384 = 49200,
		EcdheRsaWithChacha20Poly1305Sha256 = 52392,
		EcdheEcdsaWithChacha20Poly1305Sha256 = 52393,
		Aes128GcmSha256 = 4865,
		Aes256GcmSha384 = 4866,
		Chacha20Poly1305Sha256 = 4867,
	}
}
