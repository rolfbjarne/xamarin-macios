using System.Collections.Generic;
using NUnit.Framework;

namespace Samples {
	[Category (CATEGORY)]
	public class PrebuiltAppTester : SampleTester {
		const string REPO = "prebuilt-apps";
		const string CATEGORY = "prebuiltapps"; // categories can't contain dashes
		const string HASH = "origin/master";

		static string [] GetSolutions ()
		{
			return GetSolutionsImpl (REPO);
		}

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