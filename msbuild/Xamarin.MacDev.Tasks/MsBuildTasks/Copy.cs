extern alias Microsoft_Build_Tasks_Core;

using System;
using System.IO;
using System.Linq;

using Microsoft.Build.Framework;

using Xamarin.Messaging.Build.Client;

namespace Microsoft.Build.Tasks {
	public class Copy : Microsoft_Build_Tasks_Core::Microsoft.Build.Tasks.Copy {
		public string SessionId { get; set; } = string.Empty;
		public override bool Execute ()
		{
			if (!this.ShouldExecuteRemotely (SessionId)) {

				Log.LogMessage (MessageImportance.Low, $"Copy () REMOTE {(SourceFiles?.Count () ?? -1)} sources files. Current directory: {Environment.CurrentDirectory}");

				if (SourceFiles?.Any () == true) {
					foreach (var sf in SourceFiles) {
						Log.LogMessage (MessageImportance.Low, $"Copy () REMOTE  pre copy BuildSessionId: {sf.GetMetadata ("BuildSessionId")} ItemSpec: {sf.ItemSpec} BuildServerPath: {sf.GetMetadata ("BuildServerPath")} Exists: {File.Exists (sf.ItemSpec)}");
					}
				}

				var rv = base.Execute ();

				if (SourceFiles?.Any () == true) {
					foreach (var sf in SourceFiles) {
						Log.LogMessage (MessageImportance.Low, $"Copy () REMOTE post copy BuildSessionId: {sf.GetMetadata ("BuildSessionId")} ItemSpec: {sf.ItemSpec} BuildServerPath: {sf.GetMetadata ("BuildServerPath")} Exists: {File.Exists (sf.ItemSpec)}");
					}
				}

				return rv;
			}

			var taskRunner = new TaskRunner (SessionId, BuildEngine4);

			Log.LogMessage (MessageImportance.Low, $"Copy () {(SourceFiles?.Count () ?? -1)} sources files. Current directory: {Environment.CurrentDirectory}");

			if (SourceFiles?.Any () == true) {
				foreach (var sf in SourceFiles) {
					Log.LogMessage (MessageImportance.Low, $"Copy ()  pre fix BuildSessionId: {sf.GetMetadata ("BuildSessionId")} ItemSpec: {sf.ItemSpec} BuildServerPath: {sf.GetMetadata ("BuildServerPath")} Exists: {File.Exists (sf.ItemSpec)}");
				}
				taskRunner.FixReferencedItems (this, SourceFiles);
				foreach (var sf in SourceFiles) {
					Log.LogMessage (MessageImportance.Low, $"Copy () post fix BuildSessionId: {sf.GetMetadata ("BuildSessionId")} ItemSpec: {sf.ItemSpec} BuildServerPath: {sf.GetMetadata ("BuildServerPath")} Exists: {File.Exists (sf.ItemSpec)}");
				}
			}

			return taskRunner.RunAsync (this).Result;
		}
	}
}
