using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Localization.MSBuild;
using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks {
	public abstract class AOTCompileTaskBase : XamarinTask {
		[Required]
		public string AOTCompilerPath { get; set; }

		[Required]
		public ITaskItem [] Assemblies { get; set; }

		[Required]
		public string InputDirectory { get; set; }

		[Required]
		public string MinimumOSVersion { get; set; }

		[Required]
		public string OutputDirectory { get; set; }

		[Required]
		public string SdkDevPath { get; set; }

#region Output
		[Output]
		public ITaskItem[] AssemblyFiles { get; set; }

		[Output]
		public ITaskItem[] AOTData { get; set; }
#endregion

		public override bool Execute ()
		{
			var inputs = new List<string> (Assemblies.Length);
			for (var i = 0; i < Assemblies.Length; i++) {
				inputs.Add (Path.GetFullPath (Assemblies [i].ItemSpec));
			}

			// All the assemblies to AOT must be in the same directory
			var assemblyDirectories = inputs.Select (v => Path.GetDirectoryName (Path.GetFullPath (v))).Distinct ().ToArray ();
			if (assemblyDirectories.Length > 1) {
				// The assemblies are not in the same directory, so copy them somewhere else (to InputDirectory)
				Directory.CreateDirectory (InputDirectory);
				for (var i = 0; i < inputs.Count; i++) {
					var newInput = Path.Combine (InputDirectory, Path.GetFileName (inputs [i]));
					File.Copy (inputs [i], newInput, true);
					inputs [i] = newInput;
				}
			} else {
				// The assemblies are all in the same directory, we can just use that as input.
				InputDirectory = assemblyDirectories [0];
			}

			Directory.CreateDirectory (OutputDirectory);

			var aotAssemblyFiles = new List<ITaskItem> ();
			var aotDataFiles = new List<ITaskItem> ();
			var processes = new Task<Execution> [Assemblies.Length];
			var objectFiles = new List<ITaskItem> ();

			var environment = new Dictionary<string, string> {
				{ "MONO_PATH", Path.GetFullPath (InputDirectory) },
			};

			for (var i = 0; i < Assemblies.Length; i++) {
				var asm = Assemblies [i];
				var input = inputs [i];
				var arch = Assemblies [i].GetMetadata ("Arch");
				var aotArguments = Assemblies [i].GetMetadata ("AOTArguments");
				var aotData = Assemblies [i].GetMetadata ("AOTData");
				var aotAssembly = Assemblies [i].GetMetadata ("AOTAssembly");

				var aotAssemblyItem = new TaskItem (aotAssembly);
				aotAssemblyItem.SetMetadata ("Arguments", "-Xlinker -rpath -Xlinker @executable_path/ -Qunused-arguments -x assembler -D DEBUG");
				aotAssemblyItem.SetMetadata ("Arch", arch);
				aotAssemblyFiles.Add (aotAssemblyItem);
				aotDataFiles.Add (new TaskItem (aotData));

				//var aotArg = new StringBuilder ();
				//aotArg.Append ($"--aot=mtriple={arch}-{PlatformName.ToLowerInvariant ()},");
				//aotArg.Append ($"data-outfile={aotData},");
				//aotArg.Append ($"static,asmonly,direct-icalls,full,dwarfdebug,no-direct-calls,");
				//aotArg.Append ($"soft-debug,");
				//aotArg.Append ($"outfile={aotAssembly}");

				var arguments = new List<string> ();
				if (!StringUtils.TryParseArguments (aotArguments, out var parsedArguments, out var ex))
					throw ex;
				arguments.AddRange (parsedArguments);
				arguments.Add (input);
				//arguments.Add (aotArg.ToString ());
				//arguments.Add ("--debug");
				//arguments.Add ("-O=gsharedvt");
				//arguments.Add ("-O=-float32");
				//arguments.Add (input);

				processes [i] = ExecuteAsync (AOTCompilerPath, arguments, environment: environment, sdkDevPath: SdkDevPath, showErrorIfFailure: false /* we show our own error below */)
					.ContinueWith ((v) => {
						if (v.Result.ExitCode != 0)
							Log.LogError ("Failed to AOT compile {0}, the AOT compiler exited with code {1}", Path.GetFileName (input), v.Result.ExitCode);

						return System.Threading.Tasks.Task.FromResult<Execution> (v.Result);
					}).Unwrap ();
			}

			System.Threading.Tasks.Task.WaitAll (processes);

			AOTData = aotDataFiles.ToArray ();
			AssemblyFiles = aotAssemblyFiles.ToArray ();

			return !Log.HasLoggedErrors;

		}
	}
}

