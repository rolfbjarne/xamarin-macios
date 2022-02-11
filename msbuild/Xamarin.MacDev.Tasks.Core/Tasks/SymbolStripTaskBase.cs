using System;
using System.IO;
using System.Collections.Generic;

using Parallel = System.Threading.Tasks.Parallel;
using ParallelOptions = System.Threading.Tasks.ParallelOptions;

using Microsoft.Build.Framework;

#nullable enable

namespace Xamarin.MacDev.Tasks
{
	public abstract class SymbolStripTaskBase : XamarinTask
	{
		#region Inputs

		[Required]
		public ITaskItem[] Executable { get; set; } = Array.Empty<ITaskItem> ();

		public string SymbolFile { get; set; } = string.Empty;

		public bool IsFramework { get; set; }

		// the executable is a relative path to this directory
		[Required]
		public string OutputDirectory { get; set; } = string.Empty;
		#endregion

		string GetSymbolFile (ITaskItem item)
		{
			return GetNonEmptyStringOrFallback (item, "SymbolFile", SymbolFile);
		}

		bool GetIsFramework (ITaskItem item)
		{
			var value = GetNonEmptyStringOrFallback (item, "IsFramework", IsFramework ? "true" : "false", required: true);
			return string.Equals (value, "true", StringComparison.OrdinalIgnoreCase);
		}

		void ExecuteStrip (ITaskItem item)
		{
			var args = new List<string> ();

			args.Add ("strip");

			var symbolFile = GetSymbolFile (item);
			if (!string.IsNullOrEmpty (symbolFile)) {
				args.Add ("-i");
				args.Add ("-s");
				args.Add (symbolFile);
			}

			if (GetIsFramework (item)) {
				// Only remove debug symbols from frameworks.
				args.Add ("-S");
				args.Add ("-x");
			}

			var outputDirectory = GetNonEmptyStringOrFallback (item, "OutputDirectory", OutputDirectory, required: true);
			args.Add (Path.GetFullPath (Path.Combine (outputDirectory, item.ItemSpec)));

			ExecuteAsync ("xcrun", args).Wait ();
		}

		public override bool Execute ()
		{
			Parallel.ForEach (Executable, new ParallelOptions { MaxDegreeOfParallelism = Math.Max (Environment.ProcessorCount / 2, 1) }, (item) => {
				ExecuteStrip (item);
			});

			return !Log.HasLoggedErrors;
		}
	}
}
