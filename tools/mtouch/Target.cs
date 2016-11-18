// Copyright 2013--2014 Xamarin Inc. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using MonoTouch.Tuner;

using Mono.Cecil;
using Mono.Tuner;
using Mono.Linker;
using Xamarin.Linker;

using Xamarin.Utils;

using XamCore.Registrar;

namespace Xamarin.Bundler
{
	public partial class Target {
		public string TargetDirectory;
		public string AppTargetDirectory;

		public MonoTouchManifestResolver ManifestResolver = new MonoTouchManifestResolver ();
		public AssemblyDefinition ProductAssembly;

		// directories used during the build process
		public string ArchDirectory;
		public string PreBuildDirectory;
		public string BuildDirectory;
		public string LinkDirectory;

		// Note that each 'Target' can have multiple abis: armv7+armv7s for instance.
		public List<Abi> Abis;

		public Dictionary<string, List<string>> BundleFiles = new Dictionary<string, List<string>> ();

		CompilerFlags linker_flags;

		// If we didn't link because the existing (cached) assemblyes are up-to-date.
		bool cached_link;

		// If any assemblies were updated (only set to false if the linker is disabled and no assemblies were modified).
		bool any_assembly_updated = true;

		BuildTasks compile_tasks = new BuildTasks ();

		// If we didn't link the final executable because the existing binary is up-to-date.
		public bool cached_executable; 

		// If the assemblies were symlinked.
		public bool Symlinked;

		public bool Is32Build { get { return Application.IsArchEnabled (Abis, Abi.Arch32Mask); } } // If we're targetting a 32 bit arch for this target.
		public bool Is64Build { get { return Application.IsArchEnabled (Abis, Abi.Arch64Mask); } } // If we're targetting a 64 bit arch for this target.

		public void AddToBundle (string source, string bundle_path = null)
		{
			List<string> sources;

			if (bundle_path == null) {
				if (source.EndsWith (".framework", StringComparison.Ordinal)) {
					var bundle_name = Path.GetFileNameWithoutExtension (source);
					bundle_path = $"Frameworks/{bundle_name}.framework/{bundle_name}";
					source = Path.Combine (source, bundle_name);
				} else {
					bundle_path = Path.GetFileName (source);
				}
			}

			if (!BundleFiles.TryGetValue (bundle_path, out sources))
				BundleFiles [bundle_path] = sources = new List<string> ();
			sources.Add (source);
		}

		public void LinkWithStaticLibrary (string path)
		{
			linker_flags.AddLinkWith (path);
		}

		public void LinkWithStaticLibrary (IEnumerable<string> paths)
		{
			linker_flags.AddLinkWith (paths);
		}

		public void LinkWithFramework (string path)
		{
			linker_flags.AddFramework (path);
		}

		public void LinkWithDynamicLibrary (string path)
		{
			linker_flags.AddLinkWith (path);
		}

		PInvokeWrapperGenerator pinvoke_state;
		PInvokeWrapperGenerator MarshalNativeExceptionsState {
			get {
				if (!App.RequiresPInvokeWrappers)
					return null;

				if (pinvoke_state == null) {
					pinvoke_state = new PInvokeWrapperGenerator ()
					{
						SourcePath = Path.Combine (ArchDirectory, "pinvokes.m"),
						HeaderPath = Path.Combine (ArchDirectory, "pinvokes.h"),
						Registrar = (StaticRegistrar) StaticRegistrar,
					};
				}

				return pinvoke_state;
			}
		}

		public string Executable {
			get {
				return Path.Combine (TargetDirectory, App.ExecutableName);
			}
		}

		public void Initialize (bool show_warnings)
		{
			// we want to load our own mscorlib[-runtime].dll, not something else we're being feeded
			// (e.g. bug #6612) since it might not match the libmono[-sgen].a library we'll link with,
			// so load the corlib we want first.

			var corlib_path = Path.Combine (Resolver.FrameworkDirectory, "mscorlib.dll");
			var corlib = ManifestResolver.Load (corlib_path);
			if (corlib == null)
				throw new MonoTouchException (2006, true, "Can not load mscorlib.dll from: '{0}'. Please reinstall Xamarin.iOS.", corlib_path);

			foreach (var reference in App.References) {
				var ad = ManifestResolver.Load (reference);
				if (ad == null)
					throw new MonoTouchException (2002, true, "Can not resolve reference: {0}", reference);
				if (ad.MainModule.Runtime > TargetRuntime.Net_4_0)
					ErrorHelper.Show (new MonoTouchException (11, false, "{0} was built against a more recent runtime ({1}) than Xamarin.iOS supports.", Path.GetFileName (reference), ad.MainModule.Runtime));

				// Figure out if we're referencing Xamarin.iOS or monotouch.dll
				if (Path.GetFileNameWithoutExtension (ad.MainModule.FileName) == Driver.ProductAssembly)
					ProductAssembly = ad;
			}

			ComputeListOfAssemblies ();

			if (App.LinkMode == LinkMode.None && App.I18n != I18nAssemblies.None)
				AddI18nAssemblies ();

			// an extension is a .dll and it would match itself
			if (App.IsExtension)
				return;

			var root_wo_ext = Path.GetFileNameWithoutExtension (App.RootAssembly);
			foreach (var assembly in Assemblies) {
				if (!assembly.FullPath.EndsWith (".exe", StringComparison.OrdinalIgnoreCase)) {
					if (root_wo_ext == Path.GetFileNameWithoutExtension (assembly.FullPath))
						throw new MonoTouchException (23, true, "Application name '{0}.exe' conflicts with another user assembly.", root_wo_ext);
				}
			}

			linker_flags = new CompilerFlags (this);
		}

		// This is to load the symbols for all assemblies, so that we can give better error messages
		// (with file name / line number information).
		public void LoadSymbols ()
		{
			foreach (var a in Assemblies)
				a.LoadSymbols ();
		}

		IEnumerable<AssemblyDefinition> GetAssemblies ()
		{
			if (App.LinkMode == LinkMode.None)
				return ManifestResolver.GetAssemblies ();

			List<AssemblyDefinition> assemblies = new List<AssemblyDefinition> ();
			if (LinkContext == null) {
				// use data from cache
				foreach (var assembly in Assemblies)
					assemblies.Add (assembly.AssemblyDefinition);
			} else {
				foreach (var assembly in LinkContext.GetAssemblies ()) {
					if (LinkContext.Annotations.GetAction (assembly) == AssemblyAction.Delete)
						continue;

					assemblies.Add (assembly);
				}
			}
			return assemblies;
		}

		public void ComputeLinkerFlags ()
		{
			foreach (var a in Assemblies)
				a.ComputeLinkerFlags ();

			if (App.Platform != ApplePlatform.WatchOS && App.Platform != ApplePlatform.TVOS)
				Frameworks.Add ("CFNetwork"); // required by xamarin_start_wwan
		}

		Dictionary<string, MemberReference> entry_points;
		public IDictionary<string, MemberReference> GetEntryPoints ()
		{
			if (entry_points == null)
				GetRequiredSymbols ();
			return entry_points;
		}

		public IEnumerable<string> GetRequiredSymbols ()
		{
			if (entry_points != null)  
				return entry_points.Keys;

			var cache_location = Path.Combine (Cache.Location, "entry-points.txt");
			if (cached_link || !any_assembly_updated) {
				entry_points = new Dictionary<string, MemberReference> ();
				foreach (var ep in File.ReadAllLines (cache_location))
					entry_points.Add (ep, null);
			} else {
				List<MethodDefinition> marshal_exception_pinvokes;
				if (LinkContext == null) {
					// This happens when using the simlauncher and the msbuild tasks asked for a list
					// of symbols (--symbollist). In that case just produce an empty list, since the
					// binary shouldn't end up stripped anyway.
					entry_points = new Dictionary<string, MemberReference> ();
					marshal_exception_pinvokes = new List<MethodDefinition> ();
				} else {
					entry_points = LinkContext.RequiredSymbols;
					marshal_exception_pinvokes = LinkContext.MarshalExceptionPInvokes;
				}
				
				// keep the debugging helper in debugging binaries only
				if (App.EnableDebug && !App.EnableBitCode)
					entry_points.Add ("mono_pmip", null);

				if (App.IsSimulatorBuild) {
					entry_points.Add ("xamarin_dyn_objc_msgSend", null);
					entry_points.Add ("xamarin_dyn_objc_msgSendSuper", null);
					entry_points.Add ("xamarin_dyn_objc_msgSend_stret", null);
					entry_points.Add ("xamarin_dyn_objc_msgSendSuper_stret", null);
				}

				File.WriteAllText (cache_location, string.Join ("\n", entry_points.Keys.ToArray ()));
			}
			return entry_points.Keys;
		}

		public MemberReference GetMemberForSymbol (string symbol)
		{
			MemberReference rv = null;
			entry_points?.TryGetValue (symbol, out rv);
			return rv;
		}

		//
		// Gets a flattened list of all the assemblies pulled by the root assembly
		//
		public void ComputeListOfAssemblies ()
		{
			var exceptions = new List<Exception> ();
			var assemblies = new HashSet<string> ();

			try {
				var assembly = ManifestResolver.Load (App.RootAssembly);
				ComputeListOfAssemblies (assemblies, assembly, exceptions);
			} catch (MonoTouchException mte) {
				exceptions.Add (mte);
			} catch (Exception e) {
				exceptions.Add (new MonoTouchException (9, true, e, "Error while loading assemblies: {0}", e.Message));
			}

			if (App.LinkMode == LinkMode.None)
				exceptions.AddRange (ManifestResolver.list);

			if (exceptions.Count > 0)
				throw new AggregateException (exceptions);
		}

		void ComputeListOfAssemblies (HashSet<string> assemblies, AssemblyDefinition assembly, List<Exception> exceptions)
		{
			if (assembly == null)
				return;

			var fqname = assembly.MainModule.FileName;
			if (assemblies.Contains (fqname))
				return;

			assemblies.Add (fqname);

			var asm = new Assembly (this, assembly);
			asm.ComputeSatellites ();
			this.Assemblies.Add (asm);

			var main = assembly.MainModule;
			foreach (AssemblyNameReference reference in main.AssemblyReferences) {
				// Verify that none of the references references an incorrect platform assembly.
				switch (reference.Name) {
				case "monotouch":
				case "Xamarin.iOS":
				case "Xamarin.TVOS":
				case "Xamarin.WatchOS":
					if (reference.Name != Driver.ProductAssembly)
						exceptions.Add (ErrorHelper.CreateError (34, "Cannot reference '{0}.dll' in a {1} project - it is implicitly referenced by '{2}'.", reference.Name, Driver.TargetFramework.Identifier, assembly.FullName));
					break;
				}

				var reference_assembly = ManifestResolver.Resolve (reference);
				ComputeListOfAssemblies (assemblies, reference_assembly, exceptions);
			}

			// Custom Attribute metadata can include references to other assemblies, e.g. [X (typeof (Y)], 
			// but it is not reflected in AssemblyReferences :-( ref: #37611
			// so we must scan every custom attribute to look for System.Type
			GetCustomAttributeReferences (assembly, assemblies, exceptions);
			GetCustomAttributeReferences (main, assemblies, exceptions);
			if (main.HasTypes) {
				foreach (var t in main.Types) {
					GetTypeReferences (t, assemblies, exceptions);
				}
			}
		}

		void GetTypeReferences (TypeDefinition type, HashSet<string> assemblies, List<Exception> exceptions)
		{
			GetCustomAttributeReferences (type, assemblies, exceptions);
			if (type.HasEvents) {
				foreach (var e in type.Events)
					GetCustomAttributeReferences (e, assemblies, exceptions);
			}
			if (type.HasFields) {
				foreach (var f in type.Fields)
					GetCustomAttributeReferences (f, assemblies, exceptions);
			}
			if (type.HasMethods) {
				foreach (var m in type.Methods)
					GetCustomAttributeReferences (m, assemblies, exceptions);
			}
			if (type.HasProperties) {
				foreach (var p in type.Properties)
					GetCustomAttributeReferences (p, assemblies, exceptions);
			}
			if (type.HasNestedTypes) {
				foreach (var nt in type.NestedTypes)
					GetTypeReferences (nt, assemblies, exceptions);
			}
		}

		void GetCustomAttributeReferences (ICustomAttributeProvider cap, HashSet<string> assemblies, List<Exception> exceptions)
		{
			if (!cap.HasCustomAttributes)
				return;
			foreach (var ca in cap.CustomAttributes) {
				if (ca.HasConstructorArguments) {
					foreach (var arg in ca.ConstructorArguments)
						GetCustomAttributeArgumentReference (arg, assemblies, exceptions);
				}
				if (ca.HasFields) {
					foreach (var arg in ca.Fields)
						GetCustomAttributeArgumentReference (arg.Argument, assemblies, exceptions);
				}
				if (ca.HasProperties) {
					foreach (var arg in ca.Properties)
						GetCustomAttributeArgumentReference (arg.Argument, assemblies, exceptions);
				}
			}
		}

		void GetCustomAttributeArgumentReference (CustomAttributeArgument arg, HashSet<string> assemblies, List<Exception> exceptions)
		{
			if (!arg.Type.Is ("System", "Type"))
				return;
			var ar = (arg.Value as TypeReference)?.Scope as AssemblyNameReference;
			if (ar == null)
				return;
			var reference_assembly = ManifestResolver.Resolve (ar);
			ComputeListOfAssemblies (assemblies, reference_assembly, exceptions);
		}

		bool IncludeI18nAssembly (Mono.Linker.I18nAssemblies assembly)
		{
			return (App.I18n & assembly) != 0;
		}

		public void AddI18nAssemblies ()
		{
			Assemblies.Add (LoadI18nAssembly ("I18N"));

			if (IncludeI18nAssembly (Mono.Linker.I18nAssemblies.CJK))
				Assemblies.Add (LoadI18nAssembly ("I18N.CJK"));

			if (IncludeI18nAssembly (Mono.Linker.I18nAssemblies.MidEast))
				Assemblies.Add (LoadI18nAssembly ("I18N.MidEast"));

			if (IncludeI18nAssembly (Mono.Linker.I18nAssemblies.Other))
				Assemblies.Add (LoadI18nAssembly ("I18N.Other"));

			if (IncludeI18nAssembly (Mono.Linker.I18nAssemblies.Rare))
				Assemblies.Add (LoadI18nAssembly ("I18N.Rare"));

			if (IncludeI18nAssembly (Mono.Linker.I18nAssemblies.West))
				Assemblies.Add (LoadI18nAssembly ("I18N.West"));
		}

		Assembly LoadI18nAssembly (string name)
		{
			var assembly = ManifestResolver.Resolve (AssemblyNameReference.Parse (name));
			return new Assembly (this, assembly);
		}

		public void LinkAssemblies (string main, ref List<string> assemblies, string output_dir, out MonoTouchLinkContext link_context)
		{
			if (Driver.Verbosity > 0)
				Console.WriteLine ("Linking {0} into {1} using mode '{2}'", main, output_dir, App.LinkMode);

			var cache = Resolver.ToResolverCache ();
			var resolver = cache != null
				? new AssemblyResolver (cache)
				: new AssemblyResolver ();

			resolver.AddSearchDirectory (Resolver.RootDirectory);
			resolver.AddSearchDirectory (Resolver.FrameworkDirectory);

			LinkerOptions = new LinkerOptions {
				MainAssembly = Resolver.Load (main),
				OutputDirectory = output_dir,
				LinkMode = App.LinkMode,
				Resolver = resolver,
				SkippedAssemblies = App.LinkSkipped,
				I18nAssemblies = App.I18n,
				LinkSymbols = true,
				LinkAway = App.LinkAway,
				ExtraDefinitions = App.Definitions,
				Device = App.IsDeviceBuild,
				// by default we keep the code to ensure we're executing on the UI thread (for UI code) for debug builds
				// but this can be overridden to either (a) remove it from debug builds or (b) keep it in release builds
				EnsureUIThread = App.ThreadCheck.HasValue ? App.ThreadCheck.Value : App.EnableDebug,
				DebugBuild = App.EnableDebug,
				Arch = Is64Build ? 8 : 4,
				IsDualBuild = App.IsDualBuild,
				DumpDependencies = App.LinkerDumpDependencies,
				RuntimeOptions = App.RuntimeOptions,
				MarshalNativeExceptionsState = MarshalNativeExceptionsState,
			};

			MonoTouch.Tuner.Linker.Process (LinkerOptions, out link_context, out assemblies);

			Driver.Watch ("Link Assemblies", 1);
		}

		public void ManagedLink ()
		{
			var cache_path = Path.Combine (ArchDirectory, "linked-assemblies.txt");

			foreach (var a in Assemblies)
				a.CopyToDirectory (LinkDirectory, false, check_case: true);

			// Check if we can use a previous link result.
			if (!Driver.Force) {
				var input = new List<string> ();
				var output = new List<string> ();
				var cached_output = new List<string> ();

				if (File.Exists (cache_path)) {
					cached_output.AddRange (File.ReadAllLines (cache_path));

					var cached_loaded = new HashSet<string> ();
					// Only add the previously linked assemblies (and their satellites) as the input/output assemblies.
					// Do not add assemblies which the linker process removed.
					foreach (var a in Assemblies) {
						if (!cached_output.Contains (a.FullPath))
							continue;
						cached_loaded.Add (a.FullPath);
						input.Add (a.FullPath);
						output.Add (Path.Combine (PreBuildDirectory, a.FileName));
						if (File.Exists (a.FullPath + ".mdb")) {
							// Debug files can change without the assemblies themselves changing
							// This should also invalidate the cached linker results, since the non-linked mdbs can't be copied.
							input.Add (a.FullPath + ".mdb");
							output.Add (Path.Combine (PreBuildDirectory, a.FileName) + ".mdb");
						}
						
						if (a.Satellites != null) {
							foreach (var s in a.Satellites) {
								input.Add (s);
								output.Add (Path.Combine (PreBuildDirectory, Path.GetFileName (Path.GetDirectoryName (s)), Path.GetFileName (s)));
								// No need to copy satellite mdb files, satellites are resource-only assemblies.
							}
						}
					}

					// The linker might have added assemblies that weren't specified/reachable
					// from the command line arguments (such as I18N assemblies). Those are not
					// in the Assemblies list at this point (since we haven't run the linker yet)
					// so make sure we take those into account as well.
					var not_loaded = cached_output.Except (cached_loaded);
					foreach (var path in not_loaded) {
						input.Add (path);
						output.Add (Path.Combine (PreBuildDirectory, Path.GetFileName (path)));
					}

					// Include mtouch here too?
					// input.Add (Path.Combine (MTouch.MonoTouchDirectory, "usr", "bin", "mtouch"));

					if (Application.IsUptodate (input, output)) {
						cached_link = true;
						for (int i = Assemblies.Count - 1; i >= 0; i--) {
							var a = Assemblies [i];
							if (!cached_output.Contains (a.FullPath)) {
								Assemblies.RemoveAt (i);
								continue;
							}
							// Load the cached assembly
							a.LoadAssembly (Path.Combine (PreBuildDirectory, a.FileName));
							Driver.Log (3, "Target '{0}' is up-to-date.", a.FullPath);
						}

						foreach (var path in not_loaded) {
							var a = new Assembly (this, path);
							a.LoadAssembly (Path.Combine (PreBuildDirectory, a.FileName));
							Assemblies.Add (a);
						}

						Driver.Watch ("Cached assemblies reloaded", 1);
						Driver.Log ("Cached assemblies reloaded.");

						return;
					}
				}
			}

			// Load the assemblies into memory.
			foreach (var a in Assemblies)
				a.LoadAssembly (a.FullPath);

			var assemblies = new List<string> ();
			foreach (var a in Assemblies)
				assemblies.Add (a.FullPath);
			var linked_assemblies = new List<string> (assemblies);

			LinkAssemblies (App.RootAssembly, ref linked_assemblies, PreBuildDirectory, out LinkContext);

			// Remove assemblies that were linked away
			var removed = new HashSet<string> (assemblies);
			removed.ExceptWith (linked_assemblies);

			foreach (var assembly in removed) {
				for (int i = Assemblies.Count - 1; i >= 0; i--) {
					var ad = Assemblies [i];
					if (assembly != ad.FullPath)
						continue;

					Assemblies.RemoveAt (i);
				}
			}

			// anything added by the linker will have it's original path
			var added = new HashSet<string> ();
			foreach (var assembly in linked_assemblies)
				added.Add (Path.GetFileName (assembly));
			var original = new HashSet<string> ();
			foreach (var assembly in assemblies)
				original.Add (Path.GetFileName (assembly));
			added.ExceptWith (original);

			foreach (var assembly in added) {
				// the linker already copied the assemblies (linked or not) into the output directory
				// and we must NOT overwrite the linker work with an original (unlinked) assembly
				string path = Path.Combine (PreBuildDirectory, assembly);
				var ad = ManifestResolver.Load (path);
				var a = new Assembly (this, ad);
				a.CopyToDirectory (PreBuildDirectory);
				Assemblies.Add (a);
			}

			assemblies = linked_assemblies;

			// Make the assemblies point to the right path.
			foreach (var a in Assemblies)
				a.FullPath = Path.Combine (PreBuildDirectory, a.FileName);

			File.WriteAllText (cache_path, string.Join ("\n", linked_assemblies));
		}
			
		public void ProcessAssemblies ()
		{
			//
			// * Linking
			//   Copy assemblies to LinkDirectory
			//   Link and save to PreBuildDirectory
			//   If marshalling native exceptions:
			//     * Generate/calculate P/Invoke wrappers and save to PreBuildDirectory
			//   [AOT assemblies in BuildDirectory]
			//   Strip managed code save to TargetDirectory (or just copy the file if stripping is disabled).
			//
			// * No linking
			//   If marshalling native exceptions:
			//     Generate/calculate P/Invoke wrappers and save to PreBuildDirectory.
			//   If not marshalling native exceptions:
			//     Copy assemblies to PreBuildDirectory
			//     Copy unmodified assemblies to BuildDirectory
			//   [AOT assemblies in BuildDirectory]
			//   Strip managed code save to TargetDirectory (or just copy the file if stripping is disabled).
			//
			// Note that we end up copying assemblies around quite much,
			// this is because we we're comparing contents instead of 
			// filestamps, so we need the previous file around to be
			// able to do the actual comparison. For instance: in the
			// 'No linking' case above, we copy the assembly to PreBuild
			// before removing the resources and saving that result to Build.
			// The copy in PreBuild is required for the next build iteration,
			// to see if the original assembly has been modified or not (the
			// file in the Build directory might be different due to resource
			// removal even if the original assembly didn't change).
			//
			// This can probably be improved by storing digests/hashes instead
			// of the entire files, but this turned out a bit messy when
			// trying to make it work with the linker, so I decided to go for
			// simple file copying for now.
			//

			// 
			// Other notes:
			//
			// * We need all assemblies in the same directory when doing AOT-compilation.
			// * We cannot overwrite in-place, because it will mess up dependency tracking 
			//   and besides if we overwrite in place we might not be able to ignore
			//   insignificant changes (such as only a GUID change - the code is identical,
			//   but we still need the original assembly since the AOT-ed image also stores
			//   the GUID, and we fail at runtime if the GUIDs in the assembly and the AOT-ed
			//   image don't match - if we overwrite in-place we lose the original assembly and
			//   its GUID).
			// 

			LinkDirectory = Path.Combine (ArchDirectory, "Link");
			if (!Directory.Exists (LinkDirectory))
				Directory.CreateDirectory (LinkDirectory);

			PreBuildDirectory = Path.Combine (ArchDirectory, "PreBuild");
			if (!Directory.Exists (PreBuildDirectory))
				Directory.CreateDirectory (PreBuildDirectory);
			
			BuildDirectory = Path.Combine (ArchDirectory, "Build");
			if (!Directory.Exists (BuildDirectory))
				Directory.CreateDirectory (BuildDirectory);

			if (!Directory.Exists (TargetDirectory))
				Directory.CreateDirectory (TargetDirectory);

			ManagedLink ();

			if (App.RequiresPInvokeWrappers) {
				// Write P/Invokes
				var state = MarshalNativeExceptionsState;
				if (state.Started) {
					// The generator is 'started' by the linker, which means it may not
					// be started if the linker was not executed due to re-using cached results.
					state.End ();
				}
				
				PinvokesTask.Create (compile_tasks, Abis, this, state.SourcePath);

				//if (App.FastDev) {
					// In this case assemblies must link with the resulting dylib,
					// so we can't compile the pinvoke dylib in parallel with later
					// stuff.
					compile_tasks.ExecuteInParallel ();
				//}
			}

			// Now the assemblies are in PreBuildDirectory.

			foreach (var a in Assemblies) {
				var target = Path.Combine (BuildDirectory, a.FileName);
				if (!a.CopyAssembly (a.FullPath, target))
					Driver.Log (3, "Target '{0}' is up-to-date.", target);
				a.FullPath = target;
			}

			Driver.GatherFrameworks (this, Frameworks, WeakFrameworks);

			// Make sure there are no duplicates between frameworks and weak frameworks.
			// Keep the weak ones.
			Frameworks.ExceptWith (WeakFrameworks);
		}

		public void SelectStaticRegistrar ()
		{
			switch (App.Registrar) {
			case RegistrarMode.Static:
			case RegistrarMode.Dynamic:
			case RegistrarMode.Default:
				StaticRegistrar = new StaticRegistrar (this)
				{
					LinkContext = LinkContext,
				};
				break;
			}
		}

		void AOTCompile ()
		{
			if (App.IsSimulatorBuild)
				return;

			// Compile to object files
			foreach (var a in Assemblies) {
				foreach (var abi in Abis)
					a.CreateAOTTask (compile_tasks, abi);
			}

			compile_tasks.ExecuteInParallel (); // REMOVE

			// Convert any .s files to bitcode files if needed
			foreach (var a in Assemblies) {
				foreach (var abi in Abis)
					a.ConvertToBitcodeTask (compile_tasks, abi);
			}

			compile_tasks.ExecuteInParallel (); // REMOVE

			// Sort assemblies to have an assembly's dependency below itself (so that mscorlib is at the top and the .exe at the bottom).
			var sortedAssemblies = new List<Assembly> (Assemblies);
			sortedAssemblies.Sort ((x, y) =>
			{
				if (x.DependencyMap.Contains (y.FullPath))
					return 1;
				else if (y.DependencyMap.Contains (x.FullPath))
					return -1;
				else
					return 0;
			});

			if (Driver.Verbosity > 5) {
				for (int i = 0; i < sortedAssemblies.Count; i++) {
					Driver.Log (6, $"Assembly #{i}: {sortedAssemblies [i].FileName} has {sortedAssemblies [i].DependencyMap.Count} dependencies: {string.Join (", ", sortedAssemblies [i].DependencyMap.OrderBy ((v) => v, StringComparer.Ordinal).ToArray ())}");
				}

				// No matter what the .exe should end up last, so just do a little consistency check
				if (!sortedAssemblies [sortedAssemblies.Count - 1].FileName.EndsWith (".exe", StringComparison.OrdinalIgnoreCase))
					throw new Exception ();
			}

			// Group the assemblies according to their target name, and build them all.
			var grouped = sortedAssemblies.GroupBy ((arg) => arg.BuildTargetName);
			foreach (var abi in Abis) {
				foreach (var @group in grouped) {
					var name = @group.Key;
					var assemblies = @group.AsEnumerable ().ToArray ();

					Driver.Log (5, "Building {0} with {1}", name, string.Join (", ", assemblies.Select ((arg1) => Path.GetFileNameWithoutExtension (arg1.FileName)).ToArray ()));

					// We ensure elsewhere that all assemblies in a group have the same build target.
					var build_target = assemblies [0].BuildTarget;
					string install_name;
					string compiler_output;
					var compiler_flags = new CompilerFlags (this);

					foreach (var a in assemblies) {
						compiler_flags.AddSourceFiles (a.AotInfos [abi].AsmFiles);
						compiler_flags.AddSourceFiles (a.AotInfos [abi].ObjectFiles);
						compiler_flags.AddSourceFiles (a.AotInfos [abi].BitcodeFiles);
					}

					var arch = abi.AsArchString ();
					switch (build_target) {
					case AssemblyBuildTarget.StaticObject:
						install_name = null;
						compiler_output = Path.Combine (Cache.Location, arch, $"lib{name}.o");
						break;
					case AssemblyBuildTarget.DynamicLibrary:
						install_name = $"@executable_path/lib{name}.dylib";
						compiler_output = Path.Combine (Cache.Location, arch, $"lib{name}.dylib");
						break;
					case AssemblyBuildTarget.Framework:
						install_name = $"@rpath/{name}.framework/{name}";
						compiler_output = Path.Combine (Cache.Location, arch, $"lib{name}.dylib"); // frameworks are almost identical to dylibs, so this is expected.
						break;
					default:
						throw new Exception ();
					}

					if (build_target != AssemblyBuildTarget.StaticObject) {
						foreach (var a in assemblies) {
							compiler_flags.AddFrameworks (a.Frameworks, a.WeakFrameworks);
							compiler_flags.AddLinkWith (a.LinkWith, a.ForceLoad);
							compiler_flags.AddOtherFlags (a.LinkerFlags);
						}
						compiler_flags.LinkWithMono ();
						compiler_flags.LinkWithXamarin ();
						if (GetEntryPoints ().ContainsKey ("UIApplicationMain"))
							compiler_flags.AddFramework ("UIKit");
						compiler_flags.LinkWithPInvokes (abi);
					}

					// Check if we really need to 
					var outputs = new string [] { compiler_output };
					compiler_flags.PopulateInputs ();
					if (!Application.IsUptodate (compiler_flags.Inputs, outputs)) {
						Application.TryDelete (outputs);
						compile_tasks.Add (new LinkTask ()
						{
							Target = this,
							AssemblyName = name,
							Abi = abi,
							OutputFile = compiler_output,
							InstallName = install_name,
							CompilerFlags = compiler_flags,
							Language = "assembler",
							SharedLibrary = build_target != AssemblyBuildTarget.StaticObject,
						});
					} else {
						Driver.Log ("Target {0} is up-to-date.", compiler_output);
					}

					switch (build_target) {
					case AssemblyBuildTarget.StaticObject:
						LinkWithStaticLibrary (compiler_output);
						break;
					case AssemblyBuildTarget.DynamicLibrary:
						AddToBundle (compiler_output);
						LinkWithDynamicLibrary (compiler_output);
						break;
					case AssemblyBuildTarget.Framework:
						AddToBundle (compiler_output, $"Frameworks/{name}.framework/{name}");
						LinkWithDynamicLibrary (compiler_output);
						break;
					default:
						throw new Exception ();
					}
				}

				compile_tasks.ExecuteInParallel (); // REMOVE
			}
		}

		public void Compile ()
		{
			// Compute the dependency map, and show warnings if there are any problems.
			List<Exception> exceptions = new List<Exception> ();
			foreach (var a in Assemblies)
				a.ComputeDependencyMap (exceptions);
			if (exceptions.Count > 0) {
				ErrorHelper.Show (exceptions);
				ErrorHelper.Warning (3006, "Could not compute a complete dependency map for the project. This will result in slower build times because Xamarin.iOS can't properly detect what needs to be rebuilt (and what does not need to be rebuilt). Please review previous warnings for more details.");
			}

			// Compile the managed assemblies into object files, frameworks or shared libraries
			AOTCompile ();

			// The static registrar.
			List<string> registration_methods = null;
			if (App.Registrar == RegistrarMode.Static) {
				var registrar_m = Path.Combine (ArchDirectory, "registrar.m");
				var registrar_h = Path.Combine (ArchDirectory, "registrar.h");
				if (!Application.IsUptodate (Assemblies.Select (v => v.FullPath), new string[] { registrar_m, registrar_h })) {
					StaticRegistrar.Generate (Assemblies.Select ((a) => a.AssemblyDefinition), registrar_h, registrar_m);
					registration_methods = new List<string> ();
					registration_methods.Add ("xamarin_create_classes");
					Driver.Watch ("Registrar", 1);
				} else {
					Driver.Log (3, "Target '{0}' is up-to-date.", registrar_m);
				}

				RegistrarTask.Create (compile_tasks, Abis, this, registrar_m);
			}

			if (App.Registrar == RegistrarMode.Dynamic && App.IsSimulatorBuild && App.LinkMode == LinkMode.None) {
				if (registration_methods == null)
					registration_methods = new List<string> ();

				string method;
				string library;
				switch (App.Platform) {
				case ApplePlatform.iOS:
					method = "xamarin_create_classes_Xamarin_iOS";
					library = "Xamarin.iOS.registrar.a";
					break;
				case ApplePlatform.WatchOS:
					method = "xamarin_create_classes_Xamarin_WatchOS";
					library = "Xamarin.WatchOS.registrar.a";
					break;					
				case ApplePlatform.TVOS:
					method = "xamarin_create_classes_Xamarin_TVOS";
					library = "Xamarin.TVOS.registrar.a";
					break;
				default:
					throw ErrorHelper.CreateError (71, "Unknown platform: {0}. This usually indicates a bug in Xamarin.iOS; please file a bug report at http://bugzilla.xamarin.com with a test case.", App.Platform);
				}

				registration_methods.Add (method);
				linker_flags.AddLinkWith (Path.Combine (Driver.MonoTouchLibDirectory, library));
			}

			// The main method.
			foreach (var abi in Abis)
				MainTask.Create (compile_tasks, this, abi, Assemblies, App.AssemblyName, registration_methods);

			// Start compiling.
			// At this point we have:
			// - AOT tasks
			// - static registrar
			// - main method
			// All of these can be compiled in parallel.
			compile_tasks.ExecuteInParallel ();

			//if (App.FastDev) {
			//	foreach (var a in Assemblies) {
			//		if (a.ObjectFiles == null)
			//			continue;
			//		foreach (var dylib in a.ObjectFiles)
			//			LinkWith (dylib);
			//	}
			//}

			Driver.Watch ("Compile", 1);
		}

		public void NativeLink ()
		{
			if (!string.IsNullOrEmpty (App.UserGccFlags))
				App.DeadStrip = false;
			if (App.EnableLLVMOnlyBitCode)
				App.DeadStrip = false;

			// Get global frameworks
			linker_flags.AddFrameworks (App.Frameworks, App.WeakFrameworks);
			linker_flags.AddFrameworks (Frameworks, WeakFrameworks);

			// Collect all LinkWith flags and frameworks from all assemblies.
			foreach (var a in Assemblies) {
				linker_flags.AddFrameworks (a.Frameworks, a.WeakFrameworks);
				if (App.OnlyStaticLibraries || App.IsSimulatorBuild)
					linker_flags.AddLinkWith (a.LinkWith, a.ForceLoad);
				linker_flags.AddOtherFlags (a.LinkerFlags);
			}

			var bitcode = App.EnableBitCode;
			if (bitcode)
				linker_flags.AddOtherFlag (App.EnableMarkerOnlyBitCode ? "-fembed-bitcode-marker" : "-fembed-bitcode");
			
			if (App.EnablePie.HasValue && App.EnablePie.Value && (App.DeploymentTarget < new Version (4, 2)))
				ErrorHelper.Error (28, "Cannot enable PIE (-pie) when targeting iOS 4.1 or earlier. Please disable PIE (-pie:false) or set the deployment target to at least iOS 4.2");

			if (!App.EnablePie.HasValue)
				App.EnablePie = true;

			if (App.Platform == ApplePlatform.iOS) {
				if (App.EnablePie.Value && (App.DeploymentTarget >= new Version (4, 2))) {
					linker_flags.AddOtherFlag ("-Wl,-pie");
				} else {
					linker_flags.AddOtherFlag ("-Wl,-no_pie");
				}
			}

			CompileTask.GetArchFlags (linker_flags, Abis);
			if (App.IsDeviceBuild) {
				linker_flags.AddOtherFlag ($"-m{Driver.TargetMinSdkName}-version-min={App.DeploymentTarget}");
				linker_flags.AddOtherFlag ($"-isysroot {Driver.Quote (Driver.FrameworkDirectory)}");
			} else {
				CompileTask.GetSimulatorCompilerFlags (linker_flags, false, App);
			}
			linker_flags.LinkWithMono ();
			if (App.LibMonoLinkMode != AssemblyBuildTarget.StaticObject)
				AddToBundle (App.GetLibMono (App.LibMonoLinkMode));
			linker_flags.LinkWithXamarin ();
			if (App.LibXamarinLinkMode != AssemblyBuildTarget.StaticObject)
				AddToBundle (App.GetLibXamarin (App.LibXamarinLinkMode));

			linker_flags.AddOtherFlag ($"-o {Driver.Quote (Executable)}");

			linker_flags.AddOtherFlag ("-lz");
			linker_flags.AddOtherFlag ("-liconv");

			bool need_libcpp = false;
			if (App.EnableBitCode)
				need_libcpp = true;
#if ENABLE_BITCODE_ON_IOS
			need_libcpp = true;
#endif
			if (need_libcpp)
				linker_flags.AddOtherFlag ("-lc++");

			// allow the native linker to remove unused symbols (if the caller was removed by the managed linker)
			if (!bitcode) {
				foreach (var entry in GetRequiredSymbols ()) {
					// Note that we include *all* (__Internal) p/invoked symbols here
					// We also include any fields from [Field] attributes.
					linker_flags.ReferenceSymbol (entry);
				}
			}

			string mainlib;
			if (App.IsWatchExtension) {
				mainlib = "libwatchextension.a";
				linker_flags.AddOtherFlag (" -e _xamarin_watchextension_main");
			} else if (App.IsTVExtension) {
				mainlib = "libtvextension.a";
			} else if (App.IsExtension) {
				mainlib = "libextension.a";
			} else {
				mainlib = "libapp.a";
			}
			var libdir = Path.Combine (Driver.ProductSdkDirectory, "usr", "lib");
			var libmain = Path.Combine (libdir, mainlib);
			linker_flags.AddLinkWith (libmain, true);

			if (App.EnableProfiling) {
				string libprofiler;
				if (App.OnlyStaticLibraries) {
					libprofiler = Path.Combine (libdir, "libmono-profiler-log.a");
					linker_flags.AddLinkWith (libprofiler);
					if (!App.EnableBitCode)
						linker_flags.ReferenceSymbol ("mono_profiler_startup_log");
				} else {
					libprofiler = Path.Combine (libdir, "libmono-profiler-log.dylib");
					linker_flags.AddLinkWith (libprofiler);
					AddToBundle (libprofiler);
				}
			}

			if (!string.IsNullOrEmpty (App.UserGccFlags))
				linker_flags.AddOtherFlag (App.UserGccFlags);

			if (App.DeadStrip)
				linker_flags.AddOtherFlag ("-dead_strip");

			if (App.IsExtension) {
				if (App.Platform == ApplePlatform.iOS && Driver.XcodeVersion.Major < 7) {
					linker_flags.AddOtherFlag ("-lpkstart");
					linker_flags.AddOtherFlag ($"-F {Driver.Quote (Path.Combine (Driver.FrameworkDirectory, "System/Library/PrivateFrameworks"))} -framework PlugInKit");
				}
				linker_flags.AddOtherFlag ("-fapplication-extension");
			}

			linker_flags.Inputs = new List<string> ();
			var flags = linker_flags.ToString (); // This will populate Inputs.

			if (!Application.IsUptodate (linker_flags.Inputs, new string [] { Executable } )) {
				// always show the native linker warnings since many of them turn out to be very important
				// and very hard to diagnose otherwise when hidden from the build output. Ref: bug #2430
				var linker_errors = new List<Exception> ();
				var output = new StringBuilder ();
				var code = Driver.RunCommand (Driver.CompilerPath, flags, null, output);

				Application.ProcessNativeLinkerOutput (this, output.ToString (), new string [] { /* FIXME */ } , linker_errors, code != 0);

				if (code != 0) {
					// if the build failed - it could be because of missing frameworks / libraries we identified earlier
					foreach (var assembly in Assemblies) {
						if (assembly.UnresolvedModuleReferences == null)
							continue;
						
						foreach (var mr in assembly.UnresolvedModuleReferences) {
							// TODO: add more diagnose information on the warnings
							var name = Path.GetFileNameWithoutExtension (mr.Name);
							linker_errors.Add (new MonoTouchException (5215, false, "References to '{0}' might require additional -framework=XXX or -lXXX instructions to the native linker", name));
						}
					}
					// mtouch does not validate extra parameters given to GCC when linking (--gcc_flags)
					if (!String.IsNullOrEmpty (App.UserGccFlags))
						linker_errors.Add (new MonoTouchException (5201, true, "Native linking failed. Please review the build log and the user flags provided to gcc: {0}", App.UserGccFlags));
					linker_errors.Add (new MonoTouchException (5202, true, "Native linking failed. Please review the build log.", App.UserGccFlags));
				}
				ErrorHelper.Show (linker_errors);
			} else {
				cached_executable = true;
				Driver.Log (3, "Target '{0}' is up-to-date.", Executable);
			}
			// the native linker can prefer private (and existing) over public (but non-existing) framework when weak_framework are used
			// on an iOS target version where the framework does not exists, e.g. targeting iOS6 for JavaScriptCore added in iOS7 results in
			// /System/Library/PrivateFrameworks/JavaScriptCore.framework/JavaScriptCore instead of
			// /System/Library/Frameworks/JavaScriptCore.framework/JavaScriptCore
			// more details in https://bugzilla.xamarin.com/show_bug.cgi?id=31036
			if (WeakFrameworks.Count > 0)
				AdjustDylibs ();
			Driver.Watch ("Native Link", 1);
		}

		void AdjustDylibs ()
		{
			var sb = new StringBuilder ();
			foreach (var dependency in Xamarin.MachO.GetNativeDependencies (Executable)) {
				if (!dependency.StartsWith ("/System/Library/PrivateFrameworks/", StringComparison.Ordinal))
					continue;
				var fixed_dep = dependency.Replace ("/PrivateFrameworks/", "/Frameworks/");
				sb.Append (" -change ").Append (dependency).Append (' ').Append (fixed_dep);
			}
			if (sb.Length > 0) {
				var quoted_name = Driver.Quote (Executable);
				sb.Append (' ').Append (quoted_name);
				Driver.XcodeRun ("install_name_tool", sb.ToString ());
				sb.Clear ();
			}
		}

		public bool CanWeSymlinkTheApplication ()
		{
			if (!Driver.CanWeSymlinkTheApplication ())
				return false;

			foreach (var a in Assemblies)
				if (!a.CanSymLinkForApplication ())
					return false;

			return true;
		}

		public void Symlink ()
		{
			foreach (var a in Assemblies)
				a.Symlink ();

			var targetExecutable = Executable;

			Application.TryDelete (targetExecutable);

			try {
				var launcher = new StringBuilder ();
				launcher.Append (Path.Combine (Driver.MonoTouchDirectory, "bin", "simlauncher"));
				if (Is32Build)
					launcher.Append ("32");
				else if (Is64Build)
					launcher.Append ("64");
				launcher.Append ("-sgen");
				File.Copy (launcher.ToString (), Executable);
				File.SetLastWriteTime (Executable, DateTime.Now);
			} catch (MonoTouchException) {
				throw;
			} catch (Exception ex) {
				throw new MonoTouchException (1015, true, ex, "Failed to create the executable '{0}': {1}", targetExecutable, ex.Message);
			}

			Symlinked = true;

			if (Driver.Verbosity > 0)
				Console.WriteLine ("Application ({0}) was built using fast-path for simulator.", string.Join (", ", Abis.ToArray ()));
		}

		public void StripManagedCode ()
		{
			var strip = false;

			strip = App.ManagedStrip && App.IsDeviceBuild && !App.EnableDebug && !App.PackageMdb;

			if (!Directory.Exists (AppTargetDirectory))
				Directory.CreateDirectory (AppTargetDirectory);

			if (strip) {
				// note: this is much slower when Parallel.ForEach is used
				Parallel.ForEach (Assemblies, new ParallelOptions () { MaxDegreeOfParallelism = Driver.Concurrency }, (assembly) => 
					{
						var file = assembly.FullPath;
						var output = Path.Combine (AppTargetDirectory, Path.GetFileName (assembly.FullPath));
						if (Application.IsUptodate (file, output)) {
							Driver.Log (3, "Target '{0}' is up-to-date", output);
						} else {
							Driver.FileDelete (output);
							Stripper.Process (file, output);
						}
						// The stripper will only copy the main assembly.
						// We need to copy .config files and satellite assemblies too
						if (App.PackageMdb)
							assembly.CopyMdbToDirectory (AppTargetDirectory);
						assembly.CopyConfigToDirectory (AppTargetDirectory);
						assembly.CopySatellitesToDirectory (AppTargetDirectory);
					});

				Driver.Watch ("Strip Assemblies", 1);
			} else if (!Symlinked) {
				foreach (var assembly in Assemblies)
					assembly.CopyToDirectory (AppTargetDirectory, reload: false, copy_mdb: App.PackageMdb);
			}
		}
	}
}
