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
namespace Security {
	/// <summary>Contains attributes for creating and using public-private key pairs.</summary><remarks>To be added.</remarks>
	public partial class SecPublicPrivateKeyAttrs : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="SecPublicPrivateKeyAttrs" /> with default (empty) values.</summary>
		public SecPublicPrivateKeyAttrs () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="SecPublicPrivateKeyAttrs" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public SecPublicPrivateKeyAttrs (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>Gets or sets the label for the key pair.</summary><value>The label for the key pair.</value><remarks>To be added.</remarks>
		public string? Label {
			get {
				return GetStringValue (SecAttributeKeys.LabelKey!);
			}
			set {
				SetStringValue (SecAttributeKeys.LabelKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key pair is permanent.</summary><value>A Boolean value that controls whether the key pair is permanent.</value><remarks>To be added.</remarks>
		public bool? IsPermanent {
			get {
				return  GetBoolValue (SecAttributeKeys.IsPermanentKey!);
			}
			set {
				SetBooleanValue (SecAttributeKeys.IsPermanentKey!, value);
			}
		}
		/// <summary>Gets or sets the application's private tag.</summary><value>The application's private tag.</value><remarks>To be added.</remarks>
		public NSData? ApplicationTag {
			get {
				return Dictionary [SecAttributeKeys.ApplicationTagKey!] as Foundation.NSData;
			}
			set {
				SetNativeValue (SecAttributeKeys.ApplicationTagKey!, value);
			}
		}
		/// <summary>Gets or sets a value that describes the minimum size of attack that can defeat the key pair. This value can be significantly smaller than the actual key size.</summary><value>A value that describes the minimum size of attack that can defeat the key pair. This value can be significantly smaller than the actual key size.</value><remarks>To be added.</remarks>
		public int? EffectiveKeySize {
			get {
				return  GetInt32Value (SecAttributeKeys.EffectiveKeySizeKey!);
			}
			set {
				SetNumberValue (SecAttributeKeys.EffectiveKeySizeKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key pair can be used for encryption.</summary><value>A Boolean value that controls whether the key pair can be used for encryption.</value><remarks>To be added.</remarks>
		public bool? CanEncrypt {
			get {
				return  GetBoolValue (SecAttributeKeys.CanEncryptKey!);
			}
			set {
				SetBooleanValue (SecAttributeKeys.CanEncryptKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key pair can be used for decryption.</summary><value>A  Boolean value that controls whether the key pair can be used for decryption.</value><remarks>To be added.</remarks>
		public bool? CanDecrypt {
			get {
				return  GetBoolValue (SecAttributeKeys.CanDecryptKey!);
			}
			set {
				SetBooleanValue (SecAttributeKeys.CanDecryptKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key pair can be used for key derivation.</summary><value>A  Boolean value that controls whether the key pair can be used for key derivation.</value><remarks>To be added.</remarks>
		public bool? CanDerive {
			get {
				return  GetBoolValue (SecAttributeKeys.CanDeriveKey!);
			}
			set {
				SetBooleanValue (SecAttributeKeys.CanDeriveKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key pair can be used for signing.</summary><value>A Boolean value that controls whether the key pair can be used for signing.</value><remarks>To be added.</remarks>
		public bool? CanSign {
			get {
				return  GetBoolValue (SecAttributeKeys.CanSignKey!);
			}
			set {
				SetBooleanValue (SecAttributeKeys.CanSignKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key pair can be used for verifying signatures.</summary><value>A Boolean value that controls whether the key pair can be used for verifying signatures.</value><remarks>To be added.</remarks>
		public bool? CanVerify {
			get {
				return  GetBoolValue (SecAttributeKeys.CanVerifyKey!);
			}
			set {
				SetBooleanValue (SecAttributeKeys.CanVerifyKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key pair can be used for key unwrapping.</summary><value>A Boolean value that controls whether the key pair can be used for key unwrapping.</value><remarks>To be added.</remarks>
		public bool? CanUnwrap {
			get {
				return  GetBoolValue (SecAttributeKeys.CanUnwrapKey!);
			}
			set {
				SetBooleanValue (SecAttributeKeys.CanUnwrapKey!, value);
			}
		}
#endif
	}
}
