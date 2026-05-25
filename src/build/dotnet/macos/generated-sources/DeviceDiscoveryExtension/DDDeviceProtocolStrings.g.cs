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
namespace DeviceDiscoveryExtension {
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[UnsupportedOSPlatform ("tvos")]
	public unsafe static partial class DDDeviceProtocolStrings  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Dial;
		/// <summary>Represents the value associated with the constant 'DDDeviceProtocolStringDIAL'.</summary>
		[Field ("DDDeviceProtocolStringDIAL",  "DeviceDiscoveryExtension")]
		public static NSString Dial {
			get {
				if (_Dial is null)
					_Dial = Dlfcn.GetStringConstant (Libraries.DeviceDiscoveryExtension.Handle, "DDDeviceProtocolStringDIAL")!;
				return _Dial;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Invalid;
		/// <summary>Represents the value associated with the constant 'DDDeviceProtocolStringInvalid'.</summary>
		[Field ("DDDeviceProtocolStringInvalid",  "DeviceDiscoveryExtension")]
		public static NSString Invalid {
			get {
				if (_Invalid is null)
					_Invalid = Dlfcn.GetStringConstant (Libraries.DeviceDiscoveryExtension.Handle, "DDDeviceProtocolStringInvalid")!;
				return _Invalid;
			}
		}
	} /* class DDDeviceProtocolStrings */
}
