using System;

using Mono.Cecil;

namespace Cecil.Tests {
	public static class CustomAttributeExtensions {
		public static string AsOSPlatformAttributeString (this CustomAttribute ca)
		{
			if (ca.AttributeType.Namespace != "System.Runtime.Versioning")
				throw new ArgumentOutOfRangeException ($"Not an OSPlatformAttribute: {ca.AttributeType.FullName}");

			switch (ca.AttributeType.Name) {
			case "UnsupportedOSPlatformAttribute":
				return $"[UnsupportedOSPlatform (\"{(string) ca.ConstructorArguments [0].Value}\")]";
			case "SupportedOSPlatformAttribute":
				return $"[SupportedOSPlatform (\"{(string) ca.ConstructorArguments [0].Value}\")]";
			case "ObsoletedOSPlatformAttribute":
				return $"[ObsoletedOSPlatform (\"{(string) ca.ConstructorArguments [0].Value}\")]";
			default:
				throw new NotImplementedException (ca.AttributeType.FullName);
			}
		}
	}
}
