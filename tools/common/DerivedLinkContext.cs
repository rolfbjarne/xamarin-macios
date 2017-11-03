using System.Collections.Generic;
using System.Linq;

using Mono.Cecil;
using Mono.Linker;

using XamCore.Registrar;
using Xamarin.Bundler;

namespace Xamarin.Tuner
{
	public class DerivedLinkContext : LinkContext
	{
		internal StaticRegistrar StaticRegistrar;
		internal Target Target;
		Symbols required_symbols;

		// SDK candidates - they will be preserved only if the application (not the SDK) uses it
		List<ICustomAttributeProvider> srs_data_contract = new List<ICustomAttributeProvider> ();
		List<ICustomAttributeProvider> xml_serialization = new List<ICustomAttributeProvider> ();

		HashSet<TypeDefinition> cached_isnsobject;
		Dictionary<TypeDefinition, bool?> needs_isdirectbinding_check;

		public Dictionary<TypeDefinition, List<TypeDefinition>> ProtocolImplementations { get; private set; } = new Dictionary<TypeDefinition, List<TypeDefinition>> ();

		public bool DynamicRegistrationSupported { get; set; }

		public HashSet<TypeDefinition> CachedIsNSObject {
			get { return cached_isnsobject; }
			set { cached_isnsobject = value; }
		}

		public Dictionary<TypeDefinition, bool?> NeedsIsDirectBindingCheck {
			get { return needs_isdirectbinding_check; }
			set { needs_isdirectbinding_check = value; }
		}

		public IList<ICustomAttributeProvider> DataContract {
			get {
				return srs_data_contract;
			}
		}

		public IList<ICustomAttributeProvider> XmlSerialization {
			get {
				return xml_serialization;
			}
		}

		public Symbols RequiredSymbols {
			get {
				if (required_symbols == null)
					required_symbols = new Symbols ();
				return required_symbols;
			}
		}

		public DerivedLinkContext (Pipeline pipeline, AssemblyResolver resolver)
			: base (pipeline, resolver)
		{
		}

		public List<ICustomAttribute> GetCustomAttributes (ICustomAttributeProvider provider, string attribute_namespace, string attribute_name)
		{
			var annotations = Annotations?.GetCustomAnnotations (attribute_name);
			object storage = null;
			if (annotations?.TryGetValue (provider, out storage) != true)
				return null;
			return (List<ICustomAttribute>) storage;
		}

		public void StoreProtocolMethods (TypeDefinition type)
		{
			var attribs = Annotations.GetCustomAnnotations ("ProtocolMethods");
			object value;
			if (!attribs.TryGetValue (type, out value)) {
				attribs [type] = type.Methods.ToArray (); // Make a copy of the collection.
				System.Console.WriteLine ($"Stored protocol methods for {type.FullName}");
			}
		}

		public IList<MethodDefinition> GetProtocolMethods (TypeDefinition type)
		{
			var attribs = Annotations.GetCustomAnnotations ("ProtocolMethods");
			object value;
			if (attribs.TryGetValue (type, out value)) {
				System.Console.WriteLine ($"Got protocol methods for {type.FullName}");
				return (MethodDefinition []) value;
			}
			return null;
		}
	}
}
