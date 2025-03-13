using Xamarin.Utils;

namespace Xamarin.Bundler;

public class Application {
	public ApplePlatform Platform { get => throw new NotImplementedException (); }
	public string ProductName => "assembly-preparer";
	public void LoadSymbols ()
	{
		throw new NotImplementedException ();
	}
}
