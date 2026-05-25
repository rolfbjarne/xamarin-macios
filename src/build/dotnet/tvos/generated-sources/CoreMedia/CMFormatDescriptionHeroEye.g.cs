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
namespace CoreMedia {
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public enum CMFormatDescriptionHeroEye : int {
		Left = 0,
		Right = 1,
	}
	/// <summary>Extension methods for the <see cref="global::CoreMedia.CMFormatDescriptionHeroEye" /> enumeration.</summary>
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CMFormatDescriptionHeroEyeExtensions {
		static IntPtr[] values = new IntPtr [2];
		[Field ("kCMFormatDescriptionHeroEye_Left", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionHeroEye_Left {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionHeroEye_Left", storage);
			}
		}
		[Field ("kCMFormatDescriptionHeroEye_Right", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionHeroEye_Right {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionHeroEye_Right", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CMFormatDescriptionHeroEye self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CMFormatDescriptionHeroEye.Left
				ptr = kCMFormatDescriptionHeroEye_Left;
				break;
			case 1: // CMFormatDescriptionHeroEye.Right
				ptr = kCMFormatDescriptionHeroEye_Right;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionHeroEye" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CMFormatDescriptionHeroEye GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCMFormatDescriptionHeroEye_Left))
				return CMFormatDescriptionHeroEye.Left;
			if (constant.IsEqualTo (kCMFormatDescriptionHeroEye_Right))
				return CMFormatDescriptionHeroEye.Right;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionHeroEye" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionHeroEye GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionHeroEye" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionHeroEye? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreMedia.CMFormatDescriptionHeroEye" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CMFormatDescriptionHeroEye[]? values)
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
		internal static CMFormatDescriptionHeroEye[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CMFormatDescriptionHeroEye> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
