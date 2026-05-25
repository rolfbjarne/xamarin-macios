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
namespace HealthKit {
	/// <summary>Enumerates the amount of menstrual flow.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("ios18.0", "Use 'HKCategoryValueVaginalBleeding' instead.")]
	[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'HKCategoryValueVaginalBleeding' instead.")]
	[ObsoletedOSPlatform ("macos15.0", "Use 'HKCategoryValueVaginalBleeding' instead.")]
	[SupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[Native]
	public enum HKCategoryValueMenstrualFlow : long {
		/// <summary>Categorization is not applicable.</summary>
		NotApplicable = 0,
		/// <summary>The level is unspecified.</summary>
		Unspecified = 1,
		/// <summary>Light flow.</summary>
		Light = 2,
		/// <summary>Medium flow.</summary>
		Medium = 3,
		/// <summary>Heavy flow.</summary>
		Heavy = 4,
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'HKCategoryValueVaginalBleeding' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'HKCategoryValueVaginalBleeding' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'HKCategoryValueVaginalBleeding' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		None = 5,
	}
}
