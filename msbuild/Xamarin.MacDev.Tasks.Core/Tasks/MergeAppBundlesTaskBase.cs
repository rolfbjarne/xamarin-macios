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
		// This is a list of files (filename only, no path, will match any file with the given name in the app bundle)
		// that can be put in a RID-specific subdirectory.
		public ITaskItem[] ArchitectureSpecificFiles { get; set; }

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
			ArchitectureSpecific,
			Directory,
			Symlink,
			Other,
		}

		class Entries : List<Entry> {
			public string BundlePath;
			public string SpecificSubdirectory;
		}

		class Entry {
			public MergeAppBundlesTaskBase Task;
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
						Task.Log.LogMessage (MessageImportance.Low, $"Added dependent file {dependentFile.RelativePath} to {RelativePath}");
					}
				}
			}

			public void FindDependentFiles ()
			{
				Task.Log.LogMessage (MessageImportance.Low, $"Finding dependencies for {RelativePath}");
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
						Task.Log.LogMessage (MessageImportance.Low, $"Not the right satellite assembly name: {v.RelativePath} Name: {Path.GetFileName (v.RelativePath)} satelliteName: {satelliteName}");
						return false;
					}

					// if it's not in an immediate subdirectory, it's not a dependent assembly of ours
					if (!string.Equals (Path.GetDirectoryName (Path.GetDirectoryName (v.RelativePath)), Path.GetDirectoryName (RelativePath), StringComparison.OrdinalIgnoreCase)) {
						Task.Log.LogMessage (MessageImportance.Low, $"Not immediate subdir: {v.RelativePath}");
						return false;
					}

					// if the name of the immediate subdirectory isn't a valid culture, then it's not a dependent assembly of ours
					var immediateSubDir = Path.GetFileName (Path.GetDirectoryName (v.RelativePath));
					var cultureInfo = CultureInfo.GetCultureInfo (immediateSubDir);
					if (cultureInfo == null) {
						Task.Log.LogMessage (MessageImportance.Low, $"Not a culture: {v.RelativePath}");
						return false;
					}


					Task.Log.LogMessage (MessageImportance.Low, $"Found: {v.RelativePath}");

					return true;
				});

				// also add the directories where the satellite assemblies are
				if (DependentFiles?.Any () == true) {
					Task.Log.LogMessage (MessageImportance.Low, $"Check for subdirs for dependent files for: {RelativePath}");
					FindDependentFiles (v => {
						if (v.Type != FileType.Directory && v.Type != FileType.Symlink)
							return false;

						Task.Log.LogMessage (MessageImportance.Low, $"    Testing: {v.RelativePath}");

						return DependentFiles.Any (df => {
							if (df.Type != FileType.PEAssembly) {
								Task.Log.LogMessage (MessageImportance.Low, $"    {df.RelativePath} is of the wrong type.");
								return false;
							}
							if (Path.GetDirectoryName (df.RelativePath) != v.RelativePath) {
								Task.Log.LogMessage (MessageImportance.Low, $"    {Path.GetDirectoryName (df.RelativePath)} and {v.RelativePath} don't match.");
								return false;
							}
							Task.Log.LogMessage (MessageImportance.Low, $"    {df.RelativePath} is of the CORRECT type.");
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

			public void CopyTo (string outputDirectory, string subDirectory = null)
			{
				string outputFile;

				if (subDirectory == null) {
					outputFile = Path.Combine (outputDirectory, RelativePath);
				} else {
					var relativeAppDir = Path.GetDirectoryName (RelativePath);
					if (string.IsNullOrEmpty (relativeAppDir)) {
						outputFile = Path.Combine (outputDirectory, subDirectory, RelativePath);
					} else {
						outputFile = Path.Combine (outputDirectory, relativeAppDir, subDirectory, Path.GetFileName (RelativePath));
					}
				}

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
						file.CopyTo (outputDirectory, subDirectory);
				}
			}
		}

		public override bool Execute ()
		{

			Log.LogMessage (MessageImportance.Low, $"Got has {InputAppBundles.Length} inputs:");
			foreach (var input in InputAppBundles)
				Log.LogMessage (MessageImportance.Low, input.ItemSpec);

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
						Task = this,
						RelativePath = relativePath,
						AppBundle = entries,
						Type = GetFileType (file),
					};
					entries.Add (entry);
					Log.LogMessage (MessageImportance.Low, $"File: {file} RelativePath: {relativePath} Type: {entry.Type}");
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
				Log.LogMessage (MessageImportance.Low, $"Input files found in {list.BundlePath}:");
				foreach (var file in list) {
					Log.LogMessage (MessageImportance.Low, $"    {file.RelativePath} Type: {file.Type} Dependent files: {file.DependentFiles?.Count.ToString () ?? "0"}");
					if (file.DependentFiles?.Any () == true) {
						foreach (var df in file.DependentFiles) {
							Log.LogMessage (MessageImportance.Low, $"        {df.RelativePath} Type: {df.Type}");
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

			Log.LogMessage (MessageImportance.Low, $"Map has {map.Count} entries");

			// Merge stuff
			Directory.CreateDirectory (OutputAppBundle);
			foreach (var kvp in map) {
				var relativePath = kvp.Key;
				var entries = kvp.Value;
				var outputFile = Path.Combine (OutputAppBundle, relativePath);

				// FIXME: only if newer/modified

				if (entries.Count == 1) {
					// just copy the file(s) if there's only one
					Log.LogMessage (MessageImportance.Low, $"The file '{entries [0].RelativePath}' only exists in '{entries [0].AppBundle.BundlePath}' and will be copied to the merged app bundle.");
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
					Log.LogMessage (MessageImportance.Low, $"All the files for '{entries [0].RelativePath}' are identical between all the input app bundles, and will be copied to the merged app bundle.");
					entries [0].CopyTo (OutputAppBundle); // TODO: only if changed
					continue;
				}

				// Custom merging is needed, depending on the type
				switch (entries [0].Type) {
				case FileType.MachO:
					MergeMachOFiles (outputFile, entries);
					break;
				case FileType.PEAssembly:
				case FileType.ArchitectureSpecific:
					MergeArchitectureSpecific (entries);
					break;
				case FileType.Symlink:
					Log.LogError ($"Can't merge symlinks with different targets."); // FIXME: better error
					break;
				default:
					Log.LogError ($"Unknown merge file type: {entries [0].Type} for '{entries [0].FullPath}"); // FIXME: show error
					break;
				}
			}

			return !Log.HasLoggedErrors;
		}

		void MergeArchitectureSpecific (IList<Entry> inputs)
		{
			foreach (var input in inputs) {
				Log.LogMessage (MessageImportance.Low, $"Copying '{input.RelativePath}' to the specific subdirectory {input.AppBundle.SpecificSubdirectory} for the merged app bundle.");
				input.CopyTo (OutputAppBundle, input.AppBundle.SpecificSubdirectory);
			}
		}

		void MergeMachOFiles (string output, IList<Entry> input)
		{
			if (input.Any (v => v.DependentFiles?.Any () == true)) {
				Log.LogError ($"// TODO: Should not have dependent files");
				return;
			}

			Log.LogMessage (MessageImportance.Low, $"Lipoing '{input [0].RelativePath}' for the merged app bundle from the following sources:\n\t{string.Join ("\n\t", input.Select (v => v.FullPath))}");

			// TODO: only if changed
			var arguments = new List<string> ();
			arguments.Add ("-create");
			arguments.Add ("-output");
			arguments.Add (output);
			arguments.AddRange (input.Select (v => v.FullPath));
			ExecuteAsync ("lipo", arguments, sdkDevPath: SdkDevPath).Wait ();
		}

		FileType GetFileType (string path)
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

			if (ArchitectureSpecificFiles != null) {
				var filename = Path.GetFileName (path);
				if (ArchitectureSpecificFiles.Any (v => v.ItemSpec == filename))
					return FileType.ArchitectureSpecific;
			}

			return FileType.Other;
		}
	}
}
