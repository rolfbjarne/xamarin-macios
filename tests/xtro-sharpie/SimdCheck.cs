using System;
using System.Collections.Generic;
using System.Linq;

using Mono.Cecil;

using Clang.Ast;

namespace Extrospection
{

	class SimdCheck : BaseVisitor
	{
		Dictionary<string, MethodDefinition> methods = new Dictionary<string, MethodDefinition> ();
		MethodDefinition GetMethod (ObjCMethodDecl decl)
		{
			MethodDefinition md;
			methods.TryGetValue (decl.GetName (), out md);
			return md;
		}

		public override void End ()
		{
			base.End ();

			foreach (var t in simd_types.Where ((v) => v.Value).OrderBy ((v) => v.Key))
				Console.WriteLine ("SIMD type: {0}", t.Key);
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
			switch (td.Name) {
			case "MDLAxisAlignedBoundingBox":
			case "MDLVoxelIndexExtent":
			case "Matrix3":
			case "Matrix4":
			case "GKBox":
			case "GKQuad":
			case "GKTriangle":
				return true;
			default:
				return false;
			}
		}

		bool ContainsSimdTypes (ObjCMethodDecl decl, ref string simd_type)
		{
			if (IsSimdType (decl.ReturnQualType, ref simd_type))
				return true;

			foreach (var param in decl.Parameters) {
				if (IsSimdType (param.QualType, ref simd_type))
					return true;
			}

			return false;
		}


		Dictionary<string, bool> simd_types = new Dictionary<string, bool> ();
		bool IsSimdType (QualType type, ref string simd_type)
		{
			var str = type.ToString ();
			simd_type = str;
			bool rv;
			if (simd_types.TryGetValue (str, out rv))
				return rv;

			if (str.Contains ("MDL_EXPORT_CPPCLASS"))
				Console.WriteLine ("STOP");

			switch (str) {
			case "const MPSImageHistogramInfo *":
			case "MPSImageHistogramInfo *":
			case "MPSImageHistogramInfo":
				return false; // it really is, but we've defined it correctly (with OpenTK.Vector4)
			default:
				var t = type.CanonicalQualType.Type;

				if (t is Clang.Ast.PointerType) {
					var pt = (Clang.Ast.PointerType) t;
					t = pt.PointeeQualType.Type;
				}

				if (t.Kind == TypeKind.ExtVector) {
					simd_types [str] = true;
					return true;
				}

				var r = (t as RecordType)?.Decl;

				if (r != null) {
					foreach (var f in r.Fields) {
						var qt = f.QualType.CanonicalQualType.Type;
						if (qt.Kind == TypeKind.ExtVector) {
							simd_types [str] = true;
							return true;
						}
						var at = qt as ConstantArrayType;
						if (at != null) {
							if (at.ElementType.Type.Kind == TypeKind.ExtVector) {
								simd_types [str] = true;
								return true;
							}
						}
					}
				}

				if (str.Contains ("simd"))
					throw new NotImplementedException (str);

				simd_types [str] = false;

				return false;
			}
		}

		//public override void VisitObjCInterfaceDecl (ObjCInterfaceDecl decl, VisitKind visitKind)
		//{
		//	base.VisitObjCInterfaceDecl (decl, visitKind);

		//	if (decl.Attrs.Count () != 0 || decl.Annotations.Count () != 0)
		//		Console.WriteLine ($"{decl.Name} has {decl.Attrs.Count ()} attrs and {decl.Annotations.Count ()} annotations");
		//}

		public override void VisitObjCMethodDecl (ObjCMethodDecl decl, VisitKind visitKind)
		{
			if (visitKind != VisitKind.Enter)
				return;

			// don't process methods (or types) that are unavailable for the current platform
			if (!decl.IsAvailable () || !(decl.DeclContext as Decl).IsAvailable ())
				return;

			var parentClass = decl.DeclContext as Decl;
			var attrs = decl.Attrs.ToList ();
			if (parentClass != null)
				attrs.AddRange (parentClass.Attrs);
			var is_new = false;
			foreach (var attr in attrs) {
				var av_attr = attr as AvailabilityAttr;
				if (av_attr == null)
					continue;
				if (av_attr.Platform.Name != "ios")
					continue;
				if (av_attr.Introduced.Major >= 11) {
					is_new = true;
					break;
				}
			}

			var simd_type = string.Empty;
			var contains = ContainsSimdTypes (decl, ref simd_type);

			var method = GetMethod (decl);
			if (method == null) {
				if (contains) {
					if (is_new) {
						//Console.WriteLine ($"-- iOS 11 -- found simd type '{simd_type}' in native signature, but no equivalent managed function found: {decl}");
					} else {
						Console.WriteLine ($"-- found simd type '{simd_type}' in native signature, but no equivalent managed function found: {decl} (selector: {decl.Selector} name: {decl.GetName ()})");
					}
				}
				return;
			}

			if (!contains) {
				//Console.WriteLine ("-- Simd-lookalike in signature, but not a simd type -- {0}", method);
				return;
			}

			if (method.IsObsolete ()) {
				Console.WriteLine ($"-- OBSOLETE simd type '{simd_type}' in signature, has a simd type -- {method}");
				return;
			}

			Console.WriteLine ($"-- simd type '{simd_type}' in signature, has a simd type -- {method}");
		}
	}
}