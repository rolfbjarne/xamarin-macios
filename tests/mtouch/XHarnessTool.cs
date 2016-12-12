using System;
using System.IO;
using System.Text;

using Xamarin.Tests;

namespace Xamarin
{
	class XHarnessTool : Tool, IDisposable
	{
#pragma warning disable 649
		public Profile Profile;
		public string ProjectPath;
		public string Target;
		public string LogDirectory = Cache.CreateTemporaryDirectory ();
		public string Configuration;
		public string SdkRoot;
#pragma warning restore 649

		string GetTarget (bool? device = null)
		{
			if (Target != null)
				return Target;
			
			switch (Profile) {
			case Profile.iOS:
				return device == true ? "ios-device" : "ios-simulator";
			case Profile.tvOS:
				return device == true ? "tvos-device" : "tvos-simulator";
			case Profile.watchOS:
				return device == true ? "watchos-device" : "watchos-simulator";
			default:
				throw new NotImplementedException ();
			}
		}

		public string XHarnessPath {
			get {
				return Path.Combine (Xamarin.Tests.Configuration.SourceRoot, "tests", "xharness", "xharness.exe");
			}
		}

		protected override string ToolPath {
			get {
				return "mono";
			}
		}

		public int RunDevice (TimeSpan? timeout = null)
		{
			return Run (target: GetTarget (true), timeout: timeout);
		}

		StringBuilder GetArguments (string action, string project_path = null, string target = null, bool? device = null)
		{
			if (target == null)
				target = GetTarget (device);

			var sb = new StringBuilder ();
			sb.Append ("--debug ");
			sb.Append (MTouch.Quote (XHarnessPath));
			sb.Append (" --rootdir ").Append (MTouch.Quote (Path.Combine (Xamarin.Tests.Configuration.SourceRoot, "tests")));
			sb.Append (action).Append (MTouch.Quote (project_path ?? ProjectPath));
			sb.Append (" --target ").Append (target);

			if (SdkRoot == MTouchTool.None) {
				// do nothing
			} else if (!string.IsNullOrEmpty (SdkRoot)) {
				sb.Append (" --sdkroot ").Append (MTouch.Quote (SdkRoot));
			} else {
				sb.Append (" --sdkroot ").Append (MTouch.Quote (Xamarin.Tests.Configuration.xcode_root));
			}

			sb.Append (" --logdirectory ").Append (MTouch.Quote (LogDirectory));
			sb.Append (" --configuration ").Append (Configuration);
			sb.Append (" --verbose");
			return sb;
		}

		public int Run (string project_path = null, string target = null, TimeSpan? timeout = null)
		{
			return Execute (GetArguments (" --run ", project_path: project_path, target: target).ToString (), timeout);
		}

		public int UninstallDevice (string project_path = null, string target = null)
		{
			return Uninstall (project_path, target: target ?? GetTarget (true));
		}

		public int Uninstall (string project_path = null, string target = null)
		{
			return Execute (GetArguments (" --uninstall ", project_path: project_path, target: target, device: true).ToString (), TimeSpan.FromMinutes (1));
		}

		public int InstallDevice (string project_path = null, string target = null, TimeSpan? timeout = null)
		{
			return Install (project_path: project_path, target: target ?? GetTarget (true), timeout: timeout);
		}

		public int Install (string project_path = null, string target = null, TimeSpan? timeout = null)
		{
			if (timeout == null) {
				if (target == "watchos-device") {
					timeout = TimeSpan.FromMinutes (10);
				} else {
					timeout = TimeSpan.FromMinutes (1);
				}
			}
			
			return Execute (GetArguments (" --install ", project_path: project_path, target: target).ToString (), timeout);
		}

		int Execute (string arguments, TimeSpan? timeout)
		{
			var saved_timeout = Timeout;
			if (timeout != null)
				Timeout = timeout.Value;
			try {
				return base.Execute (arguments);
			} finally {
				Timeout = saved_timeout;
			}
		}

		void IDisposable.Dispose ()
		{
		}
	}
}
