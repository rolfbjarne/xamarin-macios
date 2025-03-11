using System;
using System.Collections.Generic;
using System.IO;
using Mono.Cecil;
using Mono.Linker;
using Xamarin.Bundler;
using Xamarin.Linker.Steps;
using Xamarin.Tuner;
using Xamarin.Utils;

namespace Xamarin.Build;

public class AssemblyPreparer : IDisposable {
	LinkerConfiguration configuration = new LinkerConfiguration ();

	public AssemblyPreparerInfo[] Assemblies { get; set; }

	public AssemblyPreparer (AssemblyPreparerInfo[] assemblies, string platform)
#if NET
	: this (assemblies, Enum.Parse<ApplePlatform> (platform, true))
#else
	: this (assemblies, (ApplePlatform) Enum.Parse (typeof (ApplePlatform), platform, true))
#endif
	{
	}

	public AssemblyPreparer (AssemblyPreparerInfo[] assemblies, ApplePlatform platform)
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

		foreach (var assembly in Assemblies) {
			var assemblyDefinition = AssemblyDefinition.ReadAssembly (assembly.InputPath); // FIXME: symbols
			linkContext.Assemblies.Add (assemblyDefinition);
			assembly.Assembly = assemblyDefinition;
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
			Directory.CreateDirectory (Path.GetDirectoryName (assembly.OutputPath)!);
			assemblyDefinition.Write (assembly.OutputPath);
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
