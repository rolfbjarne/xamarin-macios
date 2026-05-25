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
namespace UIKit {
	/// <summary>An enumeration of values that are automatically detected in text.</summary><remarks>The types of text that are automatically detected in text content.   If the types are detected in the content, the text is converted into clickable content.   When clicked the application that is bound to handle that kind of data type is invoked (Web browser for HTTP links, Phone application for phone numbers).</remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Flags]
	[Native ("UIDataDetectorTypes")]
	public enum UIDataDetectorType : ulong {
		/// <summary>Detects phone numbers.</summary>
		PhoneNumber = 1,
		/// <summary>Detects web Urls.</summary>
		Link = 2,
		/// <summary>Addresses.</summary>
		Address = 4,
		/// <summary>Detects calendar events.</summary>
		CalendarEvent = 8,
		/// <summary>A tracking number for a parcel.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		ShipmentTrackingNumber = 16,
		/// <summary>An airplane flight identifier.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		FlightNumber = 32,
		/// <summary>A word or phrase that may be the intended final value.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		LookupSuggestion = 64,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		Money = 128,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		PhysicalValue = 256,
		/// <summary>Do not perform any content detection.</summary>
		None = 0,
		/// <summary>All supported detection types are activated.</summary>
		All = 18446744073709551615,
	}
}
