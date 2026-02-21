namespace Mono.Linker;

using System.Collections.Generic;
using Mono.Cecil;

public class MarkContext {
	List<Action<AssemblyDefinition>> markAssemblyActions = new ();
	List<Action<AssemblyDefinition>> markAssemblyEndActions = new ();
	List<Action<TypeDefinition>> markTypeActions = new ();
	List<Action<MethodDefinition>> markMethodActions = new ();

	// takes care of nested types as well
	public void MarkType (TypeDefinition type)
	{
		foreach (var action in markTypeActions) {
			action (type);
		}

		if (type.HasMethods && markMethodActions.Count > 0) {
			foreach (var method in type.Methods) {
				foreach (var action in markMethodActions) {
					action (method);
				}
			}
		}

		if (type.HasNestedTypes) {
			foreach (var nested in type.NestedTypes) {
				MarkType (nested);
			}
		}
	}

	public void MarkAssembly (AssemblyDefinition assembly)
	{
		foreach (var action in markAssemblyActions) {
			action (assembly);
		}
	}

	public void MarkAssemblyEnd (AssemblyDefinition assembly)
	{
		foreach (var action in markAssemblyEndActions) {
			action (assembly);
		}
	}

	public void RegisterMarkTypeAction (Action<TypeDefinition> action)
	{
		markTypeActions.Add (action);
	}

	public void RegisterMarkMethodAction (Action<MethodDefinition> action)
	{
		markMethodActions.Add (action);
	}

	public void RegisterMarkAssemblyAction (Action<AssemblyDefinition> action)
	{
		markAssemblyActions.Add (action);
	}

	public void RegisterMarkAssemblyEndAction (Action<AssemblyDefinition> action)
	{
		markAssemblyEndActions.Add (action);
	}
}
