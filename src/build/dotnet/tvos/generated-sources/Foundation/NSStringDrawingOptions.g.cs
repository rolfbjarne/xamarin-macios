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
namespace Foundation {
	/// <summary>An enumeration of options for use when drawing strings.</summary><remarks>To be added.</remarks>
	[Flags]
	[Native]
	public enum NSStringDrawingOptions : ulong {
		/// <summary>To be added.</summary>
		UsesLineFragmentOrigin = 1,
		/// <summary>To be added.</summary>
		UsesFontLeading = 2,
		/// <summary>This value is OSX-specific (not available in iOS)</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.11")]
		[SupportedOSPlatform ("macos")]
		DisableScreenFontSubstitution = 4,
		/// <summary>To be added.</summary>
		UsesDeviceMetrics = 8,
		/// <summary>This value is OSX-specific (not available in iOS)</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.11")]
		[SupportedOSPlatform ("macos")]
		OneShot = 16,
		/// <summary>To be added.</summary>
		TruncatesLastVisibleLine = 32,
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		OptionsResolvesNaturalAlignmentWithBaseWritingDirection = 512,
	}
}
