using System;
using System.Linq;

using Mono.Cecil;

using Mono.Linker.Steps;
using Mono.Tuner;

using Xamarin.Bundler;

namespace Xamarin.Linker.Steps {
	public class InjectDynamicDependencyStep : ConfigurationAwareSubStep {
		MethodDefinition ctor_string_def;
		MethodReference ctor_string_ref;

		public override SubStepTargets Targets {
			get {
				return SubStepTargets.Assembly |
						SubStepTargets.Field |
						SubStepTargets.Type;
			}
		}

		MethodReference GetConstructorReference (AssemblyDefinition assembly)
		{
			if (ctor_string_def == null) {
				// Find the method definition for the constructor we want to use
				foreach (var asm in Configuration.Assemblies) {
					var dependencyAttribute = asm.MainModule.GetType ("System.Diagnostics.CodeAnalysis.DynamicDependencyAttribute");
					if (dependencyAttribute == null)
						continue;

					foreach (var method in dependencyAttribute.Methods) {
						if (!method.HasParameters)
							continue;

						if (method.Parameters.Count == 1 && method.Parameters [0].ParameterType.Is ("System", "String")) {
							ctor_string_def = method;
							break;
						}
					}

					break;
				}

				if (ctor_string_def == null)
					throw ErrorHelper.CreateError (99, Errors.MX0099, "Could not find the constructor 'System.Diagnostics.CodeAnalysis.DynamicDependencyAttribute..ctor(System.String)'");
			}

			// Import the constructor into the current assembly if it hasn't already been imported
			ctor_string_ref ??= assembly.MainModule.ImportReference (ctor_string_def);

			return ctor_string_ref;
		}

		public override void ProcessAssembly (AssemblyDefinition assembly)
		{
			// Clear out the method reference we have, so that we import the method definition again
			ctor_string_ref = null;

			base.ProcessAssembly (assembly);
		}

		public override void ProcessField (FieldDefinition field)
		{
			base.ProcessField (field);

			PreserveBlockField (field);
		}

		void PreserveBlockField (FieldDefinition field)
		{
			/* For the following class:

			static internal class SDInnerBlock {
				// this field is not preserved by other means, but it must not be linked away
				static internal readonly DInnerBlock Handler = Invoke;

				[MonoPInvokeCallback (typeof (DInnerBlock))]
				static internal void Invoke (IntPtr block, int magic_number)
				{
				}
			}

			We need to make sure the linker doesn't remove the Handler field. Unfortunately there's no programmatic way to
			preserve a field dependent upon the preservation of the containing type, so we have to inject a DynamicDependency attribute.
			Our generator generates this attribute, but since we have to work with existing assemblies, we also detect the scenario
			here and inject the attribute manually.

			*/

			// First filter out any other fields
			var td = field.DeclaringType;
			if (!td.IsAbstract || !td.IsSealed || !td.IsNested)
				return;
			if (td.Fields.Count != 1)
				return;

			var nestingType = td.DeclaringType;
			if (nestingType == null)
				return;
			if (!nestingType.Is ("ObjCRuntime", "Trampolines"))
				return;


			if (!field.IsInitOnly)
				return;
			if (field.Name != "Handler")
				return;


			// One problem is that we can't add the DynamicDependency attribute to the type, nor the field itself,
			// so we add it to the Invoke method in the same type.
			if (!td.HasMethods)
				return;

			var method = td.Methods.SingleOrDefault (v => {
				if (v.Name != "Invoke")
					return false;
				if (v.Parameters.Count == 0)
					return false;
				if (!v.HasCustomAttributes)
					return false;
				if (!v.CustomAttributes.Any (v => v.AttributeType.Name == "MonoPInvokeCallbackAttribute"))
					return false;
				return true;
			});
			if (method == null)
				return;

			// Create and add the DynamicDependency attribute to the method
			var ctor = GetConstructorReference (field.DeclaringType.Module.Assembly);
			var attrib = new CustomAttribute (ctor);
			attrib.ConstructorArguments.Add (new CustomAttributeArgument (ctor.Parameters [0].ParameterType, "Handler"));
			method.CustomAttributes.Add (attrib);
		}
	}
}
