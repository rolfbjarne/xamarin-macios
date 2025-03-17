using System;
using Mono.Cecil;
using Xamarin.Linker;
using Xamarin.Tuner;
using Mono.Linker;
using System.Collections.Generic;
using Xamarin.Utils;

namespace Xamarin.Bundler;

public class LinkerConfiguration {
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
	public Profile Profile { get => throw new NotImplementedException (); }
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
		Console.WriteLine ($"Linker error: {exception}");
		throw new NotImplementedException ();
	}
	public static void Report (LinkContext context, List<Exception> exceptions)
	{
		throw new NotImplementedException ();
	}
}
