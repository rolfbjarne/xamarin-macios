using System.Collections.Generic;

using NUnit.Framework;

namespace Samples {
	[Category (CATEGORY)]
	public class MacIosSampleTester : SampleTester {
		const string REPO = "mac-ios-samples";
		const string CATEGORY = "maciossamples"; // categories can't contain dashes
		const string HASH = "origin/master";

		static string [] GetProjects ()
		{
			return GetExecutableProjects (REPO);
		}

		protected override Dictionary<string, SampleTestData> GetTestDataImpl ()
		{
			return new Dictionary<string, SampleTestData> {
				{ "ExceptionMarshaling/ExceptionMarshaling.Mac.csproj", new SampleTestData { BuildSolution = true, Solution = "ExceptionMarshaling/ExceptionMarshaling.sln" } },
				{ "Fox2/Fox2.macOS/Fox2.macOS.csproj", new SampleTestData { BuildSolution = true, Solution = "Fox2/Fox2.sln" } },
				{ "MetalKitEssentials/MetalKitEssentials.Mac/MetalKitEssentials.Mac.csproj", new SampleTestData { BuildSolution = true, Solution = "MetalKitEssentials/MetalKitEssentials.sln" } },
				{ "SceneKitReel/SceneKitReelMac/SceneKitReelMac.csproj", new SampleTestData { BuildSolution = true, Solution = "SceneKitReel/SceneKitReel.sln" } },
			};
		}
	}
}
