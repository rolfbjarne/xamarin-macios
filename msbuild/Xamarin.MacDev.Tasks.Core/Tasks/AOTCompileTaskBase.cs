using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

using Microsoft.Build.Framework;

using Xamarin.Localization.MSBuild;
using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks {
	public abstract class AOTCompileTaskBase : XamarinTask {

		[Required]
		public ITaskItem [] Assemblies { get; set; }

		[Required]
		public string AOTCompilerPath { get; set; }

		[Required]
		public string InputDirectory { get; set; }

		[Required]
		public string MinimumOSVersion { get; set; }

		[Required]
		public string OutputDirectory { get; set; }

		[Required]
		public string SdkDevPath { get; set; }

		[Required]
		public bool SdkIsSimulator { get; set; }

		[Required]
		public string SdkRoot { get; set; }

		[Required]
		public string TargetArchitectures { get; set; }

		TargetArchitecture architectures;

		public override bool Execute ()
		{
			var processes = new Task<Execution> [Assemblies.Length];
			var objectFiles = new List<ITaskItem> ();

			Directory.CreateDirectory (OutputDirectory);

			if (!Enum.TryParse (TargetArchitectures, out architectures)) {
				Log.LogError (12, null, MSBStrings.E0012, TargetArchitectures);
				return false;
			}

			var inputs = new List<string> (Assemblies.Length);
			for (var i = 0; i < Assemblies.Length; i++) {
				inputs.Add (Path.GetFullPath (Assemblies [i].ItemSpec));
			}

			// All the assemblies to AOT must be in the same directory
			var assemblyDirectories = inputs.Select (v => Path.GetDirectoryName (Path.GetFullPath (v))).Distinct ().ToArray ();
			if (assemblyDirectories.Length > 1) {
				// The assemblies are not in the same directory, so copy them somewhere else
				for (var i = 0; i < inputs.Count; i++) {
					var newInput = Path.Combine (InputDirectory, Path.GetFileName (inputs [i]));
					File.Copy (inputs [i], newInput, true);
					inputs [i] = newInput;
				}
			} else {
				// The assemblies are all in the same directory, we can just use that as input.
				InputDirectory = assemblyDirectories [0];
			}

			Directory.CreateDirectory (InputDirectory);

			var environment = new Dictionary<string, string> {
				{ "MONO_PATH", Path.GetFullPath (InputDirectory) },
			};

			foreach (var arch in architectures.ToArray ()) {

				for (var i = 0; i < Assemblies.Length; i++) {
					var asm = Assemblies [i];
					var src = Path.GetFullPath (asm.ItemSpec);
					var arguments = new List<string> ();
					var abi = arch.ToNativeArchitecture ();

					arguments.Add ("--debug");
					arguments.Add ("-O=gsharedvt");
					arguments.Add ("-O=-float32");

					var aotArg = new StringBuilder ();
					aotArg.Append ($"--aot=mtriple={abi}-{PlatformName.ToLowerInvariant ()}");
					aotArg.Append ($",data-outfile={Path.Combine (OutputDirectory, Path.GetFileNameWithoutExtension (src) + ".aotdata." + abi)}");
					aotArg.Append ($",static,asmonly,direct-icalls,full,dwarfdebug,no-direct-calls");
					aotArg.Append ($",soft-debug");
					aotArg.Append ($",outfile={Path.Combine (OutputDirectory, Path.GetFileName (src) + ".s")}");
					arguments.Add (aotArg.ToString ());
					arguments.Add (inputs [i]);

					processes [i] = ExecuteAsync (AOTCompilerPath, arguments, environment: environment, sdkDevPath: SdkDevPath, showErrorIfFailure: false /* we show our own error below */);

					processes [i].Wait ();

					processes [i] = processes [i].ContinueWith ((v) => {
						if (v.Result.ExitCode != 0) {
							Log.LogError ("Failed to AOT compile {0}, the AOT compiler exited with code {1}", Path.GetFileName (src), v.Result.ExitCode);

							return System.Threading.Tasks.Task.FromResult<Execution> (v.Result);
						}

						// Compile the native code into a .o file
						var linkerArgs = new List<string> ();
						linkerArgs.Add ("clang");
						linkerArgs.Add ("-Xlinker");
						linkerArgs.Add ("-rpath");
						linkerArgs.Add ("-Xlinker");
						linkerArgs.Add ("@executable_path/");
						linkerArgs.Add ("-isysroot");
						linkerArgs.Add (SdkRoot);
						linkerArgs.Add ("-Qunused-arguments");
						linkerArgs.Add (PlatformFrameworkHelper.GetMinimumVersionArgument (TargetFrameworkMoniker, SdkIsSimulator, MinimumOSVersion));
						linkerArgs.Add ("-arch");
						linkerArgs.Add (abi);
						linkerArgs.Add ("-c");
						linkerArgs.Add ("-o");
						linkerArgs.Add (Path.Combine (OutputDirectory, Path.GetFileName (src) + ".o"));
						linkerArgs.Add ("-x");
						linkerArgs.Add ("assembler");
						linkerArgs.Add ("-D");
						linkerArgs.Add ("DEBUG");
						linkerArgs.Add (Path.Combine (OutputDirectory, Path.GetFileName (src) + ".s"));

						return ExecuteAsync ("xcrun", linkerArgs, sdkDevPath: SdkDevPath);
					}, TaskContinuationOptions.OnlyOnRanToCompletion).Unwrap ();
				}
			}

			System.Threading.Tasks.Task.WaitAll (processes);

			return !Log.HasLoggedErrors;

		}
	}
}

