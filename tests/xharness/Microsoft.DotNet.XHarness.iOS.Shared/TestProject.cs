using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.DotNet.XHarness.iOS.Shared.Execution;
using Microsoft.DotNet.XHarness.iOS.Shared.Logging;
using Microsoft.DotNet.XHarness.iOS.Shared.Tasks;
using Microsoft.DotNet.XHarness.iOS.Shared.Utilities;

namespace Microsoft.DotNet.XHarness.iOS.Shared {
	public class TestProject
	{
		XmlDocument xml;
		bool generate_variations = true;

		public TestPlatform TestPlatform;
		public string Path;
		public string SolutionPath;
		public string Name;
		public bool IsExecutableProject;
		public bool IsNUnitProject;
		public bool IsDotNetProject;
		public string [] Configurations;
		public Func<Task> Dependency;
		public string FailureMessage;
		public bool RestoreNugetsInProject = true;
		public string MTouchExtraArgs;
		public double TimeoutMultiplier = 1;
		public bool? Ignore;

		public IEnumerable<TestProject> ProjectReferences;

		// Optional
		public MonoNativeInfo MonoNativeInfo { get; set; }

		public TestProject ()
		{
		}

		public TestProject (string path, bool isExecutableProject = true)
		{
			Path = path;
			IsExecutableProject = isExecutableProject;
		}

		public virtual bool GenerateVariations { get => generate_variations; set => generate_variations = value; }

		public XmlDocument Xml {
			get {
				if (xml == null) {
					xml = new XmlDocument ();
					xml.LoadWithoutNetworkAccess (Path);
				}
				return xml;
			}
		}

		public virtual TestProject Clone ()
		{
			TestProject rv = (TestProject) Activator.CreateInstance (GetType ());
			rv.Path = Path;
			rv.IsExecutableProject = IsExecutableProject;
			rv.IsDotNetProject = IsDotNetProject;
			rv.RestoreNugetsInProject = RestoreNugetsInProject;
			rv.Name = Name;
			rv.MTouchExtraArgs = MTouchExtraArgs;
			rv.TimeoutMultiplier = TimeoutMultiplier;
			rv.Ignore = Ignore;
			return rv;
		}

		internal async Task<TestProject> CreateCloneAsync (ILog log, IProcessManager processManager, ITestTask test, string rootDirectory)
		{
			var rv = Clone ();
			await rv.CreateCopyAsync (log, processManager, test, rootDirectory);
			return rv;
		}

		public Task CreateCopyAsync (ILog log, IProcessManager processManager, ITestTask test, string rootDirectory)
		{
			var pr = new Dictionary<string, TestProject> ();
			return CreateCopyAsync (log, processManager, test, rootDirectory, pr);
		}

		async Task CreateCopyAsync (ILog log, IProcessManager processManager, ITestTask test, string rootDirectory, Dictionary<string, TestProject> allProjectReferences)
		{
			var directory = DirectoryUtilities.CreateTemporaryDirectory (test?.TestName ?? System.IO.Path.GetFileNameWithoutExtension (Path));
			Directory.CreateDirectory (directory);
			var original_path = Path;
			Path = System.IO.Path.Combine (directory, System.IO.Path.GetFileName (Path));

			await Task.Yield ();

			XmlDocument doc;
			doc = new XmlDocument ();
			doc.LoadWithoutNetworkAccess (original_path);
			var original_name = System.IO.Path.GetFileName (original_path);
			doc.ResolveAllPaths (original_path, rootDirectory);

			if (doc.IsDotNetProject ()) {
				if (doc.GetEnableDefaultItems () != false) {
					// Many types of files below the csproj directory are included by default,
					// which means that we have to include them manually in the cloned csproj,
					// because the cloned project is stored in a very different directory.
					var test_dir = System.IO.Path.GetDirectoryName (original_path);

					// Get all the files in the project directory from git
					using var process = new Process ();
					process.StartInfo.FileName = "git";
					process.StartInfo.Arguments = "ls-files";
					process.StartInfo.WorkingDirectory = test_dir;
					var stdout = new MemoryLog () { Timestamp = false };
					var result = await processManager.RunAsync (process, log, stdout, stdout, timeout: TimeSpan.FromSeconds (15));
					if (!result.Succeeded)
						throw new Exception ($"Failed to list the files in the directory {test_dir} (TimedOut: {result.TimedOut} ExitCode: {result.ExitCode}):\n{stdout}");

					var files = stdout.ToString ().Split ('\n');
					foreach (var file in files) {
						var ext = System.IO.Path.GetExtension (file);
						var full_path = System.IO.Path.Combine (test_dir, file);
						var windows_file = full_path.Replace ('/', '\\');

						if (file.Contains (".xcasset")) {
							doc.AddInclude ("ImageAsset", file, windows_file, true);
							continue;
						}

						switch (ext.ToLowerInvariant ()) {
						case ".cs":
							doc.AddInclude ("Compile", file, windows_file, true);
							break;
						case ".plist":
							doc.AddInclude ("None", file, windows_file, true);
							break;
						case ".storyboard":
							doc.AddInclude ("InterfaceDefinition", file, windows_file, true);
							break;
						case ".gitignore":
						case ".csproj":
						case ".props": // Directory.Build.props
						case "": // Makefile
							break; // ignore these files
						default:
							Console.WriteLine ($"Unknown file: {file} (extension: {ext}). There might be a default inclusion behavior for this file.");
							break;
						}
					}
				}

				// The global.json and NuGet.config files make sure we use the locally built packages.
				var dotnet_test_dir = System.IO.Path.Combine (test.RootDirectory, "dotnet");
				var global_json = System.IO.Path.Combine (dotnet_test_dir, "global.json");
				var nuget_config = System.IO.Path.Combine (dotnet_test_dir, "NuGet.config");
				var target_directory = directory;
				File.Copy (global_json, System.IO.Path.Combine (target_directory, System.IO.Path.GetFileName (global_json)), true);
				log.WriteLine ($"Copied {global_json} to {target_directory}");
				File.Copy (nuget_config, System.IO.Path.Combine (target_directory, System.IO.Path.GetFileName (nuget_config)), true);
				log.WriteLine ($"Copied {nuget_config} to {target_directory}");
			}

			var projectReferences = new List<TestProject> ();
			foreach (var pr in doc.GetProjectReferences ()) {
				var prPath = pr.Replace ('\\', '/');
				if (!allProjectReferences.TryGetValue (prPath, out var tp)) {
					tp = new TestProject (pr.Replace ('\\', '/'));
					await tp.CreateCopyAsync (log, processManager, test, rootDirectory, allProjectReferences);
					allProjectReferences.Add (prPath, tp);
				}
				doc.SetProjectReferenceInclude (pr, tp.Path.Replace ('/', '\\'));
				projectReferences.Add (tp);
			}
			this.ProjectReferences = projectReferences;

			doc.Save (Path);
		}

		public override string ToString()
		{
			return Name;
		}
	}

}

