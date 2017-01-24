// Copyright 2013 Xamarin Inc. All rights reserved.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;

using Mono.Cecil;

using Xamarin.Utils;

namespace Xamarin.Bundler {
	public enum AssemblyBuildTarget
	{
		StaticObject,
		DynamicLibrary,
		Framework,
	}

	public class AotInfo
	{
		public AOTTask Task;
		public LinkTask LinkTask;
		public List<string> BitcodeFiles = new List<string> (); // .bc files produced by the AOT compiler
		public List<string> AsmFiles = new List<string> (); // .s files produced by the AOT compiler.
		public List<string> AotDataFiles = new List<string> (); // .aotdata files produced by the AOT compiler
		public List<string> ObjectFiles = new List<string> (); // .o files produced by the AOT compiler
	}

	public partial class Assembly
	{
		public AssemblyBuildTarget BuildTarget;
		public string BuildTargetName;
		public bool IsCodeShared;

		public List<string> Satellites;

		public Dictionary<Abi, AotInfo> AotInfos = new Dictionary<Abi, AotInfo> ();

		HashSet<string> dependency_map;
		bool has_dependency_map;

		public bool HasDependencyMap {
			get {
				return has_dependency_map;
			}
		}

		public HashSet<string> DependencyMap {
			get {
				return dependency_map;
			}
		}

		// Recursively list all the assemblies the specified assembly depends on.
		HashSet<string> ComputeDependencies (List<Exception> warnings)
		{
			if (dependency_map != null)
				return dependency_map;

			dependency_map = new HashSet<string> ();
			has_dependency_map = true;

			foreach (var ar in AssemblyDefinition.MainModule.AssemblyReferences) {
				var found = false;

				if (ar.FullName == AssemblyDefinition.FullName)
					continue;

				// find the dependent assembly
				foreach (var a in Target.Assemblies) {
					if (a == this)
						continue;

					if (a.AssemblyDefinition.Name.Name == ar.Name) {
						// gotcha
						if (!dependency_map.Contains (a.FullPath)) {
							dependency_map.Add (a.FullPath);
							dependency_map.UnionWith (a.ComputeDependencies (warnings));
						}
						found = true;
						break;
					}
				}

				if (!found) {
					warnings.Add (new MonoTouchException (3005, false, "The dependency '{0}' of the assembly '{1}' was not found. Please review the project's references.",
														  ar.FullName, AssemblyDefinition.FullName));
					has_dependency_map = true;
				}
			}

			return dependency_map;
		}

		public void ComputeDependencyMap (List<Exception> exceptions)
		{
			ComputeDependencies (exceptions);
		}

		// returns false if the assembly was not copied (because it was already up-to-date).
		public bool CopyAssembly (string source, string target, bool copy_mdb = true, bool strip = false)
		{
			var copied = false;

			try {
				if (!Application.IsUptodate (source, target) && (strip || !Cache.CompareAssemblies (source, target))) {
					copied = true;
					if (strip) {
						Driver.FileDelete (target);
						Directory.CreateDirectory (Path.GetDirectoryName (target));
						MonoTouch.Tuner.Stripper.Process (source, target);
					} else {
						Application.CopyFile (source, target);
					}
				} else {
					Driver.Log (3, "Target '{0}' is up-to-date.", target);
				}

				// Update the mdb even if the assembly didn't change.
				if (copy_mdb && File.Exists (source + ".mdb"))
					Application.UpdateFile (source + ".mdb", target + ".mdb", true);

				CopyConfigToDirectory (Path.GetDirectoryName (target));
			} catch (Exception e) {
				throw new MonoTouchException (1009, true, e, "Could not copy the assembly '{0}' to '{1}': {2}", source, target, e.Message);
			}

			return copied;
		}

		public void CopyMdbToDirectory (string directory)
		{
			string mdb_src = FullPath + ".mdb";
			if (File.Exists (mdb_src)) {
				string mdb_target = Path.Combine (directory, FileName + ".mdb");
				Application.UpdateFile (mdb_src, mdb_target);
			}
		}
		
		public void CopyMSymToDirectory (string directory)
		{
			string msym_src = FullPath + ".aotid.msym";
			var dirInfo = new DirectoryInfo (msym_src);
			if (!dirInfo.Exists) // got no aot data
				return;
			var subdirs = dirInfo.GetDirectories();
			foreach (var subdir in subdirs) {
				var destPath = Path.Combine (directory, subdir.Name.ToUpperInvariant ());
				var destInfo = new DirectoryInfo (destPath);
				if (!destInfo.Exists)
					Directory.CreateDirectory (destPath);
				var files = subdir.GetFiles ();
				foreach (FileInfo file in files) {
					string temppath = Path.Combine (destPath, file.Name);
					file.CopyTo(temppath, true);
				}
			}
		}

		public void CopyConfigToDirectory (string directory)
		{
			string config_src = FullPath + ".config";
			if (File.Exists (config_src)) {
				string config_target = Path.Combine (directory, FileName + ".config");
				Application.UpdateFile (config_src, config_target);
			}
		}

		public void CopySatellitesToDirectory (string directory)
		{
			if (Satellites == null)
				return;

			foreach (var a in Satellites) {
				string target_dir = Path.Combine (directory, Path.GetFileName (Path.GetDirectoryName (a)));
				string target_s = Path.Combine (target_dir, Path.GetFileName (a));

				if (!Directory.Exists (target_dir))
					Directory.CreateDirectory (target_dir);

				CopyAssembly (a, target_s);
			}
		}

		// this will copy (and optionally strip) the assembly and all the related files:
		// * debug file (.mdb)
		// * config file (.config)
		// * satellite assemblies (<language id>/.dll)
		// * aot data
		public void CopyToDirectory (string directory, bool reload = true, bool check_case = false, bool only_copy = false, bool copy_mdb = true, bool strip = false)
		{
			var target = Path.Combine (directory, FileName);

			var fileNameNoExtension = Path.GetFileNameWithoutExtension (FileName);
			var assemblyName = AssemblyDefinition.Name.Name;
			if (check_case && fileNameNoExtension != assemblyName && string.Equals (fileNameNoExtension, assemblyName, StringComparison.OrdinalIgnoreCase)) {
				// Fix up the name of the target file to match the assembly name.
				target = Path.Combine (directory, assemblyName + Path.GetExtension (FileName));
			}

			// our Copy code deletes the target (so copy'ing over itself is a bad idea)
			if (directory != Path.GetDirectoryName (FullPath))
				CopyAssembly (FullPath, target, copy_mdb: copy_mdb, strip: strip);

			CopySatellitesToDirectory (directory);

			if (!only_copy) {
				if (reload) {
					LoadAssembly (target);
				} else {
					FullPath = target;
				}
			}

			foreach (var aotdata in AotInfos.Values.SelectMany ((info) => info.AotDataFiles))
				Application.UpdateFile (aotdata, Path.Combine (directory, Path.GetFileName (aotdata)));
		}

		/*
		 * Runs the AOT compiler, creating one of the following:
		 *     [not llvm]     => .s           + .aotdata
		 *     [is llvm-only] => .bc          + .aotdata
		 *     [is llvm]      => 
		 *          [is llvm creating assembly code] => .s + -llvm.s + .aotdata
		 *          [is llvm creating object code]   => .s + -llvm.o + .aotdata
		 */
		public void CreateAOTTask (Abi abi)
		{
			if (AotInfos.ContainsKey (abi))
				return;

			var build_dir = Target.BuildDirectory;
			var assembly_path = Path.Combine (build_dir, FileName); // FullPath?
			var arch = abi.AsArchString ();
			var output_dir = Path.Combine (App.Cache.Location, arch);
			var asm = Path.Combine (output_dir, Path.GetFileName (assembly_path)) + ".s";
			var aot_data = Path.Combine (output_dir, Path.GetFileNameWithoutExtension (assembly_path)) + ".aotdata." + arch;
			var llvm_aot_ofile = "";
			var asm_output = "";
			var is_llvm = (abi & Abi.LLVM) == Abi.LLVM;

			Directory.CreateDirectory (output_dir);

			if (!File.Exists (assembly_path))
				throw new MonoTouchException (3004, true, "Could not AOT the assembly '{0}' because it doesn't exist.", assembly_path);

			var aotInfo = new AotInfo ();
			AotInfos.Add (abi, aotInfo);

			if (App.EnableLLVMOnlyBitCode) {
				// In llvm-only mode, the AOT compiler emits a .bc file and no .s file for JITted code
				llvm_aot_ofile = Path.Combine (output_dir, Path.GetFileName (assembly_path)) + ".bc";
				aotInfo.BitcodeFiles.Add (llvm_aot_ofile);
			} else if (is_llvm) {
				if (Driver.GetLLVMAsmWriter (App)) {
					llvm_aot_ofile = Path.Combine (output_dir, Path.GetFileName (assembly_path)) + "-llvm.s";
					aotInfo.AsmFiles.Add (llvm_aot_ofile);
				} else {
					llvm_aot_ofile = Path.Combine (output_dir, Path.GetFileName (assembly_path)) + "-llvm.o";
					aotInfo.ObjectFiles.Add (llvm_aot_ofile);
				}
				asm_output = asm;
			} else {
				asm_output = asm;
			}

			if (!string.IsNullOrEmpty (asm_output))
				aotInfo.AsmFiles.Add (asm_output);
			aotInfo.AotDataFiles.Add (aot_data);

			var aotCompiler = Driver.GetAotCompiler (App, Target.Is64Build);
			var aotArgs = Driver.GetAotArguments (App, assembly_path, abi, build_dir, asm_output, llvm_aot_ofile, aot_data);
			var task = new AOTTask
			{
				Assembly = this,
				AssemblyName = assembly_path,
				AddBitcodeMarkerSection = App.FastDev && App.EnableMarkerOnlyBitCode,
				AssemblyPath = asm,
				ProcessStartInfo = Driver.CreateStartInfo (App, aotCompiler, aotArgs, Path.GetDirectoryName (assembly_path)),
				AotInfo = aotInfo,
			};

			aotInfo.Task = task;
		}

		public bool CanSymLinkForApplication ()
		{
			if (EnableCxx || NeedsGccExceptionHandling || ForceLoad)
				return false;

			if (LinkerFlags != null && LinkerFlags.Count > 0)
				return false;

			if (LinkWith != null && LinkWith.Count > 0)
				return false;

			return true;
		}

		public bool Symlink ()
		{
			bool symlink_failed = false;

			string target = Path.Combine (Target.TargetDirectory, Path.GetFileName (FullPath));
			string source = FullPath;

			if (!Driver.SymlinkAssembly (App, source, target, Path.GetDirectoryName (target))) {
				symlink_failed = true;
				CopyAssembly (source, target);
			}

			if (Satellites != null) {
				foreach (var a in Satellites) {
					string s_target_dir = Path.Combine (Target.TargetDirectory, Path.GetFileName (Path.GetDirectoryName (a)));
					string s_target = Path.Combine (s_target_dir, Path.GetFileName (a));

					if (!Driver.SymlinkAssembly (App, a, s_target, s_target_dir)) {
						CopyAssembly (a, s_target);
					}
				}
			}

			return symlink_failed;
		}

		public void LoadAssembly (string filename)
		{
			try {
				AssemblyDefinition = Target.Resolver.Load (filename);
				FullPath = AssemblyDefinition.MainModule.FileName;
				if (symbols_loaded.HasValue && symbols_loaded.Value) {
					symbols_loaded = null;
					LoadSymbols ();
				}
				Driver.Log (3, "Loaded '{0}'", FullPath);
			} catch (Exception e) {
				// cecil might not be able to load the assembly, e.g. bug #758
				throw new MonoTouchException (1010, true, e, "Could not load the assembly '{0}': {1}", FullPath, e.Message);
			}
		}

		public void ComputeSatellites ()
		{
			var path = Path.GetDirectoryName (FullPath);
			var satellite_name = Path.GetFileNameWithoutExtension (FullPath) + ".resources.dll";

			foreach (var subdir in Directory.GetDirectories (path)) {
				var culture_name = Path.GetFileName (subdir);
				CultureInfo ci;

				if (culture_name.IndexOf ('.') >= 0)
					continue; // cultures can't have dots. This way we don't check every *.app directory

				try {
					ci = CultureInfo.GetCultureInfo (culture_name);
				} catch {
					// nope, not a resource language
					continue;
				}

				if (ci == null)
					continue;

				var satellite = Path.Combine (subdir, satellite_name);
				if (File.Exists (satellite)) {
					if (Satellites == null)
						Satellites = new List<string> ();
					Satellites.Add (satellite);
				}
			}
		}
	}
}
