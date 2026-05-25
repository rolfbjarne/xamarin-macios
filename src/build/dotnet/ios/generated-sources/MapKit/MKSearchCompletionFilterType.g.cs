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
namespace MapKit {
	/// <summary>Enumerates values that control whether search queries, in addition to place results, are included in completion lists.</summary><remarks>To be added.</remarks>
	[ObsoletedOSPlatform ("ios13.0", "Use 'MKLocalSearchCompleterResultType' instead.")]
	[ObsoletedOSPlatform ("macos10.15", "Use 'MKLocalSearchCompleterResultType' instead.")]
	[ObsoletedOSPlatform ("tvos13.0", "Use 'MKLocalSearchCompleterResultType' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'MKLocalSearchCompleterResultType' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum MKSearchCompletionFilterType : long {
		/// <summary>Include related search queries in the completion results, in addition to place names.</summary>
		AndQueries = 0,
		/// <summary>Only include place names in the completion results.</summary>
		Only = 1,
	}
}
