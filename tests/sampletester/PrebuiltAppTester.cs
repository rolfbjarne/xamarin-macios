using System.Collections.Generic;
using NUnit.Framework;

public class PrebuiltAppTester : SampleTester
{
	const string REPO = "prebuilt-apps";
	public PrebuiltAppTester ()
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
}
