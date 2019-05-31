using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

		// Files or directories in the destination which are ignored.
		// Must be relative paths.
		// Only considered if Source is a directory.
		public ITaskItem[] Ignore { get; set; }

		[Output]
		public ITaskItem[] CopiedFiles { get; set; }

		[Output]
		public bool AnyCopiedFiles { get; set; }

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
					File.Copy (src, dst, true);
					files_copied.Add (dst);
					Log.LogMessage ("Copied {0} to {1}", src, dst);
				} else {
					files_skipped.Add (dst);
					Log.LogMessage ("Target '{0}' is up-to-date", dst);
				}

			} else if (Directory.Exists (src)) {

				Log.LogMessage ("Copying directory from {0} to {1}", src, dst);

				//dst = Path.GetDirectoryName (dst);
				//FileCopier.UpdateDirectory (src, dst, CopyFileCallback);
				UpdateDirectory (src, dst);
			} else {
				Log.LogError ("Could not find the source location {0}", src);
			}

			var copiedFiles = new List<ITaskItem> ();
			foreach (var file in files_copied) {
				copiedFiles.Add (new TaskItem (file));
				Log.LogMessage ($"Copied: {file}: target: {new FileInfo (file).LastWriteTimeUtc}");
			}
			foreach (var file in files_skipped)
				Log.LogMessage ($"Skipped: {file}: {new FileInfo (file).LastWriteTimeUtc}");

			AnyCopiedFiles = files_copied.Count > 0;

			return !Log.HasLoggedErrors;
		}

		List<string> files_copied = new List<string> ();
		List<string> files_skipped = new List<string> ();
		List<string> files_deleted = new List<string> ();


		void UpdateDirectory (string source, string destination)
		{
			var isDirty = false;

			source = source.TrimEnd (Path.DirectorySeparatorChar);
			destination = destination.TrimEnd (Path.DirectorySeparatorChar);

			var src = Directory.GetFileSystemEntries (source, "*", SearchOption.AllDirectories);
			var dst = new List<string> ();
			foreach (var s in src)
				dst.Add (destination + s.Substring (source.Length));

			// Delete any existing files or directories that aren't in the input
			if (Directory.Exists (destination)) {
				var ignored = Ignore != null ? new HashSet<string> (Ignore.Select ((v) => v.ItemSpec)) : null;
				var ignoredDirectories = ignored?.Where ((v) => Directory.Exists (Path.Combine (destination, v))).Select ((v) => v + Path.DirectorySeparatorChar);
				var existingFiles = Directory.GetFileSystemEntries (destination);
				foreach (var file in existingFiles) {
					if (dst.Contains (file))
						continue;

					if (ignored != null) {
						var relativePath = file.Substring (destination.Length + 1);
						if (ignored.Contains (relativePath)) {
							Console.WriteLine ($"The file or directory {file} exists in the destination, but will be ignored.");
							continue;
						}
						var ignoredContainer = ignoredDirectories.FirstOrDefault ((v) => relativePath.StartsWith (v, StringComparison.Ordinal));
						if (ignoredContainer != null) {
							Console.WriteLine ($"The file or directory {file} exists in the destination, but will be ignored because the containing directory '{ignoredContainer}' is ignored.");
							continue;
						}
					}

					if (File.Exists (file)) {
						Console.WriteLine ($"Deleting file {file}");
						File.Delete (file);
					} else {
						Console.WriteLine ($"Deleting directory {file}");
						Directory.Delete (file, true);
					}
					isDirty = true;
					files_deleted.Add (file);
				}
			}

			// Copy (clone) existing files
			for (var i = 0; i < src.Length; i++) {
				var s = src [i];
				var d = dst [i];
				if (Directory.Exists (s)) { // If the source is a directory
					if (Directory.Exists (d)) {
						Log.LogMessage ("Target '{0}' is up-to-date", d);
					} else {
						if (File.Exists (d)) // If target is a file
							File.Delete (d);
						Directory.CreateDirectory (d);
						isDirty = true;
					}
				} else if (FileCopier.IsUptodate (s, d, check_stamp: false)) {
					Log.LogMessage ("Target '{0}' is up-to-date", d);
					files_skipped.Add (d);
				} else {
					isDirty = true;
					files_copied.Add (d);
					Directory.CreateDirectory (Path.GetDirectoryName (d));
					File.Copy (s, d, true);
					Log.LogMessage ($"Copied: {s} to {d}: target's timestamp: {new FileInfo (d).LastWriteTimeUtc}");
				}
			}
			Console.WriteLine ("IsDirty: {0}", isDirty);
		}

		CopyFileResult CopyFileCallback (CopyFileWhat what, CopyFileStep stage, IntPtr state, string source, string target, IntPtr ctx)
		{
			Console.WriteLine ("CopyFileCallback ({0}, {1}, 0x{2}, {3}, {4}, 0x{5}) src: {6} tgt: {7}", what, stage, state.ToString ("x"), source, target, ctx.ToString ("x"), new FileInfo (source).LastWriteTimeUtc, new FileInfo (target).LastWriteTimeUtc);

			switch (what) {
			case CopyFileWhat.File:
				if (stage == CopyFileStep.Start) {
					if (FileCopier.IsUptodate (source, target, check_stamp: false)) {
						files_skipped.Add (target);
						Log.LogMessage ("Target '{0}' is up-to-date", target);
						return CopyFileResult.Skip;
					}
					files_copied.Add (target);
					if (File.Exists (target))
						File.Delete (target);
					Log.LogMessage ("Copying {0} to {1}", source, target);
				} else if (stage == CopyFileStep.Err) {
					Log.LogMessage ("Copying {0} to {1} FAILEEEEEED!!! errno: {2}", source, target, Marshal.GetLastWin32Error ());
					return CopyFileResult.Quit;
				}
				return CopyFileResult.Continue;
			case CopyFileWhat.Error:
				Log.LogError ("Could not copy the file '{0}' to '{1}': {2}", source, target, FileCopier.strerror (Marshal.GetLastWin32Error ()));
				return CopyFileResult.Quit;
			case CopyFileWhat.Dir:
			case CopyFileWhat.DirCleanup:
			case CopyFileWhat.CopyData:
			case CopyFileWhat.CopyXattr:
			default:
				if (stage == CopyFileStep.Err)
					return CopyFileResult.Quit;
				return CopyFileResult.Continue;
			}
		}
	}
}
