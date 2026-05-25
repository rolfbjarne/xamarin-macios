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
	/// <summary>Enumerates the type of change in presence that the <see cref="T:HomeKit.HMPresenceEvent" /> represents.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum HMPresenceEventType : ulong {
		/// <summary>To be added.</summary>
		EveryEntry = 1,
		/// <summary>To be added.</summary>
		EveryExit = 2,
		/// <summary>To be added.</summary>
		FirstEntry = 3,
		/// <summary>To be added.</summary>
		LastExit = 4,
		/// <summary>To be added.</summary>
		AtHome = 3,
		/// <summary>To be added.</summary>
		NotAtHome = 4,
	}
}
