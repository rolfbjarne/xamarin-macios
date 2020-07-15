using System.Runtime.InteropServices;

namespace Xamarin.Mac.Tests {
	static class MainClass {
		static int Main (string [] args)
		{
			var exit_code = MonoTouch.NUnit.UI.MacRunner.Main (args, typeof (MainClass).Assembly);
			_exit (exit_code);
			return exit_code;
		}

		[DllImport ("/usr/lib/libSystem.dylib")]
		static extern void _exit (int exit_code);
	}
}
