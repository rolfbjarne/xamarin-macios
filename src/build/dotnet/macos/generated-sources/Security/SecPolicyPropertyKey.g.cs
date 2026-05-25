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
	/// <summary>Contains keys that index security policy data..</summary><remarks>To be added.</remarks>
	public unsafe static partial class SecPolicyPropertyKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Client;
		/// <summary>Represents the value associated with the constant kSecPolicyClient</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecPolicyClient",  "Security")]
		public static NSString Client {
			get {
				if (_Client is null)
					_Client = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyClient")!;
				return _Client;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Name;
		/// <summary>Represents the value associated with the constant kSecPolicyName</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecPolicyName",  "Security")]
		public static NSString Name {
			get {
				if (_Name is null)
					_Name = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyName")!;
				return _Name;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Oid;
		/// <summary>Represents the value associated with the constant kSecPolicyOid</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecPolicyOid",  "Security")]
		public static NSString Oid {
			get {
				if (_Oid is null)
					_Oid = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyOid")!;
				return _Oid;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RevocationFlags;
		/// <summary>Represents the value associated with the constant kSecPolicyRevocationFlags</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecPolicyRevocationFlags",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString RevocationFlags {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_RevocationFlags is null)
					_RevocationFlags = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyRevocationFlags")!;
				return _RevocationFlags;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TeamIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kSecPolicyTeamIdentifier",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TeamIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TeamIdentifier is null)
					_TeamIdentifier = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPolicyTeamIdentifier")!;
				return _TeamIdentifier;
			}
		}
	} /* class SecPolicyPropertyKey */
}
