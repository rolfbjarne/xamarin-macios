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
namespace VideoToolbox {
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos16.0")]
	public enum VTRotation : int {
		Zero = 0,
		ClockwiseNinety = 1,
		OneHundredAndEighty = 2,
		CounterclockwiseNinety = 3,
	}
	/// <summary>Extension methods for the <see cref="global::VideoToolbox.VTRotation" /> enumeration.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VTRotationExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("kVTRotation_0", "VideoToolbox")]
		internal unsafe static IntPtr kVTRotation_0 {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.VideoToolbox.Handle, "kVTRotation_0", storage);
			}
		}
		[Field ("kVTRotation_CW90", "VideoToolbox")]
		internal unsafe static IntPtr kVTRotation_CW90 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.VideoToolbox.Handle, "kVTRotation_CW90", storage);
			}
		}
		[Field ("kVTRotation_180", "VideoToolbox")]
		internal unsafe static IntPtr kVTRotation_180 {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.VideoToolbox.Handle, "kVTRotation_180", storage);
			}
		}
		[Field ("kVTRotation_CCW90", "VideoToolbox")]
		internal unsafe static IntPtr kVTRotation_CCW90 {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.VideoToolbox.Handle, "kVTRotation_CCW90", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this VTRotation self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // VTRotation.Zero
			default:
				ptr = kVTRotation_0;
				break;
			case 1: // VTRotation.ClockwiseNinety
				ptr = kVTRotation_CW90;
				break;
			case 2: // VTRotation.OneHundredAndEighty
				ptr = kVTRotation_180;
				break;
			case 3: // VTRotation.CounterclockwiseNinety
				ptr = kVTRotation_CCW90;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::VideoToolbox.VTRotation" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static VTRotation GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kVTRotation_0))
				return VTRotation.Zero;
			if (constant.IsEqualTo (kVTRotation_CW90))
				return VTRotation.ClockwiseNinety;
			if (constant.IsEqualTo (kVTRotation_180))
				return VTRotation.OneHundredAndEighty;
			if (constant.IsEqualTo (kVTRotation_CCW90))
				return VTRotation.CounterclockwiseNinety;
			return VTRotation.Zero;
		}
		/// <summary>Retrieves the <see cref="global::VideoToolbox.VTRotation" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VTRotation GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::VideoToolbox.VTRotation" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VTRotation? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::VideoToolbox.VTRotation" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this VTRotation[]? values)
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
		internal static VTRotation[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<VTRotation> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
