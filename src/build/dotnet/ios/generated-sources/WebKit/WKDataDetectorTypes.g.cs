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
namespace WebKit {
	/// <summary>Enumerates the kinds of data that are detected and converted to links.</summary>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Flags]
	[Native]
	public enum WKDataDetectorTypes : ulong {
		/// <summary>Indicates that no items are detected and converted to links.</summary>
		None = 0,
		/// <summary>Indicates that phone numbers are detected and converted to links.</summary>
		PhoneNumber = 1,
		/// <summary>Indicates that URLs are detected and converted to links.</summary>
		Link = 2,
		/// <summary>Indicates that addresses are detected and converted to links.</summary>
		Address = 4,
		/// <summary>Indicates that datetimes in the future are detected and converted to links.</summary>
		CalendarEvent = 8,
		/// <summary>Indicates that shipping numbers are detected and converted to links.</summary>
		TrackingNumber = 16,
		/// <summary>Indicates that flight numbers are detected and converted to links.</summary>
		FlightNumber = 32,
		/// <summary>Indicates that lookup suggestions will be provided.</summary>
		LookupSuggestion = 64,
		/// <summary>Indicates that Spotlight suggestsions are detected and converted into links.</summary>
		SpotlightSuggestion = 64,
		/// <summary>Indicates that all detectable items will be detected and converted to links.</summary>
		All = 18446744073709551615,
	}
}
