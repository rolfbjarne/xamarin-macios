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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace HealthKit {
	/// <summary>Enumerates the locations at which a heart rate monitor is attached.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum HKHeartRateSensorLocation : long {
		/// <summary>The monitor is attached elsewhere on the user's body.</summary>
		Other = 0,
		/// <summary>The monitor is attached to the user's chest.</summary>
		Chest = 1,
		/// <summary>The monitor is attached to the user's wrist.</summary>
		Wrist = 2,
		/// <summary>The monitor is attached to the user's finger.</summary>
		Finger = 3,
		/// <summary>The monitor is attached to the user's hand.</summary>
		Hand = 4,
		/// <summary>The monitor is attached to the user's earlobe.</summary>
		EarLobe = 5,
		/// <summary>The monitor is attached to the user's foot.</summary>
		Foot = 6,
	}
}
