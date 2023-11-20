using System;
using System.Collections.Generic;
using System.IO;

using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;

using Xamarin.Messaging.Build.Client;
using Xamarin.Utils;

// Disable until we get around to enable + fix any issues.
#nullable disable

namespace Xamarin.MacDev.Tasks {
	public class ScnTool : XamarinToolTask {
		string sdkDevPath;

		#region Inputs

		[Required]
		public string IntermediateOutputPath { get; set; }

		[Required]
		public string InputScene { get; set; }

		public bool IsWatchApp { get; set; }

		[Required]
		public string OutputScene { get; set; }

		[Required]
		public string SdkPlatform { get; set; }

		[Required]
		public string SdkRoot { get; set; }

		[Required]
		public string SdkVersion { get; set; }

		[Required]
		public string SdkDevPath {
			get { return sdkDevPath; }
			set {
				sdkDevPath = value;

				EnvironmentVariables ["DEVELOPER_DIR"] = sdkDevPath;
			}
		}

		#endregion

		string DevicePlatformBinDir {
			get { return Path.Combine (SdkDevPath, "usr", "bin"); }
		}

		protected virtual string OperatingSystem {
			get {
				return PlatformFrameworkHelper.GetOperatingSystem (TargetFrameworkMoniker);
			}
		}

		protected override string ToolName {
			get { return "scntool"; }
		}

		protected override string GenerateFullPathToTool ()
		{
			if (!string.IsNullOrEmpty (ToolPath))
				return Path.Combine (ToolPath, ToolExe);

			var path = Path.Combine (DevicePlatformBinDir, ToolExe);

			return File.Exists (path) ? path : ToolExe;
		}

		protected override IList<string> GenerateCommandLineCommands ()
		{
			var args = new List<string> ();

			args.Add ("--compress");
			args.Add (InputScene);
			args.Add ("-o");
			args.Add (OutputScene);
			args.Add ($"--sdk-root={SdkRoot}");
			args.Add ($"--target-build-dir={IntermediateOutputPath}");
			if (AppleSdkSettings.XcodeVersion.Major >= 13) {
				// I'm not sure which Xcode version these options are available in, but it's at least Xcode 13+
				args.Add ($"--target-version={SdkVersion}");
				args.Add ($"--target-platform={PlatformUtils.GetTargetPlatform (SdkPlatform, IsWatchApp)}");
			} else {
				args.Add ($"--target-version-{OperatingSystem}={SdkVersion}");
			}

			return args;
		}

		public override bool Execute ()
		{
			if (ShouldExecuteRemotely ())
				return new TaskRunner (SessionId, BuildEngine4).RunAsync (this).Result;

			Directory.CreateDirectory (Path.GetDirectoryName (OutputScene));

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
