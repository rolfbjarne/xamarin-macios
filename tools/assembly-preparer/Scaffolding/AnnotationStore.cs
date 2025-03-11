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
}
