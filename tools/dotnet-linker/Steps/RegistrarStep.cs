using System.Collections.Generic;
using System.IO;

using Xamarin.Bundler;
using Xamarin.Utils;

using Mono.Cecil;

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
			case RegistrarMode.Static: {
				var dir = Configuration.CacheDirectory;
				var header = Path.Combine (dir, "registrar.h");
				var code = Path.Combine (dir, "registrar.mm");
				var bundled_assemblies = new List<AssemblyDefinition> ();
				foreach (var assembly in Configuration.Assemblies) {
					if (Annotations.GetAction (assembly) != Mono.Linker.AssemblyAction.Delete)
						bundled_assemblies.Add (assembly);
				}
				Configuration.Target.StaticRegistrar.Generate (bundled_assemblies, header, code, out var initialization_method);

				var items = new List<MSBuildItem> ();
				foreach (var abi in Configuration.Abis) {
					items.Add (new MSBuildItem {
						Include = code,
						Metadata = {
							{ "Arch", abi.AsArchString () },
							{ "Arguments", "-std=c++14" },
						},
					});
				}

				Configuration.WriteOutputForMSBuild ("_RegistrarFile", items);
				Configuration.RegistrationMethods.Add (initialization_method);
				break;
			}
			case RegistrarMode.StaticPerAssembly: {
				var dir = Configuration.CacheDirectory;
				var bundled_assemblies = new List<AssemblyDefinition> ();
				AssemblyDefinition? corlib = null;
				foreach (var assembly in Configuration.Assemblies) {
					if (Annotations.GetAction (assembly) != Mono.Linker.AssemblyAction.Delete)
						bundled_assemblies.Add (assembly);
					if (assembly.Name.Name == Driver.CorlibName)
						corlib = assembly;
				}

				var registeredAssemblies = new Dictionary<string, RegisteredAssembly> ();
				foreach (var asm in bundled_assemblies) {
					var asmName = asm.Name.Name;
					var header = Path.Combine (dir, asmName + ".registrar.h");
					var code = Path.Combine (dir, asmName + ".registrar.mm");
					var assemblies = new AssemblyDefinition [] { corlib, asm };
					var registered_types = Configuration.Target.StaticRegistrar.GenerateSingleAssembly (null, assemblies, header, code, asm, out var initialization_method);

					if (registered_types == 0) {
						//File.Delete (header);
						File.Delete (code);
						continue;
					}

					var referencedAssemblies = asm.MainModule.AssemblyReferences.
						Where (v => registeredAssemblies.ContainsKey (v.Name));
					registeredAssemblies [asmName] = new RegisteredAssembly {
						Assembly = asm,
						Name = asmName,
						Header = header,
						Code = code,
						InitializationMethod = initialization_method,
						ReferencedAssemblies = referencedAssemblies,
					};
				}

				var sortedRegisteredAssemblies = Sort (registeredAssemblies.Values);
				foreach (var ra in sortedRegisteredAssemblies) {
					var asm = ra.Assembly;

					var items = new List<MSBuildItem> ();
					var isProductAssembly = Configuration.Profile.IsProductAssembly (asm);
					var referencedAssemblies = ra.ReferencedAssemblies.
						Select (v => "lib" + v.Name + ".registrar.dylib");
					var referencedAssembliesMetadata = string.Join (";", referencedAssemblies);
					foreach (var abi in Configuration.Abis) {
						items.Add (new MSBuildItem {
							Include = ra.Code,
							Metadata = {
								{ "Arch", abi.AsArchString () },
								{ "Arguments", "-std=c++14" },
								{ "AssemblyName", ra.Name },
								{ "IsProductAssembly", isProductAssembly ? "true" : "false" },
								{ "ReferencedAssemblies", referencedAssembliesMetadata },
							},
						});
					}

					Configuration.WriteOutputForMSBuild ("_RegistrarFile", items);

					if (isProductAssembly)
						Configuration.RegistrationMethods.Add (ra.InitializationMethod);
				}
				break;
			}
			case RegistrarMode.Default: // We should have resolved 'Default' to an actual mode by now.
			default:
				Report (ErrorHelper.CreateError (99, Errors.MX0099, $"Invalid registrar mode: {app.Registrar}"));
				break;
			}
		}

		IList<RegisteredAssembly> Sort (IEnumerable<RegisteredAssembly> list)
		{
			var rv = new List<RegisteredAssembly> ();
			var input = list.ToList ();

			while (input.Count > 0) {
				// A candidate is an assembly that only references assemblies already in the sorted list.
				// We should always have at least one assembly that does not reference any other assembly,
				// and that will be the first assembly. On the next iteration, the candidates will be all
				// the assemblies that only reference that first assembly. And so on.
				var candidates = input.Where (v => v.ReferencedAssemblies.All (ra => rv.Find (sorted => sorted.Name == ra.Name) is not null)).ToArray ();
				if (candidates.Length == 0)
					throw new System.NotImplementedException ("No candidates?");
				rv.AddRange (candidates);
				foreach (var c in candidates)
					input.Remove (c);
			}

			System.Console.WriteLine ($"Sorted assemblies:\n\t{string.Join ("\n\t", rv.Select (v => v.Name + " => " + string.Join (";", v.ReferencedAssemblies.Select (v => v.Name))))}");

			return rv;
		}

		class RegisteredAssembly
		{
			public AssemblyDefinition Assembly;
			public string Name;
			public string Header;
			public string Code;
			public string InitializationMethod;
			public IEnumerable<AssemblyNameReference> ReferencedAssemblies;
		}

		class CompareRegisteredAssembly : IComparer<RegisteredAssembly> {
			public int Compare (RegisteredAssembly x, RegisteredAssembly y)
			{
				if (y.ReferencedAssemblies.Any (v => v.Name == x.Name))
					return -1;

				if (x.ReferencedAssemblies.Any (v => v.Name == y.Name))
					return 1;

				return 0;
			}
		}
	}
}
