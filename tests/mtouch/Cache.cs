using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace Xamarin
{
	public class Cache : IDisposable
	{
		static string root_cache_directory;

		List<string> directories_to_delete = new List<string> ();


		static Cache ()
		{
			root_cache_directory = Path.Combine (Path.GetDirectoryName (System.Reflection.Assembly.GetExecutingAssembly ().Location), "tmp-test-dir");
			if (Directory.Exists (root_cache_directory))
				Directory.Delete (root_cache_directory, true);
			Directory.CreateDirectory (root_cache_directory);
		}


		[DllImport ("libc", SetLastError = true)]
		static extern int mkdir (string path, ushort mode);

		public string CreateTemporaryDirectory ()
		{
			var calling_method = new System.Diagnostics.StackFrame (1).GetMethod ();
			string name;

			if (calling_method != null) {
				name = calling_method.DeclaringType.FullName + "." + calling_method.Name;
			} else {
				name = "unknown-test";
			}

			var rv = Path.Combine (root_cache_directory, name);
			for (int i = 0; i < 10000; i++) {
				if (mkdir (rv, Convert.ToUInt16 ("777", 8)) == 0) {
					directories_to_delete.Add (rv);
					Console.WriteLine ("Created tmp dir: {0}", rv);
					return rv;
				}
				rv = Path.Combine (root_cache_directory, name + "_" + i);
			}

			throw new Exception ("Could not create temporary directory");
		}

		public void Dispose ()
		{
			//if (directories_to_delete != null) {
			//	foreach (var dir in directories_to_delete)
			//		Directory.Delete (dir, true);
			//}
		}
	}
}
