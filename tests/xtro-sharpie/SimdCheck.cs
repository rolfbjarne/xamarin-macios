using System;
using System.Collections.Generic;
using System.Linq;

using Mono.Cecil;

using Clang.Ast;

namespace Extrospection
{

	class SimdCheck : BaseVisitor
	{
		static Dictionary<string, MethodDefinition> methods = new Dictionary<string, MethodDefinition> ();

		static MethodDefinition GetMethod (ObjCMethodDecl decl)
		{
			MethodDefinition md;
			methods.TryGetValue (decl.GetName (), out md);
			return md;
		}

		public override void VisitManagedMethod (MethodDefinition method)
		{
			
			var type = method.DeclaringType;
			if (!type.IsNested && type.IsNotPublic)
				return;

			if (type.IsNested && (type.IsNestedPrivate || type.IsNestedAssembly || type.IsNestedFamilyAndAssembly))
				return;

			if (method.IsPrivate || method.IsAssembly || method.IsFamilyAndAssembly)
				return; // Don't care about non-visible types

			if (type.Namespace == "Simd" || type.Namespace == "OpenTK")
				return;

			if (!MightHaveSimdType (method))
				return;
			
			//Console.WriteLine ($"{method}");

			var key = method.GetName ();
			if (key == null) {
				Console.WriteLine ("-- simd skipping -- {0}", method);
				return;
			}

			methods.Add (key, method);
		}

		bool MightHaveSimdType (MethodDefinition method)
		{
			if (MightBeSimdType (method.ReturnType))
				return true;

			if (method.HasParameters) {
				foreach (var param in method.Parameters)
					if (MightBeSimdType (param.ParameterType))
						return true;
			}

			return false;
		}

		bool MightBeSimdType (TypeReference td)
		{
			return td.Name == "Matrix4" || td.Name == "Matrix3";
		}

		bool ContainsSimdTypes (ObjCMethodDecl decl)
		{
			if (IsSimdType (decl.ReturnQualType))
				return true;

			foreach (var param in decl.Parameters) {
				if (IsSimdType (param.QualType))
					return true;
			}

			return false;
		}


		Dictionary<string, bool> simd_types = new Dictionary<string, bool> ();
		bool IsSimdType (QualType type)
		{
			var str = type.CanonicalQualType.ToString ();
			bool rv;
			if (simd_types.TryGetValue (str, out rv))
				return rv;

			switch (str) {
			case "GKTriangle":
			case "GKBox":
				return false; // we probably need to fix these :(
			case "GKQuad":
				return false; // need to look into this
			case "MPSImageHistogramInfo *":
			case "MPSImageHistogramInfo":
				return false; // it really is, but we've defined it correctly (with OpenTK.Vector4)
			default:
				var t = type.CanonicalQualType.Type;

				if (t is AttributedType) {
					var at = (AttributedType) t;
					t = at.ModifiedType.Type;
				}

				if ( t is Clang.Ast.PointerType) {
					var pt = (Clang.Ast.PointerType) t;
					t = pt.PointeeQualType.Type;
				}

				var r = (t as RecordType)?.Decl;

				if (r != null) {
					//Console.WriteLine (r);
					//Console.WriteLine ("Attributes: {0}", r.Attrs.Count ());
					//Console.WriteLine ("Identifier: {0}", r.Identifier);
					//Console.WriteLine ("Fields: {0}", r.Fields.Count ());
					foreach (var f in r.Fields) {
						//Console.WriteLine (f);
						var qt = f.QualType.CanonicalQualType.Type;
						if (qt.Kind == TypeKind.ExtVector) {
							Console.WriteLine ("Detected that {0} is an ExtVector", str);
							simd_types [str] = true;
							return true;
						}
						var at = qt as ConstantArrayType;
						//Console.WriteLine (qt);
						if (at != null) {
							//Console.WriteLine (at.ElementType);
							//Console.WriteLine (at.ElementType.Type.Kind);
							if (at.ElementType.Type.Kind == TypeKind.ExtVector) {
								Console.WriteLine ("Detected that {0} is an ExtVector", str);
								simd_types [str] = true;
								return true;
							}
						}
					}
				}

				if (str.StartsWith ("simd_", StringComparison.Ordinal))
					throw new NotImplementedException (str);//?

				//Console.WriteLine ("Detected that {0} is NOT an ExtVector", str);

				simd_types [str] = false;

				return false;
			}
		}

		public override void VisitObjCMethodDecl (ObjCMethodDecl decl, VisitKind visitKind)
		{
			if (visitKind != VisitKind.Enter)
				return;

			// don't process methods (or types) that are unavailable for the current platform
			if (!decl.IsAvailable () || !(decl.DeclContext as Decl).IsAvailable ())
				return;

			var contains = ContainsSimdTypes (decl);

			var method = GetMethod (decl);
			// don't report missing [DesignatedInitializer] for types that are not bound - that's a different problem
			if (method == null) {
				if (contains)
					Console.WriteLine ("-- found simd type in native signature, not no equivalent managed function marked: {0}", decl);
				return;
			}

			if (!contains) {
				Console.WriteLine ("-- Simd-lookalike in signature, but not a simd type -- {0}", method);
				return;
			}

			Console.WriteLine ("-- simd type in signature, has a simd type -- {0}", method);
		}
	}
}