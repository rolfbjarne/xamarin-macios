using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

using Microsoft.Build.Framework;

using Xamarin.Localization.MSBuild;
using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks {
	public abstract partial class MergeAppBundlesTaskBase : XamarinTask {

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

		class Entries : List<Entry> {
			public string BundlePath;
			public string SpecificSubdirectory;
		}

		class Entry {
			public Entries AppBundle;
			public string RelativePath;
			public FileType Type;
			public List<Entry> DependentFiles;

			public string FullPath => Path.Combine (AppBundle.BundlePath, RelativePath);

			void FindDependentFiles (List<Entry> list, Func<Entry, bool> condition)
			{
				var dependentFiles = list.Where (condition).ToArray ();
				if (dependentFiles.Length == 1) {
					var dependentFile = dependentFiles [0];
					list.Remove (dependentFile);
					if (DependentFiles == null)
						DependentFiles = new List<Entry> ();
					DependentFiles.Add (dependentFile);
				} else {
					Console.WriteLine ($"// TODO: show error.");
				}
			}

			public bool IsIdenticalTo (Entry other)
			{
				if (other is null)
					throw new ArgumentNullException (nameof (other));

				if (!FileUtils.CompareFiles (FullPath, other.FullPath))
					return false;

				if (DependentFiles != null && other.DependentFiles != null) {
					// there are different number of dependent files
					if (DependentFiles.Count != other.DependentFiles.Count)
						return false;
					// group by relative path
					var grouped = DependentFiles.Union (other.DependentFiles).GroupBy (v => v.RelativePath);
					foreach (var group in grouped) {
						// the files don't match up (same number of files, but not the same filenames)
						var files = group.ToArray ();
						if (files.Length != 2)
							return false;
						if (!FileUtils.CompareFiles (files [0].FullPath, files [1].FullPath))
							return false;
					}
				}

				return true;
			}			

			public void FindDependentFiles (List<Entry> list)
			{
				// pdb
				FindDependentFiles (list, v => string.Equals (v.RelativePath, Path.ChangeExtension (RelativePath, "pdb"), StringComparison.OrdinalIgnoreCase));

				// config
				FindDependentFiles (list, v => string.Equals (v.RelativePath, RelativePath + ".config", StringComparison.OrdinalIgnoreCase));

				// satellite assemblies
				var satelliteName = Path.GetFileNameWithoutExtension (RelativePath) + "resources.dll";
				FindDependentFiles (list, v => {
					// if the name isn't the satellite name, it's not a dependent assembly of ours
					if (!string.Equals (Path.GetFileName (v.RelativePath), satelliteName, StringComparison.OrdinalIgnoreCase))
						return false;

					// if it's not in an immediate subdirectory, it's not a dependent assembly of ours
					if (!string.Equals (Path.GetDirectoryName (Path.GetDirectoryName (v.RelativePath)), Path.GetDirectoryName (RelativePath), StringComparison.OrdinalIgnoreCase))
						return false;

					// if the name of the immediate subdirectory isn't a valid culture, then it's not a dependent assembly of ours
					var immediateSubDir = Path.GetFileName (Path.GetDirectoryName (v.RelativePath));
					var cultureInfo = CultureInfo.GetCultureInfo (immediateSubDir);
					if (cultureInfo == null)
						return false;

					return true;
				});
			}

			public void CopyTo (string outputDirectory)
			{
				var outputFile = Path.Combine (outputDirectory, RelativePath);
				File.Copy (FullPath, outputFile, true);
				if (DependentFiles != null) {
					foreach (var file in DependentFiles)
						file.CopyTo (outputDirectory);
				}
			}
		}

		public override bool Execute ()
		{
			// Some validation
			foreach (var input in InputAppBundles) {
				if (!Directory.Exists (input.ItemSpec)) {
					Log.LogError ($"The InputAppBundle {input.ItemSpec} does not exist."); // TODO: better error
					return false;
				}
				var specificSubdirectory = input.GetMetadata ("SpecificSubdirectory");
				if (string.IsNullOrEmpty (specificSubdirectory)) {
					Log.LogError ($"The InputAppBundle {input.ItemSpec} does not have a 'SpecificSubDirectory' metadata."); // TODO: better error
					return false;
				}
			}

			// Gather all the files in each input app bundle
			var inputFiles = new Entries [InputAppBundles.Length];
			for (var i = 0; i < InputAppBundles.Length; i++) {
				var input = InputAppBundles [i];
				var specificSubdirectory = input.GetMetadata ("SpecificSubdirectory");
				var fullInput = Path.GetFullPath (input.ItemSpec);
				// strip the trailing path separator
				if (fullInput[fullInput.Length - 1] == Path.DirectorySeparatorChar)
					fullInput = fullInput.Substring (0, fullInput.Length - 1);
				// get all the files and subdirectories in the input app bundle
				var files = Directory.GetFileSystemEntries (fullInput);
				var entries = new Entries () {
					BundlePath = fullInput,
					SpecificSubdirectory = specificSubdirectory,
				};
				foreach (var file in files) {
					var relativePath = file.Substring (fullInput.Length + 1);
					var entry = new Entry {
						RelativePath = relativePath,
						AppBundle = entries,
						Type = GetFileType (file),
					};
					entries.Add (entry);
				}
			}

			// Group dependent files for assemblies
			for (var i = 0; i < inputFiles.Length; i++) {
				var list = inputFiles [i];
				var assemblies = list.Where (v => v.Type == FileType.PEAssembly).ToArray ();
				foreach (var assembly in assemblies) {
					assembly.FindDependentFiles (list);
				}
			}

			// List the input
			foreach (var list in inputFiles) {
				Console.WriteLine ($"Input files found in {list.BundlePath}:");
				foreach (var file in list) {
					Console.WriteLine ($"    {file} Type: {file.Type} Dependent assemblies: {file.DependentFiles?.Count.ToString () ?? "0"}");
					if (file.DependentFiles?.Any () == true) {
						foreach (var df in file.DependentFiles) {
							Console.WriteLine ($"        {file} Type: {file.Type}");
						}
					}
				}
			}

			// Group the input
			var map = new Dictionary<string, List<Entry>> ();
			foreach (var list in inputFiles) {
				foreach (var file in list) {
					if (!map.TryGetValue (file.RelativePath, out var groupedList)) {
						map [file.RelativePath] = groupedList = new List<Entry> ();
					}
					groupedList.Add (file);
				}
			}

			// Verify that the type of the input for each target file is the same
			foreach (var kvp in map) {
				var types = kvp.Value.Select (v => v.Type).Distinct ();
				if (types.Count () > 1) {
					// Files of different types.
					Log.LogError ("// FIXME: show error about different types");
					return false;
				}
			}

			// Merge stuff
			Directory.CreateDirectory (OutputAppBundle);
			foreach (var kvp in map) {
				var relativePath = kvp.Key;
				var entries = kvp.Value;
				var outputFile = Path.Combine (OutputAppBundle, relativePath);

				// FIXME: only if newer/modified

				if (entries.Count == 1) {
					// just copy the file(s) if there's only one
					entries [0].CopyTo (OutputAppBundle);
					continue;
				}

				// If they're all the same, just copy the first one
				var identical = true;
				for (var i = 1; i < entries.Count; i++) {
					if (!entries [0].IsIdenticalTo (entries [i])) {
						identical = false;
						break;
					}
				}
				if (identical) {
					// All the input files are identical. Just copy the first one into the bundle.
					entries [0].CopyTo (OutputAppBundle); // TODO: only if changed
					continue;
				}

				// Custom merging is needed, depending on the type
				switch (entries [0].Type) {
				case FileType.MachO:
					MergeMachOFiles (outputFile, entries);
					break;
				case FileType.PEAssembly:
					MergePEAssembly (outputFile, entries);
					break;
				default:
					Log.LogError ($"Unknown merge file type: {entries [0].Type}"); // FIXME: show error
					break;
				}
			}

			return !Log.HasLoggedErrors;
		}

		void MergePEAssembly (string output, IList<Entry> inputs)
		{
			foreach (var input in inputs) {
				var targetDirectory = Path.Combine (input.AppBundle.BundlePath, input.AppBundle.SpecificSubdirectory);
				input.CopyTo (targetDirectory);
			}
		}

		void MergeMachOFiles (string output, IList<Entry> input)
		{
			if (input.Any (v => v.DependentFiles?.Any () == true)) {
				Log.LogError ($"// TODO: Should not have dependent files");
				return;
			}

			// TODO: only if changed
			var arguments = new List<string> ();
			arguments.Add ("-create");
			arguments.Add ("-output");
			arguments.Add (output);
			arguments.AddRange (input.Select (v => v.FullPath));
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

