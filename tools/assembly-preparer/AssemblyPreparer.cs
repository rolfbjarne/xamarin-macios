using System;
using System.Collections.Generic;
using System.IO;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Linker;
using Xamarin.Bundler;
using Xamarin.Linker.Steps;
using Xamarin.Tuner;
using Xamarin.Utils;

namespace Xamarin.Build;

public class AssemblyPreparer : IDisposable {
	LinkerConfiguration configuration = new LinkerConfiguration ();

	public AssemblyPreparerInfo [] Assemblies { get; set; }

	public AssemblyPreparer (AssemblyPreparerInfo [] assemblies, string platform)
#if NET
	: this (assemblies, Enum.Parse<ApplePlatform> (platform, true))
#else
	: this (assemblies, (ApplePlatform) Enum.Parse (typeof (ApplePlatform), platform, true))
#endif
	{
	}

	public AssemblyPreparer (AssemblyPreparerInfo [] assemblies, ApplePlatform platform)
	{
		Assemblies = assemblies;
		configuration.Platform = platform;
	}

	public bool Prepare (out List<Exception> exceptions)
	{
		exceptions = new List<Exception> ();

		var markHandlers = new IMarkHandler [] {
			new PreserveBlockCodeHandler (),
		};

		var linkContext = new DerivedLinkContext (configuration);
		configuration.DerivedLinkContext = linkContext;

		var markContext = new MarkContext ();
		foreach (var handler in markHandlers) {
			handler.Initialize (linkContext, markContext);
		}

		// load assemblies

		var assemblyResolver = new DefaultAssemblyResolver ();
		// var metadataResolver = new DefaultMetadataResolver ();

		var parameters = new ReaderParameters {
				AssemblyResolver = assemblyResolver,
				// MetadataResolver = metadataResolver,
				ReadSymbols = true,
				SymbolReaderProvider = new DefaultSymbolReaderProvider (throwIfNoSymbol: false),
		};
		foreach (var assembly in Assemblies) {
			var assemblyDefinition = AssemblyDefinition.ReadAssembly (assembly.InputPath, parameters); // FIXME: symbols
			linkContext.Assemblies.Add (assemblyDefinition);
			assembly.Assembly = assemblyDefinition;
			configuration.Context.Annotations.SetAction (assemblyDefinition, AssemblyAction.Copy);
		}

		foreach (var assembly in linkContext.GetAssemblies ()) {
			//assembly.MainModule.ReadSymbols ();
			foreach (var type in assembly.MainModule.Types) {
				markContext.MarkType (type);
			}
		}

		// save assemblies

		foreach (var assembly in Assemblies) {
			var assemblyDefinition = assembly.Assembly!;

		var action = configuration.Context.Annotations.GetAction (assemblyDefinition);
		switch (action) {
			case AssemblyAction.Copy:
				// FIXME: optimization if nothing changed: don't copy
				Console.WriteLine ($"No modifications to {assembly.InputPath}, so copying input assembly.");
				File.Copy (assembly.InputPath, assembly.OutputPath, true);
				if (assemblyDefinition.MainModule.HasSymbols) {
					// Copy the symbols too
					var symbolPath = Path.ChangeExtension (assembly.OutputPath, ".pdb");
					File.Copy (assembly.InputPath + ".pdb", symbolPath, true);
				}
				break;
			case AssemblyAction.Link:
			case AssemblyAction.Save:
				Console.WriteLine ($"Saving {assembly.InputPath} to {assembly.OutputPath}");
				break;
			default:
			throw new NotImplementedException ($"Unknown link action: {action}");
		}

			Directory.CreateDirectory (Path.GetDirectoryName (assembly.OutputPath)!);
			var writerParameters = new WriterParameters ();
			if (assemblyDefinition.MainModule.HasSymbols) {
				writerParameters.WriteSymbols = true;
				writerParameters.SymbolWriterProvider = new DefaultSymbolWriterProvider ();
			}
			assemblyDefinition.Write (assembly.OutputPath, writerParameters);
		}

		return true;
	}

	public void Dispose ()
	{
		foreach (var assembly in Assemblies)
			assembly.Assembly?.Dispose ();
	}
}

public class AssemblyPreparerInfo {
	internal AssemblyDefinition? Assembly { get; set; }

	public string InputPath { get; private set; }
	public string OutputPath { get; private set; }

	public AssemblyPreparerInfo (string inputPath, string outputPath)
	{
		InputPath = inputPath;
		OutputPath = outputPath;
	}
}
