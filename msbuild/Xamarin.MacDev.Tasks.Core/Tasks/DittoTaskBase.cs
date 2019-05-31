using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Bundler;

namespace Xamarin.MacDev.Tasks
{
	public abstract class DittoTaskBase : Task
	{
		#region Inputs

		public string SessionId { get; set; }

		[Required]
		public ITaskItem Source { get; set; }

		[Required]
		[Output]
		public ITaskItem Destination { get; set; }

		[Output]
		public ITaskItem[] CopiedFiles { get; set; }

		public ITaskItem ToolExe { get; set; }
		public ITaskItem ToolPath { get; set; }

		#endregion

		public override bool Execute ()
		{
			var src = Path.GetFullPath (Source.ItemSpec);
			var dst = Path.GetFullPath (Destination.ItemSpec);

			if (File.Exists (src)) {
				Log.LogMessage ("Copying file from {0} to {1}: {2}", src, dst, Directory.Exists (dst));
				if (Directory.Exists (dst))
					dst = Path.Combine (dst, Path.GetFileName (src));
				Log.LogMessage ("Copying file from {0} to {1}", src, dst);

				if (!FileCopier.IsUptodate (src, dst, check_stamp: false)) {
					files_copied.Add (dst);
					Log.LogMessage ("Copied {0} to {1}", src, dst);
				} else {
					Log.LogMessage ("Target '{0}' is up-to-date", dst);
				}

			} else if (Directory.Exists (src)) {
				dst = Path.GetDirectoryName (dst);

				Log.LogMessage ("Copying directory from {0} to {1}", src, dst);

				FileCopier.UpdateDirectory (src, dst, CopyFileCallback);
			} else {
				Log.LogError ("Could not find the source location {0}", src);
			}

			var copiedFiles = new List<ITaskItem> ();
			foreach (var file in files_copied) {
				copiedFiles.Add (new TaskItem (file));
				Log.LogMessage ($"Copied: {file}");
			}

			return !Log.HasLoggedErrors;
		}

		List<string> files_copied = new List<string> ();

		CopyFileResult CopyFileCallback (CopyFileWhat what, CopyFileStep stage, IntPtr state, string source, string target, IntPtr ctx)
		{
			//Console.WriteLine ("CopyFileCallback ({0}, {1}, 0x{2}, {3}, {4}, 0x{5})", what, stage, state.ToString ("x"), source, target, ctx.ToString ("x"));
			switch (what) {
			case CopyFileWhat.File:
				if (!FileCopier.IsUptodate (source, target, check_stamp: false)) {
					if (stage == CopyFileStep.Start)
						Log.LogMessage ("Copying {0} to {1}", source, target);
					return CopyFileResult.Continue;
				} else {
					if (stage == CopyFileStep.Start)
						Log.LogMessage ("Target '{0}' is up-to-date", target);
					return CopyFileResult.Skip;
				}
			case CopyFileWhat.Error:
				Log.LogError ("Could not copy the file '{0}' to '{1}': {2}", source, target, FileCopier.strerror (Marshal.GetLastWin32Error ()));
				return CopyFileResult.Quit;
			case CopyFileWhat.Dir:
			case CopyFileWhat.DirCleanup:
			case CopyFileWhat.CopyData:
			case CopyFileWhat.CopyXattr:
			default:
				return CopyFileResult.Continue;
			}
		}
	}
}
