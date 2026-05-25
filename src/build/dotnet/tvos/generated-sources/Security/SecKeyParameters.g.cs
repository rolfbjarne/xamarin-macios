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
namespace Security {
	public partial class SecKeyParameters : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="SecKeyParameters" /> with default (empty) values.</summary>
		public SecKeyParameters () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="SecKeyParameters" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public SecKeyParameters (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>Gets or sets the label for the key.</summary><value>The label for the key.</value><remarks>To be added.</remarks>
		public string? Label {
			get {
				return GetStringValue (SecAttributeKeys.LabelKey!);
			}
			set {
				SetStringValue (SecAttributeKeys.LabelKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key is permanent.</summary><value>A Boolean value that controls whether the key is permanent.</value><remarks>To be added.</remarks>
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
		/// <summary>Gets or sets a value that describes the minimum size of attack that can defeat the key. This value can be significantly smaller than the actual key size.</summary><value>A value that describes the minimum size of attack that can defeat the key. This value can be significantly smaller than the actual key size.</value><remarks>To be added.</remarks>
		public int? EffectiveKeySize {
			get {
				return  GetInt32Value (SecAttributeKeys.EffectiveKeySizeKey!);
			}
			set {
				SetNumberValue (SecAttributeKeys.EffectiveKeySizeKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for encryption.</summary><value>A Boolean value that controls whether the key can be used for encryption.</value><remarks>To be added.</remarks>
		public bool? CanEncrypt {
			get {
				return  GetBoolValue (SecAttributeKeys.CanEncryptKey!);
			}
			set {
				SetBooleanValue (SecAttributeKeys.CanEncryptKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for decryption.</summary><value>A  Boolean value that controls whether the key can be used for decryption.</value><remarks>To be added.</remarks>
		public bool? CanDecrypt {
			get {
				return  GetBoolValue (SecAttributeKeys.CanDecryptKey!);
			}
			set {
				SetBooleanValue (SecAttributeKeys.CanDecryptKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for key derivation.</summary><value>A  Boolean value that controls whether the key can be used for key derivation.</value><remarks>To be added.</remarks>
		public bool? CanDerive {
			get {
				return  GetBoolValue (SecAttributeKeys.CanDeriveKey!);
			}
			set {
				SetBooleanValue (SecAttributeKeys.CanDeriveKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for signing.</summary><value>A Boolean value that controls whether the key can be used for signing.</value><remarks>To be added.</remarks>
		public bool? CanSign {
			get {
				return  GetBoolValue (SecAttributeKeys.CanSignKey!);
			}
			set {
				SetBooleanValue (SecAttributeKeys.CanSignKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for verifying signatures.</summary><value>A Boolean value that controls whether the key can be used for verifying signatures.</value><remarks>To be added.</remarks>
		public bool? CanVerify {
			get {
				return  GetBoolValue (SecAttributeKeys.CanVerifyKey!);
			}
			set {
				SetBooleanValue (SecAttributeKeys.CanVerifyKey!, value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for key unwrapping.</summary><value>A Boolean value that controls whether the key can be used for key unwrapping.</value><remarks>To be added.</remarks>
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
