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
	public partial class SecKeyGenerationParameters : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="SecKeyGenerationParameters" /> with default (empty) values.</summary>
		public SecKeyGenerationParameters () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="SecKeyGenerationParameters" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public SecKeyGenerationParameters (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>Gets or sets the key size, in bits.</summary><value>The key size, in bits.</value><remarks>To be added.</remarks>
		public int? KeySizeInBits {
			get {
				return  GetInt32Value (SecKeyGenerationAttributeKeys.KeySizeInBitsKey!);
			}
			set {
				SetNumberValue (SecKeyGenerationAttributeKeys.KeySizeInBitsKey!, value);
			}
		}
		/// <summary>Gets or sets the attributes for the private key.</summary><value>The attributes for the private key.</value><remarks>To be added.</remarks>
		public SecKeyParameters? PrivateKeyAttrs {
			get {
				return GetStrongDictionary<SecKeyParameters>(SecKeyGenerationAttributeKeys.PrivateKeyAttrsKey!, (dict) => new SecKeyParameters (dict));
			}
			set {
				SetNativeValue (SecKeyGenerationAttributeKeys.PrivateKeyAttrsKey!, value?.Dictionary);
			}
		}
		/// <summary>Gets or sets the attributes for the public key.</summary><value>The attributes for the public key.</value><remarks>To be added.</remarks>
		public SecKeyParameters? PublicKeyAttrs {
			get {
				return GetStrongDictionary<SecKeyParameters>(SecKeyGenerationAttributeKeys.PublicKeyAttrsKey!, (dict) => new SecKeyParameters (dict));
			}
			set {
				SetNativeValue (SecKeyGenerationAttributeKeys.PublicKeyAttrsKey!, value?.Dictionary);
			}
		}
		/// <summary>Gets or sets the label for the key.</summary><value>The label for the key.</value><remarks>To be added.</remarks>
		public string? Label {
			get {
				return GetStringValue (SecKeyGenerationAttributeKeys.LabelKey!);
			}
			set {
				SetStringValue (SecKeyGenerationAttributeKeys.LabelKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key is permanent.</summary><value>A Boolean value that controls whether the key is permanent.</value><remarks>To be added.</remarks>
		public bool? IsPermanent {
			get {
				return  GetBoolValue (SecKeyGenerationAttributeKeys.IsPermanentKey!);
			}
			set {
				SetBooleanValue (SecKeyGenerationAttributeKeys.IsPermanentKey!, value);
			}
		}
		/// <summary>Gets or sets the application's private tag.</summary><value>The application's private tag.</value><remarks>To be added.</remarks>
		public NSData? ApplicationTag {
			get {
				return Dictionary [SecKeyGenerationAttributeKeys.ApplicationTagKey!] as Foundation.NSData;
			}
			set {
				SetNativeValue (SecKeyGenerationAttributeKeys.ApplicationTagKey!, value);
			}
		}
		/// <summary>Gets or sets a value that describes the minimum size of attack that can defeat the key. This value can be significantly smaller than the actual key size.</summary><value>A value that describes the minimum size of attack that can defeat the key. This value can be significantly smaller than the actual key size.</value><remarks>To be added.</remarks>
		public int? EffectiveKeySize {
			get {
				return  GetInt32Value (SecKeyGenerationAttributeKeys.EffectiveKeySizeKey!);
			}
			set {
				SetNumberValue (SecKeyGenerationAttributeKeys.EffectiveKeySizeKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for encryption.</summary><value>A Boolean value that controls whether the key can be used for encryption.</value><remarks>To be added.</remarks>
		public bool? CanEncrypt {
			get {
				return  GetBoolValue (SecKeyGenerationAttributeKeys.CanEncryptKey!);
			}
			set {
				SetBooleanValue (SecKeyGenerationAttributeKeys.CanEncryptKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for decryption.</summary><value>A  Boolean value that controls whether the key can be used for decryption.</value><remarks>To be added.</remarks>
		public bool? CanDecrypt {
			get {
				return  GetBoolValue (SecKeyGenerationAttributeKeys.CanDecryptKey!);
			}
			set {
				SetBooleanValue (SecKeyGenerationAttributeKeys.CanDecryptKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for key derivation.</summary><value>A  Boolean value that controls whether the key can be used for key derivation.</value><remarks>To be added.</remarks>
		public bool? CanDerive {
			get {
				return  GetBoolValue (SecKeyGenerationAttributeKeys.CanDeriveKey!);
			}
			set {
				SetBooleanValue (SecKeyGenerationAttributeKeys.CanDeriveKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for signing.</summary><value>A Boolean value that controls whether the key can be used for signing.</value><remarks>To be added.</remarks>
		public bool? CanSign {
			get {
				return  GetBoolValue (SecKeyGenerationAttributeKeys.CanSignKey!);
			}
			set {
				SetBooleanValue (SecKeyGenerationAttributeKeys.CanSignKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for verifying signatures.</summary><value>A Boolean value that controls whether the key can be used for verifying signatures.</value><remarks>To be added.</remarks>
		public bool? CanVerify {
			get {
				return  GetBoolValue (SecKeyGenerationAttributeKeys.CanVerifyKey!);
			}
			set {
				SetBooleanValue (SecKeyGenerationAttributeKeys.CanVerifyKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for key wrapping.</summary><value>A Boolean value that controls whether the key can be used for key wrapping.</value><remarks>To be added.</remarks>
		public bool? CanWrap {
			get {
				return  GetBoolValue (SecKeyGenerationAttributeKeys.CanWrapKey!);
			}
			set {
				SetBooleanValue (SecKeyGenerationAttributeKeys.CanWrapKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for key unwrapping.</summary><value>A Boolean value that controls whether the key can be used for key unwrapping.</value><remarks>To be added.</remarks>
		public bool? CanUnwrap {
			get {
				return  GetBoolValue (SecKeyGenerationAttributeKeys.CanUnwrapKey!);
			}
			set {
				SetBooleanValue (SecKeyGenerationAttributeKeys.CanUnwrapKey!, value);
			}
		}
#endif
	}
}
