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
	// The managed static registrar will make this interface public when needed.
	interface IManagedRegistrar {
		IntPtr LookupUnmanagedFunction (string? symbol, int id);
		RuntimeTypeHandle LookupType (uint id);
		void RegisterWrapperTypes (Dictionary<RuntimeTypeHandle, RuntimeTypeHandle> type);
	}

	class MapInfo {
		public IManagedRegistrar Registrar;
		public bool RegisteredWrapperTypes;

		public MapInfo (IManagedRegistrar registrar)
		{
			Registrar = registrar;
		}
	}

	// This class contains helper methods for the managed static registrar.
	// The managed static registrar will make it public when needed.
	static class RegistrarHelper {
#pragma warning disable 8618
		static Dictionary<string, MapInfo> assembly_map;
		static Dictionary<RuntimeTypeHandle, RuntimeTypeHandle> wrapper_types;
#pragma warning restore 8618


		internal static void Initialize ()
		{
			assembly_map = new Dictionary<string, MapInfo> (Runtime.StringEqualityComparer);
			wrapper_types = new Dictionary<RuntimeTypeHandle, RuntimeTypeHandle> (Runtime.RuntimeTypeHandleEqualityComparer);
		}

		unsafe static IntPtr GetBlockPointer (BlockLiteral block)
		{
			var rv = BlockLiteral._Block_copy (&block);
			block.Dispose ();
			return rv;
		}

		static IntPtr GetBlockForDelegate (object @delegate, RuntimeMethodHandle method_handle)
		{
			var method = (MethodInfo) MethodBase.GetMethodFromHandle (method_handle)!;
			return BlockLiteral.GetBlockForDelegate (method, @delegate, Runtime.INVALID_TOKEN_REF, null);
		}


		static MapInfo GetMapEntry (Assembly assembly)
		{
			return GetMapEntry (assembly.GetName ().Name!, assembly);
		}

		static MapInfo GetMapEntry (IntPtr assembly)
		{
			return GetMapEntry (Marshal.PtrToStringAuto (assembly)!, null);
		}

		static MapInfo GetMapEntry (string assemblyName, Assembly? assembly)
		{
			lock (assembly_map) {
				if (!assembly_map.TryGetValue (assemblyName, out var mapEntry)) {
					if (assembly is null)
						assembly = GetAssembly (assemblyName);
					var type = assembly.GetType ("ObjCRuntime.__Registrar__", false);
					if (type is null)
						throw ErrorHelper.CreateError (99, "Could not find the type 'ObjCRuntime.__Registrar__' in the assembly '{0}'", assembly);

					var registrar = (IManagedRegistrar) Activator.CreateInstance (type)!;
					mapEntry = new MapInfo (registrar);
					assembly_map [assemblyName] = mapEntry;
				}
				return mapEntry;
			}
		}

		static Assembly GetAssembly (string assemblyName)
		{
			foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies ()) {
				if (assembly.GetName ().Name == assemblyName)
					return assembly;
			}

			throw ErrorHelper.CreateError (99, "Could not find the assembly '{0}' in the current AppDomain", assemblyName);
		}

		internal static Type? FindProtocolWrapperType (Type type)
		{
			var typeHandle = type.TypeHandle;

			lock (assembly_map) {
				// First check if the type is already in our dictionary.
				if (wrapper_types.TryGetValue (typeHandle, out var wrapperType))
					return Type.GetTypeFromHandle (wrapperType);

				// Not in our dictionary, get the map entry to see if we've already
				// called RegisterWrapperTypes for this assembly,
				var entry = GetMapEntry (type.Assembly);
				if (!entry.RegisteredWrapperTypes) {
					entry.Registrar.RegisterWrapperTypes (wrapper_types);
					entry.RegisteredWrapperTypes = true;
				}

				// Return whatever's in the dictionary now.
				if (wrapper_types.TryGetValue (typeHandle, out wrapperType))
					return Type.GetTypeFromHandle (wrapperType);
			}

			return null;
		}

#if TRACE
		[ThreadStatic]
		static Stopwatch? lookupWatch;
#endif

		internal static IntPtr LookupUnmanagedFunction (IntPtr assembly, string? symbol, int id)
		{
			IntPtr rv;

#if TRACE
			if (lookupWatch is null)
				lookupWatch = new Stopwatch ();

			lookupWatch.Start ();
			Console.WriteLine ("LookupUnmanagedFunction (0x{0} = {1}, 0x{2} = {3}, {4})", assembly.ToString ("x"), Marshal.PtrToStringAuto (assembly), symbol, symb, id);
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

			Console.WriteLine ("LookupUnmanagedFunction (0x{0} = {1}, {2}, {3}) => 0x{4} ElapsedMilliseconds: {5}", assembly.ToString ("x"), Marshal.PtrToStringAuto (assembly), symbol, id, rv.ToString ("x"), lookupWatch.ElapsedMilliseconds);
#endif

			if (rv != IntPtr.Zero)
				return rv;

			throw ErrorHelper.CreateError (8001, "Unable to find the managed function with id {0} ({1})", id, symbol);
		}

		static IntPtr LookupUnmanagedFunctionInAssembly (IntPtr assembly_name, string? symbol, int id)
		{
			var entry = GetMapEntry (assembly_name);
			return entry.Registrar.LookupUnmanagedFunction (symbol, id);
		}

		static IntPtr LookupManagedFunctionImpl (int id)
		{
			// The static registrar will modify this function as needed.
			return IntPtr.Zero;
		}

		internal static Type LookupRegisteredType (Assembly assembly, uint id)
		{
			var entry = GetMapEntry (assembly);
			var handle = entry.Registrar.LookupType (id);
			return Type.GetTypeFromHandle (handle)!;
		}

		// helper functions for converting between native and managed objects
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
