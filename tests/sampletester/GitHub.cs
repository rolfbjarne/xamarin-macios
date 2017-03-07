using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using NUnit.Framework;

using Xamarin.Tests;

public static class GitHub {
	public static string [] GetProjects (string user, string repo)
	{
		IEnumerable<string> files;

		var dir = CloneRepository (user, repo);
		files = Directory.GetFiles (dir, "*.*", SearchOption.AllDirectories);
		files = files.Select ((v) => v.Substring (dir.Length).TrimStart ('/'));

		return files
			.Where ((v) => {
				var ext = Path.GetExtension (v).ToLowerInvariant ();
				return ext == ".csproj" || ext == ".fsproj";
			}).ToArray ();
	}

	public static string CloneRepository (string user, string repo, bool clean = true)
	{
		var repo_dir = Path.Combine (Configuration.SampleRootDirectory, repo);

		if (!Directory.Exists (repo_dir)) {
			var auth = Environment.GetEnvironmentVariable ("GITHUB_AUTH_TOKEN") ?? string.Empty;
			Assert.AreEqual (0, ExecutionHelper.Execute ("git", new string [] { "clone", $"https://{auth}github.com/{user}/{repo}" }, working_directory: Configuration.SampleRootDirectory, timeout: TimeSpan.FromMinutes (10)), "cloned in 10 minutes");
		} else if (clean) {
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
