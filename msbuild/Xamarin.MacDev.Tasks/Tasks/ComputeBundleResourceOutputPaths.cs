using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.MacDev;
using Xamarin.Messaging.Build.Client;

// Disable until we get around to enable + fix any issues.
#nullable disable

namespace Xamarin.MacDev.Tasks {
	public class ComputeBundleResourceOutputPaths : XamarinTask, ITaskCallback, ICancelableTask {
		[Required]
		public ITaskItem AppResourcesPath { get; set; }

		[Required]
		public string BundleIdentifier { get; set; }

		public ITaskItem [] BundleResources { get; set; }

		public bool EnableOnDemandResources { get; set; }

		[Required]
		public string IntermediateOutputPath { get; set; }

		[Required]
		public string OutputPath { get; set; }

		[Output]
		public ITaskItem [] BundleResourcesWithOutputPaths { get; set; }

		public override bool Execute ()
		{
			if (ShouldExecuteRemotely ()) {
				var result = new TaskRunner (SessionId, BuildEngine4).RunAsync (this).Result;

				RemoveDuplicates ();

				return result;
			}

			var intermediate = Path.Combine (IntermediateOutputPath, "assetpacks");
			var bundleResources = new List<ITaskItem> ();
			var packs = new HashSet<string> ();

			if (BundleResources is not null) {
				foreach (var item in BundleResources) {
					var logicalName = item.GetMetadata ("LogicalName");
					// if logicalName is null or empty, use the filename
					if (string.IsNullOrEmpty (logicalName))
						logicalName = Path.GetFileName (item.GetMetadata ("FullPath"));
					var outputPath = item.GetMetadata ("OutputPath");
					IList<string> tags;
					string hash;

					if (EnableOnDemandResources && (tags = AssetPackUtils.GetResourceTags (item)) is not null) {
						var assetpack = AssetPackUtils.GetAssetPackDirectory (OutputPath, BundleIdentifier, tags, out hash);

						if (packs.Add (hash)) {
							var path = Path.Combine (intermediate, hash + ".plist");

							if (!File.Exists (path)) {
								var plist = new PDictionary ();
								var array = new PArray ();

								for (int i = 0; i < tags.Count; i++)
									array.Add (new PString (tags [i]));

								plist.SetCFBundleIdentifier (BundleIdentifier + ".asset-pack-" + hash);
								plist.Add ("Tags", array);

								Directory.CreateDirectory (intermediate);

								plist.Save (path, true, true);
							}

							var manifest = new TaskItem (path);
							manifest.SetMetadata ("OutputPath", Path.Combine (assetpack, "Info.plist"));
							bundleResources.Add (manifest);
						}

						outputPath = Path.Combine (assetpack, logicalName);
					} else if (string.IsNullOrEmpty (outputPath)) {
						outputPath = Path.Combine (AppResourcesPath.ItemSpec, logicalName);
					}

					var bundleResource = new TaskItem (item);

					bundleResource.SetMetadata ("OutputPath", outputPath);

					bundleResources.Add (bundleResource);
				}
			}

			BundleResourcesWithOutputPaths = bundleResources.ToArray ();

			return !Log.HasLoggedErrors;
		}

		public IEnumerable<ITaskItem> GetAdditionalItemsToBeCopied () => Enumerable.Empty<ITaskItem> ();

		public bool ShouldCopyToBuildServer (ITaskItem item) => false;

		public bool ShouldCreateOutputFile (ITaskItem item) => false;

		public void Cancel ()
		{
			if (ShouldExecuteRemotely ())
				BuildConnection.CancelAsync (BuildEngine4).Wait ();
		}

		void RemoveDuplicates ()
		{
			// Remove duplicated files 
			var filteredOutput = new List<ITaskItem> ();

			foreach (var item in BundleResourcesWithOutputPaths) {
				var itemIsFromProjectReference = IsFromProjectReference (item);
				var duplicate = filteredOutput.FirstOrDefault (i => i.GetMetadata ("OutputPath") == item.GetMetadata ("OutputPath"));

				if (duplicate is not null) {
					if (!IsFromProjectReference (duplicate) && itemIsFromProjectReference) {
						filteredOutput.Remove (duplicate);
					}
				}

				if (itemIsFromProjectReference || duplicate is null)
					filteredOutput.Add (item);
			}

			BundleResourcesWithOutputPaths = filteredOutput.ToArray ();
		}

		bool IsFromProjectReference (ITaskItem item) => !string.IsNullOrEmpty (item.GetMetadata ("MSBuildSourceProjectFile"));
	}
}
