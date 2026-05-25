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
namespace MetalPerformanceShaders {
	/// <summary>Options for how a neural network graph will pad results.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum MPSNNPaddingMethod : ulong {
		/// <summary>To be added.</summary>
		AlignCentered = 0,
		/// <summary>To be added.</summary>
		AlignTopLeft = 1,
		/// <summary>To be added.</summary>
		AlignBottomRight = 2,
		/// <summary>To be added.</summary>
		AlignReserved = 3,
		/// <summary>To be added.</summary>
		AddRemainderToTopLeft = 0,
		/// <summary>To be added.</summary>
		AddRemainderToTopRight = 4,
		/// <summary>To be added.</summary>
		AddRemainderToBottomLeft = 8,
		/// <summary>To be added.</summary>
		AddRemainderToBottomRight = 12,
		/// <summary>To be added.</summary>
		SizeValidOnly = 0,
		/// <summary>To be added.</summary>
		SizeSame = 16,
		/// <summary>To be added.</summary>
		SizeFull = 32,
		/// <summary>To be added.</summary>
		SizeReserved = 48,
		/// <summary>To be added.</summary>
		CustomWhitelistForNodeFusion = 8192,
		/// <summary>To be added.</summary>
		Custom = 16384,
		/// <summary>To be added.</summary>
		SizeMask = 2032,
		/// <summary>To be added.</summary>
		ExcludeEdges = 32768,
	}
}
