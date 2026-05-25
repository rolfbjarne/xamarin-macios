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
