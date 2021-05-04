using AppKit;

namespace MyCocoaApp {
	static class MainClass {
		static void Main (string [] args)
		{
			throw new System.Exception ("Hello Exception");
			NSApplication.Init ();
			NSApplication.Main (args);
		}
	}
}
