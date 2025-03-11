using Mono.Cecil;

namespace Mono.Linker;

public class AnnotationStore
{
    public AssemblyAction GetAction (AssemblyDefinition assembly)
    {
        throw new NotImplementedException ();
    }   
    public void SetAction (AssemblyDefinition assembly, AssemblyAction action)
    {
        throw new NotImplementedException ();
    }

    public void Mark (TypeDefinition type)
    {
        throw new NotImplementedException ();
    }
    public void Mark (ExportedType type)
    {
        throw new NotImplementedException ();
    }
}