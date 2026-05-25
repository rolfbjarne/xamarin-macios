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
namespace Intents {
	/// <summary>Enumerates repetition frequencies.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum INRecurrenceFrequency : long {
		/// <summary>Indicates an unknown frequency.</summary>
		Unknown = 0,
		/// <summary>Indicates a repetition every minute.</summary>
		Minute = 1,
		/// <summary>Indicates an hourly repetition.</summary>
		Hourly = 2,
		/// <summary>Indicates a daily repetition.</summary>
		Daily = 3,
		/// <summary>Indicates a weekly repetition.</summary>
		Weekly = 4,
		/// <summary>Indicates a monthly repetition.</summary>
		Monthly = 5,
		/// <summary>Indicates an annual repetition.</summary>
		Yearly = 6,
	}
}
