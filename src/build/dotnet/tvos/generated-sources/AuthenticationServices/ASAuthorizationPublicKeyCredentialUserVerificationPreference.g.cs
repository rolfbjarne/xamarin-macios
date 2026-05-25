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
namespace AuthenticationServices {
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class ASAuthorizationPublicKeyCredentialUserVerificationPreference  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Discouraged;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationPublicKeyCredentialUserVerificationPreferenceDiscouraged'.</summary>
		[Field ("ASAuthorizationPublicKeyCredentialUserVerificationPreferenceDiscouraged",  "AuthenticationServices")]
		public static NSString Discouraged {
			get {
				if (_Discouraged is null)
					_Discouraged = Dlfcn.GetStringConstant (Libraries.AuthenticationServices.Handle, "ASAuthorizationPublicKeyCredentialUserVerificationPreferenceDiscouraged")!;
				return _Discouraged;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Preferred;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationPublicKeyCredentialUserVerificationPreferencePreferred'.</summary>
		[Field ("ASAuthorizationPublicKeyCredentialUserVerificationPreferencePreferred",  "AuthenticationServices")]
		public static NSString Preferred {
			get {
				if (_Preferred is null)
					_Preferred = Dlfcn.GetStringConstant (Libraries.AuthenticationServices.Handle, "ASAuthorizationPublicKeyCredentialUserVerificationPreferencePreferred")!;
				return _Preferred;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Required;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationPublicKeyCredentialUserVerificationPreferenceRequired'.</summary>
		[Field ("ASAuthorizationPublicKeyCredentialUserVerificationPreferenceRequired",  "AuthenticationServices")]
		public static NSString Required {
			get {
				if (_Required is null)
					_Required = Dlfcn.GetStringConstant (Libraries.AuthenticationServices.Handle, "ASAuthorizationPublicKeyCredentialUserVerificationPreferenceRequired")!;
				return _Required;
			}
		}
	} /* class ASAuthorizationPublicKeyCredentialUserVerificationPreference */
}
