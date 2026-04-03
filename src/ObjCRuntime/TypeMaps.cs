// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ObjCRuntime;

static class TypeMaps {
	internal static IReadOnlyDictionary<string, Type>? nsobject_types;
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
	[MemberNotNull (nameof (protocol_proxy_types))]
	[MemberNotNull (nameof (protocol_wrapper_types))]
	internal static void Initialize ()
	{
		// Ideally we'd be able to run this from Runtime.Initialize, but that runs into:
		//     System.InvalidOperationException: Entry assembly is required but was not found.
		//         at System.Runtime.InteropServices.TypeMapLazyDictionary.CreateMaps(RuntimeType groupType,  newExternalTypeEntry,  newProxyTypeEntry)
		//         at System.Runtime.InteropServices.TypeMapLazyDictionary.CreateExternalTypeMap(RuntimeType groupType)
		// So we have to do this on-demand instead.
		// Potential fix: maybe we can set the entry point assembly in Runtime.Initialize?

		lock (lock_obj) {
			if (nsobject_types is null)
				nsobject_types = TypeMapping.GetOrCreateExternalTypeMapping<NSObject> ();

			if (skipped_proxy_types is null)
				skipped_proxy_types = TypeMapping.GetOrCreateProxyTypeMapping<SkippedObjectiveCTypeUniverse> ();

			if (nsobject_proxy_types is null)
				nsobject_proxy_types = TypeMapping.GetOrCreateProxyTypeMapping<NSObject> ();

			if (protocol_proxy_types is null)
				protocol_proxy_types = TypeMapping.GetOrCreateProxyTypeMapping<ProtocolProxyAttribute> ();

			if (protocol_wrapper_types is null)
				protocol_wrapper_types = TypeMapping.GetOrCreateProxyTypeMapping<ProtocolAttribute> ();
		}
	}
}

