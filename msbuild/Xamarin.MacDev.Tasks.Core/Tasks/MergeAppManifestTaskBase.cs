using System;
using System.IO;
using System.Linq;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Localization.MSBuild;
using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks
{
	public abstract class MergeAppManifestTaskBase : XamarinTask
	{
		#region Inputs

		[Required]
		public ITaskItem[] AppManifests { get; set; }

		[Required]
		public string MergedAppManifest { get; set; }

		#endregion

		public override bool Execute ()
		{
			Directory.CreateDirectory (Path.GetDirectoryName (MergedAppManifest));

			if (AppManifests.Length == 1) {
				// If there's only one input, then copy straight to output
				File.Copy (AppManifests [0].ItemSpec, MergedAppManifest);
			} else {
				PDictionary plist;

				var firstManifest = AppManifests [0].ItemSpec;
				try {
					plist = PDictionary.FromFile (firstManifest);
				} catch (Exception ex) {
					Log.LogError (null, null, null, firstManifest, 0, 0, 0, 0, MSBStrings.E0010, ex.Message);
					return false;
				}

				CompileAppManifestTaskBase.MergePartialPLists (this, plist, AppManifests.Skip (1));

				FileUtils.UpdateFile (MergedAppManifest, (tmpfile) => plist.Save (tmpfile, true, true));
			}

			return !Log.HasLoggedErrors;
		}
	}
}
