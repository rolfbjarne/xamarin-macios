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
namespace HomeKit {
	/// <summary>Enumerates air quality values.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum HMCharacteristicValueAirQuality : long {
		/// <summary>An indeterminate quality.</summary>
		Unknown = 0,
		/// <summary>The best air quality.</summary>
		Excellent = 1,
		/// <summary>Better than <see cref="F:HomeKit.HMCharacteristicValueAirQuality.Fair" />, but poorer than <see cref="F:HomeKit.HMCharacteristicValueAirQuality.Excellent" />.</summary>
		Good = 2,
		/// <summary>The middle value of air quality.</summary>
		Fair = 3,
		/// <summary>Better than <see cref="F:HomeKit.HMCharacteristicValueAirQuality.Poor" />, but poorer than <see cref="F:HomeKit.HMCharacteristicValueAirQuality.Fair" />.</summary>
		Inferior = 4,
		/// <summary>The worst air quality.</summary>
		Poor = 5,
	}
}
