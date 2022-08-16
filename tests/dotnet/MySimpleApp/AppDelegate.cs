using System;
using System.Runtime.InteropServices;

using Foundation;

namespace MySimpleApp
{
	public class Program
	{
		static int Main (string[] args)
		{
			GC.KeepAlive (typeof (NSObject)); // prevent linking away the platform assembly

			try {
				new System.Runtime.Loader.AssemblyDependencyResolver ("/tmp");
			} catch (Exception e) {
				Console.WriteLine ($"❌ {e}");
				return 1;
			}

			return 0;
		}
	}
}
