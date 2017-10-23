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
public abstract class SampleTester : BaseTester
{
	Dictionary<string, string> ignored_solutions;
	Dictionary<string, string> GetIgnoredSolutions ()
	{
		if (ignored_solutions == null)
			ignored_solutions = GetIgnoredSolutionsImpl ();
		return ignored_solutions;
	}

	protected virtual Dictionary<string, string> GetIgnoredSolutionsImpl ()
	{
		return new Dictionary<string, string> ();
	}

	protected virtual string Platform {
		get {
			return "iPhone";
		}
	}

	protected SampleTester (string repo)
	{
		Repository = repo;
	}

	void BuildSolution (string solution, string msbuild, string platform, string configuration)
	{
		string ignored_message = "Ignored";
		if (GetIgnoredSolutions ()?.TryGetValue (solution, out ignored_message) == true)
			Assert.Ignore (ignored_message);

		solution = Path.Combine (CloneRepo (), solution);

		ProcessHelper.BuildSolution (solution, msbuild, platform, configuration);
	}

	[Test]
	public void BuildSolution ([Values (/*"xbuild", */"msbuild")] string msbuild, [Values ("Debug"/*, "Release"*/)] string configuration, [ValueSource ("GetSolutions")] string solution)
	{
		BuildSolution (solution, msbuild, Platform, configuration);
	}

	protected static string RootDirectory {
		get {
			return Configuration.RootDirectory;
		}
	}

	protected static string [] GetSolutionsImpl (string repo)
	{
		return GitHub.GetSolutions ("xamarin", repo);
	}

	string CloneRepo ()
	{
		return GitHub.CloneRepository ("xamarin", Repository);
	}
}
