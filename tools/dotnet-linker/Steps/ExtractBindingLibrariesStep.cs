using System;
using System.Collections.Generic;

namespace Xamarin.Linker {

	public class ExtractBindingLibrariesStep : ConfigurationAwareStep {
		protected override void EndProcess ()
		{
			base.EndProcess ();

			// No attributes are currently linked away, which means we don't need to worry about linked away LinkWith attributes.
			// Ref: https://github.com/mono/linker/issues/952 (still open as of this writing).
			var exceptions = new List<Exception> ();
			Configuration.Target.ExtractNativeLinkInfo (exceptions);
			Report (exceptions);

			// Tell MSBuild about the native libraries we found
			var linkWith = new List<MSBuildItem> ();
			foreach (var asm in Configuration.Target.Assemblies) {
				foreach (var arg in asm.LinkWith) {
					var item = new MSBuildItem {
						Include = arg,
						Metadata = new Dictionary<string, string> { { "ForceLoad", "true" } },
					};
					linkWith.Add (item);
				}
			}
			Configuration.WriteOutputForMSBuild ("_BindingLibraryLinkWith", linkWith);

			// Tell MSBuild about any additional linker flags we found
			var linkerFlags = new List<MSBuildItem> ();
			foreach (var asm in Configuration.Target.Assemblies) {
				if (asm.LinkerFlags == null)
					continue;
				foreach (var arg in asm.LinkerFlags) {
					var item = new MSBuildItem {
						Include = arg,
					};
					linkerFlags.Add (item);
				}
			}
			Configuration.WriteOutputForMSBuild ("_BindingLibraryLinkerFlags", linkerFlags);
		}
	}
}
