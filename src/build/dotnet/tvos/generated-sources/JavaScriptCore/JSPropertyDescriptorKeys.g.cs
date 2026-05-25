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
namespace JavaScriptCore {
	/// <summary>Contains keys that index property descriptors.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class JSPropertyDescriptorKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Configurable;
		/// <summary>Represents the value associated with the constant JSPropertyDescriptorConfigurableKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("JSPropertyDescriptorConfigurableKey",  "JavaScriptCore")]
		public static NSString Configurable {
			get {
				if (_Configurable is null)
					_Configurable = Dlfcn.GetStringConstant (Libraries.JavaScriptCore.Handle, "JSPropertyDescriptorConfigurableKey")!;
				return _Configurable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Enumerable;
		/// <summary>Represents the value associated with the constant JSPropertyDescriptorEnumerableKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("JSPropertyDescriptorEnumerableKey",  "JavaScriptCore")]
		public static NSString Enumerable {
			get {
				if (_Enumerable is null)
					_Enumerable = Dlfcn.GetStringConstant (Libraries.JavaScriptCore.Handle, "JSPropertyDescriptorEnumerableKey")!;
				return _Enumerable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Get;
		/// <summary>Represents the value associated with the constant JSPropertyDescriptorGetKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("JSPropertyDescriptorGetKey",  "JavaScriptCore")]
		public static NSString Get {
			get {
				if (_Get is null)
					_Get = Dlfcn.GetStringConstant (Libraries.JavaScriptCore.Handle, "JSPropertyDescriptorGetKey")!;
				return _Get;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Set;
		/// <summary>Represents the value associated with the constant JSPropertyDescriptorSetKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("JSPropertyDescriptorSetKey",  "JavaScriptCore")]
		public static NSString Set {
			get {
				if (_Set is null)
					_Set = Dlfcn.GetStringConstant (Libraries.JavaScriptCore.Handle, "JSPropertyDescriptorSetKey")!;
				return _Set;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Value;
		/// <summary>Represents the value associated with the constant JSPropertyDescriptorValueKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("JSPropertyDescriptorValueKey",  "JavaScriptCore")]
		public static NSString Value {
			get {
				if (_Value is null)
					_Value = Dlfcn.GetStringConstant (Libraries.JavaScriptCore.Handle, "JSPropertyDescriptorValueKey")!;
				return _Value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Writable;
		/// <summary>Represents the value associated with the constant JSPropertyDescriptorWritableKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("JSPropertyDescriptorWritableKey",  "JavaScriptCore")]
		public static NSString Writable {
			get {
				if (_Writable is null)
					_Writable = Dlfcn.GetStringConstant (Libraries.JavaScriptCore.Handle, "JSPropertyDescriptorWritableKey")!;
				return _Writable;
			}
		}
	} /* class JSPropertyDescriptorKeys */
}
