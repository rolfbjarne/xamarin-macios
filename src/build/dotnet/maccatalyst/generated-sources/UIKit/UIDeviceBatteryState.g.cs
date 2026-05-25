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
namespace UIKit {
	/// <summary>An enumeration of values indicating the state of the battery.</summary><remarks><para>This is a qualitative description of the battery state (e.g., <see cref="F:UIKit.UIDeviceBatteryState.Charging" />). For a quantitative view of battery charge level, use <see cref="P:UIKit.UIDevice.BatteryLevel" />.</para></remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIDeviceBatteryState : long {
		/// <summary>Can not determine the state of the battery.</summary>
		Unknown = 0,
		/// <summary>The device is unplugged.</summary>
		Unplugged = 1,
		/// <summary>The device's battery is currently charging.</summary>
		Charging = 2,
		/// <summary>The device's battery is at full capacity.</summary>
		Full = 3,
	}
}
