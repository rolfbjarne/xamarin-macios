﻿using System;
using System.IO;
using System.Collections.Generic;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.MacDev;

namespace Xamarin.MacDev.Tasks
{
	public abstract class ComputeBundleResourceOutputPathsTaskBase : Task
	{
		public string SessionId { get; set; }

		[Required]
		public ITaskItem AppBundleDir { get; set; }

		[Required]
		public string BundleIdentifier { get; set; }

		public ITaskItem[] BundleResources { get; set; }

		public bool EnableOnDemandResources { get; set; }

		[Required]
		public string IntermediateOutputPath { get; set; }

		[Required]
		public string OutputPath { get; set; }

		[Output]
		public ITaskItem[] BundleResourcesWithOutputPaths { get; set; }

		public override bool Execute ()
		{
			Log.LogTaskName ("ComputeBundleResourceOutputPaths");
			Log.LogTaskProperty ("AppBundleDir", AppBundleDir);
			Log.LogTaskProperty ("BundleIdentifier", BundleIdentifier);
			Log.LogTaskProperty ("BundleResources", BundleResources);
			Log.LogTaskProperty ("EnableOnDemandResources", EnableOnDemandResources);
			Log.LogTaskProperty ("IntermediateOutputPath", IntermediateOutputPath);
			Log.LogTaskProperty ("OutputPath", OutputPath);

			var intermediate = Path.Combine (IntermediateOutputPath, "assetpacks");
			var bundleResources = new List<ITaskItem> ();
			var packs = new HashSet<string> ();

			if (BundleResources != null) {
				foreach (var item in BundleResources) {
					var logicalName = item.GetMetadata ("LogicalName");
					var outputPath = item.GetMetadata ("OutputPath");
					IList<string> tags;
					string hash;

					if (EnableOnDemandResources && (tags = AssetPackUtils.GetResourceTags (item)) != null) {
						var assetpack = AssetPackUtils.GetAssetPackDirectory (OutputPath, BundleIdentifier, tags, out hash);

						if (packs.Add (hash)) {
							var path = Path.Combine (intermediate, hash + ".plist");

							if (!File.Exists (path)) {
								var plist = new PDictionary ();
								var array = new PArray ();

								for (int i = 0; i < tags.Count; i++)
									array.Add (new PString (tags[i]));

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
						outputPath = Path.Combine (AppBundleDir.ItemSpec, logicalName);
					}

					var bundleResource = new TaskItem (item);

					bundleResource.SetMetadata ("OutputPath", outputPath);

					bundleResources.Add (bundleResource);
				}
			}

			BundleResourcesWithOutputPaths = bundleResources.ToArray ();

			return !Log.HasLoggedErrors;
		}
	}
}
