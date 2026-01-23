using Xamarin.Utils;

namespace Xamarin.Bundler;

public class Application {
	public Application () {}
	public ApplePlatform Platform { get => throw new NotImplementedException (); }
	public string ProductName => throw new NotImplementedException ();
	public void LoadSymbols ()
	{
		throw new NotImplementedException ();
	}
}
