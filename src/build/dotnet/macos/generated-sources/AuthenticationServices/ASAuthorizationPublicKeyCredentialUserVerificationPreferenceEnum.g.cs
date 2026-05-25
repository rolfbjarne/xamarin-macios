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
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos16.0")]
	public enum ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum : int {
		Preferred = 0,
		Required = 1,
		Discouraged = 2,
	}
	/// <summary>Extension methods for the <see cref="global::AuthenticationServices.ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum" /> enumeration.</summary>
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos16.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnumExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("ASAuthorizationPublicKeyCredentialUserVerificationPreferencePreferred", "AuthenticationServices")]
		internal unsafe static IntPtr ASAuthorizationPublicKeyCredentialUserVerificationPreferencePreferred {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AuthenticationServices.Handle, "ASAuthorizationPublicKeyCredentialUserVerificationPreferencePreferred", storage);
			}
		}
		[Field ("ASAuthorizationPublicKeyCredentialUserVerificationPreferenceRequired", "AuthenticationServices")]
		internal unsafe static IntPtr ASAuthorizationPublicKeyCredentialUserVerificationPreferenceRequired {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AuthenticationServices.Handle, "ASAuthorizationPublicKeyCredentialUserVerificationPreferenceRequired", storage);
			}
		}
		[Field ("ASAuthorizationPublicKeyCredentialUserVerificationPreferenceDiscouraged", "AuthenticationServices")]
		internal unsafe static IntPtr ASAuthorizationPublicKeyCredentialUserVerificationPreferenceDiscouraged {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AuthenticationServices.Handle, "ASAuthorizationPublicKeyCredentialUserVerificationPreferenceDiscouraged", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum.Preferred
				ptr = ASAuthorizationPublicKeyCredentialUserVerificationPreferencePreferred;
				break;
			case 1: // ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum.Required
				ptr = ASAuthorizationPublicKeyCredentialUserVerificationPreferenceRequired;
				break;
			case 2: // ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum.Discouraged
				ptr = ASAuthorizationPublicKeyCredentialUserVerificationPreferenceDiscouraged;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AuthenticationServices.ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (ASAuthorizationPublicKeyCredentialUserVerificationPreferencePreferred))
				return ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum.Preferred;
			if (constant.IsEqualTo (ASAuthorizationPublicKeyCredentialUserVerificationPreferenceRequired))
				return ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum.Required;
			if (constant.IsEqualTo (ASAuthorizationPublicKeyCredentialUserVerificationPreferenceDiscouraged))
				return ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum.Discouraged;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AuthenticationServices.ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AuthenticationServices.ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AuthenticationServices.ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum[]? values)
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
		internal static ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<ASAuthorizationPublicKeyCredentialUserVerificationPreferenceEnum> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
