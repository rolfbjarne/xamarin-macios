using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;

using Xamarin.Localization.MSBuild;
using Xamarin.Messaging.Build.Client;
using Xamarin.Utils;

// Disable until we get around to enable + fix any issues.
#nullable disable

namespace Xamarin.MacDev.Tasks {
	public class OptimizeImage : XamarinTask, ITaskCallback {
		#region Inputs

		[Required]
		public ITaskItem [] InputImages { get; set; }

		[Required]
		[Output]
		public ITaskItem [] OutputImages { get; set; }

		[Required]
		public string SdkDevPath { get; set; }

		#endregion

		static List<string> GenerateCommandLineCommands (string inputImage, string outputImage)
		{
			var args = new List<string> ();

			args.Add ("pngcrush");
			args.Add ("-q");
			args.Add ("-iphone");
			args.Add ("-f");
			args.Add ("0");
			args.Add (inputImage);
			args.Add (outputImage);

			return args;
		}

		void LogEventsFromTextOutput (string singleLine, string inputImage, MessageImportance messageImportance)
		{
			var tokens = singleLine.Split (new [] { ':' }, 2);

			if (tokens.Length == 2 && tokens [0].StartsWith ("libpng ", StringComparison.Ordinal)) {
				var type = tokens [0].Substring ("libpng ".Length).Trim ();

				switch (type) {
				case "warning":
					Log.LogWarning (null, null, null, inputImage, 0, 0, 0, 0, "{0}", tokens [1].Trim ());
					break;
				case "error":
					Log.LogError (null, null, null, inputImage, 0, 0, 0, 0, "{0}", tokens [1].Trim ());
					break;
				default:
					Log.LogError (null, null, null, inputImage, 0, 0, 0, 0, "{0}", singleLine);
					break;
				}
			} else {
				Log.LogMessage (messageImportance, "{0}", singleLine);
			}
		}

		public override bool Execute ()
		{
			if (ShouldExecuteRemotely ())
				return new TaskRunner (SessionId, BuildEngine4).RunAsync (this).Result;

			var listOfArguments = new List<(List<string> Arguments, string Input)> ();
			for (var index = 0; index < this.InputImages.Length && index < this.OutputImages.Length; index++) {
				var inputImage = this.InputImages [index].ItemSpec;
				var outputImage = this.OutputImages [index].ItemSpec;

				Directory.CreateDirectory (Path.GetDirectoryName (outputImage));

				var args = GenerateCommandLineCommands (inputImage, outputImage);
				listOfArguments.Add ((args, inputImage));
			}

			Parallel.ForEach (listOfArguments, (arg) => {
				ExecuteAsync ("xcrun", arg.Arguments, sdkDevPath: SdkDevPath, mergeOutput: true, showErrorIfFailure: false /* we show our own error below */)
					.ContinueWith ((v) => {
						Execution execution = v.Result;
						if (execution.ExitCode != 0)
							Log.LogError (MSBStrings.E7120 /* Failed to optimize the image {0}, pngcrush exited with code {1}. */, Path.GetFileName (arg.Input), execution.ExitCode);

						foreach (var line in execution.StandardOutput.ToString ().Split ('\n')) {
							LogEventsFromTextOutput (line, arg.Input, MessageImportance.Normal);
						}

						return System.Threading.Tasks.Task.FromResult<Execution> (execution);
					})
					.Unwrap ()
					.Wait ();
			});

			return !Log.HasLoggedErrors;
		}

		public bool ShouldCopyToBuildServer (ITaskItem item) => !OutputImages.Contains (item);

		public bool ShouldCreateOutputFile (ITaskItem item) => true;

		public IEnumerable<ITaskItem> GetAdditionalItemsToBeCopied () => Enumerable.Empty<ITaskItem> ();

		public void Cancel ()
		{
			if (!string.IsNullOrEmpty (SessionId))
				BuildConnection.CancelAsync (BuildEngine4).Wait ();
		}
	}
}
