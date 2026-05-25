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
namespace Security {
	internal unsafe static partial class SecKeyGenerationAttributeKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AccessControlKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrAccessControl'.</summary>
		[Field ("kSecAttrAccessControl",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AccessControlKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AccessControlKey is null)
					_AccessControlKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrAccessControl")!;
				return _AccessControlKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplicationTagKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrApplicationTag'.</summary>
		[Field ("kSecAttrApplicationTag",  "Security")]
		public static NSString ApplicationTagKey {
			get {
				if (_ApplicationTagKey is null)
					_ApplicationTagKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrApplicationTag")!;
				return _ApplicationTagKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CanDecryptKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrCanDecrypt'.</summary>
		[Field ("kSecAttrCanDecrypt",  "Security")]
		public static NSString CanDecryptKey {
			get {
				if (_CanDecryptKey is null)
					_CanDecryptKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrCanDecrypt")!;
				return _CanDecryptKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CanDeriveKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrCanDerive'.</summary>
		[Field ("kSecAttrCanDerive",  "Security")]
		public static NSString CanDeriveKey {
			get {
				if (_CanDeriveKey is null)
					_CanDeriveKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrCanDerive")!;
				return _CanDeriveKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CanEncryptKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrCanEncrypt'.</summary>
		[Field ("kSecAttrCanEncrypt",  "Security")]
		public static NSString CanEncryptKey {
			get {
				if (_CanEncryptKey is null)
					_CanEncryptKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrCanEncrypt")!;
				return _CanEncryptKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CanSignKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrCanSign'.</summary>
		[Field ("kSecAttrCanSign",  "Security")]
		public static NSString CanSignKey {
			get {
				if (_CanSignKey is null)
					_CanSignKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrCanSign")!;
				return _CanSignKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CanUnwrapKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrCanUnwrap'.</summary>
		[Field ("kSecAttrCanUnwrap",  "Security")]
		public static NSString CanUnwrapKey {
			get {
				if (_CanUnwrapKey is null)
					_CanUnwrapKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrCanUnwrap")!;
				return _CanUnwrapKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CanVerifyKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrCanVerify'.</summary>
		[Field ("kSecAttrCanVerify",  "Security")]
		public static NSString CanVerifyKey {
			get {
				if (_CanVerifyKey is null)
					_CanVerifyKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrCanVerify")!;
				return _CanVerifyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CanWrapKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrCanWrap'.</summary>
		[Field ("kSecAttrCanWrap",  "Security")]
		public static NSString CanWrapKey {
			get {
				if (_CanWrapKey is null)
					_CanWrapKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrCanWrap")!;
				return _CanWrapKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EffectiveKeySizeKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrEffectiveKeySize'.</summary>
		[Field ("kSecAttrEffectiveKeySize",  "Security")]
		public static NSString EffectiveKeySizeKey {
			get {
				if (_EffectiveKeySizeKey is null)
					_EffectiveKeySizeKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrEffectiveKeySize")!;
				return _EffectiveKeySizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsPermanentKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrIsPermanent'.</summary>
		[Field ("kSecAttrIsPermanent",  "Security")]
		public static NSString IsPermanentKey {
			get {
				if (_IsPermanentKey is null)
					_IsPermanentKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrIsPermanent")!;
				return _IsPermanentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySizeInBitsKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrKeySizeInBits'.</summary>
		[Field ("kSecAttrKeySizeInBits",  "Security")]
		public static NSString KeySizeInBitsKey {
			get {
				if (_KeySizeInBitsKey is null)
					_KeySizeInBitsKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrKeySizeInBits")!;
				return _KeySizeInBitsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyTypeKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrKeyType'.</summary>
		[Field ("kSecAttrKeyType",  "Security")]
		public static NSString KeyTypeKey {
			get {
				if (_KeyTypeKey is null)
					_KeyTypeKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrKeyType")!;
				return _KeyTypeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LabelKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrLabel'.</summary>
		[Field ("kSecAttrLabel",  "Security")]
		public static NSString LabelKey {
			get {
				if (_LabelKey is null)
					_LabelKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrLabel")!;
				return _LabelKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PrivateKeyAttrsKey;
		/// <summary>Represents the value associated with the constant 'kSecPrivateKeyAttrs'.</summary>
		[Field ("kSecPrivateKeyAttrs",  "Security")]
		public static NSString PrivateKeyAttrsKey {
			get {
				if (_PrivateKeyAttrsKey is null)
					_PrivateKeyAttrsKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPrivateKeyAttrs")!;
				return _PrivateKeyAttrsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PublicKeyAttrsKey;
		/// <summary>Represents the value associated with the constant 'kSecPublicKeyAttrs'.</summary>
		[Field ("kSecPublicKeyAttrs",  "Security")]
		public static NSString PublicKeyAttrsKey {
			get {
				if (_PublicKeyAttrsKey is null)
					_PublicKeyAttrsKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPublicKeyAttrs")!;
				return _PublicKeyAttrsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TokenIDKey;
		/// <summary>Represents the value associated with the constant 'kSecAttrTokenID'.</summary>
		[Field ("kSecAttrTokenID",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TokenIDKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TokenIDKey is null)
					_TokenIDKey = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecAttrTokenID")!;
				return _TokenIDKey;
			}
		}
	} /* class SecKeyGenerationAttributeKeys */
}
