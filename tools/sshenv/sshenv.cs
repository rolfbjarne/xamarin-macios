namespace Xamarin.SshEnv;

using System;

using Mono.Options;

using Renci.SshNet;

using Xamarin.Utils;

class Program {
	static void ShowHelp (OptionSet os)
	{
		Console.WriteLine ("sshenv --user <user> --host <host> --penv <environment variable> command");
		os.WriteOptionDescriptions (Console.Out);

	}
	static int Main (string[] args)
	{
		var show_help = false;
		var passwordEnvironmentVariable = string.Empty;
		var host = string.Empty;
		var username = string.Empty;

		host = "127.0.0.1";
		username = "rolf";
		
		var os = new OptionSet {
			{ "host=", "The host to connect to (required).", (v) => host = v },
			{ "user=", "The user to connect as (required).", (v) => username = v },
			{ "penv=", "The name of the environment variable with the password (required).", (v) => passwordEnvironmentVariable = v },
			{ "?|h|help", "Show this help", (v) => show_help = true },
		};

		var commandArguments = os.Parse (args);

		if (show_help) {
			ShowHelp (os);
			return 0;
		}

		if (string.IsNullOrEmpty (passwordEnvironmentVariable)) {
			Console.Error.WriteLine ($"The --penv argument is required.");
			ShowHelp (os);
			return 1;
		}


		if (string.IsNullOrEmpty (host)) {
			Console.Error.WriteLine ($"The --host argument is required.");
			ShowHelp (os);
			return 1;
		}

		if (string.IsNullOrEmpty (username)) {
			Console.Error.WriteLine ($"The --user argument is required.");
			ShowHelp (os);
			return 1;
		}

		if (commandArguments.Count == 0) {
			Console.WriteLine ($"No command to execute.");
			ShowHelp (os);
			return 1;
		}

		var password = Environment.GetEnvironmentVariable (passwordEnvironmentVariable);
		if (string.IsNullOrEmpty (password)) {
			Console.WriteLine ($"No value was find in the environment variable {passwordEnvironmentVariable}");
			return 1;
		}

		try {
			Console.WriteLine ($"Connecting to {username}@{host}...");
			using var client = new SshClient (host, username, password);
			client.Connect ();
			using var cmd = client.CreateCommand (StringUtils.FormatArguments (commandArguments));
			Console.WriteLine ($"Executing command: {cmd.CommandText}");
			var rv = cmd.Execute ();
			Console.WriteLine (rv);
		} catch (Exception e) {
			Console.WriteLine ($"Something went wrong:");
			Console.WriteLine (e);
			return 1;
		}
		return 0;
	}
}
