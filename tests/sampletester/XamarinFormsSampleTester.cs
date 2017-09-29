using System.Collections.Generic;
using NUnit.Framework;

public class XamarinFormsSampleTester : SampleTester
{
	const string REPO = "xamarin-forms-samples";
	public XamarinFormsSampleTester ()
		: base (REPO)
	{
	}

	static string [] GetSolutions ()
	{
		return GetSolutionsImpl (REPO);
	}

	protected override Dictionary<string, string> GetIgnoredSolutionsImpl ()
	{
		return new Dictionary<string, string>
		{
		};
	}

	// msbuild Xuzzle.sln /verbosity:diag /p:Platform=iPhone /p:Configuration=Debug "/t:Platforms\\Xuzzle_iOS"
	Dictionary<string, string> sln_to_proj = new Dictionary<string, string> {
		{ "Xuzzle.sln", "Platforms\\Xuzzle_iOS" },
	};
}
