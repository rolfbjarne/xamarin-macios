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
	public enum ASAuthorizationProviderExtensionSigningAlgorithm : int {
		ES256 = 0,
		ES384 = 1,
		Ed25519 = 2,
	}
	/// <summary>Extension methods for the <see cref="global::AuthenticationServices.ASAuthorizationProviderExtensionSigningAlgorithm" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class ASAuthorizationProviderExtensionSigningAlgorithmExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("ASAuthorizationProviderExtensionSigningAlgorithmES256", "AuthenticationServices")]
		internal unsafe static IntPtr ASAuthorizationProviderExtensionSigningAlgorithmES256 {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderExtensionSigningAlgorithmES256", storage);
			}
		}
		[Field ("ASAuthorizationProviderExtensionSigningAlgorithmES384", "AuthenticationServices")]
		internal unsafe static IntPtr ASAuthorizationProviderExtensionSigningAlgorithmES384 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderExtensionSigningAlgorithmES384", storage);
			}
		}
		[Field ("ASAuthorizationProviderExtensionSigningAlgorithmEd25519", "AuthenticationServices")]
		internal unsafe static IntPtr ASAuthorizationProviderExtensionSigningAlgorithmEd25519 {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AuthenticationServices.Handle, "ASAuthorizationProviderExtensionSigningAlgorithmEd25519", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSNumber" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSNumber? GetConstant (this ASAuthorizationProviderExtensionSigningAlgorithm self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // ASAuthorizationProviderExtensionSigningAlgorithm.ES256
				ptr = ASAuthorizationProviderExtensionSigningAlgorithmES256;
				break;
			case 1: // ASAuthorizationProviderExtensionSigningAlgorithm.ES384
				ptr = ASAuthorizationProviderExtensionSigningAlgorithmES384;
				break;
			case 2: // ASAuthorizationProviderExtensionSigningAlgorithm.Ed25519
				ptr = ASAuthorizationProviderExtensionSigningAlgorithmEd25519;
				break;
			}
			return (NSNumber?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AuthenticationServices.ASAuthorizationProviderExtensionSigningAlgorithm" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static ASAuthorizationProviderExtensionSigningAlgorithm GetValue (NSNumber constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (ASAuthorizationProviderExtensionSigningAlgorithmES256))
				return ASAuthorizationProviderExtensionSigningAlgorithm.ES256;
			if (constant.IsEqualTo (ASAuthorizationProviderExtensionSigningAlgorithmES384))
				return ASAuthorizationProviderExtensionSigningAlgorithm.ES384;
			if (constant.IsEqualTo (ASAuthorizationProviderExtensionSigningAlgorithmEd25519))
				return ASAuthorizationProviderExtensionSigningAlgorithm.Ed25519;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AuthenticationServices.ASAuthorizationProviderExtensionSigningAlgorithm" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ASAuthorizationProviderExtensionSigningAlgorithm GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSNumber> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AuthenticationServices.ASAuthorizationProviderExtensionSigningAlgorithm" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ASAuthorizationProviderExtensionSigningAlgorithm? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSNumber> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AuthenticationServices.ASAuthorizationProviderExtensionSigningAlgorithm" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSNumber?[]? ToConstantArray (this ASAuthorizationProviderExtensionSigningAlgorithm[]? values)
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
		internal static ASAuthorizationProviderExtensionSigningAlgorithm[]? ToEnumArray (this NSNumber[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<ASAuthorizationProviderExtensionSigningAlgorithm> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
