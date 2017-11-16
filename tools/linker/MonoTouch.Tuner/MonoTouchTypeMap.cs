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

using Xamarin.Bundler;
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
			LinkContext.DynamicRegistrationSupported |= RequiresDynamicRegistrar (assembly);

			base.ProcessAssembly (assembly);
		}

		// If certain conditions are met, we can optimize away the code for the dynamic registrar..
		bool RequiresDynamicRegistrar (AssemblyDefinition assembly)
		{
#if MONOMAC && !XAMCORE_2_0
			// Disable removing the dynamic registrar for XM/Classic to simplify the code a little bit.
			return true;
#else
			if (LinkContext.Target.App.Registrar != RegistrarMode.Static)
				return true;

			// Req 1: Nobody must call Runtime.ConnectMethod.
			if (HasProductMethodReference (assembly, "ObjCRuntime", "Runtime", "ConnectMethod")) {
				Driver.Log (4, "Can't optimize away the dynamic registrar, because {0} references Runtime.ConnectMethod.", assembly.FullName);
				return true;
			}

			// Req 2: Nobody must call BlockLiteral.SetupBlock[Unsafe].
			//
			// Fortunately the linker is able to rewrite calls to SetupBlock[Unsafe] to call
			// SetupBlockImpl (which doesn't need the dynamic registrar), which means we only have
			// to look in assemblies that aren't linked.
			if (LinkContext.Annotations.GetAction (assembly) != Mono.Linker.AssemblyAction.Link) {
				if (HasProductMethodReference (assembly, "ObjCRuntime", "BlockLiteral", "SetupBlock")) {
					Driver.Log (4, "Can't optimize away the dynamic registrar, because {0} references BlockLiteral.SetupBlock.", assembly.FullName);
					return true;
				}
				if (HasProductMethodReference (assembly, "ObjCRuntime", "BlockLiteral", "SetupBlockImpl")) {
					Driver.Log (4, "Can't optimize away the dynamic registrar, because {0} references BlockLiteral.SetupBlockImpl.", assembly.FullName);
					return true;
				}
			}

			return false;
#endif
		}

		bool HasProductMethodReference (AssemblyDefinition assembly, string @namespace, string type_name, string method_name)
		{
			if (Profile.IsProductAssembly (assembly) || Profile.IsSdkAssembly (assembly)) {
				// We know that the assemblies we ship don't use the methods we're looking for.
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

			// Can't use reference a product method if not referencing the product assembly.
			if (!hasProductReference)
				return false;

			// Check if the assembly references the method.
			foreach (var mr in assembly.MainModule.GetMemberReferences ()) {
				if (mr.Name != method_name)
					continue;
				if (mr.DeclaringType == null)
					continue;
				if (mr.DeclaringType.Name != type_name)
					continue;
				if (mr.DeclaringType.Namespace != @namespace)
					continue;
				if (!Profile.IsProductAssembly (mr.Module.Assembly))
					continue;

				return true;
			}

			return false;
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
			if (isdirectbinding_value.ContainsKey (type))
				return;
			
			var registerAttribute = LinkContext.StaticRegistrar.GetRegisterAttribute (type);
			var isWrapperType = registerAttribute?.IsWrapper == true || registerAttribute?.SkipRegistration == true;
			var clearSuperclasses = false;
			if (!isWrapperType) {
				isdirectbinding_value [type] = false;
				Console.WriteLine ($"Setting IsDirectBinding=false for {type.FullName} because the type is not a wrapper type.");
				// We must clear IsDirectBinding for any superclasses.
				clearSuperclasses = true;
			} else if (type.IsSealed) {
				isdirectbinding_value [type] = true;
				Console.WriteLine ($"Setting IsDirectBinding=true for {type.FullName} because the type is sealed wrapper type.");
			} else if (!isdirectbinding_value.ContainsKey (type)) {
				isdirectbinding_value [type] = true; // Let's try 'true' first, any derived non-wrapper classes will clear it if needed
				Console.WriteLine ($"Setting IsDirectBinding=true for {type.FullName} because the type is a wrapper type.");
			}

			if (clearSuperclasses) {
				var base_type = type.BaseType.Resolve ();
				while (base_type != null && IsNSObject (base_type)) {
					if (isdirectbinding_value.ContainsKey (base_type) && isdirectbinding_value [base_type] != null)
						Console.WriteLine ($"Setting IsDirectBinding=null for {base_type.FullName} because the type contains a derived non-wrapper type ({type.FullName}).");
					isdirectbinding_value [base_type] = null;
					base_type = base_type.BaseType.Resolve ();
				}
			}
		}
	}
}