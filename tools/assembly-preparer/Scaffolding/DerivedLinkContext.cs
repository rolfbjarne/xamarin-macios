namespace Xamarin.Tuner;

using Mono.Linker;
using Xamarin.Bundler;

public class DerivedLinkContext : LinkContext {
	public DerivedLinkContext (LinkerConfiguration configuration) : base (configuration)
	{
	}
}
