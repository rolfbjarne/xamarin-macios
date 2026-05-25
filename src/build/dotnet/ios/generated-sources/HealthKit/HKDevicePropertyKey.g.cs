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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace HealthKit {
	/// <summary>Holds keys whose constant values relate to properties of a <see cref="T:HealthKit.HKDevice" />.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe static partial class HKDevicePropertyKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FirmwareVersion;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKDevicePropertyKeyFirmwareVersion",  "HealthKit")]
		public static NSString FirmwareVersion {
			get {
				if (_FirmwareVersion is null)
					_FirmwareVersion = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKDevicePropertyKeyFirmwareVersion")!;
				return _FirmwareVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HardwareVersion;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKDevicePropertyKeyHardwareVersion",  "HealthKit")]
		public static NSString HardwareVersion {
			get {
				if (_HardwareVersion is null)
					_HardwareVersion = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKDevicePropertyKeyHardwareVersion")!;
				return _HardwareVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKDevicePropertyKeyLocalIdentifier",  "HealthKit")]
		public static NSString LocalIdentifier {
			get {
				if (_LocalIdentifier is null)
					_LocalIdentifier = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKDevicePropertyKeyLocalIdentifier")!;
				return _LocalIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Manufacturer;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKDevicePropertyKeyManufacturer",  "HealthKit")]
		public static NSString Manufacturer {
			get {
				if (_Manufacturer is null)
					_Manufacturer = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKDevicePropertyKeyManufacturer")!;
				return _Manufacturer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Model;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKDevicePropertyKeyModel",  "HealthKit")]
		public static NSString Model {
			get {
				if (_Model is null)
					_Model = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKDevicePropertyKeyModel")!;
				return _Model;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Name;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKDevicePropertyKeyName",  "HealthKit")]
		public static NSString Name {
			get {
				if (_Name is null)
					_Name = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKDevicePropertyKeyName")!;
				return _Name;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SoftwareVersion;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKDevicePropertyKeySoftwareVersion",  "HealthKit")]
		public static NSString SoftwareVersion {
			get {
				if (_SoftwareVersion is null)
					_SoftwareVersion = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKDevicePropertyKeySoftwareVersion")!;
				return _SoftwareVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UdiDeviceIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("HKDevicePropertyKeyUDIDeviceIdentifier",  "HealthKit")]
		public static NSString UdiDeviceIdentifier {
			get {
				if (_UdiDeviceIdentifier is null)
					_UdiDeviceIdentifier = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKDevicePropertyKeyUDIDeviceIdentifier")!;
				return _UdiDeviceIdentifier;
			}
		}
	} /* class HKDevicePropertyKey */
}
