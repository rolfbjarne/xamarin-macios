// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.IO;

using Mono.Cecil;
using Mono.Linker;

using Xamarin.Bundler;
using Xamarin.Linker;

namespace MonoTouch.Tuner {
	// Populate Application.Assemblies with the loaded assemblies.
	// This is needed so that steps like ComputeAOTArguments and GatherFrameworksStep
	// can find the assemblies they need to process.
	// This is equivalent to LoadNonSkippedAssembliesStep in the ILLink path.
	public class PopulateApplicationAssembliesStep : ConfigurationAwareStep {
		protected override string Name { get; } = "PopulateApplicationAssemblies";
		protected override int ErrorCode { get; } = 2520;

		protected override void TryProcessAssembly (AssemblyDefinition assembly)
		{
			var action = Context.Annotations.GetAction (assembly);
			switch (action) {
			case AssemblyAction.Delete:
			case AssemblyAction.Skip:
				break;
			default:
				var ad = Configuration.Application.AddAssembly (assembly);
				ad.FullPath = assembly.MainModule.FileName;
				break;
			}
		}
	}
}
