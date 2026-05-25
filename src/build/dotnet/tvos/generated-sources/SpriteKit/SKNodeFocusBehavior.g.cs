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
namespace SpriteKit {
	/// <summary>Enumerates the various ways a <see cref="T:SpriteKit.SKNode" /> may be focusable.</summary>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum SKNodeFocusBehavior : long {
		/// <summary>The <see cref="T:SpriteKit.SKNode" /> is not focusable.</summary>
		None = 0,
		/// <summary>The <see cref="T:SpriteKit.SKNode" /> is not focusable. It prevents nodes it obscures from being focused.</summary>
		Occluding = 1,
		/// <summary>The <see cref="T:SpriteKit.SKNode" /> is focusable. It prevents nodes it obscures from being focused.</summary>
		Focusable = 2,
	}
}
