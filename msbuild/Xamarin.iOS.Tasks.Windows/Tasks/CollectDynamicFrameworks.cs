using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.iOS.Tasks.Windows.Properties;
using Xamarin.iOS.Windows;

#nullable enable

namespace Xamarin.iOS.HotRestart.Tasks {
	public class CollectDynamicFrameworks : Task {
		#region Inputs

		[Required]
		public ITaskItem [] Frameworks { get; set; } = Array.Empty<ITaskItem> ();
		#endregion

		#region Outputs

		[Output]
		public ITaskItem [] DynamicFrameworks { get; set; } = Array.Empty<ITaskItem> ();

		#endregion

		public override bool Execute ()
		{
			var frameworks = new List<ITaskItem> ();
			var hotRestartClient = new HotRestartClient ();

			foreach (var framework in Frameworks.Where (f => Path.GetExtension (f.ItemSpec.TrimEnd ('\\')) == ".framework")) {
				framework.ItemSpec = framework.ItemSpec.TrimEnd ('\\');

				if (frameworks.Any (x => x.ItemSpec == framework.ItemSpec)) {
					continue;
				}

				var frameworkDirName = Path.GetFileName (framework.ItemSpec);

				try {
					var frameworkPath = Path.Combine (framework.ItemSpec, Path.GetFileNameWithoutExtension (frameworkDirName));

					Log.LogMessage (MessageImportance.Low, $"Loading: {frameworkPath}");
					hotRestartClient.LoadDynamicFramework (frameworkPath);
				} catch (AppleInvalidFrameworkException frameworkEx) {
					Log.LogMessage (MessageImportance.Normal, Resources.CollectDynamicFrameworks_InvalidFramework, Path.GetFileName (framework.ItemSpec), frameworkEx.Message);
					continue;
				} catch (Exception ex) {
					Log.LogErrorFromException (ex, true, true, framework.ItemSpec);
					continue;
				}

				framework.SetMetadata ("FrameworkDir", $@"{frameworkDirName}\");

				frameworks.Add (framework);
			}

			DynamicFrameworks = frameworks.ToArray ();

			return !Log.HasLoggedErrors;
		}
	}
}
