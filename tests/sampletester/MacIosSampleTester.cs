using System.Collections.Generic;

using NUnit.Framework;

namespace Samples {
	[Category (CATEGORY)]
	public class MacIosSampleTester : SampleTester {
		const string REPO = "mac-ios-samples";
		const string CATEGORY = "maciossamples"; // categories can't contain dashes
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
			return new Dictionary<string, string>
			{
			{  "AgentsCatalog/AgentsCatalog.sln", "build error: /Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Mac/Xamarin.Mac.Common.targets: error : Error executing task ACTool: Method 'Xamarin.MacDev.PObject.Save' not found." },
			{ "SceneKitReel/SceneKitReel.sln",
				@"Compile errors: 
xamarin-macios/tests/sampletester/bin/Debug/repositories/mac-ios-samples/SceneKitReel/SceneKitReelShared/GameViewController.cs(1072,4): error CS0103: The name `p3d' does not exist in the current context
xamarin-macios/tests/sampletester/bin/Debug/repositories/mac-ios-samples/SceneKitReel/SceneKitReelShared/GameViewController.cs(1081,26): error CS0103: The name `p3d' does not exist in the current context"
			},
			{ "MetalKitEssentials/MetalKitEssentials.sln", "build error: /Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Mac/Xamarin.Mac.Common.targets: error : Error executing task ACTool: Method 'Xamarin.MacDev.PObject.Save' not found." },
		};
		}
	}
}
