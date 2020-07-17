
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Mono.Cecil;
using Mono.Tuner;

using Xamarin.Bundler;

namespace Xamarin.Linker {
	public class DotNetResolver : CoreResolver {

		public bool EnableRepl { get; set; }

		public IEnumerable<AssemblyDefinition> GetAssemblies ()
		{
			return cache.Values.Cast<AssemblyDefinition> ();
		}

		public void Add (AssemblyDefinition assembly)
		{
			cache [Path.GetFileNameWithoutExtension (assembly.MainModule.FileName)] = assembly;
		}

		public override AssemblyDefinition Resolve (AssemblyNameReference name, ReaderParameters parameters)
		{
			var aname = name.Name;

			AssemblyDefinition assembly;
			if (cache.TryGetValue (aname, out assembly))
				return assembly;

			if (EnableRepl && FrameworkDirectory != null) {
				var replDir = Path.Combine (FrameworkDirectory, "repl");
				if (Directory.Exists (replDir)) {
					assembly = SearchDirectory (aname, replDir);
					if (assembly != null)
						return assembly;
				}
			}

			if (FrameworkDirectory != null) {
				var facadeDir = Path.Combine (FrameworkDirectory, "Facades");
				assembly = SearchDirectory (aname, facadeDir);
				if (assembly != null)
					return assembly;
			}

			if (ArchDirectory != null) {
				assembly = SearchDirectory (aname, ArchDirectory);
				if (assembly != null)
					return assembly;
			}

			assembly = SearchDirectory (aname, FrameworkDirectory);
			if (assembly != null)
				return assembly;

			assembly = SearchDirectory (aname, RootDirectory);
			if (assembly != null)
				return assembly;

			assembly = SearchDirectory (aname, RootDirectory, ".exe");
			if (assembly != null)
				return assembly;

			return null;
		}
	}
}