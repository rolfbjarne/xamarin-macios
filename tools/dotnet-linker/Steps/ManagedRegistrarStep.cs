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
using System.Diagnostics;
using System.Xml.Linq;


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

		TypeReference System_IntPtr {
			get {
				return GetTypeReference (CorlibAssembly, "System.IntPtr", out var _);
			}
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

			if (!StaticRegistrar.TryFindMethod (method, out _)) {
				Console.WriteLine ("Could not find method {0}, so no generating trampoline.", GetMethodSignature (method));
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
			var placeholderType = System_IntPtr;
			var initialExceptionCount = exceptions.Count;
			ParameterDefinition? callSuperParameter = null;
			VariableDefinition? returnVariable = null;
			var leaveTryInstructions = new List<Instruction> ();
			var isVoid = method.ReturnType.Is ("System", "Void");

			var name = $"callback_{counter++}_{Sanitize (method.DeclaringType.FullName)}_{Sanitize (method.Name)}";

			var callback = method.DeclaringType.AddMethod (name, MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig, placeholderType);
			callback.CustomAttributes.Add (CreateUnmanagedCallersAttribute (name));
			Configuration.UnmanagedCallersMap.Add (method, new LinkerConfiguration.UnmanagedCallersEntry (name, Configuration.UnmanagedCallersMap.Count, callback));

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
			try {
				Trace (il, $"ENTER");

				if (method.IsConstructor) {
					callback.AddParameter ("pobj", ObjCRuntime_NativeHandle);
				} else {
					callback.AddParameter ("pobj", System_IntPtr);
				}

				if (!isVoid || method.IsConstructor)
					returnVariable = body.AddVariable (placeholderType);

				if (!method.IsStatic) {
					if (method.IsConstructor) {
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
						il.Emit (OpCodes.Ldarg_0);
						EmitConversion (method, il, method.DeclaringType, true, -1, out var nativeType, postProcessing);
						//if (nativeType != callback.Parameters [0].ParameterType)
						//	AddException (ErrorHelper.CreateWarning (99, "Unexpected parameter type for the first parameter. Expected {0}, got {1}. Method: {2}", callback.Parameters [0].ParameterType.FullName, nativeType?.FullName, GetMethodSignatureWithSourceCode (method)));
					}
				}

				callback.AddParameter ("sel", System_IntPtr);

				if (method.HasParameters) {
					for (var p = 0; p < method.Parameters.Count; p++) {
						var parameter = callback.AddParameter ($"p{p}", placeholderType);
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
						if (EmitConversion (method, il, method.Parameters [p].ParameterType, true, p, out var nativeType, postProcessing)) {
							parameter.ParameterType = nativeType;
						} else {
							parameter.ParameterType = placeholderType;
							AddException (ErrorHelper.CreateWarning (99, "Unable to emit conversion for parameter {2} of type {0}. Method: {1}", method.Parameters [p].ParameterType, GetMethodSignatureWithSourceCode (method), p));
						}
					}
				}

				if (callSuperParameter is not null)
					callback.Parameters.Add (callSuperParameter);

				callback.AddParameter ("exception_gchandle", new PointerType (System_IntPtr));

				il.Emit (OpCodes.Call, method);

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
			return $"{method?.ReturnType?.DeclaringType?.FullName ?? "(null)"} {method?.DeclaringType?.FullName ?? "(null)"}::{method?.Name ?? "(null)"} ({string.Join (", ", method?.Parameters?.Select (v => v?.ParameterType?.FullName + " " + v?.Name) ?? Array.Empty<string> ())})";
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
			foreach (var variable in method.Body.Variables)
				Console.WriteLine ($"    {variable.VariableType?.FullName}: V_{variable.Index}");
			foreach (var instr in method.Body.Instructions) {
				string str;
				try {
					str = instr.ToString ();
				} catch (Exception e) {
					str = e.ToString ();
				}
				log ($"    IL_{instr.Offset:X4}: {str}");
			}
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

		// This emits a conversion between the native and the managed representation of a parameter or return value,
		// and returns the corresponding native type. The returned nativeType will (must) be a blittable type.
		bool EmitConversionImpl (MethodDefinition method, ILProcessor il, TypeReference type, bool toManaged, int parameter, [NotNullWhen (true)] out TypeReference? nativeType, List<Instruction> postProcessing)
		{
			nativeType = null;

			var bindAsAttribute = GetBindAsAttribute (method, parameter);
			if (bindAsAttribute is not null) {
				// FIXME: make this an error
				AddException (ErrorHelper.CreateWarning (99, "Don't know how (4) to convert BindAs {0} -> {2} between managed and native code. Method: {1}", type.FullName, GetMethodSignatureWithSourceCode (method), bindAsAttribute.OriginalType.FullName));
				return false;
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

			// call !!0& [System.Runtime]System.Runtime.CompilerServices.Unsafe::AsRef<int32>(void*)
			if (type is ByReferenceType brt) {
				if (toManaged) {
					if (type.IsValueType) {
						var mr = new GenericInstanceMethod (CurrentAssembly.MainModule.ImportReference (Unsafe_AsRef));
						mr.GenericArguments.Add (brt.GetElementType ());
						il.Emit (OpCodes.Call, mr);
						// reference types aren't blittable, so the managed signature must have be a pointer type
						nativeType = new PointerType (brt.GetElementType ());
						return true;
					} else if (type.IsNSObject (DerivedLinkContext)) {
						il.Emit (OpCodes.Ldind_I);
						il.Emit (OpCodes.Call, Runtime_GetNSObject__System_IntPtr);
						if (!type.Is ("Foundation", "NSObject"))
							il.Emit (OpCodes.Castclass, type);
						var indirectVariable = il.Body.AddVariable (type);
						il.Emit (OpCodes.Stloc, indirectVariable);
						il.Emit (OpCodes.Ldloca, indirectVariable);

						// post processing too
						postProcessing.Add (il.Create (OpCodes.Ldarg, parameter));
						postProcessing.Add (il.Create (OpCodes.Ldloc, indirectVariable));
						postProcessing.Add (il.Create (OpCodes.Call, Runtime_GetINativeObject__IntPtr_Boolean_Type_Type));
						postProcessing.Add (il.Create (OpCodes.Call, NativeObject_op_Implicit_IntPtr));
						postProcessing.Add (il.Create (OpCodes.Stind_I));
						nativeType = new PointerType (System_IntPtr);
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
					nativeType = ObjCRuntime_NativeHandle;
					return true;
				}

				AddException (ErrorHelper.CreateWarning (99, "Don't know how (3) to convert array element type {1} for array type {0} between managed and native code. Method: {2}", type.FullName, elementType.FullName, GetMethodSignatureWithSourceCode (method)));
				return false;
			}

			if (IsNSObject (type)) {
				if (toManaged) {
					il.Emit (OpCodes.Call, Runtime_GetNSObject__System_IntPtr);
					if (!type.Is ("Foundation", "NSObject"))
						il.Emit (OpCodes.Castclass, type);
					nativeType = System_IntPtr;
				} else {
					il.Emit (OpCodes.Call, NativeObjectExtensions_GetHandle);
					nativeType = ObjCRuntime_NativeHandle;
				}
				return true;
			}

			if (StaticRegistrar.IsNativeObject (DerivedLinkContext, type)) {
				if (toManaged) {
					var nativeObjType = StaticRegistrar.GetInstantiableType (type, exceptions, GetMethodSignature (method));
					il.Emit (OpCodes.Ldc_I4_0); // false
					il.Emit (OpCodes.Ldtoken, method.Module.ImportReference (type)); // target type
					il.Emit (OpCodes.Call, Type_GetTypeFromHandle);
					il.Emit (OpCodes.Ldtoken, method.Module.ImportReference (nativeObjType)); // implementation type
					il.Emit (OpCodes.Call, Type_GetTypeFromHandle);
					il.Emit (OpCodes.Call, Runtime_GetINativeObject__IntPtr_Boolean_Type_Type);
					il.Emit (OpCodes.Castclass, type);
					nativeType = System_IntPtr;
				} else {
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
					MethodReference createMethod = StaticRegistrar.GetBlockWrapperCreator (objcMethod, parameter);
					il.Emit (OpCodes.Call, BlockLiteral_Copy);
					il.Emit (OpCodes.Dup);
					il.Emit (OpCodes.Call, method.Module.ImportReference (createMethod));
					il.Emit (OpCodes.Call, Runtime_ReleaseBlockWhenDelegateIsCollected);
				} else {
					if (!DerivedLinkContext.StaticRegistrar.TryComputeBlockSignature (method, trampolineDelegateType: type, out var exception, out var signature)) {
						AddException (ErrorHelper.CreateWarning (99, "Error while converting block/delegates: FIXME better error: {0}", exception.ToString ()));
						return false;
					}
					var delegateProxyType = StaticRegistrar.GetDelegateProxyType (objcMethod);
					if (delegateProxyType is null) {
						AddException (ErrorHelper.CreateWarning (99, "No delegate proxy type for {0}", method.FullName));
						return false;
					}
					var delegateProxyField = delegateProxyType.Fields.SingleOrDefault (v => v.Name == "Handler");
					if (delegateProxyField is null) {
						AddException (ErrorHelper.CreateWarning (99, "No delegate proxy field on {0}", delegateProxyType.FullName));
						return false;
					}
					// the delegate is already on the stack
					il.Emit (OpCodes.Ldsfld, method.Module.ImportReference (delegateProxyField));
					il.Emit (OpCodes.Ldstr, signature);
					il.Emit (OpCodes.Call, BlockLiteral_CreateBlockForDelegate);
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

		StaticRegistrar StaticRegistrar {
			get { return DerivedLinkContext.StaticRegistrar; }
		}

		CustomAttribute CreateUnmanagedCallersAttribute (string entryPoint)
		{
			var unmanagedCallersAttribute = new CustomAttribute (UnmanagedCallersOnlyAttribute_Constructor);
			unmanagedCallersAttribute.Fields.Add (new CustomAttributeNamedArgument ("EntryPoint", new CustomAttributeArgument (System_String, entryPoint)));
			return unmanagedCallersAttribute;
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
