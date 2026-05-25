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
	[NativeName ("tls_ciphersuite_group_t")]
	public enum TlsCipherSuiteGroup : ushort {
		Default = 0,
		Compatibility = 1,
		Legacy = 2,
		Ats = 3,
		AtsCompatibility = 4,
		/// <summary>The ciphersuite group that conforms to the App Transport Security Forward Compatibility Profile version 2.1.</summary>
		[SupportedOSPlatform ("ios26.5")]
		[SupportedOSPlatform ("tvos26.5")]
		[SupportedOSPlatform ("macos26.5")]
		[SupportedOSPlatform ("maccatalyst26.5")]
		AtsFcpV21 = 5,
	}
}
