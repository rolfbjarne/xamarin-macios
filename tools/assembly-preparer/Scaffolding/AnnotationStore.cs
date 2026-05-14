using System.Diagnostics;
using Mono.Cecil;

namespace Mono.Linker;

public class AnnotationStore {
	Dictionary<AssemblyDefinition, AssemblyAction> assemblyActions = new Dictionary<AssemblyDefinition, AssemblyAction> ();
	Dictionary<MethodDefinition, List<OverrideInformation>> overrides = new Dictionary<MethodDefinition, List<OverrideInformation>> ();
	public AssemblyAction GetAction (AssemblyDefinition assembly)
	{
		if (assemblyActions.TryGetValue (assembly, out var action))
			return action;
		throw new InvalidOperationException ($"Assembly {assembly.Name} not found in the annotation store");
	}

	public void SetAction (AssemblyDefinition assembly, AssemblyAction action)
	{
		assemblyActions [assembly] = action;
	}

	public IEnumerable<OverrideInformation>? GetOverrides (MethodDefinition method)
	{
		if (overrides.TryGetValue (method, out var list))
			return list;
		return null;
	}

	// Scan all types in the given assemblies and build the overrides map.
	// For each method that overrides a base virtual method (or explicitly implements an interface method),
	// record an OverrideInformation entry keyed by the base method.
	public void CollectOverrides (IEnumerable<AssemblyDefinition> assemblies, LinkContext context)
	{
		foreach (var assembly in assemblies) {
			foreach (var module in assembly.Modules) {
				foreach (var type in module.GetTypes ()) {
					CollectOverridesForType (type, context);
				}
			}
		}
	}

	void CollectOverridesForType (TypeDefinition type, LinkContext context)
	{
		if (!type.HasMethods)
			return;

		foreach (var method in type.Methods) {
			// Handle explicit overrides (.override directive in IL / method.Overrides in Cecil)
			if (method.HasOverrides) {
				foreach (var overriddenRef in method.Overrides) {
					var baseMethod = TryResolve (overriddenRef);
					if (baseMethod is not null)
						AddOverride (baseMethod, method);
				}
			}

			// Handle implicit virtual method overrides via the type hierarchy
			if (method.IsVirtual && !method.IsNewSlot) {
				var baseMethod = GetBaseMethodInTypeHierarchy (type, method, context);
				if (baseMethod is not null)
					AddOverride (baseMethod, method);
			}
		}
	}

	void AddOverride (MethodDefinition baseMethod, MethodDefinition overridingMethod)
	{
		if (!overrides.TryGetValue (baseMethod, out var list)) {
			list = new List<OverrideInformation> ();
			overrides [baseMethod] = list;
		}
		list.Add (new OverrideInformation (overridingMethod));
	}

	static MethodDefinition? GetBaseMethodInTypeHierarchy (TypeDefinition type, MethodDefinition method, LinkContext context)
	{
		var baseTypeRef = type.BaseType;
		while (baseTypeRef is not null) {
			TypeDefinition? baseType;
			try {
				baseType = context.Resolve (baseTypeRef);
			} catch {
				break;
			}

			if (baseType.HasMethods) {
				foreach (var candidate in baseType.Methods) {
					if (candidate.IsVirtual && MethodMatch (candidate, method))
						return candidate;
				}
			}

			baseTypeRef = baseType.BaseType;
		}
		return null;
	}

	static bool MethodMatch (MethodDefinition candidate, MethodDefinition method)
	{
		if (candidate.Name != method.Name)
			return false;
		if (candidate.HasGenericParameters != method.HasGenericParameters)
			return false;
		if (candidate.GenericParameters.Count != method.GenericParameters.Count)
			return false;
		if (candidate.ReturnType.FullName != method.ReturnType.FullName)
			return false;
		if (candidate.HasParameters != method.HasParameters)
			return false;
		if (!candidate.HasParameters)
			return true;
		if (candidate.Parameters.Count != method.Parameters.Count)
			return false;
		for (int i = 0; i < candidate.Parameters.Count; i++) {
			if (candidate.Parameters [i].ParameterType.FullName != method.Parameters [i].ParameterType.FullName)
				return false;
		}
		return true;
	}

	static MethodDefinition? TryResolve (MethodReference methodRef)
	{
		try {
			return methodRef.Resolve ();
		} catch {
			// FIXME: figure out a way that doesn't require throwing and catching exceptions.
			return null;
		}
	}

	public void SetCustomAnnotation (object key, IMetadataTokenProvider item, object value)
	{
		throw new NotImplementedException ();
	}

	// This should not be called; once closer to done, just remove this method.
	public void Mark (object obj)
	{
		throw new UnreachableException ();
	}
}

[DebuggerDisplay ("{Override}")]
public class OverrideInformation {
	// public MethodDefinition Base { get; }

	public MethodDefinition Override { get; }

	// internal InterfaceImplementor? InterfaceImplementor { get; }

	internal OverrideInformation (MethodDefinition @override)
	{
		Override = @override;
	}

	// internal OverrideInformation(MethodDefinition @base, MethodDefinition @override, InterfaceImplementor? interfaceImplementor = null)
	// {
	// 	Base = @base;
	// 	Override = @override;
	// 	InterfaceImplementor = interfaceImplementor;
	// 	// Ensure we have an interface implementation if the base method is from an interface and the override method is on a class
	// 	Debug.Assert(@base.DeclaringType.IsInterface && interfaceImplementor is not null
	// 				|| !@base.DeclaringType.IsInterface && interfaceImplementor is null);
	// 	// Ensure the interfaceImplementor is for the interface we expect
	// 	Debug.Assert(@base.DeclaringType.IsInterface ? interfaceImplementor!.InterfaceType == @base.DeclaringType : true);
	// }

	// public InterfaceImplementation? MatchingInterfaceImplementation
	// 	=> InterfaceImplementor?.InterfaceImplementation;

	// public TypeDefinition? InterfaceType
	// 	=> InterfaceImplementor?.InterfaceType;

	// [MemberNotNullWhen(true, nameof(InterfaceImplementor), nameof(MatchingInterfaceImplementation))]
	// public bool IsOverrideOfInterfaceMember
	// 	=> InterfaceImplementor is not null;
}
