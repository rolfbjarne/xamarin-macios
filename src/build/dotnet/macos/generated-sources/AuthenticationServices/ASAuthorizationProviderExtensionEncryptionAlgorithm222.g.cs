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
namespace AuthenticationServices {
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe static partial class ASAuthorizationProviderExtensionEncryptionAlgorithm222  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSNumber? _EcdheA256Gcm;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationProviderExtensionEncryptionAlgorithmECDHE_A256GCM'.</summary>
		[Field ("ASAuthorizationProviderExtensionEncryptionAlgorithmECDHE_A256GCM",  "AuthenticationServices")]
		public static NSNumber EcdheA256Gcm {
			get {
				if (_EcdheA256Gcm is null)
					_EcdheA256Gcm = Runtime.GetNSObject<NSNumber> (Dlfcn.GetIndirect (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderExtensionEncryptionAlgorithmECDHE_A256GCM"))!;
				return _EcdheA256Gcm;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSNumber? _HpkeCurve25519Sha256ChachaPoly;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_Curve25519_SHA256_ChachaPoly'.</summary>
		[Field ("ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_Curve25519_SHA256_ChachaPoly",  "AuthenticationServices")]
		public static NSNumber HpkeCurve25519Sha256ChachaPoly {
			get {
				if (_HpkeCurve25519Sha256ChachaPoly is null)
					_HpkeCurve25519Sha256ChachaPoly = Runtime.GetNSObject<NSNumber> (Dlfcn.GetIndirect (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_Curve25519_SHA256_ChachaPoly"))!;
				return _HpkeCurve25519Sha256ChachaPoly;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSNumber? _HpkeP256Sha256AesGcm256;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P256_SHA256_AES_GCM_256'.</summary>
		[Field ("ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P256_SHA256_AES_GCM_256",  "AuthenticationServices")]
		public static NSNumber HpkeP256Sha256AesGcm256 {
			get {
				if (_HpkeP256Sha256AesGcm256 is null)
					_HpkeP256Sha256AesGcm256 = Runtime.GetNSObject<NSNumber> (Dlfcn.GetIndirect (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P256_SHA256_AES_GCM_256"))!;
				return _HpkeP256Sha256AesGcm256;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSNumber? _HpkeP384Sha384AesGcm256;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P384_SHA384_AES_GCM_256'.</summary>
		[Field ("ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P384_SHA384_AES_GCM_256",  "AuthenticationServices")]
		public static NSNumber HpkeP384Sha384AesGcm256 {
			get {
				if (_HpkeP384Sha384AesGcm256 is null)
					_HpkeP384Sha384AesGcm256 = Runtime.GetNSObject<NSNumber> (Dlfcn.GetIndirect (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P384_SHA384_AES_GCM_256"))!;
				return _HpkeP384Sha384AesGcm256;
			}
		}
	} /* class ASAuthorizationProviderExtensionEncryptionAlgorithm222 */
}
