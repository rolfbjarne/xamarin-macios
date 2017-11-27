﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace xharness
{
	public class TestProject
	{
		XmlDocument xml;

		public string Path;
		public string SolutionPath;
		public string Name;
		public bool IsExecutableProject;
		public bool IsNUnitProject;
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

		public TestProject AsTodayExtensionProject ()
		{
			var clone = Clone ();
			clone.Path = System.IO.Path.Combine (System.IO.Path.GetDirectoryName (Path), System.IO.Path.GetFileNameWithoutExtension (Path) + "-today" + System.IO.Path.GetExtension (Path));
			return clone;
		}

		// Get the referenced today extension project (if any)
		public TestProject GetTodayExtension ()
		{
			var extensions = Xml.GetExtensionProjectReferences ().ToArray ();
			if (!extensions.Any ())
				return null;
			if (extensions.Count () != 1)
				throw new NotImplementedException ();
			return new TestProject
			{
				Path = System.IO.Path.GetFullPath (System.IO.Path.Combine (System.IO.Path.GetDirectoryName (Path), extensions.First ().Replace ('\\', '/'))),
			};
		}

		public XmlDocument Xml {
			get {
				if (xml == null) {
					xml = new XmlDocument ();
					xml.LoadWithoutNetworkAccess (Path);
				}
				return xml;
			}
		}

		public bool IsBclTest {
			get {
				return Path.Contains ("bcl-test");
			}
		}

		public virtual TestProject Clone ()
		{
			return new TestProject ()
			{
				Path = Path,
				IsExecutableProject = IsExecutableProject,
				GenerateVariations = GenerateVariations,
				Name = Name,
			};
		}

		internal async Task<TestProject> CreateCloneAsync (TestTask test)
		{
			var rv = Clone ();
			await rv.CreateCopyAsync (test);
			return rv;
		}

		internal async Task CreateCopyAsync (TestTask test)
		{
			var directory = Xamarin.Cache.CreateTemporaryDirectory (test.TestName);
			Directory.CreateDirectory (directory);
			var original_path = Path;
			Path = System.IO.Path.Combine (directory, System.IO.Path.GetFileName (Path));

			await Task.Yield ();

			XmlDocument doc;
			doc = new XmlDocument ();
			doc.LoadWithoutNetworkAccess (original_path);
			doc.ResolveAllPaths (original_path);

			foreach (var pr in doc.GetProjectReferences ()) {
				var tp = new TestProject (pr.Replace ('\\', '/'));
				await tp.CreateCopyAsync (test);
				doc.SetProjectReferenceInclude (pr, tp.Path.Replace ('/', '\\'));
			}

			doc.Save (Path);
		}

		public override string ToString()
		{
			return Name;
		}
	}

	public class iOSTestProject : TestProject
	{
		public bool SkipiOSVariation;
		public bool SkipwatchOSVariation;
		public bool SkiptvOSVariation;

		// Optional
		public BCLTestInfo BCLInfo { get; set; }

		public iOSTestProject ()
		{
		}

		public iOSTestProject (string path, bool isExecutableProject = true, bool generateVariations = true)
			: base (path, isExecutableProject, generateVariations)
		{
		}
	}

	public enum MacFlavors { All, Modern, Full }

	public class MacTestProject : TestProject
	{
		public MacFlavors TargetFrameworkFlavor;

		// Optional
		public MacBCLTestInfo BCLInfo { get; set; }

		public bool GenerateModern => TargetFrameworkFlavor == MacFlavors.All || TargetFrameworkFlavor == MacFlavors.Modern;
		public bool GenerateFull => TargetFrameworkFlavor == MacFlavors.All || TargetFrameworkFlavor == MacFlavors.Full;

		public string Platform = "x86";
		public string [] Configurations;

		public MacTestProject () : base ()
		{
		}

		public MacTestProject (string path, bool isExecutableProject = true, bool generateVariations = true, MacFlavors targetFrameworkFlavor = MacFlavors.All) : base (path, isExecutableProject, generateVariations)
		{
			TargetFrameworkFlavor = targetFrameworkFlavor;
		}
	}
}

