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
namespace SceneKit {
	/// <summary>A dictionary of shader snippets.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class _SCNShaderModifiers  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EntryPointFragmentKey;
		/// <summary>Represents the value associated with the constant 'SCNShaderModifierEntryPointFragment'.</summary>
		[Field ("SCNShaderModifierEntryPointFragment",  "SceneKit")]
		internal static NSString EntryPointFragmentKey {
			get {
				if (_EntryPointFragmentKey is null)
					_EntryPointFragmentKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNShaderModifierEntryPointFragment")!;
				return _EntryPointFragmentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EntryPointGeometryKey;
		/// <summary>Represents the value associated with the constant 'SCNShaderModifierEntryPointGeometry'.</summary>
		[Field ("SCNShaderModifierEntryPointGeometry",  "SceneKit")]
		internal static NSString EntryPointGeometryKey {
			get {
				if (_EntryPointGeometryKey is null)
					_EntryPointGeometryKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNShaderModifierEntryPointGeometry")!;
				return _EntryPointGeometryKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EntryPointLightingModelKey;
		/// <summary>Represents the value associated with the constant 'SCNShaderModifierEntryPointLightingModel'.</summary>
		[Field ("SCNShaderModifierEntryPointLightingModel",  "SceneKit")]
		internal static NSString EntryPointLightingModelKey {
			get {
				if (_EntryPointLightingModelKey is null)
					_EntryPointLightingModelKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNShaderModifierEntryPointLightingModel")!;
				return _EntryPointLightingModelKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EntryPointSurfaceKey;
		/// <summary>Represents the value associated with the constant 'SCNShaderModifierEntryPointSurface'.</summary>
		[Field ("SCNShaderModifierEntryPointSurface",  "SceneKit")]
		internal static NSString EntryPointSurfaceKey {
			get {
				if (_EntryPointSurfaceKey is null)
					_EntryPointSurfaceKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNShaderModifierEntryPointSurface")!;
				return _EntryPointSurfaceKey;
			}
		}
	} /* class _SCNShaderModifiers */
}
