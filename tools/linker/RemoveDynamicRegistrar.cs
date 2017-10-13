using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Mono.Linker;
using Mono.Linker.Steps;

using Mono.Cecil;
using Mono.Cecil.Cil;

using Xamarin.Bundler;
using Xamarin.Linker;
using Xamarin.Tuner;

namespace Mono.Tuner
{

	public class RemoveDynamicRegistrar : BaseStep
	{
		bool uses_runtime_connectmethod;
		AssemblyDefinition product_assembly;

		DerivedLinkContext LinkContext {
			get {
				return (DerivedLinkContext) base.Context;
			}
		}

		protected override void ProcessAssembly (AssemblyDefinition assembly)
		{
			Console.WriteLine ($"Processing {assembly.MainModule.FullyQualifiedName}");
			if (uses_runtime_connectmethod)
				return;

#if MONOMAC && !XAMCORE_2_0
			// Disable removing the dynamic registrar for XM/Classic to simplify the code a little bit.
			uses_runtime_connectmethod = true;
#endif

			if (LinkContext.Target.App.Registrar != Xamarin.Bundler.RegistrarMode.Static) {
				uses_runtime_connectmethod = true;
				return;
			}

			if (Profile.IsProductAssembly (assembly) || Profile.IsSdkAssembly (assembly)) {
				// We know that the assemblies we ship don't use Runtime.ConnectMethod.
				if (assembly.FullName == LinkContext.Target.ProductAssembly.FullName)
					product_assembly = assembly;
				return;
			}

			// Check if the assembly is referencing our product assembly.
			var hasProductReference = false;
			foreach (var ar in assembly.MainModule.AssemblyReferences) {
				if (Profile.IsProductAssembly (ar.Name)) {
					hasProductReference = true;
					break;
				}
			}
			if (!hasProductReference)
				return;

			foreach (var mr in assembly.MainModule.GetMemberReferences ()) {
				if (mr.Name != "ConnectMethod")
					continue;
				if (mr.DeclaringType == null)
					continue;
				if (mr.DeclaringType.Name != "Runtime")
					continue;
				if (mr.DeclaringType.Namespace != "ObjCRuntime")
					continue;
				if (!Profile.IsProductAssembly (mr.Module.Assembly))
					continue;
				uses_runtime_connectmethod = true;
				break;
			}
		}


		protected override void EndProcess ()
		{
			if (uses_runtime_connectmethod)
				return;
			
			if (product_assembly == null)
				return; // huh? this shouldn't happen

			var runtime_type = product_assembly.MainModule.GetType ("ObjCRuntime", "Runtime");
			ProcessMethods (runtime_type.Methods.Where ((v) => v.Name == "RegisterDelegates"));
			ProcessMethods (runtime_type.Methods.Where ((v) => v.Name == "Initialize"));

			var get_DynamicRegistrationSupported = runtime_type.Methods.First ((v) => v.Name == "get_DynamicRegistrationSupported");
			var instructions = get_DynamicRegistrationSupported.Body.Instructions;
			instructions.Clear ();
			instructions.Add (Instruction.Create (OpCodes.Ldc_I4_0));
			instructions.Add (Instruction.Create (OpCodes.Ret));

			var class_type = product_assembly.MainModule.GetType ("ObjCRuntime", "Class");
			ProcessMethods (class_type.Methods.Where ((v) => v.Name == "GetClassHandle"));
			ProcessMethods (class_type.Methods.Where ((v) => v.Name == "LookupClass"));
			ProcessMethods (class_type.Methods.Where ((v) => v.Name == "IsCustomType"));
		}

		void ProcessMethods (IEnumerable<MethodDefinition> methods)
		{
			foreach (var method in methods)
				ProcessMethod (method);
		}

		void ProcessMethod (MethodDefinition method)
		{
			// Remove the call to get_DynamicRegistrationSupported and the subsequent if block
			// The linker will then remove the RegisterDelegatesDynamic method (since nothing calls it).
			var instructions = method.Body.Instructions;
			var type = method.DeclaringType;
			for (int i = 0; i < instructions.Count; i++) {
				var ins = instructions [i];
				if (ins.OpCode.Code != Code.Call)
					continue;
				var mr = (MethodReference) ins.Operand;
				if (mr.Name != "get_DynamicRegistrationSupported")
					continue;
				if (!mr.DeclaringType.Is ("ObjCRuntime", "Runtime"))
					continue;
				// A few consistency checks...
				if (ins.Next == null) {
					Driver.Log (1, "Unexpected code sequence when trying to remove the dynamic registrar in {1}: expected brfalse, got no more instructions", method);
					return;
				} else if (ins.Next.OpCode.Code != Code.Brfalse) {
					Driver.Log (1, "Unexpected code sequence when trying to remove the dynamic registrar in {1}: expected brfalse, got {0}", ins.Next?.OpCode, method);
					return;
				}
				var removeUntil = (Instruction) ins.Next.Operand;
				var previous = ins.Previous;
				while (previous.Next != removeUntil)
					instructions.Remove (previous.Next);
				Driver.Log (1, "Linked away dynamic code in {0}.", method);
				return;
			}
			Driver.Log (1, "Failed to link dynamic code in {0}: no call to get_DynamicRegistrationSupported.", method);
		}
	}
}
