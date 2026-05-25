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
	/// <summary>Enumerates safe area inset adjustment behaviors.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIScrollViewContentInsetAdjustmentBehavior : long {
		/// <summary>Indicates that safe area insets are automatically adjusted when content is adjusted.</summary>
		Automatic = 0,
		/// <summary>Indicates that safe area insets are adjusted only in scroll directions.</summary>
		ScrollableAxes = 1,
		/// <summary>Indicates that safe area insets are never included in content adjustment.</summary>
		Never = 2,
		/// <summary>Indicates that safe area insets are always included in content adjustment.</summary>
		Always = 3,
	}
}
