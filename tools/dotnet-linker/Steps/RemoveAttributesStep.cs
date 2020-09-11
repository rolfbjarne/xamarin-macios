using System;

using Mono.Cecil;
using Mono.Tuner;
using Xamarin.Tuner;

namespace Xamarin.Linker.Steps {
	public class RemoveAttributesStep : RemoveAttributesBase {
		public RemoveAttributesStep ()
		{
		}

		protected DerivedLinkContext LinkContext {
			get {
				return LinkerConfiguration.GetInstance (Context).DerivedLinkContext;
			}
		}

		protected override bool IsRemovedAttribute (CustomAttribute attribute)
		{
			// this avoids calling FullName (which allocates a string)
			var attr_type = attribute.Constructor.DeclaringType;
			switch (attr_type.Namespace) {
			case Namespaces.ObjCRuntime:
				switch (attr_type.Name) {
				case "AdoptsAttribute":
					return LinkContext.App.Optimizations.RegisterProtocols == true;
				}
				goto default;
			case Namespaces.Foundation:
				switch (attr_type.Name) {
				case "ProtocolAttribute":
				case "ProtocolMemberAttribute":
					return LinkContext.App.Optimizations.RegisterProtocols == true;
				}
				goto default;
			default:
				return false;
			}
		}

		protected override void WillRemoveAttribute (ICustomAttributeProvider provider, CustomAttribute attribute)
		{
			LinkContext.StoreCustomAttribute (provider, attribute);
			base.WillRemoveAttribute (provider, attribute);
		}
	}
}

