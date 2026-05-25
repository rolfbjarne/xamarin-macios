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
