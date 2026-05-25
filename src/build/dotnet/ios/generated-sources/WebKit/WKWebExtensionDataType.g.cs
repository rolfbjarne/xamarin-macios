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
namespace WebKit {
	[SupportedOSPlatform ("macos15.4")]
	[SupportedOSPlatform ("ios18.4")]
	[SupportedOSPlatform ("maccatalyst18.4")]
	[UnsupportedOSPlatform ("tvos")]
	[Flags]
	public enum WKWebExtensionDataType : int {
		Local = 1,
		Session = 2,
		Synchronized = 4,
	}
	/// <summary>Extension methods for the <see cref="global::WebKit.WKWebExtensionDataType" /> enumeration.</summary>
	[SupportedOSPlatform ("macos15.4")]
	[SupportedOSPlatform ("ios18.4")]
	[SupportedOSPlatform ("maccatalyst18.4")]
	[UnsupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class WKWebExtensionDataTypeExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("WKWebExtensionDataTypeLocal", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionDataTypeLocal {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionDataTypeLocal", storage);
			}
		}
		[Field ("WKWebExtensionDataTypeSession", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionDataTypeSession {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionDataTypeSession", storage);
			}
		}
		[Field ("WKWebExtensionDataTypeSynchronized", "WebKit")]
		internal unsafe static IntPtr WKWebExtensionDataTypeSynchronized {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.WebKit.Handle, "WKWebExtensionDataTypeSynchronized", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this WKWebExtensionDataType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // WKWebExtensionDataType.Local
				ptr = WKWebExtensionDataTypeLocal;
				break;
			case 2: // WKWebExtensionDataType.Session
				ptr = WKWebExtensionDataTypeSession;
				break;
			case 4: // WKWebExtensionDataType.Synchronized
				ptr = WKWebExtensionDataTypeSynchronized;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::WebKit.WKWebExtensionDataType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static WKWebExtensionDataType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (WKWebExtensionDataTypeLocal))
				return WKWebExtensionDataType.Local;
			if (constant.IsEqualTo (WKWebExtensionDataTypeSession))
				return WKWebExtensionDataType.Session;
			if (constant.IsEqualTo (WKWebExtensionDataTypeSynchronized))
				return WKWebExtensionDataType.Synchronized;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::WebKit.WKWebExtensionDataType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static WKWebExtensionDataType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::WebKit.WKWebExtensionDataType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static WKWebExtensionDataType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::WebKit.WKWebExtensionDataType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this WKWebExtensionDataType[]? values)
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
		internal static WKWebExtensionDataType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<WKWebExtensionDataType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
		/// <summary>Retrieves all the <see cref="global::WebKit.WKWebExtensionDataType" /> constants named by the flags <paramref name="value" />.</summary>
		/// <param name="value">The flags to retrieve</param>
		/// <remarks>Any flags that are not recognized will be ignored.</remarks>
		public static NSString[] ToArray (this WKWebExtensionDataType value)
		{
			var rv = new global::System.Collections.Generic.List<NSString> ();
			if (value.HasFlag (WKWebExtensionDataType.Local) && WKWebExtensionDataTypeLocal != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionDataTypeLocal)!);
			if (value.HasFlag (WKWebExtensionDataType.Session) && WKWebExtensionDataTypeSession != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionDataTypeSession)!);
			if (value.HasFlag (WKWebExtensionDataType.Synchronized) && WKWebExtensionDataTypeSynchronized != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (WKWebExtensionDataTypeSynchronized)!);
			// In order to be forward-compatible, any unknown values are ignored.
			return rv.ToArray ();
		}
		public static WKWebExtensionDataType ToFlags (global::System.Collections.Generic.IEnumerable<NSString> constants)
		{
			var rv = default (WKWebExtensionDataType);
			if (constants is null)
				return rv;
			foreach (var constant in constants) {
				if (constant.IsEqualTo (WKWebExtensionDataTypeLocal))
					rv |= WKWebExtensionDataType.Local;
				else if (constant.IsEqualTo (WKWebExtensionDataTypeSession))
					rv |= WKWebExtensionDataType.Session;
				else if (constant.IsEqualTo (WKWebExtensionDataTypeSynchronized))
					rv |= WKWebExtensionDataType.Synchronized;
				// In order to be forward-compatible, any unknown values are ignored.
			}
			return rv;
		}
	}
}
