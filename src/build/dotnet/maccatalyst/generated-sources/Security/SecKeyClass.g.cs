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
	/// <summary>The kind of cryptographic key</summary><remarks>To be added.</remarks>
	public enum SecKeyClass : int {
		/// <summary>To be added.</summary>
		Invalid = -1,
		/// <summary>Public part of a symmetric key.</summary>
		Public = 0,
		/// <summary>Private part of an asymmetric key.</summary>
		Private = 1,
		/// <summary>A symmetric key.</summary>
		Symmetric = 2,
	}
	/// <summary>Extension methods for the <see cref="global::Security.SecKeyClass" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SecKeyClassExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("kSecAttrKeyClassPublic", "Security")]
		internal unsafe static IntPtr kSecAttrKeyClassPublic {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecAttrKeyClassPublic", storage);
			}
		}
		[Field ("kSecAttrKeyClassPrivate", "Security")]
		internal unsafe static IntPtr kSecAttrKeyClassPrivate {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecAttrKeyClassPrivate", storage);
			}
		}
		[Field ("kSecAttrKeyClassSymmetric", "Security")]
		internal unsafe static IntPtr kSecAttrKeyClassSymmetric {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecAttrKeyClassSymmetric", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this SecKeyClass self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // SecKeyClass.Public
				ptr = kSecAttrKeyClassPublic;
				break;
			case 1: // SecKeyClass.Private
				ptr = kSecAttrKeyClassPrivate;
				break;
			case 2: // SecKeyClass.Symmetric
				ptr = kSecAttrKeyClassSymmetric;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Security.SecKeyClass" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static SecKeyClass GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kSecAttrKeyClassPublic))
				return SecKeyClass.Public;
			if (constant.IsEqualTo (kSecAttrKeyClassPrivate))
				return SecKeyClass.Private;
			if (constant.IsEqualTo (kSecAttrKeyClassSymmetric))
				return SecKeyClass.Symmetric;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Security.SecKeyClass" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SecKeyClass GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Security.SecKeyClass" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SecKeyClass? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Security.SecKeyClass" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this SecKeyClass[]? values)
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
		internal static SecKeyClass[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<SecKeyClass> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
