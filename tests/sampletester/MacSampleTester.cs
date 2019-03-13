using System.Collections.Generic;
using NUnit.Framework;

namespace Samples {
	[Category (CATEGORY)]
	public class MacSampleTester : SampleTester {
		const string REPO = "mac-samples";
		const string CATEGORY = "macsamples"; // categories can't contain dashes
		const string HASH = "origin/master";

		static string [] GetProjects ()
		{
			return GetExecutableProjects (REPO);
		}

		protected override Dictionary<string, string> GetIgnoredSolutionsImpl ()
		{
			return new Dictionary<string, string> {
			};
		}
	}
}
