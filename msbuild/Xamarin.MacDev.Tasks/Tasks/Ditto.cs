using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Messaging.Build.Client;

namespace Xamarin.MacDev.Tasks
{
	public class Ditto : DittoTaskBase, ITaskCallback
	{
		public override bool Execute ()
		{
			if (ShouldExecuteRemotely ()) {
				var taskRunner = new TaskRunner (SessionId, BuildEngine4);

				taskRunner.FixReferencedItems (new ITaskItem [] { Source });

				return taskRunner.RunAsync (this).Result;
			}

			return base.Execute ();
		}

		public override void Cancel ()
		{
			base.Cancel ();

			if (ShouldExecuteRemotely ())
				BuildConnection.CancelAsync (SessionId, BuildEngine4).Wait ();
		}

		public IEnumerable<ITaskItem> GetAdditionalItemsToBeCopied ()
		{
			// ShouldCopyToBuildServer only works with files, and ditto can take directories (and that's why we use ditto often).
			// So here we must enumerate all the items inside the source directory.
			var dir = Source.ItemSpec;
			if (!Directory.Exists (dir))
				return Enumerable.Empty<ITaskItem> ();
			return Directory.EnumerateFiles (dir, "*", SearchOption.TopDirectoryOnly).Select (v => new TaskItem (v));
		}

		public bool ShouldCopyToBuildServer (ITaskItem item) => true;

		public bool ShouldCreateOutputFile (ITaskItem item)
		{
			var fileExtension = Path.GetExtension (item.ItemSpec);

			return fileExtension != ".app" && fileExtension != ".appex";
		}
	}
}
