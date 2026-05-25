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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	/// <summary>Enumerates layout bar metrics.</summary><remarks>To be added.</remarks><!-- TODO:  How does this behave with an iPad app? -->
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIBarMetrics : long {
		/// <summary>The default metrics for the device.</summary>
		Default = 0,
		/// <summary>Metrics for the phone idiom.</summary>
		Compact = 1,
		/// <summary>Default metrics for the device for bars with the prompt property, e.g., UINavigationBar and UISearchBar.</summary>
		DefaultPrompt = 101,
		/// <summary>Default metrics for bars with prompts on the phone idiom.</summary>
		CompactPrompt = 102,
		/// <summary>Developers should not use this deprecated field. Developers should use 'UIBarMetrics.Compat' instead.</summary>
		[ObsoletedOSPlatform ("ios8.0", "Use 'UIBarMetrics.Compat' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'UIBarMetrics.Compat' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UIBarMetrics.Compat' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		LandscapePhone = 1,
		/// <summary>Metrics for landscape orientation for the phone idiom, for bar with the prompt property.</summary>
		[ObsoletedOSPlatform ("ios8.0", "Use 'UIBarMetrics.CompactPrompt' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'UIBarMetrics.CompactPrompt' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UIBarMetrics.CompactPrompt' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		LandscapePhonePrompt = 102,
	}
}
