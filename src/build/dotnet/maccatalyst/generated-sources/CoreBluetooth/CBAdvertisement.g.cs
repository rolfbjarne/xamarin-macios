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
	/// <summary>Keys used to lookup dictionary values from the NSDictionary received as a parameter in <see cref="M:CoreBluetooth.CBCentralManagerDelegate.DiscoveredPeripheral(CoreBluetooth.CBCentralManager,CoreBluetooth.CBPeripheral,Foundation.NSDictionary,Foundation.NSNumber)" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class CBAdvertisement  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DataLocalNameKey;
		/// <summary>Represents the value associated with the constant CBAdvertisementDataLocalNameKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("CBAdvertisementDataLocalNameKey",  "CoreBluetooth")]
		public static NSString DataLocalNameKey {
			get {
				if (_DataLocalNameKey is null)
					_DataLocalNameKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataLocalNameKey")!;
				return _DataLocalNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DataManufacturerDataKey;
		/// <summary>Represents the value associated with the constant CBAdvertisementDataManufacturerDataKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("CBAdvertisementDataManufacturerDataKey",  "CoreBluetooth")]
		public static NSString DataManufacturerDataKey {
			get {
				if (_DataManufacturerDataKey is null)
					_DataManufacturerDataKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataManufacturerDataKey")!;
				return _DataManufacturerDataKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DataOverflowServiceUUIDsKey;
		/// <summary>Represents the value associated with the constant CBAdvertisementDataOverflowServiceUUIDsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("CBAdvertisementDataOverflowServiceUUIDsKey",  "CoreBluetooth")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DataOverflowServiceUUIDsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DataOverflowServiceUUIDsKey is null)
					_DataOverflowServiceUUIDsKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataOverflowServiceUUIDsKey")!;
				return _DataOverflowServiceUUIDsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DataServiceDataKey;
		/// <summary>Represents the value associated with the constant CBAdvertisementDataServiceDataKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("CBAdvertisementDataServiceDataKey",  "CoreBluetooth")]
		public static NSString DataServiceDataKey {
			get {
				if (_DataServiceDataKey is null)
					_DataServiceDataKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataServiceDataKey")!;
				return _DataServiceDataKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DataServiceUUIDsKey;
		/// <summary>Represents the value associated with the constant CBAdvertisementDataServiceUUIDsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("CBAdvertisementDataServiceUUIDsKey",  "CoreBluetooth")]
		public static NSString DataServiceUUIDsKey {
			get {
				if (_DataServiceUUIDsKey is null)
					_DataServiceUUIDsKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataServiceUUIDsKey")!;
				return _DataServiceUUIDsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DataSolicitedServiceUUIDsKey;
		/// <summary>Represents the value associated with the constant CBAdvertisementDataSolicitedServiceUUIDsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("CBAdvertisementDataSolicitedServiceUUIDsKey",  "CoreBluetooth")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DataSolicitedServiceUUIDsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DataSolicitedServiceUUIDsKey is null)
					_DataSolicitedServiceUUIDsKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataSolicitedServiceUUIDsKey")!;
				return _DataSolicitedServiceUUIDsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DataTxPowerLevelKey;
		/// <summary>Represents the value associated with the constant CBAdvertisementDataTxPowerLevelKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("CBAdvertisementDataTxPowerLevelKey",  "CoreBluetooth")]
		public static NSString DataTxPowerLevelKey {
			get {
				if (_DataTxPowerLevelKey is null)
					_DataTxPowerLevelKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataTxPowerLevelKey")!;
				return _DataTxPowerLevelKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsConnectable;
		/// <summary>Represents the value associated with the constant CBAdvertisementDataIsConnectable</summary><value></value><remarks>To be added.</remarks>
		[Field ("CBAdvertisementDataIsConnectable",  "CoreBluetooth")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IsConnectable {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IsConnectable is null)
					_IsConnectable = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBAdvertisementDataIsConnectable")!;
				return _IsConnectable;
			}
		}
	} /* class CBAdvertisement */
}
