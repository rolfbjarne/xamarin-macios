using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

#nullable enable

namespace Xamarin.Linker {

	static class Cecil_Extensions {
		public static VariableDefinition AddVariable (this MethodBody self, TypeReference variableType)
		{
			var rv = new VariableDefinition (variableType);
			self.Variables.Add (rv);
			return rv;
		}

		public static ParameterDefinition AddParameter (this MethodDefinition self, string name, TypeReference parameterType)
		{
			var rv = new ParameterDefinition (name, ParameterAttributes.None, parameterType);
			self.Parameters.Add (rv);
			return rv;
		}

		public static MethodDefinition AddMethod (this TypeDefinition self, string name, MethodAttributes attributes, TypeReference returnType)
		{
			var rv = new MethodDefinition (name, attributes, returnType);
			rv.DeclaringType = self;
			self.Methods.Add (rv);
			return rv;
		}

		public static MethodBody CreateBody (this MethodDefinition self, out ILProcessor il)
		{
			var body = new MethodBody (self);
			self.Body = body;
			il = body.GetILProcessor ();
			return body;
		}

		public static void AddRange<T> (this Mono.Collections.Generic.Collection<T> self, IEnumerable<T>? items)
		{
			if (items is null)
				return;

			foreach (var item in items) {
				self.Add (item);
			}
		}

		public static void EmitLoadArgument (this ILProcessor il, int argument)
		{
			il.Append (il.CreateLoadArgument (argument));
		}
		public static Instruction CreateLoadArgument (this ILProcessor il, int argument)
		{
			switch (argument) {
			case 0:
				return il.Create (OpCodes.Ldarg_0);
			case 1:
				return il.Create (OpCodes.Ldarg_1);
			case 2:
				return il.Create (OpCodes.Ldarg_2);
			case 3:
				return il.Create (OpCodes.Ldarg_3);
			default:
				return il.Create (OpCodes.Ldarg, argument);
			}
		}

		public static Instruction Create (this ILProcessor il, bool value)
		{
			if (value)
				return il.Create (OpCodes.Ldc_I4_1);
			return il.Create (OpCodes.Ldc_I4_0);
		}

		public static void Emit (this ILProcessor il, bool value)
		{
			il.Append (il.Create (value));
		}

		public static GenericInstanceMethod CreateGenericInstanceMethod (this MethodReference mr, params TypeReference [] genericTypeArguments)
		{
			var gim = new GenericInstanceMethod (mr);
			gim.GenericArguments.AddRange (genericTypeArguments);
			return gim;
		}

		public static MethodReference CreateMethodReferenceOnGenericType (this TypeReference type, MethodReference mr, params TypeReference [] genericTypeArguments)
		{
			var git = new GenericInstanceType (type);
			git.GenericArguments.AddRange (genericTypeArguments);

			var rv = new MethodReference (mr.Name, mr.ReturnType, git);
			rv.HasThis = mr.HasThis;
			rv.ExplicitThis = mr.ExplicitThis;
			rv.CallingConvention = mr.CallingConvention;
			rv.Parameters.AddRange (mr.Parameters);
			return rv;
		}

		public static GenericInstanceType CreateGenericInstanceType (this TypeReference type, params TypeReference [] genericTypeArguments)
		{
			var git = new GenericInstanceType (type);
			git.GenericArguments.AddRange (genericTypeArguments);
			return git;
		}

		public static MethodDefinition AddDefaultConstructor (this TypeDefinition type, AppBundleRewriter abr)
		{
			// Add default ctor that just calls the base ctor
			var defaultCtor = type.AddMethod (".ctor", MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName, abr.System_Void);
			defaultCtor.CreateBody (out var il);
			il.Emit (OpCodes.Ldarg_0);
			il.Emit (OpCodes.Call, abr.System_Object__ctor);
			il.Emit (OpCodes.Ret);
			return defaultCtor;
		}
	}
}