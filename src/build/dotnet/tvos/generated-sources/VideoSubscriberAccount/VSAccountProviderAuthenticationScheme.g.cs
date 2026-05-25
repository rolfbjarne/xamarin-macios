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
namespace VideoSubscriberAccount {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum VSAccountProviderAuthenticationScheme : int {
		/// <summary>To be added.</summary>
		Saml = 0,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Api = 1,
	}
	/// <summary>Extension methods for the <see cref="global::VideoSubscriberAccount.VSAccountProviderAuthenticationScheme" /> enumeration.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VSAccountProviderAuthenticationSchemeExtensions {
		static IntPtr[] values = new IntPtr [2];
		[Field ("VSAccountProviderAuthenticationSchemeSAML", "VideoSubscriberAccount")]
		internal unsafe static IntPtr VSAccountProviderAuthenticationSchemeSAML {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.VideoSubscriberAccount.Handle, "VSAccountProviderAuthenticationSchemeSAML", storage);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("VSAccountProviderAuthenticationSchemeAPI", "VideoSubscriberAccount")]
		internal unsafe static IntPtr VSAccountProviderAuthenticationSchemeAPI {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.VideoSubscriberAccount.Handle, "VSAccountProviderAuthenticationSchemeAPI", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this VSAccountProviderAuthenticationScheme self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // VSAccountProviderAuthenticationScheme.Saml
				ptr = VSAccountProviderAuthenticationSchemeSAML;
				break;
			case 1: // VSAccountProviderAuthenticationScheme.Api
				ptr = VSAccountProviderAuthenticationSchemeAPI;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::VideoSubscriberAccount.VSAccountProviderAuthenticationScheme" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static VSAccountProviderAuthenticationScheme GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (VSAccountProviderAuthenticationSchemeSAML))
				return VSAccountProviderAuthenticationScheme.Saml;
			if (constant.IsEqualTo (VSAccountProviderAuthenticationSchemeAPI))
				return VSAccountProviderAuthenticationScheme.Api;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::VideoSubscriberAccount.VSAccountProviderAuthenticationScheme" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VSAccountProviderAuthenticationScheme GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::VideoSubscriberAccount.VSAccountProviderAuthenticationScheme" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VSAccountProviderAuthenticationScheme? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::VideoSubscriberAccount.VSAccountProviderAuthenticationScheme" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this VSAccountProviderAuthenticationScheme[]? values)
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
		internal static VSAccountProviderAuthenticationScheme[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<VSAccountProviderAuthenticationScheme> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
