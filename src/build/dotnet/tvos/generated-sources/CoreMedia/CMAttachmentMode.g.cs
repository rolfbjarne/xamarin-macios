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
namespace CoreMedia {
	/// <summary>Enumerates attachment propagation policies.</summary><remarks>This setting controls whether <see cref="CoreMedia.CMAttachmentBearer.PropagateAttachments(CoreMedia.ICMAttachmentBearer,CoreMedia.ICMAttachmentBearer)" /> will propagate a given attachment.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CMAttachmentMode : uint {
		/// <summary>Indicates that the attachment does not propagate.</summary>
		ShouldNotPropagate = 0,
		/// <summary>Indicates that the attachment will propagate.</summary>
		ShouldPropagate = 1,
	}
}
