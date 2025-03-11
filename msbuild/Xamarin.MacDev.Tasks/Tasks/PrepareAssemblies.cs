using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Build;
using Xamarin.Utils;

#nullable enable

namespace Xamarin.MacDev.Tasks {
	public class PrepareAssemblies : XamarinTask {
#region Inputs
		[Required]
		public ITaskItem[] InputAssemblies { get; set; } = [];

		public string OutputDirectory { get; set; } = "";
#endregion

#region Outputs
		[Output]
		public ITaskItem[] OutputAssemblies { get; set; } = [];
#endregion

		Dictionary<AssemblyPreparerInfo, ITaskItem> map = new ();

		AssemblyPreparerInfo GetAssemblyInfo (ITaskItem item)
		{
			var inputPath = Path.GetFullPath (item.ItemSpec);
			var outputPath = Path.Combine (OutputDirectory, Path.GetFileName (inputPath)); // FIXME: wrong for resource assemblies, at the very least.
			var rv = new AssemblyPreparerInfo (inputPath, outputPath);
			map [rv] = item;
			return rv;
		}

		public override bool Execute ()
		{
			try {
				var infos = InputAssemblies.Select (GetAssemblyInfo).ToArray ();
				using var preparer = new AssemblyPreparer (infos, Platform.AsString ());
				var rv = preparer.Prepare (out var exceptions);
				// TODO: report warnings & errors
				OutputAssemblies = preparer.Assemblies.Select (v => {
					var item = map [v];
					item.ItemSpec = v.OutputPath;
					return item;
				}).ToArray ();
				return rv && !Log.HasLoggedErrors;
			} catch (Exception e) {
				Log.LogError ("Unexpected error while preparing assemblies: {0}", e.Message);
				return false;
			}
		}
	}
}
