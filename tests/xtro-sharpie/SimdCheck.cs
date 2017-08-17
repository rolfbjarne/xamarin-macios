using System;
using System.Collections.Generic;
using System.Linq;

using Mono.Cecil;

using Clang.Ast;

namespace Extrospection
{

	class SimdCheck : BaseVisitor
	{
		Dictionary<string, MethodDefinition> potentially_broken_methods = new Dictionary<string, MethodDefinition> ();
		Dictionary<string, MethodDefinition> correct_methods = new Dictionary<string, MethodDefinition> ();

		MethodDefinition GetPotentiallyBrokenMethod (ObjCMethodDecl decl)
		{
			MethodDefinition md;
			potentially_broken_methods.TryGetValue (decl.GetName (), out md);
			return md;
		}

		MethodDefinition GetCorrectMethod (ObjCMethodDecl decl)
		{
			MethodDefinition md;
			correct_methods.TryGetValue (decl.GetName (), out md);
			return md;
		}

		public override void End ()
		{
			base.End ();

			//foreach (var t in simd_types.Where ((v) => v.Value).OrderBy ((v) => v.Key))
			//	Console.WriteLine ("SIMD type: {0}", t.Key);
			//Console.WriteLine ($"A- Found {potentially_broken_methods.Count} potentially broken methods:");
			//foreach (var t in potentially_broken_methods)
			//	Console.WriteLine ($"B-     {t.Key} => {t.Value.DeclaringType.FullName}: {t.Value.FullName}");
			//Console.WriteLine ($"C- Found {correct_methods.Count} correct methods:");
			//foreach (var t in correct_methods)
				//Console.WriteLine ($"D-     {t.Key} => {t.Value.DeclaringType.FullName}: {t.Value.FullName}");
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

			if (method.HasCustomAttributes && method.CustomAttributes.Where ((v) => v.Constructor.DeclaringType.Name == "ExtensionAttribute").Any ())
				return; // Extension methods can't be mapped.

			var key = method.GetName ();
			if (key == null) {
				if (method.IsObsolete ())
					return; // Don't care about obsolete API.

				// We can't map this method to a native function.
				// Console.WriteLine ($"-- simd can't map -- {method.DeclaringType.FullName}: {method}");
				return;
			}

			var potentially_broken_method = MightHaveBrokenSimdType (method);
			var fixed_method = !potentially_broken_method && ContainsSimdTypes (method);

			if (potentially_broken_method) {
				MethodDefinition existing;
				if (potentially_broken_methods.TryGetValue (key, out existing)) {
					Console.WriteLine ("CRASH");
					Console.WriteLine (existing);
					Console.WriteLine (method);
				}
				potentially_broken_methods.Add (key, method);
			} else if (fixed_method) {
				correct_methods.Add (key, method); // We need to keep track of methods using correct Simd types, otherwise we won't know that the native signature has been correctly bound.
			}
		}

		bool MightHaveBrokenSimdType (MethodDefinition method)
		{
			if (MightHaveBrokenSimdType (method.ReturnType))
				return true;

			if (method.HasParameters) {
				foreach (var param in method.Parameters)
					if (MightHaveBrokenSimdType (param.ParameterType))
						return true;
			}

			return false;
		}

		bool ContainsSimdTypes (MethodDefinition method)
		{
			if (IsSimdType (method.ReturnType))
				return true;

			if (method.HasParameters) {
				foreach (var param in method.Parameters)
					if (IsSimdType (param.ParameterType))
						return true;
			}

			return false;
		}

		bool IsSimdType (TypeReference type)
		{
			return type.Namespace == "Simd";
		}

		bool MightHaveBrokenSimdType (TypeReference td)
		{
			switch (td.Name) {
			case "MDLAxisAlignedBoundingBox":
			case "MDLVoxelIndexExtent":
			case "Matrix2":
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

			switch (str) {
			case "GKQuad":
				// The native definition is two 'vector_float2' fields.
				// The managed definition matches this (two 'Vector2' fields), and should work fine.
				return false;
			case "struct GKBox":
			case "GKBox":
				// REQUIRES MARSHAL DIRECTIVE
				// The native definition is two 'vector_float3' fields.
				// In this case each element uses 16 bytes (4 floats) due to padding.
				// The managed definition is two Vector3 fields, and does *not*
				// match the native definition (missing the padding).
				// Right now we're marshalling this struct manually ([MarshalDirective]),
				// so managed code should get correct results.
				return false;
			case "GKTriangle":
				// REQUIRES MARSHAL DIRECTIVE
				// The native definition is 'vector_float3 points[3]' - an array of three vector_float3.
				// In this case each element uses 16 bytes (4 floats) due to padding.
				// The managed definition is just an array of Vector3, but luckily
				// it's a private field, so we can improve this later. Right now we're marshalling
				// this struct manually ([MarshalDirective]), so managed code should get correct
				// results.
				return false;
			case "MDLVoxelIndex":
				// This is a 'vector_int4, represented by a Vector4i in managed code,
				// which means it's matching the native definition.
				return false;
			case "MDLAxisAlignedBoundingBox":
				// REQUIRES MARSHAL DIRECTIVE
				// In managed code this is a struct of two Vector3, so it's *not* matching
				// the native definition. However, since we're manually marshalling this type
				// (using [MarshalDirective]), managed code doesn't get incorrect results.
				return false;
			case "MDLVoxelIndexExtent":
				// In managed code this is struct of two Vector4, so it's matching the native definition.
				return false;
			case "const MPSImageHistogramInfo * _Nonnull'":
			case "const MPSImageHistogramInfo *":
			case "MPSImageHistogramInfo *":
			case "MPSImageHistogramInfo":
				// The managed definition is identical to the native definition,
				// so this is not a type we care about.
				return false;
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

		public override void VisitObjCPropertyDecl (ObjCPropertyDecl decl)
		{
			base.VisitObjCPropertyDecl (decl);

			if (decl.ToString ().Contains ("GKAgent3D"))
				Console.WriteLine (decl.Getter.Selector);
		}

		public override void VisitObjCMethodDecl (ObjCMethodDecl decl, VisitKind visitKind)
		{
			if (visitKind != VisitKind.Enter)
				return;

			// don't process methods (or types) that are unavailable for the current platform
			if (!decl.IsAvailable () || !(decl.DeclContext as Decl).IsAvailable ())
				return;

			// Check if this API is new in iOS 11 (helps printing more useful
			// debug info, we might run into API that hasn't been bound).
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
			var native_simd = ContainsSimdTypes (decl, ref simd_type);

			var method = GetPotentiallyBrokenMethod (decl);

			if (!native_simd) {
				if (method != null) {
					// The managed method uses types that were incorrectly used in place of the correct Simd types,
					// but the managed method doesn't use the native Simd types. This means the binding is correct.
				} else {
					// Neither the managed nor the native method have anything to do with Simd types.
				}
				return;
			}

			if (method == null) {
				var correct = GetCorrectMethod (decl);
				if (correct != null) {
					// This method is correctly bound using managed Simd types.
					//Console.WriteLine ($"-- the managed method {correct} was correctly bound (native function: {decl}).");
				} else {
					// Could not map the native method to a managed method.
					if (is_new) {
						// Most likely the method hasn't been bound yet.
						//Console.WriteLine ($"-- iOS 11 -- found simd type '{simd_type}' in native signature, but no equivalent managed function found: {decl}");
					} else {
						// This needs investigation, to see why the native method couldn't be mapped.
						switch (simd_type) {
						case "const vector_float2 * _Nullable":
						case "vector_float2":
						case "vector_float3 * _Nonnull":
						case "vector_float2 * _Nonnull":
						case "const vector_float2 * _Nonnull":
						case "vector_float3":
						case "vector_float4":
						case "vector_double2":
						case "vector_double3":
						case "vector_int2":
						case "const MPSImageHistogramInfo * _Nonnull":
						case "simd_quatf":
							break; // we don't care about these types (yet)
						default:
							Console.WriteLine ($"!simd-mapping-failure! {decl}: could not find a managed method (selector: {decl.Selector} name: {decl.GetName ()}. Found the simd type '{simd_type}' in the native signature.");
							break;
						}
					}
				}
				return;
			}

			if (method.IsObsolete ()) {
				// We have a potentially broken managed method, but it's obsolete. That's fine.
				//Console.WriteLine ($"-- OBSOLETE simd type '{simd_type}' in signature, has a simd type -- {method}");
				return;
			}

			// We have a potentially broken managed method. This needs fixing/investigation.
			Console.WriteLine ($"!unknown-simd-type-in-signature! {method}: the native signature has a simd type ({simd_type}), while the corresponding managed method is using an incorrect (non-simd) type.");
		}
	}
}