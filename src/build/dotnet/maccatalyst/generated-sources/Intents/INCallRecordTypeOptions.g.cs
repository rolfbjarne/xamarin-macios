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
	/// <summary>Flags that enumerate call types to search for.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Flags]
	[Native]
	public enum INCallRecordTypeOptions : ulong {
		/// <summary>Indicates that outgoing calls should be searched.</summary>
		Outgoing = 1,
		/// <summary>Indicates that missed calls should be searched.</summary>
		Missed = 2,
		/// <summary>Indicates that received calls should be searched.</summary>
		Received = 4,
		/// <summary>Indicates that the most recent call by the user should be searched.</summary>
		Latest = 8,
		/// <summary>Indicates that voicemails should be searched.</summary>
		Voicemail = 16,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		Ringing = 32,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		InProgress = 64,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		OnHold = 128,
	}
}
