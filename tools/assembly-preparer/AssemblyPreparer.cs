using System.IO;
using System.Runtime.Serialization;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.CompilerServices.SymbolWriter;
using Mono.Linker;
using Mono.Linker.Steps;
using MonoTouch.Tuner;
using Xamarin.Bundler;
using Xamarin.Linker;
using Xamarin.Linker.Steps;
using Xamarin.Tuner;
using Xamarin.Utils;

namespace Xamarin.Build;

public class AssemblyPreparer : IDisposable {
	AggregateLog log = new AggregateLog ();

	LinkerConfiguration configuration;

	public string MakeReproPath { get; set; } = string.Empty;

	public RegistrarMode Registrar {
		get => configuration.Application.Registrar;
		set => configuration.Application.Registrar = value;
	}

	public string IntermediateOutputPath {
		get => configuration.IntermediateOutputPath;
	}

	public Optimizations Optimizations => configuration.Application.Optimizations;

	public List<AssemblyPreparerInfo> Assemblies { get; set; } = new List<AssemblyPreparerInfo> ();

	LinkerConfiguration.Configurator GetConfigurator (string? reproPath = null)
	{
		var dict = new LinkerConfiguration.Configurator () {
			{ "AssemblyPreparer", (
				new LinkerConfiguration.LoadValue ((key, value) => {
					var split = value.Split ('|');
					var input = split[0];
					var output = split[1];
					Assemblies.Add (new AssemblyPreparerInfo (input, output));	
				}),
				new LinkerConfiguration.SaveValue ((key, storage) => SaveAssemblies (key, storage, reproPath, Assemblies))
			)},
		};
		return dict;
	}

	static void SaveAssemblies (string key, List<string> storage, string? reproPath, IList<AssemblyPreparerInfo> assemblies)
	{
		foreach (var assembly in assemblies) {
			var input = assembly.InputPath;
			var output = assembly.OutputPath;
			if (!string.IsNullOrEmpty (reproPath)) {
				output = Path.Combine (reproPath, Path.GetFileName (output));
				File.Copy (input, output);
			}
			storage.Add ($"{key}: {input}|{output}");
		}
	}

	public AssemblyPreparer (AssemblyPreparerInfo [] assemblies, string linker_file)
	{
		var lines = File.ReadAllLines (linker_file).ToList ();
		SaveAssemblies ("AssemblyPreparer", lines, null, assemblies);
		configuration = new LinkerConfiguration (lines, linker_file, GetConfigurator ());
	}

	public void AddLog (IAssemblyPreparerLog log)
	{
		if (log is null)
			throw new ArgumentNullException (nameof (log));
		this.log.Add (log);
	}

	bool SaveToReproPath (List<ProductException> exceptions)
	{
		if (File.Exists (MakeReproPath) || Directory.Exists (MakeReproPath)) {
			exceptions.Add (ErrorHelper.CreateError (99, $"Repro location already exists: {MakeReproPath}"));
			return false;
		}
		Directory.CreateDirectory (MakeReproPath);
		var lines = new List<string> ();
		configuration.Save (lines, GetConfigurator (MakeReproPath));
		File.WriteAllLines (Path.Combine (MakeReproPath, "arguments.txt"), lines);
		log.Log ($"Created repro in {MakeReproPath}");

		return true;
	}

	public static AssemblyPreparer LoadFromReproPath (string reproPath)
	{
		var file = Path.Combine (reproPath, "arguments.txt");
		if (!File.Exists (file))
			throw new FileNotFoundException ($"Repro arguments file not found: {file}");
		return new AssemblyPreparer (Array.Empty<AssemblyPreparerInfo> (), file);
	}

	public bool Prepare (out List<ProductException> exceptions)
	{
		exceptions = configuration.Exceptions;

		if (Registrar == RegistrarMode.Default) {
			exceptions.Add (ErrorHelper.CreateError (99, "RegistrarMode must be explicitly set."));
			return false;
		}

		if (!string.IsNullOrEmpty (MakeReproPath) && !SaveToReproPath (exceptions))
			return false;

		var steps = new ConfigurationAwareStep [] {
			// All the same steps as the custom trimmer steps that are run before MarkStep in Xamarin.Shared.Sdk.targets (and in the same order).
			// CollectAssembliesStep
			new CoreTypeMapStep (),
			// ProcessExportedFields
			new PreserveProtocolsStep (),
			new PreserveSmartEnumConversionsStep (),
			new PreserveBlockCodeStep (),
			new OptimizeGeneratedCodeStep (),
			new ApplyPreserveAttributeStep (),
			new MarkForStaticRegistrarStep (),
			new MarkNSObjectsStep (),
			new InlineDlfcnMethodsStep (),
			new RegistrarRemovalTrackingStep (),
			// PreMarkDispatcher: we don't need this one
			// TODO new SetBeforeFieldInitStep (), // part of PreMarkDispatcher
			new ManagedRegistrarStep (),
			new TrimmableRegistrarStep (),
		};

		var linkContext = configuration.DerivedLinkContext;

		var parameters = new ReaderParameters {
			AssemblyResolver = configuration.AssemblyResolver,
			MetadataResolver = configuration.MetadataResolver,
			ReadSymbols = true,
			SymbolReaderProvider = new DefaultSymbolReaderProvider (throwIfNoSymbol: false),
		};

		foreach (var assembly in Assemblies) {
			var assemblyDefinition = AssemblyDefinition.ReadAssembly (assembly.InputPath, parameters); // FIXME: symbols
			linkContext.Assemblies.Add (assemblyDefinition);
			assembly.Assembly = assemblyDefinition;
			configuration.Context.Annotations.SetAction (assemblyDefinition, AssemblyAction.Copy);
			configuration.AssemblyResolver.ResolverCache.Add (assemblyDefinition.Name.Name, assemblyDefinition);
		}

		foreach (var step in steps) {
			step.Process (linkContext);
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
				log.Log ($"Saving {assembly.InputPath} to {assembly.OutputPath}");
				break;
			default:
				exceptions.Add (ErrorHelper.CreateError (99, $"Unknown link action: {action} for assembly {assemblyDefinition.Name}"));
				return false;
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
					log.Log ($"Failed to create symbol writer for {assembly.OutputPath}, not writing symbols: {e.Message}");
				}
			}
			try {
				assemblyDefinition.Write (assembly.OutputPath, writerParameters);
			} catch (Exception e) {
				exceptions.Add (ErrorHelper.CreateError (99, e, $"Failed to write {assembly.OutputPath}: {e.Message}"));
				log.Log ($"Failed to write {assembly.OutputPath}: {e}");
				return false;
			}
		}

		return exceptions.Count == 0;
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
