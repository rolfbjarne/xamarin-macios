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
	/// <summary>Enumerates the types of <see cref="T:SceneKit.SCNLight" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class SCNLightType  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Ambient;
		/// <summary>Represents the value associated with the constant SCNLightTypeAmbient</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNLightTypeAmbient",  "SceneKit")]
		public static NSString Ambient {
			get {
				if (_Ambient is null)
					_Ambient = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightTypeAmbient")!;
				return _Ambient;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Area;
		/// <summary>Represents the value associated with the constant 'SCNLightTypeArea'.</summary>
		[Field ("SCNLightTypeArea",  "SceneKit")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Area {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Area is null)
					_Area = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightTypeArea")!;
				return _Area;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Directional;
		/// <summary>Represents the value associated with the constant SCNLightTypeDirectional</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNLightTypeDirectional",  "SceneKit")]
		public static NSString Directional {
			get {
				if (_Directional is null)
					_Directional = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightTypeDirectional")!;
				return _Directional;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Ies;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNLightTypeIES",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Ies {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Ies is null)
					_Ies = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightTypeIES")!;
				return _Ies;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Omni;
		/// <summary>Represents the value associated with the constant SCNLightTypeOmni</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNLightTypeOmni",  "SceneKit")]
		public static NSString Omni {
			get {
				if (_Omni is null)
					_Omni = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightTypeOmni")!;
				return _Omni;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Probe;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("SCNLightTypeProbe",  "SceneKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Probe {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Probe is null)
					_Probe = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightTypeProbe")!;
				return _Probe;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Spot;
		/// <summary>Represents the value associated with the constant SCNLightTypeSpot</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNLightTypeSpot",  "SceneKit")]
		public static NSString Spot {
			get {
				if (_Spot is null)
					_Spot = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNLightTypeSpot")!;
				return _Spot;
			}
		}
	} /* class SCNLightType */
}
