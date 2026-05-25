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
namespace CoreAnimation {
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public enum CADynamicRange : int {
		Automatic = 0,
		Standard = 1,
		ConstrainedHigh = 2,
		High = 3,
	}
	/// <summary>Extension methods for the <see cref="global::CoreAnimation.CADynamicRange" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CADynamicRangeExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("CADynamicRangeAutomatic", "CoreAnimation")]
		internal unsafe static IntPtr CADynamicRangeAutomatic {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "CADynamicRangeAutomatic", storage);
			}
		}
		[Field ("CADynamicRangeStandard", "CoreAnimation")]
		internal unsafe static IntPtr CADynamicRangeStandard {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "CADynamicRangeStandard", storage);
			}
		}
		[Field ("CADynamicRangeConstrainedHigh", "CoreAnimation")]
		internal unsafe static IntPtr CADynamicRangeConstrainedHigh {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "CADynamicRangeConstrainedHigh", storage);
			}
		}
		[Field ("CADynamicRangeHigh", "CoreAnimation")]
		internal unsafe static IntPtr CADynamicRangeHigh {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "CADynamicRangeHigh", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CADynamicRange self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CADynamicRange.Automatic
				ptr = CADynamicRangeAutomatic;
				break;
			case 1: // CADynamicRange.Standard
				ptr = CADynamicRangeStandard;
				break;
			case 2: // CADynamicRange.ConstrainedHigh
				ptr = CADynamicRangeConstrainedHigh;
				break;
			case 3: // CADynamicRange.High
				ptr = CADynamicRangeHigh;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CADynamicRange" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CADynamicRange GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (CADynamicRangeAutomatic))
				return CADynamicRange.Automatic;
			if (constant.IsEqualTo (CADynamicRangeStandard))
				return CADynamicRange.Standard;
			if (constant.IsEqualTo (CADynamicRangeConstrainedHigh))
				return CADynamicRange.ConstrainedHigh;
			if (constant.IsEqualTo (CADynamicRangeHigh))
				return CADynamicRange.High;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CADynamicRange" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CADynamicRange GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CADynamicRange" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CADynamicRange? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreAnimation.CADynamicRange" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CADynamicRange[]? values)
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
		internal static CADynamicRange[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CADynamicRange> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
