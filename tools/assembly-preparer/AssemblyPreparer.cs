using System.IO;
using System.Runtime.Serialization;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.CompilerServices.SymbolWriter;
using Mono.Linker;
using Mono.Linker.Steps;
using MonoTouch.Tuner;
using Xamarin.Bundler;
using Xamarin.Linker.Steps;
using Xamarin.Tuner;
using Xamarin.Utils;

namespace Xamarin.Build;

public class AssemblyPreparer : IDisposable {
	AggregateLog log = new AggregateLog ();

	LinkerConfiguration configuration = new LinkerConfiguration ();

	public string MakeReproPath { get; set; } = string.Empty;

	public RegistrarMode Registrar {
		get => configuration.App.Registrar;
		set => configuration.App.Registrar = value;
	}

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

	bool SaveToReproPath (List<ProductException> exceptions)
	{
		if (File.Exists (MakeReproPath) || Directory.Exists (MakeReproPath)) {
			exceptions.Add (ErrorHelper.CreateError (99, $"Repro location already exists: {MakeReproPath}"));
			return false;
		}
		Directory.CreateDirectory (MakeReproPath);
		var lines = new List<string> ();
		lines.Add ($"Platform: {configuration.Platform}");
		lines.Add ($"Registrar: {configuration.Registrar}");
		foreach (var assembly in Assemblies) {
			lines.Add ($"Assembly: {Path.GetFileName (assembly.InputPath)}");
			File.Copy (assembly.InputPath, Path.Combine (MakeReproPath, Path.GetFileName (assembly.InputPath)));
		}
		File.WriteAllLines (Path.Combine (MakeReproPath, "arguments.txt"), lines);
		log.Log ($"Created repro in {MakeReproPath}");

		return true;
	}

	public static AssemblyPreparer LoadFromReproPath (string reproPath)
	{
		var file = Path.Combine (reproPath, "arguments.txt");
		if (!File.Exists (file))
			throw new FileNotFoundException ($"Repro arguments file not found: {file}");

		var lines = File.ReadAllLines (file);
		ApplePlatform? platform = null;
		string? registrar = null;
		var assemblies = new List<AssemblyPreparerInfo> ();
		foreach (var line in lines) {
			if (line.StartsWith ("Platform: ")) {
				var platformStr = line.Substring ("Platform: ".Length);
#if NET
				platform = Enum.Parse<ApplePlatform> (platformStr);
#else
				platform = (ApplePlatform) Enum.Parse (typeof (ApplePlatform), platformStr);
#endif
			} else if (line.StartsWith ("Registrar: ")) {
				registrar = line.Substring ("Registrar: ".Length);
			} else if (line.StartsWith ("Assembly: ")) {
				var assembly = line.Substring ("Assembly: ".Length);
				assemblies.Add (new AssemblyPreparerInfo (Path.Combine (reproPath, assembly), Path.Combine (reproPath, "out", assembly)));
			} else {
				throw new Exception ($"Unknown line: {line}");
			}
		}
		if (!platform.HasValue)
			throw new Exception ("Platform not specified in repro arguments");
		if (registrar is null)
			throw new Exception ("RegistrarMode not specified in repro arguments");
		var ap = new AssemblyPreparer (assemblies.ToArray (), platform.Value);
		if (!string.IsNullOrEmpty (registrar))
			ap.configuration.App.ParseRegistrar (registrar);
		return ap;
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

		var steps = new IStep [] {
			new CoreTypeMapStep (),
		};

		var markHandlers = new IMarkHandler [] {
			new PreserveBlockCodeHandler (),
			new MarkIProtocolHandler (),
			new PreserveSmartEnumConversionsHandler (),
		};

		var linkContext = new DerivedLinkContext (configuration, configuration.App);
		configuration.DerivedLinkContext = linkContext;

		var markContext = new MarkContext ();
		foreach (var handler in markHandlers) {
			handler.Initialize (linkContext, markContext);
		}

		// load assemblies

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
