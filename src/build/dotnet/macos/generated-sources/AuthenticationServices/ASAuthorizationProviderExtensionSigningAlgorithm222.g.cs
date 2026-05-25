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
	public unsafe static partial class ASAuthorizationProviderExtensionSigningAlgorithm222  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSNumber? _ES256;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationProviderExtensionSigningAlgorithmES256'.</summary>
		[Field ("ASAuthorizationProviderExtensionSigningAlgorithmES256",  "AuthenticationServices")]
		public static NSNumber ES256 {
			get {
				if (_ES256 is null)
					_ES256 = Runtime.GetNSObject<NSNumber> (Dlfcn.GetIndirect (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderExtensionSigningAlgorithmES256"))!;
				return _ES256;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSNumber? _ES384;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationProviderExtensionSigningAlgorithmES384'.</summary>
		[Field ("ASAuthorizationProviderExtensionSigningAlgorithmES384",  "AuthenticationServices")]
		public static NSNumber ES384 {
			get {
				if (_ES384 is null)
					_ES384 = Runtime.GetNSObject<NSNumber> (Dlfcn.GetIndirect (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderExtensionSigningAlgorithmES384"))!;
				return _ES384;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSNumber? _Ed25519;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationProviderExtensionSigningAlgorithmEd25519'.</summary>
		[Field ("ASAuthorizationProviderExtensionSigningAlgorithmEd25519",  "AuthenticationServices")]
		public static NSNumber Ed25519 {
			get {
				if (_Ed25519 is null)
					_Ed25519 = Runtime.GetNSObject<NSNumber> (Dlfcn.GetIndirect (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderExtensionSigningAlgorithmEd25519"))!;
				return _Ed25519;
			}
		}
	} /* class ASAuthorizationProviderExtensionSigningAlgorithm222 */
}
