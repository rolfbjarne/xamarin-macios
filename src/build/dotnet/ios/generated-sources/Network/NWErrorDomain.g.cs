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
namespace Network {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum NWErrorDomain : int {
		/// <summary>To be added.</summary>
		Invalid = 0,
		/// <summary>To be added.</summary>
		Posix = 1,
		/// <summary>To be added.</summary>
		Dns = 2,
		/// <summary>To be added.</summary>
		Tls = 3,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		WiFiAware = 4,
	}
	/// <summary>Extension methods for the <see cref="global::Network.NWErrorDomain" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NWErrorDomainExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("kNWErrorDomainPOSIX", "Network")]
		internal unsafe static IntPtr kNWErrorDomainPOSIX {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Network.Handle, "kNWErrorDomainPOSIX", storage);
			}
		}
		[Field ("kNWErrorDomainDNS", "Network")]
		internal unsafe static IntPtr kNWErrorDomainDNS {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Network.Handle, "kNWErrorDomainDNS", storage);
			}
		}
		[Field ("kNWErrorDomainTLS", "Network")]
		internal unsafe static IntPtr kNWErrorDomainTLS {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Network.Handle, "kNWErrorDomainTLS", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("kNWErrorDomainWiFiAware", "Network")]
		internal unsafe static IntPtr kNWErrorDomainWiFiAware {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Network.Handle, "kNWErrorDomainWiFiAware", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NWErrorDomain self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // NWErrorDomain.Posix
				ptr = kNWErrorDomainPOSIX;
				break;
			case 2: // NWErrorDomain.Dns
				ptr = kNWErrorDomainDNS;
				break;
			case 3: // NWErrorDomain.Tls
				ptr = kNWErrorDomainTLS;
				break;
			case 4: // NWErrorDomain.WiFiAware
				ptr = kNWErrorDomainWiFiAware;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Network.NWErrorDomain" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NWErrorDomain GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kNWErrorDomainPOSIX))
				return NWErrorDomain.Posix;
			if (constant.IsEqualTo (kNWErrorDomainDNS))
				return NWErrorDomain.Dns;
			if (constant.IsEqualTo (kNWErrorDomainTLS))
				return NWErrorDomain.Tls;
			if (constant.IsEqualTo (kNWErrorDomainWiFiAware))
				return NWErrorDomain.WiFiAware;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Network.NWErrorDomain" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NWErrorDomain GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Network.NWErrorDomain" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NWErrorDomain? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Network.NWErrorDomain" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NWErrorDomain[]? values)
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
		internal static NWErrorDomain[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NWErrorDomain> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
