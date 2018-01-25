using System;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Tuner;

using Xamarin.Tuner;

namespace Xamarin.Linker {

	public static class MobileExtensions {

		// Returns a string representation of the specified provider that is suitable for user-visible error/warning messages.
		public static string AsString (this ICustomAttributeProvider provider)
		{
			if (provider is MemberReference member)
				return member.DeclaringType.FullName + "." + member.Name;
			if (provider is MethodReturnType returnType)
				return AsString ((ICustomAttributeProvider) returnType.Method);
			return provider.ToString ();
		}

		// This method will look in any stored attributes in the link context as well as the provider itself.
		public static bool HasCustomAttribute (this ICustomAttributeProvider provider, DerivedLinkContext context, string @namespace, string name)
		{
			if (provider?.HasCustomAttribute (@namespace, name) == true)
				return true;
			
			return context?.GetCustomAttributes (provider, @namespace, name)?.Count > 0;
		}

		public static bool HasCustomAttribute (this ICustomAttributeProvider provider, string @namespace, string name)
		{
			if (provider == null || !provider.HasCustomAttributes)
				return false;

			foreach (CustomAttribute attribute in provider.CustomAttributes) {
				TypeReference tr = attribute.Constructor.DeclaringType;
				if (tr.Is (@namespace, name))
					return true;
			}
			return false;
		}

		static bool HasGeneratedCodeAttribute (ICustomAttributeProvider provider, DerivedLinkContext context)
		{
			return provider.HasCustomAttribute (context, "System.Runtime.CompilerServices", "CompilerGeneratedAttribute");
		}

		static PropertyDefinition GetPropertyByAccessor (MethodDefinition method)
		{
			foreach (PropertyDefinition property in method.DeclaringType.Properties) {
				if (property.GetMethod == method || property.SetMethod == method)
					return property;
			}
			return null;
		}

		public static bool IsGeneratedCode (this MethodDefinition self, DerivedLinkContext link_context)
		{
			// check the property too
			if (self.IsGetter || self.IsSetter) {
				if (HasGeneratedCodeAttribute (GetPropertyByAccessor (self), link_context))
					return true;
			}
			return HasGeneratedCodeAttribute (self, link_context);
		}
	}
}