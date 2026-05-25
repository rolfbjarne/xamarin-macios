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
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	public enum ASAuthorizationPublicKeyCredentialResidentKeyPreference : int {
		Discouraged = 0,
		Preferred = 1,
		Required = 2,
	}
	/// <summary>Extension methods for the <see cref="global::AuthenticationServices.ASAuthorizationPublicKeyCredentialResidentKeyPreference" /> enumeration.</summary>
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class ASAuthorizationPublicKeyCredentialResidentKeyPreferenceExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("ASAuthorizationPublicKeyCredentialResidentKeyPreferenceDiscouraged", "AuthenticationServices")]
		internal unsafe static IntPtr ASAuthorizationPublicKeyCredentialResidentKeyPreferenceDiscouraged {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AuthenticationServices.Handle, "ASAuthorizationPublicKeyCredentialResidentKeyPreferenceDiscouraged", storage);
			}
		}
		[Field ("ASAuthorizationPublicKeyCredentialResidentKeyPreferencePreferred", "AuthenticationServices")]
		internal unsafe static IntPtr ASAuthorizationPublicKeyCredentialResidentKeyPreferencePreferred {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AuthenticationServices.Handle, "ASAuthorizationPublicKeyCredentialResidentKeyPreferencePreferred", storage);
			}
		}
		[Field ("ASAuthorizationPublicKeyCredentialResidentKeyPreferenceRequired", "AuthenticationServices")]
		internal unsafe static IntPtr ASAuthorizationPublicKeyCredentialResidentKeyPreferenceRequired {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AuthenticationServices.Handle, "ASAuthorizationPublicKeyCredentialResidentKeyPreferenceRequired", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this ASAuthorizationPublicKeyCredentialResidentKeyPreference self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // ASAuthorizationPublicKeyCredentialResidentKeyPreference.Discouraged
				ptr = ASAuthorizationPublicKeyCredentialResidentKeyPreferenceDiscouraged;
				break;
			case 1: // ASAuthorizationPublicKeyCredentialResidentKeyPreference.Preferred
				ptr = ASAuthorizationPublicKeyCredentialResidentKeyPreferencePreferred;
				break;
			case 2: // ASAuthorizationPublicKeyCredentialResidentKeyPreference.Required
				ptr = ASAuthorizationPublicKeyCredentialResidentKeyPreferenceRequired;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AuthenticationServices.ASAuthorizationPublicKeyCredentialResidentKeyPreference" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static ASAuthorizationPublicKeyCredentialResidentKeyPreference GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (ASAuthorizationPublicKeyCredentialResidentKeyPreferenceDiscouraged))
				return ASAuthorizationPublicKeyCredentialResidentKeyPreference.Discouraged;
			if (constant.IsEqualTo (ASAuthorizationPublicKeyCredentialResidentKeyPreferencePreferred))
				return ASAuthorizationPublicKeyCredentialResidentKeyPreference.Preferred;
			if (constant.IsEqualTo (ASAuthorizationPublicKeyCredentialResidentKeyPreferenceRequired))
				return ASAuthorizationPublicKeyCredentialResidentKeyPreference.Required;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AuthenticationServices.ASAuthorizationPublicKeyCredentialResidentKeyPreference" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ASAuthorizationPublicKeyCredentialResidentKeyPreference GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AuthenticationServices.ASAuthorizationPublicKeyCredentialResidentKeyPreference" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ASAuthorizationPublicKeyCredentialResidentKeyPreference? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AuthenticationServices.ASAuthorizationPublicKeyCredentialResidentKeyPreference" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this ASAuthorizationPublicKeyCredentialResidentKeyPreference[]? values)
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
		internal static ASAuthorizationPublicKeyCredentialResidentKeyPreference[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<ASAuthorizationPublicKeyCredentialResidentKeyPreference> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
