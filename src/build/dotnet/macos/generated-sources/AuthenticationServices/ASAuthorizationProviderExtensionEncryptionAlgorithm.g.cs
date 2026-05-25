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
	public enum ASAuthorizationProviderExtensionEncryptionAlgorithm : int {
		EcdheA256Gcm = 0,
		HpkeP256Sha256AesGcm256 = 1,
		HpkeP384Sha384AesGcm256 = 2,
		HpkeCurve25519Sha256ChachaPoly = 3,
	}
	/// <summary>Extension methods for the <see cref="global::AuthenticationServices.ASAuthorizationProviderExtensionEncryptionAlgorithm" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class ASAuthorizationProviderExtensionEncryptionAlgorithmExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("ASAuthorizationProviderExtensionEncryptionAlgorithmECDHE_A256GCM", "AuthenticationServices")]
		internal unsafe static IntPtr ASAuthorizationProviderExtensionEncryptionAlgorithmECDHE_A256GCM {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderExtensionEncryptionAlgorithmECDHE_A256GCM", storage);
			}
		}
		[Field ("ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P256_SHA256_AES_GCM_256", "AuthenticationServices")]
		internal unsafe static IntPtr ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P256_SHA256_AES_GCM_256 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P256_SHA256_AES_GCM_256", storage);
			}
		}
		[Field ("ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P384_SHA384_AES_GCM_256", "AuthenticationServices")]
		internal unsafe static IntPtr ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P384_SHA384_AES_GCM_256 {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P384_SHA384_AES_GCM_256", storage);
			}
		}
		[Field ("ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_Curve25519_SHA256_ChachaPoly", "AuthenticationServices")]
		internal unsafe static IntPtr ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_Curve25519_SHA256_ChachaPoly {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_Curve25519_SHA256_ChachaPoly", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSNumber" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSNumber? GetConstant (this ASAuthorizationProviderExtensionEncryptionAlgorithm self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // ASAuthorizationProviderExtensionEncryptionAlgorithm.EcdheA256Gcm
				ptr = ASAuthorizationProviderExtensionEncryptionAlgorithmECDHE_A256GCM;
				break;
			case 1: // ASAuthorizationProviderExtensionEncryptionAlgorithm.HpkeP256Sha256AesGcm256
				ptr = ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P256_SHA256_AES_GCM_256;
				break;
			case 2: // ASAuthorizationProviderExtensionEncryptionAlgorithm.HpkeP384Sha384AesGcm256
				ptr = ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P384_SHA384_AES_GCM_256;
				break;
			case 3: // ASAuthorizationProviderExtensionEncryptionAlgorithm.HpkeCurve25519Sha256ChachaPoly
				ptr = ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_Curve25519_SHA256_ChachaPoly;
				break;
			}
			return (NSNumber?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AuthenticationServices.ASAuthorizationProviderExtensionEncryptionAlgorithm" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static ASAuthorizationProviderExtensionEncryptionAlgorithm GetValue (NSNumber constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (ASAuthorizationProviderExtensionEncryptionAlgorithmECDHE_A256GCM))
				return ASAuthorizationProviderExtensionEncryptionAlgorithm.EcdheA256Gcm;
			if (constant.IsEqualTo (ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P256_SHA256_AES_GCM_256))
				return ASAuthorizationProviderExtensionEncryptionAlgorithm.HpkeP256Sha256AesGcm256;
			if (constant.IsEqualTo (ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_P384_SHA384_AES_GCM_256))
				return ASAuthorizationProviderExtensionEncryptionAlgorithm.HpkeP384Sha384AesGcm256;
			if (constant.IsEqualTo (ASAuthorizationProviderExtensionEncryptionAlgorithmHPKE_Curve25519_SHA256_ChachaPoly))
				return ASAuthorizationProviderExtensionEncryptionAlgorithm.HpkeCurve25519Sha256ChachaPoly;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AuthenticationServices.ASAuthorizationProviderExtensionEncryptionAlgorithm" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ASAuthorizationProviderExtensionEncryptionAlgorithm GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSNumber> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AuthenticationServices.ASAuthorizationProviderExtensionEncryptionAlgorithm" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ASAuthorizationProviderExtensionEncryptionAlgorithm? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSNumber> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AuthenticationServices.ASAuthorizationProviderExtensionEncryptionAlgorithm" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSNumber?[]? ToConstantArray (this ASAuthorizationProviderExtensionEncryptionAlgorithm[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSNumber?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="NSNumber" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="NSNumber" /> values to convert.</param>
		internal static ASAuthorizationProviderExtensionEncryptionAlgorithm[]? ToEnumArray (this NSNumber[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<ASAuthorizationProviderExtensionEncryptionAlgorithm> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
