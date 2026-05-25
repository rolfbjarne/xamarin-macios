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
namespace Photos {
	/// <summary>Enumerates values that indicate the subtype of the collection.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum PHCollectionListSubtype : long {
		/// <summary>The collection is a moment list cluster.</summary>
		[ObsoletedOSPlatform ("ios13.0")]
		[ObsoletedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		MomentListCluster = 1,
		/// <summary>The collection is a moment list year.</summary>
		[ObsoletedOSPlatform ("ios13.0")]
		[ObsoletedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		MomentListYear = 2,
		/// <summary>The collection is a regular folder.</summary>
		RegularFolder = 100,
		/// <summary>The collection is a smart folder of events.</summary>
		SmartFolderEvents = 200,
		/// <summary>The collection is a smart folder of faces.</summary>
		SmartFolderFaces = 201,
		/// <summary>The collection subtype is unspecified.</summary>
		Any = 9223372036854775807,
	}
}
