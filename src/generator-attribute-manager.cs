using System;
using System.Collections.Generic;

#if IKVM
using IKVM.Reflection;
using Type = IKVM.Reflection.Type;
#else
using System.Reflection;
#endif

public static class AttributeManager
{
#if IKVM
	static object [] EmptyAttributes = new object [0];

	static System.Type ConvertType (Type type)
	{
		System.Type rv;
		if (type.Assembly == TypeManager.CorlibAssembly) {
			rv = typeof (int).Assembly.GetType (type.FullName);
		} else if (type.Assembly == TypeManager.SystemAssembly) {
			rv = typeof (System.ComponentModel.EditorBrowsableAttribute).Assembly.GetType (type.FullName);
		} else if (type.Assembly == TypeManager.BindingAssembly) {
			rv = typeof (TypeManager).Assembly.GetType (type.FullName);
		} else if (type.Assembly == TypeManager.PlatformAssembly) {
			var prefix = BindingTouch.NamespacePlatformPrefix;
			var n = type.FullName;
			if (!string.IsNullOrEmpty (prefix) && type.Namespace.StartsWith (prefix, System.StringComparison.Ordinal)) {
				n = "XamCore." + n.Substring (prefix.Length + 1);
			} else {
				n = "XamCore." + n;
			}
			rv = typeof (TypeManager).Assembly.GetType (n);
		} else {
			throw new System.NotImplementedException ();
		}
		if (rv == null)
			throw new System.NotImplementedException ();
		return rv;
	}

	static Type ConvertType (System.Type type)
	{
		Type rv;
		if (type.Assembly == typeof (int).Assembly) {
			rv = TypeManager.CorlibAssembly.GetType (type.FullName);
		} else if (type.Assembly == typeof (System.ComponentModel.EditorBrowsableAttribute).Assembly) {
			rv = TypeManager.SystemAssembly.GetType (type.FullName);
		} else if (type.Assembly == typeof (TypeManager).Assembly) {
			rv = TypeManager.BindingAssembly.GetType (type.FullName);
			if (rv == null) {
				string fullname;
				if (type.Namespace?.StartsWith ("XamCore.", System.StringComparison.Ordinal) == true) {
					var prefix = BindingTouch.NamespacePlatformPrefix;
					if (!string.IsNullOrEmpty (prefix)) {
						fullname = prefix + "." + type.FullName.Substring (8);
					} else {
						fullname = type.FullName.Substring (8);
					}
				} else {
					fullname = type.FullName;
				}
				rv = TypeManager.PlatformAssembly.GetType (fullname);
			}
		} else {
			throw new System.NotImplementedException ();
		}
		if (rv == null)
			throw new System.NotImplementedException ();
		return rv;
	}

	static System.Attribute CreateAttributeInstance (CustomAttributeData attribute)
	{
		System.Type attribType = ConvertType (attribute.AttributeType);

		var constructorArguments = new object [attribute.ConstructorArguments.Count];

		for (int i = 0; i < constructorArguments.Length; i++) {
			var value = attribute.ConstructorArguments [i].Value;
			switch (attribute.ConstructorArguments [i].ArgumentType.FullName) {
			case "System.Type":
				if (value != null) {
					if (attribType.Assembly == typeof (TypeManager).Assembly) {
						constructorArguments [i] = value;
					} else {
						constructorArguments [i] = System.Type.GetType (((Type) value).FullName);
					}
					if (constructorArguments [i] == null)
						throw new System.NotImplementedException ();
				}
				break;
			default:
				constructorArguments [i] = value;
				break;
			}
		}

		var parameters = attribute.Constructor.GetParameters ();
		var ctorTypes = new System.Type [parameters.Length];
		for (int i = 0; i < ctorTypes.Length; i++) {
			var paramType = parameters [i].ParameterType;
			switch (paramType.FullName) {
			case "System.Type":
				if (attribType.Assembly == typeof (TypeManager).Assembly) {
					ctorTypes [i] = typeof (Type);
				} else {
					ctorTypes [i] = typeof (System.Type);
				}
				break;
			default:
				ctorTypes [i] = ConvertType (paramType);
				break;
			}
			if (ctorTypes [i] == null)
				throw new System.NotImplementedException ();
		}
		var ctor = attribType.GetConstructor (ctorTypes);
		if (ctor == null)
			throw new System.NotImplementedException ();
		var instance = ctor.Invoke (constructorArguments);

		for (int i = 0; i < attribute.NamedArguments.Count; i++) {
			var arg = attribute.NamedArguments [i];
			var value = arg.TypedValue.Value;
			if (arg.TypedValue.ArgumentType == TypeManager.System_String_Array) {
				var typed_values = (CustomAttributeTypedArgument []) arg.TypedValue.Value;
				var arr = new string [typed_values.Length];
				for (int a = 0; a < arr.Length; a++)
					arr [a] = (string) typed_values [a].Value;
				value = arr;
			} else if (arg.TypedValue.ArgumentType.FullName == "System.Type[]") {
				var typed_values = (CustomAttributeTypedArgument []) arg.TypedValue.Value;
				var arr = new Type [typed_values.Length];
				for (int a = 0; a < arr.Length; a++)
					arr [a] = (Type) typed_values [a].Value;
				value = arr;
			} else if (arg.TypedValue.ArgumentType.IsArray) {
				throw new System.NotImplementedException ();
			}
			if (arg.IsField) {
				attribType.GetField (arg.MemberName).SetValue (instance, value);
			} else {
				attribType.GetProperty (arg.MemberName).SetValue (instance, value, new object [] { });
			}
		}

		return (System.Attribute) instance;
	}

	static object [] FilterAttributes (IList<CustomAttributeData> attributes, Type type)
	{
		if (attributes == null || attributes.Count == 0)
			return EmptyAttributes;

		if (type == null) {
			var rv = new System.Attribute [attributes.Count];
			for (int i = 0; i < attributes.Count; i++)
				rv [i] = CreateAttributeInstance (attributes [i]);
			return rv;
		}

		List<System.Attribute> list = null;
		for (int i = 0; i < attributes.Count; i++) {
			var attrib = attributes [i];
			if (attrib.AttributeType != type && !IsSubclassOf (type, attrib.AttributeType))
				continue;

			if (list == null)
				list = new List<System.Attribute> ();
			list.Add (CreateAttributeInstance (attributes [i]));
		}

		if (list != null)
			return list.ToArray ();

		return EmptyAttributes;
	}

	static T [] FilterAttributes<T> (IList<CustomAttributeData> attributes) where T : System.Attribute
	{
		if (attributes == null || attributes.Count == 0)
			return new T [0]; // FIXME: ugh, we end up allocating a lot of empty arrays

		var type = GetAttributeType (typeof (T));
		List<T> list = null;
		for (int i = 0; i < attributes.Count; i++) {
			var attrib = attributes [i];
			if (attrib.AttributeType != type && !IsSubclassOf (type, attrib.AttributeType))
				continue;

			if (list == null)
				list = new List<T> ();
			list.Add ((T) CreateAttributeInstance (attributes [i]));
		}

		if (list != null)
			return list.ToArray ();

		return new T [0]; // FIXME: ugh, we end up allocating a lot of empty arrays
	}

	public static T [] GetCustomAttributes<T> (ICustomAttributeProvider provider) where T : System.Attribute
	{
		return FilterAttributes<T> (GetIKVMAttributes (provider));
	}

	public static object [] GetCustomAttributes (ICustomAttributeProvider provider, Type type)
	{
		if (type == null)
			throw new System.ArgumentNullException (nameof (type));

		return FilterAttributes (GetIKVMAttributes (provider), type);
	}

	static IList<CustomAttributeData> GetIKVMAttributes (ICustomAttributeProvider provider)
	{
		var member = provider as MemberInfo;
		if (member != null)
			return CustomAttributeData.GetCustomAttributes (member);
		var assembly = provider as Assembly;
		if (assembly != null)
			return CustomAttributeData.GetCustomAttributes (assembly);
		var pinfo = provider as ParameterInfo;
		if (pinfo != null)
			return CustomAttributeData.GetCustomAttributes (pinfo);
		var module = provider as Module;
		if (module != null)
			return CustomAttributeData.GetCustomAttributes (module);
		throw new BindingException (1051, true, "Internal error: Don't know how to get attributes for {0}. Please file a bug report (https://bugzilla.xamarin.com) with a test case.", provider.GetType ().FullName);
	}

	public static bool HasAttribute (ICustomAttributeProvider provider, string type_name)
	{
		var attribs = GetIKVMAttributes (provider);
		for (int i = 0; i < attribs.Count; i++)
			if (attribs [i].AttributeType.Name == type_name)
				return true;
		return false;
	}

	public static bool HasAttribute (ICustomAttributeProvider provider, Type attribute_type)
	{
		var attribs = GetIKVMAttributes (provider);
		if (attribs == null || attribs.Count == 0)
			return false;

		for (int i = 0; i < attribs.Count; i++) {
			var attrib = attribs [i];
			if (attrib.AttributeType == attribute_type)
				return true;
			if (IsSubclassOf (attribute_type, attrib.AttributeType))
				return true;
		}

		return false;
	}

	public static bool HasAttribute<T> (ICustomAttributeProvider provider) where T : Attribute
	{
		return HasAttribute (provider, ConvertType (typeof (T)));
	}

	public static T GetCustomAttribute<T> (ICustomAttributeProvider provider) where T : System.Attribute
	{
		var rv = GetCustomAttributes<T> (provider);
		if (rv.Length == 1)
			return rv [0];
		if (rv.Length == 0)
			return null;
		throw new NotImplementedException ();
	}

	public static Type GetAttributeType (System.Attribute attribute)
	{
		return GetAttributeType (attribute.GetType ());
	}

	public static ICustomAttributeProvider GetReturnTypeCustomAttributes (MethodInfo method)
	{
		return method.ReturnParameter;
	}

	public static Type GetAttributeType (System.Type type)
	{
		return ConvertType (type);
	}

	static bool IsSubclassOf (Type base_class, Type derived_class)
	{
		return derived_class.IsSubclassOf (base_class);
	}
#else
	static System.Attribute GetCustomAttribute (ICustomAttributeProvider provider, Type type)
	{
		if (provider == null)
			return null;

		var pi = provider as ParameterInfo;
		if (pi != null)
			return Attribute.GetCustomAttribute (pi, type);
		var mi = provider as MemberInfo;
		if (mi != null)
			return Attribute.GetCustomAttribute (mi, type);
		var asm = provider as Assembly;
		if (asm != null)
			return Attribute.GetCustomAttribute (asm, type);
		throw new BindingException (1051, true, "Internal error: Don't know how to get attributes for {0}. Please file a bug report (http://bugzilla.xamarin.com) with a test case.", provider.GetType ().FullName);
	}

	public static T GetCustomAttribute <T> (ICustomAttributeProvider provider) where T: System.Attribute
	{
		return (T) GetCustomAttribute (provider, typeof (T));
	}

	public static T [] GetCustomAttributes<T> (ICustomAttributeProvider provider) where T : System.Attribute
	{
		return (T []) provider.GetCustomAttributes (typeof (T));
	}

	public static object [] GetCustomAttributes (ICustomAttributeProvider provider, Type type)
	{
		if (type == null)
			throw new System.ArgumentNullException (nameof (type));

		return (System.Attribute []) provider.GetCustomAttributes (type);
	}

	public static object [] GetCustomAttributes (ICustomAttributeProvider provider)
	{
		return provider.GetCustomAttributes ();
	}

	public static bool HasAttribute<T> (ICustomAttributeProvider provider) where T : Attribute
	{
		return HasAttribute (provider, typeof (T));
	}

	public static bool HasAttribute (ICustomAttributeProvider provider, string type_name)
	{
		foreach (var attr in AttributeManager.GetCustomAttributes (provider)) {
			if (attr.GetType ().Name == type_name)
				return true;
		}

		return false;
	}

	public static bool HasAttribute (ICustomAttributeProvider provider, Type attribute_type)
	{
		var attribs = GetCustomAttributes (provider, attribute_type);
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
