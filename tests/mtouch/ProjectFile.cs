using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Xamarin.Tests;

namespace Xamarin
{
	public class ProjectFile
	{
		public string Guid = System.Guid.NewGuid ().ToString ();
		public string ProjectPath;
		public MTouch.Profile Profile;

		public bool MTouchDebug;
		public string MTouchExtraArgs;
		public string MTouchArch_Simulator;
		public string MTouchArch_Device;
		public string MTouchLink;
		public bool MTouchProfiling;
		public bool MTouchUseLlvm;
		public bool MTouchEnableBitcode;
		public List<string> References = new List<string> () { "System", "System.Xml", "System.Core" };
		public List<string> Files = new List<string> ();
		public List<ProjectFile> ProjectReferences = new List<ProjectFile> ();

		public void Generate ()
		{
			var sb = new StringWriter ();
			string suffix;
			string target_framework_identifier;
			string project_type_guids;
			string target_type;

			switch (Profile) {
			case MTouch.Profile.Unified:
				suffix = "ios";
				target_framework_identifier = "Xamarin.iOS";
				project_type_guids = "{FEACFBD2-3405-455C-9665-78FE426C6842};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}";
				target_type = "iOS";
				break;
			case MTouch.Profile.TVOS:
				suffix = "tvos";
				target_framework_identifier = "Xamarin.TVOS";
				project_type_guids = "{06FA79CB-D6CD-4721-BB4B-1BD202089C55};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}";
				target_type = "tvOS";
				break;
			case MTouch.Profile.WatchOS:
			default:
				throw new NotImplementedException ();
			}

			sb.WriteLine ($@"<?xml version=""1.0"" encoding=""utf-8""?>");
			sb.WriteLine ($@"<Project DefaultTargets=""Build"" ToolsVersion=""4.0"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">");
			sb.WriteLine ($@"  <PropertyGroup>");
			sb.WriteLine ($@"    <ProductVersion>8.0.30703</ProductVersion>");
			sb.WriteLine ($@"    <SchemaVersion>2.0</SchemaVersion>");
			sb.WriteLine ($@"    <ProjectGuid>{{{Guid}}}</ProjectGuid>");
			sb.WriteLine ($@"    <ProjectTypeGuids>{project_type_guids}</ProjectTypeGuids>");
			sb.WriteLine ($@"    <TargetFrameworkIdentifier>{target_framework_identifier}</TargetFrameworkIdentifier>");
			sb.WriteLine ($@"    <OutputType>Exe</OutputType>");
			sb.WriteLine ($@"    <AssemblyName>{System.IO.Path.GetFileNameWithoutExtension (ProjectPath)}</AssemblyName>");
			sb.WriteLine ($@"    <IntermediateOutputPath>obj\$(Platform)\{suffix}</IntermediateOutputPath>");
			sb.WriteLine ($@"    <OutputPath>bin\$(Platform)\{suffix}</OutputPath>");
			sb.WriteLine ($@"    <DebugSymbols>True</DebugSymbols>");
			sb.WriteLine ($@"    <DebugType>full</DebugType>");
			sb.WriteLine ($@"    <Optimize>False</Optimize>");
			sb.WriteLine ($@"    <MtouchLink>{MTouchLink}</MtouchLink>");
			sb.WriteLine ($@"    <MtouchExtraArgs>{MTouchExtraArgs}</MtouchExtraArgs>");
			sb.WriteLine ($@"    <MtouchDebug>{MTouchDebug}</MtouchDebug>");
			sb.WriteLine ($@"    <MtouchProfiling>{MTouchProfiling}</MtouchProfiling>");
			sb.WriteLine ($@"    <MtouchUseLlvm>{MTouchUseLlvm}</MtouchUseLlvm>");
			sb.WriteLine ($@"    <MtouchEnableBitcode>{MTouchEnableBitcode}</MtouchEnableBitcode>");
			sb.WriteLine ($@"  </PropertyGroup>");
			sb.WriteLine ($@"  <PropertyGroup Condition="" '$(Platform)' == 'iPhoneSimulator' "">");
			sb.WriteLine ($@"    <MtouchArch>{MTouchArch_Simulator}</MtouchArch>");
			sb.WriteLine ($@"  </PropertyGroup>");
			sb.WriteLine ($@"  <PropertyGroup Condition="" '$(Platform)' == 'iPhone' "">");
			sb.WriteLine ($@"    <MtouchArch>{MTouchArch_Device}</MtouchArch>");
			sb.WriteLine ($@"  </PropertyGroup>");
			sb.WriteLine ($@"  <ItemGroup>");
			sb.WriteLine ($@"    <Reference Include=""{target_framework_identifier}"" />");
			foreach (var r in References)
				sb.WriteLine ($@"    <Reference Include=""{r}"" />");
			sb.WriteLine ($@"  </ItemGroup>");
			sb.WriteLine ($@"  <ItemGroup>");
			sb.WriteLine ($@"    <None Include=""Info.plist"">");
			sb.WriteLine ($@"      <LogicalName>Info.plist</LogicalName>");
			sb.WriteLine ($@"    </None>");
			sb.WriteLine ($@"  </ItemGroup>");
			sb.WriteLine ($@"  <ItemGroup>");
			foreach (var f in Files)
				sb.WriteLine ($@"    <Compile Include=""{f}"" />");
			sb.WriteLine ($@"  </ItemGroup>");
			sb.WriteLine ($@"  <Import Project=""$(MSBuildExtensionsPath)\Xamarin\{target_type}\Xamarin.{target_type}.CSharp.targets"" />");
			if (ProjectReferences.Count > 0) {
				sb.WriteLine ($@"  <ItemGroup>");
				foreach (var pr in ProjectReferences) {
					sb.WriteLine ($@"    <ProjectReference Include=""{pr.ProjectPath}"">");
					sb.WriteLine ($@"      <Project>{{{pr.Guid}}}</Project>");
					sb.WriteLine ($@"      <Name>{System.IO.Path.GetFileNameWithoutExtension (pr.ProjectPath)}</Name>");
					sb.WriteLine ($@"    </ProjectReference>");
				}
				sb.WriteLine ($@"  </ItemGroup>");
			}
			sb.WriteLine ($@"</Project>");

			File.WriteAllText (ProjectPath, sb.ToString ());
		}


		public void GenerateUnitTestProject (string testCode = null)
		{
			switch (Profile) {
			case MTouch.Profile.Unified:
			case MTouch.Profile.TVOS:
				break; // OK
			case MTouch.Profile.WatchOS:
			default:
				throw new NotImplementedException ();
			}

			if (testCode == null) {
				testCode = @"[TestFixture]
public class SimpleTest
{
	[Test]
	public void Success ()
	{
	}
}";
			}

			var code = @"
using System;
using System.Reflection;

using Foundation;
using UIKit;

using MonoTouch.NUnit.UI;
using NUnit.Framework;
using NUnit.Framework.Internal;

[Register (""AppDelegate"")]
public partial class AppDelegate : UIApplicationDelegate
{
        UIWindow window;
		TouchRunner runner;

        public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {
                window = new UIWindow (UIScreen.MainScreen.Bounds);
				runner = new TouchRunner (window);

				runner.Add (Assembly.GetExecutingAssembly ());

				window.RootViewController = new UINavigationController (runner.GetViewController ());
				window.MakeKeyAndVisible ();

                return true;
        }

        static void Main (string[] args)
        {
                UIApplication.Main (args, null, typeof (AppDelegate));
        }
}
" + testCode;
			

			File.WriteAllText (System.IO.Path.Combine (System.IO.Path.GetDirectoryName (ProjectPath), "Main.cs"), code);
			Files.Add ("Main.cs");

			References.Add ("MonoTouch.NUnitLite");
			Generate ();
		}

		public void GenerateInfoPlist ()
		{
			var name = Path.GetFileNameWithoutExtension (ProjectPath);

			var sb = new StringWriter ();
			sb.WriteLine ($@"<?xml version=""1.0"" encoding=""UTF-8""?>");
			sb.WriteLine ($@"<!DOCTYPE plist PUBLIC ""-//Apple//DTD PLIST 1.0//EN"" ""http://www.apple.com/DTDs/PropertyList-1.0.dtd"">");
			sb.WriteLine ($@"<plist version=""1.0"">");
			sb.WriteLine ($@"<dict>");
			sb.WriteLine ($@"	<key>CFBundleDisplayName</key>");
			sb.WriteLine ($@"	<string>{name}</string>");
			sb.WriteLine ($@"	<key>CFBundleIdentifier</key>");
			sb.WriteLine ($@"	<string>com.xamarin.{name}</string>");
			sb.WriteLine ($@"	<key>CFBundleName</key>");
			sb.WriteLine ($@"	<string>{name}</string>");
			sb.WriteLine ($@"	<key>MinimumOSVersion</key>");
			sb.WriteLine ($@"	<string>{MTouch.GetMinSdkVersion (Profile)}</string>");
			sb.WriteLine ($@"	<key>UIDeviceFamily</key>");
			sb.WriteLine ($@"	<array>");
			switch (Profile) {
			case MTouch.Profile.Unified:
				sb.WriteLine ($@"		<integer>1</integer>");
				sb.WriteLine ($@"		<integer>2</integer>");
				break;
			case MTouch.Profile.TVOS:
				sb.WriteLine ($@"		<integer>3</integer>");
				break;
			case MTouch.Profile.WatchOS:
				sb.WriteLine ($@"		<integer>4</integer>");
				break;
			default:
				throw new NotImplementedException ();
			}
			sb.WriteLine ($@"	</array>");
			sb.WriteLine ($@"</dict>");
			sb.WriteLine ($@"</plist>");

			File.WriteAllText (System.IO.Path.Combine (System.IO.Path.GetDirectoryName (ProjectPath), "Info.plist"), sb.ToString ());
		}

		public void Build (string platform = "iPhoneSimulator")
		{
			XBuild.Build (ProjectPath, platform: platform);
		}
	}
}
