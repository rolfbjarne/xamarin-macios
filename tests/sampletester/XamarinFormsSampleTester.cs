using System.Collections.Generic;

using NUnit.Framework;

namespace Samples {
	[Category (CATEGORY)]
	public class XamarinFormsTester : SampleTester {
		const string REPO = "xamarin-forms-samples";
		const string CATEGORY = "xamarinformssamples"; // categories can't contain dashes
		const string HASH = "origin/master";

		static IEnumerable<SampleTestData> GetSampleData ()
		{
			return GetSampleTestData (null, REPO);
		}
	}
}
