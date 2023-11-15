//
// The rule reports
//
// !missing-protocol!
//		if headers defines a protocol that we have not bound as [Protocol]
//
// !incorrect-protocol-member!
//		if we have @required members without [Abstract] or @optional members with [Abstract]
//
// !missing-protocol-member!
//		if we have protocol members (found in header files) but not in the interface
//
// !extra-protocol-member!
//		if we have protocol members in the interface that are NOT found in header files
//
// Limitations
//
// * .NET interfaces does not allow constructors, so we cannot check for `init*` members
//
// * .NET interfaces cannot have static members, so we cannot check for [Static] members
//
// Notes: Both limitations could be _mostly_ lifted by another tests that would check types conformance to a protocol
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Mono.Cecil;

using Clang.Ast;

namespace Extrospection {

	public class ObjCProtocolCheck : BaseVisitor {

		Dictionary<string, List<TypeDefinition>> protocol_map = new Dictionary<string, List<TypeDefinition>> ();

		public override void VisitManagedType (TypeDefinition type)
		{
			if (!type.HasCustomAttributes)
				return;

			if (!type.IsInterface) {
				// Only interfaces map to protocols, but unfortunately we add [Protocol] to generated model classes too, so we need to skip those.
				return;
			}

			string pname = null;
			bool informal = false;

			foreach (var ca in type.CustomAttributes) {
				switch (ca.Constructor.DeclaringType.Name) {
				case "ProtocolAttribute":
					if (!ca.HasProperties)
						continue;
					foreach (var p in ca.Properties) {
						switch (p.Name) {
						case "Name":
							pname = p.Argument.Value as string;
							break;
						case "IsInformal":
							informal = (bool) p.Argument.Value;
							break;
						}
					}
					break;
				}
			}
			if (!informal && !String.IsNullOrEmpty (pname)) {
				if (!protocol_map.TryGetValue (pname, out var types))
					protocol_map [pname] = types = new List<TypeDefinition> ();
				types.Add (type);
			}
		}

		public override void VisitObjCProtocolDecl (ObjCProtocolDecl decl, VisitKind visitKind)
		{
			if (visitKind != VisitKind.Enter)
				return;
			if (!decl.IsDefinition)
				return;

			// check availability macros to see if the API is available on the OS and not deprecated
			if (!decl.IsAvailable ())
				return;

			var framework = Helpers.GetFramework (decl);
			if (framework is null)
				return;

			var name = decl.Name;
			if (!protocol_map.TryGetValue (name, out var types)) {
				if (!decl.IsDeprecated ())
					Log.On (framework).Add ($"!missing-protocol! {name} not bound");
				// other checks can't be done without an actual protocol to inspect
				return;
			}

			// build type selector-required map
			var map = new Dictionary<string, Requiredness> ();
			foreach (var td in types) {
				foreach (var ca in td.CustomAttributes) {
					string export = null;
					string g_export = null;
					string s_export = null;
					bool is_required = false;
					bool is_property = false;
					bool is_static = false;
					switch (ca.Constructor.DeclaringType.Name) {
					case "ProtocolMemberAttribute":
						foreach (var p in ca.Properties) {
							switch (p.Name) {
							case "Selector":
								export = p.Argument.Value as string;
								break;
							case "GetterSelector":
								g_export = p.Argument.Value as string;
								break;
							case "SetterSelector":
								s_export = p.Argument.Value as string;
								break;
							case "IsRequired":
								is_required = (bool) p.Argument.Value;
								break;
							case "IsProperty":
								is_property = (bool) p.Argument.Value;
								break;
							case "IsStatic":
								is_static = (bool) p.Argument.Value;
								break;
							}
						}
						break;
					}
					if (is_property) {
						if (g_export is not null) {
							if (is_static)
								g_export = "+" + g_export;
							AddRequiredness (map, g_export, is_required);
						}
						if (s_export is not null) {
							if (is_static)
								s_export = "+" + s_export;
							AddRequiredness (map, s_export, is_required);
						}
					} else if (export is not null) {
						if (is_static)
							export = "+" + export;
						AddRequiredness (map, export, is_required);
					}
				}
			}

			var deprecatedProtocol = (decl.DeclContext as Decl).IsDeprecated ();

			// don't report anything for deprecated protocols
			// (we still report some errors for deprecated members of non-deprecated protocols - because abstract/non-abstract can
			// change the managed API and we want to get things right, even if for deprecated members).
			if (!deprecatedProtocol) {
				var remaining = new Dictionary<string, Requiredness> (map);

				// check that required members match the [Abstract] members
				foreach (ObjCMethodDecl method in decl.Methods) {
					// some members might not be part of the current platform
					if (!method.IsAvailable ())
						continue;

					var selector = GetSelector (method);
					if (selector is null)
						continue;

					// a .NET interface cannot have constructors - so we cannot enforce that on the interface
					if (IsInit (selector))
						continue;

					if (method.IsClassMethod)
						selector = "+" + selector;

					if (map.TryGetValue (selector, out var requiredness)) {
						var is_abstract = requiredness.HasFlag (Requiredness.Required);
						var is_optional = requiredness.HasFlag (Requiredness.Optional);
						bool required = method.ImplementationControl == ObjCImplementationControl.Required;
						if (required) {
							if (!is_abstract)
								Log.On (framework).Add ($"!incorrect-protocol-member! {GetName (decl, method)} is REQUIRED and should be abstract");
						} else {
							if (!is_optional)
								Log.On (framework).Add ($"!incorrect-protocol-member! {GetName (decl, method)} is OPTIONAL and should NOT be abstract");
						}
						remaining.Remove (selector);
					} else if (!method.IsClassMethod) {
						// a .NET interface cannot have static methods - so we can only report missing instance methods
						if (!decl.IsDeprecated ())
							Log.On (framework).Add ($"!missing-protocol-member! {GetName (decl, method)} not found");
						remaining.Remove (selector);
					}
				}

				foreach (var selector in remaining.Keys)
					Log.On (framework).Add ($"!extra-protocol-member! unexpected selector {decl.Name}::{selector} found");
				remaining.Clear ();
			}
			map.Clear ();

			protocol_map.Remove (name);
		}

		static void AddRequiredness (Dictionary<string, Requiredness> map, string key, bool required)
		{
			AddRequiredness (map, key, required ? Requiredness.Required : Requiredness.Optional);
		}

		static void AddRequiredness (Dictionary<string, Requiredness> map, string key, Requiredness required)
		{
			if (map.TryGetValue (key, out var current)) {
				map [key] = current | required;
			} else {
				map [key] = required;
			}
		}

		// We can have multiple interfaces binding the same protocol
		// (in particular to work around binding mistakes, where we can't
		// make an existing interface work, we might add another one for
		// the same protocol), and a protocol member might be defined in
		// more than one interface, so we need to keep track of the all
		// of them, which is why we have this weird enum that lists "Both"
		// for required/optional: it's the sum of all the managed members
		// that bind a particular protocol member.
		[Flags]
		enum Requiredness {
			Required = 1,
			Optional = 2,
			Both = 3,
		}

		static string GetSelector (ObjCMethodDecl method)
		{
			var result = method.Selector.ToString ();
			if (result is not null)
				return result;
			if (method.IsPropertyAccessor || (method.DeclContext is ObjCProtocolDecl))
				return method.Name;
			return null;
		}

		static string GetName (ObjCProtocolDecl decl, ObjCMethodDecl method)
		{
			var sb = new StringBuilder ();
			if (method.IsClassMethod)
				sb.Append ('+');
			sb.Append (decl.Name);
			sb.Append ("::");
			sb.Append (GetSelector (method));
			return sb.ToString ();
		}

		bool IsInit (string selector)
		{
			return selector.StartsWith ("init", StringComparison.Ordinal) && Char.IsUpper (selector [4]);
		}

		public override void End ()
		{
			// at this stage anything else we have is not something we could find in Apple's headers
			foreach (var kvp in protocol_map) {
				var extra = kvp.Key;
				var fx = kvp.Value [0].Namespace;
				Log.On (fx).Add ($"!unknown-protocol! {extra} bound");
			}
		}
	}
}
