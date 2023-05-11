using System.Collections.Generic;
using System.IO;

using Xamarin.Bundler;
using Xamarin.Utils;

using Mono.Cecil;

#nullable enable

namespace Xamarin.Linker {
	public class RegistrarStep : ConfigurationAwareStep {
		protected override string Name { get; } = "Registrar";
		protected override int ErrorCode { get; } = 2360;

		protected override void TryEndProcess ()
		{
			var app = Configuration.Application;

			app.SelectRegistrar ();

			switch (app.Registrar) {
			case RegistrarMode.Dynamic:
				// Nothing to do here
				break;
			case RegistrarMode.PartialStatic:
				// The method name is created in StaticRegistrar.Specialize.
				var method = Configuration.Target.StaticRegistrar.GetInitializationMethodName (Configuration.PlatformAssembly);
				Configuration.RegistrationMethods.Add (method);
				Configuration.CompilerFlags.AddLinkWith (Configuration.PartialStaticRegistrarLibrary);
				break;
			case RegistrarMode.Static:
				var dir = Configuration.CacheDirectory;
				var header = Path.Combine (dir, "registrar.h");
				var code = Path.Combine (dir, "registrar.mm");
				var bundled_assemblies = new List<AssemblyDefinition> ();
				foreach (var assembly in Configuration.Assemblies) {
					if (Annotations.GetAction (assembly) != Mono.Linker.AssemblyAction.Delete)
						bundled_assemblies.Add (assembly);
				}
				Configuration.Target.StaticRegistrar.Generate (bundled_assemblies, header, code, out var initialization_method, app.ClassMapPath);

				var items = new List<MSBuildItem> ();
				foreach (var abi in Configuration.Abis) {
					items.Add (new MSBuildItem (
						code,
						new Dictionary<string, string> {
							{ "Arch", abi.AsArchString () },
							{ "Arguments", "-std=c++14" },
						}
					));
				}

				Configuration.WriteOutputForMSBuild ("_RegistrarFile", items);
				Configuration.RegistrationMethods.Add (initialization_method);
				break;
			case RegistrarMode.Default: // We should have resolved 'Default' to an actual mode by now.
			default:
				Report (ErrorHelper.CreateError (99, Errors.MX0099, $"Invalid registrar mode: {app.Registrar}"));
				break;
			}
		}
	}
}
