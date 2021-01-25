using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

using Xamarin.Utils;

namespace Xamarin.Linker {
	public class ComputeAOTArguments : ConfigurationAwareStep {
		protected override string Name { get; } = "Compute AOT Arguments";
		protected override int ErrorCode { get; } = 2370;

		protected override void TryEndProcess ()
		{
			base.TryEndProcess ();

			var assembliesToAOT = new List<MSBuildItem> ();

			var app = Configuration.Application;
			var outputDirectory = Configuration.AOTOutputDirectory;

			foreach (var asm in Configuration.Target.Assemblies) {
				var isInterpreted = asm.IsInterpreted;
				var isAOTCompiled = asm.IsAOTCompiled;

				if (!isAOTCompiled)
					continue;

				var item = new MSBuildItem {
					Include = asm.FullPath,
					Metadata = new Dictionary<string, string> {
						{ "IsInterpreted", isInterpreted ? "true" : "false" },
						{ "IsAOTCompiled", isAOTCompiled ? "true" : "false" },
					},
				};

				var input = asm.FullPath;
				var abis = app.Abis.Select (v => v.AsString ()).ToArray ();
				foreach (var abi in app.Abis) {
					var abiString = abi.AsString ();
					var arch = abi.AsArchString ();
					var aotAssembly = Path.Combine (outputDirectory, arch, Path.GetFileName (input) + ".s");
					var aotData = Path.Combine (outputDirectory, arch, Path.GetFileNameWithoutExtension (input) + ".aotdata");
					var llvmFile = string.Empty;
					if ((abi & Abi.LLVM) == Abi.LLVM)
						throw new NotImplementedException ($"Support for LLVM hasn't been implemented yet.");
					var aotArguments = app.GetAotArguments (asm.FullPath, abi, outputDirectory, aotAssembly, llvmFile, aotData);
					aotArguments.RemoveAt (aotArguments.Count - 1); // remove the input filename
					item.Metadata.Add ("AOTArguments", StringUtils.FormatArguments (aotArguments));
					item.Metadata.Add ("Abi", abiString);
					item.Metadata.Add ("Arch", arch);
					item.Metadata.Add ("Assembly", input);
					item.Metadata.Add ("AOTData", aotData);
					item.Metadata.Add ("AOTAssembly", aotAssembly);
				}

				assembliesToAOT.Add (item);
			}

			Configuration.WriteOutputForMSBuild ("_AssembliesToAOT", assembliesToAOT);
		}
	}
}

