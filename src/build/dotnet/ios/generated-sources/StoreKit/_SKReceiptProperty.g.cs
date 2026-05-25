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
namespace StoreKit {
	[ObsoletedOSPlatform ("ios18.0")]
	[ObsoletedOSPlatform ("maccatalyst18.0")]
	[ObsoletedOSPlatform ("macos15.0")]
	[ObsoletedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class _SKReceiptProperty  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsExpired;
		/// <summary>Represents the value associated with the constant 'SKReceiptPropertyIsExpired'.</summary>
		[Field ("SKReceiptPropertyIsExpired",  "StoreKit")]
		internal static NSString IsExpired {
			get {
				if (_IsExpired is null)
					_IsExpired = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKReceiptPropertyIsExpired")!;
				return _IsExpired;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsRevoked;
		/// <summary>Represents the value associated with the constant 'SKReceiptPropertyIsRevoked'.</summary>
		[Field ("SKReceiptPropertyIsRevoked",  "StoreKit")]
		internal static NSString IsRevoked {
			get {
				if (_IsRevoked is null)
					_IsRevoked = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKReceiptPropertyIsRevoked")!;
				return _IsRevoked;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsVolumePurchase;
		/// <summary>Represents the value associated with the constant 'SKReceiptPropertyIsVolumePurchase'.</summary>
		[Field ("SKReceiptPropertyIsVolumePurchase",  "StoreKit")]
		internal static NSString IsVolumePurchase {
			get {
				if (_IsVolumePurchase is null)
					_IsVolumePurchase = Dlfcn.GetStringConstant (Libraries.StoreKit.Handle, "SKReceiptPropertyIsVolumePurchase")!;
				return _IsVolumePurchase;
			}
		}
	} /* class _SKReceiptProperty */
}
