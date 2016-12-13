using System;
using System.IO;

namespace xharness
{
	public class TestProject
	{
		public string Path;
		public bool IsExecutableProject;
		public bool GenerateVariations = true;

		public TestProject ()
		{
		}

		public TestProject (string path, bool isExecutableProject = true, bool generateVariations = true)
		{
			Path = path;
			IsExecutableProject = isExecutableProject;
			GenerateVariations = generateVariations;
		}

		public TestProject AsTvOSProject ()
		{
			var clone = Clone ();
			clone.Path = System.IO.Path.Combine (System.IO.Path.GetDirectoryName (Path), System.IO.Path.GetFileNameWithoutExtension (Path) + "-tvos" + System.IO.Path.GetExtension (Path));
			return clone;
		}

		public TestProject AsWatchOSProject ()
		{
			var clone = Clone ();
			clone.Path = System.IO.Path.Combine (System.IO.Path.GetDirectoryName (Path), System.IO.Path.GetFileNameWithoutExtension (Path) + "-watchos" + System.IO.Path.GetExtension (Path));
			return clone;
		}

		public bool IsBclTest {
			get {
				return Path.Contains ("bcl-test");
			}
		}

		protected virtual TestProject Clone ()
		{
			return new TestProject ()
			{
				Path = Path,
				IsExecutableProject = IsExecutableProject,
				GenerateVariations = GenerateVariations,
			};
		}
	}

	public class MacTestProject : TestProject
	{
		public bool SkipXMVariations;

		public MacTestProject () : base ()
		{
		}

		public MacTestProject (string path, bool isExecutableProject = true, bool generateVariations = true, bool skipXMVariations = false) : base (path, isExecutableProject, generateVariations)
		{
			SkipXMVariations = skipXMVariations;
		}
	}
}

