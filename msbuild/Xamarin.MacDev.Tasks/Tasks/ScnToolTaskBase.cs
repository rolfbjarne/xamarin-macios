using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;

using Xamarin.Messaging.Build.Client;
using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks {
	public class ScnTool : XamarinTask {
		#region Inputs

		[Required]
		public string IntermediateOutputPath { get; set; } = string.Empty;

		[Required]
		public ITaskItem[] ColladaAssets { get; set; } = Array.Empty<ITaskItem> ();

		[Required]
		public string DeviceSpecificIntermediateOutputPath { get; set; } = string.Empty;

		public bool IsWatchApp { get; set; }

		[Required]
		public string SdkPlatform { get; set; } = string.Empty;

		[Required]
		public string SdkRoot { get; set; } = string.Empty;

		[Required]
		public string SdkVersion { get; set; } = string.Empty;

		[Required]
		public string SdkDevPath { get; set; } = string.Empty;

		#endregion

#region Outputs
		[Output]
		public ITaskItem[] BundleResources { get; set; } = Array.Empty<ITaskItem> ();
#endregion

		IList<string> GenerateCommandLineCommands (string inputScene, string outputScene)
		{
			var args = new List<string> ();

			args.Add ("scntool");
			args.Add ("--compress");
			args.Add (inputScene);
			args.Add ("-o");
			args.Add (outputScene);
			args.Add ($"--sdk-root={SdkRoot}");
			args.Add ($"--target-build-dir={IntermediateOutputPath}");
			if (AppleSdkSettings.XcodeVersion.Major >= 13) {
				// I'm not sure which Xcode version these options are available in, but it's at least Xcode 13+
				args.Add ($"--target-version={SdkVersion}");
				args.Add ($"--target-platform={PlatformUtils.GetTargetPlatform (SdkPlatform, IsWatchApp)}");
			} else {
				args.Add ($"--target-version-{PlatformFrameworkHelper.GetOperatingSystem (TargetFrameworkMoniker)}={SdkVersion}");
			}

			return args;
		}

		public override bool Execute ()
		{
			if (ShouldExecuteRemotely ())
				return new TaskRunner (SessionId, BuildEngine4).RunAsync (this).Result;

			var listOfArguments = new List<(IList<string> Arguments, ITaskItem Input)> ();
			var bundleResources = new List<ITaskItem> ();
			foreach (var asset in ColladaAssets) {
				var inputScene = asset.ItemSpec;
				var outputScene = Path.Combine (DeviceSpecificIntermediateOutputPath, asset.GetMetadata ("LogicalName"));
				var args = GenerateCommandLineCommands (inputScene, outputScene);
				listOfArguments.Add (new (args, asset));

				Directory.CreateDirectory (Path.GetDirectoryName (outputScene));

				var bundleResource = new TaskItem (outputScene);
				asset.CopyMetadataTo (bundleResource);
				bundleResource.SetMetadata ("Optimize", "false");
				bundleResources.Add (bundleResource);
			}

			Parallel.ForEach (listOfArguments, (arg) => {
				ExecuteAsync ("xcrun", arg.Arguments, sdkDevPath: SdkDevPath).Wait ();
			});

			BundleResources = bundleResources.ToArray ();

			return !Log.HasLoggedErrors;
		}

		public void Cancel ()
		{
			if (ShouldExecuteRemotely ())
				BuildConnection.CancelAsync (BuildEngine4).Wait ();
		}
	}
}
