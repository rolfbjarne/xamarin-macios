using System.Collections.Generic;

using NUnit.Framework;

namespace Samples {
	[Category (CATEGORY)]
	public class MacIosSampleTester : SampleTester {
		const string REPO = "mac-ios-samples";
		const string CATEGORY = "maciossamples"; // categories can't contain dashes
		const string HASH = "origin/master";

		static Dictionary<string, SampleTest> test_data = new Dictionary<string, SampleTest> {
				// Build solution instead of csproj
				{ "ExceptionMarshaling/ExceptionMarshaling.Mac.csproj", new SampleTest { BuildSolution = true, Solution = "ExceptionMarshaling/ExceptionMarshaling.sln" } },
				{ "Fox2/Fox2.macOS/Fox2.macOS.csproj", new SampleTest { BuildSolution = true, Solution = "Fox2/Fox2.sln" } },
				{ "MetalKitEssentials/MetalKitEssentials.Mac/MetalKitEssentials.Mac.csproj", new SampleTest { BuildSolution = true, Solution = "MetalKitEssentials/MetalKitEssentials.sln" } },
				{ "SceneKitReel/SceneKitReelMac/SceneKitReelMac.csproj", new SampleTest { BuildSolution = true, Solution = "SceneKitReel/SceneKitReel.sln" } },
			};

		static IEnumerable<SampleTestData> GetSampleData ()
		{
			return GetSampleTestData (test_data, REPO);
		}
	}
}
