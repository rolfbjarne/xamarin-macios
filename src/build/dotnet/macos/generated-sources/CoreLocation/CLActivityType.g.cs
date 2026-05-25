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
namespace CoreLocation {
	/// <summary>An enumeration whose values specify different types of activity.</summary><remarks><para>By assigning <see cref="P:CoreLocation.CLLocationManager.ActivityType" />, the system can make intelligent choices regarding location update frequency vs. power consumption. </para></remarks>
	[Native]
	public enum CLActivityType : long {
		/// <summary>Indicates that the activity type is unknown.</summary>
		Other = 1,
		/// <summary>Indicates that the app is engaged in navigating an automobile. (Use <see cref="F:CoreLocation.CLActivityType.OtherNavigation" /> for other vehicle types.)</summary>
		AutomotiveNavigation = 2,
		/// <summary>Indicates fitness and all walking activities.</summary>
		Fitness = 3,
		/// <summary>Indicates that the app is involved in navigation, but not in a car. This value should be used for tracking motion in, e.g., trains, planes, and boats.</summary>
		OtherNavigation = 4,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Airborne = 5,
	}
}
