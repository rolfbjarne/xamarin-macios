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
			Directory,
			Symlink,
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

			void FindDependentFiles (Func<Entry, bool> condition)
			{
				var dependentFiles = AppBundle.Where (v => v != this).Where (condition).ToArray ();

				if (dependentFiles.Length > 0) {
					if (DependentFiles == null)
						DependentFiles = new List<Entry> ();

					foreach (var dependentFile in dependentFiles) {
						AppBundle.Remove (dependentFile);
						DependentFiles.Add (dependentFile);
						Console.WriteLine ($"Added dependent file {dependentFile.RelativePath} to {RelativePath}");
					}
				}
			}

			public void FindDependentFiles ()
			{
				Console.WriteLine ($"Finding dependencies for {RelativePath}");
				// pdb
				FindDependentFiles (v => string.Equals (v.RelativePath, Path.ChangeExtension (RelativePath, "pdb"), StringComparison.OrdinalIgnoreCase));

				// config
				FindDependentFiles (v => string.Equals (v.RelativePath, RelativePath + ".config", StringComparison.OrdinalIgnoreCase));

				// satellite assemblies
				var satelliteName = Path.GetFileNameWithoutExtension (RelativePath) + ".resources.dll";
				FindDependentFiles (v => {
					if (v.Type != FileType.PEAssembly)
						return false;

					// if the name isn't the satellite name, it's not a dependent assembly of ours
					if (!string.Equals (Path.GetFileName (v.RelativePath), satelliteName, StringComparison.OrdinalIgnoreCase)) {
						Console.WriteLine ($"Not the right satellite assembly name: {v.RelativePath} Name: {Path.GetFileName (v.RelativePath)} satelliteName: {satelliteName}");
						return false;
					}

					// if it's not in an immediate subdirectory, it's not a dependent assembly of ours
					if (!string.Equals (Path.GetDirectoryName (Path.GetDirectoryName (v.RelativePath)), Path.GetDirectoryName (RelativePath), StringComparison.OrdinalIgnoreCase)) {
						Console.WriteLine ($"Not immediate subdir: {v.RelativePath}");
						return false;
					}

					// if the name of the immediate subdirectory isn't a valid culture, then it's not a dependent assembly of ours
					var immediateSubDir = Path.GetFileName (Path.GetDirectoryName (v.RelativePath));
					var cultureInfo = CultureInfo.GetCultureInfo (immediateSubDir);
					if (cultureInfo == null) {
						Console.WriteLine ($"Not a culture: {v.RelativePath}");
						return false;
					}


					Console.WriteLine ($"Found: {v.RelativePath}");

					return true;
				});

				// also add the directories where the satellite assemblies are
				if (DependentFiles?.Any () == true) {
					Console.WriteLine ($"Check for subdirs for dependent files for: {RelativePath}");
					FindDependentFiles (v => {
						if (v.Type != FileType.Directory && v.Type != FileType.Symlink)
							return false;

						Console.WriteLine ($"    Testing: {v.RelativePath}");

						return DependentFiles.Any (df => {
							if (df.Type != FileType.PEAssembly) {
								Console.WriteLine ($"    {df.RelativePath} is of the wrong type.");
								return false;
							}
							if (Path.GetDirectoryName (df.RelativePath) != v.RelativePath) {
								Console.WriteLine ($"    {Path.GetDirectoryName (df.RelativePath)} and {v.RelativePath} don't match.");
								return false;
							}
							Console.WriteLine ($"    {df.RelativePath} is of the CORRECT type.");
							return true;
						});
					});
				}
			}

			public bool IsIdenticalTo (Entry other)
			{
				if (other is null)
					throw new ArgumentNullException (nameof (other));

				if (other.Type != Type)
					return false;

				if (Type == FileType.Directory)
					return true;

				if (Type == FileType.Symlink) {
					var thisTarget = PathUtils.GetSymlinkTarget (FullPath);
					var otherTarget = PathUtils.GetSymlinkTarget (other.FullPath);
					return string.Equals (thisTarget, otherTarget, StringComparison.Ordinal);
				}

				if (!FileUtils.CompareFiles (FullPath, other.FullPath))
					return false;

				if (DependentFiles != null && other.DependentFiles != null) {
					// check if there are different number of dependent files, if so, we're different
					if (DependentFiles.Count != other.DependentFiles.Count)
						return false;

					// group by relative path
					var grouped = DependentFiles.Union (other.DependentFiles).GroupBy (v => v.RelativePath);
					foreach (var group in grouped) {
						// the files don't match up (same number of files, but not the same filenames)
						var files = group.ToArray ();
						if (files.Length != 2)
							return false;

						// compare the dependent files.
						if (!files [0].IsIdenticalTo (files [1]))
							return false;
					}
				}

				return true;
			}

			public void CopyTo (string outputDirectory)
			{
				var outputFile = Path.Combine (outputDirectory, RelativePath);
				if (Type == FileType.Directory) {
					Directory.CreateDirectory (outputFile);
				} else if (Type == FileType.Symlink) {
					Directory.CreateDirectory (Path.GetDirectoryName (outputFile));
					PathUtils.Symlink (PathUtils.GetSymlinkTarget (FullPath), Path.Combine (outputDirectory, RelativePath));
				} else {
					Directory.CreateDirectory (Path.GetDirectoryName (outputFile));
					File.Copy (FullPath, outputFile, true);
				}

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
				var files = Directory.GetFileSystemEntries (fullInput, "*", SearchOption.AllDirectories);
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
					Console.WriteLine ($"File: {file} RelativePath: {relativePath} Type: {entry.Type}");
				}
				inputFiles [i] = entries;
			}

			// Group dependent files for assemblies
			for (var i = 0; i < inputFiles.Length; i++) {
				var list = inputFiles [i];
				var assemblies = list.Where (v => v.Type == FileType.PEAssembly).ToArray ();
				foreach (var assembly in assemblies) {
					assembly.FindDependentFiles ();
				}
			}

			// List the input
			foreach (var list in inputFiles) {
				Console.WriteLine ($"Input files found in {list.BundlePath}:");
				foreach (var file in list) {
					Console.WriteLine ($"    {file.RelativePath} Type: {file.Type} Dependent files: {file.DependentFiles?.Count.ToString () ?? "0"}");
					if (file.DependentFiles?.Any () == true) {
						foreach (var df in file.DependentFiles) {
							Console.WriteLine ($"        {df.RelativePath} Type: {df.Type}");
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
					Console.WriteLine ($"The file '{entries [0].RelativePath}' only exists in '{entries [0].AppBundle.BundlePath}' and will be copied to the merged app bundle.");
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
					Console.WriteLine ($"All the files for '{entries [0].RelativePath}' between all the input app bundles, and will be copied to the merged app bundle.");
					entries [0].CopyTo (OutputAppBundle); // TODO: only if changed
					continue;
				}

				// Custom merging is needed, depending on the type
				switch (entries [0].Type) {
				case FileType.MachO:
					MergeMachOFiles (outputFile, entries);
					break;
				case FileType.PEAssembly:
					MergePEAssembly (entries);
					break;
				case FileType.Symlink:
					Log.LogError ($"Can't merge symlinks with different targets."); // FIXME: better error
					break;
				default:
					Log.LogError ($"Unknown merge file type: {entries [0].Type}"); // FIXME: show error
					break;
				}
			}

			return !Log.HasLoggedErrors;
		}

		void MergePEAssembly (IList<Entry> inputs)
		{
			foreach (var input in inputs) {
				var targetDirectory = Path.Combine (input.AppBundle.BundlePath, input.AppBundle.SpecificSubdirectory);
				Console.WriteLine ($"Copying '{input.RelativePath}' to the specific subdirectory {input.AppBundle.SpecificSubdirectory} for the merged app bundle.");
				input.CopyTo (targetDirectory);
			}
		}

		void MergeMachOFiles (string output, IList<Entry> input)
		{
			if (input.Any (v => v.DependentFiles?.Any () == true)) {
				Log.LogError ($"// TODO: Should not have dependent files");
				return;
			}

			Console.WriteLine ($"Lipoing '{input [0].RelativePath}' for the merged app bundle from the following sources:\n\t{string.Join ("\n\t", input.Select (v => v.FullPath))}");

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
			if (Directory.Exists (path))
				return FileType.Directory;

			if (PathUtils.IsSymlink (path))
				return FileType.Symlink;

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
