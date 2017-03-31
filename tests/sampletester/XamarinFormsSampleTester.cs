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
}
