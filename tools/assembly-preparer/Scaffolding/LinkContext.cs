using System.Collections.Generic;
using Mono.Cecil;
using Xamarin.Bundler;

namespace Mono.Linker;

public class LinkContext {
	public AnnotationStore Annotations { get => throw new NotImplementedException (); }

	public List<AssemblyDefinition> Assemblies = new List<AssemblyDefinition> ();
	public AssemblyDefinition [] GetAssemblies () { return Assemblies.ToArray (); }

	public LinkerConfiguration Configuration { get; private set; }

	public LinkContext (LinkerConfiguration configuration)
	{
		Configuration = configuration;
	}
}
