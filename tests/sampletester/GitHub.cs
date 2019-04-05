using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using NUnit.Framework;

using Xamarin.Tests;

public static class GitHub {
	public static string [] GetProjects (string user, string repo, string hash)
	{
		IEnumerable<string> files;

		var dir = CloneRepository (user, repo, hash);
		files = Directory.GetFiles (dir, "*.*", SearchOption.AllDirectories);
		files = files.Select ((v) => v.Substring (dir.Length).TrimStart ('/'));

		return files
			.Where ((v) => {
				var ext = Path.GetExtension (v).ToLowerInvariant ();
				return ext == ".csproj" || ext == ".fsproj";
			}).ToArray ();
	}

	public static string CloneRepository (string user, string repo, string hash, bool clean = true)
	{
		var repo_dir = Path.Combine (Configuration.SampleRootDirectory, repo);

		if (!Directory.Exists (repo_dir)) {
			Directory.CreateDirectory (repo_dir);
			Assert.AreEqual (0, ExecutionHelper.Execute ("git", new string [] { "init" }, working_directory: repo_dir, timeout: TimeSpan.FromSeconds (10)), "git init");
			Assert.AreEqual (0, ExecutionHelper.Execute ("git", new string [] { "remote", "add", "origin", $"https://github.com/{user}/{repo}" }, working_directory: repo_dir, timeout: TimeSpan.FromSeconds (10)), "git remote add");
			Assert.AreEqual (0, ExecutionHelper.Execute ("git", new string [] { "fetch" }, working_directory: repo_dir, timeout: TimeSpan.FromMinutes (10)), "git fetch");
			Assert.AreEqual (0, ExecutionHelper.Execute ("git", new string [] { "checkout", "-b", "temporary-sample-testing-branch", hash }, working_directory: repo_dir, timeout: TimeSpan.FromMinutes (1)), "git checkout");
			Assert.AreEqual (0, ExecutionHelper.Execute ("git", new string [] { "submodule", "update", "--init", "--recursive" }, working_directory: repo_dir, timeout: TimeSpan.FromMinutes (10)), "git submodule update");
		} else if (clean) {
			Assert.AreEqual (0, ExecutionHelper.Execute ("git", new string [] { "reset", "--hard", hash }, working_directory: repo_dir, timeout: TimeSpan.FromMinutes (1)), "git checkout");
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
