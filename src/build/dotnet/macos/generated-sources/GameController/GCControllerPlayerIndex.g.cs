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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace GameController {
	/// <summary>Enumerates player controller indices.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum GCControllerPlayerIndex : long {
		/// <summary>The index that represents the condition where the player index is not set. (<c>-1</c>)</summary>
		Unset = -1,
		/// <summary>The index for the first player. (<c>0</c>)</summary>
		Index1 = 0,
		/// <summary>The index for the second player. (<c>1</c>)</summary>
		Index2 = 1,
		/// <summary>The index for the third player. (<c>2</c>)</summary>
		Index3 = 2,
		/// <summary>The index for the fourth player. (<c>3</c>)</summary>
		Index4 = 3,
	}
}
