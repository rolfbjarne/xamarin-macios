using System;
using System.Text;

using Mono.Cecil;

namespace Xamarin.Utils {
	public static partial class CecilExtensions {

		// note: direct check, no inheritance
		public static bool Is (this TypeReference type, string @namespace, string name)
		{
			return (type is not null) && (type.Name == name) && (type.Namespace == @namespace);
		}


		public static string AsOSPlatformAttributeString (this CustomAttribute ca)
		{
			if (ca.AttributeType.Namespace != "System.Runtime.Versioning")
				throw new ArgumentOutOfRangeException ($"Not an OSPlatformAttribute: {ca.AttributeType.FullName}");

			switch (ca.AttributeType.Name) {
			case "UnsupportedOSPlatformAttribute":
				return $"[UnsupportedOSPlatform (\"{(string) ca.ConstructorArguments [0].Value}\")]";
			case "SupportedOSPlatformAttribute":
				return $"[SupportedOSPlatform (\"{(string) ca.ConstructorArguments [0].Value}\")]";
			default:
				throw new NotImplementedException (ca.AttributeType.FullName);
			}
		}

		public static string AsString (this IMemberDefinition member)
		{
			if (member is MethodDefinition md) {
				var rv = new StringBuilder ();
				rv.Append (md.Name);
				rv.Append ('(');
				if (md.HasParameters) {
					for (var i = 0; i < md.Parameters.Count; i++) {
						if (i > 0)
							rv.Append (", ");
						var p = md.Parameters [0];
						if (p.IsOut)
							rv.Append ("out ");
						rv.Append (p.ParameterType.FullName);
					}
				}
				rv.Append (')');
				return rv.ToString ();
			}

			if (member is FieldDefinition fd)
				return fd.Name;

			if (member is PropertyDefinition pd)
				return pd.Name;

			return member.ToString ();
		}

		public static string AsFullName (this IMemberDefinition member)
		{
			if (member is MethodDefinition md) {
				var rv = new StringBuilder ();
				rv.Append (AsFullName (md.DeclaringType));
				rv.Append ('.');
				rv.Append (md.Name);
				rv.Append ('(');
				if (md.HasParameters) {
					for (var i = 0; i < md.Parameters.Count; i++) {
						if (i > 0)
							rv.Append (", ");
						var p = md.Parameters [0];
						if (p.IsOut)
							rv.Append ("out ");
						rv.Append (p.ParameterType.FullName);
					}
				}
				rv.Append (')');
				return rv.ToString ();
			}

			if (member is FieldDefinition fd)
				return fd.FullName;

			if (member is PropertyDefinition pd)
				return pd.FullName;

			return member.FullName;
		}

		public static string GetOSPlatformAttributePlatformName (this CustomAttribute ca)
		{
			return (string) ca.ConstructorArguments [0].Value;
		}
	}
}

