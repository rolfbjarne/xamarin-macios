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
namespace CoreGraphics {
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public unsafe partial class CGToneMappingOptionKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentAverageLightLevelKey;
		/// <summary>Represents the value associated with the constant 'kCGContentAverageLightLevel'.</summary>
		[Field ("kCGContentAverageLightLevel",  "CoreGraphics")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		internal static NSString ContentAverageLightLevelKey {
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_ContentAverageLightLevelKey is null)
					_ContentAverageLightLevelKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGContentAverageLightLevel")!;
				return _ContentAverageLightLevelKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentAverageLightLevelNitsKey;
		/// <summary>Represents the value associated with the constant 'kCGContentAverageLightLevelNits'.</summary>
		[Field ("kCGContentAverageLightLevelNits",  "CoreGraphics")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		internal static NSString ContentAverageLightLevelNitsKey {
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_ContentAverageLightLevelNitsKey is null)
					_ContentAverageLightLevelNitsKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGContentAverageLightLevelNits")!;
				return _ContentAverageLightLevelNitsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExrToneMappingGammaDefogKey;
		/// <summary>Represents the value associated with the constant 'kCGEXRToneMappingGammaDefog'.</summary>
		[Field ("kCGEXRToneMappingGammaDefog",  "CoreGraphics")]
		internal static NSString ExrToneMappingGammaDefogKey {
			get {
				if (_ExrToneMappingGammaDefogKey is null)
					_ExrToneMappingGammaDefogKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGEXRToneMappingGammaDefog")!;
				return _ExrToneMappingGammaDefogKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExrToneMappingGammaExposureKey;
		/// <summary>Represents the value associated with the constant 'kCGEXRToneMappingGammaExposure'.</summary>
		[Field ("kCGEXRToneMappingGammaExposure",  "CoreGraphics")]
		internal static NSString ExrToneMappingGammaExposureKey {
			get {
				if (_ExrToneMappingGammaExposureKey is null)
					_ExrToneMappingGammaExposureKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGEXRToneMappingGammaExposure")!;
				return _ExrToneMappingGammaExposureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExrToneMappingGammaKneeHighKey;
		/// <summary>Represents the value associated with the constant 'kCGEXRToneMappingGammaKneeHigh'.</summary>
		[Field ("kCGEXRToneMappingGammaKneeHigh",  "CoreGraphics")]
		internal static NSString ExrToneMappingGammaKneeHighKey {
			get {
				if (_ExrToneMappingGammaKneeHighKey is null)
					_ExrToneMappingGammaKneeHighKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGEXRToneMappingGammaKneeHigh")!;
				return _ExrToneMappingGammaKneeHighKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExrToneMappingGammaKneeLowKey;
		/// <summary>Represents the value associated with the constant 'kCGEXRToneMappingGammaKneeLow'.</summary>
		[Field ("kCGEXRToneMappingGammaKneeLow",  "CoreGraphics")]
		internal static NSString ExrToneMappingGammaKneeLowKey {
			get {
				if (_ExrToneMappingGammaKneeLowKey is null)
					_ExrToneMappingGammaKneeLowKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGEXRToneMappingGammaKneeLow")!;
				return _ExrToneMappingGammaKneeLowKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreferredDynamicRangeKey;
		/// <summary>Represents the value associated with the constant 'kCGPreferredDynamicRange'.</summary>
		[Field ("kCGPreferredDynamicRange",  "CoreGraphics")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		internal static NSString PreferredDynamicRangeKey {
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_PreferredDynamicRangeKey is null)
					_PreferredDynamicRangeKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGPreferredDynamicRange")!;
				return _PreferredDynamicRangeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SkipBoostToHdrKey;
		/// <summary>Represents the value associated with the constant 'kCGSkipBoostToHDR'.</summary>
		[Field ("kCGSkipBoostToHDR",  "CoreGraphics")]
		internal static NSString SkipBoostToHdrKey {
			get {
				if (_SkipBoostToHdrKey is null)
					_SkipBoostToHdrKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGSkipBoostToHDR")!;
				return _SkipBoostToHdrKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Use100nitsHlgOotfKey;
		/// <summary>Represents the value associated with the constant 'kCGUse100nitsHLGOOTF'.</summary>
		[Field ("kCGUse100nitsHLGOOTF",  "CoreGraphics")]
		internal static NSString Use100nitsHlgOotfKey {
			get {
				if (_Use100nitsHlgOotfKey is null)
					_Use100nitsHlgOotfKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGUse100nitsHLGOOTF")!;
				return _Use100nitsHlgOotfKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UseBT1886ForCoreVideoGammaKey;
		/// <summary>Represents the value associated with the constant 'kCGUseBT1886ForCoreVideoGamma'.</summary>
		[Field ("kCGUseBT1886ForCoreVideoGamma",  "CoreGraphics")]
		internal static NSString UseBT1886ForCoreVideoGammaKey {
			get {
				if (_UseBT1886ForCoreVideoGammaKey is null)
					_UseBT1886ForCoreVideoGammaKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGUseBT1886ForCoreVideoGamma")!;
				return _UseBT1886ForCoreVideoGammaKey;
			}
		}
	} /* class CGToneMappingOptionKeys */
}
