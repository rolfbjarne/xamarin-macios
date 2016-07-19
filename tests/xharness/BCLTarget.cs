using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace xharness
{
	public class BCLTarget
	{
		public Harness Harness;
		public string MonoPath; // MONO_PATH
		public string WatchMonoPath; // WATCH_MONO_PATH
		public string TestName;

		static readonly Dictionary<string, string[]> ignored_tests =  new Dictionary<string, string[]> { 
			{ "Microsoft.Win32", null },
			{ "System.Diagnostics.Contracts", null },
			{ "System.Runtime.Remoting", null },
			{ "System.Security.AccessControl", null },
			{ "System.Security.Permissions", null },
			{ "System.Security.Policy", null },
			{ "System.Reflection.Emit", null },
			// System
			{ "System.CodeDom", null },
			{ "System.Configuration", null },
			{ "System.IO.Ports", null },
			{ "System.Web", new [] { "System_test.dll.sources" } },
			{ "Microsoft.CSharp", null },
			{ "Microsoft.VisualBasic", null },
			// System.Core
			{ "System.IO.Pipes", null },
			// System.Data
			{ "System.Data.Odbc", null },
			{ "System.Data.OleDb", null },
			// System.Web.Services
			{ "System.Web.Services.Configuration", null }
		};

		public BCLTarget ()
		{
		}

		void Process (string test_sources, IEnumerable<string> test_files, string condition, StringBuilder [] sb)
		{
			test_files = test_files.Where ((v) => !string.IsNullOrEmpty (v));

			var split_count = sb.Length;
			var files_path = Path.GetDirectoryName (test_sources).Replace ("/", "\\");
			var test_dirs = test_files.Select ((arg) =>
			{
				return Path.GetDirectoryName (arg);
			}).Distinct ().OrderBy ((dir) => dir).ToArray ();
			var split_dirs = new HashSet<string> [split_count];
			var consumed_count = 0;
			for (int i = 0; i < split_count; i++) {
				split_dirs [i] = new HashSet<string> (test_dirs.Skip (consumed_count).Take (test_dirs.Count () / split_count));
				consumed_count += split_dirs [i].Count;
			}
			// Hardcode some stuff to make sure 
			var concurrent = split_dirs.FirstOrDefault ((v) => v.Contains ("System.Collections.Concurrent"));
			if (concurrent != null) {
				foreach (var dirs in split_dirs) {
					if (concurrent == dirs) {
						dirs.Add ("System.Threading");
						dirs.Add ("System.Threading.Tasks");
					} else {
						dirs.Remove ("System.Threading");
						dirs.Remove ("System.Threading.Tasks");
					}
				}
			}
			for (int i = 0; i < split_count; i++) {
				foreach (var d in split_dirs [i])
					Console.WriteLine ("#{0}: {1}", i, d);
			}
			foreach (var s in test_files) {
				if (string.IsNullOrEmpty (s))
					continue;

				if (IsNotSupported (test_sources, s))
					continue;

				var dir = Path.GetDirectoryName (s);
				var idx = Array.FindIndex (split_dirs, (v) => v.Contains (dir));

				//Console.WriteLine ("IDX: {0} for {1}", idx, s);

				sb [idx].AppendFormat ("    <Compile Include=\"{0}\\Test\\{1}\" Condition=\"{2}\">\r\n", files_path, s.Replace ("/", "\\").Trim (), condition);

				var link_path = Path.GetDirectoryName (s);
				if (string.IsNullOrEmpty (link_path) || link_path [0] == '.')
					sb [idx].AppendFormat ("      <Link>{0}</Link>\r\n", Path.GetFileName (s));
				else
					sb [idx].AppendFormat ("      <Link>{0}\\{1}</Link>\r\n", link_path, Path.GetFileName (s));

				sb [idx].AppendFormat ("    </Compile>\r\n");
			}
		}

		public void Convert ()
		{
			var testName = TestName == "mscorlib" ? "corlib" : TestName;
			var main_test_sources = Path.Combine (MonoPath, "mcs", "class", testName, testName + "_test.dll.sources");
			var main_test_files = File.ReadAllLines (main_test_sources);
			var watch_test_sources = Path.Combine (WatchMonoPath, "mcs", "class", testName, testName + "_test.dll.sources");
			var watch_test_files = File.ReadAllLines (watch_test_sources).Where ((arg) => !string.IsNullOrEmpty (arg));
			var template_path = Path.Combine (Harness.RootDirectory, "bcl-test", TestName, TestName + ".csproj.template");
			var csproj_input = File.ReadAllText (template_path);
			var project_path = Path.Combine (Harness.RootDirectory, "bcl-test", TestName, TestName + ".csproj");
			var csproj_output = project_path;

			var split_count = testName == "corlib" ? 2 : 1;
			var sb = new StringBuilder [split_count];
			for (int i = 0; i < split_count; i++)
				sb [i] = new StringBuilder ();

			Process (main_test_sources, main_test_files, "'$(TargetFrameworkIdentifier)' == 'MonoTouch' Or '$(TargetFrameworkIdentifier)' == 'Xamarin.iOS' Or '$(TargetFrameworkIdentifier)' == 'Xamarin.TVOS'", sb);
			Process (watch_test_sources, watch_test_files, "'$(TargetFrameworkIdentifier)' == 'Xamarin.WatchOS'", sb);

			if (split_count > 1) {
				var split_template = File.ReadAllText (Path.Combine (Harness.RootDirectory, "bcl-test", TestName, TestName + "-split.csproj.template"));
				for (int i = 0; i < split_count; i++) {
					var split_output = Path.Combine (Harness.RootDirectory, "bcl-test", TestName, TestName + "-" + i + ".csproj");
					Harness.Save (split_template.Replace ("#SPLIT#", (i + 1).ToString ()).Replace ("#FILES#", sb [i].ToString ()), split_output);
				}
				Harness.Save (csproj_input.Replace ("#FILES#", string.Empty), csproj_output);
			} else {
				Harness.Save (csproj_input.Replace ("#FILES#", sb [0].ToString ()), csproj_output);
			}
		}

		bool IsNotSupported (string sourcesFile, string path)
		{
			foreach (var p in ignored_tests) {
				if (path.Contains (p.Key)) {
					if (p.Value == null)
						return true;

					foreach (var assembly in p.Value) {
						if (sourcesFile.Contains (Path.DirectorySeparatorChar + assembly))
							return true;
					}
				}
			}

			return false;
		}
	}
}
