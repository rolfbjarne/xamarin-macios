// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ObjCRuntime;

static class TypeMaps {
#if NET11_0_OR_GREATER
#pragma warning disable 8618 // "Non-nullable field '...' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.": we make sure through other means that these will never be null
	internal static IReadOnlyDictionary<string, Type> NSObjectTypes;
	internal static IReadOnlyDictionary<Type, Type> SkippedProxyTypes;
	internal static IReadOnlyDictionary<Type, Type> NSObjectProxyTypes;
	internal static IReadOnlyDictionary<Type, Type> INativeObjectProxyTypes;
	internal static IReadOnlyDictionary<Type, Type> ProtocolProxyTypes;
	internal static IReadOnlyDictionary<Type, Type> ProtocolWrapperTypes;
#pragma warning restore 8618

	internal static void Initialize ()
	{
		NSObjectTypes = TypeMapping.GetOrCreateExternalTypeMapping<NSObject> ();
		SkippedProxyTypes = TypeMapping.GetOrCreateProxyTypeMapping<SkippedObjectiveCTypeUniverse> ();
		NSObjectProxyTypes = TypeMapping.GetOrCreateProxyTypeMapping<NSObject> ();
		INativeObjectProxyTypes = TypeMapping.GetOrCreateProxyTypeMapping<INativeObject> ();
		ProtocolProxyTypes = TypeMapping.GetOrCreateProxyTypeMapping<ProtocolProxyAttribute> ();
		ProtocolWrapperTypes = TypeMapping.GetOrCreateProxyTypeMapping<ProtocolAttribute> ();
	}
#else
	static IReadOnlyDictionary<string, Type>? nsobject_types;
	internal static IReadOnlyDictionary<string, Type> NSObjectTypes {
		get {
			if (nsobject_types is null)
				Initialize ();
			return nsobject_types;
		}
	}

	static IReadOnlyDictionary<Type, Type>? skipped_proxy_types;
	internal static IReadOnlyDictionary<Type, Type> SkippedProxyTypes {
		get {
			if (skipped_proxy_types is null)
				Initialize ();
			return skipped_proxy_types;
		}
	}

	static IReadOnlyDictionary<Type, Type>? nsobject_proxy_types;
	internal static IReadOnlyDictionary<Type, Type> NSObjectProxyTypes {
		get {
			if (nsobject_proxy_types is null)
				Initialize ();
			return nsobject_proxy_types;
		}
	}

	static IReadOnlyDictionary<Type, Type>? inativeobject_proxy_types;
	internal static IReadOnlyDictionary<Type, Type> INativeObjectProxyTypes {
		get {
			if (inativeobject_proxy_types is null)
				Initialize ();
			return inativeobject_proxy_types;
		}
	}

	static IReadOnlyDictionary<Type, Type>? protocol_proxy_types;
	internal static IReadOnlyDictionary<Type, Type> ProtocolProxyTypes {
		get {
			if (protocol_proxy_types is null)
				Initialize ();
			return protocol_proxy_types;
		}
	}

	static IReadOnlyDictionary<Type, Type>? protocol_wrapper_types;
	internal static IReadOnlyDictionary<Type, Type> ProtocolWrapperTypes {
		get {
			if (protocol_wrapper_types is null)
				Initialize ();
			return protocol_wrapper_types;
		}
	}

	static object lock_obj = new object ();

	[MemberNotNull (nameof (nsobject_types))]
	[MemberNotNull (nameof (skipped_proxy_types))]
	[MemberNotNull (nameof (nsobject_proxy_types))]
	[MemberNotNull (nameof (inativeobject_proxy_types))]
	[MemberNotNull (nameof (protocol_proxy_types))]
	[MemberNotNull (nameof (protocol_wrapper_types))]
	internal static void Initialize ()
	{
		// In .NET 10 we can only create the type maps from the entry assembly, which can only be done after calling the
		// main assembly's Main method - so we need to create the type maps on demand, instead of from Runtime.Initialize.
		// For reference, this is what happens:
		//     System.InvalidOperationException: Entry assembly is required but was not found.
		//         at System.Runtime.InteropServices.TypeMapLazyDictionary.CreateMaps(RuntimeType groupType,  newExternalTypeEntry,  newProxyTypeEntry)
		//         at System.Runtime.InteropServices.TypeMapLazyDictionary.CreateExternalTypeMap(RuntimeType groupType)
		lock (lock_obj) {
			if (nsobject_types is null)
				nsobject_types = TypeMapping.GetOrCreateExternalTypeMapping<NSObject> ();

			if (skipped_proxy_types is null)
				skipped_proxy_types = TypeMapping.GetOrCreateProxyTypeMapping<SkippedObjectiveCTypeUniverse> ();

			if (nsobject_proxy_types is null)
				nsobject_proxy_types = TypeMapping.GetOrCreateProxyTypeMapping<NSObject> ();

			if (inativeobject_proxy_types is null)
				inativeobject_proxy_types = TypeMapping.GetOrCreateProxyTypeMapping<INativeObject> ();

			if (protocol_proxy_types is null)
				protocol_proxy_types = TypeMapping.GetOrCreateProxyTypeMapping<ProtocolProxyAttribute> ();

			if (protocol_wrapper_types is null)
				protocol_wrapper_types = TypeMapping.GetOrCreateProxyTypeMapping<ProtocolAttribute> ();
		}
	}
#endif // NET11_0_OR_GREATER
}

