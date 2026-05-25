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
namespace Social {
	/// <summary>Enumeration with the various kinds of social services that can be used.</summary><remarks>This enumeration is used to map into the underlying set of services offered by the social framework. It is intended to assist code completion while developing and take the guesswork out of using the framework in some entry points that take an NSString as a parameter.</remarks>
	public enum SLServiceKind : int {
		/// <summary>Facebook services</summary>
		[ObsoletedOSPlatform ("ios11.0", "Use Facebook SDK instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use Facebook SDK instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Facebook SDK instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		Facebook = 0,
		/// <summary>Twitter service.</summary>
		[ObsoletedOSPlatform ("ios11.0", "Use Twitter SDK instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use Twitter SDK instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Twitter SDK instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		Twitter = 1,
		/// <summary>SinaWeibo service</summary>
		[ObsoletedOSPlatform ("ios11.0", "Use Sina Weibo SDK instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use Sina Weibo SDK instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Sina Weibo SDK instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		SinaWeibo = 2,
		/// <summary>TencentWeibo service.</summary>
		[ObsoletedOSPlatform ("ios11.0", "Use Tencent Weibo SDK instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use Tencent Weibo SDK instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Tencent Weibo SDK instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		TencentWeibo = 3,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos10.13", "Use LinkedIn SDK instead.")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		LinkedIn = 4,
	}
	/// <summary>Extension methods for the <see cref="global::Social.SLServiceKind" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SLServiceKindExtensions {
		static IntPtr[] values = new IntPtr [4];
		[ObsoletedOSPlatform ("ios11.0", "Use Facebook SDK instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use Facebook SDK instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Facebook SDK instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("SLServiceTypeFacebook", "Social")]
		internal unsafe static IntPtr SLServiceTypeFacebook {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Social.Handle, "SLServiceTypeFacebook", storage);
			}
		}
		[ObsoletedOSPlatform ("ios11.0", "Use Twitter SDK instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use Twitter SDK instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Twitter SDK instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("SLServiceTypeTwitter", "Social")]
		internal unsafe static IntPtr SLServiceTypeTwitter {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Social.Handle, "SLServiceTypeTwitter", storage);
			}
		}
		[ObsoletedOSPlatform ("ios11.0", "Use Sina Weibo SDK instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use Sina Weibo SDK instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Sina Weibo SDK instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("SLServiceTypeSinaWeibo", "Social")]
		internal unsafe static IntPtr SLServiceTypeSinaWeibo {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Social.Handle, "SLServiceTypeSinaWeibo", storage);
			}
		}
		[ObsoletedOSPlatform ("ios11.0", "Use Tencent Weibo SDK instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use Tencent Weibo SDK instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use Tencent Weibo SDK instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[Field ("SLServiceTypeTencentWeibo", "Social")]
		internal unsafe static IntPtr SLServiceTypeTencentWeibo {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Social.Handle, "SLServiceTypeTencentWeibo", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this SLServiceKind self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // SLServiceKind.Facebook
				ptr = SLServiceTypeFacebook;
				break;
			case 1: // SLServiceKind.Twitter
				ptr = SLServiceTypeTwitter;
				break;
			case 2: // SLServiceKind.SinaWeibo
				ptr = SLServiceTypeSinaWeibo;
				break;
			case 3: // SLServiceKind.TencentWeibo
				ptr = SLServiceTypeTencentWeibo;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Social.SLServiceKind" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static SLServiceKind GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (SLServiceTypeFacebook))
				return SLServiceKind.Facebook;
			if (constant.IsEqualTo (SLServiceTypeTwitter))
				return SLServiceKind.Twitter;
			if (constant.IsEqualTo (SLServiceTypeSinaWeibo))
				return SLServiceKind.SinaWeibo;
			if (constant.IsEqualTo (SLServiceTypeTencentWeibo))
				return SLServiceKind.TencentWeibo;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Social.SLServiceKind" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SLServiceKind GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Social.SLServiceKind" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SLServiceKind? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Social.SLServiceKind" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this SLServiceKind[]? values)
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
		internal static SLServiceKind[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<SLServiceKind> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
