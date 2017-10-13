//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//using Mono.Linker;
//using Mono.Linker.Steps;

//using Mono.Cecil;
//using Mono.Cecil.Cil;

//using Xamarin.Bundler;
//using Xamarin.Linker;
//using Xamarin.Tuner;

//namespace Mono.Tuner
//{

//	public class RemoveProtocolStep : BaseStep
//	{
//		HashSet<TypeDefinition> protocols = new HashSet<TypeDefinition> ();
//		HashSet<TypeDefinition> used_protocols = new HashSet<TypeDefinition> ();

//		DerivedLinkContext LinkContext {
//			get {
//				return (DerivedLinkContext) base.Context;
//			}
//		}

//		protected override void ProcessAssembly (AssemblyDefinition assembly)
//		{
//			Console.WriteLine ($"Processing {assembly.MainModule.FileName}");

//			// Check if the assembly is referencing our product assembly.
//			var hasProductReference = false;
//			foreach (var ar in assembly.MainModule.AssemblyReferences) {
//				if (Profile.IsProductAssembly (ar.Name)) {
//					hasProductReference = true;
//					break;
//				}
//			}
//			if (!hasProductReference)
//				return;

//			var hasProtocolReference = false;
//			foreach (var mr in assembly.MainModule.GetTypeReferences ()) {
//				if (mr.Name != "ProtocolAttribute")
//					continue;
//				if (mr.Namespace != Namespaces.ObjCRuntime)
//					continue;
//				hasProtocolReference = true;
//				break;
//			}
//			if (!hasProtocolReference)
//				return;

//			MarkAssembly (assembly);
//		}


//		protected override void EndProcess ()
//		{
//		}

//		void MarkAssembly (AssemblyDefinition assembly)
//		{
//			if (assembly.MainModule.HasTypes)
//				foreach (var type in assembly.MainModule.Types)
//					MarkType (type);
//		}

//		void MarkType (TypeReference tr)
//		{
//			var type = tr.Resolve ();

//			if (type == null)
//				return;

//			MarkType (type.BaseType);
//			MarkType (type.DeclaringType);
//			MarkCustomAttributes (type);

//			if (type.HasMethods)
//				foreach (var method in type.Methods)
//					MarkMethod (method);
//		}

//		void MarkMethod (MethodReference mr)
//		{
//			var method = mr.Resolve ();

//			if (method.HasParameters)
//				foreach (var param in method.Parameters)
//					MarkType (param.ParameterType);
			
//			if (method.HasBody)
//				MarkMethodBody (method.Body);
//		}

//		void MarkMethodBody (MethodBody body)
//		{
//			foreach (VariableDefinition var in body.Variables)
//				MarkType (var.VariableType);

//			foreach (ExceptionHandler eh in body.ExceptionHandlers)
//				if (eh.HandlerType == ExceptionHandlerType.Catch)
//					MarkType (eh.CatchType);

//			foreach (Instruction instruction in body.Instructions)
//				MarkInstruction (instruction);
//		}

//		void MarkInstruction (Instruction instruction)
//		{
//			switch (instruction.OpCode.OperandType) {
//			case OperandType.InlineField:
//				MarkField ((FieldReference) instruction.Operand);
//				break;
//			case OperandType.InlineMethod:
//				MarkMethod ((MethodReference) instruction.Operand);
//				break;
//			case OperandType.InlineTok:
//				object token = instruction.Operand;
//				if (token is TypeReference)
//					MarkType ((TypeReference) token);
//				else if (token is MethodReference)
//					MarkMethod ((MethodReference) token);
//				else
//					MarkField ((FieldReference) token);
//				break;
//			case OperandType.InlineType:
//				MarkType ((TypeReference) instruction.Operand);
//				break;
//			default:
//				break;
//			}
//		}

//		void MarkField (FieldReference reference)
//		{
//			if (reference.DeclaringType is GenericInstanceType)
//				MarkType (reference.DeclaringType);

//			FieldDefinition field = reference.Resolve ();

//			if (field == null)
//				return;

//			MarkType (field.DeclaringType);
//			MarkType (field.FieldType);
//			MarkCustomAttributes (field);
//		}

//		void MarkCustomAttributes (ICustomAttributeProvider provider)
//		{
//			if (!provider.HasCustomAttributes)
//				return;

//			foreach (CustomAttribute ca in provider.CustomAttributes)
//				MarkCustomAttribute (ca);
//		}

//		void MarkCustomAttribute (CustomAttribute ca)
//		{
//			MarkMethod (ca.Constructor);

//			MarkCustomAttributeArguments (ca);

//			TypeReference constructor_type = ca.Constructor.DeclaringType;
//			TypeDefinition type = constructor_type.Resolve ();

//			if (type == null) {
//				throw new Exception ();
//				//return;
//			}

//			MarkCustomAttributeProperties (ca, type);
//			MarkCustomAttributeFields (ca, type);
//		}

//		void MarkCustomAttributeArguments (CustomAttribute ca)
//		{
//			if (!ca.HasConstructorArguments)
//				return;

//			foreach (var argument in ca.ConstructorArguments)
//				MarkIfType (argument);
//		}

//		protected void MarkCustomAttributeProperties (CustomAttribute ca, TypeDefinition attribute)
//		{
//			if (!ca.HasProperties)
//				return;

//			foreach (var named_argument in ca.Properties)
//				MarkCustomAttributeProperty (named_argument, attribute);
//		}

//		void MarkCustomAttributeProperty (CustomAttributeNamedArgument namedArgument, TypeDefinition attribute)
//		{
//			PropertyDefinition property = GetProperty (attribute, namedArgument.Name);
//			Annotations.Push (property);
//			if (property != null)
//				MarkMethod (property.SetMethod);

//			MarkIfType (namedArgument.Argument);
//			Annotations.Pop ();
//		}


//		void MarkCustomAttributeFields (CustomAttribute ca, TypeDefinition attribute)
//		{
//			if (!ca.HasFields)
//				return;

//			foreach (var named_argument in ca.Fields)
//				MarkCustomAttributeField (named_argument, attribute);
//		}

//		protected void MarkCustomAttributeField (CustomAttributeNamedArgument namedArgument, TypeDefinition attribute)
//		{
//			FieldDefinition field = GetField (attribute, namedArgument.Name);
//			if (field != null)
//				MarkField (field);

//			MarkIfType (namedArgument.Argument);
//		}


//		void MarkIfType (CustomAttributeArgument argument)
//		{
//			var at = argument.Type;
//			if (at.IsArray) {
//				var et = at.GetElementType ();
//				if (et.Namespace != "System" || et.Name != "Type")
//					return;

//				MarkType (et);
//				if (argument.Value == null)
//					return;

//				foreach (var cac in (CustomAttributeArgument []) argument.Value)
//					MarkWithResolvedScope ((TypeReference) cac.Value);
//			} else if (at.Namespace == "System" && at.Name == "Type") {
//				MarkType (argument.Type);
//				MarkWithResolvedScope ((TypeReference) argument.Value);
//			}
//		}

//		// custom attributes encoding means it's possible to have a scope that will point into a PCL facade
//		// even if we (just before saving) will resolve all type references (bug #26752)
//		void MarkWithResolvedScope (TypeReference type)
//		{
//			if (type == null)
//				return;

//			// a GenericInstanceType can could contains generic arguments with scope that
//			// needs to be updated out of the PCL facade (bug #28823)
//			var git = (type as GenericInstanceType);
//			if ((git != null) && git.HasGenericArguments) {
//				foreach (var ga in git.GenericArguments)
//					MarkWithResolvedScope (ga);
//			}
//			// we cannot set the Scope of a TypeSpecification but it's element type can be set
//			// e.g. System.String[] -> System.String
//			var ts = (type as TypeSpecification);
//			if (ts != null) {
//				MarkWithResolvedScope (ts.ElementType);
//				return;
//			}

//			var td = type.Resolve ();
//			if (td != null)
//				type.Scope = td.Scope;
//			MarkType (type);
//		}

//		PropertyDefinition GetProperty (TypeDefinition type, string propertyname)
//		{
//			while (type != null) {
//				PropertyDefinition property = type.Properties.FirstOrDefault (p => p.Name == propertyname);
//				if (property != null)
//					return property;

//				type = type.BaseType != null ? ResolveTypeDefinition (type.BaseType) : null;
//			}

//			return null;
//		}

//		FieldDefinition GetField (TypeDefinition type, string fieldname)
//		{
//			while (type != null) {
//				FieldDefinition field = type.Fields.FirstOrDefault (f => f.Name == fieldname);
//				if (field != null)
//					return field;

//				type = type.BaseType != null ? ResolveTypeDefinition (type.BaseType) : null;
//			}

//			return null;
//		}

//		protected TypeDefinition ResolveTypeDefinition (TypeReference type)
//		{
//			TypeDefinition td = type as TypeDefinition;
//			if (td == null)
//				td = type.Resolve ();

//			return td;
//		}
//	}
//}
