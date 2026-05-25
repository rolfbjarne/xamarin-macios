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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace SceneKit {
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.10")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class SCNLightAttribute  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AttenuationEndKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNLightAttenuationEndKey",  "SceneKit")]
		public static NSString AttenuationEndKey {
			get {
				if (_AttenuationEndKey is null)
					_AttenuationEndKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightAttenuationEndKey")!;
				return _AttenuationEndKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AttenuationFalloffExponentKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNLightAttenuationFalloffExponentKey",  "SceneKit")]
		public static NSString AttenuationFalloffExponentKey {
			get {
				if (_AttenuationFalloffExponentKey is null)
					_AttenuationFalloffExponentKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightAttenuationFalloffExponentKey")!;
				return _AttenuationFalloffExponentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AttenuationStartKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNLightAttenuationStartKey",  "SceneKit")]
		public static NSString AttenuationStartKey {
			get {
				if (_AttenuationStartKey is null)
					_AttenuationStartKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightAttenuationStartKey")!;
				return _AttenuationStartKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShadowFarClippingKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNLightShadowFarClippingKey",  "SceneKit")]
		public static NSString ShadowFarClippingKey {
			get {
				if (_ShadowFarClippingKey is null)
					_ShadowFarClippingKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightShadowFarClippingKey")!;
				return _ShadowFarClippingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShadowNearClippingKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNLightShadowNearClippingKey",  "SceneKit")]
		public static NSString ShadowNearClippingKey {
			get {
				if (_ShadowNearClippingKey is null)
					_ShadowNearClippingKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightShadowNearClippingKey")!;
				return _ShadowNearClippingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpotInnerAngleKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNLightSpotInnerAngleKey",  "SceneKit")]
		public static NSString SpotInnerAngleKey {
			get {
				if (_SpotInnerAngleKey is null)
					_SpotInnerAngleKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightSpotInnerAngleKey")!;
				return _SpotInnerAngleKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpotOuterAngleKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNLightSpotOuterAngleKey",  "SceneKit")]
		public static NSString SpotOuterAngleKey {
			get {
				if (_SpotOuterAngleKey is null)
					_SpotOuterAngleKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightSpotOuterAngleKey")!;
				return _SpotOuterAngleKey;
			}
		}
	} /* class SCNLightAttribute */
}
