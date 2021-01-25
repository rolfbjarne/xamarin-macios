using System.Collections.Generic;

using Xamarin.Utils;

namespace Xamarin.Linker {
	public class ComputeAOTArguments : ConfigurationAwareStep {
		protected override string Name { get; } = "Compute AOT Arguments";
		protected override int ErrorCode { get; } = 2370;

		protected override void TryEndProcess ()
		{
			base.TryEndProcess ();

			var linkerFrameworks = new List<MSBuildItem> ();

			switch (Configuration.Platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.MacCatalyst:
				linkerFrameworks.Add (new MSBuildItem {
					Include = "GSS",
					Metadata = { { "IsWeak", "false" } },
				});
				break;
			}

			Configuration.WriteOutputForMSBuild ("_LinkerFrameworks", linkerFrameworks);
		}
	}
}
