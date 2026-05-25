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
namespace AudioToolbox {
	/// <summary>This enum specifies parameters for <see cref="AudioUnitSubType.AUAudioMix" /> audio units.</summary>
	public enum AUAudioMixParameter : int {
		/// <summary>Get or set the style of the audio mixing, using a value of the <see cref="T:AudioToolbox.AUAudioMixRenderingStyle" /> enum.</summary>
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		Style = 0,
		/// <summary>The remix amount, which is a <see langword="float" />, with valid values ranging from 0.0f to 1.0f. The default value is 0.5f.</summary>
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		RemixAmount = 1,
	}
}
