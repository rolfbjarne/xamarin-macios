using System;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Linker;
using Mono.Tuner;
using MonoTouch.Tuner;

using Xamarin.Bundler;

namespace Xamarin.Linker {

	public class OptimizeBlockSetupStep : ExceptionalSubStep {

		public override SubStepTargets Targets {
			get { return SubStepTargets.Method; }
		}

		protected override string Name { get; } = " Block Setup Optimizer";
		protected override int ErrorCode { get; } = 2120; // FIXME: docs

		public override bool IsActiveFor(AssemblyDefinition assembly)
		{
			if (Profile.IsProductAssembly (assembly))
				return true;

			// We don't need to process assemblies that don't reference ObjCRuntime.BlockLiteral.
			foreach (var tr in assembly.MainModule.GetTypeReferences ()) {
				if (tr.IsPlatformType ("ObjCRuntime", "BlockLiteral"))
					return true;
			}

			return false;
		}

		protected override void Process (MethodDefinition method)
		{
			if (!method.HasBody)
				return;

			var instructions = method.Body.Instructions;
		}
	}
}
