using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Build;
using Xamarin.Utils;

#nullable enable

namespace Xamarin.Utils {
	using System.Text;

	class NoWriter : TextWriter {
		TaskLoggingHelper helper;
		public override Encoding Encoding => Encoding.UTF8;

		public NoWriter (TaskLoggingHelper helper)
		{
			this.helper = helper;
		}

		bool errorShown;

		void ShowError ()
		{
			if (errorShown)
				return;
			errorShown = true;
			// TODO: change to LogError
			helper.LogWarning ($"Console.Standard[Output|Error] accessed!", 
				$"Console.Standard[Output|Error] should not be used in tasks, as it can cause deadlocks and other issues. Please use the TaskLoggingHelper to log messages instead.");
			helper.LogWarning ($"Stack trace: {Environment.StackTrace}");
		}

		public override void Write (char value)
		{
			ShowError ();
			helper.LogMessage (MessageImportance.Low, value.ToString ());
		}

		public override void Write (char [] buffer, int index, int count)
		{
			ShowError ();
			helper.LogMessage (MessageImportance.Low, new string (buffer, index, count));
		}

		public override void Write (string? value)
		{
			ShowError ();
			helper.LogMessage (MessageImportance.Low, value ?? string.Empty);
		}

		public override void WriteLine ()
		{
			ShowError ();
		}

		public override void WriteLine (string? value)
		{
			ShowError ();
			helper.LogMessage (MessageImportance.Low, value ?? string.Empty);
		}
	}

	static class MSBuildUtils
	{		
		public static void EnsureNoCWL (TaskLoggingHelper log)
		{
			Console.SetOut (new NoWriter (log));
			Console.SetError (new NoWriter (log));
		}
	}
}

namespace Xamarin.MacDev.Tasks {
	public class PrepareAssemblies : XamarinTask {
		const string ErrorPrefix = "AP";

		#region Inputs
		[Required]
		public ITaskItem [] InputAssemblies { get; set; } = [];

		public string MakeReproPath { get; set; } = "";

		public string OutputDirectory { get; set; } = "";

		[Required]
		public ITaskItem? OptionsFile { get; set; }
		#endregion

		#region Outputs
		[Output]
		public ITaskItem [] OutputAssemblies { get; set; } = [];
		#endregion

		Dictionary<AssemblyPreparerInfo, ITaskItem> map = new ();

		AssemblyPreparerInfo GetAssemblyInfo (ITaskItem item)
		{
			var inputPath = item.ItemSpec;
			var outputPath = Path.Combine (OutputDirectory, Path.GetFileName (inputPath));
			var rv = new AssemblyPreparerInfo (inputPath, outputPath);
			map [rv] = item;
			return rv;
		}

		public override bool Execute ()
		{
			MSBuildUtils.EnsureNoCWL (Log);

			try {
				var infos = InputAssemblies.Select (GetAssemblyInfo).ToArray ();
				using var preparer = new AssemblyPreparer (infos, OptionsFile?.ItemSpec ?? "");
				preparer.MakeReproPath = MakeReproPath;
				var rv = preparer.Prepare (out var exceptions);

				foreach (var pe in exceptions) {
					if (pe.Error) {
						Log.LogError (null, $"{ErrorPrefix}{pe.Code}", null, pe.FileName ?? "MSBuild", 0, 0, 0, 0, message: pe.Message);
						Exception? ie = pe.InnerException;
						while (ie is not null) {
							Log.LogMessage (MessageImportance.Low, "Inner exception: {0}\n{1}", ie.Message, ie.StackTrace);
							ie = ie.InnerException;
						}
					} else {
						Log.LogWarning (null, $"{ErrorPrefix}{pe.Code}", null, pe.FileName ?? "MSBuild", 0, 0, 0, 0, message: pe.Message);
					}
				}

				OutputAssemblies = preparer.Assemblies.Select (v => {
					var item = map [v];
					item.ItemSpec = v.OutputPath;
					item.SetMetadata ("BeforePrepareAssembliesPath", v.InputPath);
					return item;
				}).ToArray ();
				return rv && !Log.HasLoggedErrors;
			} catch (Exception e) {
				Log.LogError ("Unexpected error while preparing assemblies: {0}", e);
				Log.LogErrorFromException (e, true, true, null);
				return false;
			}
		}
	}
}
