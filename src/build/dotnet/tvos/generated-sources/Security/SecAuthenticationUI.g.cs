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
namespace Security {
	/// <summary>Enumeration whose values represent valid options for <see cref="Security.SecRecord.AuthenticationUI" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum SecAuthenticationUI : int {
		/// <summary>To be added.</summary>
		NotSet = -1,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos11.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		Allow = 0,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos11.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		Fail = 1,
		/// <summary>To be added.</summary>
		Skip = 2,
	}
	/// <summary>Extension methods for the <see cref="global::Security.SecAuthenticationUI" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class SecAuthenticationUIExtensions {
		static IntPtr[] values = new IntPtr [3];
		[ObsoletedOSPlatform ("macos11.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kSecUseAuthenticationUIAllow", "Security")]
		internal unsafe static IntPtr kSecUseAuthenticationUIAllow {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecUseAuthenticationUIAllow", storage);
			}
		}
		[ObsoletedOSPlatform ("macos11.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LAContext.InteractionNotAllowed' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kSecUseAuthenticationUIFail", "Security")]
		internal unsafe static IntPtr kSecUseAuthenticationUIFail {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecUseAuthenticationUIFail", storage);
			}
		}
		[Field ("kSecUseAuthenticationUISkip", "Security")]
		internal unsafe static IntPtr kSecUseAuthenticationUISkip {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Security.Handle, "kSecUseAuthenticationUISkip", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this SecAuthenticationUI self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // SecAuthenticationUI.Allow
				ptr = kSecUseAuthenticationUIAllow;
				break;
			case 1: // SecAuthenticationUI.Fail
				ptr = kSecUseAuthenticationUIFail;
				break;
			case 2: // SecAuthenticationUI.Skip
				ptr = kSecUseAuthenticationUISkip;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Security.SecAuthenticationUI" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static SecAuthenticationUI GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kSecUseAuthenticationUIAllow))
				return SecAuthenticationUI.Allow;
			if (constant.IsEqualTo (kSecUseAuthenticationUIFail))
				return SecAuthenticationUI.Fail;
			if (constant.IsEqualTo (kSecUseAuthenticationUISkip))
				return SecAuthenticationUI.Skip;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Security.SecAuthenticationUI" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SecAuthenticationUI GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Security.SecAuthenticationUI" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static SecAuthenticationUI? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Security.SecAuthenticationUI" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this SecAuthenticationUI[]? values)
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
		internal static SecAuthenticationUI[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<SecAuthenticationUI> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
