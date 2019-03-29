using System.Collections.Generic;

using NUnit.Framework;

namespace Samples {
	[Category (CATEGORY)]
	public class IosSampleTester : SampleTester {
		const string REPO = "ios-samples"; // monotouch-samples redirects to ios-samples
		const string CATEGORY = "iossamples"; // categories can't contain dashes
		const string HASH = "origin/master";

		static Dictionary<string, SampleTest> test_data = new Dictionary<string, SampleTest> {
				// Build solution instead of csproj
				{ "BindingSample/XMBindingLibrarySample/XMBindingLibrarySample.csproj", new SampleTest { BuildSolution = true, Solution = "BindingSample/BindingSample.sln" } },
				{ "BouncingGameCompleteiOS/BouncingGame.iOS/BouncingGame.iOS.csproj", new SampleTest { BuildSolution = true, Solution = "BouncingGameCompleteiOS/BouncingGame.sln" } },
				{ "BouncingGameEmptyiOS/BouncingGame.iOS/BouncingGame.iOS.csproj", new SampleTest { BuildSolution = true, Solution = "BouncingGameEmptyiOS/BouncingGame.sln" } },
				{ "FileSystemSampleCode/FileSystem/FileSystem.csproj", new SampleTest { BuildSolution = true, Solution = "FileSystemSampleCode/WorkingWithTheFileSystem.sln" } },
				{ "InfColorPicker/InfColorPickerBinding/InfColorPickerSample/InfColorPickerSample.csproj", new SampleTest { BuildSolution = true, Solution = "InfColorPicker/InfColorPickerBinding/InfColorPickerBinding.sln" } },
				{ "ios10/ElizaChat/ElizaChat/ElizaChat.csproj", new SampleTest { BuildSolution = true, Solution = "ios10/ElizaChat/ElizaChat.sln" } },
				{ "ios10/IceCreamBuilder/IceCreamBuilder/IceCreamBuilder.csproj", new SampleTest { BuildSolution = true, Solution = "ios10/IceCreamBuilder/IceCreamBuilder.sln" } },
				{ "ios11/ARKitPlacingObjects/PlacingObjects/PlacingObjects.csproj", new SampleTest { BuildSolution = true, Solution = "ios11/ARKitPlacingObjects/PlacingObjects.sln" } },
				{ "ios11/WeatherWidget/WeatherWidget/WeatherWidget.csproj", new SampleTest { BuildSolution = true, Solution = "ios11/WeatherWidget/WeatherWidget.sln" } },
				{ "ios12/SoupChef/SoupChef/SoupChef.csproj", new SampleTest { BuildSolution = true, Solution = "ios12/SoupChef/SoupChef.sln" } },
				{ "ios12/XamarinShot/XamarinShot/XamarinShot.csproj", new SampleTest { BuildSolution = true, Solution = "ios12/XamarinShot/XamarinShot.sln" } },
				{ "ios8/Lister/Lister/Lister.csproj", new SampleTest { BuildSolution = true, Solution = "ios8/Lister/Lister.sln" } },
				{ "ios9/iTravel/iTravel/iTravel.csproj", new SampleTest { BuildSolution = true, Solution = "ios9/iTravel/iTravel.sln" } },
				{ "Profiling/MemoryDemo/MemoryDemo/MemoryDemo.csproj", new SampleTest { BuildSolution = true, Solution = "Profiling/MemoryDemo/MemoryDemo.sln", DebugConfigurations = new string [] { "Before-Debug", "After-Debug" }, ReleaseConfigurations = new string [] { "Before-Release", "After-Release" } } },
				{ "WalkingGameCompleteiOS/WalkingGame.iOS/WalkingGame.iOS.csproj", new SampleTest { BuildSolution = true, Solution = "WalkingGameCompleteiOS/WalkingGame.sln" } },
				{ "WalkingGameEmptyiOS/WalkingGame.iOS/WalkingGame.iOS.csproj", new SampleTest { BuildSolution = true, Solution = "WalkingGameEmptyiOS/WalkingGame.sln" } },
				{ "watchOS/WatchConnectivity/WatchConnectivity/WatchConnectivity.csproj", new SampleTest { BuildSolution = true, Solution = "watchOS/WatchConnectivity/WatchConnectivity.sln" } },
				{ "watchOS/WatchKitCatalog/WatchKitCatalog/WatchKitCatalog.csproj", new SampleTest { BuildSolution = true, Solution = "watchOS/WatchKitCatalog/WatchKitCatalog.sln" } },

				// known failures
				{ "ios9/Emporium/Emporium/Emporium.csproj", new SampleTest { BuildSolution = true, Solution = "ios9/Emporium/Emporium.sln", KnownFailure = "error : Xcode 10 does not support watchOS 1 apps. Either upgrade to watchOS 2 apps, or use an older version of Xcode." } },
				{ "WatchKit/GpsWatch/GpsWatch/MainApp.csproj", new SampleTest { KnownFailure = "error : Xcode 10 does not support watchOS 1 apps. Either upgrade to watchOS 2 apps, or use an older version of Xcode." } },
				{ "WatchKit/WatchNotifications/WatchNotifications_iOS/WatchNotifications_iOS.csproj", new SampleTest { KnownFailure = "error : Xcode 10 does not support watchOS 1 apps. Either upgrade to watchOS 2 apps, or use an older version of Xcode." } },
				{ "PassKit/PassLibrary/PassLibrary.csproj", new SampleTest { BuildSolution = true, Solution = "PassKit/PassLibrary/PassLibrary.sln", KnownFailure = "Requires custom provisioning to get a proper pass." } },
			};

		static IEnumerable<SampleTestData> GetSampleData ()
		{
			return GetSampleTestData (test_data, REPO);
		}
	}

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

	[Category (CATEGORY)]
	public class MacSampleTester : SampleTester {
		const string REPO = "mac-samples";
		const string CATEGORY = "macsamples"; // categories can't contain dashes
		const string HASH = "origin/master";

		static IEnumerable<SampleTestData> GetSampleData ()
		{
			return GetSampleTestData (null, REPO);
		}
	}

	[Category (CATEGORY)]
	public class MobileSampleTester : SampleTester {
		const string REPO = "mobile-samples";
		const string CATEGORY = "mobilesamples"; // categories can't contain dashes
		const string HASH = "origin/master";

		static Dictionary<string, SampleTest> test_data = new Dictionary<string, SampleTest> {
				// Build solution instead of csproj
				{ "BouncingGame/BouncingGame/BouncingGame.iOS/BouncingGame.iOS.csproj", new SampleTest { BuildSolution = true, Solution = "BouncingGame/BouncingGame.sln" } },
				{ "CCAction/ActionProject/ActionProject.iOS/ActionProject.iOS.csproj", new SampleTest { BuildSolution = true, Solution = "CCAction/ActionProject.sln" } },
				{ "CCRenderTexture/RenderTextureExample/RenderTextureExample.iOS/RenderTextureExample.iOS.csproj", new SampleTest { BuildSolution = true, Solution = "CCRenderTexture/RenderTextureExample.sln" } },
				{ "EmbeddedResources/EmbeddedResources/EmbeddedResources.iOS.csproj", new SampleTest { BuildSolution = true, Solution = "EmbeddedResources/EmbeddedResources.sln" } },
				{ "FruityFalls/FruityFalls/FruityFalls.iOS/FruityFalls.iOS.csproj", new SampleTest { BuildSolution = true, Solution = "FruityFalls/FruityFalls.sln" } },
				{ "LivePlayer/BasicCalculator/Calculator.iOS/Calculator.iOS.csproj", new SampleTest { BuildSolution = true, Solution = "LivePlayer/BasicCalculator/Calculator.sln" } },
				{ "MonoGameTvOs/MonoGameTvOs/MonoGameTvOs.csproj", new SampleTest { BuildSolution = true, Solution = "MonoGameTvOs/MonoGameTvOs.sln" } },
				{ "RazorTodo/RazorNativeTodo/RazorNativeTodo.iOS/RazorNativeTodo.iOS.csproj", new SampleTest { BuildSolution = true, Solution = "RazorTodo/RazorNativeTodo/RazorNativeTodo.sln", KnownFailure = "There's a Xamarin.Android project in the solution, and I can't figure out how to build only the Xamarin.iOS project." } },
				{ "RazorTodo/RazorTodo/RazorTodo.iOS/RazorTodo.iOS.csproj", new SampleTest { BuildSolution = true, Solution = "RazorTodo/RazorTodo/RazorTodo.sln", KnownFailure = "There's a Xamarin.Android project in the solution, and I can't figure out how to build only the Xamarin.iOS project." } },
				{ "SpriteSheetDemo/iOS/SpriteSheetDemo.iOS.csproj", new SampleTest { BuildSolution = true, Solution = "SpriteSheetDemo/SpriteSheetDemo.sln" } },
				{ "TaskyPortable/TaskyiOS/TaskyiOS.csproj", new SampleTest { BuildSolution = true, Solution = "TaskyPortable/TaskyPortable.sln" } },
				{ "TipCalc/TipCalc-UI-iOS/TipCalc-UI-iOS.csproj", new SampleTest { BuildSolution = true, Solution = "TipCalc/TipCalc.sln" } },
				{ "VisualBasic/TaskyPortableVB/TaskyiOS/TaskyiOS.csproj", new SampleTest { KnownFailure = "VisualBasic not supported on macOS: error MSB4057: The target \"Build\" does not exist in the project." } },
				{ "VisualBasic/XamarinFormsVB/XamarinForms.iOS/XamarinForms.iOS.csproj", new SampleTest { KnownFailure = "VisualBasic not supported on macOS." } },
				{ "WebServices/WebServiceSamples/WebServices.RxNorm/src/WebServices.RxNormSample/WebServices.RxNormSample.csproj", new SampleTest { KnownFailure = "Xamarin.iOS Classic isn't supported anymore." } },
			};

		static IEnumerable<SampleTestData> GetSampleData ()
		{
			return GetSampleTestData (test_data, REPO);
		}
	}

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


	[Category (CATEGORY)]
	public class XamarinFormsBooksTester : SampleTester {
		const string REPO = "xamarin-forms-book-samples";
		const string CATEGORY = "xamarinformsbookssamples"; // categories can't contain dashes
		const string HASH = "origin/master";

		static IEnumerable<SampleTestData> GetSampleData ()
		{
			return GetSampleTestData (null, REPO);
		}
	}
}
