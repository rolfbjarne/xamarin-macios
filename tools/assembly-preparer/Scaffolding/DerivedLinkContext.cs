namespace Xamarin.Tuner;

using Mono.Cecil;
using Mono.CompilerServices.SymbolWriter;
using Mono.Linker;
using Mono.Tuner;
using Xamarin.Bundler;

public class DerivedLinkContext : LinkContext {
	public RegistrarMode Registrar { get => Configuration.Registrar; }

	public Target Target { get => throw new NotImplementedException (); }

	public DerivedLinkContext (LinkerConfiguration configuration) : base (configuration)
	{
	}

	public IEnumerable<ICustomAttribute> GetCustomAttributes (ICustomAttributeProvider? provider, string @namespace, string name)
	{
		if (provider is null || !provider.HasCustomAttributes)
			yield break;

		foreach (var attrib in provider.CustomAttributes) {
			if (attrib.AttributeType.Is (@namespace, name))
				yield return attrib;
		}
	}

	/// <summary>
	/// Tries to resolve the TypeReference to a TypeDefinition
	/// </summary>
	public TypeDefinition? Resolve (TypeReference? typeReference)
	{
		if (typeReference is null)
			return null;

		if (typeReference is TypeDefinition typeDefinition)
			return typeDefinition;

		//
		// Types which never have TypeDefinition or can have ambiguous definition should not be passed in
		//
		if (typeReference is GenericParameter || (typeReference is TypeSpecification && typeReference is not GenericInstanceType))
			throw new NotSupportedException($"TypeDefinition cannot be resolved from '{typeReference.GetType()}' type");

		return Configuration.MetadataResolver.Resolve (typeReference);
	}
}
