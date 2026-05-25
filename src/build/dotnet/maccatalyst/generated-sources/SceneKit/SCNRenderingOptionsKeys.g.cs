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
	} /* class SCNRenderingOptionsKeys */
}
