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
	/// <summary>An enumeration indicating the scrolling direction desired.</summary><remarks>Used as the argument to <see cref="UIResponder.AccessibilityScroll" /> to generate a scrolling action.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIAccessibilityScrollDirection : long {
		/// <summary>Indicates a scroll to the right.</summary>
		Right = 1,
		/// <summary>Indicates a scroll to the left.</summary>
		Left = 2,
		/// <summary>Indicates a scroll upwards.</summary>
		Up = 3,
		/// <summary>Indicates a scroll downwards.</summary>
		Down = 4,
		/// <summary>Indicates a scroll to the next logical position.</summary>
		Next = 5,
		/// <summary>Indicates a scroll to the previous position.</summary>
		Previous = 6,
	}
}
