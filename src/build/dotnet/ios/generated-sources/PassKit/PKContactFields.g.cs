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
namespace PassKit {
	/// <summary>Enumerates fields for a contact.</summary>
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Flags]
	public enum PKContactFields : int {
		/// <summary>Indicates a name field.</summary>
		None = 0,
		/// <summary>Indicates a postal address field.</summary>
		PostalAddress = 1,
		/// <summary>Indicates an email address field.</summary>
		EmailAddress = 2,
		/// <summary>Indicates a phone number field.</summary>
		PhoneNumber = 4,
		/// <summary>To be added.</summary>
		Name = 8,
		/// <summary>Indicates a phonetic name field.</summary>
		PhoneticName = 16,
	}
	/// <summary>Extension methods for the <see cref="global::PassKit.PKContactFields" /> enumeration.</summary>
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class PKContactFieldsExtensions {
		static IntPtr[] values = new IntPtr [5];
		[Field ("PKContactFieldPostalAddress", "PassKit")]
		internal unsafe static IntPtr PKContactFieldPostalAddress {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.PassKit.Handle, "PKContactFieldPostalAddress", storage);
			}
		}
		[Field ("PKContactFieldEmailAddress", "PassKit")]
		internal unsafe static IntPtr PKContactFieldEmailAddress {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.PassKit.Handle, "PKContactFieldEmailAddress", storage);
			}
		}
		[Field ("PKContactFieldPhoneNumber", "PassKit")]
		internal unsafe static IntPtr PKContactFieldPhoneNumber {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.PassKit.Handle, "PKContactFieldPhoneNumber", storage);
			}
		}
		[Field ("PKContactFieldName", "PassKit")]
		internal unsafe static IntPtr PKContactFieldName {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.PassKit.Handle, "PKContactFieldName", storage);
			}
		}
		[Field ("PKContactFieldPhoneticName", "PassKit")]
		internal unsafe static IntPtr PKContactFieldPhoneticName {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.PassKit.Handle, "PKContactFieldPhoneticName", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this PKContactFields self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // PKContactFields.PostalAddress
				ptr = PKContactFieldPostalAddress;
				break;
			case 2: // PKContactFields.EmailAddress
				ptr = PKContactFieldEmailAddress;
				break;
			case 4: // PKContactFields.PhoneNumber
				ptr = PKContactFieldPhoneNumber;
				break;
			case 8: // PKContactFields.Name
				ptr = PKContactFieldName;
				break;
			case 16: // PKContactFields.PhoneticName
				ptr = PKContactFieldPhoneticName;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::PassKit.PKContactFields" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static PKContactFields GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (PKContactFieldPostalAddress))
				return PKContactFields.PostalAddress;
			if (constant.IsEqualTo (PKContactFieldEmailAddress))
				return PKContactFields.EmailAddress;
			if (constant.IsEqualTo (PKContactFieldPhoneNumber))
				return PKContactFields.PhoneNumber;
			if (constant.IsEqualTo (PKContactFieldName))
				return PKContactFields.Name;
			if (constant.IsEqualTo (PKContactFieldPhoneticName))
				return PKContactFields.PhoneticName;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::PassKit.PKContactFields" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PKContactFields GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::PassKit.PKContactFields" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PKContactFields? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::PassKit.PKContactFields" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this PKContactFields[]? values)
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
		internal static PKContactFields[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<PKContactFields> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
		/// <summary>Retrieves all the <see cref="global::PassKit.PKContactFields" /> constants named by the flags <paramref name="value" />.</summary>
		/// <param name="value">The flags to retrieve</param>
		/// <remarks>Any flags that are not recognized will be ignored.</remarks>
		public static NSString[] ToArray (this PKContactFields value)
		{
			var rv = new global::System.Collections.Generic.List<NSString> ();
			if (value.HasFlag (PKContactFields.PostalAddress) && PKContactFieldPostalAddress != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (PKContactFieldPostalAddress)!);
			if (value.HasFlag (PKContactFields.EmailAddress) && PKContactFieldEmailAddress != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (PKContactFieldEmailAddress)!);
			if (value.HasFlag (PKContactFields.PhoneNumber) && PKContactFieldPhoneNumber != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (PKContactFieldPhoneNumber)!);
			if (value.HasFlag (PKContactFields.Name) && PKContactFieldName != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (PKContactFieldName)!);
			if (value.HasFlag (PKContactFields.PhoneticName) && PKContactFieldPhoneticName != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (PKContactFieldPhoneticName)!);
			// In order to be forward-compatible, any unknown values are ignored.
			return rv.ToArray ();
		}
		public static PKContactFields ToFlags (global::System.Collections.Generic.IEnumerable<NSString> constants)
		{
			var rv = default (PKContactFields);
			if (constants is null)
				return rv;
			foreach (var constant in constants) {
				if (constant.IsEqualTo (PKContactFieldPostalAddress))
					rv |= PKContactFields.PostalAddress;
				else if (constant.IsEqualTo (PKContactFieldEmailAddress))
					rv |= PKContactFields.EmailAddress;
				else if (constant.IsEqualTo (PKContactFieldPhoneNumber))
					rv |= PKContactFields.PhoneNumber;
				else if (constant.IsEqualTo (PKContactFieldName))
					rv |= PKContactFields.Name;
				else if (constant.IsEqualTo (PKContactFieldPhoneticName))
					rv |= PKContactFields.PhoneticName;
				// In order to be forward-compatible, any unknown values are ignored.
			}
			return rv;
		}
	}
}
