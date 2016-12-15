using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Text;

namespace xharness
{
	public class Jenkins
	{
		public Harness Harness;
		public bool IncludeClassicMac = false;
		public bool IncludeBcl;
		public bool IncludeMac = false;
		public bool IncludeiOS = true;
		public bool IncludetvOS = true;
		public bool IncludewatchOS = true;
		public bool IncludeMmpTest;
		public bool IncludeiOSMSBuild = false;
		public bool IncludeMtouch;
		public bool IncludeBtouch;
		public bool IncludeMacBindingProject;
		public bool IncludeSimulator = false;
		public bool IncludeLongRunningDevice = true;

		public Logs Logs = new Logs ();
		public Log MainLog;
		Log SimulatorLoadLog;

		public string LogDirectory {
			get {
				return Path.Combine (Harness.JENKINS_RESULTS_DIRECTORY, "tests");
			}
		}
		public Simulators Simulators = new Simulators ();
		public Devices Devices = new Devices ();

		List<TestTask> Tasks = new List<TestTask> ();

		internal static Resource DesktopResource = new Resource ("Desktop", Environment.ProcessorCount);

		static Dictionary<string, Resource> device_resources = new Dictionary<string, Resource> ();
		internal static Resources GetDeviceResources (IEnumerable<Device> devices)
		{
			List<Resource> resources = new List<Resource> ();
			lock (device_resources) {
				foreach (var device in devices) {
					Resource res;
					if (!device_resources.TryGetValue (device.UDID, out res))
						device_resources.Add (device.UDID, res = new Resource (device.UDID, 1));
					resources.Add (res);
				}
			}
			return new Resources (resources);
		}

		async Task<IEnumerable<RunSimulatorTask>> CreateRunSimulatorTaskAsync (XBuildTask buildTask)
		{
			var runtasks = new List<RunSimulatorTask> ();

			Simulators.Harness = Harness;
			if (SimulatorLoadLog == null)
				SimulatorLoadLog = Logs.CreateStream (LogDirectory, "simulator-list.log", "Simulator Listing");
			try {
				await Simulators.LoadAsync (SimulatorLoadLog);
			} catch (Exception e) {
				SimulatorLoadLog.WriteLine ("Failed to load simulators:");
				SimulatorLoadLog.WriteLine (e.ToString ());
				var task = new RunSimulatorTask (buildTask) { ExecutionResult = TestExecutingResult.Failed };
				var log = task.Logs.CreateFile ("Run log", Path.Combine (task.LogDirectory, "run-" + DateTime.Now.Ticks + ".log"));
				File.WriteAllText (log.Path, "Failed to load simulators.");
				runtasks.Add (task);
				return runtasks;
			}

			var fn = Path.GetFileNameWithoutExtension (buildTask.ProjectFile);
			AppRunnerTarget [] targets;
			TestPlatform [] platforms;
			SimDevice [] devices;

			if (fn.EndsWith ("-tvos", StringComparison.Ordinal)) {
				targets = new AppRunnerTarget [] { AppRunnerTarget.Simulator_tvOS };
				platforms = new TestPlatform [] { TestPlatform.tvOS };
			} else if (fn.EndsWith ("-watchos", StringComparison.Ordinal)) {
				targets = new AppRunnerTarget [] { AppRunnerTarget.Simulator_watchOS };
				platforms = new TestPlatform [] { TestPlatform.watchOS };
			} else {
				targets = new AppRunnerTarget [] { AppRunnerTarget.Simulator_iOS32, AppRunnerTarget.Simulator_iOS64 };
				platforms = new TestPlatform [] { TestPlatform.iOS_Unified32, TestPlatform.iOS_Unified64 };
			}

			for (int i = 0; i < targets.Length; i++) {
				try {
					devices = await Simulators.FindAsync (targets [i], SimulatorLoadLog);
					if (devices == null) {
						SimulatorLoadLog.WriteLine ($"Failed to find simulator for {targets [i]}.");
						var task = new RunSimulatorTask (buildTask) { ExecutionResult = TestExecutingResult.Failed };
						var log = task.Logs.CreateFile ("Run log", Path.Combine (task.LogDirectory, "run-" + DateTime.Now.Ticks + ".log"));
						File.WriteAllText (log.Path, "Failed to find simulators.");
						runtasks.Add (task);
						continue;
					}
				} catch (Exception e) {
					SimulatorLoadLog.WriteLine ($"Failed to find simulator for {targets [i]}");
					SimulatorLoadLog.WriteLine (e);
					var task = new RunSimulatorTask (buildTask) { ExecutionResult = TestExecutingResult.Failed };
					var log = task.Logs.CreateFile ("Run log", Path.Combine (task.LogDirectory, "run-" + DateTime.Now.Ticks + ".log"));
					File.WriteAllText (log.Path, "Failed to find simulators.");
					runtasks.Add (task);
					continue;
				}
				runtasks.Add (new RunSimulatorTask (buildTask, devices [0], devices.Length > 1 ? devices [1] : null) { Platform = platforms [i] });
			}

			return runtasks;
		}

		async Task<IEnumerable<TestTask>> CreateLongRunningDeviceTasks ()
		{
			var rv = new List<TestTask> ();

			Devices.Harness = Harness;
			try {
				await Devices.LoadAsync (MainLog);
				Devices.RemoveLockedDevices ();
			} catch (Exception e) {
				MainLog.WriteLine ("Failed to load devices: {0}", e);
				return rv;
			}

			foreach (var project in Harness.IOSTestProjects) {
				if (!project.IsExecutableProject)
					continue;

				if (!IncludeBcl && project.IsBclTest)
					continue;
				
				if (IncludeiOS) {
					var build64 = new XBuildTask
					{
						Jenkins = this,
						ProjectFile = project.Path,
						ProjectConfiguration = "Debug64",
						ProjectPlatform = "iPhone",
						Platform = TestPlatform.iOS_Unified64,
					};
					rv.Add (new RunDeviceTask (build64, Devices.ConnectedDevices.Where ((dev) => dev.DevicePlatform == DevicePlatform.iOS && dev.Supports64Bit)));

					var build32 = new XBuildTask
					{
						Jenkins = this,
						ProjectFile = project.Path,
						ProjectConfiguration = "Debug32",
						ProjectPlatform = "iPhone",
						Platform = TestPlatform.iOS_Unified32,
					};
					rv.Add (new RunDeviceTask (build32, Devices.ConnectedDevices.Where ((dev) => dev.DevicePlatform == DevicePlatform.iOS)));
				}

				if (IncludetvOS) {
					var tvOSProject = project.AsTvOSProject ();
					var build = new XBuildTask
					{
						Jenkins = this,
						ProjectFile = tvOSProject.Path,
						ProjectConfiguration = "Debug",
						ProjectPlatform = "iPhone",
						Platform = TestPlatform.tvOS,
					};
					rv.Add (new RunDeviceTask (build, Devices.ConnectedDevices.Where ((dev) => dev.DevicePlatform == DevicePlatform.tvOS)));
				}

				if (IncludewatchOS) {
					var watchOSProject = project.AsWatchOSProject ();
					var build = new XBuildTask
					{
						Jenkins = this,
						ProjectFile = watchOSProject.Path,
						ProjectConfiguration = "Debug",
						ProjectPlatform = "iPhone",
						Platform = TestPlatform.watchOS,
					};
					rv.Add (new RunDeviceTask (build, Devices.ConnectedDevices.Where ((dev) => dev.DevicePlatform == DevicePlatform.watchOS)));
				}
			}

			return rv;
		}

		static string AddSuffixToPath (string path, string suffix)
		{
			return Path.Combine (Path.GetDirectoryName (path), Path.GetFileNameWithoutExtension (path) + suffix + Path.GetExtension (path));
		}

		void SelectTests ()
		{
			int pull_request;

			if (!int.TryParse (Environment.GetEnvironmentVariable ("ghprbPullId"), out pull_request)) {
				MainLog.WriteLine ("The environment variable 'ghprbPullId' was not found, so no pull requests will be checked for test selection.");
				return;
			}

			// First check if can auto-select any tests based on which files were modified.
			// This will only enable additional tests, never disable tests.
			SelectTestsByModifiedFiles (pull_request);
			// Then we check for labels. Labels are manually set, so those override
			// whatever we did automatically.
			SelectTestsByLabel (pull_request);
		}

		void SelectTestsByModifiedFiles (int pull_request)
		{
			var files = GitHub.GetModifiedFiles (Harness, pull_request);

			MainLog.WriteLine ("Found {0} modified file(s) in the pull request #{1}.", files.Count (), pull_request);
			foreach (var f in files)
				MainLog.WriteLine ("    {0}", f);

			// We select tests based on a prefix of the modified files.
			// Add entries here to check for more prefixes.
			var mtouch_prefixes = new string [] {
				"tests/mtouch",
				"tools/mtouch",
				"tools/common",
				"tools/linker",
				"src/ObjCRuntime/Registrar.cs",
				"external/mono",
				"external/llvm",
			};
			var mmp_prefixes = new string [] {
				"tests/mmptest",
				"tools/mmp",
				"tools/common",
				"tools/linker",
				"src/ObjCRuntime/Registrar.cs",
				"external/mono",
			};
			var bcl_prefixes = new string [] {
				"tests/bcl-test",
				"external/mono",
				"external/llvm",
			};
			var btouch_prefixes = new string [] {
				"src/btouch.cs",
				"src/generator.cs",
				"src/generator-enums.cs",
				"src/generator-filters.cs",
			};
			var mac_binding_project = new string [] {
				"msbuild",
				"tests/mac-binding-project",
			}.Intersect (btouch_prefixes).ToArray ();

			SetEnabled (files, mtouch_prefixes, "mtouch", ref IncludeMtouch);
			SetEnabled (files, mmp_prefixes, "mmp", ref IncludeMmpTest);
			SetEnabled (files, bcl_prefixes, "bcl", ref IncludeBcl);
			SetEnabled (files, btouch_prefixes, "btouch", ref IncludeBtouch);
			SetEnabled (files, mac_binding_project, "mac-binding-project", ref IncludeMacBindingProject);
		}

		void SetEnabled (IEnumerable<string> files, string [] prefixes, string testname, ref bool value)
		{
			foreach (var file in files) {
				foreach (var prefix in prefixes) {
					if (file.StartsWith (prefix, StringComparison.Ordinal)) {
						value = true;
						MainLog.WriteLine ("Enabled '{0}' tests because the modified file '{1}' matches prefix '{2}'", testname, file, prefix);
						return;
					}
				}
			}
		}

		void SelectTestsByLabel (int pull_request)
		{
			var labels = GitHub.GetLabels (Harness, pull_request);

			MainLog.WriteLine ("Found {1} label(s) in the pull request #{2}: {0}", string.Join (", ", labels.ToArray ()), labels.Count (), pull_request);

			// disabled by default
			SetEnabled (labels, "mtouch", ref IncludeMtouch);
			SetEnabled (labels, "mmp", ref IncludeMmpTest);
			SetEnabled (labels, "bcl", ref IncludeBcl);
			SetEnabled (labels, "btouch", ref IncludeBtouch);
			SetEnabled (labels, "mac-binding-project", ref IncludeMacBindingProject);

			// enabled by default
			SetEnabled (labels, "ios", ref IncludeiOS);
			SetEnabled (labels, "tvos", ref IncludetvOS);
			SetEnabled (labels, "watchos", ref IncludewatchOS);
			SetEnabled (labels, "mac", ref IncludeMac);
			SetEnabled (labels, "mac-classic", ref IncludeClassicMac);
			SetEnabled (labels, "ios-msbuild", ref IncludeiOSMSBuild);
		}

		void SetEnabled (IEnumerable<string> labels, string testname, ref bool value)
		{
			if (labels.Contains ("skip-" + testname + "-tests")) {
				MainLog.WriteLine ("Disabled '{0}' tests because the label 'skip-{0}-tests' is set.", testname);
				value = false;
			} else if (labels.Contains ("run-" + testname + "-tests")) {
				MainLog.WriteLine ("Enabled '{0}' tests because the label 'run-{0}-tests' is set.", testname);
				value = true;
			} else if (labels.Contains ("skip-all-tests")) {
				MainLog.WriteLine ("Disabled '{0}' tests because the label 'skip-all-tests' is set.", testname);
				value = false;
			} else if (labels.Contains ("run-all-tests")) {
				MainLog.WriteLine ("Enabled '{0}' tests because the label 'run-all-tests' is set.", testname);
				value = true;
			}
			// respect any default value
		}

		async Task PopulateTasksAsync ()
		{
			// Missing:
			// api-diff
			// msbuild tests

			SelectTests ();

			if (IncludeiOS || IncludetvOS || IncludewatchOS) {
				var runSimulatorTasks = new List<RunSimulatorTask> ();

				foreach (var project in Harness.IOSTestProjects) {
					if (!project.IsExecutableProject)
						continue;

					if (!IncludeSimulator)
						continue;

					if (!IncludeBcl && project.IsBclTest)
						continue;

					var build = new XBuildTask () {
						Jenkins = this,
						ProjectFile = project.Path,
						ProjectConfiguration = "Debug",
						ProjectPlatform = "iPhoneSimulator",
						Platform = TestPlatform.iOS_Unified,
					};
					if (IncludeiOS)
						runSimulatorTasks.AddRange (await CreateRunSimulatorTaskAsync (build));

					var suffixes = new List<Tuple<string, TestPlatform>> ();
					if (IncludetvOS)
						suffixes.Add (new Tuple<string, TestPlatform> ("-tvos", TestPlatform.tvOS));
					if (IncludewatchOS)
						suffixes.Add (new Tuple<string, TestPlatform> ("-watchos", TestPlatform.watchOS));
					foreach (var pair in suffixes) {
						var derived = new XBuildTask () {
							Jenkins = this,
							ProjectFile = AddSuffixToPath (project.Path, pair.Item1),
							ProjectConfiguration = build.ProjectConfiguration,
							ProjectPlatform = build.ProjectPlatform,
							Platform = pair.Item2,
						};
						runSimulatorTasks.AddRange (await CreateRunSimulatorTaskAsync (derived));
					}
				}

				foreach (var taskGroup in runSimulatorTasks.GroupBy ((RunSimulatorTask task) => task.Device)) {
					Tasks.Add (new AggregatedRunSimulatorTask (taskGroup) {
						Jenkins = this,
						Devices = taskGroup.First ().Simulators,
					});
				}
			}

			if (IncludeiOSMSBuild) {
				var build = new XBuildTask ()
				{
					Jenkins = this,
					ProjectFile = Path.GetFullPath (Path.Combine (Harness.RootDirectory, "..", "msbuild", "Xamarin.MacDev.Tasks.sln")),
					SpecifyPlatform = false,
					SpecifyConfiguration = false,
					Platform = TestPlatform.iOS,
				};
				var nunitExecution = new NUnitExecuteTask ()
				{
					Jenkins = this,
					BuildTask = build,
					TestLibrary = Path.Combine (Harness.RootDirectory, "..", "msbuild", "tests", "bin", "Xamarin.iOS.Tasks.Tests.dll"),
					TestExecutable = Path.Combine (Harness.RootDirectory, "..", "packages", "NUnit.Runners.2.6.4", "tools", "nunit-console.exe"),
					WorkingDirectory = Path.Combine (Harness.RootDirectory, "..", "packages", "NUnit.Runners.2.6.4", "tools", "lib"),
					Platform = TestPlatform.iOS,
					TestName = "MSBuild tests - iOS",
					Timeout = TimeSpan.FromMinutes (30),
				};
				Tasks.Add (nunitExecution);
			}

			if (IncludeMac) {
				foreach (var project in Harness.MacTestProjects) {
					if (!project.IsExecutableProject)
						continue;

					if (!IncludeMmpTest && project.Path.Contains ("mmptest"))
						continue;

					BuildToolTask build;
					if (project.GenerateVariations) {
						build = new MdtoolTask ();
						build.Platform = TestPlatform.Mac_Classic;
					} else {
						build = new XBuildTask ();
						build.Platform = TestPlatform.Mac;
					}
					build.Jenkins = this;
					build.ProjectFile = project.Path;
					build.ProjectConfiguration = "Debug";
					build.ProjectPlatform = "x86";
					build.SpecifyPlatform = false;
					build.SpecifyConfiguration = false;
					var exec = new MacExecuteTask () {
						Platform = build.Platform,
						Jenkins = this,
						BuildTask = build,
						ProjectFile = build.ProjectFile,
						ProjectConfiguration = build.ProjectConfiguration,
						ProjectPlatform = build.ProjectPlatform,
					};
					if (IncludeClassicMac)
						Tasks.Add (exec);

					if (project.GenerateVariations) {
						Tasks.Add (CloneExecuteTask (exec, TestPlatform.Mac_Unified, "-unified"));
						Tasks.Add (CloneExecuteTask (exec, TestPlatform.Mac_Unified32, "-unified-32"));
						if (!project.SkipXMVariations) {
							Tasks.Add (CloneExecuteTask (exec, TestPlatform.Mac_UnifiedXM45, "-unifiedXM45"));
							Tasks.Add (CloneExecuteTask (exec, TestPlatform.Mac_UnifiedXM45_32, "-unifiedXM45-32"));
						}
					}
				}
			}

			if (IncludeMtouch) {
				var build = new MakeTask ()
				{
					Jenkins = this,
					ProjectFile = Path.GetFullPath (Path.Combine (Harness.RootDirectory, "mtouch", "mtouch.sln")),
					SpecifyPlatform = false,
					SpecifyConfiguration = false,
					Platform = TestPlatform.iOS,
					Target = "dependencies",
					WorkingDirectory = Path.GetFullPath (Path.Combine (Harness.RootDirectory, "mtouch")),
				};
				var nunitExecution = new NUnitExecuteTask ()
				{
					Jenkins = this,
					BuildTask = build,
					TestLibrary = Path.Combine (Harness.RootDirectory, "mtouch", "bin", "Debug", "mtouch.dll"),
					TestExecutable = Path.Combine (Harness.RootDirectory, "..", "packages", "NUnit.ConsoleRunner.3.5.0", "tools", "nunit3-console.exe"),
					WorkingDirectory = Path.Combine (Harness.RootDirectory, "mtouch", "bin", "Debug"),
					Platform = TestPlatform.iOS,
					TestName = "MTouch tests",
					Timeout = TimeSpan.FromMinutes (120),
				};
				Tasks.Add (nunitExecution);
			}

			if (IncludeBtouch) {
				var run = new MakeTask
				{
					Jenkins = this,
					Platform = TestPlatform.iOS,
					TestName = "BTouch tests",
					Target = "wrench-btouch",
					WorkingDirectory = Harness.RootDirectory,

				};
				Tasks.Add (run);
			}

			if (IncludeMacBindingProject) {
				var run = new MakeTask
				{
					Jenkins = this,
					Platform = TestPlatform.Mac,
					TestName = "Mac Binding Projects",
					Target = "all",
					WorkingDirectory = Path.Combine (Harness.RootDirectory, "mac-binding-project"),
				};
				Tasks.Add (run);
			}

			if (IncludeLongRunningDevice) {
				Tasks.AddRange (await CreateLongRunningDeviceTasks ());
			}
		}

		static MacExecuteTask CloneExecuteTask (MacExecuteTask task, TestPlatform platform, string suffix)
		{
			var build = new XBuildTask ()
			{
				Platform = platform,
				Jenkins = task.Jenkins,
				ProjectFile = AddSuffixToPath (task.ProjectFile, suffix),
				ProjectConfiguration = task.ProjectConfiguration,
				ProjectPlatform = task.ProjectPlatform,
				SpecifyPlatform = task.BuildTask.SpecifyPlatform,
				SpecifyConfiguration = task.BuildTask.SpecifyConfiguration,
			};

			var execute = new MacExecuteTask ()
			{
				Platform = build.Platform,
				Jenkins = build.Jenkins,
				ProjectFile = build.ProjectFile,
				ProjectConfiguration = build.ProjectConfiguration,
				ProjectPlatform = build.ProjectPlatform,
				BuildTask = build,
			};

			return execute;
		}

		public int Run ()
		{
			try {
				Directory.CreateDirectory (LogDirectory);
				Harness.HarnessLog = MainLog = Logs.CreateStream (LogDirectory, "Harness.log", "Harness log");
				Harness.HarnessLog.Timestamp = true;

				var tasks = new List<Task> ();
				if (IsServerMode)
					tasks.Add (RunTestServer ());

				Task.Run (async () =>
				{
					await SimDevice.KillEverythingAsync (MainLog);
					await PopulateTasksAsync ();
				}).Wait ();
				GenerateReport ();
				if (!IsServerMode) {
					foreach (var task in Tasks)
						tasks.Add (task.RunAsync ());
				}
				Task.WaitAll (tasks.ToArray ());
				GenerateReport ();
				return Tasks.Any ((v) => v.Failed) ? 1 : 0;
			} catch (Exception ex) {
				MainLog.WriteLine ("Unexpected exception: {0}", ex);
				Console.WriteLine ("Unexpected exception: {0}", ex);
				return 2;
			}
		}

		public bool IsServerMode {
			get { return Harness.JenkinsConfiguration == "server"; }
		}

		Task RunTestServer ()
		{
			var server = new HttpListener ();

			// Try and find an unused port
			int attemptsLeft = 50;
			int port = 0;
			Random r = new Random ((int) DateTime.Now.Ticks);
			while (attemptsLeft-- > 0) {
				var newPort = r.Next (49152, 65535); // The suggested range for dynamic ports is 49152-65535 (IANA)
				server.Prefixes.Clear ();
				server.Prefixes.Add ("http://*:" + newPort + "/");
				try {
					server.Start ();
					port = newPort;
					break;
				} catch (Exception ex) {
					MainLog.WriteLine ("Failed to listen on port {0}: {1}", newPort, ex.Message);
				}
			}
			MainLog.WriteLine ($"Created server on localhost:{port}");

			var tcs = new TaskCompletionSource<bool> ();
			var thread = new System.Threading.Thread (() =>
			{
				while (server.IsListening) {
					var context = server.GetContext ();
					var request = context.Request;
					var response = context.Response;
					var arguments = System.Web.HttpUtility.ParseQueryString (request.Url.Query);
					try {
						switch (request.Url.LocalPath) {
						case "/":
							response.ContentType = System.Net.Mime.MediaTypeNames.Text.Html;
							GenerateReportImpl (response.OutputStream);
							break;
						case "/runalltests":
							response.ContentType = System.Net.Mime.MediaTypeNames.Text.Plain;
							using (var writer = new StreamWriter (response.OutputStream)) {
								foreach (var task in Tasks) {
									if (task.InProgress || task.Waiting) {
										writer.WriteLine ($"Test '{task.TestName}' is already executing.");
									} else {
										task.Reset ();
										task.RunAsync ();
									}
								}

								writer.WriteLine ("OK");
							}
							break;
						case "/runtest":
							response.ContentType = System.Net.Mime.MediaTypeNames.Text.Plain;
							using (var writer = new StreamWriter (response.OutputStream)) {
								int id;
								if (int.TryParse (arguments ["id"], out id)) {
									var task = Tasks.FirstOrDefault ((t) => t.ID == id);
									if (task == null)
										task = Tasks.Where ((v) => v is AggregatedRunSimulatorTask).Cast<AggregatedRunSimulatorTask> ().SelectMany ((v) => v.Tasks).FirstOrDefault ((t) => t.ID == id);
									if (task == null) {
										writer.WriteLine ($"Could not find test {id}");
									} else if (task.InProgress || task.Waiting) {
										writer.WriteLine ($"Test '{task.TestName}' is already executing.");
									} else {
										task.Reset ();
										task.RunAsync ();
										writer.WriteLine ("OK");
									}
								} else {
									writer.WriteLine ($"Could not parse {arguments ["id"]}");
								}
							}
							break;
						case "/quit":
							using (var writer = new StreamWriter (response.OutputStream)) {
								writer.WriteLine ("<!DOCTYPE html>");
								writer.WriteLine ("<html>");
								writer.WriteLine ("<body onload='close ();'>Closing web page...</body>");
								writer.WriteLine ("</html>");
							}
							server.Stop ();
							break;
						default:
							var path = Path.Combine (LogDirectory, request.Url.LocalPath.Substring (1));
							if (File.Exists (path)) {
								var buffer = new byte [4096];
								using (var fs = new FileStream (path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
									int read;
									response.ContentLength64 = fs.Length;
									response.ContentType = System.Net.Mime.MediaTypeNames.Text.Plain;
									while ((read = fs.Read (buffer, 0, buffer.Length)) > 0)
										response.OutputStream.Write (buffer, 0, read);
								}
							} else {
								response.StatusCode = 404;
								response.OutputStream.WriteByte ((byte) '?');
							}
							break;
						}
					} catch (Exception e) {
						Console.WriteLine (e);
					}
					response.Close ();
				}
				tcs.SetResult (true);
			})
			{
				IsBackground = true,
			};
			thread.Start ();

			Process.Start ("open", $"http://localhost:{port}/");

			return tcs.Task;
		}

		string GetTestColor (IEnumerable<TestTask> tests)
		{
			if (tests.All ((v) => v.Succeeded))
				return "green";
			else if (tests.Any ((v) => v.Crashed))
				return "maroon";
			else if (tests.Any ((v) => v.TimedOut))
				return "purple";
			else if (tests.Any ((v) => v.BuildFailure))
				return "darkred";
			else if (tests.Any ((v) => v.Failed))
				return "red";
			else if (tests.All ((v) => v.Building))
				return "darkblue";
			else if (tests.All ((v) => v.InProgress))
				return "blue";
			else if (tests.Any ((v) => v.NotStarted))
				return "black";
			else if (tests.Any ((v) => v.Ignored))
				return "gray";
			else
				return "black";
		}

		string GetTestColor (TestTask test)
		{
			if (test.NotStarted) {
				return "black";
			} else if (test.InProgress) {
				if (test.Building) {
					return "darkblue";
				} else if (test.Running) {
					return "lightblue";
				} else {
					return "blue";
				}
			} else {
				if (test.Crashed) {
					return "maroon";
				} else if (test.HarnessException) {
					return "orange";
				} else if (test.TimedOut) {
					return "purple";
				} else if (test.BuildFailure) {
					return "darkred";
				} else if (test.Failed) {
					return "red";
				} else if (test.Succeeded) {
					return "green";
				} else if (test.Ignored) {
					return "gray";
				} else if (test.Waiting) {
					return "darkgray";
				} else {
					return "pink";
				}
			}
		}

		object report_lock = new object ();
		public void GenerateReport ()
		{
			lock (report_lock) {
				var report = Path.Combine (LogDirectory, "index.html");
				using (var stream = new MemoryStream ()) {
					GenerateReportImpl (stream);
					if (File.Exists (report))
						File.Delete (report);
					File.WriteAllBytes (report, stream.ToArray ());
				}
			}
		}

		void GenerateReportImpl (Stream stream)
		{
			var id_counter = 0;

			var allSimulatorTasks = new List<RunSimulatorTask> ();
			var allExecuteTasks = new List<MacExecuteTask> ();
			var allNUnitTasks = new List<NUnitExecuteTask> ();
			var allMakeTasks = new List<MakeTask> ();
			var allDeviceTasks = new List<RunDeviceTask> ();
			foreach (var task in Tasks) {
				var aggregated = task as AggregatedRunSimulatorTask;
				if (aggregated != null) {
					allSimulatorTasks.AddRange (aggregated.Tasks);
					continue;
				}

				var execute = task as MacExecuteTask;
				if (execute != null) {
					allExecuteTasks.Add (execute);
					continue;
				}

				var nunit = task as NUnitExecuteTask;
				if (nunit != null) {
					allNUnitTasks.Add (nunit);
					continue;
				}

				var make = task as MakeTask;
				if (make != null) {
					allMakeTasks.Add (make);
					continue;
				}

				var run_device = task as RunDeviceTask;
				if (run_device != null) {
					allDeviceTasks.Add (run_device);
					continue;
				}

				throw new NotImplementedException ();
			}

			var allTasks = new List<TestTask> ();
			allTasks.AddRange (allExecuteTasks);
			allTasks.AddRange (allSimulatorTasks);
			allTasks.AddRange (allNUnitTasks);
			allTasks.AddRange (allMakeTasks);
			allTasks.AddRange (allDeviceTasks);

			var failedTests = allTasks.Where ((v) => v.Failed);
			var unfinishedTests = allTasks.Where ((v) => !v.Finished);
			var passedTests = allTasks.Where ((v) => v.Succeeded);
			var runningTests = allTasks.Where ((v) => v.Running && !v.Waiting);
			var buildingTests = allTasks.Where ((v) => v.Building && !v.Waiting);
			var runningQueuedTests = allTasks.Where ((v) => v.Running && v.Waiting);
			var buildingQueuedTests = allTasks.Where ((v) => v.Building && v.Waiting);

			using (var writer = new StreamWriter (stream)) {
				writer.WriteLine ("<!DOCTYPE html>");
				writer.WriteLine ("<html onkeypress='keyhandler(event)'>");
				if (IsServerMode && allTasks.Count == 0)
					writer.WriteLine ("<meta http-equiv=\"refresh\" content=\"5\">");
				writer.WriteLine ("<title>Test results</title>");
				writer.WriteLine (@"<script type='text/javascript'>
function toggleLogVisibility (logName)
{
	var button = document.getElementById ('button_' + logName);
	var logs = document.getElementById ('logs_' + logName);
	if (logs.style.display == 'none') {
		logs.style.display = 'block';
		button.innerText = 'Hide details';
	} else {
		logs.style.display = 'none';
		button.innerText = 'Show details';
	}
}
function toggleContainerVisibility (containerName)
{
	var button = document.getElementById ('button_container_' + containerName);
	var div = document.getElementById ('test_container_' + containerName);
	if (div.style.display == 'none') {
		div.style.display = 'block';
		button.innerText = 'Hide';
	} else {
		div.style.display = 'none';
		button.innerText = 'Show';
	}
}
function quit ()
{
	var xhttp = new XMLHttpRequest();
	xhttp.onreadystatechange = function() {
	    if (this.readyState == 4 && this.status == 200) {
	       window.close ();
	    }
	};
	xhttp.open(""GET"", ""quit"", true);
	xhttp.send();
}
function keyhandler(event)
{
	switch (String.fromCharCode (event.keyCode)) {
	case ""q"":
	case ""Q"":
		quit ();
		break;
	}
}
function runalltests()
{
	sendrequest (""runalltests"");
}
function runtest(id)
{
	sendrequest (""runtest?id="" + id);
}
function sendrequest(url, callback)
{
	var xhttp = new XMLHttpRequest();
	xhttp.onreadystatechange = function() {
	    if (this.readyState == 4) {
	       	document.getElementById ('ajax-log').innerText = ""Loaded url: "" + url + "" with status code: "" + this.status + ""\nResponse: "" + this.responseText + ""\n"" + document.getElementById ('ajax-log').innerText;
			if (callback)
				callback (this.responseText);
	    }
	};
	xhttp.open(""GET"", url, true);
	xhttp.send();
	document.getElementById ('ajax-log').innerText = ""Loading url: "" + url + ""\n"" + document.getElementById ('ajax-log').innerText;
}
function autorefresh()
{
	var xhttp = new XMLHttpRequest();
	xhttp.onreadystatechange = function() {
	    if (this.readyState == 4) {
	       	document.getElementById ('ajax-log').innerText = ""Reloaded.\n"" + document.getElementById ('ajax-log').innerText;
			var parser = new DOMParser ();
			var r = parser.parseFromString (this.responseText, 'text/html');
			var ar_objs = document.getElementsByClassName (""autorefreshable"");
			//console.log (""Found "" + ar_objs.length + "" autorefreshable objects"");
			for (var i = 0; i < ar_objs.length; i++) {
				var ar_obj = ar_objs [i];
				if (!ar_obj.id || ar_obj.id.length == 0) {
					console.log (""Found object without id"");
					continue;
				}
				
				var new_obj = r.getElementById (ar_obj.id);
				if (new_obj) {
					ar_obj.innerHTML = new_obj.innerHTML;
					ar_obj.style = new_obj.style;
					//console.log (""Updated "" + ar_obj.id);
				} else {
					console.log (""Cound not find id "" + ar_obj.id + "" in updated page."");
				}
			}
	    }
	};
	xhttp.open(""GET"", window.location.href, true);
	xhttp.send();
}
setInterval(autorefresh, 1000);
</script>");
				writer.WriteLine ("<body>");

				if (IsServerMode) {
					writer.WriteLine ("<div id='quit' style='position:absolute; top: 20px; right: 20px;'><a href='javascript:quit()'>Quit</a></div>");
					writer.WriteLine ("<div id='ajax-log' style='position:absolute; top: 200px; right: 20px;'></div>");
				}

				writer.WriteLine ("<h1>Test results</h1>");

				foreach (var log in Logs)
					writer.WriteLine ("<a href='{0}' type='text/plain'>{1}</a><br />", log.FullPath.Substring (LogDirectory.Length + 1), log.Description);

				var headerColor = "black";
				if (failedTests.Any ()) {
					headerColor = "red";
				} else if (passedTests.Count () != allTasks.Count) {
					headerColor = "gray";
				} else {
					headerColor = "green";
				}

				writer.Write ($"<span id='x{id_counter++}' class='autorefreshable'>");
				if (allTasks.Count == 0) {
					writer.Write ($"<h2 style='color: {headerColor}'>Loading tests...");
				} else if (unfinishedTests.Any ()) {
					writer.Write ($"<h2 style='color: {headerColor}'>Test run in progress ({failedTests.Count ()} tests failed, {passedTests.Count ()} tests passed, {unfinishedTests.Count ()} tests left)");
				} else if (failedTests.Any ()) {
					writer.Write ($"<h2 style='color: {headerColor}'>{failedTests.Count ()} tests failed, {passedTests.Count ()} tests passed.");
				} else {
					writer.Write ($"<h2 style='color: {headerColor}'>All tests passed");
				}
				if (IsServerMode && allTasks.Count > 0) {
					writer.Write ("<small>");
					writer.Write (" <a href='javascript:runalltests()'>Run all tests</a>");
					writer.WriteLine ("</small>");
				}
				writer.WriteLine ("</h2></span>");

				writer.WriteLine ("<div id='test-table' style='width: 100%'>");
				writer.WriteLine ("<div id='test-status' style='display: inline-block; margin-left: 100px;' class='autorefreshable'>");
				if (failedTests.Count () == 0) {
					foreach (var group in failedTests.GroupBy ((v) => v.TestName)) {
						var enumerableGroup = group as IEnumerable<TestTask>;
						if (enumerableGroup != null) {
							writer.WriteLine ("<a href='#test_{2}'>{0}</a> ({1})<br />", group.Key, string.Join (", ", enumerableGroup.Select ((v) => string.Format ("<span style='color: {0}'>{1}</span>", GetTestColor (v), string.IsNullOrEmpty (v.Mode) ? v.ExecutionResult.ToString () : v.Mode)).ToArray ()), group.Key.Replace (' ', '-'));
							continue;
						}

						throw new NotImplementedException ();
					}
				}

				if (buildingTests.Any ()) {
					writer.WriteLine ($"<h3>{buildingTests.Count ()} building tests:</h3>");
					foreach (var test in buildingTests) {
						writer.WriteLine ($"<a href='#test_{test.TestName}'>{test.TestName} ({test.Mode})</a><br />");
					}
				}

				if (runningTests.Any ()) {
					writer.WriteLine ($"<h3>{runningTests.Count ()} running tests:</h3>");
					foreach (var test in runningTests) {
						writer.WriteLine ($"<a href='#test_{test.TestName}'>{test.TestName} ({test.Mode})</a><br />");
					}
				}

				if (buildingQueuedTests.Any ()) {
					writer.WriteLine ($"<h3>{buildingQueuedTests.Count ()} tests in build queue:</h3>");
					foreach (var test in buildingQueuedTests) {
						writer.WriteLine ($"<a href='#test_{test.TestName}'>{test.TestName} ({test.Mode})</a><br />");
					}
				}

				if (runningQueuedTests.Any ()) {
					writer.WriteLine ($"<h3>{runningQueuedTests.Count ()} tests in run queue:</h3>");
					foreach (var test in runningQueuedTests) {
						writer.WriteLine ($"<a href='#test_{test.TestName}'>{test.TestName} ({test.Mode})</a><br />");
					}
				}
				writer.WriteLine ("</div>");

				writer.WriteLine ("<div id='test-list' style='float:left'>");
				foreach (var group in allTasks.GroupBy ((TestTask v) => v.TestName).OrderBy ((v) => v.Key, StringComparer.Ordinal)) {
					// Create a collection of all non-ignored tests in the group (unless all tests were ignored).
					var relevantGroup = group.Where ((v) => v.ExecutionResult != TestExecutingResult.Ignored);
					if (!relevantGroup.Any ())
						relevantGroup = group;
					var results = relevantGroup
						.GroupBy ((v) => v.ExecutionResult)
						.Select ((v) => v.First ()) // GroupBy + Select = Distinct (lambda)
						.OrderBy ((v) => v.ID)
						.Select ((v) => $"<span style='color: {GetTestColor (v)}'>{v.ExecutionResult.ToString ()}</span>")
						.ToArray ();
					var defaultHide = group.All ((v) => v.Succeeded);
					var defaultHideMessage = defaultHide ? "Show" : "Hide";
					var singleTask = group.Count () == 1;
					var groupId = group.Key.Replace (' ', '-');
					writer.Write ($"<h2 id='test_{groupId}' class='autorefreshable'>{group.Key} ({string.Join ("; ", results)})");
					writer.Write ("<small>");
					writer.Write ($" <a id='button_container_{groupId}' href=\"javascript: toggleContainerVisibility ('{groupId}');\">{defaultHideMessage}</a>");
					if (IsServerMode) {
						writer.WriteLine ($" <a href='javascript: {string.Join ("", group.Select ((v) => $"runtest ({v.ID});"))}'>Run all tests</a>");
					}
					writer.Write ("</small>");
					writer.WriteLine ("</h2>");
					writer.WriteLine ("<div id='test_container_{0}' style='display: {1}'>", group.Key.Replace (' ', '-'), defaultHide ? "none" : "block");
					foreach (var test in group) {
						string state;
						state = test.ExecutionResult.ToString ();
						var log_id = id_counter++;
						var logs = test.AggregatedLogs;
						var hasDetails = test.Duration.Ticks > 0 || logs.Count () > 0;
						if (!singleTask) {
							writer.Write ($"{test.Mode} (<span id='x{id_counter++}' class='autorefreshable'><span style='color: {GetTestColor (test)}'>{state}</span></span>) ");
							writer.Write ($"<a id='button_{log_id}' href=\"javascript: toggleLogVisibility ('{log_id}');\">Show details</a> ");
							if (IsServerMode && !test.InProgress && !test.Waiting)
								writer.Write ($"<a href='javascript:runtest ({test.ID})'>Run</a> ");
							writer.WriteLine ("<br />");
							writer.WriteLine ("<div id='logs_{0}' class='autorefreshable' style='display: none; padding-bottom: 10px; padding-top: 10px; padding-left: 20px;'>", log_id);
						}
						if (hasDetails) {
							if (test.Duration.Ticks > 0)
								writer.WriteLine ("Duration: {0} <br />", test.Duration);
							if (logs.Count () > 0) {
								foreach (var log in logs) {
									log.Flush ();
									writer.WriteLine ("<a href='{0}' type='text/plain'>{1}</a><br />", log.FullPath.Substring (LogDirectory.Length + 1), log.Description);
									if (log.Description == "Test log") {
										var summary = string.Empty;
										try {
											using (var reader = log.GetReader ()) {
												while (!reader.EndOfStream) {
													string line = reader.ReadLine ();
													if (line.StartsWith ("Tests run:", StringComparison.Ordinal)) {
														summary = line;
													} else if (line.Trim ().StartsWith ("[FAIL]", StringComparison.Ordinal)) {
														writer.WriteLine ("<span style='padding-left: 20px;'>{0}</span><br />", line.Trim ());
													}
												}
											}
											if (!string.IsNullOrEmpty (summary))
												writer.WriteLine ("<span style='padding-left: 15px;'>{0}</span><br />", summary);
										} catch (Exception ex) {
											writer.WriteLine ("<span style='padding-left: 15px;'>Could not parse log file: {0}</span><br />", System.Web.HttpUtility.HtmlEncode (ex.Message));
										}
									} else if (log.Description == "Build log") {
										var errors = new HashSet<string> ();
										try {
											using (var reader = log.GetReader ()) {
												while (!reader.EndOfStream) {
													string line = reader.ReadLine ().Trim ();
													if (line.Contains (": error"))
														errors.Add (line);
												}
											}
											foreach (var error in errors)
												writer.WriteLine ("<span style='padding-left: 15\tpx;'>{0}</span> <br />", error);
										} catch (Exception ex) {
											writer.WriteLine ("<span style='padding-left: 15px;'>Could not parse log file: {0}</span><br />", System.Web.HttpUtility.HtmlEncode (ex.Message));
										}
									}
								}
							}
						}
						writer.WriteLine ("</div>");
					}
					writer.WriteLine ("</div>");
				}
				writer.WriteLine ("</div>");
				writer.WriteLine ("</div>");
				writer.WriteLine ("</body>");
				writer.WriteLine ("</html>");
			}
		}
	}

	abstract class TestTask
	{
		static int counter;
		public readonly int ID = counter++;

		public Jenkins Jenkins;
		public Harness Harness { get { return Jenkins.Harness; } }
		public string ProjectFile;
		public string ProjectConfiguration;
		public string ProjectPlatform;

		Stopwatch duration = new Stopwatch ();
		public TimeSpan Duration { 
			get {
				return duration.Elapsed;
			}
		}

		TestExecutingResult execution_result;
		public virtual TestExecutingResult ExecutionResult {
			get {
				return execution_result;
			}
			set {
				execution_result = value;
				Jenkins.GenerateReport ();
			}
		}

		public bool NotStarted { get { return (ExecutionResult & TestExecutingResult.StateMask) == TestExecutingResult.NotStarted; } }
		public bool InProgress { get { return (ExecutionResult & TestExecutingResult.InProgress) == TestExecutingResult.InProgress; } }
		public bool Waiting { get { return (ExecutionResult & TestExecutingResult.Waiting) == TestExecutingResult.Waiting; } }
		public bool Finished { get { return (ExecutionResult & TestExecutingResult.Finished) == TestExecutingResult.Finished; } }

		public bool Building { get { return (ExecutionResult & TestExecutingResult.Building) == TestExecutingResult.Building; } }
		public bool Built { get { return (ExecutionResult & TestExecutingResult.Built) == TestExecutingResult.Built; } }
		public bool Running { get { return (ExecutionResult & TestExecutingResult.Running) == TestExecutingResult.Running; } }

		public bool Succeeded { get { return (ExecutionResult & TestExecutingResult.Succeeded) == TestExecutingResult.Succeeded; } }
		public bool Failed { get { return (ExecutionResult & TestExecutingResult.Failed) == TestExecutingResult.Failed; } }
		public bool Ignored { get { return (ExecutionResult & TestExecutingResult.Ignored) == TestExecutingResult.Ignored; } }

		public bool Crashed { get { return (ExecutionResult & TestExecutingResult.Crashed) == TestExecutingResult.Crashed; } }
		public bool TimedOut { get { return (ExecutionResult & TestExecutingResult.TimedOut) == TestExecutingResult.TimedOut; } }
		public bool BuildFailure { get { return (ExecutionResult & TestExecutingResult.BuildFailure) == TestExecutingResult.BuildFailure; } }
		public bool HarnessException { get { return (ExecutionResult & TestExecutingResult.HarnessException) == TestExecutingResult.HarnessException; } }

		public virtual string Mode { get; set; }

		string test_name;
		public virtual string TestName {
			get {
				if (test_name != null)
					return test_name;
				
				var rv = Path.GetFileNameWithoutExtension (ProjectFile);
				switch (Platform) {
				case TestPlatform.Mac:
				case TestPlatform.Mac_Classic:
					return rv;
				case TestPlatform.Mac_Unified:
					return rv.Substring (0, rv.Length - "-unified".Length);
				case TestPlatform.Mac_Unified32:
					return rv.Substring (0, rv.Length - "-unified-32".Length);
				case TestPlatform.Mac_UnifiedXM45:
					return rv.Substring (0, rv.Length - "-unifiedXM45".Length);
				case TestPlatform.Mac_UnifiedXM45_32:
					return rv.Substring (0, rv.Length - "-unifiedXM45-32".Length);
				default:
					if (rv.EndsWith ("-watchos", StringComparison.Ordinal)) {
						return rv.Substring (0, rv.Length - 8);
					} else if (rv.EndsWith ("-tvos", StringComparison.Ordinal)) {
						return rv.Substring (0, rv.Length - 5);
					} else if (rv.EndsWith ("-unified", StringComparison.Ordinal)) {
						return rv.Substring (0, rv.Length - 8);
					} else {
						return rv;
					}
				}
			}
			set {
				test_name = value;
			}
		}

		public TestPlatform Platform { get; set; }

		public Logs Logs = new Logs ();
		public List<Resource> Resources = new List<Resource> ();

		Log test_log;
		public Log MainLog {
			get {
				if (test_log == null)
					test_log = Logs.CreateStream (LogDirectory, "main.log", "Main log");
				return test_log;
			}
		}

		public virtual IEnumerable<Log> AggregatedLogs {
			get {
				return Logs;
			}
		}

		public string LogDirectory {
			get {
				var rv = Path.Combine (Jenkins.LogDirectory, $"{TestName}_{ID}");
				Directory.CreateDirectory (rv);
				return rv;
			}
		}

		Task build_task;
		async Task RunInternalAsync ()
		{
			if (Finished)
				return;
			
			ExecutionResult = (ExecutionResult & ~TestExecutingResult.StateMask) | TestExecutingResult.InProgress;

			Jenkins.GenerateReport ();

			duration.Start ();

			try {
				build_task = ExecuteAsync ();
				await build_task;

				ExecutionResult = (ExecutionResult & ~TestExecutingResult.StateMask) | TestExecutingResult.Finished;
				if ((ExecutionResult & ~TestExecutingResult.StateMask) == 0)
					throw new Exception ("Result not set!");
			} catch (Exception e) {
				ExecutionResult = TestExecutingResult.Failed;
				using (var log = Logs.CreateStream (LogDirectory, "execution-failure.log", "Execution failure"))
					log.WriteLine (e.ToString ());
			} finally {
				duration.Stop ();
			}

			Jenkins.GenerateReport ();
		}

		public virtual void Reset ()
		{
			test_log = null;
			Logs.Clear ();
			duration.Reset ();
			execution_result = TestExecutingResult.NotStarted;
			build_task = null;
		}

		public Task RunAsync ()
		{
			if (build_task == null)
				build_task = RunInternalAsync ();
			return build_task;
		}

		protected abstract Task ExecuteAsync ();

		public override string ToString ()
		{
			return ExecutionResult.ToString ();
		}

		protected void SetEnvironmentVariables (Process process)
		{
			switch (Platform) {
			case TestPlatform.iOS:
			case TestPlatform.iOS_Unified:
			case TestPlatform.iOS_Unified32:
			case TestPlatform.iOS_Unified64:
			case TestPlatform.tvOS:
			case TestPlatform.watchOS:
				process.StartInfo.EnvironmentVariables ["MD_APPLE_SDK_ROOT"] = Harness.XcodeRoot;
				process.StartInfo.EnvironmentVariables ["MD_MTOUCH_SDK_ROOT"] = Path.Combine (Harness.IOS_DESTDIR, "Library", "Frameworks", "Xamarin.iOS.framework", "Versions", "Current");
				process.StartInfo.EnvironmentVariables ["XBUILD_FRAMEWORK_FOLDERS_PATH"] = Path.Combine (Harness.IOS_DESTDIR, "Library", "Frameworks", "Mono.framework", "External", "xbuild-frameworks");
				process.StartInfo.EnvironmentVariables ["MSBuildExtensionsPath"] = Path.Combine (Harness.IOS_DESTDIR, "Library", "Frameworks", "Mono.framework", "External", "xbuild");
				break;
			case TestPlatform.Mac:
			case TestPlatform.Mac_Classic:
			case TestPlatform.Mac_Unified:
			case TestPlatform.Mac_Unified32:
			case TestPlatform.Mac_UnifiedXM45:
			case TestPlatform.Mac_UnifiedXM45_32:
				process.StartInfo.EnvironmentVariables ["MD_APPLE_SDK_ROOT"] = Harness.XcodeRoot;
				process.StartInfo.EnvironmentVariables ["XBUILD_FRAMEWORK_FOLDERS_PATH"] = Path.Combine (Harness.MAC_DESTDIR, "Library", "Frameworks", "Mono.framework", "External", "xbuild-frameworks");
				process.StartInfo.EnvironmentVariables ["MSBuildExtensionsPath"] = Path.Combine (Harness.MAC_DESTDIR, "Library", "Frameworks", "Mono.framework", "External", "xbuild");
				process.StartInfo.EnvironmentVariables ["XamarinMacFrameworkRoot"] = Path.Combine (Harness.MAC_DESTDIR, "Library", "Frameworks", "Xamarin.Mac.framework", "Versions", "Current");
				process.StartInfo.EnvironmentVariables ["XAMMAC_FRAMEWORK_PATH"] = Path.Combine (Harness.MAC_DESTDIR, "Library", "Frameworks", "Xamarin.Mac.framework", "Versions", "Current");
				break;
			default:
				throw new NotImplementedException ();
			}
		}
	}

	abstract class BuildToolTask : TestTask
	{
		public bool SpecifyPlatform = true;
		public bool SpecifyConfiguration = true;

		public override string Mode {
			get { return Platform.ToString (); }
			set { throw new NotSupportedException (); }
		}
}

	class MdtoolTask : BuildToolTask
	{
		protected override async Task ExecuteAsync ()
		{
			using (var resource = await Jenkins.DesktopResource.AcquireConcurrentAsync ()) {
				using (var xbuild = new Process ()) {
					xbuild.StartInfo.FileName = "/Applications/Xamarin Studio.app/Contents/MacOS/mdtool";
					var args = new StringBuilder ();
					args.Append ("build ");
					var sln = Path.ChangeExtension (ProjectFile, "sln");
					args.Append (Harness.Quote (File.Exists (sln) ? sln : ProjectFile));
					xbuild.StartInfo.Arguments = args.ToString ();
					Jenkins.MainLog.WriteLine ("Building {0} ({1})", TestName, Mode);
					SetEnvironmentVariables (xbuild);
					var log = Logs.CreateStream (LogDirectory, "build-" + Platform + ".txt", "Build log");
					foreach (string key in xbuild.StartInfo.EnvironmentVariables.Keys)
						log.WriteLine ("{0}={1}", key, xbuild.StartInfo.EnvironmentVariables [key]);
					log.WriteLine ("{0} {1}", xbuild.StartInfo.FileName, xbuild.StartInfo.Arguments);
					if (!Harness.DryRun) {
						try {
							var timeout = TimeSpan.FromMinutes (5);
							var result = await xbuild.RunAsync (log, true, timeout);
							if (result.TimedOut) {
								ExecutionResult = TestExecutingResult.TimedOut;
								log.WriteLine ("Build timed out after {0} seconds.", timeout.TotalSeconds);
							} else if (result.Succeeded) {
								ExecutionResult = TestExecutingResult.Succeeded;
							} else {
								ExecutionResult = TestExecutingResult.Failed;
							}
						} catch (Exception e) {
							log.WriteLine ("Harness exception: {0}", e);
							ExecutionResult = TestExecutingResult.HarnessException;
						}
					}
					Jenkins.MainLog.WriteLine ("Built {0} ({1})", TestName, Mode);
				}
			}
		}
	}

	class MakeTask : BuildToolTask
	{
		public string Target;
		public string WorkingDirectory;

		protected override async Task ExecuteAsync ()
		{
			using (var resource = await Jenkins.DesktopResource.AcquireConcurrentAsync ()) {
				using (var make = new Process ()) {
					make.StartInfo.FileName = "make";
					make.StartInfo.WorkingDirectory = WorkingDirectory;
					make.StartInfo.Arguments = Target;
					Jenkins.MainLog.WriteLine ("Making {0} in {1}", Target, WorkingDirectory);
					SetEnvironmentVariables (make);
					var log = Logs.CreateStream (LogDirectory, "make-" + Platform + ".txt", "Build log");
					foreach (string key in make.StartInfo.EnvironmentVariables.Keys)
						log.WriteLine ("{0}={1}", key, make.StartInfo.EnvironmentVariables [key]);
					log.WriteLine ("{0} {1}", make.StartInfo.FileName, make.StartInfo.Arguments);
					if (!Harness.DryRun) {
						try {
							var timeout = TimeSpan.FromMinutes (5);
							var result = await make.RunAsync (log, true, timeout);
							if (result.TimedOut) {
								ExecutionResult = TestExecutingResult.TimedOut;
								log.WriteLine ("Make timed out after {0} seconds.", timeout.TotalSeconds);
							} else if (result.Succeeded) {
								ExecutionResult = TestExecutingResult.Succeeded;
							} else {
								ExecutionResult = TestExecutingResult.Failed;
							}
						} catch (Exception e) {
							log.WriteLine ("Harness exception: {0}", e);
							ExecutionResult = TestExecutingResult.HarnessException;
						}
					}
					Jenkins.MainLog.WriteLine ("Made {0} ({1})", TestName, Mode);
				}
			}
		}
	}

	class XBuildTask : BuildToolTask
	{
		protected override async Task ExecuteAsync ()
		{
			ExecutionResult = TestExecutingResult.BuildQueued;
			using (var resource = await Jenkins.DesktopResource.AcquireExclusiveAsync ()) {
				ExecutionResult = TestExecutingResult.Building;
				using (var xbuild = new Process ()) {
					xbuild.StartInfo.FileName = "xbuild";
					var args = new StringBuilder ();
					args.Append ("/verbosity:diagnostic ");
					if (SpecifyPlatform)
						args.Append ($"/p:Platform={ProjectPlatform} ");
					if (SpecifyConfiguration)
						args.Append ($"/p:Configuration={ProjectConfiguration} ");
					args.Append (Harness.Quote (ProjectFile));
					xbuild.StartInfo.Arguments = args.ToString ();
					Jenkins.MainLog.WriteLine ("Building {0} ({1})", TestName, Mode);
					SetEnvironmentVariables (xbuild);
					var log = Logs.CreateStream (LogDirectory, $"build-{Platform}-{DateTime.Now:yyyyMMdd_HHmmss}.txt", "Build log");
					foreach (string key in xbuild.StartInfo.EnvironmentVariables.Keys)
						log.WriteLine ("{0}={1}", key, xbuild.StartInfo.EnvironmentVariables [key]);
					log.WriteLine ("{0} {1}", xbuild.StartInfo.FileName, xbuild.StartInfo.Arguments);
					if (!Harness.DryRun) {
						try {
							var timeout = TimeSpan.FromMinutes (5);
							var result = await xbuild.RunAsync (log, true, timeout);
							if (result.TimedOut) {
								ExecutionResult = TestExecutingResult.TimedOut;
								log.WriteLine ("Build timed out after {0} seconds.", timeout.TotalSeconds);
							} else if (result.Succeeded) {
								ExecutionResult = TestExecutingResult.Succeeded;
							} else {
								ExecutionResult = TestExecutingResult.Failed;
							}
						} catch (Exception e) {
							log.WriteLine ("Harness exception: {0}", e);
							ExecutionResult = TestExecutingResult.HarnessException;
						}
					}
					Jenkins.MainLog.WriteLine ("Built {0} ({1})", TestName, Mode);
				}
			}
		}
	}


	class NUnitExecuteTask : TestTask
	{
		public BuildToolTask BuildTask;
		public string TestLibrary;
		public string TestExecutable;
		public string WorkingDirectory;
		public bool ProduceHtmlReport = true;
		public TimeSpan Timeout = TimeSpan.FromMinutes (10);

		public bool IsNUnit3 {
			get {
				return Path.GetFileName (TestExecutable) == "nunit3-console.exe";
			}
		}
		public override IEnumerable<Log> AggregatedLogs {
			get {
				return base.AggregatedLogs.Union (BuildTask.Logs);
			}
		}

		public override string Mode {
			get {
				return "NUnit";
			}
			set {
				throw new NotSupportedException ();
			}
		}

		protected override async Task ExecuteAsync ()
		{
			ExecutionResult = TestExecutingResult.Building;
			await BuildTask.RunAsync ();
			if (!BuildTask.Succeeded) {
				ExecutionResult = TestExecutingResult.BuildFailure;
				return;
			}

			ExecutionResult = TestExecutingResult.Built;

			using (var resource = await Jenkins.DesktopResource.AcquireConcurrentAsync ()) {
				var xmlLog = Logs.CreateFile ("XML log", Path.Combine (LogDirectory, "log.xml"));
				var log = Logs.CreateStream (LogDirectory, "execute.txt", "Execution log");
				using (var proc = new Process ()) {

					proc.StartInfo.WorkingDirectory = WorkingDirectory;
					proc.StartInfo.FileName = "/Library/Frameworks/Mono.framework/Commands/mono";
					var args = new StringBuilder ();
					args.Append (Harness.Quote (Path.GetFullPath (TestExecutable))).Append (' ');
					args.Append (Harness.Quote (Path.GetFullPath (TestLibrary))).Append (' ');
					if (IsNUnit3) {
						args.Append ("-result=").Append (Harness.Quote (xmlLog.FullPath)).Append (";format=nunit2 ");
						args.Append ("--labels=All ");
					} else {
						args.Append ("-xml=" + Harness.Quote (xmlLog.FullPath)).Append (' ');
						args.Append ("-labels ");
					}
					proc.StartInfo.Arguments = args.ToString ();
					SetEnvironmentVariables (proc);
					Jenkins.MainLog.WriteLine ("Executing {0} ({1})", TestName, Mode);
					if (!Harness.DryRun) {
						ExecutionResult = TestExecutingResult.Running;
						try {
							var result = await proc.RunAsync (log, true, Timeout);
							if (result.TimedOut) {
								log.WriteLine ("Execution timed out after {0} minutes.", Timeout.Minutes);
								ExecutionResult = TestExecutingResult.TimedOut;
							} else if (result.Succeeded) {
								ExecutionResult = TestExecutingResult.Succeeded;
							} else {
								ExecutionResult = TestExecutingResult.Failed;
							}
						} catch (Exception e) {
							log.WriteLine (e.ToString ());
							ExecutionResult = TestExecutingResult.HarnessException;
						}
					}
					Jenkins.MainLog.WriteLine ("Executed {0} ({1})", TestName, Mode);
				}

				if (ProduceHtmlReport) {
					try {
						var output = Logs.CreateStream (LogDirectory, "Log.html", "HTML log");
						using (var srt = new StringReader (File.ReadAllText (Path.Combine (Harness.RootDirectory, "HtmlTransform.xslt")))) {
							using (var sri = xmlLog.GetReader ()) {
								using (var xrt = System.Xml.XmlReader.Create (srt)) {
									using (var xri = System.Xml.XmlReader.Create (sri)) {
										var xslt = new System.Xml.Xsl.XslCompiledTransform ();
										xslt.Load (xrt);
										using (var sw = output.GetWriter ()) {
											using (var xwo = System.Xml.XmlWriter.Create (sw, xslt.OutputSettings)) // use OutputSettings of xsl, so it can be output as HTML
											{
												xslt.Transform (xri, xwo);
											}
										}
									}
								}
							}
						}
					} catch (Exception e) {
						log.WriteLine ("Failed to produce HTML report: {0}", e);
					}
				}
			}
		}
	}

	abstract class MacTask : TestTask
	{
		public override string Mode {
			get {
				switch (Platform) {
				case TestPlatform.Mac:
					return TestName;
				case TestPlatform.Mac_Classic:
					return "Classic";
				case TestPlatform.Mac_Unified:
					return "Unified";
				case TestPlatform.Mac_Unified32:
					return "Unified 32-bit";
				case TestPlatform.Mac_UnifiedXM45:
					return "Unified XM45";
				case TestPlatform.Mac_UnifiedXM45_32:
					return "Unified XM45 32-bit";
				default:
					throw new NotImplementedException ();
				}
			}
			set {
				throw new NotSupportedException ();
			}
		}
	}

	class MacExecuteTask : MacTask
	{
		public string Path;
		public BuildToolTask BuildTask;

		public override IEnumerable<Log> AggregatedLogs {
			get {
				return base.AggregatedLogs.Union (BuildTask.Logs);
			}
		}

		protected override async Task ExecuteAsync ()
		{
			ExecutionResult = TestExecutingResult.Building;
			await BuildTask.RunAsync ();
			if (!BuildTask.Succeeded) {
				ExecutionResult = TestExecutingResult.BuildFailure;
				return;
			}

			ExecutionResult = TestExecutingResult.Built;

			var projectDir = System.IO.Path.GetDirectoryName (ProjectFile);
			var name = System.IO.Path.GetFileName (projectDir);
			if (string.Equals ("mac", name, StringComparison.OrdinalIgnoreCase))
				name = System.IO.Path.GetFileName (System.IO.Path.GetDirectoryName (projectDir));
			var suffix = string.Empty;
			switch (Platform) {
			case TestPlatform.Mac_Unified:
				suffix = "-unified";
				break;
			case TestPlatform.Mac_Unified32:
				suffix = "-unified-32";
				break;
			case TestPlatform.Mac_UnifiedXM45:
				suffix = "-unifiedXM45";
				break;
			case TestPlatform.Mac_UnifiedXM45_32:
				suffix = "-unifiedXM45-32";
				break;
			}
			Path = System.IO.Path.Combine (System.IO.Path.GetDirectoryName (ProjectFile), "bin", BuildTask.ProjectPlatform, BuildTask.ProjectConfiguration + suffix, name + ".app", "Contents", "MacOS", name);

			using (var resource = await Jenkins.DesktopResource.AcquireConcurrentAsync ()) {
				using (var proc = new Process ()) {
					proc.StartInfo.FileName = Path;
					Jenkins.MainLog.WriteLine ("Executing {0} ({1})", TestName, Mode);
					var log = Logs.CreateStream (LogDirectory, "execute-" + Platform + ".txt", "Execution log");
					log.WriteLine ("{0} {1}", proc.StartInfo.FileName, proc.StartInfo.Arguments);
					if (!Harness.DryRun) {
						ExecutionResult = TestExecutingResult.Running;

						var snapshot = new CrashReportSnapshot () { Device = false, Harness = Harness, Log = log, Logs = Logs, LogDirectory = LogDirectory };
						await snapshot.StartCaptureAsync ();

						try {
							var timeout = TimeSpan.FromMinutes (20);

							var result = await proc.RunAsync (log, true, timeout);
							if (result.TimedOut) {
								log.WriteLine ("Execution timed out after {0} seconds.", timeout.TotalSeconds);
								ExecutionResult = TestExecutingResult.TimedOut;
							} else if (result.Succeeded) {
								ExecutionResult = TestExecutingResult.Succeeded;
							} else {
								ExecutionResult = TestExecutingResult.Failed;
							}
						} catch (Exception e) {
							log.WriteLine (e.ToString ());
							ExecutionResult = TestExecutingResult.HarnessException;
						}

						await snapshot.EndCaptureAsync (TimeSpan.FromSeconds (Succeeded ? 0 : 5));
					}
					Jenkins.MainLog.WriteLine ("Executed {0} ({1})", TestName, Mode);
				}
			}
		}
	}

	abstract class RunXITask<TDevice> : TestTask where TDevice: class, IDevice
	{
		TDevice device;
		TDevice companion_device;
		public readonly XBuildTask BuildTask;
		public AppRunnerTarget AppRunnerTarget;

		protected AppRunner runner;

		public TDevice Device {
			get { return device; }
			protected set { device = value; }
		}

		public TDevice CompanionDevice {
			get { return companion_device; }
			protected set { companion_device = value; }
		}

		public string BundleIdentifier {
			get { return runner.BundleIdentifier; }
		}

		public override TestExecutingResult ExecutionResult {
			get {
				// When building, the result is the build result.
				if ((BuildTask.ExecutionResult & (TestExecutingResult.InProgress | TestExecutingResult.Waiting)) != 0)
					return (BuildTask.ExecutionResult & ~TestExecutingResult.InProgressMask) | TestExecutingResult.Building;
				return base.ExecutionResult;
			}
			set {
				base.ExecutionResult = value;
			}
		}

		public RunXITask (XBuildTask build_task, TDevice device = null, TDevice companion_device = null)
		{
			this.device = device;
			this.companion_device = companion_device;
			this.BuildTask = build_task;

			Jenkins = build_task.Jenkins;
			ProjectFile = build_task.ProjectFile;
			Platform = build_task.Platform;
			ProjectConfiguration = build_task.ProjectConfiguration;
		}

		public async Task BuildAsync ()
		{
			if (Finished)
				return;
			ExecutionResult |= TestExecutingResult.Building;
			await BuildTask.RunAsync ();
			if (BuildTask.Succeeded) {
				ExecutionResult = (ExecutionResult & ~TestExecutingResult.InProgressMask) | TestExecutingResult.Built;
			} else {
				ExecutionResult = (ExecutionResult & ~(TestExecutingResult.InProgressMask | TestExecutingResult.StateMask)) | TestExecutingResult.BuildFailure;
			}
		}

		public override void Reset ()
		{
			base.Reset ();
			BuildTask.Reset ();
		}

		public override IEnumerable<Log> AggregatedLogs {
			get {
				return base.AggregatedLogs.Union (BuildTask.Logs);
			}
		}

		public override string Mode {
			get {
				switch (Platform) {
				case TestPlatform.tvOS:
				case TestPlatform.watchOS:
					return Platform.ToString () + " - " + XIMode;
				case TestPlatform.iOS_Unified32:
					return "iOS Unified 32-bits - " + XIMode;
				case TestPlatform.iOS_Unified64:
					return "iOS Unified 64-bits - " + XIMode;
				case TestPlatform.iOS_Unified:
					throw new NotImplementedException ();
				default:
					throw new NotImplementedException ();
				}
			}
			set { throw new NotSupportedException (); }
		}

		protected abstract string XIMode { get; }
	}

	class RunDeviceTask : RunXITask<Device>
	{
		IEnumerable<Device> device_candidates;

		public RunDeviceTask (XBuildTask build_task, IEnumerable<Device> device_candidates)
			: base (build_task)
		{
			this.device_candidates = device_candidates;

			var project = Path.GetFileNameWithoutExtension (ProjectFile);
			if (project.EndsWith ("-tvos", StringComparison.Ordinal)) {
				AppRunnerTarget = AppRunnerTarget.Device_tvOS;
			} else if (project.EndsWith ("-watchos", StringComparison.Ordinal)) {
				AppRunnerTarget = AppRunnerTarget.Device_watchOS;
			} else {
				AppRunnerTarget = AppRunnerTarget.Device_iOS;
			}
		}

		protected override async Task ExecuteAsync ()
		{
			Jenkins.MainLog.WriteLine ("Running '{0}' on device (candidates: '{1}')", ProjectFile, string.Join ("', '", device_candidates.Select ((v) => v.Name).ToArray ()));

			if (Finished)
				return;

			if (Harness.DryRun) {
				Jenkins.MainLog.WriteLine ("<running app on device>");
				return;
			}

			await BuildAsync ();
			if (!BuildTask.Succeeded) {
				ExecutionResult = TestExecutingResult.BuildFailure;
				return;
			}

			ExecutionResult = TestExecutingResult.RunQueued;
			using (var device_resource = await Jenkins.GetDeviceResources (device_candidates).AcquireAnyConcurrentAsync ()) {
				ExecutionResult = TestExecutingResult.Running;

				try {
					// Set the device we acquired.
					Device = device_candidates.First ((d) => d.UDID == device_resource.Resource.Name);
					if (Platform == TestPlatform.watchOS)
						CompanionDevice = Jenkins.Devices.FindCompanionDevice (Jenkins.MainLog, Device);

					runner = new AppRunner
					{
						Harness = Harness,
						ProjectFile = ProjectFile,
						Target = AppRunnerTarget,
						LogDirectory = LogDirectory,
						MainLog = Logs.CreateStream (LogDirectory, "run-" + Device.UDID + ".log", "Run log"),
						DeviceName = Device.Name,
						CompanionDeviceName = CompanionDevice?.Name,
						Configuration = ProjectConfiguration,
					};

					var uninstall_result = await runner.UninstallAsync ();
					if (!uninstall_result.Succeeded) {
						MainLog.WriteLine ($"Uninstall failed, exit code: {uninstall_result.ExitCode}.");
						ExecutionResult = TestExecutingResult.Failed;
					} else {
						var install_result = await runner.InstallAsync ();
						if (!install_result.Succeeded) {
							MainLog.WriteLine ($"Install failed, exit code: {install_result.ExitCode}.");
							ExecutionResult = TestExecutingResult.Failed;
						} else {
							await runner.RunAsync ();
							ExecutionResult = runner.Result;
						}
					}
				} catch (Exception ex) {
					MainLog.WriteLine ("Test {0} failed: {1}", Path.GetFileName (ProjectFile), ex);
					ExecutionResult = TestExecutingResult.HarnessException;
				} finally {
					var uninstall_result = await runner.UninstallAsync ();
					if (!uninstall_result.Succeeded)
						MainLog.WriteLine ($"Post-run uninstall failed, exit code: {uninstall_result.ExitCode} (this won't affect the test result)");
				}
				if (runner != null)
					Logs.AddRange (runner.Logs);
			}
		}

		protected override string XIMode {
			get {
				return "device";
			}
		}
	}

	class RunSimulatorTask : RunXITask<SimDevice>
	{
		public SimDevice [] Simulators {
			get {
				if (Device == null) {
					return new SimDevice [] { };
				} else if (CompanionDevice == null) {
					return new SimDevice [] { Device };
				} else {
					return new SimDevice [] { Device, CompanionDevice };
				}
			}
		}

		public RunSimulatorTask (XBuildTask build_task, SimDevice device = null, SimDevice companion_device = null)
			: base (build_task, device, companion_device)
		{
			var project = Path.GetFileNameWithoutExtension (ProjectFile);
			if (project.EndsWith ("-tvos", StringComparison.Ordinal)) {
				AppRunnerTarget = AppRunnerTarget.Simulator_tvOS;
			} else if (project.EndsWith ("-watchos", StringComparison.Ordinal)) {
				AppRunnerTarget = AppRunnerTarget.Simulator_watchOS;
			} else {
				AppRunnerTarget = AppRunnerTarget.Simulator_iOS;
			}
		}

		public Task PrepareSimulatorAsync ()
		{
			if (Finished)
				return Task.FromResult (true);
			
			if (!BuildTask.Succeeded) {
				ExecutionResult = TestExecutingResult.BuildFailure;
				return Task.FromResult (true);
			}

			var clean_state = false;//Platform == TestPlatform.tvOS;
			runner = new AppRunner ()
			{
				Harness = Harness,
				ProjectFile = ProjectFile,
				EnsureCleanSimulatorState = clean_state,
				Target = AppRunnerTarget,
				LogDirectory = LogDirectory,
				MainLog = Logs.CreateStream (LogDirectory, "run-" + Device.UDID + ".log", "Run log"),
			};
			runner.Simulators = Simulators;
			runner.Initialize ();

			return Task.FromResult (true);
		}

		protected override async Task ExecuteAsync ()
		{
			Jenkins.MainLog.WriteLine ("Running XI on '{0}' ({2}) for {1}", Device.Name, ProjectFile, Device.UDID);

			if (Finished)
				return;

			if (Harness.DryRun) {
				Jenkins.MainLog.WriteLine ("<running app in simulator>");
			} else {
				try {
					ExecutionResult = (ExecutionResult & ~TestExecutingResult.InProgressMask) | TestExecutingResult.Running;
					if (BuildTask.NotStarted)
						await BuildTask.RunAsync ();
					if (!BuildTask.Succeeded) {
						ExecutionResult = TestExecutingResult.BuildFailure;
						return;
					}
					if (runner == null)
						await PrepareSimulatorAsync ();
					await runner.RunAsync ();
					ExecutionResult = runner.Result;
				} catch (Exception ex) {
					MainLog.WriteLine ("Test {0} failed: {1}", Path.GetFileName (ProjectFile), ex);
					ExecutionResult = TestExecutingResult.HarnessException;
				}
				Logs.AddRange (runner.Logs);
			}
		}

		protected override string XIMode {
			get {
				return "simulator";
			}
		}
	}

	// This class groups simulator run tasks according to the
	// simulator they'll run from, so that we minimize switching
	// between different simulators (which is slow).
	class AggregatedRunSimulatorTask : TestTask
	{
		public SimDevice[] Devices;

		public IEnumerable<RunSimulatorTask> Tasks;

		// Due to parallelization this isn't the same as the sum of the duration for all the build tasks.
		Stopwatch build_timer = new Stopwatch ();
		public TimeSpan BuildDuration { get { return build_timer.Elapsed; } }

		Stopwatch run_timer = new Stopwatch ();
		public TimeSpan RunDuration { get { return run_timer.Elapsed; } }

		public AggregatedRunSimulatorTask (IEnumerable<RunSimulatorTask> tasks)
		{
			this.Tasks = tasks;
		}

		protected override async Task ExecuteAsync ()
		{
			// First build everything. This is required for the run simulator
			// task to properly configure the simulator.
			build_timer.Start ();
			await Task.WhenAll (Tasks.Select ((v) => v.BuildAsync ()).Distinct ());
			build_timer.Stop ();

			using (var desktop = await Jenkins.DesktopResource.AcquireExclusiveAsync ()) {
				run_timer.Start ();

				Jenkins.MainLog.WriteLine ("Preparing simulator: {0}", Devices.Length > 0 ? Devices [0].Name : "none");
				// We need to set the dialog permissions for all the apps
				// before launching the simulator, because once launched
				// the simulator caches the values in-memory.
				foreach (var task in Tasks)
					await task.PrepareSimulatorAsync ();

				foreach (var dev in Devices)
					await dev.PrepareSimulatorAsync (Jenkins.MainLog, Tasks.Where ((v) => !v.Ignored && !v.Failed).Select ((v) => v.BundleIdentifier).ToArray ());
				
				foreach (var task in Tasks)
					await task.RunAsync ();

				foreach (var dev in Devices)
					await dev.ShutdownAsync (Jenkins.MainLog);

				await SimDevice.KillEverythingAsync (Jenkins.MainLog);

				run_timer.Stop ();
			}

			if (Tasks.All ((v) => v.Ignored)) {
				ExecutionResult = TestExecutingResult.Ignored;
			} else {
				ExecutionResult = Tasks.Any ((v) => v.Failed) ? TestExecutingResult.Failed : TestExecutingResult.Succeeded;
			}
		}
	}

	// This is a very simple class to manage the general concept of 'resource'.
	// Performance isn't important, so this is very simple.
	// Currently it's only used to make sure everything that happens on the desktop
	// is serialized (Jenkins.DesktopResource), but in the future the idea is to
	// make each connected device a separate resource, which will make it possible
	// to run tests in parallel across devices (and at the same time use the desktop
	// to build the next test project).
	class Resource
	{
		public string Name;
		ConcurrentQueue<TaskCompletionSource<IAcquiredResource>> queue = new ConcurrentQueue<TaskCompletionSource<IAcquiredResource>> ();
		ConcurrentQueue<TaskCompletionSource<IAcquiredResource>> exclusive_queue = new ConcurrentQueue<TaskCompletionSource<IAcquiredResource>> ();
		int users;
		int max_concurrent_users = 1;
		bool exclusive;

		public Resource (string name, int max_concurrent_users = 1)
		{
			this.Name = name;
			this.max_concurrent_users = max_concurrent_users;
		}

		public Task<IAcquiredResource> AcquireConcurrentAsync ()
		{
			lock (queue) {
				if (!exclusive && users < max_concurrent_users) {
					users++;
					return Task.FromResult<IAcquiredResource> (new AcquiredResource (this));
				} else {
					var tcs = new TaskCompletionSource<IAcquiredResource> (new AcquiredResource (this));
					queue.Enqueue (tcs);
					return tcs.Task;
				}
			}
		}

		public Task<IAcquiredResource> AcquireExclusiveAsync ()
		{
			lock (queue) {
				if (users == 0) {
					users++;
					exclusive = true;
					return Task.FromResult<IAcquiredResource> (new AcquiredResource (this));
				} else {
					var tcs = new TaskCompletionSource<IAcquiredResource> (new AcquiredResource (this));
					exclusive_queue.Enqueue (tcs);
					return tcs.Task;
				}
			}
		}

		void Release ()
		{
			TaskCompletionSource<IAcquiredResource> tcs;

			lock (queue) {
				users--;
				exclusive = false;
				if (queue.TryDequeue (out tcs)) {
					users++;
					tcs.SetResult ((IAcquiredResource) tcs.Task.AsyncState);
				} else if (users == 0 && exclusive_queue.TryDequeue (out tcs)) {
					users++;
					exclusive = true;
					tcs.SetResult ((IAcquiredResource) tcs.Task.AsyncState);
				}
			}
		}
		class AcquiredResource : IAcquiredResource
		{
			Resource resource;

			public AcquiredResource (Resource resource)
			{
				this.resource = resource;
			}

			void IDisposable.Dispose ()
			{
				resource.Release ();
			}

			public Resource Resource { get { return resource; } }
		}
	}

	interface IAcquiredResource : IDisposable
	{
		Resource Resource { get; }
	}

	class Resources
	{
		readonly Resource [] resources;

		public Resources (IEnumerable<Resource> resources)
		{
			this.resources = resources.ToArray ();
		}

		public Task<IAcquiredResource> AcquireAnyConcurrentAsync ()
		{
			if (resources.Length == 0)
				throw new Exception ("No resources");

			if (resources.Length == 1)
				return resources [0].AcquireConcurrentAsync ();

			// We try to acquire every resource
			// When the first one succeeds, we set the result to true
			// We immediately release any other resources we acquire.
			var tcs = new TaskCompletionSource<IAcquiredResource> ();
			for (int i = 0; i < resources.Length; i++) {
				resources [i].AcquireConcurrentAsync ().ContinueWith ((v) =>
				{
					var ar = v.Result;
					if (!tcs.TrySetResult (ar))
						ar.Dispose ();
				});
			}

			return tcs.Task;
		}
	}

	public enum TestPlatform
	{
		None,
		iOS,
		iOS_Unified,
		iOS_Unified32,
		iOS_Unified64,
		tvOS,
		watchOS,

		Mac,
		Mac_Classic,
		Mac_Unified,
		Mac_UnifiedXM45,
		Mac_Unified32,
		Mac_UnifiedXM45_32,
	}

	[Flags]
	public enum TestExecutingResult
	{
		NotStarted = 0,
		InProgress = 0x1,
		Finished   = 0x2,
		Waiting    = 0x4,
		StateMask  = NotStarted + InProgress + Waiting + Finished,

		// In progress state
		Building         =   0x10 + InProgress,
		BuildQueued      =   0x10 + InProgress + Waiting,
		Built            =   0x20 + InProgress,
		Running          =   0x40 + InProgress,
		RunQueued        =   0x40 + InProgress + Waiting,
		InProgressMask   =   0x10 + 0x20 + 0x40,

		// Finished results
		Succeeded        =  0x100 + Finished,
		Failed           =  0x200 + Finished,
		Ignored          =  0x400 + Finished,

		// Finished & Failed results
		Crashed          = 0x1000 + Failed,
		TimedOut         = 0x2000 + Failed,
		HarnessException = 0x4000 + Failed,
		BuildFailure     = 0x8000 + Failed,
	}
}
