using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Messaging.Build.Client;
using Xamarin.Utils;

// Disable until we get around to enable + fix any issues.
#nullable disable

namespace Xamarin.MacDev.Tasks {
	public class Zip : XamarinToolTask2, ITaskCallback {
		#region Inputs

		[Output]
		[Required]
		public ITaskItem OutputFile { get; set; }

		public bool Recursive { get; set; }

		[Required]
		public ITaskItem [] Sources { get; set; }

		public bool Symlinks { get; set; }

		[Required]
		public ITaskItem WorkingDirectory { get; set; }

		#endregion

		protected override string ToolName {
			get { return "zip"; }
		}

		protected override string GenerateFullPathToTool ()
		{
			if (!string.IsNullOrEmpty (ToolPath))
				return Path.Combine (ToolPath, ToolExe);

			var path = Path.Combine ("/usr/bin", ToolExe);

			return File.Exists (path) ? path : ToolExe;
		}

		protected override string GetWorkingDirectory ()
		{
			return WorkingDirectory.GetMetadata ("FullPath");
		}

		protected override IList<string> GenerateCommandLineCommands ()
		{
			var args = new List<string> ();

			if (Recursive)
				args.Add ("-r");

			if (Symlinks)
				args.Add ("-y");

			args.Add (OutputFile.GetMetadata ("FullPath"));

			var root = WorkingDirectory.GetMetadata ("FullPath");
			for (int i = 0; i < Sources.Length; i++) {
				var relative = PathUtils.AbsoluteToRelative (root, Sources [i].GetMetadata ("FullPath"));
				args.Add (relative);
			}

			return args;
		}

		public override bool Execute ()
		{
			if (ShouldExecuteRemotely ()) {
				var taskRunner = new TaskRunner (SessionId, BuildEngine4);
				var rv = taskRunner.RunAsync (this).Result;

				// Copy the zipped file back to Windows.
				if (rv)
					taskRunner.GetFileAsync (this, OutputFile.ItemSpec).Wait ();

				return rv;
			}

			return base.Execute ();
		}

		public override void Cancel ()
		{
			if (ShouldExecuteRemotely ())
				BuildConnection.CancelAsync (BuildEngine4).Wait ();

			base.Cancel ();
		}

		public bool ShouldCopyToBuildServer (ITaskItem item) => false;

		public bool ShouldCreateOutputFile (ITaskItem item) => true;

		public IEnumerable<ITaskItem> GetAdditionalItemsToBeCopied () => Enumerable.Empty<ITaskItem> ();
	}
}
