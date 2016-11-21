using System;
using System.Collections.Generic;
using System.IO;

namespace Xamarin
{
	public class Cache : IDisposable
	{
		List<string> directories_to_delete = new List<string> ();

		public string CreateTemporaryDirectory ()
		{
			var tmpDir = MTouch.GetTempDirectory ();
			directories_to_delete.Add (tmpDir);
			return tmpDir;
		}

		public void Dispose ()
		{
			if (directories_to_delete != null) {
				foreach (var dir in directories_to_delete)
					Directory.Delete (dir, true);
			}
		}
	}
}
