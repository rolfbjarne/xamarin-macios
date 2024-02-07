using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Xamarin.Localization.MSBuild;
using Xamarin.Messaging.Build.Client;

// Disable until we get around to enable + fix any issues.
#nullable disable

namespace Xamarin.MacDev.Tasks {
	public class PackLibraryResources : XamarinTask, ITaskCallback, ICancelableTask {
		#region Inputs

		[Required]
		public string Prefix { get; set; }

		public ITaskItem [] BundleResourcesWithLogicalNames { get; set; }

		#endregion

		#region Outputs

		[Output]
		public ITaskItem [] EmbeddedResources { get; set; }

		#endregion

		static string EscapeMangledResource (string name)
		{
			var mangled = new StringBuilder ();

			for (int i = 0; i < name.Length; i++) {
				switch (name [i]) {
				case '\\': mangled.Append ("_b"); break;
				case '/': mangled.Append ("_f"); break;
				case '_': mangled.Append ("__"); break;
				default: mangled.Append (name [i]); break;
				}
			}

			return mangled.ToString ();
		}

		bool ExecuteRemotely ()
		{
			// Fix LogicalName path for the Mac
			if (BundleResourcesWithLogicalNames is not null) {
				foreach (var resource in BundleResourcesWithLogicalNames) {
					var logicalName = resource.GetMetadata ("LogicalName");

					if (!string.IsNullOrEmpty (logicalName)) {
						resource.SetMetadata ("LogicalName", logicalName.Replace ("\\", "/"));
					}
				}
			}

			var runner = new TaskRunner (SessionId, BuildEngine4);

			try {
				var result = runner.RunAsync (this).Result;

				if (result && EmbeddedResources is not null) {
					// We must get the "real" file that will be embedded in the
					// compiled assembly in Windows
					foreach (var embeddedResource in EmbeddedResources.Where (x => runner.ShouldCopyItemAsync (task: this, item: x).Result)) {
						runner.GetFileAsync (this, embeddedResource.ItemSpec).Wait ();
					}
				}

				return result;
			} catch (Exception ex) {
				Log.LogErrorFromException (ex);

				return false;
			}
		}

		public override bool Execute ()
		{
			if (ShouldExecuteRemotely ())
				return ExecuteRemotely ();

			var results = new List<ITaskItem> ();

			if (BundleResourcesWithLogicalNames is not null) {
				foreach (var item in BundleResourcesWithLogicalNames) {
					var logicalName = item.GetMetadata ("LogicalName");

					if (string.IsNullOrEmpty (logicalName)) {
						Log.LogError (MSBStrings.E0161);
						return false;
					}

					var embedded = new TaskItem (item);

					embedded.SetMetadata ("LogicalName", "__" + Prefix + "_content_" + EscapeMangledResource (logicalName));

					results.Add (embedded);
				}
			}

			EmbeddedResources = results.ToArray ();

			return !Log.HasLoggedErrors;
		}

		public void Cancel ()
		{
			if (ShouldExecuteRemotely ())
				BuildConnection.CancelAsync (BuildEngine4).Wait ();
		}

		public bool ShouldCopyToBuildServer (ITaskItem item) => false;

		public bool ShouldCreateOutputFile (ITaskItem item) => false;

		public IEnumerable<ITaskItem> GetAdditionalItemsToBeCopied () => Enumerable.Empty<ITaskItem> ();
	}
}
