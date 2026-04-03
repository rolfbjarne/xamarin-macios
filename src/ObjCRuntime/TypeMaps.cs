using System.Collections.Generic;

namespace ObjCRuntime;

static class TypeMaps {
#pragma warning disable CS8618 // "Non-nullable field must contain a non-null value when exiting constructor." - we ensure these fields are non-null in other ways
	internal static IReadOnlyDictionary<string, Type> NSObjectTypes;

	internal static IReadOnlyDictionary<Type, Type> SkippedProxyTypes;
	internal static IReadOnlyDictionary<Type, Type> NSObjectProxyTypes;
	internal static IReadOnlyDictionary<Type, Type> ProtocolProxyTypes;
	internal static IReadOnlyDictionary<Type, Type> ProtocolWrapperTypes;
#pragma warning restore CS8618

	internal static void Initialize ()
	{
		NSObjectTypes = TypeMapping.GetOrCreateExternalTypeMapping<NSObject> ();

		SkippedProxyTypes = TypeMapping.GetOrCreateProxyTypeMapping<SkippedObjectiveCTypeUniverse> ();
		NSObjectProxyTypes = TypeMapping.GetOrCreateProxyTypeMapping<NSObject> ();
		ProtocolProxyTypes = TypeMapping.GetOrCreateProxyTypeMapping<ProtocolProxyAttribute> ();
		ProtocolWrapperTypes = TypeMapping.GetOrCreateProxyTypeMapping<ProtocolAttribute> ();
	}
}
