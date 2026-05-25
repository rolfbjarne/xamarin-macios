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
namespace HealthKit {
	/// <summary>Enumerates weather types.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum HKWeatherCondition : long {
		/// <summary>The weather has not been indicated.</summary>
		None = 0,
		/// <summary>Indicates that the weather is clear.</summary>
		Clear = 1,
		/// <summary>Indicates that the weather is fair.</summary>
		Fair = 2,
		/// <summary>Indicates that the weather is partly cloudy.</summary>
		PartlyCloudy = 3,
		/// <summary>Indicates that the weather is mostly cloudy.</summary>
		MostlyCloudy = 4,
		/// <summary>Indicates that the weather is cloudy.</summary>
		Cloudy = 5,
		/// <summary>Indicates that the weather is foggy.</summary>
		Foggy = 6,
		/// <summary>Indicates haze.</summary>
		Haze = 7,
		/// <summary>Indicates that it is windy outside.</summary>
		Windy = 8,
		/// <summary>Indicates that the weather is blustery.</summary>
		Blustery = 9,
		/// <summary>Indicates smoky weather.</summary>
		Smoky = 10,
		/// <summary>Indicates that the weather is dusty.</summary>
		Dust = 11,
		/// <summary>Indicates falling snow.</summary>
		Snow = 12,
		/// <summary>Indicates hail.</summary>
		Hail = 13,
		/// <summary>Indicates sleet.</summary>
		Sleet = 14,
		/// <summary>Indicates freezing drizzle.</summary>
		FreezingDrizzle = 15,
		/// <summary>Indicates freezing rain.</summary>
		FreezingRain = 16,
		/// <summary>Indicates mixed rain and hail.</summary>
		MixedRainAndHail = 17,
		/// <summary>Indicates mixed rain and snow.</summary>
		MixedRainAndSnow = 18,
		/// <summary>Indicates mixed rain and sleet.</summary>
		MixedRainAndSleet = 19,
		/// <summary>Indicates mixed sleet and snow.</summary>
		MixedSnowAndSleet = 20,
		/// <summary>Indicates that the weather is drizzly.</summary>
		Drizzle = 21,
		/// <summary>Indicates scattered showers.</summary>
		ScatteredShowers = 22,
		/// <summary>Indicates showers.</summary>
		Showers = 23,
		/// <summary>Indicates thunderstorms.</summary>
		Thunderstorms = 24,
		/// <summary>Indicates a tropical storm.</summary>
		TropicalStorm = 25,
		/// <summary>Indicates that there is a hurricane.</summary>
		Hurricane = 26,
		/// <summary>Indicates one or more tornadoes.</summary>
		Tornado = 27,
	}
}
