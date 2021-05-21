using System;
using System.Runtime.InteropServices;

using Foundation;

namespace NativeFileReferencesApp
{
	public class Program
	{
		static int Main (string[] args)
		{
			Console.WriteLine (RuntimeInformation.ProcessArchitecture);

			GC.KeepAlive (typeof (NSObject)); // prevent linking away the platform assembly

			Console.WriteLine (Environment.GetEnvironmentVariable ("MAGIC_WORD"));

			return 0;
		}
	}
}
