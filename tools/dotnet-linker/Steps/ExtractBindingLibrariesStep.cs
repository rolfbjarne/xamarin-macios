using System;
using System.Collections.Generic;
using System.Linq;

using Mono.Cecil;

using Xamarin.Bundler;
using Xamarin.Linker;

namespace Xamarin.Linker {

	public class ExtractBindingLibrariesStep : ConfigurationAwareStep {
		protected override void EndProcess ()
		{
			base.EndProcess ();

			// No attributes are currently linked away, which means we don't need to worry about linked away LinkWith attributes.
			// Ref: https://github.com/mono/linker/issues/952 (still open as of this writing).
			List<Exception> exceptions = new List<Exception> ();
			Configuration.Target.ExtractNativeLinkInfo (exceptions);
			Console.WriteLine ("Extracted native link info");
			Report (exceptions);

			var items = new List<MSBuildItem> ();
			foreach (var asm in Configuration.Target.Assemblies) {
				foreach (var arg in asm.LinkWith) {
					var item = new MSBuildItem {
						Include = arg,
					};
					items.Add (item);
				}
			}
			Configuration.WriteOutputForMSBuild ("_NativeLinkerFlags", items);
		}
	}
}
