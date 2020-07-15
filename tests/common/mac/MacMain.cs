namespace Xamarin.Mac.Tests {
	static class MainClass {
		static int Main (string [] args)
		{
			return MonoTouch.NUnit.UI.MacRunner.Main (args, typeof (MainClass).Assembly);
		}
	}
}
