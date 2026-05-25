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
namespace AVFoundation {
	/// <summary>Enumerates states for physical image stabilization hardware.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum AVCaptureLensStabilizationStatus : long {
		/// <summary>Indicates that stabilization hardware is not present.</summary>
		Unsupported = 0,
		/// <summary>Indicates that the stabilization hardware is off.</summary>
		Off = 1,
		/// <summary>Indicates that the stabilization hardware is active.</summary>
		Active = 2,
		/// <summary>Indicates that the stabilization hardware reached or exceeded the range that it can stabilize.</summary>
		OutOfRange = 3,
		/// <summary>Indicates that stabilization hardware is present but unavailable.</summary>
		Unavailable = 4,
	}
}
