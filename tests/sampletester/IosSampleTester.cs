using System.Collections.Generic;

using NUnit.Framework;

namespace Samples {
	[Category (CATEGORY)]
	public class IosSampleTester : SampleTester {
		const string REPO = "ios-samples"; // monotouch-samples redirects to ios-samples
		const string CATEGORY = "iossamples"; // categories can't contain dashes
		const string HASH = "origin/master";

		static string [] GetProjects ()
		{
			return GetExecutableProjects (REPO);
		}

		protected override Dictionary<string, SampleTestData> GetTestDataImpl ()
		{
			return new Dictionary<string, SampleTestData> {
				// Build solution instead of csproj
				{ "BindingSample/XMBindingLibrarySample/XMBindingLibrarySample.csproj", new SampleTestData { BuildSolution = true, Solution = "BindingSample/BindingSample.sln" } },
				{ "BouncingGameCompleteiOS/BouncingGame.iOS/BouncingGame.iOS.csproj", new SampleTestData { BuildSolution = true, Solution = "BouncingGameCompleteiOS/BouncingGame.sln" } },
				{ "BouncingGameEmptyiOS/BouncingGame.iOS/BouncingGame.iOS.csproj", new SampleTestData { BuildSolution = true, Solution = "BouncingGameEmptyiOS/BouncingGame.sln" } },
				{ "FileSystemSampleCode/FileSystem/FileSystem.csproj", new SampleTestData { BuildSolution = true, Solution = "FileSystemSampleCode/WorkingWithTheFileSystem.sln" } },
				{ "InfColorPicker/InfColorPickerBinding/InfColorPickerSample/InfColorPickerSample.csproj", new SampleTestData { BuildSolution = true, Solution = "InfColorPicker/InfColorPickerBinding/InfColorPickerBinding.sln" } },
				{ "ios10/ElizaChat/ElizaChat/ElizaChat.csproj", new SampleTestData { BuildSolution = true, Solution = "ios10/ElizaChat/ElizaChat.sln" } },
				{ "ios10/IceCreamBuilder/IceCreamBuilder/IceCreamBuilder.csproj", new SampleTestData { BuildSolution = true, Solution = "ios10/IceCreamBuilder/IceCreamBuilder.sln" } },
				{ "ios11/ARKitPlacingObjects/PlacingObjects/PlacingObjects.csproj", new SampleTestData { BuildSolution = true, Solution = "ios11/ARKitPlacingObjects/PlacingObjects.sln" } },
				{ "ios11/WeatherWidget/WeatherWidget/WeatherWidget.csproj", new SampleTestData { BuildSolution = true, Solution = "ios11/WeatherWidget/WeatherWidget.sln" } },
				{ "ios12/SoupChef/SoupChef/SoupChef.csproj", new SampleTestData { BuildSolution = true, Solution = "ios12/SoupChef/SoupChef.sln" } },
				{ "ios12/XamarinShot/XamarinShot/XamarinShot.csproj", new SampleTestData { BuildSolution = true, Solution = "ios12/XamarinShot/XamarinShot.sln" } },
				{ "ios8/Lister/Lister/Lister.csproj", new SampleTestData { BuildSolution = true, Solution = "ios8/Lister/Lister.sln" } },
				{ "ios9/Emporium/Emporium/Emporium.csproj", new SampleTestData { BuildSolution = true, Solution = "ios9/Emporium/Emporium.sln" } },
				{ "ios9/iTravel/iTravel/iTravel.csproj", new SampleTestData { BuildSolution = true, Solution = "ios9/iTravel/iTravel.sln" } },
				{ "Profiling/MemoryDemo/MemoryDemo/MemoryDemo.csproj", new SampleTestData { BuildSolution = true, Solution = "Profiling/MemoryDemo/MemoryDemo.sln", DebugConfiguration = "Before-Debug", ReleaseConfiguration = "Before-Release" } },
				{ "WalkingGameCompleteiOS/WalkingGame.iOS/WalkingGame.iOS.csproj", new SampleTestData { BuildSolution = true, Solution = "WalkingGameCompleteiOS/WalkingGame.sln" } },
				{ "WalkingGameEmptyiOS/WalkingGame.iOS/WalkingGame.iOS.csproj", new SampleTestData { BuildSolution = true, Solution = "WalkingGameEmptyiOS/WalkingGame.sln" } },
				{ "watchOS/WatchConnectivity/WatchConnectivity/WatchConnectivity.csproj", new SampleTestData { BuildSolution = true, Solution = "watchOS/WatchConnectivity/WatchConnectivity.sln" } },
				{ "watchOS/WatchKitCatalog/WatchKitCatalog/WatchKitCatalog.csproj", new SampleTestData { BuildSolution = true, Solution = "watchOS/WatchKitCatalog/WatchKitCatalog.sln" } },

				// known failures
				{ "WatchKit/GpsWatch/GpsWatch/MainApp.csproj", new SampleTestData { KnownFailure = "error : Xcode 10 does not support watchOS 1 apps. Either upgrade to watchOS 2 apps, or use an older version of Xcode." } },
				{ "WatchKit/WatchNotifications/WatchNotifications_iOS/WatchNotifications_iOS.csproj", new SampleTestData { KnownFailure = "error : Xcode 10 does not support watchOS 1 apps. Either upgrade to watchOS 2 apps, or use an older version of Xcode." } },
				{ "PassKit/PassLibrary/PassLibrary.csproj", new SampleTestData { BuildSolution = true, Solution = "PassKit/PassLibrary/PassLibrary.sln", KnownFailure = "Requires custom provisioning to get a proper pass." } },
			};
		}
	}
}
