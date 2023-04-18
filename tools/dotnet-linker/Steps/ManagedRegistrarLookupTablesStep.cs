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
	public class ManagedRegistrarLookupTablesStep : ConfigurationAwareStep {
		protected override string Name { get; } = "ManagedRegistrarLookupTables";
		protected override int ErrorCode { get; } = 2440;

		List<Exception> exceptions = new List<Exception> ();

		AppBundleRewriter abr { get { return Configuration.AppBundleRewriter; } }

		void AddException (Exception exception)
		{
			if (exceptions is null)
				exceptions = new List<Exception> ();
			exceptions.Add (exception);
		}

		protected override void TryProcess ()
		{
			base.TryProcess ();

			if (App.Registrar != RegistrarMode.ManagedStatic)
				return;

			Configuration.Target.StaticRegistrar.Register (Configuration.GetNonDeletedAssemblies (this));
		}

		protected override void TryEndProcess ()
		{
			base.TryEndProcess ();

			if (App.Registrar != RegistrarMode.ManagedStatic)
				return;

			if (exceptions is null)
				return;
			var warnings = exceptions.Where (v => (v as ProductException)?.Error == false).ToArray ();
			if (warnings.Length == exceptions.Count)
				return;

			if (exceptions.Count == 1)
				throw exceptions [0];
			throw new AggregateException (exceptions);
		}

		protected override void TryProcessAssembly (AssemblyDefinition assembly)
		{
			base.TryProcessAssembly (assembly);

			if (App.Registrar != RegistrarMode.ManagedStatic)
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

			var annotation = DerivedLinkContext.Annotations.GetCustomAnnotation ("ManagedRegistrarStep", assembly);
			var trampolineInfos = annotation as AssemblyTrampolineInfo;
			if (trampolineInfos is null)
				return;

			abr.SetCurrentAssembly (assembly);

			trampolineInfos.SetIds ();
			CreateRegistrarType (trampolineInfos);

			abr.ClearCurrentAssembly ();
		}

		void CreateRegistrarType (AssemblyTrampolineInfo infos)
		{
			var registrarType = new TypeDefinition ("ObjCRuntime", "__Registrar__", TypeAttributes.Public | TypeAttributes.Class | TypeAttributes.Sealed | TypeAttributes.BeforeFieldInit);
			registrarType.BaseType = abr.System_Object;
			registrarType.Interfaces.Add (new InterfaceImplementation (abr.ObjCRuntime_IManagedRegistrar));
			// registrarType.CustomAttributes.Add (abr.CreateDynamicallyAccessedMemberTypesAttribute (DynamicallyAccessedMemberTypes.Interfaces));
			abr.CurrentAssembly.MainModule.Types.Add (registrarType);

			infos.RegistrarType = registrarType;
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

			var sorted = infos.OrderBy (v => v.Id).ToList ();
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

			var defaultCtor = registrarType.AddMethod (".ctor", MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName, abr.System_Void);
			defaultCtor.CreateBody (out var il);
			il.Emit (OpCodes.Ldarg_0);
			il.Emit (OpCodes.Call, abr.System_Object__ctor);
			il.Emit (OpCodes.Ret);
			DerivedLinkContext.Annotations.Mark (defaultCtor);

			GenerateLookupUnmanagedFunction (registrarType, sorted);
			GenerateLookupType (infos, registrarType);
			GenerateRegisterWrapperTypes (registrarType);

			Annotations.Mark (registrarType);
			foreach (var method in registrarType.Methods)
				Annotations.Mark (method);
			foreach (var iface in registrarType.Interfaces) {
				Annotations.Mark (iface);
				Annotations.Mark (iface.InterfaceType);
				Annotations.Mark (iface.InterfaceType.Resolve ());
			}
		}

		void GenerateLookupType (AssemblyTrampolineInfo infos, TypeDefinition registrarType)
		{
			var method = registrarType.AddMethod ("LookupType", MethodAttributes.Private | MethodAttributes.Final | MethodAttributes.Virtual | MethodAttributes.NewSlot | MethodAttributes.HideBySig, abr.System_RuntimeTypeHandle);
			method.AddParameter ("id", abr.System_UInt32);
			method.Overrides.Add (abr.IManagedRegistrar_LookupType);
			var body = method.CreateBody (out var il);

			// switch (id) {
			// case 0: return <ldtoken TYPE1>;
			// case 1: return <ldtoken TYPE2>;
			// }

			var types = new List<(TypeReference Reference, TypeDefinition Definition)> ();
			types.AddRange (StaticRegistrar.Types.Select (v => {
				var tr = v.Value.Type;
				var td = tr.Resolve ();
				return (tr, td);
			}));
			foreach (var st in StaticRegistrar.SkippedTypes) {
				if (!types.Any (v => v.Reference == st.Skipped))
					types.Add (new (st.Skipped, st.Skipped.Resolve ()));
				if (!types.Any (v => v.Reference == st.Actual.Type))
					types.Add (new (st.Actual.Type, st.Actual.Type.Resolve ()));
			}
			types.RemoveAll (v => v.Reference.Module.Assembly != abr.CurrentAssembly);
			types.RemoveAll (v => !Annotations.IsMarked (v.Definition));

			var targets = new Instruction [types.Count];

			for (var i = 0; i < targets.Length; i++) {
				targets [i] = Instruction.Create (OpCodes.Ldtoken, types [i].Reference);
				var td = types [i].Definition;
				Console.WriteLine ($"Registering {td.FullName} => {i}");
				if (!Annotations.IsMarked (td))
					Console.WriteLine ("Linked away?");
				infos.RegisterType (td, (uint) i);
			}

			il.Emit (OpCodes.Ldarg_1);
			il.Emit (OpCodes.Switch, targets);
			for (var i = 0; i < targets.Length; i++) {
				il.Append (targets [i]);
				il.Emit (OpCodes.Ret);
			}

			// return default (RuntimeTypeHandle)
			var temporary = body.AddVariable (abr.System_RuntimeTypeHandle);
			il.Emit (OpCodes.Ldloca, temporary);
			il.Emit (OpCodes.Initobj, abr.System_RuntimeTypeHandle);
			il.Emit (OpCodes.Ldloc, temporary);
			il.Emit (OpCodes.Ret);
		}

		void GenerateRegisterWrapperTypes (TypeDefinition type)
		{
			var method = type.AddMethod ("RegisterWrapperTypes", MethodAttributes.Private | MethodAttributes.Final | MethodAttributes.Virtual | MethodAttributes.NewSlot | MethodAttributes.HideBySig, abr.System_Void);
			var git = new GenericInstanceType (abr.System_Collections_Generic_Dictionary2);
			git.GenericArguments.Add (abr.System_RuntimeTypeHandle);
			git.GenericArguments.Add (abr.System_RuntimeTypeHandle);
			method.AddParameter ("type", git);
			method.Overrides.Add (abr.IManagedRegistrar_RegisterWrapperTypes);
			method.CreateBody (out var il);

			var addMethodReference = abr.System_Collections_Generic_Dictionary2.CreateMethodReferenceOnGenericType (abr.Dictionary2_Add, abr.System_RuntimeTypeHandle, abr.System_RuntimeTypeHandle);
			var currentTypes = StaticRegistrar.Types.Where (v => v.Value.Type.Resolve ().Module.Assembly == abr.CurrentAssembly);
			foreach (var ct in currentTypes) {
				if (!ct.Value.IsProtocol)
					continue;
				if (ct.Value.ProtocolWrapperType is null)
					continue;

				var keyMarked = Annotations.IsMarked (ct.Key.Resolve ());
				var wrapperTypeMarked = Annotations.IsMarked (ct.Value.ProtocolWrapperType.Resolve ());
				if (!keyMarked && !wrapperTypeMarked)
					continue;
				if (keyMarked ^ wrapperTypeMarked)
					throw new InvalidOperationException ($"Huh?");

				il.Emit (OpCodes.Ldarg_1);
				il.Emit (OpCodes.Ldtoken, type.Module.ImportReference (ct.Key));
				il.Emit (OpCodes.Ldtoken, type.Module.ImportReference (ct.Value.ProtocolWrapperType));
				il.Emit (OpCodes.Call, addMethodReference);
			}

			il.Emit (OpCodes.Ret);
		}

		void GenerateLookupUnmanagedFunction (TypeDefinition registrar_type, IList<TrampolineInfo> trampolineInfos)
		{
			Console.WriteLine ($"GenerateLookupMethods ({registrar_type.FullName}, {trampolineInfos.Count} items");

			MethodDefinition? lookupMethods = null;
			if (App.IsAOTCompiled (abr.CurrentAssembly.Name.Name)) {
				// Don't generate lookup code, because native code will call the EntryPoint for the UnmanagedCallerOnly methods directly.
				Console.WriteLine ($"Not generating method lookup code for {abr.CurrentAssembly.Name.Name}, because it's AOT compiled");
			} else if (trampolineInfos.Count > 0) {
				// All the methods in a given assembly will have consecutive IDs (but might not start at 0).
				if (trampolineInfos.First ().Id + trampolineInfos.Count - 1 != trampolineInfos.Last ().Id)
					throw ErrorHelper.CreateError (99, $"Invalid ID range: {trampolineInfos.First ().Id} + {trampolineInfos.Count - 1} != {trampolineInfos.Last ().Id}");

				const int methodsPerLevel = 10;
				var levels = (int) Math.Ceiling (Math.Log (trampolineInfos.Count, methodsPerLevel));
				GenerateLookupMethods (registrar_type, trampolineInfos, methodsPerLevel, 1, levels, 0, trampolineInfos.Count - 1, out lookupMethods);
			}

			var method = registrar_type.AddMethod ("LookupUnmanagedFunction", MethodAttributes.Private | MethodAttributes.Final | MethodAttributes.Virtual | MethodAttributes.NewSlot | MethodAttributes.HideBySig, abr.System_IntPtr);
			method.AddParameter ("symbol", abr.System_String);
			method.AddParameter ("id", abr.System_Int32);
			method.Overrides.Add (abr.IManagedRegistrar_LookupUnmanagedFunction);
			method.CreateBody (out var il);
			if (lookupMethods is null) {
				il.Emit (OpCodes.Ldc_I4_M1);
				il.Emit (OpCodes.Conv_I);
			} else {
				il.Emit (OpCodes.Ldarg_1);
				il.Emit (OpCodes.Ldarg_2);
				il.Emit (OpCodes.Call, lookupMethods);
			}
			il.Emit (OpCodes.Ret);
		}

		MethodDefinition GenerateLookupMethods (TypeDefinition type, IList<TrampolineInfo> trampolineInfos, int methodsPerLevel, int level, int levels, int startIndex, int endIndex, out MethodDefinition method)
		{
			Console.WriteLine ($"GenerateLookupMethods ({type.FullName}, {trampolineInfos.Count} items, methodsPerLevel: {methodsPerLevel}, level: {level}, levels: {levels}, startIndex: {startIndex}, endIndex: {endIndex})");

			if (startIndex > endIndex)
				throw new InvalidOperationException ($"Huh 3? startIndex: {startIndex} endIndex: {endIndex}");

			var startId = trampolineInfos [startIndex].Id;
			var name = level == 1 ? "LookupUnmanagedFunctionImpl" : $"LookupUnmanagedFunction_{level}_{levels}__{startIndex}_{endIndex}__";
			method = type.AddMethod (name, MethodAttributes.Private | MethodAttributes.HideBySig | MethodAttributes.Static, abr.System_IntPtr);
			method.ReturnType = abr.System_IntPtr; // shouldn't be necessary???
			method.AddParameter ("symbol", abr.System_String);
			method.AddParameter ("id", abr.System_Int32);
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
						var mr = abr.CurrentAssembly.MainModule.ImportReference (md);
						if (wrapLookup) {
							var wrappedLookup = type.AddMethod (name + ti.Id, MethodAttributes.Private | MethodAttributes.Static | MethodAttributes.HideBySig, abr.System_IntPtr);
							wrappedLookup.CreateBody (out var wrappedIl);
							wrappedIl.Emit (OpCodes.Ldftn, mr);
							wrappedIl.Emit (OpCodes.Ret);

							targets [i] = Instruction.Create (OpCodes.Call, wrappedLookup);
						} else {
							targets [i] = Instruction.Create (OpCodes.Ldftn, mr);
						}
					} catch (Exception e) {
						var str = string.Format ("Failed to import reference {0}: {1}", GetMethodSignature (md), e.ToString ());
						AddException (ErrorHelper.CreateError (99, e, str));
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
						var subEndIndex = subStartIndex + (chunkSize) - 1;
						if (subEndIndex > endIndex)
							subEndIndex = endIndex;
						var md = GenerateLookupMethods (type, trampolineInfos, methodsPerLevel, level + 1, levels, subStartIndex, subEndIndex, out _);
						lookupMethods [i] = md;
						targets [i] = Instruction.Create (OpCodes.Ldarg_0);
					} catch (Exception e) {
						var str = string.Format ("Failed to generate nested lookup method: {0}", e.ToString ());
						AddException (ErrorHelper.CreateError (99, e, str));
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

			return method;
		}

		static string GetMethodSignature (MethodDefinition method)
		{
			return $"{method?.ReturnType?.FullName ?? "(null)"} {method?.DeclaringType?.FullName ?? "(null)"}::{method?.Name ?? "(null)"} ({string.Join (", ", method?.Parameters?.Select (v => v?.ParameterType?.FullName + " " + v?.Name) ?? Array.Empty<string> ())})";
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

		StaticRegistrar StaticRegistrar {
			get { return DerivedLinkContext.StaticRegistrar; }
		}
	}
}

