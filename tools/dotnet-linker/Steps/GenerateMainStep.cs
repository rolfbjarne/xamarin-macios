using System.Collections.Generic;
using System.IO;
using System.Text;

using Xamarin.Linker;

namespace Xamarin {

	public class GenerateMainStep : ConfigurationAwareStep {
		protected override void EndProcess ()
		{
			base.EndProcess ();

			var registration_methods = new List<string> (Configuration.RegistrationMethods);
			var items = new List<MSBuildItem> ();

			var app = Configuration.Application;

			// We want this called before any other initialization methods.
			registration_methods.Insert (0, "xamarin_initialize_dotnet");

			foreach (var abi in Configuration.Abis) {

				var file = Path.Combine (Configuration.CacheDirectory, $"main.{abi.AsArchString ()}.mm");
				var contents = new StringBuilder ();

				contents.AppendLine ("static void xamarin_initialize_dotnet ()");
				contents.AppendLine ("{");
				contents.AppendLine ("\tsetenv (\"DOTNET_SYSTEM_GLOBALIZATION_INVARIANT\", \"1\", 1); // https://github.com/xamarin/xamarin-macios/issues/8906");
				contents.AppendLine ("}");
				contents.AppendLine ();

				Configuration.Target.GenerateMain (contents, app.Platform, abi, file, registration_methods);

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
