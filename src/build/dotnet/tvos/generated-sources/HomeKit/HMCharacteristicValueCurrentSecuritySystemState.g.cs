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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace HomeKit {
	/// <summary>Enumerates the states of a security system.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum HMCharacteristicValueCurrentSecuritySystemState : long {
		/// <summary>The system is alarmed appropriately for a user who is home and active.</summary>
		StayArm = 0,
		/// <summary>The system is armed and no one is home.</summary>
		AwayArm = 1,
		/// <summary>The system is armed appropriately for when a user is asleep at home.</summary>
		NightArm = 2,
		/// <summary>The system is disarmed.</summary>
		Disarmed = 3,
		/// <summary>The system has been triggered.</summary>
		Triggered = 4,
	}
}
