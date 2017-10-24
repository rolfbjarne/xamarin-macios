using System.Collections.Generic;
using NUnit.Framework;

[Category (CATEGORY)]
public class PrebuiltAppTester : SampleTester
{
	const string REPO = "prebuilt-apps";
	const string CATEGORY = "prebuiltapps"; // categories can't contain dashes
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
