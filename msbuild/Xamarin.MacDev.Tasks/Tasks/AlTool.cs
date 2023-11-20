using System;
using System.Collections.Generic;
using System.IO;

using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;
using System.Text;

using Xamarin.Utils;
using Xamarin.Localization.MSBuild;

// Disable until we get around to enable + fix any issues.
#nullable disable

namespace Xamarin.MacDev.Tasks {
	public abstract class ALToolTaskBase : XamarinToolTask {
		string sdkDevPath;

		[Required]
		public string Username { get; set; }

		[Required]
		public string Password { get; set; }

		[Required]
		public string FilePath { get; set; }

		protected override string ToolName {
			get { return "altool"; }
		}

		[Required]
		public string SdkDevPath {
			get { return sdkDevPath; }
			set {
				sdkDevPath = value;
			}
		}

		string DevicePlatformBinDir {
			get { return Path.Combine (SdkDevPath, "usr", "bin"); }
		}

		protected abstract string ALToolAction { get; }

		public override bool Execute ()
		{
			base.Execute ();

			LogErrorsFromOutput (ExecutionResult.StandardOutput.ToString ());

			return !Log.HasLoggedErrors;
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

			args.Add (ALToolAction);
			args.Add ("--file");
			args.Add (FilePath);
			args.Add ("--type");
			args.Add (GetFileTypeValue ());
			args.Add ("--username");
			args.Add (Username);
			args.Add ("--password");
			args.Add (Password);
			args.Add ("--output-format");
			args.Add ("xml");

			return args;
		}

		string GetFileTypeValue ()
		{
			switch (Platform) {
			case ApplePlatform.MacOSX: return "osx";
			case ApplePlatform.TVOS: return "appletvos";
			case ApplePlatform.iOS: return "ios";
			default: throw new NotSupportedException ($"Provided file type '{Platform}' is not supported by altool");
			}
		}

		void LogErrorsFromOutput (string output)
		{
			try {
				if (string.IsNullOrEmpty (output))
					return;

				var plist = PObject.FromString (output) as PDictionary;
				var errors = PObject.Create (PObjectType.Array) as PArray;
				var message = PObject.Create (PObjectType.String) as PString;

				if ((plist?.TryGetValue ("product-errors", out errors) == true)) {
					foreach (var error in errors) {
						var dict = error as PDictionary;
						if (dict?.TryGetValue ("message", out message) == true) {
							Log.LogError (ToolName, null, null, null, 0, 0, 0, 0, "{0}", message.Value);
						}
					}
				}
			} catch (Exception ex) {
				Log.LogWarning (MSBStrings.W0095, ex.Message, output);
			}
		}
	}
}
