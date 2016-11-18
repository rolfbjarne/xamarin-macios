using System;
using System.Reflection;

public static class AttributeManager
{
	public static System.Attribute GetCustomAttribute (ICustomAttributeProvider provider, Type type, bool inherit = false /* REMOVE */)
	{
		if (provider == null) {
			Console.WriteLine ("Null provider getting {0}", type.FullName);
			return null;
		}
		var pi = provider as ParameterInfo;
		if (pi != null)
			return Attribute.GetCustomAttribute (pi, type, inherit);
		var mi = provider as MemberInfo;
		if (mi != null)
			return Attribute.GetCustomAttribute (mi, type, inherit);
		var asm = provider as Assembly;
		if (asm != null)
			return Attribute.GetCustomAttribute (asm, type, inherit);
		throw new NotImplementedException (provider.GetType ().FullName);
	}

	public static T GetCustomAttribute <T> (ICustomAttributeProvider provider, bool inherit = false /* REMOVE */) where T: System.Attribute
	{
		return (T) GetCustomAttribute (provider, typeof (T), inherit);
	}

	public static T [] GetCustomAttributes<T> (ICustomAttributeProvider provider, bool inherits) where T : System.Attribute
	{
		return (T []) provider.GetCustomAttributes (typeof (T), inherits);
	}


	public static object [] GetCustomAttributes (ICustomAttributeProvider provider, Type type, bool inherits)
	{
		if (type == null)
			throw new System.ArgumentNullException (nameof (type));

		return (System.Attribute []) provider.GetCustomAttributes (type, inherits);
	}

	public static object [] GetCustomAttributes (ICustomAttributeProvider provider, bool inherits)
	{
		return provider.GetCustomAttributes (inherits);
	}

	public static bool HasAttribute<T> (ICustomAttributeProvider provider, bool inherit = false) where T : Attribute
	{
		return HasAttribute (provider, typeof (T), inherit);
	}

	public static bool HasAttribute (ICustomAttributeProvider provider, string type_name, bool inherit = false)
	{
		foreach (var attr in AttributeManager.GetCustomAttributes (provider, inherit)) {
			if (attr.GetType ().Name == type_name)
				return true;
		}

		return false;
	}

	public static bool HasAttribute (ICustomAttributeProvider provider, bool inherits, params Type [] any_attribute_type)
	{
		var attribs = GetCustomAttributes (provider, inherits);
		if (attribs == null || attribs.Length == 0)
			return false;

		foreach (var attrib in attribs) {
			var attribType = GetAttributeType ((System.Attribute) attrib);
			for (int t = 0; t < any_attribute_type.Length; t++) {
				if (any_attribute_type [t] == attribType) {
					//System.Console.WriteLine ("Has exact attribute: {0}", provider);
					return true;
				}
				if (any_attribute_type [t].IsSubclassOf (attribType)) {
					//System.Console.WriteLine ("Has attribute: {0}", provider);
					return true;
				} else {
					//System.Console.WriteLine ("Attribute check: {0} {1} is not of {2}", provider, any_attribute_type [t], attribType);
				}
			}
		}

		//System.Console.WriteLine ("No attribute: {0}", provider);
		return false;
	}

	public static bool HasAttribute (ICustomAttributeProvider provider, Type attribute_type, bool inherits = false)
	{
		var attribs = GetCustomAttributes (provider, inherits);
		if (attribs == null || attribs.Length == 0) {
			//Console.WriteLine ("No {0} for {1}", attribute_type, provider);
			return false;
		}

		foreach (var attrib in attribs) {
			var attribType = GetAttributeType ((System.Attribute) attrib);
			if (attribute_type == attribType)
				return true;
			if (attribute_type.IsSubclassOf (attribType))
				return true;
		}

		return false;
	}

	public static Type GetAttributeType (System.Attribute attribute)
	{
		return GetAttributeType (attribute.GetType ());
	}

	public static ICustomAttributeProvider GetReturnTypeCustomAttributes (MethodInfo method)
	{
		return method.ReturnTypeCustomAttributes;
	}

	public static Type GetAttributeType (System.Type type)
	{
		return type;
	}
}
