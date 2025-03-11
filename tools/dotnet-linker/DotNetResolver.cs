using System;

using Mono.Cecil;

using Xamarin.Bundler;

#nullable enable

namespace Xamarin.Linker {
	public class DotNetResolver : CoreResolver {
		public override AssemblyDefinition Resolve (AssemblyNameReference name, ReaderParameters parameters)
		{
			if (cache.TryGetValue (name.Name, out var assembly) && assembly.Name.FullName == name.FullName)
				return assembly;
			throw new NotImplementedException ($"Unable to resolve the assembly reference {name}");
		}
	}
}
