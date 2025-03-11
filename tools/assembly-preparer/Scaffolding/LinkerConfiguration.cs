using System;
using Mono.Cecil;
using Xamarin.Linker;
using Xamarin.Tuner;
using Mono.Linker;
using System.Collections.Generic;
using Xamarin.Utils;

namespace Xamarin.Bundler;

public class LinkerConfiguration {
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

	public AssemblyDefinition [] Assemblies { get => Context.GetAssemblies (); }

	public ApplePlatform Platform { get; set; }

	public string PlatformAssembly {
		get {
			return $"Microsoft.{Platform.AsString ()}";
		}
	}

	public static LinkerConfiguration GetInstance (LinkContext context)
	{
		return context.Configuration;
	}

	public static void Report (LinkContext context, Exception exception)
	{
		var pe = exception as ProductException;
		if (pe is null)
			pe = ErrorHelper.CreateError (99, exception, "Unexpected error: {0}}", exception.Message);
		GetInstance (context).exceptions.Add (pe);
	}

	public static void Report (LinkContext context, List<Exception> exceptions)
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

}
