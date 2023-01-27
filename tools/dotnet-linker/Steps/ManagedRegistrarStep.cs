using System;
using System.Collections.Generic;
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

#nullable enable

namespace Xamarin.Linker {
	public class ManagedRegistrarStep : ConfigurationAwareStep {
		protected override string Name { get; } = "ManagedRegistrar";
		protected override int ErrorCode { get; } = 2430;

		List<Exception>? exceptions;
		Application? app;

		AssemblyDefinition? current_assembly;

		AssemblyDefinition? corlib_assembly;
		AssemblyDefinition? platform_assembly;

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

		Dictionary<AssemblyDefinition, Dictionary<string, (TypeDefinition, TypeReference)>> type_map = new Dictionary<AssemblyDefinition, Dictionary<string, (TypeDefinition, TypeReference)>> ();
		Dictionary<string, (MethodDefinition, MethodReference)> method_map = new Dictionary<string, (MethodDefinition, MethodReference)> ();

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

		MethodReference GetMethodReference (AssemblyDefinition assembly, TypeReference tr, string name)
		{
			return GetMethodReference (assembly, tr, name, tr.FullName + "::" + name, null, out var _);
		}

		MethodReference GetMethodReference (AssemblyDefinition assembly, TypeReference tr, string name, Func<MethodDefinition, bool>? predicate)
		{
			return GetMethodReference (assembly, tr, name, tr.FullName + "::" + name, predicate, out var _);
		}

		MethodReference GetMethodReference (AssemblyDefinition assembly, TypeReference tr, string name, string key, Func<MethodDefinition, bool>? predicate, out MethodDefinition method)
		{
			if (!method_map.TryGetValue (key, out var tuple)) {
				var td = tr.Resolve ();
				var md = td.Methods.SingleOrDefault (v => v.Name == name && (predicate is null || predicate (v)));
				if (md is null)
					throw new InvalidOperationException ($"Unable to find the method '{tr.FullName}::{name}' (for key '{key}') in {assembly.Name.Name}");

				tuple.Item1 = md;
				tuple.Item2 = CurrentAssembly.MainModule.ImportReference (md);
				method_map.Add (key, tuple);
			}

			method = tuple.Item1;
			return tuple.Item2;
		}

		TypeReference System_IntPtr {
			get {
				return GetTypeReference (CorlibAssembly, "System.IntPtr", out var _);
			}
		}

		TypeReference System_String {
			get {
				return GetTypeReference (CorlibAssembly, "System.String", out var _);
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

		TypeReference ObjCRuntime_NativeObjectExtensions {
			get {
				return GetTypeReference (PlatformAssembly, "ObjCRuntime.NativeObjectExtensions", out var _);
			}
		}

		MethodReference Runtime_GetNSObject {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "GetNSObject", (v) => 
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("System", "IntPtr")
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

		MethodReference NativeObjectExtensions_GetHandle {
			get {
				return GetMethodReference (PlatformAssembly, ObjCRuntime_NativeObjectExtensions, "GetHandle");
			}
		}

		MethodReference UnmanagedCallersOnlyAttribute_Constructor {
			get {
				return GetMethodReference (CorlibAssembly, "System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute", "GetHandle", (v) => v.IsDefaultConstructor ());
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
		}

		protected override void TryEndProcess ()
		{
			base.TryEndProcess ();

			if (exceptions is null)
				return;
			if (exceptions.Count == 1)
				throw exceptions [0];
			throw new AggregateException (exceptions);
		}

		protected override void TryProcessAssembly (AssemblyDefinition assembly)
		{
			base.TryProcessAssembly (assembly);

			if (app!.Registrar != RegistrarMode.ManagedStatic)
				return;

			if (Annotations.GetAction (assembly) == AssemblyAction.Delete)
				return;

			if (assembly.Name.Name == Driver.CorlibName) {
				corlib_assembly = assembly;
				return;
			}

			if (Configuration.Profile.IsProductAssembly (assembly))
				platform_assembly = assembly;

			// FIXME: Skip assemblies that aren't our platform assembly or references our platform assembly

			if (!assembly.MainModule.HasTypes)
				return;

			current_assembly = assembly;

			var modified = false;
			foreach (var type in assembly.MainModule.Types)
				modified |= ProcessType (type);

			// Make sure the linker saves any changes in the assembly.
			if (modified) {
				var action = Context.Annotations.GetAction (assembly);
				if (action == AssemblyAction.Copy)
					Context.Annotations.SetAction (assembly, AssemblyAction.Save);
			}

			type_map.Clear ();
			method_map.Clear ();
			current_assembly = null;
		}

		bool ProcessType (TypeDefinition type)
		{
			var modified = false;
			if (type.HasNestedTypes) {
				foreach (var nested in type.NestedTypes)
					modified |= ProcessType (nested);
			}

			if (!IsNSObject (type))
				return modified;

			if (type.HasMethods) {
				foreach (var method in type.Methods.ToArray ())
					modified |= ProcessMethod (method);
			}

			return modified;
		}

		bool ProcessMethod (MethodDefinition method)
		{
			var modified = false;

			var ea = Registrar.StaticRegistrar.GetExportAttribute (method);
			if (ea is null)
				return modified;

			CreateUnmanagedCallersMethod (method);

			return modified;
		}

		int counter;
		void CreateUnmanagedCallersMethod (MethodDefinition method)
		{
			string name = $"callback_{counter++}";
			Configuration.UnmanagedCallersMap.Add (method, name);

			var callback = new MethodDefinition (name, MethodAttributes.Private | MethodAttributes.Static, GetNativeType (method, method.ReturnType));
			callback.Parameters.Add (new ParameterDefinition ("pobj", ParameterAttributes.None, System_IntPtr));
			callback.Parameters.Add (new ParameterDefinition ("sel", ParameterAttributes.None, System_IntPtr));
			if (method.HasParameters) {
				for (var i = 0; i < method.Parameters.Count; i++) {
					callback.Parameters.Add (new ParameterDefinition ($"p{i}", ParameterAttributes.None, GetNativeType (method, method.Parameters [i].ParameterType)));
				}
			}
			callback.CustomAttributes.Add (CreateUnmanagedCallersAttribute2 (name));
			callback.Body = new MethodBody (callback);

			var il = callback.Body.GetILProcessor ();

			if (!method.IsStatic) {
				il.Emit (OpCodes.Ldarg_0);
				il.Emit (OpCodes.Call, GetConversionFunction (method, method.DeclaringType, true));
			}

			if (method.HasParameters) {
				for (var p = 0; p < method.Parameters.Count; p++) {
					switch (p) {
					case 0:
						il.Emit (OpCodes.Ldarg_2);
						break;
					case 1:
						il.Emit (OpCodes.Ldarg_3);
						break;
					default:
						il.Emit (OpCodes.Ldarg, p + 2);
						break;
					}
					var conversion = GetConversionFunction (method, method.Parameters [p].ParameterType, true);
					if (conversion is not null)
						il.Emit (OpCodes.Call, conversion);
				}
			}

			il.Emit (OpCodes.Call, method);

			if (!method.ReturnType.Is ("System", "Void")) {
				var conversion = GetConversionFunction (method, method.ReturnType, false);
				if (conversion is not null)
					il.Emit (OpCodes.Call, conversion);
			} else if (method.IsConstructor) {
				il.Emit (OpCodes.Call, NativeObjectExtensions_GetHandle);
			}

			il.Emit (OpCodes.Ret);
			method.DeclaringType.Methods.Add (callback);

			Dump (method, callback);
		}

		static string GetMethodSignature (MethodDefinition method)
		{
			return $"{method?.ReturnType.DeclaringType?.FullName} {method?.DeclaringType?.FullName}::{method?.Name} ({string.Join (", ", method?.Parameters?.Select (v => v?.ParameterType?.FullName + " " + v?.Name))})";
		}

		static void Dump (MethodDefinition method, MethodDefinition trampoline)
		{
			Action<string> log = Console.WriteLine;
			log ($"// created callback trampoline for: {GetMethodSignature (method)}");
			log ($"{GetMethodSignature (trampoline)}:");
			foreach (var instr in trampoline.Body.Instructions)
				log ($"IL_{instr.Offset:X4}: {instr.ToString ()}");
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

		// This gets the type to use as return type / parameter types in the UnmanagedCallersOnly function
		// These must all be blittable types.
		// The implementation of this method mirrors the GetConversionFunction implementation.
		TypeReference GetNativeType (MethodDefinition method, TypeReference type)
		{
			// no conversion necessary if we're a value type
			if (type.IsValueType)
				return type;

			// reference types aren't blittable, so the managed signature must have be a pointer type
			if (type is ByReferenceType brt)
				return new PointerType (brt.GetElementType ());

			if (type.Is ("System", "Void"))
				return type;

			if (IsNSObject (type))
				return ObjCRuntime_NativeHandle;

			if (Registrar.StaticRegistrar.IsNativeObject (DerivedLinkContext, type))
				return ObjCRuntime_NativeHandle;

			if (type.Is ("System", "String"))
				return ObjCRuntime_NativeHandle;

			if (StaticRegistrar.IsDelegate (type.Resolve ()))
				return System_IntPtr;

			AddException (ErrorHelper.CreateError (99, "Don't know how the native equivalent of {0}.", type.FullName));
			return System_IntPtr;
		}

		// This gets a conversion function to convert between the native and the managed representation of a parameter
		// or return value.
		// The implementation of this method mirrors the GetNativeType implementation.
		MethodReference? GetConversionFunction (MethodDefinition method, TypeReference type, bool toManaged)
		{
			// no conversion necessary if we're a value type
			if (type.IsValueType)
				return null;

			// call !!0& [System.Runtime]System.Runtime.CompilerServices.Unsafe::AsRef<int32>(void*)
			if (type is ByReferenceType brt) {
				if (toManaged) {
					var mr = new GenericInstanceMethod (CurrentAssembly.MainModule.ImportReference (Unsafe_AsRef));
					mr.GenericArguments.Add (brt.GetElementType ());
					return mr;
				}
				AddException (ErrorHelper.CreateError (99, "Don't know how (2) to convert {0} between managed and native code.", type.FullName));
				return null;
			}

			if (type.Is ("System", "Void"))
				throw new InvalidOperationException ($"Can't convert System.Void!");

			if (IsNSObject (type))
				return toManaged ? Runtime_GetNSObject : NativeObjectExtensions_GetHandle;

			if (Registrar.StaticRegistrar.IsNativeObject (DerivedLinkContext, type))
				return toManaged ? Runtime_GetNSObject : NativeObjectExtensions_GetHandle;

			if (type.Is ("System", "String"))
				return toManaged ? CFString_FromHandle : CFString_CreateNative;

			if (StaticRegistrar.IsDelegate (type.Resolve ())) {
				AddException (ErrorHelper.CreateError (99, "Don't know how to convert blocks/delegates yet - of type {0}.", type.FullName));
				return null;
			}

			AddException (ErrorHelper.CreateError (99, "Don't know how (1) to convert {0} between managed and native code.", type.FullName));
			return null;
		}

		CustomAttribute CreateUnmanagedCallersAttribute2 (string entryPoint)
		{
			var unmanagedCallersAttribute = new CustomAttribute (UnmanagedCallersOnlyAttribute_Constructor);
			unmanagedCallersAttribute.Fields.Add (new CustomAttributeNamedArgument ("EntryPoint", new CustomAttributeArgument (System_String, entryPoint)));
			return unmanagedCallersAttribute;
		}
	}
}
