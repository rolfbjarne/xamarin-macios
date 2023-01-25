//
// BindAs.cs: Helper code for BindAs support.
//
// Authors:
//   Rolf Bjarne Kvinge
//
// Copyright 2023 Microsoft Corp


// #define TRACE

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
	// This class contains helper methods for the static registrar.
	static class RegistrarHelper {
		static IntPtr GetBlockForDelegate (object @delegate, RuntimeMethodHandle method_handle)
		{
			var method = (MethodInfo) MethodBase.GetMethodFromHandle (method_handle)!;
			return BlockLiteral.GetBlockForDelegate (method, @delegate, Runtime.INVALID_TOKEN_REF, null);
		}

		unsafe static IntPtr GetBlockPointer (BlockLiteral block)
		{
			var rv = BlockLiteral._Block_copy (&block);
			block.Dispose ();
			return rv;
		}

		static NativeHandle ManagedArrayToNSArray (object array, bool retain)
		{
			if (array is null)
				return NativeHandle.Zero;

			NSObject rv;
			if (array is NSObject[] nsobjs) {
				rv = NSArray.FromNSObjects (nsobjs);
			} else if (array is INativeObject[] inativeobjs) {
				rv = NSArray.FromNSObjects (inativeobjs);
			} else {
				throw new InvalidOperationException ($"Can't convert {array.GetType ()} to an NSArray."); // FIXME: better error
			}

			if (retain)
				return Runtime.RetainNSObject (rv);
			return Runtime.RetainAndAutoreleaseNSObject (rv);
		}

		unsafe static void NSArray_string_native_to_managed (IntPtr* ptr, ref string[]? value, ref string[]? copy)
		{
			if (ptr is not null) {
				value = NSArray.StringArrayFromHandle (*ptr);
			} else {
				value = null;
			}
			copy = value;
		}

		unsafe static void NSArray_string_managed_to_native (IntPtr* ptr, string[] value, string[] copy, bool isOut)
		{
			if (ptr is null)
				return;

			// Note that we won't notice if individual array elements change, only if the array itself changes
			if (!isOut && (object) value == (object) copy) {
#if TRACE
				Runtime.NSLog ($"NSArray_string_managed_to_native (0x{(*ptr).ToString ("x")}, equal)");
#endif
				return;
			}
			if (value is null) {
#if TRACE
				Runtime.NSLog ($"NSArray_string_managed_to_native (0x{(*ptr).ToString ("x")}, null, !null)");
#endif
				*ptr = IntPtr.Zero;
				return;
			}
			IntPtr rv = Runtime.RetainAndAutoreleaseNSObject (NSArray.FromStrings (value));
#if TRACE
			Runtime.NSLog ($"NSArray_string_managed_to_native (0x{(*ptr).ToString ("x")}, value != copy: {value?.Length} != {copy?.Length}): 0x{rv.ToString ("x")} => {value?.GetType ()}");
#endif
			*ptr = rv;
		}

		unsafe static void NSArray_native_to_managed<T> (IntPtr* ptr, ref T[]? value, ref T[]? copy) where T: class, INativeObject
		{
			if (ptr is not null) {
				value = NSArray.ArrayFromHandle<T> (*ptr);
			} else {
				value = null;
			}
			copy = value;
		}

		unsafe static void NSArray_managed_to_native<T> (IntPtr* ptr, T[] value, T[] copy, bool isOut) where T: class, INativeObject
		{
			if (ptr is null) {
#if TRACE
				Runtime.NSLog ($"NSArray_managed_to_native (NULL, ?, ?)");
#endif
				return;
			}
			// Note that we won't notice if individual array elements change, only if the array itself changes
			if (!isOut && (object) value == (object) copy) {
#if TRACE
				Runtime.NSLog ($"NSArray_managed_to_native (0x{(*ptr).ToString ("x")}, equal)");
#endif
				return;
			}
			if (value is null) {
#if TRACE
				Runtime.NSLog ($"NSArray_managed_to_native (0x{(*ptr).ToString ("x")}, null, !null)");
#endif
				*ptr = IntPtr.Zero;
				return;
			}
			IntPtr rv = Runtime.RetainAndAutoreleaseNSObject (NSArray.FromNSObjects<T> (value));
#if TRACE
			Runtime.NSLog ($"NSArray_managed_to_native (0x{(*ptr).ToString ("x")}, value != copy: {value?.Length} != {copy?.Length}): 0x{rv.ToString ("x")} => {value?.GetType ()}");
#endif
			*ptr = rv;
		}

		unsafe static void NSObject_native_to_managed<T> (IntPtr* ptr, ref T? value, ref T? copy) where T: NSObject
		{
			if (ptr is not null) {
				value = Runtime.GetNSObject<T> (*ptr, owns: false);
			} else {
				value = null;
			}
			copy = value;
		}

		unsafe static void NSObject_managed_to_native (IntPtr* ptr, NSObject value, NSObject copy, bool isOut)
		{
			if (ptr is null) {
#if TRACE
				Runtime.NSLog ($"NSObject_managed_to_native (NULL, ?, ?)");
#endif
				return;
			}
			if (!isOut && (object) value == (object) copy) {
#if TRACE
				Runtime.NSLog ($"NSObject_managed_to_native (0x{(*ptr).ToString ("x")}, equal)");
#endif
				return;
			}
			IntPtr rv = Runtime.RetainAndAutoreleaseNSObject (value);
#if TRACE
			Runtime.NSLog ($"NSObject_managed_to_native (0x{(*ptr).ToString ("x")}, ? != ?): 0x{rv.ToString ("x")} => {value?.GetType ()}");
#endif
			*ptr = rv;
		}

		unsafe static void string_native_to_managed (NativeHandle *ptr, ref string? value, ref string? copy)
		{
			if (ptr is not null) {
				value = CFString.FromHandle (*ptr);
			} else {
				value = null;
			}
			copy = value;
		}

		unsafe static void string_managed_to_native (NativeHandle *ptr, string value, string copy, bool isOut)
		{
			if (ptr is null) {
#if TRACE
				Runtime.NSLog ($"string_managed_to_native (NULL, ?, ?)");
#endif
				return;
			}
			if (!isOut && (object) value == (object) copy) {
#if TRACE
				Runtime.NSLog ($"string_managed_to_native (0x{(*ptr).ToString ()}, equal)");
#endif
				return;
			}
			var rv = CFString.CreateNative (value);
#if TRACE
			Runtime.NSLog ($"string_managed_to_native (0x{(*ptr).ToString ()}, ? != ?): 0x{rv.ToString ()} => {value}");
#endif
			*ptr = rv;
		}

		unsafe static void INativeObject_native_to_managed<T> (IntPtr* ptr, ref T? value, ref T? copy, RuntimeTypeHandle implementationType) where T: class, INativeObject
		{
			if (ptr is not null) {
				value = Runtime.GetINativeObject<T> (*ptr, implementation: Type.GetTypeFromHandle (implementationType), forced_type: false, owns: false);
			} else {
				value = null;
			}
			copy = value;
		}

		unsafe static void INativeObject_managed_to_native (IntPtr *ptr, INativeObject value, INativeObject copy, bool isOut)
		{
			if (ptr is null) {
#if TRACE
				Runtime.NSLog ($"INativeObject_managed_to_native (NULL, ?, ?)");
#endif
				return;
			}
			if (!isOut && (object) value == (object) copy) {
#if TRACE
				Runtime.NSLog ($"INativeObject_managed_to_native (0x{(*ptr).ToString ("x")}, equal)");
#endif
				return;
			}
			IntPtr rv = value.GetHandle ();
#if TRACE
			Runtime.NSLog ($"INativeObject_managed_to_native (0x{(*ptr).ToString ("x")}, ? != ?): 0x{rv.ToString ("x")} => {value?.GetType ()}");
#endif
			*ptr = rv;
		}
	}
}

#endif // NET
