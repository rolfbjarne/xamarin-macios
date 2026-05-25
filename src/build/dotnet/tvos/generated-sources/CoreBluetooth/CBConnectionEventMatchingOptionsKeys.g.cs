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
namespace CoreBluetooth {
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	internal unsafe static partial class CBConnectionEventMatchingOptionsKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PeripheralUuidsKey;
		/// <summary>Represents the value associated with the constant 'CBConnectionEventMatchingOptionPeripheralUUIDs'.</summary>
		[Field ("CBConnectionEventMatchingOptionPeripheralUUIDs",  "CoreBluetooth")]
		public static NSString PeripheralUuidsKey {
			get {
				if (_PeripheralUuidsKey is null)
					_PeripheralUuidsKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBConnectionEventMatchingOptionPeripheralUUIDs")!;
				return _PeripheralUuidsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ServiceUuidsKey;
		/// <summary>Represents the value associated with the constant 'CBConnectionEventMatchingOptionServiceUUIDs'.</summary>
		[Field ("CBConnectionEventMatchingOptionServiceUUIDs",  "CoreBluetooth")]
		public static NSString ServiceUuidsKey {
			get {
				if (_ServiceUuidsKey is null)
					_ServiceUuidsKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBConnectionEventMatchingOptionServiceUUIDs")!;
				return _ServiceUuidsKey;
			}
		}
	} /* class CBConnectionEventMatchingOptionsKeys */
}
