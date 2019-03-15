using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Xml;

using NUnit.Framework;

using Xamarin.Tests;

public static class GitHub {
	static WebClient CreateClient ()
	{
		var client = new WebClient ();
		client.Headers.Add (HttpRequestHeader.UserAgent, "xamarin");
		var xharness_github_token_file = Environment.GetEnvironmentVariable ("XHARNESS_GITHUB_TOKEN_FILE");
		if (!string.IsNullOrEmpty (xharness_github_token_file) && File.Exists (xharness_github_token_file))
			client.Headers.Add (HttpRequestHeader.Authorization, File.ReadAllText (xharness_github_token_file));
		return client;
	}

	static string[] GetFiles (string user, string repo)
	{
		var fn = Path.Combine (Configuration.SampleRootDirectory, $"{repo}.filelist");
		if (File.Exists (fn))
			return File.ReadAllLines (fn);
		Directory.CreateDirectory (Path.GetDirectoryName (fn));

		using (var client = CreateClient ()) {
			byte [] data;
			try {
				data = client.DownloadData ($"https://api.github.com/repos/{user}/{repo}/git/trees/master?recursive=1");
			} catch (WebException we) {
				string rsp = we.Message;
				try {
					foreach (var header in we.Response.Headers.AllKeys)
						rsp += $"\n{header}={we.Response.Headers [header]}";
					using (var webreader = new StreamReader (we.Response.GetResponseStream ()))
						rsp += "\n" + webreader.ReadToEnd ();
				} catch {
				}

				return new string [] { $"Failed to load {user}/{repo}: {rsp}" };
			}
			var reader = JsonReaderWriterFactory.CreateJsonReader (data, new XmlDictionaryReaderQuotas ());
			var doc = new XmlDocument ();
			doc.Load (reader);
			var rv = new List<string> ();
			foreach (XmlNode node in doc.SelectNodes ("/root/tree/item/path")) {
				rv.Add (node.InnerText);
			}

			File.WriteAllLines (fn, rv.ToArray ());
			return rv.ToArray ();
		}

	}

	public static string [] GetProjects (string user, string repo)
	{
		return GetFiles (user, repo)
			.Where ((v) => {
				var ext = Path.GetExtension (v).ToLowerInvariant ();
				return ext == ".csproj" || ext == ".fsproj";
			}).ToArray ();
	}

	public static string CloneRepository (string user, string repo)
	{
		var repo_dir = Path.Combine (Configuration.SampleRootDirectory, repo);

		Directory.CreateDirectory (Configuration.SampleRootDirectory);

		if (!Directory.Exists (repo_dir)) {
			var auth = Environment.GetEnvironmentVariable ("GITHUB_AUTH_TOKEN") ?? string.Empty;
			Assert.AreEqual (0, ExecutionHelper.Execute ("git", new string [] { "clone", $"https://{auth}github.com/{user}/{repo}" }, working_directory: Configuration.SampleRootDirectory, timeout: TimeSpan.FromMinutes (10)), "cloned in 10 minutes");
		} else {
			CleanRepository (repo_dir);
		}

		return repo_dir;
	}

	public static void CleanRepository (string directory, bool submodules = true)
	{
		ExecutionHelper.Execute ("git", new string [] { "clean", "-xffdq" }, working_directory: directory, timeout: TimeSpan.FromSeconds (30));
		if (submodules)
			ExecutionHelper.Execute ("git", new string [] { "submodule", "foreach", "--recursive", "clean -xffdq" }, working_directory: directory, timeout: TimeSpan.FromSeconds (60));
	}
}
