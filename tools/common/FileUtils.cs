using System;
using System.Collections.Generic;
using System.IO;

using Xamarin.Bundler;

using Logger = Xamarin.Bundler.Driver;

namespace Xamarin.Utils {
	public static class FileUtils {
		public static void TryDelete (string path)
		{
			try {
				if (File.Exists (path))
					File.Delete (path);
			} catch {
			}
		}

		static void FileMove (string source, string target)
		{
			TryDelete (target);
			File.Move (source, target);
		}

		static void MoveIfDifferent (string path, string tmp, bool use_stamp = false)
		{
			// Don't read the entire file into memory, it can be quite big in certain cases.

			bool move = false;

			using (var fs1 = new FileStream (path, FileMode.Open, FileAccess.Read)) {
				using (var fs2 = new FileStream (tmp, FileMode.Open, FileAccess.Read)) {
					if (fs1.Length != fs2.Length) {
						Logger.Log (3, "New file '{0}' has different length, writing new file.", path);
						move = true;
					} else {
						move = !CompareStreams (fs1, fs2);
					}
				}
			}

			if (move) {
				FileMove (tmp, path);
			} else {
				Logger.Log (3, "Target {0} is up-to-date.", path);
				if (use_stamp)
					Touch (path + ".stamp");
			}
		}

		public static void WriteIfDifferent (string path, string contents, bool use_stamp = false)
		{
			var tmp = path + ".tmp";

			try {
				if (!File.Exists (path)) {
					Directory.CreateDirectory (Path.GetDirectoryName (path));
					File.WriteAllText (path, contents);
					Logger.Log (3, "File '{0}' does not exist, creating it.", path);
					return;
				}

				File.WriteAllText (tmp, contents);
				MoveIfDifferent (path, tmp, use_stamp);
			} catch (Exception e) {
				File.WriteAllText (path, contents);
				ErrorHelper.Warning (1014, e, Errors.MT1014, path, e.Message);
			} finally {
				TryDelete (tmp);
			}
		}

		public static void WriteIfDifferent (string path, byte [] contents, bool use_stamp = false)
		{
			var tmp = path + ".tmp";

			try {
				if (!File.Exists (path)) {
					File.WriteAllBytes (path, contents);
					Logger.Log (3, "File '{0}' does not exist, creating it.", path);
					return;
				}

				File.WriteAllBytes (tmp, contents);
				MoveIfDifferent (path, tmp, use_stamp);
			} catch (Exception e) {
				File.WriteAllBytes (path, contents);
				ErrorHelper.Warning (1014, e, Errors.MT1014, path, e.Message);
			} finally {
				TryDelete (tmp);
			}
		}

		public static void Touch (IEnumerable<string> filenames, DateTime? timestamp = null)
		{
			if (timestamp == null)
				timestamp = DateTime.Now;
			foreach (var filename in filenames) {
				try {
					var fi = new FileInfo (filename);
					if (!fi.Exists) {
						using (var fo = fi.OpenWrite ()) {
							// Create an empty file.
						}
					}
					fi.LastWriteTime = timestamp.Value;
				} catch (Exception e) {
					ErrorHelper.Warning (128, Errors.MT0128, filename, e.Message);
				}
			}
		}

		public static void Touch (params string [] filenames)
		{
			Touch ((IEnumerable<string>) filenames);
		}

		public unsafe static bool CompareStreams (Stream astream, Stream bstream)
		{
			if (astream.Length != bstream.Length) {
				Logger.Log (6, " > streams are considered different because their lengths do not match.");
				return false;
			}

			var ab = new byte [2048];
			var bb = new byte [2048];

			do {
				int ar = astream.Read (ab, 0, ab.Length);
				int br = bstream.Read (bb, 0, bb.Length);

				if (ar != br) {
					Logger.Log (6, " > streams are considered different because their read lengths do not match.");
					return false;
				}

				if (ar == 0)
					return true;

				fixed (byte* aptr = ab, bptr = bb) {
					long* l1 = (long*) aptr;
					long* l2 = (long*) bptr;
					int len = ar;
					// Compare one long at a time.
					for (int i = 0; i < len / 8; i++) {
						if (l1 [i] != l2 [i]) {
							Logger.Log (6, " > streams differ at index {0}-{1}", i, i + 8);
							return false;
						}
					}
					// Compare any remaining bytes.
					int mod = len % 8;
					if (mod > 0) {
						for (int i = len - mod; i < len; i++) {
							if (ab [i] != bb [i]) {
								Logger.Log (6, " > streams differ at byte index {0}", i);
								return false;
							}
						}
					}
				}
			} while (true);
		}
	}
}
