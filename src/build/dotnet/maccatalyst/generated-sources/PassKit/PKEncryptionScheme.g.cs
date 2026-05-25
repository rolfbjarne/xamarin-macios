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
namespace PassKit {
	/// <summary>Defines the constant string <see cref="P:PassKit.PKEncryptionScheme.Ecc_V2" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class PKEncryptionScheme  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Ecc_V2;
		/// <summary>Elliptical Curve Cryptography, version 2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKEncryptionSchemeECC_V2",  "PassKit")]
		public static NSString Ecc_V2 {
			get {
				if (_Ecc_V2 is null)
					_Ecc_V2 = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKEncryptionSchemeECC_V2")!;
				return _Ecc_V2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Rsa_V2;
		/// <summary>RSA v2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PKEncryptionSchemeRSA_V2",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString Rsa_V2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Rsa_V2 is null)
					_Rsa_V2 = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKEncryptionSchemeRSA_V2")!;
				return _Rsa_V2;
			}
		}
	} /* class PKEncryptionScheme */
}
