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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class SCNRenderingOptionsKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeviceKey;
		/// <summary>Represents the value associated with the constant 'SCNPreferredDeviceKey'.</summary>
		[Field ("SCNPreferredDeviceKey",  "SceneKit")]
		public static NSString DeviceKey {
			get {
				if (_DeviceKey is null)
					_DeviceKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPreferredDeviceKey")!;
				return _DeviceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LowPowerDeviceKey;
		/// <summary>Represents the value associated with the constant 'SCNPreferLowPowerDeviceKey'.</summary>
		[Field ("SCNPreferLowPowerDeviceKey",  "SceneKit")]
		public static NSString LowPowerDeviceKey {
			get {
				if (_LowPowerDeviceKey is null)
					_LowPowerDeviceKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPreferLowPowerDeviceKey")!;
				return _LowPowerDeviceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RenderingApiKey;
		/// <summary>Represents the value associated with the constant 'SCNPreferredRenderingAPIKey'.</summary>
		[Field ("SCNPreferredRenderingAPIKey",  "SceneKit")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString RenderingApiKey {
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_RenderingApiKey is null)
					_RenderingApiKey = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPreferredRenderingAPIKey")!;
				return _RenderingApiKey;
			}
		}
	} /* class SCNRenderingOptionsKeys */
}
