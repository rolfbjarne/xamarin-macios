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
			if (assembly == productAssembly || !assembly.MainModule.AssemblyReferences.Any(v => v.Name == Configuration.PlatformAssembly))
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

		protected override void TryEndProcess()
		{

			var class_type = productAssembly!.MainModule.Types.First(v => v.Is("ObjCRuntime", "Class"));

			var system_runtimetypehandle = corlibAssembly!.MainModule.Types.First(v => v.Is("System", "RuntimeTypeHandle"));
			var system_runtimetypehandle_getmethodfromhandle = system_runtimetypehandle.Methods.First(v => v.Name == "GetMethodFromHandle");
			var system_runtimetypehandle_system_runtimetypehandle_getmethodfromhandle_ref = class_type.Module.ImportReference(system_runtimetypehandle_getmethodfromhandle);

			var system_runtimetypehandle_equals = system_runtimetypehandle.Methods.First(v => v.Name == "Equals" && v.HasParameters && v.Parameters.Count == 1 && v.Parameters[0].ParameterType.Is ("System", "RuntimeTypeHandle"));
			var system_runtimetypehandle_equals_ref = class_type.Module.ImportReference(system_runtimetypehandle_equals);

			var system_type = corlibAssembly.MainModule.Types.First(v => v.Is("System", "Type"));
			var system_type_gettypefromhandle = system_type.Methods.Single(v => v.Name == "GetTypeFromHandle" && v.HasParameters && v.Parameters.Count == 1 && v.Parameters[0].ParameterType.Is("System", "RuntimeTypeHandle"));
			var system_type_gettypefromhandle_ref = class_type.Module.ImportReference(system_type_gettypefromhandle);

			var system_methodbase = corlibAssembly.MainModule.Types.First(v => v.Is("System", "MethodBase"));
			var system_methodbase_getmethodfromhandle = system_type.Methods.Single(v => v.Name == "GetMethodFromHandle" && v.HasParameters && v.Parameters.Count == 1 && v.Parameters[0].ParameterType.Is("System", "RuntimeMethodHandle"));
			var system_methodbase_getmethodfromhandle_ref = class_type.Module.ImportReference(system_methodbase_getmethodfromhandle);

			var system_runtimemethodhandle = corlibAssembly.MainModule.Types.First(v => v.Is("System", "RuntimeMethodHandle"));
			var system_runtimemethodhandle_tointptr = system_runtimemethodhandle.Methods.Single(v => v.Name == "ToIntPtr");
			var system_runtimemethodhandle_tointptr_ref = class_type.Module.ImportReference(system_runtimemethodhandle_tointptr);

			int counter = 0;

			Console.WriteLine($"GenerateStaticRegistrarMap: Adding {Types.Count} types and {Methods.Count} methods");

			var mapTypeToTokenMethod = class_type.Methods.Single(m => m.Name == "TryMapRuntimeTypeHandleToToken");
			mapTypeToTokenMethod.Body = new MethodBody(mapTypeToTokenMethod);
			var mapTypeToToken = mapTypeToTokenMethod.Body.GetILProcessor();

			var mapToMemberMethod = class_type.Methods.Single(m => m.Name == "TryMapTokenToMember");
			mapToMemberMethod.Body = new MethodBody(mapToMemberMethod);
			var mapToMember = mapToMemberMethod.Body.GetILProcessor();
			for (var i = 0; i < Types.Count; i++)
			{
				var token = 0x02000000 /* TypeDef */ | counter++;
				var type = Types[i];
				TypeReference tr = type;
				if (type.Module.Assembly != productAssembly)
					tr = productAssembly.MainModule.ImportReference(type);

				//
				// TryMapTokenToMember
				//
				var neqTarget = mapToMember.Create(OpCodes.Nop);
				// if (token_reference == <constant>) {
				mapToMember.Emit(OpCodes.Ldarg_0);
				mapToMember.Emit(OpCodes.Ldc_I4, token);
				mapToMember.Emit(OpCodes.Bne_Un, neqTarget);
				//     member = Type.GetTypeFromHandle (ldtoken <type>);
				mapToMember.Emit(OpCodes.Ldarg_1);
				mapToMember.Emit(OpCodes.Ldtoken, tr);
				mapToMember.Emit(OpCodes.Call, system_type_gettypefromhandle_ref);
				mapToMember.Emit(OpCodes.Stind_Ref);
				mapToMember.Emit(OpCodes.Ldc_I4_1);
				//     return;
				mapToMember.Emit(OpCodes.Ret);
				// }
				mapToMember.Append(neqTarget);

				//
				// TryMapRuntimeTypeHandleToToken
				//
				neqTarget = mapTypeToToken.Create(OpCodes.Nop);
				// if (runtimetypehandle.Equals (ldtoken <type>)) {
				mapTypeToToken.Emit(OpCodes.Ldarg_0);
				mapTypeToToken.Emit(OpCodes.Ldtoken, tr);
				mapTypeToToken.Emit(OpCodes.Call, system_runtimetypehandle_equals_ref);
				mapTypeToToken.Emit(OpCodes.Ldc_I4_1);
				mapTypeToToken.Emit(OpCodes.Bne_Un, neqTarget);
				//     token = <constant>;
				mapTypeToToken.Emit(OpCodes.Ldarg_1);
				mapTypeToToken.Emit(OpCodes.Ldc_I4, token);
				mapTypeToToken.Emit(OpCodes.Stind_Ref);
				//     return;
				mapTypeToToken.Emit(OpCodes.Ret);
				// } 
				mapTypeToToken.Append(neqTarget);
			}

			for (var i = 0; i < Methods.Count; i++)
			{
				var token = 0x06000000 /* Method */ | counter++;
				var method = Methods[i];
				MethodReference mr = method;
				if (method.Module.Assembly != productAssembly)
					mr = productAssembly.MainModule.ImportReference(method);

				//
				// TryMapTokenToMember
				//
				var neqTarget = mapToMember.Create(OpCodes.Nop);
				// if (token_reference == <constant>) {
				mapToMember.Emit(OpCodes.Ldarg_0);
				mapToMember.Emit(OpCodes.Ldc_I4, token);
				mapToMember.Emit(OpCodes.Bne_Un, neqTarget);
				mapToMember.Emit(OpCodes.Ldarg_1);
				mapToMember.Emit(OpCodes.Ldtoken, mr);
				//     member = MethodBase.GetMethodFromHandle (ldtoken <type>);
				mapToMember.Emit(OpCodes.Call, system_methodbase_getmethodfromhandle_ref);
				mapToMember.Emit(OpCodes.Stind_Ref);
				mapToMember.Emit(OpCodes.Ldc_I4_1);
				//     return;
				mapToMember.Emit(OpCodes.Ret);
				// }
				mapToMember.Append(neqTarget);
			}

			//
			// TryMapTokenToMember epilogue
			//
			//     member = null;
			mapToMember.Emit(OpCodes.Ldarg_1);
			mapToMember.Emit(OpCodes.Ldnull);
			mapToMember.Emit(OpCodes.Stind_Ref);
			mapToMember.Emit(OpCodes.Ldc_I4_0);
			//     return false;
			mapToMember.Emit(OpCodes.Ret);
			// }

			//
			// TryMapRuntimeTypeHandleToToken epilogue:
			//
			//     token = 0;
			mapTypeToToken.Emit(OpCodes.Ldarg_1);
			mapTypeToToken.Emit(OpCodes.Ldc_I4_0);
			mapTypeToToken.Emit(OpCodes.Stind_Ref);
			mapTypeToToken.Emit(OpCodes.Ldc_I4_0);
			//     return false;
			mapTypeToToken.Emit(OpCodes.Ret);
			// }

			Console.WriteLine($"GenerateStaticRegistrarMap: previons action: {Context.Annotations.GetAction(productAssembly)}");
			Context.Annotations.SetAction(productAssembly, Mono.Linker.AssemblyAction.Save);
		}
	}
}

