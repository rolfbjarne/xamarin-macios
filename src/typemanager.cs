
#if !__WATCHOS__
#define AUDIOTOOLBOX
#define AUDIOUNIT
#define COREMEDIA
#define MEDIATOOLBOX
#endif

#if __IOS__ || __TVOS__
#define AUDIOTOOLBOX_MUSICSEQUENCE
#endif

#if !__TVOS__ && !__WATCHOS__ && !MONOMAC
#define ADDRESSBOOK
#endif

#if !__TVOS__ && !__WATCHOS__
#define COREMIDI
#endif

#if !__WATCHOS__
#define COREVIDEO
#endif

#if MONOMAC
#define OPENGL
#endif

using System.Collections.Generic;

#if IKVM
using System.Diagnostics.Contracts;
using IKVM.Reflection;
using Type=IKVM.Reflection.Type;
#else
using System.Reflection;
using Type=System.Type;

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

using DictionaryContainerType = XamCore.Foundation.DictionaryContainer;


using XamCore.CoreGraphics;
using XamCore.Foundation;
#if !__UNIFIED__
using XamCore;
#endif
using XamCore.ObjCRuntime;
#if COREMEDIA
using XamCore.CoreMedia;
#endif
using XamCore.CoreFoundation;
using XamCore.Security;
using XamCore.AVFoundation;
#if COREVIDEO
using XamCore.CoreVideo;
#endif
using XamCore.AudioToolbox;
#if AUDIOUNIT
using XamCore.AudioUnit;
#endif
#if MEDIATOOLBOX
using XamCore.MediaToolbox;
#endif
#if ADDRESSBOOK
using XamCore.AddressBook;
#endif
#if COREMIDI
using XamCore.CoreMidi;
#endif
#if OPENGL
using XamCore.OpenGL;
#endif
#endif

public static class AttributeManager
{
	public static System.Attribute GetCustomAttribute (MemberInfo provider, Type type)
	{
#if IKVM
		// FIXME: improve perf here.
		var list = GetCustomAttributes (provider, type, false);
		if (list.Length == 0)
			return null;
		if (list.Length > 1)
			throw new System.Reflection.AmbiguousMatchException ();
		return (System.Attribute) list [0];
#else
		return System.Attribute.GetCustomAttribute (provider, type);
#endif
	}

	static object [] EmptyAttributes = new object [0];

	static System.Attribute CreateAttributeInstance (CustomAttributeData attribute)
	{
		var attribType = typeof (TypeManager).Assembly.GetType (attribute.AttributeType.FullName);
		if (attribType == null)
			attribType = typeof (TypeManager).Assembly.GetType ("XamCore." + attribute.AttributeType.FullName);
		if (attribType == null)
			attribType = System.Type.GetType (attribute.AttributeType.AssemblyQualifiedName);
		if (attribType == null)
			throw new System.NotImplementedException ();
		var constructorArguments = new object [attribute.ConstructorArguments.Count];

		for (int i = 0; i < constructorArguments.Length; i++)
			constructorArguments [i] = attribute.ConstructorArguments [i].Value;
		
		var parameters = attribute.Constructor.GetParameters ();
		var ctorTypes = new System.Type [parameters.Length];
		for (int i = 0; i < ctorTypes.Length; i++) {
			var paramType = parameters [i].ParameterType;
			switch (paramType.FullName) {
			case "System.Type":
				ctorTypes [i] = typeof (Type);
				break;
			default:
				ctorTypes [i] = typeof (TypeManager).Assembly.GetType ("XamCore." + parameters [i].ParameterType.FullName);
				if (ctorTypes [i] == null) {
					ctorTypes [i] = System.Type.GetType (parameters [i].ParameterType.AssemblyQualifiedName);
					if (ctorTypes [i] == null)
						ctorTypes [i] = System.Type.GetType (parameters [i].ParameterType.FullName);
				}
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
			if (attrib.AttributeType != type && !TypeManager.IsSubclassOf (type, attrib.AttributeType))
				continue;

			if (list == null)
				list = new List<System.Attribute> ();
			list.Add (CreateAttributeInstance (attributes [i]));
		}

		if (list != null)
			return list.ToArray ();

		return EmptyAttributes;
	}

	public static object [] GetCustomAttributes (ICustomAttributeProvider provider, Type type, bool inherits)
	{
#if IKVM
		return FilterAttributes (GetIKVMAttributes (provider), type);
#else
		return (System.Attribute []) provider.GetCustomAttributes (type, inherits);
#endif
	}

	public static object [] GetCustomAttributes (ICustomAttributeProvider provider, bool inherits)
	{
#if IKVM
		return FilterAttributes (GetIKVMAttributes (provider), null);
#else
		return provider.GetCustomAttributes (inherits);
#endif
	}

	public static bool HasAttribute (ICustomAttributeProvider provider, bool inherits, params Type [] any_attribute_type)
	{
#if IKVM
		var attribs = GetIKVMAttributes (provider);
		if (attribs == null || attribs.Count == 0)
			return false;

		for (int i = 0; i < attribs.Count; i++) {
			var attrib = attribs [i];
			var attribType = attrib.AttributeType;
			for (int t = 0; t < any_attribute_type.Length; t++) {
				if (any_attribute_type [t] == attribType)
					return true;
				
				if (TypeManager.IsSubclassOf (any_attribute_type [t], attribType))
					return true;
			}
		}

#else
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
				if (TypeManager.IsSubclassOf (any_attribute_type [t], attribType)) {
					//System.Console.WriteLine ("Has attribute: {0}", provider);
					return true;
				} else {
					//System.Console.WriteLine ("Attribute check: {0} {1} is not of {2}", provider, any_attribute_type [t], attribType);
				}
			}
		}
#endif
		//System.Console.WriteLine ("No attribute: {0}", provider);
		return false;
	}

#if IKVM
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
		throw new System.NotImplementedException ();
	}
#endif

	public static bool HasAttribute (ICustomAttributeProvider provider, Type attribute_type, bool inherits = false)
	{
#if IKVM
		var attribs = GetIKVMAttributes (provider);
		if (attribs == null || attribs.Count == 0)
			return false;

		for (int i = 0; i < attribs.Count; i++) {
			var attrib = attribs [i];
			if (attrib.AttributeType == attribute_type)
				return true;
			if (TypeManager.IsSubclassOf (attribute_type, attrib.AttributeType))
				return true;
		}

		return false;
#else
		var attribs = GetCustomAttributes (provider, inherits);
		if (attribs == null || attribs.Length == 0) {
			//Console.WriteLine ("No {0} for {1}", attribute_type, provider);
			return false;
		}

		foreach (var attrib in attribs) {
			var attribType = GetAttributeType ((System.Attribute) attrib);
			if (attribute_type == attribType)
				return true;
			if (TypeManager.IsSubclassOf (attribute_type, attribType))
				return true;
		}

		return false;
#endif
	}

	public static Type GetAttributeType (System.Attribute attribute)
	{
#if IKVM
		throw new System.NotImplementedException ();
#else
		return attribute.GetType ();
#endif
	}

	public static ICustomAttributeProvider GetReturnTypeCustomAttributes (MethodInfo method)
	{
#if IKVM
		return method.ReturnParameter;
		throw new System.NotImplementedException ();
#else
		return method.ReturnTypeCustomAttributes;
#endif
	}

	public static Type GetAttributeType (System.Type type)
	{
#if IKVM
		var asm = TypeManager.binding_attribute_assembly;
		var name = type.FullName;
		if (name.StartsWith ("XamCore.", System.StringComparison.Ordinal))
			name = name.Substring (8);
		var rv = asm.GetType (name);
		if (rv == null) {
			rv = TypeManager.platform_assembly.GetType (name);
		}
		if (rv == null)
			throw new System.NotImplementedException ();
		return rv;
#else
		return type;
#endif
	}
}

public static class TypeManager {
	public static Type System_Object { get; set; }
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
	public static Type System_Attribute;

	public static Type NSObject { get; set; }
	public static Type INativeObject { get; set; }
	public static Type Selector { get; set; }
	public static Type BlockLiteral { get; set; }
	public static Type Class;
	public static Type Protocol;
	public static Type Constants;

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
	public static Type WrapAttribute { get; set; }
	public static Type AlignAttribute { get; set; }
	public static Type ExportAttribute { get; set; }
	public static Type TransientAttribute { get; set; }
	public static Type IsThreadStaticAttribute;
	public static Type FieldAttribute;
	public static Type CoreImageFilterPropertyAttribute;
	public static Type AvailabilityBaseAttribute;
	public static Type RegisterAttribute;
	public static Type ModelAttribute;
	public static Type ProtocolizeAttribute;
	public static Type ParamsAttribute;
	public static Type ParamArrayAttribute;
	public static Type PrologueSnippetAttribute;
	public static Type PreSnippetAttribute;
	public static Type PostGetAttribute;
	public static Type FactoryAttribute;
	public static Type SyntheticAttribute;
	public static Type ProxyAttribute;
	public static Type PostSnippetAttribute;
	public static Type ThreadSafeAttribute;
	public static Type DesignatedInitializerAttribute;
	public static Type ManualAttribute;
	public static Type RetainAttribute;
	public static Type AsyncAttribute;
	public static Type NotImplementedAttribute;
	public static Type ZeroCopyStringsAttribute;
	public static Type CoreImageFilterAttribute;
	public static Type AdvancedAttribute;
	public static Type AppearanceAttribute;
	public static Type NotificationAttribute;
	public static Type NoDefaultValueAttribute;
	public static Type CheckDisposedAttribute;
	public static Type EventNameAttribute;
	public static Type DelegateApiNameAttribute;
	public static Type EventArgsAttribute;
	public static Type DelegateNameAttribute;
	public static Type DefaultValueAttribute;
	public static Type DefaultValueFromArgumentAttribute;
	public static Type CategoryAttribute;
	public static Type DisposeAttribute;
	public static Type InternalAttribute;
	public static Type UnifiedInternalAttribute;
	public static Type ProtectedAttribute;
	public static Type OverrideAttribute;
	public static Type NewAttribute;
	public static Type SealedAttribute;
	public static Type AutoreleaseAttribute;
	public static Type DisableZeroCopyAttribute;
	public static Type PlainStringAttribute;
	public static Type ReleaseAttribute;
#if !__UNIFIED__
	public static Type AlphaAttribute;
#endif

	public static Type FieldOffsetAttribute;
	public static Type MarshalAsAttribute;
	public static Type EditorBrowsableAttribute;
	public static Type OptionalImplementationAttribute;
	public static Type DebuggerDisplayAttribute;
	public static Type DebuggerBrowsableAttribute;
	public static Type ObsoleteAttribute;

	public static Type DictionaryContainerType { get; set; }

	public static Type AudioBuffers { get; set; }
	public static Type MusicSequence { get; set; }
	public static Type CMSampleBuffer;
	public static Type CGColor;
	public static Type CGPath;
	public static Type CGGradient;
	public static Type CGContext;
	public static Type CGImage;
	public static Type CGColorSpace;
	public static Type DispatchQueue;
	public static Type MidiEndpoint;
	public static Type CMTimebase;
	public static Type CMClock;
	public static Type NSZone;
	public static Type ABAddressBook;
	public static Type ABPerson;
	public static Type ABRecord;
	public static Type MTAudioProcessingTap;
	public static Type CVPixelBuffer;
	public static Type CGLayer;
	public static Type CVImageBuffer;
	public static Type CVPixelBufferPool;
	public static Type AudioComponent;
	public static Type CMFormatDescription;
	public static Type CMAudioFormatDescription;
	public static Type CMVideoFormatDescription;
	public static Type SecIdentity;
	public static Type SecTrust;
	public static Type SecAccessControl;
	public static Type AURenderEventEnumerator;
	public static Type CFRunLoop;
	public static Type AudioUnit;

#if __UNIFIED__ || IKVM
	public static Type CGRect;
	public static Type CGPoint;
	public static Type CGSize;
#endif

	public static Type CMTime;
	public static Type NSString;
	public static Type ProbePresenceAttribute;
	public static Type AVCaptureWhiteBalanceGains;
	public static Type CGLContext;
	public static Type CGLPixelFormat;

	public static bool IsSubclassOf (Type base_class, Type derived_class)
	{
#if IKVM
		return base_class.IsSubclassOf (derived_class);
#else
		return base_class.IsSubclassOf (derived_class);
#endif
	}

	static Type LookupType (Assembly assembly, string @namespace, string name)
	{
#if IKVM
		Type rv;
		if (string.IsNullOrEmpty (@namespace)) {
			rv = assembly.GetType (name);
		} else {
			rv = assembly.GetType (@namespace + "." + name);
		}
		if (rv == null)
			System.Console.WriteLine ("Could not load the type: {0}{1}", string.IsNullOrEmpty (@namespace) ? string.Empty : @namespace + ".", name);
		return rv;
#else
		throw new System.NotImplementedException ();
#endif
	}

#if IKVM
	static Assembly mscorlib;
	static Assembly system;
	internal static Assembly platform_assembly;
	internal static Assembly binding_attribute_assembly;
#endif

	static TypeManager ()
	{
#if IKVM
		mscorlib = BindingTouch.universe.Load ("mscorlib.dll");
		system = BindingTouch.universe.Load ("System.dll");
		platform_assembly = BindingTouch.universe.Load ("Xamarin.iOS.dll");
		binding_attribute_assembly = BindingTouch.universe.Load ("Xamarin.iOS.BindingAttributes.dll");

		/* Types from mscorlib.dll */
		System_Object = LookupType (mscorlib, "System", "Object");
		System_Int32 = LookupType (mscorlib, "System", "Int32");
		System_Int64 = LookupType (mscorlib, "System", "Int64");
		System_UInt32 = LookupType (mscorlib, "System", "UInt32");
		System_UInt64 = LookupType (mscorlib, "System", "UInt64");
		System_Int16 = LookupType (mscorlib, "System", "Int16");
		System_UInt16 = LookupType (mscorlib, "System", "UInt16");
		System_Byte = LookupType (mscorlib, "System", "Byte");
		System_SByte = LookupType (mscorlib, "System", "SByte");
		System_Double = LookupType (mscorlib, "System", "Double");
		System_Float = LookupType (mscorlib, "System", "Single");
		System_Boolean = LookupType (mscorlib, "System", "Boolean");
		System_IntPtr = LookupType (mscorlib, "System", "IntPtr");
		System_Void = LookupType (mscorlib, "System", "Void");
		System_String = LookupType (mscorlib, "System", "String");
		System_String_Array = System_String.MakeArrayType ();
		System_Delegate = LookupType (mscorlib, "System", "Delegate");
		System_Attribute = LookupType (mscorlib, "System", "Attribute");

		FlagsAttribute = LookupType (mscorlib, "System", "FlagsAttribute");
		ObsoleteAttribute = LookupType (mscorlib, "System", "ObsoleteAttribute");
		ParamArrayAttribute = LookupType (mscorlib, "System", "ParamArrayAttribute");
		FieldOffsetAttribute = LookupType (mscorlib, "System.Runtime.InteropServices", "FieldOffsetAttribute");
		MarshalAsAttribute = LookupType (mscorlib, "System.Runtime.InteropServices", "MarshalAsAttribute");
		OutAttribute = LookupType (mscorlib, "System.Runtime.InteropServices", "OutAttribute");
		DebuggerDisplayAttribute = LookupType (mscorlib, "System.Diagnostics", "DebuggerDisplayAttribute");
		DebuggerBrowsableAttribute = LookupType (mscorlib, "System.Diagnostics", "DebuggerBrowsableAttribute");

		/* Types from System.dll */
		EditorBrowsableAttribute = LookupType (system, "System.ComponentModel", "EditorBrowsableAttribute");

		/* Attribute types from the platform assembly (Xamarin.*.dll) */
		System_nint = LookupType (platform_assembly, "System", "nint");
		System_nuint = LookupType (platform_assembly, "System", "nuint");
		System_nfloat = LookupType (platform_assembly, "System", "nfloat");
		LinkWithAttribute = LookupType (platform_assembly, "ObjCRuntime", "LinkWithAttribute");
		ProtocolAttribute = LookupType (platform_assembly, "Foundation", "ProtocolAttribute");
		NativeAttribute = LookupType (platform_assembly, "ObjCRuntime", "NativeAttribute");
		ExportAttribute = LookupType (platform_assembly, "Foundation", "ExportAttribute");
		FieldAttribute = LookupType (platform_assembly, "Foundation", "FieldAttribute");
		AvailabilityBaseAttribute = LookupType (platform_assembly, "ObjCRuntime", "AvailabilityBaseAttribute");
		RegisterAttribute = LookupType (platform_assembly, "Foundation", "RegisterAttribute");
		ModelAttribute = LookupType (platform_assembly, "Foundation", "ModelAttribute");
		CategoryAttribute = LookupType (platform_assembly, "ObjCRuntime", "CategoryAttribute");

		/* Binding-only attributes, from the binding attribute assembly (Xamarin.*.BindingAttributes.dll) */
		AbstractAttribute = LookupType (binding_attribute_assembly, "", "AbstractAttribute");
		BlockCallbackAttribute = LookupType (binding_attribute_assembly, "", "BlockCallbackAttribute");
		CCallbackAttribute = LookupType (binding_attribute_assembly, "", "CCallbackAttribute");
		NullAllowedAttribute = LookupType (binding_attribute_assembly, "", "NullAllowedAttribute");
		BindAttribute = LookupType (binding_attribute_assembly, "", "BindAttribute");
		MarshalNativeExceptionsAttribute = LookupType (binding_attribute_assembly, "", "MarshalNativeExceptionsAttribute");
		StaticAttribute = LookupType (binding_attribute_assembly, "", "StaticAttribute");
		PartialAttribute = LookupType (binding_attribute_assembly, "", "PartialAttribute");
		StrongDictionaryAttribute = LookupType (binding_attribute_assembly, "", "StrongDictionaryAttribute");
		AlignAttribute = LookupType (binding_attribute_assembly, "", "AlignAttribute");
		BaseTypeAttribute = LookupType (binding_attribute_assembly, "", "BaseTypeAttribute");
		ManualAttribute = LookupType (binding_attribute_assembly, "", "ManualAttribute");
		RetainAttribute = LookupType (binding_attribute_assembly, "", "RetainAttribute");
		AsyncAttribute = LookupType (binding_attribute_assembly, "", "AsyncAttribute");
		NotImplementedAttribute = LookupType (binding_attribute_assembly, "", "NotImplementedAttribute");
		ZeroCopyStringsAttribute = LookupType (binding_attribute_assembly, "", "ZeroCopyStringsAttribute");
		CoreImageFilterAttribute = LookupType (binding_attribute_assembly, "", "CoreImageFilterAttribute");
		AdvancedAttribute = LookupType (binding_attribute_assembly, "", "AdvancedAttribute");
		AppearanceAttribute = LookupType (binding_attribute_assembly, "", "AppearanceAttribute");
		NotificationAttribute = LookupType (binding_attribute_assembly, "", "NotificationAttribute");
		NoDefaultValueAttribute = LookupType (binding_attribute_assembly, "", "NoDefaultValueAttribute");
		CheckDisposedAttribute = LookupType (binding_attribute_assembly, "", "CheckDisposedAttribute");
		EventNameAttribute = LookupType (binding_attribute_assembly, "", "EventNameAttribute");
		DelegateApiNameAttribute = LookupType (binding_attribute_assembly, "", "DelegateApiNameAttribute");
		EventArgsAttribute = LookupType (binding_attribute_assembly, "", "EventArgsAttribute");
		DelegateNameAttribute = LookupType (binding_attribute_assembly, "", "DelegateNameAttribute");
		DefaultValueAttribute = LookupType (binding_attribute_assembly, "", "DefaultValueAttribute");
		DefaultValueFromArgumentAttribute = LookupType (binding_attribute_assembly, "", "DefaultValueFromArgumentAttribute");
		DisposeAttribute = LookupType (binding_attribute_assembly, "", "DisposeAttribute");
		InternalAttribute = LookupType (binding_attribute_assembly, "", "InternalAttribute");
		UnifiedInternalAttribute = LookupType (binding_attribute_assembly, "", "UnifiedInternalAttribute");
		ProtectedAttribute = LookupType (binding_attribute_assembly, "", "ProtectedAttribute");
		OverrideAttribute = LookupType (binding_attribute_assembly, "", "OverrideAttribute");
		NewAttribute = LookupType (binding_attribute_assembly, "", "NewAttribute");
		SealedAttribute = LookupType (binding_attribute_assembly, "", "SealedAttribute");
		AutoreleaseAttribute = LookupType (binding_attribute_assembly, "", "AutoreleaseAttribute");
		DisableZeroCopyAttribute = LookupType (binding_attribute_assembly, "", "DisableZeroCopyAttribute");
		PlainStringAttribute = LookupType (binding_attribute_assembly, "", "PlainStringAttribute");
		ReleaseAttribute = LookupType (binding_attribute_assembly, "", "ReleaseAttribute");
		AlphaAttribute = LookupType (binding_attribute_assembly, "", "AlphaAttribute");
		OptionalImplementationAttribute = LookupType (binding_attribute_assembly, "", "OptionalImplementationAttribute");
		ProbePresenceAttribute = LookupType (binding_attribute_assembly, "", "ProbePresenceAttribute");
		TargetAttribute = LookupType (binding_attribute_assembly, "", "TargetAttribute");
		WrapAttribute = LookupType (binding_attribute_assembly, "", "WrapAttribute");
		TransientAttribute = LookupType (binding_attribute_assembly, "", "TransientAttribute");
		IsThreadStaticAttribute = LookupType (binding_attribute_assembly, "", "IsThreadStaticAttribute");
		CoreImageFilterPropertyAttribute = LookupType (binding_attribute_assembly, "", "CoreImageFilterPropertyAttribute");
		ProtocolizeAttribute = LookupType (binding_attribute_assembly, "", "ProtocolizeAttribute");
		ParamsAttribute = LookupType (binding_attribute_assembly, "", "ParamsAttribute");
		PrologueSnippetAttribute = LookupType (binding_attribute_assembly, "", "PrologueSnippetAttribute");
		PreSnippetAttribute = LookupType (binding_attribute_assembly, "", "PreSnippetAttribute");
		PostGetAttribute = LookupType (binding_attribute_assembly, "", "PostGetAttribute");
		FactoryAttribute = LookupType (binding_attribute_assembly, "", "FactoryAttribute");
		SyntheticAttribute = LookupType (binding_attribute_assembly, "", "SyntheticAttribute");
		ProxyAttribute = LookupType (binding_attribute_assembly, "", "ProxyAttribute");
		PostSnippetAttribute = LookupType (binding_attribute_assembly, "", "PostSnippetAttribute");
		ThreadSafeAttribute = LookupType (binding_attribute_assembly, "", "ThreadSafeAttribute");
		DesignatedInitializerAttribute = LookupType (binding_attribute_assembly, "", "DesignatedInitializerAttribute");


		/* Types from the platform assembly (Xamarin.*.dll) */
		INativeObject = LookupType (platform_assembly, "ObjCRuntime", "INativeObject");
		Selector = LookupType (platform_assembly, "ObjCRuntime", "Selector");
		BlockLiteral = LookupType (platform_assembly, "ObjCRuntime", "BlockLiteral");
		Class = LookupType (platform_assembly, "ObjCRuntime", "Class");
		Protocol = LookupType (platform_assembly, "ObjCRuntime", "Protocol");
		Constants = LookupType (platform_assembly, "ObjCRuntime", "Constants");
		AudioBuffers = LookupType (platform_assembly, "AudioToolbox", "AudioBuffers");
		MusicSequence = LookupType (platform_assembly, "AudioToolbox", "MusicSequence");
		AudioComponent = LookupType (platform_assembly, "AudioUnit", "AudioComponent");
		AURenderEventEnumerator = LookupType (platform_assembly, "AudioUnit", "AURenderEventEnumerator");
		AudioUnit = LookupType (platform_assembly, "AudioUnit", "AudioUnit");
		CMSampleBuffer = LookupType (platform_assembly, "CoreMedia", "CMSampleBuffer");
		CMTimebase = LookupType (platform_assembly, "CoreMedia", "CMTimebase");
		CMClock = LookupType (platform_assembly, "CoreMedia", "CMClock");
		CMFormatDescription = LookupType (platform_assembly, "CoreMedia", "CMFormatDescription");
		CMAudioFormatDescription = LookupType (platform_assembly, "CoreMedia", "CMAudioFormatDescription");
		CMVideoFormatDescription = LookupType (platform_assembly, "CoreMedia", "CMVideoFormatDescription");
		CMTime = LookupType (platform_assembly, "CoreMedia", "CMTime");
		CGColor = LookupType (platform_assembly, "CoreGraphics", "CGColor");
		CGPath = LookupType (platform_assembly, "CoreGraphics", "CGPath");
		CGGradient = LookupType (platform_assembly, "CoreGraphics", "CGGradient");
		CGContext = LookupType (platform_assembly, "CoreGraphics", "CGContext");
		CGImage = LookupType (platform_assembly, "CoreGraphics", "CGImage");
		CGColorSpace = LookupType (platform_assembly, "CoreGraphics", "CGColorSpace");
		CGRect = LookupType (platform_assembly, "CoreGraphics", "CGRect");
		CGPoint = LookupType (platform_assembly, "CoreGraphics", "CGPoint");
		CGSize = LookupType (platform_assembly, "CoreGraphics", "CGSize");
		CGLayer = LookupType (platform_assembly, "CoreGraphics", "CGLayer");
		DispatchQueue = LookupType (platform_assembly, "CoreFoundation", "DispatchQueue");
		CFRunLoop = LookupType (platform_assembly, "CoreFoundation", "CFRunLoop");
		MidiEndpoint = LookupType (platform_assembly, "CoreMidi", "MidiEndpoint");
		NSZone = LookupType (platform_assembly, "Foundation", "NSZone");
		NSObject = LookupType (platform_assembly, "Foundation", "NSObject");
		NSString = LookupType (platform_assembly, "Foundation", "NSString");
		DictionaryContainerType = LookupType (platform_assembly, "Foundation", "DictionaryContainer");
		ABAddressBook = LookupType (platform_assembly, "AddressBook", "ABAddressBook");
		ABPerson = LookupType (platform_assembly, "AddressBook", "ABPerson");
		ABRecord = LookupType (platform_assembly, "AddressBook", "ABRecord");
		MTAudioProcessingTap = LookupType (platform_assembly, "MediaToolbox", "MTAudioProcessingTap");
		CVPixelBuffer = LookupType (platform_assembly, "CoreVideo", "CVPixelBuffer");
		CVImageBuffer = LookupType (platform_assembly, "CoreVideo", "CVImageBuffer");
		CVPixelBufferPool = LookupType (platform_assembly, "CoreVideo", "CVPixelBufferPool");
		SecIdentity = LookupType (platform_assembly, "Security", "SecIdentity");
		SecTrust = LookupType (platform_assembly, "Security", "SecTrust");
		SecAccessControl = LookupType (platform_assembly, "Security", "SecAccessControl");
		AVCaptureWhiteBalanceGains = LookupType (platform_assembly, "AVFoundation", "AVCaptureWhiteBalanceGains");
		CGLContext = LookupType (platform_assembly, "OpenGL", "CGLContext");
		CGLPixelFormat = LookupType (platform_assembly, "OpenGL", "CGLPixelFormat");

#else // IKVM
	System_Object = typeof (object);
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

	System_Void = typeof (void);
	System_String = typeof (string);
	System_String_Array = typeof (string[]);
	System_Delegate = typeof (System.Delegate);
	System_Attribute = typeof (System.Attribute);

	NSObject = typeof (NSObject);
	INativeObject = typeof (INativeObject);
	Selector = typeof (Selector);
	BlockLiteral = typeof (BlockLiteral);
	Class = typeof (Class);
	Protocol = typeof (Protocol);

#if __UNIFIED__
	Constants = typeof (XamCore.ObjCRuntime.Constants);
#else
	Constants = typeof (XamCore.Constants);
#endif

	LinkWithAttribute = typeof (LinkWithAttribute);
	BaseTypeAttribute = typeof (BaseTypeAttribute);
	ProtocolAttribute = typeof (ProtocolAttribute);
	StaticAttribute = typeof (StaticAttribute);
	PartialAttribute = typeof (PartialAttribute);
	StrongDictionaryAttribute = typeof (StrongDictionaryAttribute);
	FlagsAttribute = typeof (FlagsAttribute);
	AbstractAttribute = typeof (AbstractAttribute);
	NativeAttribute = typeof (NativeAttribute);
	BlockCallbackAttribute = typeof (BlockCallbackAttribute);
	CCallbackAttribute = typeof (CCallbackAttribute);
	NullAllowedAttribute = typeof (NullAllowedAttribute);
	OutAttribute = typeof (OutAttribute);
	BindAttribute = typeof (BindAttribute);
	MarshalNativeExceptionsAttribute = typeof (MarshalNativeExceptionsAttribute);
	TargetAttribute = typeof (TargetAttribute);
	WrapAttribute = typeof (WrapAttribute);
	AlignAttribute = typeof (AlignAttribute);
	ExportAttribute = typeof (ExportAttribute);
	TransientAttribute = typeof (TransientAttribute);
	IsThreadStaticAttribute = typeof (IsThreadStaticAttribute);
	FieldAttribute = typeof (FieldAttribute);
	CoreImageFilterPropertyAttribute = typeof (CoreImageFilterPropertyAttribute);
	AvailabilityBaseAttribute = typeof (AvailabilityBaseAttribute);
	RegisterAttribute = typeof (RegisterAttribute);
	ModelAttribute = typeof (ModelAttribute);
	ProtocolizeAttribute = typeof (ProtocolizeAttribute);
	ParamsAttribute = typeof (ParamsAttribute);
	ParamArrayAttribute = typeof (ParamArrayAttribute);
	PrologueSnippetAttribute = typeof (PrologueSnippetAttribute);
	PreSnippetAttribute = typeof (PreSnippetAttribute);
	PostGetAttribute = typeof (PostGetAttribute);
	FactoryAttribute = typeof (FactoryAttribute);
	SyntheticAttribute = typeof (SyntheticAttribute);
	ProxyAttribute = typeof (ProxyAttribute);
	PostSnippetAttribute = typeof (PostSnippetAttribute);
	ThreadSafeAttribute = typeof (ThreadSafeAttribute);
	DesignatedInitializerAttribute = typeof (DesignatedInitializerAttribute);
	ManualAttribute = typeof (ManualAttribute);
	RetainAttribute = typeof (RetainAttribute);
	AsyncAttribute = typeof (AsyncAttribute);
	NotImplementedAttribute = typeof (NotImplementedAttribute);
	ZeroCopyStringsAttribute = typeof (ZeroCopyStringsAttribute);
	CoreImageFilterAttribute = typeof (CoreImageFilterAttribute);
	AdvancedAttribute = typeof (AdvancedAttribute);
	AppearanceAttribute = typeof (AppearanceAttribute);
	NotificationAttribute = typeof (NotificationAttribute);
	NoDefaultValueAttribute = typeof (NoDefaultValueAttribute);
	CheckDisposedAttribute = typeof (CheckDisposedAttribute);
	EventNameAttribute = typeof (EventNameAttribute);
	DelegateApiNameAttribute = typeof (DelegateApiNameAttribute);
	EventArgsAttribute = typeof (EventArgsAttribute);
	DelegateNameAttribute = typeof (DelegateNameAttribute);
	DefaultValueAttribute = typeof (DefaultValueAttribute);
	DefaultValueFromArgumentAttribute = typeof (DefaultValueFromArgumentAttribute);
	CategoryAttribute = typeof (CategoryAttribute);
	DisposeAttribute = typeof (DisposeAttribute);
	InternalAttribute = typeof (InternalAttribute);
	UnifiedInternalAttribute = typeof (UnifiedInternalAttribute);
	ProtectedAttribute = typeof (ProtectedAttribute);
	OverrideAttribute = typeof (OverrideAttribute);
	NewAttribute = typeof (NewAttribute);
	SealedAttribute = typeof (SealedAttribute);
	AutoreleaseAttribute = typeof (AutoreleaseAttribute);
	DisableZeroCopyAttribute = typeof (DisableZeroCopyAttribute);
	PlainStringAttribute = typeof (PlainStringAttribute);
	ReleaseAttribute = typeof (ReleaseAttribute);
#if !__UNIFIED__
	AlphaAttribute = typeof (AlphaAttribute);
#endif

	FieldOffsetAttribute = typeof (FieldOffsetAttribute);
	MarshalAsAttribute = typeof (MarshalAsAttribute);
	EditorBrowsableAttribute = typeof (EditorBrowsableAttribute);
	OptionalImplementationAttribute = typeof (OptionalImplementationAttribute);
	DebuggerDisplayAttribute = typeof (DebuggerDisplayAttribute);
	DebuggerBrowsableAttribute = typeof (DebuggerBrowsableAttribute);
	ObsoleteAttribute = typeof (ObsoleteAttribute);

	DictionaryContainerType = typeof (DictionaryContainerType);

#if AUDIOTOOLBOX
	AudioBuffers = typeof (AudioBuffers);
#if AUDIOTOOLBOX_MUSICSEQUENCE
	MusicSequence = typeof (MusicSequence);
#endif
#endif

#if COREMEDIA
	CMSampleBuffer = typeof (CMSampleBuffer);
	CMTimebase = typeof (CMTimebase);
	CMClock = typeof (CMClock);
#endif
	CGColor = typeof (CGColor);
	CGPath = typeof (CGPath);
	CGGradient = typeof (CGGradient);
	CGContext = typeof (CGContext);
	CGImage = typeof (CGImage);
	CGColorSpace = typeof (CGColorSpace);
	DispatchQueue = typeof (DispatchQueue);
#if COREMIDI
	MidiEndpoint = typeof (MidiEndpoint);
#endif
#if ADDRESSBOOK
	ABAddressBook = typeof (ABAddressBook);
	ABPerson = typeof (ABPerson);
	ABRecord = typeof (ABRecord);
#endif

	NSZone = typeof (NSZone);
#if MEDIATOOLBOX
	MTAudioProcessingTap = typeof (MTAudioProcessingTap);
#endif
#if COREVIDEO
	CVImageBuffer = typeof (CVImageBuffer);
	CVPixelBufferPool = typeof (CVPixelBufferPool);
	CVPixelBuffer = typeof (CVPixelBuffer);
#endif
	CGLayer = typeof (CGLayer);
#if COREMEDIA
	CMTime = typeof (CMTime);
	CMFormatDescription = typeof (CMFormatDescription);
	CMAudioFormatDescription = typeof (CMAudioFormatDescription);
	CMVideoFormatDescription = typeof (CMVideoFormatDescription);
#endif
	SecIdentity = typeof (SecIdentity);
	SecTrust = typeof (SecTrust);
	SecAccessControl = typeof (SecAccessControl);
#if AUDIOUNIT
	AudioComponent = typeof (AudioComponent);
	AURenderEventEnumerator = typeof (AURenderEventEnumerator);
	AudioUnit = typeof (XamCore.AudioUnit.AudioUnit);
#endif

	// CoreFoundation
	CFRunLoop = typeof (CFRunLoop);



#if __UNIFIED__
	CGRect = typeof (CGRect);
	CGPoint = typeof (CGPoint);
	CGSize = typeof (CGSize);
#endif

	NSString = typeof (NSString);

	ProbePresenceAttribute = typeof (ProbePresenceAttribute);
	AVCaptureWhiteBalanceGains = typeof (AVCaptureWhiteBalanceGains);
#if OPENGL
	CGLContext = typeof (CGLContext);
	CGLPixelFormat = typeof (CGLPixelFormat);
#endif

#if __UNIFIED__
	System_nint = typeof (System.nint);
	System_nuint = typeof (System.nuint);
	System_nfloat = typeof (System.nfloat);
#endif
#endif // IKVM
	}

	public static Type GetUnderlyingEnumType (Type type)
	{
#if IKVM
		return type.GetEnumUnderlyingType ();
#else
		return Enum.GetUnderlyingType (type);
#endif
	}

	public static bool IsEnumValueDefined (Type type, object value)
	{
#if IKVM
		var rv = type.IsEnumDefined (value);
		System.Console.WriteLine ("IsEnumValueDefined ({0}, {1}) => {2}", type, value, rv);
		return rv;
#else
		var enumValue = System.Enum.ToObject (type, value);
		return System.Array.IndexOf (System.Enum.GetValues (type), enumValue) >= 0;

#endif
		}
}