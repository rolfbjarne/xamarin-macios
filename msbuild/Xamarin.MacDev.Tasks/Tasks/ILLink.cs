using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Tasks;
using Microsoft.Build.Utilities;

using Xamarin.MacDev.Tasks;
using Xamarin.Messaging.Build.Client;

#nullable enable

namespace Xamarin.MacDev.Tasks {
	public class ILLink : global::ILLink.Tasks.ILLink, ITaskCallback, IHasSessionId {
		public string SessionId { get; set; } = string.Empty;

		public ITaskItem [] DebugSymbols { get; set; } = Array.Empty<ITaskItem> ();

		[Required]
		public string LinkerItemsDirectory { get; set; } = string.Empty;

		[Required]
		public string LinkerCacheDirectory { get; set; } = string.Empty;

		[Output]
		public ITaskItem [] LinkerOutputItems { get; set; } = Array.Empty<ITaskItem> ();

		[Output]
		public ITaskItem [] LinkerCacheItems { get; set; } = Array.Empty<ITaskItem> ();

		[Output]
		public ITaskItem [] LinkedItems { get; set; } = Array.Empty<ITaskItem> ();

		public override bool Execute ()
		{
			if (this.ShouldExecuteRemotely (SessionId)) {
				if (!XamarinTask.ExecuteRemotely (this, out var taskRunner))
					return false;
				// After remote execution, explicitly copy the output files from the Mac to Windows
				// so they have actual content (not just 0-byte placeholders).
				CopyFilesToWindowsAsync (taskRunner).Wait ();
				return true;
			}

			// Capture execution start time for Mac-side detection
			var executionStartTime = DateTime.UtcNow;
			var result = base.Execute ();

			if (result) {
				// Collect all files and tag those modified during this execution
				LinkerOutputItems = GetAllFilesWithMetadata (LinkerItemsDirectory, executionStartTime);
				LinkedItems = GetAllFilesWithMetadata (OutputDirectory.ItemSpec, executionStartTime);
				LinkerCacheItems = GetAllFilesWithMetadata (LinkerCacheDirectory, executionStartTime);
			}

			return result;
		}

		public override void Cancel ()
		{
			if (this.ShouldExecuteRemotely (SessionId))
				BuildConnection.CancelAsync (BuildEngine4).Wait ();
			else
				base.Cancel ();
		}

		ITaskItem [] GetAllFilesWithMetadata (string directory, DateTime executionStartTime)
		{
			if (string.IsNullOrEmpty (directory) || !Directory.Exists (directory))
				return Array.Empty<ITaskItem> ();

			return Directory.EnumerateFiles (directory, "*", SearchOption.AllDirectories)
				.Select (file => {
					var fileInfo = new FileInfo (file);
					var item = new TaskItem (file);

					// Check if file was created or modified during this execution
					var wasModified = fileInfo.CreationTimeUtc >= executionStartTime ||
									  fileInfo.LastWriteTimeUtc >= executionStartTime;

					// Tag files that were modified during this execution
					item.SetMetadata ("Modified", wasModified.ToString ());

					return item;
				})
				.ToArray ();
		}

		async System.Threading.Tasks.Task CopyFilesToWindowsAsync (TaskRunner taskRunner)
		{
			var allItems = LinkerOutputItems.Concat (LinkedItems).Concat (LinkerCacheItems);
			foreach (var item in allItems) {
				Log.LogMessage (MessageImportance.Low, $"Copying {item.ItemSpec} from the remote Mac to Windows");
				await taskRunner.GetFileAsync (this, item.ItemSpec).ConfigureAwait (false);
			}
		}

		// ITaskCallback implementation
		public bool ShouldCopyToBuildServer (ITaskItem item) => true;

		public bool ShouldCreateOutputFile (ITaskItem item)
		{
			// Don't create output files here - we explicitly copy them in CopyFilesToWindowsAsync
			// to ensure they have actual content instead of being 0-byte placeholders.
			return false;
		}

		public IEnumerable<ITaskItem> GetAdditionalItemsToBeCopied () => Array.Empty<ITaskItem> ();
	}
}
