namespace Mono.Linker;

using Mono.Cecil;

public interface IMarkHandler {
	void Initialize (LinkContext context, MarkContext markContext);
	//     void Initialize (LinkContext context, MarkContext markContext);
	//     void ProcessAssembly (AssemblyDefinition assembly);
	//     void ProcessType (TypeDefinition type);
	//     void ProcessField (FieldDefinition field);
	//     void ProcessMethod (MethodDefinition method);
	//     void ProcessParameter (ParameterDefinition parameter);
	//     void ProcessProperty (PropertyDefinition property);
	//     void ProcessEvent (EventDefinition eventDef);

}
