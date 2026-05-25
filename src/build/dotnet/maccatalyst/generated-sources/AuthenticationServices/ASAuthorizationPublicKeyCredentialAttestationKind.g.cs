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
namespace AuthenticationServices {
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class ASAuthorizationPublicKeyCredentialAttestationKind  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Direct;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationPublicKeyCredentialAttestationKindDirect'.</summary>
		[Field ("ASAuthorizationPublicKeyCredentialAttestationKindDirect",  "AuthenticationServices")]
		public static NSString Direct {
			get {
				if (_Direct is null)
					_Direct = Dlfcn.GetStringConstant (Libraries.AuthenticationServices.Handle, "ASAuthorizationPublicKeyCredentialAttestationKindDirect")!;
				return _Direct;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Enterprise;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationPublicKeyCredentialAttestationKindEnterprise'.</summary>
		[Field ("ASAuthorizationPublicKeyCredentialAttestationKindEnterprise",  "AuthenticationServices")]
		public static NSString Enterprise {
			get {
				if (_Enterprise is null)
					_Enterprise = Dlfcn.GetStringConstant (Libraries.AuthenticationServices.Handle, "ASAuthorizationPublicKeyCredentialAttestationKindEnterprise")!;
				return _Enterprise;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Indirect;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationPublicKeyCredentialAttestationKindIndirect'.</summary>
		[Field ("ASAuthorizationPublicKeyCredentialAttestationKindIndirect",  "AuthenticationServices")]
		public static NSString Indirect {
			get {
				if (_Indirect is null)
					_Indirect = Dlfcn.GetStringConstant (Libraries.AuthenticationServices.Handle, "ASAuthorizationPublicKeyCredentialAttestationKindIndirect")!;
				return _Indirect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _None;
		/// <summary>Represents the value associated with the constant 'ASAuthorizationPublicKeyCredentialAttestationKindNone'.</summary>
		[Field ("ASAuthorizationPublicKeyCredentialAttestationKindNone",  "AuthenticationServices")]
		public static NSString None {
			get {
				if (_None is null)
					_None = Dlfcn.GetStringConstant (Libraries.AuthenticationServices.Handle, "ASAuthorizationPublicKeyCredentialAttestationKindNone")!;
				return _None;
			}
		}
	} /* class ASAuthorizationPublicKeyCredentialAttestationKind */
}
