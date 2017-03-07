using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Xml;

using NUnit.Framework;

[TestFixture]
public abstract class SampleTester
{
	public string Repository { get; private set; }

	protected virtual string [] GetIgnoredSolutions ()
	{
		return new string [0];
	}

	protected SampleTester (string repo)
	{
		Repository = repo;
	}

	// returns false if timed out (in which case exit code is int.MinValue
	protected static bool RunProcess (string filename, string arguments, out int exitCode, TimeSpan timeout, string workingDirectory)
	{	
		var outputDone = new ManualResetEvent (false);
		var errorDone = new ManualResetEvent (false);
		using (var xbuild = new Process ()) {
			xbuild.StartInfo.FileName = filename;
			xbuild.StartInfo.Arguments = arguments;
			xbuild.StartInfo.RedirectStandardError = true;
			xbuild.StartInfo.RedirectStandardOutput = true;
			xbuild.StartInfo.UseShellExecute = false;
			xbuild.StartInfo.WorkingDirectory = workingDirectory;
			xbuild.OutputDataReceived += (sender, e) =>
			{
				if (e.Data == null) {
					outputDone.Set ();
				} else {
					Console.WriteLine (e.Data);
				}
			};
			xbuild.ErrorDataReceived += (sender, e) =>
			{
				if (e.Data == null) {
					errorDone.Set ();
				} else {
					Console.WriteLine (e.Data);
				}
			};
			Console.WriteLine ("{0} {1}", xbuild.StartInfo.FileName, xbuild.StartInfo.Arguments);
			xbuild.Start ();
			xbuild.BeginErrorReadLine ();
			xbuild.BeginOutputReadLine ();
			var rv = xbuild.WaitForExit ((int) timeout.TotalMilliseconds);
			if (rv) {
				outputDone.WaitOne (TimeSpan.FromSeconds (5));
				errorDone.WaitOne (TimeSpan.FromSeconds (5));
				exitCode = xbuild.ExitCode;
			} else {
				Console.WriteLine ("Command timed out after {0}s", timeout.TotalSeconds);
				exitCode = int.MinValue;
			}
			return rv;
		}
	}

	[TestCaseSource ("GetSolutions")]
	public void BuildSolution (string solution)
	{
		if (Array.IndexOf (GetIgnoredSolutions (), solution) >= 0)
			Assert.Ignore ("Ignored");

		solution = Path.Combine (CloneRepo (), solution);

		var exitCode = 0;
		try {
			Assert.IsTrue (RunProcess ("xbuild", $"/verbosity:diag /p:Platform=iPhone \"{solution}\"", out exitCode, TimeSpan.FromMinutes (5), RootDirectory), "built in 5 minutes");
			Assert.AreEqual (0, exitCode, "exit code");
		} finally {
			// Clean up after us, since building for device needs a lot of space.
			RunProcess ("git", "clean -xfdq", out exitCode, TimeSpan.FromSeconds (30), Path.GetDirectoryName (solution));
		}
	}

	protected static string RootDirectory {
		get {
			return Path.Combine (Path.GetDirectoryName (System.Reflection.Assembly.GetExecutingAssembly ().Location), "repositories");
		}
	}

	protected static string [] GetSolutionsImpl (string repo)
	{
		var fn = Path.Combine (RootDirectory, $"{repo}.filelist");
		if (File.Exists (fn))
			return File.ReadAllLines (fn);
		Directory.CreateDirectory (Path.GetDirectoryName (fn));

		using (var client = new WebClient ()) {
			byte [] data;
			try {
				client.Headers.Add (HttpRequestHeader.UserAgent, "xamarin");
				data = client.DownloadData ($"https://api.github.com/repos/xamarin/{repo}/git/trees/master?recursive=1");
			} catch (WebException we) {
				return new string [] { $"Failed to load repo: {we.Message}" };
			}
			var reader = JsonReaderWriterFactory.CreateJsonReader (data, new XmlDictionaryReaderQuotas ());
			var doc = new XmlDocument ();
			doc.Load (reader);
			var rv = new List<string> ();
			foreach (XmlNode node in doc.SelectNodes ("/root/tree/item/path")) {
				var path = node.InnerText;
				if (!path.EndsWith (".sln", StringComparison.OrdinalIgnoreCase))
					continue;
				rv.Add (node.InnerText);
			}

			File.WriteAllLines (fn, rv.ToArray ());
			return rv.ToArray ();
		}
	}

	string CloneRepo ()
	{
		var repo_dir = Path.Combine (RootDirectory, Path.GetFileName (Repository));

		Directory.CreateDirectory (RootDirectory);

		if (!Directory.Exists (repo_dir)) {
			var exitCode = 0;
			Assert.IsTrue (RunProcess ("git", $"clone git@github.com:xamarin/{Repository}", out exitCode, TimeSpan.FromMinutes (10), RootDirectory), "cloned in 10 minutes");
			Assert.AreEqual (0, exitCode, "git clone exit code");
		}

		return repo_dir;
	}
}

public class IosSampleTester : SampleTester
{
	const string REPO = "ios-samples"; // monotouch-samples redirects to ios-samples
	public IosSampleTester ()
		: base (REPO)
	{
	}

	static string [] GetSolutions ()
	{
		return GetSolutionsImpl (REPO);
	}
}

public class MacIosSampleTester : SampleTester
{
	const string REPO = "mac-ios-samples";
	public MacIosSampleTester ()
		: base (REPO)
	{
	}

	static string [] GetSolutions ()
	{
		return GetSolutionsImpl (REPO);
	}

	protected override string [] GetIgnoredSolutions ()
	{
		return new string []
		{
			// xamarin-macios/tests/sampletester/bin/Debug/repositories/mac-ios-samples/SceneKitReel/SceneKitReelShared/GameViewController.cs(1072,4): error CS0103: The name `p3d' does not exist in the current context
			// xamarin-macios/tests/sampletester/bin/Debug/repositories/mac-ios-samples/SceneKitReel/SceneKitReelShared/GameViewController.cs(1081,26): error CS0103: The name `p3d' does not exist in the current context
			"SceneKitReel/SceneKitReel.sln",
		};
	}
}


public class MobileSampleTester : SampleTester
{
	const string REPO = "mobile-samples";
	public MobileSampleTester ()
		: base (REPO)
	{
	}

	static string [] GetSolutions ()
	{
		return GetSolutionsImpl (REPO);
	}
}

public class PrivateSampleTester : SampleTester
{
	const string REPO = "private-samples";
	public PrivateSampleTester ()
		: base (REPO)
	{
	}

	static string [] GetSolutions ()
	{
		return GetSolutionsImpl (REPO);
	}
}

