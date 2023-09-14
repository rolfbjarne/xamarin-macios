using System;
using System.Collections.Generic;
using System.IO;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks {
	public abstract class ZipTaskBase : XamarinTask {
		#region Inputs

		[Output]
		[Required]
		public ITaskItem OutputFile { get; set; }

		[Required]
		public ITaskItem [] Sources { get; set; }

		[Required]
		public ITaskItem WorkingDirectory { get; set; }

		#endregion

		public override bool Execute ()
		{
			var zip = OutputFile.GetMetadata ("FullPath");
			var workingDirectory = WorkingDirectory.GetMetadata ("FullPath");
			var sources = new List<string> ();
			for (int i = 0; i < Sources.Length; i++) {
				var relative = PathUtils.AbsoluteToRelative (workingDirectory, Sources [i].GetMetadata ("FullPath"));
				sources.Add (relative);
			}

			if (!CompressionHelper.TryCompress (this.Log, zip, sources, false, workingDirectory, false))
				return false;

			return !Log.HasLoggedErrors;
		}
	}
}
