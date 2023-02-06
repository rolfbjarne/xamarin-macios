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

		List<Exception> exceptions = new List<Exception> ();
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

		MethodReference GetMethodReference (AssemblyDefinition assembly, TypeReference tr, string name, string key, Func<MethodDefinition, bool>? predicate)
		{
			return GetMethodReference (assembly, tr, name, key, predicate, out var _);
		}

		MethodReference GetMethodReference (AssemblyDefinition assembly, TypeReference tr, string name, string key, Func<MethodDefinition, bool>? predicate, out MethodDefinition method)
		{
			if (!method_map.TryGetValue (key, out var tuple)) {
				var td = tr.Resolve ();
				var md = td.Methods.SingleOrDefault (v => v.Name == name && (predicate is null || predicate (v)));
				if (md is null)
					throw new InvalidOperationException ($"Unable to find the method '{tr.FullName}::{name}' (for key '{key}') in {assembly.Name.Name}. Methods in type:\n\t{string.Join ("\n\t", td.Methods.Select (GetMethodSignature))}");

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

		TypeReference Foundation_NSObject {
			get {
				return GetTypeReference (PlatformAssembly, "Foundation.NSObject", out var _);
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

		MethodReference NSObject_AllocateNSObject {
			get {
				var rv = GetMethodReference (PlatformAssembly, Foundation_NSObject, "AllocateNSObject", "AllocateNSObject", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 2
						&& v.Parameters [0].ParameterType.Is ("System", "IntPtr")
						// && v.Parameters [1].ParameterType.Is ("Foundation", "NSObject/Flags")
						&& v.HasGenericParameters
						&& v.GenericParameters.Count == 1,
						out var md);
				Console.WriteLine ($"HOORAY NSObject_AllocateNSObject: Namespace: {md.Parameters [1].ParameterType.Namespace} Name: {md.Parameters [1].ParameterType.Name}");
				md.IsPublic = true; // This method is usually private so that nobody can call it (i.e. not in our API), but we need it at runtime so make it public.
				return rv;
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

		MethodReference BlockLiteral_CreateBlockForDelegate {
			get {
				return GetMethodReference (PlatformAssembly, "ObjCRuntime.BlockLiteral", "CreateBlockForDelegate", (v) => 
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 3
						&& v.Parameters [0].ParameterType.Is ("System", "Delegate")
						&& v.Parameters [1].ParameterType.Is ("System", "Delegate")
						&& v.Parameters [2].ParameterType.Is ("System", "String")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference BlockLiteral_Copy {
			get {
				return GetMethodReference (PlatformAssembly, "ObjCRuntime.BlockLiteral", "Copy", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 1
						&& v.Parameters [0].ParameterType.Is ("System", "IntPtr")
						&& !v.HasGenericParameters);
			}
		}

		MethodReference Runtime_ReleaseBlockWhenDelegateIsCollected {
			get {
				return GetMethodReference (PlatformAssembly, "ObjCRuntime.Runtime", "ReleaseBlockWhenDelegateIsCollected", (v) =>
						v.IsStatic
						&& v.HasParameters
						&& v.Parameters.Count == 2
						&& v.Parameters [0].ParameterType.Is ("System", "IntPtr")
						&& v.Parameters [1].ParameterType.Is ("System", "Delegate")
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
				if (Annotations.GetAction (assembly) != Mono.Linker.AssemblyAction.Delete)
					bundled_assemblies.Add (assembly);
			}
			Configuration.Target.StaticRegistrar.Register (bundled_assemblies);
		}

		protected override void TryEndProcess ()
		{
			base.TryEndProcess ();

			RewriteRuntimeLookupManagedFunction ();

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

			var modified = false;
			foreach (var type in assembly.MainModule.Types)
				modified |= ProcessType (type);

			// Make sure the linker saves any changes in the assembly.
			if (modified) {
				Save (assembly);
			}
			Console.WriteLine ($"LOGLOG: saving {assembly.FullName}: {modified}");
			type_map.Clear ();
			method_map.Clear ();
			current_assembly = null;
		}

		void Save (AssemblyDefinition assembly)
		{
			var action = Context.Annotations.GetAction (assembly);
			if (action == AssemblyAction.Copy)
				Context.Annotations.SetAction (assembly, AssemblyAction.Save);
			Console.WriteLine ($"ACTIONACTION: {assembly.FullName}: {Context.Annotations.GetAction (assembly)}");
		}

		void RewriteRuntimeLookupManagedFunction ()
		{
			current_assembly = PlatformAssembly;

			var method = GetMethodReference (PlatformAssembly, ObjCRuntime_Runtime, "LookupManagedFunctionImpl").Resolve ();
			var table = Configuration.UnmanagedCallersMap.ToList ().OrderBy (v => v.Value.Id).ToList ();

			// Consistency check
			for (var i = 0; i < table.Count; i++)
				if (table [i].Value.Id != i)
					throw new InvalidOperationException ($"Invalid ID in table!");

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
					var mr = PlatformAssembly.MainModule.ImportReference (table [index].Value.UnmanagedCallersMethod);
					targets [k] = Instruction.Create (OpCodes.Ldftn, mr);
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
			if (!(method.IsConstructor && !method.IsStatic)) {
				var ea = StaticRegistrar.GetExportAttribute (method);
				if (ea is null && !method.IsVirtual)
					return false;
			}

			try {
				CreateUnmanagedCallersMethod (method);
			} catch (Exception e) {
				Console.WriteLine (e);
				AddException (ErrorHelper.CreateWarning (99, e, "Failed process {0}: {1}", method.FullName, e.Message));
			}

			return true;
		}

		int counter;
		void CreateUnmanagedCallersMethod (MethodDefinition method)
		{
			string name = $"callback_{counter++}_{method.DeclaringType.FullName.Replace ('.', '_').Replace ('/', '_').Replace ('`', '_')}_{method.Name.Replace ('.', '_').Replace ('/', '_').Replace ('`', '_')}";

			Console.WriteLine ($"Creating {name} 1");

			var callback = new MethodDefinition (name, MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig, GetNativeType (method, method.ReturnType, -1));
			callback.DeclaringType = method.DeclaringType;
			method.DeclaringType.Methods.Add (callback);

			Console.WriteLine ($"Creating {name} 2");
			var entry = new LinkerConfiguration.UnmanagedCallersEntry (name, Configuration.UnmanagedCallersMap.Count, callback);
			Configuration.UnmanagedCallersMap.Add (method, entry);

			Console.WriteLine ($"Creating {name} 2a");
			callback.Parameters.Add (new ParameterDefinition ("pobj", ParameterAttributes.None, System_IntPtr));
			callback.Parameters.Add (new ParameterDefinition ("sel", ParameterAttributes.None, System_IntPtr));
			Console.WriteLine ($"Creating {name} 2b");
			if (method.HasParameters) {
				for (var i = 0; i < method.Parameters.Count; i++) {
					Console.WriteLine ($"Creating {name} 2c{i}");
					callback.Parameters.Add (new ParameterDefinition ($"p{i}", ParameterAttributes.None, GetNativeType (method, method.Parameters [i].ParameterType, i)));
				}
			}
			Console.WriteLine ($"Creating {name} 2d");
			callback.CustomAttributes.Add (CreateUnmanagedCallersAttribute2 (name));
			callback.Body = new MethodBody (callback);

			Console.WriteLine ($"Creating {name} 3");
			var il = callback.Body.GetILProcessor ();
			var initialExceptionCount = exceptions.Count;

			if (!method.IsStatic) {
				il.Emit (OpCodes.Ldarg_0);
				if (method.IsConstructor) {
					var git = new GenericInstanceMethod (NSObject_AllocateNSObject);
					git.GenericArguments.Add (method.DeclaringType);
					il.Emit (OpCodes.Ldc_I4_2); // NSObject.Flags.NativeRef
					il.Emit (OpCodes.Call, git);
					il.Emit (OpCodes.Dup); // this is for the call to ObjCRuntime.NativeObjectExtensions::GetHandle after the call to the constructor
				} else {
					EmitConversion (method, il, method.DeclaringType, true, -1);
				}
			}

			Console.WriteLine ($"Creating {name} 4");
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
					EmitConversion (method, il, method.Parameters [p].ParameterType, true, p);
				}
			}

			il.Emit (OpCodes.Call, method);

			Console.WriteLine ($"Creating {name} 5");
			if (!method.ReturnType.Is ("System", "Void")) {
				EmitConversion (method, il, method.ReturnType, false, -1);
			} else if (method.IsConstructor) {
				il.Emit (OpCodes.Call, NativeObjectExtensions_GetHandle);
			}

			il.Emit (OpCodes.Ret);

			Console.WriteLine ($"Creating {name} 6");
			if (exceptions.Count != initialExceptionCount) {
				il.Clear ();
				var newExceptions = exceptions.Skip (initialExceptionCount);
				il.Emit (OpCodes.Ldstr, $"Conversion not implemented. Exceptions during process:\n\t{string.Join ("\n\t", newExceptions.Select (v => v.ToString ()))}");
				il.Emit (OpCodes.Newobj, Exception_ctor_String);
				il.Emit (OpCodes.Throw);
				exceptions.RemoveRange (initialExceptionCount, exceptions.Count - initialExceptionCount);
			}

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
			Dump (trampoline, log);
		}

		static void Dump (MethodDefinition method, Action<string> log)
		{
			log ($"{GetMethodSignature (method)}:");
			foreach (var instr in method.Body.Instructions)
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

		BindAsAttribute? GetBindAsAttribute (MethodDefinition method, int parameter)
		{
			if (StaticRegistrar.IsPropertyAccessor (method, out var property)) {
				return StaticRegistrar.GetBindAsAttribute (property);
			} else {
				return StaticRegistrar.GetBindAsAttribute (method, parameter);
			}
		}

		// This gets the type to use as return type / parameter types in the UnmanagedCallersOnly function
		// These must all be blittable types.
		// The implementation of this method mirrors the GetConversionFunction implementation.
		TypeReference GetNativeType (MethodDefinition method, TypeReference type, int parameter, bool checkBindAs = true)
		{
			if (checkBindAs) {
				var bindAsAttribute = GetBindAsAttribute (method, parameter);
				if (bindAsAttribute is not null)
					return GetNativeType (method, bindAsAttribute.OriginalType, parameter, checkBindAs: false);
			}

			// no conversion necessary if we're a value type
			if (type.IsValueType)
				return type;

			// reference types aren't blittable, so the managed signature must have be a pointer type
			if (type is ByReferenceType brt)
				return new PointerType (brt.GetElementType ());

			if (type is ArrayType at) {
				var elementType = at.GetElementType ();
				if (elementType.Is ("System", "String"))
					return ObjCRuntime_NativeHandle;

				if (elementType.IsNSObject (DerivedLinkContext) || StaticRegistrar.IsNativeObject (elementType))
					return System_IntPtr;

				AddException (ErrorHelper.CreateWarning (99, "Don't know how the native equivalent of the array type {0}, where element type is {1}. Method: {2}", type.FullName, elementType?.FullName, method.FullName));
				return System_IntPtr;
			}

			if (type.Is ("System", "Void")) {
				if (parameter == -1 && method.IsConstructor && !method.IsStatic)
					return ObjCRuntime_NativeHandle;
				return type;
			}

			if (IsNSObject (type))
				return parameter == -1 ? ObjCRuntime_NativeHandle : System_IntPtr;

			if (StaticRegistrar.IsNativeObject (DerivedLinkContext, type))
				return parameter == -1 ? ObjCRuntime_NativeHandle : System_IntPtr;

			if (type.Is ("System", "String"))
				return ObjCRuntime_NativeHandle;

			if (StaticRegistrar.IsDelegate (type.Resolve ()))
				return System_IntPtr;

			AddException (ErrorHelper.CreateWarning (99, "Don't know the native equivalent of {0}. Method: {1}", type.FullName, method.FullName));
			return System_IntPtr;
		}

		void EmitConversion (MethodDefinition method, ILProcessor il, TypeReference type, bool toManaged, int parameter)
		{
			try {
				EmitConversionImpl (method, il, type, toManaged, parameter);
			} catch (Exception e) {
				AddException (ErrorHelper.CreateWarning (99, e, "Failed to process {0}: {1}", method.FullName, e.Message));
			}
		}

		// This gets a conversion function to convert between the native and the managed representation of a parameter
		// or return value.
		// The implementation of this method mirrors the GetNativeType implementation.
		void EmitConversionImpl (MethodDefinition method, ILProcessor il, TypeReference type, bool toManaged, int parameter)
		{
			var bindAsAttribute = GetBindAsAttribute (method, parameter);
			if (bindAsAttribute is not null) {
				// FIXME: make this an error
				AddException (ErrorHelper.CreateWarning (99, "Don't know how (4) to convert BindAs {0} -> {2} between managed and native code. Method: {1}", type.FullName, method.FullName, bindAsAttribute.OriginalType.FullName));
				return;
			}

			// no conversion necessary if we're a value type
			if (type.IsValueType)
				return;

			// call !!0& [System.Runtime]System.Runtime.CompilerServices.Unsafe::AsRef<int32>(void*)
			if (type is ByReferenceType brt) {
				if (toManaged) {
					var mr = new GenericInstanceMethod (CurrentAssembly.MainModule.ImportReference (Unsafe_AsRef));
					mr.GenericArguments.Add (brt.GetElementType ());
					il.Emit (OpCodes.Call, mr);
					return;
				}
				AddException (ErrorHelper.CreateWarning (99, "Don't know how (2) to convert {0} between managed and native code. Method: {1}", type.FullName, method.FullName));
				return;
			}

			if (type is ArrayType at) {
				var elementType = at.GetElementType ();
				if (elementType.Is ("System", "String")) {
					il.Emit (OpCodes.Call, toManaged ? CFArray_StringArrayFromHandle : CFArray_Create);
					return;
				}

				if (elementType.IsNSObject (DerivedLinkContext) || StaticRegistrar.IsNativeObject (elementType)) {
					MethodReference mr;
					if (toManaged) {
						var gim = new GenericInstanceMethod (NSArray_ArrayFromHandle);
						gim.GenericArguments.Add (elementType);
						mr = gim;
					} else {
						mr = NSArray_FromNSObjects__INativeObjects;
					}
					il.Emit (OpCodes.Call, mr);
					return;
				}

				AddException (ErrorHelper.CreateWarning (99, "Don't know how (3) to convert array element type {1} for array type {0} between managed and native code. Method: {2}", type.FullName, elementType.FullName, method.FullName));
				return;
			}

			if (type.Is ("System", "Void"))
				throw new InvalidOperationException ($"Can't convert System.Void!");

			if (IsNSObject (type)) {
				il.Emit (OpCodes.Call, toManaged ? Runtime_GetNSObject__System_IntPtr : NativeObjectExtensions_GetHandle);
				return;
			}

			if (StaticRegistrar.IsNativeObject (DerivedLinkContext, type)) {
				il.Emit (OpCodes.Call, toManaged ? Runtime_GetNSObject__System_IntPtr : NativeObjectExtensions_GetHandle);
				return;
			}

			if (type.Is ("System", "String")) {
				il.Emit (OpCodes.Call, toManaged ? CFString_FromHandle : CFString_CreateNative);
				return;
			}

			if (StaticRegistrar.IsDelegate (type.Resolve ())) {
				var objcMethod = StaticRegistrar.FindMethod (method);
				if (toManaged) {
					MethodReference createMethod = StaticRegistrar.GetBlockWrapperCreator (objcMethod, parameter);
					il.Emit (OpCodes.Call, BlockLiteral_Copy);
					il.Emit (OpCodes.Dup);
					il.Emit (OpCodes.Call, createMethod);
					il.Emit (OpCodes.Call, Runtime_ReleaseBlockWhenDelegateIsCollected);
				} else {
					if (!DerivedLinkContext.StaticRegistrar.TryComputeBlockSignature (method, trampolineDelegateType: type, out var exception, out var signature)) {
						AddException (ErrorHelper.CreateWarning (99, "Error while converting block/delegates: FIXME better error: {0}", exception.ToString ()));
						return;
					}
					var delegateProxyType = StaticRegistrar.GetDelegateProxyType (objcMethod);
					if (delegateProxyType is null) {
						AddException (ErrorHelper.CreateWarning (99, "No delegate proxy type for {0}", method.FullName));
						return;
					}
					var delegateProxyField = delegateProxyType.Fields.SingleOrDefault (v => v.Name == "Handler");
					if (delegateProxyField is null) {
						AddException (ErrorHelper.CreateWarning (99, "No delegate proxy field on {0}", delegateProxyType.FullName));
						return;
					}
					// the delegate is already on the stack
					il.Emit (OpCodes.Ldsfld, delegateProxyField);
					il.Emit (OpCodes.Ldstr, signature);
					il.Emit (OpCodes.Call, BlockLiteral_CreateBlockForDelegate);
				}
				return;
			}

			AddException (ErrorHelper.CreateWarning (99, "Don't know how (1) to convert {0} between managed and native code: {1}. Method: {2}", type.FullName, type.GetType ().FullName, method.FullName));
		}

		StaticRegistrar StaticRegistrar {
			get { return DerivedLinkContext.StaticRegistrar; }
		}

		CustomAttribute CreateUnmanagedCallersAttribute2 (string entryPoint)
		{
			var unmanagedCallersAttribute = new CustomAttribute (UnmanagedCallersOnlyAttribute_Constructor);
			unmanagedCallersAttribute.Fields.Add (new CustomAttributeNamedArgument ("EntryPoint", new CustomAttributeArgument (System_String, entryPoint)));
			return unmanagedCallersAttribute;
		}
	}
}
