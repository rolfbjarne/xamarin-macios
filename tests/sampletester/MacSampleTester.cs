using System.Collections.Generic;
using NUnit.Framework;

[Category (CATEGORY)]
public class MacSampleTester : SampleTester
{
	const string REPO = "mac-samples";
	const string CATEGORY = "macsamples"; // categories can't contain dashes
	public MacSampleTester ()
		: base (REPO)
	{
	}

	protected override string Platform {
		get {
			return string.Empty;
		}
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
