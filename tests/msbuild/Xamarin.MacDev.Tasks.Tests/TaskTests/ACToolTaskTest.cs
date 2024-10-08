// using System;
// using System.IO;
// using System.Linq;
// using System.Collections.Generic;

// using Microsoft.Build.Framework;
// using Microsoft.Build.Utilities;

// using NUnit.Framework;

// using Xamarin.MacDev;
// using Xamarin.MacDev.Tasks;
// using Xamarin.Tests;
// using Xamarin.Utils;

// namespace Xamarin.MacDev.Tasks {
// 	[TestFixture]
// 	public class ACBToolTaskTests : TestBase {
// 		ACTool CreateACToolTask (ApplePlatform framework, string projectDir, out string intermediateOutputPath, params string[] imageAssets)
// 		{
// 			intermediateOutputPath = Cache.CreateTemporaryDirectory ();

// 			var sdk = Sdks.GetSdk (framework);
// 			var version = AppleSdkVersion.GetDefault (sdk, false);
// 			var root = sdk.GetSdkPath (version, false);
// 			var usr = Path.Combine (sdk.DeveloperRoot, "usr");
// 			var bin = Path.Combine (usr, "bin");
// 			string platform;

// 			switch (framework) {
// 			case ApplePlatform.TVOS:
// 				platform = "AppleTVOS";
// 				break;
// 			case ApplePlatform.iOS:
// 				platform = "iPhoneOS";
// 				break;
// 			default:
// 				throw new NotImplementedException (framework.ToString ());
// 			}

// 			var task = CreateTask<ACTool> ();
// 			task.ImageAssets = imageAssets
// 				.Select (v => {
// 					var spl = v.Split ('|');
// 					var rv = new TaskItem (spl [0]);
// 					rv.SetMetadata ("Link", spl [1]);
// 					return rv;
// 				})
// 				.Cast<ITaskItem> ()
// 				.ToArray ();
// 			task.IntermediateOutputPath = intermediateOutputPath;
// 			task.OutputPath = Path.Combine (intermediateOutputPath, "OutputPath");
// 			task.ProjectDir = projectDir;
// 			task.SdkDevPath = Configuration.xcode_root;
// 			task.SdkPlatform = platform;
// 			task.SdkVersion = version.ToString ();
// 			task.SdkUsrPath = usr;
// 			task.SdkBinPath = bin;
// 			task.TargetFrameworkMoniker = TargetFramework.GetTargetFramework (framework, true).ToString ();
// 			task.ToolExe = "true"; // don't actually execute 'actool'
// 			return task;
// 		}

// 		[Test]
// 		public void DefaultAppIcons ()
// 		{
// 			var platform = ApplePlatform.iOS;
// 			var projectDir = Path.Combine (Configuration.SourceRoot, "tests", "dotnet", "AppWithXCAssets", platform.AsString ());
// 			var actool = CreateACToolTask (
// 				platform,
// 				projectDir,
// 				out var _,
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "Contents.json") + "|Resources/Images.xcassets/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon32.png"
// 			);
// 			ExecuteTask (actool);

// 			Assert.IsNull (actool.AppIconsManifest, "AppIconsManifest");
// 			Assert.IsNull (actool.PartialAppManifest, "PartialAppManifest");
// 		}

// 		[Test]
// 		public void AllAppIcons ()
// 		{
// 			var platform = ApplePlatform.iOS;
// 			var projectDir = Path.Combine (Configuration.SourceRoot, "tests", "dotnet", "AppWithXCAssets", platform.AsString ());
// 			var actool = CreateACToolTask (
// 				platform,
// 				projectDir,
// 				out var _,
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "Contents.json") + "|Resources/Images.xcassets/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon32.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon32.png"
// 			);
// 			actool.IncludeAllAppIcons = true;

// 			ExecuteTask (actool);

// 			Assert.IsNotNull (actool.AppIconsManifest, "AppIconsManifest");
// 			Assert.IsNull (actool.PartialAppManifest, "PartialAppManifest");

// 			var appIconsManifest = PDictionary.FromFile (actool.AppIconsManifest.ItemSpec!)!;
// 			var cfBundleIcons = appIconsManifest.Get<PDictionary> ("CFBundleIcons");
// 			Assert.IsNotNull (cfBundleIcons, "CFBundleIcons");
// 			Assert.IsFalse (cfBundleIcons.ContainsKey ("CFBundlePrimaryIcon"), "CFBundlePrimaryIcon");
// 			var cfBundleAlternateIcons = cfBundleIcons.Get<PDictionary> ("CFBundleAlternateIcons");
// 			Assert.IsNotNull (cfBundleAlternateIcons, "CFBundleAlternateIcons");
// 			Assert.AreEqual (2, cfBundleAlternateIcons.Count, "CFBundleAlternateIcons.Count");

// 			var alternateAppIcons1 = cfBundleAlternateIcons.Get<PDictionary> ("AppIcons");
// 			Assert.IsNotNull (alternateAppIcons1, "AppIcons");
// 			Assert.AreEqual ("AppIcons", alternateAppIcons1.Get<PString> ("CFBundleIconName")?.Value, "CFBundleIconName");

// 			var alternateAppIcons2 = cfBundleAlternateIcons.Get<PDictionary> ("AlternateAppIcons");
// 			Assert.IsNotNull (alternateAppIcons2, "AlternateAppIcons");
// 			Assert.AreEqual ("AlternateAppIcons", alternateAppIcons2.Get<PString> ("CFBundleIconName")?.Value, "CFBundleIconName");
// 		}

// 		[Test]
// 		public void AllAppIconsWithAppIcon ()
// 		{
// 			var platform = ApplePlatform.iOS;
// 			var projectDir = Path.Combine (Configuration.SourceRoot, "tests", "dotnet", "AppWithXCAssets", platform.AsString ());
// 			var actool = CreateACToolTask (
// 				platform,
// 				projectDir,
// 				out var _,
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "Contents.json") + "|Resources/Images.xcassets/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon32.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon32.png"
// 			);
// 			actool.IncludeAllAppIcons = true;
// 			actool.AppIcon = "AlternateAppIcons";

// 			ExecuteTask (actool);

// 			Assert.IsNotNull (actool.AppIconsManifest, "AppIconsManifest");
// 			Assert.IsNull (actool.PartialAppManifest, "PartialAppManifest");

// 			var appIconsManifest = PDictionary.FromFile (actool.AppIconsManifest.ItemSpec!)!;
// 			var cfBundleIcons = appIconsManifest.Get<PDictionary> ("CFBundleIcons");
// 			Assert.IsNotNull (cfBundleIcons, "CFBundleIcons");

// 			var cfBundlePrimaryIcon = cfBundleIcons.Get<PDictionary> ("CFBundlePrimaryIcon");
// 			Assert.IsNotNull (cfBundlePrimaryIcon, "CFBundlePrimaryIcon");
// 			var cfBundleIconFiles = cfBundlePrimaryIcon.Get<PArray> ("CFBundleIconFiles");
// 			Assert.IsNotNull (cfBundleIconFiles, "CFBundleIconFiles");
// 			Assert.AreEqual (1, cfBundleIconFiles.Count, "CFBundleIconFiles.Length");
// 			Assert.AreEqual ("AppIcon60x60", ((PString) cfBundleIconFiles [0]).Value, "CFBundleIconFiles[0].Value");
// 			Assert.AreEqual ("AlternateAppIcons", cfBundlePrimaryIcon.Get<PString> ("CFBundleIconName")?.Value, "CFBundleIconName");

// 			var cfBundleAlternateIcons = cfBundleIcons.Get<PDictionary> ("CFBundleAlternateIcons");
// 			Assert.IsNotNull (cfBundleAlternateIcons, "CFBundleAlternateIcons");
// 			Assert.AreEqual (1, cfBundleAlternateIcons.Count, "CFBundleAlternateIcons.Count");

// 			var alternateAppIcons1 = cfBundleAlternateIcons.Get<PDictionary> ("AppIcons");
// 			Assert.IsNotNull (alternateAppIcons1, "AppIcons");
// 			Assert.AreEqual ("AppIcons", alternateAppIcons1.Get<PString> ("CFBundleIconName")?.Value, "CFBundleIconName");
// 		}

// 		[Test]
// 		public void AppIcon ()
// 		{
// 			var platform = ApplePlatform.iOS;
// 			var projectDir = Path.Combine (Configuration.SourceRoot, "tests", "dotnet", "AppWithXCAssets", platform.AsString ());
// 			var actool = CreateACToolTask (
// 				platform,
// 				projectDir,
// 				out var _,
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "Contents.json") + "|Resources/Images.xcassets/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon32.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon32.png"
// 			);
// 			actool.AppIcon = "AppIcons";

// 			ExecuteTask (actool);

// 			Assert.IsNotNull (actool.AppIconsManifest, "AppIconsManifest");
// 			Assert.IsNull (actool.PartialAppManifest, "PartialAppManifest");

// 			Console.WriteLine (actool.AppIconsManifest);

// 			var appIconsManifest = PDictionary.FromFile (actool.AppIconsManifest.ItemSpec!)!;
// 			var cfBundleIcons = appIconsManifest.Get<PDictionary> ("CFBundleIcons");
// 			Assert.IsNotNull (cfBundleIcons, "CFBundleIcons");
// 			Assert.IsFalse (cfBundleIcons.ContainsKey ("CFBundleAlternateIcons"), "CFBundleAlternateIcons");
// 			var cfBundlePrimaryIcon = cfBundleIcons.Get<PDictionary> ("CFBundlePrimaryIcon");
// 			Assert.IsNotNull (cfBundlePrimaryIcon, "CFBundlePrimaryIcon");
// 			var cfBundleIconFiles = cfBundlePrimaryIcon.Get<PArray> ("CFBundleIconFiles");
// 			Assert.IsNotNull (cfBundleIconFiles, "CFBundleIconFiles");
// 			Assert.AreEqual (1, cfBundleIconFiles.Count, "CFBundleIconFiles.Length");
// 			Assert.AreEqual ("AppIcon60x60", ((PString) cfBundleIconFiles [0]).Value, "CFBundleIconFiles[0].Value");
// 			Assert.AreEqual ("AppIcons", cfBundlePrimaryIcon.Get<PString> ("CFBundleIconName")?.Value, "CFBundleIconName");
// 		}

// 		[Test]
// 		public void AppIconAndAlternateIcons ()
// 		{
// 			var platform = ApplePlatform.iOS;
// 			var projectDir = Path.Combine (Configuration.SourceRoot, "tests", "dotnet", "AppWithXCAssets", platform.AsString ());
// 			var actool = CreateACToolTask (
// 				platform,
// 				projectDir,
// 				out var _,
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "Contents.json") + "|Resources/Images.xcassets/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon32.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon32.png"
// 			);
// 			actool.AppIcon = "AppIcons";
// 			actool.AlternateAppIcons = new ITaskItem [] { new TaskItem ("AlternateAppIcons")};

// 			ExecuteTask (actool);

// 			Assert.IsNotNull (actool.AppIconsManifest, "AppIconsManifest");
// 			Assert.IsNull (actool.PartialAppManifest, "PartialAppManifest");

// 			Console.WriteLine (actool.AppIconsManifest);

// 			var appIconsManifest = PDictionary.FromFile (actool.AppIconsManifest.ItemSpec!)!;
// 			var cfBundleIcons = appIconsManifest.Get<PDictionary> ("CFBundleIcons");
// 			Assert.IsNotNull (cfBundleIcons, "CFBundleIcons");

// 			var cfBundleAlternateIcons = cfBundleIcons.Get<PDictionary> ("CFBundleAlternateIcons");
// 			Assert.IsNotNull (cfBundleAlternateIcons, "CFBundleAlternateIcons");
// 			Assert.AreEqual (1, cfBundleAlternateIcons.Count, "CFBundleAlternateIcons.Count");
// 			var alternateAppIcons = cfBundleAlternateIcons.Get<PDictionary> ("AlternateAppIcons");
// 			Assert.IsNotNull (alternateAppIcons, "AlternateAppIcons");
// 			Assert.AreEqual ("AlternateAppIcons", alternateAppIcons.Get<PString> ("CFBundleIconName")?.Value, "CFBundleIconName");

// 			var cfBundlePrimaryIcon = cfBundleIcons.Get<PDictionary> ("CFBundlePrimaryIcon");
// 			Assert.IsNotNull (cfBundlePrimaryIcon, "CFBundlePrimaryIcon");
// 			var cfBundleIconFiles = cfBundlePrimaryIcon.Get<PArray> ("CFBundleIconFiles");
// 			Assert.IsNotNull (cfBundleIconFiles, "CFBundleIconFiles");
// 			Assert.AreEqual (1, cfBundleIconFiles.Count, "CFBundleIconFiles.Length");
// 			Assert.AreEqual ("AppIcon60x60", ((PString) cfBundleIconFiles [0]).Value, "CFBundleIconFiles[0].Value");
// 			Assert.AreEqual ("AppIcons", cfBundlePrimaryIcon.Get<PString> ("CFBundleIconName")?.Value, "CFBundleIconName");
// 		}

// 		[Test]
// 		public void AlternateIcons ()
// 		{
// 			var platform = ApplePlatform.iOS;
// 			var projectDir = Path.Combine (Configuration.SourceRoot, "tests", "dotnet", "AppWithXCAssets", platform.AsString ());
// 			var actool = CreateACToolTask (
// 				platform,
// 				projectDir,
// 				out var _,
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "Contents.json") + "|Resources/Images.xcassets/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon32.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon32.png"
// 			);
// 			actool.AlternateAppIcons = new ITaskItem [] { new TaskItem ("AlternateAppIcons")};

// 			ExecuteTask (actool);

// 			Assert.IsNotNull (actool.AppIconsManifest, "AppIconsManifest");
// 			Assert.IsNull (actool.PartialAppManifest, "PartialAppManifest");

// 			Console.WriteLine (actool.AppIconsManifest);

// 			var appIconsManifest = PDictionary.FromFile (actool.AppIconsManifest.ItemSpec!)!;
// 			var cfBundleIcons = appIconsManifest.Get<PDictionary> ("CFBundleIcons");
// 			Assert.IsNotNull (cfBundleIcons, "CFBundleIcons");

// 			var cfBundleAlternateIcons = cfBundleIcons.Get<PDictionary> ("CFBundleAlternateIcons");
// 			Assert.IsNotNull (cfBundleAlternateIcons, "CFBundleAlternateIcons");
// 			Assert.AreEqual (1, cfBundleAlternateIcons.Count, "CFBundleAlternateIcons.Count");
// 			var alternateAppIcons = cfBundleAlternateIcons.Get<PDictionary> ("AlternateAppIcons");
// 			Assert.IsNotNull (alternateAppIcons, "AlternateAppIcons");
// 			Assert.AreEqual ("AlternateAppIcons", alternateAppIcons.Get<PString> ("CFBundleIconName")?.Value, "CFBundleIconName");

// 			Assert.IsFalse (cfBundleIcons.ContainsKey ("CFBundlePrimaryIcon"), "CFBundlePrimaryIcon");
// 		}

// 		[Test]
// 		public void InexistentAppIcon ()
// 		{
// 			var platform = ApplePlatform.iOS;
// 			var projectDir = Path.Combine (Configuration.SourceRoot, "tests", "dotnet", "AppWithXCAssets", platform.AsString ());
// 			var actool = CreateACToolTask (
// 				platform,
// 				projectDir,
// 				out var _,
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "Contents.json") + "|Resources/Images.xcassets/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon32.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon32.png"
// 			);
// 			actool.AppIcon = "InexistentAppIcons";

// 			ExecuteTask (actool, 1);
// 			Assert.AreEqual ("Can't find the AppIcon 'InexistentAppIcons' among the image resources.", Engine.Logger.ErrorEvents [0].Message, "Error message");
// 		}

// 		[Test]
// 		public void InexistentAlternateIcons ()
// 		{
// 			var platform = ApplePlatform.iOS;
// 			var projectDir = Path.Combine (Configuration.SourceRoot, "tests", "dotnet", "AppWithXCAssets", platform.AsString ());
// 			var actool = CreateACToolTask (
// 				platform,
// 				projectDir,
// 				out var _,
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "Contents.json") + "|Resources/Images.xcassets/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon32.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon32.png"
// 			);
// 			actool.AlternateAppIcons = new ITaskItem [] { new TaskItem ("InexistentAlternateAppIcons")};

// 			ExecuteTask (actool, 1);
// 			Assert.AreEqual ("Can't find the AlternateAppIcon 'InexistentAlternateAppIcons' among the image resources.", Engine.Logger.ErrorEvents [0].Message, "Error message");
// 		}

// 		[Test]
// 		public void BothAlternateAndMainIcon ()
// 		{
// 			var platform = ApplePlatform.iOS;
// 			var projectDir = Path.Combine (Configuration.SourceRoot, "tests", "dotnet", "AppWithXCAssets", platform.AsString ());
// 			var actool = CreateACToolTask (
// 				platform,
// 				projectDir,
// 				out var _,
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "Contents.json") + "|Resources/Images.xcassets/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon32.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon32.png"
// 			);
// 			actool.AlternateAppIcons = new ITaskItem [] { new TaskItem ("AppIcons")};
// 			actool.AppIcon = "AppIcons";

// 			ExecuteTask (actool, 1);
// 			Assert.AreEqual ("The image resource 'AppIcons' is specified as both 'AppIcon' and 'AlternateAppIcon'", Engine.Logger.ErrorEvents [0].Message, "Error message");
// 		}

// 		[Test]
// 		public void XSAppIconAssetsAndAppIcon ()
// 		{
// 			var platform = ApplePlatform.iOS;
// 			var projectDir = Path.Combine (Configuration.SourceRoot, "tests", "dotnet", "AppWithXCAssets", platform.AsString ());
// 			var actool = CreateACToolTask (
// 				platform,
// 				projectDir,
// 				out var _,
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "Contents.json") + "|Resources/Images.xcassets/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AppIcons.appiconset/Icon32.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Contents.json") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Contents.json",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon16.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon16.png",
// 				Path.Combine (projectDir, "Resources", "Images.xcassets", "AlternateAppIcons.appiconset", "Icon32.png") + "|Resources/Images.xcassets/AlternateAppIcons.appiconset/Icon32.png"
// 			);
// 			actool.AppIcon = "AppIcons";
// 			actool.XSAppIconAssets = "Resources/Images.xcassets/AppIcons.appiconset";

// 			ExecuteTask (actool, 1);
// 			Assert.AreEqual ("Can't specify both 'XSAppIconAssets' in the Info.plist and 'AppIcon' in the project file. Please select one or the other.", Engine.Logger.ErrorEvents [0].Message, "Error message");
// 		}
// 	}
// }
