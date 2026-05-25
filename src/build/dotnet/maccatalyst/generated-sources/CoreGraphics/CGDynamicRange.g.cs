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
namespace CoreGraphics {
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public enum CGDynamicRange : int {
		High = 0,
		Constrained = 1,
		Standard = 2,
	}
	/// <summary>Extension methods for the <see cref="global::CoreGraphics.CGDynamicRange" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CGDynamicRangeExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("kCGDynamicRangeHigh", "CoreGraphics")]
		internal unsafe static IntPtr kCGDynamicRangeHigh {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreGraphics.Handle, "kCGDynamicRangeHigh", storage);
			}
		}
		[Field ("kCGDynamicRangeConstrained", "CoreGraphics")]
		internal unsafe static IntPtr kCGDynamicRangeConstrained {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreGraphics.Handle, "kCGDynamicRangeConstrained", storage);
			}
		}
		[Field ("kCGDynamicRangeStandard", "CoreGraphics")]
		internal unsafe static IntPtr kCGDynamicRangeStandard {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreGraphics.Handle, "kCGDynamicRangeStandard", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CGDynamicRange self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CGDynamicRange.High
				ptr = kCGDynamicRangeHigh;
				break;
			case 1: // CGDynamicRange.Constrained
				ptr = kCGDynamicRangeConstrained;
				break;
			case 2: // CGDynamicRange.Standard
				ptr = kCGDynamicRangeStandard;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreGraphics.CGDynamicRange" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CGDynamicRange GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCGDynamicRangeHigh))
				return CGDynamicRange.High;
			if (constant.IsEqualTo (kCGDynamicRangeConstrained))
				return CGDynamicRange.Constrained;
			if (constant.IsEqualTo (kCGDynamicRangeStandard))
				return CGDynamicRange.Standard;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreGraphics.CGDynamicRange" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CGDynamicRange GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreGraphics.CGDynamicRange" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CGDynamicRange? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreGraphics.CGDynamicRange" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CGDynamicRange[]? values)
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
		internal static CGDynamicRange[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CGDynamicRange> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
