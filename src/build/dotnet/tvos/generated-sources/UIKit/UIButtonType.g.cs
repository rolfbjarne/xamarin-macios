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
	/// <summary>An enumeration of predefined button types.</summary><remarks>The type of a <see cref="T:UIKit.UIButton" />.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIButtonType : long {
		/// <summary>No button style.</summary>
		Custom = 0,
		/// <summary>Rounded rectangle style. This style is deprecated as of iOS 7; developers should use <see cref="F:UIKit.UIButtonType.System" />.</summary>
		RoundedRect = 1,
		/// <summary>Uses a detail disclosure button (arrow).</summary>
		DetailDisclosure = 2,
		/// <summary>Information button, light background.</summary>
		InfoLight = 3,
		/// <summary>Information button, dark background.</summary>
		InfoDark = 4,
		/// <summary>The contact add button.</summary>
		ContactAdd = 5,
		/// <summary>A standard system button.</summary>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		Plain = 6,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		Close = 7,
		/// <summary>Added in iOS 7, this is the preferred default style. It lacks visible edges, background, etc.</summary>
		System = 1,
	}
}
