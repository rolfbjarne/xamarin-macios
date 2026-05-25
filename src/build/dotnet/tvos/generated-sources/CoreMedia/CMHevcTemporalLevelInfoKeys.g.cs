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
namespace CoreMedia {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class CMHevcTemporalLevelInfoKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ConstraintIndicatorFlagsKey;
		/// <summary>Represents the value associated with the constant 'kCMHEVCTemporalLevelInfoKey_ConstraintIndicatorFlags'.</summary>
		[Field ("kCMHEVCTemporalLevelInfoKey_ConstraintIndicatorFlags",  "CoreMedia")]
		public static NSString ConstraintIndicatorFlagsKey {
			get {
				if (_ConstraintIndicatorFlagsKey is null)
					_ConstraintIndicatorFlagsKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMHEVCTemporalLevelInfoKey_ConstraintIndicatorFlags")!;
				return _ConstraintIndicatorFlagsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LevelIndexKey;
		/// <summary>Represents the value associated with the constant 'kCMHEVCTemporalLevelInfoKey_LevelIndex'.</summary>
		[Field ("kCMHEVCTemporalLevelInfoKey_LevelIndex",  "CoreMedia")]
		public static NSString LevelIndexKey {
			get {
				if (_LevelIndexKey is null)
					_LevelIndexKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMHEVCTemporalLevelInfoKey_LevelIndex")!;
				return _LevelIndexKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileCompatibilityFlagsKey;
		/// <summary>Represents the value associated with the constant 'kCMHEVCTemporalLevelInfoKey_ProfileCompatibilityFlags'.</summary>
		[Field ("kCMHEVCTemporalLevelInfoKey_ProfileCompatibilityFlags",  "CoreMedia")]
		public static NSString ProfileCompatibilityFlagsKey {
			get {
				if (_ProfileCompatibilityFlagsKey is null)
					_ProfileCompatibilityFlagsKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMHEVCTemporalLevelInfoKey_ProfileCompatibilityFlags")!;
				return _ProfileCompatibilityFlagsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileIndexKey;
		/// <summary>Represents the value associated with the constant 'kCMHEVCTemporalLevelInfoKey_ProfileIndex'.</summary>
		[Field ("kCMHEVCTemporalLevelInfoKey_ProfileIndex",  "CoreMedia")]
		public static NSString ProfileIndexKey {
			get {
				if (_ProfileIndexKey is null)
					_ProfileIndexKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMHEVCTemporalLevelInfoKey_ProfileIndex")!;
				return _ProfileIndexKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileSpaceKey;
		/// <summary>Represents the value associated with the constant 'kCMHEVCTemporalLevelInfoKey_ProfileSpace'.</summary>
		[Field ("kCMHEVCTemporalLevelInfoKey_ProfileSpace",  "CoreMedia")]
		public static NSString ProfileSpaceKey {
			get {
				if (_ProfileSpaceKey is null)
					_ProfileSpaceKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMHEVCTemporalLevelInfoKey_ProfileSpace")!;
				return _ProfileSpaceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TemporalLevelKey;
		/// <summary>Represents the value associated with the constant 'kCMHEVCTemporalLevelInfoKey_TemporalLevel'.</summary>
		[Field ("kCMHEVCTemporalLevelInfoKey_TemporalLevel",  "CoreMedia")]
		public static NSString TemporalLevelKey {
			get {
				if (_TemporalLevelKey is null)
					_TemporalLevelKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMHEVCTemporalLevelInfoKey_TemporalLevel")!;
				return _TemporalLevelKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TierFlagKey;
		/// <summary>Represents the value associated with the constant 'kCMHEVCTemporalLevelInfoKey_TierFlag'.</summary>
		[Field ("kCMHEVCTemporalLevelInfoKey_TierFlag",  "CoreMedia")]
		public static NSString TierFlagKey {
			get {
				if (_TierFlagKey is null)
					_TierFlagKey = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMHEVCTemporalLevelInfoKey_TierFlag")!;
				return _TierFlagKey;
			}
		}
	} /* class CMHevcTemporalLevelInfoKeys */
}
