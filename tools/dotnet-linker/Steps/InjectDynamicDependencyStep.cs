using System;
using System.Linq;

using Mono.Cecil;

using Mono.Linker.Steps;
using Mono.Tuner;

using Xamarin.Bundler;

namespace Xamarin.Linker.Steps {
	public class InjectDynamicDependencyStep : ConfigurationAwareSubStep {
		MethodDefinition ctor_string;
		MethodDefinition ctor_enum_type;

		MethodReference ctor_string_ref;
		MethodReference ctor_enum_type_ref;

		public override SubStepTargets Targets {
			get {
				return SubStepTargets.Method |
						SubStepTargets.Assembly;
			}
		}

		void FetchMethodDefinitions (AssemblyDefinition assembly)
		{
			if (ctor_string == null) {
				// Find the method definitions for the constructors we want to use
				foreach (var asm in Configuration.Assemblies) {
					var dependencyAttribute = asm.MainModule.GetType ("System.Diagnostics.CodeAnalysis.DynamicDependencyAttribute");
					if (dependencyAttribute == null)
						continue;

					foreach (var method in dependencyAttribute.Methods) {
						if (!method.HasParameters)
							continue;

						if (method.Parameters.Count == 1) {
							if (method.Parameters [0].ParameterType.Is ("System", "String"))
								ctor_string = method;
						} else if (method.Parameters.Count == 2) {
							if (method.Parameters [0].ParameterType.Is ("System.Diagnostics.CodeAnalysis", "DynamicallyAccessedMemberTypes") && method.Parameters [1].ParameterType.Is ("System", "Type"))
								ctor_enum_type = method;
						}

						if (ctor_enum_type != null && ctor_string != null)
							break; // Found both of the methods we're looking for, no need to look any longer
					}

					break;
				}

				if (ctor_string == null)
					throw ErrorHelper.CreateError (99, Errors.MX0099, "Could not find the constructor 'System.Diagnostics.CodeAnalysis.DynamicDependencyAttribute..ctor(System.String)'");
				if (ctor_enum_type == null)
					throw ErrorHelper.CreateError (99, Errors.MX0099, "Could not find the constructor 'System.Diagnostics.CodeAnalysis.DynamicDependencyAttribute..ctor(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes,System.Type)'");
			}

			// Import the constructors into the current assembly if they haven't already been imported
			ctor_string_ref ??= assembly.MainModule.ImportReference (ctor_string);
			ctor_enum_type_ref ??= assembly.MainModule.ImportReference (ctor_enum_type);
		}

		public override void ProcessAssembly (AssemblyDefinition assembly)
		{
			// Clear out the method references we have, so that the we import the method definitions again
			ctor_enum_type_ref = null;
			ctor_string_ref = null;

			base.ProcessAssembly (assembly);
		}

		public override void ProcessMethod (MethodDefinition method)
		{
			base.ProcessMethod (method);

			// Methods with [return: DelegateProxy (typeof (...))]
			// Add the following attribute to any method that has a DelegateProxy return type attribute:
			//     [DynamicDependency (DynamicallyAccessedMemberTypes.All, typeof (SomeType))]
			// This DynamicDependency attribute makes sure the linker doesn't link away anything from SomeType (in particular SomeType.Handler)
			if (method.MethodReturnType.HasCustomAttributes) {
				var delegateProxyAttribute = method.MethodReturnType.CustomAttributes.FirstOrDefault (v => v.AttributeType.Is ("ObjCRuntime", "DelegateProxyAttribute"));
				if (delegateProxyAttribute != null) {
					FetchMethodDefinitions (method.DeclaringType.Module.Assembly);
					var attrib = new CustomAttribute (ctor_enum_type_ref);
					attrib.ConstructorArguments.Add (new CustomAttributeArgument (ctor_enum_type_ref.Parameters [0].ParameterType, System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.All));
					attrib.ConstructorArguments.Add (new CustomAttributeArgument (ctor_enum_type_ref.Parameters [1].ParameterType, delegateProxyAttribute.ConstructorArguments [0].Value));
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
			//if (method.HasCustomAttributes) {
			//	var monoPInvokeCallbackAttribute = method.CustomAttributes.FirstOrDefault (v => v.AttributeType.Is ("ObjCRuntime", "MonoPInvokeCallbackAttribute"));
			//	if (monoPInvokeCallbackAttribute != null) {
			//		var td = method.DeclaringType;
			//		if (td.IsAbstract && td.IsSealed && td.IsNested && td.HasFields && td.HasFields && td.Fields.Count == 1 && td.DeclaringType.Is ("ObjCRuntime", "Trampolines")) {
			//			var handlerField = td.Fields [0];
			//			if (handlerField.IsInitOnly && handlerField.Name == "Handler") {
			//				FetchMethodDefinitions (method.DeclaringType.Module.Assembly);
			//				var attrib = new CustomAttribute (ctor_string);
			//				attrib.ConstructorArguments.Add (new CustomAttributeArgument (ctor_string.Parameters [0].ParameterType, "Handler"));
			//				method.CustomAttributes.Add (attrib);
			//				Console.WriteLine ("Added dynamic attribute (2) to: {0}", method.FullName);
			//			}
			//		}
			//	}
			//}
		}
	}
}

