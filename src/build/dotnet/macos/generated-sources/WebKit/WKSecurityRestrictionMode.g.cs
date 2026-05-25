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
namespace WebKit {
	/// <summary>Security restriction modes for WebView content.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos26.4")]
	[SupportedOSPlatform ("ios26.4")]
	[SupportedOSPlatform ("maccatalyst26.4")]
	[Native]
	public enum WKSecurityRestrictionMode : long {
		/// <summary>No additional security restrictions beyond WebKit defaults.</summary>
		None = 0,
		/// <summary>Enhanced security protections optimized for maintaining web compatibility. Disables JIT compilation and enables increased MTE adoption.</summary>
		MaximizeCompatibility = 1,
		/// <summary>Maximum security restrictions including feature disablement. Applied automatically by the system in Lockdown Mode.</summary>
		Lockdown = 2,
	}
}
