using System.Collections.Generic;
using NUnit.Framework;

namespace Samples {
	[Category (CATEGORY)]
	public class PrebuiltAppTester : SampleTester {
		const string REPO = "prebuilt-apps";
		const string CATEGORY = "prebuiltapps"; // categories can't contain dashes
		const string HASH = "origin/master";

		static IEnumerable<SampleTestData> GetSampleData ()
		{
			return GetSampleTestData (null, REPO);
		}
	}
}