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

	class AssemblyDynamicLibraryTarget
	{
		public string Name;
		public Target Target { get { return Assemblies [0].Target; } }
		public List<Assembly> Assemblies = new List<Assembly> ();
		public string OutputPath;
		public bool IsFramework;

		public string ComputedBaseName {
			get {
				switch (Name) {
				case "@all":
				case "@rest":
					return Path.GetFileNameWithoutExtension (Target.App.AssemblyName) + "X";
				case null:
				case "":
					if (Assemblies.Count != 1)
						throw new Exception ();
					return Path.GetFileNameWithoutExtension (Assemblies [0].FileName);
				default:
					return Name;
				}
			}
		}

		public void CreateTasks (List<BuildTask> tasks, Abi abi)
		{
			var arch = abi.AsArchString ();
			var linker_inputs = new List<string> ();
			foreach (var a in Assemblies) {
				linker_inputs.AddRange (a.AotInfos [abi].AsmFiles);
				linker_inputs.AddRange (a.AotInfos [abi].ObjectFiles);
				linker_inputs.AddRange (a.AotInfos [abi].BitcodeFiles);
			}
			var computedName = ComputedBaseName;
			var install_name = IsFramework ? $"@rpath/{computedName}.framework/{computedName}" : $"@executable_path/lib{computedName}.dylib";
			var linker_output = Path.Combine (Cache.Location, arch, $"lib{computedName}.dylib");

			var compiler_flags = new CompilerFlags () {
				Target = Target,
				Inputs = new List<string> (linker_inputs),
			};
			foreach (var a in Assemblies) {
				compiler_flags.AddFrameworks (a.Frameworks, a.WeakFrameworks);
				compiler_flags.AddLinkWith (a.LinkWith, a.ForceLoad);
				compiler_flags.AddOtherFlags (a.LinkerFlags);
			}
			compiler_flags.LinkWithMono ();
			compiler_flags.LinkWithXamarin ();
			if (Target.GetEntryPoints ().ContainsKey ("UIApplicationMain"))
				compiler_flags.AddFramework ("UIKit");
			compiler_flags.LinkWithPInvokes (abi);

			OutputPath = linker_output;

			// Check if we really need to 
			var outputs = new string [] { linker_output };
			compiler_flags.PopulateInputs ();
			if (Application.IsUptodate (compiler_flags.Inputs, outputs))
				return;
			Application.TryDelete (outputs);

			tasks.Add (new LinkTask ()
			{
				Target = Target,
				AssemblyName = computedName,
				Abi = abi,
				InputFiles = linker_inputs,
				OutputFile = linker_output,
				InstallName = install_name,
				CompilerFlags = compiler_flags,
				SharedLibrary = true,
			});
		}
	}

	public class AotInfo
	{
		public List<string> BitcodeFiles = new List<string> (); // .bc files produced by the AOT compiler
		public List<string> AsmFiles = new List<string> (); // .s files produced by the AOT compiler.
		public List<string> AotDataFiles = new List<string> (); // .aotdata files produced by the AOT compiler
		public List<string> ObjectFiles = new List<string> (); // .o files produced by the AOT compiler
	}

	public partial class Assembly
	{
		public AssemblyBuildTarget BuildTarget;
		public string BuildTargetName;

		public List<string> Satellites;

		public Dictionary<Abi, AotInfo> AotInfos = new Dictionary<Abi, AotInfo> ();

		HashSet<string> dependency_map;
		bool has_dependency_map;

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
		public bool CopyAssembly (string source, string target, bool copy_mdb = true)
		{
			var copied = false;

			try {
				if (!Application.IsUptodate (source, target) && !Cache.CompareAssemblies (source, target)) {
					copied = true;
					Application.CopyFile (source, target);
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

		// returns false if the assembly was not copied (because it was already up-to-date).
		public bool CopyToDirectory (string directory, bool reload = true, bool check_case = false, bool only_copy = false, bool copy_mdb = true)
		{
			var target = Path.Combine (directory, FileName);

			var fileNameNoExtension = Path.GetFileNameWithoutExtension (FileName);
			var assemblyName = AssemblyDefinition.Name.Name;
			if (check_case && fileNameNoExtension != assemblyName && string.Equals (fileNameNoExtension, assemblyName, StringComparison.OrdinalIgnoreCase)) {
				// Fix up the name of the target file to match the assembly name.
				target = Path.Combine (directory, assemblyName + Path.GetExtension (FileName));
			}

			var copied = false;

			// our Copy code deletes the target (so copy'ing over itself is a bad idea)
			if (directory != Path.GetDirectoryName (FullPath))
				copied = CopyAssembly (FullPath, target, copy_mdb: copy_mdb);

			CopySatellitesToDirectory (directory);

			if (!only_copy) {
				if (reload) {
					LoadAssembly (target);
				} else {
					FullPath = target;
				}
			}

			return copied;
		}

		//IEnumerable<BuildTask> CreateLinkTasks (string s, string asm_infile, string llvm_infile, Abi abi)
		//{
		//	var compile_tasks = new BuildTasks ();
		//	if (asm_infile != null) {
		//		var task = CreateLinkTask (s, asm_infile, abi);
		//		if (task != null)
		//			compile_tasks.Add (task);
		//	}

		//	if (llvm_infile != null) {
		//		var taskllvm = CreateLinkTask (s, llvm_infile, abi);
		//		if (taskllvm != null)
		//			compile_tasks.Add (taskllvm);
		//	}
		//	return compile_tasks.Count > 0 ? compile_tasks : null;
		//}

		/*
		 * Runs the AOT compiler, creating one of the following:
		 *     [not llvm]     => .s           + .aotdata
		 *     [is llvm-only] => .bc          + .aotdata
		 *     [is llvm]      => 
		 *          [is llvm creating assembly code] => .s + -llvm.s + .aotdata
		 *          [is llvm creating object code]   => .s + -llvm.o + .aotdata
		 */
		public void CreateAOTTask (List<BuildTask> tasks, Abi abi)
		{
			var build_dir = Target.BuildDirectory;
			var assembly_path = Path.Combine (build_dir, FileName); // FullPath?
			var arch = abi.AsArchString ();
			var output_dir = Path.Combine (Cache.Location, arch);
			var asm = Path.Combine (output_dir, Path.GetFileName (assembly_path)) + ".s";
			var aot_data = Path.Combine (output_dir, Path.GetFileNameWithoutExtension (assembly_path)) + "." + arch + ".aotdata";
			var llvm_aot_ofile = "";
			var asm_output = "";
			var is_llvm = (abi & Abi.LLVM) == Abi.LLVM;

			Directory.CreateDirectory (output_dir);

			if (!File.Exists (assembly_path))
				throw new MonoTouchException (3004, true, "Could not AOT the assembly '{0}' because it doesn't exist.", assembly_path);

			List<string> dependencies = new List<string> ();
			List<string> outputs = new List<string> ();

			var aotInfo = new AotInfo ();
			AotInfos.Add (abi, aotInfo);

			if (App.EnableLLVMOnlyBitCode) {
				// In llvm-only mode, the AOT compiler emits a .bc file and no .s file for JITted code
				llvm_aot_ofile = Path.Combine (output_dir, Path.GetFileName (assembly_path)) + ".bc";
				aotInfo.BitcodeFiles.Add (llvm_aot_ofile);
			} else if (is_llvm) {
				if (Driver.LLVMAsmWriter) {
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

			outputs.AddRange (aotInfo.AotDataFiles);
			outputs.AddRange (aotInfo.AsmFiles);
			outputs.AddRange (aotInfo.BitcodeFiles);
			outputs.AddRange (aotInfo.ObjectFiles);

			// Check if the output is up-to-date
			if (has_dependency_map) { // We can only check dependencies if we know the assemblies this assembly depend on (otherwise always rebuild).
				dependencies.AddRange (dependency_map);
				dependencies.Add (assembly_path);
				dependencies.Add (Driver.GetAotCompiler (Target.Is64Build));
				if (Application.IsUptodate (dependencies, outputs)) {
					Driver.Log (3, "Target(s) {0} up-to-date.", string.Join (", ", outputs.ToArray ()));
					return;
				}
			}

			Application.TryDelete (outputs); // otherwise the next task might not detect that it has to rebuild.
			Driver.Log (3, "Target(s) {0} must be rebuilt.", string.Join (", ", outputs.ToArray ()));
		
			// Output is not up-to-date, so we must run the AOT compiler.
			var aotCompiler = Driver.GetAotCompiler (Target.Is64Build);
			var aotArgs = Driver.GetAotArguments (assembly_path, abi, build_dir, asm_output, llvm_aot_ofile, aot_data);
			tasks.Add (new AOTTask ()
			{
				AssemblyName = assembly_path,
				ProcessStartInfo = Driver.CreateStartInfo (aotCompiler, aotArgs, Path.GetDirectoryName (assembly_path)),
			});
		}

		public void ConvertToBitcodeTask (List<BuildTask> tasks, Abi abi)
		{
			// Converts .s into bitcode (.ll).

			if (!App.EnableAsmOnlyBitCode)
				return;

			var info = AotInfos [abi];
			foreach (var asm in info.AsmFiles) {
				var input = asm;
				var output = asm + ".ll";

				info.BitcodeFiles.Add (output);

				if (Application.IsUptodate (input, output))
					continue;

				Application.TryDelete (output);
				tasks.Add (new BitCodeify ()
				{
					Input = input,
					OutputFile = output,
					Platform = App.Platform,
					Abi = abi,
					DeploymentTarget = App.DeploymentTarget,
				});
			}
		}

		//IEnumerable<BuildTask> CreateManagedToAssemblyTasks (string assembly_path, Abi abi, string build_dir)
		//{
		//	var arch = abi.AsArchString ();
		//	var cache_dir = Cache.Location;
		//	var asm = Path.Combine (cache_dir, Path.GetFileName (assembly_path)) + "." + arch + ".s";
		//	var llvm_asm = Path.Combine (cache_dir, Path.GetFileName (assembly_path)) + "." + arch + "-llvm.s";
		//	var aot_data = Path.Combine (cache_dir, Path.GetFileNameWithoutExtension (assembly_path)) + "." + arch + ".aotdata";
		//	string llvm_ofile, llvm_aot_ofile = "";
		//	var is_llvm = (abi & Abi.LLVM) == Abi.LLVM;
		//	bool assemble_llvm = is_llvm && Driver.LLVMAsmWriter;

		//	if (!File.Exists (assembly_path))
		//		throw new MonoTouchException (3004, true, "Could not AOT the assembly '{0}' because it doesn't exist.", assembly_path);

		//	HashSet<string> dependencies = null;
		//	List<string> deps = null;
		//	List<string> outputs = new List<string> ();
		//	var warnings = new List<Exception> ();

		//	dependencies = ComputeDependencies (warnings);

		//	if (warnings.Count > 0) {
		//		ErrorHelper.Show (warnings);
		//		ErrorHelper.Warning (3006, "Could not compute a complete dependency map for the project. This will result in slower build times because Xamarin.iOS can't properly detect what needs to be rebuilt (and what does not need to be rebuilt). Please review previous warnings for more details.");
		//	} else {
		//		deps = new List<string> (dependencies.ToArray ());
		//		deps.Add (assembly_path);
		//		deps.Add (Driver.GetAotCompiler (Target.Is64Build));
		//	}

		//	if (App.EnableLLVMOnlyBitCode) {
		//		//
		//		// In llvm-only mode, the AOT compiler emits a .bc file and no .s file for JITted code
		//		//
		//		llvm_ofile = Path.Combine (cache_dir, Path.GetFileName (assembly_path)) + "." + arch + ".bc";
		//		outputs.Add (llvm_ofile);
		//		llvm_aot_ofile = llvm_ofile;
		//	} else {
		//		llvm_ofile = Path.Combine (cache_dir, Path.GetFileName (assembly_path)) + "." + arch + "-llvm.o";
		//		outputs.Add (asm);

		//		if (is_llvm) {
		//			if (assemble_llvm) {
		//				llvm_aot_ofile = llvm_asm;
		//			} else {
		//				llvm_aot_ofile = llvm_ofile;
		//				Target.LinkWith (llvm_ofile);
		//			}
		//			outputs.Add (llvm_aot_ofile);
		//		}
		//	}

		//	if (deps != null && Application.IsUptodate (deps, outputs)) {
		//		Driver.Log (3, "Target(s) {0} is up-to-date.", string.Join (", ", outputs.ToArray ()));
		//		if (App.EnableLLVMOnlyBitCode)
		//			return CreateLinkTasks (assembly_path, null, llvm_ofile, abi);
		//		else
		//			return CreateLinkTasks (assembly_path, asm, assemble_llvm ? llvm_asm : null, abi);
		//	} else {
		//		Application.TryDelete (outputs); // otherwise the next task might not detect that it will have to rebuild.
		//		Driver.Log (3, "Target(s) {0} needs to be rebuilt.", string.Join (", ", outputs.ToArray ()));
		//	}

		//	var aotCompiler = Driver.GetAotCompiler (Target.Is64Build);
		//	var aotArgs = Driver.GetAotArguments (assembly_path, abi, build_dir, asm, llvm_aot_ofile, aot_data);
		//	Driver.Log (3, "Aot compiler: {0} {1}", aotCompiler, aotArgs);

		//	AotDataFiles.Add (aot_data);

		//	IEnumerable<BuildTask> nextTasks;
		//	if (App.EnableLLVMOnlyBitCode)
		//		nextTasks = CreateLinkTasks (assembly_path, null, llvm_ofile, abi);
		//	else
		//		nextTasks = CreateLinkTasks (assembly_path, asm, assemble_llvm ? llvm_asm : null, abi);

		//	return new BuildTask [] { new AOTTask ()
		//		{
		//			AssemblyName = assembly_path,
		//			ProcessStartInfo = Driver.CreateStartInfo (aotCompiler, aotArgs, Path.GetDirectoryName (assembly_path)),
		//			NextTasks = nextTasks
		//		}
		//	};
		//}

		//// The input file is either a .s or a .bc file
		//// The output is an object file (.dylib or .o file).
		//BuildTask CreateLinkTask (string assembly_name, string infile_path, Abi abi)
		//{
		//	var ext = BuildTarget == AssemblyBuildTarget.DynamicLibrary ? "dylib" : "o";
		//	var ofile = Path.ChangeExtension (infile_path, ext);
		//	var install_name = string.Empty;

		//	object_files.Add (ofile);

		//	if (BuildTarget == AssemblyBuildTarget.DynamicLibrary)
		//		install_name = "lib" + Path.GetFileName (assembly_name) + ".dylib";

		//	if (Application.IsUptodate (new string [] { infile_path, Driver.CompilerPath }, new string [] { ofile })) {
		//		Driver.Log (3, "Target {0} is up-to-date.", ofile);
		//		return null;
		//	} else {
		//		Application.TryDelete (ofile); // otherwise the next task might not detect that it will have to rebuild.
		//		Driver.Log (3, "Target {0} needs to be rebuilt.", ofile);
		//	}

		//	var compiler_flags = new CompilerFlags () { Target = Target };

		//	BuildTask bitcode_task = null;
		//	BuildTask link_task = null;
		//	string link_task_input, link_language = "";

		//	if (App.EnableAsmOnlyBitCode) {
		//		link_task_input = infile_path + ".ll";
		//		link_language = "";
		//		// linker_flags.Add (" -fembed-bitcode");

		//		bitcode_task = new BitCodeify () {
		//			Input = infile_path,
		//			OutputFile = link_task_input,
		//			Platform = App.Platform,
		//			Abi = abi,
		//			DeploymentTarget = App.DeploymentTarget,
		//		};
		//	} else {
		//		link_task_input = infile_path;
		//		if (infile_path.EndsWith (".s", StringComparison.Ordinal))
		//			link_language = "assembler";
		//	}

		//	if (BuildTarget == AssemblyBuildTarget.DynamicLibrary) {
		//		compiler_flags.AddFrameworks (Frameworks, WeakFrameworks);
		//		compiler_flags.AddLinkWith (LinkWith, ForceLoad);
		//		compiler_flags.LinkWithMono ();
		//		compiler_flags.LinkWithXamarin ();
		//		compiler_flags.AddOtherFlags (LinkerFlags);
		//		if (Target.GetEntryPoints ().ContainsKey ("UIApplicationMain"))
		//			compiler_flags.AddFramework ("UIKit");
		//		compiler_flags.LinkWithPInvokes (abi);
		//	}

		//	link_task = new LinkTask ()
		//	{
		//		Target = Target,
		//		AssemblyName = assembly_name,
		//		Abi = abi,
		//		InputFile = link_task_input,
		//		OutputFile = ofile,
		//		InstallName = install_name,
		//		CompilerFlags = compiler_flags,
		//		SharedLibrary = App.FastDev,
		//		Language = link_language,
		//	};

		//	if (bitcode_task != null) {
		//		bitcode_task.NextTasks = new BuildTask[] { link_task };
		//		return bitcode_task;
		//	}
		//	return link_task;
		//}

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

			if (!Driver.SymlinkAssembly (source, target, Path.GetDirectoryName (target))) {
				symlink_failed = true;
				CopyAssembly (source, target);
			}

			if (Satellites != null) {
				foreach (var a in Satellites) {
					string s_target_dir = Path.Combine (Target.TargetDirectory, Path.GetFileName (Path.GetDirectoryName (a)));
					string s_target = Path.Combine (s_target_dir, Path.GetFileName (a));

					if (!Driver.SymlinkAssembly (a, s_target, s_target_dir)) {
						CopyAssembly (a, s_target);
					}
				}
			}

			return symlink_failed;
		}

		//public void CreateCompilationTasks (BuildTasks tasks, string build_dir, IEnumerable<Abi> abis)
		//{
		//	var assembly = Path.Combine (build_dir, FileName);

		//	//if (BuildTarget == AssemblyBuildTarget.DynamicLibrary)
		//	//	ObjectFile = Path.Combine (App.AppDirectory, Driver.Quote ("lib" + Path.GetFileName (FullPath) + ".dylib"));
		//	//else if (BuildTarget == AssemblyBuildTarget.Framework)
		//	//	ObjectFile = Path.Combine (App.AppDirectory, Driver.Quote ("lib" + Path.GetFileName (FullPath) + ".o"));

		//	foreach (var abi in abis) {
		//		var task = CreateManagedToAssemblyTasks (assembly, abi, build_dir);
		//		if (task != null)
		//			tasks.AddRange (task);
		//	}
		//}

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
