using System.Collections.Generic;

using Mono.Cecil;
using Mono.Linker;

using XamCore.Registrar;

namespace Xamarin.Tuner
{
	public class DerivedLinkContext : LinkContext
	{
		internal StaticRegistrar StaticRegistrar;
		Dictionary<string, List<MemberReference>> required_symbols;
		Dictionary<string, TypeDefinition> objectivec_classes;

		public List<MemberReference> GetRequiredSymbolList (string symbol)
		{
			List<MemberReference> rv;
			if (!RequiredSymbols.TryGetValue (symbol, out rv))
				required_symbols [symbol] = rv = new List<MemberReference> ();
			return rv;
		}

		public Dictionary<string, List<MemberReference>> RequiredSymbols {
			get {
				if (required_symbols == null)
					required_symbols = new Dictionary<string, List<MemberReference>> ();
				return required_symbols;
			}
		}

		public Dictionary<string, TypeDefinition> ObjectiveCClasses {
			get {
				if (objectivec_classes == null)
					objectivec_classes = new Dictionary<string, TypeDefinition> ();
				return objectivec_classes;
			}
		}
		
		public DerivedLinkContext (Pipeline pipeline, AssemblyResolver resolver)
			: base (pipeline, resolver)
		{
		}
	}
}
