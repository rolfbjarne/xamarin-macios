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
namespace MediaAccessibility {
	/// <summary>Enumerates values that indicate whether to raise caption text, use drop shadows on them, or etc.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum MACaptionAppearanceTextEdgeStyle : long {
		/// <summary>To be added.</summary>
		Undefined = 0,
		/// <summary>To be added.</summary>
		None = 1,
		/// <summary>To be added.</summary>
		Raised = 2,
		/// <summary>To be added.</summary>
		Depressed = 3,
		/// <summary>To be added.</summary>
		Uniform = 4,
		/// <summary>To be added.</summary>
		DropShadow = 5,
	}
}
