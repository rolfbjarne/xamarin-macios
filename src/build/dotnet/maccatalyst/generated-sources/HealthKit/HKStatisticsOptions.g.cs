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
	/// <summary>Enumerates options applicable to <see cref="T:HealthKit.HKStatisticsQuery" /> and <see cref="T:HealthKit.HKStatisticsCollectionQuery" /> objets.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Flags]
	[Native]
	public enum HKStatisticsOptions : ulong {
		/// <summary>Do nothing with the data.</summary>
		None = 0,
		/// <summary>Calculate each statistic by source.</summary>
		SeparateBySource = 1,
		/// <summary>Calculate the average of all the matching data.</summary>
		DiscreteAverage = 2,
		/// <summary>Find the minimum value in the matching data.</summary>
		DiscreteMin = 4,
		/// <summary>Find the maximum value in the matching data.</summary>
		DiscreteMax = 8,
		/// <summary>Calculate a sum of all the matching data.</summary>
		CumulativeSum = 16,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		MostRecent = 32,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		Duration = 64,
	}
}
