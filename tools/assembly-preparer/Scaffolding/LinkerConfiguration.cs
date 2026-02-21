using System;
using Mono.Cecil;
using Xamarin.Linker;
using Xamarin.Tuner;
using Mono.Linker;
using System.Collections.Generic;
using Xamarin.Utils;

namespace Xamarin.Bundler;

public class LinkerConfiguration {
	public Application App { get; private set; }

	List<ProductException> exceptions = new List<ProductException> ();
	public List<ProductException> Exceptions {
		get {
			return exceptions;
		}
	}

	AppBundleRewriter? abr;
	internal AppBundleRewriter AppBundleRewriter {
		get {
			if (abr is null)
				abr = new AppBundleRewriter (this);
			return abr;
		}
	}

	public DotNetResolver AssemblyResolver { get; private set; }
	public IMetadataResolver MetadataResolver { get; private set; }

	public string IntermediateOutputPath { get; set; } = string.Empty;
	public List<string> NativeCodeToCompileAndLink { get; private set; } = new List<string> ();

	DerivedLinkContext? derivedLinkContext;
	public DerivedLinkContext DerivedLinkContext {
		get {
			if (derivedLinkContext is null)
				throw new InvalidOperationException ($"No derived link context set?");
			return derivedLinkContext!;
		}
		set => derivedLinkContext = value;
	}

	public DerivedLinkContext Context { get => DerivedLinkContext; }
	public Profile Profile { get; private set; }

	public AssemblyDefinition [] Assemblies { get => Context.GetAssemblies (); }

	ApplePlatform platform;
	public ApplePlatform Platform {
		get => platform;
		set {
			platform = value;
			App.Platform = value;
		}
	}

	public string PlatformAssembly {
		get {
			return $"Microsoft.{Platform.AsString ()}";
		}
	}

	public RegistrarMode Registrar { get => App.Registrar; }

	public LinkerConfiguration ()
	{
		App = new Application (this);
		AssemblyResolver = new DotNetResolver ();
		MetadataResolver = new MetadataResolver (AssemblyResolver);
		Profile = new Profile (this);
	}

	public static LinkerConfiguration GetInstance (LinkContext context)
	{
		return context.Configuration;
	}

	public static void Report (LinkContext context, Exception exception)
	{
		var pe = exception as ProductException;
		if (pe is null)
			pe = ErrorHelper.CreateError (99, exception, "Unexpected error: {0}", exception.Message);
		GetInstance (context).exceptions.Add (pe);
	}

	public static void Report (LinkContext context, IList<Exception> exceptions)
	{
		foreach (var exception in exceptions) {
			Report (context, exception);
		}
	}

	public bool IsProductAssembly (string assemblyName)
	{
		return assemblyName == PlatformAssembly;
	}

	public bool IsProductAssembly (AssemblyDefinition assembly)
	{
		return assembly.Name.Name == PlatformAssembly;
	}

	public void Log (int level, string message)
	{
		if (level > 0)
			return; // FIXME: check actual verbosity
		Console.WriteLine (message);
	}
}
