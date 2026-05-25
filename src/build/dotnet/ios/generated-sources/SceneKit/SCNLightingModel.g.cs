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
	/// <summary>Constants for use with the <see cref="P:SceneKit.SCNMaterial.LightingModelName" /> property, which defines the way lights and materials combine to produce a particular rendered color.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class SCNLightingModel  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Blinn;
		/// <summary>Represents the value associated with the constant SCNLightingModelBlinn</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNLightingModelBlinn",  "SceneKit")]
		public static NSString Blinn {
			get {
				if (_Blinn is null)
					_Blinn = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightingModelBlinn")!;
				return _Blinn;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Constant;
		/// <summary>Represents the value associated with the constant SCNLightingModelConstant</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNLightingModelConstant",  "SceneKit")]
		public static NSString Constant {
			get {
				if (_Constant is null)
					_Constant = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightingModelConstant")!;
				return _Constant;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Lambert;
		/// <summary>Represents the value associated with the constant SCNLightingModelLambert</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNLightingModelLambert",  "SceneKit")]
		public static NSString Lambert {
			get {
				if (_Lambert is null)
					_Lambert = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightingModelLambert")!;
				return _Lambert;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Phong;
		/// <summary>Represents the value associated with the constant SCNLightingModelPhong</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNLightingModelPhong",  "SceneKit")]
		public static NSString Phong {
			get {
				if (_Phong is null)
					_Phong = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightingModelPhong")!;
				return _Phong;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PhysicallyBased;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNLightingModelPhysicallyBased",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PhysicallyBased {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PhysicallyBased is null)
					_PhysicallyBased = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightingModelPhysicallyBased")!;
				return _PhysicallyBased;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShadowOnly;
		/// <summary>Represents the value associated with the constant 'SCNLightingModelShadowOnly'.</summary>
		[Field ("SCNLightingModelShadowOnly",  "SceneKit")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ShadowOnly {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ShadowOnly is null)
					_ShadowOnly = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightingModelShadowOnly")!;
				return _ShadowOnly;
			}
		}
	} /* class SCNLightingModel */
}
