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
	internal unsafe static partial class AdvertisementDataKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsConnectableKey;
		/// <summary>Represents the value associated with the constant 'CBAdvertisementDataIsConnectable'.</summary>
		[Field ("CBAdvertisementDataIsConnectable",  "CoreBluetooth")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IsConnectableKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IsConnectableKey is null)
					_IsConnectableKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataIsConnectable")!;
				return _IsConnectableKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalNameKey;
		/// <summary>Represents the value associated with the constant 'CBAdvertisementDataLocalNameKey'.</summary>
		[Field ("CBAdvertisementDataLocalNameKey",  "CoreBluetooth")]
		public static NSString LocalNameKey {
			get {
				if (_LocalNameKey is null)
					_LocalNameKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataLocalNameKey")!;
				return _LocalNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ManufacturerDataKey;
		/// <summary>Represents the value associated with the constant 'CBAdvertisementDataManufacturerDataKey'.</summary>
		[Field ("CBAdvertisementDataManufacturerDataKey",  "CoreBluetooth")]
		public static NSString ManufacturerDataKey {
			get {
				if (_ManufacturerDataKey is null)
					_ManufacturerDataKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataManufacturerDataKey")!;
				return _ManufacturerDataKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OverflowServiceUuidsKey;
		/// <summary>Represents the value associated with the constant 'CBAdvertisementDataOverflowServiceUUIDsKey'.</summary>
		[Field ("CBAdvertisementDataOverflowServiceUUIDsKey",  "CoreBluetooth")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OverflowServiceUuidsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OverflowServiceUuidsKey is null)
					_OverflowServiceUuidsKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataOverflowServiceUUIDsKey")!;
				return _OverflowServiceUuidsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ServiceDataKey;
		/// <summary>Represents the value associated with the constant 'CBAdvertisementDataServiceDataKey'.</summary>
		[Field ("CBAdvertisementDataServiceDataKey",  "CoreBluetooth")]
		public static NSString ServiceDataKey {
			get {
				if (_ServiceDataKey is null)
					_ServiceDataKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataServiceDataKey")!;
				return _ServiceDataKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ServiceUuidsKey;
		/// <summary>Represents the value associated with the constant 'CBAdvertisementDataServiceUUIDsKey'.</summary>
		[Field ("CBAdvertisementDataServiceUUIDsKey",  "CoreBluetooth")]
		public static NSString ServiceUuidsKey {
			get {
				if (_ServiceUuidsKey is null)
					_ServiceUuidsKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataServiceUUIDsKey")!;
				return _ServiceUuidsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SolicitedServiceUuidsKey;
		/// <summary>Represents the value associated with the constant 'CBAdvertisementDataSolicitedServiceUUIDsKey'.</summary>
		[Field ("CBAdvertisementDataSolicitedServiceUUIDsKey",  "CoreBluetooth")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString SolicitedServiceUuidsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_SolicitedServiceUuidsKey is null)
					_SolicitedServiceUuidsKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataSolicitedServiceUUIDsKey")!;
				return _SolicitedServiceUuidsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TxPowerLevelKey;
		/// <summary>Represents the value associated with the constant 'CBAdvertisementDataTxPowerLevelKey'.</summary>
		[Field ("CBAdvertisementDataTxPowerLevelKey",  "CoreBluetooth")]
		public static NSString TxPowerLevelKey {
			get {
				if (_TxPowerLevelKey is null)
					_TxPowerLevelKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataTxPowerLevelKey")!;
				return _TxPowerLevelKey;
			}
		}
	} /* class AdvertisementDataKeys */
}
