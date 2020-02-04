using System;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Xamarin.MacDev.Tasks
{
	public abstract class FindItemWithLogicalNameTaskBase : Task
	{
		#region Inputs

		public string SessionId { get; set; }

		[Required]
		public string ProjectDir { get; set; }

		[Required]
		public string ResourcePrefix { get; set; }

		[Required]
		public string LogicalName { get; set; }

		public ITaskItem[] Items { get; set; }

		#endregion Inputs

		#region Outputs

		[Output]
		public ITaskItem Item { get; set; }

		#endregion Outputs

		public override bool Execute ()
		{
			if (Items != null) {
				var prefixes = BundleResource.SplitResourcePrefixes (ResourcePrefix);

				foreach (var item in Items) {
					var logical = BundleResource.GetLogicalName (ProjectDir, prefixes, item, !string.IsNullOrEmpty(SessionId));

					Console.WriteLine ("FindItemWithLogicalName ProjectDir={0} prefixes={1} item={2} => {3}", ProjectDir, string.Join (";", prefixes), item, logical);
					if (logical == LogicalName) {
						Log.LogMessage (MessageImportance.Low, "  {0} found at: {1}", LogicalName, item.ItemSpec);
						Item = item;
						break;
					}
				}
			} else {

				Console.WriteLine ("FindItemWithLogicalName ProjectDir={0} No Items", ProjectDir);
			}

			return !Log.HasLoggedErrors;
		}
	}
}

