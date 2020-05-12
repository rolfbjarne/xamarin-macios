using System;
namespace Xamarin.Bundler {
	public partial class Driver {
		// LogMessage and LogError are instance objects on the tasks themselves and bubbling an event up is not ideal
		public static void Log (int min_verbosity, string format, params object [] args)
		{
			// FIXME
			Console.WriteLine (format, args);
		}


		// LogMessage and LogError are instance objects on the tasks themselves and bubbling an event up is not ideal
		public static void Log (int min_verbosity, string message)
		{
			// FIXME
			Console.WriteLine (message);
		}
	}
}

