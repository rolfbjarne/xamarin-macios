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
	/// <summary>Enumerates the different kinds of <see cref="T:HomeKit.HMActionSet" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public enum HMActionSetType : int {
		/// <summary>The <see cref="T:HomeKit.HMActionSet" /> is not associated with a known kind.</summary>
		Unknown = -1,
		/// <summary>The <see cref="T:HomeKit.HMActionSet" /> relates to the user waking.</summary>
		WakeUp = 0,
		/// <summary>The <see cref="T:HomeKit.HMActionSet" /> relates to the user indicating they are going to sleep.</summary>
		Sleep = 1,
		/// <summary>The <see cref="T:HomeKit.HMActionSet" /> relates to the user leaving the home location.</summary>
		HomeDeparture = 2,
		/// <summary>The <see cref="T:HomeKit.HMActionSet" /> relates to the user arriving at the home location.</summary>
		HomeArrival = 3,
		/// <summary>The <see cref="T:HomeKit.HMActionSet" /> was manually created by the user.</summary>
		UserDefined = 4,
		/// <summary>The <see cref="T:HomeKit.HMActionSet" /> relates to a user-defined trigger.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		TriggerOwned = 5,
	}
}
