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
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public enum CMFormatDescriptionViewPackingKind : int {
		SideBySide = 0,
		OverUnder = 1,
	}
	/// <summary>Extension methods for the <see cref="global::CoreMedia.CMFormatDescriptionViewPackingKind" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CMFormatDescriptionViewPackingKindExtensions {
		static IntPtr[] values = new IntPtr [2];
		[Field ("kCMFormatDescriptionViewPackingKind_SideBySide", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionViewPackingKind_SideBySide {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionViewPackingKind_SideBySide", storage);
			}
		}
		[Field ("kCMFormatDescriptionViewPackingKind_OverUnder", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionViewPackingKind_OverUnder {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionViewPackingKind_OverUnder", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CMFormatDescriptionViewPackingKind self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CMFormatDescriptionViewPackingKind.SideBySide
				ptr = kCMFormatDescriptionViewPackingKind_SideBySide;
				break;
			case 1: // CMFormatDescriptionViewPackingKind.OverUnder
				ptr = kCMFormatDescriptionViewPackingKind_OverUnder;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionViewPackingKind" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CMFormatDescriptionViewPackingKind GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCMFormatDescriptionViewPackingKind_SideBySide))
				return CMFormatDescriptionViewPackingKind.SideBySide;
			if (constant.IsEqualTo (kCMFormatDescriptionViewPackingKind_OverUnder))
				return CMFormatDescriptionViewPackingKind.OverUnder;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionViewPackingKind" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionViewPackingKind GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionViewPackingKind" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionViewPackingKind? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreMedia.CMFormatDescriptionViewPackingKind" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CMFormatDescriptionViewPackingKind[]? values)
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
		internal static CMFormatDescriptionViewPackingKind[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CMFormatDescriptionViewPackingKind> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
