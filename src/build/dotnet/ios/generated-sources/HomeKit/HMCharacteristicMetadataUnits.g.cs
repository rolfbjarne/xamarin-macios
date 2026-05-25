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
namespace HomeKit {
	/// <summary>Enumerates units of measure that might be associated with a <see cref="T:HomeKit.HMCharacteristic" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public enum HMCharacteristicMetadataUnits : int {
		/// <summary>Indicates no unit, or a dimensionless unit.</summary>
		None = 0,
		/// <summary>Indicates a unit that measures temperature in degrees Celsius.</summary>
		Celsius = 1,
		/// <summary>Indicates a unit that measures temperature in degrees Fahrenheit.</summary>
		Fahrenheit = 2,
		/// <summary>Indicates a unit that measures percentage.</summary>
		Percentage = 3,
		/// <summary>Indicates a unit that measures degrees of arc.</summary>
		ArcDegree = 4,
		/// <summary>The SI unit of time.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Seconds = 5,
		/// <summary>The SI unit of luminance.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Lux = 6,
		/// <summary>A unit often used for measuring concentrations in liquids or gas.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		PartsPerMillion = 7,
		/// <summary>A unit often used for measuring air quality.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		MicrogramsPerCubicMeter = 8,
	}
}
