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
namespace CoreLocation {
	/// <summary>A class whose static members define constants relating to filtering and maximum distance.</summary><remarks>To be added.</remarks>
	public unsafe static partial class CLLocationDistance  {
		/// <summary>When used with <see cref="P:CoreLocation.CLLocationManager.DistanceFilter" />, indicates that no distance filter be used.</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCLDistanceFilterNone",  "CoreLocation")]
		public static double FilterNone {
			get {
				return Dlfcn.GetDouble (Libraries.CoreLocation.Handle, "kCLDistanceFilterNone");
			}
		}
		/// <summary>When used with <see cref="P:CoreLocation.CLLocationManager.DistanceFilter" />, indicates that the maximum distance filter be used.</summary><value></value><remarks>To be added.</remarks>
		[Field ("CLLocationDistanceMax",  "CoreLocation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static double MaxDistance {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetDouble (Libraries.CoreLocation.Handle, "CLLocationDistanceMax");
			}
		}
	} /* class CLLocationDistance */
}
