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
namespace CoreLocation {
	/// <summary>An enumeration whose values specify the current status of authorization to use location services.</summary>
	public enum CLAuthorizationStatus : uint {
		/// <summary>The user has not yet chosen whether to allow location services.</summary>
		NotDetermined = 0,
		/// <summary>Location services are not available and the user cannot change the authorization (e.g., constrained by parental controls).</summary>
		Restricted = 1,
		/// <summary>The app is not allowed to use location services.</summary>
		Denied = 2,
		/// <summary>Developers should not use this deprecated field. Developers should use 'AuthorizedAlways' instead.</summary>
		[ObsoletedOSPlatform ("ios8.0", "Use 'AuthorizedAlways' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AuthorizedAlways' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		Authorized = 3,
		/// <summary>To be added.</summary>
		AuthorizedAlways = 3,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		AuthorizedWhenInUse = 4,
	}
}
