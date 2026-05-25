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
namespace CoreBluetooth {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class RestoredStateKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PeripheralsKey;
		/// <summary>Represents the value associated with the constant 'CBCentralManagerRestoredStatePeripheralsKey'.</summary>
		[Field ("CBCentralManagerRestoredStatePeripheralsKey",  "CoreBluetooth")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PeripheralsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PeripheralsKey is null)
					_PeripheralsKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBCentralManagerRestoredStatePeripheralsKey")!;
				return _PeripheralsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScanOptionsKey;
		/// <summary>Represents the value associated with the constant 'CBCentralManagerRestoredStateScanOptionsKey'.</summary>
		[Field ("CBCentralManagerRestoredStateScanOptionsKey",  "CoreBluetooth")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ScanOptionsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ScanOptionsKey is null)
					_ScanOptionsKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBCentralManagerRestoredStateScanOptionsKey")!;
				return _ScanOptionsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScanServicesKey;
		/// <summary>Represents the value associated with the constant 'CBCentralManagerRestoredStateScanServicesKey'.</summary>
		[Field ("CBCentralManagerRestoredStateScanServicesKey",  "CoreBluetooth")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ScanServicesKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ScanServicesKey is null)
					_ScanServicesKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBCentralManagerRestoredStateScanServicesKey")!;
				return _ScanServicesKey;
			}
		}
	} /* class RestoredStateKeys */
}
