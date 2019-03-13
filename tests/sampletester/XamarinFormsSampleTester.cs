using System.Collections.Generic;
using NUnit.Framework;

namespace Samples {
	[Category (CATEGORY)]
	public class XamarinFormsTester : SampleTester {
		const string REPO = "xamarin-forms-samples";
		const string CATEGORY = "xamarinformssamples"; // categories can't contain dashes
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

		// msbuild Xuzzle.sln /verbosity:diag /p:Platform=iPhone /p:Configuration=Debug "/t:Platforms\\Xuzzle_iOS"
		Dictionary<string, string> sln_to_proj = new Dictionary<string, string> {
			{ "Xuzzle.sln", "Platforms\\Xuzzle_iOS" },
		};
	}
}
