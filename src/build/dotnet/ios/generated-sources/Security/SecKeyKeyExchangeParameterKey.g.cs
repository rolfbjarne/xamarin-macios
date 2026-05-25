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
namespace Security {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class SecKeyKeyExchangeParameterKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RequestedSizeKey;
		/// <summary>Represents the value associated with the constant 'kSecKeyKeyExchangeParameterRequestedSize'.</summary>
		[Field ("kSecKeyKeyExchangeParameterRequestedSize",  "Security")]
		public static NSString RequestedSizeKey {
			get {
				if (_RequestedSizeKey is null)
					_RequestedSizeKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecKeyKeyExchangeParameterRequestedSize")!;
				return _RequestedSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SharedInfoKey;
		/// <summary>Represents the value associated with the constant 'kSecKeyKeyExchangeParameterSharedInfo'.</summary>
		[Field ("kSecKeyKeyExchangeParameterSharedInfo",  "Security")]
		public static NSString SharedInfoKey {
			get {
				if (_SharedInfoKey is null)
					_SharedInfoKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecKeyKeyExchangeParameterSharedInfo")!;
				return _SharedInfoKey;
			}
		}
	} /* class SecKeyKeyExchangeParameterKey */
}
