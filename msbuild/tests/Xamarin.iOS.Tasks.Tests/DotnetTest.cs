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

		[Test]
		// OK [TestCase ("AppWithExtraArgumentThatOverrides")]
		////[TestCase ("Bug60536")] // Supposed to fail the build
		// OK [TestCase ("My Spaced App")]
		// OK [TestCase ("MyAppWithPackageReference")]
		// OK [TestCase ("MyCoreMLApp")]
		// OK [TestCase ("MyIBToolLinkTest")]
		// OK [TestCase ("MyLinkedAssets")]
		// OK [TestCase ("MyMasterDetailApp")]
		// PENDING - DEVICE ONLY [TestCase ("MyMetalGame")] // The iOS Simulator does not support metal. Build for a device instead.
		// OK [TestCase ("MyOpenGLApp")]
		// OK [TestCase ("MyReleaseBuild")]
		// OK [TestCase ("MySceneKitApp")]
		// OK [TestCase ("MySingleView")]
		// OK [TestCase ("MySpriteKitGame")]
		////[TestCase ("MyTVApp")] // Apple TV - not yet
		// OK [TestCase ("MyTabbedApplication")]
		////[TestCase ("MyWatch2Container")] // watchOS - not yet
		// OK [TestCase ("MyWebViewApp")]
		// OK [TestCase ("MyXamarinFormsApp")]
		// OK [TestCase ("MyiOSAppWithBinding")]
		public void CompareBuilds (string project)
		{
			var net461 = GetTestDirectory ("net461");
			var dotnet = GetTestDirectory ("dotnet");
			FixupTestFiles (dotnet, "dotnet5");


			switch (project) {
			case "MyXamarinFormsApp":
				NugetRestore (Path.Combine (net461, project, "MyXamarinFormsAppNS", "MyXamarinFormsAppNS.csproj"));
				break;
			case "MyAppWithPackageReference":
				NugetRestore (Path.Combine (net461, "MyExtensionWithPackageReference", "MyExtensionWithPackageReference.csproj"));
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
