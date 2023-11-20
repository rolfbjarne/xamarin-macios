using System;
using System.Collections.Generic;
using System.IO;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Messaging.Build.Client;

namespace Xamarin.MacDev.Tasks {
	public class SpotlightIndexer : XamarinToolTask2 {
		#region Inputs

		[Required]
		public string Input { get; set; } = string.Empty;

		#endregion

		protected override string ToolName {
			get { return "mdimport"; }
		}

		protected override string GenerateFullPathToTool ()
		{
			if (!string.IsNullOrEmpty (ToolPath))
				return Path.Combine (ToolPath, ToolExe);

			var path = Path.Combine ("/usr/bin", ToolExe);

			return File.Exists (path) ? path : ToolExe;
		}

		protected override IList<string> GenerateCommandLineCommands ()
		{
			var args = new List<string> ();

			args.Add (Input);

			return args;
		}

		public override bool Execute ()
		{
			if (ShouldExecuteRemotely ())
				return new TaskRunner (SessionId, BuildEngine4).RunAsync (this).Result;

			return base.Execute ();
		}

		public override void Cancel ()
		{
			if (ShouldExecuteRemotely ())
				BuildConnection.CancelAsync (BuildEngine4).Wait ();

			base.Execute ();
		}
	}
}
