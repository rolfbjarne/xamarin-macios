//
// The rule reports
//
// !missing-release-attribute-on-return-value!
//             for methods whose objc family indicates the returned value is retained, and the method doesn't have a [return: Release] attribute.
//

using System;
using System.Collections.Generic;

using Mono.Cecil;

using Clang.Ast;

namespace Extrospection {

	public class ReleaseAttributeCheck : BaseVisitor {

		class MethodData {
			public MethodDefinition Method;
			public string Selector;
			public bool HasReleaseAttribute;
			public string Family;
			public string ObjCFamilyAttribute;
		}
		static Dictionary<string, MethodData> methods = new Dictionary<string, MethodData> ();

		// most selectors will be found in [Export] attributes
		public override void VisitManagedMethod (MethodDefinition method)
		{
			// Don't care about methods that don't have [Export] attributes
			if (!method.HasCustomAttributes)
				return;

			// We don't care about 'void' functions
			if (method.ReturnType.FullName == "System.Void")
				return;

			// Value types can't need '[return: Release]'
			if (method.ReturnType.IsValueType)
				return;

			string family = null;
			string selector = null;
			bool hasReleaseAttribute = false;

			if (method.MethodReturnType.HasCustomAttributes) {
				foreach (var ca in method.MethodReturnType.CustomAttributes) {
					switch (ca.Constructor.DeclaringType.Name) {
					case "ReleaseAttribute":
						hasReleaseAttribute = true;
						break;
					}
				}
			}

			foreach (var ca in method.CustomAttributes) {
				switch (ca.Constructor.DeclaringType.Name) {
				case "ExportAttribute":
					selector = (string) ca.ConstructorArguments [0].Value;

					// We need to compute the selector's method family
					// https://clang.llvm.org/docs/AutomaticReferenceCounting.html#method-families

					// A selector is in a certain selector family if ignoring any leading underscore the first component of the selector either consists entirely
					// of the name of the method family or it begins with that name followed by a character other than a lowercase letter
					var firstLetter = 0;
					var firstNonLowercaseLetter = selector.Length;
					for (var i = 0; i < selector.Length; i++) {
						var c = selector [i];

						if (firstLetter == i && c == '_') {
							// ... ignoring any leading underscores ...
							firstLetter++;
						}  else if (c < 'a' || c > 'z') {
							firstNonLowercaseLetter = i;
							break;
						}
					}
					family = selector.Substring (0, firstNonLowercaseLetter - firstLetter);
					break;
				}
			}

			var key = method.GetName ();
			if (key == null) {
				if (family == null)
					return;
				// No key for this method, let's just use a random value as the key. Worst case scenario is that we won't find any objc_method_family attributes for this method, and report it when we shouldn't.
				key = Guid.NewGuid ().ToString ();
			} else if (methods.ContainsKey (key)) {
				// No key for this method, let's just use a random value as the key. Worst case scenario is that we won't find any objc_method_family attributes for this method, and report it when we shouldn't.
				key = Guid.NewGuid ().ToString ();
			}
			methods.Add (key, new MethodData { Family = family, HasReleaseAttribute = hasReleaseAttribute, Method = method, Selector = selector });
		}

		// Look at the native definition for family attributes: __attribute__((objc_method_family(...))
		public override void VisitObjCMethodDecl (ObjCMethodDecl decl, VisitKind visitKind)
		{
			if (visitKind != VisitKind.Enter)
				return;

			// don't process methods (or types) that are unavailable for the current platform
			if (!decl.IsAvailable () || !(decl.DeclContext as Decl).IsAvailable ())
				return;

			var framework = Helpers.GetFramework (decl);
			if (framework == null)
				return;

			foreach (var attr in decl.Attrs) {
				switch (attr.Kind) {
				case AttrKind.ObjCMethodFamily:
					ObjCMethodFamilyAttr familyAttr = (ObjCMethodFamilyAttr)attr;
					var key = decl.GetName ();
					if (key != null && methods.TryGetValue (key, out var data))
						data.ObjCFamilyAttribute = familyAttr.Family.ToString ().ToLower ();
					break;
				default:
					break;
				}
			}
		}

		public override void End ()
		{
			foreach (var entry in methods) {
				var family = entry.Value.Family;
				var method = entry.Value.Method;
				var hasReleaseAttribute = entry.Value.HasReleaseAttribute;
				var selector = entry.Value.Selector;

				if (entry.Value.ObjCFamilyAttribute != null)
					family = entry.Value.ObjCFamilyAttribute;

				switch (family) {
				case "init": // in many cases we have custom init/constructor code, which seems to be correct, so ignore the 'init' family for now.
					break;
				case "alloc":
				case "copy":
				case "mutableCopy":
				case "new":
					if (!hasReleaseAttribute) {
						var framework = Helpers.GetFramework (method);
						Log.On (framework).Add ($"!missing-release-attribute-on-return-value! {method.FullName}'s selector's ('{selector}') Objective-C method family ('{family}') indicates that the native method returns a retained object, and as such a '[return: Release]' attribute is required.");
					}
					break;
				case "none":
				default:
					break;
				}
			}
		}
	}
}