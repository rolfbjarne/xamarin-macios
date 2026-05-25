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
namespace CoreWlan {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum CWEventType : long {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		PowerDidChange = 1,
		/// <summary>To be added.</summary>
		SsidDidChange = 2,
		/// <summary>To be added.</summary>
		BssidDidChange = 3,
		/// <summary>To be added.</summary>
		CountryCodeDidChange = 4,
		/// <summary>To be added.</summary>
		LinkDidChange = 5,
		/// <summary>To be added.</summary>
		LinkQualityDidChange = 6,
		/// <summary>To be added.</summary>
		ModeDidChange = 7,
		/// <summary>To be added.</summary>
		ScanCacheUpdated = 8,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos11.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		VirtualInterfaceStateChanged = 9,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos11.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		RangingReportEvent = 10,
		/// <summary>To be added.</summary>
		Unknown = 9223372036854775807,
	}
}
