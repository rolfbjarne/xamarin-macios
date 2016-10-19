#if IKVM
using IKVM.Reflection;
using Type=IKVM.Reflection.Type;
#else
using System.Reflection;
using Type=System.Type;
#endif

public static class AttributeManager
{
	public static System.Attribute [] GetCustomAttributes (ICustomAttributeProvider provider, Type type, bool inherits = false)
	{
#if IKVM
		return CustomAttributeData.GetCustomAttributes (provider, type);
#else
		return (System.Attribute []) provider.GetCustomAttributes (type, inherits);
#endif
	}

	public static System.Attribute [] GetCustomAttributes (ICustomAttributeProvider provider, bool inherits = false)
	{
#if IKVM
		return CustomAttributeData.GetCustomAttributes (provider);
#else
		return (System.Attribute []) provider.GetCustomAttributes (inherits);
#endif
	}

	public static bool HasAttribute (ICustomAttributeProvider provider, bool inherits, params Type [] any_attribute_type)
	{
		var attribs = GetCustomAttributes (provider, inherits);
		if (attribs == null || attribs.Length == 0)
			return false;

		foreach (var attrib in attribs) {
			var attribType = GetAttributeType (attrib);
			for (int t = 0; t < any_attribute_type.Length; t++) {
				if (TypeManager.IsSubclassOf (any_attribute_type [t], attribType))
					return true;
			}
		}

		return false;
	}

	public static bool HasAttribute (ICustomAttributeProvider provider, Type attribute_type, bool inherits = false)
	{
		var attribs = GetCustomAttributes (provider, inherits);
		if (attribs == null || attribs.Length == 0)
			return false;

		foreach (var attrib in attribs) {
			var attribType = GetAttributeType (attrib);
			if (TypeManager.IsSubclassOf (attrib, attribType))
				return true;
		}

		return false;
	}

	public static Type GetAttributeType (System.Attribute attribute)
	{
#if IKVM
		throw new NotImplementedException ();
#else
		return attribute.GetType ();
#endif
	}

	public static Type GetAttributeType (System.Type type)
	{
		throw new System.NotImplementedException ();
	}
}

public static class TypeManager {
	public static Type System_Int32 { get; set; }
	public static Type System_Int64 { get; set; }
	public static Type System_UInt32 { get; set; }
	public static Type System_UInt64 { get; set; }
	public static Type System_Int16 { get; set; }
	public static Type System_UInt16 { get; set; }
	public static Type System_Byte { get; set; }
	public static Type System_SByte { get; set; }
	public static Type System_Double { get; set; }
	public static Type System_Float { get; set; }
	public static Type System_Boolean {get; set; }
	public static Type System_IntPtr { get; set; }
	public static Type System_nint { get; set; }
	public static Type System_nuint { get; set; }
	public static Type System_nfloat { get; set; }
	public static Type System_Void { get; set; }
	public static Type System_String { get; set; }
	public static Type System_String_Array { get; set; }
	public static Type System_Delegate { get; set; }

	public static Type NSObject { get; set; }
	public static Type INativeObject { get; set; }

	public static Type LinkWithAttribute { get; set; }
	public static Type BaseTypeAttribute { get; set; }
	public static Type ProtocolAttribute { get; set; }
	public static Type StaticAttribute { get; set; }
	public static Type PartialAttribute { get; set; }
	public static Type StrongDictionaryAttribute { get; set; }
	public static Type FlagsAttribute { get; set; }
	public static Type AbstractAttribute { get; set; }
	public static Type NativeAttribute { get; set; }
	public static Type BlockCallbackAttribute { get; set; }
	public static Type CCallbackAttribute { get; set; }
	public static Type NullAllowedAttribute { get; set; }
	public static Type OutAttribute { get; set; }
	public static Type BindAttribute { get; set; }
	public static Type MarshalNativeExceptionsAttribute { get; set; }
	public static Type TargetAttribute { get; set; }

	public static Type DictionaryContainerType { get; set; }

	public static Type AudioBuffers { get; set; }

	public static bool IsSubclassOf (Type base_class, Type derived_class)
	{
		throw new System.NotImplementedException ();
	}

	static TypeManager ()
	{
#if IKVM

#else
	System_Int32 = typeof (int);
	System_Int64 = typeof (long);
	System_UInt32 = typeof (uint);
	System_UInt64 = typeof (ulong);
	System_Int16 = typeof (short);
	System_UInt16 = typeof (ushort);
	System_Byte = typeof (byte);
	System_SByte = typeof (sbyte);
	System_Double = typeof (double);
	System_Float = typeof (float);
	System_Boolean = typeof (bool);
	System_IntPtr = typeof (System.IntPtr);
#if __UNIFIED__
	System_nint = typeof (System.nint);
	System_nuint = typeof (System.nuint);
	System_nfloat = typeof (System.nfloat);
#endif
#endif
	}

	public static Type GetUnderlyingEnumType (Type type)
	{
		throw new System.NotImplementedException ();
	}
}