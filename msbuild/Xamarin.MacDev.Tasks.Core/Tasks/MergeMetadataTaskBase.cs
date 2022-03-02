using System;
using System.Linq;

using Microsoft.Build.Framework;

#nullable enable

namespace Xamarin.MacDev.Tasks {

	// Given two item groups and a list of metadata names, this task
	// will find all the items in the second (target) item group that exist
	// in the first (source) item group, and copy the specified metadata
	// from the source item into corresponding the target item.
	public abstract partial class MergeMetadataTaskBase : XamarinTask {

		#region Inputs
		[Required]
		public ITaskItem [] SourceItemGroup { get; set; } = Array.Empty<ITaskItem> ();

		[Required]
		public ITaskItem [] TargetItemGroup { get; set; } = Array.Empty<ITaskItem> ();

		[Required]
		public string MetadataToCopy { get; set; } = string.Empty;
		#endregion

		#region Outputs
		[Output]
		public ITaskItem[] OutputItemGroup { get; set; } = Array.Empty<ITaskItem> ();
		#endregion

		public override bool Execute ()
		{
			var metadataNames = MetadataToCopy.Split (new char [] { ';' }, StringSplitOptions.RemoveEmptyEntries);

			foreach (var target in TargetItemGroup) {
				var source = SourceItemGroup.FirstOrDefault (v => v.ItemSpec == target.ItemSpec);
				if (source is null)
					continue;

				foreach (var metadata in metadataNames) {
					target.SetMetadata (metadata, source.GetMetadata (metadata));
				}
			}

			OutputItemGroup = TargetItemGroup;

			return !Log.HasLoggedErrors;
		}
	}
}
