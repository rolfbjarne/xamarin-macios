using System;
using System.IO;
using System.Text;

using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;
using Xamarin.Localization.MSBuild;
using Xamarin.Bundler;

namespace Xamarin.MacDev.Tasks {
	public abstract class GenerateMainTaskBase : XamarinTask {
		#region Input
		[Required]
		public string Architectures { get; set; }

		[Required]
		public string OutputDirectory { get; set; }

		public int Verbosity { get; set; }

		[Required]
		public ITaskItem [] Assemblies { get; set; }

		#endregion

		#region Output
		[Output]
		public ITaskItem [] GeneratedMain { get; set; }
		#endregion

		public override bool Execute ()
		{
			try {
				if (TryParseTargetArchitectures (Architectures, out var architectures)) {
					Log.LogError (57, MSBStrings.E0057 /* Invalid architectures: '{0}'. */, Architectures);
					return false;
				}

				var assemblies = new Assembly [Assemblies.Length];
				for (var i = 0; i < assemblies.Length; i++) {
					var asmitem = Assemblies [i];
					var asm = new Assembly ();
					asm.IsAOTCompiled = asmitem.GetMetadata ("IsAOTCompiled") == "true";
					asm.FileName = Path.GetFileName (asmitem.ItemSpec);
					var bt = asmitem.GetMetadata ("BuildTarget");
					if (!Enum.TryParse<AssemblyBuildTarget> (bt, out var build_target)) {
						Log.LogError (99, "TODO", $"Invalid Build Target: {bt}");
						return false;
					}
					asm.BuildTarget = build_target;
					asm.BuildTargetName = asmitem.GetMetadata ("BuildTargetName");
					asm.Identity = asmitem.GetMetadata ("AssemblyIdentity"); // Can't use 'Identity', because it's already a well-known MSBuild metadata item.
					asm.IsCodeShared = asmitem.GetMetadata ("IsCodeShared") == "true";
					asm.IsBoundAssembly = asmitem.GetMetadata ("IsBoundAssembly") == "true";
					asm.AssemblyName = asmitem.GetMetadata ("AssemblyName");
					assemblies [i] = asm;
				}

				var arches = architectures.ToList ();

				GeneratedMain = new ITaskItem [arches.Count];

				for (var i = 0; i < arches.Count; i++) {
					var arch = arches [i];
					var abi = arch.ToAbi ();


					var app = new Application ();
					app.Platform = Platform;

					var mainGenerator = new MainGenerator ();
					mainGenerator.App = app;
					mainGenerator.Verbosity = Verbosity;
					mainGenerator.Abi = abi;
					mainGenerator.Assemblies = assemblies;
					mainGenerator.RegistrationMethods = null; // FIXME
					mainGenerator.Output = Path.Combine (OutputDirectory, $"main.{abi.AsArchString ()}.m");

					mainGenerator.Generate ();

					var item = new TaskItem (mainGenerator.Output);
					item.SetMetadata ("Abi", abi.AsArchString ());
					GeneratedMain [i] = item;
				}

			} catch (ProductException pe) {
				Log.LogError (7069, null, MSBStrings.E7069 /* Failed to generate the main method: {0 */, pe.Message);
			}

			return true;
		}
	}
}

