using System.Collections.Generic;
using NUnit.Framework;

public class MacSampleTester : SampleTester
{
	const string REPO = "mac-samples";
	public MacSampleTester ()
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
