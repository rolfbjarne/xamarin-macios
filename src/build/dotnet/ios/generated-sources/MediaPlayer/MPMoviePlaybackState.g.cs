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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MediaPlayer {
	/// <summary>An enumeration of possible states in which the <see cref="T:MediaPlayer.MPMoviePlayerController" /> may be. Used with the <see cref="P:MediaPlayer.MPMoviePlayerController.PlaybackState" /> property.</summary>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios9.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum MPMoviePlaybackState : long {
		/// <summary>To be added.</summary>
		Stopped = 0,
		/// <summary>To be added.</summary>
		Playing = 1,
		/// <summary>To be added.</summary>
		Paused = 2,
		/// <summary>To be added.</summary>
		Interrupted = 3,
		/// <summary>To be added.</summary>
		SeekingForward = 4,
		/// <summary>To be added.</summary>
		SeekingBackward = 5,
	}
}
