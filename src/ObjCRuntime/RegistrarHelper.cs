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
	// This class contains helper methods for the managed static registrar.
	static class RegistrarHelper {
		static Dictionary<string, LookupMethod> lookup_method_map;
		static Dictionary<string, LookupType> lookup_type_map;

		delegate IntPtr LookupMethod (IntPtr symbol, int id);
		delegate Type LookupType (int id);

		internal static void Initialize ()
		{
			lookup_method_map = new Dictionary<string, LookupFunction> (StringEqualityComparer);
			lookup_type_map = new Dictionary<string, LookupFunction> (StringEqualityComparer);
		}

		[ThreadStatic]
		static Stopwatch? lookupWatch;

		static IntPtr LookupUnmanagedFunction (IntPtr assembly, IntPtr symbol, int id)
		{
			IntPtr rv;
			var symb = Marshal.PtrToStringAuto (symbol);

#if TRACE
			if (lookupWatch is null)
				lookupWatch = new Stopwatch ();

			lookupWatch.Start ();
			Console.WriteLine ("LookupUnmanagedFunction (0x{0} = {1}, 0x{2} = {3}, {4})", assembly.ToString ("x"), Marshal.PtrToStringAuto (assembly), symbol.ToString ("x"), symb, id);
#endif

			if (id == -1) {
				rv = IntPtr.Zero;
			} else if (assembly != IntPtr.Zero) {
				rv = LookupUnmanagedFunctionInAssembly (assembly, symbol, id);
			} else {
				rv = LookupManagedFunctionImpl (id);
			}

#if TRACE
			lookupWatch.Stop ();

			Console.WriteLine ("LookupUnmanagedFunction (0x{0} = {1}, 0x{2} = {3}, {4}) => 0x{5} ElapsedMilliseconds: {6}", assembly.ToString ("x"), Marshal.PtrToStringAuto (assembly), symbol.ToString ("x"), symb, id, rv.ToString ("x"), lookupWatch.ElapsedMilliseconds);
#endif

			if (rv != IntPtr.Zero)
				return rv;

			throw ErrorHelper.CreateError (8001, "Unable to find the managed function with id {0} ({1})", id, symb);;
		}

		static T FindLookup<T> (IntPtr assemblyNamePtr, Assembly? assembly, string methodName, Dictionary<string, T> map) where T: delegate
		{
			string assemblyName;
			if (assembly is not null) {
				assemblyName = assembly.GetName ().Name;
			} else {
				assemblyName = Marshal.PtrToStringAuto (assemblyNamePtr)!;
			}

			lock (lock_obj) {
				if (map.TryGetValue (assemblyName, out var value))
					return value;
			}

			if (assembly is null) {
				foreach (var a in AppDomain.CurrentDomain.GetAssemblies ()) {
					if (a.GetName ().Name != assemblyName)
						continue;
					assembly = a;
					break;
				}
			}

			if (assembly is null)
				throw ErrorHelper.CreateError (99, "Could not find the assembly '{0}' in the list of assemblies in the current AppDomain.", assembly);

			var type = assembly.GetType ("ObjCRuntime.__Registrar__", false);
			if (type is null)
				throw ErrorHelper.CreateError (99, "Could not find the type 'ObjCRuntime.Registrar' in the assembly '{0}'", assembly);

			var method = type.GetMethod (methodName, BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);
			if (method is null)
				throw ErrorHelper.CreateError (99, "Could not find the method '{1}' in the type '{2}' in the assembly '{0}'", assembly, methodName, type.FullName);

			var del = (T) Delegate.CreateDelegate (typeof (T), method);

			lock (lock_obj)
				map [assembly] = del;

			return del;
		}

		static IntPtr LookupUnmanagedFunctionInAssembly (IntPtr assembly_name, IntPtr symbol, int id)
		{
			var del = FindLookupMethod<LookupMethod> (assembly_name, null, "LookupUnmanagedFunction", lookup_method_map);
			return del (symbol, id);
		}

		static IntPtr LookupManagedFunctionImpl (int id)
		{
			// The static registrar will modify this function as needed.
			return IntPtr.Zero;
		}

		internal Type LookupRegisteredType (Assembly assembly, int id)
		{
			var del = FindLookup<LookupType> (IntPtr.Zero, assembly, "LookupType", lookup_type_map);
			return del (id);
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
