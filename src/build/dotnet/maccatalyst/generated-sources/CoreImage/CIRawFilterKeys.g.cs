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
namespace CoreImage {
	[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
	[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
	[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class CIRawFilterKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ActiveKeysKey;
		/// <summary>Represents the value associated with the constant 'kCIActiveKeys'.</summary>
		[Field ("kCIActiveKeys",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ActiveKeysKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ActiveKeysKey is null)
					_ActiveKeysKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIActiveKeys")!;
				return _ActiveKeysKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowDraftModeKey;
		/// <summary>Represents the value associated with the constant 'kCIInputAllowDraftModeKey'.</summary>
		[Field ("kCIInputAllowDraftModeKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AllowDraftModeKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AllowDraftModeKey is null)
					_AllowDraftModeKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputAllowDraftModeKey")!;
				return _AllowDraftModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BaselineExposureKey;
		/// <summary>Represents the value associated with the constant 'kCIInputBaselineExposureKey'.</summary>
		[Field ("kCIInputBaselineExposureKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString BaselineExposureKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_BaselineExposureKey is null)
					_BaselineExposureKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputBaselineExposureKey")!;
				return _BaselineExposureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BoostKey;
		/// <summary>Represents the value associated with the constant 'kCIInputBoostKey'.</summary>
		[Field ("kCIInputBoostKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString BoostKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_BoostKey is null)
					_BoostKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputBoostKey")!;
				return _BoostKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BoostShadowAmountKey;
		/// <summary>Represents the value associated with the constant 'kCIInputBoostShadowAmountKey'.</summary>
		[Field ("kCIInputBoostShadowAmountKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString BoostShadowAmountKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_BoostShadowAmountKey is null)
					_BoostShadowAmountKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputBoostShadowAmountKey")!;
				return _BoostShadowAmountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorNoiseReductionAmountKey;
		/// <summary>Represents the value associated with the constant 'kCIInputColorNoiseReductionAmountKey'.</summary>
		[Field ("kCIInputColorNoiseReductionAmountKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ColorNoiseReductionAmountKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ColorNoiseReductionAmountKey is null)
					_ColorNoiseReductionAmountKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputColorNoiseReductionAmountKey")!;
				return _ColorNoiseReductionAmountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisableGamutMapKey;
		/// <summary>Represents the value associated with the constant 'kCIInputDisableGamutMapKey'.</summary>
		[Field ("kCIInputDisableGamutMapKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DisableGamutMapKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DisableGamutMapKey is null)
					_DisableGamutMapKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputDisableGamutMapKey")!;
				return _DisableGamutMapKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EnableChromaticNoiseTrackingKey;
		/// <summary>Represents the value associated with the constant 'kCIInputEnableChromaticNoiseTrackingKey'.</summary>
		[Field ("kCIInputEnableChromaticNoiseTrackingKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString EnableChromaticNoiseTrackingKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EnableChromaticNoiseTrackingKey is null)
					_EnableChromaticNoiseTrackingKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputEnableChromaticNoiseTrackingKey")!;
				return _EnableChromaticNoiseTrackingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EnableEdrModeKey;
		/// <summary>Represents the value associated with the constant 'kCIInputEnableEDRModeKey'.</summary>
		[Field ("kCIInputEnableEDRModeKey",  "CoreImage")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("macos")]
		public static NSString EnableEdrModeKey {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_EnableEdrModeKey is null)
					_EnableEdrModeKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputEnableEDRModeKey")!;
				return _EnableEdrModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EnableSharpeningKey;
		/// <summary>Represents the value associated with the constant 'kCIInputEnableSharpeningKey'.</summary>
		[Field ("kCIInputEnableSharpeningKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString EnableSharpeningKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EnableSharpeningKey is null)
					_EnableSharpeningKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputEnableSharpeningKey")!;
				return _EnableSharpeningKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EnableVendorLensCorrectionKey;
		/// <summary>Represents the value associated with the constant 'kCIInputEnableVendorLensCorrectionKey'.</summary>
		[Field ("kCIInputEnableVendorLensCorrectionKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString EnableVendorLensCorrectionKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EnableVendorLensCorrectionKey is null)
					_EnableVendorLensCorrectionKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputEnableVendorLensCorrectionKey")!;
				return _EnableVendorLensCorrectionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IgnoreImageOrientationKey;
		/// <summary>Represents the value associated with the constant 'kCIInputIgnoreImageOrientationKey'.</summary>
		[Field ("kCIInputIgnoreImageOrientationKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IgnoreImageOrientationKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IgnoreImageOrientationKey is null)
					_IgnoreImageOrientationKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputIgnoreImageOrientationKey")!;
				return _IgnoreImageOrientationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ImageOrientationKey;
		/// <summary>Represents the value associated with the constant 'kCIInputImageOrientationKey'.</summary>
		[Field ("kCIInputImageOrientationKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ImageOrientationKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ImageOrientationKey is null)
					_ImageOrientationKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputImageOrientationKey")!;
				return _ImageOrientationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputLocalToneMapAmountKey;
		/// <summary>Represents the value associated with the constant 'kCIInputLocalToneMapAmountKey'.</summary>
		[Field ("kCIInputLocalToneMapAmountKey",  "CoreImage")]
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("tvos14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("macos")]
		public static NSString InputLocalToneMapAmountKey {
			[SupportedOSPlatform ("ios14.3")]
			[SupportedOSPlatform ("tvos14.3")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_InputLocalToneMapAmountKey is null)
					_InputLocalToneMapAmountKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputLocalToneMapAmountKey")!;
				return _InputLocalToneMapAmountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LinearSpaceFilterKey;
		/// <summary>Represents the value associated with the constant 'kCIInputLinearSpaceFilter'.</summary>
		[Field ("kCIInputLinearSpaceFilter",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString LinearSpaceFilterKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_LinearSpaceFilterKey is null)
					_LinearSpaceFilterKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputLinearSpaceFilter")!;
				return _LinearSpaceFilterKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LuminanceNoiseReductionAmountKey;
		/// <summary>Represents the value associated with the constant 'kCIInputLuminanceNoiseReductionAmountKey'.</summary>
		[Field ("kCIInputLuminanceNoiseReductionAmountKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString LuminanceNoiseReductionAmountKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_LuminanceNoiseReductionAmountKey is null)
					_LuminanceNoiseReductionAmountKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputLuminanceNoiseReductionAmountKey")!;
				return _LuminanceNoiseReductionAmountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MoireAmountKey;
		/// <summary>Represents the value associated with the constant 'kCIInputMoireAmountKey'.</summary>
		[Field ("kCIInputMoireAmountKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MoireAmountKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MoireAmountKey is null)
					_MoireAmountKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputMoireAmountKey")!;
				return _MoireAmountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NeutralChromaticityXKey;
		/// <summary>Represents the value associated with the constant 'kCIInputNeutralChromaticityXKey'.</summary>
		[Field ("kCIInputNeutralChromaticityXKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NeutralChromaticityXKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NeutralChromaticityXKey is null)
					_NeutralChromaticityXKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputNeutralChromaticityXKey")!;
				return _NeutralChromaticityXKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NeutralChromaticityYKey;
		/// <summary>Represents the value associated with the constant 'kCIInputNeutralChromaticityYKey'.</summary>
		[Field ("kCIInputNeutralChromaticityYKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NeutralChromaticityYKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NeutralChromaticityYKey is null)
					_NeutralChromaticityYKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputNeutralChromaticityYKey")!;
				return _NeutralChromaticityYKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NeutralLocationKey;
		/// <summary>Represents the value associated with the constant 'kCIInputNeutralLocationKey'.</summary>
		[Field ("kCIInputNeutralLocationKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NeutralLocationKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NeutralLocationKey is null)
					_NeutralLocationKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputNeutralLocationKey")!;
				return _NeutralLocationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NeutralTemperatureKey;
		/// <summary>Represents the value associated with the constant 'kCIInputNeutralTemperatureKey'.</summary>
		[Field ("kCIInputNeutralTemperatureKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NeutralTemperatureKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NeutralTemperatureKey is null)
					_NeutralTemperatureKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputNeutralTemperatureKey")!;
				return _NeutralTemperatureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NeutralTintKey;
		/// <summary>Represents the value associated with the constant 'kCIInputNeutralTintKey'.</summary>
		[Field ("kCIInputNeutralTintKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NeutralTintKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NeutralTintKey is null)
					_NeutralTintKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputNeutralTintKey")!;
				return _NeutralTintKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NoiseReductionAmountKey;
		/// <summary>Represents the value associated with the constant 'kCIInputNoiseReductionAmountKey'.</summary>
		[Field ("kCIInputNoiseReductionAmountKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NoiseReductionAmountKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NoiseReductionAmountKey is null)
					_NoiseReductionAmountKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputNoiseReductionAmountKey")!;
				return _NoiseReductionAmountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NoiseReductionContrastAmountKey;
		/// <summary>Represents the value associated with the constant 'kCIInputNoiseReductionContrastAmountKey'.</summary>
		[Field ("kCIInputNoiseReductionContrastAmountKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NoiseReductionContrastAmountKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NoiseReductionContrastAmountKey is null)
					_NoiseReductionContrastAmountKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputNoiseReductionContrastAmountKey")!;
				return _NoiseReductionContrastAmountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NoiseReductionDetailAmountKey;
		/// <summary>Represents the value associated with the constant 'kCIInputNoiseReductionDetailAmountKey'.</summary>
		[Field ("kCIInputNoiseReductionDetailAmountKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NoiseReductionDetailAmountKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NoiseReductionDetailAmountKey is null)
					_NoiseReductionDetailAmountKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputNoiseReductionDetailAmountKey")!;
				return _NoiseReductionDetailAmountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NoiseReductionSharpnessAmountKey;
		/// <summary>Represents the value associated with the constant 'kCIInputNoiseReductionSharpnessAmountKey'.</summary>
		[Field ("kCIInputNoiseReductionSharpnessAmountKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NoiseReductionSharpnessAmountKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NoiseReductionSharpnessAmountKey is null)
					_NoiseReductionSharpnessAmountKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputNoiseReductionSharpnessAmountKey")!;
				return _NoiseReductionSharpnessAmountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OutputNativeSizeKey;
		/// <summary>Represents the value associated with the constant 'kCIOutputNativeSizeKey'.</summary>
		[Field ("kCIOutputNativeSizeKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OutputNativeSizeKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OutputNativeSizeKey is null)
					_OutputNativeSizeKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIOutputNativeSizeKey")!;
				return _OutputNativeSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScaleFactorKey;
		/// <summary>Represents the value associated with the constant 'kCIInputScaleFactorKey'.</summary>
		[Field ("kCIInputScaleFactorKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ScaleFactorKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ScaleFactorKey is null)
					_ScaleFactorKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputScaleFactorKey")!;
				return _ScaleFactorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SupportedDecoderVersionsKey;
		/// <summary>Represents the value associated with the constant 'kCISupportedDecoderVersionsKey'.</summary>
		[Field ("kCISupportedDecoderVersionsKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString SupportedDecoderVersionsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_SupportedDecoderVersionsKey is null)
					_SupportedDecoderVersionsKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCISupportedDecoderVersionsKey")!;
				return _SupportedDecoderVersionsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VersionKey;
		/// <summary>Represents the value associated with the constant 'kCIInputDecoderVersionKey'.</summary>
		[Field ("kCIInputDecoderVersionKey",  "CoreImage")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString VersionKey {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("tvos15.0", "Use 'CIRawFilter' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'CIRawFilter' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_VersionKey is null)
					_VersionKey = Dlfcn.GetStringConstant (Libraries.CoreImage.Handle, "kCIInputDecoderVersionKey")!;
				return _VersionKey;
			}
		}
	} /* class CIRawFilterKeys */
}
