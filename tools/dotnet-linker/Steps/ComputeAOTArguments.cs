using System.Collections.Generic;

using Xamarin.Utils;

namespace Xamarin.Linker {
	public class ComputeAOTArguments : ConfigurationAwareStep {
		protected override string Name { get; } = "Compute AOT Arguments";
		protected override int ErrorCode { get; } = 2370;

		protected override void TryEndProcess ()
		{
			base.TryEndProcess ();

			var assembliesToAOT = new List<MSBuildItem> ();

			var app = Configuration.Application;
			foreach (var asm in Configuration.Target.Assemblies) {
				var isInterpreted = app.IsInterpreted (asm.FullPath);
				var isAOTCompiled = app.IsAOTCompiled (asm.FullPath);
				var item = new MSBuildItem {
					Include = asm.FullPath,
					Metadata = new Dictionary<string, string> {
						{ "IsInterpreted", isInterpreted ? "true" : "false" },
						{ "IsAOTCompiled", isAOTCompiled ? "true" : "false" },
					},
				};
				if (isAOTCompiled)
					item.Metadata.Add ("AOTArguments", StringUtils.FormatArguments (app.GetAotArguments (asm.FullPath, Abi.i386, "", "", "", ""))); // FIXME
				assembliesToAOT.Add (item);
			}

			Configuration.WriteOutputForMSBuild ("_AssembliesToAOT", assembliesToAOT);
		}
	}
}
