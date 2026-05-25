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
namespace CoreVideo {
	public enum CVPixelFormatComponentRangeValues : int {
		VideoRange = 0,
		FullRange = 1,
		WideRange = 2,
	}
	/// <summary>Extension methods for the <see cref="global::CoreVideo.CVPixelFormatComponentRangeValues" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CVPixelFormatComponentRangeValuesExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("kCVPixelFormatComponentRange_VideoRange", "CoreVideo")]
		internal unsafe static IntPtr kCVPixelFormatComponentRange_VideoRange {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVPixelFormatComponentRange_VideoRange", storage);
			}
		}
		[Field ("kCVPixelFormatComponentRange_FullRange", "CoreVideo")]
		internal unsafe static IntPtr kCVPixelFormatComponentRange_FullRange {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVPixelFormatComponentRange_FullRange", storage);
			}
		}
		[Field ("kCVPixelFormatComponentRange_WideRange", "CoreVideo")]
		internal unsafe static IntPtr kCVPixelFormatComponentRange_WideRange {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVPixelFormatComponentRange_WideRange", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CVPixelFormatComponentRangeValues self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CVPixelFormatComponentRangeValues.VideoRange
				ptr = kCVPixelFormatComponentRange_VideoRange;
				break;
			case 1: // CVPixelFormatComponentRangeValues.FullRange
				ptr = kCVPixelFormatComponentRange_FullRange;
				break;
			case 2: // CVPixelFormatComponentRangeValues.WideRange
				ptr = kCVPixelFormatComponentRange_WideRange;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreVideo.CVPixelFormatComponentRangeValues" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CVPixelFormatComponentRangeValues GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCVPixelFormatComponentRange_VideoRange))
				return CVPixelFormatComponentRangeValues.VideoRange;
			if (constant.IsEqualTo (kCVPixelFormatComponentRange_FullRange))
				return CVPixelFormatComponentRangeValues.FullRange;
			if (constant.IsEqualTo (kCVPixelFormatComponentRange_WideRange))
				return CVPixelFormatComponentRangeValues.WideRange;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreVideo.CVPixelFormatComponentRangeValues" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CVPixelFormatComponentRangeValues GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreVideo.CVPixelFormatComponentRangeValues" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CVPixelFormatComponentRangeValues? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreVideo.CVPixelFormatComponentRangeValues" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CVPixelFormatComponentRangeValues[]? values)
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
		internal static CVPixelFormatComponentRangeValues[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CVPixelFormatComponentRangeValues> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
