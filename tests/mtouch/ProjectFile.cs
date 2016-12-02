using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Tests;

using NUnit.Framework;

namespace Xamarin
{
	public class ProjectFile
	{
		public string TargetDirectory = Cache.CreateTemporaryDirectory ();
		public string TemplateDirectory;
		public ProjectFile ContainerProject;
		public string Guid = System.Guid.NewGuid ().ToString ();
		public string ProjectPath { get; private set; }
		public ProjectType ProjectType;
		public Architecture Architectures;

		public string MinimumOSVersion { get; set; }

		public string MTouchExtraArgs;
		public string MTouchArch_Simulator;
		public string MTouchArch_Device;
		public string MTouchLink;
		public bool MTouchDebug;
		public bool MTouchProfiling;
		public bool MTouchUseLlvm;
		public bool MTouchEnableBitcode;

		public ProjectFile [] ProjectReferences = new ProjectFile [0];

		void SetArchitectureString ()
		{
			string sim;
			string dev;

			switch (Architectures) {
			case Architecture.Default:
				switch (ProjectType) {
				case ProjectType.iOSApp:
				case ProjectType.TodayExtension:
					throw new Exception ("iOS apps must specifiy architecture");
				case ProjectType.tvOSApp:
					sim = "x86_64";
					dev = "ARM64";
					break;
				case ProjectType.WatchKit2App:
				case ProjectType.WatchKit2Extension:
					sim = "i386";
					dev = "ARMv7k";
					break;
				default:
					throw new NotImplementedException ();
				}
				break;
			case Architecture.ARMv7 | Architecture.ARMv7s:
				dev = "ARMv7, ARMv7s";
				sim = "i386, x86_64";
				break;
			case Architecture.ARMv7 | Architecture.ARM64:
				dev = "ARMv7, ARM64";
				sim = "i386, x86_64";
				break;
			case Architecture.ARMv7 | Architecture.ARMv7s | Architecture.ARM64:
				dev = "ARMv7, ARMv7s, ARM64";
				sim = "i386, x86_64";
				break;
			case Architecture.ARM64:
				dev = "ARM64";
				sim = "x86_64";
				break;
			case Architecture.ARMv7:
				dev = "ARMv7";
				sim = "i386";
				break;
			case Architecture.ARMv7s:
				dev = "ARMv7s";
				sim = "i386";
				break;
			case Architecture.ARMv7k:
				dev = "ARMv7k";
				sim = "i386";
				break;
			default:
				throw new NotImplementedException ();
			}

			MTouchArch_Simulator = sim;
			MTouchArch_Device = dev;
		}

		public void AddProjectReference (ProjectFile project)
		{
			//ProjectReferences.Add (project);
			project.ContainerProject = this;
		}

		string GetMSBuildPath (string path, bool is_dir = true)
		{
			if (is_dir)
				return path.Replace ('/', '\\') + "\\";
			return path.Replace ('/', '\\');
		}

		void CopyTemplateProject ()
		{
			var target_dir = TargetDirectory;
			var testCodeAdded = false;

			foreach (var file in Directory.EnumerateFiles (TemplateDirectory, "*", SearchOption.AllDirectories)) {
				var target = Path.Combine (target_dir, file.Substring (TemplateDirectory.Length + 1));
				var ext = Path.GetExtension (target).ToLowerInvariant ();
				switch (ext) {
				case ".png":
					File.Copy (file, target, true);
					break;
				case ".cs":
				case ".fs":
				case ".plist":
				case ".storyboard":
				case ".json":
				case ".csproj":
					var contents = File.ReadAllText (file);
					contents = contents.Replace ("%APP_CFBUNDLEIDENTIFER%", CFBundleIdentifier);
					contents = contents.Replace ("%CFBUNDLEIDENTIFIER%", CFBundleIdentifier);
					var minOSVersion = MinimumOSVersion;
					if (string.IsNullOrEmpty (minOSVersion)) {
						switch (ProjectType) {
						case ProjectType.iOSApp:
							minOSVersion = "8.0"; // We default to an iOS version that supports embedded frameworks.
							break;
						default:
							contents = contents.Replace ("%MINOSVERSION%", MinimumOSVersion ?? MTouch.GetMinSdkVersion (MTouch.GetProfileForProjectType (ProjectType)));
							break;
						}
					}
					contents = contents.Replace ("%MINOSVERSION%", minOSVersion);
					contents = contents.Replace ("%MTOUCH_LINK%", MTouchLink);
					contents = contents.Replace ("%MTOUCH_EXTRAARGS%", MTouchExtraArgs);
					contents = contents.Replace ("%MTOUCH_DEBUG%", MTouchDebug.ToString ());
					contents = contents.Replace ("%MTOUCH_PROFILING%", MTouchProfiling.ToString ());
					contents = contents.Replace ("%MTOUCH_ENABLEBITCODE%", MTouchEnableBitcode.ToString ());
					contents = contents.Replace ("%MTOUCH_USELLVM%", MTouchUseLlvm.ToString ());
					contents = contents.Replace ("%SIMULATOR_ARCH%", MTouchArch_Simulator);
					contents = contents.Replace ("%DEVICE_ARCH%", MTouchArch_Device);
					var sb = new StringBuilder ();
					foreach (var pr in ProjectReferences) {
						sb.Append ($"    <ProjectReference Include=\"{pr.ProjectPath}\">\n");
						if (pr.ProjectType == ProjectType.WatchKit2App) {
							sb.Append ($"      <IsWatchApp>true</IsWatchApp>\n");
						} else {
							sb.Append ($"      <IsAppExtension>true</IsAppExtension>\n");
						}
						sb.Append ($"      <Project>{{{pr.Guid}}}</Project>\n");
						sb.Append ($"      <Name>{Path.GetFileNameWithoutExtension (pr.ProjectPath)}</Name>\n");
						sb.Append ($"    </ProjectReference>");
					}
					contents = contents.Replace ("%PROJECT_REFERENCES%", sb.ToString ());

					switch (ProjectType) {
					case ProjectType.iOSApp:
					case ProjectType.tvOSApp:
					case ProjectType.TodayExtension:
						break;
					case ProjectType.WatchKit2App:
						contents = contents.Replace ("%WATCHAPP_CFBUNDLEIDENTIFIER%", CFBundleIdentifier);
						contents = contents.Replace ("%CONTAINER_CFBUNDLEIDENTIFIER%", ContainerProject.CFBundleIdentifier);
						contents = contents.Replace ("%WATCHAPP_PATH%", GetMSBuildPath (target_dir));
						contents = contents.Replace ("%WATCHEXTENSION_GUID%", ProjectReferences [0].Guid);
						contents = contents.Replace ("%WATCHEXTENSION_CSPROJ%", GetMSBuildPath (ProjectReferences [0].ProjectPath, false));
						contents = contents.Replace ("%WATCHEXTENSION_NAME%", Path.GetFileNameWithoutExtension (ProjectReferences [0].ProjectPath));
						break;
					case ProjectType.WatchKit2Extension:
						contents = contents.Replace ("%WATCHAPP_CFBUNDLEIDENTIFIER%", ContainerProject.CFBundleIdentifier);
						contents = contents.Replace ("%CONTAINER_CFBUNDLEIDENTIFIER%", ContainerProject.ContainerProject.CFBundleIdentifier);
						contents = contents.Replace ("%WATCHEXTENSION_GUID%", Guid);
						break;
					default:
						throw new NotImplementedException ();
					}

					if (contents.Contains ("%")) {
						var lines = contents.Split ('\n');
						foreach (var line in lines) {
							var a = line.IndexOf ('%');
							if (a == -1)
								continue;
							var b = line.IndexOf ('%', a + 1);
							if (b == -1)
								continue;

							Console.WriteLine ("FOUND {1} in {0} (from {2})", target, line.Substring (a, b - a + 1), file);
						}
					}

					if (!testCodeAdded && ext == ".cs") {
						testCodeAdded = true;
						contents = contents + @"
namespace Tests {
	using NUnit.Framework;

	[TestFixture]
	public class SimpleTest
	{
		[Test]
		public void Success ()
		{
		}
	}
}
";
					}

					Directory.CreateDirectory (Path.GetDirectoryName (target));
					File.WriteAllText (target, contents);
					break;
				default:
					throw new NotImplementedException (Path.GetExtension (target));
				}
			}
		}

		void SetProjectPath ()
		{
			switch (ProjectType) {
			case ProjectType.iOSApp:
				TemplateDirectory = Path.Combine (Configuration.SourceRoot, "tests", "template", "iOSApp");
				break;
			case ProjectType.TodayExtension:
				TemplateDirectory = Path.Combine (Configuration.SourceRoot, "tests", "template", "TodayExtension");
				break;
			case ProjectType.WatchKit2App:
				TemplateDirectory = Path.Combine (Configuration.SourceRoot, "tests", "template", "WatchApp");
				break;
			case ProjectType.tvOSApp:
				TemplateDirectory = Path.Combine (Configuration.SourceRoot, "tests", "template", "tvOSApp");
				break;
			case ProjectType.WatchKit2Extension:
				TemplateDirectory = Path.Combine (Configuration.SourceRoot, "tests", "template", "WatchExtension");
				break;
			default:
				throw new NotImplementedException (ProjectType.ToString ());
			}

			foreach (var reference in ProjectReferences)
				reference.SetProjectPath ();

			// find the csproj
			ProjectPath = Path.Combine (TargetDirectory, Path.GetFileName (Directory.GetFiles (TemplateDirectory, "*.csproj", SearchOption.TopDirectoryOnly) [0]));
		}

		public void Generate ()
		{
			SetArchitectureString ();
			SetProjectPath ();

			foreach (var reference in ProjectReferences)
				reference.Generate ();

			CopyTemplateProject ();
		}

		public void BuildDevice (string configuration = "Debug", string verbosity = "diagnostic")
		{
			Build (platform: "iPhone", configuration: configuration, verbosity: verbosity);
		}

		public void Build (string platform = "iPhone", string configuration = "Debug", string verbosity = "diagnostic")
		{
			XBuild.Build (ProjectPath, platform: platform, configuration: configuration, verbosity: "diagnostic");
		}

		bool HasWatchOSExtension {
			get {
				foreach (var pr in ProjectReferences)
					if (pr.ProjectType == ProjectType.WatchKit2App)
						return true;
				return false;
			}
		}

		public void RunDevice (string configuration = "Debug")
		{
			using (var xharness = new XHarnessTool ()) {
				xharness.Profile = MTouch.GetProfileForProjectType (ProjectType);
				xharness.ProjectPath = ProjectPath;
				xharness.Configuration = configuration;
				xharness.Verbose = true;
				Assert.AreEqual (0, xharness.UninstallDevice (), "uninstall");
				Assert.AreEqual (0, xharness.InstallDevice (timeout: TimeSpan.FromMinutes (1)), "install");
				// First run the container app. This will close the notification center (if it's open),
				// which is important because launching today extensions with the notification center
				// already open won't do anything.
				Assert.AreEqual (0, xharness.RunDevice (timeout: TimeSpan.FromSeconds (30)), "run");
				foreach (var refs in ProjectReferences) {
					if (refs.ProjectType == ProjectType.WatchKit2App) {
						xharness.Target = "watchos-device";
						xharness.ProjectPath = ProjectPath;
						// watchOS extensions must be installed separately.
						Assert.AreEqual (0, xharness.InstallDevice (timeout: TimeSpan.FromMinutes (10)), "install watchos");
						Assert.AreEqual (0, xharness.RunDevice (timeout: TimeSpan.FromMinutes (2)), "run watchos");
					} else {
						xharness.Target = null;
						xharness.ProjectPath = refs.ProjectPath;
						// The extension has already been installed with the container app.
						Assert.AreEqual (0, xharness.RunDevice (timeout: TimeSpan.FromMinutes (1)), "run");
					}
				}
			}
		}

		public string CFBundleIdentifier {
			get {
				if (ContainerProject != null) {
					return ContainerProject.CFBundleIdentifier + "." + Path.GetFileNameWithoutExtension (ProjectPath);
				} else {
					return "com.xamarin." + Path.GetFileNameWithoutExtension (ProjectPath);
				}
			}
		}
	}
}
