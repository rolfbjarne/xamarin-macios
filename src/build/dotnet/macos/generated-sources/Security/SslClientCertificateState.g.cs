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
	/// <summary>Enumerates stages in an SSL client certificate exchange.</summary>
	[ObsoletedOSPlatform ("macos10.15", "Use 'Network.framework' instead.")]
	[ObsoletedOSPlatform ("ios13.0", "Use 'Network.framework' instead.")]
	[ObsoletedOSPlatform ("tvos13.0", "Use 'Network.framework' instead.")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'Network.framework' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum SslClientCertificateState : int {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		Requested = 1,
		/// <summary>To be added.</summary>
		Sent = 2,
		/// <summary>To be added.</summary>
		Rejected = 3,
	}
}
