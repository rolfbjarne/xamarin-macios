using System;
using System.Collections.Generic;
using System.IO;

using Microsoft.Build.Framework;

using Xamarin.Localization.MSBuild;
using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks {
	public abstract class MergeAppBundlesTaskBase : XamarinTask {

		#region Inputs
		[Required]
		public ITaskItem [] InputAppBundles { get; set; }

		[Required]
		public string OutputAppBundle { get; set; }
		#endregion

		public override bool Execute ()
		{
			return !Log.HasLoggedErrors;
		}
	}
}

