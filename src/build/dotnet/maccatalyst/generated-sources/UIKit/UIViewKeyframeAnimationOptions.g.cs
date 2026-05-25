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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
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
namespace UIKit {
	/// <summary>An enumeration whose values specify valid options for the <see cref="M:UIKit.UIView.AnimateKeyframes(System.Double,System.Double,UIKit.UIViewKeyframeAnimationOptions,System.Action,UIKit.UICompletionHandler)" /> method.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIViewKeyframeAnimationOptions : ulong {
		/// <summary>The option to layout subviews at commit time so they animate with their parent.</summary>
		LayoutSubviews = 1,
		/// <summary>Whether the user can interact with the views while they are being animated.</summary>
		AllowUserInteraction = 2,
		/// <summary>Whether to start an animation from the current setting of the in-flight animation. If not set, in-flight animations are allowed to finish before the new animation is started.</summary>
		BeginFromCurrentState = 4,
		/// <summary>Whether to repeat the animation indefinitely.</summary>
		Repeat = 8,
		/// <summary>Whether to run the animation in both directions. Must be combined with the Repeat option.</summary>
		Autoreverse = 16,
		/// <summary>Whether to force an animation to use the original duration value specified when the animation was submitted. If not set, the animation inherits the remaining duration of the in-flight animation.</summary>
		OverrideInheritedDuration = 32,
		/// <summary>Whether to not inherit the animation type or any options.</summary>
		OverrideInheritedOptions = 512,
		/// <summary>Use a simple linear calculation for interpolating between keyframe values.</summary>
		CalculationModeLinear = 0,
		/// <summary>Does not interpolate keyframe values; jumps directly to each keyframe value.</summary>
		CalculationModeDiscrete = 1024,
		/// <summary>Use a simple even-pacing algorithm to interpolate between keyframe values.</summary>
		CalculationModePaced = 2048,
		/// <summary>Use a Catmull-Rom spline to interpolate between keyframe values. The Catmull-Rom parameter is not available for manipulation.</summary>
		CalculationModeCubic = 3072,
		/// <summary>Use a cubic scheme to compute intermediate frames, ignoring timing properties. Timing parameters are implicitly calculated to give the animation a constant velocity.</summary>
		CalculationModeCubicPaced = 4096,
	}
}
