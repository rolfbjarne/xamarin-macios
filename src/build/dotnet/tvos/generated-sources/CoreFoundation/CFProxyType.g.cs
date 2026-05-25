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
namespace CoreFoundation {
	/// <summary>An enum of <see cref="T:CoreFoundation.CFProxy" /> proxy types.</summary>
	public enum CFProxyType : int {
		/// <summary>No proxy should be used.</summary>
		None = 0,
		/// <summary>An autoconfiguration url.</summary>
		AutoConfigurationUrl = 1,
		/// <summary>Proxy types available from the system.</summary>
		AutoConfigurationJavaScript = 2,
		/// <summary>An FTP proxy.</summary>
		FTP = 3,
		/// <summary>An HTTP proxy.</summary>
		HTTP = 4,
		/// <summary>An HTTPS proxy.</summary>
		HTTPS = 5,
		/// <summary>A SOCKS proxy.</summary>
		SOCKS = 6,
	}
	/// <summary>Extension methods for the <see cref="global::CoreFoundation.CFProxyType" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CFProxyTypeExtensions {
		static IntPtr[] values = new IntPtr [7];
		[Field ("kCFProxyTypeNone", "CFNetwork")]
		internal unsafe static IntPtr kCFProxyTypeNone {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CFNetwork.Handle, "kCFProxyTypeNone", storage);
			}
		}
		[Field ("kCFProxyTypeAutoConfigurationURL", "CFNetwork")]
		internal unsafe static IntPtr kCFProxyTypeAutoConfigurationURL {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CFNetwork.Handle, "kCFProxyTypeAutoConfigurationURL", storage);
			}
		}
		[Field ("kCFProxyTypeAutoConfigurationJavaScript", "CFNetwork")]
		internal unsafe static IntPtr kCFProxyTypeAutoConfigurationJavaScript {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CFNetwork.Handle, "kCFProxyTypeAutoConfigurationJavaScript", storage);
			}
		}
		[Field ("kCFProxyTypeFTP", "CFNetwork")]
		internal unsafe static IntPtr kCFProxyTypeFTP {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CFNetwork.Handle, "kCFProxyTypeFTP", storage);
			}
		}
		[Field ("kCFProxyTypeHTTP", "CFNetwork")]
		internal unsafe static IntPtr kCFProxyTypeHTTP {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CFNetwork.Handle, "kCFProxyTypeHTTP", storage);
			}
		}
		[Field ("kCFProxyTypeHTTPS", "CFNetwork")]
		internal unsafe static IntPtr kCFProxyTypeHTTPS {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.CFNetwork.Handle, "kCFProxyTypeHTTPS", storage);
			}
		}
		[Field ("kCFProxyTypeSOCKS", "CFNetwork")]
		internal unsafe static IntPtr kCFProxyTypeSOCKS {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.CFNetwork.Handle, "kCFProxyTypeSOCKS", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CFProxyType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CFProxyType.None
			default:
				ptr = kCFProxyTypeNone;
				break;
			case 1: // CFProxyType.AutoConfigurationUrl
				ptr = kCFProxyTypeAutoConfigurationURL;
				break;
			case 2: // CFProxyType.AutoConfigurationJavaScript
				ptr = kCFProxyTypeAutoConfigurationJavaScript;
				break;
			case 3: // CFProxyType.FTP
				ptr = kCFProxyTypeFTP;
				break;
			case 4: // CFProxyType.HTTP
				ptr = kCFProxyTypeHTTP;
				break;
			case 5: // CFProxyType.HTTPS
				ptr = kCFProxyTypeHTTPS;
				break;
			case 6: // CFProxyType.SOCKS
				ptr = kCFProxyTypeSOCKS;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreFoundation.CFProxyType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CFProxyType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCFProxyTypeNone))
				return CFProxyType.None;
			if (constant.IsEqualTo (kCFProxyTypeAutoConfigurationURL))
				return CFProxyType.AutoConfigurationUrl;
			if (constant.IsEqualTo (kCFProxyTypeAutoConfigurationJavaScript))
				return CFProxyType.AutoConfigurationJavaScript;
			if (constant.IsEqualTo (kCFProxyTypeFTP))
				return CFProxyType.FTP;
			if (constant.IsEqualTo (kCFProxyTypeHTTP))
				return CFProxyType.HTTP;
			if (constant.IsEqualTo (kCFProxyTypeHTTPS))
				return CFProxyType.HTTPS;
			if (constant.IsEqualTo (kCFProxyTypeSOCKS))
				return CFProxyType.SOCKS;
			return CFProxyType.None;
		}
		/// <summary>Retrieves the <see cref="global::CoreFoundation.CFProxyType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CFProxyType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreFoundation.CFProxyType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CFProxyType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreFoundation.CFProxyType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CFProxyType[]? values)
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
		internal static CFProxyType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CFProxyType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
