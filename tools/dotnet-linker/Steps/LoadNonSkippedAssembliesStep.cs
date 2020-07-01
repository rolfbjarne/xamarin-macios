using System;

using Mono.Cecil;
using Mono.Linker;

namespace Xamarin.Linker {
	// List all the assemblies we care about (i.e. the ones that have not been linked away)
	public class LoadNonSkippedAssembliesStep : ConfigurationAwareStep {

		protected override void ProcessAssembly (AssemblyDefinition assembly)
		{
			base.ProcessAssembly (assembly);

			// Figure out if an assembly is linked away or not
			if (Context.Annotations.HasAction (assembly)) {
				var action = Context.Annotations.GetAction (assembly);
				switch (action) {
				case AssemblyAction.Delete:
				case AssemblyAction.Skip:
					break;
				case AssemblyAction.Copy:
				case AssemblyAction.CopyUsed:
				case AssemblyAction.Link:
				case AssemblyAction.Save:
					var assemblyFileName = Configuration.GetAssemblyFileName (assembly);
					Console.WriteLine ("LOG: {0} for {1}: {2}", action, assembly.Name.Name, assemblyFileName);
					var ad = Configuration.Target.AddAssembly (assembly);
					ad.FullPath = assemblyFileName;
					Console.WriteLine ("    {0} => {1}", ad.FullPath, ad.Identity);
					break;
				case AssemblyAction.AddBypassNGen: // This should be turned into Save or Delete
				case AssemblyAction.AddBypassNGenUsed: // This should be turned into Save or Delete
					Console.WriteLine ("WARNING: unsupported action {0} for {1}", action, assembly.FullName);
					break;
				default:
					Console.WriteLine ("WARNING: unknown action {0} for {1}", action, assembly.FullName);
					break;
				}
			} else {
				Console.WriteLine ("WARNING: assembly without action: {0}", assembly.FullName);
			}
		}
	}
}
