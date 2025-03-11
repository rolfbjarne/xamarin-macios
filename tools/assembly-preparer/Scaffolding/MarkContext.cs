namespace Mono.Linker;

using System.Collections.Generic;
using Mono.Cecil;

public class MarkContext {
	List<Action<TypeDefinition>> markTypeActions = new List<Action<TypeDefinition>> ();

	// takes care of nested types as well
	public void MarkType (TypeDefinition type)
	{
		foreach (var action in markTypeActions) {
			action (type);
		}

		if (type.HasNestedTypes) {
			foreach (var nested in type.NestedTypes) {
				MarkType (nested);
			}
		}
	}

	public void RegisterMarkTypeAction (Action<TypeDefinition> action)
	{
		markTypeActions.Add (action);
	}
}
