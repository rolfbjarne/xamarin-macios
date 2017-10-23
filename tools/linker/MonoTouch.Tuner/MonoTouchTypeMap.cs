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
		HashSet<MethodDefinition> generated_code = new HashSet<MethodDefinition> ();

		DerivedLinkContext LinkContext {
			get {
				return (DerivedLinkContext) base.Context;
			}
		}

		protected override void EndProcess ()
		{
			base.EndProcess ();

			LinkContext.CachedIsNSObject = cached_isnsobject;
			LinkContext.NeedsIsDirectBindingCheck = isdirectbinding_value;
			LinkContext.GeneratedCode = generated_code;
		}

		protected override void MapType (TypeDefinition type)
		{
			base.MapType (type);

			// we'll remove [GeneratedCode] in RemoveAttribute but we need this information later
			// when processing Dispose methods in MonoTouchMarkStep
			if (type.HasMethods) {
				foreach (MethodDefinition m in type.Methods) {
					if (m.IsGeneratedCode (LinkContext))
						generated_code.Add (m);
				}
			}
			
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