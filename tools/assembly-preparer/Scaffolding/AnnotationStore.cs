using System.Diagnostics;
using Mono.Cecil;

namespace Mono.Linker;

public class AnnotationStore {
	Dictionary<AssemblyDefinition, AssemblyAction> assemblyActions = new Dictionary<AssemblyDefinition, AssemblyAction> ();
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
		throw new NotImplementedException ();
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

	OverrideInformation (MethodDefinition @override)
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
