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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace HomeKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class HMCharacteristicMetadataUnitsInternal  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ArcDegree;
		/// <summary>Represents the value associated with the constant 'HMCharacteristicMetadataUnitsArcDegree'.</summary>
		[Field ("HMCharacteristicMetadataUnitsArcDegree",  "HomeKit")]
		public static NSString ArcDegree {
			get {
				if (_ArcDegree is null)
					_ArcDegree = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMCharacteristicMetadataUnitsArcDegree")!;
				return _ArcDegree;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Celsius;
		/// <summary>Represents the value associated with the constant 'HMCharacteristicMetadataUnitsCelsius'.</summary>
		[Field ("HMCharacteristicMetadataUnitsCelsius",  "HomeKit")]
		public static NSString Celsius {
			get {
				if (_Celsius is null)
					_Celsius = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMCharacteristicMetadataUnitsCelsius")!;
				return _Celsius;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Fahrenheit;
		/// <summary>Represents the value associated with the constant 'HMCharacteristicMetadataUnitsFahrenheit'.</summary>
		[Field ("HMCharacteristicMetadataUnitsFahrenheit",  "HomeKit")]
		public static NSString Fahrenheit {
			get {
				if (_Fahrenheit is null)
					_Fahrenheit = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMCharacteristicMetadataUnitsFahrenheit")!;
				return _Fahrenheit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Lux;
		/// <summary>Represents the value associated with the constant 'HMCharacteristicMetadataUnitsLux'.</summary>
		[Field ("HMCharacteristicMetadataUnitsLux",  "HomeKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Lux {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Lux is null)
					_Lux = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMCharacteristicMetadataUnitsLux")!;
				return _Lux;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MicrogramsPerCubicMeter;
		/// <summary>Represents the value associated with the constant 'HMCharacteristicMetadataUnitsMicrogramsPerCubicMeter'.</summary>
		[Field ("HMCharacteristicMetadataUnitsMicrogramsPerCubicMeter",  "HomeKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MicrogramsPerCubicMeter {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MicrogramsPerCubicMeter is null)
					_MicrogramsPerCubicMeter = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMCharacteristicMetadataUnitsMicrogramsPerCubicMeter")!;
				return _MicrogramsPerCubicMeter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PartsPerMillion;
		/// <summary>Represents the value associated with the constant 'HMCharacteristicMetadataUnitsPartsPerMillion'.</summary>
		[Field ("HMCharacteristicMetadataUnitsPartsPerMillion",  "HomeKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PartsPerMillion {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PartsPerMillion is null)
					_PartsPerMillion = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMCharacteristicMetadataUnitsPartsPerMillion")!;
				return _PartsPerMillion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Percentage;
		/// <summary>Represents the value associated with the constant 'HMCharacteristicMetadataUnitsPercentage'.</summary>
		[Field ("HMCharacteristicMetadataUnitsPercentage",  "HomeKit")]
		public static NSString Percentage {
			get {
				if (_Percentage is null)
					_Percentage = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMCharacteristicMetadataUnitsPercentage")!;
				return _Percentage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Seconds;
		/// <summary>Represents the value associated with the constant 'HMCharacteristicMetadataUnitsSeconds'.</summary>
		[Field ("HMCharacteristicMetadataUnitsSeconds",  "HomeKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Seconds {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Seconds is null)
					_Seconds = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMCharacteristicMetadataUnitsSeconds")!;
				return _Seconds;
			}
		}
	} /* class HMCharacteristicMetadataUnitsInternal */
}
