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
	/// <summary>Enumerates the frequences for background delivery of data (see <see cref="M:HealthKit.HKHealthStore.EnableBackgroundDelivery(HealthKit.HKObjectType,HealthKit.HKUpdateFrequency,System.Action{System.Boolean,Foundation.NSError})" />).</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum HKUpdateFrequency : long {
		/// <summary>Updates as they become available.</summary>
		Immediate = 1,
		/// <summary>Hourly updates.</summary>
		Hourly = 2,
		/// <summary>Daily updates.</summary>
		Daily = 3,
		/// <summary>Weekly updates.</summary>
		Weekly = 4,
	}
}
