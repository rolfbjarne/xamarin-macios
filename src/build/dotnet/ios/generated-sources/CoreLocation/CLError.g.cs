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
namespace CoreLocation {
	/// <summary>Errors returned by the CLLocationManager.</summary>
	[Native]
	public enum CLError : long {
		/// <summary>The location could not be determined.</summary>
		LocationUnknown = 0,
		/// <summary>Access to the location service was denied by the user.</summary>
		Denied = 1,
		/// <summary>The network is unavailable.</summary>
		Network = 2,
		/// <summary>The heading could not be determined.</summary>
		HeadingFailure = 3,
		/// <summary>Region monitoring was disallowed by the user.</summary>
		RegionMonitoringDenied = 4,
		/// <summary>Region monitoring failed.</summary>
		RegionMonitoringFailure = 5,
		/// <summary>Region monitoring could not be configured immediately.</summary>
		RegionMonitoringSetupDelayed = 6,
		/// <summary>Although region monitoring is available, events may be delayed.</summary>
		RegionMonitoringResponseDelayed = 7,
		/// <summary>The geocoding was unsuccessful.</summary>
		GeocodeFoundNoResult = 8,
		/// <summary>The geocoding was only partially successful.</summary>
		GeocodeFoundPartialResult = 9,
		/// <summary>The geocoding request was canceled.</summary>
		GeocodeCanceled = 10,
		/// <summary>The attempt to switch to deferred mode failed. Application developers may try again on devices that have a GPS device.</summary>
		DeferredFailed = 11,
		/// <summary>The <see cref="T:CoreLocation.CLLocationManager" /> did not enter deferred mode because location updates were already paused or disabled.</summary>
		DeferredNotUpdatingLocation = 12,
		/// <summary>Deferred mode is not available for the requested accuracy. For deferred mode, the accuracy must be <see cref="P:CoreLocation.CLLocation.AccuracyBest" /> or <see cref="P:CoreLocation.CLLocation.AccurracyBestForNavigation" />.</summary>
		DeferredAccuracyTooLow = 13,
		/// <summary>Deferred mode does not allow distance filters. The <see cref="P:CoreLocation.CLLocationManager.DistanceFilter" /> must be set to <see cref="P:CoreLocation.CLLocationDistance.FilterNone" />.</summary>
		DeferredDistanceFiltered = 14,
		/// <summary>The application's request for deferred location notices has been canceled.</summary>
		DeferredCanceled = 15,
		/// <summary>An error occurred during ranging.</summary>
		RangingFailure = 16,
		/// <summary>Ranging is not available.</summary>
		RangingUnavailable = 17,
		PromptDeclined = 18,
		HistoricalLocationError = 19,
	}
}
