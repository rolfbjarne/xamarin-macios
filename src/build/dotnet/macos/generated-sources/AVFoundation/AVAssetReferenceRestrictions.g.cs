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
namespace AVFoundation {
	/// <summary>An enumeration whose values define restrictions relating to a <see cref="T:AVFoundation.AVAsset" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum AVAssetReferenceRestrictions : ulong {
		/// <summary>There are no restrictions on references to media data.</summary>
		ForbidNone = 0,
		/// <summary>Remote assets cannot require a local media resource (e.g., an HTTP URL cannot require a client-side file).</summary>
		ForbidRemoteReferenceToLocal = 1,
		/// <summary>Local asset references to remote media are not allowed.</summary>
		ForbidLocalReferenceToRemote = 2,
		/// <summary>Remote asset references to a different site are not allowed.</summary>
		ForbidCrossSiteReference = 4,
		/// <summary>Local asset references to local media outside the container are not allowed.</summary>
		ForbidLocalReferenceToLocal = 8,
		/// <summary>Only references to media data stored within the asset's container are allowed.</summary>
		ForbidAll = 65535,
	}
}
