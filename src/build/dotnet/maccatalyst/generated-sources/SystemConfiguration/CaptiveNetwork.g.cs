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
namespace SystemConfiguration {
	/// <summary>Deprecated: Use <see cref="T:NetworkExtension.NEHotspotHelper" /> instead. A class that encapsulates the Captive Network system component, which is responsible for detecting networks that require user interaction prior to providing Internet access.</summary>
	public unsafe static partial class CaptiveNetwork  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NetworkInfoKeyBSSID;
		/// <summary>Represents the value associated with the constant kCNNetworkInfoKeyBSSID</summary><value></value><remarks>This API is only available on devices. An EntryPointNotFoundException will be thrown on the simulator</remarks>
		[Field ("kCNNetworkInfoKeyBSSID",  "SystemConfiguration")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public static NSString NetworkInfoKeyBSSID {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_NetworkInfoKeyBSSID is null)
					_NetworkInfoKeyBSSID = Dlfcn.GetStringConstant (Libraries.SystemConfiguration.Handle, "kCNNetworkInfoKeyBSSID")!;
				return _NetworkInfoKeyBSSID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NetworkInfoKeySSID;
		/// <summary>Represents the value associated with the constant kCNNetworkInfoKeySSID</summary><value></value><remarks>This API is only available on devices. An EntryPointNotFoundException will be thrown on the simulator</remarks>
		[Field ("kCNNetworkInfoKeySSID",  "SystemConfiguration")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public static NSString NetworkInfoKeySSID {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_NetworkInfoKeySSID is null)
					_NetworkInfoKeySSID = Dlfcn.GetStringConstant (Libraries.SystemConfiguration.Handle, "kCNNetworkInfoKeySSID")!;
				return _NetworkInfoKeySSID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NetworkInfoKeySSIDData;
		/// <summary>Represents the value associated with the constant kCNNetworkInfoKeySSIDData</summary><value></value><remarks>This API is only available on devices. An EntryPointNotFoundException will be thrown on the simulator</remarks>
		[Field ("kCNNetworkInfoKeySSIDData",  "SystemConfiguration")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public static NSString NetworkInfoKeySSIDData {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_NetworkInfoKeySSIDData is null)
					_NetworkInfoKeySSIDData = Dlfcn.GetStringConstant (Libraries.SystemConfiguration.Handle, "kCNNetworkInfoKeySSIDData")!;
				return _NetworkInfoKeySSIDData;
			}
		}
	} /* class CaptiveNetwork */
}
