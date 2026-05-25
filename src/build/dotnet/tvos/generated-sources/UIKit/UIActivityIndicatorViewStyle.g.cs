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
namespace UIKit {
	/// <summary>The visual style for a <see cref="T:UIKit.UIActivityIndicatorView" />.</summary><remarks>To be added.</remarks><altmember cref="T:UIKit.UIActivityIndicatorView" /><altmember cref="UIKit.UIActivityIndicatorView.UIActivityIndicatorViewAppearance" />
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIActivityIndicatorViewStyle : long {
		/// <summary>The indicator is large and white.</summary>
		[ObsoletedOSPlatform ("ios13.0", "Use 'Large' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'Large' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'Large' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		WhiteLarge = 0,
		/// <summary>The indicator is white.</summary>
		[ObsoletedOSPlatform ("ios13.0", "Use 'Medium' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'Medium' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'Medium' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		White = 1,
		/// <summary>The indicator is gray.</summary>
		[ObsoletedOSPlatform ("ios13.0", "Use 'Medium' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'Medium' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'Medium' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		Gray = 2,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		Medium = 100,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		Large = 101,
	}
}
