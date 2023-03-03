//
// BindAs.cs: Helper code for BindAs support.
//
// Authors:
//   Rolf Bjarne Kvinge
//
// Copyright 2023 Microsoft Corp

#if NET

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

using CoreFoundation;
using CoreGraphics;
using Foundation;

using Registrar;

namespace ObjCRuntime {
	static class RegistrarHelper {
		// registrar helpers
		unsafe static void NSArray_native_to_managed<T> (IntPtr* ptr, ref T[]? value, ref T[]? copy) where T: class, INativeObject
		{
			if (ptr != null) {
				value = NSArray.ArrayFromHandle<T> (*ptr);
			} else {
				value = null;
			}
			copy = value;
		}

		unsafe static void NSArray_managed_to_native<T> (IntPtr* ptr, T[] value, T[] copy, bool isOut) where T: class, INativeObject
		{
			if (ptr == null) {
				Runtime.NSLog ($"NSArray_managed_to_native (NULL, ?, ?)");
				return;
			}
			// Note that we won't notice if individual array elements change, only if the array itself changes
			if (!isOut && (object) value == (object) copy) {
				Runtime.NSLog ($"NSArray_managed_to_native (0x{(*ptr).ToString ("x")}, ? == ?)");
				return;
			}
			IntPtr rv = Runtime.RetainAndAutorelease (NSArray.FromNSObjects<T> (value));
			Runtime.NSLog ($"NSArray_managed_to_native (0x{(*ptr).ToString ("x")}, ? != ?): 0x{rv.ToString ("x")} => {value?.GetType ()}");
			*ptr = rv;
		}

		unsafe static void NSObject_native_to_managed<T> (IntPtr* ptr, ref T? value, ref T? copy) where T: NSObject
		{
			if (ptr != null) {
				value = Runtime.GetNSObject<T> (*ptr, owns: false);
			} else {
				value = null;
			}
			copy = value;
		}

		unsafe static void NSObject_managed_to_native (IntPtr* ptr, NSObject value, NSObject copy, bool isOut)
		{
			if (ptr == null) {
				Runtime.NSLog ($"NSObject_managed_to_native (NULL, ?, ?)");
				return;
			}
			if (!isOut && (object) value == (object) copy) {
				Runtime.NSLog ($"NSObject_managed_to_native (0x{(*ptr).ToString ("x")}, ? == ?)");
				return;
			}
			IntPtr rv = Runtime.RetainAndAutorelease (value);
			Runtime.NSLog ($"NSObject_managed_to_native (0x{(*ptr).ToString ("x")}, ? != ?): 0x{rv.ToString ("x")} => {value?.GetType ()}");
			*ptr = rv;
		}

		unsafe static void string_native_to_managed (NativeHandle *ptr, ref string? value, ref string? copy)
		{
			if (ptr != null) {
				value = CFString.FromHandle (*ptr);
			} else {
				value = null;
			}
			copy = value;
		}

		unsafe static void string_managed_to_native (NativeHandle *ptr, string value, string copy, bool isOut)
		{
			if (ptr == null) {
				Runtime.NSLog ($"string_managed_to_native (NULL, ?, ?)");
				return;
			}
			if (!isOut && (object) value == (object) copy) {
				Runtime.NSLog ($"string_managed_to_native (0x{(*ptr).ToString ()}, ? == ?)");
				return;
			}
			var rv = CFString.CreateNative (value);
			Runtime.NSLog ($"string_managed_to_native (0x{(*ptr).ToString ()}, ? != ?): 0x{rv.ToString ()} => {value}");
			*ptr = rv;
		}

		unsafe static void INativeObject_native_to_managed<T> (IntPtr* ptr, ref T? value, ref T? copy, RuntimeTypeHandle implementationType) where T: class, INativeObject
		{
			if (ptr != null) {
				value = Runtime.GetINativeObject<T> (*ptr, implementation: Type.GetTypeFromHandle (implementationType), forced_type: false, owns: false);
			} else {
				value = null;
			}
			copy = value;
		}

		unsafe static void INativeObject_managed_to_native (IntPtr *ptr, INativeObject value, INativeObject copy, bool isOut)
		{
			if (ptr == null) {
				Runtime.NSLog ($"INativeObject_managed_to_native (NULL, ?, ?)");
				return;
			}
			if (!isOut && (object) value == (object) copy) {
				Runtime.NSLog ($"INativeObject_managed_to_native (0x{(*ptr).ToString ("x")}, ? == ?)");
				return;
			}
			IntPtr rv = value.GetHandle ();
			Runtime.NSLog ($"INativeObject_managed_to_native (0x{(*ptr).ToString ("x")}, ? != ?): 0x{rv.ToString ("x")} => {value?.GetType ()}");
			*ptr = rv;
		}
	}

	static class BindAs {
		// xamarin_convert_nsarray_to_managed_with_func
		static T Identity<T> (T obj)
		{
			return obj;
		}

		internal unsafe static T[]? ConvertNSArrayToManagedArray<T> (IntPtr nsarray, delegate*<IntPtr, T> convert) where T: struct
		{
			if (nsarray == IntPtr.Zero)
				return null;

			return ConvertNSArrayToManagedArray2<T, T> (nsarray, convert, &Identity<T>);
		}

		internal unsafe static IntPtr ConvertManagedArrayToNSArray<T> (T[]? array, delegate*<T, IntPtr> convert) where T: struct
		{
			if (array is null)
				return IntPtr.Zero;

			return ConvertManagedArrayToNSArray2<T, T> (array, &Identity<T>, convert);
		}

		internal unsafe static T[]? ConvertNSArrayToManagedArray2<T,U> (IntPtr nsarray, delegate*<IntPtr, U> convert1, delegate*<U, T> convert2) where T: struct
		{
			if (nsarray == IntPtr.Zero)
				return null;

			return NSArray.ArrayFromHandleFunc<T> (nsarray, (	ptr) => convert2 (convert1 (ptr)));
		}

		internal unsafe static IntPtr ConvertManagedArrayToNSArray2<T,U> (T[]? array, delegate*<T, U> convert1, delegate*<U, IntPtr> convert2) where T: struct
		{
			if (array is null)
				return IntPtr.Zero;

			NSArray arr;
			var count = array.Length;
			if (count == 0) {
				arr = new NSArray ();
			} else {
				var ptrs = new IntPtr [count];
				for (nint i = 0; i < count; i++) {
					var item = convert2 (convert1 (array [i]));
					if (item == IntPtr.Zero)
						item = NSNull.Null.Handle;
					ptrs [i] = item;
				}
				fixed (void* ptr = &ptrs[0]) {
					arr = Runtime.GetNSObject<NSArray> (NSArray.FromObjects ((IntPtr) ptr, count))!;
				}
			}

			arr.DangerousRetain ();
			arr.DangerousAutorelease ();
			var rv = arr.Handle;
			arr.Dispose ();
			return rv;
		}

		internal unsafe static T? CreateNullable<T> (IntPtr handle, delegate*<IntPtr, T> convert) where T: struct
		{
			if (handle == IntPtr.Zero)
				return null;
			return convert (handle);
		}

		internal unsafe static T? CreateNullable2<T, U> (IntPtr handle, delegate*<IntPtr, U> convert1, delegate*<U, T> convert2) where T: struct
		{
			if (handle == IntPtr.Zero)
				return null;
			return convert2 (convert1 (handle));
		}

		// FIXME: create helper functions that don't need a managed wrapper.
		internal static Foundation.NSRange xamarin_nsvalue_to_nsrange (IntPtr value) { if (value == IntPtr.Zero) return default (Foundation.NSRange); return Runtime.GetNSObject<NSValue> (value)?.RangeValue ?? default (Foundation.NSRange); }
		internal static CoreGraphics.CGAffineTransform xamarin_nsvalue_to_cgaffinetransform (IntPtr value) { if (value == IntPtr.Zero) return default (CoreGraphics.CGAffineTransform); return Runtime.GetNSObject<NSValue> (value)?.CGAffineTransformValue ?? default (CoreGraphics.CGAffineTransform); }
		internal static CoreGraphics.CGPoint xamarin_nsvalue_to_cgpoint (IntPtr value) { if (value == IntPtr.Zero) return default (CoreGraphics.CGPoint); return Runtime.GetNSObject<NSValue> (value)?.CGPointValue ?? default (CoreGraphics.CGPoint); }
		internal static CoreGraphics.CGRect xamarin_nsvalue_to_cgrect (IntPtr value) { if (value == IntPtr.Zero) return default (CoreGraphics.CGRect); return Runtime.GetNSObject<NSValue> (value)?.CGRectValue ?? default (CoreGraphics.CGRect); }
		internal static CoreGraphics.CGSize xamarin_nsvalue_to_cgsize (IntPtr value) { if (value == IntPtr.Zero) return default (CoreGraphics.CGSize); return Runtime.GetNSObject<NSValue> (value)?.CGSizeValue ?? default (CoreGraphics.CGSize); }
#if !__MACOS__
		internal static CoreGraphics.CGVector xamarin_nsvalue_to_cgvector (IntPtr value) { if (value == IntPtr.Zero) return default (CoreGraphics.CGVector); return Runtime.GetNSObject<NSValue> (value)?.CGVectorValue ?? default (CoreGraphics.CGVector); }
#endif
		internal static CoreAnimation.CATransform3D xamarin_nsvalue_to_catransform3d (IntPtr value) { if (value == IntPtr.Zero) return default (CoreAnimation.CATransform3D); return Runtime.GetNSObject<NSValue> (value)?.CATransform3DValue ?? default (CoreAnimation.CATransform3D); }
		internal static CoreLocation.CLLocationCoordinate2D xamarin_nsvalue_to_cllocationcoordinate2d (IntPtr value) { if (value == IntPtr.Zero) return default (CoreLocation.CLLocationCoordinate2D); return Runtime.GetNSObject<NSValue> (value)?.CoordinateValue ?? default (CoreLocation.CLLocationCoordinate2D); }
		internal static CoreMedia.CMTime xamarin_nsvalue_to_cmtime (IntPtr value) { if (value == IntPtr.Zero) return default (CoreMedia.CMTime); return Runtime.GetNSObject<NSValue> (value)?.CMTimeValue ?? default (CoreMedia.CMTime); }
		internal static CoreMedia.CMTimeMapping xamarin_nsvalue_to_cmtimemapping (IntPtr value) { if (value == IntPtr.Zero) return default (CoreMedia.CMTimeMapping); return Runtime.GetNSObject<NSValue> (value)?.CMTimeMappingValue ?? default (CoreMedia.CMTimeMapping); }
		internal static CoreMedia.CMTimeRange xamarin_nsvalue_to_cmtimerange (IntPtr value) { if (value == IntPtr.Zero) return default (CoreMedia.CMTimeRange); return Runtime.GetNSObject<NSValue> (value)?.CMTimeRangeValue ?? default (CoreMedia.CMTimeRange); }
		internal static CoreMedia.CMVideoDimensions xamarin_nsvalue_to_cmvideodimensions (IntPtr value) { if (value == IntPtr.Zero) return default (CoreMedia.CMVideoDimensions); return Runtime.GetNSObject<NSValue> (value)?.CMVideoDimensionsValue ?? default (CoreMedia.CMVideoDimensions); }
		internal static MapKit.MKCoordinateSpan xamarin_nsvalue_to_mkcoordinatespan (IntPtr value) { if (value == IntPtr.Zero) return default (MapKit.MKCoordinateSpan); return Runtime.GetNSObject<NSValue> (value)?.CoordinateSpanValue ?? default (MapKit.MKCoordinateSpan); }
		internal static SceneKit.SCNMatrix4 xamarin_nsvalue_to_scnmatrix4 (IntPtr value) { if (value == IntPtr.Zero) return default (SceneKit.SCNMatrix4); return Runtime.GetNSObject<NSValue> (value)?.SCNMatrix4Value ?? default (SceneKit.SCNMatrix4); }
		internal static SceneKit.SCNVector3 xamarin_nsvalue_to_scnvector3 (IntPtr value) { if (value == IntPtr.Zero) return default (SceneKit.SCNVector3); return Runtime.GetNSObject<NSValue> (value)?.Vector3Value ?? default (SceneKit.SCNVector3); }
		internal static SceneKit.SCNVector4 xamarin_nsvalue_to_scnvector4 (IntPtr value) { if (value == IntPtr.Zero) return default (SceneKit.SCNVector4); return Runtime.GetNSObject<NSValue> (value)?.Vector4Value ?? default (SceneKit.SCNVector4); }
#if HAS_UIKIT
		internal static UIKit.UIEdgeInsets xamarin_nsvalue_to_uiedgeinsets (IntPtr value) { if (value == IntPtr.Zero) return default (UIKit.UIEdgeInsets); return Runtime.GetNSObject<NSValue> (value)?.UIEdgeInsetsValue ?? default (UIKit.UIEdgeInsets); }
		internal static UIKit.UIOffset xamarin_nsvalue_to_uioffset (IntPtr value) { if (value == IntPtr.Zero) return default (UIKit.UIOffset); return Runtime.GetNSObject<NSValue> (value)?.UIOffsetValue ?? default (UIKit.UIOffset); }
		internal static UIKit.NSDirectionalEdgeInsets xamarin_nsvalue_to_nsdirectionaledgeinsets (IntPtr value) { if (value == IntPtr.Zero) return default (UIKit.NSDirectionalEdgeInsets); return Runtime.GetNSObject<NSValue> (value)?.DirectionalEdgeInsetsValue ?? default (UIKit.NSDirectionalEdgeInsets); }
#endif

		// FIXME: create helper functions that don't need a managed wrapper.
		internal static IntPtr xamarin_nsrange_to_nsvalue (Foundation.NSRange value) { using var rv = NSValue.FromRange (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
		internal static IntPtr xamarin_cgaffinetransform_to_nsvalue (CoreGraphics.CGAffineTransform value) { using var rv = NSValue.FromCGAffineTransform (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
		internal static IntPtr xamarin_cgpoint_to_nsvalue (CoreGraphics.CGPoint value) { using var rv = NSValue.FromCGPoint (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
		internal static IntPtr xamarin_cgrect_to_nsvalue (CoreGraphics.CGRect value) { using var rv = NSValue.FromCGRect (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
		internal static IntPtr xamarin_cgsize_to_nsvalue (CoreGraphics.CGSize value) { using var rv = NSValue.FromCGSize (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
#if !__MACOS__
		internal static IntPtr xamarin_cgvector_to_nsvalue (CoreGraphics.CGVector value) { using var rv = NSValue.FromCGVector (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
#endif
		internal static IntPtr xamarin_catransform3d_to_nsvalue (CoreAnimation.CATransform3D value) { using var rv = NSValue.FromCATransform3D (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
		internal static IntPtr xamarin_cllocationcoordinate2d_to_nsvalue (CoreLocation.CLLocationCoordinate2D value) { using var rv = NSValue.FromMKCoordinate (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
		internal static IntPtr xamarin_cmtime_to_nsvalue (CoreMedia.CMTime value) { using var rv = NSValue.FromCMTime (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
		internal static IntPtr xamarin_cmtimemapping_to_nsvalue (CoreMedia.CMTimeMapping value) { using var rv = NSValue.FromCMTimeMapping (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
		internal static IntPtr xamarin_cmtimerange_to_nsvalue (CoreMedia.CMTimeRange value) { using var rv = NSValue.FromCMTimeRange (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
		internal static IntPtr xamarin_cmvideodimensions_to_nsvalue (CoreMedia.CMVideoDimensions value) { using var rv = NSValue.FromCMVideoDimensions (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
		internal static IntPtr xamarin_mkcoordinatespan_to_nsvalue (MapKit.MKCoordinateSpan value) { using var rv = NSValue.FromMKCoordinateSpan (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
		internal static IntPtr xamarin_scnmatrix4_to_nsvalue (SceneKit.SCNMatrix4 value) { using var rv = NSValue.FromSCNMatrix4 (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
		internal static IntPtr xamarin_scnvector3_to_nsvalue (SceneKit.SCNVector3 value) { using var rv = NSValue.FromVector (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
		internal static IntPtr xamarin_scnvector4_to_nsvalue (SceneKit.SCNVector4 value) { using var rv = NSValue.FromVector (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
#if HAS_UIKIT
		internal static IntPtr xamarin_uiedgeinsets_to_nsvalue (UIKit.UIEdgeInsets value) { using var rv = NSValue.FromUIEdgeInsets (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
		internal static IntPtr xamarin_uioffset_to_nsvalue (UIKit.UIOffset value) { using var rv = NSValue.FromUIOffset (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
		internal static IntPtr xamarin_nsdirectionaledgeinsets_to_nsvalue (UIKit.NSDirectionalEdgeInsets value) { using var rv = NSValue.FromDirectionalEdgeInsets (value); rv.DangerousRetain ().DangerousAutorelease (); return rv.Handle; }
#endif

		// FIXME: create helper functions that don't need a managed wrapper.
		public static System.SByte xamarin_nsnumber_to_sbyte (IntPtr value) { if (value == IntPtr.Zero) return default (System.SByte); return Runtime.GetNSObject<NSNumber> (value)?.SByteValue ?? default (System.SByte); }
		public static System.Byte xamarin_nsnumber_to_byte (IntPtr value) { if (value == IntPtr.Zero) return default (System.Byte); return Runtime.GetNSObject<NSNumber> (value)?.ByteValue ?? default (System.Byte); }
		public static System.Int16 xamarin_nsnumber_to_short (IntPtr value) { if (value == IntPtr.Zero) return default (System.Int16); return Runtime.GetNSObject<NSNumber> (value)?.Int16Value ?? default (System.Int16); }
		public static System.UInt16 xamarin_nsnumber_to_ushort (IntPtr value) { if (value == IntPtr.Zero) return default (System.UInt16); return Runtime.GetNSObject<NSNumber> (value)?.UInt16Value ?? default (System.UInt16); }
		public static System.Int32 xamarin_nsnumber_to_int (IntPtr value) { if (value == IntPtr.Zero) return default (System.Int32); return Runtime.GetNSObject<NSNumber> (value)?.Int32Value ?? default (System.Int32); }
		public static System.UInt32 xamarin_nsnumber_to_uint (IntPtr value) { if (value == IntPtr.Zero) return default (System.UInt32); return Runtime.GetNSObject<NSNumber> (value)?.UInt32Value ?? default (System.UInt32); }
		public static System.Int64 xamarin_nsnumber_to_long (IntPtr value) { if (value == IntPtr.Zero) return default (System.Int64); return Runtime.GetNSObject<NSNumber> (value)?.Int64Value ?? default (System.Int64); }
		public static System.UInt64 xamarin_nsnumber_to_ulong (IntPtr value) { if (value == IntPtr.Zero) return default (System.UInt64); return Runtime.GetNSObject<NSNumber> (value)?.UInt64Value ?? default (System.UInt64); }
		public static nint xamarin_nsnumber_to_nint (IntPtr value) { if (value == IntPtr.Zero) return default (nint); return Runtime.GetNSObject<NSNumber> (value)?.NIntValue ?? default (nint); }
		public static nuint xamarin_nsnumber_to_nuint (IntPtr value) { if (value == IntPtr.Zero) return default (nuint); return Runtime.GetNSObject<NSNumber> (value)?.NUIntValue ?? default (nuint); }
		public static System.Single xamarin_nsnumber_to_float (IntPtr value) { if (value == IntPtr.Zero) return default (System.Single); return Runtime.GetNSObject<NSNumber> (value)?.FloatValue ?? default (System.Single); }
		public static System.Double xamarin_nsnumber_to_double (IntPtr value) { if (value == IntPtr.Zero) return default (System.Double); return Runtime.GetNSObject<NSNumber> (value)?.DoubleValue ?? default (System.Double); }
		public static System.Boolean xamarin_nsnumber_to_bool (IntPtr value) { if (value == IntPtr.Zero) return default (System.Boolean); return Runtime.GetNSObject<NSNumber> (value)?.BoolValue ?? default (System.Boolean); }
		public static nfloat xamarin_nsnumber_to_nfloat (IntPtr value)
		{
			if (value == IntPtr.Zero)
				return default (nfloat);
			var number = Runtime.GetNSObject<NSNumber> (value);
			if (number is null)
				return default (nfloat);
			if (IntPtr.Size == 4)
				return (nfloat) number.FloatValue;
			return (nfloat) number.DoubleValue;
		}

		// FIXME: create helper functions that don't need a managed wrapper.
		public static System.SByte? xamarin_nsnumber_to_nullable_sbyte (IntPtr value) { return Runtime.GetNSObject<NSNumber> (value)?.SByteValue ?? null; }
		public static System.Byte? xamarin_nsnumber_to_nullable_byte (IntPtr value) { return Runtime.GetNSObject<NSNumber> (value)?.ByteValue ?? null; }
		public static System.Int16? xamarin_nsnumber_to_nullable_short (IntPtr value) { return Runtime.GetNSObject<NSNumber> (value)?.Int16Value ?? null; }
		public static System.UInt16? xamarin_nsnumber_to_nullable_ushort (IntPtr value) { return Runtime.GetNSObject<NSNumber> (value)?.UInt16Value ?? null; }
		public static System.Int32? xamarin_nsnumber_to_nullable_int (IntPtr value) { return Runtime.GetNSObject<NSNumber> (value)?.Int32Value ?? null; }
		public static System.UInt32? xamarin_nsnumber_to_nullable_uint (IntPtr value) { return Runtime.GetNSObject<NSNumber> (value)?.UInt32Value ?? null; }
		public static System.Int64? xamarin_nsnumber_to_nullable_long (IntPtr value) { return Runtime.GetNSObject<NSNumber> (value)?.Int64Value ?? null; }
		public static System.UInt64? xamarin_nsnumber_to_nullable_ulong (IntPtr value) { return Runtime.GetNSObject<NSNumber> (value)?.UInt64Value ?? null; }
		public static nint? xamarin_nsnumber_to_nullable_nint (IntPtr value) { return Runtime.GetNSObject<NSNumber> (value)?.NIntValue ?? null; }
		public static nuint? xamarin_nsnumber_to_nullable_nuint (IntPtr value) { return Runtime.GetNSObject<NSNumber> (value)?.NUIntValue ?? null; }
		public static System.Single? xamarin_nsnumber_to_nullable_float (IntPtr value) { return Runtime.GetNSObject<NSNumber> (value)?.FloatValue ?? null; }
		public static System.Double? xamarin_nsnumber_to_nullable_double (IntPtr value) { return Runtime.GetNSObject<NSNumber> (value)?.DoubleValue ?? null; }
		public static System.Boolean? xamarin_nsnumber_to_nullable_bool (IntPtr value) { return Runtime.GetNSObject<NSNumber> (value)?.BoolValue ?? null; }
		public static nfloat? xamarin_nsnumber_to_nullable_nfloat (IntPtr value)
		{
			if (value == IntPtr.Zero)
				return null;
			var number = Runtime.GetNSObject<NSNumber> (value);
			if (number is null)
				return null;
			if (IntPtr.Size == 4)
				return (nfloat) number.FloatValue;
			return (nfloat) number.DoubleValue;
		}

		// FIXME: create helper functions that don't need a managed wrapper.
		public static IntPtr xamarin_sbyte_to_nsnumber (System.SByte value) { return NSNumber.FromSByte (value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_byte_to_nsnumber (System.Byte value) { return NSNumber.FromByte (value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_short_to_nsnumber (System.Int16 value) { return NSNumber.FromInt16 (value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_ushort_to_nsnumber (System.UInt16 value) { return NSNumber.FromUInt16 (value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_int_to_nsnumber (System.Int32 value) { return NSNumber.FromInt32 (value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_uint_to_nsnumber (System.UInt32 value) { return NSNumber.FromUInt32 (value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_long_to_nsnumber (System.Int64 value) { return NSNumber.FromInt64 (value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_ulong_to_nsnumber (System.UInt64 value) { return NSNumber.FromUInt64 (value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nint_to_nsnumber (nint value) { return NSNumber.FromNInt (value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nuint_to_nsnumber (nuint value) { return NSNumber.FromNUInt (value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_float_to_nsnumber (System.Single value) { return NSNumber.FromFloat (value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_double_to_nsnumber (System.Double value) { return NSNumber.FromDouble (value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_bool_to_nsnumber (System.Boolean value) { return NSNumber.FromBoolean (value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nfloat_to_nsnumber (nfloat value)
		{
			if (IntPtr.Size == 4)
				return NSNumber.FromFloat ((float) value).DangerousRetain ().DangerousAutorelease ().Handle;
			return NSNumber.FromDouble ((double) value).DangerousRetain ().DangerousAutorelease ().Handle;
		}

		// FIXME: create helper functions that don't need a managed wrapper.
		public static IntPtr xamarin_nullable_sbyte_to_nsnumber (System.SByte? value) { if (!value.HasValue) return IntPtr.Zero; return NSNumber.FromSByte (value.Value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nullable_byte_to_nsnumber (System.Byte? value) { if (!value.HasValue) return IntPtr.Zero; return NSNumber.FromByte (value.Value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nullable_short_to_nsnumber (System.Int16? value) { if (!value.HasValue) return IntPtr.Zero; return NSNumber.FromInt16 (value.Value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nullable_ushort_to_nsnumber (System.UInt16? value) { if (!value.HasValue) return IntPtr.Zero; return NSNumber.FromUInt16 (value.Value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nullable_int_to_nsnumber (System.Int32? value) { if (!value.HasValue) return IntPtr.Zero; return NSNumber.FromInt32 (value.Value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nullable_uint_to_nsnumber (System.UInt32? value) { if (!value.HasValue) return IntPtr.Zero; return NSNumber.FromUInt32 (value.Value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nullable_long_to_nsnumber (System.Int64? value) { if (!value.HasValue) return IntPtr.Zero; return NSNumber.FromInt64 (value.Value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nullable_ulong_to_nsnumber (System.UInt64? value) { if (!value.HasValue) return IntPtr.Zero; return NSNumber.FromUInt64 (value.Value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nullable_nint_to_nsnumber (nint? value) { if (!value.HasValue) return IntPtr.Zero; return NSNumber.FromNInt (value.Value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nullable_nuint_to_nsnumber (nuint? value) { if (!value.HasValue) return IntPtr.Zero; return NSNumber.FromNUInt (value.Value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nullable_float_to_nsnumber (System.Single? value) { if (!value.HasValue) return IntPtr.Zero; return NSNumber.FromFloat (value.Value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nullable_double_to_nsnumber (System.Double? value) { if (!value.HasValue) return IntPtr.Zero; return NSNumber.FromDouble (value.Value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nullable_bool_to_nsnumber (System.Boolean? value) { if (!value.HasValue) return IntPtr.Zero; return NSNumber.FromBoolean (value.Value).DangerousRetain ().DangerousAutorelease ().Handle; }
		public static IntPtr xamarin_nullable_nfloat_to_nsnumber (nfloat? value)
		{
			if (!value.HasValue)
				return IntPtr.Zero;
			if (IntPtr.Size == 4)
				return NSNumber.FromFloat ((float) value.Value).DangerousRetain ().DangerousAutorelease ().Handle;
			return NSNumber.FromDouble ((double) value.Value).DangerousRetain ().DangerousAutorelease ().Handle;
		}
	}
}

#endif // NET
