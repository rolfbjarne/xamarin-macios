using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Xamarin.Bundler;
using Xamarin.Utils;

using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Linker;
using Mono.Tuner;
using System.Runtime.InteropServices;


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

		// FIXME: mark the types and methods we use
		TypeReference? system_intptr;
		TypeReference System_IntPtr {
			get {
				if (system_intptr is null) {
					if (corlib_assembly is null)
						throw new NotImplementedException ();
					system_intptr = corlib_assembly.MainModule.Types.SingleOrDefault (v => v.Is ("System", "IntPtr"));
					if (system_intptr is null)
						throw new NotImplementedException ("System.IntPtr not found.");
					system_intptr = current_assembly!.MainModule.ImportReference (system_intptr);
				}
				return system_intptr;
			}
		}

		TypeReference? system_string;
		TypeReference System_String {
			get {
				if (system_string is null) {
					if (corlib_assembly is null)
						throw new NotImplementedException ();
					system_string = corlib_assembly.MainModule.Types.SingleOrDefault (v => v.Is ("System", "String"));
					if (system_string is null)
						throw new NotImplementedException ("System.String not found.");
					system_string = current_assembly!.MainModule.ImportReference (system_string);
				}
				return system_string;
			}
		}

		TypeDefinition? objcruntime_runtime;
		TypeDefinition ObjCRuntime_Runtime {
			get {
				if (objcruntime_runtime is null) {
					if (platform_assembly is null)
						throw new NotImplementedException ();
					objcruntime_runtime = platform_assembly.MainModule.Types.SingleOrDefault (v => v.Is ("ObjCRuntime", "Runtime"));
					if (objcruntime_runtime is null)
						throw new NotImplementedException ("ObjCRuntime.Runtime not found.");
				}
				return objcruntime_runtime;
			}
		}

		TypeDefinition? objcruntime_nativeobjectextensions;
		TypeDefinition ObjCRuntime_NativeObjectExtensions {
			get {
				if (objcruntime_nativeobjectextensions is null) {
					if (platform_assembly is null)
						throw new NotImplementedException ();
					objcruntime_nativeobjectextensions = platform_assembly.MainModule.Types.SingleOrDefault (v => v.Is ("ObjCRuntime", "NativeObjectExtensions"));
					if (objcruntime_nativeobjectextensions is null)
						throw new NotImplementedException ("ObjCRuntime.NativeObjectExtensions not found.");
				}
				return objcruntime_nativeobjectextensions;
			}
		}

		MethodReference? runtime_getnsobject;
		MethodReference Runtime_GetNSObject {
			get {
				if (runtime_getnsobject is null) {
					if (platform_assembly is null)
						throw new NotImplementedException ();
					runtime_getnsobject = ObjCRuntime_Runtime.Methods.SingleOrDefault (v => v.Name == "GetNSObject");
					if (runtime_getnsobject is null)
						throw new NotImplementedException ("ObjCRuntime.Runtime::GetNSObject not found.");
					runtime_getnsobject = current_assembly!.MainModule.ImportReference (runtime_getnsobject);
				}
				return runtime_getnsobject;
			}
		}

		MethodReference? nativeobjectextensions_gethandle;
		MethodReference NativeObjectExtensions_GetHandle {
			get {
				if (nativeobjectextensions_gethandle is null) {
					if (platform_assembly is null)
						throw new NotImplementedException ();
					nativeobjectextensions_gethandle = ObjCRuntime_NativeObjectExtensions.Methods.SingleOrDefault (v => v.Name == "GetHandle");
					if (nativeobjectextensions_gethandle is null)
						throw new NotImplementedException ("ObjCRuntime.NativeObjectExtensions::GetHandle not found.");
					nativeobjectextensions_gethandle = current_assembly!.MainModule.ImportReference (nativeobjectextensions_gethandle);
				}
				return nativeobjectextensions_gethandle;
			}
		}

		MethodReference? unmanagedcallersonlyattribute_ctor;
		MethodReference UnmanagedCallersOnlyAttribute_Constructor {
			get {
				if (unmanagedcallersonlyattribute_ctor is null) {
					if (corlib_assembly is null)
						throw new NotImplementedException ();
					var td = corlib_assembly.MainModule.Types.SingleOrDefault (v => v.Is ("System.Runtime.InteropServices", "UnmanagedCallersOnlyAttribute"));
					if (td is null)
						throw new NotImplementedException ("System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute not found.");
					unmanagedcallersonlyattribute_ctor = td.Methods.SingleOrDefault (v => v.IsDefaultConstructor ());
					if (unmanagedcallersonlyattribute_ctor is null)
						throw new NotImplementedException ("ObjCRuntime.NativeObjectExtensions::GetHandle not found.");
					unmanagedcallersonlyattribute_ctor = current_assembly!.MainModule.ImportReference (unmanagedcallersonlyattribute_ctor);
				}
				return unmanagedcallersonlyattribute_ctor;
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

			system_intptr = null;
			system_string = null;
			runtime_getnsobject = null;
			nativeobjectextensions_gethandle = null;
			current_assembly = null;
		}

		bool ProcessType (TypeDefinition type)
		{
			var modified = false;
			if (type.HasNestedTypes) {
				foreach (var nested in type.NestedTypes)
					modified |= ProcessType (nested);
			}

			if (!type.IsNSObject (Configuration.DerivedLinkContext))
				return modified;

			if (type.HasMethods) {
				foreach (var method in type.Methods)
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
			callback.Parameters.Add (new ParameterDefinition ("pobj", ParameterAttributes.None, system_intptr));
			callback.Parameters.Add (new ParameterDefinition ("sel", ParameterAttributes.None, system_intptr));
			if (method.HasParameters) {
				for (var i = 0; i < method.Parameters.Count; i++) {
					callback.Parameters.Add (new ParameterDefinition ($"p{i}", ParameterAttributes.None, GetNativeType (method, method.Parameters [i].ParameterType)));
				}
			}
			callback.CustomAttributes.Add (CreateUnmanagedCallersAttribute (name));
			callback.Body = new MethodBody (callback);

			var il = callback.Body.GetILProcessor ();

			if (!method.IsStatic) {
				il.Emit (OpCodes.Ldarg_0);
				il.Emit (OpCodes.Call, GetConversionFunction (method, System_IntPtr, method.DeclaringType, true));
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
					var conversion = GetConversionFunction (method, null!, method.Parameters [p].ParameterType, true);
					if (conversion is not null)
						il.Emit (OpCodes.Call, conversion);
				}
			}

			il.Emit (OpCodes.Call, method);

			if (!method.ReturnType.Is ("System", "Void")) {
				var conversion = GetConversionFunction (method, null!, method.ReturnType, false);
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
			return $"{method.ReturnType.DeclaringType.FullName} {method.DeclaringType.FullName}::{method.Name} ({string.Join (", ", method.Parameters.Select (v => v.ParameterType.DeclaringType + "." + v.ParameterType.Name + " " + v.Name))})";
		}

		static void Dump (MethodDefinition method, MethodDefinition trampoline)
		{
			Action<string> log = Console.WriteLine;
			log ($"// created callback trampoline for: {GetMethodSignature (method)}");
			log ($"{GetMethodSignature (trampoline)}:");
			foreach (var instr in trampoline.Body.Instructions)
				log ($"IL_{instr.Offset:X4}: {instr.ToString ()}");
		}

		TypeReference GetNativeType (MethodDefinition method, TypeReference type)
		{
			if (type.IsValueType)
				return type;

			if (type.IsNSObject (DerivedLinkContext))
				return System_IntPtr;

			AddException (ErrorHelper.CreateError (99, "Don't know how the native equivalent of {0}.", type.FullName));
			return System_IntPtr;
		}

		MethodReference? GetConversionFunction (MethodDefinition method, TypeReference nativeType, TypeReference managedType, bool toManaged)
		{
			// no conversion necessary if we're a value type
			if (managedType.IsValueType)
				return null;

			if (managedType.IsNSObject (DerivedLinkContext))
				return toManaged ? Runtime_GetNSObject : NativeObjectExtensions_GetHandle;

			AddException (ErrorHelper.CreateError (99, "Don't know how to convert from {0} to {1}.", nativeType.FullName, managedType.FullName));
			return null;
		}

		CustomAttribute CreateUnmanagedCallersAttribute (string entryPoint)
		{
			var unmanagedCallersAttribute = new CustomAttribute (UnmanagedCallersOnlyAttribute_Constructor);
			unmanagedCallersAttribute.Fields.Add (new CustomAttributeNamedArgument ("EntryPoint", new CustomAttributeArgument (system_string, entryPoint)));
			return unmanagedCallersAttribute;
		}
	}
}
