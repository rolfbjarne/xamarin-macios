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
namespace HomeKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class HMActionSetTypesInternal  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HomeArrival;
		/// <summary>Represents the value associated with the constant 'HMActionSetTypeHomeArrival'.</summary>
		[Field ("HMActionSetTypeHomeArrival",  "HomeKit")]
		public static NSString HomeArrival {
			get {
				if (_HomeArrival is null)
					_HomeArrival = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMActionSetTypeHomeArrival")!;
				return _HomeArrival;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HomeDeparture;
		/// <summary>Represents the value associated with the constant 'HMActionSetTypeHomeDeparture'.</summary>
		[Field ("HMActionSetTypeHomeDeparture",  "HomeKit")]
		public static NSString HomeDeparture {
			get {
				if (_HomeDeparture is null)
					_HomeDeparture = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMActionSetTypeHomeDeparture")!;
				return _HomeDeparture;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Sleep;
		/// <summary>Represents the value associated with the constant 'HMActionSetTypeSleep'.</summary>
		[Field ("HMActionSetTypeSleep",  "HomeKit")]
		public static NSString Sleep {
			get {
				if (_Sleep is null)
					_Sleep = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMActionSetTypeSleep")!;
				return _Sleep;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TriggerOwned;
		/// <summary>Represents the value associated with the constant 'HMActionSetTypeTriggerOwned'.</summary>
		[Field ("HMActionSetTypeTriggerOwned",  "HomeKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TriggerOwned {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TriggerOwned is null)
					_TriggerOwned = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMActionSetTypeTriggerOwned")!;
				return _TriggerOwned;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UserDefined;
		/// <summary>Represents the value associated with the constant 'HMActionSetTypeUserDefined'.</summary>
		[Field ("HMActionSetTypeUserDefined",  "HomeKit")]
		public static NSString UserDefined {
			get {
				if (_UserDefined is null)
					_UserDefined = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMActionSetTypeUserDefined")!;
				return _UserDefined;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WakeUp;
		/// <summary>Represents the value associated with the constant 'HMActionSetTypeWakeUp'.</summary>
		[Field ("HMActionSetTypeWakeUp",  "HomeKit")]
		public static NSString WakeUp {
			get {
				if (_WakeUp is null)
					_WakeUp = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMActionSetTypeWakeUp")!;
				return _WakeUp;
			}
		}
	} /* class HMActionSetTypesInternal */
}
