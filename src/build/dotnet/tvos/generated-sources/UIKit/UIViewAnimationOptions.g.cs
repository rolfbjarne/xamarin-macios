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
	/// <summary>An enumeration indicating animation options.</summary><remarks></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum UIViewAnimationOptions : ulong {
		/// <summary>Lays out subviews at commit time so they are animated along with their parent.</summary>
		LayoutSubviews = 1,
		/// <summary>This flag instructs the system to keep sending input events to the view during the animation.   By default input events are disabled when an animation is taking place.</summary>
		AllowUserInteraction = 2,
		/// <summary>Starts the animation from the current view state.</summary>
		BeginFromCurrentState = 4,
		/// <summary>If set, the animation will repeat.</summary>
		Repeat = 8,
		/// <summary>If set, the animation will automatically reverse once it completes.</summary>
		Autoreverse = 16,
		/// <summary>If set, the animation will use the original duration value, rather than the remaining duration of the in-flight animation.</summary>
		OverrideInheritedDuration = 32,
		/// <summary>If set, the animation will use the original curve specified when the animation was submitted, not the curve of the in-flight animation.</summary>
		OverrideInheritedCurve = 64,
		/// <summary>If set, views are animated by changing their properties and redrawing. If not set, the views are animated using a snapshot image.</summary>
		AllowAnimatedContent = 128,
		/// <summary>If set, views are hidden and shown (not removed or added) during transition. Both views must already be in the parent view's hierarchy.</summary>
		ShowHideTransitionViews = 256,
		/// <summary>The option to not inherit the animation type or any other options.</summary>
		OverrideInheritedOptions = 512,
		/// <summary>Uses an EasyInOut animation.</summary>
		CurveEaseInOut = 0,
		/// <summary>Uses an EaseIn animation.</summary>
		CurveEaseIn = 65536,
		/// <summary>Uses an EaseOut animation.</summary>
		CurveEaseOut = 131072,
		/// <summary>Uses a linear animation.</summary>
		CurveLinear = 196608,
		/// <summary>No transition.</summary>
		TransitionNone = 0,
		/// <summary>A transition that flips a view around its vertical axis from left to right. The left side comes forward and the right moves backward.</summary>
		TransitionFlipFromLeft = 1048576,
		/// <summary>A transition that flips a view around its vertical axis from right to left. The right side comes forward and the left moves backward.</summary>
		TransitionFlipFromRight = 2097152,
		/// <summary>A transition that curls a view up from the bottom.</summary>
		TransitionCurlUp = 3145728,
		/// <summary>A transition that curls a view down from the top.</summary>
		TransitionCurlDown = 4194304,
		/// <summary>A transition that dissolves between views.</summary>
		TransitionCrossDissolve = 5242880,
		/// <summary>A transition that flips a view around its horizontal axis from top to bottom. The top moves forward and the bottom moves back.</summary>
		TransitionFlipFromTop = 6291456,
		/// <summary>A transition that flips a view around its horizontal axis from bottom to top. The bottom moves forward and the top moves back.</summary>
		TransitionFlipFromBottom = 7340032,
		/// <summary>Constant that indicates that the default frame rate is preferred for animations.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		PreferredFramesPerSecondDefault = 0,
		/// <summary>Constant that indicates that 60 frames per second are preferred for animations.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		PreferredFramesPerSecond60 = 50331648,
		/// <summary>Constant that indicates that 30 frames per second are preferred for animations.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		PreferredFramesPerSecond30 = 117440512,
		/// <summary>Forces layout updates to flush immediately after animation changes.</summary>
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		FlushUpdates = 268435456,
	}
}
