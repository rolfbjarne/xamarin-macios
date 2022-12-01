using System;
using System.Collections.Generic;
using System.Linq;

using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Tuner;

using Xamarin.Bundler;

#nullable enable

namespace Xamarin.Linker
{
	public class GenerateStaticRegistrarMap : ConfigurationAwareStep
	{
		protected override string Name => "Generate Static Registrar Map";
		protected override int ErrorCode => 2430;

		AssemblyDefinition? productAssembly;
		AssemblyDefinition? corlibAssembly;

		List<TypeDefinition> Types = new List<TypeDefinition>();
		List<MethodDefinition> Methods = new List<MethodDefinition>();

		protected override void TryProcessAssembly (AssemblyDefinition assembly)
		{
			base.TryProcessAssembly (assembly);

			if (assembly.Name.Name == Configuration.PlatformAssembly)
				productAssembly = assembly;
			else if (assembly.Name.Name == Driver.CorlibName)
				corlibAssembly = assembly;

			if (!assembly.MainModule.HasTypes)
				return;

			// There's no need to process assemblies that don't reference our platform assembly (unless it's the platform assembly itself)
			if (!assembly.MainModule.HasAssemblyReferences)
				return;
			if (assembly != productAssembly && !assembly.MainModule.AssemblyReferences.Any(v => v.Name == Configuration.PlatformAssembly))
				return;

			Types.AddRange(assembly.MainModule.Types);
			foreach (var type in assembly.MainModule.Types)
				ProcessType(type);
		}

		void ProcessType (TypeDefinition type)
		{
			if (type.HasNestedTypes)
			{
				Types.AddRange(type.NestedTypes);
				foreach (var nestedType in type.NestedTypes)
					ProcessType(nestedType);
			}

			if (type.HasMethods)
				Methods.AddRange(type.Methods);
		}

		MethodReference GetCorlibMethod (string typeNamespace, string typeName, string methodName, string parameter1Namespace, string parameter1Name)
		{
			var type = corlibAssembly!.MainModule.Types.First (v => v.Is (typeNamespace, typeName));
			var method = type.Methods.Single (v => v.Name == methodName && v.HasParameters && v.Parameters.Count == 1 && v.Parameters [0].ParameterType.Is (parameter1Namespace, parameter1Name));
			return productAssembly!.MainModule.ImportReference (method);
		}

		protected override void TryEndProcess()
		{

			var class_type = productAssembly!.MainModule.Types.First(v => v.Is("ObjCRuntime", "Class"));
			var productModule = productAssembly.MainModule;

			var system_type_gettypefromhandle_ref = GetCorlibMethod ("System", "Type", "GetTypeFromHandle", "System", "RuntimeTypeHandle");
			var system_runtimetypehandle_equals_ref = GetCorlibMethod ("System", "RuntimeTypeHandle", "Equals", "System", "RuntimeTypeHandle");
			var system_methodbase_getmethodfromhandle_ref = GetCorlibMethod ("System.Reflection", "MethodBase", "GetMethodFromHandle", "System", "RuntimeMethodHandle");

			int counter = 0;
			int methodA = 0;
			int methodB = 0;
			int methodC = 0;
			int methodD = 0;
			int methodE = 0;

			var filteredMethods = Methods
				.Where(v => {
					if (v.HasCustomAttributes && v.CustomAttributes.Any(v => v.AttributeType.Name == "ExportAttribute" || v.AttributeType.Name == "BindingImplAttribute"))
					{
						methodA++;
						return true;
					}
					if (v.IsConstructor && v.DeclaringType.IsNSObject(Configuration.DerivedLinkContext))
					{
						methodB++;
						return true;
					}
					if (v.IsVirtual && v.DeclaringType.IsNSObject(Configuration.DerivedLinkContext))
					{
						methodC++;
						return true;
					}
					if (v.IsSpecialName)
					{
						var property = v.GetPropertyByAccessor();
						if (property?.HasCustomAttributes == true && property.CustomAttributes.Any(v => v.AttributeType.Name == "ExportAttribute" || v.AttributeType.Name == "OutletAttribute" || v.AttributeType.Name == "BindingImplAttribute"))
						{
							methodD++;
							return true;
						}
					}

					if (v.DeclaringType.HasCustomAttributes && v.DeclaringType.CustomAttributes.Any(v => v.AttributeType.Name == "BindingImplAttribute"))
					{
						methodE++;
						return true;
					}

					if (v.DeclaringType.Name == "NIDActionArity1V1")
						return true;

					if (v.Name == "Create" && v.HasCustomAttributes && v.CustomAttributes.Any(v => v.AttributeType.Name == "PreserveAttribute"))
						return true;

					return false;
					})
				.ToList();
			var filteredTypes = Types
				.Where(v => v.Name != "<Module>")
				.ToList();

			Console.WriteLine($"GenerateStaticRegistrarMap: Adding {filteredTypes.Count} types and {filteredMethods.Count} methods: {methodA} {methodB} {methodC} {methodD} {methodE}");

			var mapTypeToTokenMethod = class_type.Methods.Single(m => m.Name == "TryMapRuntimeTypeHandleToToken");
			mapTypeToTokenMethod.Body = new MethodBody(mapTypeToTokenMethod);
			var mapTypeToToken = mapTypeToTokenMethod.Body.GetILProcessor();

			var mapToMemberMethod = class_type.Methods.Single(m => m.Name == "TryMapTokenToMember");
			mapToMemberMethod.Body = new MethodBody(mapToMemberMethod);
			var mapToMember = mapToMemberMethod.Body.GetILProcessor();
			ILProcessor? mapToMemberChunk = null;

			var addMapToMemberEpilog = (ILProcessor il) =>
			{
				//
				// TryMapTokenToMember epilogue
				//
				//     member = null;
				il.Emit(OpCodes.Ldarg_1);
				il.Emit(OpCodes.Ldnull);
				il.Emit(OpCodes.Stind_Ref);
				il.Emit(OpCodes.Ldc_I4_0);
				//     return false;
				il.Emit(OpCodes.Ret);
				// }
			};

			var lastToken = 0;

			var totalMembers = filteredMethods.Count + filteredTypes.Count;
			var chunkSize = 100;
			var chunks = (totalMembers + chunkSize - 1) / chunkSize;
			var branches = new(Instruction, Instruction)[chunks];
			for (var i = 0; i < chunks; i++)
			{
				var loadConstant = Instruction.Create(OpCodes.Ldc_I4, 0);
				branches[i].Item1 = loadConstant;
				mapToMember.Emit(OpCodes.Ldarg_0);
				mapToMember.Append(loadConstant);
				var jumpTarget = Instruction.Create(OpCodes.Ble_Un, loadConstant /* this is just a temporary target */);
				branches[i].Item2 = jumpTarget; 
				mapToMember.Append(jumpTarget);
			}

			var splitInChunks = () =>
			{
				if (counter % chunkSize != 0)
					return;
				var chunk = counter / chunkSize;
				var chunkMethod = new MethodDefinition($"{mapToMemberMethod.Name}_{chunk + 1}", mapToMemberMethod.Attributes, mapToMemberMethod.ReturnType);
				for (var i = 0; i < mapToMemberMethod.Parameters.Count; i++)
					chunkMethod.Parameters.Add(new ParameterDefinition(mapToMemberMethod.Parameters[i].Name, mapToMemberMethod.Parameters[i].Attributes, mapToMemberMethod.Parameters[i].ParameterType));
				mapToMemberMethod.DeclaringType.Methods.Add(chunkMethod);

				if (mapToMemberChunk is not null)
					addMapToMemberEpilog(mapToMemberChunk);

				if (chunk > 0)
				{
					branches[chunk - 1].Item1.Operand = lastToken;
				}
				var startChunk = Instruction.Create(OpCodes.Ldarg_0);
				branches[chunk].Item2.Operand = startChunk;

				mapToMember.Append(startChunk);
				mapToMember.Emit(OpCodes.Ldarg_1);
				mapToMember.Emit(OpCodes.Call, chunkMethod);
				var neqTarget = mapToMember.Create(OpCodes.Nop);
				mapToMember.Emit(OpCodes.Brfalse, neqTarget);
				mapToMember.Emit(OpCodes.Ldc_I4_1);
				mapToMember.Emit(OpCodes.Ret);
				mapToMember.Append(neqTarget);

				mapToMemberChunk = chunkMethod.Body.GetILProcessor ();
			};

			for (var i = 0; i < filteredTypes.Count; i++)
			{
				splitInChunks();

				var type = filteredTypes[i];
				var token = 0x02000000 /* TypeDef */ | counter++;
				lastToken = token;

				TypeReference tr = type;
				if (type.Module.Assembly != productAssembly)
					tr = productAssembly.MainModule.ImportReference(type);

				Configuration.AddToMap(type, token);

				//
				// TryMapTokenToMember
				//
				var neqTarget = mapToMemberChunk!.Create(OpCodes.Nop);
				// if (token_reference == <constant>) {
				mapToMemberChunk.Emit(OpCodes.Ldarg_0);
				mapToMemberChunk.Emit(OpCodes.Ldc_I4, token);
				mapToMemberChunk.Emit(OpCodes.Bne_Un, neqTarget);
				//     member = Type.GetTypeFromHandle (ldtoken <type>);
				mapToMemberChunk.Emit(OpCodes.Ldarg_1);
				mapToMemberChunk.Emit(OpCodes.Ldtoken, tr);
				mapToMemberChunk.Emit(OpCodes.Call, system_type_gettypefromhandle_ref);
				mapToMemberChunk.Emit(OpCodes.Stind_Ref);
				//     return true;
				mapToMemberChunk.Emit(OpCodes.Ldc_I4_1);
				mapToMemberChunk.Emit(OpCodes.Ret);
				// }
				mapToMemberChunk.Append(neqTarget);

				//
				// TryMapRuntimeTypeHandleToToken
				//
				neqTarget = mapTypeToToken.Create(OpCodes.Nop);
				// if (runtimetypehandle.Equals (ldtoken <type>)) {
				mapTypeToToken.Emit(OpCodes.Ldarga_S, (byte) 0);
				mapTypeToToken.Emit(OpCodes.Ldtoken, tr);
				mapTypeToToken.Emit(OpCodes.Call, system_runtimetypehandle_equals_ref);
				mapTypeToToken.Emit(OpCodes.Brfalse, neqTarget);
				//     token = <constant>;
				mapTypeToToken.Emit(OpCodes.Ldarg_1);
				mapTypeToToken.Emit(OpCodes.Ldc_I4, token);
				mapTypeToToken.Emit(OpCodes.Stind_I4);
				//     return true;
				mapTypeToToken.Emit(OpCodes.Ldc_I4_1);
				mapTypeToToken.Emit(OpCodes.Ret);
				// } 
				mapTypeToToken.Append(neqTarget);
			}

			for (var i = 0; i < filteredMethods.Count; i++)
			{
				splitInChunks();

				var token = 0x06000000 /* Method */ | counter++;
				var method = filteredMethods[i];
				lastToken = token;

				MethodReference mr = method;
				if (method.Module.Assembly != productAssembly)
					mr = productAssembly.MainModule.ImportReference(method);

				Configuration.AddToMap(method, token);

				//
				// TryMapTokenToMember
				//
				var neqTarget = mapToMemberChunk!.Create(OpCodes.Nop);
				// if (token_reference == <constant>) {
				mapToMemberChunk.Emit(OpCodes.Ldarg_0);
				mapToMemberChunk.Emit(OpCodes.Ldc_I4, token);
				mapToMemberChunk.Emit(OpCodes.Bne_Un, neqTarget);
				mapToMemberChunk.Emit(OpCodes.Ldarg_1);
				mapToMemberChunk.Emit(OpCodes.Ldtoken, mr);
				//     member = MethodBase.GetMethodFromHandle (ldtoken <type>);
				mapToMemberChunk.Emit(OpCodes.Call, system_methodbase_getmethodfromhandle_ref);
				mapToMemberChunk.Emit(OpCodes.Stind_Ref);
				//     return true;
				mapToMemberChunk.Emit(OpCodes.Ldc_I4_1);
				mapToMemberChunk.Emit(OpCodes.Ret);
				// }
				mapToMemberChunk.Append(neqTarget);
			}

			//
			// TryMapTokenToMember epilogue
			//
			addMapToMemberEpilog(mapToMemberChunk!);
			addMapToMemberEpilog(mapToMember);

			//
			// TryMapRuntimeTypeHandleToToken epilogue:
			//
			//     token = 0;
			mapTypeToToken.Emit(OpCodes.Ldarg_1);
			mapTypeToToken.Emit(OpCodes.Ldc_I4_0);
			mapTypeToToken.Emit(OpCodes.Stind_I4);
			mapTypeToToken.Emit(OpCodes.Ldc_I4_0);
			//     return false;
			mapTypeToToken.Emit(OpCodes.Ret);
			// }


			branches[chunks - 1].Item1.Operand = lastToken;

			Console.WriteLine($"GenerateStaticRegistrarMap: previons action: {Context.Annotations.GetAction(productAssembly)}");
			Context.Annotations.SetAction(productAssembly, Mono.Linker.AssemblyAction.Save);
		}
	}
}

