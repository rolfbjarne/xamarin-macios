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
namespace Security {
	[ObsoletedOSPlatform ("macos10.15", "Use 'TlsCipherSuiteGroup' instead.")]
	[ObsoletedOSPlatform ("ios13.0", "Use 'TlsCipherSuiteGroup' instead.")]
	[ObsoletedOSPlatform ("tvos13.0", "Use 'TlsCipherSuiteGroup' instead.")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'TlsCipherSuiteGroup' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum SslCipherSuiteGroup : int {
		/// <summary>To be added.</summary>
		Default = 0,
		/// <summary>To be added.</summary>
		Compatibility = 1,
		/// <summary>To be added.</summary>
		Legacy = 2,
		/// <summary>To be added.</summary>
		Ats = 3,
		/// <summary>To be added.</summary>
		AtsCompatibility = 4,
		/// <summary>The ciphersuite group that conforms to the App Transport Security Forward Compatibility Profile version 2.1.</summary>
		[SupportedOSPlatform ("ios26.5")]
		[SupportedOSPlatform ("tvos26.5")]
		[SupportedOSPlatform ("macos26.5")]
		[SupportedOSPlatform ("maccatalyst26.5")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'TlsCipherSuiteGroup' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'TlsCipherSuiteGroup' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'TlsCipherSuiteGroup' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'TlsCipherSuiteGroup' instead.")]
		AtsFcpV21 = 5,
	}
}
