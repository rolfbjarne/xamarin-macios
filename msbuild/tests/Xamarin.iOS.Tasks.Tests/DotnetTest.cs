using System;
using System.IO;
using System.Linq;

using NUnit.Framework;

namespace Xamarin.iOS.Tasks {

	[TestFixture]
	//[TestFixture ("iPhoneSimulator")]
	//[TestFixture ("iPhoneSimulator")]
	public class DotnetTest : ProjectTest {
		public DotnetTest ()
			: base ("iPhoneSimulator")
		{
		}

		string tfi;
		public override string TargetFrameworkIdentifier {
			get {
				return tfi ?? base.TargetFrameworkIdentifier;
			}
		}

		[Test]
		[TestCase ("AppWithExtraArgumentThatOverrides")]
		////[TestCase ("Bug60536")] // Supposed to fail the build
		[TestCase ("My Spaced App")]
		[TestCase ("MyAppWithPackageReference")]
		[TestCase ("MyCoreMLApp")]
		[TestCase ("MyIBToolLinkTest")]
		[TestCase ("MyLinkedAssets")]
		[TestCase ("MyMasterDetailApp")]
		[TestCase ("MyMetalGame")]
		[TestCase ("MyOpenGLApp")]
		[TestCase ("MyReleaseBuild")]
		[TestCase ("MySceneKitApp")]
		[TestCase ("MySingleView")]
		[TestCase ("MySpriteKitGame")]
		[TestCase ("MyTVApp")]
		[TestCase ("MyTabbedApplication")]
		[TestCase ("MyWatch2Container")]
		[TestCase ("MyWebViewApp")]
		[TestCase ("MyXamarinFormsApp")]
		[TestCase ("MyiOSAppWithBinding")]
		public void CompareBuilds (string project)
		{
			var net461 = GetTestDirectory ("net461");
			var dotnet = GetTestDirectory ("dotnet");
			FixupTestFiles (dotnet, "dotnet5");

			tfi = "Xamarin.iOS";
			switch (project) {
			case "MyXamarinFormsApp":
				NugetRestore (Path.Combine (net461, project, "MyXamarinFormsAppNS", "MyXamarinFormsAppNS.csproj"));
				break;
			case "MyAppWithPackageReference":
				NugetRestore (Path.Combine (net461, "MyExtensionWithPackageReference", "MyExtensionWithPackageReference.csproj"));
				break;
			case "MyMetalGame":
				if (Platform == "iPhoneSimulator")
					Assert.Ignore ("The iOS Simulator does not support metal. Build for a device instead.");
				break;
			case "MyTVApp":
				tfi = "Xamarin.TVOS";
				break;
			case "MyWatch2Container":
				tfi = "Xamarin.iOS"; // The executable project is still an iOS project
				break;
			}

			Console.WriteLine ("Building net461");
			BuildProject (project, Platform, "Debug", projectBaseDir: net461, use_dotnet: false, nuget_restore: true);
			Console.WriteLine ("Done building net461");
			var net461_bundle = AppBundlePath;

			Console.WriteLine ("Building dotnet");
			BuildProject (project, Platform, "Debug", projectBaseDir: dotnet, use_dotnet: true);
			Console.WriteLine ("Done building dotnet");
			var dotnet_bundle = AppBundlePath;

			var net461_files = Directory.GetFiles (net461_bundle, "*.*", SearchOption.AllDirectories).Select ((v) => v.Substring (net461_bundle.Length + 1));
			var dotnet_files = Directory.GetFiles (dotnet_bundle, "*.*", SearchOption.AllDirectories).Select ((v) => v.Substring (dotnet_bundle.Length + 1));

			var extra_net461_files = net461_files.Except (dotnet_files);
			var extra_dotnet_files = dotnet_files.Except (net461_files);

			Console.WriteLine ($"net461: {net461_bundle}");
			Console.WriteLine ($"dotnet: {dotnet_bundle}");

			Assert.That (extra_dotnet_files, Is.Empty, "Extra dotnet files");
			Assert.That (extra_net461_files, Is.Empty, "Missing dotnet files");

			var total_diff = 0L;
			foreach (var file in dotnet_files) {
				var dotnet_size = new FileInfo (Path.Combine (dotnet_bundle, file)).Length;
				var net461_size = new FileInfo (Path.Combine (net461_bundle, file)).Length;
				if (dotnet_size == net461_size)
					continue;
				var diff = dotnet_size - net461_size;
				Console.WriteLine ($"{file}: {net461_size} bytes -> {dotnet_size} bytes. Diff: {diff}");
				total_diff += diff;
			}  
			Console.WriteLine ($"Size comparison complete, size diff: {total_diff}");
		}
	}
}
