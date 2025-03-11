using System.IO;
using System.Runtime.Serialization;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Linker;
using Xamarin.Bundler;
using Xamarin.Linker.Steps;
using Xamarin.Tuner;
using Xamarin.Utils;

namespace Xamarin.Build;

public class AssemblyPreparer : IDisposable {
	AggregateLog log = new AggregateLog ();

	LinkerConfiguration configuration = new LinkerConfiguration ();

	public string MakeReproPath { get; set; } = string.Empty;

	public AssemblyPreparerInfo [] Assemblies { get; set; }

	public AssemblyPreparer (AssemblyPreparerInfo [] assemblies, ApplePlatform platform)
	{
		Assemblies = assemblies;
		configuration.Platform = platform;
		ErrorHelper.Platform = platform;
	}

	public void AddLog (IAssemblyPreparerLog log)
	{
		if (log is null)
			throw new ArgumentNullException (nameof (log));
		this.log.Add (log);
	}

	public bool Prepare (out List<ProductException> exceptions)
	{
		exceptions = configuration.Exceptions;

		if (!string.IsNullOrEmpty (MakeReproPath)) {
			if (File.Exists (MakeReproPath) || Directory.Exists (MakeReproPath)) {
				configuration.Exceptions.Add (ErrorHelper.CreateError (99, $"Repro location already exists: {MakeReproPath}"));
				return false;
			}
			Directory.CreateDirectory (MakeReproPath);
			var lines = new List<string> ();
			lines.Add ($"Platform: {configuration.Platform}");
			foreach (var assembly in Assemblies) {
				lines.Add ($"Assembly: {Path.GetFileName (assembly.InputPath)}");
				File.Copy (assembly.InputPath, Path.Combine (MakeReproPath, Path.GetFileName (assembly.InputPath)));
			}
			File.WriteAllLines (Path.Combine (MakeReproPath, "arguments.txt"), lines);
			log.Log ($"Created repro in {MakeReproPath}");
		}

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
			// Skip SDK asemblies, they have nothing we need to process at the moment.
			if (!assembly.MainModule.HasAssemblyReferences)
				continue;
			if (!configuration.IsProductAssembly (assembly) && !assembly.MainModule.AssemblyReferences.Any (v => configuration.IsProductAssembly (v.Name)))
				continue;

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
				assembly.OutputPath = assembly.InputPath;
				continue;
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
				var provider = new CustomSymbolWriterProvider ();
				try {
					using (var tmp = provider.GetSymbolWriter (assemblyDefinition.MainModule, Path.ChangeExtension (assembly.OutputPath, ".pdb"))) { }
					File.Delete (Path.ChangeExtension (assembly.OutputPath, ".pdb"));
					writerParameters.WriteSymbols = true;
					writerParameters.SymbolWriterProvider = provider;
				} catch (Exception e) {
					Console.WriteLine ($"Failed to create symbol writer for {assembly.OutputPath}, not writing symbols: {e.Message}");
				}
			}
			try {
				assemblyDefinition.Write (assembly.OutputPath, writerParameters);
			} catch (Exception e) {
				Console.WriteLine ($"Failed to write {assembly.OutputPath}: {e}");
				throw;
			}
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
	public string OutputPath { get; set; }

	public AssemblyPreparerInfo (string inputPath, string outputPath)
	{
		InputPath = inputPath;
		OutputPath = outputPath;
	}
}
