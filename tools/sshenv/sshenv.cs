namespace Xamarin.SshEnv;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Mono.Options;

using Renci.SshNet;

using Xamarin.Utils;

enum Mode {
	ExecuteCommand,
	Upload,
}

static class Program {

	static void ShowHelp ()
	{
		Console.WriteLine ("sshenv --user <user> --host <host> --penv <environment variable> command");
		options.WriteOptionDescriptions (Console.Out);
	}

	static OptionSet options;

	static string Host;
	static string UserName;
	static string PasswordEnvironmentVariable;
	static string Password;

	static int Main (string [] args)
	{
		var show_help = false;
		var mode = Mode.ExecuteCommand;
		var source = string.Empty;
		var target = string.Empty;

		options = new OptionSet {
			{ "host=", "The host to connect to (required).", (v) => Host = v },
			{ "user=", "The user to connect as (required).", (v) => UserName = v },
			{ "penv=", "The name of the environment variable with the password (required).", (v) => PasswordEnvironmentVariable = v },
			{ "mode=", "What to do. Valid options: ExecuteCommand (default), Upload.", (v) => mode = Enum.Parse<Mode> (v, true) },
			{ "source=", "The local source file or directory when in upload mode.", (v) => source = v },
			{ "target=", "The remote source file or directory when in upload mode.", (v) => target = v },
			{ "?|h|help", "Show this help", (v) => show_help = true },
		};

		var commandArguments = options.Parse (args);

		if (show_help) {
			ShowHelp ();
			return 0;
		}

		if (string.IsNullOrEmpty (PasswordEnvironmentVariable)) {
			Console.Error.WriteLine ($"The --penv argument is required.");
			ShowHelp ();
			return 1;
		}
		Password = Environment.GetEnvironmentVariable (PasswordEnvironmentVariable);
		if (string.IsNullOrEmpty (Password)) {
			Console.Error.WriteLine ($"No value was found in the environment variable {PasswordEnvironmentVariable}");
			return 1;
		}

		if (string.IsNullOrEmpty (Host)) {
			Console.Error.WriteLine ($"The --host argument is required.");
			ShowHelp ();
			return 1;
		}

		if (string.IsNullOrEmpty (UserName)) {
			Console.Error.WriteLine ($"The --user argument is required.");
			ShowHelp ();
			return 1;
		}

		try {
			switch (mode) {
			case Mode.ExecuteCommand:
				return ExecuteCommand (commandArguments);
			case Mode.Upload: {
				if (commandArguments.Count != 0) {
					Console.WriteLine ($"Unexpected additional arguments: {StringUtils.FormatArguments (commandArguments)}");
					ShowHelp ();
					return 1;
				}
				return Upload (source, target);
			}
			default:
				Console.Error.WriteLine ($"Mode not implemented: {mode}");
				return 1;
			}
		} catch (Exception e) {
			Console.WriteLine ($"Something went wrong:");
			Console.WriteLine (e);
			return 1;
		}
	}

	static int ExecuteCommand (IList<string> arguments)
	{
		if (arguments.Count == 0) {
			Console.Error.WriteLine ($"No command to execute.");
			ShowHelp ();
			return 1;
		}
		Console.WriteLine ($"Connecting to {UserName}@{Host}...");
		using var client = new SshClient (Host, UserName, Password);
		client.Connect ();
		using var cmd = client.CreateCommand (StringUtils.FormatArguments (arguments));
		Console.WriteLine ($"Executing command: '{cmd.CommandText}'");

		var result = cmd.BeginExecute ();

		ReadStream (cmd.OutputStream, Console.WriteLine, result);
		ReadStream (cmd.ExtendedOutputStream, Console.Error.WriteLine, result);

		cmd.EndExecute (result);

		Console.WriteLine ($"Executed command: '{cmd.CommandText}' Exit Status: {cmd.ExitStatus}");
		return cmd.ExitStatus;
	}

	static Task ReadStream (Stream streamToRead, Action<string> write, IAsyncResult asyncResult)
	{
		var tcs = new TaskCompletionSource<bool> ();
		var readerThread = new Thread ((v) => {
			try {
				using var reader = new StreamReader (streamToRead, Encoding.UTF8, leaveOpen: true);
				while (true) {
					if (asyncResult.IsCompleted) {
						tcs.SetResult (true);
						return;
					}
					if (reader.EndOfStream) {
						// This isn't accurate for some reason, we may still get data.
						Thread.Sleep (1);
						continue;
					}
					var line = reader.ReadLine ();
					if (line is null)
						continue;

					write (line);
				}
			} catch (Exception e) {
				tcs.SetException (e);
			}
		});
		readerThread.IsBackground = true;
		readerThread.Start ();

		return tcs.Task;
	}

	static int Upload (string source, string target)
	{
		if (string.IsNullOrEmpty (source)) {
			Console.Error.WriteLine ($"The --source argument is required.");
			return 1;
		} else if (string.IsNullOrEmpty (target)) {
			Console.Error.WriteLine ($"The --target argument is required.");
			return 1;
		} else if (!File.Exists (source) && !Directory.Exists (source)) {
			Console.Error.WriteLine ($"The file or directory '{source}' does not exist.");
			return 1;
		}

		Console.WriteLine ($"Connecting to {UserName}@{Host}...");
		using var client = new SftpClient (Host, UserName, Password);
		client.Connect ();
		if (File.Exists (source)) {
			UploadFile (client, source, target);
		} else if (Directory.Exists (source)) {
			UploadDirectory (client, source, target);
		} else {
			throw new Exception ($"Source is neither a file or a directory?");
		}

		return 0;
	}

	static HashSet<string> createdDirectories = new HashSet<string> ();

	static string GetRemotePath (string path)
	{
		return path.Replace ('\\', '/');
	}

	static string GetRemoteDirectoryName (string path)
	{
		var components = GetRemotePath (path).Split ('/');
		if (components.Length < 2)
			return string.Empty;
		return string.Join ('/', components, 0, components.Length - 1);
	}

	static void CreateDirectory (SftpClient client, string directory)
	{
		directory = GetRemotePath (directory);
		if (createdDirectories.Contains (directory))
			return;

		if (string.IsNullOrEmpty (directory))
			return;

		var parentDirectory = GetRemoteDirectoryName (directory);
		if (parentDirectory != directory)
			CreateDirectory (client, parentDirectory);

		if (!client.Exists (directory)) {
			Console.WriteLine ($"Creating the directory {directory}");
			client.CreateDirectory (directory);
		} else {
			Console.WriteLine ($"Not creating the directory {directory} because it already exists");
		}
		createdDirectories.Add (directory);
	}

	static void UploadFile (SftpClient client, string source, string target)
	{
		if (target.EndsWithDirectorySeparatorChar ())
			target = Path.Combine (target, Path.GetFileName (source));

		var targetSystemPath = GetRemotePath (target);
		if (client.Exists (targetSystemPath))
			throw new Exception ($"The remote file '{targetSystemPath}' already exists.");
		var targetDirectory = GetRemoteDirectoryName (targetSystemPath);
		if (!client.Exists (targetDirectory)) {
			CreateDirectory (client, targetDirectory);
		} else {
			var targetDirectoryAttributes = client.GetAttributes (targetDirectory);
			if (!targetDirectoryAttributes.IsDirectory)
				throw new Exception ($"The remote target directory '{targetDirectory}' already exists and is not a directory.");
		}

		var watch = Stopwatch.StartNew ();
		var finfo = new FileInfo (source);
		Console.WriteLine ($"Uploading '{source}' to '{targetSystemPath}' - {source.Length} bytes.");
		using var input = new FileStream (source, FileMode.Open, FileAccess.Read, FileShare.Read);
		var lastPrint = Stopwatch.StartNew ();
		client.UploadFile (input, targetSystemPath, false, (v) => {
			var progress = 100 * (v > 0 ? v / (double) finfo.Length : 0);
			var elapsedSeconds = watch.Elapsed.TotalSeconds;
			var bytesPerSecond = elapsedSeconds > 0 ? v / (double) elapsedSeconds : 0;
			lock (input) {
				if (lastPrint.Elapsed.TotalSeconds > 1) {
					Console.WriteLine ($"    Progress: {v:N}/{finfo.Length:N} bytes uploaded ({progress:0.00}% done) = {bytesPerSecond / 1024 / 1024:0.00} MB/s");
					lastPrint = Stopwatch.StartNew ();
				}
			}
		});
		{
			var elapsedSeconds = watch.Elapsed.TotalSeconds;
			var bytesPerSecond = elapsedSeconds > 0 ? finfo.Length / (double) elapsedSeconds : 0;
			Console.WriteLine ($"Uploaded '{source}' to '{target}' in {elapsedSeconds:N} seconds = {bytesPerSecond / 1024 / 1024:0.00} MB/s.");
		}
	}

	static void UploadDirectory (SftpClient client, string source, string target)
	{
		CreateDirectory (client, GetRemotePath (target));

		var files = Directory.GetFiles (source);
		foreach (var file in files) {
			var filename = Path.GetFileName (file);
			var fileTarget = Path.Combine (target, filename);
			UploadFile (client, file, fileTarget);
		}
		var subdirs = Directory.GetDirectories (source);
		foreach (var subdir in subdirs) {
			var dirname = Path.GetFileName (subdir);
			var dirTarget = Path.Combine (target, dirname);
			UploadDirectory (client, subdir, dirTarget);
		}
	}

	public static bool EndsWithDirectorySeparatorChar (this string path)
	{
		return path.EndsWith (Path.DirectorySeparatorChar) || path.EndsWith (Path.AltDirectorySeparatorChar);
	}
}