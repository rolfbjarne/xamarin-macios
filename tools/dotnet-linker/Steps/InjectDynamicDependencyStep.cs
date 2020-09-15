using System;
using System.Linq;

using Mono.Cecil;

using Mono.Linker.Steps;
using Mono.Tuner;

namespace Xamarin.Linker.Steps {
	public class InjectDynamicDependencyStep : ConfigurationAwareSubStep {
		MethodDefinition dynamic_dependency_ctor_string;
		MethodDefinition dynamic_dependency_ctor_enum_type;

		MethodReference dynamic_dependency_ctor_string_mr;
		MethodReference dynamic_dependency_ctor_enum_type_mr;

		public override bool IsActiveFor (AssemblyDefinition assembly)
		{
			return base.IsActiveFor (assembly);
		}

		public override SubStepTargets Targets {
			get {
				return SubStepTargets.Method |
						SubStepTargets.Assembly |
						SubStepTargets.Type;
			}
		}

		void FetchMethodDefinitions (AssemblyDefinition assembly)
		{
			if (dynamic_dependency_ctor_string == null) {
				foreach (var asm in Configuration.Assemblies) {
					var dependencyAttribute = asm.MainModule.GetType ("System.Diagnostics.CodeAnalysis.DynamicDependencyAttribute");
					if (dependencyAttribute == null)
						continue;

					foreach (var method in dependencyAttribute.Methods) {
						if (!method.HasParameters)
							continue;

						if (method.Parameters.Count == 1 && method.Parameters [0].ParameterType.Is ("System", "String")) {
							dynamic_dependency_ctor_string = method;
						} else if (method.Parameters.Count == 2 && method.Parameters [0].ParameterType.Is ("System.Diagnostics.CodeAnalysis", "DynamicallyAccessedMemberTypes") && method.Parameters [1].ParameterType.Is ("System", "Type")) {
							dynamic_dependency_ctor_enum_type = method;
						}
					}

					break;
				}

				if (dynamic_dependency_ctor_string == null)
					throw new NotImplementedException ("Method ctor string not found");
				if (dynamic_dependency_ctor_enum_type == null)
					throw new NotImplementedException ("Method ctor enum type not found");
			}
			if (dynamic_dependency_ctor_string_mr == null)
				dynamic_dependency_ctor_string_mr = assembly.MainModule.ImportReference (dynamic_dependency_ctor_string);
			if (dynamic_dependency_ctor_enum_type_mr == null)
				dynamic_dependency_ctor_enum_type_mr = assembly.MainModule.ImportReference (dynamic_dependency_ctor_enum_type);
		}

		public override void ProcessAssembly (AssemblyDefinition assembly)
		{
			base.ProcessAssembly (assembly);

			dynamic_dependency_ctor_enum_type_mr = null;
			dynamic_dependency_ctor_string_mr = null;

			Console.WriteLine ("InjectDynamicDependencyStep.ProcessAssembly {0}", assembly.Name.Name);
		}

		public override void ProcessMethod (MethodDefinition method)
		{
			base.ProcessMethod (method);

			//Console.WriteLine ("InjectDynamicDependencyStep.ProcessMethod {0}", method.FullName);

			// Find the attributes we want to inject
			if (method.DeclaringType.Is ("System.Diagnostics.CodeAnalysis", "DynamicDependencyAttribute") && method.HasParameters) {
				if (method.Parameters.Count == 1 && method.Parameters [0].ParameterType.Is ("System", "String")) {
					dynamic_dependency_ctor_string = method;
				} else if (method.Parameters.Count == 2 && method.Parameters [0].ParameterType.Is ("System.Diagnostics.CodeAnalysis", "DynamicallyAccessedMemberTypes") && method.Parameters [1].ParameterType.Is ("System", "Type")) {
					dynamic_dependency_ctor_enum_type = method;
				}
			}

			// Methods with [return: DelegateProxy (typeof (...))]
			if (method.MethodReturnType.HasCustomAttributes) {
				var delegateProxyAttribute = method.MethodReturnType.CustomAttributes.FirstOrDefault (v => v.AttributeType.Is ("ObjCRuntime", "DelegateProxyAttribute"));
				if (delegateProxyAttribute != null) {
					FetchMethodDefinitions (method.DeclaringType.Module.Assembly);
					var attrib = new CustomAttribute (dynamic_dependency_ctor_enum_type_mr);
					attrib.ConstructorArguments.Add (new CustomAttributeArgument (dynamic_dependency_ctor_enum_type_mr.Parameters [0].ParameterType, System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.All));
					attrib.ConstructorArguments.Add (new CustomAttributeArgument (dynamic_dependency_ctor_enum_type_mr.Parameters [1].ParameterType, delegateProxyAttribute.ConstructorArguments [0].Value));
					method.CustomAttributes.Add (attrib);
					Console.WriteLine ("Added dynamic attribute (1) to: {0}", method.FullName);
				}
			}

			/*
			 * 
				// older generated bindings did not preserve the `Handler` field and
				// newer (mono 2019-02) linker can optimize them (enabled by default)
				// so we make sure our old bindings remains linker-safe
				if (td.IsAbstract && td.IsSealed && td.IsNested && td.HasFields) {
					var dt = td.DeclaringType;
					if (dt.Is ("ObjCRuntime", "Trampolines")) {
						var f = td.Fields [0];
						if (f.IsInitOnly && td.Fields.Count == 1 && f.Name == "Handler")
							MarkField (f);
					}
				}
			*/
			if (method.HasCustomAttributes) {
				var monoPInvokeCallbackAttribute = method.CustomAttributes.FirstOrDefault (v => v.AttributeType.Is ("ObjCRuntime", "MonoPInvokeCallbackAttribute"));
				if (monoPInvokeCallbackAttribute != null) {
					var td = method.DeclaringType;
					if (td.IsAbstract && td.IsSealed && td.IsNested && td.HasFields && td.HasFields && td.Fields.Count == 1 && td.DeclaringType.Is ("ObjCRuntime", "Trampolines")) {
						var handlerField = td.Fields [0];
						if (handlerField.IsInitOnly && handlerField.Name == "Handler") {
							FetchMethodDefinitions (method.DeclaringType.Module.Assembly);
							var attrib = new CustomAttribute (dynamic_dependency_ctor_string);
							attrib.ConstructorArguments.Add (new CustomAttributeArgument (dynamic_dependency_ctor_string.Parameters [0].ParameterType, "Handler"));
							method.CustomAttributes.Add (attrib);
							Console.WriteLine ("Added dynamic attribute (2) to: {0}", method.FullName);
						}
					}
				}
			}
		}
	}
}

