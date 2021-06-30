using System;
using System.Runtime.CompilerServices;

using Foundation;
using UIKit;

namespace MyInterpretedApp
{
	public class Application
	{
		static void Main (string[] args)
		{
			Console.WriteLine ($"Execution mode: {GetExecutionMode ()}");
			UIApplication.Main (args, null, typeof (AppDelegate));
		}

		public string GetExecutionMode()
		{
			if (!RuntimeFeature.IsDynamicCodeSupported)
				return "AOT";
			if (RutnimeFeature.IsDynamicCodeCompiled)
				return "JIT";
			return "Interpreter";
		}
	}
}
