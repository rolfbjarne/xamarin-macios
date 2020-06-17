using System.Collections.Generic;
using System.IO;

using Xamarin.Linker;

namespace Xamarin {

	public class GenerateMainStep : ConfigurationAwareStep {
		protected override void EndProcess ()
		{
			base.EndProcess ();

			var items = new List<MSBuildItem> ();

			foreach (var abi in Configuration.Abis) {
				var file = Path.Combine (Configuration.TemporaryDirectory, $"main.{abi.AsArchString ()}.m");
				var contents = @"
int
main (int argc, char** argv)
{
	return 0;
}
";
				File.WriteAllText (file, contents);
			}
		}
	}
}
