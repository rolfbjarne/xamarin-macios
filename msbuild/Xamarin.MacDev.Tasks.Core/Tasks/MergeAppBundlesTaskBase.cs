using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Microsoft.Build.Framework;

using Xamarin.Localization.MSBuild;
using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks {
	public abstract class MergeAppBundlesTaskBase : XamarinTask {

		#region Inputs
		[Required]
		public ITaskItem [] InputAppBundles { get; set; }

		[Required]
		public string OutputAppBundle { get; set; }

		[Required]
		public string SdkDevPath { get; set; }
		#endregion

		enum FileType {
			MachO,
			PEAssembly,
			Other,
		}

		public override bool Execute ()
		{
			Directory.CreateDirectory (OutputAppBundle);

			var map = new Dictionary<string, List<string>> ();

			foreach (var input in InputAppBundles) {
				if (!Directory.Exists (input.ItemSpec)) {
					Console.WriteLine ($"// TODO: show error.");
					return false;
				}
			}

			foreach (var input in InputAppBundles) {
				var fullInput = Path.GetFullPath (input.ItemSpec);
				// strip the trailing path separator
				if (fullInput[fullInput.Length - 1] == Path.DirectorySeparatorChar)
					fullInput = fullInput.Substring (0, fullInput.Length - 1);
				// get all the files and subdirectories in the input app bundle
				var files = Directory.GetFileSystemEntries (fullInput);
				foreach (var file in files) {
					var relativePath = file.Substring (fullInput.Length + 1);
					if (!map.TryGetValue (relativePath, out var list))
						map [relativePath] = list = new List<string> ();
					list.Add (fullInput);
				}
			}

			foreach (var kvp in map) {
				var relativePath = kvp.Key;
				var bundles = kvp.Value;
				var outputFile = Path.Combine (OutputAppBundle, relativePath);
				var inputFiles = bundles.Select (v => Path.Combine (v, relativePath)).ToArray ();

				// FIXME: only if newer/modified

				if (inputFiles.Length == 1) {
					// just copy the file
					File.Copy (inputFiles [0], outputFile, true);
					continue;
				}

				var types = inputFiles.Select (GetFileType).ToArray ();
				if (types.Distinct ().Count () > 1) {
					// Files of different types.
					Console.WriteLine ("// FIXME: show error");
					return false;
				}

				switch (types [0]) {
				case FileType.MachO:
					MergeMachOFiles (outputFile, inputFiles);
					break;
				case FileType.PEAssembly:
				case FileType.Other:
				default:
					Console.WriteLine ($"Unknown file type: {types [0]}"); // FIXME: show error
					return false;
				}
			}

			return !Log.HasLoggedErrors;
		}

		void MergeMachOFiles (string output, params string [] input)
		{
			var arguments = new List<string> ();
			arguments.Add ("-create");
			arguments.Add ("-output");
			arguments.Add (output);
			arguments.AddRange (input);
			ExecuteAsync ("lipo", arguments, sdkDevPath: SdkDevPath).Wait ();
		}

		static FileType GetFileType (string path)
		{
			if (path.EndsWith (".exe", StringComparison.Ordinal) || path.EndsWith (".dll", StringComparison.Ordinal))
				return FileType.PEAssembly;

			if (MachO.IsMachOFile (path))
				return FileType.MachO;

			if (StaticLibrary.IsStaticLibrary (path))
				return FileType.MachO;

			return FileType.Other;
		}
	}
}

