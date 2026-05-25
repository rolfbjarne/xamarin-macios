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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum SecKeyAlgorithm : int {
		/// <summary>To be added.</summary>
		RsaSignatureRaw = 0,
		/// <summary>To be added.</summary>
		RsaSignatureDigestPkcs1v15Raw = 1,
		/// <summary>To be added.</summary>
		RsaSignatureDigestPkcs1v15Sha1 = 2,
		/// <summary>To be added.</summary>
		RsaSignatureDigestPkcs1v15Sha224 = 3,
		/// <summary>To be added.</summary>
		RsaSignatureDigestPkcs1v15Sha256 = 4,
		/// <summary>To be added.</summary>
		RsaSignatureDigestPkcs1v15Sha384 = 5,
		/// <summary>To be added.</summary>
		RsaSignatureDigestPkcs1v15Sha512 = 6,
		/// <summary>To be added.</summary>
		RsaSignatureMessagePkcs1v15Sha1 = 7,
		/// <summary>To be added.</summary>
		RsaSignatureMessagePkcs1v15Sha224 = 8,
		/// <summary>To be added.</summary>
		RsaSignatureMessagePkcs1v15Sha256 = 9,
		/// <summary>To be added.</summary>
		RsaSignatureMessagePkcs1v15Sha384 = 10,
		/// <summary>To be added.</summary>
		RsaSignatureMessagePkcs1v15Sha512 = 11,
		/// <summary>To be added.</summary>
		EcdsaSignatureRfc4754 = 12,
		/// <summary>To be added.</summary>
		EcdsaSignatureDigestX962 = 13,
		/// <summary>To be added.</summary>
		EcdsaSignatureDigestX962Sha1 = 14,
		/// <summary>To be added.</summary>
		EcdsaSignatureDigestX962Sha224 = 15,
		/// <summary>To be added.</summary>
		EcdsaSignatureDigestX962Sha256 = 16,
		/// <summary>To be added.</summary>
		EcdsaSignatureDigestX962Sha384 = 17,
		/// <summary>To be added.</summary>
		EcdsaSignatureDigestX962Sha512 = 18,
		/// <summary>To be added.</summary>
		EcdsaSignatureMessageX962Sha1 = 19,
		/// <summary>To be added.</summary>
		EcdsaSignatureMessageX962Sha224 = 20,
		/// <summary>To be added.</summary>
		EcdsaSignatureMessageX962Sha256 = 21,
		/// <summary>To be added.</summary>
		EcdsaSignatureMessageX962Sha384 = 22,
		/// <summary>To be added.</summary>
		EcdsaSignatureMessageX962Sha512 = 23,
		/// <summary>To be added.</summary>
		RsaEncryptionRaw = 24,
		/// <summary>To be added.</summary>
		RsaEncryptionPkcs1 = 25,
		/// <summary>To be added.</summary>
		RsaEncryptionOaepSha1 = 26,
		/// <summary>To be added.</summary>
		RsaEncryptionOaepSha224 = 27,
		/// <summary>To be added.</summary>
		RsaEncryptionOaepSha256 = 28,
		/// <summary>To be added.</summary>
		RsaEncryptionOaepSha384 = 29,
		/// <summary>To be added.</summary>
		RsaEncryptionOaepSha512 = 30,
		/// <summary>To be added.</summary>
		RsaEncryptionOaepSha1AesCgm = 31,
		/// <summary>To be added.</summary>
		RsaEncryptionOaepSha224AesGcm = 32,
		/// <summary>To be added.</summary>
		RsaEncryptionOaepSha256AesGcm = 33,
		/// <summary>To be added.</summary>
		RsaEncryptionOaepSha384AesGcm = 34,
		/// <summary>To be added.</summary>
		RsaEncryptionOaepSha512AesGcm = 35,
		/// <summary>To be added.</summary>
		EciesEncryptionStandardX963Sha1AesGcm = 36,
		/// <summary>To be added.</summary>
		EciesEncryptionStandardX963Sha224AesGcm = 37,
		/// <summary>To be added.</summary>
		EciesEncryptionStandardX963Sha256AesGcm = 38,
		/// <summary>To be added.</summary>
		EciesEncryptionStandardX963Sha384AesGcm = 39,
		/// <summary>To be added.</summary>
		EciesEncryptionStandardX963Sha512AesGcm = 40,
		/// <summary>To be added.</summary>
		EciesEncryptionCofactorX963Sha1AesGcm = 41,
		/// <summary>To be added.</summary>
		EciesEncryptionCofactorX963Sha224AesGcm = 42,
		/// <summary>To be added.</summary>
		EciesEncryptionCofactorX963Sha256AesGcm = 43,
		/// <summary>To be added.</summary>
		EciesEncryptionCofactorX963Sha384AesGcm = 44,
		/// <summary>To be added.</summary>
		EciesEncryptionCofactorX963Sha512AesGcm = 45,
		/// <summary>To be added.</summary>
		EcdhKeyExchangeStandard = 46,
		/// <summary>To be added.</summary>
		EcdhKeyExchangeStandardX963Sha1 = 47,
		/// <summary>To be added.</summary>
		EcdhKeyExchangeStandardX963Sha224 = 48,
		/// <summary>To be added.</summary>
		EcdhKeyExchangeStandardX963Sha256 = 49,
		/// <summary>To be added.</summary>
		EcdhKeyExchangeStandardX963Sha384 = 50,
		/// <summary>To be added.</summary>
		EcdhKeyExchangeStandardX963Sha512 = 51,
		/// <summary>To be added.</summary>
		EcdhKeyExchangeCofactor = 52,
		/// <summary>To be added.</summary>
		EcdhKeyExchangeCofactorX963Sha1 = 53,
		/// <summary>To be added.</summary>
		EcdhKeyExchangeCofactorX963Sha224 = 54,
		/// <summary>To be added.</summary>
		EcdhKeyExchangeCofactorX963Sha256 = 55,
		/// <summary>To be added.</summary>
		EcdhKeyExchangeCofactorX963Sha384 = 56,
		/// <summary>To be added.</summary>
		EcdhKeyExchangeCofactorX963Sha512 = 57,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RsaSignatureDigestPssSha1 = 58,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RsaSignatureDigestPssSha224 = 59,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RsaSignatureDigestPssSha256 = 60,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RsaSignatureDigestPssSha384 = 61,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RsaSignatureDigestPssSha512 = 62,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RsaSignatureMessagePssSha1 = 63,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RsaSignatureMessagePssSha224 = 64,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RsaSignatureMessagePssSha256 = 65,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RsaSignatureMessagePssSha384 = 66,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		RsaSignatureMessagePssSha512 = 67,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		EciesEncryptionStandardVariableIvx963Sha224AesGcm = 68,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		EciesEncryptionStandardVariableIvx963Sha256AesGcm = 69,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		EciesEncryptionStandardVariableIvx963Sha384AesGcm = 70,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		EciesEncryptionStandardVariableIvx963Sha512AesGcm = 71,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		EciesEncryptionCofactorVariableIvx963Sha224AesGcm = 72,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		EciesEncryptionCofactorVariableIvx963Sha256AesGcm = 73,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		EciesEncryptionCofactorVariableIvx963Sha384AesGcm = 74,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		EciesEncryptionCofactorVariableIvx963Sha512AesGcm = 75,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		EcdsaSignatureDigestRfc4754 = 76,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		EcdsaSignatureDigestRfc4754Sha1 = 77,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		EcdsaSignatureDigestRfc4754Sha224 = 78,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		EcdsaSignatureDigestRfc4754Sha256 = 79,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		EcdsaSignatureDigestRfc4754Sha384 = 80,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		EcdsaSignatureDigestRfc4754Sha512 = 81,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		EcdsaSignatureMessageRfc4754Sha1 = 82,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		EcdsaSignatureMessageRfc4754Sha224 = 83,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		EcdsaSignatureMessageRfc4754Sha256 = 84,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		EcdsaSignatureMessageRfc4754Sha384 = 85,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		EcdsaSignatureMessageRfc4754Sha512 = 86,
	}
	/// <summary>Extension methods for the <see cref="global::Security.SecKeyAlgorithm" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SecKeyAlgorithmExtensions {
		static IntPtr[] values = new IntPtr [87];
		[Field ("kSecKeyAlgorithmRSASignatureRaw", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureRaw {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureRaw", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15Raw", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPKCS1v15Raw {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPKCS1v15Raw", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA1", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA1 {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA1", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA224", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA224 {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA224", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA256", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA256 {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA256", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA384", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA384 {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA384", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA512", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA512 {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA512", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA1", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA1 {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA1", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA224", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA224 {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA224", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA256", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA256 {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA256", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA384", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA384 {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA384", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA512", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA512 {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA512", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDSASignatureRFC4754", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureRFC4754 {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureRFC4754", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestX962 {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestX962", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962SHA1", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestX962SHA1 {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestX962SHA1", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962SHA224", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestX962SHA224 {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestX962SHA224", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962SHA256", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestX962SHA256 {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestX962SHA256", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962SHA384", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestX962SHA384 {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestX962SHA384", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962SHA512", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestX962SHA512 {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestX962SHA512", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDSASignatureMessageX962SHA1", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureMessageX962SHA1 {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureMessageX962SHA1", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDSASignatureMessageX962SHA224", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureMessageX962SHA224 {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureMessageX962SHA224", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDSASignatureMessageX962SHA256", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureMessageX962SHA256 {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureMessageX962SHA256", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDSASignatureMessageX962SHA384", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureMessageX962SHA384 {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureMessageX962SHA384", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDSASignatureMessageX962SHA512", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureMessageX962SHA512 {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureMessageX962SHA512", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSAEncryptionRaw", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionRaw {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionRaw", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSAEncryptionPKCS1", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionPKCS1 {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionPKCS1", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA1", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA1 {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA1", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA224", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA224 {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA224", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA256", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA256 {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA256", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA384", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA384 {
			get {
				fixed (IntPtr *storage = &values [29])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA384", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA512", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA512 {
			get {
				fixed (IntPtr *storage = &values [30])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA512", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA1AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA1AESGCM {
			get {
				fixed (IntPtr *storage = &values [31])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA1AESGCM", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA224AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA224AESGCM {
			get {
				fixed (IntPtr *storage = &values [32])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA224AESGCM", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA256AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA256AESGCM {
			get {
				fixed (IntPtr *storage = &values [33])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA256AESGCM", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA384AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA384AESGCM {
			get {
				fixed (IntPtr *storage = &values [34])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA384AESGCM", storage);
			}
		}
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA512AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA512AESGCM {
			get {
				fixed (IntPtr *storage = &values [35])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA512AESGCM", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardX963SHA1AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardX963SHA1AESGCM {
			get {
				fixed (IntPtr *storage = &values [36])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardX963SHA1AESGCM", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardX963SHA224AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardX963SHA224AESGCM {
			get {
				fixed (IntPtr *storage = &values [37])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardX963SHA224AESGCM", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardX963SHA256AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardX963SHA256AESGCM {
			get {
				fixed (IntPtr *storage = &values [38])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardX963SHA256AESGCM", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardX963SHA384AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardX963SHA384AESGCM {
			get {
				fixed (IntPtr *storage = &values [39])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardX963SHA384AESGCM", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardX963SHA512AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardX963SHA512AESGCM {
			get {
				fixed (IntPtr *storage = &values [40])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardX963SHA512AESGCM", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA1AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorX963SHA1AESGCM {
			get {
				fixed (IntPtr *storage = &values [41])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorX963SHA1AESGCM", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA224AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorX963SHA224AESGCM {
			get {
				fixed (IntPtr *storage = &values [42])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorX963SHA224AESGCM", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA256AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorX963SHA256AESGCM {
			get {
				fixed (IntPtr *storage = &values [43])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorX963SHA256AESGCM", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA384AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorX963SHA384AESGCM {
			get {
				fixed (IntPtr *storage = &values [44])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorX963SHA384AESGCM", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA512AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorX963SHA512AESGCM {
			get {
				fixed (IntPtr *storage = &values [45])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorX963SHA512AESGCM", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandard", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeStandard {
			get {
				fixed (IntPtr *storage = &values [46])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeStandard", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA1", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA1 {
			get {
				fixed (IntPtr *storage = &values [47])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA1", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA224", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA224 {
			get {
				fixed (IntPtr *storage = &values [48])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA224", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA256", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA256 {
			get {
				fixed (IntPtr *storage = &values [49])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA256", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA384", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA384 {
			get {
				fixed (IntPtr *storage = &values [50])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA384", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA512", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA512 {
			get {
				fixed (IntPtr *storage = &values [51])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA512", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactor", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeCofactor {
			get {
				fixed (IntPtr *storage = &values [52])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeCofactor", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA1", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA1 {
			get {
				fixed (IntPtr *storage = &values [53])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA1", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA224", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA224 {
			get {
				fixed (IntPtr *storage = &values [54])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA224", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA256", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA256 {
			get {
				fixed (IntPtr *storage = &values [55])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA256", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA384", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA384 {
			get {
				fixed (IntPtr *storage = &values [56])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA384", storage);
			}
		}
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA512", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA512 {
			get {
				fixed (IntPtr *storage = &values [57])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA512", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPSSSHA1", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPSSSHA1 {
			get {
				fixed (IntPtr *storage = &values [58])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPSSSHA1", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPSSSHA224", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPSSSHA224 {
			get {
				fixed (IntPtr *storage = &values [59])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPSSSHA224", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPSSSHA256", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPSSSHA256 {
			get {
				fixed (IntPtr *storage = &values [60])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPSSSHA256", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPSSSHA384", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPSSSHA384 {
			get {
				fixed (IntPtr *storage = &values [61])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPSSSHA384", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPSSSHA512", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPSSSHA512 {
			get {
				fixed (IntPtr *storage = &values [62])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPSSSHA512", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePSSSHA1", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePSSSHA1 {
			get {
				fixed (IntPtr *storage = &values [63])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePSSSHA1", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePSSSHA224", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePSSSHA224 {
			get {
				fixed (IntPtr *storage = &values [64])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePSSSHA224", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePSSSHA256", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePSSSHA256 {
			get {
				fixed (IntPtr *storage = &values [65])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePSSSHA256", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePSSSHA384", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePSSSHA384 {
			get {
				fixed (IntPtr *storage = &values [66])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePSSSHA384", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePSSSHA512", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePSSSHA512 {
			get {
				fixed (IntPtr *storage = &values [67])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePSSSHA512", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA224AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA224AESGCM {
			get {
				fixed (IntPtr *storage = &values [68])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA224AESGCM", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA256AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA256AESGCM {
			get {
				fixed (IntPtr *storage = &values [69])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA256AESGCM", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA384AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA384AESGCM {
			get {
				fixed (IntPtr *storage = &values [70])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA384AESGCM", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA512AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA512AESGCM {
			get {
				fixed (IntPtr *storage = &values [71])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA512AESGCM", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA224AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA224AESGCM {
			get {
				fixed (IntPtr *storage = &values [72])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA224AESGCM", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA256AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA256AESGCM {
			get {
				fixed (IntPtr *storage = &values [73])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA256AESGCM", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA384AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA384AESGCM {
			get {
				fixed (IntPtr *storage = &values [74])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA384AESGCM", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA512AESGCM", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA512AESGCM {
			get {
				fixed (IntPtr *storage = &values [75])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA512AESGCM", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestRFC4754", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestRFC4754 {
			get {
				fixed (IntPtr *storage = &values [76])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestRFC4754", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA1", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA1 {
			get {
				fixed (IntPtr *storage = &values [77])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA1", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA224", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA224 {
			get {
				fixed (IntPtr *storage = &values [78])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA224", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA256", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA256 {
			get {
				fixed (IntPtr *storage = &values [79])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA256", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA384", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA384 {
			get {
				fixed (IntPtr *storage = &values [80])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA384", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA512", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA512 {
			get {
				fixed (IntPtr *storage = &values [81])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA512", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA1", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA1 {
			get {
				fixed (IntPtr *storage = &values [82])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA1", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA224", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA224 {
			get {
				fixed (IntPtr *storage = &values [83])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA224", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA256", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA256 {
			get {
				fixed (IntPtr *storage = &values [84])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA256", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA384", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA384 {
			get {
				fixed (IntPtr *storage = &values [85])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA384", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA512", "Security")]
		internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA512 {
			get {
				fixed (IntPtr *storage = &values [86])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA512", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this SecKeyAlgorithm self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // SecKeyAlgorithm.RsaSignatureRaw
				ptr = kSecKeyAlgorithmRSASignatureRaw;
				break;
			case 1: // SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Raw
				ptr = kSecKeyAlgorithmRSASignatureDigestPKCS1v15Raw;
				break;
			case 2: // SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Sha1
				ptr = kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA1;
				break;
			case 3: // SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Sha224
				ptr = kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA224;
				break;
			case 4: // SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Sha256
				ptr = kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA256;
				break;
			case 5: // SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Sha384
				ptr = kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA384;
				break;
			case 6: // SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Sha512
				ptr = kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA512;
				break;
			case 7: // SecKeyAlgorithm.RsaSignatureMessagePkcs1v15Sha1
				ptr = kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA1;
				break;
			case 8: // SecKeyAlgorithm.RsaSignatureMessagePkcs1v15Sha224
				ptr = kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA224;
				break;
			case 9: // SecKeyAlgorithm.RsaSignatureMessagePkcs1v15Sha256
				ptr = kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA256;
				break;
			case 10: // SecKeyAlgorithm.RsaSignatureMessagePkcs1v15Sha384
				ptr = kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA384;
				break;
			case 11: // SecKeyAlgorithm.RsaSignatureMessagePkcs1v15Sha512
				ptr = kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA512;
				break;
			case 12: // SecKeyAlgorithm.EcdsaSignatureRfc4754
				ptr = kSecKeyAlgorithmECDSASignatureRFC4754;
				break;
			case 13: // SecKeyAlgorithm.EcdsaSignatureDigestX962
				ptr = kSecKeyAlgorithmECDSASignatureDigestX962;
				break;
			case 14: // SecKeyAlgorithm.EcdsaSignatureDigestX962Sha1
				ptr = kSecKeyAlgorithmECDSASignatureDigestX962SHA1;
				break;
			case 15: // SecKeyAlgorithm.EcdsaSignatureDigestX962Sha224
				ptr = kSecKeyAlgorithmECDSASignatureDigestX962SHA224;
				break;
			case 16: // SecKeyAlgorithm.EcdsaSignatureDigestX962Sha256
				ptr = kSecKeyAlgorithmECDSASignatureDigestX962SHA256;
				break;
			case 17: // SecKeyAlgorithm.EcdsaSignatureDigestX962Sha384
				ptr = kSecKeyAlgorithmECDSASignatureDigestX962SHA384;
				break;
			case 18: // SecKeyAlgorithm.EcdsaSignatureDigestX962Sha512
				ptr = kSecKeyAlgorithmECDSASignatureDigestX962SHA512;
				break;
			case 19: // SecKeyAlgorithm.EcdsaSignatureMessageX962Sha1
				ptr = kSecKeyAlgorithmECDSASignatureMessageX962SHA1;
				break;
			case 20: // SecKeyAlgorithm.EcdsaSignatureMessageX962Sha224
				ptr = kSecKeyAlgorithmECDSASignatureMessageX962SHA224;
				break;
			case 21: // SecKeyAlgorithm.EcdsaSignatureMessageX962Sha256
				ptr = kSecKeyAlgorithmECDSASignatureMessageX962SHA256;
				break;
			case 22: // SecKeyAlgorithm.EcdsaSignatureMessageX962Sha384
				ptr = kSecKeyAlgorithmECDSASignatureMessageX962SHA384;
				break;
			case 23: // SecKeyAlgorithm.EcdsaSignatureMessageX962Sha512
				ptr = kSecKeyAlgorithmECDSASignatureMessageX962SHA512;
				break;
			case 24: // SecKeyAlgorithm.RsaEncryptionRaw
				ptr = kSecKeyAlgorithmRSAEncryptionRaw;
				break;
			case 25: // SecKeyAlgorithm.RsaEncryptionPkcs1
				ptr = kSecKeyAlgorithmRSAEncryptionPKCS1;
				break;
			case 26: // SecKeyAlgorithm.RsaEncryptionOaepSha1
				ptr = kSecKeyAlgorithmRSAEncryptionOAEPSHA1;
				break;
			case 27: // SecKeyAlgorithm.RsaEncryptionOaepSha224
				ptr = kSecKeyAlgorithmRSAEncryptionOAEPSHA224;
				break;
			case 28: // SecKeyAlgorithm.RsaEncryptionOaepSha256
				ptr = kSecKeyAlgorithmRSAEncryptionOAEPSHA256;
				break;
			case 29: // SecKeyAlgorithm.RsaEncryptionOaepSha384
				ptr = kSecKeyAlgorithmRSAEncryptionOAEPSHA384;
				break;
			case 30: // SecKeyAlgorithm.RsaEncryptionOaepSha512
				ptr = kSecKeyAlgorithmRSAEncryptionOAEPSHA512;
				break;
			case 31: // SecKeyAlgorithm.RsaEncryptionOaepSha1AesCgm
				ptr = kSecKeyAlgorithmRSAEncryptionOAEPSHA1AESGCM;
				break;
			case 32: // SecKeyAlgorithm.RsaEncryptionOaepSha224AesGcm
				ptr = kSecKeyAlgorithmRSAEncryptionOAEPSHA224AESGCM;
				break;
			case 33: // SecKeyAlgorithm.RsaEncryptionOaepSha256AesGcm
				ptr = kSecKeyAlgorithmRSAEncryptionOAEPSHA256AESGCM;
				break;
			case 34: // SecKeyAlgorithm.RsaEncryptionOaepSha384AesGcm
				ptr = kSecKeyAlgorithmRSAEncryptionOAEPSHA384AESGCM;
				break;
			case 35: // SecKeyAlgorithm.RsaEncryptionOaepSha512AesGcm
				ptr = kSecKeyAlgorithmRSAEncryptionOAEPSHA512AESGCM;
				break;
			case 36: // SecKeyAlgorithm.EciesEncryptionStandardX963Sha1AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionStandardX963SHA1AESGCM;
				break;
			case 37: // SecKeyAlgorithm.EciesEncryptionStandardX963Sha224AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionStandardX963SHA224AESGCM;
				break;
			case 38: // SecKeyAlgorithm.EciesEncryptionStandardX963Sha256AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionStandardX963SHA256AESGCM;
				break;
			case 39: // SecKeyAlgorithm.EciesEncryptionStandardX963Sha384AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionStandardX963SHA384AESGCM;
				break;
			case 40: // SecKeyAlgorithm.EciesEncryptionStandardX963Sha512AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionStandardX963SHA512AESGCM;
				break;
			case 41: // SecKeyAlgorithm.EciesEncryptionCofactorX963Sha1AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionCofactorX963SHA1AESGCM;
				break;
			case 42: // SecKeyAlgorithm.EciesEncryptionCofactorX963Sha224AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionCofactorX963SHA224AESGCM;
				break;
			case 43: // SecKeyAlgorithm.EciesEncryptionCofactorX963Sha256AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionCofactorX963SHA256AESGCM;
				break;
			case 44: // SecKeyAlgorithm.EciesEncryptionCofactorX963Sha384AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionCofactorX963SHA384AESGCM;
				break;
			case 45: // SecKeyAlgorithm.EciesEncryptionCofactorX963Sha512AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionCofactorX963SHA512AESGCM;
				break;
			case 46: // SecKeyAlgorithm.EcdhKeyExchangeStandard
				ptr = kSecKeyAlgorithmECDHKeyExchangeStandard;
				break;
			case 47: // SecKeyAlgorithm.EcdhKeyExchangeStandardX963Sha1
				ptr = kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA1;
				break;
			case 48: // SecKeyAlgorithm.EcdhKeyExchangeStandardX963Sha224
				ptr = kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA224;
				break;
			case 49: // SecKeyAlgorithm.EcdhKeyExchangeStandardX963Sha256
				ptr = kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA256;
				break;
			case 50: // SecKeyAlgorithm.EcdhKeyExchangeStandardX963Sha384
				ptr = kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA384;
				break;
			case 51: // SecKeyAlgorithm.EcdhKeyExchangeStandardX963Sha512
				ptr = kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA512;
				break;
			case 52: // SecKeyAlgorithm.EcdhKeyExchangeCofactor
				ptr = kSecKeyAlgorithmECDHKeyExchangeCofactor;
				break;
			case 53: // SecKeyAlgorithm.EcdhKeyExchangeCofactorX963Sha1
				ptr = kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA1;
				break;
			case 54: // SecKeyAlgorithm.EcdhKeyExchangeCofactorX963Sha224
				ptr = kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA224;
				break;
			case 55: // SecKeyAlgorithm.EcdhKeyExchangeCofactorX963Sha256
				ptr = kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA256;
				break;
			case 56: // SecKeyAlgorithm.EcdhKeyExchangeCofactorX963Sha384
				ptr = kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA384;
				break;
			case 57: // SecKeyAlgorithm.EcdhKeyExchangeCofactorX963Sha512
				ptr = kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA512;
				break;
			case 58: // SecKeyAlgorithm.RsaSignatureDigestPssSha1
				ptr = kSecKeyAlgorithmRSASignatureDigestPSSSHA1;
				break;
			case 59: // SecKeyAlgorithm.RsaSignatureDigestPssSha224
				ptr = kSecKeyAlgorithmRSASignatureDigestPSSSHA224;
				break;
			case 60: // SecKeyAlgorithm.RsaSignatureDigestPssSha256
				ptr = kSecKeyAlgorithmRSASignatureDigestPSSSHA256;
				break;
			case 61: // SecKeyAlgorithm.RsaSignatureDigestPssSha384
				ptr = kSecKeyAlgorithmRSASignatureDigestPSSSHA384;
				break;
			case 62: // SecKeyAlgorithm.RsaSignatureDigestPssSha512
				ptr = kSecKeyAlgorithmRSASignatureDigestPSSSHA512;
				break;
			case 63: // SecKeyAlgorithm.RsaSignatureMessagePssSha1
				ptr = kSecKeyAlgorithmRSASignatureMessagePSSSHA1;
				break;
			case 64: // SecKeyAlgorithm.RsaSignatureMessagePssSha224
				ptr = kSecKeyAlgorithmRSASignatureMessagePSSSHA224;
				break;
			case 65: // SecKeyAlgorithm.RsaSignatureMessagePssSha256
				ptr = kSecKeyAlgorithmRSASignatureMessagePSSSHA256;
				break;
			case 66: // SecKeyAlgorithm.RsaSignatureMessagePssSha384
				ptr = kSecKeyAlgorithmRSASignatureMessagePSSSHA384;
				break;
			case 67: // SecKeyAlgorithm.RsaSignatureMessagePssSha512
				ptr = kSecKeyAlgorithmRSASignatureMessagePSSSHA512;
				break;
			case 68: // SecKeyAlgorithm.EciesEncryptionStandardVariableIvx963Sha224AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA224AESGCM;
				break;
			case 69: // SecKeyAlgorithm.EciesEncryptionStandardVariableIvx963Sha256AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA256AESGCM;
				break;
			case 70: // SecKeyAlgorithm.EciesEncryptionStandardVariableIvx963Sha384AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA384AESGCM;
				break;
			case 71: // SecKeyAlgorithm.EciesEncryptionStandardVariableIvx963Sha512AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA512AESGCM;
				break;
			case 72: // SecKeyAlgorithm.EciesEncryptionCofactorVariableIvx963Sha224AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA224AESGCM;
				break;
			case 73: // SecKeyAlgorithm.EciesEncryptionCofactorVariableIvx963Sha256AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA256AESGCM;
				break;
			case 74: // SecKeyAlgorithm.EciesEncryptionCofactorVariableIvx963Sha384AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA384AESGCM;
				break;
			case 75: // SecKeyAlgorithm.EciesEncryptionCofactorVariableIvx963Sha512AesGcm
				ptr = kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA512AESGCM;
				break;
			case 76: // SecKeyAlgorithm.EcdsaSignatureDigestRfc4754
				ptr = kSecKeyAlgorithmECDSASignatureDigestRFC4754;
				break;
			case 77: // SecKeyAlgorithm.EcdsaSignatureDigestRfc4754Sha1
				ptr = kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA1;
				break;
			case 78: // SecKeyAlgorithm.EcdsaSignatureDigestRfc4754Sha224
				ptr = kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA224;
				break;
			case 79: // SecKeyAlgorithm.EcdsaSignatureDigestRfc4754Sha256
				ptr = kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA256;
				break;
			case 80: // SecKeyAlgorithm.EcdsaSignatureDigestRfc4754Sha384
				ptr = kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA384;
				break;
			case 81: // SecKeyAlgorithm.EcdsaSignatureDigestRfc4754Sha512
				ptr = kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA512;
				break;
			case 82: // SecKeyAlgorithm.EcdsaSignatureMessageRfc4754Sha1
				ptr = kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA1;
				break;
			case 83: // SecKeyAlgorithm.EcdsaSignatureMessageRfc4754Sha224
				ptr = kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA224;
				break;
			case 84: // SecKeyAlgorithm.EcdsaSignatureMessageRfc4754Sha256
				ptr = kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA256;
				break;
			case 85: // SecKeyAlgorithm.EcdsaSignatureMessageRfc4754Sha384
				ptr = kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA384;
				break;
			case 86: // SecKeyAlgorithm.EcdsaSignatureMessageRfc4754Sha512
				ptr = kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA512;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Security.SecKeyAlgorithm" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static SecKeyAlgorithm GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureRaw))
				return SecKeyAlgorithm.RsaSignatureRaw;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureDigestPKCS1v15Raw))
				return SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Raw;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA1))
				return SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Sha1;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA224))
				return SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Sha224;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA256))
				return SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Sha256;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA384))
				return SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Sha384;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA512))
				return SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Sha512;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA1))
				return SecKeyAlgorithm.RsaSignatureMessagePkcs1v15Sha1;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA224))
				return SecKeyAlgorithm.RsaSignatureMessagePkcs1v15Sha224;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA256))
				return SecKeyAlgorithm.RsaSignatureMessagePkcs1v15Sha256;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA384))
				return SecKeyAlgorithm.RsaSignatureMessagePkcs1v15Sha384;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA512))
				return SecKeyAlgorithm.RsaSignatureMessagePkcs1v15Sha512;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureRFC4754))
				return SecKeyAlgorithm.EcdsaSignatureRfc4754;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureDigestX962))
				return SecKeyAlgorithm.EcdsaSignatureDigestX962;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureDigestX962SHA1))
				return SecKeyAlgorithm.EcdsaSignatureDigestX962Sha1;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureDigestX962SHA224))
				return SecKeyAlgorithm.EcdsaSignatureDigestX962Sha224;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureDigestX962SHA256))
				return SecKeyAlgorithm.EcdsaSignatureDigestX962Sha256;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureDigestX962SHA384))
				return SecKeyAlgorithm.EcdsaSignatureDigestX962Sha384;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureDigestX962SHA512))
				return SecKeyAlgorithm.EcdsaSignatureDigestX962Sha512;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureMessageX962SHA1))
				return SecKeyAlgorithm.EcdsaSignatureMessageX962Sha1;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureMessageX962SHA224))
				return SecKeyAlgorithm.EcdsaSignatureMessageX962Sha224;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureMessageX962SHA256))
				return SecKeyAlgorithm.EcdsaSignatureMessageX962Sha256;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureMessageX962SHA384))
				return SecKeyAlgorithm.EcdsaSignatureMessageX962Sha384;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureMessageX962SHA512))
				return SecKeyAlgorithm.EcdsaSignatureMessageX962Sha512;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSAEncryptionRaw))
				return SecKeyAlgorithm.RsaEncryptionRaw;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSAEncryptionPKCS1))
				return SecKeyAlgorithm.RsaEncryptionPkcs1;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSAEncryptionOAEPSHA1))
				return SecKeyAlgorithm.RsaEncryptionOaepSha1;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSAEncryptionOAEPSHA224))
				return SecKeyAlgorithm.RsaEncryptionOaepSha224;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSAEncryptionOAEPSHA256))
				return SecKeyAlgorithm.RsaEncryptionOaepSha256;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSAEncryptionOAEPSHA384))
				return SecKeyAlgorithm.RsaEncryptionOaepSha384;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSAEncryptionOAEPSHA512))
				return SecKeyAlgorithm.RsaEncryptionOaepSha512;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSAEncryptionOAEPSHA1AESGCM))
				return SecKeyAlgorithm.RsaEncryptionOaepSha1AesCgm;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSAEncryptionOAEPSHA224AESGCM))
				return SecKeyAlgorithm.RsaEncryptionOaepSha224AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSAEncryptionOAEPSHA256AESGCM))
				return SecKeyAlgorithm.RsaEncryptionOaepSha256AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSAEncryptionOAEPSHA384AESGCM))
				return SecKeyAlgorithm.RsaEncryptionOaepSha384AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSAEncryptionOAEPSHA512AESGCM))
				return SecKeyAlgorithm.RsaEncryptionOaepSha512AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionStandardX963SHA1AESGCM))
				return SecKeyAlgorithm.EciesEncryptionStandardX963Sha1AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionStandardX963SHA224AESGCM))
				return SecKeyAlgorithm.EciesEncryptionStandardX963Sha224AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionStandardX963SHA256AESGCM))
				return SecKeyAlgorithm.EciesEncryptionStandardX963Sha256AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionStandardX963SHA384AESGCM))
				return SecKeyAlgorithm.EciesEncryptionStandardX963Sha384AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionStandardX963SHA512AESGCM))
				return SecKeyAlgorithm.EciesEncryptionStandardX963Sha512AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionCofactorX963SHA1AESGCM))
				return SecKeyAlgorithm.EciesEncryptionCofactorX963Sha1AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionCofactorX963SHA224AESGCM))
				return SecKeyAlgorithm.EciesEncryptionCofactorX963Sha224AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionCofactorX963SHA256AESGCM))
				return SecKeyAlgorithm.EciesEncryptionCofactorX963Sha256AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionCofactorX963SHA384AESGCM))
				return SecKeyAlgorithm.EciesEncryptionCofactorX963Sha384AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionCofactorX963SHA512AESGCM))
				return SecKeyAlgorithm.EciesEncryptionCofactorX963Sha512AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDHKeyExchangeStandard))
				return SecKeyAlgorithm.EcdhKeyExchangeStandard;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA1))
				return SecKeyAlgorithm.EcdhKeyExchangeStandardX963Sha1;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA224))
				return SecKeyAlgorithm.EcdhKeyExchangeStandardX963Sha224;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA256))
				return SecKeyAlgorithm.EcdhKeyExchangeStandardX963Sha256;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA384))
				return SecKeyAlgorithm.EcdhKeyExchangeStandardX963Sha384;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA512))
				return SecKeyAlgorithm.EcdhKeyExchangeStandardX963Sha512;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDHKeyExchangeCofactor))
				return SecKeyAlgorithm.EcdhKeyExchangeCofactor;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA1))
				return SecKeyAlgorithm.EcdhKeyExchangeCofactorX963Sha1;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA224))
				return SecKeyAlgorithm.EcdhKeyExchangeCofactorX963Sha224;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA256))
				return SecKeyAlgorithm.EcdhKeyExchangeCofactorX963Sha256;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA384))
				return SecKeyAlgorithm.EcdhKeyExchangeCofactorX963Sha384;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA512))
				return SecKeyAlgorithm.EcdhKeyExchangeCofactorX963Sha512;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureDigestPSSSHA1))
				return SecKeyAlgorithm.RsaSignatureDigestPssSha1;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureDigestPSSSHA224))
				return SecKeyAlgorithm.RsaSignatureDigestPssSha224;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureDigestPSSSHA256))
				return SecKeyAlgorithm.RsaSignatureDigestPssSha256;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureDigestPSSSHA384))
				return SecKeyAlgorithm.RsaSignatureDigestPssSha384;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureDigestPSSSHA512))
				return SecKeyAlgorithm.RsaSignatureDigestPssSha512;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureMessagePSSSHA1))
				return SecKeyAlgorithm.RsaSignatureMessagePssSha1;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureMessagePSSSHA224))
				return SecKeyAlgorithm.RsaSignatureMessagePssSha224;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureMessagePSSSHA256))
				return SecKeyAlgorithm.RsaSignatureMessagePssSha256;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureMessagePSSSHA384))
				return SecKeyAlgorithm.RsaSignatureMessagePssSha384;
			if (constant.IsEqualTo (kSecKeyAlgorithmRSASignatureMessagePSSSHA512))
				return SecKeyAlgorithm.RsaSignatureMessagePssSha512;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA224AESGCM))
				return SecKeyAlgorithm.EciesEncryptionStandardVariableIvx963Sha224AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA256AESGCM))
				return SecKeyAlgorithm.EciesEncryptionStandardVariableIvx963Sha256AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA384AESGCM))
				return SecKeyAlgorithm.EciesEncryptionStandardVariableIvx963Sha384AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA512AESGCM))
				return SecKeyAlgorithm.EciesEncryptionStandardVariableIvx963Sha512AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA224AESGCM))
				return SecKeyAlgorithm.EciesEncryptionCofactorVariableIvx963Sha224AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA256AESGCM))
				return SecKeyAlgorithm.EciesEncryptionCofactorVariableIvx963Sha256AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA384AESGCM))
				return SecKeyAlgorithm.EciesEncryptionCofactorVariableIvx963Sha384AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA512AESGCM))
				return SecKeyAlgorithm.EciesEncryptionCofactorVariableIvx963Sha512AesGcm;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureDigestRFC4754))
				return SecKeyAlgorithm.EcdsaSignatureDigestRfc4754;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA1))
				return SecKeyAlgorithm.EcdsaSignatureDigestRfc4754Sha1;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA224))
				return SecKeyAlgorithm.EcdsaSignatureDigestRfc4754Sha224;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA256))
				return SecKeyAlgorithm.EcdsaSignatureDigestRfc4754Sha256;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA384))
				return SecKeyAlgorithm.EcdsaSignatureDigestRfc4754Sha384;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA512))
				return SecKeyAlgorithm.EcdsaSignatureDigestRfc4754Sha512;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA1))
				return SecKeyAlgorithm.EcdsaSignatureMessageRfc4754Sha1;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA224))
				return SecKeyAlgorithm.EcdsaSignatureMessageRfc4754Sha224;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA256))
				return SecKeyAlgorithm.EcdsaSignatureMessageRfc4754Sha256;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA384))
				return SecKeyAlgorithm.EcdsaSignatureMessageRfc4754Sha384;
			if (constant.IsEqualTo (kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA512))
				return SecKeyAlgorithm.EcdsaSignatureMessageRfc4754Sha512;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Security.SecKeyAlgorithm" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SecKeyAlgorithm GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Security.SecKeyAlgorithm" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SecKeyAlgorithm? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Security.SecKeyAlgorithm" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this SecKeyAlgorithm[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSString?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="NSString" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="NSString" /> values to convert.</param>
		internal static SecKeyAlgorithm[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<SecKeyAlgorithm> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
