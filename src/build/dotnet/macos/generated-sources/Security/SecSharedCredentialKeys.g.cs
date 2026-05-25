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
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	internal unsafe static partial class SecSharedCredentialKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AccountKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrAccount'.</summary>
		[Field ("kSecAttrAccount",  "Security")]
		public static NSString AccountKey {
			get {
				if (_AccountKey is null)
					_AccountKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrAccount")!;
				return _AccountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PasswordKey;
		/// <summary>Represents the value associated with the constant 'kSecSharedPassword'.</summary>
		[Field ("kSecSharedPassword",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString PasswordKey {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PasswordKey is null)
					_PasswordKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecSharedPassword")!;
				return _PasswordKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PortKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrPort'.</summary>
		[Field ("kSecAttrPort",  "Security")]
		public static NSString PortKey {
			get {
				if (_PortKey is null)
					_PortKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrPort")!;
				return _PortKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ServerKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrServer'.</summary>
		[Field ("kSecAttrServer",  "Security")]
		public static NSString ServerKey {
			get {
				if (_ServerKey is null)
					_ServerKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrServer")!;
				return _ServerKey;
			}
		}
	} /* class SecSharedCredentialKeys */
}
