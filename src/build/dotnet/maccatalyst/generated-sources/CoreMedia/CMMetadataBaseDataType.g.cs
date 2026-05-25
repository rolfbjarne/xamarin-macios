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
namespace CoreMedia {
	public enum CMMetadataBaseDataType : int {
		RawData = 0,
		Utf8 = 1,
		Utf16 = 2,
		Gif = 3,
		Jpeg = 4,
		Png = 5,
		Bmp = 6,
		Float32 = 7,
		Float64 = 8,
		SInt8 = 9,
		SInt16 = 10,
		SInt32 = 11,
		SInt64 = 12,
		UInt8 = 13,
		UInt16 = 14,
		UInt32 = 15,
		UInt64 = 16,
		PointF32 = 17,
		DimensionsF32 = 18,
		RectF32 = 19,
		AffineTransformF64 = 20,
		PolygonF32 = 21,
		PolylineF32 = 22,
		Json = 23,
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		PerspectiveTransformF64 = 24,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		RasterRectangleValue = 25,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		ExtendedRasterRectangleValue = 26,
	}
	/// <summary>Extension methods for the <see cref="global::CoreMedia.CMMetadataBaseDataType" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CMMetadataBaseDataTypeExtensions {
		static IntPtr[] values = new IntPtr [27];
		[Field ("kCMMetadataBaseDataType_RawData", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_RawData {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_RawData", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_UTF8", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_UTF8 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_UTF8", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_UTF16", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_UTF16 {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_UTF16", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_GIF", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_GIF {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_GIF", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_JPEG", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_JPEG {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_JPEG", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_PNG", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_PNG {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_PNG", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_BMP", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_BMP {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_BMP", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_Float32", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_Float32 {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_Float32", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_Float64", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_Float64 {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_Float64", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_SInt8", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_SInt8 {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_SInt8", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_SInt16", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_SInt16 {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_SInt16", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_SInt32", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_SInt32 {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_SInt32", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_SInt64", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_SInt64 {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_SInt64", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_UInt8", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_UInt8 {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_UInt8", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_UInt16", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_UInt16 {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_UInt16", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_UInt32", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_UInt32 {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_UInt32", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_UInt64", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_UInt64 {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_UInt64", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_PointF32", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_PointF32 {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_PointF32", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_DimensionsF32", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_DimensionsF32 {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_DimensionsF32", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_RectF32", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_RectF32 {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_RectF32", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_AffineTransformF64", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_AffineTransformF64 {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_AffineTransformF64", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_PolygonF32", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_PolygonF32 {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_PolygonF32", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_PolylineF32", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_PolylineF32 {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_PolylineF32", storage);
			}
		}
		[Field ("kCMMetadataBaseDataType_JSON", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_JSON {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_JSON", storage);
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kCMMetadataBaseDataType_PerspectiveTransformF64", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_PerspectiveTransformF64 {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_PerspectiveTransformF64", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("kCMMetadataBaseDataType_RasterRectangleValue", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_RasterRectangleValue {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_RasterRectangleValue", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("kCMMetadataBaseDataType_ExtendedRasterRectangleValue", "CoreMedia")]
		internal unsafe static IntPtr kCMMetadataBaseDataType_ExtendedRasterRectangleValue {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMMetadataBaseDataType_ExtendedRasterRectangleValue", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CMMetadataBaseDataType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CMMetadataBaseDataType.RawData
				ptr = kCMMetadataBaseDataType_RawData;
				break;
			case 1: // CMMetadataBaseDataType.Utf8
				ptr = kCMMetadataBaseDataType_UTF8;
				break;
			case 2: // CMMetadataBaseDataType.Utf16
				ptr = kCMMetadataBaseDataType_UTF16;
				break;
			case 3: // CMMetadataBaseDataType.Gif
				ptr = kCMMetadataBaseDataType_GIF;
				break;
			case 4: // CMMetadataBaseDataType.Jpeg
				ptr = kCMMetadataBaseDataType_JPEG;
				break;
			case 5: // CMMetadataBaseDataType.Png
				ptr = kCMMetadataBaseDataType_PNG;
				break;
			case 6: // CMMetadataBaseDataType.Bmp
				ptr = kCMMetadataBaseDataType_BMP;
				break;
			case 7: // CMMetadataBaseDataType.Float32
				ptr = kCMMetadataBaseDataType_Float32;
				break;
			case 8: // CMMetadataBaseDataType.Float64
				ptr = kCMMetadataBaseDataType_Float64;
				break;
			case 9: // CMMetadataBaseDataType.SInt8
				ptr = kCMMetadataBaseDataType_SInt8;
				break;
			case 10: // CMMetadataBaseDataType.SInt16
				ptr = kCMMetadataBaseDataType_SInt16;
				break;
			case 11: // CMMetadataBaseDataType.SInt32
				ptr = kCMMetadataBaseDataType_SInt32;
				break;
			case 12: // CMMetadataBaseDataType.SInt64
				ptr = kCMMetadataBaseDataType_SInt64;
				break;
			case 13: // CMMetadataBaseDataType.UInt8
				ptr = kCMMetadataBaseDataType_UInt8;
				break;
			case 14: // CMMetadataBaseDataType.UInt16
				ptr = kCMMetadataBaseDataType_UInt16;
				break;
			case 15: // CMMetadataBaseDataType.UInt32
				ptr = kCMMetadataBaseDataType_UInt32;
				break;
			case 16: // CMMetadataBaseDataType.UInt64
				ptr = kCMMetadataBaseDataType_UInt64;
				break;
			case 17: // CMMetadataBaseDataType.PointF32
				ptr = kCMMetadataBaseDataType_PointF32;
				break;
			case 18: // CMMetadataBaseDataType.DimensionsF32
				ptr = kCMMetadataBaseDataType_DimensionsF32;
				break;
			case 19: // CMMetadataBaseDataType.RectF32
				ptr = kCMMetadataBaseDataType_RectF32;
				break;
			case 20: // CMMetadataBaseDataType.AffineTransformF64
				ptr = kCMMetadataBaseDataType_AffineTransformF64;
				break;
			case 21: // CMMetadataBaseDataType.PolygonF32
				ptr = kCMMetadataBaseDataType_PolygonF32;
				break;
			case 22: // CMMetadataBaseDataType.PolylineF32
				ptr = kCMMetadataBaseDataType_PolylineF32;
				break;
			case 23: // CMMetadataBaseDataType.Json
				ptr = kCMMetadataBaseDataType_JSON;
				break;
			case 24: // CMMetadataBaseDataType.PerspectiveTransformF64
				ptr = kCMMetadataBaseDataType_PerspectiveTransformF64;
				break;
			case 25: // CMMetadataBaseDataType.RasterRectangleValue
				ptr = kCMMetadataBaseDataType_RasterRectangleValue;
				break;
			case 26: // CMMetadataBaseDataType.ExtendedRasterRectangleValue
				ptr = kCMMetadataBaseDataType_ExtendedRasterRectangleValue;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMMetadataBaseDataType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CMMetadataBaseDataType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCMMetadataBaseDataType_RawData))
				return CMMetadataBaseDataType.RawData;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_UTF8))
				return CMMetadataBaseDataType.Utf8;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_UTF16))
				return CMMetadataBaseDataType.Utf16;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_GIF))
				return CMMetadataBaseDataType.Gif;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_JPEG))
				return CMMetadataBaseDataType.Jpeg;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_PNG))
				return CMMetadataBaseDataType.Png;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_BMP))
				return CMMetadataBaseDataType.Bmp;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_Float32))
				return CMMetadataBaseDataType.Float32;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_Float64))
				return CMMetadataBaseDataType.Float64;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_SInt8))
				return CMMetadataBaseDataType.SInt8;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_SInt16))
				return CMMetadataBaseDataType.SInt16;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_SInt32))
				return CMMetadataBaseDataType.SInt32;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_SInt64))
				return CMMetadataBaseDataType.SInt64;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_UInt8))
				return CMMetadataBaseDataType.UInt8;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_UInt16))
				return CMMetadataBaseDataType.UInt16;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_UInt32))
				return CMMetadataBaseDataType.UInt32;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_UInt64))
				return CMMetadataBaseDataType.UInt64;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_PointF32))
				return CMMetadataBaseDataType.PointF32;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_DimensionsF32))
				return CMMetadataBaseDataType.DimensionsF32;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_RectF32))
				return CMMetadataBaseDataType.RectF32;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_AffineTransformF64))
				return CMMetadataBaseDataType.AffineTransformF64;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_PolygonF32))
				return CMMetadataBaseDataType.PolygonF32;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_PolylineF32))
				return CMMetadataBaseDataType.PolylineF32;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_JSON))
				return CMMetadataBaseDataType.Json;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_PerspectiveTransformF64))
				return CMMetadataBaseDataType.PerspectiveTransformF64;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_RasterRectangleValue))
				return CMMetadataBaseDataType.RasterRectangleValue;
			if (constant.IsEqualTo (kCMMetadataBaseDataType_ExtendedRasterRectangleValue))
				return CMMetadataBaseDataType.ExtendedRasterRectangleValue;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMMetadataBaseDataType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMMetadataBaseDataType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMMetadataBaseDataType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMMetadataBaseDataType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreMedia.CMMetadataBaseDataType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CMMetadataBaseDataType[]? values)
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
		internal static CMMetadataBaseDataType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CMMetadataBaseDataType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
