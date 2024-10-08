using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using NUnit.Framework;

using Xamarin.MacDev;
using Xamarin.MacDev.Tasks;
using Xamarin.Tests;
using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks {
	[TestFixture]
	public class ACBToolTaskTests : TestBase {
		ACTool CreateACToolTask (ApplePlatform framework, string projectDir, string intermediateOutputPath, params string[] imageAssets)
		{
			var sdk = Sdks.GetSdk (framework);
			var version = AppleSdkVersion.GetDefault (sdk, false);
			var root = sdk.GetSdkPath (version, false);
			var usr = Path.Combine (sdk.DeveloperRoot, "usr");
			var bin = Path.Combine (usr, "bin");
			string platform;

			switch (framework) {
			case ApplePlatform.TVOS:
				platform = "AppleTVOS";
				break;
			case ApplePlatform.iOS:
				platform = "iPhoneOS";
				break;
			default:
				throw new NotImplementedException (framework.ToString ());
			}

			var task = CreateTask<ACTool> ();
			task.imageAssets = imageAssets.Select (v => new TaskItem (v));
			task.IntermediateOutputPath = intermediateOutputPath;
			task.OutputPath = Path.Combine (intermediateOutputPath, "OutputPath");
			task.ProjectDir = projectDir;
			task.SdkDevPath = Configuration.xcode_root;
			task.SdkPlatform = platform;
			task.SdkVersion = version.ToString ();
			task.SdkUsrPath = usr;
			task.SdkBinPath = bin;
			task.SdkRoot = root;
			return task;
		}

		[Test]
		public void TestAppIcon ()
		{
			var tmp = Cache.CreateTemporaryDirectory ();

			var srcdir = Path.Combine (Configuration.TestProjectsDirectory, "MyIBToolLinkTest");
			var ibtool = CreateACToolTask (ApplePlatform.iOS, srcdir, tmp);
			var bundleResources = new HashSet<string> ();

			Assert.IsTrue (ibtool.Execute (), "Execution of IBTool task failed.");

			foreach (var bundleResource in ibtool.BundleResources) {
				Assert.IsTrue (File.Exists (bundleResource.ItemSpec), "File does not exist: {0}", bundleResource.ItemSpec);
				Assert.That (bundleResource.GetMetadata ("LogicalName"), Is.Not.Null.Or.Empty, "The 'LogicalName' metadata must be set.");
				Assert.That (bundleResource.GetMetadata ("Optimize"), Is.Not.Null.Or.Empty, "The 'Optimize' metadata must be set.");

				bundleResources.Add (bundleResource.GetMetadata ("LogicalName"));
			}

			string [] expected = {
				"LaunchScreen.nib",
				"Main.storyboardc/UIViewController-BYZ-38-t0r.nib",
				"Main.storyboardc/BYZ-38-t0r-view-8bC-Xf-vdC.nib",
				"Main.storyboardc/Info.plist",
			};

			var inexistentResource = bundleResources.Except (expected).ToArray ();
			var unexpectedResource = expected.Except (bundleResources).ToArray ();

			Assert.That (inexistentResource, Is.Empty, "No missing resources");
			Assert.That (unexpectedResource, Is.Empty, "No extra resources");
		}

	}
}
