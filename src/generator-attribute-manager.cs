using System;
#if IKVM
using IKVM.Reflection;
using Type = IKVM.Reflection.Type;
#else
using System.Reflection;
#endif

public static class AttributeManager
{
#if IKVM
	public static System.Attribute GetCustomAttribute (ICustomAttributeProvider provider, Type type, bool inherit = false /* REMOVE */)
	{
		throw new NotImplementedException ();
	}

	public static T GetCustomAttribute<T> (ICustomAttributeProvider provider, bool inherit = false /* REMOVE */) where T : System.Attribute
	{
		throw new NotImplementedException ();
	}

	public static T [] GetCustomAttributes<T> (ICustomAttributeProvider provider, bool inherits) where T : System.Attribute
	{
		throw new NotImplementedException ();
	}

	public static object [] GetCustomAttributes (ICustomAttributeProvider provider, Type type, bool inherits)
	{
		throw new NotImplementedException ();
	}

	public static object [] GetCustomAttributes (ICustomAttributeProvider provider, bool inherits)
	{
		throw new NotImplementedException ();
	}

	public static bool HasAttribute<T> (ICustomAttributeProvider provider, bool inherit = false) where T : Attribute
	{
		throw new NotImplementedException ();
	}

	public static bool HasAttribute (ICustomAttributeProvider provider, string type_name, bool inherit = false)
	{
		throw new NotImplementedException ();
	}

	public static bool HasAttribute (ICustomAttributeProvider provider, Type attribute_type, bool inherits = false)
	{
		throw new NotImplementedException ();
	}

	public static Type GetAttributeType (System.Attribute attribute)
	{
		throw new NotImplementedException ();
	}

	public static ICustomAttributeProvider GetReturnTypeCustomAttributes (MethodInfo method)
	{
		throw new NotImplementedException ();
	}

	public static Type GetAttributeType (System.Type type)
	{
		throw new NotImplementedException ();
	}
#else
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
		throw new BindingException (1051, true, "Internal error: Don't know how to get attributes for {0}. Please file a bug report (http://bugzilla.xamarin.com) with a test case.", provider.GetType ().FullName);
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

	public static bool HasAttribute (ICustomAttributeProvider provider, Type attribute_type, bool inherits = false)
	{
		var attribs = GetCustomAttributes (provider, attribute_type, inherits);
		if (attribs == null || attribs.Length == 0)
			return false;

		return true;
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
#endif
}
