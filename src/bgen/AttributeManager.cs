using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

#nullable enable

public class AttributeManager {

	readonly Dictionary<System.Type, Type> typeLookup = new ();

	readonly HashSet<string?> ignoredAttributes = new () {
		"Microsoft.CodeAnalysis.EmbeddedAttribute",
		"System.Runtime.CompilerServices.NullableAttribute",
		"System.Runtime.CompilerServices.NullableContextAttribute",
		"System.Runtime.CompilerServices.NativeIntegerAttribute",
	};

	// Cache attribute query results per (provider, attribute type) to avoid
	// repeated reflection and attribute conversion work.
	readonly Dictionary<(ICustomAttributeProvider, System.Type), object> attributeCache = new ();

	// Cache HasAttribute<T> results to avoid repeated GetCustomAttributesData() calls.
	readonly Dictionary<(ICustomAttributeProvider, System.Type), bool> hasAttributeCache = new ();

	// Cache raw GetCustomAttributesData() results per provider to avoid repeated reflection allocations.
	readonly Dictionary<ICustomAttributeProvider, IList<CustomAttributeData>> rawAttributeCache = new ();

	TypeCache TypeCache { get; }

	public AttributeManager (TypeCache typeCache)
	{
		TypeCache = typeCache;
	}

	Type? LookupReflectionType (string? fullname, ICustomAttributeProvider? provider)
	{
		switch (fullname) {
		case "AbstractAttribute":
			return typeof (AbstractAttribute);
		case "AlignAttribute":
			return typeof (AlignAttribute);
		case "AppearanceAttribute":
			return typeof (AppearanceAttribute);
		case "AsyncAttribute":
			return typeof (AsyncAttribute);
		case "AutoreleaseAttribute":
			return typeof (AutoreleaseAttribute);
		case "BaseTypeAttribute":
			return typeof (BaseTypeAttribute);
		case "BindAttribute":
			return typeof (BindAttribute);
		case "CategoryAttribute":
			return typeof (CategoryAttribute);
		case "CheckDisposedAttribute":
			return typeof (CheckDisposedAttribute);
		case "CoreImageFilterAttribute":
			return typeof (CoreImageFilterAttribute);
		case "CoreImageFilterPropertyAttribute":
			return typeof (CoreImageFilterPropertyAttribute);
		case "DefaultCtorVisibilityAttribute":
			return typeof (DefaultCtorVisibilityAttribute);
		case "DefaultEnumValueAttribute":
			return typeof (DefaultEnumValueAttribute);
		case "DefaultValueAttribute":
			return typeof (DefaultValueAttribute);
		case "DefaultValueFromArgumentAttribute":
			return typeof (DefaultValueFromArgumentAttribute);
		case "DelegateApiNameAttribute":
			return typeof (DelegateApiNameAttribute);
		case "DelegateNameAttribute":
			return typeof (DelegateNameAttribute);
		case "ObjCRuntime.DesignatedInitializerAttribute":
#if !XAMCORE_5_0
		case "DesignatedInitializerAttribute":
#endif
			return typeof (DesignatedInitializerAttribute);
		case "DisableDefaultCtorAttribute":
			return typeof (DisableDefaultCtorAttribute);
		case "DisposeAttribute":
			return typeof (DisposeAttribute);
		case "ErrorDomainAttribute":
			return typeof (ErrorDomainAttribute);
		case "EventArgsAttribute":
			return typeof (EventArgsAttribute);
		case "EventNameAttribute":
			return typeof (EventNameAttribute);
		case "ForcedTypeAttribute":
			return typeof (ForcedTypeAttribute);
		case "Foundation.AdviceAttribute":
			return typeof (Foundation.AdviceAttribute);
		case "Foundation.ExportAttribute":
			return typeof (Foundation.ExportAttribute);
		case "Foundation.FieldAttribute":
			return typeof (Foundation.FieldAttribute);
		case "Foundation.ModelAttribute":
			return typeof (Foundation.ModelAttribute);
		case "Foundation.NotImplementedAttribute":
			return typeof (Foundation.NotImplementedAttribute);
		case "Foundation.PreserveAttribute":
			return typeof (Foundation.PreserveAttribute);
		case "Foundation.ProtocolAttribute":
			return typeof (Foundation.ProtocolAttribute);
		case "Foundation.RegisterAttribute":
			return typeof (Foundation.RegisterAttribute);
		case "Foundation.RequiredMemberAttribute":
			return typeof (Foundation.RequiredMemberAttribute);
		case "Foundation.OptionalMemberAttribute":
			return typeof (Foundation.OptionalMemberAttribute);
		case "IgnoredInDelegateAttribute":
			return typeof (IgnoredInDelegateAttribute);
		case "InternalAttribute":
			return typeof (InternalAttribute);
		case "ManualAttribute":
			return typeof (ManualAttribute);
		case "MarshalDirectiveAttribute":
			return typeof (MarshalDirectiveAttribute);
		case "MarshalNativeExceptionsAttribute":
			return typeof (MarshalNativeExceptionsAttribute);
		case "NewAttribute":
			return typeof (NewAttribute);
		case "NoDefaultValueAttribute":
			return typeof (NoDefaultValueAttribute);
		case "NoMethodAttribute":
			return typeof (NoMethodAttribute);
		case "NotificationAttribute":
			return typeof (NotificationAttribute);
		case "NullAllowedAttribute":
			return typeof (NullAllowedAttribute);
		case "ObjCRuntime.ArgumentSemantic":
			return typeof (ObjCRuntime.ArgumentSemantic);
		case "ObjCRuntime.BindAsAttribute":
			return typeof (ObjCRuntime.BindAsAttribute);
		case "ObjCRuntime.BindingImplAttribute":
			return typeof (ObjCRuntime.BindingImplAttribute);
		case "ObjCRuntime.BindingImplOptions":
			return typeof (ObjCRuntime.BindingImplOptions);
		case "DeprecatedAttribute":
			return typeof (DeprecatedAttribute);
		case "IntroducedAttribute":
			return typeof (IntroducedAttribute);
		case "ObjCRuntime.NativeAttribute":
			return typeof (ObjCRuntime.NativeAttribute);
		case "ObjCRuntime.NativeNameAttribute":
			return typeof (ObjCRuntime.NativeNameAttribute);
		case "ObsoletedAttribute":
			return typeof (ObsoletedAttribute);
		case "PlatformName":
			return typeof (PlatformName);
		case "ObjCRuntime.RequiresSuperAttribute":
			return typeof (ObjCRuntime.RequiresSuperAttribute);
		case "ObjCRuntime.ObjectiveCFrameworkAttribute":
			return typeof (ObjCRuntime.ObjectiveCFrameworkAttribute);
		case "ObjCRuntime.SupportedSimulatorAttribute":
			return typeof (ObjCRuntime.SupportedSimulatorAttribute);
		case "ObjCRuntime.UnsupportedSimulatorAttribute":
			return typeof (ObjCRuntime.UnsupportedSimulatorAttribute);
		case "UnavailableAttribute":
			return typeof (UnavailableAttribute);
		case "OptionalImplementationAttribute":
			return typeof (OptionalImplementationAttribute);
		case "OverrideAttribute":
			return typeof (OverrideAttribute);
		case "PostGetAttribute":
			return typeof (PostGetAttribute);
		case "PrologueSnippetAttribute":
			return typeof (PrologueSnippetAttribute);
		case "PostSnippetAttribute":
			return typeof (PostSnippetAttribute);
		case "PreSnippetAttribute":
			return typeof (PreSnippetAttribute);
		case "PrivateDefaultCtorAttribute":
			return typeof (PrivateDefaultCtorAttribute);
		case "ProtectedAttribute":
			return typeof (ProtectedAttribute);
		case "SealedAttribute":
			return typeof (SealedAttribute);
		case "StaticAttribute":
			return typeof (StaticAttribute);
		case "StrongDictionaryAttribute":
			return typeof (StrongDictionaryAttribute);
		case "System.Boolean":
			return typeof (System.Boolean);
		case "System.ComponentModel.EditorBrowsableAttribute":
			return typeof (System.ComponentModel.EditorBrowsableAttribute);
		case "System.ComponentModel.EditorBrowsableState":
			return typeof (System.ComponentModel.EditorBrowsableState);
		case "System.Diagnostics.DebuggerBrowsableAttribute":
			return typeof (System.Diagnostics.DebuggerBrowsableAttribute);
		case "System.Diagnostics.DebuggerBrowsableState":
			return typeof (System.Diagnostics.DebuggerBrowsableState);
		case "System.Int32":
			return typeof (System.Int32);
		case "System.Object":
			return typeof (System.Object);
		case "System.ObsoleteAttribute":
			return typeof (System.ObsoleteAttribute);
		case "System.Runtime.InteropServices.FieldOffsetAttribute":
			return typeof (System.Runtime.InteropServices.FieldOffsetAttribute);
		case "System.Runtime.InteropServices.MarshalAsAttribute":
			return typeof (System.Runtime.InteropServices.MarshalAsAttribute);
		case "System.Runtime.InteropServices.UnmanagedType":
			return typeof (System.Runtime.InteropServices.UnmanagedType);
		case "System.String":
			return typeof (System.String);
		case "ThreadSafeAttribute":
			return typeof (ThreadSafeAttribute);
		case "TransientAttribute":
			return typeof (TransientAttribute);
		case "Visibility":
			return typeof (Visibility);
		case "WrapAttribute":
			return typeof (WrapAttribute);
		case "System.Diagnostics.CodeAnalysis.ExperimentalAttribute":
			return typeof (System.Diagnostics.CodeAnalysis.ExperimentalAttribute);
		case "System.Runtime.Versioning.SupportedOSPlatformAttribute":
			return typeof (System.Runtime.Versioning.SupportedOSPlatformAttribute);
		case "System.Runtime.Versioning.UnsupportedOSPlatformAttribute":
			return typeof (System.Runtime.Versioning.UnsupportedOSPlatformAttribute);
		case "System.Runtime.Versioning.ObsoletedOSPlatformAttribute":
			return typeof (System.Runtime.Versioning.ObsoletedOSPlatformAttribute);
		case "BackingFieldTypeAttribute":
			return typeof (BackingFieldTypeAttribute);
		}

		switch (fullname) {
		case "ObjCRuntime.iOSAttribute":
		case "ObjCRuntime.LionAttribute":
		case "ObjCRuntime.AvailabilityAttribute":
		case "ObjCRuntime.MacAttribute":
		case "ObjCRuntime.SinceAttribute":
		case "ObjCRuntime.MountainLionAttribute":
		case "ObjCRuntime.MavericksAttribute":
			throw ErrorHelper.CreateError (1061, fullname, Generator.FormatProvider (provider));
		}

		return null;
	}

	// This method gets the System.Type for a IKVM.Reflection.Type to a System.Type.
	System.Type ConvertTypeFromMeta (Type type, ICustomAttributeProvider? provider)
	{
		var rv = LookupReflectionType (type.FullName, provider);
		if (rv is null)
			throw ErrorHelper.CreateError (1055, type.AssemblyQualifiedName);
		return rv;
	}

	// This method gets the IKVM.Reflection.Type for a System.Type.
	Type ConvertTypeToMeta (System.Type type)
	{
		if (!typeLookup.TryGetValue (type, out var rv)) {
			// Brute force: look everywhere.
			// Due to how types move around between assemblies in .NET 5 it gets complicated
			// to figure out which assembly each type comes from, so just look in every assembly.
			// Report a warning if we find the same type in multiple assemblies though.
			var assemblies = TypeCache.Universe.GetAssemblies ();
			foreach (var asm in assemblies) {
				var typeName = type.Name;
				if (type.Namespace is not null)
					typeName = type.Namespace + "." + typeName;
				var lookup = asm.GetType (typeName);
				if (lookup is null)
					continue;
				if (lookup.Assembly != asm) {
					// Apparently looking for type X in assembly A can return type X from assembly B... ignore those.
					continue;
				}
				// we will just throw if we do find a type multiple times but if it was not injected by the compiler.
				if (rv is not null && !ignoredAttributes.Contains (rv.FullName)) {
					ErrorHelper.Warning (1119, /*"Internal error: found the same type ({0}) in multiple assemblies ({1} and {2}). Please file a bug report (https://github.com/dotnet/macios/issues/new) with a test case.", */type.FullName, rv.AssemblyQualifiedName, lookup.AssemblyQualifiedName);
					break; // no need to report this more than once
				}
				rv = lookup;
			}
			if (rv is null)
				throw ErrorHelper.CreateError (1055, type.AssemblyQualifiedName);
			typeLookup [type] = rv;
		}
		return rv;
	}

	// Converts old-style platform attributes to new-style attributes.
	// Returns the number of attributes added to the output list.
	static int ConvertOldAttributes (CustomAttributeData attribute, List<System.Attribute> output)
	{
		switch (attribute.GetAttributeType ().Namespace) {
		case null: // Root namespace such as PlatformAvailabilityShadow.cs
		case "MonoTouch.ObjCRuntime":
		case "ObjCRuntime":
		case "System.Runtime.Versioning":
			break;
		default:
			return 0;
		}

		switch (attribute.GetAttributeType ().Name) {
		case "SinceAttribute":
		case "iOSAttribute":
			output.Add (AttributeConversionManager.ConvertPlatformAttribute (attribute, PlatformName.iOS));
			return 1;
		case "MacAttribute":
			output.Add (AttributeConversionManager.ConvertPlatformAttribute (attribute, PlatformName.MacOSX));
			return 1;
		case "WatchAttribute":
			output.Add (AttributeConversionManager.ConvertPlatformAttribute (attribute, PlatformName.WatchOS));
			return 1;
		case "TVAttribute":
			output.Add (AttributeConversionManager.ConvertPlatformAttribute (attribute, PlatformName.TvOS));
			return 1;
		case "MacCatalystAttribute":
			output.Add (AttributeConversionManager.ConvertPlatformAttribute (attribute, PlatformName.MacCatalyst));
			return 1;
		case "LionAttribute":
			output.Add (AttributeFactory.CreateNewAttribute<IntroducedAttribute> (PlatformName.MacOSX, 10, 7));
			return 1;
		case "MountainLionAttribute":
			output.Add (AttributeFactory.CreateNewAttribute<IntroducedAttribute> (PlatformName.MacOSX, 10, 8));
			return 1;
		case "MavericksAttribute":
			output.Add (AttributeFactory.CreateNewAttribute<IntroducedAttribute> (PlatformName.MacOSX, 10, 9));
			return 1;
		case "NoMacAttribute":
			output.Add (AttributeFactory.CreateNewAttribute<UnavailableAttribute> (PlatformName.MacOSX));
			return 1;
		case "NoiOSAttribute":
			output.Add (AttributeFactory.CreateNewAttribute<UnavailableAttribute> (PlatformName.iOS));
			return 1;
		case "NoWatchAttribute":
			output.Add (AttributeFactory.CreateNewAttribute<UnavailableAttribute> (PlatformName.WatchOS));
			return 1;
		case "NoTVAttribute":
			output.Add (AttributeFactory.CreateNewAttribute<UnavailableAttribute> (PlatformName.TvOS));
			return 1;
		case "NoMacCatalystAttribute":
			output.Add (AttributeFactory.CreateNewAttribute<UnavailableAttribute> (PlatformName.MacCatalyst));
			return 1;
		case "AvailabilityAttribute":
			return AttributeConversionManager.ConvertAvailability (attribute, output);
		case "ExperimentalAttribute":
			var earg = attribute.ConstructorArguments [0].Value as string ?? "";
			output.Add (new System.Diagnostics.CodeAnalysis.ExperimentalAttribute (earg));
			return 1;
		case "SupportedOSPlatformAttribute":
			var sarg = attribute.ConstructorArguments [0].Value as string ?? "";
			(var sp, var smajor, var sminor) = ParseOSPlatformAttribute (sarg);
			if (smajor < 0)
				output.Add (AttributeFactory.CreateNewAttribute<IntroducedAttribute> (sp));
			else
				output.Add (AttributeFactory.CreateNewAttribute<IntroducedAttribute> (sp, smajor, sminor));
			return 1;
		case "UnsupportedOSPlatformAttribute":
			var uarg = attribute.ConstructorArguments [0].Value as string ?? "";
			(var up, var umajor, var _) = ParseOSPlatformAttribute (uarg);
			// might have been available for a while...
			if (umajor < 0) {
				output.Add (AttributeFactory.CreateNewAttribute<UnavailableAttribute> (up));
				return 1;
			}
			return 0;
		case "ObsoletedOSPlatformAttribute":
			var oarg = attribute.ConstructorArguments [0].Value as string;
			(var op, var omajor, var ominor) = ParseOSPlatformAttribute (oarg);
			// might have been available for a while...
			if (omajor < 0)
				output.Add (AttributeFactory.CreateNewAttribute<ObsoletedAttribute> (op));
			else
				output.Add (AttributeFactory.CreateNewAttribute<ObsoletedAttribute> (op, omajor, ominor));
			return 1;
		default:
			return 0;
		}
	}

	static (PlatformName, int major, int minor) ParseOSPlatformAttribute (string? arg)
	{
		PlatformName name;
		int len;
		switch (arg) {
		case string s when s.StartsWith ("ios", StringComparison.Ordinal):
			name = PlatformName.iOS;
			len = "ios".Length;
			break;
		case string s when s.StartsWith ("tvos", StringComparison.Ordinal):
			name = PlatformName.TvOS;
			len = "tvos".Length;
			break;
		case string s when s.StartsWith ("watchos", StringComparison.Ordinal):
			name = PlatformName.WatchOS;
			len = "watchos".Length;
			break;
		case string s when s.StartsWith ("macos", StringComparison.Ordinal):
			name = PlatformName.MacOSX;
			len = "macos".Length;
			break;
		case string s when s.StartsWith ("maccatalyst", StringComparison.Ordinal):
			name = PlatformName.MacCatalyst;
			len = "maccatalyst".Length;
			break;
		default:
			throw new BindingException (1047, arg);
		}

		int major = -1;
		int minor = -1;
		if (arg.Length > len) {
			// Parse "major.minor" without allocating a substring or Version object
			int dotIdx = arg.IndexOf ('.', len);
			if (dotIdx < 0) {
				if (!int.TryParse (arg.AsSpan (len), out major))
					throw new BindingException (1047, arg);
				minor = 0;
			} else {
				if (!int.TryParse (arg.AsSpan (len, dotIdx - len), out major))
					throw new BindingException (1047, arg);
				// Find end of minor (could be "major.minor.patch")
				int nextDot = arg.IndexOf ('.', dotIdx + 1);
				int minorEnd = nextDot >= 0 ? nextDot : arg.Length;
				if (!int.TryParse (arg.AsSpan (dotIdx + 1, minorEnd - dotIdx - 1), out minor))
					throw new BindingException (1047, arg);
			}
		}
		return (name, major, minor);
	}

	readonly List<System.Attribute> convertedAttributeBuffer = new ();

	void CreateAttributeInstance<T> (CustomAttributeData attribute, ICustomAttributeProvider? provider, ref List<T>? output) where T : System.Attribute
	{
		int startCount = convertedAttributeBuffer.Count;
		int converted = ConvertOldAttributes (attribute, convertedAttributeBuffer);
		if (converted > 0) {
			for (int i = startCount; i < convertedAttributeBuffer.Count; i++) {
				if (convertedAttributeBuffer [i] is T typed) {
					output ??= new List<T> ();
					output.Add (typed);
				}
			}
			convertedAttributeBuffer.RemoveRange (startCount, converted);
			return;
		}

		var expectedType = ConvertTypeToMeta (typeof (T));
		var attributeType = ConvertTypeToMeta (attribute.GetAttributeType ());
		// == when comparing types uses reference equality, which is what we want here.
		if (attributeType != expectedType && !attributeType.IsSubclassOf (expectedType))
			return;

		System.Type attribType = ConvertTypeFromMeta (attributeType, provider);

		var constructorArguments = new object? [attribute.ConstructorArguments.Count];

		for (int i = 0; i < constructorArguments.Length; i++) {
			var value = attribute.ConstructorArguments [i].Value;
			switch (attribute.ConstructorArguments [i].ArgumentType.FullName) {
			case "System.Type":
				if (value is not null) {
					if (attribType.Assembly == typeof (TypeCache).Assembly) {
						constructorArguments [i] = value;
					} else {
						constructorArguments [i] = Type.GetType (((Type) value).FullName!);
					}
					if (constructorArguments [i] is null)
						throw ErrorHelper.CreateError (1056, attribType.FullName, i + 1);
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
				if (attribType.Assembly == typeof (TypeCache).Assembly) {
					ctorTypes [i] = typeof (Type);
				} else {
					ctorTypes [i] = typeof (System.Type);
				}
				break;
			default:
				ctorTypes [i] = ConvertTypeFromMeta (paramType, provider);
				break;
			}
			if (ctorTypes [i] is null)
				throw ErrorHelper.CreateError (1057, attribType.FullName, i, paramType.FullName);
		}
		var ctor = attribType.GetConstructor (ctorTypes);
		if (ctor is null)
			throw ErrorHelper.CreateError (1058, attribType.FullName);
		var instance = ctor.Invoke (constructorArguments);

		for (int i = 0; i < attribute.NamedArguments.Count; i++) {
			var arg = attribute.NamedArguments [i];
			var value = arg.TypedValue.Value;
			if (arg.TypedValue.ArgumentType == TypeCache.System_String_Array) {
				var typed_values = (IList<CustomAttributeTypedArgument>) arg.TypedValue.Value!;
				var arr = new string? [typed_values.Count];
				for (int a = 0; a < arr.Length; a++)
					arr [a] = (string?) typed_values [a].Value;
				value = arr;
			} else if (arg.TypedValue.ArgumentType.FullName == "System.Type[]") {
				var typed_values = (IList<CustomAttributeTypedArgument>) arg.TypedValue.Value!;
				var arr = new Type? [typed_values.Count];
				for (int a = 0; a < arr.Length; a++)
					arr [a] = (Type?) typed_values [a].Value;
				value = arr;
			} else if (arg.TypedValue.ArgumentType.IsArray) {
				throw ErrorHelper.CreateError (1073, attribType.FullName, i + 1, arg.MemberName);
			}
			if (arg.IsField) {
				attribType.GetField (arg.MemberName)!.SetValue (instance, value);
			} else {
				attribType.GetProperty (arg.MemberName)!.SetValue (instance, value, Array.Empty<object> ());
			}
		}

		output ??= new List<T> ();
		output.Add ((T) instance);
	}

	T [] FilterAttributes<T> (IList<CustomAttributeData>? attributes, ICustomAttributeProvider? provider) where T : System.Attribute
	{
		if (attributes is null || attributes.Count == 0)
			return Array.Empty<T> ();

		List<T>? list = null;
		for (int i = 0; i < attributes.Count; i++) {

			// special compiler attribtues not usable from C#
			if (ignoredAttributes.Contains (attributes [i].GetAttributeType ().FullName))
				continue;

			CreateAttributeInstance<T> (attributes [i], provider, ref list);
		}

		if (list is not null && list.Count > 0)
			return list.ToArray ();

		return Array.Empty<T> ();
	}

	public virtual T [] GetCustomAttributes<T> (ICustomAttributeProvider? provider) where T : System.Attribute
	{
		if (provider is null)
			return Array.Empty<T> ();

		var key = (provider, typeof (T));
		if (attributeCache.TryGetValue (key, out var cached))
			return (T []) cached;

		var result = FilterAttributes<T> (GetAttributes (provider), provider);
		attributeCache [key] = result;
		return result;
	}

	[return: NotNullIfNotNull (nameof (provider))]
	IList<CustomAttributeData>? GetAttributes (ICustomAttributeProvider? provider)
	{
		if (provider is null)
			return null;

		if (rawAttributeCache.TryGetValue (provider, out var cached))
			return cached;

		IList<CustomAttributeData> result = provider switch {
			MemberInfo member => member.GetCustomAttributesData (),
			Assembly assembly => assembly.GetCustomAttributesData (),
			ParameterInfo pinfo => pinfo.GetCustomAttributesData (),
			Module module => module.GetCustomAttributesData (),
			_ => throw new BindingException (1051, true, provider.GetType ().FullName)
		};

		rawAttributeCache [provider] = result;
		return result;
	}

	public bool HasAttribute (ICustomAttributeProvider provider, string type_name)
	{
		var attribs = GetAttributes (provider);
		for (int i = 0; i < attribs.Count; i++)
			if (attribs [i].GetAttributeType ().Name == type_name)
				return true;
		return false;
	}

	public virtual bool HasAttribute<T> (ICustomAttributeProvider? provider) where T : Attribute
	{
		if (provider is null)
			return false;

		var key = (provider, typeof (T));
		if (hasAttributeCache.TryGetValue (key, out var cached))
			return cached;

		var attributeType = ConvertTypeToMeta (typeof (T));
		var attribs = GetAttributes (provider);
		if (attribs is null || attribs.Count == 0) {
			hasAttributeCache [key] = false;
			return false;
		}

		for (int i = 0; i < attribs.Count; i++) {
			var attrib = attribs [i];
			// == when comparing types uses reference equality, which is what we want here.
			var currentType = ConvertTypeToMeta (attrib.GetAttributeType ());
			if (currentType == attributeType) {
				hasAttributeCache [key] = true;
				return true;
			}
			if (currentType.IsSubclassOf (attributeType)) {
				hasAttributeCache [key] = true;
				return true;
			}
		}

		hasAttributeCache [key] = false;
		return false;
	}

	public virtual T? GetCustomAttribute<T> (ICustomAttributeProvider? provider) where T : System.Attribute
	{
		if (provider is null)
			return null;
		var rv = GetCustomAttributes<T> (provider);
		if (rv is null || rv.Length == 0)
			return null;

		if (rv.Length == 1)
			return rv [0];

		throw GetTooManyAttributeFoundException<T> (provider, rv.Length);
	}

	public T GetOneCustomAttribute<T> (ICustomAttributeProvider provider) where T : System.Attribute
	{
		if (provider is null)
			throw new ArgumentNullException (nameof (provider));
		var rv = GetCustomAttributes<T> (provider);
		if (rv is null || rv.Length == 0)
			throw ErrorHelper.CreateError (9999, "/* TODO: proper error */");
		if (rv.Length == 1)
			return rv [0];
		throw GetTooManyAttributeFoundException<T> (provider, rv.Length);
	}

	Exception GetTooManyAttributeFoundException<T> (ICustomAttributeProvider? provider, int count)
	{
		int code;
		object? [] args;
		// each type of provider has its own error. This is because each exception has its own message that 
		// must be correctly translated.
		switch (provider) {
		case ParameterInfo pi:
			code = 1083;
			args = new object? [] {
				count, typeof (T).FullName, $"{pi.Member.DeclaringType?.FullName}.{pi.Member.Name}", pi.Position, pi.Name
			};
			break;
		case Type type:
			code = 1084;
			args = new object? [] { count, typeof (T).FullName, type.FullName };
			break;
		case MemberInfo mi:
			code = 1059;
			args = new object? [] { count, typeof (T).FullName, $"{mi.DeclaringType?.FullName}.{mi.Name}" };
			break;
		case Assembly assm:
			code = 1085;
			args = new object? [] { count, typeof (T).FullName, $"{assm.FullName}" };
			break;
		case Module mod:
			code = 1086;
			args = new object? [] { count, typeof (T).FullName, $"{mod.FullyQualifiedName}" };
			break;
		default:
			code = 1059;
			args = new object? [] { count, typeof (T).FullName, provider?.ToString () };
			break;
		}
		return ErrorHelper.CreateError (code, args);
	}

	public virtual T? GetCustomAttribute<T> (ICustomAttributeProvider? provider, Attribute []? attributes) where T : System.Attribute
	{
		if (attributes is null)
			return GetCustomAttribute<T> (provider);

		T? attrib = null;
		foreach (var a in attributes) {
			if (a is T t) {
				if (attrib is not null)
					throw GetTooManyAttributeFoundException<T> (provider, attributes.Length);
				attrib = t;
			}
		}

		return attrib;
	}

	public virtual bool HasNativeAttribute (ICustomAttributeProvider? provider)
	{
		if (provider is null)
			return false;

		return HasAttribute (provider, "NativeIntegerAttribute");
	}

	public virtual bool HasAttribute<T> (ICustomAttributeProvider? i, Attribute []? attributes) where T : Attribute
	{
		if (attributes is null)
			return HasAttribute<T> (i);

		foreach (var a in attributes)
			if (a.GetType () == typeof (T))
				return true;
		return false;
	}

	public bool IsStatic (ICustomAttributeProvider? provider)
	{
		if (HasAttribute<StaticAttribute> (provider))
			return true;
		var method = provider as MethodInfo;
		if (method is not null) {
			var property = Generator.GetProperyFromGetSetMethod (method);
			if (property is not null && HasAttribute<StaticAttribute> (property))
				return true;
		}
		return false;
	}

	readonly Dictionary<ICustomAttributeProvider, bool> isNullableCache = new ();

	public bool IsNullable (ICustomAttributeProvider? provider)
	{
		if (provider is null)
			return false;

		if (isNullableCache.TryGetValue (provider, out var cached))
			return cached;

		var result = IsNullableCore (provider);
		isNullableCache [provider] = result;
		return result;
	}

	bool IsNullableCore (ICustomAttributeProvider provider)
	{
		var attributes = GetAttributes (provider);
		if (attributes is null)
			return false;

		// first check if any of the attributes are [NullAllowed]
		foreach (var attrib in attributes) {
			var attribType = attrib.GetAttributeType ();
			if (attribType.Name == "NullAllowedAttribute")
				return true;
		}

		// then check for [Nullable]
		foreach (var attrib in attributes) {
			var attribType = attrib.GetAttributeType ();
			if (attribType.Name == "NullableAttribute") {
				// https://codeblog.jonskeet.uk/2019/02/10/nullableattribute-and-c-8/
				if (attrib.ConstructorArguments.Count == 1) {
					var argType = attrib.ConstructorArguments [0].ArgumentType;
					if (argType.Namespace == "System" && argType.Name == "Byte")
						return ((byte) attrib.ConstructorArguments [0].Value!) == 2;
					if (argType.IsArray && argType.GetElementType ()?.Namespace == "System" && argType.GetElementType ()?.Name == "Byte") {
						var valueCollection = (ReadOnlyCollection<CustomAttributeTypedArgument>) attrib.ConstructorArguments [0].Value!;
						// Getting complex nullability right means we'll have to completely rework how we render types.
						// So don't do that for now, just look at the outermost type (the first number in the array),
						// and return nullability depending on that value.
						return ((byte) valueCollection [0].Value!) == 2;
					}
				}
			}
		}

		return false;
	}
}
