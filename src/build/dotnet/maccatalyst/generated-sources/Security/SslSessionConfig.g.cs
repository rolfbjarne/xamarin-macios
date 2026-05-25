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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum SslSessionConfig : int {
		/// <summary>Developers should not use this deprecated field. </summary>
		[ObsoletedOSPlatform ("ios11.0")]
		[ObsoletedOSPlatform ("macos10.13")]
		[ObsoletedOSPlatform ("tvos11.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		Default = 0,
		/// <summary>To be added.</summary>
		Ats1 = 1,
		/// <summary>To be added.</summary>
		Ats1NoPfs = 2,
		/// <summary>To be added.</summary>
		Standard = 3,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("ios11.0")]
		[ObsoletedOSPlatform ("macos10.13")]
		[ObsoletedOSPlatform ("tvos11.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		RC4Fallback = 4,
		/// <summary>To be added.</summary>
		Tls1Fallback = 5,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("ios11.0")]
		[ObsoletedOSPlatform ("macos10.13")]
		[ObsoletedOSPlatform ("tvos11.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		Tls1RC4Fallback = 6,
		/// <summary>To be added.</summary>
		Legacy = 7,
		/// <summary>To be added.</summary>
		LegacyDhe = 8,
		/// <summary>To be added.</summary>
		Anonymous = 9,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("ios11.0")]
		[ObsoletedOSPlatform ("macos10.13")]
		[ObsoletedOSPlatform ("tvos11.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ThreeDesFallback = 10,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("ios11.0")]
		[ObsoletedOSPlatform ("macos10.13")]
		[ObsoletedOSPlatform ("tvos11.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Tls1ThreeDesFallback = 11,
	}
	/// <summary>Extension methods for the <see cref="global::Security.SslSessionConfig" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SslSessionConfigExtensions {
		static IntPtr[] values = new IntPtr [12];
		[ObsoletedOSPlatform ("ios11.0")]
		[ObsoletedOSPlatform ("macos10.13")]
		[ObsoletedOSPlatform ("tvos11.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kSSLSessionConfig_default", "Security")]
		internal unsafe static IntPtr kSSLSessionConfig_default {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSSLSessionConfig_default", storage);
			}
		}
		[Field ("kSSLSessionConfig_ATSv1", "Security")]
		internal unsafe static IntPtr kSSLSessionConfig_ATSv1 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSSLSessionConfig_ATSv1", storage);
			}
		}
		[Field ("kSSLSessionConfig_ATSv1_noPFS", "Security")]
		internal unsafe static IntPtr kSSLSessionConfig_ATSv1_noPFS {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSSLSessionConfig_ATSv1_noPFS", storage);
			}
		}
		[Field ("kSSLSessionConfig_standard", "Security")]
		internal unsafe static IntPtr kSSLSessionConfig_standard {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSSLSessionConfig_standard", storage);
			}
		}
		[ObsoletedOSPlatform ("ios11.0")]
		[ObsoletedOSPlatform ("macos10.13")]
		[ObsoletedOSPlatform ("tvos11.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kSSLSessionConfig_RC4_fallback", "Security")]
		internal unsafe static IntPtr kSSLSessionConfig_RC4_fallback {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSSLSessionConfig_RC4_fallback", storage);
			}
		}
		[Field ("kSSLSessionConfig_TLSv1_fallback", "Security")]
		internal unsafe static IntPtr kSSLSessionConfig_TLSv1_fallback {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSSLSessionConfig_TLSv1_fallback", storage);
			}
		}
		[ObsoletedOSPlatform ("ios11.0")]
		[ObsoletedOSPlatform ("macos10.13")]
		[ObsoletedOSPlatform ("tvos11.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kSSLSessionConfig_TLSv1_RC4_fallback", "Security")]
		internal unsafe static IntPtr kSSLSessionConfig_TLSv1_RC4_fallback {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSSLSessionConfig_TLSv1_RC4_fallback", storage);
			}
		}
		[Field ("kSSLSessionConfig_legacy", "Security")]
		internal unsafe static IntPtr kSSLSessionConfig_legacy {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSSLSessionConfig_legacy", storage);
			}
		}
		[Field ("kSSLSessionConfig_legacy_DHE", "Security")]
		internal unsafe static IntPtr kSSLSessionConfig_legacy_DHE {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSSLSessionConfig_legacy_DHE", storage);
			}
		}
		[Field ("kSSLSessionConfig_anonymous", "Security")]
		internal unsafe static IntPtr kSSLSessionConfig_anonymous {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSSLSessionConfig_anonymous", storage);
			}
		}
		[ObsoletedOSPlatform ("ios11.0")]
		[ObsoletedOSPlatform ("macos10.13")]
		[ObsoletedOSPlatform ("tvos11.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSSLSessionConfig_3DES_fallback", "Security")]
		internal unsafe static IntPtr kSSLSessionConfig_3DES_fallback {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSSLSessionConfig_3DES_fallback", storage);
			}
		}
		[ObsoletedOSPlatform ("ios11.0")]
		[ObsoletedOSPlatform ("macos10.13")]
		[ObsoletedOSPlatform ("tvos11.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kSSLSessionConfig_TLSv1_3DES_fallback", "Security")]
		internal unsafe static IntPtr kSSLSessionConfig_TLSv1_3DES_fallback {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSSLSessionConfig_TLSv1_3DES_fallback", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this SslSessionConfig self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // SslSessionConfig.Default
				ptr = kSSLSessionConfig_default;
				break;
			case 1: // SslSessionConfig.Ats1
				ptr = kSSLSessionConfig_ATSv1;
				break;
			case 2: // SslSessionConfig.Ats1NoPfs
				ptr = kSSLSessionConfig_ATSv1_noPFS;
				break;
			case 3: // SslSessionConfig.Standard
				ptr = kSSLSessionConfig_standard;
				break;
			case 4: // SslSessionConfig.RC4Fallback
				ptr = kSSLSessionConfig_RC4_fallback;
				break;
			case 5: // SslSessionConfig.Tls1Fallback
				ptr = kSSLSessionConfig_TLSv1_fallback;
				break;
			case 6: // SslSessionConfig.Tls1RC4Fallback
				ptr = kSSLSessionConfig_TLSv1_RC4_fallback;
				break;
			case 7: // SslSessionConfig.Legacy
				ptr = kSSLSessionConfig_legacy;
				break;
			case 8: // SslSessionConfig.LegacyDhe
				ptr = kSSLSessionConfig_legacy_DHE;
				break;
			case 9: // SslSessionConfig.Anonymous
				ptr = kSSLSessionConfig_anonymous;
				break;
			case 10: // SslSessionConfig.ThreeDesFallback
				ptr = kSSLSessionConfig_3DES_fallback;
				break;
			case 11: // SslSessionConfig.Tls1ThreeDesFallback
				ptr = kSSLSessionConfig_TLSv1_3DES_fallback;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Security.SslSessionConfig" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static SslSessionConfig GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kSSLSessionConfig_default))
				return SslSessionConfig.Default;
			if (constant.IsEqualTo (kSSLSessionConfig_ATSv1))
				return SslSessionConfig.Ats1;
			if (constant.IsEqualTo (kSSLSessionConfig_ATSv1_noPFS))
				return SslSessionConfig.Ats1NoPfs;
			if (constant.IsEqualTo (kSSLSessionConfig_standard))
				return SslSessionConfig.Standard;
			if (constant.IsEqualTo (kSSLSessionConfig_RC4_fallback))
				return SslSessionConfig.RC4Fallback;
			if (constant.IsEqualTo (kSSLSessionConfig_TLSv1_fallback))
				return SslSessionConfig.Tls1Fallback;
			if (constant.IsEqualTo (kSSLSessionConfig_TLSv1_RC4_fallback))
				return SslSessionConfig.Tls1RC4Fallback;
			if (constant.IsEqualTo (kSSLSessionConfig_legacy))
				return SslSessionConfig.Legacy;
			if (constant.IsEqualTo (kSSLSessionConfig_legacy_DHE))
				return SslSessionConfig.LegacyDhe;
			if (constant.IsEqualTo (kSSLSessionConfig_anonymous))
				return SslSessionConfig.Anonymous;
			if (constant.IsEqualTo (kSSLSessionConfig_3DES_fallback))
				return SslSessionConfig.ThreeDesFallback;
			if (constant.IsEqualTo (kSSLSessionConfig_TLSv1_3DES_fallback))
				return SslSessionConfig.Tls1ThreeDesFallback;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Security.SslSessionConfig" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SslSessionConfig GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Security.SslSessionConfig" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SslSessionConfig? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Security.SslSessionConfig" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this SslSessionConfig[]? values)
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
		internal static SslSessionConfig[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<SslSessionConfig> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
