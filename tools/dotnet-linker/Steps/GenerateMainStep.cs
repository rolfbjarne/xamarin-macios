using System.Collections.Generic;
using System.IO;
using System.Globalization;

using Xamarin.Linker;

namespace Xamarin {

	public class GenerateMainStep : ConfigurationAwareStep {
		protected override void EndProcess ()
		{
			base.EndProcess ();

			var registration_methods = Configuration.RegistrationMethods;
			var items = new List<MSBuildItem> ();

			var app = Configuration.Application;
			var target = Configuration.Target;
			var assemblies = target.Assemblies;
			foreach (var abi in Configuration.Abis) {

				var enable_llvm = (abi & Abi.LLVM) != 0;
				var file = Path.Combine (Configuration.CacheDirectory, $"main.{abi.AsArchString ()}.mm");
				var contents = new StringWriter ();

				contents.WriteLine ("#include \"xamarin/xamarin.h\"");
				contents.WriteLine ();

				target.GenerateAOTInitialization (contents, assemblies, abi, Configuration.AssemblyName);
				target.AddRegistrationMethods (contents, registration_methods);

				contents.WriteLine ("void xamarin_setup_impl ()");
				contents.WriteLine ("{");
				contents.WriteLine ("\tsetenv (\"DOTNET_SYSTEM_GLOBALIZATION_INVARIANT\", \"1\", 1); // https://github.com/xamarin/xamarin-macios/issues/8906");
				contents.WriteLine ("\txamarin_executable_name = \"{0}\";", Configuration.AssemblyName);
				if (registration_methods != null) {
					for (int i = 0; i < registration_methods.Count; i++) {
						contents.Write ("\t");
						contents.Write (registration_methods [i]);
						contents.WriteLine ("();");
					}
				}
				if (!app.IsDefaultMarshalManagedExceptionMode)
					contents.WriteLine ("\txamarin_marshal_managed_exception_mode = MarshalManagedExceptionMode{0};", app.MarshalManagedExceptions);
				contents.WriteLine ("\txamarin_marshal_objectivec_exception_mode = MarshalObjectiveCExceptionMode{0};", app.MarshalObjectiveCExceptions);
				contents.WriteLine ("\txamarin_supports_dynamic_registration = {0};", app.DynamicRegistrationSupported ? "TRUE" : "FALSE");
				contents.WriteLine ("\txamarin_register_assemblies = xamarin_register_assemblies_impl;");
				contents.WriteLine ("\txamarin_register_modules = xamarin_register_modules_impl;");
				if (app.IsDeviceBuild)
					contents.WriteLine ("\tmono_jit_set_aot_mode (MONO_AOT_MODE_FULL);");
				contents.WriteLine ("\tmono_use_llvm = {0};", enable_llvm ? "TRUE" : "FALSE");
				contents.WriteLine ("\txamarin_log_level = {0};", Configuration.Verbosity.ToString (CultureInfo.InvariantCulture));
				contents.WriteLine ("\txamarin_arch_name = \"{0}\";", abi.AsArchString ());
				contents.WriteLine ("}");
				contents.WriteLine ();

				if (Configuration.Platform == Utils.ApplePlatform.MacOSX) {
					contents.WriteLine ("extern \"C\" int xammac_setup ()");
					contents.WriteLine ("{");
					contents.WriteLine ("\txamarin_setup_impl ();");
					contents.WriteLine ("\treturn 0;");
					contents.WriteLine ("}");
				} else {
					contents.WriteLine ("void xamarin_initialize_callbacks () __attribute__ ((constructor));");
					contents.WriteLine ("void xamarin_initialize_callbacks ()");
					contents.WriteLine ("{");
					contents.WriteLine ("\txamarin_setup = xamarin_setup_impl;");
					contents.WriteLine ("}");
					contents.WriteLine ();
					contents.WriteLine ("int");
					contents.WriteLine ("main (int argc, char** argv)");
					contents.WriteLine ("{");
					contents.WriteLine ("\t@autoreleasepool { return xamarin_main (argc, argv, XamarinLaunchModeApp); }");
					contents.WriteLine ("}");
				}

				File.WriteAllText (file, contents.ToString ());

				items.Add (new MSBuildItem {
					Include = file,
					Metadata = {
						{ "Arch", abi.AsArchString () },
					},
				});
			}

			Configuration.WriteOutputForMSBuild ("_MainFile", items);

			var linkWith = new List<MSBuildItem> ();
			if (Configuration.CompilerFlags.LinkWithLibraries != null) {
				foreach (var lib in Configuration.CompilerFlags.LinkWithLibraries) {
					linkWith.Add (new MSBuildItem {
						Include = lib,
					});
				}
			}
			if (Configuration.CompilerFlags.ForceLoadLibraries != null) {
				foreach (var lib in Configuration.CompilerFlags.ForceLoadLibraries) {
					linkWith.Add (new MSBuildItem {
						Include = lib,
						Metadata = {
							{ "ForceLoad", "true" },
						},
					});
				}
			}

			Configuration.WriteOutputForMSBuild ("_MainLinkWith", linkWith);
		}
	}
}
