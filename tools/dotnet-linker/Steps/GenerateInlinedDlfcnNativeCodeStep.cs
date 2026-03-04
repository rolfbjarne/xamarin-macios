using System.Collections.Generic;
using System.IO;

using Xamarin.Bundler;
using Xamarin.Linker;

#nullable enable

namespace Xamarin.Linker.Steps;

// See docs/code/native-symbols.md for an overview of native symbol handling.
public class GenerateInlinedDlfcnNativeCodeStep : ConfigurationAwareStep {
	protected override string Name { get; } = "Generate Inlined Dlfcn Native Code";
	protected override int ErrorCode { get; } = 2360;

	protected override void TryEndProcess ()
	{
		base.TryEndProcess ();

		if (string.IsNullOrEmpty (Configuration.IntermediateOutputPath))
			return;

		// Merge all symbols from all assemblies into a single set to avoid duplicate native symbols.
		var allSymbols = new HashSet<string> ();
		foreach (var kvp in Configuration.InlinedDlfcnFields) {
			foreach (var symbol in kvp.Value)
				allSymbols.Add (symbol);
		}

		if (allSymbols.Count == 0)
			return;

		// Write the symbol list to a file for the PostTrimmingProcessing MSBuild task to consume.
		var dir = Path.Combine (Configuration.IntermediateOutputPath, "inlined-dlfcn");
		Directory.CreateDirectory (dir);
		var path = Path.Combine (dir, "inlined-dlfcn-symbols.txt");
		var sorted = new List<string> (allSymbols);
		sorted.Sort ();
		Driver.WriteIfDifferent (path, string.Join ("\n", sorted) + "\n");
	}
}
