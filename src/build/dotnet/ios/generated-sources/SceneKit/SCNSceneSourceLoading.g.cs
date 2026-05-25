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
namespace SceneKit {
	/// <summary>Options for creating and loading SCNScene objects.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class SCNSceneSourceLoading  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnimationImportPolicyDoNotPlay;
		/// <summary>Represents the value associated with the constant SCNSceneSourceAnimationImportPolicyDoNotPlay</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceAnimationImportPolicyDoNotPlay",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AnimationImportPolicyDoNotPlay {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AnimationImportPolicyDoNotPlay is null)
					_AnimationImportPolicyDoNotPlay = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceAnimationImportPolicyDoNotPlay")!;
				return _AnimationImportPolicyDoNotPlay;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnimationImportPolicyKey;
		/// <summary>Represents the value associated with the constant SCNSceneSourceAnimationImportPolicyKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceAnimationImportPolicyKey",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AnimationImportPolicyKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AnimationImportPolicyKey is null)
					_AnimationImportPolicyKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceAnimationImportPolicyKey")!;
				return _AnimationImportPolicyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnimationImportPolicyPlay;
		/// <summary>Represents the value associated with the constant SCNSceneSourceAnimationImportPolicyPlay</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceAnimationImportPolicyPlay",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AnimationImportPolicyPlay {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AnimationImportPolicyPlay is null)
					_AnimationImportPolicyPlay = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceAnimationImportPolicyPlay")!;
				return _AnimationImportPolicyPlay;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnimationImportPolicyPlayRepeatedly;
		/// <summary>Represents the value associated with the constant SCNSceneSourceAnimationImportPolicyPlayRepeatedly</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceAnimationImportPolicyPlayRepeatedly",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AnimationImportPolicyPlayRepeatedly {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AnimationImportPolicyPlayRepeatedly is null)
					_AnimationImportPolicyPlayRepeatedly = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceAnimationImportPolicyPlayRepeatedly")!;
				return _AnimationImportPolicyPlayRepeatedly;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnimationImportPolicyPlayUsingSceneTimeBase;
		/// <summary>Represents the value associated with the constant SCNSceneSourceAnimationImportPolicyPlayUsingSceneTimeBase</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceAnimationImportPolicyPlayUsingSceneTimeBase",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AnimationImportPolicyPlayUsingSceneTimeBase {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AnimationImportPolicyPlayUsingSceneTimeBase is null)
					_AnimationImportPolicyPlayUsingSceneTimeBase = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceAnimationImportPolicyPlayUsingSceneTimeBase")!;
				return _AnimationImportPolicyPlayUsingSceneTimeBase;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AssetDirectoryUrlsKey;
		/// <summary>Represents the value associated with the constant SCNSceneSourceAssetDirectoryURLsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceAssetDirectoryURLsKey",  "SceneKit")]
		public static NSString AssetDirectoryUrlsKey {
			get {
				if (_AssetDirectoryUrlsKey is null)
					_AssetDirectoryUrlsKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceAssetDirectoryURLsKey")!;
				return _AssetDirectoryUrlsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CheckConsistencyKey;
		/// <summary>Represents the value associated with the constant SCNSceneSourceCheckConsistencyKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceCheckConsistencyKey",  "SceneKit")]
		public static NSString CheckConsistencyKey {
			get {
				if (_CheckConsistencyKey is null)
					_CheckConsistencyKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceCheckConsistencyKey")!;
				return _CheckConsistencyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ConvertToYUpKey;
		/// <summary>Represents the value associated with the constant SCNSceneSourceConvertToYUpKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceConvertToYUpKey",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ConvertToYUpKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ConvertToYUpKey is null)
					_ConvertToYUpKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceConvertToYUpKey")!;
				return _ConvertToYUpKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ConvertUnitsToMetersKey;
		/// <summary>Represents the value associated with the constant SCNSceneSourceConvertUnitsToMetersKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceConvertUnitsToMetersKey",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ConvertUnitsToMetersKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ConvertUnitsToMetersKey is null)
					_ConvertUnitsToMetersKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceConvertUnitsToMetersKey")!;
				return _ConvertUnitsToMetersKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreateNormalsIfAbsentKey;
		/// <summary>Represents the value associated with the constant SCNSceneSourceCreateNormalsIfAbsentKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceCreateNormalsIfAbsentKey",  "SceneKit")]
		public static NSString CreateNormalsIfAbsentKey {
			get {
				if (_CreateNormalsIfAbsentKey is null)
					_CreateNormalsIfAbsentKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceCreateNormalsIfAbsentKey")!;
				return _CreateNormalsIfAbsentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FlattenSceneKey;
		/// <summary>Represents the value associated with the constant SCNSceneSourceFlattenSceneKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceFlattenSceneKey",  "SceneKit")]
		public static NSString FlattenSceneKey {
			get {
				if (_FlattenSceneKey is null)
					_FlattenSceneKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceFlattenSceneKey")!;
				return _FlattenSceneKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OptionPreserveOriginalTopology;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceLoadingOptionPreserveOriginalTopology",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OptionPreserveOriginalTopology {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OptionPreserveOriginalTopology is null)
					_OptionPreserveOriginalTopology = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceLoadingOptionPreserveOriginalTopology")!;
				return _OptionPreserveOriginalTopology;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OverrideAssetUrlsKey;
		/// <summary>Represents the value associated with the constant SCNSceneSourceOverrideAssetURLsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceOverrideAssetURLsKey",  "SceneKit")]
		public static NSString OverrideAssetUrlsKey {
			get {
				if (_OverrideAssetUrlsKey is null)
					_OverrideAssetUrlsKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceOverrideAssetURLsKey")!;
				return _OverrideAssetUrlsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StrictConformanceKey;
		/// <summary>Represents the value associated with the constant SCNSceneSourceStrictConformanceKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceStrictConformanceKey",  "SceneKit")]
		public static NSString StrictConformanceKey {
			get {
				if (_StrictConformanceKey is null)
					_StrictConformanceKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceStrictConformanceKey")!;
				return _StrictConformanceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UseSafeModeKey;
		/// <summary>Developers should not use this deprecated property. </summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNSceneSourceUseSafeModeKey",  "SceneKit")]
		[ObsoletedOSPlatform ("tvos11.0")]
		[ObsoletedOSPlatform ("ios11.0")]
		[ObsoletedOSPlatform ("macos10.13")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString UseSafeModeKey {
			[ObsoletedOSPlatform ("tvos11.0")]
			[ObsoletedOSPlatform ("ios11.0")]
			[ObsoletedOSPlatform ("macos10.13")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_UseSafeModeKey is null)
					_UseSafeModeKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNSceneSourceUseSafeModeKey")!;
				return _UseSafeModeKey;
			}
		}
	} /* class SCNSceneSourceLoading */
}
