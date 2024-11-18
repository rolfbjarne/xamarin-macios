using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using Xamarin.Messaging.Client;

namespace Xamarin.Messaging.Build {
	class Program {
		static async Task Main (string [] args)
		{
			var topicGenerator = new TopicGenerator ();
			var arguments = new AgentArgumentsParser ().ParseArguments (args);
			var agent = new BuildAgent (topicGenerator, arguments.Version, arguments.VersionInfo);
			var runner = new AgentConsoleRunner<BuildAgent> (agent, arguments);

			Console.WriteLine ($"Started agent with pid {Process.GetCurrentProcess ().Id} and arguments: \"{string.Join ("\", \"", args)}\"");
			AppDomain.CurrentDomain.FirstChanceException += (object? sender, FirstChanceExceptionEventArgs fceea) => {
				var ex = fceea.Exception;
				Console.WriteLine ($"FirstChanceException of type {ex.GetType ().FullName}\n\t{string.Join ("\n\t", ex.ToString ().Split ('\n'))}");
			};

			await runner.RunAsync ().ConfigureAwait (continueOnCapturedContext: false);
		}
	}
}
