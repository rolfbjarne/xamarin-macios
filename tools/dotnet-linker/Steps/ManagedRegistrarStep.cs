using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

using Xamarin.Bundler;
using Xamarin.Utils;

using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Linker;
using Mono.Tuner;

using Registrar;
using System.Globalization;



#nullable enable

namespace Xamarin.Linker {
	public class ManagedRegistrarStep : ConfigurationAwareStep {
		protected override string Name { get; } = "ManagedRegistrar";
		protected override int ErrorCode { get; } = 2430;

		List<Exception> exceptions = new List<Exception> ();
		Application? app;

		AssemblyDefinition? current_assembly;

		AssemblyDefinition? corlib_assembly;
		AssemblyDefinition? platform_assembly;
		AssemblyDefinition? system_console_assembly;

		AssemblyDefinition CurrentAssembly {
			get {
				if (current_assembly is null)
					throw new InvalidOperationException ($"No current assembly!");
				return current_assembly;
			}
		}

		AssemblyDefinition CorlibAssembly {
			get {
				if (corlib_assembly is null)
					throw new InvalidOperationException ($"No corlib assembly!");
				return corlib_assembly;
			}
		}

		AssemblyDefinition PlatformAssembly {
			get {
				if (platform_assembly is null)
					throw new InvalidOperationException ($"No platform assembly!");
				return platform_assembly;
			}
		}

		AssemblyDefinition? SystemConsoleAssembly {
			get {
				if (system_console_assembly is null)
					system_console_assembly = Configuration.Assemblies.SingleOrDefault (v => v.Name.Name == "System.Console");
				return system_console_assembly;
			}
		}

		Dictionary<AssemblyDefinition, Dictionary<string, (TypeDefinition, TypeReference)>> type_map = new Dictionary<AssemblyDefinition, Dictionary<string, (TypeDefinition, TypeReference)>> ();
		Dictionary<string, (MethodDefinition, MethodReference)> method_map = new Dictionary<string, (MethodDefinition, MethodReference)> ();

		class TrampolineInfo
		{
			public MethodDefinition Trampoline;
			public MethodDefinition Target;
			public int Id;

			public TrampolineInfo (MethodDefinition trampoline, MethodDefinition target, int id)
			{
				this.Trampoline = trampoline;
				this.Target = target;
				this.Id = id;
			}
		}

		List<TrampolineInfo> current_trampoline_lists = new ();
		Dictionary<AssemblyDefinition, List<TrampolineInfo>> trampoline_map = new ();

		// FIXME: mark the types and methods we use
		TypeReference GetTypeReference (AssemblyDefinition assembly, string fullname, out TypeDefinition type)
		{
			if (!type_map.TryGetValue (assembly, out var map))
				type_map.Add (assembly, map = new Dictionary<string, (TypeDefinition, TypeReference)> ());

			if (!map.TryGetValue (fullname, out var tuple)) {
				var td = assembly.MainModule.Types.SingleOrDefault (v => v.FullName == fullname);
				if (td is null)
					throw new InvalidOperationException ($"Unable to find the type '{fullname}' in {assembly.Name.Name}");
				var tr = CurrentAssembly.MainModule.ImportReference (td);
				map [fullname] = tuple = new (td, tr);
			}

			type = tuple.Item1;
			return tuple.Item2;
		}

		// FIXME: mark the types and methods we use
		MethodReference GetMethodReference (AssemblyDefinition assembly, string fullname, string name)
		{
			GetTypeReference (assembly, fullname, out var td);
			return GetMethodReference (assembly, td, name, fullname + "::" + name, null, out var _);
		}

		MethodReference GetMethodReference (AssemblyDefinition assembly, string fullname, string name, Func<MethodDefinition, bool>? predicate)
		{
			GetTypeReference (assembly, fullname, out var td);
			return GetMethodReference (assembly, td, name, fullname + "::" + name, predicate, out var _);
		}

		MethodReference GetMethodReference (AssemblyDefinition assembly, string fullname, string name, Func<MethodDefinition, bool>? predicate, bool ensurePublic)
		{
			GetTypeReference (assembly, fullname, out var td);
			return GetMethodReference (assembly, td, name, fullname + "::" + name, predicate, out var _, ensurePublic: ensurePublic);
		}

		MethodReference GetMethodReference (AssemblyDefinition assembly, TypeReference tr, string name)
		{
			return GetMethodReference (assembly, tr, name, tr.FullName + "::" + name, null, out var _);
		}

		MethodReference GetMethodReference (AssemblyDefinition assembly, TypeReference tr, string name, Func<MethodDefinition, bool>? predicate)
		{
			return GetMethodReference (assembly, tr, name, tr.FullName + "::" + name, predicate, out var _);
		}

		MethodReference GetMethodReference (AssemblyDefinition assembly, TypeReference tr, string name, Func<MethodDefinition, bool>? predicate, bool ensurePublic = false)
		{
			return GetMethodReference (assembly, tr, name, tr.FullName + "::" + name, predicate, out var _, ensurePublic: ensurePublic);
		}

		MethodReference GetMethodReference (AssemblyDefinition assembly, TypeReference tr, string name, string key, Func<MethodDefinition, bool>? predicate, bool ensurePublic = false)
		{
			return GetMethodReference (assembly, tr, name, key, predicate, out var _, ensurePublic: ensurePublic);
		}

		MethodReference GetMethodReference (AssemblyDefinition assembly, TypeReference tr, string name, string key, Func<MethodDefinition, bool>? predicate, out MethodDefinition method, bool ensurePublic = false)
		{
			if (!method_map.TryGetValue (key, out var tuple)) {
				var td = tr.Resolve ();
				var md = td.Methods.SingleOrDefault (v => v.Name == name && (predicate is null || predicate (v)));
				if (md is null)
					throw new InvalidOperationException ($"Unable to find the method '{tr.FullName}::{name}' (for key '{key}') in {assembly.Name.Name}. Methods in type:\n\t{string.Join ("\n\t", td.Methods.Select (GetMethodSignature).OrderBy (v => v))}");

				tuple.Item1 = md;
				tuple.Item2 = CurrentAssembly.MainModule.ImportReference (md);
				method_map.Add (key, tuple);

				if (ensurePublic)
					md.IsPublic = true;
			}

			method = tuple.Item1;
			return tuple.Item2;
		}


		TypeReference System_Byte {
			get {
				return GetTypeReference (CorlibAssembly, "System.Byte", out var _);
			}
		}

		TypeReference System_Exception {
			get {
				return GetTypeReference (CorlibAssembly, "System.Exception", out var _);
			}
		}

		TypeReference System_Int32 {
			get {
				return GetTypeReference (CorlibAssembly, "System.Int32", out var _);
			}
		}

		TypeReference System_IntPtr {
			get {
				return GetTypeReference (CorlibAssembly, "System.IntPtr", out var _);
			}
		}

		TypeReference System_Nullable_1 {
			get {
				return GetTypeReference (CorlibAssembly, "System.Nullable`1", out var _);
			}
		}

		TypeReference System_Object {
			get {
				return GetTypeReference (CorlibAssembly, "System.Object", out var _);
			}
		}

		TypeReference System_String {
			get {
				return GetTypeReference (CorlibAssembly, "System.String", out var _);
			}
		}

		TypeReference System_Type {
			get {
				return GetTypeReference (CorlibAssembly, "System.Type", out var _);
			}
		}

		TypeReference System_Void {
			get {
				return GetTypeReference (CorlibAssembly, "System.Void", out var _);
			}
		}

		TypeReference? System_Console {
			get {
				var assembly = SystemConsoleAssembly;
				if (assembly is null)
					return null;
				return GetTypeReference (assembly, "System.Console", out var _);
			}
		}

		TypeReference System_Reflection_MethodBase {
			get {
				return GetTypeReference (CorlibAssembly, "System.Reflection.MethodBase", out var _);
			}
		}

		TypeReference System_Reflection_MethodInfo {
			get {
				return GetTypeReference (CorlibAssembly, "System.Reflection.MethodInfo", out var _);
			}
		}

		TypeReference Foundation_NSObject {
			get {
				return GetTypeReference (PlatformAssembly, "Foundation.NSObject", out var _);
			}
		}

		TypeReference Foundation_NSString {
			get {
				return GetTypeReference (PlatformAssembly, "Foundation.NSString", out var _);
			}
		}

		TypeReference ObjCRuntime_BindAs {
			get {
				return GetTypeReference (PlatformAssembly, "ObjCRuntime.BindAs", out var _);
			}
		}

		TypeReference ObjCRuntime_Runtime {
			get {
				return GetTypeReference (PlatformAssembly, "ObjCRuntime.Runtime", out var _);
			}
		}

		TypeReference ObjCRuntime_NativeHandle {
			get {
				return GetTypeReference (PlatformAssembly, "ObjCRuntime.NativeHandle", out var _);
			}
		}

		TypeReference ObjCRuntime_BlockLiteral {
			get {
				return GetTypeReference (PlatformAssembly, "ObjCRuntime.BlockLiteral", out var _);
			}
		}

		TypeReference ObjCRuntime_NativeObjectExtensions {
			get {
				return GetTypeReference (PlatformAssembly, "ObjCRuntime.NativeObjectExtensions", out var _);
			}
		}

		MethodReference Object_GetType {
			get {
				return GetMethodReference (CorlibAssembly, System_Object, "GetType", (v) =>
						!v.IsStatic
						&& !v.HasParameters
						&& !v.HasGenericParameters);
			}
		}

		MethodReference Type_GetTypeFromHandle {
			get {
				return GetMethodReference (CorlibAssembly, System_Type, "GetTypeFromHandle", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("System", "RuntimeTypeHandle")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference Type_get_TypeHandle {
			get {
				return GetMethodReference (CorlibAssembly, System_Type, "get_TypeHandle", (v) =>
						!v.IsStatic
						&& !v.HasParameters
						&& !v.HasGenericParameters);
			}
		}

		MethodReference MethodBase_Invoke {
			get {
				return GetMethodReference (CorlibAssembly, System_Reflection_MethodBase, "Invoke", (v) =>
						!v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 2
						&& v.Parameters [0].ParameterType.Is ("System", "Object")
						&& v.Parameters [1].ParameterType is ArrayType at
						&& at.ElementType.Is ("System", "Object")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference MethodBase_GetMethodFromHandle {
			get {
				return GetMethodReference (CorlibAssembly, System_Reflection_MethodBase, "GetMethodFromHandle", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 2
						&& v.Parameters [0].ParameterType.Is ("System", "RuntimeMethodHandle")
						&& v.Parameters [1].ParameterType.Is ("System", "RuntimeTypeHandle")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference NSObject_AllocateNSObject {
			get {
				return GetMethodReference (PlatformAssembly, Foundation_NSObject, "AllocateNSObject", nameof (NSObject_AllocateNSObject), (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 2
						&& v.Parameters [0].ParameterType.Is ("ObjCRuntime", "NativeHandle")
						&& v.Parameters [1].ParameterType.Is ("", "Flags") && v.Parameters [1].ParameterType.DeclaringType.Is ("Foundation", "NSObject")
						&& v.HasGenericParameters
						&& v.GenericParameters.Count == 1,
						ensurePublic: true);
			}
		}

		MethodReference NSObject_DangerousRetain {
			get {
				return GetMethodReference (PlatformAssembly, Foundation_NSObject, "DangerousRetain", nameof (NSObject_DangerousRetain), (v) =>
						!v.IsStatic
						&& !v.HasParameters
						&& !v.HasGenericParameters);
			}
		}

		MethodReference NSObject_DangerousAutorelease {
			get {
				return GetMethodReference (PlatformAssembly, Foundation_NSObject, "DangerousAutorelease", nameof (NSObject_DangerousAutorelease), (v) =>
						!v.IsStatic
						&& !v.HasParameters
						&& !v.HasGenericParameters);
			}
		}

		MethodReference GC_KeepAlive {
			get {
				return GetMethodReference (CorlibAssembly, "System.GC", "KeepAlive", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("System", "object")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference? Console_WriteLine {
			get {
				var assembly = SystemConsoleAssembly;
				if (assembly is null)
					return null;
				var type = System_Console;
				if (type is null)
					return null;
				return GetMethodReference (assembly, type, "WriteLine", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 2
						&& v.Parameters [0].ParameterType.Is ("System", "String")
						&& v.Parameters [1].ParameterType.Is ("System", "Object")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference BindAs_ConvertNSArrayToManagedArray {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_BindAs, "ConvertNSArrayToManagedArray", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 2
						&& v.Parameters [0].ParameterType.Is ("System", "IntPtr")
						// && v.Parameters [1].ParameterType.Is ("System", "IntPtr")
						&& v.HasGenericParameters
						&& v.GenericParameters.Count == 1
						, ensurePublic: true);
			}
		}

		MethodReference BindAs_ConvertNSArrayToManagedArray2 {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_BindAs, "ConvertNSArrayToManagedArray2", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 3
						&& v.Parameters [0].ParameterType.Is ("System", "IntPtr")
						// && v.Parameters [1].ParameterType.Is ("System", "IntPtr")
						&& v.HasGenericParameters
						&& v.GenericParameters.Count == 2
						, ensurePublic: true);
			}
		}

		MethodReference BindAs_ConvertManagedArrayToNSArray {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_BindAs, "ConvertManagedArrayToNSArray", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 2
						&& v.Parameters [0].ParameterType is ArrayType at
						// && v.Parameters [1].ParameterType.Is ("System", "IntPtr")
						&& v.HasGenericParameters
						&& v.GenericParameters.Count == 1
						, ensurePublic: true);
			}
		}

		MethodReference BindAs_ConvertManagedArrayToNSArray2 {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_BindAs, "ConvertManagedArrayToNSArray2", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 3
						&& v.Parameters [0].ParameterType is ArrayType at
						// && v.Parameters [1].ParameterType.Is ("System", "IntPtr")
						&& v.HasGenericParameters
						&& v.GenericParameters.Count == 2
						, ensurePublic: true);
			}
		}

		MethodReference BindAs_CreateNullable {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_BindAs, "CreateNullable", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 2
						// && v.Parameters [0].ParameterType.Is ("System", "IntPtr")
						// && v.Parameters [1].ParameterType.Is ("System", "IntPtr")
						&& v.HasGenericParameters
						&& v.GenericParameters.Count == 1
						, ensurePublic: true);
			}
		}

		MethodReference BindAs_CreateNullable2 {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_BindAs, "CreateNullable2", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 3
						// && v.Parameters [0].ParameterType.Is ("System", "IntPtr")
						// && v.Parameters [1].ParameterType.Is ("System", "IntPtr")
						&& v.HasGenericParameters
						&& v.GenericParameters.Count == 2
						, ensurePublic: true);
			}
		}

		MethodReference Runtime_AllocGCHandle {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "AllocGCHandle", nameof (Runtime_AllocGCHandle), (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("System", "Object")
						&& !v.HasGenericParameters, ensurePublic: true);
			}
		}

		MethodReference Runtime_HasNSObject {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "HasNSObject", nameof (Runtime_HasNSObject), (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("ObjCRuntime", "NativeHandle")
						&& !v.HasGenericParameters, ensurePublic: true);
			}
		}

		MethodReference Runtime_GetNSObject__System_IntPtr {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "GetNSObject", nameof (Runtime_GetNSObject__System_IntPtr), (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("System", "IntPtr")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference Runtime_GetNSObject_T___System_IntPtr {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "GetNSObject", nameof (Runtime_GetNSObject_T___System_IntPtr), (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("System", "IntPtr")
						&& v.HasGenericParameters
						&& v.GenericParameters.Count == 1);
			}
		}
		MethodReference Runtime_GetNSObject__ObjCRuntime_NativeHandle {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "GetNSObject", nameof (Runtime_GetNSObject__ObjCRuntime_NativeHandle), (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("ObjCRuntime", "NativeHandle")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference Runtime_GetINativeObject__IntPtr_Boolean_Type_Type {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "GetINativeObject", nameof (Runtime_GetINativeObject__IntPtr_Boolean_Type_Type), (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 4
						&& v.Parameters [0].ParameterType.Is ("System", "IntPtr")
						&& v.Parameters [1].ParameterType.Is ("System", "Boolean")
						&& v.Parameters [2].ParameterType.Is ("System", "Type")
						&& v.Parameters [3].ParameterType.Is ("System", "Type")
						&& !v.HasGenericParameters,
						ensurePublic: true);
			}
		}

		MethodReference Runtime_GetINativeObject_T__IntPtr_Boolean {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "GetINativeObject", nameof (Runtime_GetINativeObject_T__IntPtr_Boolean), (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 2
						&& v.Parameters [0].ParameterType.Is ("System", "IntPtr")
						&& v.Parameters [1].ParameterType.Is ("System", "Boolean")
						&& v.HasGenericParameters
						&& v.GenericParameters.Count == 1
						,
						ensurePublic: true);
			}
		}

		MethodReference BlockLiteral_CreateBlockForDelegate {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_BlockLiteral, "CreateBlockForDelegate", (v) => 
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 3
						&& v.Parameters [0].ParameterType.Is ("System", "Delegate")
						&& v.Parameters [1].ParameterType.Is ("System", "Delegate")
						&& v.Parameters [2].ParameterType.Is ("System", "String")
						&& !v.HasGenericParameters, ensurePublic: true);
			}
		}

		MethodReference BlockLiteral_GetBlockForDelegate {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_BlockLiteral, "GetBlockForDelegate", (v) => 
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 4
						&& v.Parameters [0].ParameterType.Is ("System.Reflection", "MethodInfo")
						&& v.Parameters [1].ParameterType.Is ("System", "Object")
						&& v.Parameters [2].ParameterType.Is ("System", "UInt32")
						&& v.Parameters [3].ParameterType.Is ("System", "String")
						&& !v.HasGenericParameters, ensurePublic: true);
			}
		}

		MethodReference BlockLiteral_Copy {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_BlockLiteral, "Copy", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("System", "IntPtr")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference Runtime_ReleaseBlockWhenDelegateIsCollected {
			get {
				var rv = GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "ReleaseBlockWhenDelegateIsCollected", "ReleaseBlockWhenDelegateIsCollected", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 2
						&& v.Parameters [0].ParameterType.Is ("System", "IntPtr")
						&& v.Parameters [1].ParameterType.Is ("System", "Delegate")
						&& !v.HasGenericParameters, out var md);
				md.IsPublic = true;
				return rv;
			}
		}

		MethodReference Runtime_GetBlockWrapperCreator {
			get {
				var rv = GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "GetBlockWrapperCreator", nameof (Runtime_GetBlockWrapperCreator), (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 2
						&& v.Parameters [0].ParameterType.Is ("System.Reflection", "MethodInfo")
						&& v.Parameters [1].ParameterType.Is ("System", "Int32")
						&& !v.HasGenericParameters, out var md);
				md.IsPublic = true;
				return rv;
			}
		}

		MethodReference Runtime_CreateBlockProxy {
			get {
				var rv = GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "CreateBlockProxy", nameof (Runtime_CreateBlockProxy), (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 2
						&& v.Parameters [0].ParameterType.Is ("System.Reflection", "MethodInfo")
						&& v.Parameters [1].ParameterType.Is ("System", "IntPtr")
						&& !v.HasGenericParameters, out var md);
				md.IsPublic = true;
				return rv;
			}
		}

		MethodReference Runtime_TraceCaller {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "TraceCaller", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("System", "String")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference Runtime_FindClosedMethodForObject {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "FindClosedMethodForObject", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 2
						&& v.Parameters [0].ParameterType.Is ("System", "IntPtr")
						&& v.Parameters [1].ParameterType.Is ("System.Reflection", "MethodBase")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference CFString_FromHandle {
			get {
				return GetMethodReference (PlatformAssembly, "CoreFoundation.CFString", "FromHandle", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("ObjCRuntime", "NativeHandle")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference CFString_CreateNative {
			get {
				return GetMethodReference (PlatformAssembly, "CoreFoundation.CFString", "CreateNative", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("System", "String")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference CFArray_StringArrayFromHandle {
			get {
				return GetMethodReference (PlatformAssembly, "CoreFoundation.CFArray", "StringArrayFromHandle", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("ObjCRuntime", "NativeHandle")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference CFArray_Create {
			get {
				return GetMethodReference (PlatformAssembly, "CoreFoundation.CFArray", "Create", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType is ArrayType at
						&& at.GetElementType ().Is ("System", "String")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference NSArray_ArrayFromHandle {
			get {
				return GetMethodReference (PlatformAssembly, "Foundation.NSArray", "ArrayFromHandle", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("ObjCRuntime", "NativeHandle")
						&& v.HasGenericParameters
						&& v.GenericParameters.Count == 1);
			}
		}

		MethodReference NSArray_FromNSObjects__INativeObjects {
			get {
				return GetMethodReference (PlatformAssembly, "Foundation.NSArray", "FromNSObjects", (v) => {

					var rv =
					v.IsStatic
					&& v.HasParameters
					&& v.Parameters.Count == 1
					&& v.Parameters [0].ParameterType is ArrayType at
					&& at.GetElementType ().Is ("ObjCRuntime", "INativeObject")
					&& !v.HasGenericParameters;

					Console.WriteLine (@$"DEBUGDEBUG2:
					{v.Name}
					v.IsStatic: {v.IsStatic}
					&& v.HasParameters: {v.HasParameters}
					&& v.Parameters.Count == 1 {v.Parameters.Count}
					&& v.Parameters [0].ParameterType is ArrayType at: {v.Parameters [0].ParameterType.GetType ().FullName}
					&& at.Is (""ObjCRuntime"", ""INativeObject""):  {(v.Parameters [0].ParameterType as ArrayType)?.GetElementType ().Is ("ObjCRuntime", "INativeObject")}
					&& !v.HasGenericParameters {!v.HasGenericParameters}
					*** {rv} ***");

					return rv;
				});
			}
		}

		MethodReference NativeObjectExtensions_GetHandle {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_NativeObjectExtensions, "GetHandle");
			}
		}

		MethodReference NativeObject_op_Implicit_IntPtr {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_NativeHandle, "op_Implicit", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("ObjCRuntime", "NativeHandle")
						&& v.ReturnType.Is ("System", "IntPtr")
						&& !v.HasGenericParameters
						);
			}
		}

		MethodReference Runtime_RetainObject {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "RetainObject", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("System", "Object")
						&& !v.HasGenericParameters,
						ensurePublic: true);
			}
		}

		MethodReference Runtime_RetainAndAutorelease {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "RetainAndAutorelease", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("Foundation", "NSObject")
						&& !v.HasGenericParameters,
						ensurePublic: true);
			}
		}

		MethodReference UnmanagedCallersOnlyAttribute_Constructor {
			get {
				return GetMethodReference (CorlibAssembly, "System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute", ".ctor", (v) => v.IsDefaultConstructor ());
			}
		}

		MethodReference Unsafe_AsRef {
			get {
				return GetMethodReference (CorlibAssembly, "System.Runtime.CompilerServices.Unsafe", "AsRef", (v) => 
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.IsPointer
						&& v.Parameters [0].ParameterType.GetElementType ().Is ("System", "Void")
						&& v.HasGenericParameters
						);
			}
		}

		MethodReference Exception_ctor_String {
			get {
				return GetMethodReference (CorlibAssembly, "System.Exception", ".ctor", (v) =>
						v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("System", "String")
						&& !v.HasGenericParameters);
			}
		}
		void AddException (Exception exception)
		{
			if (exceptions is null)
				exceptions = new List<Exception> ();
			exceptions.Add (exception);
		}

		protected override void TryProcess ()
		{
			base.TryProcess ();

			app = Configuration.Application;
			app.SelectRegistrar ();

			if (app.Registrar != RegistrarMode.ManagedStatic)
				return;

			var bundled_assemblies = new List<AssemblyDefinition> ();
			foreach (var assembly in Configuration.Assemblies) {
				if (Annotations.GetAction (assembly) != AssemblyAction.Delete)
					bundled_assemblies.Add (assembly);
			}
			Configuration.Target.StaticRegistrar.Register (bundled_assemblies);
		}

		protected override void TryEndProcess ()
		{
			base.TryEndProcess ();

			RewriteRuntimeLookupManagedFunction ();

			// PlatformAssembly.Write ("/Users/rolf/Microsoft.MacCatalyst.dll");
			
			if (exceptions is null)
				return;
			var warnings = exceptions.Where (v => (v as ProductException)?.Error == false).ToArray ();
			if (warnings.Length == exceptions.Count)
				return;

			if (exceptions.Count == 1)
				throw exceptions [0];
			exceptions.Add (new Exception ($"Got {exceptions.Where (v => (v as ProductException)?.Error == true).Count ()} errors (of {exceptions.Count} exceptions) (HOORAY)"));
			throw new AggregateException (exceptions);
		}

		protected override void TryProcessAssembly (AssemblyDefinition assembly)
		{
			base.TryProcessAssembly (assembly);

			if (app!.Registrar != RegistrarMode.ManagedStatic)
				return;

			if (Annotations.GetAction (assembly) == AssemblyAction.Delete)
				return;

			// No SDK assemblies will have anything we need to register
			if (Configuration.Profile.IsSdkAssembly (assembly))
				return;

			if (!assembly.MainModule.HasAssemblyReferences)
				return;

			// In fact, unless an assembly references our platform assembly, then it won't have anything we need to register
			if (!Configuration.Profile.IsProductAssembly (assembly) && !assembly.MainModule.AssemblyReferences.Any (v => Configuration.Profile.IsProductAssembly (v.Name)))
				return;

			if (!assembly.MainModule.HasTypes)
				return;

			if (corlib_assembly is null)
				corlib_assembly = Configuration.Assemblies.Single (v => v.Name.Name == Driver.CorlibName);

			if (platform_assembly is null)
				platform_assembly = Configuration.Assemblies.Single (Configuration.Profile.IsProductAssembly);

			current_assembly = assembly;

			current_trampoline_lists = new List<TrampolineInfo> ();
			trampoline_map.Add (current_assembly, current_trampoline_lists);

			var modified = false;
			foreach (var type in assembly.MainModule.Types)
				modified |= ProcessType (type);

			// Make sure the linker saves any changes in the assembly.
			if (modified) {
				CreateRegistrarType ();
				Save (assembly);
			}

			type_map.Clear ();
			method_map.Clear ();
			current_assembly = null;
		}

		void Save (AssemblyDefinition assembly)
		{
			var action = Context.Annotations.GetAction (assembly);
			if (action == AssemblyAction.Copy)
				Context.Annotations.SetAction (assembly, AssemblyAction.Save);
		}

		void CreateRegistrarType ()
		{
			var sorted = current_trampoline_lists.OrderBy (v => v.Id).ToList ();
			if (sorted.Count == 0)
				return;

			var td = new TypeDefinition ("ObjCRuntime", "__Registrar__", TypeAttributes.Public | TypeAttributes.Class | TypeAttributes.Sealed | TypeAttributes.BeforeFieldInit);
			td.BaseType = System_Object;
			CurrentAssembly.MainModule.Types.Add (td);

			Console.WriteLine ($"GenerateLookupMethods assembly: {CurrentAssembly.FullName}");

			//
			// The callback methods themselves are all public, and thus accessible from anywhere inside the assembly even if the containing type is not public, as long as the containing type is not nested.
			// However, if the containing type is nested inside another type, it gets complicated.
			//
			// We have two options:
			// 
			// 1. Just change the visibility on the nested type to make it visible inside the assembly.
			// 2. Add a method in the containing type (which has access to any directly nested private types) that can look up any unmanaged trampolines.
			//    If the containing type is also a private nested type, when we'd have to add another method in its containing type, and so on.
			//
			// The second option is more complicated to implement than the first, so we're doing the first option. If someone
			// runs into any problems (there might be with reflection: looking up a type using the wrong visibility will fail to find that type).
			// That said, there may be all sorts of problems with reflection (we're adding methods to types, any logic that depends on a type having a certain number of methods will fail for instance).
			//

			foreach (var md in sorted) {
				var declType = md.Trampoline.DeclaringType;
				while (declType.IsNested) {
					if (declType.IsNestedPrivate) {
						declType.IsNestedAssembly = true;
					} else if (declType.IsNestedFamilyAndAssembly || declType.IsNestedFamily) {
						declType.IsNestedFamilyOrAssembly = true;
					}
					declType = declType.DeclaringType;
				}
			}

			GenerateLookupMethods (td, sorted);
		}

		void GenerateLookupMethods (TypeDefinition type, IList<TrampolineInfo> trampolineInfos)
		{
			Console.WriteLine ($"GenerateLookupMethods ({type.FullName}, {trampolineInfos.Count} items");
			// All the methods in a given assembly will have consecutive IDs (but might not start at 0).
			if (trampolineInfos.First ().Id + trampolineInfos.Count - 1 != trampolineInfos.Last ().Id)
				throw ErrorHelper.CreateError (99, "Invalid ID range");

			const int methodsPerLevel = 10;
			var levels = (int) Math.Ceiling (Math.Log (trampolineInfos.Count, methodsPerLevel));
			GenerateLookupMethods (type, trampolineInfos, methodsPerLevel, 1, levels, 0, trampolineInfos.Count - 1);
		}

		MethodDefinition GenerateLookupMethods (TypeDefinition type, IList<TrampolineInfo> trampolineInfos, int methodsPerLevel, int level, int levels, int startIndex, int endIndex)
		{
			Console.WriteLine ($"GenerateLookupMethods ({type.FullName}, {trampolineInfos.Count} items, methodsPerLevel: {methodsPerLevel}, level: {level}, levels: {levels}, startIndex: {startIndex}, endIndex: {endIndex})");

			if (startIndex > endIndex)
				throw new InvalidOperationException ($"Huh 3? startIndex: {startIndex} endIndex: {endIndex}");

			var startId = trampolineInfos [startIndex].Id;
			var name = level == 1 ? "LookupUnmanagedFunction" : $"LookupUnmanagedFunction_{level}_{levels}__{startIndex}_{endIndex}__";
			var method = type.AddMethod (name, MethodAttributes.Private | MethodAttributes.Static | MethodAttributes.HideBySig, System_IntPtr);
			method.ReturnType = System_IntPtr; // shouldn't be necessary???
			method.AddParameter ("symbol", System_IntPtr);
			method.AddParameter ("id", System_Int32);
			method.CreateBody (out var il);

			if (level == levels) {
				// This is the leaf method where we do the actual lookup.
				var wrapLookup = true;

				var targetCount = endIndex - startIndex + 1;
				var targets = new Instruction [targetCount];
				for (var i = 0; i < targets.Length; i++) {
					var ti = trampolineInfos [startIndex + i];
					var md = ti.Trampoline;
					try {
						var mr = CurrentAssembly.MainModule.ImportReference (md);
						if (wrapLookup) {
							var wrappedLookup = type.AddMethod (name + ti.Id, MethodAttributes.Private | MethodAttributes.Static | MethodAttributes.HideBySig, System_IntPtr);
							wrappedLookup.CreateBody (out var wrappedIl);
							wrappedIl.Emit (OpCodes.Ldftn, mr);
							wrappedIl.Emit (OpCodes.Ret);

							targets [i] = Instruction.Create (OpCodes.Call, wrappedLookup);
						} else {
							targets [i] = Instruction.Create (OpCodes.Ldftn, mr);
						}
					} catch (Exception e) {
						var str = string.Format ("Failed to import reference {0}: {1}", GetMethodSignature (md), e.ToString ());
						AddException (ErrorHelper.CreateWarning (99, e, str));
						targets [i] = Instruction.Create (OpCodes.Ldstr, str);
					}
				}

				il.Emit (OpCodes.Ldarg_1);
				if (startId != 0) {
					il.Emit (OpCodes.Ldc_I4, startId);
					il.Emit (OpCodes.Sub_Ovf_Un);
				}
				il.Emit (OpCodes.Switch, targets);
				for (var k = 0; k < targetCount; k++) {
					il.Append (targets [k]);
					il.Emit (OpCodes.Ret);
				}
			} else {
				// This is an intermediate method to not have too many ldftn instructions in a single method (it takes a long time to JIT).
				var chunkSize = (int) Math.Pow (methodsPerLevel, levels - level);

				// Some validation
				if (level == 1) {
					if (chunkSize * methodsPerLevel < trampolineInfos.Count)
						throw new InvalidOperationException ($"Huh 2 -- {chunkSize}?");
				}

				var count = endIndex - startIndex + 1;
				var chunks = (int) Math.Ceiling (count / (double) chunkSize);
				var targets = new Instruction [chunks];

				Console.WriteLine ($"GenerateLookupMethods ({type.FullName}, {trampolineInfos.Count} items, methodsPerLevel: {methodsPerLevel}, level: {level}, levels: {levels}, startIndex: {startIndex}, endIndex: {endIndex}) count: {count} chunks: {chunks} chunkSize: {chunkSize}");

				var lookupMethods = new MethodDefinition [targets.Length];
				for (var i = 0; i < targets.Length; i++) {
					try {
						var subStartIndex = startIndex + (chunkSize) * i;
						var subEndIndex = subStartIndex + (chunkSize)  - 1;
						if (subEndIndex > endIndex)
							subEndIndex = endIndex;
						var md = GenerateLookupMethods (type, trampolineInfos, methodsPerLevel, level + 1, levels, subStartIndex, subEndIndex);
						lookupMethods [i] = md;
						targets [i] = Instruction.Create (OpCodes.Ldarg_0);
					} catch (Exception e) {
						var str = string.Format ("Failed to generate nested lookup method: {0}", e.ToString ());
						AddException (ErrorHelper.CreateWarning (99, e, str));
						targets [i] = Instruction.Create (OpCodes.Ldstr, str);
					}
				}

				il.Emit (OpCodes.Ldarg_1);
				if (startId != 0) {
					il.Emit (OpCodes.Ldc_I4, startId);
					il.Emit (OpCodes.Sub_Ovf_Un);
				}
				il.Emit (OpCodes.Ldc_I4, chunkSize);
				il.Emit (OpCodes.Div);
				il.Emit (OpCodes.Switch, targets);
				for (var k = 0; k < targets.Length; k++) {
					il.Append (targets [k]); // OpCodes.Ldarg_0
					il.Emit (OpCodes.Ldarg_1);
					il.Emit (OpCodes.Call, lookupMethods [k]);
					il.Emit (OpCodes.Ret);
				}
			}

			// no hit? this shouldn't happen
			il.Emit (OpCodes.Ldc_I4_M1);
			il.Emit (OpCodes.Conv_I);
			il.Emit (OpCodes.Ret);

			// Dump (method, Console.WriteLine);

			return method;
		}

		void RewriteRuntimeLookupManagedFunction ()
		{
			current_assembly = PlatformAssembly;

			var method = GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "LookupManagedFunctionImpl").Resolve ();
			var table = Configuration.UnmanagedCallersMap.ToList ().OrderBy (v => v.Value.Id).ToList ();

			Console.WriteLine ($"Creating table for {table.Count} entries YAAY");

			// Create second-level methods.
			var lookupsPerMethod = 100;
			var secondLevelMethodCount = (table.Count + lookupsPerMethod - 1) / lookupsPerMethod;
			var secondLevelMethods = new MethodDefinition [secondLevelMethodCount];
			for (var i = 0; i < secondLevelMethodCount; i++) {
				var secondLevelMethod = new MethodDefinition ("LookupManagedFunctionImpl" + i.ToString (), MethodAttributes.Static | MethodAttributes.Private, method.ReturnType);
				secondLevelMethod.Parameters.Add (new ParameterDefinition ("index", ParameterAttributes.None, method.Parameters [0].ParameterType));
				method.DeclaringType.Methods.Add (secondLevelMethod);
				secondLevelMethods [i] = secondLevelMethod;

				var body = new MethodBody (secondLevelMethod);
				secondLevelMethod.Body = body;
				var il = body.GetILProcessor ();
				il.Clear ();

				var secondLevelMethodLookupCount = i == secondLevelMethodCount - 1 ? table.Count % lookupsPerMethod : lookupsPerMethod;
				var targets = new Instruction [secondLevelMethodLookupCount];
				for (var k = 0; k < secondLevelMethodLookupCount; k++) {
					var index = i * lookupsPerMethod + k;
					var md = table [index].Value.UnmanagedCallersMethod;
					try {
						var mr = PlatformAssembly.MainModule.ImportReference (md);
						targets [k] = Instruction.Create (OpCodes.Ldftn, mr);
					} catch (Exception e) {
						var str = string.Format ("Failed to import reference {0}: {1}", GetMethodSignature (md), e.ToString ());
						AddException (ErrorHelper.CreateWarning (99, e, str));
						targets [k] = Instruction.Create (OpCodes.Ldstr, str);
					}
				}

				il.Emit (OpCodes.Ldarg_0);
				il.Emit (OpCodes.Switch, targets);
				for (var k = 0; k < secondLevelMethodLookupCount; k++) {
					il.Append (targets [k]);
					il.Emit (OpCodes.Ret);
				}

				// no hit? this shouldn't happen
				il.Emit (OpCodes.Ldc_I4_M1);
				il.Emit (OpCodes.Conv_I);
				il.Emit (OpCodes.Ret);

				Dump (secondLevelMethod, Console.Out.WriteLine);
			}

			// Create first-level method
			{
				var body = new MethodBody (method);
				method.Body = body;
				var il = body.GetILProcessor ();
				il.Clear ();

				var targets = new Instruction [secondLevelMethodCount];
				var returnStatement = Instruction.Create (OpCodes.Ret);
				for (var i = 0; i < targets.Length; i++) {
					targets [i] = Instruction.Create (OpCodes.Call, secondLevelMethods [i]);
				}

				il.Emit (OpCodes.Ldarg_0);
				if (lookupsPerMethod <= sbyte.MaxValue) {
					il.Emit (OpCodes.Ldc_I4_S, (sbyte) lookupsPerMethod);
				} else {
					il.Emit (OpCodes.Ldc_I4, lookupsPerMethod);
				}
				il.Emit (OpCodes.Rem);
				il.Emit (OpCodes.Ldarg_0);
				if (lookupsPerMethod <= sbyte.MaxValue) {
					il.Emit (OpCodes.Ldc_I4_S, (sbyte) lookupsPerMethod);
				} else {
					il.Emit (OpCodes.Ldc_I4, lookupsPerMethod);
				}
				il.Emit (OpCodes.Div);
				il.Emit (OpCodes.Switch, targets);
				for (var i = 0; i < targets.Length; i++) {
					il.Append (targets [i]);
					il.Emit (OpCodes.Ret);
					il.Emit (OpCodes.Br, returnStatement);
				}
				il.Emit (OpCodes.Ldc_I4_M1);
				il.Emit (OpCodes.Conv_I);
				il.Append (returnStatement);

				Dump (method, Console.Out.WriteLine);
			}

			Save (PlatformAssembly);
			current_assembly = null;
		}

		bool ProcessType (TypeDefinition type)
		{
			var modified = false;
			if (type.HasNestedTypes) {
				foreach (var nested in type.NestedTypes)
					modified |= ProcessType (nested);
			}

			var process = false;

			process |= IsNSObject (type);
			process |= StaticRegistrar.GetCategoryAttribute (type) is not null;

			var registerAttribute = StaticRegistrar.GetRegisterAttribute (type);
			if (registerAttribute is not null && registerAttribute.IsWrapper)
				return modified;

			if (!process)
				return modified;

			var methods_to_wrap = new HashSet<MethodDefinition> ();
			if (type.HasMethods) {
				foreach (var method in type.Methods)
					ProcessMethod (method, methods_to_wrap);
			}

			if (type.HasProperties) {
				foreach (var prop in type.Properties) {
					ProcessProperty (prop, methods_to_wrap);
				}
			}

			if (methods_to_wrap.Count == 0)
				return modified;

			foreach (var method in methods_to_wrap) {
				try {
					CreateUnmanagedCallersMethod (method);
				} catch (Exception e) {
					Console.WriteLine (e);
					AddException (ErrorHelper.CreateWarning (99, e, "Failed process {0}: {1}", method.FullName, e.Message));
				}
			}

			return true;
		}

		void ProcessMethod (MethodDefinition method, HashSet<MethodDefinition> methods_to_wrap)
		{
			if (!(method.IsConstructor && !method.IsStatic)) {
				var ea = StaticRegistrar.GetExportAttribute (method);
				if (ea is null && !method.IsVirtual)
					return;
			}

			if (!StaticRegistrar.TryFindMethod (method, out _)) {
				Console.WriteLine ("Could not find method {0}, so no generating trampoline.", GetMethodSignature (method));
				return;
			}

			methods_to_wrap.Add (method);
		}

		void ProcessProperty (PropertyDefinition property, HashSet<MethodDefinition> methods_to_wrap)
		{
			var ea = StaticRegistrar.GetExportAttribute (property);
			if (ea is null)
				return;

			if (property.GetMethod is not null)
				methods_to_wrap.Add (property.GetMethod);

			if (property.SetMethod is not null)
				methods_to_wrap.Add (property.SetMethod);	
		}

		static string Sanitize (string str)
		{
			// 😐...
			str = str.Replace ('.', '_');
			str = str.Replace ('/', '_');
			str = str.Replace ('\\', '_');
			str = str.Replace ('`', '_');
			str = str.Replace ('<', '_');
			str = str.Replace ('>', '_');
			str = str.Replace ('$', '_');
			str = str.Replace ('@', '_');
			return str;
		}

		void Trace (ILProcessor il, string message)
		{
			var mr = Console_WriteLine;
			if (mr is null)
				return;

			var trace = true;
			if (trace) {
				il.Emit (OpCodes.Ldstr, message);
				il.Emit (OpCodes.Call, Runtime_TraceCaller);
			}
		}

		int counter;
		void CreateUnmanagedCallersMethod (MethodDefinition method)
		{
			if (method.Name =="ToLower")
				Console.WriteLine ("STOP!");
			var placeholderType = System_IntPtr;
			var initialExceptionCount = exceptions.Count;
			ParameterDefinition? callSuperParameter = null;
			VariableDefinition? returnVariable = null;
			var leaveTryInstructions = new List<Instruction> ();
			var isVoid = method.ReturnType.Is ("System", "Void");

			var name = $"callback_{counter++}_{Sanitize (method.DeclaringType.FullName)}_{Sanitize (method.Name)}";

			var callbackType = method.DeclaringType.NestedTypes.SingleOrDefault (v => v.Name == "__Registrar_Callbacks__");
			if (callbackType is null) {
				callbackType = new TypeDefinition (string.Empty, "__Registrar_Callbacks__", TypeAttributes.NestedPrivate | TypeAttributes.Sealed | TypeAttributes.Class);
				callbackType.BaseType = System_Object;
				method.DeclaringType.NestedTypes.Add (callbackType);
			}

			var callback = callbackType.AddMethod (name, MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig, placeholderType);
			callback.CustomAttributes.Add (CreateUnmanagedCallersAttribute (name));
			var entry = new LinkerConfiguration.UnmanagedCallersEntry (name, Configuration.UnmanagedCallersMap.Count, callback);
			Configuration.UnmanagedCallersMap.Add (method, entry);
			current_trampoline_lists.Add (new TrampolineInfo (callback, method, entry.Id));

			// FIXME
			var t = method.DeclaringType;
			while (t.IsNested) {
				t.IsNestedPublic = true;
				t = t.DeclaringType;
			}
			t.IsPublic = true;
			// END FIXME 

			var body = callback.CreateBody (out var il);
			var placeholderInstruction = il.Create (OpCodes.Nop);
			var placeholderNextInstruction = il.Create (OpCodes.Nop);
			var postProcessing = new List<Instruction> ();
			var categoryAttribute = StaticRegistrar.GetCategoryAttribute (method.DeclaringType);
			var isCategory = categoryAttribute is not null;
			var isInstanceCategory = isCategory && StaticRegistrar.HasThisAttribute (method);
			var isGeneric = method.DeclaringType.HasGenericParameters;

			try {
				Trace (il, $"ENTER");

				if (method.IsConstructor) {
					callback.AddParameter ("pobj", ObjCRuntime_NativeHandle);
				} else {
					callback.AddParameter ("pobj", System_IntPtr);
				}

				if (!isVoid || method.IsConstructor)
					returnVariable = body.AddVariable (placeholderType);

				if (isGeneric) {
					if (method.IsStatic)
						throw new NotImplementedException (); // probably an error?

					il.Emit (OpCodes.Ldtoken, method);
					// il.Emit (OpCodes.Ldtoken, Console_WriteLine); // DUMMY METHOD

					il.Emit (OpCodes.Ldarg_0);
					EmitConversion (method, il, method.DeclaringType, true, -1, out var nativeType, postProcessing);
					// FIXME: throw if null
					// FIXME: can only be NSObject
					il.Emit (OpCodes.Call, Object_GetType);
					il.Emit (OpCodes.Call, Type_get_TypeHandle);
					il.Emit (OpCodes.Call, MethodBase_GetMethodFromHandle);
				}

				if (isInstanceCategory) {
					il.Emit (OpCodes.Ldarg_0);
					EmitConversion (method, il, method.Parameters [0].ParameterType, true, 0, out var nativeType, postProcessing);
				} else if (method.IsStatic) {
					// nothing to do
				} else if (method.IsConstructor) {
					callSuperParameter = new ParameterDefinition ("call_super", ParameterAttributes.None, new PointerType (System_Byte));
					var callAllocateNSObject = il.Create (OpCodes.Ldarg_0);
					// if (Runtime.HasNSObject (p0)) {
					il.Emit (OpCodes.Ldarg_0);
					il.Emit (OpCodes.Call, Runtime_HasNSObject);
					il.Emit (OpCodes.Brfalse, callAllocateNSObject);
					// *call_super = 1;
					il.Emit (OpCodes.Ldarg, callSuperParameter);
					il.Emit (OpCodes.Ldc_I4_1);
					il.Emit (OpCodes.Stind_I1);
					// return rv;
					il.Emit (OpCodes.Ldarg_0);
					il.Emit (OpCodes.Stloc, returnVariable);
					il.Emit (OpCodes.Leave, placeholderInstruction);
					// }
					leaveTryInstructions.Add (il.Body.Instructions.Last ());

					var git = new GenericInstanceMethod (NSObject_AllocateNSObject);
					git.GenericArguments.Add (method.DeclaringType);
					il.Append (callAllocateNSObject); // ldarg_0
					il.Emit (OpCodes.Ldc_I4_2); // NSObject.Flags.NativeRef
					il.Emit (OpCodes.Call, git);
					il.Emit (OpCodes.Dup); // this is for the call to ObjCRuntime.NativeObjectExtensions::GetHandle after the call to the constructor
				} else {
					// instance method
					il.Emit (OpCodes.Ldarg_0);
					EmitConversion (method, il, method.DeclaringType, true, -1, out var nativeType, postProcessing);
					//if (nativeType != callback.Parameters [0].ParameterType)
					//	AddException (ErrorHelper.CreateWarning (99, "Unexpected parameter type for the first parameter. Expected {0}, got {1}. Method: {2}", callback.Parameters [0].ParameterType.FullName, nativeType?.FullName, GetMethodSignatureWithSourceCode (method)));
				}

				callback.AddParameter ("sel", System_IntPtr);

				var managedParameterCount = 0;
				var nativeParameterOffset = isInstanceCategory ? 1 : 2;
				var parameterStart = isInstanceCategory ? 1 : 0;
				if (method.HasParameters)
					managedParameterCount = method.Parameters.Count;

				if (isGeneric) {
					il.Emit (OpCodes.Ldc_I4, managedParameterCount);
					il.Emit (OpCodes.Newarr, System_Object);
				}

				if (method.HasParameters) {
					for (var p = parameterStart; p < managedParameterCount; p++) {
						var nativeParameter = callback.AddParameter ($"p{p}", placeholderType);
						var nativeParameterIndex = p + nativeParameterOffset;
						var managedParameterType = method.Parameters [p].ParameterType;
						if (isGeneric) {
							if (parameterStart != 0)
								throw new NotImplementedException ("parameterStart");
							il.Emit (OpCodes.Dup);
							il.Emit (OpCodes.Ldc_I4, p);
						}
						switch (nativeParameterIndex) {
						case 1:
							il.Emit (OpCodes.Ldarg_1);
							break;
						case 2:
							il.Emit (OpCodes.Ldarg_2);
							break;
						case 3:
							il.Emit (OpCodes.Ldarg_3);
							break;
						default:
							il.Emit (OpCodes.Ldarg, nativeParameterIndex);
							break;
						}
						if (EmitConversion (method, il, managedParameterType, true, p, out var nativeType, postProcessing)) {
							nativeParameter.ParameterType = nativeType;
						} else {
							nativeParameter.ParameterType = placeholderType;
							AddException (ErrorHelper.CreateWarning (99, "Unable to emit conversion for parameter {2} of type {0}. Method: {1}", method.Parameters [p].ParameterType, GetMethodSignatureWithSourceCode (method), p));
						}
						if (isGeneric) {
							if (managedParameterType.IsValueType)
								il.Emit (OpCodes.Box, managedParameterType);
							il.Emit (OpCodes.Stelem_Ref);
						}
					}
				}

				if (callSuperParameter is not null)
					callback.Parameters.Add (callSuperParameter);

				callback.AddParameter ("exception_gchandle", new PointerType (System_IntPtr));

				if (isGeneric) {
					il.Emit (OpCodes.Call, MethodBase_Invoke);
					if (isVoid) {
						il.Emit (OpCodes.Pop);
					} else if (method.ReturnType.IsValueType) {
						il.Emit (OpCodes.Unbox_Any, method.ReturnType);
					} else {
						il.Emit (OpCodes.Castclass, method.ReturnType);
					}
				} else {
					il.Emit (OpCodes.Call, method);
				}

				if (returnVariable is not null) {
					if (EmitConversion (method, il, method.ReturnType, false, -1, out var nativeReturnType, postProcessing)) {
						returnVariable.VariableType = nativeReturnType;
						callback.ReturnType = nativeReturnType;
					} else {
						AddException (ErrorHelper.CreateWarning (99, "Unable to emit conversion for return value of type {0}. Method: {1}", method.ReturnType, GetMethodSignatureWithSourceCode (method)));
					}
					il.Emit (OpCodes.Stloc, returnVariable);
				} else {
					callback.ReturnType = System_Void;
				}

				body.Instructions.AddRange (postProcessing);

				Trace (il, $"EXIT");

				il.Emit (OpCodes.Leave, placeholderInstruction);
				leaveTryInstructions.Add (il.Body.Instructions.Last ());

				AddExceptionHandler (il, returnVariable, placeholderNextInstruction, out var eh, out var leaveEHInstruction);

				// Generate code to return null/default value/void
				if (returnVariable is not null) {
					var returnType = returnVariable.VariableType!;
					if (returnType.IsValueType) {
						// return default(<struct type>)
						il.Emit (OpCodes.Ldloca, returnVariable);
						il.Emit (OpCodes.Initobj, returnType);
						il.Emit (OpCodes.Ldloc, returnVariable);
					} else {
						il.Emit (OpCodes.Ldnull);
					}
				}
				il.Emit (OpCodes.Ret);

				// Generate code to return the return value
				Instruction leaveTryInstructionOperand;
				if (returnVariable is not null) {
					il.Emit (OpCodes.Ldloc, returnVariable);
					leaveTryInstructionOperand = il.Body.Instructions.Last ();
					il.Emit (OpCodes.Ret);
				} else {
					// Here we can re-use the ret instruction from the previous block.
					leaveTryInstructionOperand = il.Body.Instructions.Last ();
				}

				// Replace any 'placeholderNextInstruction' operands with the actual next instruction.
				foreach (var instr in body.Instructions) {
					if (object.ReferenceEquals (instr.Operand, placeholderNextInstruction))
						instr.Operand = instr.Next;
				}

				foreach (var instr in leaveTryInstructions)
					instr.Operand = leaveTryInstructionOperand;
				eh.HandlerEnd = (Instruction) leaveEHInstruction.Operand;

				if (exceptions.Count != initialExceptionCount) {
					var newExceptions = exceptions.Skip (initialExceptionCount);
					body.Instructions.Insert (0, il.Create (OpCodes.Ldstr, $"Conversion not implemented. Exceptions during process:\n\t{string.Join ("\n\t", newExceptions.Select (v => v.ToString ()))}"));
					body.Instructions.Insert (1, il.Create (OpCodes.Newobj, Exception_ctor_String));
					body.Instructions.Insert (2, il.Create (OpCodes.Throw));
					while (body.Instructions [3] != eh.TryEnd)
						body.Instructions.RemoveAt (3);
					exceptions.RemoveRange (initialExceptionCount, exceptions.Count - initialExceptionCount);
				}
			} catch (Exception e) {
				il.Emit (OpCodes.Ldstr, $"Exception occurred while creating trampoline: " + e);
				throw;
			}

			Dump (method, callback);
		}

		void AddExceptionHandler (ILProcessor il, VariableDefinition? returnVariable, Instruction placeholderNextInstruction, out ExceptionHandler eh, out Instruction leaveEHInstruction)
		{
			var body = il.Body;
			var method = body.Method;

			// Exception handler
			eh = new ExceptionHandler (ExceptionHandlerType.Catch);
			eh.CatchType = System_Exception;
			eh.TryStart = il.Body.Instructions [0];
			il.Body.ExceptionHandlers.Add (eh);

			var exceptionVariable = body.AddVariable (System_Exception);
			il.Emit (OpCodes.Stloc, exceptionVariable);
			eh.HandlerStart = il.Body.Instructions.Last ();
			eh.TryEnd = eh.HandlerStart;
			il.Emit (OpCodes.Ldarg, method.Parameters.Count - 1);
			il.Emit (OpCodes.Ldloc, exceptionVariable);
			il.Emit (OpCodes.Call, Runtime_AllocGCHandle);
			il.Emit (OpCodes.Stind_I);
			Trace (il, $"EXCEPTION");
			il.Emit (OpCodes.Leave, placeholderNextInstruction);
			leaveEHInstruction = body.Instructions.Last ();

			// Generate code to return null/default value/void
			if (returnVariable is not null) {
				var returnType = returnVariable.VariableType!;
				if (returnType.IsValueType) {
					// return default(<struct type>)
					il.Emit (OpCodes.Ldloca, returnVariable);
					il.Emit (OpCodes.Initobj, returnType);
					il.Emit (OpCodes.Ldloc, returnVariable);
				} else {
					il.Emit (OpCodes.Ldnull);
				}
			}
			il.Emit (OpCodes.Ret);
		}

		static string GetMethodSignature (MethodDefinition method)
		{
			return $"{method?.ReturnType?.FullName ?? "(null)"} {method?.DeclaringType?.FullName ?? "(null)"}::{method?.Name ?? "(null)"} ({string.Join (", ", method?.Parameters?.Select (v => v?.ParameterType?.FullName + " " + v?.Name) ?? Array.Empty<string> ())})";
		}

		static string GetMethodSignatureWithSourceCode (MethodDefinition method)
		{
			var rv = GetMethodSignature (method);
			if (method.HasBody && method.DebugInformation.HasSequencePoints) {
				var seq = method.DebugInformation.SequencePoints [0];
				rv += " " + seq.Document.Url + ":" + seq.StartLine.ToString () + " ";
			}
			return rv;
		}

		static void Dump (MethodDefinition method, MethodDefinition trampoline)
		{
			Action<string> log = Console.WriteLine;
			log ($"// created callback trampoline for: {GetMethodSignature (method)}");
			Dump (trampoline, log);
		}

		static void Dump (MethodDefinition method, Action<string> log)
		{
			log ($"{GetMethodSignature (method)}:");

			//foreach (var variable in method.Body.Variables)
			//	Console.WriteLine ($"    {variable.VariableType?.FullName}: V_{variable.Index}");
			//foreach (var instr in method.Body.Instructions) {
			//	string str;
			//	try {
			//		str = instr.ToString ();
			//	} catch (Exception e) {
			//		str = e.ToString ();
			//	}
			//	log ($"    IL_{instr.Offset:X4}: {str}");
			//}
		}


		bool IsNSObject (TypeReference type)
		{
			if (type is ArrayType)
				return false;

			if (type is ByReferenceType)
				return false;

			if (type is PointerType)
				return false;

			if (type is GenericParameter)
				return false;

			return type.IsNSObject (DerivedLinkContext);
		}

		BindAsAttribute? GetBindAsAttribute (MethodDefinition method, int parameter)
		{
			if (StaticRegistrar.IsPropertyAccessor (method, out var property)) {
				return StaticRegistrar.GetBindAsAttribute (property);
			} else {
				return StaticRegistrar.GetBindAsAttribute (method, parameter);
			}
		}

		void EmitCallToGetINativeObject (MethodDefinition method, ILProcessor il, TypeReference type)
		{
			var nativeObjType = StaticRegistrar.GetInstantiableType (type, exceptions, GetMethodSignature (method));
			il.Emit (OpCodes.Ldc_I4_0); // false
			il.Emit (OpCodes.Ldtoken, method.Module.ImportReference (type)); // target type
			il.Emit (OpCodes.Call, Type_GetTypeFromHandle);
			il.Emit (OpCodes.Ldtoken, method.Module.ImportReference (nativeObjType)); // implementation type
			il.Emit (OpCodes.Call, Type_GetTypeFromHandle);
			il.Emit (OpCodes.Call, Runtime_GetINativeObject__IntPtr_Boolean_Type_Type);
			il.Emit (OpCodes.Castclass, type);
		}

		// This emits a conversion between the native and the managed representation of a parameter or return value,
		// and returns the corresponding native type. The returned nativeType will (must) be a blittable type.
		bool EmitConversionImpl (MethodDefinition method, ILProcessor il, TypeReference type, bool toManaged, int parameter, [NotNullWhen (true)] out TypeReference? nativeType, List<Instruction> postProcessing)
		{
			nativeType = null;

			if (!(parameter == -1 && !method.IsStatic && method.DeclaringType == type)) {
				var bindAsAttribute = GetBindAsAttribute (method, parameter);
				if (bindAsAttribute is not null) {
					if (toManaged) {
						// if (parameter != -1) {
						GenerateConversionToManaged (method, il, bindAsAttribute.OriginalType, type, "descriptiveMethodName", parameter, out nativeType);
						return true;
						// }
					} else {
						GenerateConversionToNative (method, il, type, bindAsAttribute.OriginalType, "descriptiveMethodName", out nativeType);
						return true;
					}
				}
			}

			if (type.Is ("System", "Void")) {
				if (parameter == -1 && method.IsConstructor) {
					if (toManaged) {
						AddException (ErrorHelper.CreateWarning (99, "Don't know how (9) to convert ctor. Method: {0}", GetMethodSignatureWithSourceCode (method)));
					} else {
						il.Emit (OpCodes.Call, NativeObjectExtensions_GetHandle);
						nativeType = ObjCRuntime_NativeHandle;
						return true;
					}
				}
				AddException (ErrorHelper.CreateWarning (99, "Can't convert System.Void. Method: {0}", GetMethodSignatureWithSourceCode (method)));
				return false;
			}

			if (type.IsValueType) {
				if (type.Is ("System", "Boolean")) {
					if (toManaged) {
						// nothing to do I think
					} else {
						// FIXME: verify if this sequence is really necessary.
						var ldc_1 = il.Create (OpCodes.Ldc_I4_1);
						var nop = il.Create (OpCodes.Nop);
						il.Emit (OpCodes.Brtrue_S, ldc_1);
						il.Emit (OpCodes.Ldc_I4_0);
						il.Emit (OpCodes.Br_S, nop);
						il.Append (ldc_1);
						il.Append (nop);
					}
					nativeType = System_Byte;
					return true;
				}

				// no conversion necessary if we're any other value type
				nativeType = type;
				return true;
			}

			if (type is ByReferenceType brt) {
				if (toManaged) {
					var elementType = brt.ElementType;
					if (elementType is GenericParameter gp) {
						if (!StaticRegistrar.VerifyIsConstrainedToNSObject (gp, out var constrained)) {
							AddException (ErrorHelper.CreateWarning (99, "Incorrectly constrained generic parameter. Method: {0}", GetMethodSignatureWithSourceCode (method)));
							return false;
						}
						elementType = constrained;
					}

					if (elementType.IsValueType) {
						// call !!0& [System.Runtime]System.Runtime.CompilerServices.Unsafe::AsRef<int32>(void*)
						var mr = new GenericInstanceMethod (CurrentAssembly.MainModule.ImportReference (Unsafe_AsRef));
						mr.GenericArguments.Add (elementType);
						il.Emit (OpCodes.Call, mr);
						// reference types aren't blittable, so the managed signature must have be a pointer type
						nativeType = new PointerType (elementType);
						return true;
					} else if (elementType is ArrayType elementArrayType) {
						var indirectVariable = il.Body.AddVariable (elementType);
						var copyIndirectVariable = il.Body.AddVariable (elementType);
						if (IsOutParameter (method, parameter)) {
							il.Emit (OpCodes.Pop); // We don't read the input for 'out' parameters, it might be garbage.
						} else {
							il.Emit (OpCodes.Ldind_I);
							var gim = new GenericInstanceMethod (NSArray_ArrayFromHandle);
							gim.GenericArguments.Add (elementType);
							il.Emit (OpCodes.Call, gim);
							il.Emit (OpCodes.Stloc, indirectVariable);
							il.Emit (OpCodes.Ldloc, indirectVariable);
							// We store a copy of the string in a separate variable, to detect if it changes.
							// Note that we won't notice if individual array elements change, only if the array itself changes
							il.Emit (OpCodes.Stloc, copyIndirectVariable);
						}
						il.Emit (OpCodes.Ldloca, indirectVariable);
						// post processing too. We check if the array has changed, and if so, we convert it to an NSArray.
						// Note that we won't notice if individual array elements change, only if the array itself changes
						var noOutputRequired = il.Create (OpCodes.Nop);
						postProcessing.Add (il.Create (OpCodes.Ldloc, indirectVariable));
						postProcessing.Add (il.Create (OpCodes.Ldloc, copyIndirectVariable));
						postProcessing.Add (il.Create (OpCodes.Beq, noOutputRequired));
						postProcessing.Add (il.Create (OpCodes.Ldloc, indirectVariable));
						postProcessing.Add (il.Create (OpCodes.Call, NSArray_FromNSObjects__INativeObjects));
						postProcessing.Add (il.Create (OpCodes.Call, NativeObjectExtensions_GetHandle));
						postProcessing.Add (il.Create (OpCodes.Stind_I));
						postProcessing.Add (noOutputRequired);

						nativeType = new PointerType (System_IntPtr);
						return true;
					} else if (elementType.Is ("System", "String")) {
						var indirectVariable = il.Body.AddVariable (elementType);
						var copyIndirectVariable = il.Body.AddVariable (elementType);
						if (IsOutParameter (method, parameter)) {
							il.Emit (OpCodes.Pop); // We don't read the input for 'out' parameters, it might be garbage.
						} else {
							il.Emit (OpCodes.Ldind_I);
							il.Emit (OpCodes.Call, CFString_FromHandle);
							il.Emit (OpCodes.Stloc, indirectVariable);
							il.Emit (OpCodes.Ldloc, indirectVariable);
							// We store a copy of the string in a separate variable, to detect if it changes.
							il.Emit (OpCodes.Stloc, copyIndirectVariable);
						}
						il.Emit (OpCodes.Ldloca, indirectVariable);

						// post processing too. We check if the ref string has changed, and if so, we convert it to an NSString.
						var noOutputRequired = il.Create (OpCodes.Nop);
						postProcessing.Add (il.Create (OpCodes.Ldloc, indirectVariable));
						postProcessing.Add (il.Create (OpCodes.Ldloc, copyIndirectVariable));
						postProcessing.Add (il.Create (OpCodes.Beq, noOutputRequired));
						postProcessing.Add (il.Create (OpCodes.Ldloc, indirectVariable));
						postProcessing.Add (il.Create (OpCodes.Call, CFString_CreateNative));
						postProcessing.Add (il.Create (OpCodes.Stind_I));
						postProcessing.Add (noOutputRequired);

						nativeType = new PointerType (System_IntPtr);
						return true;
					} else if (elementType.IsNSObject (DerivedLinkContext)) {
						var indirectVariable = il.Body.AddVariable (elementType);
						if (IsOutParameter (method, parameter)) {
							il.Emit (OpCodes.Pop); // We don't read the input for 'out' parameters, it might be garbage.
						} else {
							il.Emit (OpCodes.Ldind_I);
							il.Emit (OpCodes.Call, Runtime_GetNSObject__System_IntPtr);
							if (!elementType.Is ("Foundation", "NSObject"))
								il.Emit (OpCodes.Castclass, elementType);
							il.Emit (OpCodes.Stloc, indirectVariable);
						}
						il.Emit (OpCodes.Ldloca, indirectVariable);

						// post processing too
						postProcessing.Add (il.Create (OpCodes.Ldarg, parameter + 2));
						postProcessing.Add (il.Create (OpCodes.Ldloc, indirectVariable));
						postProcessing.Add (il.Create (OpCodes.Call, NativeObjectExtensions_GetHandle));
						postProcessing.Add (il.Create (OpCodes.Call, NativeObject_op_Implicit_IntPtr));
						postProcessing.Add (il.Create (OpCodes.Stind_I));
						nativeType = new PointerType (System_IntPtr);
						return true;
					} else if (StaticRegistrar.IsNativeObject (DerivedLinkContext, elementType)) {
						var indirectVariable = il.Body.AddVariable (elementType);
						if (IsOutParameter (method, parameter)) {
							il.Emit (OpCodes.Pop);
						} else {
							il.Emit (OpCodes.Ldind_I);
							EmitCallToGetINativeObject (method, il, type);
							il.Emit (OpCodes.Stloc, indirectVariable);
						}
						il.Emit (OpCodes.Ldloca, indirectVariable);

						// post processing too
						postProcessing.Add (il.Create (OpCodes.Ldarg, parameter + 2));
						postProcessing.Add (il.Create (OpCodes.Ldloc, indirectVariable));
						postProcessing.Add (il.Create (OpCodes.Call, NativeObjectExtensions_GetHandle));
						postProcessing.Add (il.Create (OpCodes.Call, NativeObject_op_Implicit_IntPtr));
						postProcessing.Add (il.Create (OpCodes.Stind_I));
						nativeType = new PointerType (System_IntPtr);
						return true;

					}
				}
				AddException (ErrorHelper.CreateWarning (99, "Don't know how (2) to convert {0} between managed and native code. Method: {1}", type.FullName, GetMethodSignatureWithSourceCode (method)));
				return false;
			}

			if (type is ArrayType at) {
				var elementType = at.GetElementType ();
				if (elementType.Is ("System", "String")) {
					il.Emit (OpCodes.Call, toManaged ? CFArray_StringArrayFromHandle : CFArray_Create);
					nativeType = ObjCRuntime_NativeHandle;
					return true;
				}

				if (elementType is GenericParameter gp) {
					if (!StaticRegistrar.VerifyIsConstrainedToNSObject (gp, out var constrained)) {
						AddException (ErrorHelper.CreateWarning (99, "Incorrectly constrained generic parameter. Method: {0}", GetMethodSignatureWithSourceCode (method)));
						return false;
					}
					elementType = constrained;
				}

				if (elementType.IsNSObject (DerivedLinkContext) || StaticRegistrar.IsNativeObject (elementType)) {
					if (toManaged) {
						var gim = new GenericInstanceMethod (NSArray_ArrayFromHandle);
						gim.GenericArguments.Add (elementType);
						il.Emit (OpCodes.Call, gim);
					} else {
						il.Emit (OpCodes.Call, NSArray_FromNSObjects__INativeObjects);
						il.Emit (OpCodes.Call, NativeObjectExtensions_GetHandle);
					}
					nativeType = ObjCRuntime_NativeHandle;
					return true;
				}

				AddException (ErrorHelper.CreateWarning (99, "Don't know how (3) to convert array element type {1} for array type {0} between managed and native code. Method: {2}", type.FullName, elementType.FullName, GetMethodSignatureWithSourceCode (method)));
				return false;
			}

			if (IsNSObject (type)) {
				if (toManaged) {
					// FIXME: argument semantics
					il.Emit (OpCodes.Call, Runtime_GetNSObject__System_IntPtr);
					if (!type.Is ("Foundation", "NSObject") && !type.HasGenericParameters)
						il.Emit (OpCodes.Castclass, type);
					nativeType = System_IntPtr;
				} else {
					if (parameter == -1) {
						var retain = StaticRegistrar.HasReleaseAttribute (method);
						il.Emit (OpCodes.Dup);
						if (retain) {
							il.Emit (OpCodes.Call, Runtime_RetainObject);
						} else {
							il.Emit (OpCodes.Call, Runtime_RetainAndAutorelease);
						}
					}
					il.Emit (OpCodes.Call, NativeObjectExtensions_GetHandle);
					nativeType = ObjCRuntime_NativeHandle;
				}
				return true;
			}

			if (StaticRegistrar.IsNativeObject (DerivedLinkContext, type)) {
				if (toManaged) {
					if (type is GenericParameter gp) {
						// FIXME: check that gp is constrained to NSObject
						il.Emit (OpCodes.Call, Runtime_GetNSObject__System_IntPtr);

						// var nativeObjType = StaticRegistrar.GetInstantiableType (type, exceptions, GetMethodSignature (method));
						// il.Emit (OpCodes.Ldc_I4_0); // false
						// il.Emit (OpCodes.Ldtoken, method.Module.ImportReference (type)); // target type
						// il.Emit (OpCodes.Call, Type_GetTypeFromHandle);
						// il.Emit (OpCodes.Ldtoken, method.Module.ImportReference (nativeObjType)); // implementation type
						// il.Emit (OpCodes.Call, Type_GetTypeFromHandle);
						// il.Emit (OpCodes.Call, Runtime_GetINativeObject__IntPtr_Boolean_Type_Type);
						// il.Emit (OpCodes.Castclass, type);
						
					} else {
						EmitCallToGetINativeObject (method, il, type);
					}
					nativeType = System_IntPtr;
				} else {
					if (parameter == -1 && StaticRegistrar.HasReleaseAttribute (method)) {
						il.Emit (OpCodes.Dup);
						il.Emit (OpCodes.Call, Runtime_RetainObject);
					}
					il.Emit (OpCodes.Call, NativeObjectExtensions_GetHandle);
					nativeType = ObjCRuntime_NativeHandle;
				}
				return true;
			}

			if (type.Is ("System", "String")) {
				il.Emit (OpCodes.Call, toManaged ? CFString_FromHandle : CFString_CreateNative);
				nativeType = ObjCRuntime_NativeHandle;
				return true;
			}

			if (StaticRegistrar.IsDelegate (type.Resolve ())) {
				if (!StaticRegistrar.TryFindMethod (method, out var objcMethod)) {
					AddException (ErrorHelper.CreateWarning (99, "Unable to find method {0}", GetMethodSignature (method)));
					return false;
				}
				if (toManaged) {
					var createMethod = StaticRegistrar.GetBlockWrapperCreator (objcMethod, parameter);
					if (createMethod is null) {
						AddException (ErrorHelper.CreateWarning (App, 4174 /* Unable to locate the block to delegate conversion method for the method {0}'s parameter #{1}. */, method, Errors.MT4174, method.FullName, parameter + 1));
						var tmpVariable = il.Body.AddVariable (System_IntPtr);
						il.Emit (OpCodes.Stloc, tmpVariable);
						il.Emit (OpCodes.Ldtoken, method);
						il.Emit (OpCodes.Call, MethodBase_GetMethodFromHandle);
						il.Emit (OpCodes.Castclass, System_Reflection_MethodInfo);
						il.Emit (OpCodes.Ldc_I4, parameter);
						il.Emit (OpCodes.Call, Runtime_GetBlockWrapperCreator);
						il.Emit (OpCodes.Ldloc, tmpVariable);
						il.Emit (OpCodes.Call, Runtime_CreateBlockProxy);
					} else {
						il.Emit (OpCodes.Call, BlockLiteral_Copy);
						il.Emit (OpCodes.Dup);
						il.Emit (OpCodes.Call, method.Module.ImportReference (createMethod));
						il.Emit (OpCodes.Call, Runtime_ReleaseBlockWhenDelegateIsCollected);
					}
				} else {
					if (!DerivedLinkContext.StaticRegistrar.TryComputeBlockSignature (method, trampolineDelegateType: type, out var exception, out var signature)) {
						AddException (ErrorHelper.CreateWarning (99, "Error while converting block/delegates: FIXME better error: {0}", exception.ToString ()));
						return false;
					}
					var delegateProxyType = StaticRegistrar.GetDelegateProxyType (objcMethod);
					FieldDefinition? delegateProxyField = null;
					if (delegateProxyType is null) {
						exceptions.Add (ErrorHelper.CreateWarning (App, 4176, method, Errors.MT4176 /* "Unable to locate the delegate to block conversion type for the return value of the method {0}." */, method.FullName));
					} else {
						delegateProxyField = delegateProxyType.Fields.SingleOrDefault (v => v.Name == "Handler");
						if (delegateProxyField is null) {
							AddException (ErrorHelper.CreateWarning (99, "No delegate proxy field on {0}", delegateProxyType.FullName)); // FIXME: better error message
						}
					}
					if (delegateProxyField is null) {
						var tmpVariable = il.Body.AddVariable (type);
						il.Emit (OpCodes.Stloc, tmpVariable);
						il.Emit (OpCodes.Ldtoken, method);
						il.Emit (OpCodes.Call, MethodBase_GetMethodFromHandle);
						il.Emit (OpCodes.Castclass, System_Reflection_MethodInfo);
						il.Emit (OpCodes.Ldloc, tmpVariable);
						il.Emit (OpCodes.Ldc_I4_M1);
						il.Emit (OpCodes.Ldnull);
						il.Emit (OpCodes.Call, BlockLiteral_GetBlockForDelegate);
						return false;
					} else {
						EnsureVisible (method, delegateProxyField);
						// the delegate is already on the stack
						il.Emit (OpCodes.Ldsfld, method.Module.ImportReference (delegateProxyField));
						il.Emit (OpCodes.Ldstr, signature);
						il.Emit (OpCodes.Call, BlockLiteral_CreateBlockForDelegate);
					}
				}
				nativeType = System_IntPtr;
				return true;
			}

			AddException (ErrorHelper.CreateWarning (99, "Don't know how (1) to convert {0} between managed and native code: {1}. Method: {2}", type.FullName, type.GetType ().FullName, GetMethodSignatureWithSourceCode (method)));
			return false;
		}

		bool EmitConversion (MethodDefinition method, ILProcessor il, TypeReference type, bool toManaged, int parameter, [NotNullWhen (true)] out TypeReference? nativeType, List<Instruction> postProcessing)
		{
			nativeType = null;
			try {
				return EmitConversionImpl (method, il, type, toManaged, parameter, out nativeType, postProcessing);
			} catch (Exception e) {
				AddException (ErrorHelper.CreateWarning (99, e, "Failed to process {0}: {1}", method.FullName, e.Message));
				return false;
			}
		}

		void EnsureVisible (MethodDefinition caller, FieldDefinition field)
		{
			field.IsPublic = true;
			EnsureVisible (caller, field.DeclaringType);
		}


		void EnsureVisible (MethodDefinition caller, TypeDefinition type)
		{
			if (type.IsNested) {
				type.IsNestedPublic = true;
				EnsureVisible (caller, type.DeclaringType);
			} else {
				type.IsPublic = true;
			}
		}

		bool IsOutParameter (MethodDefinition method, int parameter)
		{
			return method.Parameters [parameter].IsOut;
		}

		StaticRegistrar StaticRegistrar {
			get { return DerivedLinkContext.StaticRegistrar; }
		}

		CustomAttribute CreateUnmanagedCallersAttribute (string entryPoint)
		{
			var unmanagedCallersAttribute = new CustomAttribute (UnmanagedCallersOnlyAttribute_Constructor);
			unmanagedCallersAttribute.Fields.Add (new CustomAttributeNamedArgument ("EntryPoint", new CustomAttributeArgument (System_String, entryPoint)));
			return unmanagedCallersAttribute;
		}

		void GenerateConversionToManaged (MethodDefinition method, ILProcessor il, TypeReference inputType, TypeReference outputType, string descriptiveMethodName, int parameter, out TypeReference nativeCallerType)
		{
			// This is a mirror of the native method xamarin_generate_conversion_to_managed (for the dynamic registrar).
			// It's also a mirror of the method ManagedRegistrarStep.GenerateConversionToManaged.
			// These methods must be kept in sync.
			var managedType = outputType;
			var nativeType = inputType;

			var isManagedNullable = StaticRegistrar.IsNullable (managedType);

			var underlyingManagedType = managedType;
			var underlyingNativeType = nativeType;

			var isManagedArray = StaticRegistrar.IsArray (managedType);
			var isNativeArray = StaticRegistrar.IsArray (nativeType);

			nativeCallerType = System_IntPtr;

			if (isManagedArray != isNativeArray)
				throw ErrorHelper.CreateError (99, Errors.MX0099, $"can't convert from '{inputType.FullName}' to '{outputType.FullName}' in {descriptiveMethodName}");
			//var classVariableName = $"{inputName}_conv_class";
			//body_setup.AppendLine ($"MonoClass *{classVariableName} = NULL;");
			if (isManagedArray) {
				if (isManagedNullable)
					throw ErrorHelper.CreateError (99, Errors.MX0099, $"can't convert from '{inputType.FullName}' to '{outputType.FullName}' in {descriptiveMethodName}");
				underlyingNativeType = StaticRegistrar.GetElementType (nativeType);
				underlyingManagedType = StaticRegistrar.GetElementType (managedType);
				//sb.AppendLine ($"{classVariableName} = mono_class_get_element_class ({managedClassExpression});");
				//cleanup.AppendLine ($"xamarin_mono_object_release (&{classVariableName});");
			} else if (isManagedNullable) {
				underlyingManagedType = StaticRegistrar.GetNullableType (managedType);
				//sb.AppendLine ($"{classVariableName} = xamarin_get_nullable_type ({managedClassExpression}, &exception_gchandle);");
				//sb.AppendLine ($"if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;");
				//cleanup.AppendLine ($"xamarin_mono_object_release (&{classVariableName});");
			} else {
				//sb.AppendLine ($"{classVariableName} = {managedClassExpression};");
			}

			//CheckNamespace (underlyingNativeType.Resolve (), exceptions);
			//CheckNamespace (underlyingManagedType.Resolve (), exceptions);

			//if (isManagedNullable || isManagedArray)
			//	sb.AppendLine ($"if ({inputName}) {{");

			string? func = null;
			MethodReference? conversionFunction = null;
			MethodReference? conversionFunction2 = null;
			//string nativeTypeName;
			//string token = "0";
			if (underlyingNativeType.Is ("Foundation", "NSNumber")) {
				func = StaticRegistrar.GetNSNumberToManagedFunc (underlyingManagedType, inputType, outputType, descriptiveMethodName, out var _);
			} else if (underlyingNativeType.Is ("Foundation", "NSValue")) {
				func = StaticRegistrar.GetNSValueToManagedFunc (underlyingManagedType, inputType, outputType, descriptiveMethodName, out var _);
			} else if (underlyingNativeType.Is ("Foundation", "NSString")) {
				// func = StaticRegistrar.GetNSStringToSmartEnumFunc (underlyingManagedType, inputType, outputType, descriptiveMethodName, managedClassExpression, out nativeTypeName);
				// MethodDefinition getConstantMethod, getValueMethod;
				if (!StaticRegistrar.IsSmartEnum (underlyingManagedType, out var getConstantMethod, out var getValueMethod)) {
					// method linked away!? this should already be verified
					AddException (ErrorHelper.CreateWarning (99, Errors.MX0099, $"the smart enum {underlyingManagedType.FullName} doesn't seem to be a smart enum after all"));
					//	token = "INVALID_TOKEN_REF";
					//} else if (TryCreateTokenReference (getValueMethod, TokenType.Method, out var get_value_method_token_ref, out _)) {
					//	token = $"0x{get_value_method_token_ref:X} /* {getValueMethod.FullName} */";
					return;
				}

				var gim = new GenericInstanceMethod (Runtime_GetNSObject_T___System_IntPtr);
				gim.GenericArguments.Add (Foundation_NSString);
				conversionFunction = gim;

				conversionFunction2 = CurrentAssembly.MainModule.ImportReference (getValueMethod);
			} else {
				throw ErrorHelper.CreateError (99, Errors.MX0099, $"can't convert from '{inputType.FullName}' to '{outputType.FullName}' in {descriptiveMethodName}");
			}

			if (func is not null) {
				conversionFunction = GetMethodReference (PlatformAssembly, ObjCRuntime_BindAs, func, func, (v) =>
						v.IsStatic, out MethodDefinition conversionFunctionDefinition, ensurePublic: true);
				EnsureVisible (method, conversionFunctionDefinition.DeclaringType);
			}

			if (isManagedArray) {
				//sb.AppendLine ($"xamarin_id_to_managed_func {inputName}_conv_func = (xamarin_id_to_managed_func) {func};");
				//body_setup.AppendLine ("MonoArray *arr_convert_{0} = NULL;", parameter);
				//cleanup.AppendLine ("xamarin_mono_object_release (&arr_convert_{0});", parameter);
				//sb.AppendLine ("if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;");
				//sb.AppendLine ($"arr_convert_{parameter} = xamarin_convert_nsarray_to_managed_with_func ({inputName}, {classVariableName}, {inputName}_conv_func, GINT_TO_POINTER ({token}), &exception_gchandle);");
				//sb.AppendLine ($"{outputName} = arr_convert_{parameter};");
				//sb.AppendLine ("if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;");
				il.Emit (OpCodes.Ldftn, conversionFunction);
				if (conversionFunction2 is not null) {
					il.Emit (OpCodes.Ldftn, conversionFunction2);
					var gim = new GenericInstanceMethod (BindAs_ConvertNSArrayToManagedArray2);
					gim.GenericArguments.Add (underlyingManagedType);
					gim.GenericArguments.Add (Foundation_NSString);
					il.Emit (OpCodes.Call, gim);
				} else {
					var gim = new GenericInstanceMethod (BindAs_ConvertNSArrayToManagedArray);
					gim.GenericArguments.Add (underlyingManagedType);
					il.Emit (OpCodes.Call, gim);
				}
				nativeCallerType = System_IntPtr;
			} else {
				//var tmpName = $"{inputName}_conv_tmp";
				//body_setup.AppendLine ($"{nativeTypeName} {tmpName};");
				if (isManagedNullable) {
					il.Emit (OpCodes.Ldftn, conversionFunction);
					if (conversionFunction2 is not null) {
						il.Emit (OpCodes.Ldftn, conversionFunction2);
						var gim = new GenericInstanceMethod (BindAs_CreateNullable2);
						gim.GenericArguments.Add (underlyingManagedType);
						gim.GenericArguments.Add (Foundation_NSString);
						il.Emit (OpCodes.Call, gim);
					} else {
						var gim = new GenericInstanceMethod (BindAs_CreateNullable);
						gim.GenericArguments.Add (underlyingManagedType);
						il.Emit (OpCodes.Call, gim);
					}
					//var tmpName2 = $"{inputName}_conv_ptr";
					//body_setup.AppendLine ($"void *{tmpName2} = NULL;");
					//sb.AppendLine ($"{tmpName2} = {func} ({inputName}, &{tmpName}, {classVariableName}, GINT_TO_POINTER ({token}), &exception_gchandle);");
					//sb.AppendLine ("if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;");
					//body_setup.AppendLine ($"MonoObject *mobj_conversion_{parameter} = NULL;");
					//sb.AppendLine ($"mobj_conversion_{parameter} = mono_value_box (mono_domain_get (), {classVariableName}, {tmpName2});");
					//sb.AppendLine ($"{outputName} = mobj_conversion_{parameter};");
					//cleanup.AppendLine ($"xamarin_mono_object_release (&mobj_conversion_{parameter});");
					nativeCallerType = System_IntPtr;
				} else {
					//sb.AppendLine ($"{outputName} = {func} ({inputName}, &{tmpName}, {classVariableName}, GINT_TO_POINTER ({token}), &exception_gchandle);");
					//sb.AppendLine ("if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;");
					il.Emit (OpCodes.Call, conversionFunction);
					if (conversionFunction2 is not null)
						il.Emit (OpCodes.Call, conversionFunction2);
					nativeCallerType = System_IntPtr;
				}
			}

			//if (isManagedNullable || isManagedArray) {
			//	sb.AppendLine ($"}} else {{");
			//	sb.AppendLine ($"{outputName} = NULL;");
			//	sb.AppendLine ($"}}");
			//}
		}

		void GenerateConversionToNative (MethodDefinition method, ILProcessor il, TypeReference inputType, TypeReference outputType, string descriptiveMethodName, out TypeReference nativeCallerType)
		{
			// This is a mirror of the native method xamarin_generate_conversion_to_native (for the dynamic registrar).
			// These methods must be kept in sync.
			var managedType = inputType;
			var nativeType = outputType;

			var isManagedNullable = StaticRegistrar.IsNullable (managedType);

			var underlyingManagedType = managedType;
			var underlyingNativeType = nativeType;

			var isManagedArray = StaticRegistrar.IsArray (managedType);
			var isNativeArray = StaticRegistrar.IsArray (nativeType);

			nativeCallerType = System_IntPtr;

			if (isManagedArray != isNativeArray)
				throw ErrorHelper.CreateError (99, Errors.MX0099, $"can't convert from '{inputType.FullName}' to '{outputType.FullName}' in {descriptiveMethodName}");

			// var classVariableName = $"{inputName}_conv_class";
			// body_setup.AppendLine ($"MonoClass *{classVariableName} = NULL;");
			if (isManagedArray) {
				if (isManagedNullable)
					throw ErrorHelper.CreateError (99, Errors.MX0099, $"can't convert from '{inputType.FullName}' to '{outputType.FullName}' in {descriptiveMethodName}");
				underlyingNativeType = StaticRegistrar.GetElementType (nativeType);
				underlyingManagedType = StaticRegistrar.GetElementType (managedType);
				// sb.AppendLine ($"{classVariableName} = mono_class_get_element_class ({managedClassExpression});");
				// cleanup.AppendLine ($"xamarin_mono_object_release (&{classVariableName});");
			} else if (isManagedNullable) {
				underlyingManagedType = StaticRegistrar.GetNullableType (managedType);
				// sb.AppendLine ($"{classVariableName} = xamarin_get_nullable_type ({managedClassExpression}, &exception_gchandle);");
				// sb.AppendLine ($"if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;");
				// cleanup.AppendLine ($"xamarin_mono_object_release (&{classVariableName});");
			} else {
				// sb.AppendLine ($"{classVariableName} = {managedClassExpression};");
			}

			// StaticRegistrar.CheckNamespace (underlyingNativeType.Resolve (), exceptions);
			// StaticRegistrar.CheckNamespace (underlyingManagedType.Resolve (), exceptions);

			// if (isManagedNullable || isManagedArray)
			// 	sb.AppendLine ($"if ({inputName}) {{");

			string? func = null;
			MethodReference? conversionFunction = null;
			MethodReference? conversionFunction2 = null;
			if (underlyingNativeType.Is ("Foundation", "NSNumber")) {
				func = StaticRegistrar.GetManagedToNSNumberFunc (underlyingManagedType, inputType, outputType, descriptiveMethodName);
			} else if (underlyingNativeType.Is ("Foundation", "NSValue")) {
				func = StaticRegistrar.GetManagedToNSValueFunc (underlyingManagedType, inputType, outputType, descriptiveMethodName);
			} else if (underlyingNativeType.Is ("Foundation", "NSString")) {
				// func = StaticRegistrar.GetSmartEnumToNSStringFunc (underlyingManagedType, inputType, outputType, descriptiveMethodName, classVariableName);
				if (!StaticRegistrar.IsSmartEnum (underlyingManagedType, out var getConstantMethod, out var getValueMethod)) {
					// method linked away!? this should already be verified
					ErrorHelper.Show (ErrorHelper.CreateWarning (99, Errors.MX0099, $"the smart enum {underlyingManagedType.FullName} doesn't seem to be a smart enum after all"));
					return;
				}

				conversionFunction = CurrentAssembly.MainModule.ImportReference (getConstantMethod);
				conversionFunction2 = NativeObjectExtensions_GetHandle;
 			} else {
				AddException (ErrorHelper.CreateError (99, Errors.MX0099, $"can't convert from '{inputType.FullName}' to '{outputType.FullName}' in {descriptiveMethodName}"));
				return;
			}
			
			if (func is not null) {
				conversionFunction = GetMethodReference (PlatformAssembly, ObjCRuntime_BindAs, func, func, (v) =>
						v.IsStatic, out MethodDefinition conversionFunctionDefinition, ensurePublic: true);
				EnsureVisible (method, conversionFunctionDefinition.DeclaringType);
			}

			if (isManagedArray) {
				il.Emit (OpCodes.Ldftn, conversionFunction);
				if (conversionFunction2 is not null) {
					il.Emit (OpCodes.Ldftn, conversionFunction2);
					var gim = new GenericInstanceMethod (BindAs_ConvertManagedArrayToNSArray2);
					gim.GenericArguments.Add (underlyingManagedType);
					gim.GenericArguments.Add (Foundation_NSString);
					il.Emit (OpCodes.Call, gim);
				} else {
					var gim = new GenericInstanceMethod (BindAs_ConvertManagedArrayToNSArray);
					gim.GenericArguments.Add (underlyingManagedType);
					il.Emit (OpCodes.Call, gim);
				}
			} else {
				il.Emit (OpCodes.Call, conversionFunction);
				if (conversionFunction2 is not null)
					il.Emit (OpCodes.Call, conversionFunction2);
			}
			// sb.AppendLine ($"if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;");

			// if (isManagedNullable || isManagedArray) {
			// 	sb.AppendLine ($"}} else {{");
			// 	sb.AppendLine ($"{outputName} = NULL;");
			// 	sb.AppendLine ($"}}");
			// }
		}
	}
}

static class Cecil_Extensions {
	public static VariableDefinition AddVariable (this MethodBody self, TypeReference variableType)
	{
		var rv = new VariableDefinition (variableType);
		self.Variables.Add (rv);
		return rv;
	}

	public static ParameterDefinition AddParameter (this MethodDefinition self, string name, TypeReference parameterType)
	{
		var rv = new ParameterDefinition (name, ParameterAttributes.None, parameterType);
		self.Parameters.Add (rv);
		return rv;
	}

	public static MethodDefinition AddMethod (this TypeDefinition self, string name, MethodAttributes attributes, TypeReference returnType)
	{
		var rv = new MethodDefinition (name, attributes, returnType);
		rv.DeclaringType = self;
		self.Methods.Add (rv);
		return rv;
	}

	public static MethodBody CreateBody (this MethodDefinition self, out ILProcessor il)
	{
		var body = new MethodBody (self);
		self.Body = body;
		il = body.GetILProcessor ();
		return body;
	}

	public static void AddRange<T> (this Mono.Collections.Generic.Collection<T> self, IEnumerable<T>? items)
	{
		if (items is null)
			return;

		foreach (var item in items) {
			self.Add (item);
		}
	}
}
