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

			if (assembly.Name.Name == base.Configuration.PlatformAssembly)
				productAssembly = assembly;
			else if (assembly.Name.Name == Driver.CorlibName)
				corlibAssembly = assembly;

			if (!assembly.MainModule.HasTypes)
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

			var runtime_type = productAssembly!.MainModule.Types.First(v => v.Is("ObjCRuntime", "Class"));

			var system_type = corlibAssembly!.MainModule.Types.First(v => v.Is("System", "Type"));
			var system_type_gettype = system_type.Methods.First(v => v.Name == "GetType" && v.HasParameters && v.Parameters.Count == 1 && v.Parameters[0].ParameterType.Is("System", "String"));
			var gettype_ref = runtime_type.Module.ImportReference(system_type_gettype);

			var system_runtimemethodhandle = corlibAssembly.MainModule.Types.First(v => v.Is("System", "RuntimeMethodHandle"));
			var system_runtimemethodhandle_tointptr = system_runtimemethodhandle.Methods.Single(v => v.Name == "ToIntPtr");
			var system_runtimemethodhandle_tointptr_ref = runtime_type.Module.ImportReference(system_runtimemethodhandle_tointptr);

			long counter = 0;

			Console.WriteLine($"GenerateStaticRegistrarMap: Adding {Types.Count} types and {Methods.Count} methods");

			{
				var resolveMethod = runtime_type.Methods.Single(m => m.Name == "TryResolveTypeTokenReferenceUsingReflection");
				var body = new MethodBody(resolveMethod);
				var il = body.GetILProcessor();
				for (var i = 0; i < Types.Count; i++)
				{
					var token = counter++;
					var type = Types[i];
					TypeReference tr = type;
					if (type.Module.Assembly != productAssembly)
						tr = productAssembly.MainModule.ImportReference(type);

					var neqTarget = il.Create(OpCodes.Nop);
					il.Emit(OpCodes.Ldarg_0);
					il.Emit(OpCodes.Ldc_I4, unchecked((int)token));
					il.Emit(OpCodes.Bne_Un, neqTarget);
					il.Emit(OpCodes.Ldarg_1);
					il.Emit(OpCodes.Ldstr, $"{tr.FullName}, {tr.Module.Assembly.Name.FullName}");
					il.Emit(OpCodes.Call, gettype_ref);
					il.Emit(OpCodes.Stind_Ref);
					il.Emit(OpCodes.Ldc_I4_1);
					il.Emit(OpCodes.Ret);
					il.Append(neqTarget);

				}
				il.Emit(OpCodes.Ldarg_1);
				il.Emit(OpCodes.Ldnull);
				il.Emit(OpCodes.Stind_Ref);
				il.Emit(OpCodes.Ldc_I4_0);
				il.Emit(OpCodes.Ret);
				resolveMethod.Body = body;
			}

			{
				var resolveMethod = runtime_type.Methods.Single(m => m.Name == "TryResolveMethodTokenReferenceUsingReflection");
				var body = new MethodBody(resolveMethod);
				var il = body.GetILProcessor();
				for (var i = 0; i < Methods.Count; i++)
				{
					var token = counter++;
					var method = Methods[i];
					MethodReference mr = method;
					if (method.Module.Assembly != productAssembly)
						mr = productAssembly.MainModule.ImportReference(method);

					var neqTarget = il.Create(OpCodes.Nop);
					il.Emit(OpCodes.Ldarg_0);
					il.Emit(OpCodes.Ldc_I4, unchecked((int)token));
					il.Emit(OpCodes.Bne_Un, neqTarget);
					il.Emit(OpCodes.Ldarg_1);
					il.Emit(OpCodes.Ldtoken, mr);
					il.Emit(OpCodes.Call, system_runtimemethodhandle_tointptr_ref);
					il.Emit(OpCodes.Stind_Ref);
					il.Emit(OpCodes.Ldc_I4_1);
					il.Emit(OpCodes.Ret);
					il.Append(neqTarget);

				}
				il.Emit(OpCodes.Ldarg_1);
				il.Emit(OpCodes.Ldnull);
				il.Emit(OpCodes.Stind_Ref);
				il.Emit(OpCodes.Ldc_I4_0);
				il.Emit(OpCodes.Ret);
				resolveMethod.Body = body;
			}

			Console.WriteLine($"GenerateStaticRegistrarMap: previons action: {Context.Annotations.GetAction(productAssembly)}");
			Context.Annotations.SetAction(productAssembly, Mono.Linker.AssemblyAction.Save);
		}
	}
}

