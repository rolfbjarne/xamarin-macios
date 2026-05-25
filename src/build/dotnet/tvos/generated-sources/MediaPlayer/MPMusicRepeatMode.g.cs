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
namespace MediaPlayer {
	/// <summary>An enumeration of music repeat modes. Used with the <see cref="P:MediaPlayer.MPMusicPlayerController.RepeatMode" /> property.</summary><remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum MPMusicRepeatMode : long {
		/// <summary>To be added.</summary>
		Default = 0,
		/// <summary>To be added.</summary>
		None = 1,
		/// <summary>To be added.</summary>
		One = 2,
		/// <summary>To be added.</summary>
		All = 3,
	}
}
