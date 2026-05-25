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
namespace CoreMedia {
	public enum CMFormatDescriptionFieldDetail : int {
		TemporalTopFirst = 0,
		TemporalBottomFirst = 1,
		SpatialFirstLineEarly = 2,
		SpatialFirstLineLate = 3,
	}
	/// <summary>Extension methods for the <see cref="global::CoreMedia.CMFormatDescriptionFieldDetail" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CMFormatDescriptionFieldDetailExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("kCMFormatDescriptionFieldDetail_TemporalTopFirst", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionFieldDetail_TemporalTopFirst {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionFieldDetail_TemporalTopFirst", storage);
			}
		}
		[Field ("kCMFormatDescriptionFieldDetail_TemporalBottomFirst", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionFieldDetail_TemporalBottomFirst {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionFieldDetail_TemporalBottomFirst", storage);
			}
		}
		[Field ("kCMFormatDescriptionFieldDetail_SpatialFirstLineEarly", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionFieldDetail_SpatialFirstLineEarly {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionFieldDetail_SpatialFirstLineEarly", storage);
			}
		}
		[Field ("kCMFormatDescriptionFieldDetail_SpatialFirstLineLate", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionFieldDetail_SpatialFirstLineLate {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionFieldDetail_SpatialFirstLineLate", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CMFormatDescriptionFieldDetail self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CMFormatDescriptionFieldDetail.TemporalTopFirst
				ptr = kCMFormatDescriptionFieldDetail_TemporalTopFirst;
				break;
			case 1: // CMFormatDescriptionFieldDetail.TemporalBottomFirst
				ptr = kCMFormatDescriptionFieldDetail_TemporalBottomFirst;
				break;
			case 2: // CMFormatDescriptionFieldDetail.SpatialFirstLineEarly
				ptr = kCMFormatDescriptionFieldDetail_SpatialFirstLineEarly;
				break;
			case 3: // CMFormatDescriptionFieldDetail.SpatialFirstLineLate
				ptr = kCMFormatDescriptionFieldDetail_SpatialFirstLineLate;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionFieldDetail" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CMFormatDescriptionFieldDetail GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCMFormatDescriptionFieldDetail_TemporalTopFirst))
				return CMFormatDescriptionFieldDetail.TemporalTopFirst;
			if (constant.IsEqualTo (kCMFormatDescriptionFieldDetail_TemporalBottomFirst))
				return CMFormatDescriptionFieldDetail.TemporalBottomFirst;
			if (constant.IsEqualTo (kCMFormatDescriptionFieldDetail_SpatialFirstLineEarly))
				return CMFormatDescriptionFieldDetail.SpatialFirstLineEarly;
			if (constant.IsEqualTo (kCMFormatDescriptionFieldDetail_SpatialFirstLineLate))
				return CMFormatDescriptionFieldDetail.SpatialFirstLineLate;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionFieldDetail" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionFieldDetail GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionFieldDetail" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionFieldDetail? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreMedia.CMFormatDescriptionFieldDetail" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CMFormatDescriptionFieldDetail[]? values)
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
		internal static CMFormatDescriptionFieldDetail[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CMFormatDescriptionFieldDetail> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
