using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

using Mono.Cecil;

using Xamarin;
using Xamarin.Bundler;
using Xamarin.Linker;
using Xamarin.Utils;

using ObjCRuntime;

#if MTOUCH
using ProductException = Xamarin.Bundler.MonoTouchException;
#else
using ProductException=Xamarin.Bundler.MonoMacException;
#endif

public class MainGenerator {
	public Abi Abi;
	public int Verbosity;
	public Target Target;
	public IEnumerable<Assembly> Assemblies;
	public string AssemblyName;
	public IList<string> RegistrationMethods;
	public string Output;

	public RegistrarMode Registrar => App.Registrar;
	public bool IsDefaultMarshalManagedExceptionMode => App.IsDefaultMarshalManagedExceptionMode;
	public MarshalManagedExceptionMode MarshalManagedExceptions => App.MarshalManagedExceptions;
	public MarshalObjectiveCExceptionMode MarshalObjectiveCExceptions => App.MarshalObjectiveCExceptions;
	public bool EnableDebug => App.EnableDebug;
	public bool EnableSGenConc => App.EnableSGenConc;
	public bool DynamicRegistrationSupported => App.DynamicRegistrationSupported;

	// Xamarin.Mac options
	public string CustomBundleName;
	public bool? DisableLldbAttach;
	public bool? DisableOmitFramePointer;
	public bool IsHybridAOT;
	public bool IsMobile;

	public Application App { get { return Target.App; } }

	// note: this is executed under Parallel.ForEach
	public void Generate ()
	{
		try {
			var sb = new StringBuilder ();
			using (var sw = new StringWriter (sb)) {
				if (App.Platform == ApplePlatform.MacOSX) {
					GenerateMac (sw);
				} else {
					GenerateMain (sw, Target, Assemblies, AssemblyName, Abi, RegistrationMethods);
				}
			}
			Driver.WriteIfDifferent (Output, sb.ToString (), true);
		} catch (ProductException) {
			throw;
		} catch (Exception e) {
			throw ErrorHelper.CreateError (4001, e, Errors.MX4001, Output);
		}
	}

	void GenerateMac (TextWriter sw)
	{
		sw.WriteLine ("#define MONOMAC 1");
		sw.WriteLine ("#include <xamarin/xamarin.h>");
		if (Registrar == RegistrarMode.PartialStatic)
			sw.WriteLine ("extern \"C\" void xamarin_create_classes_Xamarin_Mac ();");
		sw.WriteLine ();
		sw.WriteLine ("extern \"C\" int xammac_setup ()");

		sw.WriteLine ("{");
		if (CustomBundleName != null) {
			sw.WriteLine ("\textern NSString* xamarin_custom_bundle_name;");
			sw.WriteLine ("\txamarin_custom_bundle_name = @\"" + CustomBundleName + "\";");
		}
		if (!IsDefaultMarshalManagedExceptionMode)
			sw.WriteLine ("\txamarin_marshal_managed_exception_mode = MarshalManagedExceptionMode{0};", MarshalManagedExceptions);
		sw.WriteLine ("\txamarin_marshal_objectivec_exception_mode = MarshalObjectiveCExceptionMode{0};", MarshalObjectiveCExceptions);
		if (DisableLldbAttach.HasValue ? DisableLldbAttach.Value : !EnableDebug)
			sw.WriteLine ("\txamarin_disable_lldb_attach = true;");
		if (DisableOmitFramePointer ?? EnableDebug)
			sw.WriteLine ("\txamarin_disable_omit_fp = true;");
		sw.WriteLine ();

		if (Registrar == RegistrarMode.Static)
			sw.WriteLine ("\txamarin_create_classes ();");
		else if (Registrar == RegistrarMode.PartialStatic)
			sw.WriteLine ("\txamarin_create_classes_Xamarin_Mac ();");

		if (EnableDebug)
			sw.WriteLine ("\txamarin_debug_mode = TRUE;");

		sw.WriteLine ($"\tsetenv (\"MONO_GC_PARAMS\", \"major={(EnableSGenConc ? "marksweep-conc" : "marksweep")}\", 1);");
		
		sw.WriteLine ($"\txamarin_supports_dynamic_registration = {(DynamicRegistrationSupported ? "TRUE" : "FALSE")};");

		if (IsHybridAOT)
			sw.WriteLine ("\txamarin_mac_hybrid_aot = TRUE;");

		if (IsMobile)
			sw.WriteLine ("\txamarin_mac_modern = TRUE;");

		sw.WriteLine ("\treturn 0;");
		sw.WriteLine ("}");
		sw.WriteLine ();
	}

	void GenerateMain (TextWriter sw, Target target, IEnumerable<Assembly> assemblies, string assembly_name, Abi abi, IList<string> registration_methods)
	{
#if !MMP
		var app = App;
		var assembly_externs = new StringBuilder ();
		var assembly_aot_modules = new StringBuilder ();
		var register_assemblies = new StringBuilder ();
		var assembly_location = new StringBuilder ();
		var assembly_location_count = 0;
		var enable_llvm = (abi & Abi.LLVM) != 0;
		var is_aot = App.Platform != ApplePlatform.MacOSX;

		register_assemblies.AppendLine ("\tguint32 exception_gchandle = 0;");
		foreach (var s in assemblies) {
			if (!s.IsAOTCompiled)
				continue;
			if ((abi & Abi.SimulatorArchMask) == 0) {
				var info = s.AssemblyDefinition.Name.Name;
				info = EncodeAotSymbol (info);
				assembly_externs.Append ("extern void *mono_aot_module_").Append (info).AppendLine ("_info;");
				assembly_aot_modules.Append ("\tmono_aot_register_module (mono_aot_module_").Append (info).AppendLine ("_info);");
			}
			string sname = s.FileName;
			if (assembly_name != sname && IsBoundAssembly (s)) {
				register_assemblies.Append ("\txamarin_open_and_register (\"").Append (sname).Append ("\", &exception_gchandle);").AppendLine ();
				register_assemblies.AppendLine ("\txamarin_process_managed_exception_gchandle (exception_gchandle);");
			}
		}

		if ((abi & Abi.SimulatorArchMask) == 0 || app.Embeddinator) {
			var frameworks = assemblies.Where ((a) => a.BuildTarget == AssemblyBuildTarget.Framework)
									   .OrderBy ((a) => a.Identity, StringComparer.Ordinal);
			foreach (var asm_fw in frameworks) {
				var asm_name = asm_fw.Identity;
				if (asm_fw.BuildTargetName == asm_name)
					continue; // this is deduceable
				var prefix = string.Empty;
				if (!app.HasFrameworksDirectory && asm_fw.IsCodeShared)
					prefix = "../../";
				var suffix = string.Empty;
				if (app.IsSimulatorBuild)
					suffix = "/simulator";
				assembly_location.AppendFormat ("\t{{ \"{0}\", \"{2}Frameworks/{1}.framework/MonoBundle{3}\" }},\n", asm_name, asm_fw.BuildTargetName, prefix, suffix);
				assembly_location_count++;
			}
		}

		sw.WriteLine ("#include \"xamarin/xamarin.h\"");

		if (assembly_location.Length > 0) {
			sw.WriteLine ();
			sw.WriteLine ("struct AssemblyLocation assembly_location_entries [] = {");
			sw.WriteLine (assembly_location);
			sw.WriteLine ("};");

			sw.WriteLine ();
			sw.WriteLine ("struct AssemblyLocations assembly_locations = {{ {0}, assembly_location_entries }};", assembly_location_count);
		}

		sw.WriteLine ();
		sw.WriteLine (assembly_externs);

		sw.WriteLine ("void xamarin_register_modules_impl ()");
		sw.WriteLine ("{");
		sw.WriteLine (assembly_aot_modules);
		sw.WriteLine ("}");
		sw.WriteLine ();

		sw.WriteLine ("void xamarin_register_assemblies_impl ()");
		sw.WriteLine ("{");
		sw.WriteLine (register_assemblies);
		sw.WriteLine ("}");
		sw.WriteLine ();

		if (registration_methods != null) {
			foreach (var method in registration_methods) {
				sw.Write ("extern \"C\" void ");
				sw.Write (method);
				sw.WriteLine ("();");
			}
		}

		// Burn in a reference to the profiling symbol so that the native linker doesn't remove it
		// On iOS we can pass -u to the native linker, but that doesn't work on tvOS, where
		// we're building with bitcode (even when bitcode is disabled, we still build with the
		// bitcode marker, which makes the linker reject -u).
		if (app.EnableProfiling) {
			sw.WriteLine ("extern \"C\" { void mono_profiler_init_log (); }");
			sw.WriteLine ("typedef void (*xamarin_profiler_symbol_def)();");
			sw.WriteLine ("extern xamarin_profiler_symbol_def xamarin_profiler_symbol;");
			sw.WriteLine ("xamarin_profiler_symbol_def xamarin_profiler_symbol = NULL;");
		}

		if (app.UseInterpreter) {
			sw.WriteLine ("extern \"C\" { void mono_ee_interp_init (const char *); }");
			sw.WriteLine ("extern \"C\" { void mono_icall_table_init (void); }");
			sw.WriteLine ("extern \"C\" { void mono_marshal_ilgen_init (void); }");
			sw.WriteLine ("extern \"C\" { void mono_method_builder_ilgen_init (void); }");
			sw.WriteLine ("extern \"C\" { void mono_sgen_mono_ilgen_init (void); }");
		}

		sw.WriteLine ("void xamarin_setup_impl ()");
		sw.WriteLine ("{");

		if (app.EnableProfiling)
			sw.WriteLine ("\txamarin_profiler_symbol = mono_profiler_init_log;");

		if (app.EnableLLVMOnlyBitCode)
			sw.WriteLine ("\tmono_jit_set_aot_mode (MONO_AOT_MODE_LLVMONLY);");
		else if (app.UseInterpreter) {
			sw.WriteLine ("\tmono_icall_table_init ();");
			sw.WriteLine ("\tmono_marshal_ilgen_init ();");
			sw.WriteLine ("\tmono_method_builder_ilgen_init ();");
			sw.WriteLine ("\tmono_sgen_mono_ilgen_init ();");
			sw.WriteLine ("\tmono_ee_interp_init (NULL);");
			sw.WriteLine ("\tmono_jit_set_aot_mode (MONO_AOT_MODE_INTERP);");
		} else if (app.IsDeviceBuild)
			sw.WriteLine ("\tmono_jit_set_aot_mode (MONO_AOT_MODE_FULL);");

		if (assembly_location.Length > 0)
			sw.WriteLine ("\txamarin_set_assembly_directories (&assembly_locations);");

		if (registration_methods != null) {
			for (int i = 0; i < registration_methods.Count; i++) {
				sw.Write ("\t");
				sw.Write (registration_methods [i]);
				sw.WriteLine ("();");
			}
		}

		if (target.MonoNativeMode != MonoNativeMode.None) {
			string mono_native_lib;
			if (app.LibMonoNativeLinkMode == AssemblyBuildTarget.StaticObject)
				mono_native_lib = "__Internal";
			else
				mono_native_lib = target.GetLibNativeName () + ".dylib";
			sw.WriteLine ();
			sw.WriteLine ($"\tmono_dllmap_insert (NULL, \"System.Native\", NULL, \"{mono_native_lib}\", NULL);");
			sw.WriteLine ($"\tmono_dllmap_insert (NULL, \"libSystem.Native\", NULL, \"{mono_native_lib}\", NULL);");
			sw.WriteLine ($"\tmono_dllmap_insert (NULL, \"System.Security.Cryptography.Native.Apple\", NULL, \"{mono_native_lib}\", NULL);");
			sw.WriteLine ($"\tmono_dllmap_insert (NULL, \"libSystem.Security.Cryptography.Native.Apple\", NULL, \"{mono_native_lib}\", NULL);");
			sw.WriteLine ($"\tmono_dllmap_insert (NULL, \"System.Net.Security.Native\", NULL, \"{mono_native_lib}\", NULL);");
			sw.WriteLine ($"\tmono_dllmap_insert (NULL, \"libSystem.Net.Security.Native\", NULL, \"{mono_native_lib}\", NULL);");
			sw.WriteLine ();
		}

		if (app.EnableDebug)
			sw.WriteLine ("\txamarin_gc_pump = {0};", app.DebugTrack.Value ? "TRUE" : "FALSE");
		sw.WriteLine ("\txamarin_init_mono_debug = {0};", app.PackageManagedDebugSymbols ? "TRUE" : "FALSE");
		sw.WriteLine ("\txamarin_executable_name = \"{0}\";", assembly_name);
		sw.WriteLine ("\tmono_use_llvm = {0};", enable_llvm ? "TRUE" : "FALSE");
		sw.WriteLine ("\txamarin_log_level = {0};", Verbosity.ToString (CultureInfo.InvariantCulture));
		sw.WriteLine ("\txamarin_arch_name = \"{0}\";", abi.AsArchString ());
		if (!app.IsDefaultMarshalManagedExceptionMode)
			sw.WriteLine ("\txamarin_marshal_managed_exception_mode = MarshalManagedExceptionMode{0};", app.MarshalManagedExceptions);
		sw.WriteLine ("\txamarin_marshal_objectivec_exception_mode = MarshalObjectiveCExceptionMode{0};", app.MarshalObjectiveCExceptions);
		if (app.EnableDebug)
			sw.WriteLine ("\txamarin_debug_mode = TRUE;");
		if (!string.IsNullOrEmpty (app.MonoGCParams))
			sw.WriteLine ("\tsetenv (\"MONO_GC_PARAMS\", \"{0}\", 1);", app.MonoGCParams);
		foreach (var kvp in app.EnvironmentVariables)
			sw.WriteLine ("\tsetenv (\"{0}\", \"{1}\", 1);", kvp.Key.Replace ("\"", "\\\""), kvp.Value.Replace ("\"", "\\\""));
		sw.WriteLine ("\txamarin_supports_dynamic_registration = {0};", app.DynamicRegistrationSupported ? "TRUE" : "FALSE");
		sw.WriteLine ("}");
		sw.WriteLine ();
		sw.Write ("int ");
		sw.Write (app.IsWatchExtension ? "xamarin_watchextension_main" : "main");
		sw.WriteLine (" (int argc, char **argv)");
		sw.WriteLine ("{");
		sw.WriteLine ("\tNSAutoreleasePool *pool = [[NSAutoreleasePool alloc] init];");
		if (app.IsExtension) {
			// the name of the executable must be the bundle id (reverse dns notation)
			// but we do not want to impose that (ugly) restriction to the managed .exe / project name / ...
			sw.WriteLine ("\targv [0] = (char *) \"{0}\";", Path.GetFileNameWithoutExtension (app.RootAssemblies [0]));
			sw.WriteLine ("\tint rv = xamarin_main (argc, argv, XamarinLaunchModeExtension);");
		} else {
			sw.WriteLine ("\tint rv = xamarin_main (argc, argv, XamarinLaunchModeApp);");
		}
		sw.WriteLine ("\t[pool drain];");
		sw.WriteLine ("\treturn rv;");
		sw.WriteLine ("}");

		sw.WriteLine ("void xamarin_initialize_callbacks () __attribute__ ((constructor));");
		sw.WriteLine ("void xamarin_initialize_callbacks ()");
		sw.WriteLine ("{");
		sw.WriteLine ("\txamarin_setup = xamarin_setup_impl;");
		sw.WriteLine ("\txamarin_register_assemblies = xamarin_register_assemblies_impl;");
		sw.WriteLine ("\txamarin_register_modules = xamarin_register_modules_impl;");
		sw.WriteLine ("}");

		if (app.Platform == ApplePlatform.WatchOS && app.SdkVersion.Major >= 6 && app.IsWatchExtension) {
			sw.WriteLine ();
			sw.WriteLine ("extern \"C\" { int WKExtensionMain (int argc, char* argv[]); }");
			sw.WriteLine ("int main (int argc, char *argv[])");
			sw.WriteLine ("{");
			sw.WriteLine ("\treturn WKExtensionMain (argc, argv);");
			sw.WriteLine ("}");
		}
#else
	throw new NotImplementedException ();
#endif
	}

	public static string EncodeAotSymbol (string symbol)
	{
		var sb = new StringBuilder ();
		/* This mimics what the aot-compiler does */
		foreach (var b in Encoding.UTF8.GetBytes (symbol)) {
			char c = (char) b;
			if ((c >= '0' && c <= '9') ||
				(c >= 'a' && c <= 'z') ||
				(c >= 'A' && c <= 'Z')) {
				sb.Append (c);
				continue;
			}
			sb.Append ('_');
		}
		return sb.ToString ();
	}

	static bool IsBoundAssembly (Assembly s)
	{
		if (s.IsFrameworkAssembly)
			return false;

		AssemblyDefinition ad = s.AssemblyDefinition;

		foreach (ModuleDefinition md in ad.Modules)
			foreach (TypeDefinition td in md.Types)
				if (td.IsNSObject (s.Target.LinkContext))
					return true;

		return false;
	}
}
