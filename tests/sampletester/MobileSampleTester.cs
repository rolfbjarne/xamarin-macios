using System.Collections.Generic;
using NUnit.Framework;

namespace Samples {
	[Category (CATEGORY)]
	public class MobileSampleTester : SampleTester {
		const string REPO = "mobile-samples";
		const string CATEGORY = "mobilesamples"; // categories can't contain dashes
		const string HASH = "origin/master";

		static string [] GetProjects ()
		{
			return GetExecutableProjects (REPO);
		}

		protected override Dictionary<string, SampleTestData> GetTestDataImpl ()
		{
			return new Dictionary<string, SampleTestData> {
				// Build solution instead of csproj
				{ "BouncingGame/BouncingGame/BouncingGame.iOS/BouncingGame.iOS.csproj", new SampleTestData { BuildSolution = true, Solution = "BouncingGame/BouncingGame.sln" } },
				{ "CCAction/ActionProject/ActionProject.iOS/ActionProject.iOS.csproj", new SampleTestData { BuildSolution = true, Solution = "CCAction/ActionProject.sln" } },
				{ "CCRenderTexture/RenderTextureExample/RenderTextureExample.iOS/RenderTextureExample.iOS.csproj", new SampleTestData { BuildSolution = true, Solution = "CCRenderTexture/RenderTextureExample.sln" } },
				{ "EmbeddedResources/EmbeddedResources/EmbeddedResources.iOS.csproj", new SampleTestData { BuildSolution = true, Solution = "EmbeddedResources/EmbeddedResources.sln" } },
				{ "FruityFalls/FruityFalls/FruityFalls.iOS/FruityFalls.iOS.csproj", new SampleTestData { BuildSolution = true, Solution = "FruityFalls/FruityFalls.sln" } },
				{ "LivePlayer/BasicCalculator/Calculator.iOS/Calculator.iOS.csproj", new SampleTestData { BuildSolution = true, Solution = "LivePlayer/BasicCalculator/Calculator.sln" } },
				{ "MonoGameTvOs/MonoGameTvOs/MonoGameTvOs.csproj", new SampleTestData { BuildSolution = true, Solution = "MonoGameTvOs/MonoGameTvOs.sln" } },
				{ "RazorTodo/RazorNativeTodo/RazorNativeTodo.iOS/RazorNativeTodo.iOS.csproj", new SampleTestData { BuildSolution = true, Solution = "RazorTodo/RazorNativeTodo/RazorNativeTodo.sln", KnownFailure = "There's a Xamarin.Android project in the solution, and I can't figure out how to build only the Xamarin.iOS project." } },
				{ "RazorTodo/RazorTodo/RazorTodo.iOS/RazorTodo.iOS.csproj", new SampleTestData { BuildSolution = true, Solution = "RazorTodo/RazorTodo/RazorTodo.sln", KnownFailure = "There's a Xamarin.Android project in the solution, and I can't figure out how to build only the Xamarin.iOS project." } },
				{ "SpriteSheetDemo/iOS/SpriteSheetDemo.iOS.csproj", new SampleTestData { BuildSolution = true, Solution = "SpriteSheetDemo/SpriteSheetDemo.sln" } },
				{ "TaskyPortable/TaskyiOS/TaskyiOS.csproj", new SampleTestData { BuildSolution = true, Solution = "TaskyPortable/TaskyPortable.sln" } },
				{ "TipCalc/TipCalc-UI-iOS/TipCalc-UI-iOS.csproj", new SampleTestData { BuildSolution = true, Solution = "TipCalc/TipCalc.sln" } },
				{ "VisualBasic/TaskyPortableVB/TaskyiOS/TaskyiOS.csproj", new SampleTestData { KnownFailure = "VisualBasic not supported on macOS: error MSB4057: The target \"Build\" does not exist in the project." } },
				{ "VisualBasic/XamarinFormsVB/XamarinForms.iOS/XamarinForms.iOS.csproj", new SampleTestData { KnownFailure = "VisualBasic not supported on macOS." } },
				{ "WebServices/WebServiceSamples/WebServices.RxNorm/src/WebServices.RxNormSample/WebServices.RxNormSample.csproj", new SampleTestData { KnownFailure = "Xamarin.iOS Classic isn't supported anymore." } },
			};
		}
	}
}
