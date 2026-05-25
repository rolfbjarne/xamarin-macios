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
namespace Contacts {
	/// <summary>Enumeration of properties of a <see cref="T:Contacts.CNPostalAddress" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public enum CNPostalAddressKeyOption : int {
		/// <summary>Corresponds to the <see cref="P:Contacts.CNPostalAddress.Street" /> property.</summary>
		Street = 0,
		/// <summary>Corresponds to the <see cref="P:Contacts.CNPostalAddress.City" /> property.</summary>
		City = 1,
		/// <summary>Corresponds to the <see cref="P:Contacts.CNPostalAddress.State" /> property.</summary>
		State = 2,
		/// <summary>Corresponds to the <see cref="P:Contacts.CNPostalAddress.PostalCode" /> property.</summary>
		PostalCode = 3,
		/// <summary>Corresponds to the <see cref="P:Contacts.CNPostalAddress.Country" /> property.</summary>
		Country = 4,
		/// <summary>Corresponds to the <see cref="P:Contacts.CNPostalAddress.IsoCountryCode" /> property.</summary>
		IsoCountryCode = 5,
		/// <summary>Corresponds to the <see cref="P:Contacts.CNPostalAddress.SubLocality" /> property.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		SubLocality = 6,
		/// <summary>Corresponds to the <see cref="P:Contacts.CNPostalAddress.SubAdministrativeArea" /> property.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		SubAdministrativeArea = 7,
	}
	/// <summary>Extension methods for the <see cref="global::Contacts.CNPostalAddressKeyOption" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CNPostalAddressKeyOptionExtensions {
		static IntPtr[] values = new IntPtr [8];
		[Field ("CNPostalAddressStreetKey", "Contacts")]
		internal unsafe static IntPtr CNPostalAddressStreetKey {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Contacts.Handle, "CNPostalAddressStreetKey", storage);
			}
		}
		[Field ("CNPostalAddressCityKey", "Contacts")]
		internal unsafe static IntPtr CNPostalAddressCityKey {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Contacts.Handle, "CNPostalAddressCityKey", storage);
			}
		}
		[Field ("CNPostalAddressStateKey", "Contacts")]
		internal unsafe static IntPtr CNPostalAddressStateKey {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Contacts.Handle, "CNPostalAddressStateKey", storage);
			}
		}
		[Field ("CNPostalAddressPostalCodeKey", "Contacts")]
		internal unsafe static IntPtr CNPostalAddressPostalCodeKey {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Contacts.Handle, "CNPostalAddressPostalCodeKey", storage);
			}
		}
		[Field ("CNPostalAddressCountryKey", "Contacts")]
		internal unsafe static IntPtr CNPostalAddressCountryKey {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Contacts.Handle, "CNPostalAddressCountryKey", storage);
			}
		}
		[Field ("CNPostalAddressISOCountryCodeKey", "Contacts")]
		internal unsafe static IntPtr CNPostalAddressISOCountryCodeKey {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Contacts.Handle, "CNPostalAddressISOCountryCodeKey", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[Field ("CNPostalAddressSubLocalityKey", "Contacts")]
		internal unsafe static IntPtr CNPostalAddressSubLocalityKey {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Contacts.Handle, "CNPostalAddressSubLocalityKey", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[Field ("CNPostalAddressSubAdministrativeAreaKey", "Contacts")]
		internal unsafe static IntPtr CNPostalAddressSubAdministrativeAreaKey {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Contacts.Handle, "CNPostalAddressSubAdministrativeAreaKey", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CNPostalAddressKeyOption self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CNPostalAddressKeyOption.Street
				ptr = CNPostalAddressStreetKey;
				break;
			case 1: // CNPostalAddressKeyOption.City
				ptr = CNPostalAddressCityKey;
				break;
			case 2: // CNPostalAddressKeyOption.State
				ptr = CNPostalAddressStateKey;
				break;
			case 3: // CNPostalAddressKeyOption.PostalCode
				ptr = CNPostalAddressPostalCodeKey;
				break;
			case 4: // CNPostalAddressKeyOption.Country
				ptr = CNPostalAddressCountryKey;
				break;
			case 5: // CNPostalAddressKeyOption.IsoCountryCode
				ptr = CNPostalAddressISOCountryCodeKey;
				break;
			case 6: // CNPostalAddressKeyOption.SubLocality
				ptr = CNPostalAddressSubLocalityKey;
				break;
			case 7: // CNPostalAddressKeyOption.SubAdministrativeArea
				ptr = CNPostalAddressSubAdministrativeAreaKey;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Contacts.CNPostalAddressKeyOption" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CNPostalAddressKeyOption GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (CNPostalAddressStreetKey))
				return CNPostalAddressKeyOption.Street;
			if (constant.IsEqualTo (CNPostalAddressCityKey))
				return CNPostalAddressKeyOption.City;
			if (constant.IsEqualTo (CNPostalAddressStateKey))
				return CNPostalAddressKeyOption.State;
			if (constant.IsEqualTo (CNPostalAddressPostalCodeKey))
				return CNPostalAddressKeyOption.PostalCode;
			if (constant.IsEqualTo (CNPostalAddressCountryKey))
				return CNPostalAddressKeyOption.Country;
			if (constant.IsEqualTo (CNPostalAddressISOCountryCodeKey))
				return CNPostalAddressKeyOption.IsoCountryCode;
			if (constant.IsEqualTo (CNPostalAddressSubLocalityKey))
				return CNPostalAddressKeyOption.SubLocality;
			if (constant.IsEqualTo (CNPostalAddressSubAdministrativeAreaKey))
				return CNPostalAddressKeyOption.SubAdministrativeArea;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Contacts.CNPostalAddressKeyOption" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CNPostalAddressKeyOption GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Contacts.CNPostalAddressKeyOption" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CNPostalAddressKeyOption? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Contacts.CNPostalAddressKeyOption" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CNPostalAddressKeyOption[]? values)
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
		internal static CNPostalAddressKeyOption[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CNPostalAddressKeyOption> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
