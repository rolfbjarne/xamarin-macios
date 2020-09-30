using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using NUnit.Framework;

using Xamarin.Tests;

namespace Xamarin.iOS.Tasks {
	[TestFixture ("iPhone")]
	[TestFixture ("iPhoneSimulator")]
	public class NativeReferencesTests : ProjectTest {
		
		public NativeReferencesTests (string platform) : base (platform)      
		{
		}

		[Test]
		public void BasicTest ()
		{
			var mtouchPaths = SetupProjectPaths ("MyTabbedApplication");

			Engine.ProjectCollection.SetGlobalProperty ("Platform", Platform);

			var csproj = new XmlDocument ();
			csproj.Load (mtouchPaths.ProjectCSProjPath);

			// Inject a NativeReference
			var xml = @$"
<Project xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
	<ItemGroup>
		<NativeReference Include=""{Path.Combine (Configuration.RootPath, "tests", "test-libraries", ".libs", "ios-fat", "XTest.framework")}"">
			<IsCxx>False</IsCxx>
			<Kind>Framework</Kind>
		</NativeReference>
	</ItemGroup>
</Project>
";
			var insertDoc = new XmlDocument ();
			insertDoc.LoadXml (xml);
			var itemGroup = insertDoc.SelectSingleNode ("./*[local-name() = 'Project']/*[local-name() = 'ItemGroup']");
			var projectNode = csproj.SelectSingleNode ("./*[local-name() = 'Project']");
			projectNode.AppendChild (csproj.ImportNode (itemGroup, true));

			csproj.Save (mtouchPaths.ProjectCSProjPath);

			MonoTouchProject = mtouchPaths;

			RunTarget (mtouchPaths, "Clean", 0);
			RunTarget (mtouchPaths, "Build", 0);

			Assert.That (Directory.Exists (Path.Combine (AppBundlePath, "Frameworks", "XTest.framework")), "Frameworks/XTest.framework");
			Assert.That (File.Exists (Path.Combine (AppBundlePath, "Frameworks", "XTest.framework", "XTest")), "Frameworks/XTest.framework/XTest");
		}

		[Test]
		public void WithIncrementalBuilds ()
		{
			if (Platform.Contains ("Simulator"))
				return; // incremental builds on the simulator doesn't make much sense.

			var mtouchPaths = SetupProjectPaths ("MyiOSAppWithBinding");

			Engine.ProjectCollection.SetGlobalProperty ("Platform", Platform);

			var properties = new Dictionary<string, string> {
				{ "MtouchFastDev", "true" },
				{ "MtouchExtraArgs", "-vvvv" },
				{ "MtouchArch", "ARM64" }, // only use ARM64 to speed up the build.
				{ "MtouchLink", "Full" }, // also to speed up the build.
			};

			MonoTouchProject = mtouchPaths;

			RunTarget (mtouchPaths, "Clean", properties: properties);
			RunTarget (mtouchPaths, "Build", properties: properties);

			Assert.That (Directory.Exists (Path.Combine (AppBundlePath, "Frameworks", "XTest.framework")), "Frameworks/XTest.framework");
			Assert.That (File.Exists (Path.Combine (AppBundlePath, "Frameworks", "XTest.framework", "XTest")), "Frameworks/XTest.framework/XTest");
		}
	}
}

