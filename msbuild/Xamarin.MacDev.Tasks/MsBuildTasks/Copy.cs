extern alias Microsoft_Build_Tasks_Core;

using System.Linq;
using Xamarin.Messaging.Build.Client;

namespace Microsoft.Build.Tasks {
	public class Copy : Microsoft_Build_Tasks_Core::Microsoft.Build.Tasks.Copy {
		public string SessionId { get; set; } = string.Empty;
		public override bool Execute ()
		{
			if (!this.ShouldExecuteRemotely (SessionId))
				return base.Execute ();

			var taskRunner = new TaskRunner (SessionId, BuildEngine4);

			if (SourceFiles?.Any () == true) {
				taskRunner.FixReferencedItems (this, SourceFiles);
			}

			return taskRunner.RunAsync (this).Result;
		}
	}
}
