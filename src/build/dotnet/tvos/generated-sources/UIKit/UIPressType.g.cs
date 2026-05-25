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
	/// <summary>Enumerates button types for <see cref="T:UIKit.UIPress" /> objects (see <see cref="P:UIKit.UIPress.Type" />).</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIPressType : long {
		/// <summary>Arrow pointing up.</summary>
		UpArrow = 0,
		/// <summary>Arrow pointing down.</summary>
		DownArrow = 1,
		/// <summary>Arrow pointing left.</summary>
		LeftArrow = 2,
		/// <summary>Arrow pointing right.</summary>
		RightArrow = 3,
		/// <summary>Button indicating selection.</summary>
		Select = 4,
		/// <summary>The dedicated Menu button.</summary>
		Menu = 5,
		/// <summary>The button dedicated to toggling playback.</summary>
		PlayPause = 6,
		[SupportedOSPlatform ("tvos14.3")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		PageUp = 30,
		[SupportedOSPlatform ("tvos14.3")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		PageDown = 31,
		[SupportedOSPlatform ("tvos18.1")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		TVRemoteOneTwoThree = 32,
		[SupportedOSPlatform ("tvos18.1")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		TVRemoteFourColors = 33,
	}
}
