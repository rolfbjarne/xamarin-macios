//
// MonoTouchTypeMapStep.cs
//
// Authors:
//	Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2012-2013 Xamarin Inc.
//

using System;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Linker.Steps;
using Mono.Tuner;

using Xamarin.Linker;
using Xamarin.Tuner;

namespace MonoTouch.Tuner {

	public class MonoTouchTypeMapStep : TypeMapStep {
		HashSet<TypeDefinition> cached_isnsobject = new HashSet<TypeDefinition> ();
		Dictionary<TypeDefinition, bool?> isdirectbinding_value = new Dictionary<TypeDefinition, bool?> ();

		DerivedLinkContext LinkContext {
			get {
				return (DerivedLinkContext) base.Context;
			}
		}

		protected override void ProcessAssembly (AssemblyDefinition assembly)
		{
			LinkContext.DynamicRegistrationSupported |= FindRuntimeConnectMethodReferences (assembly);

			base.ProcessAssembly (assembly);
		}

		// We need to know if anybody calls Runtime.ConnectMethod before marking everything,
		// since we'll be able to optimize a lot of code away if Runtime.ConnectMethod is not used.
		bool FindRuntimeConnectMethodReferences (AssemblyDefinition assembly)
		{
#if MONOMAC && !XAMCORE_2_0
			// Disable removing the dynamic registrar for XM/Classic to simplify the code a little bit.
			return true;
#else
			if (LinkContext.Target.App.Registrar != Xamarin.Bundler.RegistrarMode.Static)
				return true;

			if (Profile.IsProductAssembly (assembly) || Profile.IsSdkAssembly (assembly)) {
				// We know that the assemblies we ship don't use Runtime.ConnectMethod.
				return false;
			}

			// Check if the assembly is referencing our product assembly
			var hasProductReference = false;
			foreach (var ar in assembly.MainModule.AssemblyReferences) {
				if (Profile.IsProductAssembly (ar.Name)) {
					hasProductReference = true;
					break;
				}
			}
			// Can't use Runtime.ConnectMethod if not referencing the containing assembly
			if (!hasProductReference)
				return false;

			// Check if the assembly references the method.
			foreach (var mr in assembly.MainModule.GetMemberReferences ()) {
				if (mr.Name != "ConnectMethod")
					continue;
				if (mr.DeclaringType == null)
					continue;
				if (mr.DeclaringType.Name != "Runtime")
					continue;
				if (mr.DeclaringType.Namespace != "ObjCRuntime")
					continue;
				if (!Profile.IsProductAssembly (mr.Module.Assembly))
					continue;
				return true;
			}

			return false;
#endif
		}

		protected override void EndProcess ()
		{
			base.EndProcess ();

			LinkContext.CachedIsNSObject = cached_isnsobject;
			LinkContext.NeedsIsDirectBindingCheck = isdirectbinding_value;
		}

		protected override void MapType (TypeDefinition type)
		{
			base.MapType (type);

			// additional checks for NSObject to check if the type is a *generated* bindings
			// bonus: we cache, for every type, whether or not it inherits from NSObject (very useful later)
			if (!IsNSObject (type))
				return;
			
			SetIsDirectBindingValue (type);
#if DEBUG
			else
				Console.WriteLine ("{0} does NOT needs IsDirectBinding check", type);
#endif
		}
		
		// called once for each 'type' so it's a nice place to cache the result
		// and ensure later steps re-use the same, pre-computed, result
		bool IsNSObject (TypeDefinition type)
		{
			if (!type.IsNSObject (LinkContext))
				return false;
			cached_isnsobject.Add (type);
			return true;
		}
		
		// type has a "public .ctor (IntPtr)" with a [CompilerGenerated] attribute
		static bool IsGeneratedBindings (TypeDefinition type, DerivedLinkContext link_context)
		{
			if (type.IsNested)
				return IsGeneratedBindings (type.DeclaringType, link_context);
			
			if (!type.HasMethods)
				return false;
			
			foreach (MethodDefinition m in type.Methods) {
				if (!m.IsConstructor)
					continue;
				if (!m.HasParameters)
					continue;
				if (m.Parameters.Count != 1)
					continue;
				if (!m.Parameters [0].ParameterType.Is ("System", "IntPtr"))
					continue;
				return m.IsGeneratedCode (link_context);
			}
			return false;
		}
		
		void SetIsDirectBindingValue (TypeDefinition type)
		{
			if (type.IsSealed) {
				isdirectbinding_value [type] = true;
			} else if (type.IsAbstract) {
				isdirectbinding_value [type] = false;
			} else if (!isdirectbinding_value.ContainsKey (type)) {
				isdirectbinding_value [type] = true; // Let's try 'true' first, any derived classes will clear it if needed
				// we must clear the IsDirectBinding for any superclasses (unless they're abstract, in which case IsDirectBinding can stay as 'false')
				var base_type = type.BaseType.Resolve ();
				while (base_type != null && IsNSObject (base_type)) {
					if (!base_type.IsAbstract)
						isdirectbinding_value [base_type] = null;	
					base_type = base_type.BaseType.Resolve ();
				}
			}
		}
	}
}