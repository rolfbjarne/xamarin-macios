using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

using Xamarin.Bundler;
using Xamarin.Utils;

#nullable enable

namespace Xamarin.Linker {
	public class ManagedRegistrarStep : ConfigurationAwareStep {
		protected override string Name { get; } = "ManagedRegistrar";
		protected override int ErrorCode { get; } = 2430;


		protected override void TryProcess ()
		{
			base.TryProcess ();

			app = Configuration.Application;
			app.SelectRegistrar ();

			if (app.Registrar != RegistrarMode.ManagedStatic)
				return;
		}

		protected override void TryEndProcess ()
		{
			base.TryEndProcess ();

			if (app!.Registrar != RegistrarMode.ManagedStatic)
				return;
		}

		protected override void TryProcessAssembly (AssemblyDefinition assembly)
		{
			base.TryProcessAssembly (assembly);

			if (app!.Registrar != RegistrarMode.ManagedStatic)
				return;
		}

	}
}